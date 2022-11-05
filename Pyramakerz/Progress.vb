Public Class Progress

    Public User As String = ""
    Dim bm As New BasicMethods
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Public Sub Progress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = bm.ExcuteAdapter("GetEmpProgress", New String() {"Branch", "Instractor"}, New String() {Module1.Branch, User})

        For i As Integer = 0 To dt.Rows.Count - 1
            DataGridView1.Rows.Add(New String() {dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString, dt.Rows(i)(2).ToString, dt.Rows(i)(3).ToString, dt.Rows(i)(4).ToString, dt.Rows(i)(5).ToString, dt.Rows(i)(6).ToString, dt.Rows(i)(7).ToString, dt.Rows(i)(8), dt.Rows(i)(9), dt.Rows(i)(10)})
        Next
    End Sub


    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 8 Then
            DataGridView1.Rows(e.RowIndex).Cells(8).Value = Val(DataGridView1.Rows(e.RowIndex).Cells(8).Value)
        ElseIf e.ColumnIndex = 9 Then
            DataGridView1.Rows(e.RowIndex).Cells(9).Value = Val(DataGridView1.Rows(e.RowIndex).Cells(9).Value)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Statement As String = "insert into Progress(Branch,Instractor,DayDate,GroupId,DepartmentId,CategoryId,Course,LectureNo,Page,ReviewAfter,Canceled) values "
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Statement &= IIf(i = 0, "", ",")
            Statement &= " ('" & Module1.Branch & "','" & User & "',cast(Getdate() as date),'" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "','" & DataGridView1.Rows(i).Cells(7).Value.ToString & "'," & DataGridView1.Rows(i).Cells(8).Value & "," & DataGridView1.Rows(i).Cells(9).Value & "," & DataGridView1.Rows(i).Cells(10).Value & ")"
        Next
        If Not bm.ExcuteNonQuery(Statement) Then Return

        lblSuccess.Visible = True
        lblSuccess.Refresh()
        Threading.Thread.Sleep(1000)
        lblSuccess.Visible = False

        Close()
    End Sub
End Class