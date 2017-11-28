Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmWelcome
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login = UsersTableAdapter.LoginString(UsernameTextBox.Text, PasswordTextBox.Text)
        If login Is Nothing Then
            MsgBox("Check Username or Password")
        Else
            My.Forms.frmHomeScreen.Show()
            My.Forms.frmWelcome.Close()
        End If
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsersDataSet)

    End Sub
End Class