<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory2
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
        Me.Cnt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevios = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FromBranch = New System.Windows.Forms.ComboBox()
        Me.InvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLastEntry = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DepartmentId = New System.Windows.Forms.ComboBox()
        Me.CategoryId = New System.Windows.Forms.ComboBox()
        Me.ItemId = New System.Windows.Forms.ComboBox()
        Me.lblItemId = New System.Windows.Forms.Label()
        Me.lblCategoryId = New System.Windows.Forms.Label()
        Me.lblDepartmentId = New System.Windows.Forms.Label()
        Me.MyGetDate = New System.Windows.Forms.TextBox()
        Me.ToBranch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DayDate
        '
        Me.DayDate.CustomFormat = "yyyy-MM-dd"
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(136, 104)
        Me.DayDate.Name = "DayDate"
        Me.DayDate.Size = New System.Drawing.Size(203, 26)
        Me.DayDate.TabIndex = 191
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(12, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 215
        Me.Label10.Text = "Day Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.SystemColors.Info
        Me.UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserName.ForeColor = System.Drawing.Color.Red
        Me.UserName.Location = New System.Drawing.Point(591, 9)
        Me.UserName.MaxLength = 15
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserName.Size = New System.Drawing.Size(117, 26)
        Me.UserName.TabIndex = 212
        Me.UserName.TabStop = False
        Me.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(468, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 26)
        Me.Label17.TabIndex = 214
        Me.Label17.Text = "UserName"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotes
        '
        Me.lblNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotes.Location = New System.Drawing.Point(12, 291)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(117, 26)
        Me.lblNotes.TabIndex = 211
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notes
        '
        Me.Notes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Notes.Location = New System.Drawing.Point(136, 291)
        Me.Notes.MaxLength = 100
        Me.Notes.Name = "Notes"
        Me.Notes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Notes.Size = New System.Drawing.Size(326, 26)
        Me.Notes.TabIndex = 195
        '
        'Cnt
        '
        Me.Cnt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cnt.Location = New System.Drawing.Point(136, 259)
        Me.Cnt.MaxLength = 8
        Me.Cnt.Name = "Cnt"
        Me.Cnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cnt.Size = New System.Drawing.Size(100, 26)
        Me.Cnt.TabIndex = 193
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 208
        Me.Label7.Text = "Count"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(264, 329)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 197
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(430, 329)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 199
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLast.Location = New System.Drawing.Point(430, 359)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 26)
        Me.btnLast.TabIndex = 203
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(347, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 198
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevios
        '
        Me.btnPrevios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevios.ForeColor = System.Drawing.Color.Black
        Me.btnPrevios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrevios.Location = New System.Drawing.Point(264, 359)
        Me.btnPrevios.Name = "btnPrevios"
        Me.btnPrevios.Size = New System.Drawing.Size(77, 26)
        Me.btnPrevios.TabIndex = 201
        Me.btnPrevios.Text = "Previous"
        Me.btnPrevios.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFirst.Location = New System.Drawing.Point(181, 359)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 26)
        Me.btnFirst.TabIndex = 200
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(347, 359)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 26)
        Me.btnNext.TabIndex = 202
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(181, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 196
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Type
        '
        Me.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"", "Books", "CDs", "InCome Inv.", "OutCome Inv."})
        Me.Type.Location = New System.Drawing.Point(136, 135)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(203, 27)
        Me.Type.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Type"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FromBranch
        '
        Me.FromBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FromBranch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromBranch.FormattingEnabled = True
        Me.FromBranch.Location = New System.Drawing.Point(136, 40)
        Me.FromBranch.Name = "FromBranch"
        Me.FromBranch.Size = New System.Drawing.Size(326, 27)
        Me.FromBranch.TabIndex = 187
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InvoiceNo.Location = New System.Drawing.Point(136, 9)
        Me.InvoiceNo.MaxLength = 10
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InvoiceNo.Size = New System.Drawing.Size(100, 26)
        Me.InvoiceNo.TabIndex = 186
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(12, 40)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(117, 26)
        Me.lblMain.TabIndex = 205
        Me.lblMain.Text = "From Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Invoice No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastEntry
        '
        Me.lblLastEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastEntry.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastEntry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLastEntry.Location = New System.Drawing.Point(570, 359)
        Me.lblLastEntry.Name = "lblLastEntry"
        Me.lblLastEntry.Size = New System.Drawing.Size(138, 26)
        Me.lblLastEntry.TabIndex = 240
        Me.lblLastEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(570, 327)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(138, 26)
        Me.Label21.TabIndex = 239
        Me.Label21.Text = "Last Entry"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DepartmentId
        '
        Me.DepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DepartmentId.FormattingEnabled = True
        Me.DepartmentId.Location = New System.Drawing.Point(136, 166)
        Me.DepartmentId.Name = "DepartmentId"
        Me.DepartmentId.Size = New System.Drawing.Size(203, 27)
        Me.DepartmentId.TabIndex = 241
        '
        'CategoryId
        '
        Me.CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CategoryId.FormattingEnabled = True
        Me.CategoryId.Location = New System.Drawing.Point(136, 197)
        Me.CategoryId.Name = "CategoryId"
        Me.CategoryId.Size = New System.Drawing.Size(203, 27)
        Me.CategoryId.TabIndex = 242
        '
        'ItemId
        '
        Me.ItemId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ItemId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ItemId.FormattingEnabled = True
        Me.ItemId.Location = New System.Drawing.Point(136, 228)
        Me.ItemId.Name = "ItemId"
        Me.ItemId.Size = New System.Drawing.Size(204, 27)
        Me.ItemId.TabIndex = 243
        '
        'lblItemId
        '
        Me.lblItemId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblItemId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblItemId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblItemId.Location = New System.Drawing.Point(12, 228)
        Me.lblItemId.Name = "lblItemId"
        Me.lblItemId.Size = New System.Drawing.Size(117, 26)
        Me.lblItemId.TabIndex = 245
        Me.lblItemId.Text = "Detail"
        Me.lblItemId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategoryId
        '
        Me.lblCategoryId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCategoryId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCategoryId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategoryId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCategoryId.Location = New System.Drawing.Point(12, 197)
        Me.lblCategoryId.Name = "lblCategoryId"
        Me.lblCategoryId.Size = New System.Drawing.Size(117, 26)
        Me.lblCategoryId.TabIndex = 244
        Me.lblCategoryId.Text = "Category"
        Me.lblCategoryId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartmentId
        '
        Me.lblDepartmentId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDepartmentId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartmentId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDepartmentId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepartmentId.Location = New System.Drawing.Point(12, 166)
        Me.lblDepartmentId.Name = "lblDepartmentId"
        Me.lblDepartmentId.Size = New System.Drawing.Size(117, 26)
        Me.lblDepartmentId.TabIndex = 246
        Me.lblDepartmentId.Text = "Department"
        Me.lblDepartmentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyGetDate
        '
        Me.MyGetDate.BackColor = System.Drawing.SystemColors.Info
        Me.MyGetDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MyGetDate.ForeColor = System.Drawing.Color.Red
        Me.MyGetDate.Location = New System.Drawing.Point(468, 41)
        Me.MyGetDate.MaxLength = 15
        Me.MyGetDate.Name = "MyGetDate"
        Me.MyGetDate.ReadOnly = True
        Me.MyGetDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MyGetDate.Size = New System.Drawing.Size(240, 26)
        Me.MyGetDate.TabIndex = 247
        Me.MyGetDate.TabStop = False
        Me.MyGetDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToBranch
        '
        Me.ToBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToBranch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToBranch.FormattingEnabled = True
        Me.ToBranch.Location = New System.Drawing.Point(136, 73)
        Me.ToBranch.Name = "ToBranch"
        Me.ToBranch.Size = New System.Drawing.Size(326, 27)
        Me.ToBranch.TabIndex = 248
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "To Branch"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Inventory2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(722, 391)
        Me.Controls.Add(Me.ToBranch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MyGetDate)
        Me.Controls.Add(Me.DepartmentId)
        Me.Controls.Add(Me.CategoryId)
        Me.Controls.Add(Me.ItemId)
        Me.Controls.Add(Me.lblItemId)
        Me.Controls.Add(Me.lblCategoryId)
        Me.Controls.Add(Me.lblDepartmentId)
        Me.Controls.Add(Me.lblLastEntry)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.Cnt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevios)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FromBranch)
        Me.Controls.Add(Me.InvoiceNo)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inventory2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents Cnt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrevios As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents FromBranch As System.Windows.Forms.ComboBox
    Friend WithEvents InvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastEntry As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents DepartmentId As System.Windows.Forms.ComboBox
    Public WithEvents CategoryId As System.Windows.Forms.ComboBox
    Public WithEvents ItemId As System.Windows.Forms.ComboBox
    Friend WithEvents lblItemId As System.Windows.Forms.Label
    Friend WithEvents lblCategoryId As System.Windows.Forms.Label
    Friend WithEvents lblDepartmentId As System.Windows.Forms.Label
    Friend WithEvents MyGetDate As System.Windows.Forms.TextBox
    Public WithEvents ToBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
