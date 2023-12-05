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
    public partial class AddCountryMedalStandings : Form
    {
        SqlConnection connection;
        public AddCountryMedalStandings(string selectedTable, SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void CountryMedalStandings_Load(object sender, EventArgs e)
        {

        }

        private void AddGold_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSilver_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBronze_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddGold.Text) || string.IsNullOrWhiteSpace(AddSilver.Text) ||
                string.IsNullOrWhiteSpace(AddBronze.Text) || string.IsNullOrWhiteSpace(AddCountry.Text) ||
                string.IsNullOrWhiteSpace(AddGame.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!int.TryParse(AddGold.Text, out int gold) || !int.TryParse(AddSilver.Text, out int silver) ||
                !int.TryParse(AddBronze.Text, out int bronze) || !int.TryParse(AddCountry.Text, out int countryId) ||
                !int.TryParse(AddGame.Text, out int gameId))
            {
                MessageBox.Show("Please enter valid numerical values.");
                return;
            }
            try
            {
                string query = $"INSERT INTO CountryMedalStandings (Gold, Silver, Bronze, CountryId, OlympicGameId) " +
                               $"VALUES ({gold}, {silver}, {bronze}, {countryId}, {gameId})";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Country medal standings added successfully.");
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
