using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Change;

namespace WindowsFormsApplication1
{
    public partial class SubDialog : Form
    {
        public SubDialog()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var paymentChange = new PaymentChange();
            paymentChange.ShowDialog();
            // We get here when newform's DialogResult gets set
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            var customerChange = new CustomerChange();
            customerChange.ShowDialog();
            // We get here when newform's DialogResult gets set
        }

        private void horseButton_Click(object sender, EventArgs e)
        {
            var horseChange = new HorseChange();
            horseChange.ShowDialog();
            // We get here when newform's DialogResult gets set
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            var visitChange = new VisitChange();
            visitChange.ShowDialog();
            // We get here when newform's DialogResult gets set
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            var staffChange = new StaffChange();
            staffChange.ShowDialog();
            // We get here when newform's DialogResult gets set
        }
    }
}
