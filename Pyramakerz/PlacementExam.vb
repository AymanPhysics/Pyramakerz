Imports System.IO

Public Class PlacementExam
    Dim bm As New BasicMethods
    Public InvoiceNo As Integer
    Public StudentId As String = ""

    Dim MyMinits As Integer = 60
    Dim MySeconds As Integer = 0



    Dim Minits As Integer = 0
    Dim Seconds As Integer = 0

    Private Sub PlacementExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Minits = MyMinits
        Seconds = MySeconds

        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            'BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If

        bm.HandleColor(Me)
        BackColor = Module1.MyBackColor
        FlowLayoutPanel3.BackColor = Module1.MyLblBackColor

        FullScreen()
        StartExam()
        If Module1.MyProject = Project.Pyramakerz Then
            'btnPlay.Visible = False
            'btnStop.Visible = False
            AxWindowsMediaPlayer1.Visible = False
        ElseIf Module1.MyProject = Project.EFG Then
            AxWindowsMediaPlayer1.Visible = False
        End If
    End Sub
    Sub FullScreen()
        Top = 0
        Left = 0
        Size = New Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height)
        'ss.Screens_Load(1280, 720)
        'ss.Screens_Load(800, 600)
    End Sub

    Dim CurrentLevel As Integer = 0
    Dim CurrentButton As New Button
    Private Sub StartExam()
        CurrentLevel = bm.ExecuteScalar("select Id from PlacementLevels where StartLevel=1")
        LoadLevel(CurrentLevel)
    End Sub
    Dim DtQues As New DataTable
    Private Sub LoadLevel(ByVal Level As Integer)
        DtQues = bm.ExcuteAdapter("select *,0 'StudentResult',0 'PlayingCount' from PlacementTest where PlacementLevel=" & Level.ToString)
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.Controls.Add(Label1)
        For i As Integer = 0 To DtQues.Rows.Count - 1
            LoadButtons(i)
        Next
        lblHeader.Text = ""
        lblPassage.Text = ""
        lblQuestion.Text = ""
        Panel1.Visible = False
        lblPassage.Visible = False
        AxWindowsMediaPlayer1.URL = ""

        For i As Integer = 1 To 10
            CType((Controls.Find("LinkLabel" & i.ToString, True))(0), LinkLabel).Text = ""
            CType((Controls.Find("LinkLabel" & i.ToString, True))(0), LinkLabel).LinkVisited = False
            CType((Controls.Find("LinkLabel" & i.ToString, True))(0), LinkLabel).BorderStyle = BorderStyle.None
        Next

    End Sub

    Private Function LoadButtons(ByVal i As Integer) As Integer
        Dim tt As New TableBtn
        Dim btn As Button = tt.btn
        btn.Tag = i
        btn.Text = DtQues.Rows(i)("Id")
        btn.ForeColor = Color.Red
        FlowLayoutPanel1.Controls.Add(btn)
        AddHandler btn.Click, AddressOf btn_Click
    End Function

    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = sender
        CurrentButton = sender
        lblHeader.Text = DtQues.Rows(btn.Tag)("Header")
        lblPassage.Text = DtQues.Rows(btn.Tag)("Name")
        lblQuestion.Text = DtQues.Rows(btn.Tag)("Question")
        If lblPassage.Text.Trim = "" Then
            lblPassage.Visible = False
        Else
            lblPassage.Visible = True
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Panel1.Visible = False
        AxWindowsMediaPlayer1.URL = ""

        If DtQues.Rows(btn.Tag)("FileName").ToString <> "" Then
            Panel1.Visible = True
            Try
                Dim imagedata() As Byte = CType(DtQues.Rows(btn.Tag)("Audio"), Byte())
                File.WriteAllBytes(Application.StartupPath & "\Temp\" & DtQues.Rows(btn.Tag)("FileName"), imagedata)
                AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Temp\" & DtQues.Rows(btn.Tag)("FileName")
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
            Catch ex As Exception
            End Try
            TestPanel1()
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If DtQues.Rows(btn.Tag)("Type").ToString = 0 Then
            lblQuestion.Visible = True
            FlowLayoutPanel3.FlowDirection = FlowDirection.TopDown
        Else
            lblQuestion.Visible = False
            FlowLayoutPanel3.FlowDirection = FlowDirection.LeftToRight
        End If
        For i As Integer = 1 To 10
            CType((Controls.Find("LinkLabel" & i.ToString, True))(0), LinkLabel).Text = DtQues.Rows(btn.Tag)("Answer" & i.ToString)
            CType((Controls.Find("LinkLabel" & i.ToString, True))(0), LinkLabel).LinkVisited = False
            If DtQues.Rows(btn.Tag)("Answer" & i.ToString) = "" Then
                CType((Controls.Find("LinkLabel" & i.ToString, True))(0), LinkLabel).BorderStyle = BorderStyle.None
            Else
                CType((Controls.Find("LinkLabel" & i.ToString, True))(0), LinkLabel).BorderStyle = BorderStyle.Fixed3D
            End If
        Next
        Try
            CType((Controls.Find("LinkLabel" & DtQues.Rows(CurrentButton.Tag)("StudentResult"), True))(0), LinkLabel).LinkVisited = True
        Catch ex As Exception
        End Try
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked, LinkLabel2.LinkClicked, LinkLabel3.LinkClicked, LinkLabel4.LinkClicked, LinkLabel5.LinkClicked, LinkLabel6.LinkClicked, LinkLabel7.LinkClicked, LinkLabel8.LinkClicked, LinkLabel9.LinkClicked, LinkLabel10.LinkClicked
        CurrentButton.ForeColor = Color.Black
        DtQues.Rows(CurrentButton.Tag)("StudentResult") = CType(sender, LinkLabel).Name.Replace("LinkLabel", "")
        For i As Integer = 1 To 10
            If CType(sender, LinkLabel).Name = "LinkLabel" & i.ToString Then
                CType(sender, LinkLabel).LinkVisited = True
            Else
                CType((Controls.Find("LinkLabel" & i.ToString, True))(0), LinkLabel).LinkVisited = False
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not bm.ShowDeleteMSG("Are you SURE you have FINISHED ALL questions?") Then Return
        FinishExam()
    End Sub

    Private Function TestSuccess() As Boolean
        Dim x As Integer = 0
        For i As Integer = 0 To DtQues.Rows.Count - 1
            If DtQues.Rows(i)("StudentResult") = DtQues.Rows(i)("TrueResult") Then x += 1
        Next
        If x / DtQues.Rows.Count < 0.6 Then
            Return False
        Else
            Return True
        End If
    End Function

    Dim ForceClose As Boolean = False
    Private Sub PlacementExam_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If ForceClose Then Return
        If Not bm.ShowDeleteMSG("Are you sure you want to exit?") Then
            e.Cancel = True
            Me.BringToFront()
        End If
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then Return
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        DtQues.Rows(CurrentButton.Tag)("PlayingCount") += 1
        TestPanel1()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        TestPanel1()
    End Sub

    Sub TestPanel1()
        If DtQues.Rows(CurrentButton.Tag)("PlayingCount") < 2 Then
            btnPlay.Enabled = True
        Else
            btnPlay.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        
        Seconds -= 1
        If Minits > 0 And Seconds = -1 Then
            Minits -= 1
            Seconds += 60
        End If
        Label1.Text = Minits.ToString.PadLeft(2, "0") & " : " & Seconds.ToString.PadLeft(2, "0")
        If Minits = 0 And Seconds = 0 Then
            Timer1.Stop()
            Do While Not ForceClose
                FinishExam()
            Loop
        End If
    End Sub

    Private Sub FinishExam()
        Dim dt As DataTable = bm.ExcuteAdapter("select EndLevel,TrueLevel,FalseLevel from PlacementLevels where Id=" & CurrentLevel.ToString)
        Dim b As Boolean = TestSuccess()

        If dt.Rows(0)("EndLevel").ToString = 1 Or (b And dt.Rows(0)("TrueLevel") = 0) Or (Not b And dt.Rows(0)("FalseLevel") = 0) Then
            If Seconds > MySeconds Then
                MyMinits -= 1
                MySeconds += 60
            End If
            If b Then CurrentLevel += 1
            bm.ExcuteNonQuery("update Placement set StLevel=" & CurrentLevel & ",Minits=" & (MyMinits - Minits) & ",Seconds=" & (MySeconds - Seconds) & " where BranchId=" & Module1.Branch & " and InvoiceNo=" & InvoiceNo)
            bm.ExcuteNonQuery("if exists(select LevelId from StudentsLevels where StudentId=" & StudentId & " and DepartmentId=1 and CategoryId=1) update StudentsLevels set LevelId=" & CurrentLevel & " where StudentId=" & StudentId & " and DepartmentId=1 and CategoryId=1 else insert into StudentsLevels(StudentId,DepartmentId,CategoryId,LevelId) select " & StudentId & ",1,1," & CurrentLevel)
            bm.ShowMSG("Thank you for joining " & Module1.MyProject.ToString & vbCrLf & "Your Level is " & CurrentLevel.ToString)
            ForceClose = True
            Application.Exit()
        Else
            If b Then
                CurrentLevel = dt.Rows(0)("TrueLevel")
            Else
                CurrentLevel = dt.Rows(0)("FalseLevel")
            End If
            LoadLevel(CurrentLevel)
        End If
    End Sub

End Class
