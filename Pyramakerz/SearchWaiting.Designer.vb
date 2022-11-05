<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchWaiting
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.CategoryId = New System.Windows.Forms.ComboBox()
        Me.DepartmentId = New System.Windows.Forms.ComboBox()
        Me.lblMain2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.Days1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Days2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Days3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Shift1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Shift2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Shift3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Shift4 = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.EnName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Delayed = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LevelId = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CreateGroup = New System.Windows.Forms.Button()
        Me.CreateVirtualGroup = New System.Windows.Forms.Button()
        Me.CategoryId2 = New System.Windows.Forms.ComboBox()
        Me.DepartmentId2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Course = New System.Windows.Forms.ComboBox()
        Me.btnCourseSearch = New System.Windows.Forms.Button()
        Me.btnEmpSearch = New System.Windows.Forms.Button()
        Me.Instractor = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.AddToGroup = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Mobile = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Cities = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.HomePhone = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(1194, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 43)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Select"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(1233, 357)
        Me.DataGridView1.TabIndex = 15
        '
        'Branch
        '
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(69, 86)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(56, 23)
        Me.Branch.TabIndex = 0
        Me.Branch.Tag = "BranchId"
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(69, 37)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(56, 43)
        Me.lblMain.TabIndex = 163
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CategoryId
        '
        Me.CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryId.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.CategoryId.FormattingEnabled = True
        Me.CategoryId.Location = New System.Drawing.Point(462, 86)
        Me.CategoryId.Name = "CategoryId"
        Me.CategoryId.Size = New System.Drawing.Size(76, 23)
        Me.CategoryId.TabIndex = 4
        Me.CategoryId.Tag = "CategoryId"
        '
        'DepartmentId
        '
        Me.DepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentId.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DepartmentId.FormattingEnabled = True
        Me.DepartmentId.Location = New System.Drawing.Point(383, 86)
        Me.DepartmentId.Name = "DepartmentId"
        Me.DepartmentId.Size = New System.Drawing.Size(76, 23)
        Me.DepartmentId.TabIndex = 3
        Me.DepartmentId.Tag = "DepartmentId"
        '
        'lblMain2
        '
        Me.lblMain2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lblMain2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain2.Location = New System.Drawing.Point(462, 37)
        Me.lblMain2.Name = "lblMain2"
        Me.lblMain2.Size = New System.Drawing.Size(76, 43)
        Me.lblMain2.TabIndex = 182
        Me.lblMain2.Text = "Category"
        Me.lblMain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(383, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 43)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Department"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDays
        '
        Me.lblDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDays.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lblDays.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDays.Location = New System.Drawing.Point(622, 37)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(41, 43)
        Me.lblDays.TabIndex = 184
        Me.lblDays.Text = "Sat-Tue"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Days1
        '
        Me.Days1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Days1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Days1.FormattingEnabled = True
        Me.Days1.Items.AddRange(New Object() {"No", "Yes", "All"})
        Me.Days1.Location = New System.Drawing.Point(622, 86)
        Me.Days1.Name = "Days1"
        Me.Days1.Size = New System.Drawing.Size(41, 23)
        Me.Days1.TabIndex = 6
        Me.Days1.Tag = "Days1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(668, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 43)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Sun-Wed"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Days2
        '
        Me.Days2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Days2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Days2.FormattingEnabled = True
        Me.Days2.Items.AddRange(New Object() {"No", "Yes", "All"})
        Me.Days2.Location = New System.Drawing.Point(668, 86)
        Me.Days2.Name = "Days2"
        Me.Days2.Size = New System.Drawing.Size(41, 23)
        Me.Days2.TabIndex = 7
        Me.Days2.Tag = "Days2"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(714, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 43)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "Mon-Thu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Days3
        '
        Me.Days3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Days3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Days3.FormattingEnabled = True
        Me.Days3.Items.AddRange(New Object() {"No", "Yes", "All"})
        Me.Days3.Location = New System.Drawing.Point(714, 86)
        Me.Days3.Name = "Days3"
        Me.Days3.Size = New System.Drawing.Size(41, 23)
        Me.Days3.TabIndex = 8
        Me.Days3.Tag = "Days3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(760, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 43)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "1 - 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Shift1
        '
        Me.Shift1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Shift1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Shift1.FormattingEnabled = True
        Me.Shift1.Items.AddRange(New Object() {"No", "Yes", "All"})
        Me.Shift1.Location = New System.Drawing.Point(760, 86)
        Me.Shift1.Name = "Shift1"
        Me.Shift1.Size = New System.Drawing.Size(41, 23)
        Me.Shift1.TabIndex = 9
        Me.Shift1.Tag = "Shift1"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(806, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 43)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "3 - 4"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Shift2
        '
        Me.Shift2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Shift2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Shift2.FormattingEnabled = True
        Me.Shift2.Items.AddRange(New Object() {"No", "Yes", "All"})
        Me.Shift2.Location = New System.Drawing.Point(806, 86)
        Me.Shift2.Name = "Shift2"
        Me.Shift2.Size = New System.Drawing.Size(41, 23)
        Me.Shift2.TabIndex = 10
        Me.Shift2.Tag = "Shift2"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(852, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 43)
        Me.Label6.TabIndex = 184
        Me.Label6.Text = "5 - 6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Shift3
        '
        Me.Shift3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Shift3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Shift3.FormattingEnabled = True
        Me.Shift3.Items.AddRange(New Object() {"No", "Yes", "All"})
        Me.Shift3.Location = New System.Drawing.Point(852, 86)
        Me.Shift3.Name = "Shift3"
        Me.Shift3.Size = New System.Drawing.Size(41, 23)
        Me.Shift3.TabIndex = 11
        Me.Shift3.Tag = "Shift3"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(898, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 43)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "7 - 8 - 9"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Shift4
        '
        Me.Shift4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Shift4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Shift4.FormattingEnabled = True
        Me.Shift4.Items.AddRange(New Object() {"No", "Yes", "All"})
        Me.Shift4.Location = New System.Drawing.Point(898, 86)
        Me.Shift4.Name = "Shift4"
        Me.Shift4.Size = New System.Drawing.Size(41, 23)
        Me.Shift4.TabIndex = 12
        Me.Shift4.Tag = "Shift4"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.txtID.Location = New System.Drawing.Point(129, 86)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtID.Size = New System.Drawing.Size(49, 23)
        Me.txtID.TabIndex = 1
        Me.txtID.Tag = "StudentId"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(182, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 43)
        Me.Label18.TabIndex = 188
        Me.Label18.Text = "En. Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnName
        '
        Me.EnName.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.EnName.Location = New System.Drawing.Point(182, 86)
        Me.EnName.MaxLength = 100
        Me.EnName.Name = "EnName"
        Me.EnName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EnName.Size = New System.Drawing.Size(86, 23)
        Me.EnName.TabIndex = 2
        Me.EnName.Tag = "EnName"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(129, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 43)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "Id"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToDate
        '
        Me.ToDate.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ToDate.Location = New System.Drawing.Point(989, 86)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(76, 23)
        Me.ToDate.TabIndex = 14
        Me.ToDate.Tag = "DelayUntil"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPassword.Location = New System.Drawing.Point(989, 37)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(76, 17)
        Me.lblPassword.TabIndex = 190
        Me.lblPassword.Text = "Date"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Delayed
        '
        Me.Delayed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Delayed.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Delayed.FormattingEnabled = True
        Me.Delayed.Items.AddRange(New Object() {"No", "Yes", "All"})
        Me.Delayed.Location = New System.Drawing.Point(943, 86)
        Me.Delayed.Name = "Delayed"
        Me.Delayed.Size = New System.Drawing.Size(41, 23)
        Me.Delayed.TabIndex = 13
        Me.Delayed.Tag = "Delayed"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(943, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 43)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "Delayed"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LevelId
        '
        Me.LevelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LevelId.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.LevelId.FormattingEnabled = True
        Me.LevelId.Location = New System.Drawing.Point(543, 86)
        Me.LevelId.Name = "LevelId"
        Me.LevelId.Size = New System.Drawing.Size(76, 23)
        Me.LevelId.TabIndex = 5
        Me.LevelId.Tag = "StLevel"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(543, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 43)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Course"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreateGroup
        '
        Me.CreateGroup.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.CreateGroup.Location = New System.Drawing.Point(729, 483)
        Me.CreateGroup.Name = "CreateGroup"
        Me.CreateGroup.Size = New System.Drawing.Size(98, 82)
        Me.CreateGroup.TabIndex = 23
        Me.CreateGroup.Text = "Create Group"
        Me.CreateGroup.UseVisualStyleBackColor = True
        '
        'CreateVirtualGroup
        '
        Me.CreateVirtualGroup.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.CreateVirtualGroup.Location = New System.Drawing.Point(833, 483)
        Me.CreateVirtualGroup.Name = "CreateVirtualGroup"
        Me.CreateVirtualGroup.Size = New System.Drawing.Size(98, 82)
        Me.CreateVirtualGroup.TabIndex = 24
        Me.CreateVirtualGroup.Text = "Create Virtual Group"
        Me.CreateVirtualGroup.UseVisualStyleBackColor = True
        '
        'CategoryId2
        '
        Me.CategoryId2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryId2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.CategoryId2.FormattingEnabled = True
        Me.CategoryId2.Location = New System.Drawing.Point(146, 530)
        Me.CategoryId2.Name = "CategoryId2"
        Me.CategoryId2.Size = New System.Drawing.Size(203, 23)
        Me.CategoryId2.TabIndex = 17
        '
        'DepartmentId2
        '
        Me.DepartmentId2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentId2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DepartmentId2.FormattingEnabled = True
        Me.DepartmentId2.Location = New System.Drawing.Point(146, 502)
        Me.DepartmentId2.Name = "DepartmentId2"
        Me.DepartmentId2.Size = New System.Drawing.Size(203, 23)
        Me.DepartmentId2.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(22, 530)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 23)
        Me.Label12.TabIndex = 201
        Me.Label12.Text = "Category"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(22, 502)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 23)
        Me.Label13.TabIndex = 202
        Me.Label13.Text = "Department"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(355, 502)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 23)
        Me.Label14.TabIndex = 200
        Me.Label14.Text = "Course"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Course
        '
        Me.Course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Course.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Course.FormattingEnabled = True
        Me.Course.Location = New System.Drawing.Point(479, 502)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(203, 23)
        Me.Course.TabIndex = 18
        '
        'btnCourseSearch
        '
        Me.btnCourseSearch.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnCourseSearch.Location = New System.Drawing.Point(688, 502)
        Me.btnCourseSearch.Name = "btnCourseSearch"
        Me.btnCourseSearch.Size = New System.Drawing.Size(30, 23)
        Me.btnCourseSearch.TabIndex = 20
        Me.btnCourseSearch.TabStop = False
        Me.btnCourseSearch.Text = "..."
        Me.btnCourseSearch.UseVisualStyleBackColor = True
        '
        'btnEmpSearch
        '
        Me.btnEmpSearch.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnEmpSearch.Location = New System.Drawing.Point(688, 530)
        Me.btnEmpSearch.Name = "btnEmpSearch"
        Me.btnEmpSearch.Size = New System.Drawing.Size(30, 23)
        Me.btnEmpSearch.TabIndex = 22
        Me.btnEmpSearch.TabStop = False
        Me.btnEmpSearch.Text = "..."
        Me.btnEmpSearch.UseVisualStyleBackColor = True
        '
        'Instractor
        '
        Me.Instractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Instractor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Instractor.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Instractor.FormattingEnabled = True
        Me.Instractor.Location = New System.Drawing.Point(479, 530)
        Me.Instractor.Name = "Instractor"
        Me.Instractor.Size = New System.Drawing.Size(203, 23)
        Me.Instractor.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(355, 530)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 23)
        Me.Label15.TabIndex = 206
        Me.Label15.Text = "Instructor"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Gold
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(1194, 85)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 24)
        Me.CheckBox1.TabIndex = 207
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'AddToGroup
        '
        Me.AddToGroup.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.AddToGroup.Location = New System.Drawing.Point(937, 483)
        Me.AddToGroup.Name = "AddToGroup"
        Me.AddToGroup.Size = New System.Drawing.Size(98, 82)
        Me.AddToGroup.TabIndex = 24
        Me.AddToGroup.Text = "Add To Group"
        Me.AddToGroup.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(1041, 526)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 39)
        Me.btnClose.TabIndex = 208
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Mobile
        '
        Me.Mobile.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Mobile.Location = New System.Drawing.Point(272, 86)
        Me.Mobile.MaxLength = 100
        Me.Mobile.Name = "Mobile"
        Me.Mobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mobile.Size = New System.Drawing.Size(54, 23)
        Me.Mobile.TabIndex = 2
        Me.Mobile.Tag = "EnName"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(272, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 43)
        Me.Label16.TabIndex = 188
        Me.Label16.Text = "Mob."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(11, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 43)
        Me.Label17.TabIndex = 163
        Me.Label17.Text = "City"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cities
        '
        Me.Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cities.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Cities.FormattingEnabled = True
        Me.Cities.Location = New System.Drawing.Point(11, 86)
        Me.Cities.Name = "Cities"
        Me.Cities.Size = New System.Drawing.Size(54, 23)
        Me.Cities.TabIndex = 0
        Me.Cities.Tag = "CityName"
        '
        'btnPrint
        '
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrint.Location = New System.Drawing.Point(1041, 483)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(77, 39)
        Me.btnPrint.TabIndex = 208
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(1070, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 71)
        Me.Label19.TabIndex = 190
        Me.Label19.Text = "Remaining"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(1123, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 71)
        Me.Label20.TabIndex = 190
        Me.Label20.Text = "Installments"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label20.Visible = False
        '
        'HomePhone
        '
        Me.HomePhone.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.HomePhone.Location = New System.Drawing.Point(329, 86)
        Me.HomePhone.MaxLength = 100
        Me.HomePhone.Name = "HomePhone"
        Me.HomePhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomePhone.Size = New System.Drawing.Size(51, 23)
        Me.HomePhone.TabIndex = 2
        Me.HomePhone.Tag = "EnName"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(329, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 43)
        Me.Label21.TabIndex = 188
        Me.Label21.Text = "Work Phone"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.Red
        Me.btnSearch.Location = New System.Drawing.Point(11, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(1236, 36)
        Me.btnSearch.TabIndex = 209
        Me.btnSearch.Text = "Click here to search . . . "
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FromDate
        '
        Me.FromDate.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FromDate.Location = New System.Drawing.Point(989, 57)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(76, 23)
        Me.FromDate.TabIndex = 210
        Me.FromDate.Tag = "DelayUntil"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(1071, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 43)
        Me.Label22.TabIndex = 212
        Me.Label22.Text = "Notes"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notes
        '
        Me.Notes.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Notes.Location = New System.Drawing.Point(1071, 85)
        Me.Notes.MaxLength = 100
        Me.Notes.Name = "Notes"
        Me.Notes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Notes.Size = New System.Drawing.Size(117, 23)
        Me.Notes.TabIndex = 211
        Me.Notes.Tag = "EnName"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(1123, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 39)
        Me.Button1.TabIndex = 213
        Me.Button1.Text = "Print for Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SearchWaiting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1256, 572)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnEmpSearch)
        Me.Controls.Add(Me.Instractor)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnCourseSearch)
        Me.Controls.Add(Me.CategoryId2)
        Me.Controls.Add(Me.DepartmentId2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Course)
        Me.Controls.Add(Me.AddToGroup)
        Me.Controls.Add(Me.CreateVirtualGroup)
        Me.Controls.Add(Me.CreateGroup)
        Me.Controls.Add(Me.LevelId)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Delayed)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.HomePhone)
        Me.Controls.Add(Me.Mobile)
        Me.Controls.Add(Me.EnName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Shift4)
        Me.Controls.Add(Me.Shift2)
        Me.Controls.Add(Me.Days3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Shift3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Shift1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Days2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Days1)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.CategoryId)
        Me.Controls.Add(Me.DepartmentId)
        Me.Controls.Add(Me.lblMain2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Cities)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SearchWaiting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchWaiting"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Public WithEvents CategoryId As System.Windows.Forms.ComboBox
    Public WithEvents DepartmentId As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Public WithEvents Days1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Days2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Days3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Shift1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Shift2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Shift3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Shift4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents EnName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Public WithEvents Delayed As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents LevelId As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CreateGroup As System.Windows.Forms.Button
    Friend WithEvents CreateVirtualGroup As System.Windows.Forms.Button
    Public WithEvents CategoryId2 As System.Windows.Forms.ComboBox
    Public WithEvents DepartmentId2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Course As System.Windows.Forms.ComboBox
    Friend WithEvents btnCourseSearch As System.Windows.Forms.Button
    Friend WithEvents btnEmpSearch As System.Windows.Forms.Button
    Public WithEvents Instractor As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents AddToGroup As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Mobile As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Cities As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents HomePhone As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
