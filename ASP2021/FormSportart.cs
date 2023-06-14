using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASP2021
{
    public partial class FormSportart : Form
    {
        private Sportart sSportart;
        public FormSportart()
        {
            InitializeComponent();
            this.AcceptButton = btn_ok;
        }

        public FormSportart(Sportart sSp)
        {
            InitializeComponent();
            sSportart = sSp;
            textBoxVerbrauch.Text = sSportart.getBezeichnung();
            textBoxVerbrauch.Text = sSportart.getKilokalorien().ToString();
        }

        public Sportart getSportart()
        {
            return sSportart;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxSportart.Text != "" && textBoxVerbrauch.Text != "")
                {
                    sSportart = new Sportart(textBoxSportart.Text, Convert.ToDouble(textBoxVerbrauch.Text));
                    this.DialogResult = DialogResult.OK;
                } else
                {
                    throw new Exception("Bitte Daten korrekt eingeben.");
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_abbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
