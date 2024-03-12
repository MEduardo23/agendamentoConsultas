Public Class frmConsultas

    Private Sub frmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_listaConsultas()
        'carregar_relatConsultas()
    End Sub

    Private Sub btnAgendar_Click_1(sender As Object, e As EventArgs) Handles btnAgendar.Click
        Try
            sql = "select * from tbConsultas where paciente='" & txtPaciente.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tbConsultas values ('" & txtPaciente.Text & "', " & _
                                                        "'" & txtDoutor.Text & "', " & _
                                                        "'" & txtEspecialidade.Text & "', " & _
                                                        "'" & cmbData.Text & "', " & _
                                                        "'" & cmbHora.Text & "', " & _
                                                        "'" & txtDescricao.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Consulta agendada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_consulta()
            carregar_listaConsultas()
        Catch ex As Exception
            MsgBox("Erro ao agendar consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            sql = "select * from tbConsultas where paciente='" & txtPaciente.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tbConsultas set doutor ='" & txtDoutor.Text & "', " & _
                                            "especialidade = '" & txtEspecialidade.Text & "', " & _
                                            "dataConsulta = '" & cmbData.Text & "', " & _
                                            "horaConsulta = '" & cmbHora.Text & "', " & _
                                            "descricao = '" & txtDescricao.Text & "' where paciente = '" & txtPaciente.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Agendamento alterado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
            limpar_consulta()
            carregar_listaConsultas()
        Catch ex As Exception
            MsgBox("Erro ao alterar consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Try
        sql = "select * from tbConsultas where paciente='" & txtPaciente.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            sql = "delete * from tbConsultas where paciente='" & txtPaciente.Text & "'"
            rs = db.Execute(UCase(sql))
            MsgBox("Agendamento cancelado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
        limpar_consulta()
        carregar_listaConsultas()
        'Catch ex As Exception
        'MsgBox("Erro ao cancelar consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub txtPaciente_DoubleClick(sender As Object, e As EventArgs) Handles txtPaciente.DoubleClick
        limpar_consulta()
    End Sub

    Private Sub txtPaciente_LostFocus(sender As Object, e As EventArgs) Handles txtPaciente.LostFocus
        Try
            sql = "select * from tbConsultas where paciente='" & txtPaciente.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se o Paciente ja tiver sido cadastrado na tbConsultas
                txtDoutor.Text = rs.Fields(1).Value
                txtEspecialidade.Text = rs.Fields(2).Value
                cmbData.Text = rs.Fields(3).Value
                cmbHora.Text = rs.Fields(4).Value
                txtDescricao.Text = rs.Fields(5).Value
            Else
                txtDoutor.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'Private Sub txtBuscaPacientes_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaPacientes.TextChanged
    '    Try
    '        With listaPacientes
    '            cont = 1
    '            sql = "select * from tbPacientes where " & cmbTipo.Text & " like '" & txtBuscaPacientes.Text & "%'"
    '            rs = db.Execute(sql)
    '            .Rows.Clear()
    '            Do While rs.EOF = False 'Adiciona linhas no datagridview a cada busca de pacientes
    '                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value)
    '                cont = cont + 1
    '                rs.MoveNext()
    '            Loop
    '        End With
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub

    'Private Sub btnGerarRelat_Click(sender As Object, e As EventArgs) Handles btnGerarRelat.Click
    '    Try
    '        If cmbRelatPacientes.Text = "Relatório de Pacientes" Then
    '            frmRelatPacientes.ShowDialog()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
    '    End Try
    'End Sub

    Private Sub btnGerarRelat_Click(sender As Object, e As EventArgs) Handles btnGerarRelat.Click
        Try
            If cmbRelatConsultas.Text = "Relatório de Consultas por Doutor" Then
                frmRelatorioConsultas.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btnCadastrarPaciente_Click(sender As Object, e As EventArgs) Handles btnCadastrarPaciente.Click
        If frmPacientes.Visible = False Then
            Me.Hide()
            frmPacientes.ShowDialog()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()
        frmLogin.txtUsuario.Clear()
        frmLogin.txtSenha.Clear()
    End Sub

End Class