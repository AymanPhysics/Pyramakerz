Imports System.Net.NetworkInformation
Imports System.Net
Imports System.Management
Imports System.Data
Imports System.IO
Imports System.Threading
Imports System.Threading.Thread

Public Class MAIN
    Public NLevel As Boolean = False


    Private Sub الخروجمنالنظامToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem24.Click
        Close()
    End Sub


    Public Nlvl As Boolean = False
    Dim bol As Boolean = False
    Private Sub MAIN_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Nlvl Or bol Then Return

        If Copy = True Then
            bol = True
            Application.Exit()
            Exit Sub
        End If


        If Module1.MyProject = Project.Pyramakerz AndAlso Not Module1.HasLeft AndAlso bm.ShowDeleteMSG("Are you going to leave Pyramakerz?") Then
            e.Cancel = True
            Me.BringToFront()
            menuitem88_Click(menuitem88, Nothing)
            Return
        End If


        If bm.ShowDeleteMSG("Are you sure you want to exit?") Then
            bol = True
            Module1.FourceExit = True
            Application.Exit()
        Else
            e.Cancel = True
            Me.BringToFront()
        End If
    End Sub
    Dim Copy As Boolean = False
    Dim bm As New BasicMethods
    Private Sub MAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' AxWindowsMediaPlayer1.newMedia("mms://38.96.148.74/rd3")
        'AxWindowsMediaPlayer1.openPlayer("rtmp://liveRadio.onlinehorizons.net/Qurankareem")



        'Dim dt As DataTable = bm.ExcuteAdapter("select ID,ArName from Students")
        'Dim dtName As DataTable = bm.ExcuteAdapter("select Arabic_Name,English_Name from Names")

        'For i As Integer = 0 To dt.Rows.Count - 1
        '    bm.ExcuteNonQuery("update students set EnName='" & bm.EnName(dt.Rows(i)(1).ToString, dtName) & "' where Id=" & dt.Rows(i)(0).ToString)
        'Next



        Try

            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", "sShortDate", "dd/MM/yyyy")
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\International", "sLongDate", "dd/MM/yyyy")

        Catch ex As Exception
        End Try

        If Module1.MyProject = Project.EFG Then
            ToolStripContainer4.Visible = False
            ToolStripContainer1.Visible = False

            menuitem56.Tag = "0"
            menuitem151.Tag = "0"
            menuitem152.Tag = "0"
            menuitem60.Tag = "0"
            menuitem3.Tag = "0"
            menuitem156.Tag = "0"
            menuitem140.Tag = "0"
            menuitem150.Tag = "0"
            menuitem86.Tag = "0"
            menuitem90.Tag = "0"
            menuitem91.Tag = "0"
            menuitem181.Tag = "0"
            menuitem149.Tag = "0"
            menuitem153.Tag = "0"
            menuitem154.Tag = "0"
            menuitem155.Tag = "0"
            menuitem53.Tag = "0"
            menuitem141.Tag = "0"
            menuitem143.Tag = "0"
            menuitem144.Tag = "0"
            menuitem171.Tag = "0"
            menuitem172.Tag = "0"
            menuitem93.Tag = "0"
            menuitem55.Tag = "0"
            menuitem70.Tag = "0"
            menuitem65.Tag = "0"
            menuitem138.Tag = "0"
            menuitem147.Tag = "0"
            menuitem21.Tag = "0"
            menuitem95.Tag = "0"
            menuitem72.Tag = "0"
            menuitem190.Tag = "0"
            menuitem191.Tag = "0"
            menuitem192.Tag = "0"
            menuitem157.Tag = "0"
            menuitem169.Tag = "0"
            menuitem182.Tag = "0"
            menuitem183.Tag = "0"
            menuitem184.Tag = "0"
            menuitem194.Tag = "0"
            menuitem111.Tag = "0"
            menuitem112.Tag = "0"
            menuitem113.Tag = "0"
            menuitem114.Tag = "0"
            menuitem115.Tag = "0"
            menuitem116.Tag = "0"
            menuitem127.Tag = "0"
            menuitem128.Tag = "0"
            menuitem185.Tag = "0"
            menuitem193.Tag = "0"
            menuitem101.Tag = "0"
            menuitem142.Tag = "0"
            menuitem158.Tag = "0"
            menuitem165.Tag = "0"
            menuitem166.Tag = "0"
            menuitem173.Tag = "0"
            menuitem176.Tag = "0"
            menuitem180.Tag = "0"
            menuitem136.Tag = "0"
            menuitem160.Tag = "0"
            menuitem137.Tag = "0"
            menuitem148.Tag = "0"
            menuitem145.Tag = "0"
        End If

        For i As Integer = 0 To MenuStrip1.Items.Count - 1
            MenuStrip1.Items(i).Visible = False
        Next
        If Not NLevel Then
            LoadMenuitem()
            If Module1.UserName = Module1.SystemAdmin Then
                Dim dt As DataTable = bm.ExcuteAdapter("GetDuplicationInRealForAdministrator")
                If dt.Rows.Count > 0 Then
                    Dim frm As New DuplicationInReal
                    frm.DataGridView1.DataSource = dt
                    frm.DataGridView1.Columns(0).HeaderText = ""
                    ShowForm(frm, sender)
                End If
            End If
        End If

        MsgTimer_Tick(Nothing, Nothing)
        ChatTimer_Tick(Nothing, Nothing)
        'BackupTimer_Tick(Nothing, Nothing)
        If Module1.MyProject = Project.Pyramakerz Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
            BackgroundImageLayout = ImageLayout.Stretch
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If

        GetGroupsMsg()
    End Sub

    Sub LoadMenuitem()
        Dim dt As DataTable = bm.ExcuteAdapter("Select * From NLevels Where Id='" & Module1.LevelId & "'")
        If dt.Rows.Count = 0 Then
            Application.Exit()
            Exit Sub
        End If

        For i As Integer = 0 To MenuStrip1.Items.Count - 1
            Try
                Dim item As ToolStripMenuItem
                item = MenuStrip1.Items(i)
                item.Visible = False
                If Not item.Tag Is Nothing And Not item.Tag = "" Then Continue For
                item.Visible = dt.Rows(0)(item.Name)
                LoadSub(item, dt)
            Catch
            End Try
            Try
                Dim item As ToolStripSeparator
                item = MenuStrip1.Items(i)
                item.Visible = False
                If Not item.Tag Is Nothing And Not item.Tag = "" Then Continue For
                item.Visible = dt.Rows(0)(item.Name)
            Catch
            End Try
        Next

    End Sub

    Sub LoadSub(ByVal item2 As ToolStripMenuItem, ByVal dt As DataTable)
        For i As Integer = 0 To item2.DropDownItems.Count - 1
            Try
                Dim item As ToolStripMenuItem
                item = item2.DropDownItems(i)
                item.Visible = False
                If Not item.Tag Is Nothing And Not item.Tag = "" Then Continue For
                item.Visible = dt.Rows(0)(item.Name)
                LoadSub(item, dt)
            Catch
            End Try
            Try
                Dim item As ToolStripSeparator
                item = item2.DropDownItems(i)
                item.Visible = False
                If Not item.Tag Is Nothing And Not item.Tag = "" Then Continue For
                item.Visible = dt.Rows(0)(item.Name)
            Catch
            End Try
        Next
    End Sub

    Private Sub menuitem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem2.Click
        Dim frm As New SingleForm
        frm.TableName = "Countries"
        frm.SubId = "Id"
        frm.SubName = "Name"
        frm.SubName2 = "CountryManager"
        frm.lblSub.Text = "Manager"

        frm.CboTableName = "Employees"
        frm.CboSubId = "Id"
        frm.CboSubName = "EnName"
        frm.CboWhere = "where Manager=1"

        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem3.Click
        Dim frm As New BasicForm
        frm.TableName = "PDFTypes"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem5.Click
        Dim frm As New SingleForm2
        frm.MainTableName = "Departments"
        frm.MainSubId = "Id"
        frm.MainSubName = "Name"
        frm.lblMain.Text = "Department"

        frm.TableName = "Categories"
        frm.MainId = "DepartmentId"
        frm.SubId = "Id"
        frm.SubName = "Name"
        frm.SubName2 = "Type"

        frm.lblSub.Text = "Type"
        frm.CboSub.Items.Add("Cash")
        frm.CboSub.Items.Add("Instalment")

        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem6.Click
        Dim frm As New BasicForm
        frm.TableName = "HowDidYouKnowUs"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem7.Click
        Dim frm As New BasicForm
        frm.TableName = "Jobs"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem8.Click
        Dim frm As New BasicForm
        frm.TableName = "Religions"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem9.Click
        Dim frm As New BasicForm
        frm.TableName = "SchoolTypes"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem10.Click
        Dim frm As New BasicForm2
        frm.MainTableName = "Countries"
        frm.MainSubId = "Id"
        frm.MainSubName = "Name"
        frm.lblMain.Text = "Country"

        frm.TableName = "Universities"
        frm.MainId = "CountryId"
        frm.SubId = "Id"
        frm.SubName = "Name"

        ShowForm(frm, sender)
    End Sub
    Public Function ShowForm(ByVal frm As Form, ByVal sender As System.Object) As Form
        Return bm.ShowForm(frm, sender, Me)
    End Function
    Private Sub menuitem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem12.Click
        Dim frm As New Branches
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem13.Click
        Dim frm As New SingleForm
        frm.TableName = "Ranks"
        frm.SubId = "Id"
        frm.SubName = "Name"
        frm.SubName2 = "Type"
        frm.lblSub.Text = "Type"

        frm.CboSub.Items.Add("Faculty")
        frm.CboSub.Items.Add("School")
        frm.CboSub.Items.Add("Graduated")

        ShowForm(frm, sender)

    End Sub

    Private Sub menuitem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem14.Click
        Dim frm As New Cities
        frm.MainTableName = "Countries"
        frm.MainSubId = "Id"
        frm.MainSubName = "Name"
        frm.lblMain.Text = "Country"

        frm.TableName = "Cities"
        frm.MainId = "CountryId"
        frm.SubId = "Id"
        frm.SubName = "Name"

        frm.CboTableName = "Employees"
        frm.CboSubId = "Id"
        frm.CboSubName = "EnName"
        frm.CboWhere = "where Manager=1"

        frm.SubName2 = "FundInitialBal"
        frm.lblSub.Text = "Fund Init. Bal."

        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem16.Click

        Dim frm As New BasicForm3

        frm.MainTableName = "Countries"
        frm.MainSubId = "Id"
        frm.MainSubName = "Name"
        frm.lblMain.Text = "Country"

        frm.Main2TableName = "Universities"
        frm.Main2MainId = "CountryId"
        frm.Main2SubId = "Id"
        frm.Main2SubName = "Name"
        frm.lblMain2.Text = "University"

        frm.TableName = "Faculties"
        frm.MainId = "CountryId"
        frm.MainId2 = "UniversityId"
        frm.SubId = "Id"
        frm.SubName = "Name"

        ShowForm(frm, sender)

    End Sub

    Private Sub menuitem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem17.Click

        Dim frm As New SingleForm3

        frm.MainTableName = "Countries"
        frm.MainSubId = "Id"
        frm.MainSubName = "Name"
        frm.lblMain.Text = "Country"

        frm.Main2TableName = "Cities"
        frm.Main2MainId = "CountryId"
        frm.Main2SubId = "Id"
        frm.Main2SubName = "Name"
        frm.lblMain2.Text = "City"

        frm.TableName = "Schools"
        frm.MainId = "CountryId"
        frm.MainId2 = "CityId"
        frm.SubId = "Id"
        frm.SubName = "Name"
        frm.SubName2 = "SchoolTypeId"
        frm.lblSub.Text = "Type"

        frm.CboTableName = "SchoolTypes"
        frm.CboSubId = "Id"
        frm.CboSubName = "Name"

        ShowForm(frm, sender)


    End Sub

    Private Sub menuitem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem18.Click
        Dim frm As New NLevels
        ShowForm(frm, sender)
        frm.MdiParent = Nothing
    End Sub

    Private Sub menuitem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem20.Click
        Dim frm As New Employees
        ShowForm(frm, sender)
        frm.MdiParent = Nothing
    End Sub

    Private Sub menuitem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem22.Click
        Dim frm As New BasicForm3

        frm.MainTableName = "Countries"
        frm.MainSubId = "Id"
        frm.MainSubName = "Name"
        frm.lblMain.Text = "Country"

        frm.Main2TableName = "Cities"
        frm.Main2MainId = "CountryId"
        frm.Main2SubId = "Id"
        frm.Main2SubName = "Name"
        frm.lblMain2.Text = "City"

        frm.TableName = "Areas"
        frm.MainId = "CountryId"
        frm.MainId2 = "CityId"
        frm.SubId = "Id"
        frm.SubName = "Name"

        ShowForm(frm, sender)

    End Sub

    Private Sub menuitem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem27.Click
        Dim frm As New Students
        ShowForm(frm, sender)
        frm.MdiParent = Nothing
    End Sub

    Private Sub menuitem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem77.Click
        Dim frm As New ChangePassword
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem79.Click
        'Dim frm As New BasicForm
        Dim frm As New SingleForm
        frm.TableName = "Departments"
        frm.SubName2 = "NeedComputerLab"
        frm.lblSub.Text = "Computer Lab"

        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem80.Click
        Dim frm As New Items
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem82.Click
        Dim frm As New DurationTypes
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem83.Click
        Dim frm As New MemberShips
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem29.Click
        Dim frm As New Income
        ShowForm(frm, sender)
        frm.Text = "Detail"
    End Sub

    Private Sub menuitem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem31.Click
        Dim frm As New SubIncome
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem32.Click
        Dim frm As New Installments
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem33.Click

        Dim frm As New BasicForm3
        frm.TestSecurity = True
        frm.MainTableName = "Departments"
        frm.MainSubId = "Id"
        frm.MainSubName = "Name"
        frm.lblMain.Text = "Department"

        frm.Main2TableName = "Categories"
        frm.Main2MainId = "DepartmentId"
        frm.Main2SubId = "Id"
        frm.Main2SubName = "Name"
        frm.lblMain2.Text = "Category"

        frm.TableName = "CoursesLevels"
        frm.MainId = "DepartmentId"
        frm.MainId2 = "CategoryId"
        frm.SubId = "Id"
        frm.SubName = "Name"

        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem38.Click

    End Sub

    Private Sub menuitem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem34.Click
        Dim frm As New StudentsMemberships
        ShowForm(frm, sender)
    End Sub

    Public Sub menuitem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem49.Click
        Dim frm As New Groups
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem36.Click
        Dim frm As New TransferStudents
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem39.Click
        Dim frm As New Table
        frm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            'frm.BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            frm.BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If
        Dim tt As ToolStripMenuItem = sender
        frm.Flag = "1"
        frm.Text = tt.Text
        frm.MainFrm = Me
        frm.Show()
    End Sub

    Private Sub menuitem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem40.Click
        Dim frm As New SingleForm22
        frm.MainTableName = "Branches"
        frm.MainSubId = "Id"
        frm.MainSubName = "Name"
        frm.lblMain.Text = "Branch"

        frm.TableName = "Classes"
        frm.MainId = "BranchId"
        frm.SubId = "Id"
        frm.SubName = "Name"

        frm.SubName2 = "Capacity"
        frm.lblSub.Text = "Capacity"
        frm.ComputerLab.Visible = True

        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem61.Click
        Dim frm As New Login
        frm.Flag = 2
        frm.ShowDialog()
        MAIN_Load(Nothing, Nothing)
        Text = Module1.MyProject.ToString & "          " & bm.ExecuteScalar("select dbo.GetBranchName('" & Module1.Branch & "')") & "          Username: " & Module1.EnName
    End Sub

    Private Sub menuitem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem51.Click
        Dim frm As New BasicForm
        frm.TableName = "OutcomeReasons"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem52.Click
        Dim frm As New Outcome
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem62.Click
        Dim frm As New PutInBank
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem50.Click
        Dim frm As New SetupCost
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem57.Click
        Dim frm As New Evaluation
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem42.Click
        Dim frm As New StudentsLevels
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem43.Click
        Dim frm As New TransferStudents
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem45.Click
        Dim frm As New Placement
        frm.Flag = 0
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem63.Click
        Dim frm As New BasicForm
        frm.TableName = "RefundReasons"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem55.Click
        Dim frm As New Table
        Dim tt As ToolStripMenuItem = sender
        frm.Flag = "2"
        frm.Text = tt.Text
        frm.MainFrm = Me
        frm.Show()
    End Sub

    Private Sub menuitem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem56.Click
        Dim frm As New Statics
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem58.Click
        Dim frm As New Outcome
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem54.Click
        Dim frm As New Placement
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Public Sub menuitem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem67.Click
        Dim frm As New ReLecture
        ShowForm(frm, sender)
    End Sub


    Private Sub menuitem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem60.Click
        Dim frm As New BasicForm
        frm.TableName = "PromotionMethods"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem70.Click
        Dim frm As New Promotions
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem65.Click
        Dim frm As New CallSaving
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem46.Click
        Dim frm As New Bundle
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem66.Click
        Dim frm As New StudentsBundleItems
        ShowForm(frm, sender)
    End Sub

    Private Sub LstReLecture_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstReLecture.MouseDoubleClick
        Try
            Dim s As String = LstReLecture.SelectedValue.ToString
            Dim frm As New Income
            ShowForm(frm, sender)
            frm.Text = "Detail"
            frm.InvoiceNo.Text = s
            frm.txtID_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub menuitem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem69.Click
        Dim frm As New InventoryInitialBalance
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem71.Click
        Dim frm As New Inventory
        ShowForm(frm, sender)
    End Sub

    Private Sub BackupTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupTimer.Tick
        Return
        Dim Bath As String = bm.ExecuteScalar("Pyramakerz_Backup", New String() {"Bath"}, New String() {Application.StartupPath & "\Backup"})
        bm.SendEMail(Bath)
    End Sub

    Private Sub menuitem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem84.Click
        Dim frm As New DirectBonusCut
        frm.TableName = "DirectBonus"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem85.Click
        Dim frm As New DirectBonusCut
        frm.TableName = "DirectCut"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem86.Click
        Dim frm As New Appreasal
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem87.Click
        Dim frm As New Attendance
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem88.Click
        Dim frm As New Attendance
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem89.Click
        Dim frm As New OfficialHolidays
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem90.Click
        Dim frm As New YearTarget
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem91.Click
        Dim frm As New Share
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem64.Click
        Dim frm As New Execuse
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem73.Click
        Dim frm As New MonthYear
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem104.Click
        Dim frm As New MonthYear
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem92.Click
        Dim frm As New SearchWaiting
        ShowForm(frm, sender)
        frm.MdiParent = Nothing
    End Sub

    Private Sub menuitem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem93.Click
        Dim frm As New Groups
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub InstallmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem105.Click
        Dim frm As New RPT1
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub AllInstallmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem106.Click
        Dim frm As New RPT2
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem94.Click
        Dim frm As New RPT3
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Sub ShowChat(ByVal frm As Chat, ByVal MyRow As DataRow)
        If frm.Tbl.Rows.Count = 0 Then
            frm.ToUser = New String() {MyRow("FromUser")}
            frm.Chat_Load(Nothing, Nothing)
            frm.ToUserName = bm.ExecuteScalar("select EnName from Employees where Id='" & MyRow("FromUser") & "'")
        Else
            frm.Chat_Load(Nothing, Nothing)
        End If

        Dim s As String = frm.ToUserName & " (" & MyRow("DayDate") & ") : "
        frm.RichTextBox1.AppendText(vbCrLf & s & vbCrLf & MyRow("Details") & vbCrLf)
        frm.RichTextBox1.Select(frm.RichTextBox1.Text.Length - s.Length - MyRow("Details").Length - 2, s.Length)
        frm.RichTextBox1.SelectionColor = Color.Blue
        frm.RichTextBox1.SelectedText = ""

        frm.RichTextBox1.SelectionStart = frm.RichTextBox1.Text.Length - MyRow("Details").Trim().Length - 1
        frm.RichTextBox1.SelectionLength = MyRow("Details").Trim().Length
        frm.RichTextBox1.SelectionFont = New Font(frm.RichTextBox1.Font.FontFamily, frm.RichTextBox1.Font.Size, FontStyle.Italic)
        frm.RichTextBox1.SelectionColor = Color.Blue
        frm.RichTextBox1.SelectedText = ""

        frm.RichTextBox1.ScrollToCaret()
        frm.Show()
        Activate()
        If WindowState = FormWindowState.Minimized Then WindowState = FormWindowState.Normal
        frm.Activate()
        If frm.WindowState = FormWindowState.Minimized Then frm.WindowState = FormWindowState.Normal

        bm.ExcuteNonQuery("update Messages set Done=1 where Line=" & MyRow("Line"))
    End Sub

    Private Sub menuitem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem95.Click
        Dim frm As New PreChat2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem107.Click
        Dim frm As New RPT1
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem108.Click
        Dim frm As New RPT1
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem109.Click
        Dim frm As New RPT2
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem110.Click
        Dim frm As New MonthYear
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem111.Click
        Dim frm As New RPT2
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem112.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "AllGender.rpt"
        rpt.ShowDialog()
    End Sub

    Private Sub menuitem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem114.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "AllReligon.rpt"
        rpt.ShowDialog()
    End Sub

    Private Sub meenuitem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem113.Click
        Dim frm As New RPT2
        frm.Flag = 4
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem116.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "AllRank.rpt"
        rpt.ShowDialog()
    End Sub

    Private Sub menuitem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem115.Click
        Dim frm As New RPT2
        frm.Flag = 5
        ShowForm(frm, sender)
    End Sub

    Private Sub InstractorEvaluationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem119.Click
        Dim frm As New RPT6
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub InstractorEvaluationByCourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem118.Click
        Dim frm As New RPT4
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub InstractorPeriodEvaluationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem120.Click
        Dim frm As New RPT5
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub BestInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem117.Click
        Dim frm As New RPT25
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem121.Click
        Dim frm As New RPT8
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub ManagementEvaluationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem122.Click
        Dim frm As New RPT1
        frm.Flag = 4
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem123.Click
        Dim frm As New RPT1
        frm.Flag = 5
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem124.Click
        Dim frm As New RPT9
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem127_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem127.Click
        Dim frm As New RPT1
        frm.Flag = 6
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem128.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "StudentsFaculties.rpt"
        rpt.ShowDialog()
    End Sub

    Private Sub menuitem129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem129.Click
        Dim frm As New RPT10
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem130.Click
        Dim frm As New RPT11
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem131.Click
        Dim frm As New RPT12
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem134.Click
        Dim frm As New BasicForm
        frm.TableName = "Companies"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem135.Click
        Dim frm As New RPT19
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem136.Click
        Dim frm As New RPT13
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem137.Click
        Dim frm As New RPT14
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem138.Click
        Dim frm As New Reservations
        ShowForm(frm, sender)
    End Sub

    Private Sub LstReservations_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstReservations.MouseDoubleClick
        Try
            Dim s As String = LstReservations.SelectedValue.ToString
            Dim frm As New Reservations
            ShowForm(frm, sender)
            frm.InvoiceNo.Text = LstReservations.SelectedValue.ToString
            frm.txtID_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub menuitem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem139.Click
        Dim frm As New StudentsDegrees
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem140.Click
        Dim frm As New BasicForm
        frm.TableName = "MaintenanceTypes"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem141.Click
        Dim frm As New Maintenance
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem142.Click
        Dim frm As New RPT1
        frm.Flag = 8
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem144.Click
        Dim frm As New Fund
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem146.Click
        Dim frm As New RPT15
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem156.Click
        Dim frm As New BasicForm
        frm.TableName = "LateInstractorReasons"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem147.Click
        Dim frm As New LateInstractor
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem148.Click
        Dim frm As New RPT16
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem149.Click
        Dim frm As New Loans
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem150.Click
        Dim frm As New PhoneIndex
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem152.Click
        Dim frm As New BasicForm
        frm.TableName = "ApplicantStatus"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem153.Click
        Dim frm As New Applicant
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem154.Click
        Dim frm As New Tasks
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem155.Click
        Dim frm As New FinishingTasks
        ShowForm(frm, sender)
    End Sub

    Private Sub LstTasks_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstTasks.MouseDoubleClick
        Try
            Dim s As String = LstTasks.SelectedValue.ToString
            Dim frm As New FinishingTasks
            ShowForm(frm, sender)
            frm.InvoiceNo.Text = LstTasks.SelectedValue.ToString
            frm.txtID_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub menuitem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem157.Click
        Dim frm As New RPT15
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem158.Click
        Dim frm As New RPT14
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem159.Click
        Dim frm As New RPT1
        frm.Flag = 9
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem160.Click
        Dim frm As New RPT13
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem161_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem161.Click
        Dim frm As New RPT16
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem162_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem162.Click
        Dim frm As New RPT16
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem163.Click
        Dim frm As New RPT17
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem164.Click
        Dim frm As New RPT18
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem165.Click
        Dim frm As New RPT19
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem166.Click
        Dim frm As New RPT19
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem167.Click
        Dim frm As New RPT17
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem74.Click

    End Sub

    Private Sub menuitem168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem168.Click
        Dim frm As New EditAttendance
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem169.Click
        Dim frm As New RPT1
        frm.Flag = 10
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem170_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem170.Click
        Dim frm As New RPT25
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem172_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem172.Click
        Dim frm As New GiveUpContract
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem173.Click
        Dim frm As New RPT21
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem174_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem174.Click
        Dim frm As New RPT1
        frm.Flag = 11
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem175.Click
        Dim frm As New RPT1
        frm.Flag = 12
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem176_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem176.Click
        Dim frm As New RPT1
        frm.Flag = 13
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem178_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem178.Click
        Dim frm As New RPT20
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem179.Click
        Dim frm As New RPT20
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem180.Click
        Dim frm As New RPT1
        frm.Flag = 14
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem181.Click
        Dim frm As New MonthYear
        frm.Flag = 4
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem182_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem182.Click
        Dim frm As New MonthYear
        frm.Flag = 5
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem183.Click
        Dim frm As New RPT1
        frm.Flag = 15
        ShowForm(frm, sender)
    End Sub


    Private Sub btnCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculator.Click
        Shell("Calc")
    End Sub

    Private Sub btnArrival_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrival.Click
        menuitem87_Click(menuitem87, Nothing)
    End Sub

    Private Sub btnDeparts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeparts.Click
        menuitem88_Click(menuitem88, Nothing)
    End Sub

    Private Sub btnStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudents.Click
        menuitem27_Click(menuitem27, Nothing)
    End Sub

    Private Sub btnTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTable.Click
        menuitem39_Click(menuitem39, Nothing)
    End Sub

    Private Sub btnWillStartTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWillStartTable.Click
        menuitem55_Click(menuitem55, Nothing)
    End Sub

    Private Sub btnIncome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncome.Click
        menuitem29_Click(menuitem29, Nothing)
    End Sub

    Private Sub btnEvaluation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluation.Click
        menuitem57_Click(menuitem57, Nothing)
    End Sub

    Private Sub btnStudentsDegrees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentsDegrees.Click
        menuitem139_Click(menuitem139, Nothing)
    End Sub

    Private Sub btnSearchWaiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchWaiting.Click
        menuitem92_Click(menuitem92, Nothing)
    End Sub

    Private Sub menuitem184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem184.Click
        Dim frm As New RPT13
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem185.Click
        Dim rpt As New ReportViewer(Text)
        rpt.Rpt = "WeekDays.rpt"
        rpt.ShowDialog()
    End Sub

    Private Sub btnCallSavings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallSavings.Click
        menuitem65_Click(menuitem65, Nothing)
    End Sub

    Private Sub btnPhoneIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoneIndex.Click
        menuitem150_Click(menuitem150, Nothing)
    End Sub

    Private Sub btnTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTasks.Click
        menuitem154_Click(menuitem154, Nothing)
    End Sub

    Private Sub menuItem186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem186.Click
        Dim frm As New RPT1
        frm.Flag = 16
        ShowForm(frm, sender)
    End Sub

    Private Sub menuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem187.Click
        Dim frm As New RPT1
        frm.Flag = 17
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem188_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem188.Click
        Dim frm As New RPT1
        frm.Flag = 18
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem189_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem189.Click
        Dim frm As New RPT22
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem190.Click
        Dim frm As New UploadFiles
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem192.Click
        Dim frm As New UploadFiles
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem193_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem193.Click
        Dim frm As New RPT1
        frm.Flag = 19
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem194_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem194.Click
        Dim frm As New RPT1
        frm.Flag = 20
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem196.Click
        Dim frm As New PlacementTest
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem197_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem197.Click
        Dim frm As New PlacementLevels
        ShowForm(frm, sender)
    End Sub

    Private Sub menuItem198_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem198.Click
        Dim frm As New RPT5
        frm.Flag = 2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem199_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem199.Click
        Dim frm As New BasicForm
        frm.TableName = "PCs"
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem200.Click
        Dim frm As New RPT16
        frm.Flag = 4
        ShowForm(frm, sender)
    End Sub

    Private Sub ChatTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChatTimer.Tick
        If Module1.MyProject = Project.EFG Or bolChat Then Return
        Try
            bolChat = True
            BgChat.RunWorkerAsync()
        Catch ex As Exception
        End Try
    End Sub
    Dim DtChat As New DataTable
    Dim bolChat As Boolean = False
    Private Sub BgChat_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgChat.DoWork
        Dim XDt As DataTable = bm.ExcuteAdapter("GetMSG", New String() {"ToUser"}, New String() {Module1.UserName})
        DtChat = New DataTable : DtChat.Merge(XDt)
    End Sub

    Private Sub BgChat_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgChat.RunWorkerCompleted
        For i As Integer = 0 To DtChat.Rows.Count - 1
            Try
                Dim Done As Boolean = False
                For Each f As Form In MdiChildren
                    If f.Name <> "Chat" Then Continue For
                    Dim frm As Chat = f
                    If frm.Tbl.Rows.Count > 0 Then Continue For

                    If frm.ToUser(0) = DtChat.Rows(i)(0).ToString Or frm.Tbl.Rows.Count > 0 Then
                        ShowChat(frm, DtChat.Rows(i))
                        Done = True
                        GoTo A
                    End If
                Next
