namespace Test1
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
            this.dgvTourMau = new System.Windows.Forms.DataGridView();
            this.maTourMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourMau)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTourMau
            // 
            this.dgvTourMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTourMau,
            this.tenTour});
            this.dgvTourMau.Location = new System.Drawing.Point(221, 52);
            this.dgvTourMau.Name = "dgvTourMau";
            this.dgvTourMau.RowHeadersWidth = 51;
            this.dgvTourMau.RowTemplate.Height = 24;
            this.dgvTourMau.Size = new System.Drawing.Size(395, 150);
            this.dgvTourMau.TabIndex = 0;
            // 
            // maTourMau
            // 
            this.maTourMau.DataPropertyName = "maTourMau";
            this.maTourMau.HeaderText = "Mã tour mẫu";
            this.maTourMau.MinimumWidth = 6;
            this.maTourMau.Name = "maTourMau";
            this.maTourMau.Width = 125;
            // 
            // tenTour
            // 
            this.tenTour.DataPropertyName = "tenTour";
            this.tenTour.HeaderText = "Tên tour mẫu";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTourMau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourMau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTourMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTourMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
    }
}

