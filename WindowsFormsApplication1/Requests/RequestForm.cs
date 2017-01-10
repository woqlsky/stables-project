using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Requests;

namespace WindowsFormsApplication1
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new InqDataClassesDataContext();
            var result = db.CUSTOMERs.Select(c => new
            {
                c.name,
                c.surname,
                c.email,

            });
            dataGridView1.DataSource = result;
        }

        private void numberOfStaffButton_Click(object sender, EventArgs e)
        {
            var db = new InqDataClassesDataContext();
            var result = db.Staffs.Count();
            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void allHorsebutton_Click(object sender, EventArgs e)
        {
            var db = new InqDataClassesDataContext();
            var result = db.Horses.Select( h => new
            {
                h.price,
                h.name,

            });
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allStafOptions_Click(object sender, EventArgs e)
        {
            var db = new InqDataClassesDataContext();
            var result = db.Staffs.Select(emp => new
            {
                   emp.name,
                   emp.surname,
                   emp.salary,
                   emp.position,

            });
            dataGridView1.DataSource = result;
        }

        private void allPaymentsButton_Click(object sender, EventArgs e)
        {
            var db = new InqDataClassesDataContext();
            var result = db.Payments.Select(p => new
            {
                p.for_which_visit,
                p.sum_of_payment,

            });
            dataGridView1.DataSource = result;
        }

        private void allVisitsButton_Click(object sender, EventArgs e)
        {
            var db = new InqDataClassesDataContext();
            var result = db.Visits.Select(v => new
            {
                v.visitor,
                v.which_horse,
                v.which_day,

            });
            dataGridView1.DataSource = result;
        }

        private void maxSalaryButton_Click(object sender, EventArgs e)
        {
            var db = new InqDataClassesDataContext();
            var result = db.Staffs.Max(emp => emp.salary);
            textBox1.Text = result.ToString();
        }

        private void lowSalaryButton_Click(object sender, EventArgs e)
        {
            var db = new InqDataClassesDataContext();
            var result = db.Staffs.Min(emp => emp.salary);
            textBox1.Text = result.ToString();
        }

        private void changeSalaryButton_Click(object sender, EventArgs e)
        {
            var changeSal = new SalaryForm();
            changeSal.ShowDialog();
            // We get here when newform's DialogResult gets set
        }
    }
}
