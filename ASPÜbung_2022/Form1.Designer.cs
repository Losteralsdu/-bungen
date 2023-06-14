namespace ASPÜbung_2022
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFahrzeuge = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxKunden = new System.Windows.Forms.ListBox();
            this.btn_anlegen = new System.Windows.Forms.Button();
            this.rb_Diesel = new System.Windows.Forms.RadioButton();
            this.rb_Benzin = new System.Windows.Forms.RadioButton();
            this.rb_EAntrieb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_leihen = new System.Windows.Forms.Button();
            this.dateTimePickerAbholen = new System.Windows.Forms.DateTimePicker();
            this.textBoxLeihdauer = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewStatistik = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fahrzeuge:";
            // 
            // listViewFahrzeuge
            // 
            this.listViewFahrzeuge.HideSelection = false;
            this.listViewFahrzeuge.Location = new System.Drawing.Point(37, 28);
            this.listViewFahrzeuge.Name = "listViewFahrzeuge";
            this.listViewFahrzeuge.Size = new System.Drawing.Size(256, 131);
            this.listViewFahrzeuge.TabIndex = 2;
            this.listViewFahrzeuge.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_anlegen);
            this.groupBox1.Controls.Add(this.listBoxKunden);
            this.groupBox1.Location = new System.Drawing.Point(345, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 207);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kundendaten";
            // 
            // listBoxKunden
            // 
            this.listBoxKunden.FormattingEnabled = true;
            this.listBoxKunden.Location = new System.Drawing.Point(6, 19);
            this.listBoxKunden.Name = "listBoxKunden";
            this.listBoxKunden.Size = new System.Drawing.Size(157, 173);
            this.listBoxKunden.TabIndex = 0;
            // 
            // btn_anlegen
            // 
            this.btn_anlegen.Location = new System.Drawing.Point(169, 19);
            this.btn_anlegen.Name = "btn_anlegen";
            this.btn_anlegen.Size = new System.Drawing.Size(112, 23);
            this.btn_anlegen.TabIndex = 1;
            this.btn_anlegen.Text = "Kunden anlegen";
            this.btn_anlegen.UseVisualStyleBackColor = true;
            this.btn_anlegen.Click += new System.EventHandler(this.btn_anlegen_Click);
            // 
            // rb_Diesel
            // 
            this.rb_Diesel.AutoSize = true;
            this.rb_Diesel.Location = new System.Drawing.Point(37, 165);
            this.rb_Diesel.Name = "rb_Diesel";
            this.rb_Diesel.Size = new System.Drawing.Size(54, 17);
            this.rb_Diesel.TabIndex = 4;
            this.rb_Diesel.TabStop = true;
            this.rb_Diesel.Text = "Diesel";
            this.rb_Diesel.UseVisualStyleBackColor = true;
            this.rb_Diesel.CheckedChanged += new System.EventHandler(this.rb_Diesel_CheckedChanged);
            // 
            // rb_Benzin
            // 
            this.rb_Benzin.AutoSize = true;
            this.rb_Benzin.Location = new System.Drawing.Point(136, 165);
            this.rb_Benzin.Name = "rb_Benzin";
            this.rb_Benzin.Size = new System.Drawing.Size(57, 17);
            this.rb_Benzin.TabIndex = 5;
            this.rb_Benzin.TabStop = true;
            this.rb_Benzin.Text = "Benzin";
            this.rb_Benzin.UseVisualStyleBackColor = true;
            this.rb_Benzin.CheckedChanged += new System.EventHandler(this.rb_Benzin_CheckedChanged);
            // 
            // rb_EAntrieb
            // 
            this.rb_EAntrieb.AutoSize = true;
            this.rb_EAntrieb.Location = new System.Drawing.Point(225, 165);
            this.rb_EAntrieb.Name = "rb_EAntrieb";
            this.rb_EAntrieb.Size = new System.Drawing.Size(68, 17);
            this.rb_EAntrieb.TabIndex = 6;
            this.rb_EAntrieb.TabStop = true;
            this.rb_EAntrieb.Text = "E-Antrieb";
            this.rb_EAntrieb.UseVisualStyleBackColor = true;
            this.rb_EAntrieb.CheckedChanged += new System.EventHandler(this.rb_EAntrieb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLeihdauer);
            this.groupBox2.Controls.Add(this.dateTimePickerAbholen);
            this.groupBox2.Controls.Add(this.btn_leihen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(37, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leihzeitraum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Abholdatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Leihdauer (Tage):";
            // 
            // btn_leihen
            // 
            this.btn_leihen.Location = new System.Drawing.Point(447, 30);
            this.btn_leihen.Name = "btn_leihen";
            this.btn_leihen.Size = new System.Drawing.Size(109, 23);
            this.btn_leihen.TabIndex = 10;
            this.btn_leihen.Text = "Fahrzeug leihen";
            this.btn_leihen.UseVisualStyleBackColor = true;
            this.btn_leihen.Click += new System.EventHandler(this.btn_leihen_Click);
            // 
            // dateTimePickerAbholen
            // 
            this.dateTimePickerAbholen.Location = new System.Drawing.Point(6, 35);
            this.dateTimePickerAbholen.Name = "dateTimePickerAbholen";
            this.dateTimePickerAbholen.Size = new System.Drawing.Size(198, 20);
            this.dateTimePickerAbholen.TabIndex = 11;
            // 
            // textBoxLeihdauer
            // 
            this.textBoxLeihdauer.Location = new System.Drawing.Point(247, 36);
            this.textBoxLeihdauer.Name = "textBoxLeihdauer";
            this.textBoxLeihdauer.Size = new System.Drawing.Size(118, 20);
            this.textBoxLeihdauer.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewStatistik);
            this.groupBox3.Location = new System.Drawing.Point(37, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 179);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ausleihstatistik";
            // 
            // listViewStatistik
            // 
            this.listViewStatistik.HideSelection = false;
            this.listViewStatistik.Location = new System.Drawing.Point(9, 19);
            this.listViewStatistik.Name = "listViewStatistik";
            this.listViewStatistik.Size = new System.Drawing.Size(580, 154);
            this.listViewStatistik.TabIndex = 0;
            this.listViewStatistik.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rb_EAntrieb);
            this.Controls.Add(this.rb_Benzin);
            this.Controls.Add(this.rb_Diesel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewFahrzeuge);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(671, 551);
            this.MinimumSize = new System.Drawing.Size(671, 551);
            this.Name = "Form1";
            this.Text = "HTS-Autovermietung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFahrzeuge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_anlegen;
        private System.Windows.Forms.ListBox listBoxKunden;
        private System.Windows.Forms.RadioButton rb_Diesel;
        private System.Windows.Forms.RadioButton rb_Benzin;
        private System.Windows.Forms.RadioButton rb_EAntrieb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLeihdauer;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbholen;
        private System.Windows.Forms.Button btn_leihen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewStatistik;
    }
}

