<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSG
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
        Me.lblMSG = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMSG
        '
        Me.lblMSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMSG.BackColor = System.Drawing.SystemColors.Info
        Me.lblMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMSG.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMSG.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMSG.Location = New System.Drawing.Point(12, 9)
        Me.lblMSG.Name = "lblMSG"
        Me.lblMSG.Size = New System.Drawing.Size(406, 71)
        Me.lblMSG.TabIndex = 92
        Me.lblMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnYes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.Black
        Me.btnYes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnYes.Location = New System.Drawing.Point(341, 83)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(77, 26)
        Me.btnYes.TabIndex = 94
        Me.btnYes.Text = "&Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.Black
        Me.btnNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNo.Location = New System.Drawing.Point(258, 83)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(77, 26)
        Me.btnNo.TabIndex = 93
        Me.btnNo.Text = "&No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'MSG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnNo
        Me.ClientSize = New System.Drawing.Size(430, 113)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblMSG)
        Me.Name = "MSG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alert"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Public WithEvents lblMSG As System.Windows.Forms.Label
End Class
