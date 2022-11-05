Public Class InstallmentsSearch

    Dim dv As New DataView
    Dim dt As New DataTable
    Dim bm As New BasicMethods
    Public BranchId As String = ""
    Public InvNo As String
    Private Sub StSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Branches", Branch, "")
        Haspayed.SelectedIndex = 2
        DayDate.Value = "01-01-2000"
        InvNo = ""
        dv = New DataView(bm.ExcuteAdapter("GetInstallmentsSearch"))
        DataGridView1.DataSource = dv

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(7).FillWeight = 280

        Dim dd As New DataGridViewTextBoxColumn
        dd = DataGridView1.Columns(10)
        
    End Sub
    Sub Search(ByVal Col As String)
        Try

            Dim pd As String = "%"
            If Haspayed.SelectedIndex = 0 Then
                pd = "False"
            ElseIf Haspayed.SelectedIndex = 1 Then
                pd = "True"
            End If
            
            dv.RowFilter = "(BranchId= '" & Branch.SelectedValue.ToString() & "' or '" & Branch.SelectedValue.ToString() & "'='0') and InvoiceNo like '%" & InvoiceNo.Text & "%' and RealInvoiceNo like '%" & RealInvoiceNo.Text & "%' and MainInvoiceNo like '%" & MainInvoiceNo.Text & "%' and MainRealInvoiceNo like '%" & MainRealInvoiceNo.Text & "%' and StudentId like '%" & StudentId.Text & "%' and Value >=" & Val(Value.Text) & " and DayDate >='" & DayDate.Text & "' and Haspayed like '" & pd & "'"
            dv.Sort = Col
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ArName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceNo.TextChanged, RealInvoiceNo.TextChanged, StudentId.TextChanged, Value.TextChanged, DayDate.ValueChanged, Haspayed.SelectedIndexChanged, InvoiceNo.Enter, RealInvoiceNo.Enter, StudentId.Enter, Value.Enter, DayDate.Enter, Haspayed.Enter, MainInvoiceNo.TextChanged, MainRealInvoiceNo.Enter, MainInvoiceNo.Enter, MainRealInvoiceNo.TextChanged, Branch.SelectedIndexChanged
        Try
            Search(CType(sender, Control).Tag)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        InvNo = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class