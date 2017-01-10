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
    public partial class HorseView : Form
    {
        private IHorse _db;
        private Horse _horseToEdit;

        public HorseView(IHorse db, Horse horse)
        {
            _db = db;
            InitializeComponent();
            if (horse != null)
            {
                _horseToEdit = horse;
                nameBox.Text = horse.name;
                priceBox.Text = horse.price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_horseToEdit != null)
            {
                _horseToEdit.name = nameBox.Text;
                _horseToEdit.price = System.Convert.ToInt32(priceBox.Text);

                _db.updateHorse(_horseToEdit);
            }
            else
            {
                if (priceBox.Text.Length != 0 && !string.IsNullOrWhiteSpace(priceBox.Text)) {
                    var newHorse = new Models.Horse
                    {
                        name = nameBox.Text,
                        price = System.Convert.ToInt32(priceBox.Text),

                    };


                    _db.insertHorse(newHorse);
                }

                else
                    MessageBox.Show("Unsufficient data!");

            }
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}