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
    public partial class AddOlympicGames : Form
    {
        SqlConnection connection;
        public AddOlympicGames(string selectedTable, SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void OlympicGames_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddYear.Text) || string.IsNullOrWhiteSpace(AddCountry1.Text) ||
                string.IsNullOrWhiteSpace(AddCountry.Text) || string.IsNullOrWhiteSpace(AddSport.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!int.TryParse(AddYear.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }
            bool isWinter = IsWinter.Checked;

            try
            {
                string query = $"INSERT INTO OlympicGames (Year, IsWinter, Country, City, SportType) " +
                               $"VALUES ({year}, '{isWinter}', '{AddCountry1.Text}', '{AddCountry.Text}', '{AddSport.Text}')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Olympic game added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                connection.Close();
            }
        }

        private void AddYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCountry1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSport_TextChanged(object sender, EventArgs e)
        {

        }

        private void IsWinter_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
