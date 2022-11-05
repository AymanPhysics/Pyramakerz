Public Class Outcome

    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "Outcome"
    Public MainId As String = "BranchId"
    Public SubId As String = "InvoiceNo"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Private Sub ApplyDeduction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyDeduction.CheckedChanged
        Try
            If ApplyDeduction.Checked Then
                If lblTotalPayed.Text = "" Then lblTotalPayed.Text = 0
                Dim s As String = Val(bm.ExecuteScalar("select DeductionValue from Statics") / 100)
                Dim z As Decimal = Decimal.Parse(lblTotalPayed.Text) - Val(lblTatalInvValue.Text) * s
                Value.Text = Decimal.Round(z, 0)
            Else
                Value.Text = lblTotalPayed.Text
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub Outcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Module1.MyProject = Project.EFG Then
            btnPutInBank.Visible = False
            btnSetupCost.Visible = False
            btnCharity.Visible = False
        End If

        InvoiceNo.MaxLength = Length

        bm.FillCombo(MainTableName, Branch, "")
        bm.FillCombo("select Id,Name from OutcomeReasons union select 0 Id,'-' Name union select -1 Id,'Refund' Name order by Name", OutcomeReason)

        bm.FillCombo("select Id,Name from RefundReasons union select -1 Id,'Other' Name union select 0 Id,'-' Name order by Id", RefundReason)
        Dim v() As String = {"BranchId", "InvoiceNo", "RealInvoiceNo", "StudentId", "DayDate", "OutcomeReasonId", "RefundReason", "Other", "MainInvoiceNo", "ApplyDeduction", "Value", "Notes", "UserName", "MyGetDate", "HasRealInvNo", "Cash", "SheekNo", "SheekPerson", "SheekDate", "NotRealInvoice", "IsSalary", "Canceled"}
        bm.Fields = v

        Dim c() As Control = {Branch, InvoiceNo, RealInvoiceNo, txtStId, DayDate, OutcomeReason, RefundReason, Other, MainInvoiceNo, ApplyDeduction, Value, Notes, UserName, MyGetDate, HasRealInvNo, Cash, SheekNo, SheekPerson, SheekDate, NotRealInvoice, IsSalary, Canceld}
        bm.control = c

        Dim k() As String = {SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName
        btnNew_Click(sender, e)
        Branch.SelectedValue = Module1.Branch
        RefundReason_SelectedIndexChanged(Nothing, Nothing)

        bm.ApplySecurity(New Control() {DayDate}, False, True, True, False, False, False, True, True, True)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.FirstLast(New String() {SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {SubId}, New String() {InvoiceNo.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Branch.SelectedIndex < 1 Then
            Return
        End If

        If Not bm.TestDublicatedInvoices(Branch.SelectedValue.ToString, InvoiceNo.Text.Trim, RealInvoiceNo.Text.Trim, "O") Then Return

        If Val(Value.Text) = 0 Then
            bm.ShowMSG("Please, Enter avalue")
            Value.Focus()
            Return
        End If

        If RealInvoiceNo.Text.Trim = "" Then
            bm.ShowMSG("Please, Fill Real Inv. No ...")
            RealInvoiceNo.Focus()
            Return
        End If

        If OutcomeReason.SelectedValue.ToString = -1 And MainInvoiceNo.SelectedValue Is Nothing Then
            bm.ShowMSG("Please, Select Main Inv. No ...")
            MainInvoiceNo.Focus()
            Return
        End If

        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
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
        Else
            bm.TestMistakeOrUpdate(UserName.Text, Name)
        End If

        If InvoiceNo.Text.Trim = "" Or Branch.SelectedIndex < 1 Then
            Return
        End If

        If Value.Text.Trim = "" Then
            Value.Text = "0"
        End If

        NewSave()

        bm.DefineValues()
        If Not bm.Save(New String() {SubId}, New String() {InvoiceNo.Text.Trim}, State) Then
            If State = BasicMethods.SaveState.Insert Then
                InvoiceNo.Text = ""
                lblLastEntry.Text = ""
            End If
            Return
        End If

        If OutcomeReason.SelectedValue.ToString = -1 Then
            bm.ExcuteNonQuery("RemoveWaitingFromRefund", New String() {"StudentId", "InvoiceNo"}, New String() {txtStId.Text, MainInvoiceNo.SelectedValue.ToString})
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
            Try
                DayDate.Value = DateTime.Parse(bm.ExecuteScalar("select getdate()"))
            Catch ex As Exception
            End Try

            UserName.Text = Module1.UserName
            'Branch.SelectedValue = Module1.Branch
            InvoiceNo.Clear()
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            'If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            'InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            NewId()
            lblStName.Text = ""
            ' OutcomeReason.Focus()
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
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & InvoiceNo.Text.Trim & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
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
        bm.RetrieveAll(New String() {SubId}, New String() {InvoiceNo.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Branch.KeyDown, InvoiceNo.KeyDown, OutcomeReason.KeyDown, Value.KeyDown, Notes.KeyDown, UserName.KeyDown, DayDate.KeyDown, HasRealInvNo.KeyDown, Cash.KeyDown, SheekNo.KeyDown, SheekPerson.KeyDown, SheekDate.KeyDown, NotRealInvoice.KeyDown, Sheek.KeyDown, RadioButton1.KeyDown, txtStId.KeyDown, RefundReason.KeyDown, RealInvoiceNo.KeyDown, Other.KeyDown, MainInvoiceNo.KeyDown, ApplyDeduction.KeyDown, IsSalary.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InvoiceNo.KeyPress, RealInvoiceNo.KeyPress
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
    Private Sub txtID_KeyPress2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Value.KeyPress
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
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Cash.Text = "1"
            SheekNo.Visible = False
            SheekPerson.Visible = False
            SheekDate.Visible = False
            lblSheekNo.Visible = False
            lblSheekPerson.Visible = False
            lblSheekDate.Visible = False
            SheekNo.Clear()
            SheekPerson.Clear()
            SheekDate.Value = Now
        Else
            Cash.Text = "2"
            SheekNo.Visible = True
            SheekPerson.Visible = True
            SheekDate.Visible = True
            lblSheekNo.Visible = True
            lblSheekPerson.Visible = True
            lblSheekDate.Visible = True
        End If
    End Sub
    Private Sub Cash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cash.TextChanged
        If Cash.Text = "1" Then
            RadioButton1.Checked = True
        Else
            Sheek.Checked = True
        End If
    End Sub


    Private Sub btnOutcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutcome.Click
        'Dim P As Form = Parent.FindForm
        'Close()
        'If Navigate Then
        '    bm.ShowForm(P, Outcome, "Outcome", Location)
        'End If
    End Sub

    Private Sub btnPutInBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPutInBank.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New PutInBank, "PutInBank", Location)
        End If
    End Sub

    Private Sub btnSetupCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetupCost.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New SetupCost, "SetupCost", Location)
        End If
    End Sub



    Private Sub RefundReason_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundReason.SelectedIndexChanged
        Try
            If RefundReason.SelectedValue.ToString = -1 And RefundReason.Visible Then
                Other.Visible = True
            Else
                Other.Visible = False
                Other.Clear()
            End If
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

    Private Sub StudentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim s As String = ""
            Try
                s = MainInvoiceNo.SelectedValue.ToString
            Catch ex As Exception
            End Try
            MainInvoiceNo.DataSource = Nothing
            Dim dt As DataTable = bm.ExcuteAdapter("select * from Income where StudentId='" & txtStId.Text & "' and Refundable='1'")
            MainInvoiceNo.DataSource = dt
            MainInvoiceNo.DisplayMember = "InvoiceNo"
            MainInvoiceNo.ValueMember = "InvoiceNo"
            lblTotalPayed.Text = ""
            Try
                MainInvoiceNo.SelectedValue = s
            Catch ex As Exception
            End Try
            MainInvoiceNo_SelectedIndexChanged(Nothing, Nothing)

        Catch
        End Try
    End Sub

    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            txtStId_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MainInvoiceNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainInvoiceNo.SelectedIndexChanged
        Try
            lblTotalPayed.Text = bm.ExecuteScalar("GetRefundValue", New String() {"MainInvoiceNo", "RefundInvoiceNo", "StudentId"}, New String() {MainInvoiceNo.SelectedValue.ToString, InvoiceNo.Text, txtStId.Text})
            lblTatalInvValue.Text = bm.ExecuteScalar("select (case when SpitialOffer='1' then OfferValue else Value end) from Income where InvoiceNo='" & MainInvoiceNo.SelectedValue.ToString & "'")
        Catch ex As Exception
            lblTotalPayed.Text = ""
            lblTatalInvValue.Text = ""
        End Try
        ApplyDeduction_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub OutcomeReason_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutcomeReason.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = OutcomeReason.SelectedValue
            s = "-1"
        Catch ex As Exception
            s = "s"
        End Try
        If s = "-1" AndAlso OutcomeReason.SelectedValue.ToString = -1 Then
            Size = New Size(1080, 427)
            txtStId.Visible = True
            lblStId.Visible = True
            lblStName.Visible = True
            btnStSearch.Visible = True
            lblRefundReason.Visible = True
            RefundReason.Visible = True
            lblMainInvoiceNo.Visible = True
            MainInvoiceNo.Visible = True
            lblTotalPayed.Visible = True
            Label8.Visible = True
            lblTatalInvValue.Visible = True
            lblApplyDeduction.Visible = True
            ApplyDeduction.Visible = True
            Value.Enabled = False

            If (Module1.SystemAdmin = Module1.UserName) Or _
              (Module1.GeneralManager = "1") Or _
              (Module1.Board = "1") Or _
              (Module1.Manager = "1") Or _
              (Module1.HeadOfDepartment = "1") Or _
              (Module1.Supervisor = "1") Or _
              (Module1.Accountant = "1") Or _
              (Module1.MyChildCountry = Module1.CountryId) Or _
              (Module1.MyChildCityCountry = Module1.CountryId And Module1.MyChildCity = Module1.CityId) Then
                Value.Enabled = True
            Else
                Value.Enabled = False
            End If

            Value.Clear()
        Else
            Size = New Size(901, 427)
            txtStId.Visible = False
            txtStId.Clear()
            lblStId.Visible = False
            lblStName.Visible = False
            txtStId.Clear()
            btnStSearch.Visible = False
            lblRefundReason.Visible = False
            RefundReason.Visible = False
            RefundReason.SelectedValue = 0
            lblMainInvoiceNo.Visible = False
            MainInvoiceNo.Visible = False
            MainInvoiceNo.SelectedValue = 0
            lblTotalPayed.Visible = False
            lblTotalPayed.Text = ""
            Label8.Visible = False
            lblTatalInvValue.Visible = False
            lblTatalInvValue.Text = ""
            lblApplyDeduction.Visible = False
            ApplyDeduction.Visible = False
            ApplyDeduction.Checked = False
            Value.Enabled = True
        End If

    End Sub
    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
    End Sub

    Private Sub txtStId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.TextChanged
        'If txtStId.Text.Length = 6 Then
        'txtStId_Leave(Nothing, Nothing)
        'End If
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

    Private Sub btnCharity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCharity.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New Charity(), "Charity", Location)
        End If
    End Sub

    Private Sub btnInvSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvSearch.Click
        Dim hh As New HelpFourColumns
        hh.FirstColumn = "BranchId"
        hh.SecondColumn = "Invoice No"
        hh.ThirdColumn = "Real Invoice No"
        hh.FourthColumn = "Student EnName"
        hh.Statement = "select cast(BranchId AS varchar(10)) 'BranchId',dbo.GetBranchName(BranchId) 'BranchName',cast(InvoiceNo AS varchar(10)) InvoiceNo,cast(RealInvoiceNo AS varchar(10)) RealInvoiceNo,dbo.GetStudentEnName(StudentId) EnName from Outcome"
        hh.ShowDialog()
        InvoiceNo.Text = hh.SelectedId
        txtID_Leave(Nothing, Nothing)
    End Sub

    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class