Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmWelcome
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'My.Forms.frmHomeScreen.Show()
        'My.Forms.frmWelcome.Close()

        MessageBox.Show("handled")

        Dim opt = New Optimization
        opt.BuildModel()
    End Sub
End Class
