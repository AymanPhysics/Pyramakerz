Public Class RPT23

    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub RPT23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DayDate.Value = Now
        FromDate.Value = Now
        ToDate.Value = Now
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click 
        Dim rpt As New ReportViewer(Text)
        rpt.paraname = New String() {"@DayDate", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {DayDate.Text, FromDate.Text & "-01-01", ToDate.Text & "-12-31"}
        If Flag = 1 Then
            rpt.Rpt = "PreviosCapasity.rpt"
        End If
        rpt.ShowDialog()
    End Sub

    Private Sub FromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, FromDate.KeyDown, DayDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

End Class