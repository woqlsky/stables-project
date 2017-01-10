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
    public partial class CustomerChange : Form
    {
        private ICustomer _db = new CustomerEdit();
        public CustomerChange()
        {
            InitializeComponent();
            changeGridView.DataSource = _db.GetCustomer();
            changeGridView.Columns[0].Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            var dialog = new CustomerView(_db, null);
            dialog.ShowDialog();

            (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (changeGridView.SelectedRows.Count > 0)
            {
                var selectedCust = (Customer)changeGridView.SelectedRows[0].DataBoundItem;
                var dialog = new CustomerView(_db, selectedCust);
                dialog.ShowDialog();
                (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
            }
            else
            {
                MessageBox.Show("Select the customer");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (changeGridView.SelectedRows.Count > 0)
                {
                    var selectedCustomer = (Customer)changeGridView.SelectedRows[0].DataBoundItem;
                    _db.deleteCustomer(selectedCustomer);
                    (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();

                }
                else
                {
                    MessageBox.Show("Select the customer");
                }
            }
            catch (System.Data.SqlClient.SqlException) {
                MessageBox.Show("You cannot delete customer, which has/had a visit. Try again");
            }
            
        }
    }
}
