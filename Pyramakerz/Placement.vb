Public Class Placement


    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "Placement"
    Public MainId As String = "BranchId"
    Public SubId As String = "InvoiceNo"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 1
    ''' <summary>
    ''' Flag
    ''' 0 Placement
    ''' 1 Waiting
    ''' 2 Busy (student is in a group)
    ''' 
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' Income:              0→1
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' StudentMemberShip:   0→1
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' Groups:              1→2
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' Upgrade:             2→1
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' ReFund:              1→0
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' ''''''''''''''''''''''''''''''''''''''''''''
    ''' 
    ''' </summary>
    Private Sub SetupCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Flag = 0 Then
            lblCourse.Visible = False
            Course.Visible = False
            btnCourseSearch.Visible = False
        End If
        InvoiceNo.MaxLength = Length
        Delayed_CheckedChanged(Nothing, Nothing)
        bm.FillCombo(MainTableName, Branch, "")

        bm.FillCombo("Departments", DepartmentId, "")
        Dim v() As String = {"BranchId", "InvoiceNo", "StudentId", "DepartmentId", "CategoryId", "StLevel", "Shift1", "Shift2", "Shift3", "Shift4", "Days1", "Days2", "Days3", "Delayed", "DelayUntil", "Notes", "Flag", "UserName", "MyGetDate", "Course", "DayDate"}

        bm.Fields = v

        Dim c() As Control = {Branch, InvoiceNo, txtStId, DepartmentId, CategoryId, LevelId, Shift1, Shift2, Shift3, Shift4, Days1, Days2, Days3, Delayed, DelayUntil, Notes, txtFlag, UserName, MyGetDate, Course, DayDate}
        bm.control = c

        Dim k() As String = {MainId, SubId}
        bm.KeyFields = k

        bm.TableWhere = " Where Flag=" & Flag.ToString
        bm.AppendWhere = " and Flag=" & Flag.ToString

        bm.Table_Name = TableName
        btnNew_Click(sender, e)
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
        bm.NextPrevious(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, InvoiceNo.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Dim Generate As Boolean = False
    Dim EnableSave As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        EnableSave = False

        If Branch.SelectedIndex < 1 Then
            Return
        End If

        If txtStId.Text.Trim = "" Then
            bm.ShowMSG("Please, Select a Student ...")
            txtStId.Focus()
            Return
        End If

        If Course.Visible AndAlso Course.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select a Course ...")
            Course.Focus()
            Return
        End If


        If Not (Days1.Checked Or Days2.Checked Or Days3.Checked) Then
            bm.ShowMSG("Please, Select at least ONE Day ...")
            Return
        End If

        If Not (Shift1.Checked Or Shift2.Checked Or Shift3.Checked Or Shift4.Checked) Then
            bm.ShowMSG("Please, Select at least ONE Shift ...")
            Return
        End If


        'If bm.IF_Exists("select * from Placement where StudentId=" & txtStId.Text & " and DepartmentId=" & DepartmentId.SelectedValue.ToString & " and CategoryId=" & CategoryId.SelectedValue.ToString & " and Course=" & Course.SelectedValue.ToString & " and	Flag=1") Then
        If bm.IF_Exists("select * from Placement where StudentId=" & txtStId.Text & " and DepartmentId=" & DepartmentId.SelectedValue.ToString & " and	Flag=1") Then
            Select Case bm.RequestDelete("This Student is already waiting for this Department, Continue ...?")
                Case BasicMethods.CloseState.No, BasicMethods.CloseState.Cancel
                    Return
            End Select
        End If

        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
        If InvoiceNo.Text.Trim = "" Then
            InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            lblLastEntry.Text = InvoiceNo.Text
            lblLastEntry.BackColor = Color.Red
            Refresh()
            Threading.Thread.Sleep(200)
            Refresh()
            lblLastEntry.BackColor = System.Drawing.Color.FromArgb(192, 192, 0)
            State = BasicMethods.SaveState.Insert
        End If

        NewSave()

        If InvoiceNo.Text.Trim = "" Or Branch.SelectedIndex < 1 Then
            Return
        End If


        NewSave()

        bm.DefineValues()
        If Not bm.Save(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, InvoiceNo.Text.Trim}, State) Then
            If State = BasicMethods.SaveState.Insert Then
                InvoiceNo.Text = ""
                lblLastEntry.Text = ""
            End If
            Return
        End If


        bm.ExcuteNonQuery("CancelPlacement", New String() {"DayDate", "StudentId", "DepartmentId", "CategoryId", "Level"}, New String() {bm.ToStrDate(DayDate.Value), txtStId.Text, DepartmentId.SelectedValue.ToString, CategoryId.SelectedValue.ToString, LevelId.SelectedValue.ToString})


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
        ClearControls()
    End Sub
    Dim lop As Boolean = False
    Sub ClearControls()
        If lop Then Return
        Try
            Dim s As String = ""
            Try
                lop = True
                s = Branch.SelectedValue.ToString
                bm.ClearControls()
                Branch.SelectedValue = s
            Catch ex As Exception
            Finally
                lop = False
            End Try

            txtFlag.Text = Flag
            UserName.Text = Module1.UserName
            lblStName.Text = ""
            'Branch.SelectedValue = Module1.Branch
            InvoiceNo.Clear()
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            'If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            'InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            NewId()
            'OutcomeReason.Focus()
        Catch
        End Try
    End Sub

    Sub NewId()
        InvoiceNo.Clear()
        InvoiceNo.Enabled = False
    End Sub

    Sub UndoNewId()
        InvoiceNo.Enabled = True
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & InvoiceNo.Text.Trim & "' and " & MainId & " ='" & Branch.SelectedValue.ToString & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, InvoiceNo.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub
    Dim lv As Boolean = False
    Dim Retrive As Boolean = False
    Sub FillControls()
        UndoNewId()
        Retrive = True
        bm.FillControls()

        'txtStId_Leave(Nothing, Nothing)
        FillStName()

        Retrive = False
    End Sub
    Private Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNo.Leave
        If lv Then
            Return
        End If
        lv = True
        InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
        bm.DefineValues()
        Dim dt As New DataTable
        bm.RetrieveAll(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, InvoiceNo.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Branch.KeyDown, InvoiceNo.KeyDown, Notes.KeyDown, UserName.KeyDown, txtStId.KeyDown, Shift4.KeyDown, Shift3.KeyDown, Shift2.KeyDown, LevelId.KeyDown, DepartmentId.KeyDown, DelayUntil.KeyDown, Delayed.KeyDown, Days3.KeyDown, Days2.KeyDown, Days1.KeyDown, CategoryId.KeyDown, Shift1.KeyDown, DayDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InvoiceNo.KeyPress, txtStId.KeyPress
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




    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        Try
            lblStName.Text = ""
            If txtStId.Text.Trim = "" Then Return
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
        Catch ex As Exception
        End Try
        FillStName()
        StudentId_SelectedIndexChanged(Nothing, Nothing)
        CategoryId_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub StudentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            txtStId_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DepartmentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Categories", CategoryId, " where DepartmentId='" & s & "'")
    End Sub

    Private Sub CategoryId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryId.SelectedIndexChanged
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
            bm.FillCombo("CoursesLevels", LevelId, " where DepartmentId='" & s & "' and CategoryId='" & s1 & "'")

            LevelId.SelectedValue = bm.ExecuteScalar("select LevelId from StudentsLevels where StudentId='" & txtStId.Text & "' and DepartmentId='" & s & "' and CategoryId='" & s1 & "'")
            If LevelId.SelectedIndex < 1 Then
                LevelId.SelectedIndex = 1
            End If
        Catch ex As Exception

        End Try

        Try
            bm.FillCombo("Items", Course, " where Course='1' and DepartmentId='" & s & "' and CategoryId='" & s1 & "'")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Delayed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delayed.CheckedChanged
        If Delayed.Checked Then
            DelayUntil.Visible = True
            DelayUntil.Value = Now.AddDays(bm.GetDelayPeriod())
        Else
            DelayUntil.Value = Now
            DelayUntil.Visible = False
        End If
    End Sub

    Private Sub btnCourseSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourseSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Course Id"
        hh.SecondColumn = "Course Name"
        hh.Statement = "select cast(Id as varchar(100)) Id,Name from Items where Course='1' and DepartmentId='" & DepartmentId.SelectedValue.ToString & "' and CategoryId='" & CategoryId.SelectedValue.ToString & "'"
        hh.ShowDialog()
        Course.SelectedValue = hh.SelectedId
    End Sub
    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
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

    Private Sub btnGroupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupSearch.Click
        Dim hh As New HelpThreeColumns
        hh.FirstColumn = "InvoiceNo"
        hh.SecondColumn = "StudentId"
        hh.ThirdColumn = "Student EnName"
        hh.Statement = "select cast(InvoiceNo as varchar(10)) 'InvoiceNo',cast(StudentId as varchar(10)) 'StudentId',dbo.GetStudentEnName(StudentId) 'EnName' from Placement where BranchId=" & Branch.SelectedValue.ToString & " and Flag=" & Flag.ToString
        hh.ShowDialog()
        InvoiceNo.Text = hh.SelectedId
        txtID_Leave(Nothing, Nothing)
    End Sub
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class