<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT11
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
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SortBy = New System.Windows.Forms.ComboBox()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToRealInv = New System.Windows.Forms.TextBox()
        Me.FromRealInv = New System.Windows.Forms.TextBox()
        Me.ToInv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromInv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.OutcomeReason = New System.Windows.Forms.ComboBox()
        Me.lblOutcomeReason = New System.Windows.Forms.Label()
        Me.RefundReason = New System.Windows.Forms.ComboBox()
        Me.lblRefundReason = New System.Windows.Forms.Label()
        Me.lblIsReal = New System.Windows.Forms.Label()
        Me.IsReal = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HasInvoiceNo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cash = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Canceled = New System.Windows.Forms.ComboBox()
        Me.Cities = New System.Windows.Forms.ComboBox()
        Me.Countries = New System.Windows.Forms.ComboBox()
        Me.lblMain2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ToDate
        '
        Me.ToDate.CustomFormat = "yyyy-MM-dd"
        Me.ToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDate.Location = New System.Drawing.Point(456, 328)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(139, 26)
        Me.ToDate.TabIndex = 16
        '
        'FromDate
        '
        Me.FromDate.CustomFormat = "yyyy-MM-dd"
        Me.FromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDate.Location = New System.Drawing.Point(156, 328)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(139, 26)
        Me.FromDate.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(312, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 26)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "To Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 26)
        Me.Label6.TabIndex = 192
        Me.Label6.Text = "From Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SortBy
        '
        Me.SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SortBy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SortBy.FormattingEnabled = True
        Me.SortBy.Items.AddRange(New Object() {"Invoice No", "Real Invoice No", "Date", "Value"})
        Me.SortBy.Location = New System.Drawing.Point(457, 169)
        Me.SortBy.Name = "SortBy"
        Me.SortBy.Size = New System.Drawing.Size(139, 27)
        Me.SortBy.TabIndex = 8
        '
        'Type
        '
        Me.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"", "Outcome", "PutInBank", "SetupCost"})
        Me.Type.Location = New System.Drawing.Point(156, 168)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(139, 27)
        Me.Type.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(313, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 26)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Sort By"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(12, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 26)
        Me.Label8.TabIndex = 190
        Me.Label8.Text = "Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToRealInv
        '
        Me.ToRealInv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToRealInv.Location = New System.Drawing.Point(457, 137)
        Me.ToRealInv.MaxLength = 8
        Me.ToRealInv.Name = "ToRealInv"
        Me.ToRealInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToRealInv.Size = New System.Drawing.Size(139, 26)
        Me.ToRealInv.TabIndex = 6
        '
        'FromRealInv
        '
        Me.FromRealInv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromRealInv.Location = New System.Drawing.Point(156, 137)
        Me.FromRealInv.MaxLength = 8
        Me.FromRealInv.Name = "FromRealInv"
        Me.FromRealInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FromRealInv.Size = New System.Drawing.Size(139, 26)
        Me.FromRealInv.TabIndex = 5
        '
        'ToInv
        '
        Me.ToInv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ToInv.Location = New System.Drawing.Point(457, 105)
        Me.ToInv.MaxLength = 8
        Me.ToInv.Name = "ToInv"
        Me.ToInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToInv.Size = New System.Drawing.Size(139, 26)
        Me.ToInv.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(313, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 26)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "To Real Inv. No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FromInv
        '
        Me.FromInv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FromInv.Location = New System.Drawing.Point(156, 105)
        Me.FromInv.MaxLength = 8
        Me.FromInv.Name = "FromInv"
        Me.FromInv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FromInv.Size = New System.Drawing.Size(139, 26)
        Me.FromInv.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 26)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "From Real Inv. No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(313, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 26)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "To Inv. No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "From Inv. No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(305, 364)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(222, 364)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "View"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Branch
        '
        Me.Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(156, 73)
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
        Me.lblMain.Location = New System.Drawing.Point(12, 73)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(139, 26)
        Me.lblMain.TabIndex = 185
        Me.lblMain.Text = "Branch"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OutcomeReason
        '
        Me.OutcomeReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutcomeReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.OutcomeReason.FormattingEnabled = True
        Me.OutcomeReason.Location = New System.Drawing.Point(156, 262)
        Me.OutcomeReason.Name = "OutcomeReason"
        Me.OutcomeReason.Size = New System.Drawing.Size(203, 27)
        Me.OutcomeReason.TabIndex = 13
        '
        'lblOutcomeReason
        '
        Me.lblOutcomeReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblOutcomeReason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutcomeReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutcomeReason.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOutcomeReason.Location = New System.Drawing.Point(12, 262)
        Me.lblOutcomeReason.Name = "lblOutcomeReason"
        Me.lblOutcomeReason.Size = New System.Drawing.Size(139, 26)
        Me.lblOutcomeReason.TabIndex = 213
        Me.lblOutcomeReason.Text = "Reason"
        Me.lblOutcomeReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RefundReason
        '
        Me.RefundReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RefundReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RefundReason.FormattingEnabled = True
        Me.RefundReason.Location = New System.Drawing.Point(156, 295)
        Me.RefundReason.Name = "RefundReason"
        Me.RefundReason.Size = New System.Drawing.Size(203, 27)
        Me.RefundReason.TabIndex = 14
        '
        'lblRefundReason
        '
        Me.lblRefundReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRefundReason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRefundReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblRefundReason.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRefundReason.Location = New System.Drawing.Point(12, 295)
        Me.lblRefundReason.Name = "lblRefundReason"
        Me.lblRefundReason.Size = New System.Drawing.Size(139, 26)
        Me.lblRefundReason.TabIndex = 215
        Me.lblRefundReason.Text = "Refund Reason"
        Me.lblRefundReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIsReal
        '
        Me.lblIsReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblIsReal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIsReal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblIsReal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIsReal.Location = New System.Drawing.Point(12, 199)
        Me.lblIsReal.Name = "lblIsReal"
        Me.lblIsReal.Size = New System.Drawing.Size(139, 26)
        Me.lblIsReal.TabIndex = 190
        Me.lblIsReal.Text = "Real Type"
        Me.lblIsReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IsReal
        '
        Me.IsReal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IsReal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IsReal.FormattingEnabled = True
        Me.IsReal.Items.AddRange(New Object() {"All", "Real", "Not Real"})
        Me.IsReal.Location = New System.Drawing.Point(156, 199)
        Me.IsReal.Name = "IsReal"
        Me.IsReal.Size = New System.Drawing.Size(139, 27)
        Me.IsReal.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(313, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 26)
        Me.Label9.TabIndex = 190
        Me.Label9.Text = "Has Inv. No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HasInvoiceNo
        '
        Me.HasInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HasInvoiceNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HasInvoiceNo.FormattingEnabled = True
        Me.HasInvoiceNo.Items.AddRange(New Object() {"All", "No", "Yes"})
        Me.HasInvoiceNo.Location = New System.Drawing.Point(457, 201)
        Me.HasInvoiceNo.Name = "HasInvoiceNo"
        Me.HasInvoiceNo.Size = New System.Drawing.Size(139, 27)
        Me.HasInvoiceNo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(12, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 26)
        Me.Label10.TabIndex = 190
        Me.Label10.Text = "Pay Type"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cash
        '
        Me.Cash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cash.FormattingEnabled = True
        Me.Cash.Items.AddRange(New Object() {"All", "Cash", "Sheek"})
        Me.Cash.Location = New System.Drawing.Point(156, 230)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(139, 27)
        Me.Cash.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(312, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 26)
        Me.Label11.TabIndex = 190
        Me.Label11.Text = "Canceled"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Canceled
        '
        Me.Canceled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Canceled.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Canceled.FormattingEnabled = True
        Me.Canceled.Items.AddRange(New Object() {"All", "No", "Yes"})
        Me.Canceled.Location = New System.Drawing.Point(456, 230)
        Me.Canceled.Name = "Canceled"
        Me.Canceled.Size = New System.Drawing.Size(139, 27)
        Me.Canceled.TabIndex = 12
        '
        'Cities
        '
        Me.Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cities.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cities.FormattingEnabled = True
        Me.Cities.Location = New System.Drawing.Point(156, 41)
        Me.Cities.Name = "Cities"
        Me.Cities.Size = New System.Drawing.Size(203, 27)
        Me.Cities.TabIndex = 1
        '
        'Countries
        '
        Me.Countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Countries.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Countries.FormattingEnabled = True
        Me.Countries.Location = New System.Drawing.Point(156, 9)
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
        Me.lblMain2.Location = New System.Drawing.Point(12, 41)
        Me.lblMain2.Name = "lblMain2"
        Me.lblMain2.Size = New System.Drawing.Size(139, 26)
        Me.lblMain2.TabIndex = 218
        Me.lblMain2.Text = "City"
        Me.lblMain2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(12, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 26)
        Me.Label12.TabIndex = 219
        Me.Label12.Text = "Country"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RPT11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(607, 395)
        Me.Controls.Add(Me.Cities)
        Me.Controls.Add(Me.Countries)
        Me.Controls.Add(Me.lblMain2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RefundReason)
        Me.Controls.Add(Me.lblRefundReason)
        Me.Controls.Add(Me.OutcomeReason)
        Me.Controls.Add(Me.lblOutcomeReason)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SortBy)
        Me.Controls.Add(Me.Canceled)
        Me.Controls.Add(Me.HasInvoiceNo)
        Me.Controls.Add(Me.Cash)
        Me.Controls.Add(Me.IsReal)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblIsReal)
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
        Me.Name = "RPT11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPT11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents SortBy As System.Windows.Forms.ComboBox
    Public WithEvents Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToRealInv As System.Windows.Forms.TextBox
    Friend WithEvents FromRealInv As System.Windows.Forms.TextBox
    Friend WithEvents ToInv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FromInv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Public WithEvents OutcomeReason As System.Windows.Forms.ComboBox
    Friend WithEvents lblOutcomeReason As System.Windows.Forms.Label
    Public WithEvents RefundReason As System.Windows.Forms.ComboBox
    Friend WithEvents lblRefundReason As System.Windows.Forms.Label
    Friend WithEvents lblIsReal As System.Windows.Forms.Label
    Public WithEvents IsReal As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents HasInvoiceNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Cash As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Canceled As System.Windows.Forms.ComboBox
    Public WithEvents Cities As System.Windows.Forms.ComboBox
    Public WithEvents Countries As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
