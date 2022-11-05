<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdditionEligibility
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdditionEligibility))
        Me.lblStName = New System.Windows.Forms.Label()
        Me.txtStId = New System.Windows.Forms.TextBox()
        Me.btnStSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CategoryId = New System.Windows.Forms.ComboBox()
        Me.DepartmentId = New System.Windows.Forms.ComboBox()
        Me.lblMain2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCourseSearch = New System.Windows.Forms.Button()
        Me.Course = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.True1 = New System.Windows.Forms.PictureBox()
        Me.True2 = New System.Windows.Forms.PictureBox()
        Me.True3 = New System.Windows.Forms.PictureBox()
        Me.False1 = New System.Windows.Forms.PictureBox()
        Me.False2 = New System.Windows.Forms.PictureBox()
        Me.False3 = New System.Windows.Forms.PictureBox()
        Me.Installment = New System.Windows.Forms.TextBox()
        Me.Remaining = New System.Windows.Forms.TextBox()
        Me.lblRelevel = New System.Windows.Forms.Label()
        CType(Me.True1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.True2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.True3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.False1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.False2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.False3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStName
        '
        Me.lblStName.BackColor = System.Drawing.SystemColors.Info
        Me.lblStName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStName.Location = New System.Drawing.Point(204, 23)
        Me.lblStName.Name = "lblStName"
        Me.lblStName.Size = New System.Drawing.Size(208, 25)
        Me.lblStName.TabIndex = 1
        '
        'txtStId
        '
        Me.txtStId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStId.Location = New System.Drawing.Point(135, 22)
        Me.txtStId.MaxLength = 6
        Me.txtStId.Name = "txtStId"
        Me.txtStId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStId.Size = New System.Drawing.Size(64, 26)
        Me.txtStId.TabIndex = 0
        '
        'btnStSearch
        '
        Me.btnStSearch.Location = New System.Drawing.Point(414, 22)
        Me.btnStSearch.Name = "btnStSearch"
        Me.btnStSearch.Size = New System.Drawing.Size(30, 27)
        Me.btnStSearch.TabIndex = 2
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
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "Student"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(291, 150)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(208, 150)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Check"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CategoryId
        '
        Me.CategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CategoryId.FormattingEnabled = True
        Me.CategoryId.Location = New System.Drawing.Point(136, 86)
        Me.CategoryId.Name = "CategoryId"
        Me.CategoryId.Size = New System.Drawing.Size(203, 27)
        Me.CategoryId.TabIndex = 4
        '
        'DepartmentId
        '
        Me.DepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DepartmentId.FormattingEnabled = True
        Me.DepartmentId.Location = New System.Drawing.Point(136, 54)
        Me.DepartmentId.Name = "DepartmentId"
        Me.DepartmentId.Size = New System.Drawing.Size(203, 27)
        Me.DepartmentId.TabIndex = 3
        '
        'lblMain2
        '
        Me.lblMain2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain2.Location = New System.Drawing.Point(12, 86)
        Me.lblMain2.Name = "lblMain2"
        Me.lblMain2.Size = New System.Drawing.Size(117, 26)
        Me.lblMain2.TabIndex = 218
        Me.lblMain2.Text = "Category"
        Me.lblMain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 219
        Me.Label7.Text = "Department"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 217
        Me.Label3.Text = "Course"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCourseSearch
        '
        Me.btnCourseSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCourseSearch.Location = New System.Drawing.Point(345, 118)
        Me.btnCourseSearch.Name = "btnCourseSearch"
        Me.btnCourseSearch.Size = New System.Drawing.Size(30, 26)
        Me.btnCourseSearch.TabIndex = 6
        Me.btnCourseSearch.TabStop = False
        Me.btnCourseSearch.Text = "..."
        Me.btnCourseSearch.UseVisualStyleBackColor = True
        '
        'Course
        '
        Me.Course.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Course.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Course.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Course.FormattingEnabled = True
        Me.Course.Location = New System.Drawing.Point(136, 117)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(203, 27)
        Me.Course.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(450, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "Level"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(450, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "Book"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(450, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 26)
        Me.Label4.TabIndex = 221
        Me.Label4.Text = "Installment"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(450, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 220
        Me.Label6.Text = "Card"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(450, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 26)
        Me.Label8.TabIndex = 224
        Me.Label8.Text = "Remaining"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'True1
        '
        Me.True1.BackgroundImage = CType(resources.GetObject("True1.BackgroundImage"), System.Drawing.Image)
        Me.True1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.True1.Location = New System.Drawing.Point(574, 23)
        Me.True1.Name = "True1"
        Me.True1.Size = New System.Drawing.Size(30, 27)
        Me.True1.TabIndex = 225
        Me.True1.TabStop = False
        '
        'True2
        '
        Me.True2.BackgroundImage = CType(resources.GetObject("True2.BackgroundImage"), System.Drawing.Image)
        Me.True2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.True2.Location = New System.Drawing.Point(574, 55)
        Me.True2.Name = "True2"
        Me.True2.Size = New System.Drawing.Size(30, 27)
        Me.True2.TabIndex = 226
        Me.True2.TabStop = False
        '
        'True3
        '
        Me.True3.BackgroundImage = CType(resources.GetObject("True3.BackgroundImage"), System.Drawing.Image)
        Me.True3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.True3.Location = New System.Drawing.Point(574, 87)
        Me.True3.Name = "True3"
        Me.True3.Size = New System.Drawing.Size(30, 27)
        Me.True3.TabIndex = 225
        Me.True3.TabStop = False
        '
        'False1
        '
        Me.False1.BackgroundImage = CType(resources.GetObject("False1.BackgroundImage"), System.Drawing.Image)
        Me.False1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.False1.Location = New System.Drawing.Point(574, 23)
        Me.False1.Name = "False1"
        Me.False1.Size = New System.Drawing.Size(30, 27)
        Me.False1.TabIndex = 225
        Me.False1.TabStop = False
        '
        'False2
        '
        Me.False2.BackgroundImage = CType(resources.GetObject("False2.BackgroundImage"), System.Drawing.Image)
        Me.False2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.False2.Location = New System.Drawing.Point(574, 55)
        Me.False2.Name = "False2"
        Me.False2.Size = New System.Drawing.Size(30, 27)
        Me.False2.TabIndex = 226
        Me.False2.TabStop = False
        '
        'False3
        '
        Me.False3.BackgroundImage = CType(resources.GetObject("False3.BackgroundImage"), System.Drawing.Image)
        Me.False3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.False3.Location = New System.Drawing.Point(574, 87)
        Me.False3.Name = "False3"
        Me.False3.Size = New System.Drawing.Size(30, 27)
        Me.False3.TabIndex = 225
        Me.False3.TabStop = False
        '
        'Installment
        '
        Me.Installment.BackColor = System.Drawing.SystemColors.Info
        Me.Installment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Installment.Location = New System.Drawing.Point(573, 119)
        Me.Installment.MaxLength = 6
        Me.Installment.Name = "Installment"
        Me.Installment.ReadOnly = True
        Me.Installment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Installment.Size = New System.Drawing.Size(114, 26)
        Me.Installment.TabIndex = 227
        '
        'Remaining
        '
        Me.Remaining.BackColor = System.Drawing.SystemColors.Info
        Me.Remaining.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Remaining.Location = New System.Drawing.Point(573, 151)
        Me.Remaining.MaxLength = 6
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        Me.Remaining.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Remaining.Size = New System.Drawing.Size(114, 26)
        Me.Remaining.TabIndex = 227
        '
        'lblRelevel
        '
        Me.lblRelevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRelevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRelevel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRelevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRelevel.Location = New System.Drawing.Point(610, 87)
        Me.lblRelevel.Name = "lblRelevel"
        Me.lblRelevel.Size = New System.Drawing.Size(77, 26)
        Me.lblRelevel.TabIndex = 228
        Me.lblRelevel.Text = "Relevel"
        Me.lblRelevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdditionEligibility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(699, 182)
        Me.Controls.Add(Me.lblRelevel)
        Me.Controls.Add(Me.Remaining)
        Me.Controls.Add(Me.Installment)
        Me.Controls.Add(Me.False3)
        Me.Controls.Add(Me.False2)
        Me.Controls.Add(Me.True3)
        Me.Controls.Add(Me.False1)
        Me.Controls.Add(Me.True2)
        Me.Controls.Add(Me.True1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CategoryId)
        Me.Controls.Add(Me.DepartmentId)
        Me.Controls.Add(Me.lblMain2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCourseSearch)
        Me.Controls.Add(Me.Course)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblStName)
        Me.Controls.Add(Me.txtStId)
        Me.Controls.Add(Me.btnStSearch)
        Me.Controls.Add(Me.Label5)
        Me.KeyPreview = True
        Me.Name = "AdditionEligibility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPT22"
        CType(Me.True1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.True2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.True3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.False1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.False2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.False3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStName As System.Windows.Forms.Label
    Friend WithEvents txtStId As System.Windows.Forms.TextBox
    Friend WithEvents btnStSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents CategoryId As System.Windows.Forms.ComboBox
    Public WithEvents DepartmentId As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCourseSearch As System.Windows.Forms.Button
    Public WithEvents Course As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents True1 As System.Windows.Forms.PictureBox
    Friend WithEvents True2 As System.Windows.Forms.PictureBox
    Friend WithEvents True3 As System.Windows.Forms.PictureBox
    Friend WithEvents False1 As System.Windows.Forms.PictureBox
    Friend WithEvents False2 As System.Windows.Forms.PictureBox
    Friend WithEvents False3 As System.Windows.Forms.PictureBox
    Friend WithEvents Installment As System.Windows.Forms.TextBox
    Friend WithEvents Remaining As System.Windows.Forms.TextBox
    Friend WithEvents lblRelevel As System.Windows.Forms.Label
End Class
