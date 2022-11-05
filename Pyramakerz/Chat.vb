Public Class Chat
    Dim bm As New BasicMethods
    Public ToUser As String() = New String() {}
    Public ToUserName As String = "" '"All"
    Public Tbl As DataTable = New DataTable


    Dim MyList As New ListBox
    Public Sub Chat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ReDim Preserve ToUser(Tbl.Rows.Count - 3)
        Catch ex As Exception
        End Try
        Dim x As Integer = 0
        For i As Integer = 0 To Tbl.Rows.Count - 1
            If Tbl.Rows(i)(0).ToString = "" Or Tbl.Rows(i)(0).ToString = Module1.UserName Then Continue For
            ToUser(x) = Tbl.Rows(i)(0).ToString
            x += 1
        Next

        If Tbl.Rows.Count = 0 Then
            ToUserName = ""
            For i As Integer = 0 To ToUser.Length - 1
                ToUserName &= bm.ExecuteScalar("select EnName from Employees where Id='" & ToUser(i) & "'")
                If i < ToUser.Length - 1 Then ToUserName &= ","
            Next
        End If
        Text = ToUserName

        For Each C As Control In Controls
            AddHandler C.KeyPress, AddressOf bm._KeyPress
        Next

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If TextBox1.Text.Trim = "" Then Return
        Dim x As Integer = 0
        For i As Integer = 0 To ToUser.Length - 1
            x = bm.ExecuteScalar("insert into Messages(FromUser,ToUser,Details,Daydate,Done) select '" & Module1.UserName & "','" & ToUser(i) & "','" & TextBox1.Text.Trim.Replace("'", "''") & "',GETDATE(),'0' select @@IDENTITY")
        Next

        Dim s As String = Module1.EnName & " : "
        RichTextBox1.AppendText(vbCrLf & s & vbCrLf & TextBox1.Text.Trim() & vbCrLf)

        If ToUser.Length = 1 Then
            MyList.Items.Add(x.ToString & "," & RichTextBox1.Text.Length - TextBox1.Text.Trim().Length - 1 & "," & TextBox1.Text.Trim().Length)
        End If

        RichTextBox1.Select(RichTextBox1.Text.Length - s.Length - TextBox1.Text.Length - 2, s.Length)
        RichTextBox1.SelectionColor = Color.Red
        RichTextBox1.SelectedText = ""

        RichTextBox1.ScrollToCaret()
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i As Integer = MyList.Items.Count - 1 To 0 Step -1
            If Val(bm.ExecuteScalar("select Done from Messages where Line=" & MyList.Items(i).ToString.Split(",")(0))) = 1 Then
                'Clipboard.SetText("(Seen)")
                'RichTextBox1.SelectionStart = MyList.Items(i).ToString.Split(",")(1)
                'RichTextBox1.SelectionLength = 0
                'RichTextBox1.ReadOnly = False
                'RichTextBox1.Paste()
                'RichTextBox1.ReadOnly = True
                'Clipboard.Clear()
                RichTextBox1.SelectionStart = MyList.Items(i).ToString.Split(",")(1)
                RichTextBox1.SelectionLength = MyList.Items(i).ToString.Split(",")(2)
                RichTextBox1.SelectionFont = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Italic)
                RichTextBox1.SelectionColor = Color.Red
                RichTextBox1.SelectedText = ""
                MyList.Items.RemoveAt(i)
            End If

        Next
    End Sub
End Class