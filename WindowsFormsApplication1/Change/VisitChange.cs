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
    public partial class VisitChange : Form
    {
        private IVisit _db = new VisitEdit();
        public VisitChange()
        {
            InitializeComponent();
            changeGridView.DataSource = _db.GetVisit();
            changeGridView.Columns[0].Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var dialog = new VisitView(_db, null);
            dialog.ShowDialog();
            (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (changeGridView.SelectedRows.Count > 0)
            {
                var selectedVisit = (Visit)changeGridView.SelectedRows[0].DataBoundItem;
                var dialog = new VisitView(_db, selectedVisit);
                dialog.ShowDialog();
                (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
            }
            else
                MessageBox.Show("No data selected");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (changeGridView.SelectedRows.Count > 0)
            {
                var selectedVisit = (Visit)changeGridView.SelectedRows[0].DataBoundItem;
                _db.deleteVisit(selectedVisit);
                (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
            }
            else
                MessageBox.Show("No data selected");

        }
    }
}
