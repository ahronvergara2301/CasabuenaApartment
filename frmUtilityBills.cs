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
    public partial class frmUtilityBills : Form
    {
        public frmUtilityBills()
        {
            InitializeComponent();
        }

        private void frmUtilityBills_Load(object sender, EventArgs e)
        {
            DataGridView1.Rows.Add(new object[] { "1", 1150, 1200, 50, 2900, 3000, 100, 500, 0, 1750, 0, "Paid" });
            DataGridView1.Rows.Add(new object[] { "2", 980, 1030, 50, 2500, 2600, 100, 500, 50, 1800, 0, "Unpaid" });
            DataGridView1.Rows.Add(new object[] { "3", 1500, 1570, 70, 4000, 4120, 120, 500, 0, 2060, 500, "Partial" });
            DataGridView1.Rows.Add(new object[] { "4", 1100, 1165, 65, 2000, 2105, 105, 500, 0, 1895, 0, "Paid" });
            DataGridView1.Rows.Add(new object[] { "5", 875, 930, 55, 1000, 1100, 100, 500, 25, 1735, 0, "Unpaid" });
            DataGridView1.Rows.Add(new object[] { "1", 1150, 1200, 50, 2900, 3000, 100, 500, 0, 1750, 0, "Paid" });
            DataGridView1.Rows.Add(new object[] { "2", 980, 1030, 50, 2500, 2600, 100, 500, 50, 1800, 0, "Unpaid" });
            DataGridView1.Rows.Add(new object[] { "3", 1500, 1570, 70, 4000, 4120, 120, 500, 0, 2060, 500, "Partial" });
            DataGridView1.Rows.Add(new object[] { "4", 1100, 1165, 65, 2000, 2105, 105, 500, 0, 1895, 0, "Paid" });
            DataGridView1.Rows.Add(new object[] { "5", 875, 930, 55, 1000, 1100, 100, 500, 25, 1735, 0, "Unpaid" });


    }

        private void toUtilityBills_Click(object sender, EventArgs e)
        {
            frmRentPayments rentPayments = new frmRentPayments();
            this.Hide();
            rentPayments.Show();

        }
    }
}
