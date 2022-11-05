Public Class RPT5
    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where Instractor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub RPT5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select cast(Id as varchar(100)) Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)
        ComboBox1.SelectedIndex = 2
        DayDate1.Value = New DateTime(Now.Year, Now.Month, 1)
        DayDate2.Value = New DateTime(Now.Year, Now.Month, 1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 2 Then
            Label1.Visible = True
            DayDate2.Visible = True
        Else
            Label1.Visible = False
            DayDate2.Visible = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "InstractorPeriodEvaluation.rpt"
        ElseIf Flag = 2 Then
            rpt.Rpt = "Grades.rpt"
        End If
        rpt.paraname = New String() {"@Emp", "@Period", "@Date1", "@Date2"}
        rpt.paravalue = New String() {Instractor.SelectedValue.ToString, ComboBox1.SelectedIndex.ToString, DayDate1.Value.ToShortDateString, DayDate2.Value.ToShortDateString}
        rpt.ShowDialog()
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Instractor.KeyDown, DayDate2.KeyDown, DayDate1.KeyDown, ComboBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub
End Class