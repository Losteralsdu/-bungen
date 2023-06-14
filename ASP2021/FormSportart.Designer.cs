namespace ASP2021
{
    partial class FormSportart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSportart = new System.Windows.Forms.TextBox();
            this.textBoxVerbrauch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_abbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sportart:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verbrauch:";
            // 
            // textBoxSportart
            // 
            this.textBoxSportart.Location = new System.Drawing.Point(139, 22);
            this.textBoxSportart.Name = "textBoxSportart";
            this.textBoxSportart.Size = new System.Drawing.Size(112, 20);
            this.textBoxSportart.TabIndex = 2;
            // 
            // textBoxVerbrauch
            // 
            this.textBoxVerbrauch.Location = new System.Drawing.Point(139, 53);
            this.textBoxVerbrauch.Name = "textBoxVerbrauch";
            this.textBoxVerbrauch.Size = new System.Drawing.Size(112, 20);
            this.textBoxVerbrauch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hinweis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Verbrauch: kcal je 15 Minuten";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(15, 169);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(84, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_abbrechen
            // 
            this.btn_abbrechen.Location = new System.Drawing.Point(154, 169);
            this.btn_abbrechen.Name = "btn_abbrechen";
            this.btn_abbrechen.Size = new System.Drawing.Size(97, 23);
            this.btn_abbrechen.TabIndex = 7;
            this.btn_abbrechen.Text = "Abbrechen";
            this.btn_abbrechen.UseVisualStyleBackColor = true;
            this.btn_abbrechen.Click += new System.EventHandler(this.btn_abbrechen_Click);
            // 
            // FormSportart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 223);
            this.Controls.Add(this.btn_abbrechen);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVerbrauch);
            this.Controls.Add(this.textBoxSportart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(293, 262);
            this.MinimumSize = new System.Drawing.Size(293, 262);
            this.Name = "FormSportart";
            this.Text = "Sportart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSportart;
        private System.Windows.Forms.TextBox textBoxVerbrauch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_abbrechen;
    }
}