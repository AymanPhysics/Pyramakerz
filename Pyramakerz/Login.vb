Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Management
Imports System.Runtime.InteropServices

Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class Login
    Dim bm As New BasicMethods
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        If Not LoadConnection() Then Return


        bm.HandleColor(Me)
        BackColor = Module1.MyBackColor



        If MyProjectType = ProjectType.Table Then
            Module1.Branch = 0
            Dim frm As New Table
            frm.btnSave.Visible = False
            frm.ViewAttendance.Visible = False
            frm.Label24.Visible = False
            frm.CheckBox1.Visible = False
            'frm.DataGridView1.Visible = False
            frm.ShowDialog()
            Application.Exit()
            Return
        End If

        If Not MyProjectType = ProjectType.PCs Then bm.TestProtection()

        Dim v As Integer = Val(bm.ExecuteScalar("select LastVersion from LastVersion"))
        If v > Module1.LastVersion Or v = 0 Then
            bm.ShowMSG("There is a New Version, Please contact your admin ...")
            Application.Exit()
        End If

        If Module1.LastVersion > v Then
            bm.ExcuteNonQuery("delete from LastVersion insert into LastVersion (LastVersion) select " & Module1.LastVersion)
        End If

        bm.SetTime()

        For Each C As Control In Controls
            AddHandler C.KeyPress, AddressOf bm._KeyPress
        Next

        bm.FillCombo("select Id,EnName Name from Employees where SystemUser='1' and Stopped='0' union select 0 Id,'-' Name order by Name", Users)
        bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
    End Sub

    Function LoadConnection() As Boolean
        'If con.State = ConnectionState.Open Then Return
        If con.ConnectionString.Length > 0 Then Return True

        Dim st As New StreamReader(Application.StartupPath & "\Connect.udl")
        Dim s As String = ""
        st.ReadLine()
        st.ReadLine()
        s += st.ReadLine
        con.ConnectionString = s.Substring(20)
        Dim cb As New SqlClient.SqlConnectionStringBuilder(con.ConnectionString)
        Dim f As New Form1
        con.ConnectionString = "Data Source=" & cb.DataSource & ";Initial Catalog=" & cb.InitialCatalog & ";Persist Security Info=True;User ID=" & cb.UserID & ";Password=" & f.Password 'cb.Password
        con.ConnectionString &= ";Max Pool Size=1000"
        Try
            con.Open()
            bm.CloseConnection(con)
        Catch ex As Exception
            bm.ShowMSG("Database is currently Offline")
            Application.Exit()
            Return False
        End Try
        cmd.Connection = con
        Return True
    End Function
    Public LogedIn As Boolean = False
    Public Flag As Integer = 1
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Users.SelectedIndex < 1 Then Return
        Dim dt As DataTable

        Try
            dt = bm.ExcuteAdapter("select CountryId,CityId from Branches where Id='" & Branch.SelectedValue.ToString & "'")
        Catch ex As Exception
            bm.ShowMSG("Please, Select a Branch ...")
            Exit Sub
        End Try

        If dt.Rows.Count = 0 Then
            bm.ShowMSG("Please, Select a Branch ...")
            Exit Sub
        End If
        Module1.CountryId = dt.Rows(0)("CountryId").ToString
        Module1.CityId = dt.Rows(0)("CityId").ToString

        If Not bm.StopPro() Then Return
        Dim paraname() As String = {"Branch", "Id", "Password"}
        Dim paravalue() As String = {Branch.SelectedValue.ToString, Users.SelectedValue.ToString, bm.Encrypt(Password.Text)}
        dt = bm.ExcuteAdapter("TestLogin", paraname, paravalue)
        If dt.Rows.Count = 0 Then
            bm.ShowMSG("Invalid password ...")
            Exit Sub
        End If
        Module1.Branch = Branch.SelectedValue.ToString
        Module1.UserName = Users.SelectedValue.ToString
        Module1.ArName = dt.Rows(0)("ArName").ToString
        Module1.EnName = dt.Rows(0)("EnName").ToString
        Module1.JobId = dt.Rows(0)("JobId").ToString
        Module1.Manager = dt.Rows(0)("Manager").ToString
        Module1.LevelId = dt.Rows(0)("LevelId").ToString
        Module1.Password = bm.Decrypt(dt.Rows(0)("Password").ToString)
        Module1.GeneralManager = dt.Rows(0)("GeneralManager").ToString
        Module1.Board = dt.Rows(0)("Board").ToString
        Module1.Accountant = dt.Rows(0)("Accountant").ToString

        Module1.ThisCountryManager = dt.Rows(0)("ThisCountryManager").ToString
        Module1.ThisCityManager = dt.Rows(0)("ThisCityManager").ToString
        Module1.ThisBranchManager = dt.Rows(0)("ThisBranchManager").ToString

        Module1.MyChildCountry = dt.Rows(0)("MyChildCountry").ToString
        Module1.MyChildCityCountry = dt.Rows(0)("MyChildCityCountry").ToString
        Module1.MyChildCity = dt.Rows(0)("MyChildCity").ToString
        Module1.MyChildBranch = dt.Rows(0)("MyChildBranch").ToString
        Module1.SystemAdmin = dt.Rows(0)("SystemAdmin").ToString
        Module1.HeadOfDepartment = dt.Rows(0)("HeadOfDepartment").ToString
        Module1.Supervisor = dt.Rows(0)("Supervisor").ToString




        If MyProjectType = ProjectType.PlacemeteTest Then
            'Dim Frm As New PlacementExam
            'Frm.InvoiceNo = 1
            Dim Frm As New StudentLogin
            Frm.Text = Module1.MyProject.ToString & "          " & bm.ExecuteScalar("select dbo.GetBranchName('" & Module1.Branch & "')") & "          Username: " & Module1.EnName
            ShowForm(Frm, Nothing)
        ElseIf MyProjectType = ProjectType.PCs Then
            Dim frm As New BasicForm
            frm.TableName = "PCs"
            frm.Text = "PCs"
            frm.txtName.MaxLength = 1000
            ShowForm(frm, sender)
        ElseIf Flag = 1 Then
            Dim Frm As New MAIN
            Frm.Text = Module1.MyProject.ToString & "          " & bm.ExecuteScalar("select dbo.GetBranchName('" & Module1.Branch & "')") & "          Username: " & Module1.EnName
            Frm.Show()
        End If

        LogedIn = True
        'Close()
        Hide()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Users.KeyDown, Password.KeyDown, Branch.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub


    Public Function ShowForm(ByVal frm As Form, ByVal sender As System.Object) As Form
        frm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            'frm.BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            frm.BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If

        Try
            Dim tt As ToolStripMenuItem = sender
            frm.Text = tt.Text
        Catch ex As Exception
        End Try
        bm.HandleColor(frm)
        bm.HandleKeyDown(frm)
        'frm.MdiParent = Me
        frm.ControlBox = False
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        frm.BackColor = Module1.MyBackColor
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
        Return frm
    End Function

    Private Sub Password_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.Enter
        AcceptButton = btnSave
    End Sub

    Private Sub Password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.Leave
        AcceptButton = Nothing
    End Sub

End Class

