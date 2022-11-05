Public Class RPT2

    Dim bm As New BasicMethods
    Public Flag As Integer = 0
    Private Sub RPT2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        DayDate.Value = New DateTime(Now.Year, Now.Month, 1)
        If Flag = 2 Or Flag = 3 Or Flag = 4 Or Flag = 5 Or Flag = 6 Then
            Label3.Visible = False
            DayDate.Visible = False
        ElseIf Flag = 7 Then
            DayDate.CustomFormat = "dd-MM-yyyy"
        End If
        bm.TestBranch(Branch)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Branch.SelectedIndex < 0 Then Branch.SelectedIndex = 0
        If Flag = 1 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "AllInstallments.rpt"
            rpt.paraname = New String() {"@BranchId", "@Month", "@Year"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString, DayDate.Value.Month, DayDate.Value.Year}
            rpt.ShowDialog()
        ElseIf Flag = 2 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "CurrentStudents.rpt"
            rpt.paraname = New String() {"@BranchId"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString}
            rpt.ShowDialog()
        ElseIf Flag = 3 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "CurrentGender.rpt"
            rpt.paraname = New String() {"@BranchId"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString}
            rpt.ShowDialog()
        ElseIf Flag = 4 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "CurrentReligion.rpt"
            rpt.paraname = New String() {"@BranchId"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString}
            rpt.ShowDialog()
        ElseIf Flag = 5 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "CurrentRank.rpt"
            rpt.paraname = New String() {"@BranchId"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString}
            rpt.ShowDialog()
        ElseIf Flag = 6 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "CurrentStudents2.rpt"
            rpt.paraname = New String() {"@BranchId"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString}
            rpt.ShowDialog()
        ElseIf Flag = 7 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "GroupsTable.rpt"
            rpt.paraname = New String() {"@BranchId", "@DayDate"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString, bm.ToStrDate(DayDate.Value.Date)}
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub Branch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DayDate.KeyDown, Branch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub
End Class