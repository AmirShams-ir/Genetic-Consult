<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doctors1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ردیفDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.نامDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.نامخانوادگیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.کدملیDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.آدرسDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.تلفنDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.همراهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.User1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Genetic.DatabaseDataSet()
        Me.User1TableAdapter = New Genetic.DatabaseDataSetTableAdapters.user1TableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ردیفDataGridViewTextBoxColumn, Me.UserDataGridViewTextBoxColumn, Me.PassDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.نامDataGridViewTextBoxColumn, Me.نامخانوادگیDataGridViewTextBoxColumn, Me.کدملیDataGridViewTextBoxColumn, Me.آدرسDataGridViewTextBoxColumn, Me.تلفنDataGridViewTextBoxColumn, Me.همراهDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.User1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 300)
        Me.DataGridView1.TabIndex = 0
        '
        'ردیفDataGridViewTextBoxColumn
        '
        Me.ردیفDataGridViewTextBoxColumn.DataPropertyName = "ردیف"
        Me.ردیفDataGridViewTextBoxColumn.HeaderText = "ردیف"
        Me.ردیفDataGridViewTextBoxColumn.Name = "ردیفDataGridViewTextBoxColumn"
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        '
        'PassDataGridViewTextBoxColumn
        '
        Me.PassDataGridViewTextBoxColumn.DataPropertyName = "Pass"
        Me.PassDataGridViewTextBoxColumn.HeaderText = "Pass"
        Me.PassDataGridViewTextBoxColumn.Name = "PassDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'نامDataGridViewTextBoxColumn
        '
        Me.نامDataGridViewTextBoxColumn.DataPropertyName = "نام"
        Me.نامDataGridViewTextBoxColumn.HeaderText = "نام"
        Me.نامDataGridViewTextBoxColumn.Name = "نامDataGridViewTextBoxColumn"
        '
        'نامخانوادگیDataGridViewTextBoxColumn
        '
        Me.نامخانوادگیDataGridViewTextBoxColumn.DataPropertyName = "نام خانوادگی"
        Me.نامخانوادگیDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی"
        Me.نامخانوادگیDataGridViewTextBoxColumn.Name = "نامخانوادگیDataGridViewTextBoxColumn"
        '
        'کدملیDataGridViewTextBoxColumn
        '
        Me.کدملیDataGridViewTextBoxColumn.DataPropertyName = "کد ملی"
        Me.کدملیDataGridViewTextBoxColumn.HeaderText = "کد ملی"
        Me.کدملیDataGridViewTextBoxColumn.Name = "کدملیDataGridViewTextBoxColumn"
        '
        'آدرسDataGridViewTextBoxColumn
        '
        Me.آدرسDataGridViewTextBoxColumn.DataPropertyName = "آدرس"
        Me.آدرسDataGridViewTextBoxColumn.HeaderText = "آدرس"
        Me.آدرسDataGridViewTextBoxColumn.Name = "آدرسDataGridViewTextBoxColumn"
        '
        'تلفنDataGridViewTextBoxColumn
        '
        Me.تلفنDataGridViewTextBoxColumn.DataPropertyName = "تلفن"
        Me.تلفنDataGridViewTextBoxColumn.HeaderText = "تلفن"
        Me.تلفنDataGridViewTextBoxColumn.Name = "تلفنDataGridViewTextBoxColumn"
        '
        'همراهDataGridViewTextBoxColumn
        '
        Me.همراهDataGridViewTextBoxColumn.DataPropertyName = "همراه"
        Me.همراهDataGridViewTextBoxColumn.HeaderText = "همراه"
        Me.همراهDataGridViewTextBoxColumn.Name = "همراهDataGridViewTextBoxColumn"
        '
        'User1BindingSource
        '
        Me.User1BindingSource.DataMember = "user1"
        Me.User1BindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User1TableAdapter
        '
        Me.User1TableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ذخیره"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(307, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'doctors1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "doctors1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "پزشکان مرکز"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents User1BindingSource As BindingSource
    Friend WithEvents User1TableAdapter As DatabaseDataSetTableAdapters.user1TableAdapter
    Friend WithEvents ردیفDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents نامDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents نامخانوادگیDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents کدملیDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents آدرسDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents تلفنDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents همراهDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
