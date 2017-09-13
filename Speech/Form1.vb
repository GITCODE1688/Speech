



Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyVoice As New SpeechLib.SpVoice
        Dim strData As String
        strData = StrConv(TextBox1.Text, VbStrConv.SimplifiedChinese, 2052)     '22222
        MyVoice.Speak(strData)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "南無密斯佛陀"      'add load
        Button1_Click(Nothing, Nothing)
    End Sub
End Class
