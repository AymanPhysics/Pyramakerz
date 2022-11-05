<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Branches
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
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CountryId = New System.Windows.Forms.ComboBox
        Me.CityId = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnPrevios = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Manager = New System.Windows.Forms.ComboBox
        Me.lbl = New System.Windows.Forms.Label
        Me.ShortName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtID.Location = New System.Drawing.Point(135, 9)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtID.Size = New System.Drawing.Size(100, 26)
        Me.txtID.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblName.Location = New System.Drawing.Point(12, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(117, 26)
        Me.lblName.TabIndex = 48
        Me.lblName.Text = "English Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(135, 40)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(286, 26)
        Me.txtName.TabIndex = 1
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
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountryId
        '
        Me.CountryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountryId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CountryId.FormattingEnabled = True
        Me.CountryId.Location = New System.Drawing.Point(135, 102)
        Me.CountryId.Name = "CountryId"
        Me.CountryId.Size = New System.Drawing.Size(203, 27)
        Me.CountryId.TabIndex = 3
        '
        'CityId
        '
        Me.CityId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CityId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CityId.FormattingEnabled = True
        Me.CityId.Location = New System.Drawing.Point(135, 133)
        Me.CityId.Name = "CityId"
        Me.CityId.Size = New System.Drawing.Size(203, 27)
        Me.CityId.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "City"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Country"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(165, 198)
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
        Me.btnClose.Location = New System.Drawing.Point(331, 198)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLast.Location = New System.Drawing.Point(331, 226)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 26)
        Me.btnLast.TabIndex = 13
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(248, 198)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevios
        '
        Me.btnPrevios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevios.ForeColor = System.Drawing.Color.Black
        Me.btnPrevios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrevios.Location = New System.Drawing.Point(165, 226)
        Me.btnPrevios.Name = "btnPrevios"
        Me.btnPrevios.Size = New System.Drawing.Size(77, 26)
        Me.btnPrevios.TabIndex = 11
        Me.btnPrevios.Text = "Previous"
        Me.btnPrevios.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFirst.Location = New System.Drawing.Point(82, 226)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 26)
        Me.btnFirst.TabIndex = 10
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(248, 226)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 26)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(82, 198)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Manager
        '
        Me.Manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Manager.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Manager.FormattingEnabled = True
        Me.Manager.Location = New System.Drawing.Point(135, 165)
        Me.Manager.Name = "Manager"
        Me.Manager.Size = New System.Drawing.Size(203, 27)
        Me.Manager.TabIndex = 5
        '
        'lbl
        '
        Me.lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl.Location = New System.Drawing.Point(12, 165)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(117, 26)
        Me.lbl.TabIndex = 63
        Me.lbl.Text = "Manager"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShortName
        '
        Me.ShortName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ShortName.Location = New System.Drawing.Point(136, 71)
        Me.ShortName.MaxLength = 10
        Me.ShortName.Name = "ShortName"
        Me.ShortName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShortName.Size = New System.Drawing.Size(100, 26)
        Me.ShortName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Short Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Branches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(452, 258)
        Me.Controls.Add(Me.ShortName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Manager)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevios)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CountryId)
        Me.Controls.Add(Me.CityId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Branches"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branches"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents CountryId As System.Windows.Forms.ComboBox
    Public WithEvents CityId As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrevios As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents Manager As System.Windows.Forms.ComboBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents ShortName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
