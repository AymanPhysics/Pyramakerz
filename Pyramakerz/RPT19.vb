Public Class RPT19

    Dim bm As New BasicMethods
    Public Flag As Integer = 1

    Private Sub RPT19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Countries", Countries, "")
        Countries_SelectedIndexChanged(Nothing, Nothing)
        FromDate.Value = New DateTime(Now.Year, Now.Month, 1)
        ToDate.Value = New DateTime(Now.Year, Now.Month, 1)
        If Flag = 3 Then
            FromDate.CustomFormat = "yyyy-MM-dd"
            ToDate.CustomFormat = "yyyy-MM-dd"
            FromDate.Value = Now
            ToDate.Value = Now
        ElseIf Flag = 5 Then
            lblMain.Visible = False
            Countries.Visible = False
            lblMain2.Visible = False
            Cities.Visible = False
        ElseIf Flag = 6 Then
            FromDate.CustomFormat = "yyyy-MM-dd"
            ToDate.CustomFormat = "yyyy-MM-dd"
            FromDate.Value = Now
            ToDate.Value = Now
            lblMain.Visible = False
            Countries.Visible = False
            lblMain2.Visible = False
            Cities.Visible = False
        End If
    End Sub

    Private Sub Countries_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Countries.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = Countries.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Cities", Cities, " where CountryId='" & s & "'")
    End Sub

    Private Sub FromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, FromDate.KeyDown, Countries.KeyDown, Cities.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "Savings.rpt"
        ElseIf Flag = 2 Then
            rpt.Rpt = "Charity.rpt"
        ElseIf Flag = 3 Then
            rpt.Rpt = "KnownUs.rpt"
        ElseIf Flag = 4 Then
            rpt.Rpt = "RegStudents.rpt"
        ElseIf Flag = 5 Then
            rpt.Rpt = "Share2.rpt"
        ElseIf Flag = 6 Then
            rpt.Rpt = "PrintCarnaihHistory.rpt"
        End If
        rpt.paraname = New String() {"@CountryId", "@CityId", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {Countries.SelectedValue.ToString, Cities.SelectedValue.ToString, FromDate.Text, ToDate.Text}
        rpt.ShowDialog()
    End Sub

End Class