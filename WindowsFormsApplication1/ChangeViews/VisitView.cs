using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Interfaces;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.ChangeViews
{

    public partial class VisitView : Form
    {
        private IVisit _db;
        private Visit _visitToEdit;


        public VisitView(IVisit db, Visit visitToEdit)
        {

            _db = db;
            InitializeComponent();
            customerCombo.DataSource = _db.GetCustomer();
            customerCombo.DisplayMember = "surname";
            customerCombo.ValueMember = "id_customer";

            horseCombo.DataSource = _db.GetHorse();
            horseCombo.DisplayMember = "name";
            horseCombo.ValueMember = "horse_id";

           


            if (visitToEdit != null)
            {
                DateTime date = DateTime.ParseExact(visitToEdit.which_day, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                _visitToEdit = visitToEdit;
                customerCombo.SelectedValue = visitToEdit.visitor;
                horseCombo.SelectedValue = visitToEdit.which_horse;
                dateTimePicker1.Value = date;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (_visitToEdit != null)
            {
                var datestring = dateTimePicker1.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                _visitToEdit.visitor = (int)customerCombo.SelectedValue;
                _visitToEdit.which_horse = (int)horseCombo.SelectedValue;
                _visitToEdit.which_day = datestring;
                _db.updateVisit(_visitToEdit);

            }
            else
            {
                if (dateTimePicker1.Checked)
                {
                    var datestring = dateTimePicker1.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
                    var newVisit = new Visit
                    {

                        visitor = (int)customerCombo.SelectedValue,
                        which_horse = (int)horseCombo.SelectedValue,
                        which_day = datestring
                    };

                    _db.insertVisit(newVisit);
                }
                else
                {
                    MessageBox.Show("Invalid date");
                }
            }
        }
    }
}
