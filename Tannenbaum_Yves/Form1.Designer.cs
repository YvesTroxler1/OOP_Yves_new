namespace Tannenbaum_Yves
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
            this.textBoxStammBreite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStammHöhe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKronenHöhe = new System.Windows.Forms.TextBox();
            this.buttonTannenZeichnen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stammbreite";
            // 
            // textBoxStammBreite
            // 
            this.textBoxStammBreite.Location = new System.Drawing.Point(293, 87);
            this.textBoxStammBreite.Name = "textBoxStammBreite";
            this.textBoxStammBreite.Size = new System.Drawing.Size(406, 31);
            this.textBoxStammBreite.TabIndex = 1;
            this.textBoxStammBreite.TextChanged += new System.EventHandler(this.textBoxStammBreite_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stammhöhe";
            // 
            // textBoxStammHöhe
            // 
            this.textBoxStammHöhe.Location = new System.Drawing.Point(293, 169);
            this.textBoxStammHöhe.Name = "textBoxStammHöhe";
            this.textBoxStammHöhe.Size = new System.Drawing.Size(406, 31);
            this.textBoxStammHöhe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kronenhöhe";
            // 
            // textBoxKronenHöhe
            // 
            this.textBoxKronenHöhe.Location = new System.Drawing.Point(293, 261);
            this.textBoxKronenHöhe.Name = "textBoxKronenHöhe";
            this.textBoxKronenHöhe.Size = new System.Drawing.Size(406, 31);
            this.textBoxKronenHöhe.TabIndex = 5;
            // 
            // buttonTannenZeichnen
            // 
            this.buttonTannenZeichnen.Location = new System.Drawing.Point(823, 218);
            this.buttonTannenZeichnen.Name = "buttonTannenZeichnen";
            this.buttonTannenZeichnen.Size = new System.Drawing.Size(284, 74);
            this.buttonTannenZeichnen.TabIndex = 6;
            this.buttonTannenZeichnen.Text = "Tanne zeichnen";
            this.buttonTannenZeichnen.UseVisualStyleBackColor = true;
            this.buttonTannenZeichnen.Click += new System.EventHandler(this.buttonTannenZeichnen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(86, 364);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1021, 592);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 1094);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonTannenZeichnen);
            this.Controls.Add(this.textBoxKronenHöhe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStammHöhe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStammBreite);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStammBreite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStammHöhe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKronenHöhe;
        private System.Windows.Forms.Button buttonTannenZeichnen;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

