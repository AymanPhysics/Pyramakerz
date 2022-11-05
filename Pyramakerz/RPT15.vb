Public Class RPT15
    Dim bm As New BasicMethods
    Public Flag As Integer = 1

    Private Sub RPT15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Flag = 1 Then

            bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Users)
            bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Users2)
        ElseIf Flag = 2 Then
            bm.FillCombo("select Id,EnName Name from Employees where GeneralManager='1' or Manager='1' or HeadofDepartment='1' or Supervisor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Users)
            bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Users2)
            Label1.Text = "User From"
            Label4.Text = "User To"
        End If
        Users.SelectedValue = Module1.UserName
        FromDate.Value = Now
        ToDate.Value = Now
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Users.KeyDown, Users2.KeyDown, ToDate.KeyDown, FromDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rpt As New ReportViewer(Text)
        If Flag = 1 Then
            rpt.Rpt = "Messages.rpt"
        ElseIf Flag = 2 Then
            rpt.Rpt = "Tasks.rpt"
        End If
        rpt.paraname = New String() {"@Emp", "@Emp2", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {Users.SelectedValue.ToString, Users2.SelectedValue.ToString, FromDate.Text, ToDate.Text}
        rpt.ShowDialog()
    End Sub

    Private Sub Users_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Users.Leave
        If Not Module1.Board = "1" AndAlso Not Module1.GeneralManager = "1" AndAlso Not Users.SelectedValue = Module1.UserName AndAlso Flag = 1 Then
            Users2.SelectedValue = Module1.UserName
        End If
    End Sub
    Private Sub Users2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Users2.Leave
        If Not Module1.Board = "1" AndAlso Not Module1.GeneralManager = "1" AndAlso Not Users2.SelectedValue = Module1.UserName AndAlso Flag = 1 Then
            Users.SelectedValue = Module1.UserName
        End If
    End Sub

End Class