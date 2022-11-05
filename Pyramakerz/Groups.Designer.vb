<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Groups
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
        Me.DayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevios = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEmpSearch = New System.Windows.Forms.Button()
        Me.Instractor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.Id = New System.Windows.Forms.TextBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCourseSearch = New System.Windows.Forms.Button()
        Me.btnGroupSearch = New System.Windows.Forms.Button()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.Days = New System.Windows.Forms.ComboBox()
        Me.Course = New System.Windows.Forms.ComboBox()
        Me.Intensive = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NoOfHours = New System.Windows.Forms.ComboBox()
        Me.Saturday = New System.Windows.Forms.CheckBox()
        Me.Sunday = New System.Windows.Forms.CheckBox()
        Me.Monday = New System.Windows.Forms.CheckBox()
        Me.Tuesday = New System.Windows.Forms.CheckBox()
        Me.Wednesday = New System.Windows.Forms.CheckBox()
        Me.Thursday = New System.Windows.Forms.CheckBox()
        Me.Friday = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LectureNo = New System.Windows.Forms.ComboBox()
        Me.ChekPrivate = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CategoryId = New System.Windows.Forms.ComboBox()
        Me.DepartmentId = New System.Windows.Forms.ComboBox()
        Me.lblMain2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Closed = New System.Windows.Forms.CheckBox()
        Me.btnGenerateStudents = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.PrivateHours = New System.Windows.Forms.TextBox()
        Me.PrivateMinits = New System.Windows.Forms.TextBox()
        Me.lblPrivateMinits = New System.Windows.Forms.Label()
        Me.lblPrivateHours = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ReLecture = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Upgraded = New System.Windows.Forms.CheckBox()
        Me.CloseDate = New System.Windows.Forms.DateTimePicker()
        Me.UpgradeDate = New System.Windows.Forms.DateTimePicker()
        Me.MyGetDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DayDate
        '
        Me.DayDate.CustomFormat = "yyyy-MM-dd"
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(136, 205)
        Me.DayDate.Name = "DayDate"
        Me.DayDate.Size = New System.Drawing.Size(203, 26)
        Me.DayDate.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(12, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 171
        Me.Label10.Text = "Starting Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.SystemColors.Info
        Me.UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserName.ForeColor = System.Drawing.Color.Red
        Me.UserName.Location = New System.Drawing.Point(673, 8)
        Me.UserName.MaxLength = 15
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserName.Size = New System.Drawing.Size(117, 26)
        Me.UserName.TabIndex = 1
        Me.UserName.TabStop = False
        Me.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(550, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 26)
        Me.Label17.TabIndex = 169
        Me.Label17.Text = "UserName"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotes
        '
        Me.lblNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotes.Location = New System.Drawing.Point(12, 371)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(117, 26)
        Me.lblNotes.TabIndex = 166
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notes
        '
        Me.Notes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Notes.Location = New System.Drawing.Point(136, 371)
        Me.Notes.MaxLength = 100
        Me.Notes.Name = "Notes"
        Me.Notes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Notes.Size = New System.Drawing.Size(533, 26)
        Me.Notes.TabIndex = 28
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(315, 404)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 30
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(481, 404)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLast.Location = New System.Drawing.Point(481, 436)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 26)
        Me.btnLast.TabIndex = 36
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(398, 404)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevios
        '
        Me.btnPrevios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevios.ForeColor = System.Drawing.Color.Black
        Me.btnPrevios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrevios.Location = New System.Drawing.Point(315, 436)
        Me.btnPrevios.Name = "btnPrevios"
        Me.btnPrevios.Size = New System.Drawing.Size(77, 26)
        Me.btnPrevios.TabIndex = 34
        Me.btnPrevios.Text = "Previous"
        Me.btnPrevios.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFirst.Location = New System.Drawing.Point(232, 436)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 26)
        Me.btnFirst.TabIndex = 33
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(398, 436)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 26)
        Me.btnNext.TabIndex = 35
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(232, 404)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEmpSearch
        '
        Me.btnEmpSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmpSearch.Location = New System.Drawing.Point(345, 172)
        Me.btnEmpSearch.Name = "btnEmpSearch"
        Me.btnEmpSearch.Size = New System.Drawing.Size(30, 26)
        Me.btnEmpSearch.TabIndex = 10
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
        Me.Instractor.Location = New System.Drawing.Point(136, 172)
        Me.Instractor.Name = "Instractor"
        Me.Instractor.Size = New System.Drawing.Size(203, 27)
        Me.Instractor.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Instructor"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Branch
        '
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(136, 9)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(326, 27)
        Me.Branch.TabIndex = 0
        '
        'Id
        '
        Me.Id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Id.Location = New System.Drawing.Point(136, 41)
        Me.Id.MaxLength = 10
        Me.Id.Name = "Id"
        Me.Id.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Id.Size = New System.Drawing.Size(100, 26)
        Me.Id.TabIndex = 1
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(117, 26)
        Me.lblMain.TabIndex = 161
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Group"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "Course"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCourseSearch
        '
        Me.btnCourseSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCourseSearch.Location = New System.Drawing.Point(345, 139)
        Me.btnCourseSearch.Name = "btnCourseSearch"
        Me.btnCourseSearch.Size = New System.Drawing.Size(30, 26)
        Me.btnCourseSearch.TabIndex = 8
        Me.btnCourseSearch.TabStop = False
        Me.btnCourseSearch.Text = "..."
        Me.btnCourseSearch.UseVisualStyleBackColor = True
        '
        'btnGroupSearch
        '
        Me.btnGroupSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGroupSearch.Location = New System.Drawing.Point(242, 41)
        Me.btnGroupSearch.Name = "btnGroupSearch"
        Me.btnGroupSearch.Size = New System.Drawing.Size(30, 26)
        Me.btnGroupSearch.TabIndex = 2
        Me.btnGroupSearch.TabStop = False
        Me.btnGroupSearch.Text = "..."
        Me.btnGroupSearch.UseVisualStyleBackColor = True
        '
        'lblDays
        '
        Me.lblDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDays.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDays.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDays.Location = New System.Drawing.Point(12, 270)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(117, 26)
        Me.lblDays.TabIndex = 14
        Me.lblDays.Text = "Days"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Days
        '
        Me.Days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Days.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Days.FormattingEnabled = True
        Me.Days.Items.AddRange(New Object() {"", "Saturday - Tuesday", "Sunday - Wednesday", "Monday - Thursday"})
        Me.Days.Location = New System.Drawing.Point(136, 270)
        Me.Days.Name = "Days"
        Me.Days.Size = New System.Drawing.Size(203, 27)
        Me.Days.TabIndex = 16
        '
        'Course
        '
        Me.Course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Course.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Course.FormattingEnabled = True
        Me.Course.Location = New System.Drawing.Point(136, 138)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(203, 27)
        Me.Course.TabIndex = 7
        '
        'Intensive
        '
        Me.Intensive.AutoSize = True
        Me.Intensive.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Intensive.Location = New System.Drawing.Point(121, 244)
        Me.Intensive.Name = "Intensive"
        Me.Intensive.Size = New System.Drawing.Size(15, 14)
        Me.Intensive.TabIndex = 13
        Me.Intensive.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(12, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 26)
        Me.Label12.TabIndex = 175
        Me.Label12.Text = "Intensive"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NoOfHours
        '
        Me.NoOfHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NoOfHours.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NoOfHours.FormattingEnabled = True
        Me.NoOfHours.Location = New System.Drawing.Point(136, 238)
        Me.NoOfHours.Name = "NoOfHours"
        Me.NoOfHours.Size = New System.Drawing.Size(203, 27)
        Me.NoOfHours.TabIndex = 14
        '
        'Saturday
        '
        Me.Saturday.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Saturday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Saturday.Location = New System.Drawing.Point(12, 272)
        Me.Saturday.Name = "Saturday"
        Me.Saturday.Size = New System.Drawing.Size(105, 23)
        Me.Saturday.TabIndex = 13
        Me.Saturday.Text = "Saturday"
        Me.Saturday.UseVisualStyleBackColor = False
        '
        'Sunday
        '
        Me.Sunday.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Sunday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sunday.Location = New System.Drawing.Point(121, 272)
        Me.Sunday.Name = "Sunday"
        Me.Sunday.Size = New System.Drawing.Size(105, 23)
        Me.Sunday.TabIndex = 18
        Me.Sunday.Text = "Sunday"
        Me.Sunday.UseVisualStyleBackColor = False
        '
        'Monday
        '
        Me.Monday.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Monday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Monday.Location = New System.Drawing.Point(232, 272)
        Me.Monday.Name = "Monday"
        Me.Monday.Size = New System.Drawing.Size(105, 23)
        Me.Monday.TabIndex = 19
        Me.Monday.Text = "Monday"
        Me.Monday.UseVisualStyleBackColor = False
        '
        'Tuesday
        '
        Me.Tuesday.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Tuesday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Tuesday.Location = New System.Drawing.Point(345, 272)
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.Size = New System.Drawing.Size(105, 23)
        Me.Tuesday.TabIndex = 20
        Me.Tuesday.Text = "Tuesday"
        Me.Tuesday.UseVisualStyleBackColor = False
        '
        'Wednesday
        '
        Me.Wednesday.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Wednesday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Wednesday.Location = New System.Drawing.Point(454, 272)
        Me.Wednesday.Name = "Wednesday"
        Me.Wednesday.Size = New System.Drawing.Size(105, 23)
        Me.Wednesday.TabIndex = 21
        Me.Wednesday.Text = "Wednesday"
        Me.Wednesday.UseVisualStyleBackColor = False
        '
        'Thursday
        '
        Me.Thursday.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Thursday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Thursday.Location = New System.Drawing.Point(565, 272)
        Me.Thursday.Name = "Thursday"
        Me.Thursday.Size = New System.Drawing.Size(105, 23)
        Me.Thursday.TabIndex = 22
        Me.Thursday.Text = "Thursday"
        Me.Thursday.UseVisualStyleBackColor = False
        '
        'Friday
        '
        Me.Friday.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Friday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Friday.Location = New System.Drawing.Point(676, 272)
        Me.Friday.Name = "Friday"
        Me.Friday.Size = New System.Drawing.Size(105, 23)
        Me.Friday.TabIndex = 23
        Me.Friday.Text = "Friday"
        Me.Friday.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(12, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 26)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "LectureNo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LectureNo
        '
        Me.LectureNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LectureNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LectureNo.FormattingEnabled = True
        Me.LectureNo.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.LectureNo.Location = New System.Drawing.Point(136, 304)
        Me.LectureNo.Name = "LectureNo"
        Me.LectureNo.Size = New System.Drawing.Size(203, 27)
        Me.LectureNo.TabIndex = 24
        '
        'ChekPrivate
        '
        Me.ChekPrivate.AutoSize = True
        Me.ChekPrivate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChekPrivate.Location = New System.Drawing.Point(120, 343)
        Me.ChekPrivate.Name = "ChekPrivate"
        Me.ChekPrivate.Size = New System.Drawing.Size(15, 14)
        Me.ChekPrivate.TabIndex = 25
        Me.ChekPrivate.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 173
        Me.Label6.Text = "Private"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CategoryId
        '
        Me.CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CategoryId.FormattingEnabled = True
        Me.CategoryId.Location = New System.Drawing.Point(136, 106)
        Me.CategoryId.Name = "CategoryId"
        Me.CategoryId.Size = New System.Drawing.Size(203, 27)
        Me.CategoryId.TabIndex = 6
        '
        'DepartmentId
        '
        Me.DepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DepartmentId.FormattingEnabled = True
        Me.DepartmentId.Location = New System.Drawing.Point(136, 73)
        Me.DepartmentId.Name = "DepartmentId"
        Me.DepartmentId.Size = New System.Drawing.Size(203, 27)
        Me.DepartmentId.TabIndex = 5
        '
        'lblMain2
        '
        Me.lblMain2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain2.Location = New System.Drawing.Point(12, 106)
        Me.lblMain2.Name = "lblMain2"
        Me.lblMain2.Size = New System.Drawing.Size(117, 26)
        Me.lblMain2.TabIndex = 178
        Me.lblMain2.Text = "Category"
        Me.lblMain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "Department"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(591, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 26)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Closed"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Closed
        '
        Me.Closed.AutoSize = True
        Me.Closed.Enabled = False
        Me.Closed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Closed.ForeColor = System.Drawing.Color.Black
        Me.Closed.Location = New System.Drawing.Point(672, 86)
        Me.Closed.Name = "Closed"
        Me.Closed.Size = New System.Drawing.Size(15, 14)
        Me.Closed.TabIndex = 24
        Me.Closed.UseVisualStyleBackColor = False
        '
        'btnGenerateStudents
        '
        Me.btnGenerateStudents.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateStudents.Location = New System.Drawing.Point(278, 41)
        Me.btnGenerateStudents.Name = "btnGenerateStudents"
        Me.btnGenerateStudents.Size = New System.Drawing.Size(184, 26)
        Me.btnGenerateStudents.TabIndex = 3
        Me.btnGenerateStudents.TabStop = False
        Me.btnGenerateStudents.Text = "Generate Students"
        Me.btnGenerateStudents.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnImport.Location = New System.Drawing.Point(468, 41)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 26)
        Me.btnImport.TabIndex = 4
        Me.btnImport.TabStop = False
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'PrivateHours
        '
        Me.PrivateHours.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PrivateHours.Location = New System.Drawing.Point(141, 337)
        Me.PrivateHours.MaxLength = 3
        Me.PrivateHours.Name = "PrivateHours"
        Me.PrivateHours.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrivateHours.Size = New System.Drawing.Size(59, 26)
        Me.PrivateHours.TabIndex = 26
        Me.PrivateHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrivateMinits
        '
        Me.PrivateMinits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PrivateMinits.Location = New System.Drawing.Point(250, 337)
        Me.PrivateMinits.MaxLength = 2
        Me.PrivateMinits.Name = "PrivateMinits"
        Me.PrivateMinits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrivateMinits.Size = New System.Drawing.Size(59, 26)
        Me.PrivateMinits.TabIndex = 27
        Me.PrivateMinits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPrivateMinits
        '
        Me.lblPrivateMinits.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrivateMinits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrivateMinits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrivateMinits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrivateMinits.Location = New System.Drawing.Point(315, 337)
        Me.lblPrivateMinits.Name = "lblPrivateMinits"
        Me.lblPrivateMinits.Size = New System.Drawing.Size(39, 26)
        Me.lblPrivateMinits.TabIndex = 173
        Me.lblPrivateMinits.Text = "Min"
        Me.lblPrivateMinits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrivateHours
        '
        Me.lblPrivateHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrivateHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrivateHours.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrivateHours.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrivateHours.Location = New System.Drawing.Point(206, 337)
        Me.lblPrivateHours.Name = "lblPrivateHours"
        Me.lblPrivateHours.Size = New System.Drawing.Size(39, 26)
        Me.lblPrivateHours.TabIndex = 173
        Me.lblPrivateHours.Text = "Hr"
        Me.lblPrivateHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrint.Location = New System.Drawing.Point(610, 404)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(77, 58)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'ReLecture
        '
        Me.ReLecture.AutoSize = True
        Me.ReLecture.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReLecture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ReLecture.Location = New System.Drawing.Point(345, 207)
        Me.ReLecture.Name = "ReLecture"
        Me.ReLecture.Size = New System.Drawing.Size(100, 23)
        Me.ReLecture.TabIndex = 12
        Me.ReLecture.Text = "ReLecture"
        Me.ReLecture.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(591, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 26)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "Upgraded"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Upgraded
        '
        Me.Upgraded.AutoSize = True
        Me.Upgraded.Enabled = False
        Me.Upgraded.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Upgraded.ForeColor = System.Drawing.Color.Black
        Me.Upgraded.Location = New System.Drawing.Point(672, 113)
        Me.Upgraded.Name = "Upgraded"
        Me.Upgraded.Size = New System.Drawing.Size(15, 14)
        Me.Upgraded.TabIndex = 24
        Me.Upgraded.UseVisualStyleBackColor = False
        '
        'CloseDate
        '
        Me.CloseDate.Enabled = False
        Me.CloseDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CloseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CloseDate.Location = New System.Drawing.Point(687, 80)
        Me.CloseDate.Name = "CloseDate"
        Me.CloseDate.ShowUpDown = True
        Me.CloseDate.Size = New System.Drawing.Size(100, 26)
        Me.CloseDate.TabIndex = 11
        Me.CloseDate.Visible = False
        '
        'UpgradeDate
        '
        Me.UpgradeDate.Enabled = False
        Me.UpgradeDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UpgradeDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.UpgradeDate.Location = New System.Drawing.Point(687, 107)
        Me.UpgradeDate.Name = "UpgradeDate"
        Me.UpgradeDate.ShowUpDown = True
        Me.UpgradeDate.Size = New System.Drawing.Size(100, 26)
        Me.UpgradeDate.TabIndex = 11
        Me.UpgradeDate.Visible = False
        '
        'MyGetDate
        '
        Me.MyGetDate.BackColor = System.Drawing.SystemColors.Info
        Me.MyGetDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MyGetDate.ForeColor = System.Drawing.Color.Red
        Me.MyGetDate.Location = New System.Drawing.Point(550, 41)
        Me.MyGetDate.MaxLength = 15
        Me.MyGetDate.Name = "MyGetDate"
        Me.MyGetDate.ReadOnly = True
        Me.MyGetDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MyGetDate.Size = New System.Drawing.Size(240, 26)
        Me.MyGetDate.TabIndex = 243
        Me.MyGetDate.TabStop = False
        Me.MyGetDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Groups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(793, 469)
        Me.Controls.Add(Me.MyGetDate)
        Me.Controls.Add(Me.ReLecture)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.CategoryId)
        Me.Controls.Add(Me.DepartmentId)
        Me.Controls.Add(Me.lblMain2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Upgraded)
        Me.Controls.Add(Me.Closed)
        Me.Controls.Add(Me.ChekPrivate)
        Me.Controls.Add(Me.Friday)
        Me.Controls.Add(Me.Thursday)
        Me.Controls.Add(Me.Monday)
        Me.Controls.Add(Me.Wednesday)
        Me.Controls.Add(Me.Sunday)
        Me.Controls.Add(Me.Tuesday)
        Me.Controls.Add(Me.Saturday)
        Me.Controls.Add(Me.Intensive)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NoOfHours)
        Me.Controls.Add(Me.LectureNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Days)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblPrivateHours)
        Me.Controls.Add(Me.lblPrivateMinits)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UpgradeDate)
        Me.Controls.Add(Me.CloseDate)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevios)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnGenerateStudents)
        Me.Controls.Add(Me.btnGroupSearch)
        Me.Controls.Add(Me.btnCourseSearch)
        Me.Controls.Add(Me.btnEmpSearch)
        Me.Controls.Add(Me.Course)
        Me.Controls.Add(Me.Instractor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.PrivateMinits)
        Me.Controls.Add(Me.PrivateHours)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Groups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Groups"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrevios As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEmpSearch As System.Windows.Forms.Button
    Public WithEvents Instractor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents Id As System.Windows.Forms.TextBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCourseSearch As System.Windows.Forms.Button
    Friend WithEvents btnGroupSearch As System.Windows.Forms.Button
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Public WithEvents Days As System.Windows.Forms.ComboBox
    Public WithEvents Course As System.Windows.Forms.ComboBox
    Friend WithEvents Intensive As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents NoOfHours As System.Windows.Forms.ComboBox
    Friend WithEvents Saturday As System.Windows.Forms.CheckBox
    Friend WithEvents Sunday As System.Windows.Forms.CheckBox
    Friend WithEvents Monday As System.Windows.Forms.CheckBox
    Friend WithEvents Tuesday As System.Windows.Forms.CheckBox
    Friend WithEvents Wednesday As System.Windows.Forms.CheckBox
    Friend WithEvents Thursday As System.Windows.Forms.CheckBox
    Friend WithEvents Friday As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents LectureNo As System.Windows.Forms.ComboBox
    Friend WithEvents ChekPrivate As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents CategoryId As System.Windows.Forms.ComboBox
    Public WithEvents DepartmentId As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Closed As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenerateStudents As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents PrivateHours As System.Windows.Forms.TextBox
    Friend WithEvents PrivateMinits As System.Windows.Forms.TextBox
    Friend WithEvents lblPrivateMinits As System.Windows.Forms.Label
    Friend WithEvents lblPrivateHours As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents ReLecture As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Upgraded As System.Windows.Forms.CheckBox
    Friend WithEvents CloseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents UpgradeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents MyGetDate As System.Windows.Forms.TextBox
End Class
