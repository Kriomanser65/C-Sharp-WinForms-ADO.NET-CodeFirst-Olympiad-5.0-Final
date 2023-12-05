using Olympiad_5._0.Classes;
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
    public partial class InfoForm : Form
    {
        SqlConnection connection;
        public InfoForm(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //медальні заліки країнами з конкретної олімпіади, за історію олімпіад;
        {
            DisplayMedalsInfo();
        }
        private void DisplayMedalsInfo()
        {
            listBox1.Items.Clear();
            string query = "SELECT CountryId, SUM(Gold) AS TotalGoldMedals " +
                           "FROM CountryMedalStandings " +
                           "GROUP BY CountryId " +
                           "ORDER BY TotalGoldMedals DESC";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string countryName = reader["CountryId"].ToString();
                    int totalGoldMedals = Convert.ToInt32(reader["TotalGoldMedals"]);
                    listBox1.Items.Add($"Country: {countryName}, Total Gold Medals: {totalGoldMedals}");
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DisplayMedalsInfo();
        }

        private void MedalistsTask_Click(object sender, EventArgs e) //медалістів з різних видів спорту з конкретної олімпіади, за всю історію олімпіад;
        {
            DisplayMedalistsInfo();
        }
        private void DisplayMedalistsInfo()
        {
            listBox1.Items.Clear();
            string query = "SELECT Sports.Name AS SportName, COUNT(Medals.Id) AS TotalMedals " +
                           "FROM Medals " +
                           "JOIN Sports ON Medals.SportId = Sports.Id " +
                           "GROUP BY Sports.Name " +
                           "ORDER BY TotalMedals DESC";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string sportName = reader["SportName"].ToString();
                    int totalMedals = Convert.ToInt32(reader["TotalMedals"]);
                    listBox1.Items.Add($"Sport: {sportName}, Total Medals: {totalMedals}");
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void CountryTask_Click(object sender, EventArgs e) // країну, яка зібрала найбільше золотих медалей на конкретній олімпіаді, за всю історію олімпіад;
        {
            DisplayTopCountryWithGoldMedals();
        }
        private void DisplayTopCountryWithGoldMedals()
        {
            listBox1.Items.Clear();
            string query = "SELECT TOP 1 Countries.Name AS CountryName, SUM(CountryMedalStandings.Gold) AS TotalGoldMedals " +
                           "FROM Countries " +
                           "JOIN CountryMedalStandings ON Countries.Id = CountryMedalStandings.CountryId " +
                           "GROUP BY Countries.Name " +
                           "ORDER BY TotalGoldMedals DESC";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string countryName = reader["CountryName"].ToString();
                    int totalGoldMedals = Convert.ToInt32(reader["TotalGoldMedals"]);
                    listBox1.Items.Add($"Country: {countryName}, Total Gold Medals: {totalGoldMedals}");
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void SportsmanTask_Click(object sender, EventArgs e) //спортсмена, який виграв найбільше золотих медалей у конкретному виді спорту;
        {
            DisplayTopAthleteInSport();
        }
        private void DisplayTopAthleteInSport()
        {
            listBox1.Items.Clear();
            string query = "SELECT TOP 1 Athletes.FullName AS AthleteName, COUNT(Medals.Id) AS TotalGoldMedals " +
                           "FROM Athletes " +
                           "JOIN Medals ON Athletes.Id = Medals.AthleteId " +
                           "WHERE Medals.Type = 1 " +
                           "GROUP BY Athletes.FullName " +
                           "ORDER BY TotalGoldMedals DESC";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string athleteName = reader["AthleteName"].ToString();
                    int totalGoldMedals = Convert.ToInt32(reader["TotalGoldMedals"]);
                    listBox1.Items.Add($"Athlete: {athleteName}, Total Gold Medals: {totalGoldMedals}");
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void Country1Task_Click(object sender, EventArgs e) //назва країни, яка найчастіше була господаркою олімпіади;
        {
            DisplayMostFrequentHostCountry();
        }
        private void DisplayMostFrequentHostCountry()
        {
            listBox1.Items.Clear();
            string query = "SELECT TOP 1 Countries.Name AS HostCountry, COUNT(OlympicGames.Id) AS TotalOlympicsHosted " +
                  "FROM Countries " +
                  "JOIN OlympicGames ON Countries.Id = OlympicGames.CountryId " +
                  "GROUP BY Countries.Name " +
                  "ORDER BY TotalOlympicsHosted DESC";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string hostCountry = reader["HostCountry"].ToString();
                    int totalOlympicsHosted = Convert.ToInt32(reader["TotalOlympicsHosted"]);
                    listBox1.Items.Add($"Host Country: {hostCountry}, Total Olympics Hosted: {totalOlympicsHosted}");
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void TeamTask_Click(object sender, EventArgs e) //склад олімпіадної команди спортсменів конкретної країни;
        {
            DisplayOlympicTeamForCountry();
        }
        private void DisplayOlympicTeamForCountry()
        {
            listBox1.Items.Clear();
            string query = "SELECT Athletes.FullName AS AthleteName, Sports.Name AS SportName " +
                           "FROM Athletes " +
                           "JOIN Sports ON Athletes.SportId = Sports.Id " +
                           "WHERE Athletes.CountryId = @CountryId";
            int countryId = 1;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryId", countryId);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string athleteName = reader["AthleteName"].ToString();
                    string sportName = reader["SportName"].ToString();
                    listBox1.Items.Add($"Athlete: {athleteName}, Sport: {sportName}");
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void TeamOlTask_Click(object sender, EventArgs e) //статистику виступу конкретної країни на конкретній олімпіаді за всю історію олімпіад.
        {
            DisplayCountryPerformanceInOlympicGame();
        }
        private void DisplayCountryPerformanceInOlympicGame()
        {
            listBox1.Items.Clear();
            string query = "SELECT CountryMedalStandings.Gold, CountryMedalStandings.Silver, CountryMedalStandings.Bronze " +
                           "FROM CountryMedalStandings " +
                           "WHERE CountryMedalStandings.CountryId = @CountryId " +
                           "AND CountryMedalStandings.OlympicGameId = @OlympicGameId";
            int countryId = 1;
            int olympicGameId = 1;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryId", countryId);
            command.Parameters.AddWithValue("@OlympicGameId", olympicGameId);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    int goldMedals = Convert.ToInt32(reader["Gold"]);
                    int silverMedals = Convert.ToInt32(reader["Silver"]);
                    int bronzeMedals = Convert.ToInt32(reader["Bronze"]);
                    listBox1.Items.Add($"Gold Medals: {goldMedals}, Silver Medals: {silverMedals}, Bronze Medals: {bronzeMedals}");
                }
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e) 
        {
            connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
