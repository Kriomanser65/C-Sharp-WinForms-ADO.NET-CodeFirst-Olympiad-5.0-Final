using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Olympiad_5._0
{
    public partial class AddAthletes : Form
    {
        SqlConnection connection;
        public AddAthletes(string selectedTable, SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void Adding_Load(object sender, EventArgs e)
        {

        }

        private void AddName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSport_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddName.Text) || string.IsNullOrWhiteSpace(AddDate.Text) ||
                string.IsNullOrWhiteSpace(AddCountry.Text) || string.IsNullOrWhiteSpace(AddSport.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            string athleteName = AddName.Text;
            if (!DateTime.TryParse(AddDate.Text, out DateTime birthDate))
            {
                MessageBox.Show("Please enter a valid birth date.");
                return;
            }
            if (!int.TryParse(AddCountry.Text, out int countryId))
            {
                MessageBox.Show("Please enter a valid country ID.");
                return;
            }
            if (!int.TryParse(AddSport.Text, out int sportId))
            {
                MessageBox.Show("Please enter a valid sport ID.");
                return;
            }
            try
            {
                string query = $"INSERT INTO Athletes (FullName, BirthDate, CountryId, SportId) " +
                               $"VALUES ('{athleteName}', '{birthDate}', {countryId}, {sportId})";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Athlete added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                connection.Close();
            }
        }
    }
}
