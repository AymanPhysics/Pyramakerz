Public Class RPT7

    Dim bm As New BasicMethods
    Public Flag As Integer = 0
    Private Sub RPT7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Departments", DepartmentId, "")
        DepartmentId_SelectedIndexChanged(Nothing, Nothing)
        FromDate.Value = Now
        ToDate.Value = Now
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Flag = 1 Then
            If Course.SelectedIndex < 1 Then
                bm.ShowMSG("Please, Select A Course ...")
                Return
            End If
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "BestInCourse.rpt"
            rpt.paraname = New String() {"@FromDate", "@ToDate", "@DepartmentId", "@CategoryId", "@Course"}
            rpt.paravalue = New String() {FromDate.Text, ToDate.Text, DepartmentId.SelectedValue.ToString, CategoryId.SelectedValue.ToString, Course.SelectedValue.ToString}
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub CategoryId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, FromDate.KeyDown, DepartmentId.KeyDown, Course.KeyDown, CategoryId.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub
End Class