Public Class RPT25

    Dim bm As New BasicMethods
    Public Flag As Integer = 1
    Private Sub RPT25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Departments", DepartmentId, "")
        DepartmentId_SelectedIndexChanged(Nothing, Nothing)
        bm.FillCombo("Countries", Countries, "")
        Countries_SelectedIndexChanged(Nothing, Nothing)
        Closed.SelectedIndex = 2
        FromDate.Value = Now
        ToDate.Value = Now

        Closed.Items.Insert(2, "Closed & Not Upgraded")
        Closed.SelectedIndex = 3

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


    Private Sub Countries_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Countries.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = Countries.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Cities", Cities, " where CountryId='" & s & "'")
        Cities_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Cities_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cities.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = Countries.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = Cities.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Branches", Branch, " where CountryId='" & s & "' and CityId='" & s1 & "'")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "Groups.rpt"
        ElseIf Flag = 2 Then
            If Course.SelectedIndex < 1 Then
                bm.ShowMSG("Please, Select A Course ...")
                Return
            End If
            rpt.Rpt = "BestInCourse.rpt"
        ElseIf Flag = 3 Then
            rpt.Rpt = "VirtualGroups.rpt"
        End If
        rpt.paraname = New String() {"@CountryId", "@CityId", "@BranchId", "@FromDate", "@ToDate", "@Closed", "@DepartmentId", "@CategoryId", "@Course"}
        rpt.paravalue = New String() {Countries.SelectedValue.ToString, Cities.SelectedValue.ToString, Branch.SelectedValue.ToString, FromDate.Text, ToDate.Text, Closed.SelectedIndex.ToString, DepartmentId.SelectedValue.ToString, CategoryId.SelectedValue.ToString, Course.SelectedValue.ToString}
        rpt.ShowDialog()
    End Sub

    Private Sub Cities_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, FromDate.KeyDown, Countries.KeyDown, Closed.KeyDown, Cities.KeyDown, Branch.KeyDown, DepartmentId.KeyDown, Course.KeyDown, CategoryId.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class