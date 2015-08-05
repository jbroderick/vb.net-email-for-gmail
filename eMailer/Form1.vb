Imports System.Net
Imports System.Net.Mail

Public Class frmMain
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        ' depending on your security preferences you may have to gerneate a app specific password to
        ' send emails via gmail and then use it under smtp.credentials with your username
        ' https://security.google.com/settings/security/apppasswords


        Dim mail As New MailMessage
        Dim smtp As New SmtpClient("smtp.gmail.com")

        mail.To.Add(txtToEmail.Text)
        mail.From = New MailAddress(txtFromEmail.Text)
        mail.Subject = txtSubject.Text
        mail.Body = txtBody.Text

        smtp.Credentials = New NetworkCredential("youremailaddress@gmail.com", "pA55W0rD") ' replace with your username and password
        smtp.EnableSsl = True
        smtp.Port = "587"

        Try
            smtp.Send(mail)

            MsgBox("eMail has been sent",, "eMailer for Gmail")

        Catch ex As Exception

            MsgBox(ex.ToString(),, "eMailer for Gmail")

        End Try

        mail.Dispose()
        smtp.Dispose()

        txtToEmail.Text = ""
        txtFromEmail.Text = ""
        txtSubject.Text = ""
        txtBody.Text = ""

    End Sub
End Class
