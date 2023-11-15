

Imports System.Net.Http
Imports System.Reflection.Metadata
Imports System.Text

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        Dim apiURL As String = $"http://localhost:5272/api/AuthorizationModify/api/AuthorizationModify/Verify"

        ' Create an HttpClient instance (make sure to import System.Net.Http)
        Using client As New HttpClient()
            ' Create a request content with your username and password
            Dim jsonContent As String = $"{{""Username"": ""{username}"", ""Password"": ""{password}""}}"
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")


            ' Send the POST request
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync(apiURL, content)
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    ' Authentication successful
                    ' You can navigate to the next page or perform other actions here
                    MessageBox.Show("Login Succeed.")
                    Dim otherForm As New Form2()
                    otherForm.Show()

                    ' Optionally, you can hide the current form
                    Me.Hide()
                Else
                    ' Authentication failed
                    ' Show an error message to the user
                    MessageBox.Show("Login Failed")
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' Check the response status

        End Using
    End Sub

End Class