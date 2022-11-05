Public Class GroupsStudents
    Dim bm As New BasicMethods

    Public SubTableName As String = "GroupsStudents"

    Public BranchId As String = ""
    Public GroupId As String = ""
    Public DepartmentId As String = ""
    Public CategoryId As String = ""
    Public Course As String = ""
    Public Import As Boolean = False
    Public IsClosed As Boolean = False
    Public Flag As Integer = 0

    Private Sub GroupsStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Dim dt As DataTable = bm.ExcuteAdapter("select G.StudentId,S.EnName,G.Degree,G.Degree2 from " & SubTableName & " G left join Students S on(G.StudentId=S.ID) where G.BranchId='" & BranchId & "' and G.GroupId='" & GroupId & "'")

        For i As Integer = 0 To dt.Rows.Count - 1
            DataGridView1.Rows.Add(New String() {dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString, dt.Rows(i)(2).ToString, dt.Rows(i)(3).ToString})
        Next
    End Sub

    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            If Not Import Then
                frm.TableWhere = "  where Id in (select StudentId from StudentsLevels SL left join Items C on(C.Course='1' and C.DepartmentId=SL.DepartmentId and C.CategoryId=SL.CategoryId and C.CourseLevel=SL.LevelId) where  C.DepartmentId='" & DepartmentId & "' and C.CategoryId='" & CategoryId & "' and C.Id='" & Course & "') or exists(select * from Items C where C.Course='1' and C.DepartmentId='" & DepartmentId & "' and C.CategoryId='" & CategoryId & "' and C.Id='" & Course & "' and C.CourseLevel= (select MIN(CL.Id)from CoursesLevels CL where CL.DepartmentId='" & DepartmentId & "' and CL.CategoryId='" & CategoryId & "'))"
            End If
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            txtStId_Leave(Nothing, Nothing)
            FillStName()
        Catch ex As Exception
        End Try
    End Sub

    Dim NewStudents As String() = {}

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If txtStId.Text.Trim = "" Then Return
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(0).Value = txtStId.Text.Trim Then Return
            Next
            If bm.ExecuteScalar("select dbo.TestStudentBundleItemsCount(" & txtStId.Text.Trim & ")") = "1" Then
                bm.ShowMSG("Student has studied All courses in bundle")
            End If
            DataGridView1.Rows.Add(New String() {txtStId.Text.Trim, lblStName.Text, 0, 0})
            If Import Then
                ReDim Preserve NewStudents(NewStudents.Length)
                NewStudents(NewStudents.Length - 1) = txtStId.Text.Trim
            End If
            txtStId.Text = ""
            lblStName.Text = ""
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        bm.ExcuteNonQuery("delete from " & SubTableName & " where BranchId='" & BranchId & "' and GroupId='" & GroupId & "'")

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If Not bm.ExcuteNonQuery("insert into " & SubTableName & "(BranchId,GroupId,StudentId,Degree,Degree2,UserName)values('" & BranchId & "','" & GroupId & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & Module1.UserName & "')") Then
                bm.ShowMSG("Student [ " & DataGridView1.Rows(i).Cells(0).Value & " : " & DataGridView1.Rows(i).Cells(1).Value & """ ] didn't be saved")
            End If

            If Not IsClosed Then 'And Flag = 0 
                bm.ExcuteNonQuery("SetFlagEqual_2", New String() {"StudentId", "DepartmentId", "CategoryId", "Course"}, New String() {DataGridView1.Rows(i).Cells(0).Value, DepartmentId, CategoryId, Course})
            End If
        Next

        For i As Integer = 0 To NewStudents.Length - 1
            bm.ExcuteNonQuery("insert StudentsImported(Branch,GroupId,StudentId,UserName,DayDate)values(" & BranchId & "," & GroupId & "," & NewStudents(i) & "," & Module1.UserName & ",GETDATE())")
        Next

        Saved = True

        AllowClose = True
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Try
            Dim st As String = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            Dim frm As New TransferStudents
            frm.st = st
            frm.Degree = Val(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value)
            frm.Degree2 = Val(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value)
            frm.OldGroup = GroupId
            frm.OldBranch = BranchId
            frm.Text &= "    " & st & "    " & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            frm.ShowDialog()
            If frm.Ok Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
                btnSave_Click(Nothing, Nothing)
                NewSave()
            End If
        Catch ex As Exception
        End Try

    End Sub
    Sub NewSave()
        btnSave.BackColor = Color.Red
        btnSave.ForeColor = Color.Blue
        Refresh()
        Threading.Thread.Sleep(200)
        btnSave.BackColor = Color.White
        btnSave.ForeColor = Color.Red
    End Sub

    Private Sub DataGridView1_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            If Val(DataGridView1.Rows(e.RowIndex).Cells(2).Value) + Val(DataGridView1.Rows(e.RowIndex).Cells(3).Value) > 100 Then
                bm.ShowMSG("Max Total Degree is 100")
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = 0
                DataGridView1.Rows(e.RowIndex).Cells(3).Value = 0
            End If
        End If
    End Sub

    Private Sub txtStId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStId.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtStId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStId.KeyPress
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

    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        Try
            If txtStId.Text.Trim = "" Then
                lblStName.Text = ""
                Return
            End If
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
            FillStName()
        Catch ex As Exception
        End Try
    End Sub

    Sub FillStName()
        Dim s As String = ""
        If Not Import Then
            s = "  and (Id in (select StudentId from StudentsLevels SL left join Items C on(C.Course='1' and C.DepartmentId=SL.DepartmentId and C.CategoryId=SL.CategoryId and C.CourseLevel=SL.LevelId) where  C.DepartmentId='" & DepartmentId & "' and C.CategoryId='" & CategoryId & "' and C.Id='" & Course & "') or exists(select * from Items C where C.Course='1' and C.DepartmentId='" & DepartmentId & "' and C.CategoryId='" & CategoryId & "' and C.Id='" & Course & "' and C.CourseLevel= (select MIN(CL.Id)from CoursesLevels CL where CL.DepartmentId='" & DepartmentId & "' and CL.CategoryId='" & CategoryId & "')))"
        End If
        Dim dt As DataTable = bm.ExcuteAdapter("select EnName from Students where Id='" & txtStId.Text & "'" & s)
        If dt.Rows.Count = 0 Then
            txtStId.Clear()
            lblStName.Text = ""
            Return
        End If
        lblStName.Text = dt.Rows(0)(0)
    End Sub

    Private Sub txtStId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If txtStId.Text.Length = 6 Then
        'txtStId_Leave(Nothing, Nothing)
        'End If
    End Sub

    Dim AllowClose As Boolean = False

    Dim Saved As Boolean = False

    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Saved = True Then Return

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

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        btnSave_Click(Nothing, Nothing)
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "GroupStudents.rpt"
        rpt.paraname = New String() {"@BranchId", "@GroupId"}
        rpt.paravalue = New String() {BranchId, GroupId}
        rpt.ShowDialog()
    End Sub
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub

    Public MyDepartmentId As Integer
    Public MyCategoryId As Integer
    Public MyCourse As Integer

    Private Sub btnTestAdditionEligibility_Click(sender As Object, e As EventArgs) Handles btnTestAdditionEligibility.Click
        Dim frm As New AdditionEligibility
        bm.ShowForm(frm, sender, Nothing)
        frm.txtStId.Text = txtStId.Text
        frm.txtStId_Leave(Nothing, Nothing)

        frm.DepartmentId.SelectedValue = MyDepartmentId
        frm.CategoryId.SelectedValue = MyCategoryId
        frm.Course.SelectedValue = MyCourse

        frm.btnSave_Click(Nothing, Nothing)
        frm.BringToFront()
    End Sub
End Class