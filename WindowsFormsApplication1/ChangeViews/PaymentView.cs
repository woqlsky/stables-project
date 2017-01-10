using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Interfaces;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.ChangeViews
{
    public partial class PaymentView : Form
    {
        private IPayment _db;
        private Payment _pay;
        public PaymentView(IPayment db, Payment pay)
        {
            _db = db;
            InitializeComponent();
            visitBox.DataSource = db.GetVisit();
            visitBox.DisplayMember = "visit_id";
            visitBox.ValueMember = "visit_id";

            if (pay != null)
            {
                _pay = pay;
                visitBox.SelectedValue = pay.for_which_visit;
                textBox2.Text = pay.sum_of_payment.ToString();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (_pay != null)
            {
                _pay.for_which_visit = (int)visitBox.SelectedValue;
                _pay.sum_of_payment = System.Convert.ToInt32(textBox2.Text);
                _db.updatePayment(_pay);

            }
            else
            {
                int distance;

                if (int.TryParse(textBox2.Text, out distance))
                {

                    var newPay = new Payment
                    {
                        for_which_visit = (int)visitBox.SelectedValue,
                        sum_of_payment = System.Convert.ToInt32(textBox2.Text)
                    };
                    _db.insertPayment(newPay);
                }
                else {
                    MessageBox.Show("You have invalid data input");
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
