using Microsoft.Reporting.WinForms;
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
    public partial class ReportForm : Form
    {
        private readonly string connectionString = "Server=UNKNOWN-DEVICE\\SQLEXPRESS;Database=studentID_CompShop;Trusted_Connection=True;";

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Laptop ORDER BY brand ASC;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.ReportPath = "LaptopReport.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect or retrieve data: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnCloseReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadReportData()
        {
            string query = "SELECT Id, brand, model, processor, memory, harddisk, price FROM Laptop ORDER BY brand ASC;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
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
    }
}
