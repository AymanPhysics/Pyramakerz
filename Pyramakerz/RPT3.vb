Public Class RPT3
    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub RPT3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        bm.FillCombo("Departments", DepartmentId, "")
        Type.SelectedIndex = 0
        DepartmentId_SelectedIndexChanged(Nothing, Nothing)
        CategoryId_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub DepartmentId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Categories", CategoryId, " where DepartmentId='" & s & "'")
        CategoryId_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CategoryId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = CategoryId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Items", ItemId, " where DepartmentId='" & s & "' and CategoryId='" & s1 & "'")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Branch.SelectedIndex < 0 Then Branch.SelectedIndex = 0
        If Flag = 1 Then
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "GetBalances.rpt"
            rpt.paraname = New String() {"@Branch", "@Type", "@DepartmentId", "@CategoryId", "@Detail", "@DeficitOnly"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString, Type.SelectedIndex.ToString, DepartmentId.SelectedValue.ToString, CategoryId.SelectedValue.ToString, ItemId.SelectedValue.ToString, IIf(DeficitOnly.Checked, "1", "0")}
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub DepartmentId_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Type.KeyDown, ItemId.KeyDown, DepartmentId.KeyDown, DeficitOnly.KeyDown, CategoryId.KeyDown, Branch.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub
End Class