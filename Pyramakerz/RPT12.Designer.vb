<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT12
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
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.RefundReason = New System.Windows.Forms.ComboBox()
        Me.lblRefundReason = New System.Windows.Forms.Label()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Branch
        '
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(156, 9)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(203, 27)
        Me.Branch.TabIndex = 186
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(139, 26)
        Me.lblMain.TabIndex = 187
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RefundReason
        '
        Me.RefundReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RefundReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RefundReason.FormattingEnabled = True
        Me.RefundReason.Location = New System.Drawing.Point(156, 41)
        Me.RefundReason.Name = "RefundReason"
        Me.RefundReason.Size = New System.Drawing.Size(203, 27)
        Me.RefundReason.TabIndex = 222
        '
        'lblRefundReason
        '
        Me.lblRefundReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRefundReason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRefundReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRefundReason.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRefundReason.Location = New System.Drawing.Point(12, 41)
        Me.lblRefundReason.Name = "lblRefundReason"
        Me.lblRefundReason.Size = New System.Drawing.Size(139, 26)
        Me.lblRefundReason.TabIndex = 223
        Me.lblRefundReason.Text = "Refund Reason"
        Me.lblRefundReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToDate
        '
        Me.ToDate.CustomFormat = "yyyy-MM-dd"
        Me.ToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDate.Location = New System.Drawing.Point(456, 74)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(139, 26)
        Me.ToDate.TabIndex = 217
        '
        'FromDate
        '
        Me.FromDate.CustomFormat = "yyyy-MM-dd"
        Me.FromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDate.Location = New System.Drawing.Point(156, 74)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(139, 26)
        Me.FromDate.TabIndex = 216
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(312, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 26)
        Me.Label5.TabIndex = 221
        Me.Label5.Text = "To Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 26)
        Me.Label6.TabIndex = 220
        Me.Label6.Text = "From Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(305, 110)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 219
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(222, 110)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 218
        Me.btnSave.Text = "View"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'RPT12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(605, 143)
        Me.Controls.Add(Me.RefundReason)
        Me.Controls.Add(Me.lblRefundReason)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "RPT12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPT12"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Public WithEvents RefundReason As System.Windows.Forms.ComboBox
    Friend WithEvents lblRefundReason As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
