namespace projektPI
{
    partial class unosIgraca
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledIgraca = new projektPI.pregledIgraca();
            this.label1 = new System.Windows.Forms.Label();
            this.prezimeIgraca = new System.Windows.Forms.TextBox();
            this.imeIgraca = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblImeIgraca = new System.Windows.Forms.Label();
            this.statusIgraca = new System.Windows.Forms.ComboBox();
            this.lblStatusIgraca = new System.Windows.Forms.Label();
            this.btnUnesiIgraca = new System.Windows.Forms.Button();
            this.dobIgraca = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.igracTableAdapter = new projektPI.pregledIgracaTableAdapters.igracTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledIgraca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(105, 23);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataMember = "igrac";
            this.igracBindingSource.DataSource = this.pregledIgraca;
            // 
            // pregledIgraca
            // 
            this.pregledIgraca.DataSetName = "pregledIgraca";
            this.pregledIgraca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pregled igrača";
            // 
            // prezimeIgraca
            // 
            this.prezimeIgraca.Location = new System.Drawing.Point(119, 57);
            this.prezimeIgraca.Name = "prezimeIgraca";
            this.prezimeIgraca.Size = new System.Drawing.Size(134, 20);
            this.prezimeIgraca.TabIndex = 7;
            // 
            // imeIgraca
            // 
            this.imeIgraca.Location = new System.Drawing.Point(119, 21);
            this.imeIgraca.Name = "imeIgraca";
            this.imeIgraca.Size = new System.Drawing.Size(134, 20);
            this.imeIgraca.TabIndex = 6;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(25, 57);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblImeIgraca
            // 
            this.lblImeIgraca.AutoSize = true;
            this.lblImeIgraca.Location = new System.Drawing.Point(25, 18);
            this.lblImeIgraca.Name = "lblImeIgraca";
            this.lblImeIgraca.Size = new System.Drawing.Size(24, 13);
            this.lblImeIgraca.TabIndex = 4;
            this.lblImeIgraca.Text = "Ime";
            // 
            // statusIgraca
            // 
            this.statusIgraca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusIgraca.FormattingEnabled = true;
            this.statusIgraca.Items.AddRange(new object[] {
            "Aktivan",
            "Ozlijeđen",
            "Neaktivan"});
            this.statusIgraca.Location = new System.Drawing.Point(119, 143);
            this.statusIgraca.Name = "statusIgraca";
            this.statusIgraca.Size = new System.Drawing.Size(134, 21);
            this.statusIgraca.TabIndex = 12;
            this.statusIgraca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblStatusIgraca
            // 
            this.lblStatusIgraca.AutoSize = true;
            this.lblStatusIgraca.Location = new System.Drawing.Point(25, 143);
            this.lblStatusIgraca.Name = "lblStatusIgraca";
            this.lblStatusIgraca.Size = new System.Drawing.Size(69, 13);
            this.lblStatusIgraca.TabIndex = 11;
            this.lblStatusIgraca.Text = "Status igrača";
            // 
            // btnUnesiIgraca
            // 
            this.btnUnesiIgraca.Location = new System.Drawing.Point(28, 207);
            this.btnUnesiIgraca.Name = "btnUnesiIgraca";
            this.btnUnesiIgraca.Size = new System.Drawing.Size(225, 37);
            this.btnUnesiIgraca.TabIndex = 8;
            this.btnUnesiIgraca.Text = "Unesi igrača";
            this.btnUnesiIgraca.UseVisualStyleBackColor = true;
            this.btnUnesiIgraca.Click += new System.EventHandler(this.btnUnesiIgraca_Click);
            // 
            // dobIgraca
            // 
            this.dobIgraca.Location = new System.Drawing.Point(119, 98);
            this.dobIgraca.Name = "dobIgraca";
            this.dobIgraca.Size = new System.Drawing.Size(134, 20);
            this.dobIgraca.TabIndex = 10;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(25, 101);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(27, 13);
            this.lblDob.TabIndex = 9;
            this.lblDob.Text = "Dob";
            // 
            // igracTableAdapter
            // 
            this.igracTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Obriši igrača";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Izmjeni";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // unosIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusIgraca);
            this.Controls.Add(this.lblStatusIgraca);
            this.Controls.Add(this.btnUnesiIgraca);
            this.Controls.Add(this.dobIgraca);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.prezimeIgraca);
            this.Controls.Add(this.imeIgraca);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblImeIgraca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "unosIgraca";
            this.Text = "unosIgraca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.unosIgraca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledIgraca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prezimeIgraca;
        private System.Windows.Forms.TextBox imeIgraca;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblImeIgraca;
        private System.Windows.Forms.ComboBox statusIgraca;
        private System.Windows.Forms.Label lblStatusIgraca;
        private System.Windows.Forms.Button btnUnesiIgraca;
        private System.Windows.Forms.TextBox dobIgraca;
        private System.Windows.Forms.Label lblDob;
        private pregledIgraca pregledIgraca;
        private System.Windows.Forms.BindingSource igracBindingSource;
        private pregledIgracaTableAdapters.igracTableAdapter igracTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}