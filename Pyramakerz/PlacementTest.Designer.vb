<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlacementTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlacementTest))
        Me.TrueResult = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevios = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Header = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Question = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Answer1 = New System.Windows.Forms.TextBox()
        Me.Answer2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Answer3 = New System.Windows.Forms.TextBox()
        Me.Answer4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Answer5 = New System.Windows.Forms.TextBox()
        Me.Answer7 = New System.Windows.Forms.TextBox()
        Me.Answer6 = New System.Windows.Forms.TextBox()
        Me.Answer8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Answer9 = New System.Windows.Forms.TextBox()
        Me.Answer10 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CboMain = New System.Windows.Forms.ComboBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.FileName = New System.Windows.Forms.TextBox()
        Me.FilePath = New System.Windows.Forms.TextBox()
        Me.ChooseFile = New System.Windows.Forms.Button()
        Me.Upload = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrueResult
        '
        Me.TrueResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TrueResult.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TrueResult.FormattingEnabled = True
        Me.TrueResult.Items.AddRange(New Object() {"Please Select", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.TrueResult.Location = New System.Drawing.Point(134, 452)
        Me.TrueResult.Name = "TrueResult"
        Me.TrueResult.Size = New System.Drawing.Size(149, 27)
        Me.TrueResult.TabIndex = 15
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtID.Location = New System.Drawing.Point(134, 39)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtID.Size = New System.Drawing.Size(100, 26)
        Me.txtID.TabIndex = 0
        '
        'lblSub
        '
        Me.lblSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSub.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSub.Location = New System.Drawing.Point(12, 452)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(117, 26)
        Me.lblSub.TabIndex = 58
        Me.lblSub.Text = "True Choose"
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(13, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 103)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Passage"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Question Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(135, 186)
        Me.txtName.MaxLength = 4000
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtName.Size = New System.Drawing.Size(779, 103)
        Me.txtName.TabIndex = 4
        '
        'btnNew
        '
        Me.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNew.Location = New System.Drawing.Point(384, 491)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(550, 491)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 26)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLast.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLast.Location = New System.Drawing.Point(550, 523)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(77, 26)
        Me.btnLast.TabIndex = 23
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(467, 491)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 26)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevios
        '
        Me.btnPrevios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevios.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevios.ForeColor = System.Drawing.Color.Black
        Me.btnPrevios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrevios.Location = New System.Drawing.Point(384, 523)
        Me.btnPrevios.Name = "btnPrevios"
        Me.btnPrevios.Size = New System.Drawing.Size(77, 26)
        Me.btnPrevios.TabIndex = 21
        Me.btnPrevios.Text = "Previous"
        Me.btnPrevios.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFirst.Location = New System.Drawing.Point(301, 523)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(77, 26)
        Me.btnFirst.TabIndex = 20
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNext.Location = New System.Drawing.Point(467, 523)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 26)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(301, 491)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Header.Location = New System.Drawing.Point(134, 111)
        Me.Header.MaxLength = 100
        Me.Header.Name = "Header"
        Me.Header.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Header.Size = New System.Drawing.Size(410, 26)
        Me.Header.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Header"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Question
        '
        Me.Question.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Question.Location = New System.Drawing.Point(134, 141)
        Me.Question.MaxLength = 100
        Me.Question.Name = "Question"
        Me.Question.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Question.Size = New System.Drawing.Size(410, 26)
        Me.Question.TabIndex = 3
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuestion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblQuestion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuestion.Location = New System.Drawing.Point(12, 141)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(117, 26)
        Me.lblQuestion.TabIndex = 57
        Me.lblQuestion.Text = "Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Answer1
        '
        Me.Answer1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer1.Location = New System.Drawing.Point(134, 295)
        Me.Answer1.MaxLength = 100
        Me.Answer1.Name = "Answer1"
        Me.Answer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer1.Size = New System.Drawing.Size(326, 26)
        Me.Answer1.TabIndex = 5
        '
        'Answer2
        '
        Me.Answer2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer2.Location = New System.Drawing.Point(134, 325)
        Me.Answer2.MaxLength = 100
        Me.Answer2.Name = "Answer2"
        Me.Answer2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer2.Size = New System.Drawing.Size(326, 26)
        Me.Answer2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Answer1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Answer2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Answer3
        '
        Me.Answer3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer3.Location = New System.Drawing.Point(134, 355)
        Me.Answer3.MaxLength = 100
        Me.Answer3.Name = "Answer3"
        Me.Answer3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer3.Size = New System.Drawing.Size(326, 26)
        Me.Answer3.TabIndex = 7
        '
        'Answer4
        '
        Me.Answer4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer4.Location = New System.Drawing.Point(134, 385)
        Me.Answer4.MaxLength = 100
        Me.Answer4.Name = "Answer4"
        Me.Answer4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer4.Size = New System.Drawing.Size(326, 26)
        Me.Answer4.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Answer3"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(12, 385)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 26)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Answer4"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Answer5
        '
        Me.Answer5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer5.Location = New System.Drawing.Point(134, 415)
        Me.Answer5.MaxLength = 100
        Me.Answer5.Name = "Answer5"
        Me.Answer5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer5.Size = New System.Drawing.Size(326, 26)
        Me.Answer5.TabIndex = 9
        '
        'Answer7
        '
        Me.Answer7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer7.Location = New System.Drawing.Point(588, 325)
        Me.Answer7.MaxLength = 100
        Me.Answer7.Name = "Answer7"
        Me.Answer7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer7.Size = New System.Drawing.Size(326, 26)
        Me.Answer7.TabIndex = 11
        '
        'Answer6
        '
        Me.Answer6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer6.Location = New System.Drawing.Point(588, 295)
        Me.Answer6.MaxLength = 100
        Me.Answer6.Name = "Answer6"
        Me.Answer6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer6.Size = New System.Drawing.Size(326, 26)
        Me.Answer6.TabIndex = 10
        '
        'Answer8
        '
        Me.Answer8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer8.Location = New System.Drawing.Point(588, 355)
        Me.Answer8.MaxLength = 100
        Me.Answer8.Name = "Answer8"
        Me.Answer8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer8.Size = New System.Drawing.Size(326, 26)
        Me.Answer8.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(12, 415)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 26)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Answer5"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(466, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Answer7"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(466, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 26)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Answer6"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(466, 355)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 26)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Answer8"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Answer9
        '
        Me.Answer9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer9.Location = New System.Drawing.Point(588, 385)
        Me.Answer9.MaxLength = 100
        Me.Answer9.Name = "Answer9"
        Me.Answer9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer9.Size = New System.Drawing.Size(326, 26)
        Me.Answer9.TabIndex = 13
        '
        'Answer10
        '
        Me.Answer10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Answer10.Location = New System.Drawing.Point(588, 415)
        Me.Answer10.MaxLength = 100
        Me.Answer10.Name = "Answer10"
        Me.Answer10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Answer10.Size = New System.Drawing.Size(326, 26)
        Me.Answer10.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(466, 385)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 26)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Answer9"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(466, 415)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 26)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Answer10"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Type
        '
        Me.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"Choose", "Find Error"})
        Me.Type.Location = New System.Drawing.Point(134, 69)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(326, 27)
        Me.Type.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(12, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 26)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboMain
        '
        Me.CboMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMain.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CboMain.FormattingEnabled = True
        Me.CboMain.Location = New System.Drawing.Point(135, 9)
        Me.CboMain.Name = "CboMain"
        Me.CboMain.Size = New System.Drawing.Size(326, 27)
        Me.CboMain.TabIndex = 62
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
        Me.lblMain.TabIndex = 63
        Me.lblMain.Text = "Level"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FileName
        '
        Me.FileName.BackColor = System.Drawing.SystemColors.Info
        Me.FileName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FileName.Location = New System.Drawing.Point(722, 13)
        Me.FileName.MaxLength = 100
        Me.FileName.Name = "FileName"
        Me.FileName.ReadOnly = True
        Me.FileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FileName.Size = New System.Drawing.Size(174, 26)
        Me.FileName.TabIndex = 11
        '
        'FilePath
        '
        Me.FilePath.BackColor = System.Drawing.SystemColors.Info
        Me.FilePath.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FilePath.Location = New System.Drawing.Point(540, 44)
        Me.FilePath.MaxLength = 100
        Me.FilePath.Name = "FilePath"
        Me.FilePath.ReadOnly = True
        Me.FilePath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FilePath.Size = New System.Drawing.Size(356, 26)
        Me.FilePath.TabIndex = 10
        '
        'ChooseFile
        '
        Me.ChooseFile.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ChooseFile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseFile.ForeColor = System.Drawing.Color.Black
        Me.ChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ChooseFile.Location = New System.Drawing.Point(540, 76)
        Me.ChooseFile.Name = "ChooseFile"
        Me.ChooseFile.Size = New System.Drawing.Size(115, 26)
        Me.ChooseFile.TabIndex = 19
        Me.ChooseFile.Text = "Choose File"
        Me.ChooseFile.UseVisualStyleBackColor = True
        '
        'Upload
        '
        Me.Upload.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Upload.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Upload.ForeColor = System.Drawing.Color.Black
        Me.Upload.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Upload.Location = New System.Drawing.Point(661, 76)
        Me.Upload.Name = "Upload"
        Me.Upload.Size = New System.Drawing.Size(115, 26)
        Me.Upload.TabIndex = 19
        Me.Upload.Text = "Upload"
        Me.Upload.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(540, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 26)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Audio File"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(782, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 26)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel1.Location = New System.Drawing.Point(605, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 45)
        Me.Panel1.TabIndex = 65
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(244, 45)
        Me.AxWindowsMediaPlayer1.TabIndex = 64
        '
        'PlacementTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(929, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CboMain)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TrueResult)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Answer10)
        Me.Controls.Add(Me.Answer8)
        Me.Controls.Add(Me.FilePath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Answer6)
        Me.Controls.Add(Me.Answer4)
        Me.Controls.Add(Me.Answer2)
        Me.Controls.Add(Me.Question)
        Me.Controls.Add(Me.FileName)
        Me.Controls.Add(Me.Answer9)
        Me.Controls.Add(Me.Answer7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Answer5)
        Me.Controls.Add(Me.Answer3)
        Me.Controls.Add(Me.Answer1)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Upload)
        Me.Controls.Add(Me.ChooseFile)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrevios)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "PlacementTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlacementTest"
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents TrueResult As System.Windows.Forms.ComboBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Public WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrevios As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Header As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Question As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents Answer1 As System.Windows.Forms.TextBox
    Friend WithEvents Answer2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Answer3 As System.Windows.Forms.TextBox
    Friend WithEvents Answer4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Answer5 As System.Windows.Forms.TextBox
    Friend WithEvents Answer7 As System.Windows.Forms.TextBox
    Friend WithEvents Answer6 As System.Windows.Forms.TextBox
    Friend WithEvents Answer8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Answer9 As System.Windows.Forms.TextBox
    Friend WithEvents Answer10 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Type As System.Windows.Forms.ComboBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents CboMain As System.Windows.Forms.ComboBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents FileName As System.Windows.Forms.TextBox
    Friend WithEvents FilePath As System.Windows.Forms.TextBox
    Friend WithEvents ChooseFile As System.Windows.Forms.Button
    Friend WithEvents Upload As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
