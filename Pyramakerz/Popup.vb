Public Class Popup
    Dim bm As New BasicMethods
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        bm.ExcuteNonQuery("insert PopupHistory(BranchId,GroupId,UserName,Popup,Show,Ignore) select " & Module1.Branch & "," & Group.Text & "," & Module1.UserName & ",0 Popup,1 Show,0 Ignore")

        Hide()

        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "GroupStudents0.rpt"
        rpt.paraname = New String() {"@BranchId", "@GroupId"}
        rpt.paravalue = New String() {Module1.Branch.ToString, Group.Text}
        rpt.ShowDialog()

        Close()

    End Sub

    Dim save As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save = True
        Close()
    End Sub

    Private Sub Popup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not save Then Return
        bm.ExcuteNonQuery("insert PopupHistory(BranchId,GroupId,UserName,Popup,Show,Ignore) select " & Module1.Branch & "," & Group.Text & "," & Module1.UserName & ",0 Popup,0 Show,1 Ignore")
    End Sub

    Private Sub Popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BringToFront()
        Refresh()
    End Sub
End Class