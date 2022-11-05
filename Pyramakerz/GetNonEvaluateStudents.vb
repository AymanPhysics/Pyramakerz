Public Class GetNonEvaluateStudents
    Dim bm As New BasicMethods
    Public dt As DataTable
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub GetNonEvaluateStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = dt
        DataGridView1.Columns(2).FillWeight = 200
        DataGridView1.Columns(3).Visible = False
    End Sub
End Class