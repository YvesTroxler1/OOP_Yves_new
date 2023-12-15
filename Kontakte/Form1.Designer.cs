namespace Kontakte
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
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonImportcsv = new System.Windows.Forms.Button();
            this.buttonExportcsv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.textBoxContactEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxContactPhone = new System.Windows.Forms.TextBox();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.dataGridViewKontakte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(73, 42);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(217, 75);
            this.buttonClearList.TabIndex = 0;
            this.buttonClearList.Text = "Liste löschen";
            this.buttonClearList.UseVisualStyleBackColor = true;
            // 
            // buttonImportcsv
            // 
            this.buttonImportcsv.Location = new System.Drawing.Point(1029, 42);
            this.buttonImportcsv.Name = "buttonImportcsv";
            this.buttonImportcsv.Size = new System.Drawing.Size(224, 75);
            this.buttonImportcsv.TabIndex = 1;
            this.buttonImportcsv.Text = "Import csv";
            this.buttonImportcsv.UseVisualStyleBackColor = true;
            // 
            // buttonExportcsv
            // 
            this.buttonExportcsv.Location = new System.Drawing.Point(1295, 43);
            this.buttonExportcsv.Name = "buttonExportcsv";
            this.buttonExportcsv.Size = new System.Drawing.Size(224, 74);
            this.buttonExportcsv.TabIndex = 2;
            this.buttonExportcsv.Text = "Export csv";
            this.buttonExportcsv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(73, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Neuer Kontakt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 750);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 798);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail:";
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.Location = new System.Drawing.Point(321, 744);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(892, 31);
            this.textBoxContactName.TabIndex = 7;
            this.textBoxContactName.TextChanged += new System.EventHandler(this.textBoxContactName_TextChanged);
            // 
            // textBoxContactEmail
            // 
            this.textBoxContactEmail.Location = new System.Drawing.Point(321, 792);
            this.textBoxContactEmail.Name = "textBoxContactEmail";
            this.textBoxContactEmail.Size = new System.Drawing.Size(892, 31);
            this.textBoxContactEmail.TabIndex = 8;
            this.textBoxContactEmail.TextChanged += new System.EventHandler(this.textBoxContactEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 848);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // textBoxContactPhone
            // 
            this.textBoxContactPhone.Location = new System.Drawing.Point(321, 842);
            this.textBoxContactPhone.Name = "textBoxContactPhone";
            this.textBoxContactPhone.Size = new System.Drawing.Size(892, 31);
            this.textBoxContactPhone.TabIndex = 10;
            this.textBoxContactPhone.TextChanged += new System.EventHandler(this.textBoxContactPhone_TextChanged);
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(1137, 904);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(382, 78);
            this.buttonAddContact.TabIndex = 11;
            this.buttonAddContact.Text = "Hinzufügen";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKontakte
            // 
            this.dataGridViewKontakte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontakte.Location = new System.Drawing.Point(73, 212);
            this.dataGridViewKontakte.Name = "dataGridViewKontakte";
            this.dataGridViewKontakte.RowHeadersWidth = 82;
            this.dataGridViewKontakte.RowTemplate.Height = 33;
            this.dataGridViewKontakte.Size = new System.Drawing.Size(1446, 511);
            this.dataGridViewKontakte.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 1006);
            this.Controls.Add(this.dataGridViewKontakte);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.textBoxContactPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxContactEmail);
            this.Controls.Add(this.textBoxContactName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExportcsv);
            this.Controls.Add(this.buttonImportcsv);
            this.Controls.Add(this.buttonClearList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontakte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonImportcsv;
        private System.Windows.Forms.Button buttonExportcsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.TextBox textBoxContactEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxContactPhone;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.DataGridView dataGridViewKontakte;
    }
}

