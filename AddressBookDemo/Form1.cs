namespace AddressBookDemo
{
    public partial class BtnRefreshAddrBk : Form
    {
        public Flatfile ff = new();
        public BtnRefreshAddrBk()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string data = TxtForename.Text + ","
                + TxtSurname.Text + ","
                + TxtPhoneNum.Text + ","
                + TxtAddrLine1.Text + ","
                + TxtAddrLine2.Text + ","
                + TxtAddrTown.Text + ","
                + TxtAddrCounty.Text + ","
                + TxtAddrPostcode.Text + "\n";

            string FilePath = ff.csvFilePath;

            string errmess = string.Empty;
            ff.SaveToCsv(data, FilePath, ref errmess);

            if (errmess != string.Empty)
            {
                StatusStripLabel.Text = errmess;
            }
            else
            {
                StatusStripLabel.Text = "Data saved successfully.";
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            string FilePath = ff.csvFilePath;

            List<string[]> data = new List<string[]>();
            string errmess = string.Empty;
            ff.PullFromCsv(FilePath, ref errmess, ref data);

            // dump data to textbox for now
            TxtTestOutput.Text = data.Count.ToString();

            // clear the data grid, and refresh to apply this
            DGAddrBook.Rows.Clear();
            DGAddrBook.Refresh();

            for (int len = 0; len < data.Count; len++)
            {
                // add an extra row
                DGAddrBook.Rows.Add(data[len].ToString());

                for (int i = 0; i < DGAddrBook.ColumnCount; i++) // neater way to set number of columns in data?
                {
                    DGAddrBook[i, len].Value = data[len][i].ToString();
                    // All lines in csv file must have same number of columns/items even if empty
                    // Database should be better for if we want to add more datafields later
                }

                // refresh to show new row immediately
                DGAddrBook.Refresh();
            }
        }
    } // next, when I add a name and address to the address book, I want those fields
} // to all empty in readiness for another address being added
