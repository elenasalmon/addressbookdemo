namespace AddressBookDemo
{
    partial class BtnRefreshAddrBk
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
            DGAddrBook = new DataGridView();
            Forename = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            AddressLine1 = new DataGridViewTextBoxColumn();
            AddressLine2 = new DataGridViewTextBoxColumn();
            Town = new DataGridViewTextBoxColumn();
            County = new DataGridViewTextBoxColumn();
            Postcode = new DataGridViewTextBoxColumn();
            TxtForename = new TextBox();
            TxtSurname = new TextBox();
            TxtPhoneNum = new TextBox();
            TxtAddrLine1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnAdd = new Button();
            statusStrip1 = new StatusStrip();
            StatusStripLabel1 = new ToolStripStatusLabel();
            StatusStripLabel = new ToolStripStatusLabel();
            TxtAddrLine2 = new TextBox();
            label5 = new Label();
            TxtAddrTown = new TextBox();
            TxtAddrCounty = new TextBox();
            TxtAddrPostcode = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TxtTestOutput = new TextBox();
            BtnRefresh = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGAddrBook).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DGAddrBook
            // 
            DGAddrBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGAddrBook.Columns.AddRange(new DataGridViewColumn[] { Forename, Surname, PhoneNumber, AddressLine1, AddressLine2, Town, County, Postcode });
            DGAddrBook.Location = new Point(10, 198);
            DGAddrBook.Margin = new Padding(2, 2, 2, 2);
            DGAddrBook.Name = "DGAddrBook";
            DGAddrBook.RowHeadersVisible = false;
            DGAddrBook.RowHeadersWidth = 51;
            DGAddrBook.Size = new Size(647, 134);
            DGAddrBook.TabIndex = 0;
            // 
            // Forename
            // 
            Forename.HeaderText = "Forename";
            Forename.MinimumWidth = 6;
            Forename.Name = "Forename";
            Forename.Width = 125;
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 125;
            // 
            // AddressLine1
            // 
            AddressLine1.HeaderText = "Address Line 1";
            AddressLine1.MinimumWidth = 6;
            AddressLine1.Name = "AddressLine1";
            AddressLine1.Width = 125;
            // 
            // AddressLine2
            // 
            AddressLine2.HeaderText = "Address Line 2";
            AddressLine2.MinimumWidth = 6;
            AddressLine2.Name = "AddressLine2";
            AddressLine2.Width = 125;
            // 
            // Town
            // 
            Town.HeaderText = "Town";
            Town.MinimumWidth = 6;
            Town.Name = "Town";
            Town.Width = 125;
            // 
            // County
            // 
            County.HeaderText = "County";
            County.MinimumWidth = 6;
            County.Name = "County";
            County.Width = 125;
            // 
            // Postcode
            // 
            Postcode.HeaderText = "Postcode";
            Postcode.MinimumWidth = 6;
            Postcode.Name = "Postcode";
            Postcode.Width = 125;
            // 
            // TxtForename
            // 
            TxtForename.Location = new Point(10, 23);
            TxtForename.Margin = new Padding(2, 2, 2, 2);
            TxtForename.Name = "TxtForename";
            TxtForename.Size = new Size(105, 31);
            TxtForename.TabIndex = 1;
            // 
            // TxtSurname
            // 
            TxtSurname.Location = new Point(119, 23);
            TxtSurname.Margin = new Padding(2, 2, 2, 2);
            TxtSurname.Name = "TxtSurname";
            TxtSurname.Size = new Size(105, 31);
            TxtSurname.TabIndex = 2;
            // 
            // TxtPhoneNum
            // 
            TxtPhoneNum.Location = new Point(228, 23);
            TxtPhoneNum.Margin = new Padding(2, 2, 2, 2);
            TxtPhoneNum.Name = "TxtPhoneNum";
            TxtPhoneNum.Size = new Size(141, 31);
            TxtPhoneNum.TabIndex = 3;
            // 
            // TxtAddrLine1
            // 
            TxtAddrLine1.Location = new Point(373, 23);
            TxtAddrLine1.Margin = new Padding(2, 2, 2, 2);
            TxtAddrLine1.Name = "TxtAddrLine1";
            TxtAddrLine1.Size = new Size(136, 31);
            TxtAddrLine1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, -1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 5;
            label1.Text = "Forename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, -1);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, -1);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 7;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, -1);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 8;
            label4.Text = "Address Line 1";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(569, 23);
            BtnAdd.Margin = new Padding(2, 2, 2, 2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(88, 92);
            BtnAdd.TabIndex = 9;
            BtnAdd.Text = "Add to address book";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusStripLabel1, StatusStripLabel });
            statusStrip1.Location = new Point(0, 343);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(667, 32);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusStripLabel1
            // 
            StatusStripLabel1.Name = "StatusStripLabel1";
            StatusStripLabel1.Size = new Size(0, 25);
            // 
            // StatusStripLabel
            // 
            StatusStripLabel.Name = "StatusStripLabel";
            StatusStripLabel.Size = new Size(16, 25);
            StatusStripLabel.Text = ".";
            // 
            // TxtAddrLine2
            // 
            TxtAddrLine2.Location = new Point(10, 82);
            TxtAddrLine2.Margin = new Padding(2, 2, 2, 2);
            TxtAddrLine2.Name = "TxtAddrLine2";
            TxtAddrLine2.Size = new Size(136, 31);
            TxtAddrLine2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 57);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 12;
            label5.Text = "Address Line 2";
            // 
            // TxtAddrTown
            // 
            TxtAddrTown.Location = new Point(151, 82);
            TxtAddrTown.Margin = new Padding(2, 2, 2, 2);
            TxtAddrTown.Name = "TxtAddrTown";
            TxtAddrTown.Size = new Size(136, 31);
            TxtAddrTown.TabIndex = 13;
            // 
            // TxtAddrCounty
            // 
            TxtAddrCounty.Location = new Point(292, 82);
            TxtAddrCounty.Margin = new Padding(2, 2, 2, 2);
            TxtAddrCounty.Name = "TxtAddrCounty";
            TxtAddrCounty.Size = new Size(136, 31);
            TxtAddrCounty.TabIndex = 14;
            // 
            // TxtAddrPostcode
            // 
            TxtAddrPostcode.Location = new Point(432, 82);
            TxtAddrPostcode.Margin = new Padding(2, 2, 2, 2);
            TxtAddrPostcode.Name = "TxtAddrPostcode";
            TxtAddrPostcode.Size = new Size(114, 31);
            TxtAddrPostcode.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 57);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 16;
            label6.Text = "Town";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 57);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 17;
            label7.Text = "County";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(432, 57);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 18;
            label8.Text = "Postcode";
            // 
            // TxtTestOutput
            // 
            TxtTestOutput.Location = new Point(569, 166);
            TxtTestOutput.Margin = new Padding(2, 2, 2, 2);
            TxtTestOutput.Multiline = true;
            TxtTestOutput.Name = "TxtTestOutput";
            TxtTestOutput.Size = new Size(88, 28);
            TxtTestOutput.TabIndex = 19;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(10, 162);
            BtnRefresh.Margin = new Padding(2, 2, 2, 2);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(213, 32);
            BtnRefresh.TabIndex = 20;
            BtnRefresh.Text = "Refresh Address Book";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 166);
            label9.Name = "label9";
            label9.Size = new Size(259, 25);
            label9.TabIndex = 21;
            label9.Text = "No. of People in Address Book:";
            // 
            // BtnRefreshAddrBk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 375);
            Controls.Add(BtnRefresh);
            Controls.Add(TxtTestOutput);
            Controls.Add(TxtAddrPostcode);
            Controls.Add(TxtAddrCounty);
            Controls.Add(TxtAddrTown);
            Controls.Add(TxtAddrLine2);
            Controls.Add(statusStrip1);
            Controls.Add(BtnAdd);
            Controls.Add(TxtAddrLine1);
            Controls.Add(TxtPhoneNum);
            Controls.Add(TxtSurname);
            Controls.Add(TxtForename);
            Controls.Add(DGAddrBook);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BtnRefreshAddrBk";
            Text = "AddressBookDemo";
            ((System.ComponentModel.ISupportInitialize)DGAddrBook).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGAddrBook;
        private TextBox TxtForename;
        private TextBox TxtSurname;
        private TextBox TxtPhoneNum;
        private TextBox TxtAddrLine1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAdd;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusStripLabel1;
        private ToolStripStatusLabel StatusStripLabel;
        private TextBox TxtAddrLine2;
        private Label label5;
        private TextBox TxtAddrTown;
        private TextBox TxtAddrCounty;
        private TextBox TxtAddrPostcode;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TxtTestOutput;
        private Button BtnRefresh;
        private DataGridViewTextBoxColumn Forename;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn AddressLine1;
        private DataGridViewTextBoxColumn AddressLine2;
        private DataGridViewTextBoxColumn Town;
        private DataGridViewTextBoxColumn County;
        private DataGridViewTextBoxColumn Postcode;
        private Label label9;
    }
}
