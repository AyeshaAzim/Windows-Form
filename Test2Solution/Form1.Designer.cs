
namespace Test2Solution
{
    partial class frmPeople
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.radAndroid = new System.Windows.Forms.RadioButton();
            this.radApple = new System.Windows.Forms.RadioButton();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbPeople = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.lblVisiblePeople = new System.Windows.Forms.Label();
            this.lblTotalPeople = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radShowAndroidUsers = new System.Windows.Forms.RadioButton();
            this.radShowAppleUsers = new System.Windows.Forms.RadioButton();
            this.radShowAllUsers = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.gbPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPerson
            // 
            this.gbPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPerson.Controls.Add(this.btnAdd);
            this.gbPerson.Controls.Add(this.btnClear);
            this.gbPerson.Controls.Add(this.radAndroid);
            this.gbPerson.Controls.Add(this.radApple);
            this.gbPerson.Controls.Add(this.numAge);
            this.gbPerson.Controls.Add(this.txtLastName);
            this.gbPerson.Controls.Add(this.txtFirstName);
            this.gbPerson.Controls.Add(this.lblMobile);
            this.gbPerson.Controls.Add(this.lblAge);
            this.gbPerson.Controls.Add(this.lblLastName);
            this.gbPerson.Controls.Add(this.lblFirstName);
            this.gbPerson.Location = new System.Drawing.Point(21, 29);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(613, 237);
            this.gbPerson.TabIndex = 0;
            this.gbPerson.TabStop = false;
            this.gbPerson.Text = "Person";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(488, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(388, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radAndroid
            // 
            this.radAndroid.AutoSize = true;
            this.radAndroid.Location = new System.Drawing.Point(233, 148);
            this.radAndroid.Name = "radAndroid";
            this.radAndroid.Size = new System.Drawing.Size(84, 24);
            this.radAndroid.TabIndex = 8;
            this.radAndroid.TabStop = true;
            this.radAndroid.Text = "Android";
            this.radAndroid.UseVisualStyleBackColor = true;
            // 
            // radApple
            // 
            this.radApple.AutoSize = true;
            this.radApple.Location = new System.Drawing.Point(107, 146);
            this.radApple.Name = "radApple";
            this.radApple.Size = new System.Drawing.Size(70, 24);
            this.radApple.TabIndex = 7;
            this.radApple.TabStop = true;
            this.radApple.Text = "Apple";
            this.radApple.UseVisualStyleBackColor = true;
            // 
            // numAge
            // 
            this.numAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAge.Location = new System.Drawing.Point(107, 112);
            this.numAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(475, 27);
            this.numAge.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(107, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(475, 27);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(107, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(475, 27);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(21, 148);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(56, 20);
            this.lblMobile.TabIndex = 3;
            this.lblMobile.Text = "Mobile";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 112);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(21, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 38);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // gbPeople
            // 
            this.gbPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPeople.Controls.Add(this.btnDeleteAll);
            this.gbPeople.Controls.Add(this.lblVisiblePeople);
            this.gbPeople.Controls.Add(this.lblTotalPeople);
            this.gbPeople.Controls.Add(this.dgvPeople);
            this.gbPeople.Controls.Add(this.radShowAndroidUsers);
            this.gbPeople.Controls.Add(this.radShowAppleUsers);
            this.gbPeople.Controls.Add(this.radShowAllUsers);
            this.gbPeople.Location = new System.Drawing.Point(21, 287);
            this.gbPeople.Name = "gbPeople";
            this.gbPeople.Size = new System.Drawing.Size(613, 381);
            this.gbPeople.TabIndex = 1;
            this.gbPeople.TabStop = false;
            this.gbPeople.Text = "People";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.Location = new System.Drawing.Point(488, 340);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteAll.TabIndex = 6;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // lblVisiblePeople
            // 
            this.lblVisiblePeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVisiblePeople.AutoSize = true;
            this.lblVisiblePeople.Location = new System.Drawing.Point(140, 341);
            this.lblVisiblePeople.Name = "lblVisiblePeople";
            this.lblVisiblePeople.Size = new System.Drawing.Size(102, 20);
            this.lblVisiblePeople.TabIndex = 5;
            this.lblVisiblePeople.Text = "Visible People";
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPeople.AutoSize = true;
            this.lblTotalPeople.Location = new System.Drawing.Point(21, 341);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(94, 20);
            this.lblTotalPeople.TabIndex = 4;
            this.lblTotalPeople.Text = "Total People:";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colAge,
            this.colMobileType});
            this.dgvPeople.Location = new System.Drawing.Point(21, 83);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowHeadersWidth = 51;
            this.dgvPeople.RowTemplate.Height = 29;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(561, 251);
            this.dgvPeople.TabIndex = 3;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.MinimumWidth = 6;
            this.colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            // 
            // colMobileType
            // 
            this.colMobileType.HeaderText = "Mobile Type";
            this.colMobileType.MinimumWidth = 6;
            this.colMobileType.Name = "colMobileType";
            // 
            // radShowAndroidUsers
            // 
            this.radShowAndroidUsers.AutoSize = true;
            this.radShowAndroidUsers.Location = new System.Drawing.Point(349, 39);
            this.radShowAndroidUsers.Name = "radShowAndroidUsers";
            this.radShowAndroidUsers.Size = new System.Drawing.Size(193, 24);
            this.radShowAndroidUsers.TabIndex = 2;
            this.radShowAndroidUsers.TabStop = true;
            this.radShowAndroidUsers.Text = "Only show Android users";
            this.radShowAndroidUsers.UseVisualStyleBackColor = true;
            this.radShowAndroidUsers.CheckedChanged += new System.EventHandler(this.radShowAndroidUsers_CheckedChanged);
            // 
            // radShowAppleUsers
            // 
            this.radShowAppleUsers.AutoSize = true;
            this.radShowAppleUsers.Location = new System.Drawing.Point(149, 39);
            this.radShowAppleUsers.Name = "radShowAppleUsers";
            this.radShowAppleUsers.Size = new System.Drawing.Size(179, 24);
            this.radShowAppleUsers.TabIndex = 1;
            this.radShowAppleUsers.TabStop = true;
            this.radShowAppleUsers.Text = "Only show Apple users";
            this.radShowAppleUsers.UseVisualStyleBackColor = true;
            this.radShowAppleUsers.CheckedChanged += new System.EventHandler(this.radShowAppleUsers_CheckedChanged);
            // 
            // radShowAllUsers
            // 
            this.radShowAllUsers.AutoSize = true;
            this.radShowAllUsers.Location = new System.Drawing.Point(20, 39);
            this.radShowAllUsers.Name = "radShowAllUsers";
            this.radShowAllUsers.Size = new System.Drawing.Size(123, 24);
            this.radShowAllUsers.TabIndex = 0;
            this.radShowAllUsers.TabStop = true;
            this.radShowAllUsers.Text = "Show all users";
            this.radShowAllUsers.UseVisualStyleBackColor = true;
            this.radShowAllUsers.CheckedChanged += new System.EventHandler(this.radShowAllUsers_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(509, 675);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 738);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbPeople);
            this.Controls.Add(this.gbPerson);
            this.Name = "frmPeople";
            this.Text = "People";
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.gbPeople.ResumeLayout(false);
            this.gbPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radAndroid;
        private System.Windows.Forms.RadioButton radApple;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbPeople;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobileType;
        private System.Windows.Forms.RadioButton radShowAndroidUsers;
        private System.Windows.Forms.RadioButton radShowAppleUsers;
        private System.Windows.Forms.RadioButton radShowAllUsers;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label lblVisiblePeople;
        private System.Windows.Forms.Label lblTotalPeople;
        private System.Windows.Forms.Button btnClose;
    }
}

