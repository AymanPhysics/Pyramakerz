Imports System.IO
Imports System.Data.SqlClient

Public Class UploadFiles
    Public Flag As Integer = 1
    Dim bm As New BasicMethods
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex < 1 Then
            bm.ShowMSG("Please Select Type")
            ComboBox1.Focus()
            Return
        End If
        Dim o As New OpenFileDialog
        o.Multiselect = True
        If o.ShowDialog = DialogResult.OK Then
            ProgressBar1.Value = 0
            ProgressBar1.Maximum = o.FileNames.Length
            ProgressBar1.Visible = True
            For i As Integer = 0 To o.FileNames.Length - 1
                bm.SaveFile("FileStore", "Type", ComboBox1.SelectedValue.ToString, "FileName", (o.FileNames(i).Split("\"))(o.FileNames(i).Split("\").Length - 1), "ImageData", o.FileNames(i))
                ProgressBar1.Value += 1
                ProgressBar1.Refresh()
                Refresh()
            Next
            ProgressBar1.Visible = False
        End If
        LoadTree()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoadTree()
    End Sub

    Private Sub UploadFiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Flag = 2 Then
            Panel1.Visible = False 
            TreeView1.Size = New Size(TreeView1.Size.Width, TreeView1.Size.Height + 100)
        End If
        bm.FillCombo("PDFTypes", ComboBox1, "")
        LoadTree()
    End Sub

    Private Sub TreeView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        Button4_Click(Nothing, Nothing)
    End Sub

    Private Sub LoadTree()
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add("Contents")
        Dim pdf As DataTable = bm.ExcuteAdapter("select Type,FileName from FileStore order by FileName")
        Dim dt As DataTable = bm.ExcuteAdapter("select Id,Name from PDFTypes")
        For i As Integer = 0 To dt.Rows.Count - 1
            TreeView1.Nodes(0).Nodes.Add(dt.Rows(i)(0).ToString, dt.Rows(i)(1).ToString)
            Dim Dr() As DataRow = pdf.Select("Type='" & dt.Rows(i)(0).ToString & "'")
            For ii As Integer = 0 To Dr.Length - 1
                TreeView1.Nodes(0).Nodes(dt.Rows(i)(0).ToString).Nodes.Add(Dr(ii)("FileName"))
            Next
        Next
        TreeView1.ExpandAll()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TreeView1.SelectedNode.Level = 2 Then
                If bm.ShowDeleteMSG("Are You SURE to Delete """ & TreeView1.SelectedNode.Text & """?") Then
                    bm.ExcuteNonQuery("delete from FileStore where Type='" & TreeView1.SelectedNode.Parent.Name & "' and FileName='" & TreeView1.SelectedNode.Text & "'")
                    LoadTree()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TreeView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Button3_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyImagedata = Nothing
        If TreeView1.SelectedNode.Level <> 2 Then Return
        Dim s As New SaveFileDialog
        s.FileName = TreeView1.SelectedNode.Text
        If Not s.ShowDialog = DialogResult.OK Then Return
        MyBath = s.FileName
        Button4.Enabled = False
        F1 = TreeView1.SelectedNode.Parent.Name
        F2 = TreeView1.SelectedNode.Text
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Dim MyImagedata() As Byte
    Dim MyBath As String = "", F1 As String = "", F2 As String = ""
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim c As New SqlConnection(cmd.Connection.ConnectionString)
        Try
            Dim myCommand As SqlClient.SqlCommand = c.CreateCommand
            myCommand.CommandText = "select ImageData from FileStore where Type='" & F1 & "' and FileName='" & F2 & "'"
            bm.OpenConnection(c)
            MyImagedata = CType(myCommand.ExecuteScalar(), Byte())
            bm.CloseConnection(c)
        Catch ex As Exception
            bm.CloseConnection(c)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            File.WriteAllBytes(MyBath, MyImagedata)
        Catch ex As Exception
        End Try
        Button4.Enabled = True
    End Sub
End Class