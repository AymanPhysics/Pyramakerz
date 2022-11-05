Public Class ScanBarcode
    Public Ok As Boolean
    Public DelMsg As Boolean = False
    Public MSG As String

    Dim bm As New BasicMethods


    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ok = True
        Close()
    End Sub

    Public StudentId As Integer = 0

    Private Sub MSG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Barcode.Focus()
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ok = False
        Close()
    End Sub

    Dim lop As Boolean = False
    Private Sub Barcode_Enter(sender As Object, e As EventArgs) Handles Barcode.Enter
        If lop Then Return
        Barcode.Clear()
    End Sub

    Private Sub Barcode_LostFocus(sender As Object, e As EventArgs) Handles Barcode.LostFocus
        If lop Then Return
        'Barcode.Text = "Scan here ..."
    End Sub


    Private Sub Barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles Barcode.KeyDown
        If e.KeyData = Keys.Enter Then
            e.Handled = True

            StudentId = Val(bm.ExecuteScalar("select Id from Students where Barcode='" & Barcode.Text & "'"))

            Barcode.BackColor = Color.Red
            Application.DoEvents()
            Threading.Thread.Sleep(500)
            Barcode.BackColor = Color.White
            Application.DoEvents()

            Close()

        End If
    End Sub

End Class