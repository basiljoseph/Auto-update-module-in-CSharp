using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace auto_update
{
    public partial class UpdateProgress : Form
    {
        public UpdateProgress()
        {
            InitializeComponent();
        }

        private bool UnZip(string zipFile, string folderPath)
        {
            if (!File.Exists(zipFile))
                throw new FileNotFoundException();

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            Shell32.Shell objShell = new Shell32.Shell();
            Shell32.Folder destinationFolder = objShell.NameSpace(folderPath);
            Shell32.Folder sourceFile = objShell.NameSpace(zipFile);

            foreach (var file in sourceFile.Items())
            {
                destinationFolder.CopyHere(file, 4 | 16);
            }

            return true;
        }

        public void StartUpdate(string progName, string filename)
        {
            checkBox_download.Checked = true;

            string pwd = Directory.GetCurrentDirectory();
            if (UnZip(pwd + @"\" + filename, pwd + @"\update"))
                checkBox_extract.Checked = true;

            // Rename the running exe, so that it can be updated
            string[] fileEntries = Directory.GetFiles(pwd);
            foreach (string files in fileEntries)
            {
                /* Dont create backup for update zip and xml file */
                if (files.Equals(pwd + @"\" + filename))
                    continue;
                if (files.Equals(pwd + @"\update.xml"))
                    continue;

                /* If the backup exists, delete them and take backup of original file */
                if (File.Exists(files + @".backup"))
                    File.Delete(files + @".backup");
                File.Move(files, files + @".backup");
            }
            checkBox_backup.Checked = true;

            // Copy everything from the update directory
            checkBox_update.Checked = true;
            string[] newfileEntries = Directory.GetFiles(pwd + @"\update");
            foreach (string files in newfileEntries)
            {
                string destFile = Path.GetFileName(files);
                File.Copy(files, pwd + @"\" + destFile, true);
            }
            checkBox_complete.Checked = true;
            checkBox_restart.Checked = true;

            System.Threading.Thread.Sleep(1000);
            // Restart the program
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = pwd + @"\" + progName;
            Process.Start(startinfo);

            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
