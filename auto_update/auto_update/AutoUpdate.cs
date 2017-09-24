using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace auto_update
{
    public class AutoUpdate
    {
        private string programName;
        private string programVersion;
        private string programUpdateUrl;
        private IWin32Window programBaseClass;
        private string changeLog;
        private Version latestVer;
        private bool updateProgress = false;

        public AutoUpdate(IWin32Window baseClass)
        {
            programBaseClass = baseClass;
        }

        public Boolean SetConfiguration(string name, string version, string url)
        {
            if (name == null || version == null || url == null)
                return false;
            programName = name;
            programVersion = version;
            programUpdateUrl = url;
            return true;
        }

        public void Cleanup()
        {
            string pwd = Directory.GetCurrentDirectory();
            string[] fileEntries = Directory.GetFiles(pwd);
            foreach (string files in fileEntries)
            {
                if (Path.GetExtension(files).Equals(".backup"))
                {
                    try
                    {
                        File.Delete(files);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Skip the file
                    }
                }
            }

            // Delete the old update directory also
            string updateDir = pwd + @"\update";
            if (Directory.Exists(updateDir))
            {
                var dir = new DirectoryInfo(updateDir);
                dir.Delete(true);
            }
        }

        public void CheckForUpdates()
        {
            if (updateProgress)
            {
                MessageBox.Show("One update is already in progress");
                return;
            }

            updateProgress = true;
            Cleanup();

            WebClient client = new WebClient();
            try
            {
                client.DownloadFile(programUpdateUrl, "update.xml");
            }
            catch (WebException)
            {
                MessageBox.Show("Cannot download the update info. Please retry after some time");
                updateProgress = false;
                return;
            }

            // Assume that the file is downloaded
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load("update.xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                /* Dont do anything. Just return */
                updateProgress = false;
                return;
            }


            if (xmlDoc.DocumentElement.Name == "application")
            {
                if (xmlDoc.DocumentElement.GetAttribute("id") == programName)
                {
                    XmlNodeList xmlver = xmlDoc.GetElementsByTagName("latestVersion");
                    if (xmlver.Count == 1)
                    {
                        /* Latest version available */
                        latestVer = new Version(xmlver[0].InnerText);
                        Version curVer = new Version(programVersion);

                        var result = latestVer.CompareTo(curVer);
                        if (result > 0)
                        {
                            CreateChangeLog(xmlDoc.SelectSingleNode("/application/changeLog"));
                            DownloadPackage(xmlDoc.SelectSingleNode("/application/packages"));
                        }
                        else
                        {
                            updateProgress = false;
                            MessageBox.Show("No update available");
                        }
                    }
                    else
                        updateProgress = false;
                }
            }
        }

        private void CreateChangeLog(XmlNode changes)
        {
            XmlNodeList changeList = changes.SelectNodes("version");
            foreach (XmlNode node in changeList)
            {
                changeLog += new Version(node.Attributes.GetNamedItem("id").Value);
                changeLog += "\r\n";
                changeLog += node.InnerText;
                changeLog += "\r\n\r\n";
            }
        }

        private void DownloadPackage(XmlNode packages)
        {
            XmlNodeList changeList = packages.SelectNodes("filename");
            foreach (XmlNode node in changeList)
            {
                Version curVersion = new Version(node.Attributes.GetNamedItem("id").Value);
                if (curVersion == latestVer)
                {
                    string downloadFile = latestVer.ToString() + ".zip";
                    WebClient client = new WebClient();
                    try
                    {
                        client.DownloadFile(node.InnerText, downloadFile);
                    }
                    catch (WebException)
                    {
                        MessageBox.Show("Cannot download the update file. Please retry after some time");
                        updateProgress = false;
                        return;
                    }

                    var md5 = MD5.Create();
                    string md5hash;
                    try
                    {
                        var stream = File.OpenRead(downloadFile);
                        md5hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                    }
                    catch (FileNotFoundException)
                    {
                        updateProgress = false;
                        return;
                    }

                    if (node.Attributes.GetNamedItem("md5").Value.Equals(md5hash))
                    {
                        ShowUpdateDialogue(changeLog);
                    }
                    else
                        updateProgress = false;

                    break;
                }
            }
        }

        private void ShowUpdateDialogue(string log)
        {
            var updateForm = new UpdateWindow();
            updateForm.FormClosed += new FormClosedEventHandler(updateForm_FormClosed);
            updateForm.Show(programBaseClass);
            updateForm.update_change_log(programName, log, latestVer.ToString() + ".zip");
        }

        void updateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateProgress = false;
        }
    }
}
