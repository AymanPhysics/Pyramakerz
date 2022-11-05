<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableBtn
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btn = New System.Windows.Forms.Button()
        Me.lblYellow = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblBlack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(0, 0)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(62, 65)
        Me.btn.TabIndex = 0
        Me.btn.UseVisualStyleBackColor = True
        '
        'lblYellow
        '
        Me.lblYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblYellow.Location = New System.Drawing.Point(12, 58)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(12, 5)
        Me.lblYellow.TabIndex = 1
        Me.lblYellow.Visible = False
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.Green
        Me.lblGreen.Location = New System.Drawing.Point(25, 58)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(12, 5)
        Me.lblGreen.TabIndex = 2
        Me.lblGreen.Visible = False
        '
        'lblBlue
        '
        Me.lblBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBlue.Location = New System.Drawing.Point(38, 58)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(12, 5)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Visible = False
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(2, 58)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(12, 5)
        Me.lblRed.TabIndex = 4
        Me.lblRed.Visible = False
        '
        'lblBlack
        '
        Me.lblBlack.BackColor = System.Drawing.Color.Black
        Me.lblBlack.Location = New System.Drawing.Point(51, 58)
        Me.lblBlack.Name = "lblBlack"
        Me.lblBlack.Size = New System.Drawing.Size(12, 5)
        Me.lblBlack.TabIndex = 5
        Me.lblBlack.Visible = False
        '
        'TableBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblBlack)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblYellow)
        Me.Controls.Add(Me.btn)
        Me.Name = "TableBtn"
        Me.Size = New System.Drawing.Size(61, 66)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents lblYellow As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblBlack As System.Windows.Forms.Label

End Class
