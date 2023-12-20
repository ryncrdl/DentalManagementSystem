Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Module SMSNotification
    Private Const apiKey As String = "2e292602b80f4a266ebc8610a4bcbb11"
    Private Const apiUrl As String = "https://api.semaphore.co/api/v4/messages"

    Public Async Function SendSMSNotification(numbers As String, message As String) As Task(Of String)
        Try
            Using client As New HttpClient()
                ' Create payload
                Dim payload As String = $"apikey={apiKey}&number={numbers}&message={message}"

                ' Set the Content-Type header
                Dim content As New StringContent(payload, Encoding.UTF8, "application/x-www-form-urlencoded")

                ' Make the POST request
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

                ' Read the response content
                Dim result As String = Await response.Content.ReadAsStringAsync()

                ' Log the response for debugging
                Console.WriteLine($"Response from Semaphore API: {result}")

                ' Check if the HTTP status code indicates success
                If response.IsSuccessStatusCode Then
                    Return result
                Else
                    ' Log the error for debugging
                    Console.WriteLine($"Semaphore API error. Status code: {response.StatusCode}, Reason: {response.ReasonPhrase}")
                    Return result ' You may choose to handle the error differently if needed
                End If
            End Using
        Catch ex As Exception
            ' Log and rethrow the exception
            Console.WriteLine($"Error in SendBulkSms: {ex.Message}")
            Throw
        End Try
    End Function
End Module
