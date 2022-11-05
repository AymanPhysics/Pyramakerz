Public Class RPT10
    Dim bm As New BasicMethods
    Public Flag As Integer = 0
    Dim Length As Integer = 0

    Private Sub RPT10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FromInv.MaxLength = Length
        ToInv.MaxLength = Length
        bm.FillCombo("Countries", Countries, "")

        bm.FillCombo("select Id,EnName Name from employees where SystemUser=1 union select 0,'-'", UserInserted)
        bm.FillCombo("select Id,EnName Name from employees where Sales=1 union select 0,'-'", Sales)


        Countries_SelectedIndexChanged(Nothing, Nothing)
        'bm.FillCombo("Branches", Branch, "")
        Type.SelectedIndex = 0
        SortBy.SelectedIndex = 0
        Canceled.SelectedIndex = 1
        FromDate.Value = Now
        ToDate.Value = Now
        Type_SelectedIndexChanged(Nothing, Nothing)
        Countries.SelectedValue = Module1.CountryId
        Cities.SelectedValue = Module1.CityId
        bm.TestCountry(Countries)
        bm.TestCity(Cities)
        bm.TestBranch(Branch)
        bm.TestBranch2(Branch)
        Branch.SelectedValue = Module1.Branch
        bm.ApplySecurity(New Control() {FromDate, ToDate}, False, True, True, True, False, False, True, True, True)
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
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "Income.rpt"

        Dim br As String = "-1"
        Try
            br = Branch.SelectedValue.ToString
        Catch ex As Exception
        End Try

        rpt.paraname = New String() {"@Country", "@City", "@Branch", "@FromInv", "@ToInv", "@Type", "@FromRealInv", "@ToRealInv", "@FromDate", "@ToDate", "@SortBy", "@Course", "@Canceled", "@UserInserted", "@Sales"}
        rpt.paravalue = New String() {Countries.SelectedValue.ToString, Cities.SelectedValue.ToString, br, Val(FromInv.Text.Trim), Val(ToInv.Text.Trim), Type.SelectedIndex.ToString, Val(FromRealInv.Text.Trim), Val(ToRealInv.Text.Trim), FromDate.Text, ToDate.Text, SortBy.SelectedIndex.ToString, Course.SelectedIndex.ToString, Canceled.SelectedIndex.ToString, Val(UserInserted.SelectedValue.ToString), Val(Sales.SelectedValue.ToString)}
        rpt.ShowDialog()
    End Sub

    Private Sub InvoiceNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToInv.Leave, FromInv.Leave
        Dim txt As TextBox = sender
        If (txt.Text.Trim <> "") Then
            txt.Text = txt.Text.Trim.PadLeft(txt.MaxLength, "0")
        End If
    End Sub

    Private Sub FromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Type.KeyDown, ToRealInv.KeyDown, ToInv.KeyDown, ToDate.KeyDown, SortBy.KeyDown, FromRealInv.KeyDown, FromInv.KeyDown, FromDate.KeyDown, Branch.KeyDown, Countries.KeyDown, Cities.KeyDown, Canceled.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Type.SelectedIndexChanged
        If Type.SelectedIndex = 1 Then
            Label9.Visible = True
            Course.Visible = True
        Else
            Label9.Visible = False
            Course.Visible = False
            Course.SelectedIndex = 0
        End If
    End Sub
End Class