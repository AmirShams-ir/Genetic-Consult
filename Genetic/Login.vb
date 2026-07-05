Imports System.Text
Public Class Login

    Dim Con As New OleDb.OleDbConnection
    Dim Cmd As New OleDb.OleDbCommand
    Dim ds As New DataSet

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=|DataDirectory|\Database.mdb"
        Cmd.Connection = Con
        Cmd.CommandText = "Select * From user1 where User ='" + UsernameTextBox.Text + "'"
        Dim da As New OleDb.OleDbDataAdapter(Cmd.CommandText, Con)
        Con.Open()
        ds.Clear()
        ds.Reset()
        da.Fill(ds)
        Con.Close()
        Try
            ds.Tables(0).Rows.Item(0).Item(1) = PasswordTextBox.Text
            Consult.StartPosition = FormStartPosition.CenterScreen
            Consult.Show()
            Me.Hide()
        Catch
            MessageBox.Show("نام کاربری و یا کلمه عبور اشتباه می باشد", "خطا در ورود به سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End Try



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

End Class
