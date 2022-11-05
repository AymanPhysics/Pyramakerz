Public Class Attendance

    Dim bm As New BasicMethods
    Public Flag As Integer = 0
    Private Sub Attendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            DayDate.Value = bm.ExecuteScalar("select getdate()")
        Catch ex As Exception
            Return
        End Try

        bm.FillCombo("select Id,EnName Name from Employees where HasAttendance='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Users)
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        Branch.SelectedValue = Module1.Branch

        DefaultTime.Value = DayDate.Value
        If Flag = 1 Then
            BackColor = Color.Green
        ElseIf Flag = 2 Then
            BackColor = Color.Red
            btnSave.Text = "Logout"
        End If
        BackgroundImage = Nothing
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DayDate.Value = DayDate.Value.AddSeconds(1)
    End Sub

    Private Sub Users_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Users.KeyDown, Password.KeyDown, DefaultTime.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If bm.ExecuteScalar("select HasAttendance from Employees where Id='" & Users.SelectedValue.ToString & "'") <> "1" Then
            bm.ShowMSG("You don't have permession to Login ...")
            Return
        End If

        Dim paraname() As String = {"Branch", "Id", "Password"}
        Dim paravalue() As String = {Branch.SelectedValue.ToString, Users.SelectedValue.ToString, bm.Encrypt(Password.Text)}
        Dim dt As DataTable = bm.ExcuteAdapter("TestLogin", paraname, paravalue)
        If dt.Rows.Count = 0 Then
            bm.ShowMSG("Invalid Username or password ...")
            Exit Sub
        End If

        Dim ShowProgress As Boolean = False
        If Flag = 1 Then
            If bm.IF_Exists("select * from Attendance where EmpId='" & Users.SelectedValue.ToString & "' and DayDate='" & bm.ToStrDate(DayDate.Value) & "'") Then
                bm.ShowMSG("You already have Logged In ...")
                Return
            End If
            If Not bm.ExcuteNonQuery("insert into Attendance(Branch,EmpId,DayDate,DefaultLoginDateTime,CurrentLoginDateTime) select '" & Branch.SelectedValue.ToString & "','" & Users.SelectedValue.ToString & "','" & bm.ToStrDate(DayDate.Value) & "','" & bm.ToStrDateTime(DefaultTime.Value) & "',GETDATE()") Then Return
        Else
            If Not bm.IF_Exists("select * from Attendance where EmpId='" & Users.SelectedValue.ToString & "' and DayDate='" & bm.ToStrDate(DayDate.Value) & "'") Then
                bm.ShowMSG("You haven't Logged in yet ...")
                Return
            End If
            If bm.IF_Exists("select * from Attendance where EmpId='" & Users.SelectedValue.ToString & "' and DayDate='" & bm.ToStrDate(DayDate.Value) & "' and CurrentLogOutDateTime is not null") Then
                bm.ShowMSG("You already have Logged Out ...")
                Return
            End If
            If Not bm.ExcuteNonQuery("update Attendance set DefaultLogOutDateTime='" & bm.ToStrDateTime(DefaultTime.Value) & "',CurrentLogOutDateTime=GETDATE() where Branch='" & Branch.SelectedValue.ToString & "' and EmpId='" & Users.SelectedValue.ToString & "' and DayDate='" & bm.ToStrDate(DayDate.Value) & "'") Then Return

            'If Users.SelectedValue.ToString = Module1.UserName Then HasLeft = True
            If bm.IF_Exists("select * from Employees where Id='" & Users.SelectedValue.ToString & "' and Instractor='1'") Then ShowProgress = True
        End If

        lblSuccess.Visible = True
        lblSuccess.Refresh()
        Threading.Thread.Sleep(1000)
        lblSuccess.Visible = False
        If ShowProgress Then
            Dim pp As MAIN = Parent.FindForm
            Dim frm As Progress = pp.ShowForm(New Progress, Nothing)
            frm.User = Users.SelectedValue.ToString
            frm.Progress_Load(Nothing, Nothing)
        End If
        Users.SelectedValue = 0
        Password.Clear()
        DefaultTime.Value = DayDate.Value
        Users.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub


End Class