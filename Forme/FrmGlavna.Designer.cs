
namespace Forme
{
    partial class FrmGlavna
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
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.g1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosPrijaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPrijavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(134, 307);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.g1ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // g1ToolStripMenuItem
            // 
            this.g1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosPrijaveToolStripMenuItem,
            this.pregledPrijavaToolStripMenuItem,
            this.izmenaKorisnikaToolStripMenuItem});
            this.g1ToolStripMenuItem.Name = "g1ToolStripMenuItem";
            this.g1ToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.g1ToolStripMenuItem.Text = "G1";
            // 
            // unosPrijaveToolStripMenuItem
            // 
            this.unosPrijaveToolStripMenuItem.Name = "unosPrijaveToolStripMenuItem";
            this.unosPrijaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unosPrijaveToolStripMenuItem.Text = "Unos prijave";
            this.unosPrijaveToolStripMenuItem.Click += new System.EventHandler(this.unosPrijaveToolStripMenuItem_Click);
            // 
            // pregledPrijavaToolStripMenuItem
            // 
            this.pregledPrijavaToolStripMenuItem.Name = "pregledPrijavaToolStripMenuItem";
            this.pregledPrijavaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledPrijavaToolStripMenuItem.Text = "Pregled prijava";
            this.pregledPrijavaToolStripMenuItem.Click += new System.EventHandler(this.pregledPrijavaToolStripMenuItem_Click);
            // 
            // izmenaKorisnikaToolStripMenuItem
            // 
            this.izmenaKorisnikaToolStripMenuItem.Name = "izmenaKorisnikaToolStripMenuItem";
            this.izmenaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmenaKorisnikaToolStripMenuItem.Text = "Izmena korisnika";
            this.izmenaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.izmenaKorisnikaToolStripMenuItem_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem g1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosPrijaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPrijavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaKorisnikaToolStripMenuItem;
    }
}