Public Class StSearch
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim bm As New BasicMethods
    Public StudentId As String = ""
    Public TableWhere As String = ""
    Public Flag As Integer = 1
    Private Sub StSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        State.SelectedIndex = 2
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        End If
    End Sub
    Sub Search(ByVal Col As String)

        dv.RowFilter = AppendWhere
        Try
            dv.Sort = "ID"
            dv.Sort = Col
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ArName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArName.TextChanged, EnName.TextChanged, txtID.TextChanged, NationalId.TextChanged, HomePhone.TextChanged, Mobile.TextChanged, Mobile2.TextChanged, Email.TextChanged, WorkPhone.Enter, txtID.Enter, NationalId.Enter, Mobile2.Enter, Mobile.Enter, HomePhone.Enter, EnName.Enter, Email.Enter, ArName.Enter, State.SelectedIndexChanged
        Dim txt As TextBox
        Try
            txt = sender
        Catch ex As Exception
            txt = txtID
        End Try

        Search(txt.Tag)
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        StudentId = DataGridView1.CurrentRow.Cells(0).Value.ToString
        If Flag = 1 Then
            Close()
        Else
            Dim rpt As New ReportViewer(Text)
            rpt.Rpt = "StudentActivities.rpt"
            rpt.paraname = New String() {"@StudentId", "@BranchId", "@FromDate", "@ToDate", "@Flag"}
            rpt.paravalue = New String() {StudentId, 0, Date.MinValue.ToShortDateString, Date.MaxValue.ToShortDateString, 0}
            'rpt.SubReports = New String() {"Financial", "Technical"}
            rpt.ShowDialog()
        End If

    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Function AppendWhere() As String
        Dim s1 As String = IIf(State.SelectedIndex = 0 Or State.SelectedIndex = 1, "", "%")
        Dim s2 As String = IIf(State.SelectedIndex = 0 Or State.SelectedIndex = 3, "", "%")

        Return "ID like '" & s1 & txtID.Text & s2 & "' and ArName like '" & s1 & ArName.Text & s2 & "' and EnName like '" & s1 & EnName.Text & s2 & "' and NationalId like '" & s1 & NationalId.Text & s2 & "' and HomePhone like '" & s1 & HomePhone.Text & s2 & "' and WorkPhone like '" & s1 & WorkPhone.Text & s2 & "' and Mobile like '" & s1 & Mobile.Text & s2 & "' and Mobile2 like '" & s1 & Mobile2.Text & s2 & "' and Email like '" & s1 & Email.Text & s2 & "'"
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        btnSearch.Enabled = False
        Try
            dv = New DataView(bm.ExcuteAdapter("SELECT cast(ID as varchar(10)) 'ID',ArName,EnName,NationalId,HomePhone,WorkPhone,Mobile,Mobile2,Email FROM Students " & TableWhere & IIf(TableWhere = "", " where ", " and ") & AppendWhere()))
            DataGridView1.DataSource = dv
            DataGridView1.Columns(0).FillWeight = 150
        Catch ex As Exception
        End Try
        btnSearch.Enabled = True
    End Sub
End Class