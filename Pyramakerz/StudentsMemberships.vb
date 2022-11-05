Public Class StudentsMemberships



    Public MainTableName As String = "Branches"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public TableName As String = "Income"
    'Public MainId As String = "BranchId"
    Public SubId As String = "InvoiceNo"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 1
    Private Sub Income_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InvoiceNo.MaxLength = Length

        bm.FillCombo(MainTableName, Branch, "")
        bm.FillCombo("Memberships", Membership, "")

        bm.FillCombo("select Id,EnName Name from employees where SystemUser=1 union select 0,'-'", UserInserted)
        bm.FillCombo("select Id,EnName Name from employees where Sales=1 union select 0,'-'", Sales)

        Dim v() As String = {"BranchId", "InvoiceNo", "StudentId", "Items", "Value", "Discount", "SpitialOffer", "Payed", "OfferValue", "Notes", "UserName", "MyGetDate", "DayDate", "RealInvoiceNo", "NoOfDays", "Hold", "Flag", "StartDate", "EndDate", "Refundable", "Canceld", "UserInserted", "Sales"}
        bm.Fields = v

        Dim c() As Control = {Branch, InvoiceNo, txtStId, Membership, Value, Discount, SpitialOffer, Payed, OfferValue, Notes, UserName, MyGetDate, DayDate, RealInvoiceNo, NoOfDays, Hold, txtFlag, StartDate, EndDate, Refundable, Canceld, UserInserted, Sales}
        bm.control = c

        Dim k() As String = {SubId}
        bm.KeyFields = k

        bm.TableWhere = " Where Flag=" & Flag.ToString
        bm.AppendWhere = " and Flag=" & Flag.ToString

        bm.Table_Name = TableName
        SpitialOffer_CheckedChanged(Nothing, Nothing)
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

    Dim Generate As Boolean = False
    Dim EnableSave As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        EnableSave = False

        If Branch.SelectedIndex < 1 Then
            Return
        End If

        If Not bm.TestDublicatedInvoices(Branch.SelectedValue.ToString, InvoiceNo.Text.Trim, RealInvoiceNo.Text.Trim, "1") Then Return

        If txtStId.Text.Trim = "" Then
            bm.ShowMSG("Please, Select a Student ...")
            txtStId.Focus()
            Return
        End If

        If Membership.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select an item ...")
            Membership.Focus()
            Return
        End If

        If Notes.Visible And Notes.Text.Trim = "" Then
            bm.ShowMSG("Please, Fill Notes")
            Notes.Focus()
            Return
        End If

        If RealInvoiceNo.Text.Trim = "" Then
            bm.ShowMSG("Please, Fill Real Inv. No ...")
            RealInvoiceNo.Focus()
            Return
        End If


        If Val(Payed.Text) = 0 And Payed.Enabled And Not SpitialOffer.Checked Then
            bm.ShowMSG("Please, Enter avalue")
            Payed.Focus()
            Return
        End If

        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
        If InvoiceNo.Text.Trim = "" Then
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & SubId & ">0")
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
        If OfferValue.Text.Trim = "" Then
            OfferValue.Text = "0"
        End If
        If Discount.Text.Trim = "" Then
            Discount.Text = "0"
        End If
        If Payed.Text.Trim = "" Then
            Payed.Text = "0"
        End If

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

        If Not Hold.Checked And Not Canceld.Checked Then
            bm.ExcuteNonQuery("AddToWaitingFromMemberships", New String() {"StudentId", "MemberShipId", "FromDate", "ToDate"}, New String() {txtStId.Text, Membership.SelectedValue.ToString, bm.ToStrDate(StartDate.Value), bm.ToStrDate(EndDate.Value)})
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
                Branch.SelectedValue = Module1.Branch
            Catch ex As Exception
            Finally
                lop = False
            End Try

            txtFlag.Text = Flag
            btnGenerateInstallment.Visible = True
            UserName.Text = Module1.UserName
            UserInserted.SelectedValue = Module1.UserName
            'Branch.SelectedValue = Module1.Branch
            InvoiceNo.Clear()
            'InvoiceNo.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & Branch.SelectedValue.ToString & "'")
            'If InvoiceNo.Text = "" Then InvoiceNo.Text = "1"
            'InvoiceNo.Text = InvoiceNo.Text.Trim.PadLeft(Length, "0")
            NewId()
            'DepartmentId.Focus()
            Try
                DayDate.Value = DateTime.Parse(bm.ExecuteScalar("select getdate()"))
            Catch ex As Exception
            End Try
            lblStName.Text = ""
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
            'bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & InvoiceNo.Text.Trim & "' and " & MainId & " ='" & Branch.SelectedValue.ToString & "' delete from Installments where " & SubId & "='" & InvoiceNo.Text.Trim & "' and " & MainId & " ='" & Branch.SelectedValue.ToString & "'")
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & InvoiceNo.Text.Trim & "'  delete from Installments where " & SubId & "='" & InvoiceNo.Text.Trim & "'")
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
        btnGenerateInstallment.Visible = False
        txtStId_Leave(Nothing, Nothing)
        Retrive = False
        Calc()
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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Notes.KeyDown, InvoiceNo.KeyDown, Branch.KeyDown, Value.KeyDown, Payed.KeyDown, Remaining.KeyDown, Discount.KeyDown, Membership.KeyDown, DayDate.KeyDown, RealInvoiceNo.KeyDown, StartDate.KeyDown, EndDate.KeyDown, NoOfDays.KeyDown, txtStId.KeyDown, SpitialOffer.KeyDown, OfferValue.KeyDown
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

    Private Sub txtIDKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Payed.KeyPress, Discount.KeyPress, Value.KeyPress, OfferValue.KeyPress
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
        'If loplop Then Return
        'loplop = True
        'Dim i As Integer = Branch.SelectedIndex
        'ClearControls()
        'Branch.SelectedIndex = i
        'loplop = False
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

    Sub Calc() Handles OfferValue.TextChanged, Discount.TextChanged, Payed.TextChanged, Value.TextChanged
        Try
            If Retrive Then Return
            If Value.Text.Trim = "" Then
                Remaining.Clear()
            End If
            Dim a As Decimal
            a = Val(Value.Text.Trim)
            If SpitialOffer.Checked Then
                a = Val(OfferValue.Text.Trim)
            End If

            Dim p As Decimal
            p = Val(Payed.Text.Trim)

            Remaining.Text = Integer.Parse(a - p)
        Catch ex As Exception
            If SpitialOffer.Checked Then
                Remaining.Text = OfferValue.Text.Trim
            Else
                Remaining.Text = Value.Text
            End If
        End Try
    End Sub


    Private Sub btnGenerateInstallment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateInstallment.Click
        Generate = True
        btnSave_Click(Nothing, Nothing)
        Generate = False
        If Not EnableSave Then Return
        Dim frm As New GenerateInstallments
        frm.Branch = Branch.SelectedValue.ToString
        frm.MainInvoiceNo = InvoiceNo.Text
        frm.StudentId = txtStId.Text
        frm.lblTotal.Text = Remaining.Text
        frm.ShowDialog()
        btnGenerateInstallment.Visible = False
    End Sub

    Private Sub Hold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hold.CheckedChanged
        If Hold.Checked Then
            lblStartDate.Visible = False
            StartDate.Visible = False
            lblEndDate.Visible = False
            EndDate.Visible = False
        Else
            lblStartDate.Visible = True
            StartDate.Visible = True
            lblEndDate.Visible = True
            EndDate.Visible = True
        End If
    End Sub

    Private Sub Calc(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoOfDays.TextChanged, StartDate.ValueChanged, Value.TextChanged, Payed.TextChanged, Discount.TextChanged, OfferValue.TextChanged
        Try
            EndDate.Value = Date.Parse(StartDate.Value).AddDays(Integer.Parse(NoOfDays.Text))
        Catch ex As Exception
            EndDate.Value = StartDate.Value
        End Try
    End Sub

    Private Sub Membership_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Membership.SelectedIndexChanged, Branch.SelectedIndexChanged
        Try
            NoOfDays.Text = bm.ExecuteScalar("select D.NoOfDays from MemberShips M left join DurationTypes D on(M.DurationType=D.Id) where M.Id='" & Membership.SelectedValue.ToString & "'")

            Dim dt As DataTable = bm.ExcuteAdapter("select Value,Discount from MemberShipDetails  where Id='" & Membership.SelectedValue.ToString & "' and CountryId='" & Module1.CountryId & "' and CityId='" & Module1.CityId & "'")

            If dt.Rows.Count = 0 Then
                Value.Clear()
                Discount.Clear()
                Return
            End If

            Value.Text = dt.Rows(0)(0).ToString
            Discount.Text = dt.Rows(0)(1).ToString
            Refundable.Text = bm.ExecuteScalar("select Refundable from MemberShips  where Id='" & Membership.SelectedValue.ToString & "'")

            If Value.Text.Trim = "" Then
                Value.Text = 0
            End If
            If Discount.Text.Trim = "" Then
                Discount.Text = 0
            End If


            Try
                dt = New DataTable
                dt = bm.ExcuteAdapter("GetPromotionsSpecialPrice", New String() {"CountryId", "CityId", "DayDate", "OfferType", "DepartmentId", "CategoryId", "Detail"}, New String() {Module1.CountryId, Module1.CityId, bm.ToStrDate(DayDate.Value), "2", "0", "0", Membership.SelectedValue.ToString})
                If dt.Rows.Count > 0 Then
                    Dim s As Integer = Val(dt.Rows(0)(0))
                    If s < Val(Value.Text) Then
                        Value.Text = s
                    End If
                End If
            Catch ex As Exception
            End Try


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnInvSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvSearch.Click
        Dim hh As New HelpFourColumns
        hh.FirstColumn = "BranchId"
        hh.SecondColumn = "Invoice No"
        hh.ThirdColumn = "Real Invoice No"
        hh.FourthColumn = "Student EnName"
        hh.Statement = "select cast(BranchId AS varchar(10)) 'BranchId',dbo.GetBranchName(BranchId) 'BranchName',cast(InvoiceNo AS varchar(10)) InvoiceNo,cast(RealInvoiceNo AS varchar(10)) RealInvoiceNo,dbo.GetStudentEnName(StudentId) EnName from Income where Flag=" & Flag.ToString
        hh.ShowDialog()
        InvoiceNo.Text = hh.SelectedId
        txtID_Leave(Nothing, Nothing)
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

    End Sub

    Private Sub Canceld_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Canceld.CheckedChanged
        If Canceld.Checked Then
            Payed.Text = 0
            Payed.Enabled = False
        Else
            Payed.Enabled = True
        End If
    End Sub


    Private Sub btnIncome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncome.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New Income, "Detail", Location)
        End If
    End Sub

    Private Sub btnStudentsMemberships_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentsMemberships.Click
        'Dim P As Form = Parent.FindForm
        'Close()
        'If Navigate Then
        '    bm.ShowForm(P, StudentsMemberships, "Memberships", Location)
        'End If
    End Sub

    Private Sub btnRemaining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemaining.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New SubIncome, "Remaining", Location)
        End If
    End Sub

    Private Sub btnInstallments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstallments.Click
        Dim P As Form = Parent.FindForm
        Close()
        If Navigate Then
            bm.ShowForm(P, New Installments, "Installments", Location)
        End If
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


    Private Sub SpitialOffer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpitialOffer.CheckedChanged
        If SpitialOffer.Checked Then
            OfferValue.Visible = True
            lblNotes.Visible = True
            Notes.Visible = True
            OfferValue.Clear()
            Notes.Clear()
        Else
            OfferValue.Visible = False
            lblNotes.Visible = False
            Notes.Visible = False
        End If
        Payed.Clear()
        Calc()
    End Sub
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub

End Class
