namespace ReliefGoodsTrackingDesign_Apostol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.txtCenterName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblOfficer = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtOfficer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpReceived = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBarangay = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtBarangay = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dgvReliefGoods = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReliefGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.txtOfficer);
            this.groupBox1.Controls.Add(this.txtCenterName);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.lblCenterName);
            this.groupBox1.Controls.Add(this.lblOfficer);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(31, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(412, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relief Center Information";
            // 
            // lblCenterName
            // 
            this.lblCenterName.AutoSize = true;
            this.lblCenterName.Location = new System.Drawing.Point(21, 31);
            this.lblCenterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.Size = new System.Drawing.Size(126, 19);
            this.lblCenterName.TabIndex = 1;
            this.lblCenterName.Text = "Relief Center Name";
            // 
            // txtCenterName
            // 
            this.txtCenterName.Location = new System.Drawing.Point(170, 28);
            this.txtCenterName.Name = "txtCenterName";
            this.txtCenterName.Size = new System.Drawing.Size(173, 25);
            this.txtCenterName.TabIndex = 1;
            this.txtCenterName.TextChanged += new System.EventHandler(this.txtCenterName_TextChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(21, 70);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(61, 19);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // lblOfficer
            // 
            this.lblOfficer.AutoSize = true;
            this.lblOfficer.Location = new System.Drawing.Point(21, 107);
            this.lblOfficer.Name = "lblOfficer";
            this.lblOfficer.Size = new System.Drawing.Size(116, 19);
            this.lblOfficer.TabIndex = 2;
            this.lblOfficer.Text = "Officer-in-Charge";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(170, 67);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(173, 25);
            this.txtLocation.TabIndex = 3;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtOfficer_TextChanged);
            // 
            // txtOfficer
            // 
            this.txtOfficer.Location = new System.Drawing.Point(170, 104);
            this.txtOfficer.Name = "txtOfficer";
            this.txtOfficer.Size = new System.Drawing.Size(173, 25);
            this.txtOfficer.TabIndex = 4;
            this.txtOfficer.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.dtpReceived);
            this.groupBox2.Controls.Add(this.nudQuantity);
            this.groupBox2.Controls.Add(this.lblCategory);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.lblItemName);
            this.groupBox2.Controls.Add(this.cboCategory);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Location = new System.Drawing.Point(31, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Goods Inventory Entry";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(18, 36);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(97, 19);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Item Category";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(18, 71);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(77, 19);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "Item Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(18, 107);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 19);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(18, 148);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 19);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date Received";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Food Packs",
            "Drinking Water",
            "Medical Supplies",
            "Clothing",
            "Hygiene Kits"});
            this.cboCategory.Location = new System.Drawing.Point(170, 33);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(168, 25);
            this.cboCategory.TabIndex = 6;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(170, 68);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(168, 25);
            this.txtItemName.TabIndex = 7;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(170, 105);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(52, 25);
            this.nudQuantity.TabIndex = 8;
            // 
            // dtpReceived
            // 
            this.dtpReceived.Location = new System.Drawing.Point(170, 148);
            this.dtpReceived.Name = "dtpReceived";
            this.dtpReceived.Size = new System.Drawing.Size(220, 25);
            this.dtpReceived.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Wheat;
            this.groupBox3.Controls.Add(this.cboStatus);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.txtBarangay);
            this.groupBox3.Controls.Add(this.lblBarangay);
            this.groupBox3.Location = new System.Drawing.Point(31, 488);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 134);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distribution Status";
            // 
            // lblBarangay
            // 
            this.lblBarangay.AutoSize = true;
            this.lblBarangay.Location = new System.Drawing.Point(17, 37);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new System.Drawing.Size(140, 19);
            this.lblBarangay.TabIndex = 0;
            this.lblBarangay.Text = "Destination Barangay";
            this.lblBarangay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(123, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Distribution Status";
            // 
            // txtBarangay
            // 
            this.txtBarangay.Location = new System.Drawing.Point(170, 34);
            this.txtBarangay.Name = "txtBarangay";
            this.txtBarangay.Size = new System.Drawing.Size(173, 25);
            this.txtBarangay.TabIndex = 4;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "In Storage",
            "Ready for Distribution",
            "Distributed"});
            this.cboStatus.Location = new System.Drawing.Point(170, 75);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(173, 25);
            this.cboStatus.TabIndex = 6;
            // 
            // dgvReliefGoods
            // 
            this.dgvReliefGoods.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvReliefGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReliefGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvReliefGoods.Location = new System.Drawing.Point(484, 116);
            this.dgvReliefGoods.Name = "dgvReliefGoods";
            this.dgvReliefGoods.Size = new System.Drawing.Size(530, 472);
            this.dgvReliefGoods.TabIndex = 3;
            this.dgvReliefGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReliefGoods_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 655);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 53);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(393, 655);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 53);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(576, 655);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 53);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(766, 655);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 53);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(303, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Disaster Relief Goods Tracking System";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1040, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvReliefGoods);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Disaster Relief Goods Tracking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReliefGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.TextBox txtCenterName;
        private System.Windows.Forms.Label lblOfficer;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtOfficer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DateTimePicker dtpReceived;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBarangay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtBarangay;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DataGridView dgvReliefGoods;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
    }
}

