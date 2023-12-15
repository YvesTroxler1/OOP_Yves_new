namespace AutoSimolator
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
        /// Erforderliche Methode für die Designerunterstützung
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.textBoxGang = new System.Windows.Forms.TextBox();
            this.buttonBremse = new System.Windows.Forms.Button();
            this.buttonGas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAutos = new System.Windows.Forms.ComboBox();
            this.labelPS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxStartAuto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHupe = new System.Windows.Forms.PictureBox();
            this.pictureBoxTanken = new System.Windows.Forms.PictureBox();
            this.progressBarTank = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanken)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxTempo.ForeColor = System.Drawing.Color.Lime;
            this.textBoxTempo.Location = new System.Drawing.Point(223, 348);
            this.textBoxTempo.Multiline = true;
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(366, 85);
            this.textBoxTempo.TabIndex = 0;
            this.textBoxTempo.Text = "0";
            this.textBoxTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGang
            // 
            this.textBoxGang.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxGang.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxGang.ForeColor = System.Drawing.Color.Cyan;
            this.textBoxGang.Location = new System.Drawing.Point(631, 348);
            this.textBoxGang.Multiline = true;
            this.textBoxGang.Name = "textBoxGang";
            this.textBoxGang.Size = new System.Drawing.Size(148, 85);
            this.textBoxGang.TabIndex = 1;
            this.textBoxGang.Text = "0";
            this.textBoxGang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBremse
            // 
            this.buttonBremse.Location = new System.Drawing.Point(318, 550);
            this.buttonBremse.Name = "buttonBremse";
            this.buttonBremse.Size = new System.Drawing.Size(261, 327);
            this.buttonBremse.TabIndex = 3;
            this.buttonBremse.Text = "Bremse";
            this.buttonBremse.UseVisualStyleBackColor = true;
            // 
            // buttonGas
            // 
            this.buttonGas.Location = new System.Drawing.Point(631, 550);
            this.buttonGas.Name = "buttonGas";
            this.buttonGas.Size = new System.Drawing.Size(148, 327);
            this.buttonGas.TabIndex = 4;
            this.buttonGas.Text = "Gas";
            this.buttonGas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(169, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Auto wahlen:";
            // 
            // comboBoxAutos
            // 
            this.comboBoxAutos.FormattingEnabled = true;
            this.comboBoxAutos.Location = new System.Drawing.Point(417, 120);
            this.comboBoxAutos.Name = "comboBoxAutos";
            this.comboBoxAutos.Size = new System.Drawing.Size(300, 33);
            this.comboBoxAutos.TabIndex = 6;
            // 
            // labelPS
            // 
            this.labelPS.AutoSize = true;
            this.labelPS.Location = new System.Drawing.Point(795, 128);
            this.labelPS.Name = "labelPS";
            this.labelPS.Size = new System.Drawing.Size(0, 25);
            this.labelPS.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(223, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 40);
            this.panel1.TabIndex = 8;
            // 
            // pictureBoxStartAuto
            // 
            this.pictureBoxStartAuto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxStartAuto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStartAuto.Image")));
            this.pictureBoxStartAuto.InitialImage = global::Auto_Yves.Properties.Resources.OIP;
            this.pictureBoxStartAuto.Location = new System.Drawing.Point(68, 174);
            this.pictureBoxStartAuto.Name = "pictureBoxStartAuto";
            this.pictureBoxStartAuto.Size = new System.Drawing.Size(97, 80);
            this.pictureBoxStartAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStartAuto.TabIndex = 9;
            this.pictureBoxStartAuto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxHupe
            // 
            this.pictureBoxHupe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHupe.Image")));
            this.pictureBoxHupe.Location = new System.Drawing.Point(68, 280);
            this.pictureBoxHupe.Name = "pictureBoxHupe";
            this.pictureBoxHupe.Size = new System.Drawing.Size(97, 84);
            this.pictureBoxHupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHupe.TabIndex = 11;
            this.pictureBoxHupe.TabStop = false;
            this.pictureBoxHupe.Click += new System.EventHandler(this.pictureBoxHupe_Click);
            // 
            // pictureBoxTanken
            // 
            this.pictureBoxTanken.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTanken.Image")));
            this.pictureBoxTanken.Location = new System.Drawing.Point(68, 382);
            this.pictureBoxTanken.Name = "pictureBoxTanken";
            this.pictureBoxTanken.Size = new System.Drawing.Size(97, 84);
            this.pictureBoxTanken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTanken.TabIndex = 12;
            this.pictureBoxTanken.TabStop = false;
            // 
            // progressBarTank
            // 
            this.progressBarTank.ForeColor = System.Drawing.Color.Lime;
            this.progressBarTank.Location = new System.Drawing.Point(249, 472);
            this.progressBarTank.Name = "progressBarTank";
            this.progressBarTank.Size = new System.Drawing.Size(500, 43);
            this.progressBarTank.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 960);
            this.Controls.Add(this.progressBarTank);
            this.Controls.Add(this.pictureBoxTanken);
            this.Controls.Add(this.pictureBoxHupe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxStartAuto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPS);
            this.Controls.Add(this.comboBoxAutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGas);
            this.Controls.Add(this.buttonBremse);
            this.Controls.Add(this.textBoxGang);
            this.Controls.Add(this.textBoxTempo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.TextBox textBoxGang;
        private System.Windows.Forms.ProgressBar TankProgressBarUpdated;
        private System.Windows.Forms.Button buttonBremse;
        private System.Windows.Forms.Button buttonGas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAutos;
        private System.Windows.Forms.Label labelPS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxStartAuto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxHupe;
        private System.Windows.Forms.PictureBox pictureBoxTanken;
        private System.Windows.Forms.ProgressBar progressBarTank;
    }
}

