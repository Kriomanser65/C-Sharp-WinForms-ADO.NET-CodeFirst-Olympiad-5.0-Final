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
    public partial class AddMedals : Form
    {
        SqlConnection connection;
        public AddMedals(string selectedTable, SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void AddMedals_Load(object sender, EventArgs e)
        {

        }

        private void AddType_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSport_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAthlete_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddType.Text) || string.IsNullOrWhiteSpace(AddSport.Text) ||
                string.IsNullOrWhiteSpace(AddAthlete.Text) || string.IsNullOrWhiteSpace(AddGame.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!int.TryParse(AddType.Text, out int type) || !int.TryParse(AddSport.Text, out int sportId) ||
                !int.TryParse(AddAthlete.Text, out int athleteId) || !int.TryParse(AddGame.Text, out int gameId))
            {
                MessageBox.Show("Please enter valid numerical values.");
                return;
            }
            try
            {
                string query = $"INSERT INTO Medals (Type, SportId, AthleteId, OlympicGameId) " +
                               $"VALUES ({type}, {sportId}, {athleteId}, {gameId})";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Medal added successfully.");
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
