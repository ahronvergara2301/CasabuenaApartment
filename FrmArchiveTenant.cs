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
    public partial class FrmArchiveTenant : Form
    {
        public FrmArchiveTenant()
        {
            InitializeComponent();
        }

        private void FrmArchiveTenant_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            // Add columns
            dataGridView1.Columns.Add("Room Number", "Room Number");
            dataGridView1.Columns.Add("LeaseStart", "Lease Start");
            dataGridView1.Columns.Add("LeaseEnd", "Lease End");
            dataGridView1.Columns.Add("Payment", "Payment");
            dataGridView1.Columns.Add("Notes", "Notes");

            // Add rows (sample data from image)
            dataGridView1.Rows.Add("1", "October 23, 2024", "May 23, 2025", "₱ 4000/mo", "No Late Payments");
            

            // Auto-size columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
