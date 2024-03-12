Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value = ProgressBar1.Value + 1
            Else
                Timer1.Stop()
                ProgressBar1.Value = 0
                Me.Hide() 'oculta SplashScreen
                frmLogin.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Class
