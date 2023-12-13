using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechteck_Yves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        
        }

        

        

        private void buttonBeenden_Click(object sender, EventArgs e)
        {

        }

        private void breiteRechteck_TextChanged(object sender, EventArgs e)
        {

        }
        private void höherechteck_TextChanged(object sender, EventArgs e)
        {

        }

        private BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox breiteRechteck;
        private TextBox höherechteck;
        private TextBox AusgabeRechteck;
        private Button buttonBerechnen;
        private Button buttonBeenden;
        private Label labelrechteck;

        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.breiteRechteck = new System.Windows.Forms.TextBox();
            this.höherechteck = new System.Windows.Forms.TextBox();
            this.AusgabeRechteck = new System.Windows.Forms.TextBox();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.labelrechteck = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonBerechnenFläche = new System.Windows.Forms.Button();
            this.buttonBeendenProgramm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breite des Rechtecks";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // breiteRechteck
            // 
            this.breiteRechteck.Location = new System.Drawing.Point(521, 92);
            this.breiteRechteck.Name = "breiteRechteck";
            this.breiteRechteck.Size = new System.Drawing.Size(418, 31);
            this.breiteRechteck.TabIndex = 3;
            this.breiteRechteck.TextChanged += new System.EventHandler(this.breiteRechteck_TextChanged);
            // 
            // höherechteck
            // 
            this.höherechteck.Location = new System.Drawing.Point(521, 171);
            this.höherechteck.Name = "höherechteck";
            this.höherechteck.Size = new System.Drawing.Size(418, 31);
            this.höherechteck.TabIndex = 4;
            this.höherechteck.TextChanged += new System.EventHandler(this.höherechteck_TextChanged);
            // 
            // AusgabeRechteck
            // 
            this.AusgabeRechteck.Location = new System.Drawing.Point(521, 284);
            this.AusgabeRechteck.Name = "AusgabeRechteck";
            this.AusgabeRechteck.Size = new System.Drawing.Size(418, 31);
            this.AusgabeRechteck.TabIndex = 5;
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(1397, 64);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(303, 59);
            this.buttonBerechnen.TabIndex = 6;
            this.buttonBerechnen.Text = "berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(1397, 256);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(303, 59);
            this.buttonBeenden.TabIndex = 7;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // labelrechteck
            // 
            this.labelrechteck.AutoSize = true;
            this.labelrechteck.Location = new System.Drawing.Point(107, 78);
            this.labelrechteck.Name = "labelrechteck";
            this.labelrechteck.Size = new System.Drawing.Size(216, 25);
            this.labelrechteck.TabIndex = 0;
            this.labelrechteck.Text = "Breite des Rechtecks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Höhe des Rechtecks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ausgabe (Fläche)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 31);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(531, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(616, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(531, 419);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(616, 31);
            this.textBox3.TabIndex = 5;
            // 
            // buttonBerechnenFläche
            // 
            this.buttonBerechnenFläche.Location = new System.Drawing.Point(1385, 71);
            this.buttonBerechnenFläche.Name = "buttonBerechnenFläche";
            this.buttonBerechnenFläche.Size = new System.Drawing.Size(299, 85);
            this.buttonBerechnenFläche.TabIndex = 6;
            this.buttonBerechnenFläche.Text = "Berechnen";
            this.buttonBerechnenFläche.UseVisualStyleBackColor = true;
            this.buttonBerechnenFläche.Click += new System.EventHandler(this.buttonBerechnenFläche_Click);
            // 
            // buttonBeendenProgramm
            // 
            this.buttonBeendenProgramm.Location = new System.Drawing.Point(1385, 365);
            this.buttonBeendenProgramm.Name = "buttonBeendenProgramm";
            this.buttonBeendenProgramm.Size = new System.Drawing.Size(299, 85);
            this.buttonBeendenProgramm.TabIndex = 7;
            this.buttonBeendenProgramm.Text = "Beenden";
            this.buttonBeendenProgramm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(2140, 819);
            this.Controls.Add(this.buttonBeendenProgramm);
            this.Controls.Add(this.buttonBerechnenFläche);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelrechteck);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonBerechnenFläche;
        private Button buttonBeendenProgramm;

        private void buttonBeendenProgramm_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
