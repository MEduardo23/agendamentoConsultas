Public Class frmHome

    Private Sub btnCadastrarPaciente_Click(sender As Object, e As EventArgs) Handles btnCadastrarPaciente.Click
        If frmPacientes.Visible = False Then
            Me.Hide()
            frmPacientes.ShowDialog() 'chama frmPacientes
            Me.Close()
        End If
    End Sub

    Private Sub btnAgendarConsulta_Click(sender As Object, e As EventArgs) Handles btnAgendarConsulta.Click
        If frmConsultas.Visible = False Then
            Me.Hide()
            frmConsultas.ShowDialog() 'chama frmConsultas
            Me.Close()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()
        frmLogin.txtUsuario.Clear()
        frmLogin.txtSenha.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub frmRecepecionista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = UCase(frmLogin.txtUsuario.Text)
        lblData.Text = Date.Today
        Timer1.Start()
        'menuItemCadastrarDoutor.Enabled = False 'oculta o item CadastrarDoutor do menu CADASTRAR
        'menuItemCadastrarRecepcionista.Enabled = False 'oculta o item CadastrarRecepcionista do menu CADASTRAR
    End Sub

End Class
