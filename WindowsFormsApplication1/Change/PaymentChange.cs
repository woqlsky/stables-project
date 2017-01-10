using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ChangeViews;
using WindowsFormsApplication1.Edits;
using WindowsFormsApplication1.Interfaces;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Change
{
    public partial class PaymentChange : Form
    {
        private IPayment _db = new PaymentEdit();

        public PaymentChange()
        {
            InitializeComponent();
            changeGridView.DataSource = _db.GetPayment();
            changeGridView.Columns[0].Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var dialog = new PaymentView(_db, null);
            dialog.ShowDialog();
            (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (changeGridView.SelectedRows.Count > 0)
            {
                var selectedPay = (Payment)changeGridView.SelectedRows[0].DataBoundItem;
                var dialog = new PaymentView(_db, selectedPay);
                dialog.ShowDialog();
                (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
            }
            else
                MessageBox.Show("Choose the payment");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (changeGridView.SelectedRows.Count > 0)
            {
                var selectedPay = (Payment)changeGridView.SelectedRows[0].DataBoundItem;
                _db.deletePayment(selectedPay);
                (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
            }
            else
                MessageBox.Show("Choose the payment");

        }
    }
}
