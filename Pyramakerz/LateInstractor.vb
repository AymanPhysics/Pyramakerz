Public Class LateInstractor
    Dim bm As New BasicMethods

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub LateInstractor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        bm.FillCombo("select Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)
        bm.FillCombo("select Id,Name from LateInstractorReasons union select -1 Id,'Other' Name union select 0 Id,'-' Name order by Id", Reason)
        Branch.SelectedValue = Module1.Branch
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where Instractor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub Reason_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reason.SelectedIndexChanged, GroupId.SelectedIndexChanged
        Try

            If Reason.SelectedValue.ToString = -1 And Reason.Visible Then
                Other.Visible = True
            Else
                Other.Visible = False
                Other.Clear()
            End If
        Catch ex As Exception
            Other.Visible = False
            Other.Clear()
        End Try
    End Sub

    Private Sub MyKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Reason.KeyDown, Other.KeyDown, Instractor.KeyDown, DayDate.KeyDown, Branch.KeyDown, GroupId.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Branch.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select a Branch ...")
            Branch.Focus()
            Return
        End If
        If Instractor.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select an Instractor ...")
            Instractor.Focus()
            Return
        End If
        If GroupId.SelectedIndex < 0 Then
            bm.ShowMSG("Please, Select an GroupId ...")
            GroupId.Focus()
            Return
        End If
        If Val(Minites.Text) = 0 Then
            bm.ShowMSG("Please, Fill Minites ...")
            Minites.Focus()
            Return
        End If
        If Reason.SelectedValue = 0 Then
            bm.ShowMSG("Please, Select a Reason ...")
            Reason.Focus()
            Return
        End If


        bm.ExcuteNonQuery("insert into LateInstractor(Branch,UserName,Instractor,Reason,Other,DayDate,ServerDate,Minites) select '" & Branch.SelectedValue.ToString & "','" & Module1.UserName & "','" & Instractor.SelectedValue.ToString & "','" & Reason.SelectedValue.ToString & "','" & Other.Text.Trim & "','" & bm.ToStrDate(DayDate.Value) & "',GetDate()," & Val(Minites.Text))
        lblSuccess.Visible = True
        lblSuccess.Refresh()
        Threading.Thread.Sleep(1000)
        lblSuccess.Visible = False
        Branch.SelectedValue = 0
        Instractor.SelectedValue = 0
        DayDate.Value = DayDate.Value
        Minites.Clear()
        Reason.SelectedValue = 0
        Branch.SelectedValue = Module1.Branch
        Branch.Focus()
    End Sub

    Private Sub Minites_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Minites.KeyPress
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
     

    Private Sub Instractor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.SelectedIndexChanged, Instractor.SelectedIndexChanged, DayDate.ValueChanged
        Try
            bm.FillCombo(GroupId, "GetEmpProgress2", New String() {"Branch", "Instractor"}, New String() {Branch.SelectedValue.ToString, Instractor.SelectedValue.ToString})
        Catch ex As Exception
        End Try
    End Sub
End Class