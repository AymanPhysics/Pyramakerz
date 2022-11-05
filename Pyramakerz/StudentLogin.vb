Public Class StudentLogin

    Dim bm As New BasicMethods
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Shift1.Checked = CheckBox1.Checked
        Shift2.Checked = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Shift3.Checked = CheckBox2.Checked
        Shift4.Checked = CheckBox2.Checked
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

    Private Sub txtStId_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStId.Leave
        Try
            lblStName.Text = ""
            If txtStId.Text.Trim = "" Then Return
            txtStId.Text = txtStId.Text.Trim.PadLeft(0, "0")
        Catch ex As Exception
        End Try
        FillStName()
    End Sub
    Sub FillStName()
        lblStName.Text = bm.ExecuteScalar("select ArName from Students where Id='" & txtStId.Text & "'")
    End Sub

    Private Sub Delayed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delayed.CheckedChanged
        If Delayed.Checked Then
            DelayUntil.Visible = True
        Else
            DelayUntil.Value = Now
            DelayUntil.Visible = False
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Dim AllowClose As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If AllowClose Then Return
        If bm.ShowDeleteMSG("Are you sure you want to exit?") Then
            AllowClose = True
            Close()
        Else
            e.Cancel = True
            Me.BringToFront()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtStId.Text.Trim = "" Then
            bm.ShowMSG("برجاء تحديد رقم الطالب")
            Return
        End If

        If IIf(Days1.Checked, 1, 0) + IIf(Days2.Checked, 1, 0) + IIf(Days3.Checked, 1, 0) < 1 Then
            bm.ShowMSG("برجاء اختيار يوم مناسب")
            Return
        End If

        If IIf(Shift1.Checked, 1, 0) + IIf(Shift2.Checked, 1, 0) + IIf(Shift3.Checked, 1, 0) + IIf(Shift4.Checked, 1, 0) < 2 Then
            bm.ShowMSG("برجاء اختيار موعدين مناسبين على الأقل")
            Return
        End If

        Dim s As String = bm.ExecuteScalar("GenerateNewPlacement", New String() {"BranchId", "StudentId", "Shift1", "Shift2", "Shift3", "Shift4", "Days1", "Days2", "Days3", "Delayed", "DelayUntil", "Notes", "UserName"}, New String() {Module1.Branch, txtStId.Text, IIf(Shift1.Checked, "1", "0"), IIf(Shift2.Checked, "1", "0"), IIf(Shift3.Checked, "1", "0"), IIf(Shift4.Checked, "1", "0"), IIf(Days1.Checked, "1", "0"), IIf(Days2.Checked, "1", "0"), IIf(Days3.Checked, "1", "0"), IIf(Delayed.Checked, "1", "0"), bm.ToStrDate(DelayUntil.Value), Notes.Text, Module1.UserName})
        If Val(s) = 0 Then Return

        Dim Frm As New PlacementExam
        bm.HandleColor(Frm)
        bm.HandleKeyDown(Frm)
        Frm.BackColor = Module1.MyBackColor
        Frm.InvoiceNo = s
        Frm.StudentId = txtStId.Text
        ShowForm(Frm, Nothing)
        AllowClose = True
        Close()
    End Sub
    Public Function ShowForm(ByVal frm As Form, ByVal sender As System.Object) As Form
        Try
            Dim tt As ToolStripMenuItem = sender
            frm.Text = tt.Text
        Catch ex As Exception
        End Try
        bm.HandleColor(frm)
        bm.HandleKeyDown(frm)
        'frm.MdiParent = Me
        frm.ControlBox = False
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        frm.BackColor = Module1.MyBackColor
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
        Return frm
    End Function

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStId.KeyPress
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

    Private Sub DelayUntil_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStId.KeyDown, Shift4.KeyDown, Shift3.KeyDown, Shift2.KeyDown, Shift1.KeyDown, Notes.KeyDown, DelayUntil.KeyDown, Delayed.KeyDown, Days3.KeyDown, Days2.KeyDown, Days1.KeyDown, CheckBox2.KeyDown, CheckBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub StudentLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Delayed_CheckedChanged(Nothing, Nothing)
    End Sub
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtStId.Text = bm.ScanStudent()
            txtStId_Leave(Nothing, Nothing)
        End If
    End Sub
End Class