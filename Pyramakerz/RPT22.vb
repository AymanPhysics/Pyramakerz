Public Class RPT22

    Dim bm As New BasicMethods
    Public Flag As Integer = 0
    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            frm.TableWhere = "  where Id in (select distinct ss.StudentId from StudentsBundleItems ss)"
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            txtStId_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        Try
            lblStName.Text = ""
            If txtStId.Text.Trim = "" Then Return
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
        Catch ex As Exception
        End Try
        FillStName()
    End Sub

    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
    End Sub

    Private Sub txtStId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If txtStId.Text.Length = 6 Then
        'txtStId_Leave(Nothing, Nothing)
        'End If
    End Sub

    Private Sub txtStId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
    Private Sub txtStId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Started.KeyDown, txtStId.KeyDown, ToDate.KeyDown, FromDate.KeyDown, DepartmentId.KeyDown, Course.KeyDown, Finished.KeyDown, CategoryId.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "BundleStatus.rpt"
        End If
        rpt.paraname = New String() {"@StudentId", "@DepartmentId", "@CategoryId", "@Course", "@Started", "@Finished", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {IIf(txtStId.Text.Trim = "", 0, txtStId.Text.Trim), DepartmentId.SelectedValue.ToString, CategoryId.SelectedValue.ToString, Course.SelectedValue.ToString, Started.SelectedIndex.ToString, Finished.SelectedIndex.ToString, FromDate.Text, ToDate.Text}
        rpt.ShowDialog()
    End Sub

    Private Sub RPT22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Departments", DepartmentId, "")
        DepartmentId_SelectedIndexChanged(Nothing, Nothing)
        FromDate.Value = Now
        ToDate.Value = Now
        Started.SelectedIndex = 2
        Finished.SelectedIndex = 2
    End Sub
    Private Sub DepartmentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Categories", CategoryId, " where DepartmentId='" & s & "'")
        CategoryId_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CategoryId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryId.SelectedIndexChanged
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
        bm.FillCombo("Items", Course, " where Course='1' and DepartmentId='" & s & "' and CategoryId='" & s1 & "'")
    End Sub

    Private Sub btnCourseSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourseSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Course Id"
        hh.SecondColumn = "Course Name"
        hh.Statement = "select cast(Id as varchar(100)) Id,Name from Items where Course='1' and DepartmentId='" & DepartmentId.SelectedValue.ToString & "' and CategoryId='" & CategoryId.SelectedValue.ToString & "'"
        hh.ShowDialog()
        Course.SelectedValue = hh.SelectedId
    End Sub
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class