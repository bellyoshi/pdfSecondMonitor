﻿Public Class frmOperation
#Region "サポートするファイルの種類"

    ''' <summary>
    ''' 開ける動画の拡張子
    ''' </summary>
    Private movieExts = {"avi", "mpeg", "mp4", "wmv", "mov"}

    ''' <summary>
    ''' 開ける画像の拡張子
    ''' </summary>
    Private ImageExts = {"jpeg", "jpg", "bmp", "png", "gif", "tiff", "tif"}

    ''' <summary>
    ''' PDFの拡張子
    ''' </summary>
    Private PDFExts = {"pdf"}
#End Region

#Region "初期処理"

    Private Sub ControlEnable()
        CtlPdf1.ControlEnabled()
        CtlMovie1.ControlEnabled()
        CtlImage1.ControlEnabled()
    End Sub
    Private Sub frmOperation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        screenDetect()
        AppSettingLoad()
        ActivateForm()
        ControlEnable()
    End Sub

    Private Sub ActivateForm()

        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Activate()
        Timer1.Stop()
    End Sub

#Region "設定値"
    Private loading As Boolean
    Private Sub AppSettingLoad()
        loading = True
        cmbDisplay.SelectedIndex = My.Settings.cmbDisplaySelectedIndex
        Try
            Dim fvinfos As New List(Of FileViewParam)

            'XmlSerializerオブジェクトを作成
            Dim serializer As New System.Xml.Serialization.XmlSerializer(
                GetType(List(Of FileViewParam)))
            '読み込むファイルを開く
            Dim filename = "lstPDFFiles.xml"
            If Not IO.File.Exists(filename) Then
                Return
            End If
            Using sr As New System.IO.StreamReader(
                filename, New System.Text.UTF8Encoding(False))
                'XMLファイルから読み込み、逆シリアル化する
                fvinfos =
                DirectCast(serializer.Deserialize(sr), List(Of FileViewParam))
                'ファイルを閉じる
            End Using
            For Each info In fvinfos
                lstPDFFiles.Items.Add(info)
            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        loading = False
    End Sub

    Private Sub AppSettingSave()

        My.Settings.cmbDisplaySelectedIndex = cmbDisplay.SelectedIndex
        My.Settings.Save()

        Dim fvinfos As New List(Of FileViewParam)
        For Each info In lstPDFFiles.Items
            fvinfos.Add(info)
        Next
        Dim serializer As New System.Xml.Serialization.XmlSerializer(
            GetType(List(Of FileViewParam)))
        '書き込むファイルを開く（UTF-8 BOM無し）
        Using sw As New System.IO.StreamWriter(
            "lstPDFFiles.xml", False, New System.Text.UTF8Encoding(False))
            'シリアル化し、XMLファイルに保存する
            serializer.Serialize(sw, fvinfos)
            'ファイルを閉じる
        End Using
    End Sub

#End Region

    Private Sub screenDetect()
        'デバイス名が表示されるようにする
        Me.cmbDisplay.DisplayMember = "DeviceName"
        Me.cmbDisplay.DataSource = Screen.AllScreens

    End Sub
#End Region

#Region "終了処理"

    Private Sub frmOperation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AppSettingSave()


    End Sub
#End Region

#Region "フォームをセカンドディスプレイに表示"
    Private Sub cmbDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDisplay.SelectedIndexChanged

        If cmbDisplay.SelectedIndex < 0 Then
            Exit Sub
        End If
        If cmbDisplay.SelectedItem Is Nothing Then
            Exit Sub
        End If
        '        'フォームを表示するディスプレイのScreenを取得する
        Dim s As Screen = DirectCast(Me.cmbDisplay.SelectedItem, Screen)
        '        'フォームの開始位置をディスプレイの左上座標に設定する
        _dispacher.SetSecondScreen(s)




    End Sub



    Private _dispacher As FormDispacher = FormDispacher.GetInstance


#End Region

#Region "リストボックス処理"



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstPDFFiles.SelectedItem Is Nothing Then
            Exit Sub
        End If
        Dim fileviewinfo As FileViewParam
        fileviewinfo = lstPDFFiles.SelectedItem
        lstPDFFiles.Items.Remove(fileviewinfo)
    End Sub





    Private Sub lstFiles_Click(sender As Object, e As EventArgs) Handles lstPDFFiles.Click
        Dim fileviewinfo As FileViewParam
        fileviewinfo = lstPDFFiles.SelectedItem
        If fileviewinfo Is Nothing Then
            Exit Sub
        End If
        Dim path = fileviewinfo.FileName
        If Not IO.File.Exists(path) Then
            Dim ret = MessageBox.Show("ファイルが見つかりません。リストから削除しますか？", "ファイルがありません", MessageBoxButtons.YesNo)
            If ret = DialogResult.Yes Then
                lstPDFFiles.Items.Remove(fileviewinfo)
            End If
            Exit Sub
        End If
        txtPDFFileName.Text = fileviewinfo.FileName
        Dim ext = IO.Path.GetExtension(fileviewinfo.FileName)
        Dim imageFileViewInfo As FileViewParam = Nothing
        Dim pdfFileViewInfo As FileViewParam = Nothing
        Dim movieFileViewInfo As FileViewParam = Nothing
        If IsPDFExt(ext) Then
            tbcFileOpes.SelectTab(tpAdobePDF.TabIndex)
            pdfFileViewInfo = fileviewinfo
        ElseIf IsImageExt(ext) Then
            tbcFileOpes.SelectTab(tpImage.TabIndex)
            imageFileViewInfo = fileviewinfo
        ElseIf IsMovieExt(ext) Then
            tbcFileOpes.SelectTab(tpMediaPlayer.TabIndex)
            movieFileViewInfo = fileviewinfo
        End If
        CtlImage1.SetFileInfo(imageFileViewInfo)
        CtlMovie1.SetFileInfo(movieFileViewInfo)
        CtlPdf1.SetFileInfo(pdfFileViewInfo)
        ControlEnable()
    End Sub


    Private Function IsContain(ext As String, exts As String()) As Boolean
        For Each target In exts
            If String.Compare($".{target}", ext, True) = 0 Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Function IsPDFExt(ext) As Boolean
        Return IsContain(ext, PDFExts)
    End Function

    Private Function IsImageExt(ext) As Boolean
        Return IsContain(ext, ImageExts)
    End Function

    Private Function IsMovieExt(ext) As Boolean
        Return IsContain(ext, movieExts)
    End Function

    Private Function CreateFilter() As String
        Dim buf As New System.Text.StringBuilder
        buf.Append("画像、動画、PDFファイル")
        buf.Append("|")
        buf.Append(CreateExtsOfFilter(PDFExts))
        buf.Append(CreateExtsOfFilter(ImageExts))
        buf.Append(CreateExtsOfFilter(movieExts))
        buf.Append("|")
        buf.Append("All Files(*.*)")
        buf.Append("|")
        buf.Append("*.*")
        Return buf.ToString()
    End Function

    Private Function CreateExtsOfFilter(ByVal exts As String()) As String
        Dim buf = New System.Text.StringBuilder
        For Each ext In exts
            buf.Append("*.")
            buf.Append(ext)
            buf.Append(";")
        Next
        Return buf.ToString()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFileAdd.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Filter = CreateFilter()
        OpenFileDialog1.FileName = txtPDFFileName.Text
        Dim ret = OpenFileDialog1.ShowDialog()
        If ret = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        Dim items = lstPDFFiles.Items

        For Each filename In OpenFileDialog1.FileNames
            items.Add(New FileViewParam(filename))
        Next


    End Sub

    Private Sub btnUnSelect_Click(sender As Object, e As EventArgs) Handles btnUnSelect.Click
        lstPDFFiles.SelectedItem = Nothing
        _dispacher.CloseViewers()
        ControlEnable()
    End Sub

#Region "ドラッグアンドドロップ"
    Private Sub lstPDFFiles_DragEnter(sender As Object, e As DragEventArgs) Handles lstPDFFiles.DragEnter
        'コントロール内にドラッグされたとき実行される
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            'ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
            e.Effect = DragDropEffects.Copy
        Else
            'ファイル以外は受け付けない
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lstPDFFiles_DragDrop(sender As Object, e As DragEventArgs) Handles lstPDFFiles.DragDrop
        Dim items = lstPDFFiles.Items
        Dim fileName As String() = CType(
                e.Data.GetData(DataFormats.FileDrop, False),
                String())

        For Each f In fileName
            items.Add(New FileViewParam(f))
        Next
    End Sub
#End Region








#End Region

End Class