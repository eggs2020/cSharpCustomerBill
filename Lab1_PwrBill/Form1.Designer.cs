namespace Lab1_PwrBill
{
    partial class Form1
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
            this.txtOverallUsage = new System.Windows.Forms.TextBox();
            this.lblOverallUsage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblOffPeakUsage = new System.Windows.Forms.Label();
            this.txtOffPeakUsage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstCustData = new System.Windows.Forms.ListBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblAccNo = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustCount = new System.Windows.Forms.TextBox();
            this.txtTotalResidential = new System.Windows.Forms.TextBox();
            this.txtTotalCommercial = new System.Windows.Forms.TextBox();
            this.txtTotalIndustrial = new System.Windows.Forms.TextBox();
            this.txtTotalAllCharges = new System.Windows.Forms.TextBox();
            this.lblCustCount = new System.Windows.Forms.Label();
            this.lblTotalResidential = new System.Windows.Forms.Label();
            this.lblTotalCommercial = new System.Windows.Forms.Label();
            this.lblTotalIndsutrial = new System.Windows.Forms.Label();
            this.lblTotalAllCharges = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOverallUsage
            // 
            this.txtOverallUsage.Location = new System.Drawing.Point(27, 209);
            this.txtOverallUsage.Name = "txtOverallUsage";
            this.txtOverallUsage.Size = new System.Drawing.Size(154, 27);
            this.txtOverallUsage.TabIndex = 1;
            this.txtOverallUsage.Tag = "";
            // 
            // lblOverallUsage
            // 
            this.lblOverallUsage.AutoSize = true;
            this.lblOverallUsage.Location = new System.Drawing.Point(27, 186);
            this.lblOverallUsage.Name = "lblOverallUsage";
            this.lblOverallUsage.Size = new System.Drawing.Size(92, 20);
            this.lblOverallUsage.TabIndex = 8;
            this.lblOverallUsage.Text = "Overall kWh:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(232, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 45);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBill.Location = new System.Drawing.Point(408, 40);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(83, 20);
            this.lblBill.TabIndex = 11;
            this.lblBill.Text = "Power Bill:";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBill.Location = new System.Drawing.Point(408, 63);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(137, 27);
            this.txtBill.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(232, 266);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 45);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboCustomerType
            // 
            this.cboCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerType.FormattingEnabled = true;
            this.cboCustomerType.Location = new System.Drawing.Point(27, 62);
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.Size = new System.Drawing.Size(154, 28);
            this.cboCustomerType.Sorted = true;
            this.cboCustomerType.TabIndex = 2;
            this.cboCustomerType.SelectedIndexChanged += new System.EventHandler(this.cboCustomerType_SelectedIndexChanged);
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(27, 39);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(154, 20);
            this.lblCustomerType.TabIndex = 9;
            this.lblCustomerType.Text = "Select Customer Type:";
            // 
            // lblOffPeakUsage
            // 
            this.lblOffPeakUsage.AutoSize = true;
            this.lblOffPeakUsage.Location = new System.Drawing.Point(27, 260);
            this.lblOffPeakUsage.Name = "lblOffPeakUsage";
            this.lblOffPeakUsage.Size = new System.Drawing.Size(104, 20);
            this.lblOffPeakUsage.TabIndex = 10;
            this.lblOffPeakUsage.Text = "Off-peak kWh:";
            // 
            // txtOffPeakUsage
            // 
            this.txtOffPeakUsage.Location = new System.Drawing.Point(27, 284);
            this.txtOffPeakUsage.Name = "txtOffPeakUsage";
            this.txtOffPeakUsage.Size = new System.Drawing.Size(154, 27);
            this.txtOffPeakUsage.TabIndex = 3;
            this.txtOffPeakUsage.Tag = "Off-peak kWh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(220, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 121);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lstCustData
            // 
            this.lstCustData.FormattingEnabled = true;
            this.lstCustData.ItemHeight = 20;
            this.lstCustData.Location = new System.Drawing.Point(593, 39);
            this.lstCustData.Name = "lstCustData";
            this.lstCustData.Size = new System.Drawing.Size(336, 424);
            this.lstCustData.TabIndex = 6;
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(27, 359);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(154, 27);
            this.txtAccNo.TabIndex = 4;
            this.txtAccNo.Tag = "Account Number";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(27, 430);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(154, 27);
            this.txtCustName.TabIndex = 5;
            this.txtCustName.Tag = "Customer Name";
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = true;
            this.lblAccNo.Location = new System.Drawing.Point(27, 336);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Size = new System.Drawing.Size(124, 20);
            this.lblAccNo.TabIndex = 16;
            this.lblAccNo.Text = "Account Number:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(27, 407);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(119, 20);
            this.lblCustName.TabIndex = 17;
            this.lblCustName.Text = "Customer Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 45);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustCount
            // 
            this.txtCustCount.Location = new System.Drawing.Point(408, 134);
            this.txtCustCount.Name = "txtCustCount";
            this.txtCustCount.ReadOnly = true;
            this.txtCustCount.Size = new System.Drawing.Size(137, 27);
            this.txtCustCount.TabIndex = 19;
            // 
            // txtTotalResidential
            // 
            this.txtTotalResidential.Location = new System.Drawing.Point(408, 210);
            this.txtTotalResidential.Name = "txtTotalResidential";
            this.txtTotalResidential.ReadOnly = true;
            this.txtTotalResidential.Size = new System.Drawing.Size(137, 27);
            this.txtTotalResidential.TabIndex = 20;
            // 
            // txtTotalCommercial
            // 
            this.txtTotalCommercial.Location = new System.Drawing.Point(408, 285);
            this.txtTotalCommercial.Name = "txtTotalCommercial";
            this.txtTotalCommercial.ReadOnly = true;
            this.txtTotalCommercial.Size = new System.Drawing.Size(137, 27);
            this.txtTotalCommercial.TabIndex = 21;
            // 
            // txtTotalIndustrial
            // 
            this.txtTotalIndustrial.Location = new System.Drawing.Point(408, 360);
            this.txtTotalIndustrial.Name = "txtTotalIndustrial";
            this.txtTotalIndustrial.ReadOnly = true;
            this.txtTotalIndustrial.Size = new System.Drawing.Size(137, 27);
            this.txtTotalIndustrial.TabIndex = 22;
            // 
            // txtTotalAllCharges
            // 
            this.txtTotalAllCharges.Location = new System.Drawing.Point(408, 431);
            this.txtTotalAllCharges.Name = "txtTotalAllCharges";
            this.txtTotalAllCharges.ReadOnly = true;
            this.txtTotalAllCharges.Size = new System.Drawing.Size(137, 27);
            this.txtTotalAllCharges.TabIndex = 23;
            // 
            // lblCustCount
            // 
            this.lblCustCount.AutoSize = true;
            this.lblCustCount.Location = new System.Drawing.Point(408, 111);
            this.lblCustCount.Name = "lblCustCount";
            this.lblCustCount.Size = new System.Drawing.Size(118, 20);
            this.lblCustCount.TabIndex = 24;
            this.lblCustCount.Text = "Customer Count:";
            // 
            // lblTotalResidential
            // 
            this.lblTotalResidential.AutoSize = true;
            this.lblTotalResidential.Location = new System.Drawing.Point(408, 187);
            this.lblTotalResidential.Name = "lblTotalResidential";
            this.lblTotalResidential.Size = new System.Drawing.Size(122, 20);
            this.lblTotalResidential.TabIndex = 25;
            this.lblTotalResidential.Text = "Total Residential:";
            // 
            // lblTotalCommercial
            // 
            this.lblTotalCommercial.AutoSize = true;
            this.lblTotalCommercial.Location = new System.Drawing.Point(408, 260);
            this.lblTotalCommercial.Name = "lblTotalCommercial";
            this.lblTotalCommercial.Size = new System.Drawing.Size(129, 20);
            this.lblTotalCommercial.TabIndex = 26;
            this.lblTotalCommercial.Text = "Total Commercial:";
            // 
            // lblTotalIndsutrial
            // 
            this.lblTotalIndsutrial.AutoSize = true;
            this.lblTotalIndsutrial.Location = new System.Drawing.Point(408, 337);
            this.lblTotalIndsutrial.Name = "lblTotalIndsutrial";
            this.lblTotalIndsutrial.Size = new System.Drawing.Size(110, 20);
            this.lblTotalIndsutrial.TabIndex = 27;
            this.lblTotalIndsutrial.Text = "Total Industrial:";
            // 
            // lblTotalAllCharges
            // 
            this.lblTotalAllCharges.AutoSize = true;
            this.lblTotalAllCharges.Location = new System.Drawing.Point(408, 407);
            this.lblTotalAllCharges.Name = "lblTotalAllCharges";
            this.lblTotalAllCharges.Size = new System.Drawing.Size(124, 20);
            this.lblTotalAllCharges.TabIndex = 28;
            this.lblTotalAllCharges.Text = "Total All Charges:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(963, 505);
            this.Controls.Add(this.lblTotalAllCharges);
            this.Controls.Add(this.lblTotalIndsutrial);
            this.Controls.Add(this.lblTotalCommercial);
            this.Controls.Add(this.lblTotalResidential);
            this.Controls.Add(this.lblCustCount);
            this.Controls.Add(this.txtTotalAllCharges);
            this.Controls.Add(this.txtTotalIndustrial);
            this.Controls.Add(this.txtTotalCommercial);
            this.Controls.Add(this.txtTotalResidential);
            this.Controls.Add(this.txtCustCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblAccNo);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.lstCustData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOffPeakUsage);
            this.Controls.Add(this.lblOffPeakUsage);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.cboCustomerType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOverallUsage);
            this.Controls.Add(this.txtOverallUsage);
            this.Name = "Form1";
            this.Text = "City Power (Hydro Bill Calculator)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOverallUsage;
        private System.Windows.Forms.Label lblOverallUsage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboCustomerType;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblOffPeakUsage;
        private System.Windows.Forms.TextBox txtOffPeakUsage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstCustData;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblAccNo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustCount;
        private System.Windows.Forms.TextBox txtTotalResidential;
        private System.Windows.Forms.TextBox txtTotalCommercial;
        private System.Windows.Forms.TextBox txtTotalIndustrial;
        private System.Windows.Forms.TextBox txtTotalAllCharges;
        private System.Windows.Forms.Label lblCustCount;
        private System.Windows.Forms.Label lblTotalResidential;
        private System.Windows.Forms.Label lblTotalCommercial;
        private System.Windows.Forms.Label lblTotalIndsutrial;
        private System.Windows.Forms.Label lblTotalAllCharges;
    }
}

