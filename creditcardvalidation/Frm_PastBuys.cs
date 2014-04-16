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
 * 1. befejezni :D
 */

namespace CreditCardValidation
{
    public partial class Frm_PastBuys : Form
    {
        string str;
        string user;
        string pass;
        string delegatedName;
        
        public Frm_PastBuys(string selectedName)
        {
            InitializeComponent();
            delegatedName = selectedName;            
        }

        private void Frm_PastBuys_Load(object sender, EventArgs e)
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
            
            MySqlConnection con = null;
            MySqlDataReader reader = null;            
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
    }
}
