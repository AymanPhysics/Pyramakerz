<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsMemberships
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
        Me.RealInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerateInstallment = New System.Windows.Forms.Button()
        Me.DayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Membership = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnStSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.Remaining = New System.Windows.Forms.TextBox()
        Me.Discount = New System.Windows.Forms.TextBox()
        Me.Payed = New System.Windows.Forms.TextBox()
        Me.Value = New System.Windows.Forms.TextBox()
        Me.InvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.Hold = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NoOfDays = New System.Windows.Forms.TextBox()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        Me.lblLastEntry = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnInvSearch = New System.Windows.Forms.Button()
        Me.txtStId = New System.Windows.Forms.TextBox()
        Me.Refundable = New System.Windows.Forms.TextBox()
        Me.Canceld = New System.Windows.Forms.CheckBox()
        Me.btnInstallments = New System.Windows.Forms.Button()
        Me.btnRemaining = New System.Windows.Forms.Button()
        Me.btnStudentsMemberships = New System.Windows.Forms.Button()
        Me.btnIncome = New System.Windows.Forms.Button()
        Me.lblStName = New System.Windows.Forms.Label()
        Me.btnBundle = New System.Windows.Forms.Button()
        Me.SpitialOffer = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OfferValue = New System.Windows.Forms.TextBox()
        Me.MyGetDate = New System.Windows.Forms.TextBox()
        Me.UserInserted = New System.Windows.Forms.ComboBox()
        Me.Sales = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RealInvoiceNo
        '
        Me.RealInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RealInvoiceNo.Location = New System.Drawing.Point(782, 73)
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
        Me.Label2.Location = New System.Drawing.Point(659, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Real Inv. No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerateInstallment
        '
        Me.btnGenerateInstallment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateInstallment.Location = New System.Drawing.Point(405, 263)
        Me.btnGenerateInstallment.Name = "btnGenerateInstallment"
        Me.btnGenerateInstallment.Size = New System.Drawing.Size(166, 26)
        Me.btnGenerateInstallment.TabIndex = 13
        Me.btnGenerateInstallment.Text = "Generate Installments"
        Me.btnGenerateInstallment.UseVisualStyleBackColor = True
        '
        'DayDate
        '
        Me.DayDate.CustomFormat = "yyyy-MM-dd"
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(298, 104)
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
        Me.Label10.Location = New System.Drawing.Point(175, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Day Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.SystemColors.Info
        Me.UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserName.ForeColor = System.Drawing.Color.Red
        Me.UserName.Location = New System.Drawing.Point(784, 12)
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
        Me.Label17.Location = New System.Drawing.Point(661, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 26)
        Me.Label17.TabIndex = 148
        Me.Label17.Text = "UserName"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(509, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 26)
        Me.Label12.TabIndex = 146
        Me.Label12.Text = "Discount"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Membership
        '
        Me.Membership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Membership.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Membership.FormattingEnabled = True
        Me.Membership.Location = New System.Drawing.Point(299, 135)
        Me.Membership.Name = "Membership"
        Me.Membership.Size = New System.Drawing.Size(204, 27)
        Me.Membership.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(175, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 26)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Membership"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStSearch
        '
        Me.btnStSearch.Location = New System.Drawing.Point(577, 73)
        Me.btnStSearch.Name = "btnStSearch"
        Me.btnStSearch.Size = New System.Drawing.Size(30, 27)
        Me.btnStSearch.TabIndex = 5
        Me.btnStSearch.TabStop = False
        Me.btnStSearch.Text = "..."
        Me.btnStSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(175, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Student"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Branch
        '
        Me.Branch.BackColor = System.Drawing.SystemColors.Info
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Enabled = False
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.ForeColor = System.Drawing.Color.Black
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(299, 42)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(326, 27)
        Me.Branch.TabIndex = 1
        '
        'Remaining
        '
        Me.Remaining.BackColor = System.Drawing.SystemColors.Info
        Me.Remaining.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Remaining.Location = New System.Drawing.Point(299, 263)
        Me.Remaining.MaxLength = 8
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        Me.Remaining.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Remaining.Size = New System.Drawing.Size(100, 26)
        Me.Remaining.TabIndex = 12
        Me.Remaining.TabStop = False
        '
        'Discount
        '
        Me.Discount.BackColor = System.Drawing.SystemColors.Info
        Me.Discount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Discount.Location = New System.Drawing.Point(633, 166)
        Me.Discount.MaxLength = 8
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        Me.Discount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Discount.Size = New System.Drawing.Size(100, 26)
        Me.Discount.TabIndex = 8
        '
        'Payed
        '
        Me.Payed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Payed.Location = New System.Drawing.Point(299, 230)
        Me.Payed.MaxLength = 8
        Me.Payed.Name = "Payed"
        Me.Payed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Payed.Size = New System.Drawing.Size(100, 26)
        Me.Payed.TabIndex = 11
        '
        'Value
        '
        Me.Value.BackColor = System.Drawing.SystemColors.Info
        Me.Value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Value.Location = New System.Drawing.Point(299, 166)
        Me.Value.MaxLength = 8
        Me.Value.Name = "Value"
        Me.Value.ReadOnly = True
        Me.Value.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Value.Size = New System.Drawing.Size(100, 26)
        Me.Value.TabIndex = 7
        Me.Value.TabStop = False
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InvoiceNo.Location = New System.Drawing.Point(299, 11)
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
        Me.lblNotes.Location = New System.Drawing.Point(407, 198)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(117, 26)
        Me.lblNotes.TabIndex = 135
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(175, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 26)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "Remaining"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(175, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "Payed"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(175, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 26)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(175, 42)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(117, 26)
        Me.lblMain.TabIndex = 141
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(175, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Invoice No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notes
        '
        Me.Notes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Notes.Location = New System.Drawing.Point(531, 198)
        Me.Notes.MaxLength = 100
        Me.Notes.Name = "Notes"
        Me.Notes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Notes.Size = New System.Drawing.Size(370, 26)
        Me.Notes.TabIndex = 10
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(454, 362)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 18
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(620, 362)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLast.Location = New System.Drawing.Point(620, 396)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 26)
        Me.btnLast.TabIndex = 24
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(537, 362)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevios
        '
        Me.btnPrevios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevios.ForeColor = System.Drawing.Color.Black
        Me.btnPrevios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrevios.Location = New System.Drawing.Point(454, 396)
        Me.btnPrevios.Name = "btnPrevios"
        Me.btnPrevios.Size = New System.Drawing.Size(77, 26)
        Me.btnPrevios.TabIndex = 22
        Me.btnPrevios.Text = "Previous"
        Me.btnPrevios.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFirst.Location = New System.Drawing.Point(371, 396)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 26)
        Me.btnFirst.TabIndex = 21
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(537, 396)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 26)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(371, 362)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblStartDate
        '
        Me.lblStartDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStartDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartDate.Location = New System.Drawing.Point(175, 327)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(117, 26)
        Me.lblStartDate.TabIndex = 149
        Me.lblStartDate.Text = "Start Date"
        Me.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartDate
        '
        Me.StartDate.CustomFormat = "yyyy-MM-dd"
        Me.StartDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDate.Location = New System.Drawing.Point(298, 327)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(203, 26)
        Me.StartDate.TabIndex = 15
        '
        'lblEndDate
        '
        Me.lblEndDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEndDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEndDate.Location = New System.Drawing.Point(507, 327)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(117, 26)
        Me.lblEndDate.TabIndex = 149
        Me.lblEndDate.Text = "End Date"
        Me.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndDate
        '
        Me.EndDate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.EndDate.CustomFormat = "yyyy-MM-dd"
        Me.EndDate.Enabled = False
        Me.EndDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDate.Location = New System.Drawing.Point(630, 327)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(203, 26)
        Me.EndDate.TabIndex = 16
        '
        'Hold
        '
        Me.Hold.AutoSize = True
        Me.Hold.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Hold.Location = New System.Drawing.Point(283, 301)
        Me.Hold.Name = "Hold"
        Me.Hold.Size = New System.Drawing.Size(15, 14)
        Me.Hold.TabIndex = 14
        Me.Hold.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(175, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 26)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "Hold"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(509, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "No Of Days"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NoOfDays
        '
        Me.NoOfDays.BackColor = System.Drawing.SystemColors.Info
        Me.NoOfDays.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NoOfDays.Location = New System.Drawing.Point(633, 135)
        Me.NoOfDays.MaxLength = 8
        Me.NoOfDays.Name = "NoOfDays"
        Me.NoOfDays.ReadOnly = True
        Me.NoOfDays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NoOfDays.Size = New System.Drawing.Size(100, 26)
        Me.NoOfDays.TabIndex = 8
        Me.NoOfDays.TabStop = False
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(846, 104)
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(49, 20)
        Me.txtFlag.TabIndex = 153
        Me.txtFlag.Visible = False
        '
        'lblLastEntry
        '
        Me.lblLastEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastEntry.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastEntry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLastEntry.Location = New System.Drawing.Point(761, 394)
        Me.lblLastEntry.Name = "lblLastEntry"
        Me.lblLastEntry.Size = New System.Drawing.Size(138, 26)
        Me.lblLastEntry.TabIndex = 155
        Me.lblLastEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(761, 362)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(138, 26)
        Me.Label21.TabIndex = 154
        Me.Label21.Text = "Last Entry"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInvSearch
        '
        Me.btnInvSearch.Location = New System.Drawing.Point(405, 11)
        Me.btnInvSearch.Name = "btnInvSearch"
        Me.btnInvSearch.Size = New System.Drawing.Size(30, 27)
        Me.btnInvSearch.TabIndex = 5
        Me.btnInvSearch.TabStop = False
        Me.btnInvSearch.Text = "..."
        Me.btnInvSearch.UseVisualStyleBackColor = True
        '
        'txtStId
        '
        Me.txtStId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStId.ForeColor = System.Drawing.Color.Black
        Me.txtStId.Location = New System.Drawing.Point(298, 73)
        Me.txtStId.MaxLength = 6
        Me.txtStId.Name = "txtStId"
        Me.txtStId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStId.Size = New System.Drawing.Size(64, 26)
        Me.txtStId.TabIndex = 3
        '
        'Refundable
        '
        Me.Refundable.Location = New System.Drawing.Point(805, 104)
        Me.Refundable.Name = "Refundable"
        Me.Refundable.Size = New System.Drawing.Size(35, 20)
        Me.Refundable.TabIndex = 156
        Me.Refundable.Visible = False
        '
        'Canceld
        '
        Me.Canceld.AutoSize = True
        Me.Canceld.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Canceld.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Canceld.Location = New System.Drawing.Point(551, 14)
        Me.Canceld.Name = "Canceld"
        Me.Canceld.Size = New System.Drawing.Size(74, 23)
        Me.Canceld.TabIndex = 157
        Me.Canceld.Text = "Cancel"
        Me.Canceld.UseVisualStyleBackColor = False
        '
        'btnInstallments
        '
        Me.btnInstallments.BackColor = System.Drawing.Color.Gold
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
        Me.btnStudentsMemberships.BackColor = System.Drawing.Color.SteelBlue
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
        Me.lblStName.Location = New System.Drawing.Point(366, 74)
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
        'SpitialOffer
        '
        Me.SpitialOffer.AutoSize = True
        Me.SpitialOffer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SpitialOffer.Location = New System.Drawing.Point(283, 204)
        Me.SpitialOffer.Name = "SpitialOffer"
        Me.SpitialOffer.Size = New System.Drawing.Size(15, 14)
        Me.SpitialOffer.TabIndex = 8
        Me.SpitialOffer.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(175, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 239
        Me.Label6.Text = "Spietial Offer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OfferValue
        '
        Me.OfferValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.OfferValue.Location = New System.Drawing.Point(299, 198)
        Me.OfferValue.MaxLength = 8
        Me.OfferValue.Name = "OfferValue"
        Me.OfferValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OfferValue.Size = New System.Drawing.Size(100, 26)
        Me.OfferValue.TabIndex = 9
        '
        'MyGetDate
        '
        Me.MyGetDate.BackColor = System.Drawing.SystemColors.Info
        Me.MyGetDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MyGetDate.ForeColor = System.Drawing.Color.Red
        Me.MyGetDate.Location = New System.Drawing.Point(661, 42)
        Me.MyGetDate.MaxLength = 15
        Me.MyGetDate.Name = "MyGetDate"
        Me.MyGetDate.ReadOnly = True
        Me.MyGetDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MyGetDate.Size = New System.Drawing.Size(240, 26)
        Me.MyGetDate.TabIndex = 244
        Me.MyGetDate.TabStop = False
        Me.MyGetDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserInserted
        '
        Me.UserInserted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserInserted.Enabled = False
        Me.UserInserted.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserInserted.FormattingEnabled = True
        Me.UserInserted.Location = New System.Drawing.Point(698, 230)
        Me.UserInserted.Name = "UserInserted"
        Me.UserInserted.Size = New System.Drawing.Size(203, 27)
        Me.UserInserted.TabIndex = 248
        '
        'Sales
        '
        Me.Sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sales.FormattingEnabled = True
        Me.Sales.Location = New System.Drawing.Point(698, 261)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(203, 27)
        Me.Sales.TabIndex = 249
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(574, 261)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 26)
        Me.Label13.TabIndex = 250
        Me.Label13.Text = "Sales"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(574, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 26)
        Me.Label14.TabIndex = 251
        Me.Label14.Text = "User Inserted"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentsMemberships
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(908, 430)
        Me.Controls.Add(Me.UserInserted)
        Me.Controls.Add(Me.Sales)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.MyGetDate)
        Me.Controls.Add(Me.SpitialOffer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.OfferValue)
        Me.Controls.Add(Me.btnBundle)
        Me.Controls.Add(Me.lblStName)
        Me.Controls.Add(Me.btnInstallments)
        Me.Controls.Add(Me.btnRemaining)
        Me.Controls.Add(Me.btnStudentsMemberships)
        Me.Controls.Add(Me.btnIncome)
        Me.Controls.Add(Me.Canceld)
        Me.Controls.Add(Me.Refundable)
        Me.Controls.Add(Me.txtStId)
        Me.Controls.Add(Me.lblLastEntry)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.Hold)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RealInvoiceNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerateInstallment)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Membership)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnInvSearch)
        Me.Controls.Add(Me.btnStSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.Remaining)
        Me.Controls.Add(Me.Discount)
        Me.Controls.Add(Me.Payed)
        Me.Controls.Add(Me.NoOfDays)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.InvoiceNo)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
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
        Me.Name = "StudentsMemberships"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentsMemberships"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RealInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerateInstallment As System.Windows.Forms.Button
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Membership As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnStSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents Remaining As System.Windows.Forms.TextBox
    Friend WithEvents Discount As System.Windows.Forms.TextBox
    Friend WithEvents Payed As System.Windows.Forms.TextBox
    Friend WithEvents Value As System.Windows.Forms.TextBox
    Friend WithEvents InvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Hold As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NoOfDays As System.Windows.Forms.TextBox
    Friend WithEvents txtFlag As System.Windows.Forms.TextBox
    Friend WithEvents lblLastEntry As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnInvSearch As System.Windows.Forms.Button
    Friend WithEvents txtStId As System.Windows.Forms.TextBox
    Friend WithEvents Refundable As System.Windows.Forms.TextBox
    Friend WithEvents Canceld As System.Windows.Forms.CheckBox
    Friend WithEvents btnInstallments As System.Windows.Forms.Button
    Friend WithEvents btnRemaining As System.Windows.Forms.Button
    Friend WithEvents btnStudentsMemberships As System.Windows.Forms.Button
    Friend WithEvents btnIncome As System.Windows.Forms.Button
    Friend WithEvents lblStName As System.Windows.Forms.Label
    Friend WithEvents btnBundle As System.Windows.Forms.Button
    Friend WithEvents SpitialOffer As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OfferValue As System.Windows.Forms.TextBox
    Friend WithEvents MyGetDate As System.Windows.Forms.TextBox
    Public WithEvents UserInserted As System.Windows.Forms.ComboBox
    Public WithEvents Sales As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
