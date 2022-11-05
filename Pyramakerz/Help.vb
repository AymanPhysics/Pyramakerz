Public Class Help
    Dim bm As New BasicMethods
    Public FirstColumn, SecondColumn, Statement As String

    Dim dt As New DataTable
    Dim dv As New DataView
    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If
        dt = bm.ExcuteAdapter(Statement)
        dt.TableName = "tbl"
        dt.Columns(0).ColumnName = FirstColumn
        dt.Columns(1).ColumnName = SecondColumn

        dv.Table = dt
        DataGridView1.DataSource = dv
        DataGridView1.Columns(1).Width = 300
    End Sub

    Private Sub txtId_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.Enter
        Try
            dv.Sort = FirstColumn
        Catch
        End Try
    End Sub

    Private Sub txtName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Enter
        Try
            dv.Sort = SecondColumn
        Catch
        End Try
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged, txtName.TextChanged
        dv.RowFilter = " [" & FirstColumn & "] like '%" & txtId.Text & "%' and [" & SecondColumn & "] like '%" & txtName.Text & "%'"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
    Public SelectedId As Integer = 0
    Public SelectedName As String = ""
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            SelectedId = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            SelectedName = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            Close()
        Catch ex As Exception
        End Try
        
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectedId = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            SelectedName = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            Close()
        End If
    End Sub
End Class