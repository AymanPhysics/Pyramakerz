Public Class Installments

    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "Installments"
    '    Public MainId As String = "BranchId"
    Public SubId As String = "InvoiceNo"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub Inistallments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Branch.SelectedValue = Module1.Branch
        InvoiceNo.MaxLength = Length

        bm.FillCombo("select Id,EnName Name from employees where SystemUser=1 union select 0,'-'", UserInserted)
        bm.FillCombo("select Id,EnName Name from employees where Sales=1 union select 0,'-'", Sales)

        bm.FillCombo(MainTableName, Branch, "")

        Dim v() As String = {"BranchId", "StudentId", "InvoiceNo", "MainInvoiceNo", "Value", "Notes", "UserName", "MyGetDate", "DayDate", "Haspayed", "PayedDate", "RealInvoiceNo", "UserInserted", "Sales"}
        bm.Fields = v

        Dim c() As Control = {Branch, txtStId, InvoiceNo, MainInvoiceNo, Value, Notes, UserName, MyGetDate, DayDate, Haspayed, PayedDate, RealInvoiceNo, UserInserted, Sales}
        bm.control = c

        Dim k() As String = {SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName
        btnNew_Click(sender, e)
        Branch.SelectedValue = Module1.Branch

        bm.ApplySecurity(New Control() {DayDate}, False, True, True, False, False, False, True, True, True)
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
        If InvoiceNo.Text.Trim = "" Or Branch.SelectedIndex < 1 Then
            Return
        End If

        If Not bm.TestDublicatedInvoices(Branch.SelectedValue.ToString, InvoiceNo.Text.Trim, RealInvoiceNo.Text.Trim, "I") Then Return

        If MainInvoiceNo.SelectedIndex < 0 Then
            bm.ShowMSG("Please, Select Main Invoice No ...")
            MainInvoiceNo.Focus()
            Return
        End If

        If RealInvoiceNo.Text.Trim = "" Then
            bm.ShowMSG("Please, Fill Real Inv. No ...")
            RealInvoiceNo.Focus()
            Return
        End If

        If Value.Text.Trim = "" Then
            Value.Text = "0"
        End If

        bm.TestMistakeOrUpdate(UserName.Text, Name)

        NewSave()
        bm.DefineValues()
        'If Not bm.Save(new String(){  MainId ,SubId},New String() { Branch.SelectedValue.ToString & InvoiceNo.Text.Trim}) Then Return
        If Not bm.Save(New String() {SubId}, New String() {InvoiceNo.Text.Trim}) Then Return
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

        bm.ClearControls()
        Branch.SelectedValue = Module1.Branch
        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            UserName.Text = Module1.UserName
            UserInserted.SelectedValue = Module1.UserName
            'Branch.SelectedValue = Module1.Branch
            InvoiceNo.Clear()
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName)
            If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            MainInvoiceNo.Focus()
            lblStName.Text = ""
            Try
                DayDate.Value = DateTime.Parse(bm.ExecuteScalar("select getdate()"))
            Catch ex As Exception
            End Try
            MainInvoiceNo.DataSource = Nothing
        Catch
        End Try
        If Haspayed.Checked Then bm.ApplySecurity(New Button() {btnSave, btnDelete}, True, True, True, True, False, False, True, True, True)
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
        Retrive = True
        bm.FillControls()
        Haspayed_CheckedChanged(Nothing, Nothing)
        txtStId_Leave(Nothing, Nothing)
        Retrive = False
        If Haspayed.Checked Then bm.ApplySecurity(New Button() {btnSave, btnDelete}, False, True, True, False, False, False, True, True, True)
    End Sub
    Friend Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNo.Leave
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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Notes.KeyDown, InvoiceNo.KeyDown, Branch.KeyDown, Value.KeyDown, MainInvoiceNo.KeyDown, DayDate.KeyDown, PayedDate.KeyDown, Haspayed.KeyDown, txtStId.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InvoiceNo.KeyPress, txtStId.KeyPress, RealInvoiceNo.KeyPress
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


    Private Sub txtIDKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Value.KeyPress
        If e.KeyChar = "" OrElse Asc(e.KeyChar.ToString.Substring(0)) = 22 OrElse Asc(e.KeyChar.ToString.Substring(0)) = 3 Then
            Return
        End If
        Dim s As New TextBox
        s = sender
        If e.KeyChar = "." And Not s.Text.Contains(".") Then
            Return
        End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Dim loplop As Boolean = False
    'Private Sub CboMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.SelectedIndexChanged
    '    If loplop Then Return
    '    loplop = True
    '    Dim i As Integer = Branch.SelectedIndex
    '    ClearControls()
    '    Branch.SelectedIndex = i
    '    loplop = False
    'End Sub


    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            txtStId_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub StudentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As String = ""
        Try
            s = MainInvoiceNo.SelectedValue.ToString
        Catch ex As Exception
        End Try

        Try
            MainInvoiceNo.DataSource = Nothing
            'Dim dt As DataTable = bm.ExcuteAdapter("GetInstallments", New String() {"BranchId", "StudentId"}, New String() {Branch.SelectedValue.ToString, StudentId.SelectedValue.ToString})
            'Dim dt As DataTable = bm.ExcuteAdapter("GetInstallments", New String() {"StudentId"}, New String() {txtStId.Text})
            Dim dt As DataTable = bm.ExcuteAdapter("GetInstallments2", New String() {"StudentId"}, New String() {txtStId.Text})
            MainInvoiceNo.DataSource = dt
            MainInvoiceNo.DisplayMember = "MainInvoiceNo"
            MainInvoiceNo.ValueMember = "MainInvoiceNo"
        Catch
        End Try

        Try
            MainInvoiceNo.SelectedValue = s
        Catch ex As Exception
        End Try

    End Sub


    Private Sub Haspayed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Haspayed.CheckedChanged
        If Haspayed.Checked Then
            PayedDate.Visible = True
        Else
            PayedDate.Visible = False
        End If
    End Sub

    Private Sub btnInvSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvSearch.Click
        Try
            Dim frm As New InstallmentsSearch
            frm.TopMost = TopMost
            'frm.Branch = Branch.SelectedValue.ToString
            frm.ShowDialog()
            InvoiceNo.Text = frm.InvNo
            txtID_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        Try
            lblStName.Text = ""
            If txtStId.Text.Trim = "" Then Return
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
        Catch ex As Exception
        End Try
        FillStName()
        StudentId_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub btnIncome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncome.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New Income, "Detail", Location)
        End If
    End Sub

    Private Sub btnStudentsMemberships_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentsMemberships.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New StudentsMemberships, "Memberships", Location)
        End If
    End Sub

    Private Sub btnRemaining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemaining.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New SubIncome, "Remaining", Location)
        End If
    End Sub

    Private Sub btnInstallments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstallments.Click
        'Dim P As Form = Parent.FindForm
        'Close()
        'If Navigate Then
        '    bm.ShowForm(P, Installments, "Installments", Location)
        'End If
    End Sub
    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
    End Sub

    Private Sub btnBundle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBundle.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New StudentsBundle, "Bundle", Location)
        End If
    End Sub

    Private Sub txtStId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.TextChanged
        'If txtStId.Text.Length = 6 Then
        'txtStId_Leave(Nothing, Nothing)
        'End If
        If Retrive Then
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub


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
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class