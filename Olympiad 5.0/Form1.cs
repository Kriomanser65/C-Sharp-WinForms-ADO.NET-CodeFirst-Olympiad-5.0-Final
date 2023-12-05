using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using Olympiad_5._0.Db;
using Olympiad_5._0.Adding;
using Olympiad_5._0.Classes;

namespace Olympiad_5._0
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = dataBase.getConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("OlympicGames");
            comboBox1.Items.Add("Sports");
            comboBox1.Items.Add("Athletes");
            comboBox1.Items.Add("Medals");
            comboBox1.Items.Add("CountryMedalStandings");
            comboBox1.Items.Add("Countries");
            comboBox1.Items.Add("Sports");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormCollection openForms = Application.OpenForms;
            foreach (Form form in openForms)
            {
                form.Close();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please, Enter Table.");
                return;
            }
            string selectedTable = comboBox1.SelectedItem.ToString();
            switch (selectedTable)
            {
                case "Athletes":
                    AddAthletes addAthletesForm = new AddAthletes(selectedTable, connection);
                    addAthletesForm.ShowDialog();
                    break;
                case "OlympicGames":
                    AddOlympicGames addOlympicGamesForm = new AddOlympicGames(selectedTable, connection);
                    addOlympicGamesForm.ShowDialog();
                    break;
                case "Countries":
                    AddCountries addCountriesForm = new AddCountries(selectedTable, connection);
                    addCountriesForm.ShowDialog();
                    break;
                case "Sports":
                    AddSports addSportsForm = new AddSports(selectedTable, connection);
                    addSportsForm.ShowDialog();
                    break;
                case "CountryMedalStandings":
                    AddCountryMedalStandings addCountryMedalStandingsForm = new AddCountryMedalStandings(selectedTable, connection);
                    addCountryMedalStandingsForm.ShowDialog();
                    break;
                default:
                    MessageBox.Show("This Table not supported.");
                    break;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a table.");
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete.");
                return;
            }
            try
            {
                string selectedTable = comboBox1.SelectedItem.ToString();
                string primaryKeyColumn = GetPrimaryKeyColumnName(selectedTable);
                string deleteQuery = $"DELETE FROM {selectedTable} WHERE {primaryKeyColumn} IN (";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    deleteQuery += $"{row.Cells[primaryKeyColumn].Value}, ";
                }
                deleteQuery = deleteQuery.TrimEnd(',', ' ') + ")";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Selected row(s) deleted successfully.");
                comboBox1_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                connection.Close();
            }
        }
        private string GetPrimaryKeyColumnName(string tableName)
        {
            return "Id";
        }

        private void Info_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(connection);
            infoForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem.ToString();
            string query = $"SELECT * FROM {selectedTable}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView1();
        }
        private void LoadDataToDataGridView1()
        {
            dataGridView1.DataSource = "Data Source=DESKTOP-4SK39GD;Initial Catalog=Olympiad 4.0;Integrated Security=True";
        }
    }
}
