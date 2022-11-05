Public Class GenerateInstallments
    Public Branch, StudentId, MainInvoiceNo As String
    Dim bm As New BasicMethods
    Private Sub GenerateInstallments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DelayPeriod = bm.GetDelayPeriod()
        CheckBox1.Text = "After " & DelayPeriod.ToString & " Days"
        ComboBox1.SelectedIndex = 0
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        If Module1.SystemAdmin = Module1.UserName Or Module1.GeneralManager = "1" Or Module1.Board = "1" Or Module1.Manager = "1" Or Module1.Accountant = "1" Then
            DataGridView1.Columns(1).ReadOnly = False
        End If

    End Sub

    Dim DelayPeriod As Integer = 0
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 2 Then
            lblDays.Visible = True
            Custom.Visible = True
        Else
            lblDays.Visible = False
            Custom.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If txtInstallments.Text.Trim = "" Or lblTotal.Text.Trim = "" Then Return
            DataGridView1.Rows.Clear()
            Dim DaysCount As Integer = 0
            Select Case ComboBox1.SelectedIndex
                Case 0
                    DaysCount = 7
                Case 1
                    DaysCount = 30
                Case 2
                    DaysCount = Val(Custom.Text)
            End Select

            If DaysCount = 0 Then
                bm.ShowMSG("Please, Select a Valid Days")
                Return
            End If

            Dim NoOfInstallments As Integer = 0
            NoOfInstallments = Val(txtInstallments.Text)

            Dim x As Decimal = Val(lblTotal.Text) / NoOfInstallments

            DataGridView1.Rows.Add(NoOfInstallments)
            For i As Integer = 0 To NoOfInstallments - 1
                DataGridView1.Rows(i).Cells(0).Value = DayDate.Value.AddDays(i * DaysCount)
                DataGridView1.Rows(i).Cells(1).Value = x
            Next
        Catch
        End Try
    End Sub
    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Custom.KeyPress, txtInstallments.KeyPress
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Dim bolAllowClose As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If bolAllowClose Then
            AllowClose = True
            Return
        End If
        bolAllowClose = True
        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            Dim InvNo As String = bm.ExecuteScalar("select max(InvoiceNo) from Installments /*where BranchId='" & Branch & "'*/")

            If InvNo = "" Then InvNo = "0"

            InvNo = (Val(InvNo) + 1).ToString.PadLeft(0, "0")

            Dim InvDate As String = bm.ToStrDate(DataGridView1.Rows(i).Cells(0).Value.ToString)

            If Not bm.ExcuteNonQuery("insert into Installments (BranchId,StudentId,InvoiceNo,MainInvoiceNo,Value,Notes,UserName,DayDate,Haspayed,PayedDate,RealInvoiceNo)  select '" & Branch & "','" & StudentId & "','" & InvNo & "','" & MainInvoiceNo & "','" & DataGridView1.Rows(i).Cells(1).Value.ToString & "','','" & Module1.UserName & "','" & InvDate & "',0,'" & InvDate & "',''") Then
                bm.ShowMSG("InvoiceNo: " & InvNo & " didn't be saved ....!")
            End If
        Next

        Close()
        bolAllowClose = False
        AllowClose = True
    End Sub

    Dim AllowClose As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not btnSave.Enabled Or bolAllowClose Then Exit Sub
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            DayDate.Value = Now.AddDays(DelayPeriod)
            DayDate.Enabled = False
        Else
            DayDate.Value = Now
            DayDate.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            If e.ColumnIndex = 1 Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
            End If
        Catch ex As Exception
            DataGridView1.Rows(e.RowIndex).Cells(1).Value = 0
        End Try
    End Sub
End Class