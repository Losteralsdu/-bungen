using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASPÜbung_2022
{
    public partial class Form1 : Form
    {
        private List<Kunde> kunden;
        private List<Fahrzeug> fahrzeuge;

        public Form1()
        {
            InitializeComponent();
            //
            listViewFahrzeuge.View = View.Details;
            listViewStatistik.View = View.Details;
            //
            listViewFahrzeuge.Columns.Add("Modell", listViewFahrzeuge.Width / 2);
            listViewFahrzeuge.Columns.Add("Preis", listViewFahrzeuge.Width / 2);
            //
            listViewStatistik.Columns.Add("Name", listViewStatistik.Width / 4);
            listViewStatistik.Columns.Add("Fahzeug", listViewStatistik.Width / 4);
            listViewStatistik.Columns.Add("Leihdauer", listViewStatistik.Width / 4);
            listViewStatistik.Columns.Add("Leihgebühr", listViewStatistik.Width / 4);
            //
            List<Fahrzeug> ausgelieheneFahrzeuge = new List<Fahrzeug>();
            kunden = new List<Kunde>();
            fahrzeuge = new List<Fahrzeug>();
            //
            fahrzeuge.Add(new Fahrzeug("BMW I3", 3, 300));
            fahrzeuge.Add(new Fahrzeug("Audi A8", 1, 275));
            fahrzeuge.Add(new Fahrzeug("VW Golf", 2, 100));
            //
            aktualisiereFahrzeugauswahl();
        }

        private void btn_anlegen_Click(object sender, EventArgs e)
        {
            FormKunde fk = new FormKunde();
            var res = fk.ShowDialog();
            if(res == DialogResult.OK)
            {
                kunden.Add(fk.getKunde());
                listBoxKunden.DataSource = null;
                listBoxKunden.DataSource = kunden;
            }
        }

        private void aktualisiereFahrzeugauswahl()
        {
            listViewFahrzeuge.Items.Clear();
            int iA = 0;
            if(rb_Benzin.Checked)
            {
                iA = 1;
            } else if(rb_Diesel.Checked)
            {
                iA = 2;
            } else if(rb_EAntrieb.Checked)
            {
                iA = 3;
            }

            for(int i = 0; i < fahrzeuge.Count; i++)
            {
                ListViewItem oLvI = new ListViewItem(fahrzeuge[i].getModell());
                oLvI.SubItems.Add(fahrzeuge[i].getGeb().ToString());
                if (fahrzeuge[i].istAntriebsart(iA))
                {
                    oLvI.ForeColor = Color.Red;
                } else
                {
                    oLvI.ForeColor = Color.Black;
                }
                listViewFahrzeuge.Items.Add(oLvI);
            }

        }

        private void rb_Diesel_CheckedChanged(object sender, EventArgs e)
        {
            aktualisiereFahrzeugauswahl();
        }

        private void rb_Benzin_CheckedChanged(object sender, EventArgs e)
        {
            aktualisiereFahrzeugauswahl();
        }

        private void rb_EAntrieb_CheckedChanged(object sender, EventArgs e)
        {
            aktualisiereFahrzeugauswahl();
        }

        private void btn_leihen_Click(object sender, EventArgs e)
        {
            try { 
            if(listBoxKunden.SelectedItems.Count >= 0 && listViewFahrzeuge.SelectedItems.Count >= 0)
            {
                if(Convert.ToDouble(textBoxLeihdauer.Text) >= 0)
                {
                    double erg = Convert.ToDouble(textBoxLeihdauer.Text) * Convert.ToDouble(listViewFahrzeuge.SelectedItems[0].SubItems[1].Text);
                    string fahrzeug = listViewFahrzeuge.SelectedItems[0].SubItems[0].Text;
                    ListViewItem oLvi = new ListViewItem(kunden[listBoxKunden.SelectedIndex].getVorname() + " " +kunden[listBoxKunden.SelectedIndex].getNachname());
                    oLvi.SubItems.Add(fahrzeug);
                    oLvi.SubItems.Add(textBoxLeihdauer.Text);
                    oLvi.SubItems.Add(erg.ToString());
                    listViewStatistik.Items.Add(oLvi);

                } else
                {
                    MessageBox.Show("Du musst eine Positive Leihdauer auswählen!");
                }
            } else
            {
                MessageBox.Show("Es muss ein Kunde und ein Fahrzeug ausgewählt sein!");
            }
            } catch
            {
                MessageBox.Show("Ein Fehler ist aufgetreten!");
            }
        }
    }
}
