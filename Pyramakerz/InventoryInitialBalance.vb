Public Class InventoryInitialBalance
    Dim bm As New BasicMethods
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub InventoryInitialBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bm.FillCombo("Branches", Branch, "")
    End Sub

    Private Sub Branch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.SelectedIndexChanged
        InComeBal0.Text = "0"
        InComeLimit.Text = "0"
        OutComeBal0.Text = "0"
        OutComeLimit.Text = "0"

        Dim dt As DataTable = bm.ExcuteAdapter("select InComeBal0,OutComeBal0,InComeLimit,OutComeLimit from InventoryInitialBalance where Branch='" & Branch.SelectedValue.ToString & "'")
        If dt.Rows.Count > 0 Then
            InComeBal0.Text = dt.Rows(0)("InComeBal0").ToString
            InComeLimit.Text = dt.Rows(0)("InComeLimit").ToString
            OutComeBal0.Text = dt.Rows(0)("OutComeBal0").ToString
            OutComeLimit.Text = dt.Rows(0)("OutComeLimit").ToString
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Branch.SelectedValue.ToString = 0 Then Return

        If InComeBal0.Text.Trim = "" Then InComeBal0.Text = "0"
        If InComeLimit.Text.Trim = "" Then InComeLimit.Text = "0"

        If OutComeBal0.Text.Trim = "" Then OutComeBal0.Text = "0"
        If OutComeLimit.Text.Trim = "" Then OutComeLimit.Text = "0"


        bm.ExcuteNonQuery("delete from InventoryInitialBalance where Branch='" & Branch.SelectedValue.ToString & "'      insert into InventoryInitialBalance(Branch,InComeBal0,OutComeBal0,InComeLimit,OutComeLimit) values ('" & Branch.SelectedValue.ToString & "'," & InComeBal0.Text & "," & OutComeBal0.Text & "," & InComeLimit.Text & "," & OutComeLimit.Text & ")")
        NewSave()
        Branch_SelectedIndexChanged(Nothing, Nothing)

        AllowClose = True
    End Sub
    Sub NewSave()
        btnSave.BackColor = Color.Red
        btnSave.ForeColor = Color.Blue
        Refresh()
        Threading.Thread.Sleep(200)
        btnSave.BackColor = Color.White
        btnSave.ForeColor = Color.Red
    End Sub
    Private Sub DeductionValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InComeBal0.KeyPress, OutComeBal0.KeyPress, OutComeLimit.KeyPress, InComeLimit.KeyPress
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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OutComeBal0.KeyDown, InComeBal0.KeyDown, Branch.KeyDown, OutComeLimit.KeyDown, InComeLimit.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
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
End Class