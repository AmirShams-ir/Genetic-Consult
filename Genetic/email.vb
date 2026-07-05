Imports System.Net.Mail
Public Class email

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("genetics.software@gmail.com", "1285193008")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("genetics.software@gmail.com")
            e_mail.To.Add("skyweb@live.com")
            e_mail.Subject = txtSubject.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = txtMessage.Text
            Smtp_Server.Send(e_mail)
            MsgBox("ایمیل با موفقیت ارسال شد")

        Catch error_t As Exception

            MsgBox("ایمیل ارسال نشد")
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class