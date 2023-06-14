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
    public partial class FormKunde : Form
    {
        private Kunde knd;
        public FormKunde()
        {
            InitializeComponent();
        }

        public Kunde getKunde()
        {
            return knd;
        }

        private bool pruefeAlter()
        {
            bool tf = false;
            DateTime now = DateTime.Now;
            DateTime eingabe = dateTimePickerGeburtstag.Value;
            if(now.Year - eingabe.Year > 18)
            {
                tf = true;
            } else
            {
                if(now.Year - eingabe.Year == 18)
                {
                    if(now.Month <= eingabe.Month)
                    {
                        if(now.Day == eingabe.Day || eingabe.Day < now.Day)
                        {
                            tf = true;
                        } else
                        {
                            tf = false;
                        }
                    } else
                    {
                        tf = false;
                    }
                } else
                {
                    tf = false;
                }
            }
            return tf;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(!pruefeAlter())
            {
                MessageBox.Show("Kunden müssen Volljährig sein!");
            } else
            {
                knd = new Kunde(textBoxVorname.Text, textBoxNachname.Text, dateTimePickerGeburtstag.Value);
                MessageBox.Show("Kunde wurde erfolgreich erstellt!");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_abbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
