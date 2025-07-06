using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasabuenaApartment
{
    public partial class FrmArchive : Form
    {
        public FrmArchive()
        {
            InitializeComponent();
        }

        private void FrmArchive_Load(object sender, EventArgs e)
        {
            // Clear any previous columns
            dataGridView1.Columns.Clear();

            // Add columns
            dataGridView1.Columns.Add("TenantName", "Tenant name");
            dataGridView1.Columns.Add("TenantRoom", "Tenant Room");
            dataGridView1.Columns.Add("LeaseStart", "Lease Start");
            dataGridView1.Columns.Add("LeaseEnd", "Lease End");
            dataGridView1.Columns.Add("Payment", "Payment");

            // Add rows (sample data from image)
            dataGridView1.Rows.Add("Ahron Paul E. Vergara", "1", "October 23, 2024", "May 23, 2025", "Completed");
            dataGridView1.Rows.Add("Ahron Paul E. Vergara", "2", "March 23, 2024", "March 23, 2025", "Completed");
            dataGridView1.Rows.Add("Ahron Paul E. Vergara", "3", "January 23, 2024", "April 23, 2025", "Completed");
            dataGridView1.Rows.Add("Ahron Paul E. Vergara", "4", "February 23, 2024", "August 23, 2024", "Completed");

            // Auto-size columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
