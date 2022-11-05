<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Income
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
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.InvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevios = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnStSearch = New System.Windows.Forms.Button()
        Me.DepartmentId = New System.Windows.Forms.ComboBox()
        Me.CategoryId = New System.Windows.Forms.ComboBox()
        Me.ItemId = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Value = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Payed = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Remaining = New System.Windows.Forms.TextBox()
        Me.SpitialOffer = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OfferValue = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGenerateInstallment = New System.Windows.Forms.Button()
        Me.RealInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAfterMembershipDiscount = New System.Windows.Forms.Label()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        Me.lblLastEntry = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DiscountPerc = New System.Windows.Forms.CheckBox()
        Me.txtStId = New System.Windows.Forms.TextBox()
        Me.Refundable = New System.Windows.Forms.TextBox()
        Me.Canceld = New System.Windows.Forms.CheckBox()
        Me.btnIncome = New System.Windows.Forms.Button()
        Me.btnStudentsMemberships = New System.Windows.Forms.Button()
        Me.btnRemaining = New System.Windows.Forms.Button()
        Me.btnInstallments = New System.Windows.Forms.Button()
        Me.lblStName = New System.Windows.Forms.Label()
        Me.btnBundle = New System.Windows.Forms.Button()
        Me.ReLecture = New System.Windows.Forms.CheckBox()
        Me.btnInvSearch = New System.Windows.Forms.Button()
        Me.IsPrivate = New System.Windows.Forms.CheckBox()
        Me.MyGetDate = New System.Windows.Forms.TextBox()
        Me.UserInserted = New System.Windows.Forms.ComboBox()
        Me.Sales = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Branch
        '
        Me.Branch.BackColor = System.Drawing.SystemColors.Info
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Enabled = False
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.ForeColor = System.Drawing.Color.Black
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(314, 43)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(326, 27)
        Me.Branch.TabIndex = 1
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InvoiceNo.Location = New System.Drawing.Point(314, 12)
        Me.InvoiceNo.MaxLength = 10
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InvoiceNo.Size = New System.Drawing.Size(100, 26)
        Me.InvoiceNo.TabIndex = 0
        '
        'lblNotes
        '
        Me.lblNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotes.Location = New System.Drawing.Point(420, 260)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(117, 26)
        Me.lblNotes.TabIndex = 57
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(190, 43)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(117, 26)
        Me.lblMain.TabIndex = 59
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(190, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Invoice No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notes
        '
        Me.Notes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Notes.Location = New System.Drawing.Point(544, 260)
        Me.Notes.MaxLength = 100
        Me.Notes.Name = "Notes"
        Me.Notes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Notes.Size = New System.Drawing.Size(326, 26)
        Me.Notes.TabIndex = 13
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(420, 363)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(586, 365)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLast.Location = New System.Drawing.Point(586, 397)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 26)
        Me.btnLast.TabIndex = 23
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(503, 363)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevios
        '
        Me.btnPrevios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevios.ForeColor = System.Drawing.Color.Black
        Me.btnPrevios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrevios.Location = New System.Drawing.Point(420, 397)
        Me.btnPrevios.Name = "btnPrevios"
        Me.btnPrevios.Size = New System.Drawing.Size(77, 26)
        Me.btnPrevios.TabIndex = 21
        Me.btnPrevios.Text = "Previous"
        Me.btnPrevios.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFirst.Location = New System.Drawing.Point(337, 397)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 26)
        Me.btnFirst.TabIndex = 20
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(503, 397)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 26)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(337, 363)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(190, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Student"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStSearch
        '
        Me.btnStSearch.Location = New System.Drawing.Point(592, 74)
        Me.btnStSearch.Name = "btnStSearch"
        Me.btnStSearch.Size = New System.Drawing.Size(30, 27)
        Me.btnStSearch.TabIndex = 4
        Me.btnStSearch.TabStop = False
        Me.btnStSearch.Text = "..."
        Me.btnStSearch.UseVisualStyleBackColor = True
        '
        'DepartmentId
        '
        Me.DepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DepartmentId.FormattingEnabled = True
        Me.DepartmentId.Location = New System.Drawing.Point(314, 136)
        Me.DepartmentId.Name = "DepartmentId"
        Me.DepartmentId.Size = New System.Drawing.Size(203, 27)
        Me.DepartmentId.TabIndex = 6
        '
        'CategoryId
        '
        Me.CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CategoryId.FormattingEnabled = True
        Me.CategoryId.Location = New System.Drawing.Point(314, 167)
        Me.CategoryId.Name = "CategoryId"
        Me.CategoryId.Size = New System.Drawing.Size(203, 27)
        Me.CategoryId.TabIndex = 7
        '
        'ItemId
        '
        Me.ItemId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ItemId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ItemId.FormattingEnabled = True
        Me.ItemId.Location = New System.Drawing.Point(314, 198)
        Me.ItemId.Name = "ItemId"
        Me.ItemId.Size = New System.Drawing.Size(204, 27)
        Me.ItemId.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(190, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 26)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Detail"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(190, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Category"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(190, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Department"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(190, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 26)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Value
        '
        Me.Value.BackColor = System.Drawing.SystemColors.Info
        Me.Value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Value.Location = New System.Drawing.Point(314, 229)
        Me.Value.MaxLength = 8
        Me.Value.Name = "Value"
        Me.Value.ReadOnly = True
        Me.Value.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Value.Size = New System.Drawing.Size(100, 26)
        Me.Value.TabIndex = 10
        Me.Value.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(190, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Payed"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Payed
        '
        Me.Payed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Payed.Location = New System.Drawing.Point(314, 292)
        Me.Payed.MaxLength = 8
        Me.Payed.Name = "Payed"
        Me.Payed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Payed.Size = New System.Drawing.Size(100, 26)
        Me.Payed.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(190, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 26)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Remaining"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Remaining
        '
        Me.Remaining.BackColor = System.Drawing.SystemColors.Info
        Me.Remaining.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Remaining.Location = New System.Drawing.Point(314, 325)
        Me.Remaining.MaxLength = 8
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        Me.Remaining.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Remaining.Size = New System.Drawing.Size(100, 26)
        Me.Remaining.TabIndex = 15
        Me.Remaining.TabStop = False
        '
        'SpitialOffer
        '
        Me.SpitialOffer.AutoSize = True
        Me.SpitialOffer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SpitialOffer.Location = New System.Drawing.Point(298, 267)
        Me.SpitialOffer.Name = "SpitialOffer"
        Me.SpitialOffer.Size = New System.Drawing.Size(15, 14)
        Me.SpitialOffer.TabIndex = 11
        Me.SpitialOffer.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(190, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 26)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Spietial Offer"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OfferValue
        '
        Me.OfferValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.OfferValue.Location = New System.Drawing.Point(314, 260)
        Me.OfferValue.MaxLength = 8
        Me.OfferValue.Name = "OfferValue"
        Me.OfferValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OfferValue.Size = New System.Drawing.Size(100, 26)
        Me.OfferValue.TabIndex = 12
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.SystemColors.Info
        Me.UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserName.ForeColor = System.Drawing.Color.Red
        Me.UserName.Location = New System.Drawing.Point(769, 13)
        Me.UserName.MaxLength = 15
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserName.Size = New System.Drawing.Size(117, 26)
        Me.UserName.TabIndex = 101
        Me.UserName.TabStop = False
        Me.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(646, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 26)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "UserName"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DayDate
        '
        Me.DayDate.CustomFormat = "yyyy-MM-dd"
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(313, 105)
        Me.DayDate.Name = "DayDate"
        Me.DayDate.Size = New System.Drawing.Size(203, 26)
        Me.DayDate.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(190, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Day Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerateInstallment
        '
        Me.btnGenerateInstallment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateInstallment.Location = New System.Drawing.Point(420, 325)
        Me.btnGenerateInstallment.Name = "btnGenerateInstallment"
        Me.btnGenerateInstallment.Size = New System.Drawing.Size(166, 26)
        Me.btnGenerateInstallment.TabIndex = 15
        Me.btnGenerateInstallment.TabStop = False
        Me.btnGenerateInstallment.Text = "Generate Installments"
        Me.btnGenerateInstallment.UseVisualStyleBackColor = True
        '
        'RealInvoiceNo
        '
        Me.RealInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RealInvoiceNo.Location = New System.Drawing.Point(769, 74)
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
        Me.Label2.Location = New System.Drawing.Point(646, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Real Inv. No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAfterMembershipDiscount
        '
        Me.lblAfterMembershipDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAfterMembershipDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAfterMembershipDiscount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAfterMembershipDiscount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAfterMembershipDiscount.Location = New System.Drawing.Point(420, 229)
        Me.lblAfterMembershipDiscount.Name = "lblAfterMembershipDiscount"
        Me.lblAfterMembershipDiscount.Size = New System.Drawing.Size(220, 26)
        Me.lblAfterMembershipDiscount.TabIndex = 58
        Me.lblAfterMembershipDiscount.Text = "After Membership Discount"
        Me.lblAfterMembershipDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAfterMembershipDiscount.Visible = False
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(847, 111)
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(35, 20)
        Me.txtFlag.TabIndex = 111
        Me.txtFlag.Visible = False
        '
        'lblLastEntry
        '
        Me.lblLastEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastEntry.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastEntry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLastEntry.Location = New System.Drawing.Point(748, 395)
        Me.lblLastEntry.Name = "lblLastEntry"
        Me.lblLastEntry.Size = New System.Drawing.Size(138, 26)
        Me.lblLastEntry.TabIndex = 113
        Me.lblLastEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(748, 363)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(138, 26)
        Me.Label21.TabIndex = 112
        Me.Label21.Text = "Last Entry"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DiscountPerc
        '
        Me.DiscountPerc.AutoSize = True
        Me.DiscountPerc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DiscountPerc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DiscountPerc.Location = New System.Drawing.Point(769, 139)
        Me.DiscountPerc.Name = "DiscountPerc"
        Me.DiscountPerc.Size = New System.Drawing.Size(117, 23)
        Me.DiscountPerc.TabIndex = 10
        Me.DiscountPerc.Text = "DiscountPerc"
        Me.DiscountPerc.UseVisualStyleBackColor = False
        Me.DiscountPerc.Visible = False
        '
        'txtStId
        '
        Me.txtStId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStId.Location = New System.Drawing.Point(313, 74)
        Me.txtStId.MaxLength = 6
        Me.txtStId.Name = "txtStId"
        Me.txtStId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStId.Size = New System.Drawing.Size(64, 26)
        Me.txtStId.TabIndex = 3
        '
        'Refundable
        '
        Me.Refundable.Location = New System.Drawing.Point(806, 111)
        Me.Refundable.Name = "Refundable"
        Me.Refundable.Size = New System.Drawing.Size(35, 20)
        Me.Refundable.TabIndex = 111
        Me.Refundable.Visible = False
        '
        'Canceld
        '
        Me.Canceld.AutoSize = True
        Me.Canceld.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Canceld.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Canceld.Location = New System.Drawing.Point(566, 15)
        Me.Canceld.Name = "Canceld"
        Me.Canceld.Size = New System.Drawing.Size(74, 23)
        Me.Canceld.TabIndex = 158
        Me.Canceld.Text = "Cancel"
        Me.Canceld.UseVisualStyleBackColor = False
        '
        'btnIncome
        '
        Me.btnIncome.BackColor = System.Drawing.Color.SteelBlue
        Me.btnIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncome.Location = New System.Drawing.Point(12, 12)
        Me.btnIncome.Name = "btnIncome"
        Me.btnIncome.Size = New System.Drawing.Size(154, 78)
        Me.btnIncome.TabIndex = 159
        Me.btnIncome.Text = "Detail"
        Me.btnIncome.UseVisualStyleBackColor = False
        '
        'btnStudentsMemberships
        '
        Me.btnStudentsMemberships.BackColor = System.Drawing.Color.Gold
        Me.btnStudentsMemberships.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentsMemberships.Location = New System.Drawing.Point(12, 92)
        Me.btnStudentsMemberships.Name = "btnStudentsMemberships"
        Me.btnStudentsMemberships.Size = New System.Drawing.Size(154, 78)
        Me.btnStudentsMemberships.TabIndex = 159
        Me.btnStudentsMemberships.Text = "Memberships"
        Me.btnStudentsMemberships.UseVisualStyleBackColor = False
        '
        'btnRemaining
        '
        Me.btnRemaining.BackColor = System.Drawing.Color.Gold
        Me.btnRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemaining.Location = New System.Drawing.Point(12, 252)
        Me.btnRemaining.Name = "btnRemaining"
        Me.btnRemaining.Size = New System.Drawing.Size(154, 78)
        Me.btnRemaining.TabIndex = 159
        Me.btnRemaining.Text = "Remaining"
        Me.btnRemaining.UseVisualStyleBackColor = False
        '
        'btnInstallments
        '
        Me.btnInstallments.BackColor = System.Drawing.Color.Gold
        Me.btnInstallments.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstallments.Location = New System.Drawing.Point(12, 332)
        Me.btnInstallments.Name = "btnInstallments"
        Me.btnInstallments.Size = New System.Drawing.Size(154, 78)
        Me.btnInstallments.TabIndex = 159
        Me.btnInstallments.Text = "Installments"
        Me.btnInstallments.UseVisualStyleBackColor = False
        '
        'lblStName
        '
        Me.lblStName.BackColor = System.Drawing.SystemColors.Info
        Me.lblStName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStName.Location = New System.Drawing.Point(382, 75)
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
        Me.btnBundle.TabIndex = 235
        Me.btnBundle.Text = "Bundle"
        Me.btnBundle.UseVisualStyleBackColor = False
        '
        'ReLecture
        '
        Me.ReLecture.AutoSize = True
        Me.ReLecture.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReLecture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ReLecture.Location = New System.Drawing.Point(524, 200)
        Me.ReLecture.Name = "ReLecture"
        Me.ReLecture.Size = New System.Drawing.Size(100, 23)
        Me.ReLecture.TabIndex = 9
        Me.ReLecture.Text = "ReLecture"
        Me.ReLecture.UseVisualStyleBackColor = False
        '
        'btnInvSearch
        '
        Me.btnInvSearch.Location = New System.Drawing.Point(420, 12)
        Me.btnInvSearch.Name = "btnInvSearch"
        Me.btnInvSearch.Size = New System.Drawing.Size(30, 27)
        Me.btnInvSearch.TabIndex = 236
        Me.btnInvSearch.TabStop = False
        Me.btnInvSearch.Text = "..."
        Me.btnInvSearch.UseVisualStyleBackColor = True
        '
        'IsPrivate
        '
        Me.IsPrivate.AutoSize = True
        Me.IsPrivate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IsPrivate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IsPrivate.Location = New System.Drawing.Point(630, 200)
        Me.IsPrivate.Name = "IsPrivate"
        Me.IsPrivate.Size = New System.Drawing.Size(76, 23)
        Me.IsPrivate.TabIndex = 9
        Me.IsPrivate.Text = "Private"
        Me.IsPrivate.UseVisualStyleBackColor = False
        '
        'MyGetDate
        '
        Me.MyGetDate.BackColor = System.Drawing.SystemColors.Info
        Me.MyGetDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MyGetDate.ForeColor = System.Drawing.Color.Red
        Me.MyGetDate.Location = New System.Drawing.Point(646, 43)
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
        Me.UserInserted.Location = New System.Drawing.Point(647, 136)
        Me.UserInserted.Name = "UserInserted"
        Me.UserInserted.Size = New System.Drawing.Size(203, 27)
        Me.UserInserted.TabIndex = 244
        '
        'Sales
        '
        Me.Sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sales.FormattingEnabled = True
        Me.Sales.Location = New System.Drawing.Point(647, 167)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(203, 27)
        Me.Sales.TabIndex = 245
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(523, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 26)
        Me.Label11.TabIndex = 246
        Me.Label11.Text = "Sales"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(523, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 26)
        Me.Label13.TabIndex = 247
        Me.Label13.Text = "User Inserted"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Income
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
        Me.Controls.Add(Me.btnInvSearch)
        Me.Controls.Add(Me.btnBundle)
        Me.Controls.Add(Me.lblStName)
        Me.Controls.Add(Me.btnInstallments)
        Me.Controls.Add(Me.btnRemaining)
        Me.Controls.Add(Me.btnStudentsMemberships)
        Me.Controls.Add(Me.btnIncome)
        Me.Controls.Add(Me.Canceld)
        Me.Controls.Add(Me.txtStId)
        Me.Controls.Add(Me.lblLastEntry)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Refundable)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.RealInvoiceNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerateInstallment)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.IsPrivate)
        Me.Controls.Add(Me.ReLecture)
        Me.Controls.Add(Me.DiscountPerc)
        Me.Controls.Add(Me.SpitialOffer)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DepartmentId)
        Me.Controls.Add(Me.CategoryId)
        Me.Controls.Add(Me.ItemId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.Remaining)
        Me.Controls.Add(Me.OfferValue)
        Me.Controls.Add(Me.Payed)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.InvoiceNo)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblAfterMembershipDiscount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevios)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.KeyPreview = True
        Me.Name = "Income"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents InvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrevios As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnStSearch As System.Windows.Forms.Button
    Public WithEvents DepartmentId As System.Windows.Forms.ComboBox
    Public WithEvents CategoryId As System.Windows.Forms.ComboBox
    Public WithEvents ItemId As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Value As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Payed As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Remaining As System.Windows.Forms.TextBox
    Friend WithEvents SpitialOffer As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents OfferValue As System.Windows.Forms.TextBox
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnGenerateInstallment As System.Windows.Forms.Button
    Friend WithEvents RealInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAfterMembershipDiscount As System.Windows.Forms.Label
    Friend WithEvents txtFlag As System.Windows.Forms.TextBox
    Friend WithEvents lblLastEntry As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DiscountPerc As System.Windows.Forms.CheckBox
    Friend WithEvents txtStId As System.Windows.Forms.TextBox
    Friend WithEvents Refundable As System.Windows.Forms.TextBox
    Friend WithEvents Canceld As System.Windows.Forms.CheckBox
    Friend WithEvents btnIncome As System.Windows.Forms.Button
    Friend WithEvents btnStudentsMemberships As System.Windows.Forms.Button
    Friend WithEvents btnRemaining As System.Windows.Forms.Button
    Friend WithEvents btnInstallments As System.Windows.Forms.Button
    Friend WithEvents lblStName As System.Windows.Forms.Label
    Friend WithEvents btnBundle As System.Windows.Forms.Button
    Friend WithEvents ReLecture As System.Windows.Forms.CheckBox
    Friend WithEvents btnInvSearch As System.Windows.Forms.Button
    Friend WithEvents IsPrivate As System.Windows.Forms.CheckBox
    Friend WithEvents MyGetDate As System.Windows.Forms.TextBox
    Public WithEvents UserInserted As System.Windows.Forms.ComboBox
    Public WithEvents Sales As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
