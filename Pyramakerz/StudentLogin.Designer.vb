<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentLogin
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
        Me.lblStName = New System.Windows.Forms.Label()
        Me.Delayed = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DelayUntil = New System.Windows.Forms.DateTimePicker()
        Me.Shift4 = New System.Windows.Forms.CheckBox()
        Me.Shift3 = New System.Windows.Forms.CheckBox()
        Me.Days3 = New System.Windows.Forms.CheckBox()
        Me.Shift2 = New System.Windows.Forms.CheckBox()
        Me.Days2 = New System.Windows.Forms.CheckBox()
        Me.Shift1 = New System.Windows.Forms.CheckBox()
        Me.Days1 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStId = New System.Windows.Forms.TextBox()
        Me.btnStSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblStName
        '
        Me.lblStName.BackColor = System.Drawing.SystemColors.Info
        Me.lblStName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStName.Location = New System.Drawing.Point(198, 23)
        Me.lblStName.Name = "lblStName"
        Me.lblStName.Size = New System.Drawing.Size(208, 25)
        Me.lblStName.TabIndex = 277
        Me.lblStName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Delayed
        '
        Me.Delayed.AutoSize = True
        Me.Delayed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Delayed.Location = New System.Drawing.Point(478, 174)
        Me.Delayed.Name = "Delayed"
        Me.Delayed.Size = New System.Drawing.Size(15, 14)
        Me.Delayed.TabIndex = 11
        Me.Delayed.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(482, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 26)
        Me.Label12.TabIndex = 12
        Me.Label12.Tag = ""
        Me.Label12.Text = "تأجيل بدء الدراسة"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DelayUntil
        '
        Me.DelayUntil.CustomFormat = "yyyy-MM-dd"
        Me.DelayUntil.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DelayUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DelayUntil.Location = New System.Drawing.Point(273, 168)
        Me.DelayUntil.Name = "DelayUntil"
        Me.DelayUntil.Size = New System.Drawing.Size(203, 26)
        Me.DelayUntil.TabIndex = 13
        '
        'Shift4
        '
        Me.Shift4.AutoSize = True
        Me.Shift4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Shift4.Checked = True
        Me.Shift4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Shift4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Shift4.Location = New System.Drawing.Point(20, 129)
        Me.Shift4.Name = "Shift4"
        Me.Shift4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Shift4.Size = New System.Drawing.Size(99, 23)
        Me.Shift4.TabIndex = 10
        Me.Shift4.Text = "6:30 - 9:30"
        Me.Shift4.UseVisualStyleBackColor = False
        '
        'Shift3
        '
        Me.Shift3.AutoSize = True
        Me.Shift3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Shift3.Checked = True
        Me.Shift3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Shift3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Shift3.Location = New System.Drawing.Point(131, 129)
        Me.Shift3.Name = "Shift3"
        Me.Shift3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Shift3.Size = New System.Drawing.Size(99, 23)
        Me.Shift3.TabIndex = 9
        Me.Shift3.Text = "3:30 - 6:30"
        Me.Shift3.UseVisualStyleBackColor = False
        '
        'Days3
        '
        Me.Days3.AutoSize = True
        Me.Days3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Days3.Checked = True
        Me.Days3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Days3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Days3.Location = New System.Drawing.Point(132, 62)
        Me.Days3.Name = "Days3"
        Me.Days3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Days3.Size = New System.Drawing.Size(115, 23)
        Me.Days3.TabIndex = 4
        Me.Days3.Text = "الأثنين - الخميس"
        Me.Days3.UseVisualStyleBackColor = False
        '
        'Shift2
        '
        Me.Shift2.AutoSize = True
        Me.Shift2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Shift2.Checked = True
        Me.Shift2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Shift2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Shift2.Location = New System.Drawing.Point(242, 129)
        Me.Shift2.Name = "Shift2"
        Me.Shift2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Shift2.Size = New System.Drawing.Size(107, 23)
        Me.Shift2.TabIndex = 8
        Me.Shift2.Tag = ""
        Me.Shift2.Text = "12:30 - 3:30"
        Me.Shift2.UseVisualStyleBackColor = False
        '
        'Days2
        '
        Me.Days2.AutoSize = True
        Me.Days2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Days2.Checked = True
        Me.Days2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Days2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Days2.Location = New System.Drawing.Point(253, 62)
        Me.Days2.Name = "Days2"
        Me.Days2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Days2.Size = New System.Drawing.Size(107, 23)
        Me.Days2.TabIndex = 3
        Me.Days2.Text = "الأحد - الأربعاء"
        Me.Days2.UseVisualStyleBackColor = False
        '
        'Shift1
        '
        Me.Shift1.AutoSize = True
        Me.Shift1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Shift1.Checked = True
        Me.Shift1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Shift1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Shift1.Location = New System.Drawing.Point(362, 129)
        Me.Shift1.Name = "Shift1"
        Me.Shift1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Shift1.Size = New System.Drawing.Size(107, 23)
        Me.Shift1.TabIndex = 7
        Me.Shift1.Text = "9:30 - 12:30"
        Me.Shift1.UseVisualStyleBackColor = False
        '
        'Days1
        '
        Me.Days1.AutoSize = True
        Me.Days1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Days1.Checked = True
        Me.Days1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Days1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Days1.Location = New System.Drawing.Point(366, 62)
        Me.Days1.Name = "Days1"
        Me.Days1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Days1.Size = New System.Drawing.Size(110, 23)
        Me.Days1.TabIndex = 2
        Me.Days1.Text = "السبت - الثلاثاء"
        Me.Days1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(482, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 26)
        Me.Label8.TabIndex = 270
        Me.Label8.Text = "الأيام المناسبة"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(482, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 26)
        Me.Label6.TabIndex = 269
        Me.Label6.Text = "المواعيد المناسبة"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStId
        '
        Me.txtStId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStId.Location = New System.Drawing.Point(412, 22)
        Me.txtStId.MaxLength = 6
        Me.txtStId.Name = "txtStId"
        Me.txtStId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStId.Size = New System.Drawing.Size(64, 26)
        Me.txtStId.TabIndex = 0
        '
        'btnStSearch
        '
        Me.btnStSearch.Location = New System.Drawing.Point(162, 22)
        Me.btnStSearch.Name = "btnStSearch"
        Me.btnStSearch.Size = New System.Drawing.Size(30, 27)
        Me.btnStSearch.TabIndex = 1
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
        Me.Label5.Location = New System.Drawing.Point(482, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 26)
        Me.Label5.TabIndex = 267
        Me.Label5.Text = "الطالب"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotes
        '
        Me.lblNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotes.Location = New System.Drawing.Point(482, 204)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(146, 26)
        Me.lblNotes.TabIndex = 264
        Me.lblNotes.Text = "ملاحظات"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notes
        '
        Me.Notes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Notes.Location = New System.Drawing.Point(53, 204)
        Me.Notes.MaxLength = 100
        Me.Notes.Name = "Notes"
        Me.Notes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Notes.Size = New System.Drawing.Size(423, 26)
        Me.Notes.TabIndex = 14
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(202, 248)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 26)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "خروج"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(345, 248)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 26)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "بدء الامتحان"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.Location = New System.Drawing.Point(242, 101)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(234, 23)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "الفترة الصباحية"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox2.Location = New System.Drawing.Point(20, 101)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox2.Size = New System.Drawing.Size(216, 23)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "الفترة المسائية"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'StudentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(650, 286)
        Me.Controls.Add(Me.lblStName)
        Me.Controls.Add(Me.Delayed)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DelayUntil)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Shift4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Shift3)
        Me.Controls.Add(Me.Days3)
        Me.Controls.Add(Me.Shift2)
        Me.Controls.Add(Me.Days2)
        Me.Controls.Add(Me.Shift1)
        Me.Controls.Add(Me.Days1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStId)
        Me.Controls.Add(Me.btnStSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.KeyPreview = True
        Me.Name = "StudentLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStName As System.Windows.Forms.Label
    Friend WithEvents Delayed As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DelayUntil As System.Windows.Forms.DateTimePicker
    Friend WithEvents Shift4 As System.Windows.Forms.CheckBox
    Friend WithEvents Shift3 As System.Windows.Forms.CheckBox
    Friend WithEvents Days3 As System.Windows.Forms.CheckBox
    Friend WithEvents Shift2 As System.Windows.Forms.CheckBox
    Friend WithEvents Days2 As System.Windows.Forms.CheckBox
    Friend WithEvents Shift1 As System.Windows.Forms.CheckBox
    Friend WithEvents Days1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStId As System.Windows.Forms.TextBox
    Friend WithEvents btnStSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
