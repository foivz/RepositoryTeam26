namespace projektPI
{
    partial class Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.igračiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utakmiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planiranjeTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igračiToolStripMenuItem,
            this.timoviToolStripMenuItem,
            this.utakmiceToolStripMenuItem,
            this.planerToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // igračiToolStripMenuItem
            // 
            this.igračiToolStripMenuItem.Name = "igračiToolStripMenuItem";
            this.igračiToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.igračiToolStripMenuItem.Text = "Igrači";
            this.igračiToolStripMenuItem.Click += new System.EventHandler(this.igračiToolStripMenuItem_Click);
            // 
            // timoviToolStripMenuItem
            // 
            this.timoviToolStripMenuItem.Name = "timoviToolStripMenuItem";
            this.timoviToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.timoviToolStripMenuItem.Text = "Timovi";
            this.timoviToolStripMenuItem.Click += new System.EventHandler(this.timoviToolStripMenuItem_Click);
            // 
            // utakmiceToolStripMenuItem
            // 
            this.utakmiceToolStripMenuItem.Name = "utakmiceToolStripMenuItem";
            this.utakmiceToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utakmiceToolStripMenuItem.Text = "Utakmice";
            this.utakmiceToolStripMenuItem.Click += new System.EventHandler(this.utakmiceToolStripMenuItem_Click);
            // 
            // planerToolStripMenuItem
            // 
            this.planerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planiranjeTreningaToolStripMenuItem});
            this.planerToolStripMenuItem.Name = "planerToolStripMenuItem";
            this.planerToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.planerToolStripMenuItem.Text = "Planer";
            this.planerToolStripMenuItem.Click += new System.EventHandler(this.planerToolStripMenuItem_Click);
            // 
            // planiranjeTreningaToolStripMenuItem
            // 
            this.planiranjeTreningaToolStripMenuItem.Name = "planiranjeTreningaToolStripMenuItem";
            this.planiranjeTreningaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.planiranjeTreningaToolStripMenuItem.Text = "Planiranje treninga/skupština";
            this.planiranjeTreningaToolStripMenuItem.Click += new System.EventHandler(this.planiranjeTreningaToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 303);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem igračiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utakmiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planiranjeTreningaToolStripMenuItem;
    }
}