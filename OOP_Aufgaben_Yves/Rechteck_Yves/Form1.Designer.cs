namespace RechteckBerechner
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBreite = new System.Windows.Forms.TextBox();
            this.textBoxHöhe = new System.Windows.Forms.TextBox();
            this.textBoxFläche = new System.Windows.Forms.TextBox();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breite des Rechtecks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Höhe des Rechtecks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ausgabe (Fläche)";
            // 
            // textBoxBreite
            // 
            this.textBoxBreite.Location = new System.Drawing.Point(487, 53);
            this.textBoxBreite.Name = "textBoxBreite";
            this.textBoxBreite.Size = new System.Drawing.Size(448, 31);
            this.textBoxBreite.TabIndex = 3;
            // 
            // textBoxHöhe
            // 
            this.textBoxHöhe.Location = new System.Drawing.Point(487, 156);
            this.textBoxHöhe.Name = "textBoxHöhe";
            this.textBoxHöhe.Size = new System.Drawing.Size(448, 31);
            this.textBoxHöhe.TabIndex = 4;
            // 
            // textBoxFläche
            // 
            this.textBoxFläche.Location = new System.Drawing.Point(487, 280);
            this.textBoxFläche.Name = "textBoxFläche";
            this.textBoxFläche.Size = new System.Drawing.Size(448, 31);
            this.textBoxFläche.TabIndex = 5;
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(1123, 53);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(375, 83);
            this.buttonBerechnen.TabIndex = 6;
            this.buttonBerechnen.Text = "Berechen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(1123, 280);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(385, 73);
            this.buttonBeenden.TabIndex = 7;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 784);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.textBoxFläche);
            this.Controls.Add(this.textBoxHöhe);
            this.Controls.Add(this.textBoxBreite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBreite;
        private System.Windows.Forms.TextBox textBoxHöhe;
        private System.Windows.Forms.TextBox textBoxFläche;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.Button buttonBeenden;
    }
}

