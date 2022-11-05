Public Class Evaluation

    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "Evaluation"
    Public MainId As String = "BranchId"
    Public SubId As String = "Id"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub Evaluation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl1.Controls.Remove(TabPage2)

        Id.MaxLength = Length

        bm.FillCombo(MainTableName, Branch, "")

        Dim v() As String = {"BranchId", "Id", "UserName", "MyGetDate", "GroupId", "StudentId", "DayDate", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10", "R11", "R12", "R13", "R14", "R15", "note1", "note2", "note3", "note4", "note5", "note6", "note7", "CabdidateName1", "CabdidateJob1", "CabdidateAddress1", "CabdidateMobile1", "CabdidateName2", "CabdidateJob2", "CabdidateAddress2", "CabdidateMobile2", "CabdidateName3", "CabdidateJob3", "CabdidateAddress3", "CabdidateMobile3"}
        bm.Fields = v

        Dim c() As Control = {Branch, Id, UserName, MyGetDate, GroupId, txtStId, DayDate, R1, R2, R3, R4, R5, R6, R7, R8, R9, R10, R11, R12, R13, R14, R15, note1, note2, note3, note4, note5, note6, note7, CabdidateName1, CabdidateJob1, CabdidateAddress1, CabdidateMobile1, CabdidateName2, CabdidateJob2, CabdidateAddress2, CabdidateMobile2, CabdidateName3, CabdidateJob3, CabdidateAddress3, CabdidateMobile3}
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

    Dim Generate As Boolean = False
    Dim EnableSave As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Branch.SelectedIndex < 1 Or GroupId.Text = "" Or txtStId.Text.Trim = "" Then Return
        If Not TestSave() Then Return

        EnableSave = False

        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
        If Id.Text.Trim = "" Then
            Id.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            If Id.Text = "" Then Id.Text = "1"
            Id.Text = Id.Text.Trim.PadLeft(Length, "0")
            lblLastEntry.Text = Id.Text
            lblLastEntry.BackColor = Color.Red
            Refresh()
            Threading.Thread.Sleep(200)
            Refresh()
            lblLastEntry.BackColor = System.Drawing.Color.FromArgb(192, 192, 0)
            State = BasicMethods.SaveState.Insert
        Else
            bm.TestMistakeOrUpdate(UserName.Text, Name)
        End If

        NewSave()

        If Id.Text.Trim = "" Or Branch.SelectedIndex < 1 Then
            Return
        End If


        NewSave()

        bm.DefineValues()
        If Not bm.Save(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, Id.Text.Trim}, State) Then
            If State = BasicMethods.SaveState.Insert Then
                Id.Text = ""
                lblLastEntry.Text = ""
            End If
            Return
        End If
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

            For Each c As Control In Controls
                Clear(c)
            Next

            UserName.Text = Module1.UserName
            'Branch.SelectedValue = Module1.Branch
            Id.Clear()
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            'If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            'InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            NewId()
            lblStName.Text = ""
            'OutcomeReason.Focus()
        Catch
        End Try
    End Sub

    Sub Clear(ByVal c As Control)
        If c.GetType.ToString = "System.Windows.Forms.RadioButton" Then
            Dim rdo As RadioButton = c
            rdo.Checked = False
        ElseIf c.GetType.ToString = "System.Windows.Forms.TextBox" Then
            Dim txt As TextBox = c
            txt.Clear()
        End If
        For Each cc As Control In c.Controls
            Clear(cc)
        Next
    End Sub

    Sub NewId()
        Id.Clear()
        Id.Enabled = False
    End Sub

    Sub UndoNewId()
        Id.Enabled = True
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & Id.Text.Trim & "' and " & MainId & " ='" & Branch.SelectedValue.ToString & "'")
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
        UndoNewId()
        Retrive = True
        bm.FillControls()
        Retrive = False
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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Branch.KeyDown, Id.KeyDown, UserName.KeyDown, DayDate.KeyDown, GroupId.KeyDown, note1.KeyDown, note2.KeyDown, note3.KeyDown, note4.KeyDown, CabdidateName1.KeyDown, CabdidateJob1.KeyDown, CabdidateAddress1.KeyDown, CabdidateMobile1.KeyDown, CabdidateName2.KeyDown, CabdidateJob2.KeyDown, CabdidateAddress2.KeyDown, CabdidateMobile2.KeyDown, CabdidateName3.KeyDown, CabdidateJob3.KeyDown, CabdidateAddress3.KeyDown, CabdidateMobile3.KeyDown, txtStId.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id.KeyPress, txtStId.KeyPress
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




    Private Sub GroupId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupId.Leave
        If GroupId.Text.Trim = "" Then Return
        GroupId.Text = GroupId.Text.Trim.PadLeft(0, "0")
        Dim dt As DataTable = bm.ExcuteAdapter("select * from Groups where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & GroupId.Text & "'")
        If dt.Rows.Count = 0 Then GroupId.Clear()

        'FillStudents()
        GetId()
    End Sub

    'Sub FillStudents()
    '    bm.FillCombo("select Att.StudentId Id,St.EnName Name,COUNT(Att.StudentId)cnt from GroupsStudentsAttendance Att left join Students St on(Att.StudentId=St.ID) where Att.BranchId='" & Branch.SelectedValue.ToString & "' and Att.GroupId='" & GroupId.Text & "' and Att.Attendance=1 group by Att.StudentId,St.EnName having COUNT(Att.StudentId)>2 union select 0 Id,'-' Name,0 cnt", StudentId)
    'End Sub
    Private Sub btnGroupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupSearch.Click
        Dim hh As New GroupsSearch
        hh.Branch = Branch.SelectedValue.ToString
        hh.ShowDialog()
        GroupId.Text = hh.SelectedId
        'FillStudents()
    End Sub

    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Dim frm As New StSearch
        frm.TableWhere = "  where Id in (select Id from(select Att.StudentId Id,St.EnName Name,COUNT(Att.StudentId)cnt from GroupsStudentsAttendance Att left join Students St on(Att.StudentId=St.ID) where Att.BranchId='" & Branch.SelectedValue.ToString & "' and Att.GroupId='" & GroupId.Text & "' and Att.Attendance=1 group by Att.StudentId,St.EnName having COUNT(Att.StudentId)>2)tt)"
        frm.ShowDialog()
        txtStId.Text = frm.StudentId
        txtStId_Leave(Nothing, Nothing)
    End Sub

    Private Sub txt_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.TextChanged, R2.TextChanged, R3.TextChanged, R4.TextChanged, R5.TextChanged, R6.TextChanged, R7.TextChanged, R8.TextChanged, R9.TextChanged, R10.TextChanged, R11.TextChanged, R12.TextChanged, R13.TextChanged, R14.TextChanged, R15.TextChanged
        Try
            Dim txt As TextBox = sender
            Dim r() = Controls.Find(txt.Name & "_" & txt.Text, True)
            Dim rdo As RadioButton = r(0)
            rdo.Checked = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rdo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1_0.CheckedChanged, R1_10.CheckedChanged, R1_20.CheckedChanged, R1_30.CheckedChanged, R1_40.CheckedChanged, R1_50.CheckedChanged, R1_60.CheckedChanged, R1_70.CheckedChanged, R1_80.CheckedChanged, R1_90.CheckedChanged, R1_100.CheckedChanged, R2_0.CheckedChanged, R2_10.CheckedChanged, R2_20.CheckedChanged, R2_30.CheckedChanged, R2_40.CheckedChanged, R2_50.CheckedChanged, R2_60.CheckedChanged, R2_70.CheckedChanged, R2_80.CheckedChanged, R2_90.CheckedChanged, R2_100.CheckedChanged, R3_0.CheckedChanged, R3_10.CheckedChanged, R3_20.CheckedChanged, R3_30.CheckedChanged, R3_40.CheckedChanged, R3_50.CheckedChanged, R3_60.CheckedChanged, R3_70.CheckedChanged, R3_80.CheckedChanged, R3_90.CheckedChanged, R3_100.CheckedChanged, R4_0.CheckedChanged, R4_10.CheckedChanged, R4_20.CheckedChanged, R4_30.CheckedChanged, R4_40.CheckedChanged, R4_50.CheckedChanged, R4_60.CheckedChanged, R4_70.CheckedChanged, R4_80.CheckedChanged, R4_90.CheckedChanged, R4_100.CheckedChanged, R5_0.CheckedChanged, R5_10.CheckedChanged, R5_20.CheckedChanged, R5_30.CheckedChanged, R5_40.CheckedChanged, R5_50.CheckedChanged, R5_60.CheckedChanged, R5_70.CheckedChanged, R5_80.CheckedChanged, R5_90.CheckedChanged, R5_100.CheckedChanged, R6_0.CheckedChanged, R6_10.CheckedChanged, R6_20.CheckedChanged, R6_30.CheckedChanged, R6_40.CheckedChanged, R6_50.CheckedChanged, R6_60.CheckedChanged, R6_70.CheckedChanged, R6_80.CheckedChanged, R6_90.CheckedChanged, R6_100.CheckedChanged, R7_0.CheckedChanged, R7_10.CheckedChanged, R7_20.CheckedChanged, R7_30.CheckedChanged, R7_40.CheckedChanged, R7_50.CheckedChanged, R7_60.CheckedChanged, R7_70.CheckedChanged, R7_80.CheckedChanged, R7_90.CheckedChanged, R7_100.CheckedChanged, R8_0.CheckedChanged, R8_10.CheckedChanged, R8_20.CheckedChanged, R8_30.CheckedChanged, R8_40.CheckedChanged, R8_50.CheckedChanged, R8_60.CheckedChanged, R8_70.CheckedChanged, R8_80.CheckedChanged, R8_90.CheckedChanged, R8_100.CheckedChanged, R9_0.CheckedChanged, R9_10.CheckedChanged, R9_20.CheckedChanged, R9_30.CheckedChanged, R9_40.CheckedChanged, R9_50.CheckedChanged, R9_60.CheckedChanged, R9_70.CheckedChanged, R9_80.CheckedChanged, R9_90.CheckedChanged, R9_100.CheckedChanged, R10_0.CheckedChanged, R10_10.CheckedChanged, R10_20.CheckedChanged, R10_30.CheckedChanged, R10_40.CheckedChanged, R10_50.CheckedChanged, R10_60.CheckedChanged, R10_70.CheckedChanged, R10_80.CheckedChanged, R10_90.CheckedChanged, R10_100.CheckedChanged, R11_0.CheckedChanged, R11_10.CheckedChanged, R11_20.CheckedChanged, R11_30.CheckedChanged, R11_40.CheckedChanged, R11_50.CheckedChanged, R11_60.CheckedChanged, R11_70.CheckedChanged, R11_80.CheckedChanged, R11_90.CheckedChanged, R11_100.CheckedChanged, R12_0.CheckedChanged, R12_10.CheckedChanged, R12_20.CheckedChanged, R12_30.CheckedChanged, R12_40.CheckedChanged, R12_50.CheckedChanged, R12_60.CheckedChanged, R12_70.CheckedChanged, R12_80.CheckedChanged, R12_90.CheckedChanged, R12_100.CheckedChanged, R13_0.CheckedChanged, R13_10.CheckedChanged, R13_20.CheckedChanged, R13_30.CheckedChanged, R13_40.CheckedChanged, R13_50.CheckedChanged, R13_60.CheckedChanged, R13_70.CheckedChanged, R13_80.CheckedChanged, R13_90.CheckedChanged, R13_100.CheckedChanged, R14_0.CheckedChanged, R14_10.CheckedChanged, R14_20.CheckedChanged, R14_30.CheckedChanged, R14_40.CheckedChanged, R14_50.CheckedChanged, R14_60.CheckedChanged, R14_70.CheckedChanged, R14_80.CheckedChanged, R14_90.CheckedChanged, R14_100.CheckedChanged, R15_0.CheckedChanged, R15_10.CheckedChanged, R15_20.CheckedChanged, R15_30.CheckedChanged, R15_40.CheckedChanged, R15_50.CheckedChanged, R15_60.CheckedChanged, R15_70.CheckedChanged, R15_80.CheckedChanged, R15_90.CheckedChanged, R15_100.CheckedChanged

        Try
            Dim rdo As RadioButton = sender
            If Not rdo.Checked Then Return
            Dim n() As String = rdo.Name.Split("_")
            Dim r() = Controls.Find(n(0), True)
            Dim txt As TextBox = r(0)
            txt.Text = n(1)
        Catch ex As Exception

        End Try

    End Sub

    Function TestSave() As Boolean
        'Or R6.Text = "" Or R7.Text = "" Or R8.Text = ""  Or R12.Text = ""
        If R1.Text = "" Or R2.Text = "" Or R3.Text = "" Or R4.Text = "" Or R5.Text = "" Or R9.Text = "" Or R10.Text = "" Or R11.Text = "" Or R13.Text = "" Or R14.Text = "" Or R15.Text = "" Then
            bm.ShowMSG("Please, Fill all questions ...")
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub GroupId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupId.TextChanged
        If Retrive Then Return
        'GroupId_Leave(Nothing, Nothing)

    End Sub
    Sub GetId()
        Dim s As String = bm.ExecuteScalar("select Id from Evaluation where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & GroupId.Text & "' and StudentId='" & txtStId.Text & "'")
        If s = "" Then
            NewId()
            For Each c As Control In TabControl1.Controls
                Clear(c)
            Next
        Else
            Id.Text = s
            txtID_Leave(Nothing, Nothing)
        End If
    End Sub

    Private Sub StudentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetId()
       
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
    End Sub


    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
    End Sub

    Private Sub txtStId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.TextChanged
        'If txtStId.Text.Length = 6 Then
        'txtStId_Leave(Nothing, Nothing)
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