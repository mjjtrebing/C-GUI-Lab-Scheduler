namespace ARTIS_manager
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.manage_button = new System.Windows.Forms.Button();
            this.users_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heavy_Use_List = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heavy_Use_List)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.admin_button);
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Controls.Add(this.manage_button);
            this.panel1.Controls.Add(this.users_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(785, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 552);
            this.panel1.TabIndex = 2;
            // 
            // admin_button
            // 
            this.admin_button.FlatAppearance.BorderSize = 0;
            this.admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_button.Location = new System.Drawing.Point(0, 267);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(200, 114);
            this.admin_button.TabIndex = 3;
            this.admin_button.TabStop = false;
            this.admin_button.Text = "ADMIN";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Location = new System.Drawing.Point(0, 387);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(200, 114);
            this.logout_button.TabIndex = 2;
            this.logout_button.TabStop = false;
            this.logout_button.Text = "LOGOUT";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // manage_button
            // 
            this.manage_button.FlatAppearance.BorderSize = 0;
            this.manage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage_button.Location = new System.Drawing.Point(3, 147);
            this.manage_button.Name = "manage_button";
            this.manage_button.Size = new System.Drawing.Size(200, 114);
            this.manage_button.TabIndex = 1;
            this.manage_button.TabStop = false;
            this.manage_button.Text = "MANAGE USERS";
            this.manage_button.UseVisualStyleBackColor = true;
            this.manage_button.Click += new System.EventHandler(this.manage_button_Click);
            // 
            // users_button
            // 
            this.users_button.FlatAppearance.BorderSize = 0;
            this.users_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_button.Location = new System.Drawing.Point(3, 27);
            this.users_button.Name = "users_button";
            this.users_button.Size = new System.Drawing.Size(200, 114);
            this.users_button.TabIndex = 0;
            this.users_button.TabStop = false;
            this.users_button.Text = "USER";
            this.users_button.UseVisualStyleBackColor = true;
            this.users_button.Click += new System.EventHandler(this.users_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 84);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataSource = typeof(System.Data.DataTable);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ARTIS_manager.ARTISref.User);
            // 
            // heavy_Use_List
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heavy_Use_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.heavy_Use_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.heavy_Use_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.heavy_Use_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.heavy_Use_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.heavy_Use_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.heavy_Use_List.Location = new System.Drawing.Point(103, 147);
            this.heavy_Use_List.Name = "heavy_Use_List";
            this.heavy_Use_List.RowHeadersVisible = false;
            this.heavy_Use_List.Size = new System.Drawing.Size(574, 217);
            this.heavy_Use_List.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "rName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Resource name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UsesInLast90Days";
            this.Column2.HeaderText = "Uses in Last 90 Days";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UsesInLastYear";
            this.Column3.HeaderText = "Uses in Last Year";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AllUses";
            this.Column4.HeaderText = "Total Uses";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(262, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ARTIS Lab Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(985, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heavy_Use_List);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Landing";
            this.Text = "Landing Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Landing_FormClosing);
            this.Load += new System.EventHandler(this.Landing_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heavy_Use_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button manage_button;
        private System.Windows.Forms.Button users_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private System.Windows.Forms.DataGridView heavy_Use_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
    }
}

