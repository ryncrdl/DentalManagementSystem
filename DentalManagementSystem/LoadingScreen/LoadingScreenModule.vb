Imports System.Threading
Imports System.Windows.Forms
Module LoadingScreenModule
    Private loadingForm As LoadingForm

    Public Sub ShowLoadingScreen()
        loadingForm = New LoadingForm()
        loadingForm.StartPosition = FormStartPosition.CenterScreen
        loadingForm.Show()
        Application.DoEvents()
    End Sub

    Public Sub HideLoadingScreen()
        If loadingForm IsNot Nothing Then
            loadingForm.Close()
            loadingForm.Dispose()
        End If
    End Sub

    Public Sub PerformDatabaseOperationWithLoadingScreen(action As Action)
        Try
            ShowLoadingScreen()
            Dim thread As New Thread(
                Sub()
                    Try
                        action.Invoke()
                    Catch ex As Exception
                        ' Handle any exceptions that occur during the operation
                    Finally
                        HideLoadingScreen()
                    End Try
                End Sub)
            thread.Start()
        Catch ex As Exception
            ' Handle any exceptions related to showing the loading screen
        End Try
    End Sub
End Module
