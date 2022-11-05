Public Class Table
    Public Flag As String = "1"
    Dim ss As New Screens
    Public MainFrm As Form
    Dim bm As New BasicMethods

    Public GroupsStudentsTableName As String = "GroupsStudents"

    Private Sub Table_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            Barcode.Focus()
        End If
    End Sub

    Private Sub Table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Flag <> "1" Then
            btnSave.Visible = False
        End If

        If Flag = 3 Then
            GroupsStudentsTableName = "VirtualGroupsStudents"
            ViewAttendance.Visible = False
        Else
            btnAddStudents.Visible = False
        End If

        If Module1.Board = 1 OrElse Module1.CityManager = 1 OrElse Module1.CountryManager = 1 OrElse Module1.GeneralManager = 1 OrElse Module1.HeadOfDepartment = 1 OrElse Module1.Manager = 1 OrElse Module1.SystemAdmin = 1 Then
            btnAddStudents.Visible = True
        End If



        bm.FillCombo("Branches", Branch, "")
        bm.FillCombo("select Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)
        bm.FillCombo("Departments", DepartmentId, "")

        lblDepartmentId.Visible = False
        lblCategoryId.Visible = False
        lblCourseId.Visible = False

        DateTimePicker1.Value = Date.Now
        Branch.SelectedValue = Module1.Branch
        btnAddStudents.Visible = False
        FullScreen()
        Barcode_LostFocus(Nothing, Nothing)

    End Sub
    Sub FullScreen()
        Top = 0
        Left = 0
        Size = New Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height)
    End Sub


    Structure InitialClasses
        Dim Id As String
        Dim Name As String
        Dim Capacity As Integer
        Dim NoOfStudents As Integer
        Dim GroupId As String
        Dim DepartmentId As String
        Dim CategoryId As String
        Dim CourseId As String
        Dim CourseName As String
        Dim InstractorId As String
        Dim InstractorName As String
        Dim Intensive As Boolean
        Dim LectureNo As Integer
        Dim NoOfHours As Integer
        Dim IsPrivate As Boolean
        Dim Notes As String
        Dim Studentcount As Integer
        Dim DayDate As DateTime
        Dim Busy As Boolean
        Dim GroupHours As Decimal
        Dim CourseDuration As Integer
        Dim ReLecture As String
        Dim ComputerLab As String
    End Structure
    Dim Classes(9, 0) As InitialClasses
    Sub LoadPanel()
        Dim dt As DataTable = bm.ExcuteAdapter("Select Id,Name,Capacity,ComputerLab from Classes where BranchId='" & Branch.SelectedValue.ToString & "' order by ComputerLab desc,Capacity desc")
        ReDim Classes(9, dt.Rows.Count)
        LoadPanel(1, FLP1, dt)
        LoadPanel(2, FLP2, dt)
        LoadPanel(3, FLP3, dt)
        LoadPanel(4, FLP4, dt)
        LoadPanel(5, FLP5, dt)
        LoadPanel(6, FLP6, dt)
        LoadPanel(7, FLP7, dt)
        LoadPanel(8, FLP8, dt)
        LoadPanel(9, FLP9, dt)
    End Sub
    Sub LoadPanel(ByVal FLPNo As Integer, ByVal FLP As FlowLayoutPanel, ByVal dt As DataTable)

        FLP.Controls.Clear()

        For i As Integer = 0 To dt.Rows.Count - 1
            Classes(FLPNo, i).Id = dt.Rows(i)(0)
            Classes(FLPNo, i).Name = dt.Rows(i)(1).ToString.Trim
            Classes(FLPNo, i).Capacity = dt.Rows(i)(2)
            Classes(FLPNo, i).ComputerLab = dt.Rows(i)(3)

            'Dim btn As New Button
            Dim btn As New TableBtn
            btn.btn.Tag = i ' dt.Rows(i)(0)

            btn.btn.Text = dt.Rows(i)(1)
            ToolTip1.SetToolTip(btn.btn, dt.Rows(i)(1))
            'btn.Size = New Size(65, 65)
            'btn.btn.Size = New Size(65, 65)
            FLP.Controls.Add(btn)
            AddHandler btn.btn.Click, AddressOf btn_Click


            ToolTip1.SetToolTip(btn.btn, "Id: " & dt.Rows(i)(0) & vbCrLf & "Name: " & dt.Rows(i)(1) & vbCrLf & "Capacity: " & dt.Rows(i)(2))
            'ToolTip1.SetToolTip(btn.btn, "Id: " & dt.Rows(i)(0) & vbCrLf & "Name: " & y & vbCrLf & "Capacity: " & dt.Rows(i)(2))

        Next
    End Sub


    Sub FilterPanel(ByVal FLPNo As Integer, ByVal FLP As FlowLayoutPanel)

        For i As Integer = 0 To FLP.Controls.Count - 1
            'Dim btn As Button = FLP.Controls(i)
            Dim btn As TableBtn = FLP.Controls(i)
            btn.Enabled = True
            If Instractor.SelectedIndex < 1 And DepartmentId.SelectedIndex < 1 And CategoryId.SelectedIndex < 1 And Course.SelectedIndex < 1 And Shift.SelectedIndex < 1 Then
                btn.btn.BackColor = Color.White
                Continue For
            Else
                btn.btn.BackColor = Color.YellowGreen
            End If

            '
            If (Classes(FLPNo, i).Busy) And (Classes(FLPNo, i).InstractorName = Instractor.Text Or Instractor.SelectedIndex < 1) And (Classes(FLPNo, i).DepartmentId = DepartmentId.SelectedValue Or DepartmentId.SelectedIndex < 1) And (Classes(FLPNo, i).CategoryId = CategoryId.SelectedValue Or CategoryId.SelectedIndex < 1) And (Classes(FLPNo, i).CourseId = Course.SelectedValue Or Course.SelectedIndex < 1) And ((FLPNo < 5 And Shift.SelectedIndex = 1) Or (FLPNo >= 5 And Shift.SelectedIndex = 2) Or (Shift.SelectedIndex < 1)) Then
                'btn.BackColor = Color.Red
                GetColor(btn, Classes(FLPNo, i).NoOfStudents, Classes(FLPNo, i).IsPrivate, Classes(FLPNo, i).GroupHours, Classes(FLPNo, i).CourseDuration, Classes(FLPNo, i).ReLecture)
            Else
                btn.btn.BackColor = Color.White
                btn.Enabled = False
            End If
        Next


    End Sub


    Dim btn As Button

    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
        btn = sender

        DataGridView1.Columns.Clear()
        If sender Is Nothing OrElse Classes(btn.Parent.Parent.Tag, btn.Tag).GroupId = Nothing Then
            CheckBox2.Checked = False
            lblGroup.Text = ""
            lblDepartmentId.Text = ""
            lblCategoryId.Text = ""
            lblCourseId.Text = ""
            lblCource.Text = ""
            lblStartingDate.Text = ""
            lblInstractorName.Text = ""
            lblInstractorId.Text = ""
            lblNoOfStudents.Text = ""
            DataGridView1.DataSource = Nothing
            btnAddStudents.Visible = False
            Return
        End If


        'btnAddStudents.Visible = True
        If Module1.Board = 1 OrElse Module1.CityManager = 1 OrElse Module1.CountryManager = 1 OrElse Module1.GeneralManager = 1 OrElse Module1.HeadOfDepartment = 1 OrElse Module1.Manager = 1 OrElse Module1.SystemAdmin = 1 Then
            btnAddStudents.Visible = True
        End If


        'MessageBox.Show(Classes(btn.Parent.Parent.Tag , btn.Tag).GroupId)
        lblGroup.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).GroupId
        lblDepartmentId.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).DepartmentId
        lblCategoryId.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).CategoryId
        lblCourseId.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).CourseId
        lblCource.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).CourseName
        lblStartingDate.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).DayDate
        lblInstractorName.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).InstractorName
        lblInstractorId.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).InstractorId
        lblNoOfStudents.Text = Classes(btn.Parent.Parent.Tag, btn.Tag).NoOfStudents


        Dim dt As New DataTable

        If Classes(btn.Parent.Parent.Tag, btn.Tag).ReLecture = "0" Then
            dt = bm.ExcuteAdapter("select distinct GSt.StudentId,St.EnName ,dbo.GetSumRemaining(/*GSt.BranchId,*/GSt.StudentId) 'Remaining',dbo.GetSumInstallments(/*GSt.BranchId,*/GSt.StudentId,'" & bm.ToStrDate(DateTimePicker1.Value) & "') 'Installments',cast(Att.Attendance as bit)'Attendance','0' 'ReLecture',Att.PrivateHours 'hh',Att.PrivateMinits 'mm',Att.UserName,dbo.getAdditionEligibilityIsCard(GSt.StudentId)Card,dbo.getAdditionEligibilityIsBook(GSt.StudentId,'" & Val(lblDepartmentId.Text) & "','" & Val(lblCategoryId.Text) & "','" & Val(lblCourseId.Text) & "')Book from " & GroupsStudentsTableName & " GSt left join Students St on(GSt.StudentId=St.ID) left outer join GroupsStudentsAttendance Att on(GSt.BranchId=Att.BranchId and GSt.GroupId=Att.GroupId and GSt.StudentId=Att.StudentId and (Att.DayDate='" & bm.ToStrDate(DateTimePicker1.Value) & "')) where GSt.BranchId='" & Branch.SelectedValue.ToString & "' and GSt.GroupId='" & Classes(btn.Parent.Parent.Tag, btn.Tag).GroupId & "' and isnull(Att.DayDate,'" & bm.ToStrDate(DateTimePicker1.Value) & "')='" & bm.ToStrDate(DateTimePicker1.Value) & "'  order by St.EnName")
        Else
            dt = bm.ExcuteAdapter("select GSt.StudentId,St.EnName ,dbo.GetSumRemaining(/*GSt.BranchId,*/GSt.StudentId) 'Remaining',dbo.GetSumInstallments(/*GSt.BranchId,*/GSt.StudentId,'" & bm.ToStrDate(DateTimePicker1.Value) & "') 'Installments',cast(Att.Attendance as bit)'Attendance','1' 'ReLecture',Att.PrivateHours 'hh',Att.PrivateMinits 'mm',Att.UserName,dbo.getAdditionEligibilityIsCard(GSt.StudentId)Card,dbo.getAdditionEligibilityIsBook(GSt.StudentId,'" & Val(lblDepartmentId.Text) & "','" & Val(lblCategoryId.Text) & "','" & Val(lblCourseId.Text) & "')Book from ReLecture GSt left join Students St on(GSt.StudentId=St.ID) left outer join ReLectureStudentsAttendance Att on(GSt.BranchId=Att.BranchId and GSt.Id=Att.GroupId and GSt.StudentId=Att.StudentId and (Att.DayDate='" & bm.ToStrDate(DateTimePicker1.Value) & "')) where GSt.BranchId='" & Branch.SelectedValue.ToString & "' and GSt.Id='" & Classes(btn.Parent.Parent.Tag, btn.Tag).GroupId & "' and isnull(Att.DayDate,'" & bm.ToStrDate(DateTimePicker1.Value) & "')='" & bm.ToStrDate(DateTimePicker1.Value) & "' order by St.EnName")
        End If

        CheckBox2.Checked = False
        If dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("Attendance")) Then
            CheckBox2.Checked = True
        End If

        DataGridView1.DataSource = dt
        Try
            DataGridView1.Columns(0).ReadOnly = True
            DataGridView1.Columns(1).ReadOnly = True
            DataGridView1.Columns(2).ReadOnly = True
            DataGridView1.Columns(3).ReadOnly = True
            DataGridView1.Columns(9).ReadOnly = True
            DataGridView1.Columns(10).ReadOnly = True
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(8).Visible = False
            If Not Classes(btn.Parent.Parent.Tag, btn.Tag).IsPrivate And Classes(btn.Parent.Parent.Tag, btn.Tag).ReLecture = "0" Then
                DataGridView1.Columns(6).Visible = False
                DataGridView1.Columns(7).Visible = False
            End If
            DataGridView1.Columns(6).Width = 30
            DataGridView1.Columns(7).Width = 30
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GetTable()
        If Branch.SelectedIndex < 1 Then Return
        btn_Click(Nothing, Nothing)
        LoadPanel()
        LoadGroups()
    End Sub

    Sub LoadGroups()
        Dim dt As DataTable = bm.ExcuteAdapter("GetGroups", New String() {"Branch", "DayDate", "Flag"}, New String() {Branch.SelectedValue.ToString, bm.ToStrDate(DateTimePicker1.Value), Flag})
        For i As Integer = 0 To dt.Rows.Count - 1
            LoadClass(dt.Rows(i))
        Next
    End Sub
    Function GetLecture(ByVal LecNo As Integer) As FlowLayoutPanel
        Dim FLP As FlowLayoutPanel = Nothing
        Select Case LecNo
            Case 1 : FLP = FLP1
            Case 2 : FLP = FLP2
            Case 3 : FLP = FLP3
            Case 4 : FLP = FLP4
            Case 5 : FLP = FLP5
            Case 6 : FLP = FLP6
            Case 7 : FLP = FLP7
            Case 8 : FLP = FLP8
            Case 9 : FLP = FLP9
        End Select
        Return FLP
    End Function
    Sub LoadClass(ByVal dr As DataRow)
        Try
            Dim LecNo As Integer = dr("LectureNo")
            Dim FLP As FlowLayoutPanel = Nothing
            FLP = GetLecture(LecNo)

            For i As Integer = 0 To Classes.GetLength(1)
                If Classes(FLP.Tag, i).Busy Or Classes(FLP.Tag, i).ComputerLab <> dr("NeedComputerLab") Then Continue For
                Dim xx As Integer = 0
                If dr("Intensive") = 0 Then xx += 1

                For x As Integer = 0 To dr("NoOfHours") - 1 + xx
                    FLP = GetLecture(LecNo + x)
                    If FLP Is Nothing Then Exit For
                    Classes(FLP.Tag, i).CourseName = dr("CourseName")
                    Classes(FLP.Tag, i).GroupId = dr("Id")
                    Classes(FLP.Tag, i).DepartmentId = dr("DepartmentId")
                    Classes(FLP.Tag, i).CategoryId = dr("CategoryId")
                    Classes(FLP.Tag, i).CourseId = dr("Course")
                    Classes(FLP.Tag, i).InstractorId = dr("Instractor")
                    Classes(FLP.Tag, i).InstractorName = dr("InstractorName")
                    Classes(FLP.Tag, i).Intensive = dr("Intensive")
                    Classes(FLP.Tag, i).IsPrivate = dr("ChekPrivate")
                    Classes(FLP.Tag, i).LectureNo = dr("LectureNo")
                    Classes(FLP.Tag, i).NoOfHours = dr("NoOfHours")
                    Classes(FLP.Tag, i).NoOfStudents = dr("Studentcount")
                    Classes(FLP.Tag, i).Notes = dr("Notes")
                    Classes(FLP.Tag, i).DayDate = dr("DayDate")
                    Classes(FLP.Tag, i).GroupHours = dr("GroupHours")
                    Classes(FLP.Tag, i).CourseDuration = dr("CourseDuration")
                    Classes(FLP.Tag, i).ReLecture = dr("ReLecture")
                    Classes(FLP.Tag, i).Busy = True

                    'FLP.Controls(i).BackColor = Color.Red

                    Dim xxxx() As String = dr("InstractorName").ToString.Trim.Split(" ")
                    Dim y As String = ""
                    Try
                        y &= xxxx(0)
                        y &= " "
                        y &= xxxx(1)
                    Catch ex As Exception
                    End Try


                    GetColor(FLP.Controls(i), Val(dr("Studentcount")), dr("ChekPrivate"), dr("GroupHours"), dr("CourseDuration"), dr("ReLecture"))
                    'CType(FLP.Controls(i), TableBtn).btn.Text = dr("InstractorName") & vbCrLf & dr("CourseName")
                    CType(FLP.Controls(i), TableBtn).btn.Text = y & vbCrLf & dr("CourseName")

                Next

                Exit For
            Next


        Catch
        End Try
    End Sub

    Sub GetColor(ByVal btn As TableBtn, ByVal Studentcount As Integer, ByVal IsPrivate As Boolean, ByVal GroupHours As Decimal, ByVal CourseDuration As Integer, ByVal ReLecture As String)
        If ReLecture = "1" Then btn.lblYellow.Visible = True Else btn.lblYellow.Visible = False
        If IsPrivate Then btn.lblGreen.Visible = True Else btn.lblGreen.Visible = False
        If GroupHours > CourseDuration Then btn.lblRed.Visible = True Else btn.lblRed.Visible = False
        If Studentcount = 0 Then btn.lblBlack.Visible = True Else btn.lblBlack.Visible = False
    End Sub


    Private Sub Branch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.SelectedIndexChanged
        GetTable()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        GetTable()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If DataGridView1.Rows.Count = 0 Then Return

        Dim tbl As String = "GroupsStudentsAttendance"
        If DataGridView1.Rows(0).Cells(5).Value = "1" Then tbl = "ReLectureStudentsAttendance"



        If DataGridView1.Rows.Count > 0 AndAlso bm.IF_Exists("select * from " & tbl & " where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & lblGroup.Text & "' and DayDate='" & bm.ToStrDate(DateTimePicker1.Value) & "'") Then
            bm.TestMistakeOrUpdate(DataGridView1.Rows(0).Cells(8).Value.ToString, Name)
        End If

        Dim Statement As String = "delete from " & tbl & " where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & lblGroup.Text & "' and DayDate='" & bm.ToStrDate(DateTimePicker1.Value) & "'"

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim s As String = "0"
            If Not IsDBNull(DataGridView1.Rows(i).Cells(4).Value) AndAlso DataGridView1.Rows(i).Cells(4).Value Then s = 1
            If CheckBox2.Checked Then s = "null"
            Statement &= vbCrLf & "insert into " & tbl & "(BranchId,GroupId,InstractorId,StudentId,DayDate,Attendance,PrivateHours,PrivateMinits,UserName)values('" & Branch.SelectedValue.ToString & "','" & lblGroup.Text & "','" & lblInstractorId.Text & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & bm.ToStrDate(DateTimePicker1.Value) & "'," & s & ",'" & DataGridView1.Rows(i).Cells(6).Value & "','" & DataGridView1.Rows(i).Cells(7).Value & "'," & Module1.UserName & ")"
        Next

        If Not bm.ExcuteNonQuery(Statement) Then Return

        If sender Is Nothing Then Return
        bm.ShowMSG("Attendance Saved Successfully")
        GetTable()
    End Sub



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where Instractor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        FilterPanel(1, FLP1)
        FilterPanel(2, FLP2)
        FilterPanel(3, FLP3)
        FilterPanel(4, FLP4)
        FilterPanel(5, FLP5)
        FilterPanel(6, FLP6)
        FilterPanel(7, FLP7)
        FilterPanel(8, FLP8)
        FilterPanel(9, FLP9)
    End Sub

    Private Sub DepartmentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Categories", CategoryId, " where DepartmentId='" & s & "'")
    End Sub

    Private Sub CategoryId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryId.SelectedIndexChanged, Shift.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = CategoryId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Try
            bm.FillCombo("Items", Course, " where Course='1' and DepartmentId='" & s & "' and CategoryId='" & s1 & "'")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCourseSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourseSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Course Id"
        hh.SecondColumn = "Course Name"
        hh.Statement = "select cast(Id as varchar(100)) Id,Name from Items where Course='1' and DepartmentId='" & DepartmentId.SelectedValue.ToString & "' and CategoryId='" & CategoryId.SelectedValue.ToString & "'"
        hh.ShowDialog()
        Course.SelectedValue = hh.SelectedId
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim m As New MAIN
            If e.ColumnIndex = 2 Then
                Dim frm As New SubIncome
                frm.Text = m.menuitem31.Text
                frm.MdiParent = MainFrm
                frm.TopMost = True
                frm.Show()
                frm.Branch.SelectedValue = Branch.SelectedValue
                frm.txtStId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                frm.txtStId_Leave(Nothing, Nothing)
            ElseIf e.ColumnIndex = 3 Then
                Dim frm As New Installments
                frm.Text = m.menuitem32.Text
                frm.MdiParent = MainFrm
                frm.TopMost = True
                frm.Show()
                frm.Branch.SelectedValue = Branch.SelectedValue
                frm.InvoiceNo.Text = bm.ExecuteScalar("select top 1 InvoiceNo from Installments where BranchId='" & Branch.SelectedValue & "' and StudentId='" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "' and Haspayed=0 order by DayDate")
                frm.txtID_Leave(Nothing, Nothing)
            ElseIf e.ColumnIndex = 0 OrElse e.ColumnIndex = 1 Then
                Dim rpt As New ReportViewer(Text)
                rpt.Rpt = "StudentActivities.rpt"
                rpt.paraname = New String() {"@StudentId", "@BranchId", "@FromDate", "@ToDate", "@Flag"}
                rpt.paravalue = New String() {DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString, 0, Now.ToShortDateString, Now.ToShortDateString, 1}
                'rpt.SubReports = New String() {"Financial", "Tecnical"}
                rpt.ShowDialog()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub ViewAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAttendance.Click
        If Branch.SelectedIndex < 1 Or lblGroup.Text.Trim = "" Then Return
        btnSave_Click(Nothing, Nothing)
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "StudentsAttendance.rpt"
        rpt.paraname = New String() {"@BranchId", "@GroupId"}
        rpt.paravalue = New String() {Branch.SelectedValue.ToString, lblGroup.Text}
        rpt.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(4).Value = CheckBox1.Checked
        Next
    End Sub


    Private Sub Barcode_Enter(sender As Object, e As EventArgs) Handles Barcode.Enter
        If lop Then Return
        Barcode.Clear()
    End Sub

    Private Sub Barcode_LostFocus(sender As Object, e As EventArgs) Handles Barcode.LostFocus
        If lop Then Return
        Barcode.Text = "Scan here ..."
    End Sub


    Dim lop As Boolean = False
    Private Sub Barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles Barcode.KeyDown
        If e.KeyData = Keys.Enter Then
            e.Handled = True

            Dim dt As New DataTable

            dt = bm.ExcuteAdapter("GetGroupsPerStudent", {"Branch", "DayDate", "Barcode"}, {Val(Branch.SelectedValue.ToString), bm.ToStrDate(DateTimePicker1.Value), Barcode.Text})


            Dim dr As DataRow
            Select Case dt.Rows.Count
                Case 0
                    bm.ShowMSG("This student does NOT have any group today ..!")
                    Return
                Case 1
                    dr = dt.Select("")(0)
                Case Else
                    Dim hh As New HelpFourColumns
                    hh.FirstColumn = "Type"
                    hh.SecondColumn = "CourseName"
                    hh.ThirdColumn = "InstractorName"
                    hh.FourthColumn = "LectureNo"
                    hh.Statement = "exec GetGroupsPerStudent " & Branch.SelectedValue.ToString & ",'" & bm.ToStrDate(DateTimePicker1.Value) & "','" & Barcode.Text & "'"
                    lop = True
                    hh.ShowDialog()
                    lop = False
                    If hh.SelectedRow Is Nothing Then Return
                    'bm.ShowMSG(hh.SelectedRow.Cells(1).Value)
                    dr = dt.Select("Type='" & hh.SelectedRow.Cells(0).Value & "' and GroupId='" & hh.SelectedRow.Cells(1).Value & "'")(0)

            End Select


            If dr Is Nothing Then Return

            Dim tbl As String = "GroupsStudentsAttendance"
            If dr(0) = 1 Then tbl = "ReLectureStudentsAttendance"

            Dim MyStudentId As Integer = Val(bm.ExecuteScalar("select Id from Students where Barcode='" & Barcode.Text & "'"))

            If MyStudentId = 0 Then Return

            Dim Statement As String = "delete from " & tbl & " where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & dr(1) & "' and DayDate='" & bm.ToStrDate(DateTimePicker1.Value) & "' and StudentId=" & MyStudentId
            Statement &= vbCrLf & " insert into " & tbl & "(BranchId,GroupId,InstractorId,StudentId,DayDate,Attendance,PrivateHours,PrivateMinits,UserName)values('" & Branch.SelectedValue.ToString & "','" & dr(1) & "','" & 0 & "','" & MyStudentId & "','" & bm.ToStrDate(DateTimePicker1.Value) & "'," & 1 & ",'" & 0 & "','" & 0 & "'," & Module1.UserName & ")"


            If Not bm.ExcuteNonQuery(Statement) Then Return

            Barcode.BackColor = Color.Red
            Application.DoEvents()
            Threading.Thread.Sleep(500)
            Barcode.BackColor = Color.White
            Application.DoEvents()

            Barcode_Enter(Nothing, Nothing)

        End If
    End Sub

    Private Sub btnAddStudents_Click(sender As Object, e As EventArgs) Handles btnAddStudents.Click
        If btn Is Nothing Then Return
        Try
            Dim s As Integer = Val(bm.ExecuteScalar("select COUNT(distinct DayDate) from GroupsStudentsAttendance where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & lblGroup.Text & "'"))
            If s > 2 And Flag = 0 Then
                bm.ShowMSG("This Group took " & s & " Lectures till now")
                'If Not btn.Name = "btnImport" Then Return
            End If
        Catch ex As Exception
        End Try
        Dim frm As New GroupsStudents
        frm.Flag = Flag
        frm.SubTableName = "GroupsStudents"
        If Flag = 3 Then
            frm.SubTableName = "VirtualGroupsStudents"
        End If
        frm.BranchId = Branch.SelectedValue.ToString
        frm.GroupId = lblGroup.Text
        frm.DepartmentId = lblDepartmentId.Text
        frm.CategoryId = lblCategoryId.Text
        frm.Course = lblCourseId.Text
        frm.IsClosed = 0
        frm.btnTransfer.Enabled = False

        frm.MyDepartmentId = lblDepartmentId.Text
        frm.MyCategoryId = lblCategoryId.Text
        frm.MyCourse = lblCourseId.Text
        frm.Import = True
        frm.ShowDialog()

        btn_Click(btn, Nothing)

    End Sub


End Class