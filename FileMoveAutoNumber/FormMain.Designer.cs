
namespace FileMoveAutoNumber
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSourceFolder = new System.Windows.Forms.Button();
            this.buttonTargetFolder = new System.Windows.Forms.Button();
            this.buttonMergeFile = new System.Windows.Forms.Button();
            this.labelSourceFolder = new System.Windows.Forms.Label();
            this.labelTargetFolder = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSourceFolder
            // 
            this.buttonSourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSourceFolder.Location = new System.Drawing.Point(12, 12);
            this.buttonSourceFolder.Name = "buttonSourceFolder";
            this.buttonSourceFolder.Size = new System.Drawing.Size(173, 65);
            this.buttonSourceFolder.TabIndex = 0;
            this.buttonSourceFolder.Text = "지정 폴더";
            this.buttonSourceFolder.UseVisualStyleBackColor = true;
            this.buttonSourceFolder.Click += new System.EventHandler(this.ButtonSourceFolder_Click);
            // 
            // buttonTargetFolder
            // 
            this.buttonTargetFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTargetFolder.Location = new System.Drawing.Point(12, 83);
            this.buttonTargetFolder.Name = "buttonTargetFolder";
            this.buttonTargetFolder.Size = new System.Drawing.Size(173, 65);
            this.buttonTargetFolder.TabIndex = 0;
            this.buttonTargetFolder.Text = "참고 폴더";
            this.buttonTargetFolder.UseVisualStyleBackColor = true;
            this.buttonTargetFolder.Click += new System.EventHandler(this.ButtonTargetFolder_Click);
            // 
            // buttonMergeFile
            // 
            this.buttonMergeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMergeFile.Location = new System.Drawing.Point(12, 154);
            this.buttonMergeFile.Name = "buttonMergeFile";
            this.buttonMergeFile.Size = new System.Drawing.Size(173, 65);
            this.buttonMergeFile.TabIndex = 0;
            this.buttonMergeFile.Text = "실행\r\n\r\n[참고 -> 지정 이동]";
            this.buttonMergeFile.UseVisualStyleBackColor = true;
            this.buttonMergeFile.Click += new System.EventHandler(this.ButtonMergeFile_Click);
            // 
            // labelSourceFolder
            // 
            this.labelSourceFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSourceFolder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSourceFolder.Location = new System.Drawing.Point(191, 13);
            this.labelSourceFolder.Name = "labelSourceFolder";
            this.labelSourceFolder.Size = new System.Drawing.Size(867, 64);
            this.labelSourceFolder.TabIndex = 1;
            this.labelSourceFolder.Text = "label1";
            this.labelSourceFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTargetFolder
            // 
            this.labelTargetFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTargetFolder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTargetFolder.Location = new System.Drawing.Point(191, 84);
            this.labelTargetFolder.Name = "labelTargetFolder";
            this.labelTargetFolder.Size = new System.Drawing.Size(867, 64);
            this.labelTargetFolder.TabIndex = 1;
            this.labelTargetFolder.Text = "label1";
            this.labelTargetFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCount
            // 
            this.labelCount.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCount.Location = new System.Drawing.Point(191, 157);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(867, 64);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "0 / 0";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1070, 230);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelTargetFolder);
            this.Controls.Add(this.labelSourceFolder);
            this.Controls.Add(this.buttonMergeFile);
            this.Controls.Add(this.buttonTargetFolder);
            this.Controls.Add(this.buttonSourceFolder);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder File Merge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSourceFolder;
        private System.Windows.Forms.Button buttonTargetFolder;
        private System.Windows.Forms.Button buttonMergeFile;
        private System.Windows.Forms.Label labelSourceFolder;
        private System.Windows.Forms.Label labelTargetFolder;
        private System.Windows.Forms.Label labelCount;
    }
}

