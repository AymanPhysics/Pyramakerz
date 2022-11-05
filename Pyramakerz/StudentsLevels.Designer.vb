<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsLevels
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.LevelId = New System.Windows.Forms.ComboBox()
        Me.btnStSearch = New System.Windows.Forms.Button()
        Me.CategoryId = New System.Windows.Forms.ComboBox()
        Me.DepartmentId = New System.Windows.Forms.ComboBox()
        Me.lblMain2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStId = New System.Windows.Forms.TextBox()
        Me.lblStName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblMain.TabIndex = 75
        Me.lblMain.Text = "Student"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(218, 162)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(301, 162)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(135, 162)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'LevelId
        '
        Me.LevelId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LevelId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LevelId.FormattingEnabled = True
        Me.LevelId.Location = New System.Drawing.Point(135, 126)
        Me.LevelId.Name = "LevelId"
        Me.LevelId.Size = New System.Drawing.Size(210, 27)
        Me.LevelId.TabIndex = 5
        '
        'btnStSearch
        '
        Me.btnStSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStSearch.Location = New System.Drawing.Point(418, 9)
        Me.btnStSearch.Name = "btnStSearch"
        Me.btnStSearch.Size = New System.Drawing.Size(30, 26)
        Me.btnStSearch.TabIndex = 2
        Me.btnStSearch.TabStop = False
        Me.btnStSearch.Text = "..."
        Me.btnStSearch.UseVisualStyleBackColor = True
        '
        'CategoryId
        '
        Me.CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CategoryId.FormattingEnabled = True
        Me.CategoryId.Location = New System.Drawing.Point(136, 74)
        Me.CategoryId.Name = "CategoryId"
        Me.CategoryId.Size = New System.Drawing.Size(209, 27)
        Me.CategoryId.TabIndex = 4
        '
        'DepartmentId
        '
        Me.DepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DepartmentId.FormattingEnabled = True
        Me.DepartmentId.Location = New System.Drawing.Point(136, 41)
        Me.DepartmentId.Name = "DepartmentId"
        Me.DepartmentId.Size = New System.Drawing.Size(209, 27)
        Me.DepartmentId.TabIndex = 3
        '
        'lblMain2
        '
        Me.lblMain2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain2.Location = New System.Drawing.Point(12, 74)
        Me.lblMain2.Name = "lblMain2"
        Me.lblMain2.Size = New System.Drawing.Size(117, 26)
        Me.lblMain2.TabIndex = 182
        Me.lblMain2.Text = "Category"
        Me.lblMain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Department"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStId
        '
        Me.txtStId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStId.ForeColor = System.Drawing.Color.Black
        Me.txtStId.Location = New System.Drawing.Point(136, 9)
        Me.txtStId.MaxLength = 6
        Me.txtStId.Name = "txtStId"
        Me.txtStId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStId.Size = New System.Drawing.Size(64, 26)
        Me.txtStId.TabIndex = 0
        '
        'lblStName
        '
        Me.lblStName.BackColor = System.Drawing.SystemColors.Info
        Me.lblStName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStName.Location = New System.Drawing.Point(206, 10)
        Me.lblStName.Name = "lblStName"
        Me.lblStName.Size = New System.Drawing.Size(208, 25)
        Me.lblStName.TabIndex = 184
        '
        'StudentsLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(452, 200)
        Me.Controls.Add(Me.lblStName)
        Me.Controls.Add(Me.txtStId)
        Me.Controls.Add(Me.CategoryId)
        Me.Controls.Add(Me.DepartmentId)
        Me.Controls.Add(Me.lblMain2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnStSearch)
        Me.Controls.Add(Me.LevelId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.KeyPreview = True
        Me.Name = "StudentsLevels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentsLevels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents LevelId As System.Windows.Forms.ComboBox
    Friend WithEvents btnStSearch As System.Windows.Forms.Button
    Public WithEvents CategoryId As System.Windows.Forms.ComboBox
    Public WithEvents DepartmentId As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStId As System.Windows.Forms.TextBox
    Friend WithEvents lblStName As System.Windows.Forms.Label
End Class
