Public Class StudentsBundleItems

    Dim dt As New DataTable
    Dim bm As New BasicMethods
    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            frm.TableWhere = "  where Id in (select distinct ss.StudentId from StudentsBundleItems ss)"
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            txtStId_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        bm.FillCombo("select 0 Id,'-' Name", Bundle)
        Try
            lblStName.Text = ""
            If txtStId.Text.Trim = "" Then Return
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
        Catch ex As Exception
        End Try
        bm.FillCombo("select SB.InvoiceNo 'Id',B.Name+'      inv( '+cast(SB.InvoiceNo as varchar(100))+' )' 'Name' from Income SB right join Bundle B on(SB.Items=B.Id and Flag=2) where SB.StudentId='" & txtStId.Text & "' union select 0 Id,'-' Name", Bundle)

        FillStName()
    End Sub
    Private Sub txtStId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.TextChanged
        'If txtStId.Text.Length = 6 Then
        'txtStId_Leave(Nothing, Nothing)
        'End If
    End Sub
    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select EnName from Students where Id='" & txtStId.Text & "'")
    End Sub
    Dim dep As String = ""
    Dim BundleId As String = ""
    Private Sub Bundle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bundle.SelectedIndexChanged
        'If bm.ExecuteScalar("select Refundable from Income where InvoiceNo='" & Bundle.SelectedValue.ToString() & "'") = "1" Then
        If bm.ExecuteScalar("select AllawChange from Bundle where Id=(select Items from Income where InvoiceNo='" & Bundle.SelectedValue.ToString() & "')") = "1" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
        dep = bm.ExecuteScalar("select DepartmentId from bundle where id=(select distinct BundleId from StudentsBundleItems where InvoiceNo='" & Bundle.SelectedValue.ToString() & "')")

        BundleId = bm.ExecuteScalar("select distinct BundleId from StudentsBundleItems where InvoiceNo='" & Bundle.SelectedValue.ToString() & "'")

        Try
            bm.FillCombo("select Id,Name from Categories where DepartmentId='" & dep & "' union select 0 Id,'-' Name", Column1)
            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                DataGridView2.Rows(i).Cells(0).Value = ""
            Next
        Catch ex As Exception
        End Try



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim ss As New DataTable
        ss = bm.ExcuteAdapter("select Id,NAME from Categories where DepartmentId='" & dep & "' union select 0 Id,'-' NAME")
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
        Try
            Dim dt3 As DataTable = bm.ExcuteAdapter("select CategoryId,Detail from StudentsBundleItems where InvoiceNo='" & Bundle.SelectedValue.ToString() & "'")
            DataGridView2.Rows.Clear()
            DataGridView2.Rows.Add(dt3.Rows.Count)
            For i As Integer = 0 To dt3.Rows.Count - 1
                DataGridView2.Rows(i).Cells(0).Value = dt3.Rows(i)(0).ToString
                DataGridView2.Rows(i).Cells(1).Value = dt3.Rows(i)(1).ToString
            Next
        Catch ex As Exception
        End Try

        MaxCount.Text = bm.ExecuteScalar("select B.MaxCount from Income SB right join Bundle B on(SB.Items=B.Id and Flag=2) where SB.StudentId='" & txtStId.Text & "' and SB.InvoiceNo=" & Bundle.SelectedValue.ToString)

    End Sub
    Private Sub DataGridView2_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged

        If e.RowIndex = -1 Then Return
        If e.ColumnIndex = 0 Then
            Dim ss As New DataTable
            Try
                ss = bm.ExcuteAdapter("select Id,Name from Items where DepartmentId='" & dep & "'  and CategoryId='" & DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString & "' union select 0 Id,'-' Name")
            Catch
                ss = bm.ExcuteAdapter("select 0 Id,'-' Name")
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
            DataGridView2.Rows(e.RowIndex).Cells(1).Value = ""
        End If
    End Sub
    Private Sub DataGridView2_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Bundle.SelectedValue Is Nothing Then Return

        Dim x As Integer = 0
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            If DataGridView2.Rows(i).Cells(0).Value Is Nothing Or DataGridView2.Rows(i).Cells(1).Value Is Nothing Or DataGridView2.Rows(i).Cells(0).Value = "" Or DataGridView2.Rows(i).Cells(1).Value = "" Then
                Continue For
            End If
            x += 1
        Next
        If x > Val(MaxCount.Text) Then
            bm.ShowMSG("You've selected MORE than the MaxCount")
            Return
        End If

        If Not bm.ExcuteNonQuery(bm.SaveGrid(DataGridView2, "StudentsBundleItems", New String() {"InvoiceNo", "BundleId", "StudentId"}, New String() {Bundle.SelectedValue.ToString, BundleId, txtStId.Text}, New String() {"CategoryId", "Detail"}, New Integer() {0, 1}, New VariantType() {VariantType.Integer, VariantType.Integer})) Then Return

        'bm.ExcuteNonQuery("delete from StudentsBundleItems where InvoiceNo='" & Bundle.SelectedValue.ToString & "'")
        'For i As Integer = 0 To DataGridView2.Rows.Count - 1
        '    If DataGridView2.Rows(i).Cells(0).Value Is Nothing Or DataGridView2.Rows(i).Cells(1).Value Is Nothing Or DataGridView2.Rows(i).Cells(0).Value = "" Or DataGridView2.Rows(i).Cells(1).Value = "" Then
        '        Continue For
        '    End If
        '    bm.ExcuteNonQuery("insert into StudentsBundleItems(InvoiceNo,BundleId,StudentId,CategoryId,Detail) values('" & Bundle.SelectedValue.ToString & "','" & BundleId & "','" & txtStId.Text & "','" & DataGridView2.Rows(i).Cells(0).Value & "','" & DataGridView2.Rows(i).Cells(1).Value & "')")
        'Next

        DataGridView2.Rows.Clear()
        txtStId.Text = ""
        txtStId_Leave(Nothing, Nothing)
        AllowClose = True
    End Sub

    Private Sub StudentsBundleItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Dim AllowClose As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not btnSave.Enabled Then Return
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

    Private Sub txtStId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStId.KeyDown, Bundle.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class