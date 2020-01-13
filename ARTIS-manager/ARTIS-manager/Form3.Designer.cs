namespace ARTIS_manager
{
    partial class User_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_page));
            this.UserList = new System.Windows.Forms.DataGridView();
            this.right_click = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sunsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usrname_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fName_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lName_box = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alert2 = new System.Windows.Forms.Label();
            this.err2 = new System.Windows.Forms.Label();
            this.err1 = new System.Windows.Forms.Label();
            this.alert1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
            this.right_click.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.AutoGenerateColumns = false;
            this.UserList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.UserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.FullName});
            this.UserList.ContextMenuStrip = this.right_click;
            this.UserList.DataSource = this.userBindingSource;
            this.UserList.Location = new System.Drawing.Point(31, 80);
            this.UserList.Name = "UserList";
            this.UserList.RowHeadersVisible = false;
            this.UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserList.Size = new System.Drawing.Size(307, 318);
            this.UserList.TabIndex = 0;
            this.UserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserList_CellDoubleClick);
            this.UserList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserList_CellMouseDown);
            this.UserList.SelectionChanged += new System.EventHandler(this.UserList_SelectionChanged);
            // 
            // right_click
            // 
            this.right_click.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sunsetToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.right_click.Name = "right_click";
            this.right_click.Size = new System.Drawing.Size(128, 70);
            // 
            // sunsetToolStripMenuItem
            // 
            this.sunsetToolStripMenuItem.Name = "sunsetToolStripMenuItem";
            this.sunsetToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sunsetToolStripMenuItem.Text = "Sunset";
            this.sunsetToolStripMenuItem.Click += new System.EventHandler(this.sunsetToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ARTIS_manager.ARTISref.User);
            // 
            // usrname_box
            // 
            this.usrname_box.Location = new System.Drawing.Point(114, 48);
            this.usrname_box.Name = "usrname_box";
            this.usrname_box.Size = new System.Drawing.Size(108, 20);
            this.usrname_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // fName_box
            // 
            this.fName_box.Location = new System.Drawing.Point(114, 74);
            this.fName_box.Name = "fName_box";
            this.fName_box.Size = new System.Drawing.Size(108, 20);
            this.fName_box.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // lName_box
            // 
            this.lName_box.Location = new System.Drawing.Point(114, 100);
            this.lName_box.Name = "lName_box";
            this.lName_box.Size = new System.Drawing.Size(108, 20);
            this.lName_box.TabIndex = 3;
            // 
            // add_button
            // 
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.add_button.Location = new System.Drawing.Point(0, 72);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(156, 113);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.delete_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.delete_button.Location = new System.Drawing.Point(0, 218);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(156, 113);
            this.delete_button.TabIndex = 10;
            this.delete_button.TabStop = false;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.alert2);
            this.panel1.Controls.Add(this.err2);
            this.panel1.Controls.Add(this.err1);
            this.panel1.Controls.Add(this.alert1);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(644, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 450);
            this.panel1.TabIndex = 13;
            // 
            // alert2
            // 
            this.alert2.AutoSize = true;
            this.alert2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.alert2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.alert2.Location = new System.Drawing.Point(48, 295);
            this.alert2.Name = "alert2";
            this.alert2.Size = new System.Drawing.Size(57, 17);
            this.alert2.TabIndex = 30;
            this.alert2.Text = "Success";
            this.alert2.Visible = false;
            // 
            // err2
            // 
            this.err2.AutoSize = true;
            this.err2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.err2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.err2.Location = new System.Drawing.Point(48, 295);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(53, 17);
            this.err2.TabIndex = 32;
            this.err2.Text = "ERROR";
            this.err2.Visible = false;
            // 
            // err1
            // 
            this.err1.AutoSize = true;
            this.err1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.err1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.err1.Location = new System.Drawing.Point(48, 143);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(53, 17);
            this.err1.TabIndex = 33;
            this.err1.Text = "ERROR";
            this.err1.Visible = false;
            // 
            // alert1
            // 
            this.alert1.AutoSize = true;
            this.alert1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.alert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.alert1.Location = new System.Drawing.Point(48, 143);
            this.alert1.Name = "alert1";
            this.alert1.Size = new System.Drawing.Size(57, 17);
            this.alert1.TabIndex = 30;
            this.alert1.Text = "Success";
            this.alert1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "ADMIN FUNCTIONS";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lName_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fName_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usrname_box);
            this.groupBox1.Location = new System.Drawing.Point(357, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Info";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 170;
            // 
            // User_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_page";
            this.Text = "ADMINS Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_page_FormClosing);
            this.Load += new System.EventHandler(this.User_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).EndInit();
            this.right_click.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserList;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox usrname_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fName_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lName_box;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip right_click;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sunsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label alert2;
        private System.Windows.Forms.Label alert1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label err2;
        private System.Windows.Forms.Label err1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}