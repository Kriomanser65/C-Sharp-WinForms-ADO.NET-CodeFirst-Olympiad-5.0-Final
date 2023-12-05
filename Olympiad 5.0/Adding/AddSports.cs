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
    public partial class AddSports : Form
    {
        SqlConnection connection;
        public AddSports(string selectedTable, SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void AddSports_Load(object sender, EventArgs e)
        {

        }

        private void AddName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddName.Text))
            {
                MessageBox.Show("Please select a sport.");
                return;
            }
            try
            {
                string sportName = AddName.Text;
                string query = $"INSERT INTO Sports (Name) VALUES ('{sportName}')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sport added successfully.");
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
