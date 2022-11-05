Public Class VirtualGroupsStudents
    Dim bm As New BasicMethods

    Public SubTableName As String = "VirtualGroupsStudents"

    Public BranchId As String = ""
    Public GroupId As String = ""
    Public DepartmentId As String = ""
    Public CategoryId As String = ""
    Public Course As String = ""
    Public Import As Boolean = False
    Public IsClosed As Boolean = False
    Public Flag As Integer = 0

    Private Sub VirtualGroupsStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = bm.ExcuteAdapter("select G.StudentId,S.EnName,G.Confirm,G.Attend,G.Delay,cast(G.DelayUntil as date),G.Notes from " & SubTableName & " G left join Students S on(G.StudentId=S.ID) where G.BranchId='" & BranchId & "' and G.GroupId='" & GroupId & "'")

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim s2 As String = "No"
            If dt.Rows(i)(2).ToString = "1" Then s2 = "Yes"

            Dim s3 As String = "No"
            If dt.Rows(i)(3).ToString = "1" Then s3 = "Yes"

            DataGridView1.Rows.Add(New String() {dt.Rows(i)(0).ToString(), dt.Rows(i)(1).ToString, s2, s3, dt.Rows(i)(4).ToString, dt.Rows(i)(5), dt.Rows(i)(6).ToString})

        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If Not bm.SaveGrid(DataGridView1, SubTableName, New String() {"BranchId", "GroupId"}, New String() {BranchId, GroupId}, New String() {"CountryId", "CityId", "Value"}, New Integer() {0, 2, 4}, New VariantType() {VariantType.Integer, VariantType.Integer, VariantType.Decimal}) Then Return


        bm.ExcuteNonQuery("delete from " & SubTableName & " where BranchId='" & BranchId & "' and GroupId='" & GroupId & "'")
        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            Dim c2 As DataGridViewComboBoxCell = DataGridView1.Rows(i).Cells(2)
            Dim x2 As Integer = c2.Items.IndexOf(c2.Value.ToString())

            Dim c3 As DataGridViewComboBoxCell = DataGridView1.Rows(i).Cells(3)
            Dim x3 As Integer = c3.Items.IndexOf(c3.Value.ToString())


            DataGridView1.Rows(i).Cells(5).Value = DateTime.Parse(DataGridView1.Rows(i).Cells(5).Value.ToString)

            bm.ExcuteNonQuery("insert into " & SubTableName & "(BranchId,GroupId,StudentId,Confirm,Attend,Delay,DelayUntil,Notes,UserName)values('" & BranchId & "','" & GroupId & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & x2.ToString & "','" & x3.ToString & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & bm.ToStrDate(DateTime.Parse(DataGridView1.Rows(i).Cells(5).Value.ToString)) & "','" & DataGridView1.Rows(i).Cells(6).Value & "','" & Module1.UserName & "')")
            bm.ExcuteNonQuery("update Placement set Notes='" & DataGridView1.Rows(i).Cells(6).Value & "', UserName='" & Module1.UserName & "' where StudentId='" & DataGridView1.Rows(i).Cells(0).Value & "' and DepartmentId=dbo.GetVirtualGroupsDepartmentId('" & BranchId & "','" & GroupId & "') and CategoryId=dbo.GetVirtualGroupsCategoryId('" & BranchId & "','" & GroupId & "') and Course=dbo.GetVirtualGroupsCourse('" & BranchId & "','" & GroupId & "')")
        Next
        Saved = True
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

    Private Sub DataGridView1_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 4 Then
            If DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "1" Then
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = Now.AddDays(bm.GetDelayPeriod())
            End If
        ElseIf e.ColumnIndex = 5 Then
            If Not IsDate(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                bm.ShowMSG("Incorrect Date")
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "01-01-2000"
            End If
        End If
    End Sub

    Dim AllowClose As Boolean = False

    Dim Saved As Boolean = False

    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Saved = True Then Return

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

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        btnSave_Click(Nothing, Nothing)
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "VirtualGroupStudents.rpt"
        rpt.paraname = New String() {"@BranchId", "@GroupId"}
        rpt.paravalue = New String() {BranchId, GroupId}
        rpt.ShowDialog()
    End Sub
End Class