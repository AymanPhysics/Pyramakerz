Imports System.Data.SqlClient

Public Class MemberShips
    Public TableName As String = "MemberShips"
    Public SubId As String = "Id"
    Public SubName As String = "Name"
    Public SubName2 As String = "DurationType"

    Public CboTableName As String = "DurationTypes"
    Public CboSubId As String = "Id"
    Public CboSubName As String = "Name"
    Public CboWhere As String = ""


    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub MemberShips_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.MaxLength = Length
        Dim v() As String = {SubId, SubName, SubName2, "Refundable", "AddToWaiting", "HasContract"}
        bm.Fields = v
        Dim c() As Control = {txtID, txtName, CboSub, Refundable, AddToWaiting, HasContract}
        bm.control = c

        Dim k() As String = {SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName

        If CboTableName <> "" Then
            bm.FillCombo(CboSub, CboTableName, CboSubId, CboSubName, CboWhere)
        End If

        btnNew_Click(sender, e)

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
        bm.NextPrevious(New String() {SubId}, New String() {txtID.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text.Trim = "" Then
            Return
        End If
        bm.DefineValues()
        If Not bm.Save(New String() {SubId}, New String() {txtID.Text.Trim}) Then Return
        If Not bm.ExcuteNonQuery(SaveGrid()) Then Return
        btnNew_Click(sender, e)
        AllowClose = True
    End Sub
    Function SaveGrid() As String
        Return bm.SaveGrid(DataGridView1, "MemberShipDetails", New String() {"Id"}, New String() {txtID.Text}, New String() {"CountryId", "CityId", "Value", "Discount"}, New Integer() {0, 2, 4, 5}, New VariantType() {VariantType.Integer, VariantType.Integer, VariantType.Decimal, VariantType.Decimal})

        'bm.ExcuteNonQuery("delete from MemberShipDetails where Id='" & txtID.Text & "'")
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Rows(i).Cells(4).Value.ToString = Nothing Then
        '        DataGridView1.Rows(i).Cells(4).Value = 0
        '    End If
        '    If DataGridView1.Rows(i).Cells(5).Value.ToString = Nothing Then
        '        DataGridView1.Rows(i).Cells(5).Value = 0
        '    End If
        '    bm.ExcuteNonQuery("insert into MemberShipDetails(Id ,CountryId ,CityId ,Value,Discount) values('" & txtID.Text & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "'," & DataGridView1.Rows(i).Cells(4).Value & "," & DataGridView1.Rows(i).Cells(5).Value & ")")
        'Next
    End Function

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        bm.FirstLast(New String() {SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub
    Sub FillControls()
        Try
            bm.FillControls()
            Dim dt As DataTable = bm.ExcuteAdapter("select CN.Id ,CN.Name Country,CT.Id ,CT.Name City,0. Price,0. Discount from Countries CN left join Cities CT on(CN.Id=CT.CountryId)")
            DataGridView1.DataSource = dt
            Dim dt2 As DataTable = bm.ExcuteAdapter("select CountryId,CityId,Value,Discount from MemberShipDetails where Id='" & txtID.Text & "'")
            For i As Integer = 0 To dt2.Rows.Count - 1
                For i2 As Integer = 0 To DataGridView1.Rows.Count - 1
                    If dt2.Rows(i)(0).ToString = DataGridView1.Rows(i2).Cells(0).Value.ToString And dt2.Rows(i)(1).ToString = DataGridView1.Rows(i2).Cells(2).Value.ToString Then
                        DataGridView1.Rows(i2).Cells(4).Value = dt2.Rows(i)(2).ToString
                        DataGridView1.Rows(i2).Cells(5).Value = dt2.Rows(i)(3).ToString
                    End If
                Next
            Next
            DrawGrid()

        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        bm.ClearControls()
        ClearControls()
    End Sub



    Sub ClearControls()
        Try
            txtName.Clear()
            DataGridView1.DataSource = bm.ExcuteAdapter("select CN.Id ,CN.Name Country,CT.Id ,CT.Name City,0. Price,0. Discount from Countries CN left join Cities CT on(CN.Id=CT.CountryId)")

            DrawGrid()
    
            txtID.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName)
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            txtName.Focus()
            CboSub.SelectedIndex = 0
            Refundable.Checked = False
            AddToWaiting.Checked = False
        Catch ex As Exception
        End Try

    End Sub

    Sub DrawGrid()
        Try

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).ReadOnly = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).ReadOnly = True


            DataGridView1.Columns(1).FillWeight = 100
            DataGridView1.Columns(3).FillWeight = 100
            DataGridView1.Columns(4).FillWeight = 70
            DataGridView1.Columns(5).FillWeight = 70
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & txtID.Text.Trim & "'")
            bm.ExcuteNonQuery("delete from MemberShipDetails where Id='" & txtID.Text & "'")

            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {SubId}, New String() {txtID.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
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
        bm.RetrieveAll(New String() {SubId}, New String() {txtID.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
        'txtName.Text = dt(0)("Name")
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, txtID.KeyDown, CboSub.KeyDown, CboSub.KeyDown, Refundable.KeyDown, AddToWaiting.KeyDown, HasContract.KeyDown
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

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

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