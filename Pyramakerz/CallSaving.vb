Public Class CallSaving

    Dim bm As New BasicMethods

    Private Sub KnownUs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnownUs.SelectedIndexChanged
        Try
            If KnownUs.SelectedValue.ToString = -1 Then
                Other.Visible = True
            Else
                Other.Visible = False
                Other.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CallSaving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,Name from HowDidYouKnowUs union select -1 Id,'Other' Name union select 0 Id,'-' Name order by Id", KnownUs)
        bm.FillCombo("Promotions", Promotion, " where CountryId='" & Module1.CountryId & "' and CityId='" & Module1.CityId & "'")
        NotRealInvoice_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub NotRealInvoice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsPromotion.CheckedChanged
        If IsPromotion.Checked Then
            Promotion.Visible = True
        Else
            Promotion.Visible = False
        End If
    End Sub

    Private Sub Other_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Comment.KeyDown, ClientName.KeyDown, CAREaBOUT.KeyDown, Promotion.KeyDown, Other.KeyDown, IsPromotion.KeyDown, Mobile.KeyDown, KnownUs.KeyDown, HomePhone.KeyDown, CheckSavedBefore.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Dim bol As Boolean = False

    Private Sub HomePhone_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomePhone.Leave, Mobile.Leave
        If bol Then Return
        bol = True

        If (HomePhone.Text.Trim <> "" AndAlso bm.ExecuteScalar("IsCallSaving", New String() {"Mobile"}, New String() {HomePhone.Text.Trim}) = "1") Or (Mobile.Text.Trim <> "" AndAlso bm.ExecuteScalar("IsCallSaving", New String() {"Mobile"}, New String() {Mobile.Text.Trim}) = "1") Then

            'bm.ShowMSG("Saved before ...")
            'Close()
            CheckSavedBefore.Checked = True
        Else
            CheckSavedBefore.Checked = False
        End If

        bol = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        bm.ExcuteNonQuery("INSERT INTO CallSaving" & IIf(CheckSavedBefore.Checked, "SavedBefore", "") & " (Mobile ,HomePhone ,ClientName ,CAREaBOUT ,Comment ,KnownUsFrom ,Other ,IsPromotion ,Promotion ,DayDate ,UserName,CountryId,CityId,BranchId)select '" & Mobile.Text.Trim & "','" & HomePhone.Text.Trim & "','" & ClientName.Text.Trim & "','" & CAREaBOUT.Text.Trim & "','" & Comment.Text.Trim & "','" & KnownUs.SelectedValue.ToString & "','" & Other.Text.Trim & "','" & IsPromotion.Text.Trim & "','" & Promotion.SelectedValue.ToString & "',GETDATE(),'" & Module1.UserName & "','" & Module1.CountryId & "','" & Module1.CityId & "','" & Module1.Branch & "'")
        bm.ShowMSG("Saved Successfuly ...")

        CheckSavedBefore.Checked = False
        Mobile.Clear()
        HomePhone.Clear()
        ClientName.Clear()
        CAREaBOUT.Clear()
        Comment.Clear()
        KnownUs.SelectedIndex = 1
        Other.Clear()
        IsPromotion.Checked = False
        Promotion.SelectedIndex = 0

        'AllowClose = True
        'Close()
    End Sub

    Dim AllowClose As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Return

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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblSavedBefore.Visible = Not LblSavedBefore.Visible
    End Sub

    Private Sub CheckSavedBefore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSavedBefore.CheckedChanged
        Timer1.Enabled = CheckSavedBefore.Checked
        If Not CheckSavedBefore.Checked Then LblSavedBefore.Visible = False
    End Sub
End Class