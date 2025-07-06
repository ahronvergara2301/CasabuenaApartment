using System;
using System.Windows.Forms;

namespace CasabuenaApartment
{
    public partial class FrmTenantRecord2 : Form
    {
        public FrmTenantRecord2()
        {
            InitializeComponent();
        }

        private void FrmTenantRecord2_Load(object sender, EventArgs e)
        {
            // Clear existing columns (optional but safe)
            dataGridView1.Columns.Clear();

            // Add columns
            dataGridView1.Columns.Add("RoomNo", "Room No#");
            dataGridView1.Columns.Add("TenantName", "Tenants name");
            dataGridView1.Columns.Add("Contact", "Contact Number");
            dataGridView1.Columns.Add("LeaseStart", "Lease Start");
            dataGridView1.Columns.Add("LeaseEnd", "Lease End");
            dataGridView1.Columns.Add("PaymentStatus", "Payment Status");
            dataGridView1.Columns.Add("Deposit", "Deposit");
            dataGridView1.Columns.Add("Status", "Status");

            // Add rows - ROOM 1
            dataGridView1.Rows.Add("1", "Tenant Number 1", "0917-123-4567", "01/5/25", "02/5/25", "❌ Overdue", "₱4000", "InActive");
            dataGridView1.Rows.Add("1", "Tenant Number 2", "0917-123-4567", "01/7/25", "02/7/25", "--", "₱0.00", "Reserved");
            dataGridView1.Rows.Add("1", "Tenant Number 3", "0917-123-4567", "01/5/25", "02/5/25", "✅ Paid", "₱4000", "Active");
            dataGridView1.Rows.Add("1", "Tenant Number 4", "0917-123-4567", "01/5/25", "02/5/25", "✅ Paid", "₱4000", "Active");

            // Add rows - ROOM 2
            dataGridView1.Rows.Add("2", "Tenant Number 1", "0917-123-4567", "01/5/25", "02/5/25", "❌ Overdue", "₱4000", "InActive");
            dataGridView1.Rows.Add("2", "Tenant Number 2", "0917-123-4567", "01/7/25", "02/7/25", "⏳ Pending", "₱0.00", "Active");
            dataGridView1.Rows.Add("2", "Tenant Number 3", "0917-123-4567", "01/5/25", "02/5/25", "⚠️ Balanced", "₱4000", "Active");
            dataGridView1.Rows.Add("2", "Tenant Number 4", "0917-123-4567", "01/5/25", "02/5/25", "✅ Paid", "₱4000", "Active");

            // Auto-size columns to fill the grid width
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
