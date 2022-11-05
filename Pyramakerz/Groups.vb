Public Class Groups

    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "Groups"
    Public SubTableName As String = "GroupsStudents"
    Public MainId As String = "BranchId"
    Public SubId As String = "Id"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub Groups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCbo()
        Id.MaxLength = Length
        If Flag = 1 Then
            TableName = "VirtualGroups"
            SubTableName = "VirtualGroupsStudents"
            btnImport.Visible = False
            ReLecture.Visible = False
            Label2.Visible = False
            Label8.Visible = False
            Closed.Visible = False
            Upgraded.Visible = False
        End If


        bm.FillCombo(MainTableName, Branch, "")
        Branch.SelectedValue = Module1.Branch
        bm.FillCombo("Departments", DepartmentId, "")
        bm.FillCombo("select Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)


        Dim v() As String = {"BranchId", "Id", "UserName", "MyGetDate", "DepartmentId", "CategoryId", "Course", "Instractor", "DayDate", "Days", "Intensive", "NoOfHours", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "LectureNo", "ChekPrivate", "Notes", "Closed", "PrivateHours", "PrivateMinits", "ReLecture", "Upgraded", "CloseDate", "UpgradeDate"}
        bm.Fields = v

        Dim c() As Control = {Branch, Id, UserName, MyGetDate, DepartmentId, CategoryId, Course, Instractor, DayDate, Days, Intensive, NoOfHours, Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, LectureNo, ChekPrivate, Notes, Closed, PrivateHours, PrivateMinits, ReLecture, Upgraded, CloseDate, UpgradeDate}
        bm.control = c

        Dim k() As String = {MainId, SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName
        btnNew_Click(sender, e)
        Intensive_CheckedChanged(Nothing, Nothing)
        ChekPrivate_CheckedChanged(Nothing, Nothing)
        Branch.SelectedValue = Module1.Branch
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.FirstLast(New String() {MainId, SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, Id.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        EnableSave = False

        If Id.Text.Trim = "" Or Branch.SelectedIndex < 1 Then
            Return
        End If
        If LectureNo.SelectedIndex + NoOfHours.SelectedIndex > 10 Then
            bm.ShowMSG("Lecture No. isn't compatable with No. Of Hours ...")
            DepartmentId.Focus()
            Return
        End If

        If DepartmentId.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select a Department ...")
            DepartmentId.Focus()
            Return
        End If

        If CategoryId.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select a Category ...")
            CategoryId.Focus()
            Return
        End If

        If Course.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select a Course ...")
            Course.Focus()
            Return
        End If

        If Instractor.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select an Instractor ...")
            Instractor.Focus()
            Return
        End If

        If Intensive.Checked Or ReLecture.Checked Then
            If NoOfHours.SelectedIndex < 1 Then
                bm.ShowMSG("Please, Select No. Of Hours ...")
                NoOfHours.Focus()
                Return
            End If
            If Not (Saturday.Checked Or Sunday.Checked Or Monday.Checked Or Tuesday.Checked Or Wednesday.Checked Or Thursday.Checked Or Friday.Checked) Then
                bm.ShowMSG("Please, Select at least ONE DAY ...")
                Saturday.Focus()
                Return
            End If
        Else
            If Days.SelectedIndex < 1 Then
                bm.ShowMSG("Please, Select Days ...")
                Days.Focus()
                Return
            End If
        End If


        If LectureNo.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select a LectureNo ...")
            LectureNo.Focus()
            Return
        End If

        If Not btnSave.Enabled Then
            EnableSave = True
            Return
        End If

        NewSave()
        If PrivateHours.Text.Trim = "" Then
            PrivateHours.Text = 0
        End If
        If PrivateMinits.Text.Trim = "" Then
            PrivateMinits.Text = 0
        End If

        bm.DefineValues()
        If Not bm.Save(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, Id.Text.Trim}) Then Return

        EnableSave = True

        If Not Generate Then
            btnNew_Click(sender, e)
        End If
        AllowClose = True
    End Sub
    Sub NewSave()
        UserName.Text = Module1.UserName
        UserName.BackColor = Color.Red
        UserName.ForeColor = Color.Blue
        Refresh()
        Threading.Thread.Sleep(200)
        UserName.BackColor = Color.White
        UserName.ForeColor = Color.Red
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        bm.FirstLast(New String() {MainId, SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim s As String = ""
        Try
            s = Branch.SelectedValue.ToString
        Catch ex As Exception
        End Try

        bm.ClearControls()
        Branch.SelectedValue = s
        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            UserName.Text = Module1.UserName
            'Branch.SelectedValue = Module1.Branch
            Id.Clear()
            Id.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            If Id.Text = "" Then Id.Text = "1"
            Id.Text = Id.Text.Trim.PadLeft(Length, "0")
            '            MainInvoiceNo.Focus()
        Catch
        End Try
        If Flag = 0 Then bm.ApplySecurity(New Button() {btnSave, btnDelete, btnImport}, True, True, True, True, False, False, False, True, True)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & Id.Text.Trim & "' and " & MainId & " ='" & Branch.SelectedValue.ToString & "'            delete from " & SubTableName & " where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & Id.Text.Trim & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, Id.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub
    Dim lv As Boolean = False
    Dim Retrive As Boolean = False
    Sub FillControls()
        Retrive = True
        bm.FillControls()
        Retrive = False
        If Flag = 0 Then bm.ApplySecurity(New Button() {btnSave, btnDelete, btnImport}, False, True, True, True, False, False, False, True, True)
    End Sub
    Public Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id.Leave
        If lv Then
            Return
        End If
        lv = True
        Id.Text = Id.Text.Trim.PadLeft(Length, "0")
        bm.DefineValues()
        Dim dt As New DataTable
        bm.RetrieveAll(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, Id.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Branch.KeyDown, UserName.KeyDown, Id.KeyDown, DepartmentId.KeyDown, CategoryId.KeyDown, Course.KeyDown, Instractor.KeyDown, DayDate.KeyDown, Days.KeyDown, Intensive.KeyDown, NoOfHours.KeyDown, Saturday.KeyDown, Sunday.KeyDown, Monday.KeyDown, Tuesday.KeyDown, Wednesday.KeyDown, Thursday.KeyDown, Friday.KeyDown, LectureNo.KeyDown, ChekPrivate.KeyDown, Notes.KeyDown, Closed.KeyDown, PrivateMinits.KeyDown, PrivateHours.KeyDown, Upgraded.KeyDown, UpgradeDate.KeyDown, CloseDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id.KeyPress, PrivateHours.KeyPress, PrivateMinits.KeyPress
        If e.KeyChar = "" OrElse Asc(e.KeyChar.ToString.Substring(0)) = 22 OrElse Asc(e.KeyChar.ToString.Substring(0)) = 3 Then
            Return
        End If
        Dim s As New TextBox
        s = sender
        'If e.KeyChar = "." And Not s.Text.Contains(".") Then
        '    Return
        'End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Dim loplop As Boolean = False
    Private Sub CboMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.SelectedIndexChanged
        If loplop Then Return
        loplop = True
        Dim i As Integer = Branch.SelectedIndex
        ClearControls()
        Branch.SelectedIndex = i
        loplop = False
    End Sub

    Private Sub Department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Categories", CategoryId, " where DepartmentId='" & s & "'")
    End Sub

    Private Sub Category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryId.SelectedIndexChanged
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
        bm.FillCombo("Items", Course, " where Course='1' and DepartmentId='" & s & "' and CategoryId='" & s1 & "'")
    End Sub

    Private Sub btnCourseSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourseSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Course Id"
        hh.SecondColumn = "Course Name"
        hh.Statement = "select cast(Id as varchar(100)) Id,Name from Items where Course='1' and DepartmentId='" & DepartmentId.SelectedValue.ToString & "' and CategoryId='" & CategoryId.SelectedValue.ToString & "'"
        hh.ShowDialog()
        Course.SelectedValue = hh.SelectedId
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where Instractor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub Intensive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Intensive.CheckedChanged, ReLecture.CheckedChanged
        If Intensive.Checked Or ReLecture.Checked Then
            NoOfHours.Visible = True
            Saturday.Visible = True
            Sunday.Visible = True
            Monday.Visible = True
            Tuesday.Visible = True
            Wednesday.Visible = True
            Thursday.Visible = True
            Friday.Visible = True
            lblDays.Visible = False
            Days.Visible = False
            Days.SelectedIndex = 0
        Else
            NoOfHours.Visible = False
            Saturday.Visible = False
            Sunday.Visible = False
            Monday.Visible = False
            Tuesday.Visible = False
            Wednesday.Visible = False
            Thursday.Visible = False
            Friday.Visible = False

            NoOfHours.SelectedIndex = 0
            Saturday.Checked = False
            Sunday.Checked = False
            Monday.Checked = False
            Tuesday.Checked = False
            Wednesday.Checked = False
            Thursday.Checked = False
            Friday.Checked = False

            lblDays.Visible = True
            Days.Visible = True
        End If
    End Sub

    Private Sub btnGroupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupSearch.Click
        Dim hh As New GroupsSearch
        hh.TableName = TableName
        hh.Branch = Branch.SelectedValue.ToString
        hh.ShowDialog()
        Id.Text = hh.SelectedId
        txtID_Leave(Nothing, Nothing)
    End Sub

    Dim Generate As Boolean = False
    Dim EnableSave As Boolean = False
    Private Sub btnGenerateStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateStudents.Click, btnImport.Click
        Dim btn As Button = sender
        Try
            Dim s As Integer = Val(bm.ExecuteScalar("select COUNT(distinct DayDate) from GroupsStudentsAttendance where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & Id.Text & "'"))
            If s > 2 And Flag = 0 Then
                bm.ShowMSG("This Group took " & s & " Lectures till now")
                If Not btn.Name = "btnImport" Then Return
            End If
        Catch ex As Exception
        End Try
        Generate = True
        btnSave_Click(Nothing, Nothing)
        Generate = False
        If Not EnableSave Then Return


        Dim frm As New GroupsStudents
        frm.Flag = Flag
        frm.SubTableName = SubTableName
        frm.BranchId = Branch.SelectedValue.ToString
        frm.GroupId = Id.Text
        frm.DepartmentId = DepartmentId.SelectedValue.ToString
        frm.CategoryId = CategoryId.SelectedValue.ToString
        frm.Course = Course.SelectedValue.ToString
        frm.IsClosed = Closed.Checked
        frm.btnTransfer.Enabled = btnImport.Enabled

        frm.MyDepartmentId = DepartmentId.SelectedValue
        frm.MyCategoryId = CategoryId.SelectedValue
        frm.MyCourse = Course.SelectedValue

        If btn.Name = "btnImport" Then
            frm.Import = True
        End If
        frm.ShowDialog()

        'If Flag = 0 Then
        '    Dim frm As New GroupsStudents
        '    frm.Flag = Flag
        '    frm.SubTableName = SubTableName
        '    frm.BranchId = Branch.SelectedValue.ToString
        '    frm.GroupId = Id.Text
        '    frm.DepartmentId = DepartmentId.SelectedValue.ToString
        '    frm.CategoryId = CategoryId.SelectedValue.ToString
        '    frm.Course = Course.SelectedValue.ToString
        '    frm.IsClosed = Closed.Checked
        '    frm.btnTransfer.Enabled = btnImport.Enabled
        '    If btn.Name = "btnImport" Then
        '        frm.Import = True
        '    End If
        '    frm.ShowDialog()
        'ElseIf Flag = 1 Then
        '    Dim frm As New VirtualGroupsStudents
        '    frm.Flag = Flag
        '    frm.SubTableName = SubTableName
        '    frm.BranchId = Branch.SelectedValue.ToString
        '    frm.GroupId = Id.Text
        '    frm.DepartmentId = DepartmentId.SelectedValue.ToString
        '    frm.CategoryId = CategoryId.SelectedValue.ToString
        '    frm.Course = Course.SelectedValue.ToString
        '    frm.IsClosed = Closed.Checked
        '    If btn.Name = "btnImport" Then
        '        frm.Import = True
        '    End If
        '    frm.ShowDialog()
        'End If

    End Sub



    Private Sub ChekPrivate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChekPrivate.CheckedChanged
        If ChekPrivate.Checked Then
            PrivateHours.Visible = True
            lblPrivateHours.Visible = True
            PrivateMinits.Visible = True
            lblPrivateMinits.Visible = True
        Else
            PrivateHours.Visible = False
            PrivateHours.Clear()
            lblPrivateHours.Visible = False

            PrivateMinits.Visible = False
            PrivateMinits.Clear()
            lblPrivateMinits.Visible = False
        End If
    End Sub

    Private Sub PrivateMinits_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivateMinits.Leave
        If Val(PrivateMinits.Text) >= 60 Then
            PrivateMinits.Clear()
        End If
    End Sub

    Dim AllowClose As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not btnSave.Enabled Then Exit Sub
        Select Case bm.RequestDelete
            Case BasicMethods.CloseState.Yes
                AllowClose = False
                btnSave_Click(Nothing, Nothing)
                If Not AllowClose Then e.Cancel = True
            Case BasicMethods.CloseState.No

            Case BasicMethods.CloseState.Cancel
                e.Cancel = True
        End Select
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Generate = True
        btnSave_Click(Nothing, Nothing)
        Generate = False
        If Not EnableSave Then Return
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = IIf(Flag = 0, "GroupStudents.rpt", "VirtualGroupStudents.rpt")
        rpt.paraname = New String() {"@BranchId", "@GroupId"}
        rpt.paravalue = New String() {Branch.SelectedValue.ToString, Id.Text.Trim}
        rpt.ShowDialog()
    End Sub

    Private Sub LoadCbo()
        Dim dt As DataTable = bm.ExcuteAdapter("select dbo.GetLecturesCount(),dbo.GetLectureHours()")
        NoOfHours.Items.Add("")
        Try
            Dim x As Decimal = Val(dt.Rows(0)(0))
            Dim y As Decimal = Val(dt.Rows(0)(1))
            For i As Integer = 0 To x - 1
                NoOfHours.Items.Add(((i + 1) * y).ToString & " Hours")
            Next
        Catch ex As Exception
        End Try

    End Sub


    Private Sub Closed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Closed.CheckedChanged
        CloseDate.Visible = Closed.Checked
    End Sub

    Private Sub Upgraded_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Upgraded.CheckedChanged
        UpgradeDate.Visible = Upgraded.Checked
    End Sub


End Class