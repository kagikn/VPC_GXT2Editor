using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using VPC_GXT2Editor.Formats.CSV;
using VPC_GXT2Editor.Formats.GXT;
using ComponentOwl.BetterListView;
using VPC_GXT2Editor.Forms;
using CsvHelper;

namespace VPC_GXT2Editor
{
    public partial class Main : Form
    {

        GXT2 MainGXTFile;
        Stream MainGXTStream;
        string currentFileName;
        bool IsNewFile = false;
        public Main()
        {
            InitializeComponent();
        }

        #region ButtonHandlers

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (itemView.SelectedItems.Count > 0)
            {
                itemView.Items.Remove(itemView.SelectedItems[0]);
            }
        }
        private void closeB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the current file?", "Close - Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            this.ClearItems();
            this.itemView.Enabled = false;
            this.closeB.Enabled = false;
            this.saveCurrentB.Enabled = false;
            this.saveNewB.Enabled = false;
            this.exportB.Enabled = false;
            this.Text = "VPC GXT2 Editor";
            IsNewFile = false;
            this.currentFileName = string.Empty;
            if (MainGXTStream != null)
            {
                try
                {
                    this.MainGXTStream.Close();
                    this.MainGXTStream = null;
                }
                catch
                {

                }
            }
            this.MainGXTFile = null;

        }

        private void newB_Click(object sender, EventArgs e)
        {
            IsNewFile = true;
            ClearItems();
            itemView.Enabled = true;
            MainGXTFile = null;
            MainGXTStream = null;
            saveCurrentB.Enabled = false;
            saveNewB.Enabled = false;
            closeB.Enabled = true;
            exportB.Enabled = false;
            this.Text = "VPC GXT2 Editor";
            this.currentFileName = string.Empty;
            if (MainGXTStream != null)
            {
                try
                {
                    this.MainGXTStream.Close();
                    this.MainGXTStream = null;

                }
                catch
                {

                }
            }
            this.MainGXTFile = null;

        }

        private void openB_Click(object sender, EventArgs e)
        {
            if (IsNewFile)
                if (MessageBox.Show("You are creating a new file.  Are you sure you want to cancel and open another?\n\nClick \"Yes\" to continue to open another file.", "Close New File Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Open A GTAV GXT2 File...";
            OFD.Filter = "GXT2 File|*.gxt2|All Files|*.*";
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenGXT(OFD.FileName);
            }
        }
        private void SaveCurrentB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to overwrite the current file?", "Overwrite - Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            MainGXTStream.SetLength(0);

            this.MainGXTFile = new GXT2();
            foreach (BetterListViewItem blvi in this.itemView)
            {
                if (blvi.Text.StartsWith("0x"))
                {
                    uint hash = uint.Parse(blvi.Text.Substring(2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
                    this.MainGXTFile.AddStringItem(hash, blvi.SubItems[1].Text);
                }
                else
                    this.MainGXTFile.AddStringItem(blvi.Text, blvi.SubItems[1].Text);
            }
            this.MainGXTFile.WriteToStream(MainGXTStream);
            ClearItems();
            LoadItems();
            MessageBox.Show("File Written!", "File Write - Success", MessageBoxButtons.OK);
        }
        private void saveNewB_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "Choose output file...";
            SFD.Filter = "|*.gxt2";
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.MainGXTStream = File.Create(SFD.FileName);
                this.MainGXTFile = new GXT2();
                foreach (BetterListViewItem blvi in this.itemView)
                {
                    if (blvi.Text.StartsWith("0x"))
                    {
                        uint hash = uint.Parse(blvi.Text.Substring(2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
                        this.MainGXTFile.AddStringItem(hash, blvi.SubItems[1].Text);
                    }
                    else
                        this.MainGXTFile.AddStringItem(blvi.Text, blvi.SubItems[1].Text);
                }
                this.MainGXTFile.WriteToStream(MainGXTStream);
                IsNewFile = false;
                exportB.Enabled = true;
                saveCurrentB.Enabled = true;
                saveNewB.Enabled = true;
                closeB.Enabled = true;
                MessageBox.Show("File Written!", "File Write - Success", MessageBoxButtons.OK);
            }
        }
        private void saveCurrentB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to overwrite the current file?", "Overwrite - Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            MainGXTStream.SetLength(0);

            this.MainGXTFile = new GXT2();
            foreach (BetterListViewItem blvi in this.itemView)
            {
                if (blvi.Text.StartsWith("0x"))
                {
                    uint hash = uint.Parse(blvi.Text.Substring(2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
                    this.MainGXTFile.AddStringItem(hash, blvi.SubItems[1].Text);
                }
                else
                    this.MainGXTFile.AddStringItem(blvi.Text, blvi.SubItems[1].Text);
            }
            this.MainGXTFile.WriteToStream(MainGXTStream);
            ClearItems();
            LoadItems();
            MessageBox.Show("File Written!", "File Write - Success", MessageBoxButtons.OK);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by XBLToothPik\r\n" + "Modified by kagikn\r\n" + "Use OpenIV to extract GXT2 files from GTAV.\r\n" + "Version 0.3", "Information - About", MessageBoxButtons.OK);
        }
        private void itemView_DoubleClick(object sender, EventArgs e)
        {
            if (itemView.SelectedItems.Count > 0)
            {
                BetterListViewItem cItem = itemView.SelectedItems[0];
                EditorForm editor = new EditorForm(cItem.Text, cItem.SubItems[1].Text);
                editor.Location = this.Location;
                editor.ShowDialog();
                if (!editor.Canceled)
                {
                    string newName = editor.textLabelName.Text;
                    cItem.Text = editor.textLabelName.Text;
                    cItem.SubItems[1].Text = editor.textLabelData.Text;
                }
            }
        }
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditorForm adder = new EditorForm("", "", false);
            adder.Location = this.Location;
            adder.ShowDialog();
            
            if (!adder.Canceled)
            {
                BetterListViewItem blvi = new BetterListViewItem();
                blvi.Text = adder.textLabelName.Text;
                blvi.SubItems.Add(adder.textLabelData.Text);
                itemView.Items.Add(blvi);
            }
        }
        #endregion

        #region Methods
        private void CloseFile()
        {
            ClearItems();
            itemView.Enabled = false;
            closeB.Enabled = false;
            exportB.Enabled = false;
            MainGXTFile = null;
            MainGXTStream.Close();
            MainGXTStream = null;
        }
        private void ClearItems()
        {
            itemView.BeginUpdate();
            itemView.Items.Clear();
            itemView.EndUpdate();
        }
        private void LoadItems(bool enableView = true)
        {
            itemView.BeginUpdate();
            foreach (KeyValuePair<uint, byte[]> datas in MainGXTFile.DataItems)
            {
                string dataString = System.Text.Encoding.UTF8.GetString(datas.Value);
                ComponentOwl.BetterListView.BetterListViewItem newItem = new ComponentOwl.BetterListView.BetterListViewItem();
                newItem.Text = string.Format("0x{0:X8}", datas.Key);
                newItem.SubItems.Add(dataString);
                itemView.Items.Add(newItem);
            }
            itemView.EndUpdate();
            itemView.Enabled = enableView;
        }








        #endregion

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Open A CSV File...";
            OFD.Filter = "GXT2 File|*.csv|All Files|*.*";
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                importCsv(OFD.FileName);
            }
        }

        private void SaveCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "Choose output file...";
            SFD.Filter = "|*.csv";
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    CSV.writeCSV(SFD.FileName, this.itemView);
                    MessageBox.Show("File Written!", "File Write - Success", MessageBoxButtons.OK);
                }
                catch (IOException)
                {
                    MessageBox.Show("Unable to Write the CSV!", "File Write - Failure", MessageBoxButtons.OK);
                }
            }
        }

        private void itemView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            var fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);

            var firstFileName = fileNames[0];
            var extension = Path.GetExtension(firstFileName);

            if (extension.Equals(".gxt2", StringComparison.OrdinalIgnoreCase))
            {
                OpenGXT(firstFileName);
            }
            else if(extension.Equals(".csv", StringComparison.OrdinalIgnoreCase))
            {
                importCsv(firstFileName);
            }
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            var fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (System.IO.File.Exists(fileName[0]))
            {
                var extension = Path.GetExtension(fileName[0]);

                if (extension.Equals(".gxt2", StringComparison.OrdinalIgnoreCase) || extension.Equals(".csv", StringComparison.OrdinalIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void OpenGXT(string fileName)
        {
            Stream xIn = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

            this.MainGXTStream = xIn;
            this.MainGXTFile = new GXT2(xIn);

            LoadItems();

            closeB.Enabled = true;
            IsNewFile = false;
            saveCurrentB.Enabled = true;
            saveNewB.Enabled = true;
            exportB.Enabled = true;

            currentFileName = System.IO.Path.GetFileName(fileName);
            this.Text = string.Format("VPC GXT2 Editor - {0}", currentFileName);
        }

        private void importCsv(string fileName)
        {
            try
            {
                MainGXTFile = new GXT2();
                MainGXTStream = null;

                var dictionary = CSV.ReadCSV(fileName);

                if (dictionary == null)
                {
                    MessageBox.Show("the CSV is Empty!", "File Read - Failure", MessageBoxButtons.OK);
                    return;
                }

                foreach (var GxtEntry in dictionary)
                {
                    MainGXTFile.AddStringItem(GxtEntry.Key, GxtEntry.Value);
                }

                LoadItems();

                closeB.Enabled = true;
                IsNewFile = false;
                saveCurrentB.Enabled = true;
                saveNewB.Enabled = true;
                exportB.Enabled = true;

                currentFileName = System.IO.Path.GetFileName(fileName);
                this.Text = string.Format("VPC GXT2 Editor - {0}", currentFileName);
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to Read the CSV!", "File Read - Failure", MessageBoxButtons.OK);
            }
            catch (CsvMissingFieldException)
            {
                MessageBox.Show("invalid CSV has been loaded!", "File Read - Failure", MessageBoxButtons.OK);
            }
        }
    }
}
