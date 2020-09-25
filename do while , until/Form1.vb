Public Class Form1
    Private Sub btnClickToShow_Click(sender As Object, e As EventArgs) Handles btnClickToShow.Click
        Dim MaraNgapi As Integer
        Dim i As Integer, jina As String
        i = 1
        jina = InputBox("Enter your name please")
        MaraNgapi = InputBox(jina & " How many times do you want the message to be displayed")
        Do Until (i > MaraNgapi)
            MessageBox.Show(i & jina & " Smile Rejoice, God loves you and Fay loves you")
            i = i + 1
        Loop
        MessageBox.Show(jina & "Praise and Glorify the Almighty God")
    End Sub
End Class
