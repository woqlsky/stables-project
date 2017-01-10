using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Requests
{
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();

            var db = new InqDataClassesDataContext();
            var result = db.Staffs.Select(emp => new
            {
                emp.surname,
            });
            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "surname";
            comboBox1.ValueMember = "surname";

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int distance;
            if (int.TryParse(textBox1.Text, out distance))
            {
                var value = System.Convert.ToInt32(textBox1.Text);
                var db = new InqDataClassesDataContext();
                var result =
                     from x in db.Staffs
                     where x.surname == comboBox1.SelectedValue.ToString()
                     select x;
                foreach (Staff x in result)
                {
                    x.salary += value;
                }
                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Invalid data input, try agan");
            }
        }
    }
}