A:
                If Not Done Then
                    Dim frm As New Chat
                    frm.MdiParent = Me
                    ShowChat(frm, DtChat.Rows(i))
                End If
            Catch ex As Exception
            End Try
        Next
        bolChat = False
    End Sub


    Dim MybolMsg As Boolean = False
    Dim DtLstReLecture As New DataTable
    Dim DtLstInventory As New DataTable
    Dim DtLstBirthDay As New DataTable
    Dim DtLstStudentsBirthDay As New DataTable
    Dim DtLstReservations As New DataTable
    Dim DtLstTasks As New DataTable
    Dim DtLstNonEvaluateStudents As New DataTable
    Dim DtReviewAfter As New DataTable
    Dim DtGroupsMsg As New DataTable
    Private Sub MsgTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgTimer.Tick
        If Module1.MyProject = Project.EFG Or MybolMsg Then Return
        Try
            MybolMsg = True
            BgMsg.RunWorkerAsync()
        Catch ex As Exception
        End Try
        'bm.FillListBox("select InvoiceNo 'Id',InvoiceNo 'Name' from Income where Relecture='1' and InvoiceNo not in (select distinct MainInvNo from ReLecture where MainInvNo is not null)", LstReLecture)
        'bm.FillListBox("GetItemsBal", LstInventory)
        'bm.FillListBox("GetBirthdays", LstBirthDay)
        'bm.FillListBox("GetStudentsBirthdays", LstStudentsBirthDay)
        'bm.FillListBox("GetReservations", LstReservations)
        'bm.FillListBox("GetTasks '" & Module1.UserName & "'", LstTasks)
        'bm.FillListBox("GetNonEvaluateStudents '" & Module1.Branch & "'", LstNonEvaluateStudents)

    End Sub

    Dim CurrentHour As Integer = 0
    Private Sub BgMsg_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgMsg.DoWork
        DtLstReLecture = bm.ExcuteAdapter("select InvoiceNo 'Id',dbo.GetBranchShortName(BranchId)+' / '+CAST(RealInvoiceNo as varchar(100)) 'Name' from Income where Relecture='1' and InvoiceNo not in (select distinct MainInvNo from ReLecture where MainInvNo is not null)")
        DtLstInventory = bm.ExcuteAdapter("GetItemsBal")
        DtLstBirthDay = bm.ExcuteAdapter("GetBirthdays")
        DtLstStudentsBirthDay = bm.ExcuteAdapter("GetStudentsBirthdays")
        DtLstReservations = bm.ExcuteAdapter("GetReservations")
        DtLstTasks = bm.ExcuteAdapter("GetTasks '" & Module1.UserName & "'")
        DtLstNonEvaluateStudents = bm.ExcuteAdapter("GetNonEvaluateStudents '" & Module1.Branch & "'")
        DtReviewAfter = bm.ExcuteAdapter("GetReviewAfter")
        DtGroupsMsg = bm.ExcuteAdapter("GetGroupsMsg", {"BranchId"}, {Module1.Branch})

    End Sub

    Sub GetGroupsMsg()
        For i As Integer = 0 To DtGroupsMsg.Rows.Count - 1
            Dim f As New Popup
            f.Group.Text = DtGroupsMsg.Rows(i)("Id")
            f.Instractor.Text = DtGroupsMsg.Rows(i)("InstractorName")
            f.Course.Text = DtGroupsMsg.Rows(i)("CourseName")
            'f.Owner = Me
            f.Show()
            f.BringToFront()
        Next
    End Sub

    Private Sub BgMsg_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgMsg.RunWorkerCompleted

        Dim XDtLstReLecture As New DataTable : XDtLstReLecture.Merge(DtLstReLecture)
        Dim XDtLstInventory As New DataTable : XDtLstInventory.Merge(DtLstInventory)
        Dim XDtLstBirthDay As New DataTable : XDtLstBirthDay.Merge(DtLstBirthDay)
        Dim XDtLstStudentsBirthDay As New DataTable : XDtLstStudentsBirthDay.Merge(DtLstStudentsBirthDay)
        Dim XDtLstReservations As New DataTable : XDtLstReservations.Merge(DtLstReservations)
        Dim XDtLstTasks As New DataTable : XDtLstTasks.Merge(DtLstTasks)
        Dim XDtLstNonEvaluateStudents As New DataTable : XDtLstNonEvaluateStudents.Merge(DtLstNonEvaluateStudents)
        Dim XDtReviewAfter As New DataTable : XDtReviewAfter.Merge(DtReviewAfter)

        bm.FillListBox(XDtLstReLecture, LstReLecture)
        bm.FillListBox(XDtLstInventory, LstInventory)
        bm.FillListBox(XDtLstBirthDay, LstBirthDay)
        bm.FillListBox(XDtLstStudentsBirthDay, LstStudentsBirthDay)
        bm.FillListBox(XDtLstReservations, LstReservations)
        bm.FillListBox(XDtLstTasks, LstTasks)
        bm.FillListBox(XDtLstNonEvaluateStudents, LstNonEvaluateStudents)
        bm.FillListBox(XDtReviewAfter, LstReviewAfter)


        If CurrentHour + 3 < Now.Hour Then
            For i As Integer = 0 To DtGroupsMsg.Rows.Count - 1
                bm.ExcuteNonQuery("insert PopupHistory(BranchId,GroupId,UserName,Popup,Show,Ignore) select " & Module1.Branch & "," & DtGroupsMsg.Rows(i)("Id") & "," & Module1.UserName & ",1 Popup,0 Show,0 Ignore")
            Next
            CurrentHour = Now.Hour
            GetGroupsMsg()
        End If

        MybolMsg = False
    End Sub

    Private Sub menuitem201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem201.Click
        Dim frm As New TransferStudents
        frm.Flag = 5
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem202.Click
        Dim frm As New StSearch
        frm.Flag = 2
        ShowForm(frm, sender)
        frm.MdiParent = Nothing
    End Sub

    Private Sub menuitem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem203.Click
        Dim frm As New TransferStudents
        frm.Flag = 6
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem204.Click
        Dim frm As New RPT1
        frm.Flag = 21
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem205.Click
        Dim frm As New RPT16
        frm.Flag = 5
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem206_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem206.Click
        Dim frm As New RPT13
        frm.Flag = 4
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem207_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem207.Click
        Dim frm As New RPT1
        frm.Flag = 22
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem210.Click
        Dim frm As New RPT23
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem211.Click
        Dim frm As New RPT1
        frm.Flag = 23
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem212.Click
        Dim frm As New RPT24
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem213_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem213.Click
        Dim frm As New EditAttendancePerMonth
        ShowForm(frm, sender)
    End Sub

    Private Sub LstReviewAfter_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstReviewAfter.MouseDoubleClick
        Try
            Dim s As String = LstReviewAfter.SelectedValue.ToString
            Dim rpt As New ReportViewer(Text)
            rpt.paraname = New String() {"@Branch", "@Instractor", "@FromDate", "@ToDate", "@Closed", "@Flag"}
            rpt.paravalue = New String() {"0", s, bm.ToStrDate(Now), bm.ToStrDate(Now), "", "1"}
            rpt.Rpt = "Progress.rpt"
            rpt.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub menuitem214_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem214.Click
        Dim frm As New RPT1
        frm.Flag = 24
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem215_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem215.Click
        Dim frm As New TransferStudents
        frm.Flag = 7
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem216_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem216.Click
        Dim frm As New RPT1
        frm.Flag = 25
        ShowForm(frm, sender)
    End Sub

    Private Sub LstStudentsBirthDay_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstStudentsBirthDay.MouseDoubleClick
        Try
            Dim s As String = LstStudentsBirthDay.SelectedValue.ToString
            Dim frm As New Students
            ShowForm(frm, sender)
            frm.MdiParent = Nothing
            frm.txtID.Text = LstStudentsBirthDay.SelectedValue.ToString
            frm.txtID_Leave(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub menuitem217_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem217.Click
        Dim frm As New Progress
        frm.User = Module1.UserName
        ShowForm(frm, sender)
    End Sub

    Private Sub PartnerLoansToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem218.Click
        Dim frm As New PartnerLoans
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem290_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem290.Click
        Dim frm As New RPT20
        frm.Flag = 4
        ShowForm(frm, sender)
    End Sub

    Private Sub AreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem291.Click
        Dim frm As New RPT19
        frm.Flag = 4
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem220_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem220.Click
        Dim frm As New ShareMotion
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem221.Click
        Dim frm As New RPT19
        frm.Flag = 5
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuitem222.Click
        Dim frm As New RPT1
        frm.Flag = 26
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem292_Click(sender As Object, e As EventArgs) Handles menuitem292.Click
        Dim frm As New PrintCarnaih
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem223_Click(sender As Object, e As EventArgs) Handles menuitem223.Click
        Dim frm As New RPT26
        frm.Flag = 1
        ShowForm(frm, sender)
    End Sub

    Private Sub menuItem293_Click(sender As Object, e As EventArgs) Handles menuItem293.Click
        Dim frm As New RPT2
        frm.Flag = 6
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem224_Click(sender As Object, e As EventArgs) Handles menuitem224.Click
        'Dim frm As New TransferStudents
        'frm.Flag = 8
        'ShowForm(frm, sender)
        Dim frm As New RPT25
        frm.Flag = 3
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem225_Click(sender As Object, e As EventArgs) Handles menuitem225.Click
        Dim frm As New RPT1
        frm.Flag = 27
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem246_Click(sender As Object, e As EventArgs) Handles menuitem246.Click
        Dim frm As New RPT19
        frm.Flag = 6
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem247_Click(sender As Object, e As EventArgs) Handles menuitem247.Click
        Dim frm As New AdditionEligibility
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem248_Click(sender As Object, e As EventArgs) Handles menuitem248.Click
        Dim frm As New TransferStudents
        frm.Flag = 9
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem249_Click(sender As Object, e As EventArgs) Handles menuitem249.Click
        Dim frm As New Table
        frm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            'frm.BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            frm.BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If
        Dim tt As ToolStripMenuItem = sender
        frm.Flag = "3"
        frm.Text = tt.Text
        frm.MainFrm = Me
        frm.Show()
    End Sub

    Private Sub menuitem294_Click(sender As Object, e As EventArgs) Handles menuitem294.Click
        Dim frm As New RPT2
        frm.Flag = 7
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem229_Click(sender As Object, e As EventArgs) Handles menuitem229.Click
        Dim frm As New RPT1
        frm.Flag = 28
        ShowForm(frm, sender)
    End Sub


    Private Sub menuitem226_Click(sender As Object, e As EventArgs) Handles menuitem226.Click
        Dim frm As New Inventory2
        ShowForm(frm, sender)
    End Sub

    Private Sub menuitem295_Click(sender As Object, e As EventArgs) Handles menuitem295.Click
        Dim frm As New RPT1
        frm.Flag = 29
        ShowForm(frm, sender)
    End Sub
End Class