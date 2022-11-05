Public Class TransferStudents

    Public st As String = ""
    Public Degree As Integer = 0
    Public Degree2 As Integer = 0
    Dim bm As New BasicMethods
    Dim Length As Integer = 0

    Public TableName As String = "Groups"
    Public MainId As String = "BranchId"
    Public SubId As String = "Id"
    Public OldGroup As String = ""
    Public OldBranch As String = ""

    Public Ok As Boolean = False
    Public Flag As Integer = 1


    'For Flag4
    Public MyBranch As String = ""
    Public MyGroup As String = ""

    Private Sub TransferStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo("Branches", Branch, "")
        If Flag = 2 Then
            btnSave.Text = "Close Group"
        ElseIf Flag = 3 Then
            btnSave.Text = "Upgrade  Group"
        ElseIf Flag = 4 Then
            btnSave.Text = "Ok"
        ElseIf Flag = 5 Or Flag = 7 Or Flag = 8 Then
            btnSave.Text = "View"
        ElseIf Flag = 6 Then
            btnSave.Text = "Open Group"
        ElseIf Flag = 9 Then
            btnSave.Text = "Create"
            TableName = "VirtualGroups"
        ElseIf Flag = 10 Then
            btnSave.Text = "Add"
        End If
    End Sub

    Private Sub btnGroupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroupSearch.Click
        Dim hh As New GroupsSearch
        If Flag = 9 OrElse Flag = 10 Then
            hh.TableName = "VirtualGroups"
        End If
        hh.Branch = Branch.SelectedValue.ToString
        hh.ShowDialog()
        Id.Text = hh.SelectedId
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Sub ExecFlag1()
        If OldGroup = Id.Text And OldBranch = Branch.SelectedValue.ToString Then
            bm.ShowMSG("Please, Select another Group ...")
            Return
        End If

        If bm.IF_Exists("select * from GroupsStudents where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & Id.Text & "' and StudentId='" & st & "'") Then
            bm.ShowMSG("This Student is already EXIST in this Group ...")
            Return
        End If

        bm.ExcuteNonQuery("insert into GroupsStudents(BranchId,GroupId,StudentId,Degree,Degree2,UserName)values('" & Branch.SelectedValue.ToString & "','" & Id.Text & "','" & st & "','" & Degree & "','" & Degree2 & "','" & Module1.UserName & "')")
        Ok = True

    End Sub


    Sub ExecFlag2()
        Dim s As String = bm.ExecuteScalar("select Closed from Groups where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")
        If s = "1" Then
            bm.ShowMSG("This Group is already CLOSED ...")
            Id.Clear()
            Return
        End If
        bm.ExcuteNonQuery("update Groups set Closed='1',CloseDate=getdate(),username=" & Module1.UserName & " where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")

    End Sub

    Sub ExecFlag6()
        Dim s As String = bm.ExecuteScalar("select Upgraded from Groups where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")
        If s = "1" Then
            bm.ShowMSG("This Group is already UPGRADED ...")
            Id.Clear()
            Return
        End If

        s = ""
        s = bm.ExecuteScalar("select Closed from Groups where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")
        If s <> "1" Then
            bm.ShowMSG("This Group hasn't been CLOSED yet...")
            Id.Clear()
            Return
        End If
        bm.ExcuteNonQuery("update Groups set Closed='0',username=" & Module1.UserName & " where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")

    End Sub

    Sub ExecFlag3()

        Dim s As String = bm.ExecuteScalar("select Upgraded from Groups where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")
        If s = "1" Then
            bm.ShowMSG("This Group is already UPGRADED ...")
            Id.Clear()
            Return
        End If

        s = ""
        s = bm.ExecuteScalar("select Closed from Groups where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")
        If s <> "1" Then
            bm.ShowMSG("This Group hasn't been CLOSED yet...")
            Id.Clear()
            Return
        End If


        s = bm.ExecuteScalar("GetNextLevel", New String() {"BranchId", "GroupId"}, New String() {Branch.SelectedValue.ToString, Id.Text})
        If s = "" Then
            bm.ShowMSG("This Group is in LAST Level ...")
            Id.Clear()
            Return
        End If

        bm.ExcuteNonQuery("update Groups set Upgraded='1',UpgradeDate=getdate(),username=" & Module1.UserName & " where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")

        bm.ExcuteNonQuery("UpgradeStudents", New String() {"BranchId", "GroupId", "NewLevel"}, New String() {Branch.SelectedValue.ToString, Id.Text, s})

        Dim d As String = bm.ExecuteScalar("select DepartmentId from Groups where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")
        Dim c As String = bm.ExecuteScalar("select CategoryId from Groups where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")

        Dim dt As DataTable = bm.ExcuteAdapter("select StudentId from GroupsStudents where BranchId='" & Branch.SelectedValue.ToString & "' and GroupId='" & Id.Text & "' and Degree+Degree2>=50")

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim st As String = dt.Rows(i)(0).ToString
            Dim inv As String = bm.ExecuteScalar("select MAX(InvoiceNo) from Placement where BranchId='" & Branch.SelectedValue.ToString & "' and StudentId='" & st & "' and DepartmentId='" & d & "' and CategoryId='" & c & "'")
            Dim NewInv As String = bm.ExecuteScalar("select max(InvoiceNo)+1 from Placement where BranchId='" & Branch.SelectedValue.ToString & "'")
            If NewInv = "" Then NewInv = "1"
            NewInv = NewInv.PadLeft(0, "0")

            If inv = "" Then
                bm.ExcuteNonQuery("insert into Placement(BranchId,InvoiceNo,StudentId,DepartmentId,CategoryId,StLevel,Shift1,Shift2,Shift3,Shift4,Days1,Days2,Days3,Delayed,DelayUntil,Notes,UserName,Flag,Course,DayDate)                    SELECT '" & Branch.SelectedValue.ToString & "','" & NewInv & "','" & st & "','" & d & "','" & c & "',dbo.GetStudentLevel('" & st & "','" & d & "','" & c & "'),'1','1','1','1','1','1','1','0',GETDATE(),'','" & Module1.UserName & "','1',dbo.GetStudentLevel('" & st & "','" & d & "','" & c & "'),GETDATE() ")
            Else
                bm.ExcuteNonQuery("insert into Placement(BranchId,InvoiceNo,StudentId,DepartmentId,CategoryId,StLevel,Shift1,Shift2,Shift3,Shift4,Days1,Days2,Days3,Delayed,DelayUntil,Notes,UserName,Flag,Course,DayDate)                    SELECT BranchId,'" & NewInv & "',StudentId,DepartmentId,CategoryId,dbo.GetStudentLevel(StudentId,DepartmentId,CategoryId),Shift1,Shift2,Shift3,Shift4,Days1,Days2,Days3,Delayed,DelayUntil,Notes,'" & Module1.UserName & "','1',dbo.GetStudentLevel(StudentId,DepartmentId,CategoryId),GETDATE() FROM Placement where BranchId='" & Branch.SelectedValue.ToString & "' and InvoiceNo='" & inv & "'")
            End If

        Next
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Flag <> 8 AndAlso (Id.Text.Trim = "" Or Branch.SelectedIndex < 1) Then
            Return
        End If
        If Flag = 1 Then
            ExecFlag1()
        ElseIf Flag = 2 Then
            ExecFlag2()
        ElseIf Flag = 3 Then
            ExecFlag3()
        ElseIf Flag = 4 Then
            MyBranch = Branch.SelectedValue.ToString
            MyGroup = Id.Text
        ElseIf Flag = 5 Then
            ExecFlag5()
            Return
        ElseIf Flag = 6 Then
            ExecFlag6()
        ElseIf Flag = 7 Then
            ExecFlag7()
            Return
        ElseIf Flag = 8 Then
            ExecFlag8()
            Return
        ElseIf Flag = 9 Then
            ExecFlag9()
            Return
        ElseIf Flag = 10 Then
            ExecFlag10()
        End If
        AllowClose = True
        Close()
    End Sub

    Private Sub Id_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id.Leave
        Id.Text = Id.Text.Trim.PadLeft(Length, "0")
        Dim dt As DataTable = bm.ExcuteAdapter("select * from " & TableName & " where BranchId='" & Branch.SelectedValue.ToString & "' and Id='" & Id.Text & "'")
        If dt.Rows.Count = 0 Then Id.Clear()
    End Sub

    Private Sub Branch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.SelectedIndexChanged
        Id.Clear()
    End Sub

    Private Sub Id_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Id.KeyDown, Branch.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Dim AllowClose As Boolean = False
    Private Sub MyBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If AllowClose Then Return
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

    Private Sub ExecFlag5()
        If Branch.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select A Branch ...")
            Branch.Focus()
            Return
        End If
        If Id.Text.Trim = "" Then
            bm.ShowMSG("Please, Enter A Gruop ...")
            Id.Focus()
            Return
        End If
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "StudentsAttendanceSheet.rpt"
        rpt.paraname = New String() {"@BranchId", "@GroupId"}
        rpt.paravalue = New String() {Branch.SelectedValue.ToString, Id.Text}
        rpt.ShowDialog()
    End Sub

    Private Sub ExecFlag7()
        If Branch.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select A Branch ...")
            Branch.Focus()
            Return
        End If
        If Id.Text.Trim = "" Then
            bm.ShowMSG("Please, Enter A Gruop ...")
            Id.Focus()
            Return
        End If
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "StudentsAttendanceSheet2.rpt"
        rpt.paraname = New String() {"@BranchId", "@GroupId"}
        rpt.paravalue = New String() {Branch.SelectedValue.ToString, Id.Text}
        rpt.ShowDialog()
    End Sub

    Private Sub ExecFlag8()
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "VirtualGroupStudentsAll.rpt"
        rpt.paraname = New String() {"@BranchId", "@GroupId"}
        rpt.paravalue = New String() {Branch.SelectedValue.ToString, Val(Id.Text)}
        rpt.ShowDialog()
    End Sub


    Private Sub ExecFlag9()
        If bm.ShowDeleteMSG("Are you sure you want to CREATE a new REAL GROUP?") Then
            Dim s As String = bm.ExecuteScalar("CreateGroupFromVirtualGroups", {"BranchId", "Id"}, {Branch.SelectedValue, Id.Text.Trim})
            bm.ShowMSG("Group created with no. " & s)
        End If
    End Sub

    Public Days As Integer = 0
    Private Sub ExecFlag10()
        bm.ExecuteScalar("update Groups set Days='" & Days & "' where BranchId='" & Branch.SelectedValue & "' and Id='" & Id.Text.Trim & "'")
    End Sub
End Class