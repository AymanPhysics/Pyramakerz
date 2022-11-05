Imports System.Data.SqlClient

Public Class Employees
    Public TableName As String = "Employees"
    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtID.MaxLength = Length
        Dim v() As String = {"Id", "ArName", "EnName", "Image", "Gender", "SSN", "CountryId", "CityId", "ReligionId", "AreaId", "Address", "DateOfBirth", "JobId", "Notes", "Manager", "SystemUser", "BankAccount", "NationalId", "HomePhone", "Mobile", "Email", "Password", "LevelId", "Instractor", "Supervisor", "SalaryType", "hh", "mm", "GeneralManager", "HeadofDepartment", "DepartmentId", "Branch", "HasAttendance", "BasicSalary", "Stopped", "Accountant", "Board", "HiringDate", "Sales"}
        bm.Fields = v
        Dim c() As Control = {txtID, ArName, EnName, Imag, Gender, SSN, CountryId, CityId, ReligionId, AreaId, Address, DateOfBirth, JobId, Notes, Manager, SystemUser, BankAccount, NationalId, HomePhone, Mobile, Email, Password, LevelId, Instractor, Supervisor, SalaryType, hh, mm, GeneralManager, HeadofDepartment, DepartmentId, Branch, HasAttendance, BasicSalary, Stopped, Accountant, Board, HiringDate, Sales}
        bm.control = c

        Dim k() As String = {"Id"}
        bm.KeyFields = k

        bm.FillCombo("Countries", CountryId, "")
        bm.FillCombo("Religions", ReligionId, "")
        bm.FillCombo("NLevels", LevelId, "")
        bm.FillCombo("Jobs", JobId, "")
        bm.FillCombo("Branches", Branch, "")
        bm.FillCombo("Departments", DepartmentId, "")

        bm.Table_Name = TableName
        btnNew_Click(sender, e)
        bm.AllowDorp(Imag)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.FirstLast(New String() {"Id"}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {"Id"}, New String() {txtID.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ArName.Text.Trim = "" Or Not TestNames() Or Not TestPassword() Then
            Return
        End If
        If hh.Text.Trim = "" Then
            hh.Text = 0
        End If
        If mm.Text.Trim = "" Then
            mm.Text = 0
        End If
        If BasicSalary.Text.Trim = "" Then
            BasicSalary.Text = 0
        End If

        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
        If txtID.Text.Trim = "" Then
            txtID.Text = bm.ExecuteScalar("select max(Id)+1 from " & TableName)
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            lblLastEntry.Text = txtID.Text
            lblLastEntry.BackColor = Color.Red
            Refresh()
            Threading.Thread.Sleep(200)
            Refresh()
            lblLastEntry.BackColor = System.Drawing.Color.FromArgb(192, 192, 0)
            State = BasicMethods.SaveState.Insert
        End If
        bm.DefineValues()
        If Not bm.Save(New String() {"Id"}, New String() {txtID.Text.Trim}, State) Then
            If State = BasicMethods.SaveState.Insert Then
                txtID.Text = ""
                lblLastEntry.Text = ""
            End If
            Return
        End If
        bm.SaveImage("Employees", {"Id"}, {txtID.Text}, "Image", Imag)
        btnNew_Click(sender, e)
        AllowClose = True
    End Sub

    Function TestPassword() As Boolean
        If Password.Visible And Password.Text.Length < 6 Then
            bm.ShowMSG("Password length MUST be 6 characters at least ...")
            Password.Focus()
            Return False
        End If
        Return True
    End Function


    Function TestNames() As Boolean

        ArName.Text = ArName.Text.Trim
        EnName.Text = EnName.Text.Trim
        While ArName.Text.Contains("  ")
            ArName.Text = ArName.Text.Replace("  ", " ")
        End While
        While EnName.Text.Contains("  ")
            EnName.Text = EnName.Text.Replace("  ", " ")
        End While

        Dim Ar() As String
        Ar = ArName.Text.Split(" ")
        Dim En() As String
        En = EnName.Text.Split(" ")
        If Ar.Length <> En.Length Then
            bm.ShowMSG("Arabic Name Length must be EQUALE English Name Length")
            ArName.Focus()
            Return False
        End If

        Dim x As Integer = 0
        For i As Integer = 0 To Ar.Length - 1
            If Ar(i) = En(i) And Not IsNumeric(Ar(i)) Then
                bm.ShowMSG("Arabic Name could not be EQUALE English Name")
                EnName.Select(x, En(i).Length)
                EnName.Focus()
                Return False
            End If
            x += En(i).Length + 1
        Next


        For i As Integer = 0 To Ar.Length - 1
            Dim a As String = bm.ExecuteScalar("delete from Names  where Arabic_Name='" & Ar(i) & "' insert into Names (Arabic_Name,English_Name) values ('" & Ar(i) & "','" & En(i) & "')")
        Next

        Return True
    End Function
    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        bm.FirstLast(New String() {"Id"}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Sub FillControls()
        UndoNewId()
        bm.FillControls()
        'MessageBox.Show(Password.Text)
        Dim c As New SqlConnection(cmd.Connection.ConnectionString)
        Try
            Dim myCommand As SqlClient.SqlCommand = c.CreateCommand
            myCommand.CommandText = "select Image from Employees where Id='" & txtID.Text & "'"
            bm.OpenConnection(c)
            Dim imagedata() As Byte = CType(myCommand.ExecuteScalar(), Byte())
            bm.CloseConnection(c)
            Dim stmBLOBData As IO.MemoryStream = New IO.MemoryStream(imagedata)
            Imag.Image = Image.FromStream(stmBLOBData)
        Catch ex As Exception
            bm.CloseConnection(c)
            Imag.Image = Image.FromFile(Application.StartupPath & "\Images\no.photo.gif")
        End Try

        bm.ApplySecurity(New Button() {btnSave, btnDelete}, False, True, True, False, False, False, True, True, False)
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        bm.ClearControls()
        ClearControls()
    End Sub

    Sub NewId()
        txtID.Clear()
        txtID.Enabled = False
    End Sub

    Sub UndoNewId()
        txtID.Enabled = True
    End Sub

    Sub ClearControls()

        ArName.Clear()
        SystemUser_CheckedChanged(Nothing, Nothing)
        Supervisor_CheckedChanged(Nothing, Nothing)
        SalaryType_SelectedIndexChanged(Nothing, Nothing)
        HeadofDepartment_CheckedChanged(Nothing, Nothing)
        hh_Leave(Nothing, Nothing)
        mm_Leave(Nothing, Nothing)
        'txtID.Text = bm.ExecuteScalar("select max(Id)+1 from " & TableName)
        'If txtID.Text = "" Then txtID.Text = "1"
        'txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
        NewId()
        ArName.Focus()
        bm.ApplySecurity(New Button() {btnSave, btnDelete}, True, True, True, False, False, False, True, True, False)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where Id='" & txtID.Text.Trim & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {"Id"}, New String() {txtID.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub
    Dim lv As Boolean = False
    Private Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Leave
        If lv Or txtID.Text.Trim = "" Then
            Return
        End If
        lv = True
        txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
        bm.DefineValues()
        Dim dt As New DataTable
        bm.RetrieveAll(New String() {"Id"}, New String() {txtID.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
        'txtName.Text = dt(0)("Name")
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ArName.KeyDown, EnName.KeyDown, txtID.KeyDown, Gender.KeyDown, SSN.KeyDown, CountryId.KeyDown, CityId.KeyDown, ReligionId.KeyDown, AreaId.KeyDown, Address.KeyDown, DateOfBirth.KeyDown, JobId.KeyDown, Notes.KeyDown, Manager.KeyDown, SystemUser.KeyDown, BankAccount.KeyDown, NationalId.KeyDown, HomePhone.KeyDown, Mobile.KeyDown, Email.KeyDown, Password.KeyDown, EnName.KeyDown, LevelId.KeyDown, Instractor.KeyDown, Supervisor.KeyDown, GeneralManager.KeyDown, HeadofDepartment.KeyDown, HasAttendance.KeyDown, SalaryType.KeyDown, SalaryType.KeyDown, hh.KeyDown, mm.KeyDown, GeneralManager.KeyDown, HeadofDepartment.KeyDown, DepartmentId.KeyDown, Branch.KeyDown, HasAttendance.KeyDown, BasicSalary.KeyDown, Stopped.KeyDown, Accountant.KeyDown, Board.KeyDown, HiringDate.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
            Try
                If CType(sender, TextBox).Name = "ArName" Then
                    ArName_Leave(Nothing, Nothing)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress, hh.KeyPress, mm.KeyPress, BasicSalary.KeyPress
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

    Private Sub SystemUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemUser.CheckedChanged, HasAttendance.CheckedChanged
        If SystemUser.Checked Or HasAttendance.Checked Then
            lblPassword.Visible = True
            Password.Visible = True
        Else
            lblPassword.Visible = False
            Password.Visible = False
            Password.Clear()
        End If

        If SystemUser.Checked And Module1.UserName = Module1.SystemAdmin Then
            LevelId.Visible = True
        Else
            LevelId.Visible = False
            If Module1.UserName = Module1.SystemAdmin Then LevelId.SelectedValue = 0
        End If

    End Sub

    Private Sub CountryId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountryId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = CountryId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Cities", CityId, " where CountryId='" & s & "'")
    End Sub

    Private Sub CityId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityId.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = CountryId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = CityId.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Areas", AreaId, " where CountryId='" & s & "' and CityId='" & s1 & "'")
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
        Imag.Image = Image.FromFile(Application.StartupPath & "\Images\no.photo.gif")
    End Sub

    Private Sub ArName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArName.Leave
        ArName.Text = ArName.Text.Trim
        While ArName.Text.Contains("  ")
            ArName.Text = ArName.Text.Replace("  ", " ")
        End While
        Dim s() As String
        s = ArName.Text.Split(" ")
        EnName.Clear()
        For i As Integer = 0 To s.Length - 1
            Dim a As String = bm.ExecuteScalar("select top 1 English_Name from Names where Arabic_Name='" & s(i) & "'")
            If a = "" Then
                EnName.Text &= s(i)
            Else
                EnName.Text &= a
            End If
            EnName.Text &= " "
        Next
        EnName.Text = EnName.Text.Trim
    End Sub

    Private Sub Supervisor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supervisor.CheckedChanged
        If Supervisor.Checked Then
            Branch.Visible = True
        Else
            Branch.Visible = False
            Branch.SelectedValue = 0
        End If
    End Sub

    Private Sub HeadofDepartment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadofDepartment.CheckedChanged, Instractor.CheckedChanged, Board.CheckedChanged
        If HeadofDepartment.Checked Or Instractor.Checked Then
            DepartmentId.Visible = True
        Else
            DepartmentId.Visible = False
            DepartmentId.SelectedValue = 0
        End If
    End Sub

    Private Sub SalaryType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryType.SelectedIndexChanged
        If SalaryType.SelectedIndex = 0 Then
            lblDuration.Visible = True
            hh.Visible = True
            lblhh.Visible = True
            mm.Visible = True
            lblmm.Visible = True
            Label28.Text = "Basic Salary"
        Else
            lblDuration.Visible = False
            hh.Visible = False
            lblhh.Visible = False
            mm.Visible = False
            lblmm.Visible = False
            hh.Text = 0
            mm.Text = 0
            Label28.Text = "Hour Rate"
        End If
    End Sub

    Private Sub hh_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hh.Leave, BasicSalary.Leave
        If hh.Text.Trim = "" Then
            hh.Text = 0
        End If
    End Sub

    Private Sub mm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mm.Leave
        If mm.Text.Trim = "" Then
            mm.Text = 0
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


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim hh As New Help
        hh.FirstColumn = "Employee Id"
        hh.SecondColumn = "Employee EnName"
        hh.Statement = "select cast(Id as varchar(100)) Id,EnName from Employees  order by EnName"
        hh.ShowDialog()
        txtID.Text = hh.SelectedId
        txtID_Leave(Nothing, Nothing)
    End Sub
End Class