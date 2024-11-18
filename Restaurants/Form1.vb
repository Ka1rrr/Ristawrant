Public Class Form1
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the password character to hide password input
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        HomeForm.Show()
        ' Define username and password
        Dim correctUsername As String = "admin"
        Dim correctPassword As String = "admin"

        ' Check if the entered credentials match
        If txtUsername.Text = correctUsername AndAlso txtPassword.Text = correctPassword Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
