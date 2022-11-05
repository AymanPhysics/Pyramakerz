Public Class RPT11
    Dim bm As New BasicMethods
    Public Flag As Integer = 0
    Dim Length As Integer = 0

    Private Sub RPT11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FromInv.MaxLength = Length
        ToInv.MaxLength = Length

        bm.FillCombo("Countries", Countries, "")
        Countries_SelectedIndexChanged(Nothing, Nothing)
        'bm.FillCombo("Branches", Branch, "")
        bm.FillCombo("select Id,Name from OutcomeReasons union select 0 Id,'-' Name union select -1 Id,'Refund' Name order by Name", OutcomeReason)

        bm.FillCombo("select Id,Name from RefundReasons union select -1 Id,'Other' Name union select 0 Id,'-' Name order by Id", RefundReason)
        Try
            RefundReason.SelectedValue = 0
        Catch ex As Exception
        End Try
        Type.SelectedIndex = 0
        SortBy.SelectedIndex = 0
        Canceled.SelectedIndex = 1
        FromDate.Value = Now
        ToDate.Value = Now
        bm.TestBranch(Branch)
        Branch.SelectedValue = Module1.Branch
        bm.ApplySecurity(New Control() {FromDate, ToDate}, False, True, True, True, False, False, True, True, True)
    End Sub

    Private Sub InvoiceNo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToInv.Leave, FromInv.Leave
        Dim txt As TextBox = sender
        If (txt.Text.Trim <> "") Then
            txt.Text = txt.Text.Trim.PadLeft(txt.MaxLength, "0")
        End If
    End Sub

    Private Sub FromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Type.KeyDown, ToRealInv.KeyDown, ToInv.KeyDown, ToDate.KeyDown, SortBy.KeyDown, FromRealInv.KeyDown, FromInv.KeyDown, FromDate.KeyDown, Branch.KeyDown, IsReal.KeyDown, HasInvoiceNo.KeyDown, RefundReason.KeyDown, OutcomeReason.KeyDown, Cash.KeyDown, Canceled.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "Outcome.rpt"

        Dim br As String = "-1"
        Try
            br = Branch.SelectedValue.ToString
        Catch ex As Exception
        End Try

        rpt.paraname = New String() {"@Country", "@City", "@Branch", "@FromInv", "@ToInv", "@Type", "@FromRealInv", "@ToRealInv", "@FromDate", "@ToDate", "@SortBy", "@IsReal", "@HasInvoiceNo", "@Reason", "@RefundReason", "@Cash", "@Canceled"}
        rpt.paravalue = New String() {Countries.SelectedValue.ToString, Cities.SelectedValue.ToString, br, Val(FromInv.Text.Trim), Val(ToInv.Text.Trim), Type.SelectedIndex.ToString, Val(FromRealInv.Text.Trim), Val(ToRealInv.Text.Trim), FromDate.Text, ToDate.Text, SortBy.SelectedIndex.ToString, IsReal.SelectedIndex.ToString, HasInvoiceNo.SelectedIndex.ToString, OutcomeReason.SelectedValue.ToString, RefundReason.SelectedValue.ToString, Cash.SelectedIndex.ToString, Canceled.SelectedIndex.ToString}
        rpt.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub OutcomeReason_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutcomeReason.SelectedIndexChanged
        Try
            If OutcomeReason.SelectedValue.ToString = -1 Then
                lblRefundReason.Visible = True
                RefundReason.Visible = True
            Else
                lblRefundReason.Visible = False
                RefundReason.Visible = False
                RefundReason.SelectedValue = 0
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Type.SelectedIndexChanged, IsReal.SelectedIndexChanged, HasInvoiceNo.SelectedIndexChanged, Cash.SelectedIndexChanged, Canceled.SelectedIndexChanged
        If Type.SelectedIndex = 1 Then
            lblOutcomeReason.Visible = True
            OutcomeReason.Visible = True
            Label9.Visible = True
            HasInvoiceNo.Visible = True
            Label10.Visible = True
            Cash.Visible = True
        Else
            lblOutcomeReason.Visible = False
            OutcomeReason.Visible = False
            OutcomeReason.SelectedValue = 0
            Label9.Visible = False
            HasInvoiceNo.Visible = False
            HasInvoiceNo.SelectedIndex = 0
            Label10.Visible = False
            Cash.Visible = False
            Cash.SelectedIndex = 0
        End If

        If Type.SelectedIndex = 1 Or Type.SelectedIndex = 2 Then
            lblIsReal.Visible = True
            IsReal.Visible = True
        Else
            lblIsReal.Visible = False
            IsReal.Visible = False
            IsReal.SelectedIndex = 0
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

End Class