Public Class SearchWaiting
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim bm As New BasicMethods
    Public StudentId As String = ""
    Public TableWhere As String = ""
    
    Private Sub SearchWaiting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Module1.MyProject = Project.EFG Then CreateVirtualGroup.Visible = False
        FromDate.Value = Now.Date.AddMonths(-6)
        ToDate.Value = Now.Date.AddMonths(1)
        'GetWaiting()
        bm.FillCombo("Cities", Cities, " where CountryId='" & Module1.CountryId & "'")
        bm.FillCombo("Branches", Branch, "")
        bm.FillCombo("Departments", DepartmentId, "")
        DepartmentId_SelectedIndexChanged(Nothing, Nothing)
        bm.FillCombo("Departments", DepartmentId2, "")
        DepartmentId2_SelectedIndexChanged(Nothing, Nothing)
        bm.FillCombo("select Id,EnName Name from Employees where Instractor='1' /*and Stopped='0'*/ union select 0 Id,'-' Name order by Name", Instractor)
        Days1.SelectedIndex = 2
        Days2.SelectedIndex = 2
        Days3.SelectedIndex = 2
        Shift1.SelectedIndex = 2
        Shift2.SelectedIndex = 2
        Shift3.SelectedIndex = 2
        Shift4.SelectedIndex = 2
        Delayed.SelectedIndex = 2
    End Sub
    Sub GetWaiting() Handles btnSearch.Click
        'dv = New DataView(bm.ExcuteAdapter("GetWaiting"))
        btnSearch.Enabled = False
        dv = New DataView(bm.ExcuteAdapter("GetWaiting2", {"Where"}, {RowFilter()}))
        btnSearch.Enabled = True
        DataGridView1.DataSource = dv

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(5).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True
        DataGridView1.Columns(7).ReadOnly = True
        DataGridView1.Columns(8).ReadOnly = True
        DataGridView1.Columns(9).ReadOnly = True
        DataGridView1.Columns(10).ReadOnly = True
        DataGridView1.Columns(11).ReadOnly = True
        DataGridView1.Columns(12).ReadOnly = True
        DataGridView1.Columns(13).ReadOnly = True
        DataGridView1.Columns(14).ReadOnly = True
        DataGridView1.Columns(15).ReadOnly = True
        DataGridView1.Columns(16).ReadOnly = True
        DataGridView1.Columns(17).ReadOnly = True
        DataGridView1.Columns(18).ReadOnly = True
        DataGridView1.Columns(19).ReadOnly = True
        DataGridView1.Columns(20).ReadOnly = True
        DataGridView1.Columns(21).ReadOnly = True
        DataGridView1.Columns(22).ReadOnly = True
        DataGridView1.Columns(23).ReadOnly = True
        DataGridView1.Columns(24).ReadOnly = True
        DataGridView1.Columns(25).ReadOnly = False
        DataGridView1.Columns(26).ReadOnly = False

        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(10).Visible = False
        DataGridView1.Columns(12).Visible = False
        DataGridView1.Columns(23).Visible = False
        DataGridView1.Columns(24).Visible = False

        DataGridView1.Columns(0).FillWeight = 65
        DataGridView1.Columns(2).FillWeight = 70
        DataGridView1.Columns(4).FillWeight = 70
        DataGridView1.Columns(5).FillWeight = 100
        DataGridView1.Columns(6).FillWeight = 70
        DataGridView1.Columns(7).FillWeight = 70
        DataGridView1.Columns(11).FillWeight = 90
        DataGridView1.Columns(14).FillWeight = 55
        DataGridView1.Columns(15).FillWeight = 55
        DataGridView1.Columns(16).FillWeight = 55
        DataGridView1.Columns(17).FillWeight = 55
        DataGridView1.Columns(18).FillWeight = 55
        DataGridView1.Columns(19).FillWeight = 55
        DataGridView1.Columns(20).FillWeight = 55
        DataGridView1.Columns(21).FillWeight = 55
        DataGridView1.Columns(23).FillWeight = 60
        DataGridView1.Columns(24).FillWeight = 60
        DataGridView1.Columns(25).FillWeight = 150
        DataGridView1.Columns(26).FillWeight = 70

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

    Private Sub CityId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cities.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = Cities.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Branches", Branch, " where CountryId='" & Module1.CountryId & "' and CityId='" & s & "'")
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
        bm.FillCombo("CoursesLevels", LevelId, " where DepartmentId='" & s & "' and CategoryId='" & s1 & "'")
    End Sub

    Sub Search(ByVal Col As String)
        Try
            Dim S1 As String = ""
            Dim S2 As String = ""
            Dim S3 As String = ""
            Dim S4 As String = ""
            Dim D1 As String = ""
            Dim D2 As String = ""
            Dim D3 As String = ""
            Dim Dly As String = ""

            If Shift1.SelectedIndex = 0 Then : S1 = "False" : ElseIf Shift1.SelectedIndex = 1 Then : S1 = "True" : End If
            If Shift2.SelectedIndex = 0 Then : S2 = "False" : ElseIf Shift2.SelectedIndex = 1 Then : S2 = "True" : End If
            If Shift3.SelectedIndex = 0 Then : S3 = "False" : ElseIf Shift3.SelectedIndex = 1 Then : S3 = "True" : End If
            If Shift4.SelectedIndex = 0 Then : S4 = "False" : ElseIf Shift4.SelectedIndex = 1 Then : S4 = "True" : End If
            If Days1.SelectedIndex = 0 Then : D1 = "False" : ElseIf Days1.SelectedIndex = 1 Then : D1 = "True" : End If
            If Days2.SelectedIndex = 0 Then : D2 = "False" : ElseIf Days2.SelectedIndex = 1 Then : D2 = "True" : End If
            If Days3.SelectedIndex = 0 Then : D3 = "False" : ElseIf Days3.SelectedIndex = 1 Then : D3 = "True" : End If
            If Delayed.SelectedIndex = 0 Then : Dly = "False" : ElseIf Delayed.SelectedIndex = 1 Then : Dly = "True" : End If

            Dim ct As String = "" : Try : ct = Cities.Text : Catch ex As Exception : End Try
            Dim b As String = "" : Try : b = Branch.SelectedValue.ToString : Catch ex As Exception : End Try
            Dim d As String = "" : Try : d = DepartmentId.SelectedValue.ToString : Catch ex As Exception : End Try
            Dim c As String = "" : Try : c = CategoryId.SelectedValue.ToString : Catch ex As Exception : End Try
            Dim l As String = "" : Try : l = LevelId.SelectedValue.ToString : Catch ex As Exception : End Try 

            If ct = "-" Then ct = ""
            If b = "0" Then b = ""
            If d = "0" Then d = ""
            If c = "0" Then c = ""
            If l = "0" Then l = ""


            'dv.RowFilter = "CityName like '%" & Cities.Text & "%' and BranchId like '%" & Branch.SelectedValue.ToString & "%' and StudentId like '%" & txtID.Text.Trim & "%' and EnName like '%" & EnName.Text.Trim & "%' and Mobile like '%" & Mobile.Text.Trim & "%' and DepartmentId like '%" & d & "%' and CategoryId like '%" & c & "%' and StLevel like '%" & l & "%' and DelayUntil<='" & DayDate.Text & "'"

            dv.RowFilter = " StudentId like '%" & txtID.Text.Trim & "%' and EnName like '%" & EnName.Text.Trim & "%' and Mobile like '%" & Mobile.Text.Trim & "%' and HomePhone like '%" & HomePhone.Text.Trim & "%' and DelayUntil>='" & bm.ToStrDate(FromDate.Text) & "' and DelayUntil<='" & bm.ToStrDate(ToDate.Text) & "' and Notes like '%" & Notes.Text.Trim & "%' "

            dv.RowFilter &= IIf(ct <> "", " and CityName ='" & ct & "'", "")
            dv.RowFilter &= IIf(b <> "", " and BranchId ='" & b & "'", "")
            dv.RowFilter &= IIf(d <> "", " and DepartmentId ='" & d & "'", "")
            dv.RowFilter &= IIf(c <> "", " and CategoryId ='" & c & "'", "")
            dv.RowFilter &= IIf(l <> "", " and StLevel ='" & l & "'", "")

            dv.RowFilter &= IIf(S1 <> "", " and Shift1 ='" & S1 & "'", "")
            dv.RowFilter &= IIf(S2 <> "", " and Shift2 ='" & S2 & "'", "")
            dv.RowFilter &= IIf(S3 <> "", " and Shift3 ='" & S3 & "'", "")
            dv.RowFilter &= IIf(S4 <> "", " and Shift4 ='" & S4 & "'", "")
            dv.RowFilter &= IIf(D1 <> "", " and Days1 ='" & D1 & "'", "")
            dv.RowFilter &= IIf(D2 <> "", " and Days2 ='" & D2 & "'", "")
            dv.RowFilter &= IIf(D3 <> "", " and Days3 ='" & D3 & "'", "")
            dv.RowFilter &= IIf(Dly <> "", " and Delayed ='" & Dly & "'", "")


            dv.Sort = Col
        Catch ex As Exception
        End Try
        DataGridView1_CellEndEdit(Nothing, Nothing)
    End Sub

    Function RowFilter() As String
        Dim S1 As String = ""
        Dim S2 As String = ""
        Dim S3 As String = ""
        Dim S4 As String = ""
        Dim D1 As String = ""
        Dim D2 As String = ""
        Dim D3 As String = ""
        Dim Dly As String = ""

        If Shift1.SelectedIndex = 0 Then : S1 = "False" : ElseIf Shift1.SelectedIndex = 1 Then : S1 = "True" : End If
        If Shift2.SelectedIndex = 0 Then : S2 = "False" : ElseIf Shift2.SelectedIndex = 1 Then : S2 = "True" : End If
        If Shift3.SelectedIndex = 0 Then : S3 = "False" : ElseIf Shift3.SelectedIndex = 1 Then : S3 = "True" : End If
        If Shift4.SelectedIndex = 0 Then : S4 = "False" : ElseIf Shift4.SelectedIndex = 1 Then : S4 = "True" : End If
        If Days1.SelectedIndex = 0 Then : D1 = "False" : ElseIf Days1.SelectedIndex = 1 Then : D1 = "True" : End If
        If Days2.SelectedIndex = 0 Then : D2 = "False" : ElseIf Days2.SelectedIndex = 1 Then : D2 = "True" : End If
        If Days3.SelectedIndex = 0 Then : D3 = "False" : ElseIf Days3.SelectedIndex = 1 Then : D3 = "True" : End If
        If Delayed.SelectedIndex = 0 Then : Dly = "False" : ElseIf Delayed.SelectedIndex = 1 Then : Dly = "True" : End If

        Dim ct As String = "" : Try : ct = Cities.Text : Catch ex As Exception : End Try
        Dim b As String = "" : Try : b = Branch.SelectedValue.ToString : Catch ex As Exception : End Try
        Dim d As String = "" : Try : d = DepartmentId.SelectedValue.ToString : Catch ex As Exception : End Try
        Dim c As String = "" : Try : c = CategoryId.SelectedValue.ToString : Catch ex As Exception : End Try
        Dim l As String = "" : Try : l = LevelId.SelectedValue.ToString : Catch ex As Exception : End Try

        If ct = "-" Then ct = ""
        If b = "0" Then b = ""
        If d = "0" Then d = ""
        If c = "0" Then c = ""
        If l = "0" Then l = ""

        RowFilter = " StudentId like '%" & txtID.Text.Trim & "%' and EnName like '%" & EnName.Text.Trim & "%' and Mobile like '%" & Mobile.Text.Trim & "%' and HomePhone like '%" & HomePhone.Text.Trim & "%' and DelayUntil between '" & bm.ToStrDate(FromDate.Text) & "' and '" & bm.ToStrDate(ToDate.Text) & "' and Notes like '%" & Notes.Text.Trim & "%' "

        RowFilter &= IIf(ct <> "", " and CityName ='" & ct & "'", "")
        RowFilter &= IIf(b <> "", " and BranchId ='" & b & "'", "")
        RowFilter &= IIf(d <> "", " and DepartmentId ='" & d & "'", "")
        RowFilter &= IIf(c <> "", " and CategoryId ='" & c & "'", "")
        RowFilter &= IIf(l <> "", " and StLevel ='" & l & "'", "")

        RowFilter &= IIf(S1 <> "", " and Shift1 ='" & S1 & "'", "")
        RowFilter &= IIf(S2 <> "", " and Shift2 ='" & S2 & "'", "")
        RowFilter &= IIf(S3 <> "", " and Shift3 ='" & S3 & "'", "")
        RowFilter &= IIf(S4 <> "", " and Shift4 ='" & S4 & "'", "")
        RowFilter &= IIf(D1 <> "", " and Days1 ='" & D1 & "'", "")
        RowFilter &= IIf(D2 <> "", " and Days2 ='" & D2 & "'", "")
        RowFilter &= IIf(D3 <> "", " and Days3 ='" & D3 & "'", "")
        RowFilter &= IIf(Dly <> "", " and Delayed ='" & Dly & "'", "")

    End Function

    Private Sub Branch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Branch.SelectedIndexChanged, txtID.TextChanged, EnName.TextChanged, LevelId.SelectedIndexChanged, Days1.SelectedIndexChanged, Days2.SelectedIndexChanged, Days3.SelectedIndexChanged, Shift1.SelectedIndexChanged, Shift2.SelectedIndexChanged, Shift3.SelectedIndexChanged, Shift4.SelectedIndexChanged, Delayed.SelectedIndexChanged, FromDate.ValueChanged, ToDate.ValueChanged, EnName.Enter, LevelId.Enter, Days1.Enter, Days2.Enter, Days3.Enter, Shift1.Enter, Shift2.Enter, Shift3.Enter, Shift4.Enter, Delayed.Enter, ToDate.Enter, Mobile.TextChanged, Mobile.Enter, HomePhone.TextChanged, HomePhone.Enter, Cities.SelectedIndexChanged, HomePhone.Enter, HomePhone.TextChanged, Notes.TextChanged

        If sender.GetType Is GetType(TextBox) Then
            Dim txt As TextBox = sender
            Search(txt.Tag.ToString)
        ElseIf sender.GetType Is GetType(ComboBox) Then
            Dim cbo As ComboBox = sender
            Search(cbo.Tag.ToString)
        ElseIf sender.GetType Is GetType(DateTimePicker) Then
            Dim dtp As DateTimePicker = sender
            Search(dtp.Tag.ToString)
        End If

    End Sub




    Private Sub CreateGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateGroup.Click
        Create("Groups", "GroupsStudents", 0)
    End Sub

    Private Sub CreateVirtualGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateVirtualGroup.Click
        Create("VirtualGroups", "VirtualGroupsStudents", 1)
    End Sub


    Sub Create(ByVal Tbl As String, ByVal SubTbl As String, ByVal Flag As Integer)
        If Course.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select A Cource ...")
            Return
        End If
        If Instractor.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Select an Instractor ...")
            Instractor.Focus()
            Return
        End If

        Dim Gp As String = bm.ExecuteScalar("select max(Id)+1 from " & Tbl & " where BranchId='" & Module1.Branch & "'")
        If Gp = "" Then Gp = "1"
        Gp = Gp.Trim.PadLeft(0, "0")

        bm.ExcuteNonQuery("Insert into " & Tbl & "(BranchId , UserName , Id , DepartmentId , CategoryId , Course , Instractor , DayDate , Days , Intensive , NoOfHours , Saturday , Sunday , Monday , Tuesday , Wednesday , Thursday , Friday , LectureNo , ChekPrivate , Notes , Closed , PrivateHours , PrivateMinits ) Values ('" & Module1.Branch & "', '" & Module1.UserName & "', '" & Gp & "', '" & DepartmentId2.SelectedValue.ToString & "', '" & CategoryId2.SelectedValue.ToString & "', '" & Course.SelectedValue.ToString & "', '" & Instractor.SelectedValue.ToString & "',GETDATE(), '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '', '0', '0', '0')")


        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(26).Value = False Then Continue For


            If Flag = 0 Then
                bm.ExcuteNonQuery("insert into " & SubTbl & "(BranchId,GroupId,StudentId,Degree,Degree2,UserName)values('" & Module1.Branch & "','" & Gp & "','" & DataGridView1.Rows(i).Cells(4).Value & "','0','0','" & Module1.UserName & "')")

                bm.ExcuteNonQuery("SetFlagEqual_2", New String() {"StudentId", "DepartmentId", "CategoryId", "Course"}, New String() {DataGridView1.Rows(i).Cells(4).Value, DepartmentId2.SelectedValue.ToString, CategoryId2.SelectedValue.ToString, LevelId.SelectedValue.ToString})
            ElseIf Flag = 1 Then

                bm.ExcuteNonQuery("insert into " & SubTbl & "(BranchId,GroupId,StudentId,UserName,Confirm,Attend,Delay,DelayUntil,Notes)values('" & Module1.Branch & "','" & Gp & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & Module1.UserName & "','0','0','0',getdate(),'')")

            End If

        Next

        Dim frm As New Groups
        frm.Flag = Flag
        If Flag = 0 Then
            frm = bm.ShowForm(Nothing, frm, "Groups", New Point(200, 200))
        Else
            frm = bm.ShowForm(Nothing, frm, "Virtual Groups", New Point(200, 200))
        End If

        frm.Branch.SelectedValue = Module1.Branch
        frm.Id.Text = Gp
        frm.txtID_Leave(Nothing, Nothing)
        frm.Show()
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim cnt As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(26).Value = True Then cnt += 1
        Next
        Label3.Text = "Select (" & cnt.ToString & ")"
        Try
            If e.ColumnIndex = 25 Then
                bm.ExcuteNonQuery("update Placement set Notes='" & DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace("'", "''") & "' where Flag=1 and BranchId='" & DataGridView1.Rows(e.RowIndex).Cells(1).Value & "' and InvoiceNo='" & DataGridView1.Rows(e.RowIndex).Cells(3).Value & "'")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DepartmentId2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentId2.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId2.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Categories", CategoryId2, " where DepartmentId='" & s & "'")
        CategoryId2_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CategoryId2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryId2.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = DepartmentId2.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = CategoryId2.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Items", Course, " where Course='1' and DepartmentId='" & s & "' and CategoryId='" & s1 & "'")
    End Sub

    Private Sub btnCourseSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourseSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Course Id"
        hh.SecondColumn = "Course Name"
        hh.Statement = "select cast(Id as varchar(100)) Id,Name from Items where Course='1' and DepartmentId='" & DepartmentId2.SelectedValue.ToString & "' and CategoryId='" & CategoryId2.SelectedValue.ToString & "'"
        hh.ShowDialog()
        Course.SelectedValue = hh.SelectedId
    End Sub

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees where Instractor='1' /*and Stopped='0'*/ order by EnName"
        hh.ShowDialog()
        Instractor.SelectedValue = hh.SelectedId
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(26).Value = CheckBox1.Checked
        Next
        DataGridView1_CellEndEdit(Nothing, Nothing)
    End Sub

    Private Sub AddToGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToGroup.Click
        Dim frm As New TransferStudents
        frm.Flag = 4
        frm.ShowDialog()
        If frm.MyBranch.ToString.Trim = "" Or frm.MyGroup.Trim = "" Then Return


        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(26).Value = False Then Continue For

            If bm.IF_Exists("select * from GroupsStudents where BranchId='" & frm.MyBranch & "' and GroupId='" & frm.MyGroup & "' and StudentId='" & DataGridView1.Rows(i).Cells(4).Value & "'") Then
                bm.ShowMSG("The Student " & DataGridView1.Rows(i).Cells(4).Value.ToString & " is Already Exist in this Group ...")
                Continue For
            End If
            bm.ExcuteNonQuery("insert into GroupsStudents(BranchId,GroupId,StudentId,Degree,Degree2,UserName)values('" & frm.MyBranch & "','" & frm.MyGroup & "','" & DataGridView1.Rows(i).Cells(4).Value & "','0','0','" & Module1.UserName & "')")

            bm.ExcuteNonQuery("SetFlagEqual_2", New String() {"StudentId", "DepartmentId", "CategoryId", "Course"}, New String() {DataGridView1.Rows(i).Cells(4).Value, DepartmentId2.SelectedValue.ToString, CategoryId2.SelectedValue.ToString, LevelId.SelectedValue.ToString})

        Next

        Dim frm2 As New Groups
        frm2.Flag = 0
        frm2 = bm.ShowForm(Nothing, frm2, "Groups", New Point(200, 200))

        frm2.Branch.SelectedValue = frm.MyBranch
        frm2.Id.Text = frm.MyGroup
        frm2.txtID_Leave(Nothing, Nothing)
        frm2.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "SearchWaiting.rpt"
        rpt.paraname = New String() {"@Where"}
        rpt.paravalue = New String() {RowFilter()}
        rpt.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "StudentActivities.rpt"
        rpt.paraname = New String() {"@StudentId", "@BranchId", "@FromDate", "@ToDate", "@Flag"}
        rpt.paravalue = New String() {DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString, 0, Now.ToShortDateString, Now.ToShortDateString, 1}
        'rpt.SubReports = New String() {"Financial", "Tecnical"}
        rpt.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "SearchWaiting2.rpt"
        rpt.paraname = New String() {"@Where"}
        rpt.paravalue = New String() {RowFilter()}
        rpt.ShowDialog()
    End Sub
End Class