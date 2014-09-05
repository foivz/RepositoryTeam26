namespace projektPI
{
    partial class Utakmica
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboDomacin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGost = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboUtakmica = new System.Windows.Forms.ComboBox();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.zapisnik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboIgrac = new System.Windows.Forms.ComboBox();
            this.comboAkcija = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domaćin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboDomacin
            // 
            this.comboDomacin.FormattingEnabled = true;
            this.comboDomacin.Location = new System.Drawing.Point(110, 18);
            this.comboDomacin.Name = "comboDomacin";
            this.comboDomacin.Size = new System.Drawing.Size(121, 21);
            this.comboDomacin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gost";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboGost
            // 
            this.comboGost.FormattingEnabled = true;
            this.comboGost.Location = new System.Drawing.Point(307, 18);
            this.comboGost.Name = "comboGost";
            this.comboGost.Size = new System.Drawing.Size(121, 21);
            this.comboGost.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rezultat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tip utakmice";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboUtakmica
            // 
            this.comboUtakmica.FormattingEnabled = true;
            this.comboUtakmica.Location = new System.Drawing.Point(110, 63);
            this.comboUtakmica.Name = "comboUtakmica";
            this.comboUtakmica.Size = new System.Drawing.Size(121, 21);
            this.comboUtakmica.TabIndex = 6;
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(532, 19);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(100, 20);
            this.rezultat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum odigravanja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(375, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // zapisnik
            // 
            this.zapisnik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zapisnik.ContextMenuStrip = this.contextMenuStrip1;
            this.zapisnik.FullRowSelect = true;
            this.zapisnik.GridLines = true;
            this.zapisnik.Location = new System.Drawing.Point(375, 175);
            this.zapisnik.MultiSelect = false;
            this.zapisnik.Name = "zapisnik";
            this.zapisnik.Size = new System.Drawing.Size(331, 199);
            this.zapisnik.TabIndex = 10;
            this.zapisnik.UseCompatibleStateImageBehavior = false;
            this.zapisnik.View = System.Windows.Forms.View.Details;
            this.zapisnik.SelectedIndexChanged += new System.EventHandler(this.zapisnik_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prezime igrača";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Akcija";
            this.columnHeader2.Width = 149;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Zapisnik";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Prezime igrača";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Akcija";
            // 
            // comboIgrac
            // 
            this.comboIgrac.FormattingEnabled = true;
            this.comboIgrac.Location = new System.Drawing.Point(15, 175);
            this.comboIgrac.Name = "comboIgrac";
            this.comboIgrac.Size = new System.Drawing.Size(121, 21);
            this.comboIgrac.TabIndex = 14;
            // 
            // comboAkcija
            // 
            this.comboAkcija.FormattingEnabled = true;
            this.comboAkcija.Location = new System.Drawing.Point(174, 175);
            this.comboAkcija.Name = "comboAkcija";
            this.comboAkcija.Size = new System.Drawing.Size(121, 21);
            this.comboAkcija.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Dodaj u zapisnik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(331, 59);
            this.button4.TabIndex = 19;
            this.button4.Text = "Dodaj u arhivu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrišiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Obriši";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Utakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboAkcija);
            this.Controls.Add(this.comboIgrac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zapisnik);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.comboUtakmica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDomacin);
            this.Controls.Add(this.label1);
            this.Name = "Utakmica";
            this.Text = "Utakmica";
            this.Load += new System.EventHandler(this.Utakmica_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDomacin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboUtakmica;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView zapisnik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboIgrac;
        private System.Windows.Forms.ComboBox comboAkcija;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}