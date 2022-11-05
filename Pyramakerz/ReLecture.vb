Public Class ReLecture

    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "ReLecture"
    Public MainId As String = "BranchId"
    Public SubId As String = "Id"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub Groups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Branch.SelectedValue = Module1.Branch
        Id.MaxLength = Length

        bm.FillCombo(MainTableName, Branch, "")

        bm.FillCombo("select Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)


        Dim v() As String = {"BranchId", "Id", "UserName", "MyGetDate", "Instractor", "StudentId", "DayDate", "LectureNo", "Notes", "PrivateHours", "PrivateMinits", "MainInvNo"}
        bm.Fields = v

        Dim c() As Control = {Branch, Id, UserName, MyGetDate, Instractor, txtStId, DayDate, LectureNo, Notes, PrivateHours, PrivateMinits, MainInvNo}
        bm.control = c

        Dim k() As String = {MainId, SubId}
        bm.KeyFields = k

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
        bm.NextPrevious(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, Id.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Id.Text.Trim = "" Or Branch.SelectedIndex < 1 Or MainInvNo.SelectedIndex < 0 Then
            Return
        End If


        If Instractor.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select an Instractor ...")
            Instractor.Focus()
            Return
        End If


        If LectureNo.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select a LectureNo ...")
            LectureNo.Focus()
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

        btnNew_Click(sender, e)
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
        MainInvNo.DataSource = Nothing
        lblStName.Text = ""
        Branch.SelectedValue = s
        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            UserName.Text = Module1.UserName
            Dim s As String = Branch.SelectedValue
            bm.ClearControls()
            Branch.SelectedValue = s
            Id.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            If Id.Text = "" Then Id.Text = "1"
            Id.Text = Id.Text.Trim.PadLeft(Length, "0")
            '            MainInvoiceNo.Focus()
        Catch
        End Try
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, True, True, True, True, False, False, False, True, True)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & Id.Text.Trim & "' and " & MainId & " ='" & Branch.SelectedValue.ToString & "'            delete from GroupsStudents where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & Id.Text.Trim & "'")
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
        FillStName()
        Retrive = False
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, False, True, True, True, False, False, False, True, True)
    End Sub
    Private Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id.Leave
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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Branch.KeyDown, UserName.KeyDown, Id.KeyDown, txtStId.KeyDown, PrivateMinits.KeyDown, PrivateHours.KeyDown, Notes.KeyDown, LectureNo.KeyDown, Instractor.KeyDown, DayDate.KeyDown, MainInvNo.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id.KeyPress, PrivateHours.KeyPress, PrivateMinits.KeyPress, txtStId.KeyPress
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
        ClearControls()
        loplop = False
    End Sub



    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where Instractor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

  
    Private Sub btnGroupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupSearch.Click
        Dim hh As New HelpThreeColumns
        hh.FirstColumn = "Id"
        hh.SecondColumn = "Instructor EnName"
        hh.ThirdColumn = "Student EnName"
        hh.Statement = "select cast(R.Id as varchar(10)) 'Id',E.EnName,S.EnName from ReLecture R left join Employees E on(E.Id=R.Instractor) left join Students S on(R.StudentId=S.ID) where R.BranchId='" & Branch.SelectedValue.ToString & "'"
        hh.ShowDialog()
        Id.Text = hh.SelectedId
        txtID_Leave(Nothing, Nothing)
    End Sub


    Private Sub PrivateMinits_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivateMinits.Leave
        If Val(PrivateMinits.Text) >= 60 Then
            PrivateMinits.Clear()
        End If
    End Sub

    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        Try
            If txtStId.Text.Trim = "" Then
                lblStName.Text = ""
                Return
            End If
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
            FillStName()
            FillMainInvNo()
        Catch ex As Exception
        End Try
    End Sub

    Sub FillMainInvNo()
        bm.FillCombo("select InvoiceNo 'Id',InvoiceNo 'Name' from Income where Relecture='1' and StudentId='" & txtStId.Text & "' and InvoiceNo not in (select distinct MainInvNo from ReLecture where Id<>'" & Id.Text & "' and MainInvNo is not null)", MainInvNo)
    End Sub
    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            FillStName()
        Catch ex As Exception
        End Try
    End Sub
    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
    End Sub

    Private Sub txtStId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.TextChanged
        'If txtStId.Text.Length = 6 Then
        FillMainInvNo()
        'End If
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
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class