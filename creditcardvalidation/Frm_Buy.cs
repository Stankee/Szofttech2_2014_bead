using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/* 
 * TODO 
 * 1. vásárlások lekérdezése, group by időpont
 *    select vnev, knev, idopont, count(*), sum(ar) from vasarlasoknezet group by idopont, vnev, knev 
 * 2. néha eltűnik a termék neve után az összeg (faszt tünik el csak madár vagy) TODO: abbahagyni a madárkodást :D
 * 3. valami biszembaszom terméknév kitalálása (Properties/AssemblyInfo.cs)
 * 
 * DONE 
 * 1. cb_kategoriak feltöltése
 * 2. szűrés, ha megoldható tényleg szűrjön és ne a kezdődést vizsgálja (ha beírom, hogy Asus, akkor az összes Asus terméket mutassa)
 * 3. random generáljunk pénzt az új embereknek (Frm_Start)
 * 4. névjegy adatainak beállítása
 * 5. a korábbi vásárlások űrlapon jelenjen meg alapból a 'vasarlasoknezet', de lehessen embert is választani
 *  
 * INFO
 * vasarlasok tábla: kartyaSzam (char16), termekID (char4), darab (int)
 * vasarlok tábla: vnev (varchar), knev (varchar), kartyaSzam (char16), egyenleg (double)
 * termekek tábla: termekID (char4), nev (varchar), ar (double), kategoria (char4)
 * 
 * Nézet SQL
 * (elmentve 'vasarlasoknezet' neven (select * from vasarlasoknezet;))
 * select
 * vasarlasID as Vásárlás_azonosító, 
 * Concat(vnev, ' ', knev) as Név, 
 * t.nev as Terméknév, katnev as Kategórianév, 
 * Concat(ar, ' Ft') as Ár, 
 * idopont as Időpont 
 * from kategoriak k, termekek t, vasarlasok v, vasarlok b 
 * where katID = kategoria and t.termekID = v.termekID and b.kartyaSzam = v.kartyaSzam;
 */


namespace CreditCardValidation
{
    public partial class Frm_Buy : Form
    {
        
        string str;
        string user;
        string pass;
        string delegatedName;
        int? cacheindex = null;
        double osszar;
        List<Termek> lst_termekek = new List<Termek>();

        public Frm_Buy(string selectedName)
        {
            InitializeComponent();
            delegatedName = selectedName;
        }

        private void Frm_Buy_Load(object sender, EventArgs e)
        {
            inditas();
        }

        public Login i
        {
            set
            {
                user = value.User;
                pass = value.Pass;
            }
        }       

        public void beolvasSQL()
        {
            cb_vasarlok.Items.Clear();
            lb_termekek.DataSource = null;
            lb_termekek.Items.Clear();
            cb_kategoriak.Items.Clear();

            MySqlConnection con = null;
            MySqlDataReader reader = null;
            //MySqlDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                #region Vásárlók cbo feltöltése
                con = new MySqlConnection(str);
                con.Open();
                string cmdText = "SELECT * FROM vasarlok ORDER BY vnev, knev";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb_vasarlok.Items.Add(
                        new Vasarlo(reader.GetString(0)
                        + " " + reader.GetString(1)
                        + "\t"
                        + " ["
                        + reader.GetString(2).Substring(0, 4)
                        + "-"
                        + reader.GetString(2).Substring(4, 4)
                        + "-"
                        + reader.GetString(2).Substring(8, 4)
                        + "-"
                        + reader.GetString(2).Substring(12, 4)
                        + "]", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3)));

                    if (reader.GetString(0) + " " + reader.GetString(1) == delegatedName) cacheindex = cb_vasarlok.Items.Count; 
                }
                reader.Close();
                #endregion

                #region Termék listbox feltöltés
                cmdText = "SELECT * FROM termekek ORDER BY nev";
                cmd = null; cmd = new MySqlCommand(cmdText, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lb_termekek.Items.Add(
                        new Termek(reader.GetString(1)
                            + " ("
                            + reader.GetDouble(2).ToString() + " Ft)", 
                            reader.GetString(0), reader.GetString(1), reader.GetDouble(2)));
                    lst_termekek.Add(
                        new Termek(reader.GetString(1)
                            + " ("
                            + reader.GetDouble(2).ToString() + " Ft)",
                            reader.GetString(0), reader.GetString(1), reader.GetDouble(2)));

                }
                reader.Close();
                #region OLD
                /*adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                
                if (dt.Rows.Count > 0)
                {
                    lb_termekek.DisplayMember = "nev";
                    lb_termekek.ValueMember = "termekID";
                    lb_termekek.DataSource = dt;                  
                }
                termekTable = dt;*/
                #endregion
                #endregion

