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
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permission = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourMau)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTourMau
            // 
            this.dgvTourMau.AccessibleDescription = "cak";
            this.dgvTourMau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTourMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.Permission});
            this.dgvTourMau.Location = new System.Drawing.Point(221, 52);
            this.dgvTourMau.Name = "dgvTourMau";
            this.dgvTourMau.RowHeadersWidth = 51;
            this.dgvTourMau.RowTemplate.Height = 24;
            this.dgvTourMau.Size = new System.Drawing.Size(489, 268);
            this.dgvTourMau.TabIndex = 0;
            this.dgvTourMau.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTourMau_CellContentDoubleClick);
            this.dgvTourMau.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTourMau_RowEnter);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.FillWeight = 98.40819F;
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.FillWeight = 101.8212F;
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            // 
            // Permission
            // 
            this.Permission.DataPropertyName = "Permission";
            this.Permission.HeaderText = "Permission";
            this.Permission.MinimumWidth = 6;
            this.Permission.Name = "Permission";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(69, 52);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(69, 96);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 22);
            this.txtPass.TabIndex = 0;
            // 
            // txtPer
            // 
            this.txtPer.Location = new System.Drawing.Point(69, 146);
            this.txtPer.Name = "txtPer";
            this.txtPer.Size = new System.Drawing.Size(100, 22);
            this.txtPer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AccessibleDescription = "cak";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPer);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.dgvTourMau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourMau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTourMau;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Permission;
    }
}

