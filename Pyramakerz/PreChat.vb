Public Class PreChat
    Dim bm As New BasicMethods

    Private Sub Chat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bm.FillListBox("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ /*union select 0 Id,'-' Name*/ order by Name", Users)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Users.SelectedIndex < 0 Then Return

        Dim Done As Boolean = False
        For Each f As Form In MdiParent.MdiChildren
            If f.Name <> "Chat" Then Continue For
            Dim frm As Chat = f
            'If frm.ToUser = Users.SelectedValue.ToString Then
            '    frm.MdiParent = MdiParent
            '    frm.ToUser = Users.SelectedValue.ToString
            '    frm.Show()
            '    MdiParent.Activate()
            '    If WindowState = FormWindowState.Minimized Then WindowState = FormWindowState.Normal
            '    frm.Activate()
            '    If frm.WindowState = FormWindowState.Minimized Then frm.WindowState = FormWindowState.Normal
            '    Done = True
            'End If
        Next
        If Not Done Then
            Dim frm As New Chat
            frm.MdiParent = MdiParent

            'If Users.SelectedValue.ToString <> "" Then
            '    frm.ToUser = New String() {Users.SelectedValue.ToString}
            'Else
            '    frm.Tbl = Users.DataSource
            'End If

            Dim dt As DataTable = Users.DataSource
            Dim MyUsers() As String = New String() {}
            For i As Integer = 0 To Users.Items.Count - 1
                If Users.GetItemChecked(i) Then
                    ReDim Preserve MyUsers(MyUsers.Length)
                    MyUsers(MyUsers.Length - 1) = dt.Rows(i)("Id").ToString
                End If
            Next
            frm.ToUser = MyUsers

            frm.Show()
            MdiParent.Activate()
            If WindowState = FormWindowState.Minimized Then WindowState = FormWindowState.Normal
            frm.Activate()
            If frm.WindowState = FormWindowState.Minimized Then frm.WindowState = FormWindowState.Normal
        End If

        Close()
    End Sub

    Private Sub Users_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        For i As Integer = 0 To Users.Items.Count - 1
            Users.SetItemChecked(i, CheckBox1.Checked)
        Next
    End Sub
End Class