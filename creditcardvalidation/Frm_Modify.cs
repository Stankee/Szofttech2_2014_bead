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
    public partial class Frm_Modify : Form
    {
        Regex ex;
        string str;
        string kartyaIDOrig;
        string user;
        string pass;

        public Login i
        {
            set
            {
                user = value.User;
                pass = value.Pass;
            }
        }

        public Frm_Modify()            
        {
            InitializeComponent();               
        }        

        private void txt_kartya1_TextChanged(object sender, EventArgs e)
        {
            string r = "^[0-9]{4}$";
            ex = new Regex(r);

            if (ex.IsMatch(txt_kartya1.Text))
            {
                txt_kartya1.BackColor = Color.LightGreen;
                Validalas();
                txt_kartya2.Select();
            }
            else
            {
                txt_kartya1.BackColor = Color.LightSalmon;
                btn_change.Enabled = false;
            }
        }        

        private void txt_kartya2_TextChanged(object sender, EventArgs e)
        {
            string r = "^[0-9]{4}$";
            ex = new Regex(r);

            if (ex.IsMatch(txt_kartya2.Text))
            {
                txt_kartya2.BackColor = Color.LightGreen;
                Validalas();
                txt_kartya3.Select();
            }
            else
            {
                txt_kartya2.BackColor = Color.LightSalmon;
                btn_change.Enabled = false;
            }
        }

        private void txt_kartya3_TextChanged(object sender, EventArgs e)
        {
            string r = "^[0-9]{4}$";
            ex = new Regex(r);

            if (ex.IsMatch(txt_kartya3.Text))
            {
                txt_kartya3.BackColor = Color.LightGreen;
                Validalas();
                txt_kartya4.Select();
            }
            else
            {
                txt_kartya3.BackColor = Color.LightSalmon;
                btn_change.Enabled = false;
            }
        }

        private void txt_kartya4_TextChanged(object sender, EventArgs e)
        {
            string r = "^[0-9]{4}$";
            ex = new Regex(r);

            if (ex.IsMatch(txt_kartya4.Text))
            {
                txt_kartya4.BackColor = Color.LightGreen;
                if (txt_vnevM.Text.Length > 0 & txt_knevM.Text.Length > 0)
                {
                    Validalas();
                    btn_change.Enabled = true;
                }                
            }
            else
            {
                txt_kartya4.BackColor = Color.LightSalmon;                
                btn_change.Enabled = false;
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
        
        private void txt_vnev_TextChanged(object sender, EventArgs e)
        {
            string r = "^[^0-9^a-z]{1}[^0-9^A-Z]+$";
            ex = new Regex(r);
            if (ex.IsMatch(txt_vnevM.Text))
            {
                txt_vnevM.BackColor = Color.LightGreen;
                Validalas();
            }
            else
            {
                txt_vnevM.BackColor = Color.LightSalmon;
                btn_change.Enabled = false;
            }
        }        

        private void txt_knev_TextChanged(object sender, EventArgs e)
        {
            string r = @"^[^0-9^a-z]{1}[^0-9^A-Z]+[ ][^0-9^a-z]{1}[^0-9^A-Z]+$";
            string s = "^[^0-9^a-z]{1}[^0-9^A-Z]+$";
            ex = new Regex(r);
            Regex x = new Regex(s);

            if (ex.IsMatch(txt_knevM.Text) || x.IsMatch(txt_knevM.Text))
            {
                txt_knevM.BackColor = Color.LightGreen;
                Validalas();
            }
            else
            {
                txt_knevM.BackColor = Color.LightSalmon;
                btn_change.Enabled = false;
            }
        }

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
                btn_change.Enabled = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("red-cross.png");
                txt_kartya1.BackColor = Color.LightSalmon;
                txt_kartya2.BackColor = Color.LightSalmon;
                txt_kartya3.BackColor = Color.LightSalmon;
                txt_kartya4.BackColor = Color.LightSalmon;                
                btn_change.Enabled = false;
            }
        }

        public Modositas m
        {
            set
            {
                txt_vnevM.Text = value.vNev;
                txt_knevM.Text = value.kNev;
                txt_kartya1.Text = value.kartyaSzam.Substring(0,4);
                txt_kartya2.Text = value.kartyaSzam.Substring(4, 4);
                txt_kartya3.Text = value.kartyaSzam.Substring(8, 4);
                txt_kartya4.Text = value.kartyaSzam.Substring(12, 4);
                kartyaIDOrig = value.kartyaSzam;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            start();
            sqlUpdate();            
            this.Close();
        }

        private void sqlUpdate()
        {
            string kartyaSzam = txt_kartya1.Text + txt_kartya2.Text + txt_kartya3.Text + txt_kartya4.Text;
            string vnev = txt_vnevM.Text;
            string knev = txt_knevM.Text;           

            string command = "UPDATE proba1.vasarlok SET vnev =" + "'"
                + vnev + "'" + ", knev =" + "'"
                + knev + "'" + ", kartyaSzam =" + "'"
                + kartyaSzam + "'" + " WHERE kartyaSzam =" + "'"
                + kartyaIDOrig + "'";

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
                MessageBox.Show("A módosítás nem sikerült!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();  
                }
            }
        }

        private void Frm_Modify_Load(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {
            //szerver beállítás           

            //Remote
            //str = @"server=sql3.freesqldatabase.com;database=sql336042;userid=" + user + @";password=" + pass + @";";

            //Local
            str = @"server=89.133.40.143;database=proba1;userid=" + user + @";password=" + pass + @";";
        }

        private void Frm_Modify_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                start();
                sqlUpdate();
                this.Close();
            }
        }
    }
}