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
            dataGridView1.DataSource = GetVehicleList();
        }

        private DataTable GetVehicleList()
        {
            MySqlConnection connection = new MySqlConnection("server=www.db4free.net;database=iukmanagement;uid=elwseg;password=Scarred_92;OldGuids=true");
            connection.Open();
            DataTable dtVehicle = new DataTable();
            string query = "SELECT * FROM Fahrzeug";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            dtVehicle.Load(reader);
            return dtVehicle;
        }
    }
}
