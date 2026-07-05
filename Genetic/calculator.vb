Imports System.Math
Public Class calculator
    Inherits System.Windows.Forms.Form
    Dim a1 As String
    Dim c As Control
    Dim flag As Boolean
    Dim x1, x2, n, s, i As Double
    Dim f, k, g As Integer

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(204, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(108, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 98)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(204, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(108, 138)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 32)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(12, 138)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 32)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(204, 178)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 32)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(108, 178)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(90, 32)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(12, 178)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(90, 32)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(12, 218)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(90, 32)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button11.Location = New System.Drawing.Point(108, 218)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(90, 32)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "+"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button12.Location = New System.Drawing.Point(204, 218)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(90, 32)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "-"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button13.Location = New System.Drawing.Point(12, 258)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(90, 32)
        Me.Button13.TabIndex = 12
        Me.Button13.Text = "*"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button14.Location = New System.Drawing.Point(108, 258)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(90, 32)
        Me.Button14.TabIndex = 13
        Me.Button14.Text = "/"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button15.Location = New System.Drawing.Point(204, 258)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(90, 32)
        Me.Button15.TabIndex = 14
        Me.Button15.Text = "="
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.White
        Me.Button16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button16.Location = New System.Drawing.Point(12, 298)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(90, 32)
        Me.Button16.TabIndex = 15
        Me.Button16.Text = "."
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.White
        Me.Button17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.Red
        Me.Button17.Location = New System.Drawing.Point(396, 218)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(90, 32)
        Me.Button17.TabIndex = 16
        Me.Button17.Text = "M"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.White
        Me.Button18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.Red
        Me.Button18.Location = New System.Drawing.Point(396, 258)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(90, 32)
        Me.Button18.TabIndex = 17
        Me.Button18.Text = "MR"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.White
        Me.Button19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.Green
        Me.Button19.Location = New System.Drawing.Point(396, 298)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(90, 32)
        Me.Button19.TabIndex = 18
        Me.Button19.Text = "AC"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.White
        Me.Button20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.Green
        Me.Button20.Location = New System.Drawing.Point(396, 42)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(90, 32)
        Me.Button20.TabIndex = 19
        Me.Button20.Text = "On/Off"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.White
        Me.Button21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.Red
        Me.Button21.Location = New System.Drawing.Point(300, 178)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(90, 32)
        Me.Button21.TabIndex = 20
        Me.Button21.Text = "Tan(x)"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 42)
        Me.TextBox1.MaxLength = 12
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 26)
        Me.TextBox1.TabIndex = 22
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.White
        Me.Button22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.Color.Red
        Me.Button22.Location = New System.Drawing.Point(396, 138)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(90, 32)
        Me.Button22.TabIndex = 23
        Me.Button22.Text = "Sum"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.White
        Me.Button23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.ForeColor = System.Drawing.Color.Red
        Me.Button23.Location = New System.Drawing.Point(396, 178)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(90, 32)
        Me.Button23.TabIndex = 24
        Me.Button23.Text = "n!"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.White
        Me.Button24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.Color.Red
        Me.Button24.Location = New System.Drawing.Point(396, 98)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(90, 32)
        Me.Button24.TabIndex = 25
        Me.Button24.Text = "mul"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.White
        Me.Button25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.ForeColor = System.Drawing.Color.Red
        Me.Button25.Location = New System.Drawing.Point(300, 98)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(90, 32)
        Me.Button25.TabIndex = 26
        Me.Button25.Text = "Sin(x)"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.White
        Me.Button26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.Red
        Me.Button26.Location = New System.Drawing.Point(300, 138)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(90, 32)
        Me.Button26.TabIndex = 27
        Me.Button26.Text = "Cos(x)"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.White
        Me.Button27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.ForeColor = System.Drawing.Color.Red
        Me.Button27.Location = New System.Drawing.Point(300, 218)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(90, 32)
        Me.Button27.TabIndex = 28
        Me.Button27.Text = "Exp(x)"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.White
        Me.Button28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.ForeColor = System.Drawing.Color.Red
        Me.Button28.Location = New System.Drawing.Point(300, 258)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(90, 32)
        Me.Button28.TabIndex = 29
        Me.Button28.Text = "Sqrt(x)"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.White
        Me.Button29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.ForeColor = System.Drawing.Color.Red
        Me.Button29.Location = New System.Drawing.Point(108, 298)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(90, 32)
        Me.Button29.TabIndex = 30
        Me.Button29.Text = "(-)"
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 23)
        Me.Label2.TabIndex = 31
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.White
        Me.Button30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.ForeColor = System.Drawing.Color.Red
        Me.Button30.Location = New System.Drawing.Point(204, 298)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(88, 32)
        Me.Button30.TabIndex = 32
        Me.Button30.Text = "<----"
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.White
        Me.Button31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.ForeColor = System.Drawing.Color.Red
        Me.Button31.Location = New System.Drawing.Point(300, 298)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(90, 32)
        Me.Button31.TabIndex = 33
        Me.Button31.Text = "X^N"
        Me.Button31.UseVisualStyleBackColor = False
        '
        'calculator
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(499, 345)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "calculator"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ماشین حساب"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        TextBox1.Text &= "1"
        Label2.Text &= "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text &= "2"
        Label2.Text &= "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text &= "3"
        Label2.Text &= "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text &= "4"
        Label2.Text &= "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text &= "5"
        Label2.Text &= "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text &= "6"
        Label2.Text &= "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text &= "7"
        Label2.Text &= "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text &= "8"
        Label2.Text &= "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text &= "9"
        Label2.Text &= "9"
    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text &= "0"
        Label2.Text &= "0"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        x1 += TextBox1.Text
        TextBox1.Text = ""
        n = 1
        Label2.Text += "+"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        x1 += TextBox1.Text
        TextBox1.Text = ""
        n = 2
        Label2.Text += "-"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        x1 += TextBox1.Text
        TextBox1.Text = ""
        Label2.Text += "*"
        n = 3

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        x1 += TextBox1.Text
        TextBox1.Text = ""
        n = 4
        Label2.Text += "/"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        Select Case n
            Case 1
                x2 += TextBox1.Text
                TextBox1.Text = ""
                TextBox1.Text = x1 + x2
            Case 2
                x2 += TextBox1.Text
                TextBox1.Text = ""
                TextBox1.Text = x1 - x2
            Case 3
                x2 += TextBox1.Text
                TextBox1.Text = ""
                TextBox1.Text = x1 * x2
            Case 4
                x2 += TextBox1.Text
                TextBox1.Text = ""
                TextBox1.Text = x1 / x2
            Case 5
                x2 += TextBox1.Text
                TextBox1.Text = ""
                For i = x1 To x2
                    s += i
                Next i
                TextBox1.Text = s
            Case 6
                For i = 1 To x1
                    f = f * i
                Next i
                TextBox1.Text &= "=" & f
            Case 7
                f = 1
                x2 += TextBox1.Text
                TextBox1.Text = ""
                For i = x1 To x2
                    f = f * i
                Next i
                TextBox1.Text = f
            Case 8
                x2 = TextBox1.Text
                TextBox1.Text = ""
                f = Pow(x1, x2)
                TextBox1.Text = f
        End Select
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Me.Close()
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        TextBox1.Text = ""
        x1 = 0
        k = 0
        x2 = 0
        Label2.Text = ""
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click

        TextBox1.Text &= "."

    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        x1 += TextBox1.Text
        TextBox1.Text = ""
        n = 5
        Label2.Text += "sum"
    End Sub
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        x1 = TextBox1.Text
        TextBox1.Text &= "!"
        f = 1
        For i = 1 To x1
            f = f * i
        Next i
        TextBox1.Text &= "=" & f
    End Sub
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        x1 += TextBox1.Text
        TextBox1.Text = ""
        Label2.Text += "mul"
        n = 7
    End Sub
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        x1 = TextBox1.Text
        TextBox1.Text = Sin(x1)
        Label2.Text = ""
        Label2.Text = " Sin" & "(" & x1 & ")"
    End Sub
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        x1 = TextBox1.Text
        TextBox1.Text = Cos(x1)
        Label2.Text = ""
        Label2.Text = " cos" & "(" & x1 & ")"
    End Sub
    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        x1 = TextBox1.Text
        TextBox1.Text = Exp(x1)
        Label2.Text = ""
        Label2.Text = " Exp" & "(" & x1 & ")"
    End Sub
    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        x1 = TextBox1.Text
        TextBox1.Text = Sqrt(x1)
        Label2.Text = ""
        Label2.Text = " Sqrt" & "(" & x1 & ")"
    End Sub
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        x1 = TextBox1.Text
        TextBox1.Text = Tan(x1)
        Label2.Text = ""
        Label2.Text = " Tan" & "(" & x1 & ")"
    End Sub
    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        g = 1
        TextBox1.Text *= -1
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        a1 = Label2.Text + "=" + TextBox1.Text
        TextBox1.Text = ""
        Label2.Text = ""
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TextBox1.Text = a1
    End Sub
    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        TextBox1.Clear()
        Label2.Text = ""
    End Sub
    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        x1 += TextBox1.Text
        TextBox1.Text = ""
        n = 8
        Label2.Text += "^"
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Red
        Button1.BackColor = Color.Gold
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
        Button1.BackColor = Color.White
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.Red
        Button2.BackColor = Color.Gold
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Black
        Button2.BackColor = Color.White
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.Red
        Button3.BackColor = Color.Gold
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Black
        Button3.BackColor = Color.White
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button4.ForeColor = Color.Red
        Button4.BackColor = Color.Gold
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.ForeColor = Color.Black
        Button4.BackColor = Color.White
    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.Red
        Button5.BackColor = Color.Gold
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.Black
        Button5.BackColor = Color.White
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        Button6.ForeColor = Color.Red
        Button6.BackColor = Color.Gold
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.ForeColor = Color.Black
        Button6.BackColor = Color.White
    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.Red
        Button7.BackColor = Color.Gold
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Black
        Button7.BackColor = Color.White
    End Sub

    Private Sub Button8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseEnter
        Button8.ForeColor = Color.Red
        Button8.BackColor = Color.Gold
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        Button8.ForeColor = Color.Black
        Button8.BackColor = Color.White
    End Sub

    Private Sub Button9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseEnter
        Button9.ForeColor = Color.Red
        Button9.BackColor = Color.Gold
    End Sub

    Private Sub Button9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseLeave
        Button9.ForeColor = Color.Black
        Button9.BackColor = Color.White
    End Sub

    Private Sub Button10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseEnter
        Button10.ForeColor = Color.Red
        Button10.BackColor = Color.Gold
    End Sub

    Private Sub Button10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseLeave
        Button10.ForeColor = Color.Black
        Button10.BackColor = Color.White
    End Sub

    Private Sub Button11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseEnter
        Button11.ForeColor = Color.Red
        Button11.BackColor = Color.Gold
    End Sub

    Private Sub Button11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseLeave
        Button11.ForeColor = Color.Black
        Button11.BackColor = Color.White
    End Sub

    Private Sub Button12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseEnter
        Button12.ForeColor = Color.Red
        Button12.BackColor = Color.Gold
    End Sub

    Private Sub Button12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseLeave
        Button12.ForeColor = Color.Black
        Button12.BackColor = Color.White
    End Sub

    Private Sub Button13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseEnter
        Button13.ForeColor = Color.Red
        Button13.BackColor = Color.Gold
    End Sub

    Private Sub Button13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseLeave
        Button13.ForeColor = Color.Black
        Button13.BackColor = Color.White
    End Sub

    Private Sub Button14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseEnter
        Button14.ForeColor = Color.Red
        Button14.BackColor = Color.Gold
    End Sub

    Private Sub Button14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseLeave
        Button14.ForeColor = Color.Black
        Button14.BackColor = Color.White
    End Sub

    Private Sub Button15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseEnter
        Button15.ForeColor = Color.Red
        Button15.BackColor = Color.Gold
    End Sub

    Private Sub Button15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseLeave
        Button15.ForeColor = Color.Black
        Button15.BackColor = Color.White
    End Sub

    Private Sub Button16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.MouseEnter
        Button16.ForeColor = Color.Red
        Button16.BackColor = Color.Gold
    End Sub

    Private Sub Button16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.MouseLeave
        Button16.ForeColor = Color.Black
        Button16.BackColor = Color.White
    End Sub

    Private Sub Button17_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.MouseEnter
        Button17.ForeColor = Color.Red
        Button17.BackColor = Color.Gold
    End Sub

    Private Sub Button17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.MouseLeave
        Button17.ForeColor = Color.Red
        Button17.BackColor = Color.White
    End Sub

    Private Sub Button18_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.MouseEnter
        Button18.ForeColor = Color.Red
        Button18.BackColor = Color.Gold
    End Sub

    Private Sub Button18_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.MouseLeave
        Button18.ForeColor = Color.Red
        Button18.BackColor = Color.White
    End Sub

    Private Sub Button19_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button19.MouseEnter
        Button19.ForeColor = Color.Red
        Button19.BackColor = Color.Gold
    End Sub

    Private Sub Button19_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button19.MouseLeave
        Button19.ForeColor = Color.Green
        Button19.BackColor = Color.White
    End Sub

    Private Sub Button21_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.MouseEnter
        Button21.ForeColor = Color.Red
        Button21.BackColor = Color.Gold
    End Sub

    Private Sub Button21_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.MouseLeave
        Button21.ForeColor = Color.Red
        Button21.BackColor = Color.White
    End Sub

    Private Sub Button22_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button22.MouseEnter
        Button22.ForeColor = Color.Red
        Button22.BackColor = Color.Gold
    End Sub

    Private Sub Button22_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button22.MouseLeave
        Button22.ForeColor = Color.Red
        Button22.BackColor = Color.White
    End Sub

    Private Sub Button23_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button23.MouseEnter
        Button23.ForeColor = Color.Red
        Button23.BackColor = Color.Gold
    End Sub

    Private Sub Button24_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button24.MouseEnter
        Button24.ForeColor = Color.Red
        Button24.BackColor = Color.Gold
    End Sub

    Private Sub Button24_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button24.MouseLeave
        Button24.ForeColor = Color.Red
        Button24.BackColor = Color.White
    End Sub

    Private Sub Button25_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button25.MouseEnter
        Button25.ForeColor = Color.Red
        Button25.BackColor = Color.Gold
    End Sub

    Private Sub Button25_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button25.MouseLeave
        Button25.ForeColor = Color.Red
        Button25.BackColor = Color.White
    End Sub

    Private Sub Button26_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button26.MouseEnter
        Button26.ForeColor = Color.Red
        Button26.BackColor = Color.Gold
    End Sub

    Private Sub Button26_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button26.MouseLeave
        Button26.ForeColor = Color.Red
        Button26.BackColor = Color.White
    End Sub

    Private Sub Button27_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button27.MouseEnter
        Button27.ForeColor = Color.Red
        Button27.BackColor = Color.Gold
    End Sub

    Private Sub Button27_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button27.MouseLeave
        Button27.ForeColor = Color.Red
        Button27.BackColor = Color.White
    End Sub

    Private Sub Button28_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button28.MouseEnter
        Button28.ForeColor = Color.Red
        Button28.BackColor = Color.Gold
    End Sub

    Private Sub Button28_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button28.MouseLeave
        Button28.ForeColor = Color.Red
        Button28.BackColor = Color.White
    End Sub

    Private Sub Button29_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button29.MouseEnter
        Button29.ForeColor = Color.Red
        Button29.BackColor = Color.Gold
    End Sub

    Private Sub Button29_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button29.MouseLeave
        Button29.ForeColor = Color.Red
        Button29.BackColor = Color.White
    End Sub

    Private Sub Button30_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button30.MouseEnter
        Button30.ForeColor = Color.Red
        Button30.BackColor = Color.Gold
    End Sub

    Private Sub Button30_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button30.MouseLeave
        Button30.ForeColor = Color.Red
        Button30.BackColor = Color.White
    End Sub

    Private Sub Button31_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button31.MouseEnter
        Button31.ForeColor = Color.Red
        Button31.BackColor = Color.Gold
    End Sub

    Private Sub Button31_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button31.MouseLeave
        Button31.ForeColor = Color.Red
        Button31.BackColor = Color.White
    End Sub

    Private Sub Button23_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button23.MouseLeave
        Button23.ForeColor = Color.Red
        Button23.BackColor = Color.White
    End Sub

End Class

