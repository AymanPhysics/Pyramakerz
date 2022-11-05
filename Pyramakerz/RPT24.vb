Public Class RPT24
    Dim bm As New BasicMethods
    Public Flag As Integer = 1

    Private Sub RPT24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        bm.FillCombo("select Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)
        FromDate.Value = Now
        ToDate.Value = Now
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
        Dim rpt As New ReportViewer(Text)
        rpt.paraname = New String() {"@BranchId", "@Instructor", "@GroupId", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {Branch.SelectedValue.ToString, Instractor.SelectedValue.ToString, Val(Id.Text.Trim), FromDate.Text, ToDate.Text}
        If Flag = 1 Then
            rpt.Rpt = "GroupsEvaluations.rpt"
        End If
        rpt.ShowDialog()
    End Sub

    Private Sub btnGroupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupSearch.Click
        Dim hh As New GroupsSearch
        hh.Branch = Branch.SelectedValue.ToString
        hh.ShowDialog()
        Id.Text = hh.SelectedId
    End Sub

    Private Sub Id_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, Instractor.KeyDown, Id.KeyDown, FromDate.KeyDown, Branch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id.KeyPress
        If e.KeyChar = "" OrElse Asc(e.KeyChar.ToString.Substring(0)) = 22 OrElse Asc(e.KeyChar.ToString.Substring(0)) = 3 Then
            Return
        End If
        Dim s As New TextBox
        s = sender
        'If e.KeyChar = "." And Not s.Text.Contains(".") Then
        '    Return
        'End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class