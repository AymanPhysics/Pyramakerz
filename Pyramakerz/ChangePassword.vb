Public Class ChangePassword
    Dim bm As New BasicMethods
    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OldPassword.KeyDown, NewPassword.KeyDown, ConfimPassword.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If OldPassword.Text <> Module1.Password Then
            bm.ShowMSG("Invalid Password ...")
            Return
        End If
        If NewPassword.Text <> ConfimPassword.Text Then
            bm.ShowMSG("Your new password entries did not match.")
            Return
        End If
        If NewPassword.Text.Length < 6 Then
            bm.ShowMSG("Password length MUST be 6 characters at least ...")
            Return
        End If
        bm.ExcuteNonQuery("update Employees set Password='" & bm.Encrypt(NewPassword.Text) & "' where Id='" & Module1.UserName & "'")
        Module1.Password = NewPassword.Text
        bm.ShowMSG("Password Changed Successfully.")
        AllowClose = True
        Close()
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
End Class