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
            Forename = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            AddressLine1 = new DataGridViewTextBoxColumn();
            AddressLine2 = new DataGridViewTextBoxColumn();
            Town = new DataGridViewTextBoxColumn();
            County = new DataGridViewTextBoxColumn();
            Postcode = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGAddrBook).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DGAddrBook
            // 
            DGAddrBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGAddrBook.Columns.AddRange(new DataGridViewColumn[] { Forename, Surname, PhoneNumber, AddressLine1, AddressLine2, Town, County, Postcode });
            DGAddrBook.Location = new Point(12, 238);
            DGAddrBook.Name = "DGAddrBook";
            DGAddrBook.RowHeadersVisible = false;
            DGAddrBook.RowHeadersWidth = 51;
            DGAddrBook.Size = new Size(776, 161);
            DGAddrBook.TabIndex = 0;
            // 
            // TxtForename
            // 
            TxtForename.Location = new Point(12, 28);
            TxtForename.Name = "TxtForename";
            TxtForename.Size = new Size(125, 37);
            TxtForename.TabIndex = 1;
            // 
            // TxtSurname
            // 
            TxtSurname.Location = new Point(143, 28);
            TxtSurname.Name = "TxtSurname";
            TxtSurname.Size = new Size(125, 37);
            TxtSurname.TabIndex = 2;
            // 
            // TxtPhoneNum
            // 
            TxtPhoneNum.Location = new Point(274, 28);
            TxtPhoneNum.Name = "TxtPhoneNum";
            TxtPhoneNum.Size = new Size(168, 37);
            TxtPhoneNum.TabIndex = 3;
            // 
            // TxtAddrLine1
            // 
            TxtAddrLine1.Location = new Point(448, 28);
            TxtAddrLine1.Name = "TxtAddrLine1";
            TxtAddrLine1.Size = new Size(163, 37);
            TxtAddrLine1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, -1);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 5;
            label1.Text = "Forename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, -1);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, -1);
            label3.Name = "label3";
            label3.Size = new Size(168, 31);
            label3.TabIndex = 7;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, -1);
            label4.Name = "label4";
            label4.Size = new Size(163, 31);
            label4.TabIndex = 8;
            label4.Text = "Address Line 1";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(683, 28);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(105, 110);
            BtnAdd.TabIndex = 9;
            BtnAdd.Text = "Add to address book";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusStripLabel1, StatusStripLabel });
            statusStrip1.Location = new Point(0, 413);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 37);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusStripLabel1
            // 
            StatusStripLabel1.Name = "StatusStripLabel1";
            StatusStripLabel1.Size = new Size(0, 31);
            // 
            // StatusStripLabel
            // 
            StatusStripLabel.Name = "StatusStripLabel";
            StatusStripLabel.Size = new Size(19, 31);
            StatusStripLabel.Text = ".";
            // 
            // TxtAddrLine2
            // 
            TxtAddrLine2.Location = new Point(12, 98);
            TxtAddrLine2.Name = "TxtAddrLine2";
            TxtAddrLine2.Size = new Size(163, 37);
            TxtAddrLine2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 68);
            label5.Name = "label5";
            label5.Size = new Size(163, 31);
            label5.TabIndex = 12;
            label5.Text = "Address Line 2";
            // 
            // TxtAddrTown
            // 
            TxtAddrTown.Location = new Point(181, 98);
            TxtAddrTown.Name = "TxtAddrTown";
            TxtAddrTown.Size = new Size(163, 37);
            TxtAddrTown.TabIndex = 13;
            // 
            // TxtAddrCounty
            // 
            TxtAddrCounty.Location = new Point(350, 98);
            TxtAddrCounty.Name = "TxtAddrCounty";
            TxtAddrCounty.Size = new Size(163, 37);
            TxtAddrCounty.TabIndex = 14;
            // 
            // TxtAddrPostcode
            // 
            TxtAddrPostcode.Location = new Point(519, 98);
            TxtAddrPostcode.Name = "TxtAddrPostcode";
            TxtAddrPostcode.Size = new Size(136, 37);
            TxtAddrPostcode.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 68);
            label6.Name = "label6";
            label6.Size = new Size(67, 31);
            label6.TabIndex = 16;
            label6.Text = "Town";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 68);
            label7.Name = "label7";
            label7.Size = new Size(86, 31);
            label7.TabIndex = 17;
            label7.Text = "County";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(519, 68);
            label8.Name = "label8";
            label8.Size = new Size(107, 31);
            label8.TabIndex = 18;
            label8.Text = "Postcode";
            // 
            // TxtTestOutput
            // 
            TxtTestOutput.Location = new Point(530, 168);
            TxtTestOutput.Multiline = true;
            TxtTestOutput.Name = "TxtTestOutput";
            TxtTestOutput.Size = new Size(258, 33);
            TxtTestOutput.TabIndex = 19;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(12, 194);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(256, 38);
            BtnRefresh.TabIndex = 20;
            BtnRefresh.Text = "Refresh Address Book";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
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
            // BtnRefreshAddrBk
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
