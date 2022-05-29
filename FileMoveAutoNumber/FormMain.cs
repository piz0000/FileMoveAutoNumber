using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FileMoveAutoNumber
{
    public partial class FormMain : Form
    {
        string SourceFolder = string.Empty;
        string TargetFolder = string.Empty;
        int fileNameCount = 0;

        string programFilesFolder;
        string programFilesFile1;
        string programFilesFile2;


        public FormMain()
        {
            InitializeComponent();

            programFilesFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\" + GetType().Namespace + "\\";
            programFilesFile1 = programFilesFolder + "SourcePath.txt";
            programFilesFile2 = programFilesFolder + "TargetPath.txt";

            try
            {
                Directory.CreateDirectory(programFilesFolder);

                if (File.Exists(programFilesFile1))
                {
                    SourceFolder = File.ReadAllText(programFilesFile1);

                    labelSourceFolder.Text = SourceFolder;
                }

                if (File.Exists(programFilesFile2))
                {
                    TargetFolder = File.ReadAllText(programFilesFile2);

                    labelTargetFolder.Text = TargetFolder;
                }
            }
            catch
            {
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            SaveFolderPath();
        }

        void ButtonSourceFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = SourceFolder;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    SourceFolder = fbd.SelectedPath;
                }

                labelSourceFolder.Text = SourceFolder;
            }
        }

        void ButtonTargetFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = TargetFolder;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    TargetFolder = fbd.SelectedPath;                   
                }

                labelTargetFolder.Text = TargetFolder;
            }
        }

        void SaveFolderPath()
        {
            try
            {
                Directory.CreateDirectory(programFilesFolder);

                File.Delete(programFilesFile1);

                File.Delete(programFilesFile2);

                File.AppendAllText(programFilesFile1, SourceFolder);

                File.AppendAllText(programFilesFile2, TargetFolder);
            }
            catch
            {
            }
        }

        void ButtonMergeFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SourceFolder)) return;

            if (string.IsNullOrEmpty(TargetFolder)) return;

            string[] targetFolderFiles2 = Directory.GetFiles(TargetFolder, "*.*", SearchOption.TopDirectoryOnly);

            if (targetFolderFiles2.Length <= 0) return;

            labelCount.Text = "0 / " + targetFolderFiles2.Length;

            int completeCount = 1;

            for (int index = 0; index < targetFolderFiles2.Length; index++)
            {
                //중복 카운트 초기화
                fileNameCount = 0;

                string moveFile = NewName(SourceFolder, targetFolderFiles2[index]);

                try
                {
                    File.Move(targetFolderFiles2[index], moveFile);

                    completeCount++;
                }
                catch
                {

                }
            }

            labelCount.Text = completeCount + " / " + targetFolderFiles2.Length;
        }

        string NewName(string sourceFolder, string targetFile)
        {
            //파일 이름
            string fileName = Path.GetFileNameWithoutExtension(targetFile);
            //확장 이름
            string fileExte = Path.GetExtension(targetFile);

            //최종 이름
            string mergeName = sourceFolder + "\\" + fileName + fileExte;

            if (File.Exists(mergeName))
            {
                //(N) 붙여서 다시 체크 

                //중복 카운트 증가
                fileNameCount++;

                string newName = sourceFolder + "\\" + fileName + " (" + fileNameCount + ")" + fileExte;

                return NewName(sourceFolder, newName);
            }
            else
            {
                //이름 전달
                return mergeName;
            }
        }
    }
}
