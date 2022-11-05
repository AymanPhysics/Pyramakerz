Public Class Promotions

    Public MainTableName As String = "Countries"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"


    Public Main2TableName As String = "Cities"
    Public Main2MainId As String = "CountryId"
    Public Main2SubId As String = "Id"
    Public Main2SubName As String = "Name"

    Public TableName As String = "Promotions"
    Public MainId As String = "CountryId"
    Public MainId2 As String = "CityId"
    Public SubId As String = "Id"
    Public SubName As String = "Name"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Private Sub Promotions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.MaxLength = Length

        bm.FillCombo(MainTableName, CboMain, "")
        bm.FillCombo("PromotionMethods", PromotionMethod, "")
        bm.FillCombo("Departments", DepartmentId, "")


        Dim v() As String = {MainId, MainId2, SubId, SubName, "StartDate", "EndDate", "PromotionMethod", "OfferType", "DepartmentId", "CategoryId", "Detail", "SpecialPrice"}
        bm.Fields = v

        Dim c() As Control = {CboMain, CboMain2, txtID, txtName, StartDate, EndDate, PromotionMethod, OfferType, DepartmentId, CategoryId, Detail, Value}
        bm.control = c

        Dim k() As String = {MainId, MainId2, SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName

        btnNew_Click(sender, e)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.FirstLast(New String() {MainId, MainId2, SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        bm.FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {MainId, MainId2, SubId}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        bm.FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text.Trim = "" Or CboMain.SelectedValue.ToString = 0 Or CboMain2.SelectedValue.ToString = 0 Then
            Return
        End If
        bm.DefineValues()
        If Not bm.Save(New String() {MainId, MainId2, SubId}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text.Trim}) Then Return
        btnNew_Click(sender, e)
        AllowClose = True
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        bm.FirstLast(New String() {MainId, MainId2, SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        bm.FillControls()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'bm.ClearControls()
        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            bm.ClearControls()

            txtID.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & CboMain.SelectedValue.ToString & "' and " & MainId2 & "='" & CboMain2.SelectedValue.ToString & "'")
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            txtName.Focus()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & txtID.Text.Trim & "' and " & MainId & " ='" & CboMain.SelectedValue.ToString & "' and " & MainId2 & " ='" & CboMain2.SelectedValue.ToString & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {MainId, MainId2, SubId}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        bm.FillControls()
    End Sub
    Dim lv As Boolean = False
    Private Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Leave
        If lv Then
            Return
        End If
        lv = True
        txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
        bm.DefineValues()
        Dim dt As New DataTable
        bm.RetrieveAll(New String() {MainId, MainId2, SubId}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        bm.FillControls()
        lv = False
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, txtID.KeyDown, CboMain.KeyDown, CboMain2.KeyDown, PromotionMethod.KeyDown, Detail.KeyDown, OfferType.KeyDown, Value.KeyDown, DepartmentId.KeyDown, StartDate.KeyDown, EndDate.KeyDown, CategoryId.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
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

    Private Sub CboMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMain.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = CboMain.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Try
            bm.FillCombo(Main2TableName, CboMain2, " where " & Main2MainId & "='" & s & "'")
            ClearControls()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CboMain2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMain2.SelectedIndexChanged
        ClearControls()
    End Sub

    Private Sub Value_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Value.KeyPress
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

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = CategoryId.SelectedValue.ToString()
        Catch ex As Exception
        End Try
        bm.FillCombo("Items", Detail, " where /*Course='1' and*/ DepartmentId='" & s & "' and CategoryId='" & s1 & "'")

    End Sub

    Private Sub OfferType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfferType.SelectedIndexChanged

        Select Case OfferType.SelectedIndex
            Case 0
                lblDepartmentId.Visible = False
                DepartmentId.Visible = False
                DepartmentId.SelectedValue = 0
                lblCategoryId.Visible = False
                CategoryId.Visible = False
                bm.FillCombo("", Detail, "")
            Case 1
                lblDepartmentId.Visible = True
                DepartmentId.Visible = True
                lblCategoryId.Visible = True
                CategoryId.Visible = True
                bm.FillCombo("", Detail, "")
            Case 2
                lblDepartmentId.Visible = False
                DepartmentId.Visible = False
                DepartmentId.SelectedValue = 0
                lblCategoryId.Visible = False
                CategoryId.Visible = False
                bm.FillCombo("MemberShips", Detail, "")
            Case 3
                lblDepartmentId.Visible = False
                DepartmentId.Visible = False
                DepartmentId.SelectedValue = 0
                lblCategoryId.Visible = False
                CategoryId.Visible = False
                bm.FillCombo("Bundle", Detail, "")
        End Select
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
End Class