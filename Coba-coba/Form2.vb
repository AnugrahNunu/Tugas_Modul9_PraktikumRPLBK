Imports System.Net.Http
Imports System.Reflection.Metadata
Imports System.Text

Public Class Form2
    Private Async Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim Username As String = TextBox1.Text
        Dim Password As String = TextBox2.Text

        Dim apiURL As String = $"http://localhost:5272/api/AuthorizationModify"

        Using client As New HttpClient()
            Dim jsonContent As String = $"{{""username"": ""{Username}"", ""password"": ""{Password}""}}"
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            'send POST request
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync(apiURL, content)
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("New Data Added")
                Else
                    MessageBox.Show($"Response Content: {responseContent}")
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End Using
    End Sub

    Private Async Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim ID As String = TextBox4.Text
        Dim Username As String = TextBox5.Text
        Dim Password As String = TextBox3.Text

        Dim apiURL As String = $"http://localhost:5272/api/AuthorizationModify/{ID}"

        Using client As New HttpClient()
            Dim jsonContent As String = $"{{""id"": {ID}, ""username"": ""{Username}"", ""password"": ""{Password}""}}"
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            ' Send the PUT request
            Try
                Dim response As HttpResponseMessage = Await client.PutAsync(apiURL, content)
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Data Has Been Updated")
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End Using
    End Sub

    Private Async Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim ID As String = TextBox7.Text

        Using client As New HttpClient()

            ' Send the DELETE request
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:5272/api/AuthorizationModify/{ID}")
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Data Has Been Deleted")
                Else
                    MessageBox.Show("Data isn't available")
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
    End Sub
End Class