<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Me.components = New System.ComponentModel.Container
        Me.Branch = New System.Windows.Forms.ComboBox
        Me.Users = New System.Windows.Forms.ComboBox
        Me.Password = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DayDate = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblActualTime = New System.Windows.Forms.Label
        Me.DefaultTime = New System.Windows.Forms.DateTimePicker
        Me.lblSuccess = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Branch
        '
        Me.Branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Branch.BackColor = System.Drawing.SystemColors.Info
        Me.Branch.Enabled = False
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(135, 8)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(203, 27)
        Me.Branch.TabIndex = 0
        '
        'Users
        '
        Me.Users.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Users.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Users.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Users.FormattingEnabled = True
        Me.Users.Location = New System.Drawing.Point(135, 41)
        Me.Users.Name = "Users"
        Me.Users.Size = New System.Drawing.Size(203, 27)
        Me.Users.TabIndex = 1
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Password.Location = New System.Drawing.Point(135, 74)
        Me.Password.MaxLength = 50
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(203, 26)
        Me.Password.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Branch"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(261, 171)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(178, 171)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Login"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DayDate
        '
        Me.DayDate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DayDate.CustomFormat = "hh : mm : tt"
        Me.DayDate.Enabled = False
        Me.DayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DayDate.Location = New System.Drawing.Point(135, 138)
        Me.DayDate.Name = "DayDate"
        Me.DayDate.ShowUpDown = True
        Me.DayDate.Size = New System.Drawing.Size(203, 26)
        Me.DayDate.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(12, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Current Time"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblActualTime
        '
        Me.lblActualTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblActualTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActualTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblActualTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblActualTime.Location = New System.Drawing.Point(12, 106)
        Me.lblActualTime.Name = "lblActualTime"
        Me.lblActualTime.Size = New System.Drawing.Size(117, 26)
        Me.lblActualTime.TabIndex = 106
        Me.lblActualTime.Text = "Default Time"
        Me.lblActualTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DefaultTime
        '
        Me.DefaultTime.CustomFormat = "hh : mm : tt"
        Me.DefaultTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DefaultTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DefaultTime.Location = New System.Drawing.Point(135, 106)
        Me.DefaultTime.Name = "DefaultTime"
        Me.DefaultTime.ShowUpDown = True
        Me.DefaultTime.Size = New System.Drawing.Size(203, 26)
        Me.DefaultTime.TabIndex = 4
        '
        'lblSuccess
        '
        Me.lblSuccess.BackColor = System.Drawing.Color.Yellow
        Me.lblSuccess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSuccess.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSuccess.ForeColor = System.Drawing.Color.Red
        Me.lblSuccess.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSuccess.Location = New System.Drawing.Point(12, 171)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(160, 26)
        Me.lblSuccess.TabIndex = 106
        Me.lblSuccess.Text = "Success"
        Me.lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSuccess.Visible = False
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(349, 205)
        Me.ControlBox = False
        Me.Controls.Add(Me.DefaultTime)
        Me.Controls.Add(Me.DayDate)
        Me.Controls.Add(Me.lblSuccess)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.Users)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblActualTime)
        Me.Name = "Attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Public WithEvents Users As System.Windows.Forms.ComboBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblActualTime As System.Windows.Forms.Label
    Friend WithEvents DefaultTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSuccess As System.Windows.Forms.Label
End Class
