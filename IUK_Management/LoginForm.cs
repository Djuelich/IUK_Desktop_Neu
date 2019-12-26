using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace IUK_Management
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UsernameBox.Text=="" && PasswordBox.Text=="")
            {
                MessageBox.Show("Felder bitte ausfüllen");
            }
            else
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection("server=www.db4free.net;database=iukmanagement;uid=" + UsernameBox.Text + ";password=" + PasswordBox.Text + ";OldGuids=true");
                    connection.Open();
                    //MessageBox.Show("Erfolg!");
                    Form dispatch = new DispatchForm();
                    this.Hide();
                    connection.Close();
                    dispatch.Show();

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Anmeldung Fehlgeschlagen!");
                }
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Beenden ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = (MessageBox.Show(
                "Wirklich beenden?",
                "Beenden",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.No);

            base.OnClosing(e);
            System.Environment.Exit(1);
        }

    }
}
