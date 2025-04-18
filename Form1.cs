using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace CD_Burner
{
    public partial class Form1 : Form
    {

        public List<string> _FoldreFiles = new List<string>();
        public DataTable _dt = new DataTable();

        public const string IsoFileName = "MyIsoImage.iso";

        // Add this field declaration at the class level in Form1.cs  
        private FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        private string folderName;


        public Form1()
        {
            InitializeComponent();

            _dt.Columns.Add("Folder Files", typeof(string));

            ColumnHeader header1, header2;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();

            // Set the text, alignment and width for each column header.
            header1.Text = "File/Folder name";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 580;


            header2.TextAlign = HorizontalAlignment.Left;
            header2.Text = "Size";
            header2.Width = 500;

            // Add the headers to the ListView control.
            lstFolderFiles.Columns.Add(header1);
            lstFolderFiles.Columns.Add(header2);
            lstFolderFiles.View = View.Details;

            txtWorkFolder.Text = @"C:\Users\Public\Documents\CD_Burner";
            txtDestinationPath.Text = @"C:\Users\Public\Documents\IsoFolder";
            txtVolumeName.Text = "VolumeName";

        }


        public bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            try
            {

                txtIsoFile.Text = string.Empty;

                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = false;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Folder Selection.";

                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK)
                {

                    if (folderBrowser.FileName != null)
                    {
                        //DataRow dr = _dt.NewRow();
                        string[] strLv = { folderBrowser.FileName.ToString() };

                        if (File.Exists(folderBrowser.FileName.ToString()))
                        {
                            long length = new System.IO.FileInfo(folderBrowser.FileName).Length;
                            lstFolderFiles.Items.Add(new ListViewItem(new string[] { strLv[0], length.ToString() }));
                            Console.WriteLine("It's a file.");
                        }
                        else if (folderBrowser.FileName.Contains("Folder Selection"))
                        {
                            int lastIndex = folderBrowser.FileName.LastIndexOf("Folder Selection");

                            if (lastIndex != -1)
                            {
                                // Extract the substring before the last occurrence of the delimiter
                                string FolderPath = strLv[0].Substring(0, lastIndex - 1);
                                lstFolderFiles.Items.Add(new ListViewItem(new string[] { FolderPath, "Folder" }));
                            }
                            Console.WriteLine("It's a directory.");
                        }
                        else
                        {
                            Console.WriteLine("The path does not exist.");
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = lstFolderFiles.Items.Count - 1; i >= 0; i--)
                {
                    if (lstFolderFiles.Items[i].Selected)
                    {
                        lstFolderFiles.Items[i].Remove();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateIso_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstFolderFiles.Items.Count == 0)
                {
                    MessageBox.Show("No files listed to create ISO file.");
                    return;
                }

                if (txtWorkFolder.Text.Length == 0)
                {
                    MessageBox.Show("Source folder missing.");
                    return;
                }

                if (txtDestinationPath.Text.Length == 0)
                {
                    MessageBox.Show("Destination folder missing.");
                    return;
                }

                if (txtVolumeName.Text.Length == 0)
                {
                    MessageBox.Show("Volume Name is missing.");
                    return;
                }
                // Does the work folder exist? if not create.
                try
                {

                    if (!Directory.Exists(txtWorkFolder.Text))
                    {
                        // Create the folder
                        Directory.CreateDirectory(txtWorkFolder.Text);
                        Console.WriteLine("Source Folder created successfully.");
                    }
                    else //Source Folder already exists. Drop and replace so clean start.
                    {
                        if (!IsDirectoryEmpty(txtWorkFolder.Text))
                        {
                            DialogResult dialogResult = MessageBox.Show("There are existing items in the source folder. Do you want to keep them?", "Keep folder items in source folder", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.No)
                            {
                                Directory.Delete(txtWorkFolder.Text, true);
                                Directory.CreateDirectory(txtWorkFolder.Text);
                            }
                            Console.WriteLine("Source Folder already exists, deleted and re-added.");
                        }
                        else
                        {
                            Console.WriteLine("Source Folder already exists.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                // Does the Destination folder exist? if not create.
                try
                {

                    if (!Directory.Exists(txtDestinationPath.Text))
                    {
                        // Create the folder
                        Directory.CreateDirectory(txtDestinationPath.Text);
                        Console.WriteLine("Destination Folder created successfully.");
                    }
                    else
                    {
                        if (!IsDirectoryEmpty(txtDestinationPath.Text))
                        {
                            DialogResult dialogResult = MessageBox.Show("There are existing items in the destination folder. Do you want to keep them?", "Keep folder items in Destination folder", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.No)
                            {
                                Directory.Delete(txtDestinationPath.Text, true);
                                Directory.CreateDirectory(txtDestinationPath.Text);
                            }
                            Console.WriteLine("Destination Folder already exists, deleted and re-added.");
                        }
                        else { 
                                Console.WriteLine("Destination Folder already exists.");
                             }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Clear the source folder before copying files.
                //try
                //{
                //    if (Directory.Exists(txtWorkFolder.Text))
                //    {
                //        DirectoryInfo di = new DirectoryInfo(txtWorkFolder.Text);
                //        foreach (FileInfo file in di.GetFiles())
                //        {
                //            file.Delete();
                //        }
                //        foreach (DirectoryInfo dir in di.GetDirectories())
                //        {
                //            dir.Delete(true);
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

                Cursor.Current = Cursors.WaitCursor;

                //Copy listed files and folders to Source folder

                clsFolderFileCopier clsFnFileCopier = new clsFolderFileCopier();

                clsFnFileCopier.CopyItemsFromListView(lstFolderFiles, txtWorkFolder.Text);

                clsFnFileCopier = null;

                clsCDBurn CdIso = new clsCDBurn();

                string res = CdIso.CreateIsoImage(txtWorkFolder.Text, txtDestinationPath.Text + "\\" + IsoFileName, txtVolumeName.Text);

                txtIsoFile.Text = CdIso.TargetIso;

                Console.WriteLine(res);

                CdIso = null;

                Cursor.Current = Cursors.Default;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBurnIso_Click(object sender, EventArgs e)
        {
            // Check if the destination path is empty
            if (string.IsNullOrWhiteSpace(txtDestinationPath.Text))
            {
                MessageBox.Show("Please specify a destination path for the ISO file.");
                return;
            }

            // Check if the destination path exists
            if (!Directory.Exists(txtDestinationPath.Text))
            {
                MessageBox.Show("Destination path does not exist. Please create the folder first.");
                return;
            }
            // Check if the work folder is empty
            if (string.IsNullOrWhiteSpace(txtWorkFolder.Text) || !Directory.Exists(txtWorkFolder.Text))
            {
                MessageBox.Show("Source folder is empty or does not exist. Please specify a valid source folder.");
                return;
            }
            // Check if the work folder contains files
            if (lstFolderFiles.Items.Count == 0)
            {
                MessageBox.Show("No files listed to burn to CD. Please add files first.");
                return;
            }
            // Check if the work folder contains files
            if (Directory.GetFiles(txtWorkFolder.Text).Length == 0)
            {
                MessageBox.Show("Source folder is empty. Please add files to the source folder before burning.");
                return;
            }


            // Path to the ISO file
            string isoPath = txtDestinationPath.Text + "\\" + IsoFileName;

            // Command to execute isoburn.exe with the ISO file
            string command = $"/Q {isoPath}";

            // Create a new process to run isoburn.exe
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "isoburn.exe",
                Arguments = command,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = Process.Start(processInfo))
                {
                    // Read the output (if any) from the process
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    // Display the output and error (if any)
                    Console.WriteLine("Output: " + output);
                    Console.WriteLine("Error: " + error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Clear the source folder after burning
            ////Directory.Delete(txtWorkFolder.Text, true);
            ////Directory.Delete(txtDestinationPath.Text, true);

        }



        private void btnDestination_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;

                if (txtWorkFolder.Text == folderName)
                {
                    MessageBox.Show("Source folder cannot be the sameor a subfolder as the destination folder.");
                    return;
                }

                txtDestinationPath.Text = folderName;
            }
        }

        private void btnWorkFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;

                if (txtDestinationPath.Text == folderName)
                {
                    MessageBox.Show("Destination folder cannot be the same or a subfolder as the source folder.");
                    return;
                }

                txtWorkFolder.Text = folderName;
            }
        }

        //Menu items
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
