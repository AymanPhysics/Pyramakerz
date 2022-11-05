Public Class PreChat2
    Dim bm As New BasicMethods
    Private Sub PreChat2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTree()
    End Sub

    Private Sub LoadTree()
        TreeView1.Nodes.Add("0", "Employees", 2, 2)
        Dim dt As DataTable = bm.ExcuteAdapter("select Id,Name from Jobs where Id in(select distinct JobId from Employees where SystemUser='1' and Stopped='0') order by Name")
        Dim dt2 As DataTable = bm.ExcuteAdapter("select Id,EnName Name,JobId,(case when dateadd(SECOND,15,LastConnect)>GETDATE() then 1 else 0 end) State from Employees where SystemUser='1' and Stopped='0' order by Name")

        For i As Integer = 0 To dt.Rows.Count - 1
            TreeView1.Nodes(0).Nodes.Add(dt.Rows(i)(0), dt.Rows(i)(1), 2, 2)
            Dim dr() As DataRow = dt2.Select("JobId=" & dt.Rows(i)(0))
            For x As Integer = 0 To dr.Length - 1
                TreeView1.Nodes(0).Nodes(i).Nodes.Add(dr(x)(0).ToString, dr(x)(1), dr(x)(3), dr(x)(3))
            Next
        Next
        TreeView1.Nodes(0).Expand()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim frm As New Chat
        frm.MdiParent = MdiParent
        Dim MyUsers() As String = New String() {}
        For i As Integer = 0 To TreeView1.Nodes(0).Nodes.Count - 1
            For x As Integer = 0 To TreeView1.Nodes(0).Nodes(i).Nodes.Count - 1
                If TreeView1.Nodes(0).Nodes(i).Nodes(x).Checked Then
                    ReDim Preserve MyUsers(MyUsers.Length)
                    MyUsers(MyUsers.Length - 1) = TreeView1.Nodes(0).Nodes(i).Nodes(x).Name
                End If
            Next
        Next
        If MyUsers.Length = 0 Then Return

        frm.ToUser = MyUsers
        frm.Show()
        MdiParent.Activate()
        If WindowState = FormWindowState.Minimized Then WindowState = FormWindowState.Normal
        frm.Activate()
        If frm.WindowState = FormWindowState.Minimized Then frm.WindowState = FormWindowState.Normal
        Close()
    End Sub

    Private Sub TreeView1_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
        Try
            For Each nn As TreeNode In e.Node.Nodes
                nn.Checked = e.Node.Checked
            Next
        Catch
        End Try
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        If e.Node.Level < 2 Then Return
        Dim frm As New Chat
        frm.MdiParent = MdiParent
        Dim MyUsers() As String = New String() {}
        ReDim Preserve MyUsers(MyUsers.Length)
        MyUsers(MyUsers.Length - 1) = e.Node.Name
        If MyUsers.Length = 0 Then Return

        frm.ToUser = MyUsers
        frm.Show()
        MdiParent.Activate()
        If WindowState = FormWindowState.Minimized Then WindowState = FormWindowState.Normal
        frm.Activate()
        If frm.WindowState = FormWindowState.Minimized Then frm.WindowState = FormWindowState.Normal
        Close()
    End Sub
End Class