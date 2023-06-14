namespace ASP2021
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGewicht = new System.Windows.Forms.TextBox();
            this.textBoxGroesse = new System.Windows.Forms.TextBox();
            this.textBoxAlter = new System.Windows.Forms.TextBox();
            this.rb_männlich = new System.Windows.Forms.RadioButton();
            this.rb_weiblich = new System.Windows.Forms.RadioButton();
            this.labelkcal = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_löschen = new System.Windows.Forms.Button();
            this.btn_Anlegen = new System.Windows.Forms.Button();
            this.listBoxSportart = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_erfassen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMinuten = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelVerbrauch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewUebersicht = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGewicht);
            this.groupBox1.Controls.Add(this.textBoxGroesse);
            this.groupBox1.Controls.Add(this.textBoxAlter);
            this.groupBox1.Controls.Add(this.rb_männlich);
            this.groupBox1.Controls.Add(this.rb_weiblich);
            this.groupBox1.Controls.Add(this.labelkcal);
            this.groupBox1.Controls.Add(this.labelBMI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benutzer";
            // 
            // textBoxGewicht
            // 
            this.textBoxGewicht.Location = new System.Drawing.Point(84, 79);
            this.textBoxGewicht.Name = "textBoxGewicht";
            this.textBoxGewicht.Size = new System.Drawing.Size(119, 20);
            this.textBoxGewicht.TabIndex = 12;
            this.textBoxGewicht.TextChanged += new System.EventHandler(this.change);
            // 
            // textBoxGroesse
            // 
            this.textBoxGroesse.Location = new System.Drawing.Point(84, 53);
            this.textBoxGroesse.Name = "textBoxGroesse";
            this.textBoxGroesse.Size = new System.Drawing.Size(119, 20);
            this.textBoxGroesse.TabIndex = 11;
            this.textBoxGroesse.TextChanged += new System.EventHandler(this.change);
            // 
            // textBoxAlter
            // 
            this.textBoxAlter.Location = new System.Drawing.Point(84, 26);
            this.textBoxAlter.Name = "textBoxAlter";
            this.textBoxAlter.Size = new System.Drawing.Size(119, 20);
            this.textBoxAlter.TabIndex = 10;
            this.textBoxAlter.TextChanged += new System.EventHandler(this.change);
            // 
            // rb_männlich
            // 
            this.rb_männlich.AutoSize = true;
            this.rb_männlich.Location = new System.Drawing.Point(153, 110);
            this.rb_männlich.Name = "rb_männlich";
            this.rb_männlich.Size = new System.Drawing.Size(67, 17);
            this.rb_männlich.TabIndex = 9;
            this.rb_männlich.TabStop = true;
            this.rb_männlich.Text = "männlich";
            this.rb_männlich.UseVisualStyleBackColor = true;
            this.rb_männlich.TextChanged += new System.EventHandler(this.change);
            // 
            // rb_weiblich
            // 
            this.rb_weiblich.AutoSize = true;
            this.rb_weiblich.Location = new System.Drawing.Point(84, 110);
            this.rb_weiblich.Name = "rb_weiblich";
            this.rb_weiblich.Size = new System.Drawing.Size(63, 17);
            this.rb_weiblich.TabIndex = 8;
            this.rb_weiblich.TabStop = true;
            this.rb_weiblich.Text = "weiblich";
            this.rb_weiblich.UseVisualStyleBackColor = true;
            this.rb_weiblich.TextChanged += new System.EventHandler(this.change);
            // 
            // labelkcal
            // 
            this.labelkcal.AutoSize = true;
            this.labelkcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkcal.Location = new System.Drawing.Point(108, 179);
            this.labelkcal.Name = "labelkcal";
            this.labelkcal.Size = new System.Drawing.Size(39, 15);
            this.labelkcal.TabIndex = 7;
            this.labelkcal.Text = "0 kcal";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI.Location = new System.Drawing.Point(108, 142);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(14, 15);
            this.labelBMI.TabIndex = 6;
            this.labelBMI.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Grundumsatz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "BMI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geschlecht:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gewicht:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Größe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_löschen);
            this.groupBox2.Controls.Add(this.btn_Anlegen);
            this.groupBox2.Controls.Add(this.listBoxSportart);
            this.groupBox2.Location = new System.Drawing.Point(302, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sportarten";
            // 
            // btn_löschen
            // 
            this.btn_löschen.Location = new System.Drawing.Point(212, 71);
            this.btn_löschen.Name = "btn_löschen";
            this.btn_löschen.Size = new System.Drawing.Size(118, 23);
            this.btn_löschen.TabIndex = 2;
            this.btn_löschen.Text = "Sportart löschen";
            this.btn_löschen.UseVisualStyleBackColor = true;
            this.btn_löschen.Click += new System.EventHandler(this.btn_löschen_Click);
            // 
            // btn_Anlegen
            // 
            this.btn_Anlegen.Location = new System.Drawing.Point(212, 21);
            this.btn_Anlegen.Name = "btn_Anlegen";
            this.btn_Anlegen.Size = new System.Drawing.Size(118, 23);
            this.btn_Anlegen.TabIndex = 1;
            this.btn_Anlegen.Text = "Sportart anlegen";
            this.btn_Anlegen.UseVisualStyleBackColor = true;
            this.btn_Anlegen.Click += new System.EventHandler(this.btn_Anlegen_Click);
            // 
            // listBoxSportart
            // 
            this.listBoxSportart.FormattingEnabled = true;
            this.listBoxSportart.Location = new System.Drawing.Point(7, 20);
            this.listBoxSportart.Name = "listBoxSportart";
            this.listBoxSportart.Size = new System.Drawing.Size(198, 186);
            this.listBoxSportart.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_erfassen);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxMinuten);
            this.groupBox3.Controls.Add(this.dateTimePickerDatum);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Training erfassen";
            // 
            // btn_erfassen
            // 
            this.btn_erfassen.Location = new System.Drawing.Point(483, 42);
            this.btn_erfassen.Name = "btn_erfassen";
            this.btn_erfassen.Size = new System.Drawing.Size(118, 23);
            this.btn_erfassen.TabIndex = 3;
            this.btn_erfassen.Text = "Training erfassen";
            this.btn_erfassen.UseVisualStyleBackColor = true;
            this.btn_erfassen.Click += new System.EventHandler(this.btn_erfassen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dauer in Minuten:";
            // 
            // textBoxMinuten
            // 
            this.textBoxMinuten.Location = new System.Drawing.Point(279, 45);
            this.textBoxMinuten.Name = "textBoxMinuten";
            this.textBoxMinuten.Size = new System.Drawing.Size(120, 20);
            this.textBoxMinuten.TabIndex = 15;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(9, 45);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatum.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tag:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelVerbrauch);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.listViewUebersicht);
            this.groupBox4.Location = new System.Drawing.Point(13, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(647, 216);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trainingsübersicht";
            // 
            // labelVerbrauch
            // 
            this.labelVerbrauch.AutoSize = true;
            this.labelVerbrauch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerbrauch.Location = new System.Drawing.Point(193, 181);
            this.labelVerbrauch.Name = "labelVerbrauch";
            this.labelVerbrauch.Size = new System.Drawing.Size(14, 15);
            this.labelVerbrauch.TabIndex = 14;
            this.labelVerbrauch.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Kalorienverbrauch gesamt:";
            // 
            // listViewUebersicht
            // 
            this.listViewUebersicht.HideSelection = false;
            this.listViewUebersicht.Location = new System.Drawing.Point(8, 20);
            this.listViewUebersicht.Name = "listViewUebersicht";
            this.listViewUebersicht.Size = new System.Drawing.Size(611, 146);
            this.listViewUebersicht.TabIndex = 0;
            this.listViewUebersicht.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 579);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(699, 618);
            this.MinimumSize = new System.Drawing.Size(699, 618);
            this.Name = "Form1";
            this.Text = "HTS-Training";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelkcal;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGewicht;
        private System.Windows.Forms.TextBox textBoxGroesse;
        private System.Windows.Forms.TextBox textBoxAlter;
        private System.Windows.Forms.RadioButton rb_männlich;
        private System.Windows.Forms.RadioButton rb_weiblich;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_löschen;
        private System.Windows.Forms.Button btn_Anlegen;
        private System.Windows.Forms.ListBox listBoxSportart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_erfassen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMinuten;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelVerbrauch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewUebersicht;
    }
}

