using System;
using System.IO;
using System.Windows.Forms;

namespace CD_Burner
{
    public class clsFolderFileCopier
    {
        public void CopyItemsFromListView(System.Windows.Forms.ListView listView, string destinationPath)
        {
            try
            {
                if (listView == null || listView.Items.Count == 0)
                {
                    MessageBox.Show("No items to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (ListViewItem item in listView.Items)
                {
                    string sourcePath = item.Text;

                    if (Directory.Exists(sourcePath))
                    {
                        CopyDirectory(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));
                    }
                    else if (File.Exists(sourcePath))
                    {
                        File.Copy(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)), true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while copying items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            Directory.CreateDirectory(destinationDir);

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            foreach (string dir in Directory.GetDirectories(sourceDir))
            {
                string destDir = Path.Combine(destinationDir, Path.GetFileName(dir));
                CopyDirectory(dir, destDir);
            }
        }
    }



} //Name space

