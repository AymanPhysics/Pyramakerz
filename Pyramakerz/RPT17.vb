Public Class RPT17

    Dim bm As New BasicMethods
    Public Flag As Integer = 0
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub RPT17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DayDate.Value = New DateTime(Now.Year, Now.Month, 1)
        bm.FillCombo("select Id,EnName Name from Employees /*where Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)
        Instractor.SelectedValue = Module1.UserName

        'bm.TestEmployee(Instractor)
        If Flag = 1 Then
            bm.ApplySecurity(New Control() {Instractor, btnEmpSearch}, False, True, True, False, False, False, True, True, False)
        ElseIf Flag = 2 Then
            bm.ApplySecurity(New Control() {Instractor, btnEmpSearch}, False, True, True, True, False, False, True, True, True)
        End If
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees /*where Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "EmpSalary.rpt"
        ElseIf Flag = 2 Then
            rpt.Rpt = "EmpAttendance.rpt"
        End If
        rpt.paraname = New String() {"@Emp", "@Month", "@Year"}
        rpt.paravalue = New String() {Instractor.SelectedValue.ToString, DayDate.Value.Month, DayDate.Value.Year}
        rpt.ShowDialog()
    End Sub
End Class