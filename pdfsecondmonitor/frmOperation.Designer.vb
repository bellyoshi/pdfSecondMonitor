﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperation
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmbDisplay = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tpMediaPlayer = New System.Windows.Forms.TabPage()
        Me.tbcFileOpes = New System.Windows.Forms.TabControl()
        Me.tpAdobePDF = New System.Windows.Forms.TabPage()
        Me.tpImage = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPDFFileName = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lstPDFFiles = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnUnSelect = New System.Windows.Forms.Button()
        Me.btnFileAdd = New System.Windows.Forms.Button()
        Me.CtlPdf1 = New pdfsecondmonitor.ctlPdf()
        Me.CtlMovie1 = New pdfsecondmonitor.ctlMovie()
        Me.CtlImage1 = New pdfsecondmonitor.CtlImage()
        Me.GroupBox1.SuspendLayout()
        Me.tpMediaPlayer.SuspendLayout()
        Me.tbcFileOpes.SuspendLayout()
        Me.tpAdobePDF.SuspendLayout()
        Me.tpImage.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmbDisplay
        '
        Me.cmbDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDisplay.FormattingEnabled = True
        Me.cmbDisplay.Location = New System.Drawing.Point(218, 12)
        Me.cmbDisplay.Name = "cmbDisplay"
        Me.cmbDisplay.Size = New System.Drawing.Size(163, 23)
        Me.cmbDisplay.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "表示するディスプレイ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDisplay)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 54)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "設定"
        '
        'Timer1
        '
        '
        'tpMediaPlayer
        '
        Me.tpMediaPlayer.Controls.Add(Me.CtlMovie1)
        Me.tpMediaPlayer.Location = New System.Drawing.Point(4, 25)
        Me.tpMediaPlayer.Name = "tpMediaPlayer"
        Me.tpMediaPlayer.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMediaPlayer.Size = New System.Drawing.Size(760, 335)
        Me.tpMediaPlayer.TabIndex = 1
        Me.tpMediaPlayer.Text = "動画"
        Me.tpMediaPlayer.UseVisualStyleBackColor = True
        '
        'tbcFileOpes
        '
        Me.tbcFileOpes.Controls.Add(Me.tpAdobePDF)
        Me.tbcFileOpes.Controls.Add(Me.tpMediaPlayer)
        Me.tbcFileOpes.Controls.Add(Me.tpImage)
        Me.tbcFileOpes.Location = New System.Drawing.Point(362, 114)
        Me.tbcFileOpes.Name = "tbcFileOpes"
        Me.tbcFileOpes.SelectedIndex = 0
        Me.tbcFileOpes.Size = New System.Drawing.Size(768, 364)
        Me.tbcFileOpes.TabIndex = 12
        '
        'tpAdobePDF
        '
        Me.tpAdobePDF.Controls.Add(Me.CtlPdf1)
        Me.tpAdobePDF.Location = New System.Drawing.Point(4, 25)
        Me.tpAdobePDF.Name = "tpAdobePDF"
        Me.tpAdobePDF.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAdobePDF.Size = New System.Drawing.Size(760, 335)
        Me.tpAdobePDF.TabIndex = 0
        Me.tpAdobePDF.Text = "PDFの表示"
        Me.tpAdobePDF.UseVisualStyleBackColor = True
        '
        'tpImage
        '
        Me.tpImage.Controls.Add(Me.CtlImage1)
        Me.tpImage.Location = New System.Drawing.Point(4, 25)
        Me.tpImage.Name = "tpImage"
        Me.tpImage.Padding = New System.Windows.Forms.Padding(3)
        Me.tpImage.Size = New System.Drawing.Size(760, 335)
        Me.tpImage.TabIndex = 2
        Me.tpImage.Text = "画像"
        Me.tpImage.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ファイル情報"
        '
        'txtPDFFileName
        '
        Me.txtPDFFileName.Location = New System.Drawing.Point(362, 86)
        Me.txtPDFFileName.Name = "txtPDFFileName"
        Me.txtPDFFileName.ReadOnly = True
        Me.txtPDFFileName.Size = New System.Drawing.Size(655, 22)
        Me.txtPDFFileName.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(101, 536)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lstPDFFiles
        '
        Me.lstPDFFiles.AllowDrop = True
        Me.lstPDFFiles.FormattingEnabled = True
        Me.lstPDFFiles.ItemHeight = 15
        Me.lstPDFFiles.Location = New System.Drawing.Point(34, 170)
        Me.lstPDFFiles.Name = "lstPDFFiles"
        Me.lstPDFFiles.Size = New System.Drawing.Size(308, 349)
        Me.lstPDFFiles.TabIndex = 19
        '
        'btnUnSelect
        '
        Me.btnUnSelect.Location = New System.Drawing.Point(53, 126)
        Me.btnUnSelect.Name = "btnUnSelect"
        Me.btnUnSelect.Size = New System.Drawing.Size(267, 23)
        Me.btnUnSelect.TabIndex = 20
        Me.btnUnSelect.Text = "選択解除"
        Me.btnUnSelect.UseVisualStyleBackColor = True
        '
        'btnFileAdd
        '
        Me.btnFileAdd.Location = New System.Drawing.Point(212, 536)
        Me.btnFileAdd.Name = "btnFileAdd"
        Me.btnFileAdd.Size = New System.Drawing.Size(130, 23)
        Me.btnFileAdd.TabIndex = 21
        Me.btnFileAdd.Text = "ファイルを追加する"
        Me.btnFileAdd.UseVisualStyleBackColor = True
        '
        'CtlPdf1
        '
        Me.CtlPdf1.Location = New System.Drawing.Point(6, 31)
        Me.CtlPdf1.Name = "CtlPdf1"
        Me.CtlPdf1.Size = New System.Drawing.Size(705, 128)
        Me.CtlPdf1.TabIndex = 0
        '
        'CtlMovie1
        '
        Me.CtlMovie1.Location = New System.Drawing.Point(37, 31)
        Me.CtlMovie1.Name = "CtlMovie1"
        Me.CtlMovie1.Size = New System.Drawing.Size(467, 166)
        Me.CtlMovie1.TabIndex = 0
        '
        'CtlImage1
        '
        Me.CtlImage1.Location = New System.Drawing.Point(28, 31)
        Me.CtlImage1.Name = "CtlImage1"
        Me.CtlImage1.Size = New System.Drawing.Size(600, 179)
        Me.CtlImage1.TabIndex = 0
        '
        'frmOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 649)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnFileAdd)
        Me.Controls.Add(Me.btnUnSelect)
        Me.Controls.Add(Me.tbcFileOpes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstPDFFiles)
        Me.Controls.Add(Me.txtPDFFileName)
        Me.Name = "frmOperation"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpMediaPlayer.ResumeLayout(False)
        Me.tbcFileOpes.ResumeLayout(False)
        Me.tpAdobePDF.ResumeLayout(False)
        Me.tpImage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents cmbDisplay As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents tpMediaPlayer As TabPage
    Friend WithEvents tbcFileOpes As TabControl
    Friend WithEvents tpAdobePDF As TabPage
    Friend WithEvents txtPDFFileName As TextBox
    Friend WithEvents lstPDFFiles As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnUnSelect As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnFileAdd As Button
    Friend WithEvents tpImage As TabPage
    Friend WithEvents CtlPdf1 As ctlPdf
    Friend WithEvents CtlImage1 As CtlImage
    Friend WithEvents CtlMovie1 As ctlMovie
End Class
