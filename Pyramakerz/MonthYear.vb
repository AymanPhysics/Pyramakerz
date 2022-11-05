Public Class MonthYear
    Dim bm As New BasicMethods
    Public Flag As Integer = 0
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Flag = 1 Then
            btnSave.Enabled = False
            bm.ExcuteNonQuery("CalcSalary", New String() {"Month", "Year"}, New String() {DayDate.Value.Month, DayDate.Value.Year})
            bm.ShowMSG("Completed Successfuly ...")
            btnSave.Enabled = True

        ElseIf Flag = 2 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "Salary.rpt"
            rpt.paraname = New String() {"@Month", "@Year"}
            rpt.paravalue = New String() {DayDate.Value.Month.ToString, DayDate.Value.Year.ToString}
            rpt.ShowDialog()

        ElseIf Flag = 3 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "CountingEvaluation.rpt"
            rpt.paraname = New String() {"@Month", "@Year"}
            rpt.paravalue = New String() {DayDate.Value.Month.ToString, DayDate.Value.Year.ToString}
            rpt.ShowDialog()

        ElseIf Flag = 4 Then
            btnSave.Enabled = False
            bm.ExcuteNonQuery("CalcShare", New String() {"Month", "Year"}, New String() {DayDate.Value.Month, DayDate.Value.Year})
            bm.ShowMSG("Completed Successfuly ...")
            btnSave.Enabled = True

        ElseIf Flag = 5 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "Share.rpt"
            rpt.paraname = New String() {"@Month", "@Year"}
            rpt.paravalue = New String() {DayDate.Value.Month.ToString, DayDate.Value.Year.ToString}
            rpt.ShowDialog()
        End If


    End Sub

    Private Sub MonthYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Flag
            Case 1
                btnSave.Text = "Clac"
            Case 4
                btnSave.Text = "Clac"
            Case Else
                btnSave.Text = "View"
        End Select
        DayDate.Value = New DateTime(Now.Year, Now.Month, 1)
    End Sub
End Class