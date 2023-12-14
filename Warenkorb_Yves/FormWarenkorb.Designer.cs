namespace Warenkorb
{
    partial class FormWarenkorb
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
            this.components = new System.ComponentModel.Container();
            this.textBoxProdukte = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelSumme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxProdukte
            // 
            this.textBoxProdukte.Location = new System.Drawing.Point(87, 56);
            this.textBoxProdukte.Name = "textBoxProdukte";
            this.textBoxProdukte.Size = new System.Drawing.Size(624, 304);
            this.textBoxProdukte.TabIndex = 0;
            this.textBoxProdukte.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelSumme
            // 
            this.labelSumme.AutoSize = true;
            this.labelSumme.Location = new System.Drawing.Point(82, 391);
            this.labelSumme.Name = "labelSumme";
            this.labelSumme.Size = new System.Drawing.Size(70, 25);
            this.labelSumme.TabIndex = 2;
            this.labelSumme.Text = "label1";
            this.labelSumme.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormWarenkorb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSumme);
            this.Controls.Add(this.textBoxProdukte);
            this.Name = "FormWarenkorb";
            this.Text = "FormWarenkorb";
            this.Load += new System.EventHandler(this.FormWarenkorb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxProdukte;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelSumme;
    }
}