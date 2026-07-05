Public Class dictionary
    Dim i As Integer
    Dim Connection1 As New OleDb.OleDbConnection
    Dim dataset1 As New DataSet
    Dim Command As New OleDb.OleDbCommand
    Dim Connection2 As New OleDb.OleDbConnection
    Dim dataset2 As New DataSet
    Dim Command2 As New OleDb.OleDbCommand
    Private Sub Dic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset1 As New DataSet
        Dim StrConnection As String
        StrConnection = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=|DataDirectory|\DataBase.mdb"
        Connection1.ConnectionString = StrConnection
        Connection1.Open()
        Connection2.ConnectionString = StrConnection
        Connection2.Open()
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ListBox1.Items.Clear()
        Command.CommandText = "SELECT * FROM words Where words.loghat Like '%" + TextBox1.Text + "%'"
        Dim Adapter As New OleDb.OleDbDataAdapter(Command.CommandText, Connection1)
        dataset1.Clear()
        dataset1.Reset()
        Adapter.Fill(dataset1)
        If dataset1.Tables(0).Rows.Count <> 0 Then
            For i = 0 To dataset1.Tables(0).Rows.Count - 1
                ListBox1.Items.Add(dataset1.Tables(0).Rows(i).Item(0))
            Next
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Command2.CommandText = "SELECT * FROM words WHERE words.loghat ='" + ListBox1.Items.Item(ListBox1.SelectedIndex) + "'"
            Dim Adapter2 As New OleDb.OleDbDataAdapter(Command2.CommandText, Connection2)
            dataset2.Clear()
            dataset2.Reset()
            Adapter2.Fill(dataset2)
            If dataset2.Tables.Count > 0 Then
                txt_lgh.Text = dataset2.Tables(0).Rows(0).Item(0)
                txt_trj.Text = dataset2.Tables(0).Rows(0).Item(1)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Connection1.Close()
        Connection2.Close()
        Me.Close()
    End Sub

End Class