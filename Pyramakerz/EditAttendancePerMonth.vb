Public Class EditAttendancePerMonth

    Dim bm As New BasicMethods
    Private Sub Instractor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Instractor.SelectedIndexChanged, DayDate.ValueChanged
        LoadGrid()
    End Sub

    Sub LoadGrid()
        Try
            Dim dv As New DataView(bm.ExcuteAdapter("GetAttendancePerMonth", New String() {"EmpId", "MONTH", "YEAR"}, New String() {Instractor.SelectedValue.ToString, DayDate.Value.Month.ToString, DayDate.Value.Year.ToString}))
            DataGridView1.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where SystemUser='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub EditAttendancePerMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by EnName", Instractor)
        DayDate.Value = New DateTime(Now.Year, Now.Month, 1)
        LoadGrid()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim frm As New EditAttendance
            Dim Main As New MAIN
            Main.ShowForm(frm, sender)
            frm.MdiParent = Nothing
            frm.Hide()
            frm.MyEmp = Instractor.SelectedValue
            frm.MyDate = DataGridView1.CurrentRow.Cells(1).Value
            Dim i As Integer = DataGridView1.CurrentRow.Index
            frm.ShowDialog()
            LoadGrid()
            DataGridView1.CurrentCell = DataGridView1.Rows(i).Cells(0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class