Public Class Bundle

    Public TableName As String = "Bundle"
    Public SubId As String = "Id"
    Public SubName As String = "Name"
    Public SubName2 As String = "DepartmentId"

    Public CboTableName As String = "Departments"
    Public CboSubId As String = "Id"
    Public CboSubName As String = "Name"
    Public CboWhere As String = ""


    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub MemberShips_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.MaxLength = Length
        Dim v() As String = {SubId, SubName, SubName2, "AllawChange", "Refundable", "HasContract", "MaxCount"}
        bm.Fields = v
        Dim c() As Control = {txtID, txtName, CboSub, AllawChange, Refundable, HasContract, MaxCount}
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
        If MaxCount.Text.Trim = "" Then
            MaxCount.Text = "0"
        End If
        bm.DefineValues()
        If Not bm.Save(New String() {SubId}, New String() {txtID.Text.Trim}) Then Return

        If Not bm.ExcuteNonQuery(SaveGrid() & vbCrLf & SaveGrid2()) Then Return

        btnNew_Click(sender, e)
        AllowClose = True
    End Sub
    Function SaveGrid() As String
        Return bm.SaveGrid(DataGridView1, "BundleDetails", New String() {"Id"}, New String() {txtID.Text}, New String() {"CountryId", "CityId", "Value"}, New Integer() {0, 2, 4}, New VariantType() {VariantType.Integer, VariantType.Integer, VariantType.Decimal})

        'bm.ExcuteNonQuery("delete from BundleDetails where Id='" & txtID.Text & "'")
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Rows(i).Cells(4).Value.ToString = Nothing Then
        '        DataGridView1.Rows(i).Cells(4).Value = 0
        '    End If
        '    bm.ExcuteNonQuery("insert into BundleDetails(Id ,CountryId ,CityId ,Value) values('" & txtID.Text & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "'," & DataGridView1.Rows(i).Cells(4).Value & ")")
        'Next
    End Function

    Function SaveGrid2() As String
        Return bm.SaveGrid(DataGridView2, "BundleItems", New String() {"Id"}, New String() {txtID.Text}, New String() {"CategoryId", "Detail"}, New Integer() {0, 1}, New VariantType() {VariantType.Integer, VariantType.Integer})

        'bm.ExcuteNonQuery("delete from BundleItems where Id='" & txtID.Text & "'")
        'For i As Integer = 0 To DataGridView2.Rows.Count - 1
        '    If DataGridView2.Rows(i).Cells(0).Value Is Nothing OrElse DataGridView2.Rows(i).Cells(1).Value Is Nothing OrElse DataGridView2.Rows(i).Cells(0).Value.ToString = "" OrElse DataGridView2.Rows(i).Cells(1).Value.ToString = "" Then
        '        Continue For
        '    End If
        '    bm.ExcuteNonQuery("insert into BundleItems(Id ,CategoryId ,Detail) values('" & txtID.Text & "','" & DataGridView2.Rows(i).Cells(0).Value & "','" & DataGridView2.Rows(i).Cells(1).Value & "')")
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
            Dim dt As DataTable = bm.ExcuteAdapter("select CN.Id ,CN.Name Country,CT.Id ,CT.Name City,0. Price from Countries CN left join Cities CT on(CN.Id=CT.CountryId)")
            DataGridView1.DataSource = dt
            Dim dt2 As DataTable = bm.ExcuteAdapter("select CountryId,CityId,Value from BundleDetails where Id='" & txtID.Text & "'")
            For i As Integer = 0 To dt2.Rows.Count - 1
                For i2 As Integer = 0 To DataGridView1.Rows.Count - 1
                    If dt2.Rows(i)(0).ToString = DataGridView1.Rows(i2).Cells(0).Value.ToString And dt2.Rows(i)(1).ToString = DataGridView1.Rows(i2).Cells(2).Value.ToString Then
                        DataGridView1.Rows(i2).Cells(4).Value = dt2.Rows(i)(2).ToString
                    End If
                Next
            Next
            DrawGrid()


            Dim dt3 As DataTable = bm.ExcuteAdapter("select CategoryId,Detail from BundleItems where Id='" & txtID.Text & "'")
            DataGridView2.Rows.Clear()
            DataGridView2.Rows.Add(dt3.Rows.Count)

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim ss As New DataTable
            ss = bm.ExcuteAdapter("select Id,NAME from Categories where DepartmentId='" & CboSub.SelectedValue.ToString & "' union select 0 Id,'-' NAME")
            Dim temp As New DataTable
            temp.Columns.Add("Id")
            temp.Columns.Add("Name")
            For i As Integer = 0 To ss.Rows.Count - 1
                temp.Rows.Add(New String() {ss.Rows(i)(0).ToString, ss.Rows(i)(1).ToString})
            Next
            CType(DataGridView2.Columns(0), DataGridViewComboBoxColumn).DataSource = temp
            CType(DataGridView2.Columns(0), DataGridViewComboBoxColumn).DisplayMember = "Name"
            CType(DataGridView2.Columns(0), DataGridViewComboBoxColumn).ValueMember = "Id"

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            For i As Integer = 0 To dt3.Rows.Count - 1
                DataGridView2.Rows(i).Cells(0).Value = dt3.Rows(i)(0).ToString
                DataGridView2.Rows(i).Cells(1).Value = dt3.Rows(i)(1).ToString
            Next

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
            DataGridView1.DataSource = bm.ExcuteAdapter("select CN.Id ,CN.Name Country,CT.Id ,CT.Name City,0. Price from Countries CN left join Cities CT on(CN.Id=CT.CountryId)")

            DrawGrid()

            DataGridView2.Rows.Clear()

            txtID.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName)
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            txtName.Focus()
            CboSub.SelectedIndex = 0
            AllawChange.Checked = False
            Refundable.Checked = False
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

            DataGridView1.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & txtID.Text.Trim & "'")
            bm.ExcuteNonQuery("delete from BundleDetails where Id='" & txtID.Text & "'")
            bm.ExcuteNonQuery("delete from BundleItems where Id='" & txtID.Text & "'")

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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, txtID.KeyDown, CboSub.KeyDown, CboSub.KeyDown, AllawChange.KeyDown, Refundable.KeyDown, HasContract.KeyDown, MaxCount.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress, MaxCount.KeyPress
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
    Private Sub DataGridView2_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

    End Sub

    Private Sub CboSub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSub.SelectedIndexChanged
        bm.FillCombo("select Id,NAME from Categories where DepartmentId='" & CboSub.SelectedValue.ToString & "' union select 0 Id,'-' NAME", Column1)
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            DataGridView2.Rows(i).Cells(0).Value = "0"
        Next
    End Sub

    Private Sub DataGridView2_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = 0 Then
            Dim ss As New DataTable
            Try
                ss = bm.ExcuteAdapter("select Id,Name 'NAME' from Items where DepartmentId='" & CboSub.SelectedValue.ToString & "'  and CategoryId='" & DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString & "' union select 0 Id,'-' Name")
            Catch
                ss = bm.ExcuteAdapter("select 0 Id,'-' Name 'NAME'")
            End Try
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim temp As New DataTable
            temp.Columns.Add("Id")
            temp.Columns.Add("Name")
            For i As Integer = 0 To ss.Rows.Count - 1
                temp.Rows.Add(New String() {ss.Rows(i)(0).ToString, ss.Rows(i)(1).ToString})
            Next
            CType(DataGridView2.Rows(e.RowIndex).Cells(1), DataGridViewComboBoxCell).DataSource = temp
            CType(DataGridView2.Rows(e.RowIndex).Cells(1), DataGridViewComboBoxCell).DisplayMember = "Name"
            CType(DataGridView2.Rows(e.RowIndex).Cells(1), DataGridViewComboBoxCell).ValueMember = "Id"
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DataGridView2.Rows(e.RowIndex).Cells(1).Value = "0"
        End If
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
    Dim MyVal As String = ""
    Sub DataGridView2_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView2.EditingControlShowing

        Try
            Dim cmbBox As ComboBox
            cmbBox = CType(e.Control, ComboBox)
            cmbBox.SelectedValue = MyVal
        Catch ex As Exception
        End Try
        MyVal = ""
    End Sub

End Class