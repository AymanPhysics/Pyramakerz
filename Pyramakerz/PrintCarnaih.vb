
Public Class PrintCarnaih

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub PrintCarnaih_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim MyStr As String = ""
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            MyStr &= "," & DataGridView1.Rows(i).Cells(0).Value.ToString

            If Not IsDate(DataGridView1.Rows(i).Cells(2).Value.ToString) Then
                bm.ShowMSG("Please, insert a valid date in row no. " & (i + 1))
                Return
            End If
        Next


        bm.ExcuteNonQuery("truncate table GenerateCarnaih")
        Dim str As String = "insert GenerateCarnaih(Id,DayDate) values "
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            str &= "(" & DataGridView1.Rows(i).Cells(0).Value.ToString & ",'" & DataGridView1.Rows(i).Cells(2).Value.ToString & "'),"
        Next
        str = str.Substring(0, str.Length - 1)
        bm.ExcuteNonQuery(str)

        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "PrintCarnaih.rpt"
        rpt.paraname = New String() {"@Where"}
        rpt.paravalue = New String() {MyStr}
        rpt.ShowDialog()
    End Sub


    Private Sub btnStSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStSearch.Click
        Try
            Dim frm As New StSearch
            frm.ShowDialog()
            txtStId.Text = frm.StudentId
            txtStId_Leave(Nothing, Nothing)
            FillStName()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If txtStId.Text.Trim = "" Then Return
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(0).Value = txtStId.Text.Trim Then Return
            Next
            DataGridView1.Rows.Add(New String() {txtStId.Text.Trim, lblStName.Text, bm.ToStrDate(bm.ExecuteScalar("select dbo.GetCardExpDate(" & txtStId.Text.Trim & ")")), 0, 0})
            txtStId.Text = ""
            lblStName.Text = ""
            txtStId.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtStId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStId.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtStId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStId.KeyPress
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

    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        Try
            If txtStId.Text.Trim = "" Then
                lblStName.Text = ""
                Return
            End If
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
            FillStName()
        Catch ex As Exception
        End Try
    End Sub

    Sub FillStName()
        Dim s As String = ""
        Dim dt As DataTable = bm.ExcuteAdapter("select EnName from Students where Id='" & txtStId.Text & "'" & s)
        If dt.Rows.Count = 0 Then
            txtStId.Clear()
            lblStName.Text = ""
            Return
        End If
        lblStName.Text = dt.Rows(0)(0)
    End Sub

    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class