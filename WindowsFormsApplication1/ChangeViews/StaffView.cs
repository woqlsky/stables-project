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
    public partial class StaffView : Form
    {
        private IStaff _db;
        private Staff _empToEdit;
        public StaffView(IStaff db, Staff empToEdit)
        {
            _db = db;
            InitializeComponent();
            if (empToEdit != null)
            {
                _empToEdit = empToEdit;
                textBox1.Text = empToEdit.name;
                textBox2.Text = empToEdit.surname;
                textBox3.Text = empToEdit.salary.ToString();
                textBox4.Text = empToEdit.position;
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            if (_empToEdit != null)
            {

                _empToEdit.name = textBox1.Text;
                _empToEdit.surname = textBox2.Text;
                var value = System.Convert.ToInt32(textBox3.Text);
                _empToEdit.salary = value;
                _empToEdit.position = textBox4.Text;

                _db.updateStaff(_empToEdit);
            }
            else
            {
                int distance;
                if (textBox2.Text.Length != 0 && int.TryParse(textBox3.Text, out distance))
                {

                    var newEmp = new Staff
                    {
                        name = textBox1.Text,
                        surname = textBox2.Text,
                        salary = System.Convert.ToInt32(textBox3.Text),
                        position = textBox4.Text
                    };

                    _db.insertStaff(newEmp);
                }
                else
                {
                    MessageBox.Show("Unsufficient data!");
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
