Public Class convert
    Private Sub convert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("mili liter to micro liter")
        ComboBox1.Items.Add("deci liter to micro liter")
        ComboBox1.Items.Add("micro liter to mili liter")
        ComboBox1.Items.Add("micro liter to deci liter")

        ComboBox2.Items.Add("mili gram to micro gram")
        ComboBox2.Items.Add("deci gram to micro gram")
        ComboBox2.Items.Add("micro gram to mili gram")
        ComboBox2.Items.Add("micro gram to deci gram")

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Variables
        Dim dblInput As Double
        Dim dblOutput As Double
        Dim dblFactor As Double

        '~~~ Converting the input entered by user to Double type
        If Double.TryParse(TextBox1.Text, dblInput) = False Then
            MessageBox.Show("قابل تبدیل نیست!")
        Else
            '~~~ Checking what conversion is selected by the user, from the ComboBox
            Select Case ComboBox1.SelectedIndex
                Case 0  '~~~ cm to m
                    dblFactor = 1000
                Case 1  '~~~ m to cm
                    dblFactor = 10000
                Case 2  '~~~ cm to mm
                    dblFactor = 1 / 1000
                Case 3  '~~~ mm to cm
                    dblFactor = 1 / 10000
            End Select

            Select Case ComboBox2.SelectedIndex
                Case 0  '~~~ cm to m
                    dblFactor = 1000
                Case 1  '~~~ m to cm
                    dblFactor = 10000
                Case 2  '~~~ cm to mm
                    dblFactor = 1 / 1000
                Case 3  '~~~ mm to cm
                    dblFactor = 1 / 10000
            End Select
            dblOutput = dblInput * dblFactor
            TextBox2.Text = dblOutput
        End If
    End Sub
End Class