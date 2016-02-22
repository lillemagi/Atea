using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AteaMessage
{
    public partial class AteaConsole : Form
    {
      //  SqlCommand cmd;
      //  SqlConnection con;
        //SqlDataAdapter da;

        public AteaConsole()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToShortTimeString();
            string date = DateTime.Now.ToShortDateString();

            if (messageBox.Text.Length <= 0)
            {
                MessageBox.Show("Var god fyll i ditt meddelande!");
            }

            else
            {
                try
                {
                    string textMessage = messageBox.Text;

                    SqlConnection con = new System.Data.SqlClient.SqlConnection("Data Source = Beeerd_Surface; Initial Catalog = TestDB; Integrated Security = True");                                               
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO MessageTable (text,time,date) VALUES('"+textMessage+"','"+time+"','"+date+"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bra jobbat, ditt meddelande är skickat " + time);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + time);
                }

            }

        }

        private void AteaWebbLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://localhost:50536/AteaWebbsida.aspx");

        }
    }
}
