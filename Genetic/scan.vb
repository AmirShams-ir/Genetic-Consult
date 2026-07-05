Imports WIA
Public Class scan
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim d As CommonDialog
        Dim p As ImageFile
        Dim img As String = Application.StartupPath & "\temp.jpg"
        Try
            p = d.ShowAcquireImage(WiaDeviceType.ScannerDeviceType, WiaImageIntent.ColorIntent, WiaImageBias.MaximizeQuality, False, False, False)
            If p IsNot Nothing Then
                If IO.File.Exists(img) = True Then
                    IO.File.Delete(img)
                End If
                p.SaveFile(img)
                PictureBox1.Load(img)
            End If
        Catch ex As Exception
            MsgBox("خطا در اسکن فایل", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class