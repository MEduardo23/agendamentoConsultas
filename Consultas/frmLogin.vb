Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Try
            Timer1.Start()
            sql = "select * from tbUsuarios where (usuario = '" & txtUsuario.Text & "' or email = '" & txtUsuario.Text & "') and senha = '" & txtSenha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'se o usuario ou email ja tiver sido cadastrado
                statusLogin = 1 'faca login
            ElseIf txtUsuario.Text = "admin" And txtSenha.Text = "admin" Then
                statusLogin = 2
            Else
                statusLogin = 0 'nao faca login
            End If
        Catch ex As Exception
            MsgBox("Erro ao efetuar login!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value = ProgressBar1.Value + 1
            Else
                Timer1.Stop()
                ProgressBar1.Value = 0
                If statusLogin = 1 Then 'se a conta e senha ja tiverem sido cadastrados
                    MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide() 'oculta a tela
                    frmHome.ShowDialog()
                ElseIf statusLogin = 2 Then 'se a conta: admin e senha: admin
                    MsgBox("Conta perfil Administrador logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Hide()
                    frmAdmin.ShowDialog()
                Else
                    MsgBox("Usuário ou senha inválidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txtUsuario.Clear()
                    txtSenha.Clear()
                    txtUsuario.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkVisualizarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisualizarSenha.CheckedChanged
        Try
            If txtSenha.PasswordChar = "*" Then
                txtSenha.PasswordChar = ""
            Else
                txtSenha.PasswordChar = "*"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class