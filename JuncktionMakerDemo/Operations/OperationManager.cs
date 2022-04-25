using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using JuncktionMakerDemo.Localizations;
#pragma warning disable CS8604

namespace JuncktionMakerDemo.Operations
{
    public static class OperationManager
    {
        static readonly string[] modes = new string[]
        {
            "mklink /j",
            "mklink /h",
            "mklink /d",
            "mklink"
        };

        internal static int ModeIndex { get; set; }
        internal static string? SourcePath { get; set; }
        internal static string? SourceInitial { get; set; }
        internal static string? OperatedItem { get; set; }
        internal static string? TargetPath { get; set; }
        internal static string? TargetInitial { get; set; }
        internal static string? GetSourceItem()
        {
            if (ModeIndex == 0 || ModeIndex == 2)
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                folderBrowser.InitialDirectory = SourceInitial ?? default;
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    return SetSource(folderBrowser.SelectedPath);
                }
                return default;
            }
            else
            {
                OpenFileDialog openFileDilog = new OpenFileDialog();
                openFileDilog.InitialDirectory = SourceInitial ?? default;
                openFileDilog.Multiselect = false;
                if (openFileDilog.ShowDialog() == DialogResult.OK)
                {
                    return SetSource(openFileDilog.FileName);
                }
                return default;
            }

            static string SetSource(string path)
            {
                SourcePath = path;
                SourceInitial = Path.GetDirectoryName(SourcePath);
                OperatedItem = Path.GetFileName(SourcePath);
                return SourcePath;
            }
        }

        internal static string? GetTargetItem()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.InitialDirectory = TargetInitial ?? default;
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                TargetPath = folderBrowser.SelectedPath;
                TargetInitial = Path.GetDirectoryName(TargetPath);
                TargetPath = Path.Combine(TargetPath, OperatedItem);
                return TargetPath;
            }
            return default;
        }

        internal static void CreateLink()
        {
            switch (ModeIndex)
            {
                case 0:
                case 2:
                    CopyFilesRecursively(SourcePath, TargetPath);
                    Directory.Delete(SourcePath, true);
                    break;
                case 1:
                    if (Path.GetPathRoot(SourcePath) == Path.GetPathRoot(TargetPath))
                        File.Move(SourcePath, TargetPath, true);
                    else
                    {
                        throw new FormatException("Different drives for hard link are pointed");
                    }
                    break;
                case 3:
                    File.Move(SourcePath, TargetPath, true);
                    break;
            }


            string str = modes[ModeIndex] +
                    $" \"{SourcePath}\" \"{TargetPath}\"";
            Process appProcess = new Process();
            appProcess.StartInfo = new ProcessStartInfo("cmd.exe");
            appProcess.StartInfo.Arguments = @"/c " + str;
            appProcess.Start();


        }

        static void CopyFilesRecursively(string SourcePath, string TargetPath)
        {
            try
            {
                if (!Directory.Exists(TargetPath))
                {
                    Directory.CreateDirectory(TargetPath);
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(SourcePath, TargetPath));
                    }

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(SourcePath, TargetPath), true);
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
}
