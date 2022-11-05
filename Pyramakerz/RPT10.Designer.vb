<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT10
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.FromInv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToInv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromRealInv = New System.Windows.Forms.TextBox()
        Me.ToRealInv = New System.Windows.Forms.TextBox()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SortBy = New System.Windows.Forms.ComboBox()
        Me.Course = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cities = New System.Windows.Forms.ComboBox()
        Me.Countries = New System.Windows.Forms.ComboBox()
        Me.lblMain2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Canceled = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UserInserted = New System.Windows.Forms.ComboBox()
        Me.Sales = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Branch
        '
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(156, 72)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(203, 27)
        Me.Branch.TabIndex = 2
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMain.Location = New System.Drawing.Point(12, 72)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(139, 26)
        Me.lblMain.TabIndex = 163
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(306, 328)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(223, 328)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "View"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FromInv
        '
        Me.FromInv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromInv.Location = New System.Drawing.Point(156, 165)
        Me.FromInv.MaxLength = 8
        Me.FromInv.Name = "FromInv"
        Me.FromInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FromInv.Size = New System.Drawing.Size(139, 26)
        Me.FromInv.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "From Inv. No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(313, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 26)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "To Inv. No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToInv
        '
        Me.ToInv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToInv.Location = New System.Drawing.Point(457, 165)
        Me.ToInv.MaxLength = 8
        Me.ToInv.Name = "ToInv"
        Me.ToInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToInv.Size = New System.Drawing.Size(139, 26)
        Me.ToInv.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 26)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "From Real Inv. No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(313, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 26)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "To Real Inv. No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FromRealInv
        '
        Me.FromRealInv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromRealInv.Location = New System.Drawing.Point(156, 197)
        Me.FromRealInv.MaxLength = 8
        Me.FromRealInv.Name = "FromRealInv"
        Me.FromRealInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FromRealInv.Size = New System.Drawing.Size(139, 26)
        Me.FromRealInv.TabIndex = 5
        '
        'ToRealInv
        '
        Me.ToRealInv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToRealInv.Location = New System.Drawing.Point(457, 197)
        Me.ToRealInv.MaxLength = 8
        Me.ToRealInv.Name = "ToRealInv"
        Me.ToRealInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToRealInv.Size = New System.Drawing.Size(139, 26)
        Me.ToRealInv.TabIndex = 6
        '
        'Type
        '
        Me.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"", "Detail", "Memberships", "Bundle", "Remaining", "Installments"})
        Me.Type.Location = New System.Drawing.Point(156, 229)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(139, 27)
        Me.Type.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(12, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 26)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToDate
        '
        Me.ToDate.CustomFormat = "yyyy-MM-dd"
        Me.ToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDate.Location = New System.Drawing.Point(457, 293)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(139, 26)
        Me.ToDate.TabIndex = 12
        '
        'FromDate
        '
        Me.FromDate.CustomFormat = "yyyy-MM-dd"
        Me.FromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDate.Location = New System.Drawing.Point(156, 293)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(139, 26)
        Me.FromDate.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(313, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 26)
        Me.Label5.TabIndex = 173
        Me.Label5.Text = "To Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 26)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "From Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 26)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Sort By"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SortBy
        '
        Me.SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SortBy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SortBy.FormattingEnabled = True
        Me.SortBy.Items.AddRange(New Object() {"Invoice No", "Real Invoice No", "Date ( Of Payed )", "Value ( Payed )"})
        Me.SortBy.Location = New System.Drawing.Point(156, 261)
        Me.SortBy.Name = "SortBy"
        Me.SortBy.Size = New System.Drawing.Size(139, 27)
        Me.SortBy.TabIndex = 9
        '
        'Course
        '
        Me.Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Course.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Course.FormattingEnabled = True
        Me.Course.Items.AddRange(New Object() {"", "Course", "Book", "CD", "Placement Test", "Treanslation", "Reservation"})
        Me.Course.Location = New System.Drawing.Point(457, 229)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(139, 27)
        Me.Course.TabIndex = 8
        Me.Course.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(313, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 26)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Detail Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label9.Visible = False
        '
        'Cities
        '
        Me.Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cities.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cities.FormattingEnabled = True
        Me.Cities.Location = New System.Drawing.Point(156, 40)
        Me.Cities.Name = "Cities"
        Me.Cities.Size = New System.Drawing.Size(203, 27)
        Me.Cities.TabIndex = 1
        '
        'Countries
        '
        Me.Countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Countries.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Countries.FormattingEnabled = True
        Me.Countries.Location = New System.Drawing.Point(156, 8)
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
        Me.lblMain2.Size = New System.Drawing.Size(139, 26)
        Me.lblMain2.TabIndex = 178
        Me.lblMain2.Text = "City"
        Me.lblMain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(12, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 26)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "Country"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Canceled
        '
        Me.Canceled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Canceled.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Canceled.FormattingEnabled = True
        Me.Canceled.Items.AddRange(New Object() {"All", "No", "Yes"})
        Me.Canceled.Location = New System.Drawing.Point(457, 261)
        Me.Canceled.Name = "Canceled"
        Me.Canceled.Size = New System.Drawing.Size(139, 27)
        Me.Canceled.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(313, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 26)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "Canceled"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserInserted
        '
        Me.UserInserted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserInserted.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UserInserted.FormattingEnabled = True
        Me.UserInserted.Location = New System.Drawing.Point(156, 102)
        Me.UserInserted.Name = "UserInserted"
        Me.UserInserted.Size = New System.Drawing.Size(203, 27)
        Me.UserInserted.TabIndex = 252
        '
        'Sales
        '
        Me.Sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sales.FormattingEnabled = True
        Me.Sales.Location = New System.Drawing.Point(156, 133)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(203, 27)
        Me.Sales.TabIndex = 253
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(12, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 26)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "Sales"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(12, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 26)
        Me.Label13.TabIndex = 255
        Me.Label13.Text = "User Inserted"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RPT10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(607, 362)
        Me.Controls.Add(Me.UserInserted)
        Me.Controls.Add(Me.Sales)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Canceled)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Cities)
        Me.Controls.Add(Me.Countries)
        Me.Controls.Add(Me.lblMain2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Course)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SortBy)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ToRealInv)
        Me.Controls.Add(Me.FromRealInv)
        Me.Controls.Add(Me.ToInv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FromInv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Branch)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "RPT10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPT10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents FromInv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToInv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FromRealInv As System.Windows.Forms.TextBox
    Friend WithEvents ToRealInv As System.Windows.Forms.TextBox
    Public WithEvents Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents SortBy As System.Windows.Forms.ComboBox
    Public WithEvents Course As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Cities As System.Windows.Forms.ComboBox
    Public WithEvents Countries As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Canceled As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents UserInserted As System.Windows.Forms.ComboBox
    Public WithEvents Sales As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
