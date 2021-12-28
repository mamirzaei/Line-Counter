using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LineCounter
{
    public partial class FrmLineCounter : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public FrmLineCounter()
        {
            InitializeComponent();
        }
        #region General
        private long getFileLineCount(string fileName)
        {
            try
            {
                return File.ReadLines(fileName).Count();
                //string[] fileContent =  File.ReadAllLines(fileName);
                //return fileContent.Length;
            }
            catch (System.Exception ex)
            {
                return -1;
            }
        }
        private void clearList()
        {
            tbxTotalFileCount.Text = "";
            tbxFileLines.Text = "";
            lsvData.Clear();
            lsvData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvData.View = View.Details;

            lsvData.Columns.Add("Row", 55);
            lsvData.Columns.Add("File Name", 670);
            lsvData.Columns.Add("File Lines Count", 90);
        }
        private void FrmCodeCounter_Load(object sender, EventArgs e)
        {
            clearList();
        }
        #endregion

        #region Button methods
        private void btnSelPath_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() != DialogResult.OK)
                return;
            tbxPath.Text = fbd.SelectedPath;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxExt.Text == "")
                {
                    MessageBox.Show("Please enter file extension.");
                    tbxExt.Focus();
                    return;
                }
                if (tbxPath.Text == "")
                {
                    MessageBox.Show("Please select file path.");
                    btnSelPath.Focus();
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                clearList();
                List<string> files = Directory.EnumerateFiles(fbd.SelectedPath,
                                     "*." + tbxExt.Text,
                                     ckbSubDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList();

                tbxTotalFileCount.Text = files.Count.ToString();
                long fileLines = 0;
                ListViewItem[] itms = new ListViewItem[files.Count];
                for (int i = 0; i < files.Count; i++)
                {
                    string[] arr = new string[3];

                    arr[0] = String.Format("{0}", i + 1);
                    arr[1] = files[i];
                    if (ckbCalcLines.Checked)
                    {
                        long fileLine = getFileLineCount(files[i]);
                        arr[2] = (fileLine == -1) ? "ERROR" : fileLine.ToString();
                        if (fileLine != -1)
                            fileLines += fileLine;
                    }
                    itms[i] = new ListViewItem(arr);
                    itms[i].Tag = arr;
                }
                lsvData.Items.AddRange(itms);

                if (!ckbCalcLines.Checked)
                    tbxFileLines.Text = "Did not Calculated!";
                else
                    tbxFileLines.Text = fileLines.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                DialogResult result = folder.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;

                DateTime date = DateTime.Now;
                string dateString = string.Format("{0:0000}_{1:00}_{2:00}_{3:00}_{4:00}_{5:00}", date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
                string fileName = folder.SelectedPath + "\\Files_" + dateString + ".txt";
                if (File.Exists(fileName))
                {
                    MessageBox.Show("There is a charge file in selected folder path.");
                    return;
                }

                FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);
                StreamWriter buffer = new StreamWriter(file);

                string subDirectoryState = ckbSubDirectory.Checked?"TRUE":"FALSE";
                buffer.Write(tbxPath.Text + "\\*." + tbxExt.Text + "\n");
                buffer.Flush();
                buffer.Write("Include Sub Directory = " + subDirectoryState + "\n");
                buffer.Write("Files Count = " + tbxTotalFileCount.Text + "\n");
                buffer.Write("Files Line Count = " + tbxFileLines.Text + "\n\n");

                foreach (ListViewItem item in lsvData.Items)
                {
                    string[] arr = (string[])item.Tag;
                    buffer.Write(arr[0] + "\t" + "line(s) = " + arr[2] + "\t\t" + arr[1] + "\n");
                }

                buffer.Flush();
                buffer.Close();
                file.Close();

                System.Diagnostics.Process.Start(fileName);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}
