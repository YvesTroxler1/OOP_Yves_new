namespace Warenkorb
{
    partial class FormProduktliste
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
            this.linkLabelWarenkorb = new System.Windows.Forms.LinkLabel();
            this.comboBoxProdukt = new System.Windows.Forms.ComboBox();
            this.numericUpDown1Anzahl = new System.Windows.Forms.NumericUpDown();
            this.labelWarenkorbAnzahl = new System.Windows.Forms.Label();
            this.buttonHinzufugen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Anzahl)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelWarenkorb
            // 
            this.linkLabelWarenkorb.AutoSize = true;
            this.linkLabelWarenkorb.Location = new System.Drawing.Point(455, 58);
            this.linkLabelWarenkorb.Name = "linkLabelWarenkorb";
            this.linkLabelWarenkorb.Size = new System.Drawing.Size(211, 25);
            this.linkLabelWarenkorb.TabIndex = 0;
            this.linkLabelWarenkorb.TabStop = true;
            this.linkLabelWarenkorb.Text = "Warenkorb anzeigen";
            this.linkLabelWarenkorb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWarenkorb_LinkClicked_1);
            // 
            // comboBoxProdukt
            // 
            this.comboBoxProdukt.FormattingEnabled = true;
            this.comboBoxProdukt.Location = new System.Drawing.Point(247, 188);
            this.comboBoxProdukt.Name = "comboBoxProdukt";
            this.comboBoxProdukt.Size = new System.Drawing.Size(419, 33);
            this.comboBoxProdukt.TabIndex = 1;
            // 
            // numericUpDown1Anzahl
            // 
            this.numericUpDown1Anzahl.Location = new System.Drawing.Point(247, 250);
            this.numericUpDown1Anzahl.Name = "numericUpDown1Anzahl";
            this.numericUpDown1Anzahl.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1Anzahl.TabIndex = 2;
            // 
            // labelWarenkorbAnzahl
            // 
            this.labelWarenkorbAnzahl.AutoSize = true;
            this.labelWarenkorbAnzahl.Location = new System.Drawing.Point(321, 58);
            this.labelWarenkorbAnzahl.Name = "labelWarenkorbAnzahl";
            this.labelWarenkorbAnzahl.Size = new System.Drawing.Size(24, 25);
            this.labelWarenkorbAnzahl.TabIndex = 3;
            this.labelWarenkorbAnzahl.Text = "0";
            // 
            // buttonHinzufugen
            // 
            this.buttonHinzufugen.Location = new System.Drawing.Point(460, 250);
            this.buttonHinzufugen.Name = "buttonHinzufugen";
            this.buttonHinzufugen.Size = new System.Drawing.Size(206, 76);
            this.buttonHinzufugen.TabIndex = 4;
            this.buttonHinzufugen.Text = "Hinzufügem";
            this.buttonHinzufugen.UseVisualStyleBackColor = true;
            this.buttonHinzufugen.Click += new System.EventHandler(this.buttonHinzufugen_Click_1);
            // 
            // FormProduktliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHinzufugen);
            this.Controls.Add(this.labelWarenkorbAnzahl);
            this.Controls.Add(this.numericUpDown1Anzahl);
            this.Controls.Add(this.comboBoxProdukt);
            this.Controls.Add(this.linkLabelWarenkorb);
            this.Name = "FormProduktliste";
            this.Text = "FormProduktliste";
            this.Load += new System.EventHandler(this.FormProduktliste_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Anzahl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelWarenkorb;
        private System.Windows.Forms.ComboBox comboBoxProdukt;
        private System.Windows.Forms.NumericUpDown numericUpDown1Anzahl;
        private System.Windows.Forms.Label labelWarenkorbAnzahl;
        private System.Windows.Forms.Button buttonHinzufugen;
    }
}