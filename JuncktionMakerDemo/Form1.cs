using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using JuncktionMakerDemo.Commands;
using System.Diagnostics;



namespace JuncktionMakerDemo
{
    public partial class Form1 : Form
    {
        string sourcePath;
        string sourceInitial;
        string operatedFolder;
        string targetPath;
        string targetInitial;
        string commandString;
        CommandFormatter formatter;
        public Form1()
        {
            InitializeComponent();
            junctionRadio.Checked = true;
            formatter = new CommandFormatter();
        }

        private void sourceButtom_Click(object sender, EventArgs e)
        {
            if (junctionRadio.Checked || symbolicDirRadio.Checked)
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                folderBrowser.InitialDirectory = sourceInitial ?? default;
                DialogResult result = folderBrowser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    targetPath = "";
                    targetField.Clear();
                    sourcePath = folderBrowser.SelectedPath;
                    sourceInitial = Path.GetDirectoryName(sourcePath);
                    operatedFolder = Path.GetFileName(sourcePath);
                    sourceField.Text = sourcePath;
                }
            }
            
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            if (junctionRadio.Checked || symbolicDirRadio.Checked)
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                folderBrowser.InitialDirectory = targetInitial ?? default;
                DialogResult result = folderBrowser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    targetPath = folderBrowser.SelectedPath;
                    if ((Directory.GetDirectoryRoot(sourcePath) !=
                        Directory.GetDirectoryRoot(targetPath)) && !hardRadio.Checked)
                    {

                    }
                    targetInitial = Path.GetDirectoryName(targetPath);
                    targetPath = Path.Combine(targetPath, operatedFolder);
                    targetField.Text = targetPath;
                }
            }

        }



        private void createButton_Click(object sender, EventArgs e)
        {
            if (junctionRadio.Checked)
            {
                CopyFilesRecursively(sourcePath, targetPath);
                Directory.Delete(sourcePath, true);
                ProceedCommand(formatter.Junction);
            }
            else if (hardRadio.Checked)
            {

            }
            else
            {

            }


            void ProceedCommand(string commandString)
            {

                string str = commandString +
                    $" \"{sourcePath}\" \"{targetPath}\"";
                Process appProcess = new Process();
                appProcess.StartInfo = new ProcessStartInfo("cmd.exe");
                appProcess.StartInfo.Arguments = @"/c" + str;
                appProcess.Start();

                MessageBox.Show(str, "Info!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            void CopyFilesRecursively(string sourcePath, string targetPath)
            {
                try
                {
                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                        //Now Create all of the directories
                        foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                        {
                            Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                        }

                        //Copy all the files & Replaces any files with the same name
                        foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                        {
                            File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sourcePath = "";
            sourceField.Clear();
            targetPath = "";
            targetField.Clear();
        }
    }
}