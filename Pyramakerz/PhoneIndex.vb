Public Class PhoneIndex

    Dim bm As New BasicMethods
    Public FirstColumn, SecondColumn, ThirdColumn, Statement As String

    Dim dt As New DataTable
    Dim dv As New DataView
    Private Sub PhoneIndex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FirstColumn = "Phone"
        SecondColumn = "Name"
        ThirdColumn = "City"
        Statement = "select Phone,Name,City,dbo.GetCityName(Country,City)'City ' from PhoneIndex where Country='" & Module1.CountryId & "'"
        dt = bm.ExcuteAdapter(Statement)
        dt.TableName = "tbl"
        dt.Columns(0).ColumnName = FirstColumn
        dt.Columns(1).ColumnName = SecondColumn
        dt.Columns(2).ColumnName = ThirdColumn

        dv.Table = dt
        DataGridView1.DataSource = dv
        DataGridView1.Columns(2).Visible = False
        'DataGridView1.Columns(1).Width = 300
        bm.FillCombo("Cities", txt2, " where CountryId='" & Module1.CountryId & "'")
        txtId_TextChanged(Nothing, Nothing)
    End Sub


    Private Sub txtId_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.Enter
        Try
            dv.Sort = FirstColumn
        Catch
        End Try
    End Sub

    Private Sub txtName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Enter
        Try
            dv.Sort = SecondColumn
        Catch
        End Try
    End Sub
    Private Sub txt2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.Enter
        Try
            dv.Sort = ThirdColumn
        Catch
        End Try
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged, txtName.TextChanged, txt2.SelectedIndexChanged
        Try
            dv.RowFilter = " [" & FirstColumn & "] like '%" & txtId.Text & "%' and [" & SecondColumn & "] like '%" & txtName.Text & "%' and ([" & ThirdColumn & "] = '" & txt2.SelectedValue.ToString & "' or '" & txt2.SelectedValue.ToString & "'='0')"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub
    Public SelectedId As String = ""
    Public SelectedName As String = ""
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
      
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
       
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtId.Text.Trim = "" Then
            bm.ShowMSG("Please, Enter a Phone ...")
            txtId.Focus()
            Return
        End If
        If txtName.Text.Trim = "" Then
            bm.ShowMSG("Please, Enter a Name ...")
            txtName.Focus()
            Return
        End If
        If txt2.SelectedIndex < 1 Then
            bm.ShowMSG("Please, Enter Select a City ...")
            txt2.Focus()
            Return
        End If

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If txtId.Text.Trim = DataGridView1.Rows(i).Cells(0).Value AndAlso txtName.Text.Trim = DataGridView1.Rows(i).Cells(1).Value AndAlso txt2.SelectedValue.ToString = DataGridView1.Rows(i).Cells(2).Value Then
                bm.ShowMSG("It's Already Exists ...")
                txt2.Focus()
                Return
            End If
        Next

        bm.ExcuteNonQuery("insert into PhoneIndex (Phone,Name,Country,City) select '" & txtId.Text.Trim & "','" & txtName.Text.Trim & "','" & Module1.CountryId & "','" & txt2.SelectedValue.ToString & "'")
        Dim s As String = txt2.SelectedValue.ToString
        PhoneIndex_Load(Nothing, Nothing)
        txt2.SelectedValue = s
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not bm.ShowDeleteMSG("Are you sure you want to delete?") Then Return
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Try
            bm.ExcuteNonQuery("delete from PhoneIndex where Phone='" & DataGridView1.Rows(i).Cells(0).Value & "' and Name='" & DataGridView1.Rows(i).Cells(1).Value & "' and Country='" & Module1.CountryId & "' and City='" & DataGridView1.Rows(i).Cells(2).Value & "'")
        Catch ex As Exception
        End Try

        Dim s As String = txt2.SelectedValue.ToString
        PhoneIndex_Load(Nothing, Nothing)
        txt2.SelectedValue = s
    End Sub
End Class