Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmWelcome
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'My.Forms.frmHomeScreen.Show()
        'My.Forms.frmWelcome.Close()

        Dim opt = New Optimization
        opt.BuildModel()
        Me.Close()
    End Sub
End Class
