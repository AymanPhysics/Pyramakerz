<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Installments
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
        Me.Value = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevios = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MainInvoiceNo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.InvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Haspayed = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PayedDate = New System.Windows.Forms.DateTimePicker()
        Me.RealInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInvSearch = New System.Windows.Forms.Button()
        Me.txtStId = New System.Windows.Forms.TextBox()
        Me.btnInstallments = New System.Windows.Forms.Button()
        Me.btnRemaining = New System.Windows.Forms.Button()
        Me.btnStudentsMemberships = New System.Windows.Forms.Button()
        Me.btnIncome = New System.Windows.Forms.Button()
        Me.lblStName = New System.Windows.Forms.Label()
        Me.btnBundle = New System.Windows.Forms.Button()
        Me.MyGetDate = New System.Windows.Forms.TextBox()
        Me.UserInserted = New System.Windows.Forms.ComboBox()
        Me.Sales = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DayDate
        '
        Me.DayDate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DayDate.CustomFormat = "yyyy-MM-dd"
        Me.DayDate.Enabled = False
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(308, 116)
        Me.DayDate.Name = "DayDate"
        Me.DayDate.Size = New System.Drawing.Size(203, 26)
        Me.DayDate.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(185, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Day Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.SystemColors.Info
        Me.UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserName.ForeColor = System.Drawing.Color.Red
        Me.UserName.Location = New System.Drawing.Point(779, 22)
        Me.UserName.MaxLength = 15
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserName.Size = New System.Drawing.Size(117, 26)
        Me.UserName.TabIndex = 132
        Me.UserName.TabStop = False
        Me.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(656, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 26)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "UserName"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotes
        '
        Me.lblNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotes.Location = New System.Drawing.Point(184, 241)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(117, 26)
        Me.lblNotes.TabIndex = 130
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notes
        '
        Me.Notes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Notes.Location = New System.Drawing.Point(308, 241)
        Me.Notes.MaxLength = 100
        Me.Notes.Name = "Notes"
        Me.Notes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Notes.Size = New System.Drawing.Size(572, 26)
        Me.Notes.TabIndex = 11
        '
        'Value
        '
        Me.Value.BackColor = System.Drawing.SystemColors.Info
        Me.Value.Enabled = False
        Me.Value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Value.Location = New System.Drawing.Point(308, 178)
        Me.Value.MaxLength = 8
        Me.Value.Name = "Value"
        Me.Value.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Value.Size = New System.Drawing.Size(100, 26)
        Me.Value.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(184, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Value"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(474, 360)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(640, 360)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLast.Location = New System.Drawing.Point(640, 392)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 26)
        Me.btnLast.TabIndex = 19
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(557, 360)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevios
        '
        Me.btnPrevios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevios.ForeColor = System.Drawing.Color.Black
        Me.btnPrevios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrevios.Location = New System.Drawing.Point(474, 392)
        Me.btnPrevios.Name = "btnPrevios"
        Me.btnPrevios.Size = New System.Drawing.Size(77, 26)
        Me.btnPrevios.TabIndex = 17
        Me.btnPrevios.Text = "Previous"
        Me.btnPrevios.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFirst.Location = New System.Drawing.Point(391, 392)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 26)
        Me.btnFirst.TabIndex = 16
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(557, 392)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 26)
        Me.btnNext.TabIndex = 18
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(391, 360)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MainInvoiceNo
        '
        Me.MainInvoiceNo.BackColor = System.Drawing.SystemColors.Info
        Me.MainInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MainInvoiceNo.Enabled = False
        Me.MainInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MainInvoiceNo.FormattingEnabled = True
        Me.MainInvoiceNo.Location = New System.Drawing.Point(308, 147)
        Me.MainInvoiceNo.Name = "MainInvoiceNo"
        Me.MainInvoiceNo.Size = New System.Drawing.Size(203, 27)
        Me.MainInvoiceNo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(184, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Main Inv. No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStSearch
        '
        Me.btnStSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStSearch.Location = New System.Drawing.Point(587, 85)
        Me.btnStSearch.Name = "btnStSearch"
        Me.btnStSearch.Size = New System.Drawing.Size(30, 26)
        Me.btnStSearch.TabIndex = 5
        Me.btnStSearch.TabStop = False
        Me.btnStSearch.Text = "..."
        Me.btnStSearch.UseVisualStyleBackColor = True
        Me.btnStSearch.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(184, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Student"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Branch
        '
        Me.Branch.BackColor = System.Drawing.SystemColors.Info
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(308, 54)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(326, 27)
        Me.Branch.TabIndex = 1
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InvoiceNo.Location = New System.Drawing.Point(308, 23)
        Me.InvoiceNo.MaxLength = 10
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InvoiceNo.Size = New System.Drawing.Size(100, 26)
        Me.InvoiceNo.TabIndex = 0
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(184, 54)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(117, 26)
        Me.lblMain.TabIndex = 125
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(184, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Invoice No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Haspayed
        '
        Me.Haspayed.AutoSize = True
        Me.Haspayed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Haspayed.Location = New System.Drawing.Point(293, 216)
        Me.Haspayed.Name = "Haspayed"
        Me.Haspayed.Size = New System.Drawing.Size(15, 14)
        Me.Haspayed.TabIndex = 9
        Me.Haspayed.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(185, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 26)
        Me.Label12.TabIndex = 137
        Me.Label12.Tag = ""
        Me.Label12.Text = "Has Payed"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PayedDate
        '
        Me.PayedDate.CustomFormat = "yyyy-MM-dd"
        Me.PayedDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PayedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PayedDate.Location = New System.Drawing.Point(308, 209)
        Me.PayedDate.Name = "PayedDate"
        Me.PayedDate.Size = New System.Drawing.Size(203, 26)
        Me.PayedDate.TabIndex = 10
        '
        'RealInvoiceNo
        '
        Me.RealInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RealInvoiceNo.Location = New System.Drawing.Point(779, 85)
        Me.RealInvoiceNo.MaxLength = 10
        Me.RealInvoiceNo.Name = "RealInvoiceNo"
        Me.RealInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RealInvoiceNo.Size = New System.Drawing.Size(117, 26)
        Me.RealInvoiceNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(656, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Real Inv. No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInvSearch
        '
        Me.btnInvSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnInvSearch.Location = New System.Drawing.Point(414, 23)
        Me.btnInvSearch.Name = "btnInvSearch"
        Me.btnInvSearch.Size = New System.Drawing.Size(30, 26)
        Me.btnInvSearch.TabIndex = 140
        Me.btnInvSearch.TabStop = False
        Me.btnInvSearch.Text = "..."
        Me.btnInvSearch.UseVisualStyleBackColor = True
        '
        'txtStId
        '
        Me.txtStId.Enabled = False
        Me.txtStId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStId.ForeColor = System.Drawing.Color.Black
        Me.txtStId.Location = New System.Drawing.Point(308, 85)
        Me.txtStId.MaxLength = 6
        Me.txtStId.Name = "txtStId"
        Me.txtStId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStId.Size = New System.Drawing.Size(64, 26)
        Me.txtStId.TabIndex = 3
        '
        'btnInstallments
        '
        Me.btnInstallments.BackColor = System.Drawing.Color.SteelBlue
        Me.btnInstallments.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstallments.Location = New System.Drawing.Point(12, 332)
        Me.btnInstallments.Name = "btnInstallments"
        Me.btnInstallments.Size = New System.Drawing.Size(154, 78)
        Me.btnInstallments.TabIndex = 162
        Me.btnInstallments.Text = "Installments"
        Me.btnInstallments.UseVisualStyleBackColor = False
        '
        'btnRemaining
        '
        Me.btnRemaining.BackColor = System.Drawing.Color.Gold
        Me.btnRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemaining.Location = New System.Drawing.Point(12, 252)
        Me.btnRemaining.Name = "btnRemaining"
        Me.btnRemaining.Size = New System.Drawing.Size(154, 78)
        Me.btnRemaining.TabIndex = 163
        Me.btnRemaining.Text = "Remaining"
        Me.btnRemaining.UseVisualStyleBackColor = False
        '
        'btnStudentsMemberships
        '
        Me.btnStudentsMemberships.BackColor = System.Drawing.Color.Gold
        Me.btnStudentsMemberships.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentsMemberships.Location = New System.Drawing.Point(12, 92)
        Me.btnStudentsMemberships.Name = "btnStudentsMemberships"
        Me.btnStudentsMemberships.Size = New System.Drawing.Size(154, 78)
        Me.btnStudentsMemberships.TabIndex = 160
        Me.btnStudentsMemberships.Text = "Memberships"
        Me.btnStudentsMemberships.UseVisualStyleBackColor = False
        '
        'btnIncome
        '
        Me.btnIncome.BackColor = System.Drawing.Color.Gold
        Me.btnIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncome.Location = New System.Drawing.Point(12, 12)
        Me.btnIncome.Name = "btnIncome"
        Me.btnIncome.Size = New System.Drawing.Size(154, 78)
        Me.btnIncome.TabIndex = 161
        Me.btnIncome.Text = "Detail"
        Me.btnIncome.UseVisualStyleBackColor = False
        '
        'lblStName
        '
        Me.lblStName.BackColor = System.Drawing.SystemColors.Info
        Me.lblStName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStName.Location = New System.Drawing.Point(377, 86)
        Me.lblStName.Name = "lblStName"
        Me.lblStName.Size = New System.Drawing.Size(208, 25)
        Me.lblStName.TabIndex = 185
        Me.lblStName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBundle
        '
        Me.btnBundle.BackColor = System.Drawing.Color.Gold
        Me.btnBundle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBundle.Location = New System.Drawing.Point(12, 172)
        Me.btnBundle.Name = "btnBundle"
        Me.btnBundle.Size = New System.Drawing.Size(154, 78)
        Me.btnBundle.TabIndex = 236
        Me.btnBundle.Text = "Bundle"
        Me.btnBundle.UseVisualStyleBackColor = False
        '
        'MyGetDate
        '
        Me.MyGetDate.BackColor = System.Drawing.SystemColors.Info
        Me.MyGetDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MyGetDate.ForeColor = System.Drawing.Color.Red
        Me.MyGetDate.Location = New System.Drawing.Point(656, 54)
        Me.MyGetDate.MaxLength = 15
        Me.MyGetDate.Name = "MyGetDate"
        Me.MyGetDate.ReadOnly = True
        Me.MyGetDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MyGetDate.Size = New System.Drawing.Size(240, 26)
        Me.MyGetDate.TabIndex = 243
        Me.MyGetDate.TabStop = False
        Me.MyGetDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserInserted
        '
        Me.UserInserted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserInserted.Enabled = False
        Me.UserInserted.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserInserted.FormattingEnabled = True
        Me.UserInserted.Location = New System.Drawing.Point(693, 117)
        Me.UserInserted.Name = "UserInserted"
        Me.UserInserted.Size = New System.Drawing.Size(203, 27)
        Me.UserInserted.TabIndex = 248
        '
        'Sales
        '
        Me.Sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sales.FormattingEnabled = True
        Me.Sales.Location = New System.Drawing.Point(693, 148)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(203, 27)
        Me.Sales.TabIndex = 249
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(569, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 26)
        Me.Label11.TabIndex = 250
        Me.Label11.Text = "Sales"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(569, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 26)
        Me.Label13.TabIndex = 251
        Me.Label13.Text = "User Inserted"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Installments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(908, 430)
        Me.Controls.Add(Me.UserInserted)
        Me.Controls.Add(Me.Sales)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.MyGetDate)
        Me.Controls.Add(Me.btnBundle)
        Me.Controls.Add(Me.lblStName)
        Me.Controls.Add(Me.btnInstallments)
        Me.Controls.Add(Me.btnRemaining)
        Me.Controls.Add(Me.btnStudentsMemberships)
        Me.Controls.Add(Me.btnIncome)
        Me.Controls.Add(Me.txtStId)
        Me.Controls.Add(Me.btnInvSearch)
        Me.Controls.Add(Me.RealInvoiceNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Haspayed)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PayedDate)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevios)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MainInvoiceNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.InvoiceNo)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "Installments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Installments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents Value As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrevios As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents MainInvoiceNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnStSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents InvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Haspayed As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PayedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents RealInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnInvSearch As System.Windows.Forms.Button
    Friend WithEvents txtStId As System.Windows.Forms.TextBox
    Friend WithEvents btnInstallments As System.Windows.Forms.Button
    Friend WithEvents btnRemaining As System.Windows.Forms.Button
    Friend WithEvents btnStudentsMemberships As System.Windows.Forms.Button
    Friend WithEvents btnIncome As System.Windows.Forms.Button
    Friend WithEvents lblStName As System.Windows.Forms.Label
    Friend WithEvents btnBundle As System.Windows.Forms.Button
    Friend WithEvents MyGetDate As System.Windows.Forms.TextBox
    Public WithEvents UserInserted As System.Windows.Forms.ComboBox
    Public WithEvents Sales As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
