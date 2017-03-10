using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Directory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private List<string> recordsInSourceFile = new List<string>();

        private string sourceFilePath = string.Empty;
        private string saveFilePath = string.Empty;
        private void btnSource_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Reset();
               openFile.Filter = "CSV files (*.csv)|*.csv";


                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(sourceFilePath) == true)
                    {
                        GetSourcePath(openFile);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to load a new data file?", "Data Override Warning...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            GetSourcePath(openFile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void GetSourcePath(OpenFileDialog openFile)
        {
            sourceFilePath = openFile.FileName;
            txtSourceFile.Text = sourceFilePath;
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ',' };
            try
            {
                if (string.IsNullOrWhiteSpace(sourceFilePath) == false)
                {
                    string[] dataRecords = File.ReadAllLines(sourceFilePath);
                    int processed = 0;
                    int inserted = 0;
                    pbImport.Minimum = 0;
                    pbImport.Maximum = dataRecords.Length - 1;
                    txtTotalRecords.Text = pbImport.Maximum.ToString();

                    if (dataRecords.Length > 1)//have records in the csv other than headings
                    {

                        for (int loop = 1; loop < dataRecords.Length; loop++)

                        {
                            string[] recordData = dataRecords[loop].Split(delimiterChars);
                            if (recordData.Length == 4)
                            {
                                DAL.Repo repo = new DAL.Repo();
                                inserted = repo.InsertRecord(
                                    recordData[0],
                                    recordData[1],
                                    recordData[2],
                                    recordData[3]);
                            }

                            if (inserted != 0)//successfully imported the record
                            {
                                processed++;
                                pbImport.Value = processed;
                                txtProcessedRecords.Text = processed.ToString();
                                pbImport.Refresh();
                            }


                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            DAL.Repo repo = new DAL.Repo();
            repo.ClearRecords();
            pbImport.Value = 0;
            txtProcessedRecords.Text = "0";
            txtTotalRecords.Text = "0";
        }

        private void btnClearFiles_Click(object sender, EventArgs e)
        {
            txtFileOne.Text = string.Empty;
            txtFiletwo.Text = string.Empty;
        }

        private void btnExportFiles_Click(object sender, EventArgs e)
        {
            try
            {
                   using (StreamWriter outputFile = new StreamWriter(sourceFilePath + @"\names.txt"))
                    {
                        foreach (string line in txtFileOne.Lines)
                            outputFile.WriteLine(line);
                    }


                    using (StreamWriter outputFile = new StreamWriter(sourceFilePath + @"\addresses.txt"))
                    {
                        foreach (string line in txtFileOne.Lines)
                            outputFile.WriteLine(line);
                    }



                    MessageBox.Show($"Files saved to \n '{sourceFilePath}'", "Save Directory....");
             


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateTextFiles_Click(object sender, EventArgs e)
        {
            try
            {
                string row = string.Empty;
                
                DAL.Repo repo = new DAL.Repo();
                var names = repo.GetNamesInOrder();
                foreach(DataRow nameRow in names.Rows)
                {
                    row = $"{nameRow[0].ToString()} , {nameRow[1].ToString()}";
                    txtFileOne.AppendText(row);
                    txtFileOne.AppendText(Environment.NewLine);
                }

                var addresses = repo.GetAddressesInOrder();
                foreach (DataRow addressRow in addresses.Rows)
                {
                    row = addressRow[0].ToString();
                    txtFiletwo.AppendText(row);
                    txtFiletwo.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
