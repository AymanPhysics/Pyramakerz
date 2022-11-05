Public Class MSG
    Public Ok As Boolean
    Public DelMsg As Boolean = False
    Public MSG As String

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        Ok = True
        Close()
    End Sub

    Public MistakeOrUpdate As Boolean = False

    Private Sub MSG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        If Module1.MyProject = Project.Pyramakerz Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Resources.Pyramakerz
        ElseIf Module1.MyProject = Project.EFG Then
            BackgroundImage = Global.Pyramakerz.My.Resources.Pyramakerz
        End If
        Ok = False
        If Not DelMsg Then
            btnNo.Size = New Size(0, 0)
            btnYes.Text = "&Exit"
        End If

        If MistakeOrUpdate Then
            btnYes.Text = "&Mistake"
            btnNo.Text = "&Update"
        End If

        lblMSG.Text = MSG
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Ok = False
        Close()
    End Sub
End Class