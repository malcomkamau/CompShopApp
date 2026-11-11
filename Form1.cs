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

namespace CompShopApp
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Server=UNKNOWN-DEVICE\\SQLEXPRESS;Database=studentID_CompShop;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            LoadLaptopData();
        }

        private void LoadLaptopData()
        {
            // Requirement 10: Retrieve Brand, Model, and Price from the Laptop table and display them in the DataGridView
            string query = "SELECT brand, model, price FROM Laptop";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind the fetched records directly to the DataGridView table
                            dgvLaptops.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect or retrieve data: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Validate input fields before inserting
            if (string.IsNullOrWhiteSpace(txtBrand.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields before inserting.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Laptop (brand, model, processor, memory, harddisk, price) VALUES (@brand, @model, @processor, @memory, @harddisk, @price)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@brand", txtBrand.Text.Trim());
                        cmd.Parameters.AddWithValue("@model", txtModel.Text.Trim());
                        cmd.Parameters.AddWithValue("@processor", txtProcessor.Text.Trim());
                        cmd.Parameters.AddWithValue("@memory", txtMemory.Text.Trim());
                        cmd.Parameters.AddWithValue("@harddisk", txtHarddisk.Text.Trim());

                        if (decimal.TryParse(txtPrice.Text.Trim(), out decimal priceVal))
                        {
                            cmd.Parameters.AddWithValue("@price", priceVal);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Laptop inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLaptopData(); // Refresh the DataGridView after insertion
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Clear input fields after insertion
                        txtBrand.Clear();
                        txtModel.Clear();
                        txtProcessor.Clear();
                        txtMemory.Clear();
                        txtHarddisk.Clear();
                        txtPrice.Clear();

                        // Refresh the DataGridView to show the newly inserted record
                        LoadLaptopData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert data: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnOpenReport_Click(object sender, EventArgs e)
        {
            ReportForm reportWindow = new ReportForm();
            reportWindow.ShowDialog(); // Open the report form as a modal dialog
        }
    }
}
