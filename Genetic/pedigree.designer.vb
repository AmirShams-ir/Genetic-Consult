<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pedigree
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CoupleTableAdapter1 = New Genetic.DatabaseDataSetTableAdapters.coupleTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_fdel = New System.Windows.Forms.Button()
        Me.Button_fsave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CoupleTableAdapter1
        '
        Me.CoupleTableAdapter1.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(460, 311)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button_fdel
        '
        Me.Button_fdel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_fdel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fdel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_fdel.ImageKey = "(none)"
        Me.Button_fdel.Location = New System.Drawing.Point(144, 329)
        Me.Button_fdel.Name = "Button_fdel"
        Me.Button_fdel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_fdel.Size = New System.Drawing.Size(60, 25)
        Me.Button_fdel.TabIndex = 34
        Me.Button_fdel.Text = "حذف"
        Me.Button_fdel.UseVisualStyleBackColor = False
        '
        'Button_fsave
        '
        Me.Button_fsave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_fsave.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_fsave.ImageKey = "(none)"
        Me.Button_fsave.Location = New System.Drawing.Point(265, 329)
        Me.Button_fsave.Name = "Button_fsave"
        Me.Button_fsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_fsave.Size = New System.Drawing.Size(60, 25)
        Me.Button_fsave.TabIndex = 35
        Me.Button_fsave.Text = "ذخیره"
        Me.Button_fsave.UseVisualStyleBackColor = False
        '
        'pedigree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.Button_fdel)
        Me.Controls.Add(Me.Button_fsave)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "pedigree"
        Me.Text = "ترسیم شجر نامه"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CoupleTableAdapter1 As DatabaseDataSetTableAdapters.coupleTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_fdel As Button
    Friend WithEvents Button_fsave As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
