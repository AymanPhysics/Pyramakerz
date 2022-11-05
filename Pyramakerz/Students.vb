Imports System.Data.SqlClient

Public Class Students
    Public TableName As String = "Students"
    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods

    Public Flag As Integer = 0
    Private Sub Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.MaxLength = Length
        Dim v() As String = {"ID", "ArName", "EnName", "NationalId", "DateOfBirth", "CountryId", "CityId", "AreaId", "Address", "ReligionId", "Gender", "RankType", "RankCountry", "University", "Faculty", "SchoolCity", "School", "HomePhone", "WorkPhone", "Mobile", "Mobile2", "Email", "Notes", "UserName", "MyGetDate", "KnownUs", "Other", "FacebookMail", "RegistrationDate", "CompanyId", "RegBranch", "CardExpDate", "Barcode"} '"Image",
        bm.Fields = v
        Dim c() As Control = {txtID, ArName, EnName, NationalId, DateOfBirth, CountryId, CityId, AreaId, Address, ReligionId, Gender, RankType, RankCountry, University, Faculty, SchoolCity, School, HomePhone, WorkPhone, Mobile, Mobile2, Email, Notes, UserName, MyGetDate, KnownUs, Other, FacebookMail, RegistrationDate, CompanyId, RegBranch, CardExpDate, Barcode} 'Imag,
        bm.control = c

        Dim k() As String = {"ID"}
        bm.KeyFields = k

        bm.FillCombo("Branches", RegBranch, "")
        bm.FillCombo("Countries", CountryId, "")
        bm.FillCombo("Companies", CompanyId, "")
        bm.FillCombo("Religions", ReligionId, "")
        bm.FillCombo("Ranks", RankType, "")
        RankType_SelectedIndexChanged(Nothing, Nothing)
        bm.FillCombo("Countries", RankCountry, "")
        RankCountry_SelectedIndexChanged(Nothing, Nothing)
        bm.FillCombo("select Id,Name from HowDidYouKnowUs union select -1 Id,'Other' Name union select 0 Id,'-' Name order by Id", KnownUs)

        bm.Table_Name = TableName
        btnNew_Click(sender, e)
        bm.AllowDorp(Imag)
        Notes.Focus()
        RadioButton1.Checked = True
        Barcode.Enabled = True
        Barcode.ReadOnly = True
    End Sub

    Sub NewId()
        txtID.Clear()
        txtID.Enabled = False
    End Sub

    Sub UndoNewId()
        txtID.Enabled = True
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

    Dim MyLop As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        MyLop = True
        If Not TestValid() OrElse Not TestNames() OrElse Not TestMistakes() OrElse Not TestDuplicate() Then Return
        MyLop = False

        Dim State As BasicMethods.SaveState = BasicMethods.SaveState.Update
        If txtID.Text.Trim = "" Then
            txtID.Text = bm.ExecuteScalar("select max(Id)+1 from " & TableName)
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            Barcode.Text = bm.ean13(txtID.Text)
            lblLastEntry.Text = txtID.Text
            lblLastEntry.BackColor = Color.Red
            Refresh()
            Threading.Thread.Sleep(200)
            Refresh()
            lblLastEntry.BackColor = System.Drawing.Color.FromArgb(192, 192, 0)
            State = BasicMethods.SaveState.Insert
        Else
            bm.TestMistakeOrUpdate(UserName.Text, Name)
        End If

        NewSave()
        bm.DefineValues()
        If Not bm.Save(New String() {"Id"}, New String() {txtID.Text.Trim}, State) Then
            If State = BasicMethods.SaveState.Insert Then
                txtID.Text = ""
                lblLastEntry.Text = ""
            End If
            Return
        End If

        If Imag.Visible Then bm.SaveImage(cmd.Connection.Database & "Images.dbo.Students", {"ID"}, {txtID.Text}, "Image", Imag)
        btnNew_Click(sender, e)

        AllowClose = True
    End Sub

    Sub NewSave()
        UserName.Text = Module1.UserName
        UserName.BackColor = Color.Red
        UserName.ForeColor = Color.Blue
        Refresh()
        Threading.Thread.Sleep(200)
        UserName.BackColor = Color.White
        UserName.ForeColor = Color.Red
    End Sub

    Function TestMistakes() As Boolean
        Try
            If EnName.Text.Trim = "" Or Address.Text.Trim = "" Or RankType.SelectedValue.ToString = 0 Or RankCountry.SelectedValue.ToString = 0 Or ReligionId.SelectedValue.ToString = 0 Or (University.SelectedIndex < 1 And SchoolCity.SelectedIndex < 1) Or (Faculty.SelectedIndex < 1 And School.SelectedIndex < 1) Or HomePhone.Text.Trim = "" Or WorkPhone.Text.Trim = "" Or Mobile2.Text.Trim = "" Or Email.Text.Trim = "" Or KnownUs.SelectedValue.ToString = 0 Or (KnownUs.SelectedValue.ToString = -1 And Other.Text.Trim = "") Or CountryId.SelectedValue.ToString = 0 Or CityId.SelectedValue.ToString = 0 Or AreaId.SelectedValue.ToString = 0 Then
                Return bm.ShowDeleteMSG("There were SOME MISTAKES, Continue...?")
            End If
        Catch ex As Exception
            Return bm.ShowDeleteMSG("There were SOME MISTAKES, Continue...?")
        End Try
        Return True

    End Function

    Function TestDuplicate() As Boolean
        Dim s As String = bm.ExecuteScalar("select top 1 ID from Students where ID<>'" & txtID.Text & "' and ArName='" & ArName.Text & "' and DateOfBirth='" & bm.ToStrDate(DateOfBirth.Value) & "'")

        If s <> "" Then
            bm.ShowMSG("There was a DUPLICATE Arabic Name AND Date Of Birth with student no. '" & s & "'")
            Return False
        Else
            Return True
        End If

    End Function

    Function TestValid() As Boolean
        If ArName.Text.Trim = "" Then
            bm.ShowMSG("Please, Enter Arabic Name")
            ArName.Focus()
            Return False
        ElseIf EnName.Text.Trim = "" Then
            bm.ShowMSG("Please, Enter English Name")
            EnName.Focus()
            Return False
        ElseIf NationalId.Text.Length <> 14 And DateOfBirth.Value < Now.Date.AddYears(-17) Then
            bm.ShowMSG("Please, Enter A Correct National Id")
            NationalId.Focus()
            Return False
        ElseIf HomePhone.Text.Trim = "" And WorkPhone.Text.Trim = "" And Mobile.Text.Trim = "" And Mobile2.Text.Trim = "" Then
            bm.ShowMSG("Please, Enter Mobile")
            Mobile.Focus()
            Return False
        End If
        Return True
    End Function

    Function TestNames() As Boolean
        If Not MyLop Then ArName_Leave(Nothing, Nothing)
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

        If Imag.Visible Then
            GetImage()
        End If
    End Sub
    Sub GetImage()
        Dim c As New SqlConnection(cmd.Connection.ConnectionString)
        Try
            Dim myCommand As SqlClient.SqlCommand = c.CreateCommand
            myCommand.CommandText = "select Image from " & cmd.Connection.Database & "Images.dbo.Students where ID='" & txtID.Text & "'"
            bm.OpenConnection(c)
            Dim imagedata() As Byte = CType(myCommand.ExecuteScalar(), Byte())
            bm.CloseConnection(c)
            Dim stmBLOBData As IO.MemoryStream = New IO.MemoryStream(imagedata)
            Imag.Image = Image.FromStream(stmBLOBData)
        Catch ex As Exception
            bm.CloseConnection(c)
            Imag.Image = Image.FromFile(Application.StartupPath & "\Images\no.photo.gif")
        End Try
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        bm.ClearControls()
        ClearControls()
    End Sub

    Sub ClearControls()
        ArName.Clear()
        'txtID.Text = bm.ExecuteScalar("select max(ID)+1 from " & TableName)
        'If txtID.Text = "" Then txtID.Text = "1"
        'txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
        RegBranch.SelectedValue = Module1.Branch
        NewId()
        GetImage()
        Try
            RegistrationDate.Value = DateTime.Parse(bm.ExecuteScalar("select getdate()"))
        Catch ex As Exception
        End Try
        btnDelete.Enabled = True
        btnSave.Enabled = True
        ArName.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where ID='" & txtID.Text.Trim & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {"Id"}, New String() {txtID.Text}, "Back", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub
    Dim lv As Boolean = False
    Public Sub txtID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.Leave
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

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ArName.KeyDown, EnName.KeyDown, txtID.KeyDown, Gender.KeyDown, Gender.KeyDown, CountryId.KeyDown, CityId.KeyDown, ReligionId.KeyDown, AreaId.KeyDown, Address.KeyDown, DateOfBirth.KeyDown, Notes.KeyDown, NationalId.KeyDown, HomePhone.KeyDown, Mobile.KeyDown, Email.KeyDown, EnName.KeyDown, WorkPhone.KeyDown, Mobile2.KeyDown, SchoolCity.KeyDown, School.KeyDown, RankCountry.KeyDown, University.KeyDown, Faculty.KeyDown, RankType.KeyDown, RankType.KeyDown, RankCountry.KeyDown, University.KeyDown, Faculty.KeyDown, SchoolCity.KeyDown, School.KeyDown, Mobile2.KeyDown, Other.KeyDown, KnownUs.KeyDown, FacebookMail.KeyDown, RegistrationDate.KeyDown, CompanyId.KeyDown, RegBranch.KeyDown
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

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress, NationalId.KeyPress
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

    Private Sub RankCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RankCountry.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = RankCountry.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Cities", SchoolCity, " where CountryId='" & s & "'")
        bm.FillCombo("Universities", University, " where CountryId='" & s & "'")
    End Sub

    Private Sub SchoolCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolCity.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = RankCountry.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = SchoolCity.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Schools", School, " where CountryId='" & s & "' and CityId='" & s1 & "'")
        If SchoolCity.SelectedIndex > 0 Then University.SelectedIndex = 0
    End Sub

    Private Sub University_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles University.SelectedIndexChanged
        Dim s As String = ""
        Try
            s = RankCountry.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim s1 As String = ""
        Try
            s1 = University.SelectedValue.ToString
        Catch ex As Exception
        End Try
        bm.FillCombo("Faculties", Faculty, " where CountryId='" & s & "' and UniversityId='" & s1 & "'")
        If University.SelectedIndex > 0 Then SchoolCity.SelectedIndex = 0
    End Sub

    Private Sub RankType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RankType.SelectedIndexChanged
        Dim s As String = bm.ExecuteScalar("select Type from Ranks where Id='" & RankType.SelectedValue.ToString & "'")
        If s = "0" Then
            lblUniversity.Enabled = True
            lblFaculty.Enabled = True
            University.Enabled = True
            Faculty.Enabled = True

            lblCity.Enabled = False
            lblSchool.Enabled = False
            SchoolCity.Enabled = False
            School.Enabled = False

            SchoolCity.SelectedValue = 0

        ElseIf s = "1" Then
            lblUniversity.Enabled = False
            lblFaculty.Enabled = False
            University.Enabled = False
            Faculty.Enabled = False

            lblCity.Enabled = True
            lblSchool.Enabled = True
            SchoolCity.Enabled = True
            School.Enabled = True

            University.SelectedValue = 0

        ElseIf s = "2" Then
            lblUniversity.Enabled = True
            lblFaculty.Enabled = True
            University.Enabled = True
            Faculty.Enabled = True

            lblCity.Enabled = True
            lblSchool.Enabled = True
            SchoolCity.Enabled = True
            School.Enabled = True

        Else
            lblUniversity.Enabled = False
            lblFaculty.Enabled = False
            University.Enabled = False
            Faculty.Enabled = False

            lblCity.Enabled = False
            lblSchool.Enabled = False
            SchoolCity.Enabled = False
            School.Enabled = False

            SchoolCity.SelectedValue = 0
            University.SelectedValue = 0

        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New StSearch
        frm.ShowDialog()
        txtID.Text = frm.StudentId
        txtID_Leave(Nothing, Nothing)
    End Sub

    Private Sub KnownUs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnownUs.SelectedIndexChanged
        Try
            If KnownUs.SelectedValue.ToString = -1 Then
                Other.Visible = True
            Else
                Other.Visible = False
                Other.Clear()
            End If
        Catch ex As Exception
        End Try

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
    Private Sub MyBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            txtID.Text = bm.ScanStudent()
            txtID_Leave(Nothing, Nothing)
        End If
    End Sub
End Class