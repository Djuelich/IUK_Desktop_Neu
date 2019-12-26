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
using System.Data.SqlClient;

namespace IUK_Management
{
    public partial class DispatchForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=www.db4free.net;database=iukmanagement;uid=elwseg;password=Scarred_92;OldGuids=true");
        public DispatchForm()
        {
         InitializeComponent();
        }
        
        private void BackButton_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void DispatchForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            dataGridRtw.DataSource = GetRtwList();
            dataGridKtw.DataSource = GetKtwList();
            dataGridNef.DataSource = GetNefList();
            UpdateLabelText();
        }
        private DataTable GetRtwList()
        {
            DataTable dtVehicleR = new DataTable();
            string queryR = "SELECT Funkrufnummer as RTW FROM Fahrzeug WHERE Fahrzeugtyp = 'RTW'";
            MySqlCommand cmdR = new MySqlCommand(queryR, connection);
            MySqlDataReader readerR = cmdR.ExecuteReader();
            dtVehicleR.Load(readerR);
            readerR.Close();
            return dtVehicleR;
        }

        private DataTable GetKtwList()
        {
            DataTable dtVehicleK = new DataTable();
            string queryK = "SELECT Funkrufnummer as KTW FROM Fahrzeug WHERE Fahrzeugtyp = 'KTW'";
            MySqlCommand cmdK = new MySqlCommand(queryK, connection);
            MySqlDataReader readerK = cmdK.ExecuteReader();
            dtVehicleK.Load(readerK);
            readerK.Close();
            return dtVehicleK;
        }

        private DataTable GetNefList()
        {
            DataTable dtVehicleN = new DataTable();
            string queryN = "SELECT Funkrufnummer as NEF FROM Fahrzeug WHERE Fahrzeugtyp = 'NEF'";
            MySqlCommand cmdN = new MySqlCommand(queryN, connection);
            MySqlDataReader readerN = cmdN.ExecuteReader();
            dtVehicleN.Load(readerN);
            readerN.Close();
            return dtVehicleN;
        }


        private void UpdateLabelText()
        {
            int rCounter;
            int kCounter;
            int nCounter;

            // Iterate through all the rows and sum up the appropriate columns.
            for (rCounter = 0; rCounter < (dataGridRtw.Rows.Count); rCounter++);
            for (kCounter = 0; kCounter < (dataGridKtw.Rows.Count); kCounter++);
            for (nCounter = 0; nCounter < (dataGridNef.Rows.Count); nCounter++);

            rCount.Text = "RTW: " + (rCounter-1);
            kCount.Text = "KTW: " + (kCounter-1);
            nCount.Text = "NEF: " + (nCounter-1);

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



        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
