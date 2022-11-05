Public Class StudentsLevels
    Dim bm As New BasicMethods
    Private Sub StudentsLevels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Departments", DepartmentId, "")

    End Sub

    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            txtStId_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub DepartmentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Categories", CategoryId, " where DepartmentId='" & s & "'")
    End Sub

    Private Sub CategoryId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryId.SelectedIndexChanged, txtStId.Leave

        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = CategoryId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Try
            bm.FillCombo("CoursesLevels", LevelId, " where DepartmentId='" & s & "' and CategoryId='" & s1 & "'")

            LevelId.SelectedValue = bm.ExecuteScalar("select LevelId from StudentsLevels where StudentId='" & txtStId.Text & "' and DepartmentId='" & s & "' and CategoryId='" & s1 & "'")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtStId.Clear()
        txtStId_Leave(Nothing, Nothing)
        DepartmentId.SelectedValue = 0
        CategoryId.SelectedValue = 0
        LevelId.SelectedValue = 0
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtStId.Text.Trim = "" Or CategoryId.SelectedIndex < 1 Then Return

        bm.ExcuteNonQuery("delete from StudentsLevels where StudentId='" & txtStId.Text & "' and DepartmentId='" & DepartmentId.SelectedValue.ToString & "' and CategoryId='" & CategoryId.SelectedValue.ToString & "'			insert into StudentsLevels(StudentId,DepartmentId,CategoryId,LevelId)values('" & txtStId.Text & "','" & DepartmentId.SelectedValue.ToString & "','" & CategoryId.SelectedValue.ToString & "','" & LevelId.SelectedValue.ToString & "')")

        btnSave.ForeColor = Color.Red
        Refresh()
        Threading.Thread.Sleep(200)
        btnSave.ForeColor = Color.Black

        AllowClose = True
    End Sub

    Private Sub txtStId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStId.KeyDown, LevelId.KeyDown, DepartmentId.KeyDown, CategoryId.KeyDown
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
        If txtStId.Text.Trim = "" Then
            txtStId.Clear()
        End If
    End Sub
    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
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
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class