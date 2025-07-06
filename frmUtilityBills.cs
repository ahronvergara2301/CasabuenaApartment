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


            dataGrid_UtilityBills.Rows.Add(new object[] { "1", 120, 135, 15, 450, 490, 40, 1000, 250, 7250, 0, "Paid" });
            dataGrid_UtilityBills.Rows.Add(new object[] { "2", 98, 112, 14, 610, 660, 50, 1000, 0, 7250, 7250, "Unpaid" });
            dataGrid_UtilityBills.Rows.Add(new object[] { "3", 145, 150, 5, 300, 340, 40, 1000, 100, 6940, 2000, "Partial" });
            dataGrid_UtilityBills.Rows.Add(new object[] { "4", 80, 100, 20, 500, 550, 50, 1000, 0, 7300, 0, "Paid" });
            dataGrid_UtilityBills.Rows.Add(new object[] { "5", 210, 225, 15, 700, 765, 65, 1000, 150, 7750, 7750, "Unpaid" });
        }

    
}
}
