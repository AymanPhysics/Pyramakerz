Public Class Execuse
    Dim bm As New BasicMethods
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Execuse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,EnName Name from Employees where stopped=0 union select 0 Id,'-' Name", Employee)
        DayDate.Value = Now.Date

    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees /*where Stopped='0'*/"
        hh.ShowDialog()
        Employee.SelectedValue = hh.SelectedId
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If Employee.SelectedValue = 0 Then Return
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(0).Value = Employee.SelectedValue Then Return
            Next
            DataGridView1.Rows.Add(New String() {Employee.SelectedValue, Employee.Text, Module1.UserName})
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DayDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayDate.ValueChanged
        DataGridView1.Rows.Clear()
        Dim dt As DataTable = bm.ExcuteAdapter("select EmpId,E.EnName,UserName from Execuse Ex left join Employees E on(E.Id=Ex.EmpId) where DayDate='" & bm.ToStrDate(DayDate.Value) & "' order by E.EnName")

        For i As Integer = 0 To dt.Rows.Count - 1
            DataGridView1.Rows.Add(New String() {dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString, dt.Rows(i)(2).ToString})
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        bm.ExcuteNonQuery("delete from Execuse where DayDate='" & bm.ToStrDate(DayDate.Value) & "'")
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            bm.ExcuteNonQuery("insert into Execuse(DayDate,EmpId,UserName)values('" & bm.ToStrDate(DayDate.Value) & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "')")
        Next
        NewSave()
        AllowClose = True
    End Sub
    Sub NewSave()
        btnSave.BackColor = Color.Red
        btnSave.ForeColor = Color.Blue
        Refresh()
        Threading.Thread.Sleep(200)
        btnSave.BackColor = Color.White
        btnSave.ForeColor = Color.Red
    End Sub

    Dim AllowClose As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not btnSave.Enabled Then Exit Sub
        Select Case bm.RequestDelete
            Case BasicMethods.CloseState.Yes
                AllowClose = False
                btnSave_Click(Nothing, Nothing)
                If Not AllowClose Then e.Cancel = True
            Case BasicMethods.CloseState.No

            Case BasicMethods.CloseState.Cancel
                e.Cancel = True
        End Select
    End Sub
End Class