namespace MediaToSecondMonitor
{
    partial class frmOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDisplay = new System.Windows.Forms.ComboBox();
            this.lstPDFFiles = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbcFileOpes = new System.Windows.Forms.TabControl();
            this.tpAdobePDF = new System.Windows.Forms.TabPage();
            this.ctlPDF2 = new MediaToSecondMonitor.ctlPDF();
            this.tpImage = new System.Windows.Forms.TabPage();
            this.ctlImage2 = new MediaToSecondMonitor.ctlImage();
            this.tpMediaPlayer = new System.Windows.Forms.TabPage();
            this.ctlMovie2 = new MediaToSecondMonitor.ctlMovie();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPDFFileName = new System.Windows.Forms.TextBox();
            this.ファイル情報 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tbcFileOpes.SuspendLayout();
            this.tpAdobePDF.SuspendLayout();
            this.tpImage.SuspendLayout();
            this.tpMediaPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDisplay);
            this.groupBox1.Location = new System.Drawing.Point(25, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "表示するディスプレイ";
            // 
            // cmbDisplay
            // 
            this.cmbDisplay.AllowDrop = true;
            this.cmbDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplay.FormattingEnabled = true;
            this.cmbDisplay.Location = new System.Drawing.Point(162, 21);
            this.cmbDisplay.Name = "cmbDisplay";
            this.cmbDisplay.Size = new System.Drawing.Size(121, 23);
            this.cmbDisplay.TabIndex = 0;
            // 
            // lstPDFFiles
            // 
            this.lstPDFFiles.FormattingEnabled = true;
            this.lstPDFFiles.ItemHeight = 15;
            this.lstPDFFiles.Location = new System.Drawing.Point(59, 185);
            this.lstPDFFiles.Name = "lstPDFFiles";
            this.lstPDFFiles.Size = new System.Drawing.Size(120, 94);
            this.lstPDFFiles.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // tbcFileOpes
            // 
            this.tbcFileOpes.Controls.Add(this.tpAdobePDF);
            this.tbcFileOpes.Controls.Add(this.tpImage);
            this.tbcFileOpes.Controls.Add(this.tpMediaPlayer);
            this.tbcFileOpes.Location = new System.Drawing.Point(274, 123);
            this.tbcFileOpes.Name = "tbcFileOpes";
            this.tbcFileOpes.SelectedIndex = 0;
            this.tbcFileOpes.Size = new System.Drawing.Size(514, 261);
            this.tbcFileOpes.TabIndex = 3;
            // 
            // tpAdobePDF
            // 
            this.tpAdobePDF.Controls.Add(this.ctlPDF2);
            this.tpAdobePDF.Location = new System.Drawing.Point(4, 25);
            this.tpAdobePDF.Name = "tpAdobePDF";
            this.tpAdobePDF.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdobePDF.Size = new System.Drawing.Size(506, 232);
            this.tpAdobePDF.TabIndex = 0;
            this.tpAdobePDF.Text = "tabPage1";
            this.tpAdobePDF.UseVisualStyleBackColor = true;
            // 
            // ctlPDF2
            // 
            this.ctlPDF2.IsHalf = false;
            this.ctlPDF2.Location = new System.Drawing.Point(26, 37);
            this.ctlPDF2.Name = "ctlPDF2";
            this.ctlPDF2.Size = new System.Drawing.Size(540, 150);
            this.ctlPDF2.TabIndex = 0;
            // 
            // tpImage
            // 
            this.tpImage.Controls.Add(this.ctlImage2);
            this.tpImage.Location = new System.Drawing.Point(4, 25);
            this.tpImage.Name = "tpImage";
            this.tpImage.Padding = new System.Windows.Forms.Padding(3);
            this.tpImage.Size = new System.Drawing.Size(506, 232);
            this.tpImage.TabIndex = 1;
            this.tpImage.Text = "tabPage2";
            this.tpImage.UseVisualStyleBackColor = true;
            // 
            // ctlImage2
            // 
            this.ctlImage2.Location = new System.Drawing.Point(51, 37);
            this.ctlImage2.Name = "ctlImage2";
            this.ctlImage2.Size = new System.Drawing.Size(150, 150);
            this.ctlImage2.TabIndex = 0;
            // 
            // tpMediaPlayer
            // 
            this.tpMediaPlayer.Controls.Add(this.ctlMovie2);
            this.tpMediaPlayer.Location = new System.Drawing.Point(4, 25);
            this.tpMediaPlayer.Name = "tpMediaPlayer";
            this.tpMediaPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpMediaPlayer.Size = new System.Drawing.Size(506, 232);
            this.tpMediaPlayer.TabIndex = 2;
            this.tpMediaPlayer.Text = "tabPage3";
            this.tpMediaPlayer.UseVisualStyleBackColor = true;
            // 
            // ctlMovie2
            // 
            this.ctlMovie2.Location = new System.Drawing.Point(131, 21);
            this.ctlMovie2.Name = "ctlMovie2";
            this.ctlMovie2.Size = new System.Drawing.Size(150, 150);
            this.ctlMovie2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtPDFFileName
            // 
            this.txtPDFFileName.Location = new System.Drawing.Point(304, 101);
            this.txtPDFFileName.Name = "txtPDFFileName";
            this.txtPDFFileName.ReadOnly = true;
            this.txtPDFFileName.Size = new System.Drawing.Size(454, 22);
            this.txtPDFFileName.TabIndex = 4;
            // 
            // ファイル情報
            // 
            this.ファイル情報.AutoSize = true;
            this.ファイル情報.Location = new System.Drawing.Point(219, 103);
            this.ファイル情報.Name = "ファイル情報";
            this.ファイル情報.Size = new System.Drawing.Size(43, 15);
            this.ファイル情報.TabIndex = 5;
            this.ファイル情報.Text = "label2";
            // 
            // frmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ファイル情報);
            this.Controls.Add(this.txtPDFFileName);
            this.Controls.Add(this.tbcFileOpes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstPDFFiles);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOperation";
            this.Text = "frmOperation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcFileOpes.ResumeLayout(false);
            this.tpAdobePDF.ResumeLayout(false);
            this.tpImage.ResumeLayout(false);
            this.tpMediaPlayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDisplay;
        private System.Windows.Forms.ListBox lstPDFFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.TabControl tbcFileOpes;
        private System.Windows.Forms.TabPage tpAdobePDF;
        private System.Windows.Forms.TabPage tpImage;
        private System.Windows.Forms.TabPage tpMediaPlayer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPDFFileName;
        private System.Windows.Forms.Label ファイル情報;
        private ctlPDF ctlPDF2;
        private ctlImage ctlImage2;
        private ctlMovie ctlMovie2;
    }
}