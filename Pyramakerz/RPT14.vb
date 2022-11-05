Public Class RPT14
    Dim bm As New BasicMethods
    Public Flag As Integer = 1

    Private Sub RPT14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Countries", Countries, "")
        Countries_SelectedIndexChanged(Nothing, Nothing)
        bm.FillCombo("PromotionMethods", PromotionMethod, "")
        If Flag = 2 Then
            Label8.Visible = False
            Promotion.Visible = False
            Label7.Visible = False
            PromotionMethod.Visible = False
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

    Private Sub FromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, Promotion.KeyDown, FromDate.KeyDown, Countries.KeyDown, Cities.KeyDown
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
            rpt.Rpt = "TelephoneCalls_Promotion.rpt"
        ElseIf Flag = 2 Then
            rpt.Rpt = "Fund.rpt"
        End If
        rpt.paraname = New String() {"@CountryId", "@CityId", "@Promotion", "@PromotionMethod", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {Countries.SelectedValue.ToString, Cities.SelectedValue.ToString, Promotion.SelectedValue.ToString, PromotionMethod.SelectedValue.ToString, FromDate.Text, ToDate.Text}
        rpt.ShowDialog()
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
        bm.FillCombo("Promotions", Promotion, " where CountryId='" & s & "' and CityId='" & s1 & "'")
    End Sub
End Class