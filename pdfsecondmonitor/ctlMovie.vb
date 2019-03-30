Public Class ctlMovie
    Private _dispacher As FormDispacher = FormDispacher.GetInstance


    Private player As AxWMPLib.AxWindowsMediaPlayer

    Private _fileViewParam As FileViewParam

    Public Sub SetFileInfo(f As FileViewParam)
        Me._fileViewParam = f
        If _fileViewParam Is Nothing Then
            Return
        End If
        player = _dispacher.ShowMovie()

        player.URL = _fileViewParam.FileName
        player.uiMode = "none"
        player.stretchToFit = True

    End Sub

#Region "Media Playerの処理"

    Private inPlay As Boolean = False


    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        player.Ctlcontrols.play()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        player.Ctlcontrols.pause()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnFastForward.Click
        player.Ctlcontrols.fastForward()
    End Sub

    Private Sub btnFastReverse_Click(sender As Object, e As EventArgs) Handles btnFastReverse.Click
        player.Ctlcontrols.fastReverse()
    End Sub


    Public Sub ControlEnabled()

        Me.Enabled = Not (_fileViewParam Is Nothing)

    End Sub






#End Region
End Class
