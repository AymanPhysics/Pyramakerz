Public Class RPT20

    Dim bm As New BasicMethods
    Public Flag As Integer = 1
    Private Sub RPT20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Countries", Countries, "")
        Countries_SelectedIndexChanged(Nothing, Nothing)
        Closed.SelectedIndex = 2
        FromDate.Value = Now
        ToDate.Value = Now
        If Flag = 2 Or Flag = 3 Or Flag = 4 Then
            Label4.Visible = False
            Closed.Visible = False
        End If

        If Flag = 3 Or Flag = 4 Then
            FromDate.Value = New DateTime(Now.Year, Now.Month, 1)
            ToDate.Value = New DateTime(Now.Year, Now.Month, 1)
            FromDate.CustomFormat = "MMM-yyyy"
            ToDate.CustomFormat = "MMM-yyyy"
            FromDate.ShowUpDown = True
            ToDate.ShowUpDown = True
        End If

        If Flag = 1 Then
            Closed.Items.Insert(2, "Closed & Not Upgraded")
            Closed.SelectedIndex = 3
        End If
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
            rpt.Rpt = "Remainning.rpt"
        ElseIf Flag = 3 Then
            rpt.Rpt = "NetIncome.rpt"
        ElseIf Flag = 4 Then
            rpt.Rpt = "SafeBalance.rpt"
        End If
        rpt.paraname = New String() {"@CountryId", "@CityId", "@BranchId", "@FromDate", "@ToDate", "@Closed"}
        rpt.paravalue = New String() {Countries.SelectedValue.ToString, Cities.SelectedValue.ToString, Branch.SelectedValue.ToString, FromDate.Text, ToDate.Text, Closed.SelectedIndex.ToString}
        rpt.ShowDialog()
    End Sub

    Private Sub Cities_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, FromDate.KeyDown, Countries.KeyDown, Closed.KeyDown, Cities.KeyDown, Branch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class