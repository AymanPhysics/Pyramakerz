Public Class RPT16

    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub RPT16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        bm.FillCombo("select Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)
        FromDate.Value = Now
        ToDate.Value = Now
        If Flag = 2 Then
            Label4.Visible = True
            Closed.Visible = True
        ElseIf Flag = 3 Or Flag = 5 Then
            Label4.Visible = True
            Closed.Visible = True
            Label15.Visible = False
            Instractor.Visible = False
            btnEmpSearch.Visible = False
        End If

        If Flag = 5 Then
            Closed.Items.Clear()
            Closed.Items.AddRange(New String() {"Placement", "Waiting", "All"})
        End If
        Closed.SelectedIndex = 2
        bm.TestBranch(Branch)
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where Instractor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Branch.SelectedIndex < 0 Then Branch.SelectedIndex = 0
        Dim rpt As New ReportViewer(Text)
        rpt.paraname = New String() {"@Branch", "@Instractor", "@FromDate", "@ToDate", "@Closed", "@Flag"}
        rpt.paravalue = New String() {Branch.SelectedValue.ToString, Instractor.SelectedValue.ToString, FromDate.Text, ToDate.Text, Closed.SelectedIndex.ToString, "1"}
        If Flag = 1 Then
            rpt.Rpt = "LateInstractor.rpt"
        ElseIf Flag = 2 Then
            rpt.Rpt = "LateGroups.rpt"
        ElseIf Flag = 3 Then
            rpt.Rpt = "LateGroupsCount.rpt"
        ElseIf Flag = 4 Then
            rpt.Rpt = "Progress.rpt"
        ElseIf Flag = 5 Then
            rpt.paraname = New String() {"@Branch", "@Instractor", "@FromDate", "@ToDate", "@State", "@Flag"}
            'rpt.SubReports = New String() {"Financial.rpt"}
            rpt.Rpt = "InPlacementeAndNotInGroups.rpt"
        End If
        rpt.ShowDialog()
    End Sub

    Private Sub Closed_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, Instractor.KeyDown, FromDate.KeyDown, Closed.KeyDown, Branch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub
End Class