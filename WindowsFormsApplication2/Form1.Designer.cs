namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.rbLinija = new System.Windows.Forms.RadioButton();
            this.rbKruznica = new System.Windows.Forms.RadioButton();
            this.rbElipsa = new System.Windows.Forms.RadioButton();
            this.rbPravokutnik = new System.Windows.Forms.RadioButton();
            this.rbPoligon = new System.Windows.Forms.RadioButton();
            this.rbCrna = new System.Windows.Forms.RadioButton();
            this.rbCrvena = new System.Windows.Forms.RadioButton();
            this.rbPlava = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbLinija
            // 
            this.rbLinija.AutoSize = true;
            this.rbLinija.Location = new System.Drawing.Point(6, 19);
            this.rbLinija.Name = "rbLinija";
            this.rbLinija.Size = new System.Drawing.Size(49, 17);
            this.rbLinija.TabIndex = 0;
            this.rbLinija.TabStop = true;
            this.rbLinija.Text = "Linija";
            this.rbLinija.UseVisualStyleBackColor = true;
            // 
            // rbKruznica
            // 
            this.rbKruznica.AutoSize = true;
            this.rbKruznica.Location = new System.Drawing.Point(6, 42);
            this.rbKruznica.Name = "rbKruznica";
            this.rbKruznica.Size = new System.Drawing.Size(66, 17);
            this.rbKruznica.TabIndex = 1;
            this.rbKruznica.TabStop = true;
            this.rbKruznica.Text = "Kružnica";
            this.rbKruznica.UseVisualStyleBackColor = true;
            // 
            // rbElipsa
            // 
            this.rbElipsa.AutoSize = true;
            this.rbElipsa.Location = new System.Drawing.Point(6, 65);
            this.rbElipsa.Name = "rbElipsa";
            this.rbElipsa.Size = new System.Drawing.Size(53, 17);
            this.rbElipsa.TabIndex = 2;
            this.rbElipsa.TabStop = true;
            this.rbElipsa.Text = "Elipsa";
            this.rbElipsa.UseVisualStyleBackColor = true;
            // 
            // rbPravokutnik
            // 
            this.rbPravokutnik.AutoSize = true;
            this.rbPravokutnik.Location = new System.Drawing.Point(6, 88);
            this.rbPravokutnik.Name = "rbPravokutnik";
            this.rbPravokutnik.Size = new System.Drawing.Size(82, 17);
            this.rbPravokutnik.TabIndex = 3;
            this.rbPravokutnik.TabStop = true;
            this.rbPravokutnik.Text = "Pravokutnik";
            this.rbPravokutnik.UseVisualStyleBackColor = true;
            // 
            // rbPoligon
            // 
            this.rbPoligon.AutoSize = true;
            this.rbPoligon.Location = new System.Drawing.Point(6, 111);
            this.rbPoligon.Name = "rbPoligon";
            this.rbPoligon.Size = new System.Drawing.Size(60, 17);
            this.rbPoligon.TabIndex = 4;
            this.rbPoligon.TabStop = true;
            this.rbPoligon.Text = "Poligon";
            this.rbPoligon.UseVisualStyleBackColor = true;
            // 
            // rbCrna
            // 
            this.rbCrna.AutoSize = true;
            this.rbCrna.Checked = true;
            this.rbCrna.Location = new System.Drawing.Point(6, 19);
            this.rbCrna.Name = "rbCrna";
            this.rbCrna.Size = new System.Drawing.Size(47, 17);
            this.rbCrna.TabIndex = 5;
            this.rbCrna.TabStop = true;
            this.rbCrna.Text = "Crna";
            this.rbCrna.UseVisualStyleBackColor = true;
            this.rbCrna.CheckedChanged += new System.EventHandler(this.rbCrna_CheckedChanged);
            // 
            // rbCrvena
            // 
            this.rbCrvena.AutoSize = true;
            this.rbCrvena.Location = new System.Drawing.Point(6, 42);
            this.rbCrvena.Name = "rbCrvena";
            this.rbCrvena.Size = new System.Drawing.Size(59, 17);
            this.rbCrvena.TabIndex = 6;
            this.rbCrvena.Text = "Crvena";
            this.rbCrvena.UseVisualStyleBackColor = true;
            this.rbCrvena.CheckedChanged += new System.EventHandler(this.rbCrvena_CheckedChanged);
            // 
            // rbPlava
            // 
            this.rbPlava.AutoSize = true;
            this.rbPlava.Location = new System.Drawing.Point(6, 65);
            this.rbPlava.Name = "rbPlava";
            this.rbPlava.Size = new System.Drawing.Size(52, 17);
            this.rbPlava.TabIndex = 7;
            this.rbPlava.Text = "Plava";
            this.rbPlava.UseVisualStyleBackColor = true;
            this.rbPlava.CheckedChanged += new System.EventHandler(this.rbPlava_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 305);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLinija);
            this.groupBox1.Controls.Add(this.rbKruznica);
            this.groupBox1.Controls.Add(this.rbElipsa);
            this.groupBox1.Controls.Add(this.rbPravokutnik);
            this.groupBox1.Controls.Add(this.rbPoligon);
            this.groupBox1.Location = new System.Drawing.Point(323, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 138);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graf. oblik";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCrna);
            this.groupBox2.Controls.Add(this.rbCrvena);
            this.groupBox2.Controls.Add(this.rbPlava);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(323, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLinija;
        private System.Windows.Forms.RadioButton rbKruznica;
        private System.Windows.Forms.RadioButton rbElipsa;
        private System.Windows.Forms.RadioButton rbPravokutnik;
        private System.Windows.Forms.RadioButton rbPoligon;
        private System.Windows.Forms.RadioButton rbCrna;
        private System.Windows.Forms.RadioButton rbCrvena;
        private System.Windows.Forms.RadioButton rbPlava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

