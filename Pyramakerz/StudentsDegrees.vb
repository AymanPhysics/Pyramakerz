Public Class StudentsDegrees

    Dim bm As New BasicMethods
    Dim Length As Integer = 0

    Private Sub Id_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id.Leave
        If Id.Text.Trim = "" Then Return
        DataGridView1.Rows.Clear()
        Id.Text = Id.Text.Trim.PadLeft(Length, "0")
        Dim dt As DataTable = bm.ExcuteAdapter("select * from Groups where BranchId='" & Module1.Branch & "' and Id='" & Id.Text & "'")
        If dt.Rows.Count = 0 Then
            Id.Clear()
            Return
        End If

        dt = bm.ExcuteAdapter("select G.StudentId,S.EnName,G.Degree,G.Degree2 from GroupsStudents G left join Students S on(G.StudentId=S.ID) where G.BranchId='" & Module1.Branch & "' and G.GroupId='" & Id.Text & "'")

        For i As Integer = 0 To dt.Rows.Count - 1
            DataGridView1.Rows.Add(New String() {dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString, dt.Rows(i)(2).ToString, dt.Rows(i)(3).ToString})
        Next
    End Sub

    Private Sub btnGroupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupSearch.Click
        Dim hh As New GroupsSearch
        hh.Branch = Module1.Branch
        hh.ShowDialog()
        Id.Text = hh.SelectedId
        Id_Leave(Nothing, Nothing)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Statement = ""
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Statement &= "update GroupsStudents set Degree='" & DataGridView1.Rows(i).Cells(2).Value & "',Degree2='" & DataGridView1.Rows(i).Cells(3).Value & "',UserName='" & Module1.UserName & "' where BranchId='" & Module1.Branch & "' and GroupId='" & Id.Text & "' and StudentId ='" & DataGridView1.Rows(i).Cells(0).Value & "'" & vbCrLf
        Next
        If Not bm.ExcuteNonQuery(Statement) Then Return
        Id.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub StudentsDegrees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            If e.ColumnIndex = 2 Then
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
            End If
        Catch ex As Exception
            DataGridView1.Rows(e.RowIndex).Cells(2).Value = 0
        End Try

    End Sub

    Private Sub Id_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Id.KeyDown
        If e.KeyCode = Keys.Enter Then
            Id_Leave(Nothing, Nothing)
        End If
    End Sub

    Private Sub StudentsDegrees_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not btnSave.Enabled Then Exit Sub
        Select Case bm.RequestDelete
            Case BasicMethods.CloseState.Yes
                btnSave_Click(Nothing, Nothing)
            Case BasicMethods.CloseState.No

            Case BasicMethods.CloseState.Cancel
                e.Cancel = True
        End Select
    End Sub
End Class