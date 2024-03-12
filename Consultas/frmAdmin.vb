Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_listaContas()
        carregar_tipoBusca()
    End Sub

        'lblUsuario.Text = UCase(frmLogin.txtUsuario.Text)
        'lblData.Text = Date.Today

        'Private Sub btnListaContas_Click(sender As Object, e As EventArgs)
        '    frmPacientes.ShowDialog() 'chama frmPacientes
        'End Sub

        'Private Sub btnCadastrarUsuario_Click(sender As Object, e As EventArgs)
        '    frmConsultas.ShowDialog() 'chama frmConsultas
        'End Sub

        'menuItemCadastrarDoutor.Enabled = False 'oculta o item CadastrarDoutor do menu CADASTRAR
        'menuItemCadastrarRecepcionista.Enabled = False 'oculta o item CadastrarRecepcionista do menu CADASTRAR

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            sql = "select * from tbUsuarios where usuario = '" & txtNome.Text & "' or email = '" & txtEmail.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tbUsuarios values ('" & txtNome.Text & "'," & _
                                                        "'" & txtEmail.Text & "'," & _
                                                        "'" & txtSenha.Text & "', 'Ativada')"
                rs = db.Execute(sql)
                MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_conta()
            carregar_listaContas()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar usuário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            sql = "select * from tbUsuarios where usuario ='" & txtNome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tbUsuarios set email = '" & txtEmail.Text & "', " & _
                                            "senha = '" & txtSenha.Text & "' where usuario = '" & txtNome.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_conta()
            carregar_listaContas()
        Catch ex As Exception
            MsgBox("Erro ao editar usuário!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            sql = "select * from tbUsuarios where usuario ='" & txtNome.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                sql = "delete * from tbUsuarios where usuario = '" & txtNome.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados excluídos com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_conta()
            carregar_listaContas()
        Catch ex As Exception
            MsgBox("Erro ao excluir usuário!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub chkVisualizarSenha_Click(sender As Object, e As EventArgs) Handles chkVisualizarSenha.Click
        Try
            If txtSenha.PasswordChar = "*" Or txtRepSenha.PasswordChar = "*" Then
                txtSenha.PasswordChar = ""
                txtRepSenha.PasswordChar = ""
            Else
                txtSenha.PasswordChar = "*"
                txtRepSenha.PasswordChar = "*"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtNome_DoubleClick(sender As Object, e As EventArgs) Handles txtNome.DoubleClick
        limpar_conta()
    End Sub

    Private Sub txtNome_LostFocus(sender As Object, e As EventArgs) Handles txtNome.LostFocus
        Try
            sql = "select * from tbUsuarios where usuario='" & txtNome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se o nome pesquisado ja existir na tbUsuarios
                txtEmail.Text = rs.Fields(1).Value
                txtSenha.Text = rs.Fields(2).Value
            Else
                txtEmail.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub listaContas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaContas.CellContentClick
        Try
            With listaContas
                If .CurrentRow.Cells(5).Selected = True Then 'se a coluna selecionada do Datagridview for BLOQUEAR
                    auxUsuario = .CurrentRow.Cells(1).Value 'pega a coluna 1 (Usuario) do Datagridview
                    sql = "select * from tbUsuarios where usuario='" & auxUsuario & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then ' se o Usuario ja tiver sido cadastrado
                        sql = "update tbUsuarios set statusConta = 'Bloqueada' where usuario = '" & auxUsuario & "'"
                        rs = db.Execute(sql)
                    End If

                ElseIf .CurrentRow.Cells(6).Selected = True Then 'se a coluna selecionada do Datagridview for ATIVAR
                    auxUsuario = .CurrentRow.Cells(1).Value 'pega a coluna 1 (Usuario) do Datagridview
                    sql = "select * from tbUsuarios where usuario='" & auxUsuario & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then ' se o Usuario ja tiver sido cadastrado
                        sql = "update tbUsuarios set statusConta = 'Ativada' where usuario = '" & auxUsuario & "'"
                        rs = db.Execute(sql)
                    End If
                Else
                    Exit Sub
                End If
                carregar_listaContas()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txtBuscaUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaUsuario.TextChanged
        Try
            With listaContas
                cont = 1
                sql = "select * from tbUsuarios where " & cmbTipoBusca.Text & " like '" & txtBuscaUsuario.Text & "%'"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False 'Adiciona linhas no datagridview a cada busca de usuarios
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()
        frmLogin.txtUsuario.Clear()
        frmLogin.txtSenha.Clear()
    End Sub

End Class
