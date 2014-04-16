using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CreditCardValidation
{
    public partial class Frm_Login : Form
    {
        string str;        

        public Frm_Login()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();        
        }

        private void Login()
        {
            Frm_Start f = new Frm_Start();
            Login i = new Login();
            i.User = txt_user.Text;
            i.Pass = txt_pass.Text;
            f.i = i;

            //Remote
            //str = @"server=sql3.freesqldatabase.com;database=sql336042;userid=" + txt_user.Text + @";password=" + txt_pass.Text + @";";

            //Local
            str = @"server=89.133.40.143;database=proba1;userid=" + txt_user.Text + @";password=" + txt_pass.Text + @";";

            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open();
                this.Hide();
                f.Show();
            }
            catch (MySqlException err)
            {
                System.IO.File.WriteAllText("log.txt", err.ToString());                
                MessageBox.Show("Sikertelen bejelentkezés!","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void Frm_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }            
        }

        private void Frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                panel1.Visible = true;
            }
        }

        private void Frm_Login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                panel1.Visible = false;
            }
        }
    }
}
