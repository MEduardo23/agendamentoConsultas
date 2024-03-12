Public Class frmPacientes

    Private Sub frmPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_listaPacientes()
        carregar_tipo()
        carregar_tiposRelatorio()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            sql = "select * from tbPacientes where cpf='" & txtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tbPacientes values ('" & txtCpf.Text & "', " & _
                                                        "'" & txtNome.Text & "', " & _
                                                        "'" & cmbData.Text & "', " & _
                                                        "'" & cmbGenero.Text & "', " & _
                                                        "'" & txtCelular.Text & "', " & _
                                                        "'" & txtEmail.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Paciente cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_dados()
            carregar_listaPacientes()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar paciente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            sql = "select * from tbPacientes where cpf='" & txtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tbPacientes set nome ='" & txtNome.Text & "', " & _
                                            "datanasc = '" & cmbData.Text & "', " & _
                                            "genero = '" & cmbGenero.Text & "', " & _
                                            "celular = '" & txtCelular.Text & "', " & _
                                            "email = '" & txtEmail.Text & "' where cpf = '" & txtCpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_dados()
            carregar_listaPacientes()
        Catch ex As Exception
            MsgBox("Erro ao editar paciente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            sql = "select * from tbPacientes where cpf='" & txtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "delete * from tbPacientes where cpf = '" & txtCpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados excluídos com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_dados()
            carregar_listaPacientes()
        Catch ex As Exception
            MsgBox("Erro ao excluir paciente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txtCpf_DoubleClick(sender As Object, e As EventArgs) Handles txtCpf.DoubleClick
        limpar_dados()
    End Sub

    Private Sub txtCpf_LostFocus1(sender As Object, e As EventArgs) Handles txtCpf.LostFocus
        Try
            sql = "select * from tbPacientes where cpf='" & txtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se o CPF pesquisado ja existir na tbPacientes
                txtNome.Text = rs.Fields(1).Value
                cmbData.Text = rs.Fields(2).Value
                cmbGenero.Text = rs.Fields(3).Value
                txtCelular.Text = rs.Fields(4).Value
                txtEmail.Text = rs.Fields(5).Value
            Else
                txtNome.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txtBuscaPaciente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaPaciente.TextChanged
        Try
            With listaPacientes
                cont = 1
                sql = "select * from tbPacientes where " & cmbTipoBusca.Text & " like '" & txtBuscaPaciente.Text & "%'"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False 'Adiciona linhas no datagridview a cada busca de pacientes
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnGerarRelat_Click(sender As Object, e As EventArgs) Handles btnGerarRelat.Click
        Try
            If cmbRelatPacientes.Text = "Relatório de Pacientes por Nome" Then
                frmRelatorioPacientes.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnAgendarConsulta_Click(sender As Object, e As EventArgs) Handles btnAgendarConsulta.Click
        If frmConsultas.Visible = False Then
            Me.Hide()
            frmConsultas.ShowDialog()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()
        frmLogin.txtUsuario.Clear()
        frmLogin.txtSenha.Clear()
    End Sub

End Class