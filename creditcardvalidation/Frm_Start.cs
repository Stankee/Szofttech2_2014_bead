using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace CreditCardValidation
{    
    //mysql-connector-net-6.8.3

    /*
     * 
     * TODO
     * 
     * duplaklikk? (modify/új vásárlás)
     * 
     */

    public partial class Frm_Start : Form
    {
        Regex ex;     
        string kartyaID;
        string str;
        string user;
        string pass;
        int modValasztott;

        public Login i
        {
            set
            {
                user = value.User;
                pass = value.Pass;
            }
        }

        public Frm_Start()
        {
            InitializeComponent();
            inditas();
        }

        private void inditas()
        {           
            //szerver beállítás           

            //Remote
            //str = @"server=sql3.freesqldatabase.com;database=sql336042;userid=" + user + @";password=" + pass + @";";

            //Local
            str = @"server=89.133.40.143;database=proba1;userid=" + user + @";password=" + pass + @";";
           
            beolvasSQL();
            sqlConnect();
            btn_change.Enabled = false;
        }

        private void txt_vnev_TextChanged(object sender, EventArgs e)
        {
            if (txt_vnev.Text.Length >= 2)
            {
                string r = "^[^0-9^a-z]{1}[^0-9^A-Z]+$";
                ex = new Regex(r);
                if (ex.IsMatch(txt_vnev.Text))
                {
                    txt_vnev.BackColor = Color.LightGreen;
                }
                else
                {
                    txt_vnev.BackColor = Color.LightSalmon;
                    btn_addSQL.Enabled = false;
                }
            }            
        }

        private void txt_knev_TextChanged(object sender, EventArgs e)
        {
            if (txt_knev.Text.Length >= 2)
            {
                string r = @"^[^0-9^a-z]{1}[^0-9^A-Z]+[ ][^0-9^a-z]{1}[^0-9^A-Z]+$";
                string s = "^[^0-9^a-z]{1}[^0-9^A-Z]+$";
                ex = new Regex(r);
                Regex x = new Regex(s);

                if (ex.IsMatch(txt_knev.Text) || x.IsMatch(txt_knev.Text))
                {
                    txt_knev.BackColor = Color.LightGreen;
                }
                else
                {
                    txt_knev.BackColor = Color.LightSalmon;
                    btn_addSQL.Enabled = false;
                }
            }        
        }

        private void btn_save_Click(object sender, EventArgs e)
        {             
            Torol();

            label4.Text = "Sikeresen hozzáadva!";
            panel1.Visible = true;
            timer_save.Enabled = true;
        }        

        private void Torol()
        {
            txt_kartya1.Clear();
            txt_kartya2.Clear();
            txt_kartya3.Clear();
            txt_kartya4.Clear();
            txt_knev.Clear();
            txt_vnev.Clear();
            txt_kartya1.BackColor = Color.White;
            txt_kartya2.BackColor = Color.White;
            txt_kartya3.BackColor = Color.White;
            txt_kartya4.BackColor = Color.White;
            txt_vnev.BackColor = Color.White;
            txt_knev.BackColor = Color.White;
            pictureBox1.Visible = false;
        }       

        private void txt_kartya1_TextChanged(object sender, EventArgs e)
        {
            string r = "^[0-9]{4}$";
            ex = new Regex(r);

            if (ex.IsMatch(txt_kartya1.Text))
            {
                txt_kartya1.BackColor = Color.LightGreen;                
                txt_kartya2.Select();    
            }
            else
            {
                txt_kartya1.BackColor = Color.LightSalmon;                
                btn_addSQL.Enabled = false;
            }          
        }

        private void txt_kartya2_TextChanged(object sender, EventArgs e)
        {
            string r = "^[0-9]{4}$";
            ex = new Regex(r);

            if (ex.IsMatch(txt_kartya2.Text))
            {
                txt_kartya2.BackColor = Color.LightGreen;                
                txt_kartya3.Select();
            }
            else
            {
                txt_kartya2.BackColor = Color.LightSalmon;
                btn_addSQL.Enabled = false;
            }
        }

        private void txt_kartya3_TextChanged(object sender, EventArgs e)
        {
            string r = "^[0-9]{4}$";
            ex = new Regex(r);

            if (ex.IsMatch(txt_kartya3.Text))
            {
                txt_kartya3.BackColor = Color.LightGreen;                
                txt_kartya4.Select();
            }
            else
            {
                txt_kartya3.BackColor = Color.LightSalmon;
                btn_addSQL.Enabled = false;
            }
        }

        private void txt_kartya4_TextChanged(object sender, EventArgs e)
        {
            string r = "^[0-9]{4}$";
            ex = new Regex(r);

            if (ex.IsMatch(txt_kartya4.Text))
            {
                txt_kartya4.BackColor = Color.LightGreen;
                if (txt_vnev.Text.Length > 0 & txt_knev.Text.Length > 0)
                {
                    btn_addSQL.Enabled = true;
                }                                
                Validalas();
            }
            else
            {
                txt_kartya4.BackColor = Color.LightSalmon;                
                btn_addSQL.Enabled = false;
            }
        }

        /// Extremely fast Luhn algorithm implementation, based on 
        /// pseudo code from Cliff L. Biffle (http://microcoder.livejournal.com/17175.html)
        /// 
        /// Copyleft Thomas @ Orb of Knowledge:
        /// http://orb-of-knowledge.blogspot.com/2009/08/extremely-fast-luhn-function-for-c.html 
        /// 

        public static bool IsValidNumber(string number)
        {
            int[] DELTAS = new int[] { 0, 1, 2, 3, 4, -4, -3, -2, -1, 0 };
            int checksum = 0;
            char[] chars = number.ToCharArray();
            for (int i = chars.Length - 1; i > -1; i--)
            {
                int j = ((int)chars[i]) - 48;
                checksum += j;
                if (((i - chars.Length) % 2) == 0)
                    checksum += DELTAS[j];
            }

            return ((checksum % 10) == 0);
        }

        /// 
        /// END
        /// 

        private void Validalas()
        {
            if (IsValidNumber(txt_kartya1.Text + txt_kartya2.Text + txt_kartya3.Text + txt_kartya4.Text))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("green-tick.png");
                txt_kartya1.BackColor = Color.LightGreen;
                txt_kartya2.BackColor = Color.LightGreen;
                txt_kartya3.BackColor = Color.LightGreen;
                txt_kartya4.BackColor = Color.LightGreen;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("red-cross.png");
                txt_kartya1.BackColor = Color.LightSalmon;
                txt_kartya2.BackColor = Color.LightSalmon;
                txt_kartya3.BackColor = Color.LightSalmon;
                txt_kartya4.BackColor = Color.LightSalmon;
                btn_addSQL.Enabled = false;
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beolvasSQL();
            label4.Text = "Sikeresen elmentve!";
            panel1.Visible = true;
            timer_save.Enabled = true;
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void timer_save_Tick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox1.Visible = false;
            timer_save.Enabled = false;            
        }
        
        private void sqlConnect()
        {                       
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open();
                tlslabel_connect.Text = "Kapcsolódva";
                tlslabel_connect.ForeColor = Color.FromArgb(0, 125, 21);            
            }
            catch (MySqlException err)
            {
                System.IO.File.WriteAllText("log.txt", err.ToString());                
                tlslabel_connect.Text = "Kapcsolódás sikertelen";
                tlslabel_connect.ForeColor = Color.FromArgb(193,0,0);     
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }     

        public void beolvasSQL()
        {
            lb_sql.Items.Clear();

            //a reader.GetVAR(y) olvassa ki a megfelelő oszlopot!

            MySqlConnection con = null;
            MySqlDataReader reader = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open();
                string cmdText = "SELECT * FROM vasarlok ORDER BY vnev, knev";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nev = reader.GetString(0) + " " + reader.GetString(1);
                    if (nev.Length >= 17)
                    {
                        nev = nev.Substring(0, 17);
                    }
                    lb_sql.Items.Add(
                        new Vasarlo(nev
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
                }
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
        }

        private void btn_addSQL_Click(object sender, EventArgs e)
        {
            string kartyaSzam = txt_kartya1.Text + txt_kartya2.Text + txt_kartya3.Text + txt_kartya4.Text;
            
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open();

                string cmdAdd = "INSERT INTO vasarlok (vnev, knev, kartyaSzam) VALUES (@vnev, @knev, @kartyaSzam);";
                MySqlCommand cmd = new MySqlCommand(cmdAdd, con);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@kartyaSzam", kartyaSzam);
                cmd.Parameters.AddWithValue("@vnev", txt_vnev.Text);
                cmd.Parameters.AddWithValue("@knev", txt_knev.Text);
                cmd.ExecuteNonQuery();

                Torol();
                
                label4.Text = "Sikeresen hozzáadva!";
                panel1.Visible = true;
                timer_save.Enabled = true;

                beolvasSQL();
            }
            catch (MySqlException err)
            {                
                System.IO.File.WriteAllText("log.txt", err.ToString());
                label4.ForeColor = Color.PaleVioletRed;
                panel1.BackColor = Color.DarkRed;
                label4.Text = "Nem sikerült a művelet!";
                panel1.Visible = true;
                timer_save.Enabled = true;
            }
            finally
            {
                if (con != null)
                {
                    con.Close(); 
                }
            }
        }

        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_sql.SelectedItem != null)
            {
                Clipboard.SetText(((Vasarlo)lb_sql.SelectedItem).KartyaSzam);   
            }            
        }

        private void btn_sqlDelete_Click(object sender, EventArgs e)
        {    
            if (kartyaID != null)
            {                
                MySqlConnection con = null;
                try
                {
                    con = new MySqlConnection(str);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM vasarlok WHERE kartyaSzam =" + kartyaID, con);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException err)
                {
                    System.IO.File.WriteAllText("log.txt", err.ToString());
                    label4.ForeColor = Color.PaleVioletRed;
                    panel1.BackColor = Color.DarkRed;
                    label4.Text = "Nem sikerült a művelet!";
                    panel1.Visible = true;
                    timer_save.Enabled = true;
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
        }

        private void lb_sql_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_sql.SelectedIndex != -1)
            {
                kartyaID = ((Vasarlo)lb_sql.SelectedItem).KartyaSzam;
                btn_change.Enabled = true;
            }            
        }

        private void lb_sql_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*MessageBox.Show
                (
                    ((Elem)lb_sql.SelectedItem).VezetekNev + "\n" +
                    ((Elem)lb_sql.SelectedItem).KeresztNev + "\n" +
                    ((Elem)lb_sql.SelectedItem).KartyaSzam
                );*/

            Modositas();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Modositas();
        }

        private void Modositas()
        {
            if (lb_sql.SelectedIndex != -1)
            {
                modValasztott = lb_sql.SelectedIndex;
                Modositas m = new Modositas();
                m.vNev = ((Vasarlo)lb_sql.SelectedItem).VezetekNev;
                m.kNev = ((Vasarlo)lb_sql.SelectedItem).KeresztNev;
                m.kartyaSzam = ((Vasarlo)lb_sql.SelectedItem).KartyaSzam;

                Login k = new Login();
                k.User = user;
                k.Pass = pass;

                Frm_Modify f = new Frm_Modify();
                f.Show();
                f.m = m;
                f.i = k;
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            }            
        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            beolvasSQL();
            lb_sql.SelectedIndex = modValasztott;
        }

        private void Frm_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Start_Load(object sender, EventArgs e)
        {
            inditas();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ab_Nevjegy n = new Ab_Nevjegy();
            n.ShowDialog();
        }

        private void btn_newBuy_Click(object sender, EventArgs e)
        {
            string selectedName = null;
            if (lb_sql.SelectedIndex != -1) selectedName = ((Vasarlo)lb_sql.SelectedItem).VezetekNev + " " + ((Vasarlo)lb_sql.SelectedItem).KeresztNev;

            /*VasarloNew v = new VasarloNew();
            v.vNev = ((Vasarlo)lb_sql.SelectedItem).VezetekNev;
            v.kNev = ((Vasarlo)lb_sql.SelectedItem).KeresztNev;
            v.kartyaSzam = ((Vasarlo)lb_sql.SelectedItem).KartyaSzam;
            v.egyenleg = ((Vasarlo)lb_sql.SelectedItem).Egyenleg;*/

            Login i = new Login();
            i.User = user;
            i.Pass = pass;

            Frm_Buy f = new Frm_Buy(selectedName);
            f.i = i;
            f.Show();          
        }
    }
}