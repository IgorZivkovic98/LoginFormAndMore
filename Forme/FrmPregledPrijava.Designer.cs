
namespace Forme
{
    partial class FrmPregledPrijava
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
            this.dgvPregledPrijava = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledPrijava)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledPrijava
            // 
            this.dgvPregledPrijava.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledPrijava.Location = new System.Drawing.Point(12, 40);
            this.dgvPregledPrijava.Name = "dgvPregledPrijava";
            this.dgvPregledPrijava.RowHeadersWidth = 51;
            this.dgvPregledPrijava.Size = new System.Drawing.Size(776, 372);
            this.dgvPregledPrijava.TabIndex = 0;
            this.dgvPregledPrijava.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledPrijava_CellContentClick);
            // 
            // FrmPregledPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPregledPrijava);
            this.Name = "FrmPregledPrijava";
            this.Text = "FrmPregledPrijava";
            this.Load += new System.EventHandler(this.FrmPregledPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledPrijava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledPrijava;
    }
}