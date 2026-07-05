Imports System.Windows.Forms
Imports System.Security.Permissions
Public Class sms
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim urls As String = "http://www.payam-resan.com/APISend.aspx?Username=amirshams&Password=network&From=50002060005050&To=" + "TextBox1.text" + "&Text=" + "TextBox2.text"
        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Navigate(urls)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate("http://www.payam-resan.com/Credit.aspx?Username=amirshams&Password=network")
    End Sub
End Class