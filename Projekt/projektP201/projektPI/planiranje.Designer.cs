namespace projektPI
{
    partial class planiranje
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
            this.label1 = new System.Windows.Forms.Label();
            this.pickVrijeme = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.komentar = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.ComboBox();
            this.unosDogadaja = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum i vrijeme :";
            // 
            // pickVrijeme
            // 
            this.pickVrijeme.Location = new System.Drawing.Point(147, 53);
            this.pickVrijeme.Name = "pickVrijeme";
            this.pickVrijeme.Size = new System.Drawing.Size(200, 20);
            this.pickVrijeme.TabIndex = 1;
            this.pickVrijeme.ValueChanged += new System.EventHandler(this.pickVrijeme_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Komentar :";
            // 
            // komentar
            // 
            this.komentar.Location = new System.Drawing.Point(147, 95);
            this.komentar.Name = "komentar";
            this.komentar.Size = new System.Drawing.Size(200, 107);
            this.komentar.TabIndex = 4;
            this.komentar.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip događaja :";
            // 
            // tip
            // 
            this.tip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tip.FormattingEnabled = true;
            this.tip.Items.AddRange(new object[] {
            "Trening",
            "Utakmica",
            "Skupština"});
            this.tip.Location = new System.Drawing.Point(147, 232);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(200, 21);
            this.tip.TabIndex = 6;
            this.tip.SelectedIndexChanged += new System.EventHandler(this.tip_SelectedIndexChanged);
            // 
            // unosDogadaja
            // 
            this.unosDogadaja.Location = new System.Drawing.Point(147, 330);
            this.unosDogadaja.Name = "unosDogadaja";
            this.unosDogadaja.Size = new System.Drawing.Size(200, 44);
            this.unosDogadaja.TabIndex = 7;
            this.unosDogadaja.Text = "Unesi";
            this.unosDogadaja.UseVisualStyleBackColor = true;
            this.unosDogadaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(667, 200);
            this.dataGridView1.TabIndex = 8;
            // 
            // planiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.unosDogadaja);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.komentar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickVrijeme);
            this.Controls.Add(this.label1);
            this.Name = "planiranje";
            this.Text = "planiranjeTreninga";
            this.Load += new System.EventHandler(this.planiranje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker pickVrijeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox komentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tip;
        private System.Windows.Forms.Button unosDogadaja;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}