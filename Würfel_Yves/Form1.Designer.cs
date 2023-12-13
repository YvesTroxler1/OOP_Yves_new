namespace Würfel_Yves
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
            this.Werfen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LetzterWurfTextBox = new System.Windows.Forms.TextBox();
            this.aktuellerWurfTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Werfen
            // 
            this.Werfen.Location = new System.Drawing.Point(113, 68);
            this.Werfen.Name = "Werfen";
            this.Werfen.Size = new System.Drawing.Size(535, 253);
            this.Werfen.TabIndex = 0;
            this.Werfen.Text = "Würfel";
            this.Werfen.UseVisualStyleBackColor = true;
            this.Werfen.Click += new System.EventHandler(this.Werfen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = " Letzter Wurf: ";
            // 
            // LetzterWurfTextBox
            // 
            this.LetzterWurfTextBox.Location = new System.Drawing.Point(353, 510);
            this.LetzterWurfTextBox.Name = "LetzterWurfTextBox";
            this.LetzterWurfTextBox.Size = new System.Drawing.Size(229, 31);
            this.LetzterWurfTextBox.TabIndex = 2;
            // 
            // aktuellerWurfTextBox
            // 
            this.aktuellerWurfTextBox.Location = new System.Drawing.Point(1065, 179);
            this.aktuellerWurfTextBox.Name = "aktuellerWurfTextBox";
            this.aktuellerWurfTextBox.Size = new System.Drawing.Size(330, 31);
            this.aktuellerWurfTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 904);
            this.Controls.Add(this.aktuellerWurfTextBox);
            this.Controls.Add(this.LetzterWurfTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Werfen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Werfen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LetzterWurfTextBox;
        private System.Windows.Forms.TextBox aktuellerWurfTextBox;
    }
}

