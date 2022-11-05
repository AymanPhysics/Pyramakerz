Public Class Inventory2

    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "Inventory2"
    'Public MainId As String = "BranchId"
    Public SubId As String = "InvoiceNo"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub SubIncome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InvoiceNo.MaxLength = Length

        bm.FillCombo(MainTableName, FromBranch, "")
        bm.FillCombo(MainTableName, ToBranch, "")
        bm.FillCombo("Departments", DepartmentId, "")

        Dim v() As String = {"FromBranchId", "ToBranchId", "InvoiceNo", "Type", "DepartmentId", "CategoryId", "Items", "Cnt", "Notes", "UserName", "MyGetDate", "DayDate"}
        bm.Fields = v


        Dim c() As Control = {FromBranch, ToBranch, InvoiceNo, Type, DepartmentId, CategoryId, ItemId, Cnt, Notes, UserName, MyGetDate, DayDate}
        bm.control = c

        Dim k() As String = {SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName
        btnNew_Click(sender, e)
        FromBranch.SelectedValue = Module1.Branch

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        'bm.FirstLast(new String(){  MainId ,SubId}, "Max", dt)
        bm.FirstLast(New String() {SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'bm.NextPrevious(new String(){  MainId ,SubId},New String() { Branch.SelectedValue.ToString & InvoiceNo.Text}, "Next", dt)
        bm.NextPrevious(New String() {SubId}, New String() {InvoiceNo.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If FromBranch.SelectedIndex < 1 Then
            Return
        End If

        If Val(Cnt.Text) = 0 Then
            bm.ShowMSG("Please, Enter avalue")
            Cnt.Focus()
            Return
        End If

        If Type.SelectedIndex < 0 Then
            bm.ShowMSG("Please, Select Category ...")
            Type.Focus()
            Return
        End If

        If Cnt.Text.Trim = "" Then
            Cnt.Text = "0"
        End If
        '''''''''
        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
        If InvoiceNo.Text.Trim = "" Then
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
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

        If InvoiceNo.Text.Trim = "" Or FromBranch.SelectedIndex < 1 Then
            Return
        End If

        '''''''''''''''''''
        NewSave()
        bm.DefineValues()
        'If Not bm.Save(new String(){  MainId ,SubId},New String() { Branch.SelectedValue.ToString & InvoiceNo.Text.Trim}) Then Return
        If Not bm.Save(New String() {SubId}, New String() {InvoiceNo.Text.Trim}, State) Then
            If State = BasicMethods.SaveState.Insert Then
                InvoiceNo.Text = ""
                lblLastEntry.Text = ""
            End If
            Return
        End If
        btnNew_Click(sender, e)
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

        'bm.FirstLast(new String(){  MainId ,SubId}, "Min", dt)
        bm.FirstLast(New String() {SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim s As String = ""
        Try
            s = FromBranch.SelectedValue.ToString
        Catch ex As Exception
        End Try

        'bm.ClearControls()
        Cnt.Clear()
        Notes.Clear()
        MyGetDate.Clear()

        Try
            FromBranch.SelectedValue = s
        Catch ex As Exception
        End Try

        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            UserName.Text = Module1.UserName
            'Branch.SelectedValue = Module1.Branch
            InvoiceNo.Clear()
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName)
            If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            Type.Focus()
            NewId()
            Type.DataSource = Nothing
        Catch
        End Try
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, True, True, True, False, False, False, False, True, False)
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
            'bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & InvoiceNo.Text.Trim & "' and " & MainId & " ='" & Branch.SelectedValue.ToString & "'")
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & InvoiceNo.Text.Trim & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
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
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, False, True, True, False, False, False, False, True, False)
    End Sub
    Private Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNo.Leave
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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Notes.KeyDown, InvoiceNo.KeyDown, FromBranch.KeyDown, Cnt.KeyDown, Type.KeyDown, DayDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InvoiceNo.KeyPress, Cnt.KeyPress
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




    Private Sub DepartmentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Categories", CategoryId, " where DepartmentId='" & s & "'")
    End Sub

    Private Sub CategoryId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryId.SelectedIndexChanged
        Dim s As Integer = Type.SelectedIndex + 1
        Dim s1 As String = ""
        Try
            s1 = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s2 As String = ""
        Try
            s2 = CategoryId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Items", ItemId, " where DepartmentId='" & s1 & "' and CategoryId='" & s2 & "' and Course='" & s.ToString & "' and Course in('2','3')")
    End Sub

    Private Sub Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Type.SelectedIndexChanged
        If Type.SelectedIndex = 1 Or Type.SelectedIndex = 2 Then
            lblDepartmentId.Visible = True
            DepartmentId.Visible = True
            lblCategoryId.Visible = True
            CategoryId.Visible = True
            lblItemId.Visible = True
            ItemId.Visible = True
        Else
            lblDepartmentId.Visible = False
            DepartmentId.Visible = False
            lblCategoryId.Visible = False
            CategoryId.Visible = False
            lblItemId.Visible = False
            ItemId.Visible = False

            DepartmentId.SelectedValue = 0
        End If
        CategoryId_SelectedIndexChanged(Nothing, Nothing)
    End Sub


    Dim AllowClose As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub PlusMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Cnt.Text.StartsWith("-") Then
            Cnt.Text = Cnt.Text.Substring(1)
        Else
            Cnt.Text = "-" & Cnt.Text
        End If
    End Sub
End Class