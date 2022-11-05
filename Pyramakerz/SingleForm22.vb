Public Class SingleForm22
    Public MainTableName As String = ""
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = ""
    Public MainId As String = ""
    Public SubId As String = "Id"
    Public SubName As String = "Name"
    Public SubName2 As String = "Name2"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub SingleForm22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.MaxLength = Length

        bm.FillCombo(MainTableName, CboMain, "")
        Dim v() As String = {MainId, SubId, SubName, SubName2}
        Dim c() As Control = {CboMain, txtID, txtName, txtName2}
        Dim k() As String = {MainId, SubId}
        If ComputerLab.Visible Then
            v = {MainId, SubId, SubName, SubName2, "ComputerLab"}
            c = {CboMain, txtID, txtName, txtName2, ComputerLab}
        End If

        bm.Fields = v
        bm.control = c
        bm.KeyFields = k

        bm.Table_Name = TableName

        btnNew_Click(sender, e)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.FirstLast(New String() {MainId, SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        bm.FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {CboMain.SelectedValue.ToString, txtID.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        bm.FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text.Trim = "" Or CboMain.SelectedValue.ToString = 0 Then
            Return
        End If
        If txtName2.Text.Trim = "" Then
            txtName2.Text = "0"
        End If
        bm.DefineValues()
        If Not bm.Save(New String() {MainId, SubId}, New String() {CboMain.SelectedValue.ToString, txtID.Text.Trim}) Then Return
        btnNew_Click(sender, e)
        AllowClose = True
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        bm.FirstLast(New String() {MainId, SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        bm.FillControls()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'bm.ClearControls()
        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            txtName.Clear()
            txtID.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & CboMain.SelectedValue.ToString & "'")
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            txtName2.Clear()
            txtName.Focus()
            ComputerLab.Checked = False
        Catch
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & txtID.Text.Trim & "' and " & MainId & " ='" & CboMain.SelectedValue.ToString & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {CboMain.SelectedValue.ToString, txtID.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        bm.FillControls()
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
        bm.RetrieveAll(New String() {MainId, SubId}, New String() {CboMain.SelectedValue.ToString, txtID.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        bm.FillControls()
        lv = False
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, txtID.KeyDown, CboMain.KeyDown, txtName2.KeyDown, ComputerLab.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress, txtName2.KeyPress
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

    Private Sub CboMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMain.SelectedIndexChanged
        ClearControls()
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
End Class