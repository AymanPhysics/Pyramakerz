<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EnName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ArName = New System.Windows.Forms.TextBox()
        Me.NationalId = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.WorkPhone = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Mobile2 = New System.Windows.Forms.TextBox()
        Me.Mobile = New System.Windows.Forms.TextBox()
        Me.HomePhone = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.Size = New System.Drawing.Size(1040, 403)
        Me.DataGridView1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(96, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(0, 0)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtID.Location = New System.Drawing.Point(116, 79)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtID.Size = New System.Drawing.Size(47, 26)
        Me.txtID.TabIndex = 106
        Me.txtID.Tag = "ID"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(278, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 26)
        Me.Label18.TabIndex = 110
        Me.Label18.Text = "En. Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(169, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 26)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Arabic Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnName
        '
        Me.EnName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EnName.Location = New System.Drawing.Point(278, 79)
        Me.EnName.MaxLength = 100
        Me.EnName.Name = "EnName"
        Me.EnName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EnName.Size = New System.Drawing.Size(103, 26)
        Me.EnName.TabIndex = 108
        Me.EnName.Tag = "EnName"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 26)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ArName
        '
        Me.ArName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ArName.Location = New System.Drawing.Point(169, 79)
        Me.ArName.MaxLength = 100
        Me.ArName.Name = "ArName"
        Me.ArName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ArName.Size = New System.Drawing.Size(103, 26)
        Me.ArName.TabIndex = 107
        Me.ArName.Tag = "ArName"
        '
        'NationalId
        '
        Me.NationalId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NationalId.Location = New System.Drawing.Point(387, 79)
        Me.NationalId.MaxLength = 14
        Me.NationalId.Name = "NationalId"
        Me.NationalId.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NationalId.Size = New System.Drawing.Size(103, 26)
        Me.NationalId.TabIndex = 112
        Me.NationalId.Tag = "NationalId"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(387, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 26)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "National Id"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WorkPhone
        '
        Me.WorkPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.WorkPhone.Location = New System.Drawing.Point(605, 79)
        Me.WorkPhone.MaxLength = 15
        Me.WorkPhone.Name = "WorkPhone"
        Me.WorkPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WorkPhone.Size = New System.Drawing.Size(103, 26)
        Me.WorkPhone.TabIndex = 115
        Me.WorkPhone.Tag = "WorkPhone"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Email.Location = New System.Drawing.Point(932, 79)
        Me.Email.MaxLength = 50
        Me.Email.Name = "Email"
        Me.Email.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Email.Size = New System.Drawing.Size(103, 26)
        Me.Email.TabIndex = 118
        Me.Email.Tag = "Email"
        '
        'Mobile2
        '
        Me.Mobile2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Mobile2.Location = New System.Drawing.Point(823, 79)
        Me.Mobile2.MaxLength = 15
        Me.Mobile2.Name = "Mobile2"
        Me.Mobile2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mobile2.Size = New System.Drawing.Size(103, 26)
        Me.Mobile2.TabIndex = 117
        Me.Mobile2.Tag = "Mobile2"
        '
        'Mobile
        '
        Me.Mobile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Mobile.Location = New System.Drawing.Point(714, 79)
        Me.Mobile.MaxLength = 15
        Me.Mobile.Name = "Mobile"
        Me.Mobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Mobile.Size = New System.Drawing.Size(103, 26)
        Me.Mobile.TabIndex = 116
        Me.Mobile.Tag = "Mobile"
        '
        'HomePhone
        '
        Me.HomePhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HomePhone.Location = New System.Drawing.Point(496, 79)
        Me.HomePhone.MaxLength = 15
        Me.HomePhone.Name = "HomePhone"
        Me.HomePhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomePhone.Size = New System.Drawing.Size(103, 26)
        Me.HomePhone.TabIndex = 114
        Me.HomePhone.Tag = "HomePhone"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(932, 47)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 26)
        Me.Label20.TabIndex = 120
        Me.Label20.Text = "Email"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(496, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 26)
        Me.Label19.TabIndex = 119
        Me.Label19.Text = "Home Phone"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPassword.Location = New System.Drawing.Point(605, 47)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(103, 26)
        Me.lblPassword.TabIndex = 121
        Me.lblPassword.Text = "Work Phone"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(823, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 26)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Mobile 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(714, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 26)
        Me.Label17.TabIndex = 122
        Me.Label17.Text = "Mobile"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'State
        '
        Me.State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.State.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.State.FormattingEnabled = True
        Me.State.Items.AddRange(New Object() {"Equals", "Starts with", "Contains", "Ends With"})
        Me.State.Location = New System.Drawing.Point(12, 79)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(98, 27)
        Me.State.TabIndex = 124
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.Red
        Me.btnSearch.Location = New System.Drawing.Point(12, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(1023, 36)
        Me.btnSearch.TabIndex = 210
        Me.btnSearch.Text = "Click here to search . . . "
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'StSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(1064, 519)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.WorkPhone)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Mobile2)
        Me.Controls.Add(Me.Mobile)
        Me.Controls.Add(Me.HomePhone)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.NationalId)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EnName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ArName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "StSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EnName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ArName As System.Windows.Forms.TextBox
    Friend WithEvents NationalId As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents WorkPhone As System.Windows.Forms.TextBox
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Mobile2 As System.Windows.Forms.TextBox
    Friend WithEvents Mobile As System.Windows.Forms.TextBox
    Friend WithEvents HomePhone As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents State As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
