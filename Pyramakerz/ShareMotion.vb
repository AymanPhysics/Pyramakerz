Public Class ShareMotion

    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "ShareMotion"
    Public MainId As String = "BranchId"
    Public SubId As String = "InvoiceNo"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub SetupCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InvoiceNo.MaxLength = Length

        bm.FillCombo(MainTableName, Branch, "")
        bm.FillCombo("Share", PartnerId, "")
        Dim v() As String = {"BranchId", "InvoiceNo", "PartnerId", "Value", "Notes", "UserName", "MyGetDate", "DayDate"}
        bm.Fields = v

        Dim c() As Control = {Branch, InvoiceNo, PartnerId, Value, Notes, UserName, MyGetDate, DayDate}
        bm.control = c

        Dim k() As String = {MainId, SubId}
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
        bm.FirstLast(New String() {MainId, SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, InvoiceNo.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Dim Generate As Boolean = False
    Dim EnableSave As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        EnableSave = False

        If Branch.SelectedIndex < 1 Then
            Return
        End If

        If PartnerId.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select a Partner ...")
            PartnerId.Focus()
            Return
        End If

        If Val(Value.Text.Trim) = 0 Then
            bm.ShowMSG("Please, Enter a Value ...")
            Value.Focus()
            Return
        End If

        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
        If InvoiceNo.Text.Trim = "" Then
            InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            lblLastEntry.Text = InvoiceNo.Text
            lblLastEntry.BackColor = Color.Red
            Refresh()
            Threading.Thread.Sleep(200)
            Refresh()
            lblLastEntry.BackColor = System.Drawing.Color.FromArgb(192, 192, 0)
            State = BasicMethods.SaveState.Insert
        Else
            bm.TestMistakeOrUpdate(UserName.Text, Name)
        End If

        NewSave()

        If InvoiceNo.Text.Trim = "" Or Branch.SelectedIndex < 1 Then
            Return
        End If

        If Value.Text.Trim = "" Then
            Value.Text = "0"
        End If

        NewSave()

        bm.DefineValues()
        If Not bm.Save(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, InvoiceNo.Text.Trim}, State) Then
            If State = BasicMethods.SaveState.Insert Then
                InvoiceNo.Text = ""
                lblLastEntry.Text = ""
            End If
            Return
        End If
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

        bm.FirstLast(New String() {MainId, SubId}, "Min", dt)
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
            Dim s As String = ""
            Try
                lop = True
                s = Branch.SelectedValue.ToString
                bm.ClearControls()
                Branch.SelectedValue = s
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
            Try
                bm.ApplySecurity(New Control() {DayDate}, False, True, True, False, False, False, True, True, True)
                DayDate.Value = DateTime.Parse(bm.ExecuteScalar("select getdate()"))
            Catch ex As Exception
            End Try
            PartnerId.Focus()
        Catch
        End Try
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, True, True, True, True, False, False, True, True, True)
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
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & InvoiceNo.Text.Trim & "' and " & MainId & " ='" & Branch.SelectedValue.ToString & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, InvoiceNo.Text}, "Back", dt)
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
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, False, True, True, False, False, False, True, True, True)
    End Sub
    Private Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNo.Leave
        If lv Then
            Return
        End If
        lv = True
        InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
        bm.DefineValues()
        Dim dt As New DataTable
        bm.RetrieveAll(New String() {MainId, SubId}, New String() {Branch.SelectedValue.ToString, InvoiceNo.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Branch.KeyDown, InvoiceNo.KeyDown, PartnerId.KeyDown, Value.KeyDown, Notes.KeyDown, UserName.KeyDown, DayDate.KeyDown, PartnerId.KeyDown
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
    Private Sub CboMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.SelectedIndexChanged
        If loplop Then Return
        loplop = True
        Dim i As Integer = Branch.SelectedIndex
        ClearControls()
        Branch.SelectedIndex = i
        loplop = False
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

End Class