Imports System.Data.SqlClient

Public Class Items


    Public MainTableName As String = "Departments"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"


    Public Main2TableName As String = "Categories"
    Public Main2MainId As String = "DepartmentId"
    Public Main2SubId As String = "Id"
    Public Main2SubName As String = "Name"


    Public TableName As String = "Items"
    Public MainId As String = "DepartmentId"
    Public MainId2 As String = "CategoryId"
    Public SubId As String = "Id"
    Public SubName As String = "Name"

    Public CboTableName As String = "CoursesLevels"
    Public CboSubId As String = "Id"
    Public CboSubName As String = "Name"


    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.MaxLength = Length
        Course_CheckedChanged(Nothing, Nothing)
        bm.FillCombo(MainTableName, CboMain, "")
        Dim v() As String = {MainId, MainId2, SubId, SubName, "Refundable", "Course", "CourseLevel", "Duration", "Discountable", "HasContract", "IsCard", "SubCategory", "SubItemId"}
        bm.Fields = v

        Dim c() As Control = {CboMain, CboMain2, txtID, txtName, Refundable, Course, CboSub, Duration, Discountable, HasContract, IsCard, SubCategory, SubItemId}
        bm.control = c

        Dim k() As String = {MainId, MainId2, SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName

        bm.AllowDorp(Imag)
        btnNew_Click(sender, e)
        RadioButton1.Checked = True

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.FirstLast(New String() {MainId, MainId2, SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {MainId, MainId2, SubId}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text.Trim = "" Or CboMain.SelectedValue.ToString = 0 Or CboMain2.SelectedValue.ToString = 0 Then
            Return
        End If


        bm.DefineValues()
        If Not bm.Save(New String() {MainId, MainId2, SubId}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text.Trim}) Then Return
        If Not bm.ExcuteNonQuery(SaveGrid() & vbCrLf & SaveGrid2() & vbCrLf & SaveGrid3()) Then Return

        If Imag.Visible Then bm.SaveImage(cmd.Connection.Database & "Images.dbo.Items", {MainId, MainId2, SubId}, {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text.Trim}, "Image", Imag)

        btnNew_Click(sender, e)
        AllowClose = True
    End Sub

    Function SaveGrid() As String
        Return bm.SaveGrid(DataGridView1, "ItemDetails", New String() {"DepartmentId", "CategoryId", "ItemId"}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text}, New String() {"CountryId", "CityId", "Value"}, New Integer() {0, 2, 4}, New VariantType() {VariantType.Integer, VariantType.Integer, VariantType.Decimal})

        'bm.ExcuteNonQuery("delete from ItemDetails where DepartmentId ='" & CboMain.SelectedValue.ToString & "' and CategoryId ='" & CboMain2.SelectedValue.ToString & "' and ItemId='" & txtID.Text & "'")
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Rows(i).Cells(4).Value.ToString = Nothing Then
        '        DataGridView1.Rows(i).Cells(4).Value = 0
        '    End If
        '    bm.ExcuteNonQuery("insert into ItemDetails(DepartmentId ,CategoryId ,ItemId ,CountryId ,CityId ,Value) values('" & CboMain.SelectedValue.ToString & "','" & CboMain2.SelectedValue.ToString & "','" & txtID.Text & "','" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "'," & DataGridView1.Rows(i).Cells(4).Value & ")")
        'Next
    End Function

    Function SaveGrid2() As String
        Return bm.SaveGrid(DataGridView2, "CourseDetails", New String() {"DepartmentId", "CategoryId", "CourseId"}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text}, New String() {"MemberShipId", "Eligible"}, New Integer() {0, 2}, New VariantType() {VariantType.Integer, VariantType.Boolean})

        'bm.ExcuteNonQuery("delete from CourseDetails where  DepartmentId='" & CboMain.SelectedValue.ToString & "' and CategoryId='" & CboMain2.SelectedValue.ToString & "' and CourseId ='" & txtID.Text & "'")
        'For i As Integer = 0 To DataGridView2.Rows.Count - 1
        '    If DataGridView2.Rows(i).Cells(2).Value.ToString = Nothing Then
        '        DataGridView2.Rows(i).Cells(2).Value = 0
        '    End If
        '    Dim s As String = "0"
        '    If DataGridView2.Rows(i).Cells(2).Value Then s = "1"
        '    bm.ExcuteNonQuery("insert into CourseDetails(DepartmentId,CategoryId,CourseId ,MemberShipId ,Eligible) values('" & CboMain.SelectedValue.ToString & "','" & CboMain2.SelectedValue.ToString & "','" & txtID.Text & "','" & DataGridView2.Rows(i).Cells(0).Value & "'," & s & ")")
        'Next
    End Function

    Function SaveGrid3() As String
        Return bm.SaveGrid(DataGridView3, "ItemBal", New String() {"DepartmentId", "CategoryId", "ItemId"}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text}, New String() {"BranchId", "Bal0", "Limit"}, New Integer() {0, 2, 3}, New VariantType() {VariantType.Integer, VariantType.Integer, VariantType.Integer})

        'bm.ExcuteNonQuery("delete from ItemBal where DepartmentId ='" & CboMain.SelectedValue.ToString & "' and CategoryId ='" & CboMain2.SelectedValue.ToString & "' and ItemId='" & txtID.Text & "'")
        'For i As Integer = 0 To DataGridView3.Rows.Count - 1
        '    If DataGridView3.Rows(i).Cells(2).Value.ToString = Nothing Then
        '        DataGridView3.Rows(i).Cells(2).Value = 0
        '    End If
        '    If DataGridView3.Rows(i).Cells(3).Value.ToString = Nothing Then
        '        DataGridView3.Rows(i).Cells(3).Value = 0
        '    End If

        '    bm.ExcuteNonQuery("insert into ItemBal(DepartmentId ,CategoryId ,ItemId ,BranchId ,Bal0,Limit) values('" & CboMain.SelectedValue.ToString & "','" & CboMain2.SelectedValue.ToString & "','" & txtID.Text & "','" & DataGridView3.Rows(i).Cells(0).Value & "','" & DataGridView3.Rows(i).Cells(2).Value & "'," & DataGridView3.Rows(i).Cells(3).Value & ")")
        'Next
    End Function

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        bm.FirstLast(New String() {MainId, MainId2, SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Sub FillControls()
        Try
            bm.FillControls()
            Dim dt As DataTable = bm.ExcuteAdapter("select CN.Id ,CN.Name Country,CT.Id ,CT.Name City,0. Price from Countries CN left join Cities CT on(CN.Id=CT.CountryId)")

            DataGridView1.DataSource = dt
            Dim dt2 As DataTable = bm.ExcuteAdapter("select CountryId,CityId,Value from ItemDetails where DepartmentId ='" & CboMain.SelectedValue.ToString & "' and CategoryId ='" & CboMain2.SelectedValue.ToString & "' and ItemId='" & txtID.Text & "'")
            For i As Integer = 0 To dt2.Rows.Count - 1
                For i2 As Integer = 0 To DataGridView1.Rows.Count - 1
                    If dt2.Rows(i)(0).ToString = DataGridView1.Rows(i2).Cells(0).Value.ToString And dt2.Rows(i)(1).ToString = DataGridView1.Rows(i2).Cells(2).Value.ToString Then
                        DataGridView1.Rows(i2).Cells(4).Value = dt2.Rows(i)(2).ToString
                    End If
                Next
            Next
            DrawGrid()
            
        Catch ex As Exception
        End Try


        Try
            Dim dt As DataTable = bm.ExcuteAdapter("select Id,Name 'MemberShip',cast(0 as bit) 'Eligible' from MemberShips")
            DataGridView2.DataSource = dt
            Dim dt2 As DataTable = bm.ExcuteAdapter("select MemberShipId,Eligible from CourseDetails where DepartmentId='" & CboMain.SelectedValue.ToString & "' and CategoryId='" & CboMain2.SelectedValue.ToString & "' and CourseId ='" & txtID.Text & "'")
            For i As Integer = 0 To dt2.Rows.Count - 1
                For i2 As Integer = 0 To DataGridView2.Rows.Count - 1
                    If dt2.Rows(i)(0).ToString = DataGridView2.Rows(i2).Cells(0).Value.ToString Then
                        Dim ss As String = dt2.Rows(i)(1).ToString
                        If ss = "1" Then DataGridView2.Rows(i2).Cells(2).Value = True
                    End If
                Next
            Next
            DrawGrid2()
        Catch ex As Exception
        End Try


        Try
            Dim dt As DataTable = bm.ExcuteAdapter("select Id,Name Branch,0 Bal0,0 Limit from Branches")

            DataGridView3.DataSource = dt
            Dim dt2 As DataTable = bm.ExcuteAdapter("select BranchId,Bal0,Limit from ItemBal where DepartmentId ='" & CboMain.SelectedValue.ToString & "' and CategoryId ='" & CboMain2.SelectedValue.ToString & "' and ItemId='" & txtID.Text & "'")
            For i As Integer = 0 To dt2.Rows.Count - 1
                For i2 As Integer = 0 To DataGridView3.Rows.Count - 1
                    If dt2.Rows(i)(0).ToString = DataGridView3.Rows(i2).Cells(0).Value.ToString Then
                        DataGridView3.Rows(i2).Cells(2).Value = dt2.Rows(i)(1).ToString
                        DataGridView3.Rows(i2).Cells(3).Value = dt2.Rows(i)(2).ToString
                    End If
                Next
            Next
            DrawGrid3()
        Catch ex As Exception
        End Try

        If Imag.Visible Then
            GetImage()
        End If

    End Sub

    Sub GetImage()
        Dim c As New SqlConnection(cmd.Connection.ConnectionString)
        Try
            Dim myCommand As SqlClient.SqlCommand = c.CreateCommand
            myCommand.CommandText = "select Image from " & cmd.Connection.Database & "Images.dbo.Items where DepartmentId ='" & CboMain.SelectedValue.ToString & "' and CategoryId ='" & CboMain2.SelectedValue.ToString & "' and Id='" & txtID.Text & "'"
            bm.OpenConnection(c)
            Dim imagedata() As Byte = CType(myCommand.ExecuteScalar(), Byte())
            bm.CloseConnection(c)
            Dim stmBLOBData As IO.MemoryStream = New IO.MemoryStream(imagedata)
            Imag.Image = Image.FromStream(stmBLOBData)
        Catch ex As Exception
            bm.CloseConnection(c)
            Imag.Image = Nothing
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Imag.Image = Image.FromFile(OFD.FileName)
            End If
        Catch
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Imag.Image = Nothing
    End Sub

    Sub DrawGrid()
        Try

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).ReadOnly = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).ReadOnly = True


            DataGridView1.Columns(1).FillWeight = 100
            DataGridView1.Columns(3).FillWeight = 100
            DataGridView1.Columns(4).FillWeight = 70
        Catch ex As Exception

        End Try
    End Sub

    Sub DrawGrid2()
        Try
            DataGridView2.Columns(0).Visible = False
            DataGridView2.Columns(1).ReadOnly = True

            DataGridView2.Columns(1).FillWeight = 100
            DataGridView2.Columns(2).FillWeight = 40
        Catch ex As Exception

        End Try
    End Sub

    Sub DrawGrid3()
        Try

            DataGridView3.Columns(0).Visible = False
            DataGridView3.Columns(1).ReadOnly = True


            DataGridView3.Columns(1).FillWeight = 100
            DataGridView3.Columns(2).FillWeight = 70
            DataGridView3.Columns(3).FillWeight = 70
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'bm.ClearControls()
        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            txtName.Clear()
            Refundable.Checked = False
            Course.SelectedIndex = 0
            bm.FillCombo(CboSub, CboTableName, CboSubId, CboSubName, " where " & MainId & "='" & CboMain.SelectedValue.ToString & "' and " & MainId2 & "='" & CboMain2.SelectedValue.ToString & "'")
            CboSub.SelectedIndex = 0
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            DataGridView1.DataSource = bm.ExcuteAdapter("select CN.Id ,CN.Name Country,CT.Id ,CT.Name City,0. Price from Countries CN left join Cities CT on(CN.Id=CT.CountryId)")

            DrawGrid()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            txtID.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & CboMain.SelectedValue.ToString & "' and " & MainId2 & "='" & CboMain2.SelectedValue.ToString & "'")


            DataGridView2.DataSource = bm.ExcuteAdapter("select Id,Name 'MemberShip',cast(0 as bit) 'Eligible' from MemberShips")
            DrawGrid2()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            DataGridView3.DataSource = bm.ExcuteAdapter("select Id,Name Branch,0 Bal0,0 Limit from Branches")

            DrawGrid3()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            GetImage()


            Course_CheckedChanged(Nothing, Nothing)
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            txtName.Focus()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & txtID.Text.Trim & "' and " & MainId & " ='" & CboMain.SelectedValue.ToString & "' and " & MainId2 & " ='" & CboMain2.SelectedValue.ToString & "'")
            bm.ExcuteNonQuery("delete from ItemDetails where DepartmentId ='" & CboMain.SelectedValue.ToString & "' and CategoryId ='" & CboMain2.SelectedValue.ToString & "' and ItemId='" & txtID.Text & "'")
            bm.ExcuteNonQuery("delete from ItemBal where " & SubId & "='" & txtID.Text.Trim & "' and " & MainId & " ='" & CboMain.SelectedValue.ToString & "' and " & MainId2 & " ='" & CboMain2.SelectedValue.ToString & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {MainId, MainId2, SubId}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub
    Dim lv As Boolean = False
    Private Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Leave
        If lv Then
            Return
        End If
        lv = True
        txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
        bm.DefineValues()
        Dim dt As New DataTable
        bm.RetrieveAll(New String() {MainId, MainId2, SubId}, New String() {CboMain.SelectedValue.ToString, CboMain2.SelectedValue.ToString, txtID.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, txtID.KeyDown, CboMain.KeyDown, CboMain2.KeyDown, Refundable.KeyDown, Discountable.KeyDown, Course.KeyDown, HasContract.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress, Duration.KeyPress
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

    Private Sub CboMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMain.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = CboMain.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Try
            bm.FillCombo(Main2TableName, CboMain2, " where " & Main2MainId & "='" & s & "'")
            ClearControls()
        Catch ex As Exception
        End Try
        Try
            bm.FillCombo(Main2TableName, SubCategory, " where " & Main2MainId & "='" & s & "'")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CboMain2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMain2.SelectedIndexChanged
        ClearControls()
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub Course_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Course.SelectedIndexChanged

        If Course.SelectedIndex = 1 Or Course.SelectedIndex = 2 Or Course.SelectedIndex = 3 Or IsCard.Checked Then
            Size = New Size(840, 542)
        Else
            Size = New Size(471, 542)
        End If

        If Course.SelectedIndex = 1 Then
            lblSubCategory.Visible = False
            SubCategory.Visible = False
            lblSubItemId.Visible = False
            SubItemId.Visible = False

            lblSub.Visible = True
            Label7.Visible = True
            DataGridView2.Visible = True
            DataGridView3.Visible = False
            CboSub.Visible = True
            Duration.Visible = True
            Size = New Size(840, 542)
        ElseIf Course.SelectedIndex = 2 Then
            lblSubCategory.Visible = True
            SubCategory.Visible = True
            lblSubItemId.Visible = True
            SubItemId.Visible = True

            lblSub.Visible = False
            Label7.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            CboSub.Visible = False
            Duration.Visible = False
            Size = New Size(840, 542)
        ElseIf Course.SelectedIndex = 3 Then
            lblSubCategory.Visible = False
            SubCategory.Visible = False
            lblSubItemId.Visible = False
            SubItemId.Visible = False

            lblSub.Visible = False
            Label7.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            CboSub.Visible = False
            Duration.Visible = False
            Size = New Size(840, 542)
        Else
            lblSubCategory.Visible = False
            SubCategory.Visible = False
            lblSubItemId.Visible = False
            SubItemId.Visible = False

            lblSub.Visible = False
            Label7.Visible = False
            CboSub.SelectedValue = 0
            Duration.Text = 0
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            CboSub.Visible = False
            Duration.Visible = False
        End If

        
    End Sub

    Private Sub DataGridView3_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView3.DataError

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


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Imag.Visible = RadioButton2.Checked
        GetImage()
    End Sub

    Private Sub IsCard_CheckedChanged(sender As Object, e As EventArgs) Handles IsCard.CheckedChanged
        If Course.SelectedIndex = 1 Or Course.SelectedIndex = 2 Or Course.SelectedIndex = 3 Or IsCard.Checked Then
            Size = New Size(840, 542)
        Else
            Size = New Size(471, 542)
        End If


        If IsCard.Checked Then
            Imag.Visible = True
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            Button1.Visible = True
            Button2.Visible = True
        Else
            Imag.Visible = False
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            Button1.Visible = False
            Button2.Visible = False
        End If

        RadioButton1_CheckedChanged(Nothing, Nothing)
    End Sub
     
    Private Sub SubCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubCategory.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = CboMain.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s2 As String = ""
        Try
            s2 = SubCategory.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Try
            bm.FillCombo(TableName, SubItemId, " where " & MainId & "='" & s & "' and " & MainId2 & "='" & s2 & "'")
        Catch ex As Exception
        End Try
    End Sub
End Class