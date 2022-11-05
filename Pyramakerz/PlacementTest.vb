Imports System.IO
Imports System.Data.SqlClient

Public Class PlacementTest
    Public TableName As String = "PlacementTest"
    Public SubId As String = "Id"
    Public SubName As String = "Name"

    Dim Length As Integer = 0

    Dim dt As New DataTable
    Dim bm As New BasicMethods



    Public MainTableName As String = "PlacementLevels"
    Public MainSubId As String = "Id"
    Public MainSubName As String = "Name"

    Public MainId As String = "PlacementLevel"

    Public Flag As Integer = 0
    Private Sub SingleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bm.FillCombo(MainTableName, CboMain, "")
        txtID.MaxLength = Length
        Dim v() As String = {MainId, SubId, SubName, "Type", "Header", "Question", "Answer1", "Answer2", "Answer3", "Answer4", "Answer5", "Answer6", "Answer7", "Answer8", "Answer9", "Answer10", "TrueResult", "FileName"}
        bm.Fields = v
        Dim c() As Control = {CboMain, txtID, txtName, Type, Header, Question, Answer1, Answer2, Answer3, Answer4, Answer5, Answer6, Answer7, Answer8, Answer9, Answer10, TrueResult, FileName}
        bm.control = c

        Dim k() As String = {MainId, SubId}
        bm.KeyFields = k

        bm.Table_Name = TableName
        btnNew_Click(sender, e)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        bm.FirstLast(New String() {MainId, SubId}, "Max", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {CboMain.SelectedValue.ToString, txtID.Text}, "Next", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If CboMain.SelectedValue.ToString = 0 Then
            Return
        End If
        If TrueResult.SelectedIndex = 0 Then
            bm.ShowMSG("Please, Select The TrueResult ...")
            TrueResult.Focus()
            Return
        End If
        If Controls.Find("Answer" & TrueResult.SelectedIndex.ToString, True)(0).Text.Trim = "" Then
            bm.ShowMSG("TrueResult is empty ...!")
            Controls.Find("Answer" & TrueResult.SelectedIndex.ToString, True)(0).Focus()
            Return
        End If
        bm.DefineValues()
        If Not bm.Save(New String() {MainId, SubId}, New String() {CboMain.SelectedValue.ToString, txtID.Text.Trim}) Then Return
        If Not AllowPrint Then
            btnNew_Click(sender, e)
        End If
        AllowClose = True
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        bm.FirstLast(New String() {MainId, SubId}, "Min", dt)
        If dt.Rows.Count = 0 Then Return
        FillControls()
    End Sub

    Sub FillControls()
        bm.FillControls()
        Listen_Click()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        bm.ClearControls()
        ClearControls()
    End Sub

    Sub ClearControls()
        Try
            bm.ClearControls()
            txtID.Text = bm.ExecuteScalar("select max(" & SubId & ")+1 from " & TableName & " where " & MainId & "='" & CboMain.SelectedValue.ToString & "' and " & SubId & ">0")
            If txtID.Text = "" Then txtID.Text = "1"
            txtID.Text = txtID.Text.Trim.PadLeft(Length, "0")
            txtName.Focus()
            Type.SelectedIndex = 0
            TrueResult.SelectedIndex = 0
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If bm.ShowDeleteMSG("Are you sure you want to delete?") Then
            bm.ExcuteNonQuery("delete from " & TableName & " where " & SubId & "='" & txtID.Text.Trim & "' and " & MainId & " ='" & CboMain.SelectedValue.ToString & "'")
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnPrevios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevios.Click
        bm.NextPrevious(New String() {MainId, SubId}, New String() {CboMain.SelectedValue.ToString, txtID.Text}, "Back", dt)
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
        bm.RetrieveAll(New String() {MainId, SubId}, New String() {CboMain.SelectedValue.ToString, txtID.Text.Trim}, dt)
        If dt.Rows.Count = 0 Then
            ClearControls()
            lv = False
            Return
        End If
        FillControls()
        lv = False
        'txtName.Text = dt(0)("Name")
    End Sub

    Private Sub btnNew_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown, Type.KeyDown, Header.KeyDown, Question.KeyDown, Answer1.KeyDown, Answer2.KeyDown, Answer3.KeyDown, Answer4.KeyDown, Answer5.KeyDown, Answer6.KeyDown, Answer7.KeyDown, Answer8.KeyDown, Answer9.KeyDown, Answer10.KeyDown, TrueResult.KeyDown, FilePath.KeyDown, FileName.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
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
        ClearControls()
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

    Private Sub Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Type.SelectedIndexChanged
        If Type.SelectedIndex = 0 Then
            Question.Visible = True
            lblQuestion.Visible = True
        Else
            Question.Visible = False
            lblQuestion.Visible = False
            Question.Clear()
        End If
    End Sub

    Private Sub ChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseFile.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Audio Files(*.wav,*.mp3,*.cda,*.wmv,*.mpeg,*.flv,*.wma)|*.wav;*.mp3;*.cda;*.wmv;*.mpeg;*.flv;*.wma"
        If ofd.ShowDialog = DialogResult.OK Then
            FilePath.Text = ofd.FileName
        End If
    End Sub

    Dim AllowPrint As Boolean = False
    Private Sub Upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Upload.Click
        If txtID.Text.Trim = "" Or CboMain.SelectedValue.ToString = 0 Then
            Return
        End If
        If FilePath.Text = "" Then Return
        Upload.Enabled = False
        FileName.Text = FilePath.Text.Split("\")(FilePath.Text.Split("\").Length - 1)
        AllowPrint = True
        btnSave_Click(Nothing, Nothing)
        AllowPrint = False
        bm.SaveFile("PlacementTest", "PlacementLevel", CboMain.SelectedValue.ToString, "Id", txtID.Text, "Audio", FilePath.Text)
        FilePath.Clear()
        Upload.Enabled = True
        txtID_Leave(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtID.Text.Trim = "" Or FileName.Text.Trim = "" Or CboMain.SelectedValue.ToString = 0 Then
            Return
        End If
        If Not bm.ShowDeleteMSG("Are You SURE to Delete """ & FileName.Text & """?") Then Return
        bm.ExcuteNonQuery("Update PlacementTest set FileName='',Audio=null where PlacementLevel=" & CboMain.SelectedValue.ToString & " and Id=" & txtID.Text)
        txtID_Leave(Nothing, Nothing)
    End Sub

    Private Sub Listen_Click()
        Try
            Dim c As New SqlConnection(cmd.Connection.ConnectionString)
            AxWindowsMediaPlayer1.URL = ""
            If FileName.Text <> "" Then
                Try
                    Dim myCommand As SqlClient.SqlCommand = c.CreateCommand()
                    myCommand.CommandText = "select Audio from PlacementTest where PlacementLevel=" & CboMain.SelectedValue.ToString & " and Id=" & txtID.Text
                    bm.OpenConnection(c)
                    Dim imagedata() As Byte = CType(myCommand.ExecuteScalar(), Byte())
                    bm.CloseConnection(c)
                    File.WriteAllBytes(Application.StartupPath & "\Temp\" & FileName.Text, imagedata)
                    AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Temp\" & FileName.Text
                Catch ex As Exception
                    bm.CloseConnection(c)
                End Try
            End If
        Catch
        End Try
    End Sub
End Class