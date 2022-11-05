Public Class RPT13
    Dim bm As New BasicMethods
    Public Flag As Integer = 1

    Private Sub RPT13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Jobs", JobId, "")

        FromDate.Value = Now
        ToDate.Value = Now
        If Flag = 2 Or Flag = 3 Then
            bm.TestEmployee(Users)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "TelephoneCalls.rpt"
        ElseIf Flag = 2 Then
            rpt.Rpt = "MissedCalls.rpt"
        ElseIf Flag = 3 Then
            rpt.Rpt = "DataEntry.rpt"
        ElseIf Flag = 4 Then
            rpt.Rpt = "DuplicatedTelephoneCalls.rpt"
        End If
        rpt.paraname = New String() {"@JobId", "@Emp", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {JobId.SelectedValue.ToString, Users.SelectedValue.ToString, FromDate.Text, ToDate.Text}
        rpt.ShowDialog()
    End Sub

    Private Sub FromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Users.KeyDown, ToDate.KeyDown, FromDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub JobId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobId.SelectedIndexChanged
        Dim s As String = "0"
        Dim Statement As String = "select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name"
        Try
            If JobId.SelectedIndex > 0 Then
                s = JobId.SelectedValue
                Statement = "select Id,EnName Name from Employees where JobId=" & s & " and  SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name"
            End If
        Catch ex As Exception
        End Try
        bm.FillCombo(Statement, Users)
    End Sub
End Class