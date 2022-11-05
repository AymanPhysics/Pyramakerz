<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallSaving
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
        Me.components = New System.ComponentModel.Container()
        Me.Mobile = New System.Windows.Forms.TextBox()
        Me.HomePhone = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CAREaBOUT = New System.Windows.Forms.TextBox()
        Me.ClientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Comment = New System.Windows.Forms.TextBox()
        Me.Other = New System.Windows.Forms.TextBox()
        Me.KnownUs = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IsPromotion = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Promotion = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.LblSavedBefore = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckSavedBefore = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Mobile
        '
        Me.Mobile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Mobile.Location = New System.Drawing.Point(135, 10)
        Me.Mobile.MaxLength = 15
        Me.Mobile.Name = "Mobile"
        Me.Mobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mobile.Size = New System.Drawing.Size(203, 26)
        Me.Mobile.TabIndex = 0
        '
        'HomePhone
        '
        Me.HomePhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HomePhone.Location = New System.Drawing.Point(484, 10)
        Me.HomePhone.MaxLength = 15
        Me.HomePhone.Name = "HomePhone"
        Me.HomePhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomePhone.Size = New System.Drawing.Size(203, 26)
        Me.HomePhone.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(361, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 26)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "Home Phone"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(12, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 26)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "Mobile"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Client Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Care about"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CAREaBOUT
        '
        Me.CAREaBOUT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CAREaBOUT.Location = New System.Drawing.Point(135, 103)
        Me.CAREaBOUT.MaxLength = 1000
        Me.CAREaBOUT.Name = "CAREaBOUT"
        Me.CAREaBOUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CAREaBOUT.Size = New System.Drawing.Size(552, 26)
        Me.CAREaBOUT.TabIndex = 3
        '
        'ClientName
        '
        Me.ClientName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ClientName.Location = New System.Drawing.Point(135, 70)
        Me.ClientName.MaxLength = 1000
        Me.ClientName.Name = "ClientName"
        Me.ClientName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClientName.Size = New System.Drawing.Size(203, 26)
        Me.ClientName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Comment"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Comment
        '
        Me.Comment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Comment.Location = New System.Drawing.Point(135, 136)
        Me.Comment.MaxLength = 1000
        Me.Comment.Name = "Comment"
        Me.Comment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Comment.Size = New System.Drawing.Size(552, 26)
        Me.Comment.TabIndex = 4
        '
        'Other
        '
        Me.Other.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Other.Location = New System.Drawing.Point(12, 203)
        Me.Other.MaxLength = 1000
        Me.Other.Name = "Other"
        Me.Other.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Other.Size = New System.Drawing.Size(675, 26)
        Me.Other.TabIndex = 6
        '
        'KnownUs
        '
        Me.KnownUs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KnownUs.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.KnownUs.FormattingEnabled = True
        Me.KnownUs.Location = New System.Drawing.Point(241, 170)
        Me.KnownUs.Name = "KnownUs"
        Me.KnownUs.Size = New System.Drawing.Size(446, 27)
        Me.KnownUs.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(12, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(223, 26)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "How did you know about US ?"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IsPromotion
        '
        Me.IsPromotion.AutoSize = True
        Me.IsPromotion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IsPromotion.Location = New System.Drawing.Point(120, 253)
        Me.IsPromotion.Name = "IsPromotion"
        Me.IsPromotion.Size = New System.Drawing.Size(15, 14)
        Me.IsPromotion.TabIndex = 7
        Me.IsPromotion.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(12, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 26)
        Me.Label8.TabIndex = 190
        Me.Label8.Text = "Promotion"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Promotion
        '
        Me.Promotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Promotion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Promotion.FormattingEnabled = True
        Me.Promotion.Location = New System.Drawing.Point(135, 247)
        Me.Promotion.Name = "Promotion"
        Me.Promotion.Size = New System.Drawing.Size(203, 27)
        Me.Promotion.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(527, 296)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(610, 296)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'LblSavedBefore
        '
        Me.LblSavedBefore.BackColor = System.Drawing.Color.Red
        Me.LblSavedBefore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSavedBefore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblSavedBefore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSavedBefore.Location = New System.Drawing.Point(241, 298)
        Me.LblSavedBefore.Name = "LblSavedBefore"
        Me.LblSavedBefore.Size = New System.Drawing.Size(203, 26)
        Me.LblSavedBefore.TabIndex = 104
        Me.LblSavedBefore.Text = "Saved before ..."
        Me.LblSavedBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblSavedBefore.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'CheckSavedBefore
        '
        Me.CheckSavedBefore.AutoSize = True
        Me.CheckSavedBefore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckSavedBefore.Location = New System.Drawing.Point(201, 305)
        Me.CheckSavedBefore.Name = "CheckSavedBefore"
        Me.CheckSavedBefore.Size = New System.Drawing.Size(15, 14)
        Me.CheckSavedBefore.TabIndex = 7
        Me.CheckSavedBefore.UseVisualStyleBackColor = True
        Me.CheckSavedBefore.Visible = False
        '
        'CallSaving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(700, 333)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CheckSavedBefore)
        Me.Controls.Add(Me.IsPromotion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Other)
        Me.Controls.Add(Me.Promotion)
        Me.Controls.Add(Me.KnownUs)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ClientName)
        Me.Controls.Add(Me.Mobile)
        Me.Controls.Add(Me.Comment)
        Me.Controls.Add(Me.CAREaBOUT)
        Me.Controls.Add(Me.HomePhone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSavedBefore)
        Me.Controls.Add(Me.Label17)
        Me.Name = "CallSaving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CallSaving"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mobile As System.Windows.Forms.TextBox
    Friend WithEvents HomePhone As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CAREaBOUT As System.Windows.Forms.TextBox
    Friend WithEvents ClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Comment As System.Windows.Forms.TextBox
    Friend WithEvents Other As System.Windows.Forms.TextBox
    Public WithEvents KnownUs As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents IsPromotion As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Promotion As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents LblSavedBefore As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CheckSavedBefore As System.Windows.Forms.CheckBox
End Class
