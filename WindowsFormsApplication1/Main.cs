using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            var dialog = new SubDialog();
            dialog.ShowDialog();
            // We get here when newform's DialogResult gets set



        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            var request = new RequestForm();
            request.ShowDialog();
            // We get here when newform's DialogResult gets set

        }
    }
}
