<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calendar
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
        Me.components = New System.ComponentModel.Container()
        Me.HM_FarsiCalendar1 = New HM_FarsiCalendar.HM_FarsiCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HM_FarsiCalendar1
        '
        Me.HM_FarsiCalendar1.BodyBackColor = System.Drawing.Color.White
        Me.HM_FarsiCalendar1.BodyForeColor = System.Drawing.Color.Black
        Me.HM_FarsiCalendar1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.HM_FarsiCalendar1.HeaderBackColor = System.Drawing.Color.Gray
        Me.HM_FarsiCalendar1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.HM_FarsiCalendar1.HeaderForeColor = System.Drawing.Color.White
        Me.HM_FarsiCalendar1.Location = New System.Drawing.Point(343, 56)
        Me.HM_FarsiCalendar1.Max_Date = "1400/12/30"
        Me.HM_FarsiCalendar1.Min_Date = "1350/01/01"
        Me.HM_FarsiCalendar1.Name = "HM_FarsiCalendar1"
        Me.HM_FarsiCalendar1.SelectedBackColor = System.Drawing.Color.Blue
        Me.HM_FarsiCalendar1.SelectedForeColor = System.Drawing.Color.White
        Me.HM_FarsiCalendar1.Size = New System.Drawing.Size(125, 21)
        Me.HM_FarsiCalendar1.TabIndex = 0
        Me.HM_FarsiCalendar1.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.HM_FarsiCalendar1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 320)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ثبت رویدادها"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "تاریخ :"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(281, 146)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(469, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "عنوان :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(343, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 22)
        Me.TextBox1.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(14, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(243, 270)
        Me.ListBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "توضیحات :"
        '
        'calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "calendar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تقویم"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HM_FarsiCalendar1 As HM_FarsiCalendar.HM_FarsiCalendar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
