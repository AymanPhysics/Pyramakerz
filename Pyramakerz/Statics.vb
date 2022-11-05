Public Class Statics
    Dim bm As New BasicMethods
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If DeductionValue.Text.Trim = "" Then DeductionValue.Text = 0
        If Share1.Text.Trim = "" Then Share1.Text = 0
        If Share2.Text.Trim = "" Then Share2.Text = 0
        If Supervisor.Text.Trim = "" Then Supervisor.Text = 0
        If HeadOfDept.Text.Trim = "" Then HeadOfDept.Text = 0
        If DelayPeriod.Text.Trim = "" Then DelayPeriod.Text = 0
        If InitialSaving.Text.Trim = "" Then InitialSaving.Text = 0
        If LecturesCount.Text.Trim = "" Then LecturesCount.Text = 0
        If LectureHours.Text.Trim = "" Then LectureHours.Text = 0
        If LecAttPerc.Text.Trim = "" Then LecAttPerc.Text = 0
        If FundPerc.Text.Trim = "" Then FundPerc.Text = 0
        If Users.SelectedIndex < 0 Then Users.SelectedIndex = 0

        If Val(Share1.Text) >= 100 Or Val(Share1.Text) >= 100 Then
            bm.ShowMSG("Not Allawed to select more than or equal 100 for Share values ...")
            Return
        End If

        bm.ExcuteNonQuery("delete from Statics      insert into Statics(DeductionValue,Share1,Share2,Supervisor,HeadOfDept,DelayPeriod,InitialSaving,LecturesCount,LectureHours,LecAttPerc,FundPerc,SystemAdmin) values (" & DeductionValue.Text & "," & Share1.Text & "," & Share2.Text & "," & Supervisor.Text & "," & HeadOfDept.Text & "," & DelayPeriod.Text & "," & InitialSaving.Text & "," & LecturesCount.Text & "," & LectureHours.Text & "," & LecAttPerc.Text & "," & FundPerc.Text & "," & Users.SelectedValue.ToString & ")")
        NewSave()
        Statics_Load(Nothing, Nothing)

        AllowClose = True
    End Sub
    Sub NewSave()
        btnSave.BackColor = Color.Red
        btnSave.ForeColor = Color.Blue
        Refresh()
        Threading.Thread.Sleep(200)
        btnSave.BackColor = Color.White
        btnSave.ForeColor = Color.Red
    End Sub
    Private Sub DeductionValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DeductionValue.KeyPress, DelayPeriod.KeyPress, LecturesCount.KeyPress, LecAttPerc.KeyPress, FundPerc.KeyPress
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

    Private Sub Share_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Share1.KeyPress, Share2.KeyPress, Supervisor.KeyPress, HeadOfDept.KeyPress, InitialSaving.KeyPress, LectureHours.KeyPress, LecAttPerc.KeyPress, FundPerc.KeyPress
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

    Private Sub Statics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' and Stopped='0' union select 0 Id,'-' Name order by Name", Users)
        Try

            DeductionValue.Clear()
            Share1.Clear()
            Share2.Clear()
            Supervisor.Clear()
            HeadOfDept.Clear()
            DelayPeriod.Clear()
            InitialSaving.Clear()
            LecturesCount.Clear()
            LectureHours.Clear()
            LecAttPerc.Clear()
            FundPerc.Clear()
            Try
                Users.SelectedIndex = 0
            Catch ex As Exception
            End Try

            Dim dt As DataTable = bm.ExcuteAdapter("select DeductionValue,Share1,Share2,Supervisor,HeadOfDept,DelayPeriod,InitialSaving,LecturesCount,LectureHours,LecAttPerc,FundPerc,SystemAdmin from Statics")
            If dt.Rows.Count = 0 Then Return
            DeductionValue.Text = dt.Rows(0)(0).ToString
            Share1.Text = dt.Rows(0)(1).ToString
            Share2.Text = dt.Rows(0)(2).ToString
            Supervisor.Text = dt.Rows(0)(3).ToString
            HeadOfDept.Text = dt.Rows(0)(4).ToString
            DelayPeriod.Text = dt.Rows(0)(5).ToString
            InitialSaving.Text = dt.Rows(0)(6).ToString
            LecturesCount.Text = dt.Rows(0)(7).ToString
            LectureHours.Text = dt.Rows(0)(8).ToString
            LecAttPerc.Text = dt.Rows(0)(9).ToString
            FundPerc.Text = dt.Rows(0)(10).ToString
            Users.SelectedValue = dt.Rows(0)(11).ToString
        Catch ex As Exception
            bm.ShowMSG(ex.Message)
        End Try
    End Sub
    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DeductionValue.KeyDown, Share2.KeyDown, Share1.KeyDown, Supervisor.KeyDown, HeadOfDept.KeyDown, DelayPeriod.KeyDown, InitialSaving.KeyDown, LecturesCount.KeyDown, LectureHours.KeyDown, LecAttPerc.KeyDown, Users.KeyDown, FundPerc.KeyDown, FundPerc.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
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
     
End Class