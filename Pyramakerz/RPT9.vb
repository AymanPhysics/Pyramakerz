Public Class RPT9
    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub RPT9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Type.SelectedIndex = 0
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        FromDate.Value = Now
        ToDate.Value = Now
        bm.TestBranch(Branch)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "BelowStandard.rpt"
        End If
        rpt.paraname = New String() {"@BranchId", "@FromDate", "@ToDate", "@Type", "@Perc"}
        rpt.paravalue = New String() {Branch.SelectedValue.ToString, FromDate.Text, ToDate.Text, Type.SelectedIndex.ToString(), Val(Value.Text).ToString}
        rpt.ShowDialog()
    End Sub

    Private Sub Value_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Value.KeyDown, Type.KeyDown, ToDate.KeyDown, FromDate.KeyDown, Branch.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub
End Class