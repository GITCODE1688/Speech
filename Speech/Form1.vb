



Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyVoice As New SpeechLib.SpVoice
        Dim strData As String
        strData = StrConv(TextBox1.Text, VbStrConv.SimplifiedChinese, 2052)     ''''''test
        MyVoice.Speak(strData)
    End Sub
End Class
