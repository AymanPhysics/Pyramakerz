Public Class RPT21

    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub RPT21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Users)
        FromDate.Value = Now
        ToDate.Value = Now
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "GiveUpContract.rpt"
        End If
        rpt.paraname = New String() {"@StudentId", "@BranchId", "@UserName", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {IIf(txtStId.Text.Trim = "", 0, txtStId.Text.Trim), Branch.SelectedValue.ToString, Users.SelectedValue.ToString, FromDate.Text, ToDate.Text}
        rpt.ShowDialog()
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

    Private Sub txtStId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.TextChanged
        'If txtStId.Text.Length = 6 Then
        'txtStId_Leave(Nothing, Nothing)
        'End If
    End Sub

    Private Sub txtStId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStId.KeyDown, ToDate.KeyDown, FromDate.KeyDown, Branch.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtStId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStId.KeyPress
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

    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        Try
            lblStName.Text = ""
            If txtStId.Text.Trim = "" Then Return
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
        Catch ex As Exception
        End Try
        FillStName()
    End Sub

    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
    End Sub
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class