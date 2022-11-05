Public Class GroupsSearch


    Dim bm As New BasicMethods
    Dim FirstColumn, SecondColumn, ThirdColumn, FourthColumn, Statement, FifthColumn As String
    Public Branch As String
    Dim dt As New DataTable
    Dim dv As New DataView

    Public TableName As String = "Groups"

    Private Sub GroupsSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If
        Closed.SelectedIndex = 2
        FirstColumn = "Group"
        SecondColumn = "Course"
        ThirdColumn = "LectureNo"
        FourthColumn = "Instructor"
        FifthColumn = "Status"
        Statement = "select cast(G.Id as varchar(10)) 'Group',C.Name 'Course',cast(G.LectureNo as varchar(10)) 'LectureNo',dbo.GetEmpName(G.Instractor) 'Instructor',(case Closed when 0 then 'Running' when 1 then 'Closed' else '' end) 'Status' from " & TableName & " G left join Items C on(C.Course='1' and G.DepartmentId=C.DepartmentId and G.CategoryId=C.CategoryId and G.Course=C.Id) where G.BranchId='" & Branch & "'"

        dt = bm.ExcuteAdapter(Statement)
        dt.TableName = "tbl"
        dt.Columns(0).ColumnName = FirstColumn
        dt.Columns(1).ColumnName = SecondColumn
        dt.Columns(2).ColumnName = ThirdColumn
        dt.Columns(3).ColumnName = FourthColumn
        dt.Columns(4).ColumnName = FifthColumn

        dv.Table = dt
        DataGridView1.DataSource = dv
        'DataGridView1.Columns(1).Width = 300
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
    Private Sub txt2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.Enter
        Try
            dv.Sort = ThirdColumn
        Catch
        End Try
    End Sub

    Private Sub txt3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3.Enter
        Try
            dv.Sort = FourthColumn
        Catch
        End Try
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged, txtName.TextChanged, txt2.TextChanged, Closed.SelectedIndexChanged, txt3.TextChanged
        Try
            dv.RowFilter = " [" & FirstColumn & "] like '%" & txtId.Text & "%' and [" & SecondColumn & "] like '%" & txtName.Text & "%' and [" & ThirdColumn & "] like '%" & txt2.Text & "%' and [" & FourthColumn & "] like '%" & txt3.Text & "%' and  ([" & FifthColumn & "]='" & Closed.Text & "' or " & Closed.SelectedIndex & "=2)"
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
    Public SelectedId As String = ""
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