                #region Kategória cbo feltöltés
                cmdText = "SELECT * FROM kategoriak ORDER BY katNev";
                cmd = null; cmd = new MySqlCommand(cmdText, con);
                reader = cmd.ExecuteReader();
                cb_kategoriak.Items.Add(new Kategoria("Minden","0000","Minden"));
                while (reader.Read())
                {
                    cb_kategoriak.Items.Add(
                        new Kategoria(reader.GetString(1), reader.GetString(0), reader.GetString(1)));
                }
                reader.Close();

                #endregion
            }
            catch (MySqlException err)
            {
                System.IO.File.WriteAllText("log.txt", err.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
            con.Close();
            

            if (cacheindex != null) cb_vasarlok.SelectedIndex = (int)cacheindex-1;
          
        }

        private void inditas()
        {
            //szerver beállítás           

            //Remote
            //str = @"server=sql3.freesqldatabase.com;database=sql336042;userid=" + user + @";password=" + pass + @";";

            //Local
            str = @"server=89.133.40.143;database=proba1;userid=" + user + @";password=" + pass + @";";

            beolvasSQL();
        }

        public void SetData()
        {
            Vasarlo selected = ((Vasarlo)cb_vasarlok.SelectedItem);

            /*MySqlConnection con = null;
            MySqlDataReader reader = null;

            con = new MySqlConnection(str);
            con.Open();
            string cmdText = "SELECT * FROM vasarlok WHERE vnev='" + selected.VezetekNev + "' AND knev='" + selected.KeresztNev + "' ORDER BY vnev, knev";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txt_egyenleg.Text = reader.GetDouble(3).ToString();
            }*/

            txt_egyenleg.Text = selected.Egyenleg.ToString() + " Ft";
        }

        public void SQLEgyenlegUpdate()
        {
            string kartyaSzam = ((Vasarlo)cb_vasarlok.SelectedItem).KartyaSzam;
            double ujEgyenleg = ((Vasarlo)cb_vasarlok.SelectedItem).Egyenleg - osszar;

            string command = "UPDATE vasarlok SET egyenleg=" + ujEgyenleg.ToString() + " WHERE kartyaSzam = '" + kartyaSzam + "'";

            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException err)
            {
                System.IO.File.WriteAllText("log.txt", err.ToString());
                MessageBox.Show("Az egyenlegfrissítés nem sikerült!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void SQLVasarlasokUpdate()       
        {
            string kartyaSzam = ((Vasarlo)cb_vasarlok.SelectedItem).KartyaSzam;            

            //DateTime formátum konvertálás, csak így fogadja el a mySQL

            foreach (Termek item in lb_kosar.Items)
            {
                string termekId = item.TermekID;
                DateTime datum = DateTime.Now;
                string mysqlDate = datum.ToString("yyyy-MM-dd HH:mm:ss");

                string command = "INSERT INTO vasarlasok (kartyaSzam, termekID, idopont) VALUES('" + kartyaSzam + "','" + termekId + "','" + mysqlDate + "')";

                MySqlConnection con = null;
                try
                {
                    con = new MySqlConnection(str);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(command, con);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException err)
                {
                    System.IO.File.WriteAllText("log.txt", err.ToString());
                    MessageBox.Show("Az egyenlegfrissítés nem sikerült!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string kartyaSzam = ((Vasarlo)cb_vasarlok.SelectedItem).KartyaSzam;
            double ujEgyenleg = ((Vasarlo)cb_vasarlok.SelectedItem).Egyenleg +10000;

            string command = "UPDATE vasarlok SET egyenleg=" + ujEgyenleg.ToString() + " WHERE kartyaSzam = '" + kartyaSzam + "'";

            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException err)
            {
                System.IO.File.WriteAllText("log.txt", err.ToString());
                MessageBox.Show("Az egyenlegfrissítés nem sikerült!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            beolvasSQL();
        }

        private void btn_kiakosarbol_Click(object sender, EventArgs e)
        {
            kiakosarbol();
        }

        private void kiakosarbol()
        {
            try
            {
                osszar -= ((Termek)lb_kosar.SelectedItem).Ar;
                lb_kosar.Items.Remove(lb_kosar.SelectedItem);
                txt_teljesar.Text = osszar.ToString() + " Ft";
                if (lb_kosar.Items.Count == 0)
                {
                    cb_vasarlok.Enabled = true;
                }
            }
            catch { MessageBox.Show("Nem választottál ki semmit a kosaradból!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btn_kosarba_Click(object sender, EventArgs e)
        {
            kosarba();

        }

        private void kosarba()
        {
            try
            {
                lb_kosar.Items.Add(lb_termekek.SelectedItem);
                osszar += ((Termek)lb_termekek.SelectedItem).Ar;
                txt_teljesar.Text = osszar.ToString() + " Ft";
                cb_vasarlok.Enabled = false;
            }
            catch { MessageBox.Show("Nincs kiválasztott termék!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cb_vasarlok.SelectedIndex != -1 && lb_kosar.Items.Count != 0)
            {
                if (((Vasarlo)cb_vasarlok.SelectedItem).Egyenleg < osszar)
                {
                    MessageBox.Show("Nincs elegendő összeg a kártyán!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLEgyenlegUpdate();
                    SQLVasarlasokUpdate();
                    beolvasSQL();

                    txt_teljesar.Text = "0 Ft";
                    osszar = 0;
                    lb_kosar.Items.Clear();
                }
            }
            else
            {
                if (cb_vasarlok.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs kiválasztott vásárló!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (lb_kosar.Items.Count == 0)
                {
                    MessageBox.Show("Nincs semmi a kosárban!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void cb_vasarlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_vasarlok.SelectedIndex != -1)
            {
                btn_add.Enabled = true;
            }
            string nev = ((Vasarlo)cb_vasarlok.SelectedItem).VezetekNev + " " + ((Vasarlo)cb_vasarlok.SelectedItem).KeresztNev;
            delegatedName = nev;
            SetData();
        }

        private void txt_szuro_TextChanged(object sender, EventArgs e)
        {
            if (txt_szuro.Text != "Keresés")
            {
                List<Termek> lst_nemszurt = new List<Termek>();
                foreach (Termek item in lst_termekek)
                {
                    lst_nemszurt.Add(item);
                }

                IEnumerable<Termek> result = lst_nemszurt.Where(s => s.Nev.ToLower().Contains(txt_szuro.Text.ToLower()));
                List<Termek> lst_szurt = result.ToList();

                lb_termekek.Items.Clear();
                foreach (Termek item in lst_szurt)
                {
                    lb_termekek.Items.Add(item);
                }
            }
            else { }

            #region OLD
            /*lb_termekek.DataSource = termekTable;
            lb_termekek.DisplayMember = "nev";
            lb_termekek.ValueMember = "termekID";

            try
            {
                DataTable dt = termekTable;

                var eredmeny = from x in dt.AsEnumerable()
                               where x.Field<string>("nev").StartsWith(txt_szuro.Text)
                               select x;

                DataTable asd = eredmeny.CopyToDataTable();

                lb_termekek.DataSource = asd;
            }
            catch { lb_termekek.DataSource = null; }*/
            #endregion

        }

        private void lb_termekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ar.Text = ((Termek)lb_termekek.SelectedItem).Ar.ToString() + " Ft";
        }

        private void lb_termekek_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            kosarba();
        }

        private void lb_kosar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            kiakosarbol();
        }

        //txt_szuro szín mentése
        Color szuroSzin = new Color();

        private void txt_szuro_Enter(object sender, EventArgs e)
        {
            txt_szuro.Text = "";
            szuroSzin = txt_szuro.ForeColor;
            txt_szuro.ForeColor = Color.Black;
        }

        private void txt_szuro_Leave(object sender, EventArgs e)
        {
            if (txt_szuro.Text == "")
            {
                txt_szuro.Text = "Keresés";
                txt_szuro.ForeColor = szuroSzin;
            }
            if (txt_szuro.Text != "Keresés")
            {
                txt_szuro.ForeColor = Color.Black;
            }            
        }

        private void cb_kategoriak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_kategoriak.Text != "Kategóriák")
            {
                lb_termekek.Items.Clear();
                lst_termekek.Clear();
                cb_kategoriak.ForeColor = Color.Black;
                try
                {
                    string katnev = ((Kategoria)cb_kategoriak.SelectedItem).KatNev;
                    string katnevsqlstring = " AND k.katNev = '" +  katnev + "' ";
                    if (katnev == "Minden") katnevsqlstring = " ";

                    MySqlConnection con = new MySqlConnection(str);
                    con.Open();
                    string cmdText = "SELECT termekID, nev, ar, kategoria FROM termekek t, kategoriak k WHERE t.kategoria = k.katID" + katnevsqlstring + "ORDER BY t.nev";
                    MySqlCommand cmd = new MySqlCommand(cmdText, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lb_termekek.Items.Add(
                            new Termek(reader.GetString(1)
                                + " ("
                                + reader.GetDouble(2).ToString() + " Ft)",
                                reader.GetString(0), reader.GetString(1), reader.GetDouble(2)));
                        lst_termekek.Add(
                            new Termek(reader.GetString(1)
                                + " ("
                                + reader.GetDouble(2).ToString() + " Ft)",
                                reader.GetString(0), reader.GetString(1), reader.GetDouble(2)));
                    }
                }
                catch (MySqlException err)
                {
                    System.IO.File.WriteAllText("log.txt", err.ToString());
                }

                
            }
            else
            {
                cb_kategoriak.ForeColor = szuroSzin;
                
            }

            
        }

        private void cb_kategoriak_Enter(object sender, EventArgs e)
        {
            cb_kategoriak.ForeColor = Color.Black;
        }
    }
}