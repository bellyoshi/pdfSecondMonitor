Public Class CtlImage

    Private _dispacher As FormDispacher = FormDispacher.GetInstance

    Private _pictureBox As PictureBox

    Private Sub Rotate(flip As RotateFlipType)
        Dim bmp As Bitmap = New Bitmap(_fileViewParam.FileName)
        bmp.RotateFlip(flip)
        _pictureBox.Image = bmp
    End Sub
    Private Sub None()
        _pictureBox.ImageLocation = _fileViewParam.FileName
    End Sub
    Private Sub btnRotate_Click(sender As Object, e As EventArgs) Handles btnRotate180.Click
        Rotate(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub btnRotate90_Click(sender As Object, e As EventArgs) Handles btnRotate90.Click
        Rotate(RotateFlipType.Rotate90FlipNone)
    End Sub

    Private Sub btnRotate0_Click(sender As Object, e As EventArgs) Handles btnRotate0.Click
        None()
    End Sub

    Private Sub btnRotate270_Click(sender As Object, e As EventArgs) Handles btnRotateM90.Click
        Rotate(RotateFlipType.Rotate270FlipNone)
    End Sub

    Private _fileViewParam As FileViewParam

    Public Sub SetFileInfo(f As FileViewParam)
        Me._fileViewParam = f
        If f Is Nothing Then
            Return
        End If
        _pictureBox = _dispacher.ShowImage()
        None()
        _pictureBox.SizeMode = PictureBoxSizeMode.Zoom 'サイズ調整


    End Sub

    Public Sub ControlEnabled()

        Me.Enabled = Not (_fileViewParam Is Nothing)

    End Sub

End Class
