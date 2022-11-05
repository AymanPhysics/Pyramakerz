<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallmentsSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Value = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.InvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RealInvoiceNo = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DayDate = New System.Windows.Forms.DateTimePicker()
        Me.Haspayed = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainRealInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MainInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.lblMain = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Value
        '
        Me.Value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Value.Location = New System.Drawing.Point(772, 58)
        Me.Value.MaxLength = 15
        Me.Value.Name = "Value"
        Me.Value.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Value.Size = New System.Drawing.Size(78, 26)
        Me.Value.TabIndex = 6
        Me.Value.Tag = "Value"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(772, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 46)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "Value"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPassword.Location = New System.Drawing.Point(853, 9)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(97, 46)
        Me.lblPassword.TabIndex = 136
        Me.lblPassword.Text = "Date"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(954, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 46)
        Me.Label17.TabIndex = 137
        Me.Label17.Text = "Payed"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InvoiceNo.Location = New System.Drawing.Point(103, 58)
        Me.InvoiceNo.MaxLength = 10
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InvoiceNo.Size = New System.Drawing.Size(83, 26)
        Me.InvoiceNo.TabIndex = 1
        Me.InvoiceNo.Tag = "InvoiceNo"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(447, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(322, 46)
        Me.Label18.TabIndex = 128
        Me.Label18.Text = "Student Id"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(189, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 46)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Inv. No (Real)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentId
        '
        Me.StudentId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StudentId.Location = New System.Drawing.Point(447, 58)
        Me.StudentId.MaxLength = 100
        Me.StudentId.Name = "StudentId"
        Me.StudentId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StudentId.Size = New System.Drawing.Size(322, 26)
        Me.StudentId.TabIndex = 5
        Me.StudentId.Tag = "StudentId"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(103, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 46)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Inv. No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RealInvoiceNo
        '
        Me.RealInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RealInvoiceNo.Location = New System.Drawing.Point(189, 58)
        Me.RealInvoiceNo.MaxLength = 100
        Me.RealInvoiceNo.Name = "RealInvoiceNo"
        Me.RealInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RealInvoiceNo.Size = New System.Drawing.Size(83, 26)
        Me.RealInvoiceNo.TabIndex = 2
        Me.RealInvoiceNo.Tag = "RealInvoiceNo"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.Size = New System.Drawing.Size(1031, 400)
        Me.DataGridView1.TabIndex = 9
        '
        'DayDate
        '
        Me.DayDate.CustomFormat = "yyyy-MM-dd"
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(853, 58)
        Me.DayDate.Name = "DayDate"
        Me.DayDate.Size = New System.Drawing.Size(97, 26)
        Me.DayDate.TabIndex = 7
        Me.DayDate.Tag = "DayDate"
        '
        'Haspayed
        '
        Me.Haspayed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Haspayed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Haspayed.FormattingEnabled = True
        Me.Haspayed.Items.AddRange(New Object() {"Not Payed", "Payed", "All"})
        Me.Haspayed.Location = New System.Drawing.Point(954, 58)
        Me.Haspayed.Name = "Haspayed"
        Me.Haspayed.Size = New System.Drawing.Size(84, 27)
        Me.Haspayed.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(401, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(0, 0)
        Me.Button1.TabIndex = 140
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainRealInvoiceNo
        '
        Me.MainRealInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MainRealInvoiceNo.Location = New System.Drawing.Point(361, 58)
        Me.MainRealInvoiceNo.MaxLength = 100
        Me.MainRealInvoiceNo.Name = "MainRealInvoiceNo"
        Me.MainRealInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainRealInvoiceNo.Size = New System.Drawing.Size(83, 26)
        Me.MainRealInvoiceNo.TabIndex = 4
        Me.MainRealInvoiceNo.Tag = "MainRealInvoiceNo"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(275, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 46)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Main Inv. No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(361, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 46)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Main Inv. No (Real)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainInvoiceNo
        '
        Me.MainInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MainInvoiceNo.Location = New System.Drawing.Point(275, 58)
        Me.MainInvoiceNo.MaxLength = 10
        Me.MainInvoiceNo.Name = "MainInvoiceNo"
        Me.MainInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MainInvoiceNo.Size = New System.Drawing.Size(83, 26)
        Me.MainInvoiceNo.TabIndex = 3
        Me.MainInvoiceNo.Tag = "MainInvoiceNo"
        '
        'Branch
        '
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(12, 58)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(83, 27)
        Me.Branch.TabIndex = 0
        Me.Branch.Tag = "BranchId"
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(12, 11)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(83, 43)
        Me.lblMain.TabIndex = 165
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InstallmentsSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(1055, 503)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Haspayed)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MainInvoiceNo)
        Me.Controls.Add(Me.InvoiceNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StudentId)
        Me.Controls.Add(Me.MainRealInvoiceNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RealInvoiceNo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "InstallmentsSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InstallmentsSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Value As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents InvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StudentId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RealInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Haspayed As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MainRealInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MainInvoiceNo As System.Windows.Forms.TextBox
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
End Class
