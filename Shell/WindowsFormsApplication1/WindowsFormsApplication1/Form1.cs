using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string m_sourceFolder;
        private string m_destFolder;
        private string m_tempFolder;
        private string m_tempFolder_input;
        private string m_tempFolder_output;

        private static void DelectDir(string srcPath)
        {
            try
            {
                if (!Directory.Exists(srcPath))
                    return;
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CopyFilesUnderDirectory(string scrPath, string destPath)
        {
            if (Directory.Exists(scrPath))//检查路径(目录)是否存在
            {
                if (!Directory.Exists(destPath))
                    Directory.CreateDirectory(destPath);

                string[] aFiles = Directory.GetFiles(scrPath);
                for (int i = 0; i < aFiles.Length; i++)
                {
                    FileInfo fi = new FileInfo(aFiles[i]);
                    long fileSize = fi.Length;//文件大小

                    File.Copy(aFiles[i], destPath + "\\" + fi.Name, true);
                }
            }
        }

        private void DoProgress(string sourceFolder, string destFolder, string tempFolder)
        {
            try
            {
                output.Text = "Begin initializing...";
                progressBar.Value = 0;
                if (!Directory.Exists(sourceFolder))
                {
                    Directory.CreateDirectory(sourceFolder);
                }
                m_sourceFolder = sourceFolder;
                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }
                m_destFolder = destFolder;
                if (!Directory.Exists(tempFolder))
                {
                    Directory.CreateDirectory(tempFolder);
                }
                m_tempFolder = tempFolder;
                m_tempFolder_input = Path.Combine(tempFolder, "input");
                if (!Directory.Exists(m_tempFolder_input))
                {
                    Directory.CreateDirectory(m_tempFolder_input);
                }
                m_tempFolder_output = Path.Combine(tempFolder, "output");
                if (!Directory.Exists(m_tempFolder_output))
                {
                    Directory.CreateDirectory(m_tempFolder_output);
                }
                output.Text = "Finished initializing...";

                int progress = 0;
                foreach (var img in file_list.Items)
                {
                    progress++;
                    //clear environment first
                    DelectDir(m_tempFolder_input);
                    DelectDir(Path.Combine(m_tempFolder_output, "stage_1_restore_output"));
                    DelectDir(Path.Combine(m_tempFolder_output, "stage_2_detection_output"));
                    DelectDir(Path.Combine(m_tempFolder_output, "stage_3_face_output"));
                    DelectDir(Path.Combine(m_tempFolder_output, "final_output"));

                    var fullinputfilename = img.ToString();
                    output.Text = $"Start handle {fullinputfilename}";
                    File.Copy(fullinputfilename, Path.Combine(m_tempFolder_input, Path.GetFileName(fullinputfilename)));
                    // run.py

                    var currentPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

                    output.Text = $"Run photo fixing for {fullinputfilename}.";
                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    //process.StartInfo.Arguments = "adb deviecs";
                    process.StartInfo.WorkingDirectory = (currentPath);
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.ErrorDialog = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardInput.WriteLine($"python run.py --input_folder \"{m_tempFolder_input}\" --output_folder \"{m_tempFolder_output}\" --GPU 0 {(scratch_mode.Checked ? "--with_scratch" : String.Empty)}");
                    process.StandardInput.WriteLine($"exit");
                    Thread.Sleep(1000);
                    process.StandardInput.AutoFlush = true;
                    process.WaitForExit();
                    process.Close();
                    output.Text = $"Outputing for {fullinputfilename}.";
                    CopyFilesUnderDirectory(Path.Combine(m_tempFolder_output, "final_output"), destFolder);

                    progressBar.Value = progress * 100 / file_list.Items.Count;
                    output.Text = $"Finished handle {fullinputfilename}.";
                }
            }
            catch (Exception e)
            {
                output.Text = $"Error happened: {e.ToString()}";
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fName = openFileDialog.SelectedPath;
                source_text.Text = fName;
                List<string> files = new List<string>(Directory.GetFiles(fName, "*"));
                file_list.Items.Clear();
                foreach (var file in files)
                {
                    file_list.Items.Add(file);
                }
            }
        }

        private void source_text_TextChanged(object sender, EventArgs e)
        {
            file_list.Items.Clear();
            try
            {
                List<string> files = new List<string>(Directory.GetFiles(source_text.Text, "*"));
                foreach (var file in files)
                {
                    file_list.Items.Add(file);
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fName = openFileDialog.SelectedPath;
                dest_text.Text = fName;
            }
        }

        private void select_temp_but_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fName = openFileDialog.SelectedPath;
                temp_folder.Text = fName;
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (source_text.Text.Length == 0)
            {
                output.Text = "Please set source folder.";
                return;
            }
            if (dest_text.Text.Length == 0)
            {
                output.Text = "Please set destinate folder.";
                return;
            }
            if (temp_folder.Text.Length == 0)
            {
                output.Text = "Please set temp folder.";
                return;
            }
            DoProgress(source_text.Text, dest_text.Text, temp_folder.Text);
        }
    }
}
