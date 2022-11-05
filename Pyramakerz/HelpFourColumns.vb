Public Class HelpFourColumns

    Dim bm As New BasicMethods
    Public FirstColumn, SecondColumn, ThirdColumn, FourthColumn, Statement As String

    Dim dt As New DataTable
    Dim dv As New DataView

    Private Sub HelpFourColumns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If
        bm.FillCombo("Branches", Branch, "")
        dt = bm.ExcuteAdapter(Statement)
        dt.TableName = "tbl"
        dt.Columns(0).ColumnName = FirstColumn
        dt.Columns(2).ColumnName = SecondColumn
        dt.Columns(3).ColumnName = ThirdColumn
        dt.Columns(4).ColumnName = FourthColumn

        dv.Table = dt
        DataGridView1.DataSource = dv
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub Branch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.Enter
        Try
            dv.Sort = FirstColumn
        Catch
        End Try
    End Sub
    Private Sub txtId_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.Enter
        Try
            dv.Sort = SecondColumn
        Catch
        End Try
    End Sub

    Private Sub txtName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Enter
        Try
            dv.Sort = ThirdColumn
        Catch
        End Try
    End Sub
    Private Sub txt2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.Enter
        Try
            dv.Sort = FourthColumn
        Catch
        End Try
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged, txtName.TextChanged, txt2.TextChanged, Branch.SelectedIndexChanged
        Try
            dv.RowFilter = " ([" & FirstColumn & "] = '" & Branch.SelectedValue.ToString() & "' or '" & Branch.SelectedValue.ToString() & "'='0') and [" & SecondColumn & "] like '%" & txtId.Text & "%' and [" & ThirdColumn & "] like '%" & txtName.Text & "%' and [" & FourthColumn & "] like '%" & txt2.Text & "%'"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
    Public SelectedId As String = ""
    Public SelectedName As String = ""
    Public SelectedRow As DataGridViewRow
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            SelectedId = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            SelectedName = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            SelectedRow = DataGridView1.Rows(e.RowIndex)
            Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectedId = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            SelectedName = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            SelectedRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)
            Close()
        End If
    End Sub

End Class