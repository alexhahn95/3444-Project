Imports Microsoft.VisualBasic.ApplicationServices

'Welcome form
Public Class frmWelcome

    'Button click event handler. Containts form validation.
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login = UsersTableAdapter.LoginString(UsernameTextBox.Text, PasswordTextBox.Text)
        If login Is Nothing Then
            MsgBox("Check Username or Password")
        Else
            My.Forms.frmHomeScreen.Show()
            My.Forms.frmWelcome.Close()
        End If
    End Sub

    'Used for form validation
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsersDataSet)
    End Sub
End Class