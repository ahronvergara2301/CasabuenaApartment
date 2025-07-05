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
    public partial class frmRentPayments : Form
    {
        public frmRentPayments()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmRentPayments_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Columns["Column1"].Width = 250;
            guna2DataGridView1.Rows.Add(new object[]
{
    "Delos Santos, Marie", 1200, 600, "Gcash", "01/15/25", "02/15/25", "Partially Paid"
});
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Reyes, John Michael", 950, 950, "Maya", "01/20/25", "02/20/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Cruz, Angela Mae", 1300, 0, "Cash", "01/10/25", "02/10/25", "OverDue"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Gonzales, Peter", 1500, 1000, "Gcash", "01/25/25", "02/25/25", "Partially Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Tan, Kimberly", 1100, 1100, "Bank Transfer", "01/18/25", "02/18/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Lim, Francis", 1050, 500, "Cash", "01/22/25", "02/22/25", "Partially Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Navarro, Clarisse", 1250, 0, "Maya", "01/05/25", "02/05/25", "OverDue"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Santos, Miguel", 1000, 1000, "Gcash", "01/19/25", "02/19/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Lopez, Sarah", 900, 450, "Gcash", "01/14/25", "02/14/25", "Partially Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
{
    "Delos Santos, Marie", 1200, 600, "Gcash", "01/15/25", "02/15/25", "Partially Paid"
});
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Reyes, John Michael", 950, 950, "Maya", "01/20/25", "02/20/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Cruz, Angela Mae", 1300, 0, "Cash", "01/10/25", "02/10/25", "OverDue"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Gonzales, Peter", 1500, 1000, "Gcash", "01/25/25", "02/25/25", "Partially Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Tan, Kimberly", 1100, 1100, "Bank Transfer", "01/18/25", "02/18/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Lim, Francis", 1050, 500, "Cash", "01/22/25", "02/22/25", "Partially Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Navarro, Clarisse", 1250, 0, "Maya", "01/05/25", "02/05/25", "OverDue"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Santos, Miguel", 1000, 1000, "Gcash", "01/19/25", "02/19/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Lopez, Sarah", 900, 450, "Gcash", "01/14/25", "02/14/25", "Partially Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
{
    "Delos Santos, Marie", 1200, 600, "Gcash", "01/15/25", "02/15/25", "Partially Paid"
});
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Reyes, John Michael", 950, 950, "Maya", "01/20/25", "02/20/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Cruz, Angela Mae", 1300, 0, "Cash", "01/10/25", "02/10/25", "OverDue"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Gonzales, Peter", 1500, 1000, "Gcash", "01/25/25", "02/25/25", "Partially Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Tan, Kimberly", 1100, 1100, "Bank Transfer", "01/18/25", "02/18/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Lim, Francis", 1050, 500, "Cash", "01/22/25", "02/22/25", "Partially Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Navarro, Clarisse", 1250, 0, "Maya", "01/05/25", "02/05/25", "OverDue"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Santos, Miguel", 1000, 1000, "Gcash", "01/19/25", "02/19/25", "Paid"
            });
            guna2DataGridView1.Rows.Add(new object[]
            {
    "Lopez, Sarah", 900, 450, "Gcash", "01/14/25", "02/14/25", "Partially Paid"
            });
        }
    }
}
