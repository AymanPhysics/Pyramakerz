Public Class DirectBonusCut

    Public TableName As String = ""
    Public SubId As String = "Id"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0

    Private Sub DirectBonusCut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsVal.SelectedIndex = 0
        IsVal_SelectedIndexChanged(Nothing, Nothing)
        bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Employee)
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)

        txtID.MaxLength = Length
        Dim v() As String = {SubId, "BranchId", "EmpId", "DayDate", "UserName", "MyGetDate", "hh", "mm", "Reason", "IsVal", "value"}
        bm.Fields = v
        Dim c() As Control = {txtID, Branch, Employee, DayDate, UserName, MyGetDate, hh, mm, Reason, IsVal, value}
        bm.control = c

        Dim k() As String = {SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName

        btnNew_Click(sender, e)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.FirstLast(New String() {SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {SubId}, New String() {txtID.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Branch.SelectedValue.ToString = 0 Or Employee.SelectedValue.ToString = 0 Then
            Return
        End If
        If hh.Text.Trim = "" Then
            hh.Text = 0
        End If
        If mm.Text.Trim = "" Then
            mm.Text = 0
        End If
        If value.Text.Trim = "" Then
            value.Text = 0
        End If

        NewSave()

        bm.DefineValues()
        If Not bm.Save(New String() {SubId}, New String() {txtID.Text.Trim}) Then Return
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

        bm.FirstLast(New String() {SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Sub FillControls()
        bm.FillControls()
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, False, True, True, False, True, False, True, True, True)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        bm.ClearControls()
        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            bm.ClearControls()
            UserName.Text = Module1.UserName
            txtID.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName)
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            Branch.Focus()
        Catch ex As Exception
        End Try
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, True, True, True, False, True, False, True, True, True)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & txtID.Text.Trim & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {SubId}, New String() {txtID.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub
    Dim lv As Boolean = False
    Private Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Leave
        If lv Then
            Return
        End If
        lv = True
        txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
        bm.DefineValues()
        Dim dt As New DataTable
        bm.RetrieveAll(New String() {SubId}, New String() {txtID.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
        'txtName.Text = dt(0)("Name")
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown, Branch.KeyDown, Employee.KeyDown, DayDate.KeyDown, hh.KeyDown, mm.KeyDown, IsVal.KeyDown, value.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress, hh.KeyPress, mm.KeyPress
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

    Private Sub IsVal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsVal.SelectedIndexChanged
        Label6.Text = IsVal.Text
        Select Case IsVal.SelectedIndex
            Case 0
                value.Visible = False
                hh.Visible = True
                mm.Visible = True
                lblPrivateHours.Visible = True
                lblPrivateMinits.Visible = True
                value.Text = 0
            Case 1
                value.Visible = True
                hh.Visible = False
                mm.Visible = False
                lblPrivateHours.Visible = False
                lblPrivateMinits.Visible = False
                hh.Text = 0
                mm.Text = 0
        End Select
    End Sub

    Private Sub value_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles value.KeyPress
        If e.KeyChar = "" OrElse Asc(e.KeyChar.ToString.Substring(0)) = 22 OrElse Asc(e.KeyChar.ToString.Substring(0)) = 3 Then
            Return
        End If
        Dim s As New TextBox
        s = sender
        If e.KeyChar = "." And Not s.Text.Contains(".") Then
            Return
        End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class