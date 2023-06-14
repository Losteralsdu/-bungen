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
    public partial class Form1 : Form
    {
        private List<Sportart> sportarten = new List<Sportart>();
        //
        public Form1()
        {
            InitializeComponent();
            //
            listViewUebersicht.View = View.Details;
            listViewUebersicht.Columns.Add("Training", listViewUebersicht.Width / 4);
            listViewUebersicht.Columns.Add("Tag", listViewUebersicht.Width / 4);
            listViewUebersicht.Columns.Add("Dauer [min]", listViewUebersicht.Width / 4);
            listViewUebersicht.Columns.Add("Kalorienverbrauch", listViewUebersicht.Width / 4);
            //
            List<ListViewItem> lTrainingseinheiten = new List<ListViewItem>();
            //
        }

        public void berechneBMI()
        {
            try { 
            double gewicht = Convert.ToDouble(textBoxGewicht.Text);
            double groesse = Convert.ToDouble(textBoxGroesse.Text);
            //
            double bmi = gewicht / (groesse*groesse);
            //
            if(bmi > 40)
            {
                labelBMI.ForeColor = Color.Red;
                labelBMI.Text = bmi.ToString("0.00"); 
            } else if(bmi >= 30 && bmi <= 40 || bmi < 18.5)
            {
                labelBMI.ForeColor = Color.Orange;
                labelBMI.Text = bmi.ToString("0.00");
            } else
            {
                labelBMI.ForeColor = Color.Green;
                labelBMI.Text = bmi.ToString("0.00"); 
            }
            } catch { 
                
            }
        }

        public void berechneGrundumsatz()
        {
            try { 
            double alter = Convert.ToDouble(textBoxAlter.Text);
            double gewicht = Convert.ToDouble(textBoxGewicht.Text);
            double groesse = Convert.ToDouble(textBoxGroesse.Text) * 100;
            //
            if (rb_männlich.Checked)
            {
                double gMann = 66.47 + (13.7 * gewicht) + (5 * groesse) - (6.8 * alter);
                labelkcal.Text = gMann.ToString("0.00");
            } else if(rb_weiblich.Checked)
            {
                double gFrau = 655.1 + (9.6 * gewicht) + (1.8 * groesse) - (4.7 * alter);
                labelkcal.Text = gFrau.ToString("0.00");
            }
            } catch { }
        }

        private void change(object sender, EventArgs e)
        {
            if(labelBMI.Text != "" && labelkcal.Text != "")
            {
                berechneBMI();
            } 
            
            if(labelBMI.Text != "" && labelkcal.Text != "" && textBoxAlter.Text != "")
            {
                berechneBMI();
                berechneGrundumsatz();
            }
        }

        private void btn_Anlegen_Click(object sender, EventArgs e)
        {
            FormSportart fs = new FormSportart();
            DialogResult ds = fs.ShowDialog();
            if(ds == DialogResult.OK)
            {
                sportarten.Add(fs.getSportart());
                listBoxSportart.DataSource = null;
                listBoxSportart.DataSource = sportarten;
            }
        }

        private void btn_löschen_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBoxSportart.SelectedItems.Count < 0)
                {
                    throw new Exception("Du musst ein Item auswählen um es zu löschen!");
                } else 
                {
                    DialogResult ds = MessageBox.Show("Wollen sie die Sportart wirklich löschen?", "Training", MessageBoxButtons.YesNo);
                    if(ds == DialogResult.Yes)
                    {
                        sportarten.RemoveAt(listBoxSportart.SelectedIndex);
                        listBoxSportart.DataSource = null;
                        listBoxSportart.DataSource = sportarten;
                    } else
                    {
                        MessageBox.Show("Vorgang wurde abgebrochen!");
                    }
                }
            } catch{
                MessageBox.Show("Du musst ein Item auswählen um es zu löschen!");
            }
        }

        private void btn_erfassen_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBoxSportart.SelectedItems.Count >= 0)
                {
                    double re = 0;
                    double kalorien = sportarten[listBoxSportart.SelectedIndex].getKilokalorien();
                    double minuten = Convert.ToDouble(textBoxMinuten.Text);
                    re = Math.Round((minuten / 15), 0) * kalorien;
                    //
                    ListViewItem oLvi = new ListViewItem(sportarten[listBoxSportart.SelectedIndex].getBezeichnung());
                    oLvi.SubItems.Add(dateTimePickerDatum.Value.ToShortDateString());
                    oLvi.SubItems.Add(textBoxMinuten.Text);
                    oLvi.SubItems.Add(re.ToString());
                    //
                    listViewUebersicht.Items.Add(oLvi);
                    //
                    berechneGesamtKalorienverbrauch();
                } else
                {
                    MessageBox.Show("Du musst eine Sportart auswählen!");
                }
            } 
            catch
            {
                MessageBox.Show("Du musst eine Sportart auswählen!");
            }
        }

        public void berechneGesamtKalorienverbrauch()
        {
            double re = 0;
            for(int i = 0; i < listViewUebersicht.Items.Count; i++)
            {
                re += Convert.ToDouble(listViewUebersicht.Items[i].SubItems[2].Text);
            }
        }
    }
}
