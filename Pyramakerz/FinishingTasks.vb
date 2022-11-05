Public Class FinishingTasks


    Public TableName As String = "Tasks"
    'Public MainId As String = "BranchId"
    Public SubId As String = "InvoiceNo"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0

    Private Sub FinishingTasks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InvoiceNo.MaxLength = Length

        bm.FillCombo("select Id,EnName Name from Employees where GeneralManager='1' or Manager='1' or HeadofDepartment='1' or Supervisor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", UserFrom)

        Dim v() As String = {"InvoiceNo", "UserFrom", "ServerDate", "Dedline", "Description", "Notes"}
        bm.Fields = v

        Dim c() As Control = {InvoiceNo, UserFrom, ServerDate, Dedline, Description, Notes}
        bm.control = c

        Dim k() As String = {SubId}
        bm.KeyFields = k

        bm.TableWhere = " Where (Done='0' or Done is null) and Dedline+1>GETDATE() and UserTo='" & Module1.UserName & "'"
        bm.AppendWhere = " and (Done='0' or Done is null) and Dedline+1>GETDATE() and UserTo='" & Module1.UserName & "'"

        bm.Table_Name = TableName
        btnNew_Click(sender, e)

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

    Dim Generate As Boolean = False
    Dim EnableSave As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If InvoiceNo.Text.Trim = "" Then
            Return
        End If

        If bm.ShowDeleteMSG("Are you sure you had FINISHED this Task?") Then
            bm.ExcuteNonQuery("update Tasks set Done='1',Notes='" & Notes.Text.Trim & "',DoneDate=GetDate() where InvoiceNo='" & InvoiceNo.Text & "'")

            bm.ExcuteNonQuery("insert into Messages(FromUser,ToUser,Details,Daydate,Done) select '" & Module1.UserName & "','" & UserFrom.SelectedValue.ToString & "','Automatic message: User [" & Module1.UserName & " : " & Module1.EnName & "] has finished the task [Id : " & InvoiceNo.Text.Trim & "]',GETDATE(),'0'")

            btnNew_Click(sender, e)
        End If



    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        'bm.FirstLast(new String(){  MainId ,SubId}, "Min", dt)
        bm.FirstLast(New String() {SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            NewId()
            UserFrom.Focus()
        Catch
        End Try
    End Sub

    Sub NewId()
        InvoiceNo.Clear()
        InvoiceNo.Enabled = False
    End Sub

    Sub UndoNewId()
        InvoiceNo.Enabled = True
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
    End Sub
    Public Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNo.Leave
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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InvoiceNo.KeyDown, UserFrom.KeyDown, ServerDate.KeyDown, Dedline.KeyDown
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

End Class