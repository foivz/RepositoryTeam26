namespace projektPI
{
    partial class Login
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
            this.prijava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.korIme = new System.Windows.Forms.TextBox();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prijava
            // 
            this.prijava.Location = new System.Drawing.Point(262, 205);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(163, 32);
            this.prijava.TabIndex = 0;
            this.prijava.Text = "Prijavi se";
            this.prijava.UseVisualStyleBackColor = true;
            this.prijava.Click += new System.EventHandler(this.prijava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka";
            // 
            // korIme
            // 
            this.korIme.Location = new System.Drawing.Point(262, 84);
            this.korIme.Name = "korIme";
            this.korIme.Size = new System.Drawing.Size(163, 20);
            this.korIme.TabIndex = 3;
            // 
            // lozinka
            // 
            this.lozinka.Location = new System.Drawing.Point(262, 125);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(163, 20);
            this.lozinka.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 262);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prijava);
            this.Name = "Login";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korIme;
        private System.Windows.Forms.TextBox lozinka;
    }
}