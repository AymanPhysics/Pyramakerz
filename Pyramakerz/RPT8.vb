Public Class RPT8
    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub RPT8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Departments", DepartmentId, "")
        DayDate.Value = New DateTime(Now.Year, Now.Month, 1)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Flag = 1 Then
            If DepartmentId.SelectedIndex < 1 Then
                bm.ShowMSG("Please, Select A Department ...")
                Return
            End If
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "InstractorComparison.rpt"
            rpt.paraname = New String() {"@Month", "@Year", "@DepartmentId"}
            rpt.paravalue = New String() {DayDate.Value.Month, DayDate.Value.Year, DepartmentId.SelectedValue.ToString}
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub btnSave_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DepartmentId.KeyDown, DayDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub
End Class