<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAttendance
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
        Me.lblPrivateHours = New System.Windows.Forms.Label()
        Me.lblPrivateMinits = New System.Windows.Forms.Label()
        Me.Min1 = New System.Windows.Forms.TextBox()
        Me.Hr1 = New System.Windows.Forms.TextBox()
        Me.tt1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEmpSearch = New System.Windows.Forms.Button()
        Me.Instractor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tt2 = New System.Windows.Forms.ComboBox()
        Me.Hr2 = New System.Windows.Forms.TextBox()
        Me.Min2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tt3 = New System.Windows.Forms.ComboBox()
        Me.Hr3 = New System.Windows.Forms.TextBox()
        Me.Min3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tt4 = New System.Windows.Forms.ComboBox()
        Me.Hr4 = New System.Windows.Forms.TextBox()
        Me.Min4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblSuccess = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrivateHours
        '
        Me.lblPrivateHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrivateHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrivateHours.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrivateHours.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrivateHours.Location = New System.Drawing.Point(10, 23)
        Me.lblPrivateHours.Name = "lblPrivateHours"
        Me.lblPrivateHours.Size = New System.Drawing.Size(39, 26)
        Me.lblPrivateHours.TabIndex = 177
        Me.lblPrivateHours.Text = "Hr"
        Me.lblPrivateHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrivateMinits
        '
        Me.lblPrivateMinits.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrivateMinits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrivateMinits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrivateMinits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrivateMinits.Location = New System.Drawing.Point(54, 23)
        Me.lblPrivateMinits.Name = "lblPrivateMinits"
        Me.lblPrivateMinits.Size = New System.Drawing.Size(39, 26)
        Me.lblPrivateMinits.TabIndex = 178
        Me.lblPrivateMinits.Text = "Min"
        Me.lblPrivateMinits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Min1
        '
        Me.Min1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Min1.Location = New System.Drawing.Point(54, 54)
        Me.Min1.MaxLength = 2
        Me.Min1.Name = "Min1"
        Me.Min1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Min1.Size = New System.Drawing.Size(39, 26)
        Me.Min1.TabIndex = 1
        Me.Min1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Hr1
        '
        Me.Hr1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Hr1.Location = New System.Drawing.Point(10, 54)
        Me.Hr1.MaxLength = 2
        Me.Hr1.Name = "Hr1"
        Me.Hr1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Hr1.Size = New System.Drawing.Size(39, 26)
        Me.Hr1.TabIndex = 0
        Me.Hr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tt1
        '
        Me.tt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tt1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tt1.FormattingEnabled = True
        Me.tt1.Items.AddRange(New Object() {"AM", "PM"})
        Me.tt1.Location = New System.Drawing.Point(99, 54)
        Me.tt1.Name = "tt1"
        Me.tt1.Size = New System.Drawing.Size(49, 27)
        Me.tt1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Green
        Me.GroupBox1.Controls.Add(Me.tt1)
        Me.GroupBox1.Controls.Add(Me.Hr1)
        Me.GroupBox1.Controls.Add(Me.Min1)
        Me.GroupBox1.Controls.Add(Me.lblPrivateHours)
        Me.GroupBox1.Controls.Add(Me.lblPrivateMinits)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 92)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Default Login Time"
        '
        'DayDate
        '
        Me.DayDate.CustomFormat = "yyyy-MM-dd"
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(135, 46)
        Me.DayDate.Name = "DayDate"
        Me.DayDate.Size = New System.Drawing.Size(203, 26)
        Me.DayDate.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(12, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 182
        Me.Label10.Text = "Day Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEmpSearch
        '
        Me.btnEmpSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmpSearch.Location = New System.Drawing.Point(345, 9)
        Me.btnEmpSearch.Name = "btnEmpSearch"
        Me.btnEmpSearch.Size = New System.Drawing.Size(30, 26)
        Me.btnEmpSearch.TabIndex = 1
        Me.btnEmpSearch.TabStop = False
        Me.btnEmpSearch.Text = "..."
        Me.btnEmpSearch.UseVisualStyleBackColor = True
        '
        'Instractor
        '
        Me.Instractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Instractor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Instractor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Instractor.FormattingEnabled = True
        Me.Instractor.Location = New System.Drawing.Point(136, 9)
        Me.Instractor.Name = "Instractor"
        Me.Instractor.Size = New System.Drawing.Size(203, 27)
        Me.Instractor.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 185
        Me.Label5.Text = "Employee"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Green
        Me.GroupBox2.Controls.Add(Me.tt2)
        Me.GroupBox2.Controls.Add(Me.Hr2)
        Me.GroupBox2.Controls.Add(Me.Min2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(205, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 92)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Login Time"
        '
        'tt2
        '
        Me.tt2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tt2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tt2.FormattingEnabled = True
        Me.tt2.Items.AddRange(New Object() {"AM", "PM"})
        Me.tt2.Location = New System.Drawing.Point(99, 54)
        Me.tt2.Name = "tt2"
        Me.tt2.Size = New System.Drawing.Size(49, 27)
        Me.tt2.TabIndex = 2
        '
        'Hr2
        '
        Me.Hr2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Hr2.Location = New System.Drawing.Point(10, 54)
        Me.Hr2.MaxLength = 2
        Me.Hr2.Name = "Hr2"
        Me.Hr2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Hr2.Size = New System.Drawing.Size(39, 26)
        Me.Hr2.TabIndex = 0
        Me.Hr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Min2
        '
        Me.Min2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Min2.Location = New System.Drawing.Point(54, 54)
        Me.Min2.MaxLength = 2
        Me.Min2.Name = "Min2"
        Me.Min2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Min2.Size = New System.Drawing.Size(39, 26)
        Me.Min2.TabIndex = 1
        Me.Min2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 26)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Hr"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(54, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 26)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "Min"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Red
        Me.GroupBox3.Controls.Add(Me.tt3)
        Me.GroupBox3.Controls.Add(Me.Hr3)
        Me.GroupBox3.Controls.Add(Me.Min3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 92)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Default LogOut Time"
        '
        'tt3
        '
        Me.tt3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tt3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tt3.FormattingEnabled = True
        Me.tt3.Items.AddRange(New Object() {"AM", "PM"})
        Me.tt3.Location = New System.Drawing.Point(99, 54)
        Me.tt3.Name = "tt3"
        Me.tt3.Size = New System.Drawing.Size(49, 27)
        Me.tt3.TabIndex = 2
        '
        'Hr3
        '
        Me.Hr3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Hr3.Location = New System.Drawing.Point(10, 54)
        Me.Hr3.MaxLength = 2
        Me.Hr3.Name = "Hr3"
        Me.Hr3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Hr3.Size = New System.Drawing.Size(39, 26)
        Me.Hr3.TabIndex = 0
        Me.Hr3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Min3
        '
        Me.Min3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Min3.Location = New System.Drawing.Point(54, 54)
        Me.Min3.MaxLength = 2
        Me.Min3.Name = "Min3"
        Me.Min3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Min3.Size = New System.Drawing.Size(39, 26)
        Me.Min3.TabIndex = 1
        Me.Min3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(10, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 26)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Hr"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(54, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 26)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "Min"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Red
        Me.GroupBox4.Controls.Add(Me.tt4)
        Me.GroupBox4.Controls.Add(Me.Hr4)
        Me.GroupBox4.Controls.Add(Me.Min4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(205, 248)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(171, 92)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current LogOut Time"
        '
        'tt4
        '
        Me.tt4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tt4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tt4.FormattingEnabled = True
        Me.tt4.Items.AddRange(New Object() {"AM", "PM"})
        Me.tt4.Location = New System.Drawing.Point(99, 54)
        Me.tt4.Name = "tt4"
        Me.tt4.Size = New System.Drawing.Size(49, 27)
        Me.tt4.TabIndex = 2
        '
        'Hr4
        '
        Me.Hr4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Hr4.Location = New System.Drawing.Point(10, 54)
        Me.Hr4.MaxLength = 2
        Me.Hr4.Name = "Hr4"
        Me.Hr4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Hr4.Size = New System.Drawing.Size(39, 26)
        Me.Hr4.TabIndex = 0
        Me.Hr4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Min4
        '
        Me.Min4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Min4.Location = New System.Drawing.Point(54, 54)
        Me.Min4.MaxLength = 2
        Me.Min4.Name = "Min4"
        Me.Min4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Min4.Size = New System.Drawing.Size(39, 26)
        Me.Min4.TabIndex = 1
        Me.Min4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(10, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 26)
        Me.Label6.TabIndex = 177
        Me.Label6.Text = "Hr"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(54, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 26)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Min"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(298, 348)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(215, 348)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Branch
        '
        Me.Branch.BackColor = System.Drawing.SystemColors.Info
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.ForeColor = System.Drawing.Color.Black
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(136, 79)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(203, 27)
        Me.Branch.TabIndex = 3
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(12, 79)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(117, 26)
        Me.lblMain.TabIndex = 189
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSuccess
        '
        Me.lblSuccess.BackColor = System.Drawing.Color.Yellow
        Me.lblSuccess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSuccess.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSuccess.ForeColor = System.Drawing.Color.Red
        Me.lblSuccess.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSuccess.Location = New System.Drawing.Point(98, 348)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(109, 26)
        Me.lblSuccess.TabIndex = 190
        Me.lblSuccess.Text = "Success"
        Me.lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSuccess.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.Location = New System.Drawing.Point(18, 120)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 23)
        Me.CheckBox1.TabIndex = 191
        Me.CheckBox1.Text = "Login Only"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(12, 348)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'EditAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(398, 380)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblSuccess)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEmpSearch)
        Me.Controls.Add(Me.Instractor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EditAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditAttendance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrivateHours As System.Windows.Forms.Label
    Friend WithEvents lblPrivateMinits As System.Windows.Forms.Label
    Friend WithEvents Min1 As System.Windows.Forms.TextBox
    Friend WithEvents Hr1 As System.Windows.Forms.TextBox
    Public WithEvents tt1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnEmpSearch As System.Windows.Forms.Button
    Public WithEvents Instractor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents tt2 As System.Windows.Forms.ComboBox
    Friend WithEvents Hr2 As System.Windows.Forms.TextBox
    Friend WithEvents Min2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents tt3 As System.Windows.Forms.ComboBox
    Friend WithEvents Hr3 As System.Windows.Forms.TextBox
    Friend WithEvents Min3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents tt4 As System.Windows.Forms.ComboBox
    Friend WithEvents Hr4 As System.Windows.Forms.TextBox
    Friend WithEvents Min4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents lblSuccess As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
