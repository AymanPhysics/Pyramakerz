<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT14
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
        Me.Cities = New System.Windows.Forms.ComboBox()
        Me.Countries = New System.Windows.Forms.ComboBox()
        Me.lblMain2 = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Promotion = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PromotionMethod = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Cities
        '
        Me.Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cities.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cities.FormattingEnabled = True
        Me.Cities.Location = New System.Drawing.Point(135, 40)
        Me.Cities.Name = "Cities"
        Me.Cities.Size = New System.Drawing.Size(203, 27)
        Me.Cities.TabIndex = 1
        '
        'Countries
        '
        Me.Countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Countries.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Countries.FormattingEnabled = True
        Me.Countries.Location = New System.Drawing.Point(135, 9)
        Me.Countries.Name = "Countries"
        Me.Countries.Size = New System.Drawing.Size(203, 27)
        Me.Countries.TabIndex = 0
        '
        'lblMain2
        '
        Me.lblMain2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain2.Location = New System.Drawing.Point(12, 40)
        Me.lblMain2.Name = "lblMain2"
        Me.lblMain2.Size = New System.Drawing.Size(117, 26)
        Me.lblMain2.TabIndex = 97
        Me.lblMain2.Text = "City"
        Me.lblMain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblMain.TabIndex = 98
        Me.lblMain.Text = "Country"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(12, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 26)
        Me.Label8.TabIndex = 193
        Me.Label8.Text = "Promotion"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Promotion
        '
        Me.Promotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Promotion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Promotion.FormattingEnabled = True
        Me.Promotion.Location = New System.Drawing.Point(135, 72)
        Me.Promotion.Name = "Promotion"
        Me.Promotion.Size = New System.Drawing.Size(203, 27)
        Me.Promotion.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(258, 164)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(175, 164)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "View"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ToDate
        '
        Me.ToDate.CustomFormat = "yyyy-MM-dd"
        Me.ToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDate.Location = New System.Drawing.Point(381, 133)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(115, 26)
        Me.ToDate.TabIndex = 195
        '
        'FromDate
        '
        Me.FromDate.CustomFormat = "yyyy-MM-dd"
        Me.FromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDate.Location = New System.Drawing.Point(136, 133)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(115, 26)
        Me.FromDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(257, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "To Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 198
        Me.Label3.Text = "From Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 201
        Me.Label7.Text = "Method"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PromotionMethod
        '
        Me.PromotionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PromotionMethod.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PromotionMethod.FormattingEnabled = True
        Me.PromotionMethod.Location = New System.Drawing.Point(135, 102)
        Me.PromotionMethod.Name = "PromotionMethod"
        Me.PromotionMethod.Size = New System.Drawing.Size(205, 27)
        Me.PromotionMethod.TabIndex = 200
        '
        'RPT14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(509, 193)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PromotionMethod)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Promotion)
        Me.Controls.Add(Me.Cities)
        Me.Controls.Add(Me.Countries)
        Me.Controls.Add(Me.lblMain2)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "RPT14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPT14"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Cities As System.Windows.Forms.ComboBox
    Public WithEvents Countries As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain2 As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Promotion As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents PromotionMethod As System.Windows.Forms.ComboBox
End Class
