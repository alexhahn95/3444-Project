Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmWelcome
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'My.Forms.frmHomeScreen.Show()
        'My.Forms.frmWelcome.Close()

        Dim opt = New Optimization
        opt.BuildModel()
        Dim h As Integer = 5

        MessageBox.Show(h)
    End Sub
End Class
