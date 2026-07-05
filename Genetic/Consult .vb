Imports System.IO
Imports System.IO.Stream
Imports System.Text
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing.Imaging

Public Class Consult
    Dim str(22) As String

    Dim Con As New SqlClient.SqlConnection
    Dim Cmd As New SqlClient.SqlCommand

    Private Sub برگشتبهصفحهاصلیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles برگشتبهصفحهاصلیToolStripMenuItem.Click
        Login.StartPosition = FormStartPosition.CenterScreen
        Login.Show()
        Me.Close()
    End Sub

    Private Sub خروجازبرنامهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles خروجازبرنامهToolStripMenuItem.Click
        End
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        staffs1.StartPosition = FormStartPosition.CenterScreen
        staffs1.Show()
    End Sub

    Private Sub کاربرسیستمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles کاربرسیستمToolStripMenuItem.Click
        users1.StartPosition = FormStartPosition.CenterScreen
        users1.Show()
    End Sub

    Private Sub پزشکمعالجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پزشکمعالجToolStripMenuItem.Click
        doctors1.StartPosition = FormStartPosition.CenterScreen
        doctors1.Show()
    End Sub

    Private Sub پزشکمشاورToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پزشکمشاورToolStripMenuItem.Click
        doctors1.StartPosition = FormStartPosition.CenterScreen
        doctors1.Show()
    End Sub

    Private Sub پزشکمعرفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پزشکمعرفToolStripMenuItem.Click
        doctors1.StartPosition = FormStartPosition.CenterScreen
        doctors1.Show()
    End Sub

    Private Sub نوشتننسخهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles نوشتننسخهToolStripMenuItem.Click
        dictionary.StartPosition = FormStartPosition.CenterScreen
        dictionary.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        print.StartPosition = FormStartPosition.CenterScreen
        print.Show()
    End Sub

    Private Sub تهيهنسخهپشتيبانToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تهيهنسخهپشتيبانToolStripMenuItem.Click
        backup.StartPosition = FormStartPosition.CenterScreen
        backup.Show()
    End Sub

    Private Sub بازگرداندننسخهپشتيبانToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بازگرداندننسخهپشتيبانToolStripMenuItem.Click
        backup.StartPosition = FormStartPosition.CenterScreen
        backup.Show()
    End Sub

    Private Sub پاککردنتمامیفیلدهاToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles پاککردنتمامیفیلدهاToolStripMenuItem.Click
        MsgBox("ارتباط با سرور مرکزی برقرار نیست", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub تقویمسالToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تقویمسالToolStripMenuItem.Click
        calendar.StartPosition = FormStartPosition.CenterScreen
        calendar.Show()
    End Sub

    Private Sub مبدلواحدهاToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مبدلواحدهاToolStripMenuItem.Click
        convert.StartPosition = FormStartPosition.CenterScreen
        convert.Show()
    End Sub

    Private Sub ماشینحسابToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ماشینحسابToolStripMenuItem.Click
        calculator.StartPosition = FormStartPosition.CenterScreen
        calculator.Show()
    End Sub

    Private Sub اسکنتصاویرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اسکنتصاویرToolStripMenuItem.Click
        scan.StartPosition = FormStartPosition.CenterScreen
        scan.Show()
    End Sub

    Private Sub ارسالپیامکToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ارسالپیامکToolStripMenuItem.Click
        sms.StartPosition = FormStartPosition.CenterScreen
        sms.Show()
    End Sub

    Private Sub رسمشجرهنامهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles رسمشجرهنامهToolStripMenuItem.Click
        prescription.StartPosition = FormStartPosition.CenterScreen
        prescription.Show()
    End Sub

    Private Sub ارتباطباماToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ارتباطباماToolStripMenuItem.Click
        email.StartPosition = FormStartPosition.CenterScreen
        email.Show()
    End Sub
    Private Sub آموزشToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles آموزشToolStripMenuItem.Click
        learn.StartPosition = FormStartPosition.CenterScreen
        learn.Show()
    End Sub

    Private Sub قوانینومقرارتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles قوانینومقرارتToolStripMenuItem.Click
        laws.StartPosition = FormStartPosition.CenterScreen
        laws.Show()
    End Sub

    Private Sub حریمخصوصیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حریمخصوصیToolStripMenuItem.Click
        privacy.StartPosition = FormStartPosition.CenterScreen
        privacy.Show()
    End Sub

    Private Sub دربارهماToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles دربارهماToolStripMenuItem.Click
        info.StartPosition = FormStartPosition.CenterScreen
        info.Show()
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Try
            Con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Cmd.Connection = Con
            Cmd.CommandText = "Insert Into couple ([case],consult,[f-name],[f-family],[f-education],[f-national],[f-certificate],[f-job],[f-relation],[f-race],[f-religion],[f-marriage],[f-children],[f-age],[m-name],[m-family],[m-education],[m-national],[m-certificate],[m-job],[m-relation],[m-race],[m-religion],[m-marriage],[m-children],[m-age],address,tel,cell,email,[f-disease],[f-infertility],[f-abortion],[f-prebirth],[f-admission],[f-surgery],[f-alcoholism],[f-addiction],[f-radiation],[f-teratogen],[f-allergies],[f-std],[f-other],[m-disease],[m-counsult],[m-marry],[m-sex],[m-admission],[m-surgery],[m-alcoholism],[m-addiction],[m-radiation],[m-teratogen],[m-allergies],[m-std],[m-other],[f-relation1],[f-relation2],[f-relation3],[f-relation4],[f-relation5],[f-illness1],[f-illness2],[f-illness3],[f-illness4],[f-illness5],[f-history1],[f-history2],[f-history3],[f-history4],[f-history5],[f-history6],[m-relation1],[m-relation2],[m-relation3],[m-relation4],[m-relation5],[m-illness1],[m-illness2],[m-illness3],[m-illness4],[m-illness5],[m-history1],[m-history2],[m-history3],[m-history4],[m-history5],[m-history6],illness1,illness2,illness3,heredity1,heredity2,heredity3,result1,result2,result3,risk1,risk2,risk3,action,advise,committee) 
            values ('" + TextBox_case.Text + "','" + ComboBox_consult.SelectedItem + "','" + TextBox_fname.Text + "','" + TextBox_ffamily.Text + "','" + ComboBox_feducation.SelectedItem + "','" + TextBox_fnational.Text + "','" + TextBox_fcertificate.Text + "','" + TextBox_fjob.Text + "','" + TextBox_frelation.Text + "','" + ComboBox_frace.SelectedItem + "','" + ComboBox_freligion.Text + "','" + ComboBox_fmarriage.Text + "','" + TextBox_fchildren.Text + "','" + TextBox_fage.Text + "','" + TextBox_mname.Text + "','" + TextBox_mfamily.Text + "','" + ComboBox_meducation.SelectedItem + "','" + TextBox_mnational.Text + "','" + TextBox_mcertificate.Text + "','" + TextBox_mjob.Text + "','" + TextBox_mrelation.Text + "','" + ComboBox_mrace.SelectedItem + "','" + ComboBox_mreligion.SelectedItem + "','" + ComboBox_mmarriage.SelectedItem + "','" + TextBox_mchildren.Text + "','" + TextBox_mage.Text + "','" + TextBox_address.Text + "','" + TextBox_tel.Text + "','" + TextBox_cell.Text + "','" + TextBox_email.Text + "','" + TextBox_fdisease.Text + "','" + TextBox_finfertility.Text + "','" + TextBox_fabortion.Text + "','" + TextBox_fprebirth.Text + "','" + TextBox_fadmission.Text + "','" + TextBox_fsurgery.Text + "','" + TextBox_falcoholism.Text + "','" + TextBox_faddiction.Text + "','" + TextBox_fradiation.Text + "','" + TextBox_fteratogen.Text + "','" + TextBox_fallergies.Text + "','" + TextBox_fstd.Text + "','" + TextBox_fother.Text + "','" + TextBox_mdisease.Text + "','" + TextBox_mcounsult.Text + "','" + TextBox_mmarry.Text + "','" + TextBox_msex.Text + "','" + TextBox_madmission.Text + "','" + TextBox_msurgery.Text + "','" + TextBox_malcoholism.Text + "','" + TextBox_maddiction.Text + "','" + TextBox_mradiation.Text + "','" + TextBox_mteratogen.Text + "','" + TextBox_mallergies.Text + "','" + TextBox_mstd.Text + "','" + TextBox_mother.Text + "','" + ComboBox_fr1.SelectedItem + "','" + ComboBox_fr2.SelectedItem + "','" + ComboBox_fr3.SelectedItem + "','" + ComboBox_fr4.SelectedItem + "','" + ComboBox_fr5.SelectedItem + "','" + ComboBox_fd1.SelectedItem + "','" + ComboBox_fd2.SelectedItem + "','" + ComboBox_fd3.SelectedItem + "','" + ComboBox_fd4.SelectedItem + "','" + ComboBox_fd5.SelectedItem + "','" + TextBox_fhistory1.Text + "','" + TextBox_fhistory2.Text + "','" + TextBox_fhistory3.Text + "','" + TextBox_fhistory4.Text + "','" + TextBox_fhistory5.Text + "','" + TextBox_fhistory6.Text + "','" + ComboBox_mr1.SelectedItem + "','" + ComboBox_mr2.SelectedItem + "','" + ComboBox_mr3.SelectedItem + "','" + ComboBox_mr4.SelectedItem + "','" + ComboBox_mr5.SelectedItem + "','" + ComboBox_md1.SelectedItem + "','" + ComboBox_md2.SelectedItem + "','" + ComboBox_md3.SelectedItem + "','" + ComboBox_md4.SelectedItem + "','" + ComboBox_md5.SelectedItem + "','" + TextBox_mhistory1.Text + "','" + TextBox_mhistory2.Text + "','" + TextBox_mhistory3.Text + "','" + TextBox_mhistory4.Text + "','" + TextBox_mhistory5.Text + "','" + TextBox_mhistory6.Text + "','" + TextBox_illness1.Text + "','" + TextBox_illness2.Text + "','" + TextBox_illness3.Text + "','" + ComboBox_heredity1.SelectedItem + "','" + ComboBox_heredity2.SelectedItem + "','" + ComboBox_heredity3.SelectedItem + "','" + TextBox_result1.Text + "','" + TextBox_result2.Text + "','" + TextBox_result3.Text + "','" + TextBox_risk1.Text + "','" + TextBox_risk2.Text + "','" + TextBox_risk3.Text + "','" + TextBox_action.Text + "','" + TextBox_advise.Text + "','" + TextBox_committee.Text + "')"
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("اطلاعات با موفقیت ثبت شد", "پایگاه داده ها", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show("اطلاعات ثبت نشد", "خطا در پایگاه داده ها", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        Try
            Con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Cmd.Connection = Con
            Cmd.CommandText = "Select * From couple where [case]='" + TextBox_case.Text + "'"
            Con.Open()
            Dim dr As SqlDataReader = Cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            Con.Close()

            ComboBox_consult.Text = dt.Rows.Item(0).Item(2).ToString()
            TextBox_fname.Text = dt.Rows.Item(0).Item(3).ToString()
            TextBox_ffamily.Text = dt.Rows.Item(0).Item(4).ToString()
            ComboBox_feducation.Text = dt.Rows.Item(0).Item(5).ToString()
            TextBox_fnational.Text = dt.Rows.Item(0).Item(6).ToString()
            TextBox_fcertificate.Text = dt.Rows.Item(0).Item(7).ToString()
            TextBox_fjob.Text = dt.Rows.Item(0).Item(8).ToString()
            TextBox_frelation.Text = dt.Rows.Item(0).Item(9).ToString()
            ComboBox_frace.Text = dt.Rows.Item(0).Item(10).ToString()
            ComboBox_freligion.Text = dt.Rows.Item(0).Item(11).ToString()
            ComboBox_fmarriage.Text = dt.Rows.Item(0).Item(12).ToString()
            TextBox_fchildren.Text = dt.Rows.Item(0).Item(13).ToString()
            TextBox_fage.Text = dt.Rows.Item(0).Item(14).ToString()

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(15)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_fpic.Image = Bitmap.FromStream(MS)
                PictureBox_fpic.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            TextBox_mname.Text = dt.Rows.Item(0).Item(16).ToString()
            TextBox_mfamily.Text = dt.Rows.Item(0).Item(17).ToString()
            ComboBox_meducation.Text = dt.Rows.Item(0).Item(18).ToString()
            TextBox_mnational.Text = dt.Rows.Item(0).Item(19).ToString()
            TextBox_mcertificate.Text = dt.Rows.Item(0).Item(20).ToString()
            TextBox_mjob.Text = dt.Rows.Item(0).Item(21).ToString()
            TextBox_mrelation.Text = dt.Rows.Item(0).Item(22).ToString()
            ComboBox_mrace.Text = dt.Rows.Item(0).Item(23).ToString()
            ComboBox_mreligion.Text = dt.Rows.Item(0).Item(24).ToString()
            ComboBox_mmarriage.Text = dt.Rows.Item(0).Item(25).ToString()
            TextBox_mchildren.Text = dt.Rows.Item(0).Item(26).ToString()
            TextBox_mage.Text = dt.Rows.Item(0).Item(27).ToString()

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(28)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_mpic.Image = Bitmap.FromStream(MS)
                PictureBox_mpic.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            TextBox_address.Text = dt.Rows.Item(0).Item(29).ToString()
            TextBox_tel.Text = dt.Rows.Item(0).Item(30).ToString()
            TextBox_cell.Text = dt.Rows.Item(0).Item(31).ToString()
            TextBox_email.Text = dt.Rows.Item(0).Item(32).ToString()
            TextBox_fdisease.Text = dt.Rows.Item(0).Item(33).ToString().ToString()
            TextBox_finfertility.Text = dt.Rows.Item(0).Item(34).ToString()
            TextBox_fabortion.Text = dt.Rows.Item(0).Item(35).ToString()
            TextBox_fprebirth.Text = dt.Rows.Item(0).Item(36).ToString()
            TextBox_fadmission.Text = dt.Rows.Item(0).Item(37).ToString()
            TextBox_fsurgery.Text = dt.Rows.Item(0).Item(38).ToString()
            TextBox_falcoholism.Text = dt.Rows.Item(0).Item(39).ToString()
            TextBox_faddiction.Text = dt.Rows.Item(0).Item(40).ToString()
            TextBox_fradiation.Text = dt.Rows.Item(0).Item(41).ToString()
            TextBox_fteratogen.Text = dt.Rows.Item(0).Item(42).ToString()
            TextBox_fallergies.Text = dt.Rows.Item(0).Item(43).ToString()
            TextBox_fstd.Text = dt.Rows.Item(0).Item(44).ToString()
            TextBox_fother.Text = dt.Rows.Item(0).Item(45).ToString()
            TextBox_mdisease.Text = dt.Rows.Item(0).Item(46).ToString()
            TextBox_mcounsult.Text = dt.Rows.Item(0).Item(47).ToString()
            TextBox_mmarry.Text = dt.Rows.Item(0).Item(48).ToString()
            TextBox_msex.Text = dt.Rows.Item(0).Item(49).ToString()
            TextBox_madmission.Text = dt.Rows.Item(0).Item(50).ToString()
            TextBox_msurgery.Text = dt.Rows.Item(0).Item(51).ToString()
            TextBox_malcoholism.Text = dt.Rows.Item(0).Item(52).ToString()
            TextBox_maddiction.Text = dt.Rows.Item(0).Item(53).ToString()
            TextBox_mradiation.Text = dt.Rows.Item(0).Item(54).ToString()
            TextBox_mteratogen.Text = dt.Rows.Item(0).Item(55).ToString()
            TextBox_mallergies.Text = dt.Rows.Item(0).Item(56).ToString()
            TextBox_mstd.Text = dt.Rows.Item(0).Item(57).ToString()
            TextBox_mother.Text = dt.Rows.Item(0).Item(58).ToString()
            ComboBox_fr1.Text = dt.Rows.Item(0).Item(59).ToString()
            ComboBox_fr2.Text = dt.Rows.Item(0).Item(60).ToString()
            ComboBox_fr3.Text = dt.Rows.Item(0).Item(61).ToString()
            ComboBox_fr4.Text = dt.Rows.Item(0).Item(62).ToString()
            ComboBox_fr5.Text = dt.Rows.Item(0).Item(63).ToString()
            ComboBox_fd1.Text = dt.Rows.Item(0).Item(64).ToString()
            ComboBox_fd2.Text = dt.Rows.Item(0).Item(65).ToString()
            ComboBox_fd3.Text = dt.Rows.Item(0).Item(66).ToString()
            ComboBox_fd4.Text = dt.Rows.Item(0).Item(67).ToString()
            ComboBox_fd5.Text = dt.Rows.Item(0).Item(68).ToString()
            TextBox_fhistory1.Text = dt.Rows.Item(0).Item(69).ToString()
            TextBox_fhistory2.Text = dt.Rows.Item(0).Item(70).ToString()
            TextBox_fhistory3.Text = dt.Rows.Item(0).Item(71).ToString()
            TextBox_fhistory4.Text = dt.Rows.Item(0).Item(72).ToString()
            TextBox_fhistory5.Text = dt.Rows.Item(0).Item(73).ToString()
            TextBox_fhistory6.Text = dt.Rows.Item(0).Item(74).ToString()
            ComboBox_mr1.Text = dt.Rows.Item(0).Item(75).ToString()
            ComboBox_mr2.Text = dt.Rows.Item(0).Item(76).ToString()
            ComboBox_mr3.Text = dt.Rows.Item(0).Item(77).ToString()
            ComboBox_mr4.Text = dt.Rows.Item(0).Item(78).ToString()
            ComboBox_mr5.Text = dt.Rows.Item(0).Item(79).ToString()
            ComboBox_md1.Text = dt.Rows.Item(0).Item(80).ToString()
            ComboBox_md2.Text = dt.Rows.Item(0).Item(81).ToString()
            ComboBox_md3.Text = dt.Rows.Item(0).Item(82).ToString()
            ComboBox_md4.Text = dt.Rows.Item(0).Item(83).ToString()
            ComboBox_md5.Text = dt.Rows.Item(0).Item(84).ToString()
            TextBox_mhistory1.Text = dt.Rows.Item(0).Item(85).ToString()
            TextBox_mhistory2.Text = dt.Rows.Item(0).Item(86).ToString()
            TextBox_mhistory3.Text = dt.Rows.Item(0).Item(87).ToString()
            TextBox_mhistory4.Text = dt.Rows.Item(0).Item(88).ToString()
            TextBox_mhistory5.Text = dt.Rows.Item(0).Item(89).ToString()
            TextBox_mhistory6.Text = dt.Rows.Item(0).Item(90).ToString()

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(91)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_pedigree.Image = Bitmap.FromStream(MS)
                PictureBox_pedigree.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(92)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_radiology1.Image = Bitmap.FromStream(MS)
                PictureBox_radiology1.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(93)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_radiology2.Image = Bitmap.FromStream(MS)
                PictureBox_radiology2.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(94)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_radiology3.Image = Bitmap.FromStream(MS)
                PictureBox_radiology3.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(95)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_radiology4.Image = Bitmap.FromStream(MS)
                PictureBox_radiology4.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(96)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_radiology5.Image = Bitmap.FromStream(MS)
                PictureBox_radiology5.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(97)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_radiology6.Image = Bitmap.FromStream(MS)
                PictureBox_radiology6.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(98)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_lab1.Image = Bitmap.FromStream(MS)
                PictureBox_lab1.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(99)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_lab2.Image = Bitmap.FromStream(MS)
                PictureBox_lab2.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(100)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_lab3.Image = Bitmap.FromStream(MS)
                PictureBox_lab3.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(101)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_lab4.Image = Bitmap.FromStream(MS)
                PictureBox_lab4.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(102)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_lab5.Image = Bitmap.FromStream(MS)
                PictureBox_lab5.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(103)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_lab6.Image = Bitmap.FromStream(MS)
                PictureBox_lab6.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(104)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_gene1.Image = Bitmap.FromStream(MS)
                PictureBox_gene1.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(105)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_gene2.Image = Bitmap.FromStream(MS)
                PictureBox_gene2.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(106)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_gene3.Image = Bitmap.FromStream(MS)
                PictureBox_gene3.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(107)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_gene4.Image = Bitmap.FromStream(MS)
                PictureBox_gene4.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(108)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_gene5.Image = Bitmap.FromStream(MS)
                PictureBox_gene5.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            Try
                Dim file() As Byte = dt.Rows.Item(0).Item(109)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                PictureBox_gene6.Image = Bitmap.FromStream(MS)
                PictureBox_gene6.SizeMode = PictureBoxSizeMode.StretchImage
            Catch
            End Try

            TextBox_illness1.Text = dt.Rows.Item(0).Item(110).ToString()
            TextBox_illness2.Text = dt.Rows.Item(0).Item(111).ToString()
            TextBox_illness3.Text = dt.Rows.Item(0).Item(112).ToString()
            ComboBox_heredity1.Text = dt.Rows.Item(0).Item(113).ToString()
            ComboBox_heredity2.Text = dt.Rows.Item(0).Item(114).ToString()
            ComboBox_heredity3.Text = dt.Rows.Item(0).Item(115).ToString()
            TextBox_result1.Text = dt.Rows.Item(0).Item(116).ToString()
            TextBox_result2.Text = dt.Rows.Item(0).Item(117).ToString()
            TextBox_result3.Text = dt.Rows.Item(0).Item(118).ToString()
            TextBox_risk1.Text = dt.Rows.Item(0).Item(119).ToString()
            TextBox_risk2.Text = dt.Rows.Item(0).Item(120).ToString()
            TextBox_risk3.Text = dt.Rows.Item(0).Item(121).ToString()
            TextBox_action.Text = dt.Rows.Item(0).Item(122).ToString()
            TextBox_advise.Text = dt.Rows.Item(0).Item(123).ToString()
            TextBox_committee.Text = dt.Rows.Item(0).Item(124).ToString()
            Button_save.Enabled = False
            Button_edit.Enabled = True
        Catch
            MessageBox.Show("اطلاعات بیمار در سیستم موجود نیست", "خطا در پایگاه داده ها", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox_case.Text = ""
        End Try

    End Sub

    Private Sub Button_fopen_Click(sender As Object, e As EventArgs) Handles Button_fopen.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(1) = open.FileName
            PictureBox_fpic.Image = Image.FromFile(str(1))
            PictureBox_fpic.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button_fsave_Click(sender As Object, e As EventArgs) Handles Button_fsave.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(1))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update couple set [f-pic]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button_fcam_Click(sender As Object, e As EventArgs) Handles Button_fcam.Click

    End Sub

    Private Sub Button_fdel_Click(sender As Object, e As EventArgs) Handles Button_fdel.Click
        PictureBox_fpic.Image = Nothing
        str(1) = ""
    End Sub

    Private Sub Button_mopen_Click(sender As Object, e As EventArgs) Handles Button_mopen.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(2) = open.FileName
            PictureBox_mpic.Image = Image.FromFile(str(2))
            PictureBox_mpic.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button_msave_Click(sender As Object, e As EventArgs) Handles Button_msave.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(2))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update couple set [m-pic]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button_mcam_Click(sender As Object, e As EventArgs) Handles Button_mcam.Click

    End Sub

    Private Sub Button_mdel_Click(sender As Object, e As EventArgs) Handles Button_mdel.Click
        PictureBox_mpic.Image = Nothing
        str(2) = ""
    End Sub

    Private Sub Button_opening_Click(sender As Object, e As EventArgs) Handles Button_opening.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(3) = open.FileName
            PictureBox_document.Image = Image.FromFile(str(3))
            PictureBox_document.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button_saving_Click(sender As Object, e As EventArgs) Handles Button_saving.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(3))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update financial set [document]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button_scan_Click(sender As Object, e As EventArgs) Handles Button_scan.Click

    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        PictureBox_document.Image = Nothing
        str(3) = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(4) = open.FileName
            PictureBox_pedigree.Image = Image.FromFile(str(4))
            PictureBox_pedigree.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim img As Byte()
            img = IO.File.ReadAllBytes(str(4))
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update couple set [pedigree]=@pic  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic", img)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pedigree.StartPosition = FormStartPosition.CenterScreen
        pedigree.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox_pedigree.Image = Nothing
        str(4) = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(5) = open.FileName
            PictureBox_radiology1.Image = Image.FromFile(str(5))
            PictureBox_radiology1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        PictureBox_radiology1.Image = Nothing
        str(5) = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(6) = open.FileName
            PictureBox_radiology2.Image = Image.FromFile(str(6))
            PictureBox_radiology2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox_radiology2.Image = Nothing
        str(6) = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(7) = open.FileName
            PictureBox_radiology3.Image = Image.FromFile(str(7))
            PictureBox_radiology3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox_radiology3.Image = Nothing
        str(7) = ""
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(8) = open.FileName
            PictureBox_radiology4.Image = Image.FromFile(str(8))
            PictureBox_radiology4.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        PictureBox_radiology4.Image = Nothing
        str(8) = ""
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(9) = open.FileName
            PictureBox_radiology5.Image = Image.FromFile(str(9))
            PictureBox_radiology5.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        PictureBox_radiology5.Image = Nothing
        str(9) = ""
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(10) = open.FileName
            PictureBox_radiology6.Image = Image.FromFile(str(10))
            PictureBox_radiology6.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        PictureBox_radiology6.Image = Nothing
        str(10) = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(11) = open.FileName
            PictureBox_lab1.Image = Image.FromFile(str(11))
            PictureBox_lab1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        PictureBox_lab1.Image = Nothing
        str(11) = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(12) = open.FileName
            PictureBox_lab2.Image = Image.FromFile(str(12))
            PictureBox_lab2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PictureBox_lab2.Image = Nothing
        str(12) = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(13) = open.FileName
            PictureBox_lab3.Image = Image.FromFile(str(13))
            PictureBox_lab3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PictureBox_lab3.Image = Nothing
        str(13) = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(14) = open.FileName
            PictureBox_lab4.Image = Image.FromFile(str(14))
            PictureBox_lab4.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        PictureBox_lab4.Image = Nothing
        str(14) = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(15) = open.FileName
            PictureBox_lab5.Image = Image.FromFile(str(15))
            PictureBox_lab5.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        PictureBox_lab5.Image = Nothing
        str(15) = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(16) = open.FileName
            PictureBox_lab6.Image = Image.FromFile(str(16))
            PictureBox_lab6.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PictureBox_lab6.Image = Nothing
        str(16) = ""
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(17) = open.FileName
            PictureBox_gene1.Image = Image.FromFile(str(17))
            PictureBox_gene1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        PictureBox_gene1.Image = Nothing
        str(17) = ""
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(18) = open.FileName
            PictureBox_gene2.Image = Image.FromFile(str(18))
            PictureBox_gene2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        PictureBox_gene2.Image = Nothing
        str(18) = ""
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(19) = open.FileName
            PictureBox_gene3.Image = Image.FromFile(str(19))
            PictureBox_gene3.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        PictureBox_gene3.Image = Nothing
        str(19) = ""
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(20) = open.FileName
            PictureBox_gene4.Image = Image.FromFile(str(20))
            PictureBox_gene4.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        PictureBox_gene4.Image = Nothing
        str(20) = ""
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(21) = open.FileName
            PictureBox_gene5.Image = Image.FromFile(str(21))
            PictureBox_gene5.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        PictureBox_gene5.Image = Nothing
        str(21) = ""
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر نامه"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            str(22) = open.FileName
            PictureBox_gene6.Image = Image.FromFile(str(22))
            PictureBox_gene6.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        PictureBox_gene6.Image = Nothing
        str(22) = ""
    End Sub

    Private Sub Button_save1_Click(sender As Object, e As EventArgs) Handles Button_save1.Click
        Try
            Dim img(18) As Byte
            For i = 1 To 18 Step 1
                img(i) = New Byte()
                img(i) = IO.File.ReadAllBytes(str(i + 4)).ToString
            Next i
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source = LAPTOP;Initial Catalog=medical;Integrated Security=True"
            Dim com As New SqlCommand
            com.Connection = con
            com.CommandText = "update couple set [radiology1]=@pic1, [radiology2]=@pic2, [radiology3]=@pic3, [radiology4]=@pic4, [radiology5]=@pic5, [radiology6]=@pic6, [lab1]=@pic7, [lab2]=@pic8, [lab3]=@pic9, [lab4]=@pic10, [lab5]=@pic11, [lab6]=@pic12, [gene1]=@pic13, [gene2]=@pic14, [gene3]=@pic15, [gene4]=@pic16, [gene5]=@pic17, [gene6]=@pic18  where [case]='" + TextBox_case.Text + "' "
            com.Parameters.AddWithValue("@pic1", img(1))
            com.Parameters.AddWithValue("@pic2", img(2))
            com.Parameters.AddWithValue("@pic3", img(3))
            com.Parameters.AddWithValue("@pic4", img(4))
            com.Parameters.AddWithValue("@pic5", img(5))
            com.Parameters.AddWithValue("@pic6", img(6))
            com.Parameters.AddWithValue("@pic7", img(7))
            com.Parameters.AddWithValue("@pic8", img(8))
            com.Parameters.AddWithValue("@pic9", img(9))
            com.Parameters.AddWithValue("@pic10", img(10))
            com.Parameters.AddWithValue("@pic11", img(11))
            com.Parameters.AddWithValue("@pic12", img(12))
            com.Parameters.AddWithValue("@pic13", img(13))
            com.Parameters.AddWithValue("@pic14", img(14))
            com.Parameters.AddWithValue("@pic15", img(15))
            com.Parameters.AddWithValue("@pic16", img(16))
            com.Parameters.AddWithValue("@pic17", img(17))
            com.Parameters.AddWithValue("@pic18", img(18))
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("ثبت عکس با موفقیت انجام شد")
        Catch
            MsgBox("عملیات ثبت عکس انجام نشد")
        End Try
    End Sub

End Class