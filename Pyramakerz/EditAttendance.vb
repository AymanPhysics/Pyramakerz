Public Class EditAttendance

    Dim bm As New BasicMethods

    Public MyEmp As Integer = 0
    Public MyDate As DateTime = Now

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where SystemUser='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub EditAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         

        bm.FillCombo("Branches", Branch, "")
        bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by EnName", Instractor)
        Instractor.SelectedValue = MyEmp
        DayDate.Value = MyDate

    End Sub


    Private Sub Instractor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Instractor.SelectedIndexChanged, DayDate.ValueChanged
        ClearControls()
        TestPermition()
        If Instractor.SelectedIndex < 1 Then Return

        Dim dt As DataTable = bm.ExcuteAdapter("select Branch,DefaultLoginDateTime,CurrentLoginDateTime,DefaultLogOutDateTime,CurrentLogOutDateTime from Attendance where EmpId='" & Instractor.SelectedValue.ToString & "' and DayDate='" & bm.ToStrDate(DayDate.Value) & "'")
        If dt.Rows.Count = 0 Then Return

        Branch.SelectedValue = dt.Rows(0)("Branch")

        Try : Hr1.Text = DateTime.Parse(dt.Rows(0)("DefaultLoginDateTime")).Hour : Catch ex As Exception : End Try
        Try : Hr2.Text = DateTime.Parse(dt.Rows(0)("CurrentLoginDateTime")).Hour : Catch ex As Exception : End Try
        Try : Hr3.Text = DateTime.Parse(dt.Rows(0)("DefaultLogOutDateTime")).Hour : Catch ex As Exception : End Try
        Try : Hr4.Text = DateTime.Parse(dt.Rows(0)("CurrentLogOutDateTime")).Hour : Catch ex As Exception : End Try

        Try : Min1.Text = DateTime.Parse(dt.Rows(0)("DefaultLoginDateTime")).Minute : Catch ex As Exception : End Try
        Try : Min2.Text = DateTime.Parse(dt.Rows(0)("CurrentLoginDateTime")).Minute : Catch ex As Exception : End Try
        Try : Min3.Text = DateTime.Parse(dt.Rows(0)("DefaultLogOutDateTime")).Minute : Catch ex As Exception : End Try
        Try : Min4.Text = DateTime.Parse(dt.Rows(0)("CurrentLogOutDateTime")).Minute : Catch ex As Exception : End Try

        Try : Catch ex As Exception : End Try
        Try : Catch ex As Exception : End Try
        Try : Catch ex As Exception : End Try

        If Val(Hr1.Text) > 12 Then : Hr1.Text = Val(Hr1.Text) - 12 : tt1.SelectedIndex = 1 : End If
        If Val(Hr2.Text) > 12 Then : Hr2.Text = Val(Hr2.Text) - 12 : tt2.SelectedIndex = 1 : End If
        If Val(Hr3.Text) > 12 Then : Hr3.Text = Val(Hr3.Text) - 12 : tt3.SelectedIndex = 1 : End If
        If Val(Hr4.Text) > 12 Then : Hr4.Text = Val(Hr4.Text) - 12 : tt4.SelectedIndex = 1 : End If

    End Sub

    Sub ClearControls()
        Branch.SelectedValue = 0

        Hr1.Clear()
        Hr2.Clear()
        Hr3.Clear()
        Hr4.Clear()

        Min1.Clear()
        Min2.Clear()
        Min3.Clear()
        Min4.Clear()

        tt1.SelectedIndex = 0
        tt2.SelectedIndex = 0
        tt3.SelectedIndex = 0
        tt4.SelectedIndex = 0
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Function TestValid() As Boolean
        If Instractor.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select Employee ...")
            Instractor.Focus()
            Return False
        End If
        If Branch.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select Branch ...")
            Branch.Focus()
            Return False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Hr1.Text.Trim = "" Then
            bm.ShowMSG("Please, Insert Default Login Hr ...")
            Hr1.Focus()
            Return False
        End If

        If Min1.Text.Trim = "" Then
            bm.ShowMSG("Please, Insert Default Login Min ...")
            Min1.Focus()
            Return False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Hr2.Text.Trim = "" Then
            bm.ShowMSG("Please, Insert Current Login Hr ...")
            Hr2.Focus()
            Return False
        End If

        If Min2.Text.Trim = "" Then
            bm.ShowMSG("Please, Insert Current Login Min ...")
            Min2.Focus()
            Return False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If CheckBox1.Checked Then Return True
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Hr3.Text.Trim = "" Then
            bm.ShowMSG("Please, Insert Default LogOut Hr ...")
            Hr3.Focus()
            Return False
        End If

        If Min3.Text.Trim = "" Then
            bm.ShowMSG("Please, Insert Default LogOut Min ...")
            Min3.Focus()
            Return False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Hr4.Text.Trim = "" Then
            bm.ShowMSG("Please, Insert Current LogOut Hr ...")
            Hr4.Focus()
            Return False
        End If

        If Min4.Text.Trim = "" Then
            bm.ShowMSG("Please, Insert Current LogOut Min ...")
            Min4.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not TestValid() Then Return

        bm.TestMistakeOrUpdate(Instractor.SelectedValue.ToString, "Attendance")

        Dim MyDate As String = bm.ToStrDate(DayDate.Value)
        If CheckBox1.Checked Then
            If bm.IF_Exists("select DefaultLoginDateTime,CurrentLoginDateTime,DefaultLogOutDateTime,CurrentLogOutDateTime from Attendance where EmpId='" & Instractor.SelectedValue.ToString & "' and DayDate='" & MyDate & "'") Then
                bm.ExcuteNonQuery("Update Attendance Set Branch='" & Branch.SelectedValue.ToString & "',DefaultLoginDateTime='" & MyDate & " " & Hr1.Text & ":" & Min1.Text & " " & tt1.Text _
                              & "',CurrentLoginDateTime='" & MyDate & " " & Hr2.Text & ":" & Min2.Text & " " & tt2.Text _
                              & "' where EmpId='" & Instractor.SelectedValue.ToString & "' and DayDate='" & MyDate & "'")
            Else
                bm.ExcuteNonQuery("Insert into Attendance(Branch,EmpId,DayDate,DefaultLoginDateTime,CurrentLoginDateTime) Select '" & Branch.SelectedValue.ToString & "','" & Instractor.SelectedValue.ToString & "','" & MyDate & "','" & MyDate & " " & Hr1.Text & ":" & Min1.Text & " " & tt1.Text _
                              & "','" & MyDate & " " & Hr2.Text & ":" & Min2.Text & " " & tt2.Text _
                              & "'")
            End If

        Else

            If bm.IF_Exists("select DefaultLoginDateTime,CurrentLoginDateTime,DefaultLogOutDateTime,CurrentLogOutDateTime from Attendance where EmpId='" & Instractor.SelectedValue.ToString & "' and DayDate='" & MyDate & "'") Then
                bm.ExcuteNonQuery("Update Attendance Set Branch='" & Branch.SelectedValue.ToString & "',DefaultLoginDateTime='" & MyDate & " " & Hr1.Text & ":" & Min1.Text & " " & tt1.Text _
                              & "',CurrentLoginDateTime='" & MyDate & " " & Hr2.Text & ":" & Min2.Text & " " & tt2.Text _
                              & "',DefaultLogOutDateTime='" & MyDate & " " & Hr3.Text & ":" & Min3.Text & " " & tt3.Text _
                              & "',CurrentLogOutDateTime='" & MyDate & " " & Hr4.Text & ":" & Min4.Text & " " & tt4.Text _
                              & "' where EmpId='" & Instractor.SelectedValue.ToString & "' and DayDate='" & MyDate & "'")
            Else
                bm.ExcuteNonQuery("Insert into Attendance(Branch,EmpId,DayDate,DefaultLoginDateTime,CurrentLoginDateTime,DefaultLogOutDateTime,CurrentLogOutDateTime) Select '" & Branch.SelectedValue.ToString & "','" & Instractor.SelectedValue.ToString & "','" & MyDate & "','" & MyDate & " " & Hr1.Text & ":" & Min1.Text & " " & tt1.Text _
                              & "','" & MyDate & " " & Hr2.Text & ":" & Min2.Text & " " & tt2.Text _
                              & "','" & MyDate & " " & Hr3.Text & ":" & Min3.Text & " " & tt3.Text _
                              & "','" & MyDate & " " & Hr4.Text & ":" & Min4.Text & " " & tt4.Text _
                              & "'")
            End If


        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lblSuccess.Visible = True
        lblSuccess.Refresh()
        Threading.Thread.Sleep(1000)
        lblSuccess.Visible = False
        Instractor.SelectedValue = 0
        DayDate.Value = Now
        ClearControls()
        Instractor.Focus()
    End Sub

    Private Sub Hr1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hr4.Leave, Hr3.Leave, Hr2.Leave, Hr1.Leave
        If Val(CType(sender, TextBox).Text) > 12 Then
            CType(sender, TextBox).Clear()
        End If
    End Sub

    Private Sub Min1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Min4.Leave, Min3.Leave, Min2.Leave, Min1.Leave
        If Val(CType(sender, TextBox).Text) > 60 Then
            CType(sender, TextBox).Clear()
        End If
    End Sub

    Private Sub tt4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tt4.KeyDown, tt3.KeyDown, tt2.KeyDown, tt1.KeyDown, Min4.KeyDown, Min3.KeyDown, Min2.KeyDown, Min1.KeyDown, Instractor.KeyDown, Hr4.KeyDown, Hr3.KeyDown, Hr2.KeyDown, Hr1.KeyDown, DayDate.KeyDown, Branch.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub


    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Min4.KeyPress, Min3.KeyPress, Min2.KeyPress, Min1.KeyPress, Hr4.KeyPress, Hr3.KeyPress, Hr2.KeyPress, Hr1.KeyPress
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
        Else
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub TestPermition()
        Try
            If Module1.GeneralManager = "1" OrElse Module1.Board = "1" OrElse Module1.Accountant = "1" OrElse CDate(bm.ExecuteScalar("select getdate()")) < DayDate.Value.AddDays(3) Then
                btnSave.Enabled = True
            Else
                btnSave.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to Delete?") Then
            Dim MyDate As String = bm.ToStrDate(DayDate.Value)
            bm.ExcuteNonQuery("delete Attendance where EmpId='" & Instractor.SelectedValue.ToString & "' and DayDate='" & MyDate & "'")
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            lblSuccess.Visible = True
            lblSuccess.Refresh()
            Threading.Thread.Sleep(1000)
            lblSuccess.Visible = False
            Instractor.SelectedValue = 0
            DayDate.Value = Now
            ClearControls()
            Instractor.Focus()
        End If
    End Sub
End Class