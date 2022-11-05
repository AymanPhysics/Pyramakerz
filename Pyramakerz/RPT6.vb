Public Class RPT6
    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub PRT6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where Instractor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Flag = 1 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "InstractorEvaluation.rpt"
            rpt.paraname = New String() {"@Emp"}
            rpt.paravalue = New String() {Instractor.SelectedValue.ToString}
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub Instractor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Instractor.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub
End Class