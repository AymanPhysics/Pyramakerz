Public Class RPT12
    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub RPT12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Branches", Branch, "")
        bm.FillCombo("select Id,Name from RefundReasons union select -1 Id,'Other' Name union select 0 Id,'-' Name order by Id", RefundReason)
        FromDate.Value = Now
        ToDate.Value = Now
        bm.TestBranch(Branch)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub RefundReason_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, RefundReason.KeyDown, FromDate.KeyDown, Branch.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "Refund.rpt"

        Dim br As String = "-1"
        Try
            br = Branch.SelectedValue.ToString
        Catch ex As Exception
        End Try

        rpt.paraname = New String() {"@Branch", "@FromDate", "@ToDate", "@RefundReason"}
        rpt.paravalue = New String() {br, FromDate.Text, ToDate.Text, RefundReason.SelectedValue.ToString}
        rpt.ShowDialog()
    End Sub
End Class