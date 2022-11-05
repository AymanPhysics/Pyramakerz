Public Class Tasks

    Public TableName As String = "Tasks"
    'Public MainId As String = "BranchId"
    Public SubId As String = "InvoiceNo"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub Income_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InvoiceNo.MaxLength = Length

        bm.FillCombo("select Id,EnName Name from Employees where GeneralManager='1' or Manager='1' or HeadofDepartment='1' or Supervisor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", UserFrom)

        bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", UserTo)

        Dim v() As String = {"InvoiceNo", "UserFrom", "UserTo", "UserName", "MyGetDate", "ServerDate", "Dedline", "Description"}
        bm.Fields = v

        Dim c() As Control = {InvoiceNo, UserFrom, UserTo, UserName, MyGetDate, ServerDate, Dedline, Description}
        bm.control = c

        Dim k() As String = {SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName
        btnNew_Click(sender, e)

        LoadTree()
        ComputerLab_CheckedChanged(Nothing, Nothing)
        UserFrom.SelectedValue = Module1.UserName
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.AppendWhere = " and " & Module1.UserName & " in (UserFrom,UserTo)"
        'bm.FirstLast(new String(){  MainId ,SubId}, "Max", dt)
        bm.FirstLast(New String() {SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.AppendWhere = " and " & Module1.UserName & " in (UserFrom,UserTo)"
        'bm.NextPrevious(new String(){  MainId ,SubId},New String() { Branch.SelectedValue.ToString & InvoiceNo.Text}, "Next", dt)
        bm.NextPrevious(New String() {SubId}, New String() {InvoiceNo.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Dim Generate As Boolean = False
    Dim EnableSave As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If UserFrom.SelectedIndex < 1 Or Description.Text.Trim = "" Then Return

        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
        EnableSave = False

        Dim MyUsers() As String = New String() {}
        If ComputerLab.Checked Then
            For i As Integer = 0 To TreeView1.Nodes(0).Nodes.Count - 1
                For x As Integer = 0 To TreeView1.Nodes(0).Nodes(i).Nodes.Count - 1
                    If TreeView1.Nodes(0).Nodes(i).Nodes(x).Checked Then
                        ReDim Preserve MyUsers(MyUsers.Length)
                        MyUsers(MyUsers.Length - 1) = TreeView1.Nodes(0).Nodes(i).Nodes(x).Name
                    End If
                Next
            Next
        Else
            If UserTo.SelectedIndex > 0 Then
                ReDim Preserve MyUsers(MyUsers.Length)
                MyUsers(MyUsers.Length - 1) = UserTo.SelectedValue.ToString
            End If
        End If


        If MyUsers.Length = 0 Then Return

        For i As Integer = 0 To MyUsers.Length - 1
            Try

                If InvoiceNo.Text.Trim = "" Then
                    InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName)
                    If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
                    InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
                    lblLastEntry.Text = InvoiceNo.Text
                    lblLastEntry.BackColor = Color.Red
                    Refresh()
                    Threading.Thread.Sleep(200)
                    Refresh()
                    lblLastEntry.BackColor = System.Drawing.Color.FromArgb(192, 192, 0)
                    State = BasicMethods.SaveState.Insert
                End If

                If InvoiceNo.Text.Trim = "" Then Return

                UserTo.SelectedValue = MyUsers(i)
                NewSave()
                bm.DefineValues()
                If Not bm.Save(New String() {SubId}, New String() {InvoiceNo.Text.Trim}, State) Then
                    If State = BasicMethods.SaveState.Insert Then
                        InvoiceNo.Text = ""
                        lblLastEntry.Text = ""
                    End If
                    bm.ShowMSG("Employee [" & UserTo.Text & "] Not Saved ...")
                End If
            Catch ex As Exception

            End Try
            InvoiceNo.Text = ""
        Next



        EnableSave = True
        If Not Generate Then
            btnNew_Click(sender, e)
        End If

        AllowClose = True
    End Sub
    Sub NewSave()
        UserName.Text = Module1.UserName
        UserName.BackColor = Color.Red
        UserName.ForeColor = Color.Blue
        Refresh()
        Threading.Thread.Sleep(200)
        UserName.BackColor = Color.White
        UserName.ForeColor = Color.Red
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        bm.AppendWhere = " and " & Module1.UserName & " in (UserFrom,UserTo)"
        'bm.FirstLast(new String(){  MainId ,SubId}, "Min", dt)
        bm.FirstLast(New String() {SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearControls()
    End Sub
    Dim lop As Boolean = False
    Sub ClearControls()
        If lop Then Return
        Try
            Try
                lop = True
                bm.ClearControls()
            Catch ex As Exception
            Finally
                lop = False
            End Try

            UserName.Text = Module1.UserName
            'Branch.SelectedValue = Module1.Branch
            InvoiceNo.Clear()
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            'If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            'InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            NewId()
            UserFrom.Focus()
            ServerDate.Value = bm.ExecuteScalar("select GetDate()")
        Catch
        End Try
        ComputerLab.Checked = False
        ComputerLab.Visible = True
        btnSave.Enabled = True
    End Sub

    Sub NewId()
        InvoiceNo.Clear()
        InvoiceNo.Enabled = False
    End Sub

    Sub UndoNewId()
        InvoiceNo.Enabled = True
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & InvoiceNo.Text.Trim & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.AppendWhere = " and " & Module1.UserName & " in (UserFrom,UserTo)"
        'bm.NextPrevious(new String(){  MainId ,SubId},New String() { Branch.SelectedValue.ToString & InvoiceNo.Text}, "Back", dt)
        bm.NextPrevious(New String() {SubId}, New String() {InvoiceNo.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub
    Dim lv As Boolean = False
    Dim Retrive As Boolean = False
    Sub FillControls()
        UndoNewId()
        Retrive = True
        bm.FillControls()
        Retrive = False
        btnSave.Enabled = False
        ComputerLab.Checked = False
        ComputerLab.Visible = False
    End Sub
    Public Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNo.Leave
        bm.AppendWhere = " and " & Module1.UserName & " in (UserFrom,UserTo)"
        If lv Then
            Return
        End If
        lv = True
        InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
        bm.DefineValues()
        Dim dt As New DataTable
        'bm.RetrieveAll(new String(){  MainId ,SubId},New String() { Branch.SelectedValue.ToString & InvoiceNo.Text.Trim}, dt)
        bm.RetrieveAll(New String() {SubId}, New String() {InvoiceNo.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InvoiceNo.KeyDown, UserTo.KeyDown, UserFrom.KeyDown, ServerDate.KeyDown, Dedline.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InvoiceNo.KeyPress
        If e.KeyChar = "" OrElse Asc(e.KeyChar.ToString.Substring(0)) = 22 OrElse Asc(e.KeyChar.ToString.Substring(0)) = 3 Then
            Return
        End If
        Dim s As New TextBox
        s = sender
        If e.KeyChar = "." And Not s.Text.Contains(".") And s.Name = "Value" Then
            Return
        End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Dim loplop As Boolean = False

    Dim AllowClose As Boolean = False
    Dim Navigate As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not btnSave.Enabled Then Exit Sub
        Select Case bm.RequestDelete
            Case BasicMethods.CloseState.Yes
                AllowClose = False
                btnSave_Click(Nothing, Nothing)
                If AllowClose Then
                    Navigate = True
                Else
                    e.Cancel = True
                End If
            Case BasicMethods.CloseState.No
                Navigate = True
            Case BasicMethods.CloseState.Cancel
                e.Cancel = True
        End Select
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where GeneralManager='1' or Manager='1' or HeadofDepartment='1' or Supervisor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        UserFrom.SelectedValue = hh.SelectedId
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where SystemUser='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        UserTo.SelectedValue = hh.SelectedId
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

    Private Sub ComputerLab_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputerLab.CheckedChanged
        If ComputerLab.Checked Then
            UserTo.SelectedIndex = 0
            UserTo.Enabled = False
            Button1.Enabled = False
            TreeView1.Visible = True
        Else
            UserTo.Enabled = True
            Button1.Enabled = True
            TreeView1.Visible = False
            TreeView1.Nodes(0).Checked = False
        End If
    End Sub

    Private Sub TreeView1_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
        Try
            For Each nn As TreeNode In e.Node.Nodes
                nn.Checked = e.Node.Checked
            Next
        Catch
        End Try
    End Sub

End Class