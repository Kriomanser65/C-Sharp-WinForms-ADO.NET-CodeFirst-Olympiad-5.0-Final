using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympiad_5._0.Adding
{
    public partial class AddCountries : Form
    {
        SqlConnection connection;
        public AddCountries(string selectedTable, SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void AddCountries_Load(object sender, EventArgs e)
        {

        }

        private void AddName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddName.Text))
            {
                MessageBox.Show("Please select a country.");
                return;
            }
            try
            {
                string countryName = AddName.Text;
                string query = $"INSERT INTO Countries (Name) VALUES ('{countryName}')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Country added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
