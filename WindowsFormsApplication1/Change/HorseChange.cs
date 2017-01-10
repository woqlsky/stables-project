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
    public partial class HorseChange : Form
    {
        private IHorse _db = new HorseEdit();
        public HorseChange()
        {
            InitializeComponent();
            changeGridView.DataSource = _db.GetHorse();
            changeGridView.Columns[0].Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var dialog = new HorseView(_db, null);
            dialog.ShowDialog();

            (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (changeGridView.SelectedRows.Count > 0)
            {
                var selectedHorse = (Horse)changeGridView.SelectedRows[0].DataBoundItem;
                var dialog = new HorseView(_db, selectedHorse);
                dialog.ShowDialog();
                (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
            }
            else
            {
                MessageBox.Show("Select the horse");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeGridView.SelectedRows.Count > 0)
                {

                    var selectedHorse = (Horse)changeGridView.SelectedRows[0].DataBoundItem;
                    _db.deleteHorse(selectedHorse);
                    (changeGridView.BindingContext[changeGridView.DataSource] as CurrencyManager).Refresh();
                }
                else
                {
                    MessageBox.Show("Select the horse");
                }
            }
            catch (System.Data.SqlClient.SqlException) {

                MessageBox.Show("You cannot delete horse, which is in visit database. Try again");
            }

        }
    }
}
