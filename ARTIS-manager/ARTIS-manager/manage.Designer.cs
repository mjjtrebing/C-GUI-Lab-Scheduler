namespace ARTIS_manager
{
    partial class manage_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage_form));
            this.manageList = new System.Windows.Forms.DataGridView();
            this.right_click = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sunsetUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusDropDown = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numDaysInactive = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.daysusedin90 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.err2 = new System.Windows.Forms.Label();
            this.alert2 = new System.Windows.Forms.Label();
            this.err1 = new System.Windows.Forms.Label();
            this.alert1 = new System.Windows.Forms.Label();
            this.sunset_retire_button = new System.Windows.Forms.Button();
            this.sunset = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysInactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.manageList)).BeginInit();
            this.right_click.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysInactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysusedin90)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // manageList
            // 
            this.manageList.AutoGenerateColumns = false;
            this.manageList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.manageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.FullName,
            this.Column1,
            this.Column2,
            this.DaysInactive,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.manageList.ContextMenuStrip = this.right_click;
            this.manageList.DataSource = this.resourceBindingSource;
            this.manageList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.manageList.Location = new System.Drawing.Point(12, 149);
            this.manageList.MultiSelect = false;
            this.manageList.Name = "manageList";
            this.manageList.ReadOnly = true;
            this.manageList.RowHeadersVisible = false;
            this.manageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manageList.Size = new System.Drawing.Size(1260, 437);
            this.manageList.TabIndex = 0;
            this.manageList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manageList_CellDoubleClick);
            this.manageList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.manageList_CellMouseDown);
            // 
            // right_click
            // 
            this.right_click.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sunsetUserToolStripMenuItem,
            this.activateUserToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.right_click.Name = "right_click";
            this.right_click.Size = new System.Drawing.Size(144, 70);
            // 
            // sunsetUserToolStripMenuItem
            // 
            this.sunsetUserToolStripMenuItem.Name = "sunsetUserToolStripMenuItem";
            this.sunsetUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sunsetUserToolStripMenuItem.Text = "Sunset User";
            this.sunsetUserToolStripMenuItem.Click += new System.EventHandler(this.sunsetUserToolStripMenuItem_Click);
            // 
            // activateUserToolStripMenuItem
            // 
            this.activateUserToolStripMenuItem.Name = "activateUserToolStripMenuItem";
            this.activateUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.activateUserToolStripMenuItem.Text = "Activate User";
            this.activateUserToolStripMenuItem.Click += new System.EventHandler(this.activateUserToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // resourceBindingSource
            // 
            this.resourceBindingSource.DataSource = typeof(ARTIS_manager.ARTISref.Resource);
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataSource = typeof(System.Data.DataTable);
            // 
            // typeDropDown
            // 
            this.typeDropDown.FormattingEnabled = true;
            this.typeDropDown.Location = new System.Drawing.Point(188, 100);
            this.typeDropDown.Name = "typeDropDown";
            this.typeDropDown.Size = new System.Drawing.Size(121, 21);
            this.typeDropDown.TabIndex = 2;
            this.typeDropDown.Text = "Student";
            this.typeDropDown.SelectedIndexChanged += new System.EventHandler(this.typeDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(113, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(379, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // statusDropDown
            // 
            this.statusDropDown.FormattingEnabled = true;
            this.statusDropDown.Location = new System.Drawing.Point(432, 100);
            this.statusDropDown.Name = "statusDropDown";
            this.statusDropDown.Size = new System.Drawing.Size(121, 21);
            this.statusDropDown.TabIndex = 3;
            this.statusDropDown.Text = "Active";
            this.statusDropDown.SelectedIndexChanged += new System.EventHandler(this.statusDropDown_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(535, 44);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(239, 20);
            this.search.TabIndex = 1;
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(405, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserName Search: ";
            // 
            // numDaysInactive
            // 
            this.numDaysInactive.Location = new System.Drawing.Point(746, 101);
            this.numDaysInactive.Name = "numDaysInactive";
            this.numDaysInactive.Size = new System.Drawing.Size(64, 20);
            this.numDaysInactive.TabIndex = 4;
            this.numDaysInactive.ValueChanged += new System.EventHandler(this.numDaysInactive_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label4.Location = new System.Drawing.Point(650, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Days Inactive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(838, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Days used in last 90 Days";
            // 
            // daysusedin90
            // 
            this.daysusedin90.Location = new System.Drawing.Point(1006, 101);
            this.daysusedin90.Name = "daysusedin90";
            this.daysusedin90.Size = new System.Drawing.Size(64, 20);
            this.daysusedin90.TabIndex = 5;
            this.daysusedin90.ValueChanged += new System.EventHandler(this.daysusedin90_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.err2);
            this.panel1.Controls.Add(this.alert2);
            this.panel1.Controls.Add(this.err1);
            this.panel1.Controls.Add(this.alert1);
            this.panel1.Controls.Add(this.sunset_retire_button);
            this.panel1.Controls.Add(this.sunset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1278, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 598);
            this.panel1.TabIndex = 12;
            // 
            // err2
            // 
            this.err2.AutoSize = true;
            this.err2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.err2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.err2.Location = new System.Drawing.Point(61, 413);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(53, 17);
            this.err2.TabIndex = 31;
            this.err2.Text = "ERROR";
            this.err2.Visible = false;
            // 
            // alert2
            // 
            this.alert2.AutoSize = true;
            this.alert2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.alert2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.alert2.Location = new System.Drawing.Point(61, 413);
            this.alert2.Name = "alert2";
            this.alert2.Size = new System.Drawing.Size(57, 17);
            this.alert2.TabIndex = 30;
            this.alert2.Text = "Success";
            this.alert2.Visible = false;
            // 
            // err1
            // 
            this.err1.AutoSize = true;
            this.err1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.err1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.err1.Location = new System.Drawing.Point(61, 233);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(53, 17);
            this.err1.TabIndex = 30;
            this.err1.Text = "ERROR";
            this.err1.Visible = false;
            // 
            // alert1
            // 
            this.alert1.AutoSize = true;
            this.alert1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.alert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.alert1.Location = new System.Drawing.Point(61, 233);
            this.alert1.Name = "alert1";
            this.alert1.Size = new System.Drawing.Size(57, 17);
            this.alert1.TabIndex = 29;
            this.alert1.Text = "Success";
            this.alert1.Visible = false;
            // 
            // sunset_retire_button
            // 
            this.sunset_retire_button.FlatAppearance.BorderSize = 0;
            this.sunset_retire_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunset_retire_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.sunset_retire_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.sunset_retire_button.Location = new System.Drawing.Point(3, 313);
            this.sunset_retire_button.Name = "sunset_retire_button";
            this.sunset_retire_button.Size = new System.Drawing.Size(178, 139);
            this.sunset_retire_button.TabIndex = 1;
            this.sunset_retire_button.TabStop = false;
            this.sunset_retire_button.Text = "Sunset Retired Users";
            this.sunset_retire_button.UseVisualStyleBackColor = true;
            this.sunset_retire_button.Click += new System.EventHandler(this.sunset_retire_button_Click);
            // 
            // sunset
            // 
            this.sunset.FlatAppearance.BorderSize = 0;
            this.sunset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunset.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.sunset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.sunset.Location = new System.Drawing.Point(0, 130);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(178, 139);
            this.sunset.TabIndex = 0;
            this.sunset.TabStop = false;
            this.sunset.Text = "Sunset Selected";
            this.sunset.UseVisualStyleBackColor = true;
            this.sunset.Click += new System.EventHandler(this.sunset_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ARTIS_manager.ARTISref.User);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.lbl.Location = new System.Drawing.Point(27, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(228, 35);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Manage Users";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // UserName
            // 
            this.UserName.ContextMenuStrip = this.right_click;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserType";
            this.Column1.HeaderText = "User Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Status";
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // DaysInactive
            // 
            this.DaysInactive.DataPropertyName = "DaysInactive";
            this.DaysInactive.HeaderText = "DaysInactive";
            this.DaysInactive.Name = "DaysInactive";
            this.DaysInactive.ReadOnly = true;
            this.DaysInactive.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UsesInLast90Days";
            this.Column3.HeaderText = "Uses In Last 90 Days";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UsesInLastYear";
            this.Column4.HeaderText = "Uses In Last Year";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AllUses";
            this.Column5.HeaderText = "All Uses";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CreateDate";
            this.Column6.HeaderText = "Create Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "EstSunsetDate";
            this.Column7.HeaderText = "Estimated Sunest Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SunsetDate";
            this.Column8.HeaderText = "Sunset Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Notes";
            this.Column9.HeaderText = "Notes";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 240;
            // 
            // manage_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(56)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1456, 598);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daysusedin90);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numDaysInactive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeDropDown);
            this.Controls.Add(this.manageList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "manage_form";
            this.Text = "Manage Users Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.manage_form_FormClosing);
            this.Load += new System.EventHandler(this.manage_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageList)).EndInit();
            this.right_click.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysInactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysusedin90)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView manageList;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource resourceBindingSource;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private System.Windows.Forms.ComboBox typeDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusDropDown;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDaysInactive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown daysusedin90;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sunset;
        private System.Windows.Forms.Button sunset_retire_button;
        private System.Windows.Forms.ContextMenuStrip right_click;
        private System.Windows.Forms.ToolStripMenuItem sunsetUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label alert1;
        private System.Windows.Forms.Label alert2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label err2;
        private System.Windows.Forms.Label err1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysInactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}