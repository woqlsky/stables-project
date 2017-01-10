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
    public partial class CustomerView : Form
    {
        private ICustomer _db;
        private Customer _customerToEdit;

        public CustomerView(ICustomer db, Customer customer)
        {
            _db = db;
            InitializeComponent();
            if (customer != null)
            {
                _customerToEdit = customer;
                textBox1.Text = customer.name;
                textBox2.Text = customer.surname;
                textBox3.Text = customer.email;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (_customerToEdit != null)
            {
                _customerToEdit.name = textBox1.Text;
                _customerToEdit.surname = textBox2.Text;
                _customerToEdit.email = textBox3.Text;

                _db.updateCustomer(_customerToEdit);
            }
            else
            {
                if (textBox2.Text.Length != 0 && string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    var newCustomer = new Models.Customer
                    {
                        name = textBox1.Text,
                        surname = textBox2.Text,
                        email = textBox3.Text,

                    };


                    _db.insertCustomer(newCustomer);
                }
          
                else
                    MessageBox.Show("Unsufficient data!");

            }
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
