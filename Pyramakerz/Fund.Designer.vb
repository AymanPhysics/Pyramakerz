<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fund
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
        Me.Value = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLastEntry = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Country = New System.Windows.Forms.ComboBox()
        Me.InvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Reason = New System.Windows.Forms.TextBox()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevios = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.ComboBox()
        Me.MyGetDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Value
        '
        Me.Value.BackColor = System.Drawing.SystemColors.Info
        Me.Value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Value.Location = New System.Drawing.Point(137, 139)
        Me.Value.MaxLength = 8
        Me.Value.Name = "Value"
        Me.Value.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Value.Size = New System.Drawing.Size(100, 26)
        Me.Value.TabIndex = 242
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(14, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 264
        Me.Label7.Text = "Value"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastEntry
        '
        Me.lblLastEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLastEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastEntry.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastEntry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLastEntry.Location = New System.Drawing.Point(572, 341)
        Me.lblLastEntry.Name = "lblLastEntry"
        Me.lblLastEntry.Size = New System.Drawing.Size(138, 26)
        Me.lblLastEntry.TabIndex = 263
        Me.lblLastEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(572, 309)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(138, 26)
        Me.Label21.TabIndex = 262
        Me.Label21.Text = "Last Entry"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DayDate
        '
        Me.DayDate.CustomFormat = "yyyy-MM-dd"
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(137, 107)
        Me.DayDate.Name = "DayDate"
        Me.DayDate.Size = New System.Drawing.Size(203, 26)
        Me.DayDate.TabIndex = 238
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(14, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 261
        Me.Label10.Text = "Day Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.SystemColors.Info
        Me.UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserName.ForeColor = System.Drawing.Color.Red
        Me.UserName.Location = New System.Drawing.Point(594, 14)
        Me.UserName.MaxLength = 15
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserName.Size = New System.Drawing.Size(117, 26)
        Me.UserName.TabIndex = 259
        Me.UserName.TabStop = False
        Me.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(471, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 26)
        Me.Label17.TabIndex = 260
        Me.Label17.Text = "UserName"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Country
        '
        Me.Country.BackColor = System.Drawing.SystemColors.Info
        Me.Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Country.Enabled = False
        Me.Country.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Country.ForeColor = System.Drawing.Color.Black
        Me.Country.FormattingEnabled = True
        Me.Country.Location = New System.Drawing.Point(139, 43)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(203, 27)
        Me.Country.TabIndex = 235
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InvoiceNo.Location = New System.Drawing.Point(139, 11)
        Me.InvoiceNo.MaxLength = 10
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.InvoiceNo.Size = New System.Drawing.Size(100, 26)
        Me.InvoiceNo.TabIndex = 234
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(14, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 90)
        Me.Label2.TabIndex = 254
        Me.Label2.Text = "Reason"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotes
        '
        Me.lblNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotes.Location = New System.Drawing.Point(13, 267)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(117, 26)
        Me.lblNotes.TabIndex = 253
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(15, 43)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(117, 26)
        Me.lblMain.TabIndex = 256
        Me.lblMain.Text = "Country"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "Invoice No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Reason
        '
        Me.Reason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Reason.Location = New System.Drawing.Point(138, 171)
        Me.Reason.MaxLength = 50
        Me.Reason.Multiline = True
        Me.Reason.Name = "Reason"
        Me.Reason.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Reason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Reason.Size = New System.Drawing.Size(573, 90)
        Me.Reason.TabIndex = 243
        '
        'Notes
        '
        Me.Notes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Notes.Location = New System.Drawing.Point(137, 267)
        Me.Notes.MaxLength = 100
        Me.Notes.Name = "Notes"
        Me.Notes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Notes.Size = New System.Drawing.Size(574, 26)
        Me.Notes.TabIndex = 244
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(262, 307)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 246
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(428, 309)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 248
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLast.Location = New System.Drawing.Point(428, 341)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 26)
        Me.btnLast.TabIndex = 252
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(345, 307)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 247
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevios
        '
        Me.btnPrevios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevios.ForeColor = System.Drawing.Color.Black
        Me.btnPrevios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrevios.Location = New System.Drawing.Point(262, 341)
        Me.btnPrevios.Name = "btnPrevios"
        Me.btnPrevios.Size = New System.Drawing.Size(77, 26)
        Me.btnPrevios.TabIndex = 250
        Me.btnPrevios.Text = "Previous"
        Me.btnPrevios.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFirst.Location = New System.Drawing.Point(179, 341)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 26)
        Me.btnFirst.TabIndex = 249
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(345, 341)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 26)
        Me.btnNext.TabIndex = 251
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(179, 307)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 245
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(15, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 26)
        Me.Label4.TabIndex = 256
        Me.Label4.Text = "City"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'City
        '
        Me.City.BackColor = System.Drawing.SystemColors.Info
        Me.City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.City.Enabled = False
        Me.City.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.City.ForeColor = System.Drawing.Color.Black
        Me.City.FormattingEnabled = True
        Me.City.Location = New System.Drawing.Point(139, 75)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(203, 27)
        Me.City.TabIndex = 235
        '
        'MyGetDate
        '
        Me.MyGetDate.BackColor = System.Drawing.SystemColors.Info
        Me.MyGetDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MyGetDate.ForeColor = System.Drawing.Color.Red
        Me.MyGetDate.Location = New System.Drawing.Point(471, 43)
        Me.MyGetDate.MaxLength = 15
        Me.MyGetDate.Name = "MyGetDate"
        Me.MyGetDate.ReadOnly = True
        Me.MyGetDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MyGetDate.Size = New System.Drawing.Size(240, 26)
        Me.MyGetDate.TabIndex = 265
        Me.MyGetDate.TabStop = False
        Me.MyGetDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(723, 377)
        Me.Controls.Add(Me.MyGetDate)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblLastEntry)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Country)
        Me.Controls.Add(Me.InvoiceNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Reason)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevios)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Fund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fund"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Value As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblLastEntry As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Country As System.Windows.Forms.ComboBox
    Friend WithEvents InvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Reason As System.Windows.Forms.TextBox
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrevios As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents City As System.Windows.Forms.ComboBox
    Friend WithEvents MyGetDate As System.Windows.Forms.TextBox
End Class
