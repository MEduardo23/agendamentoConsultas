Module Module1
    Public sql As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public banco_access = Application.StartupPath & "\bancoDados\cadastroPacientes.accdb"
    Public cont As Integer
    Public auxCpf, auxUsuario, resp As String
    Public idConta As Integer
    Public statusLogin As Integer

    'CONEXAO - BANCO ACCESS
    Sub conecta_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & banco_access)
            'MsgBox("Banco de Dados conectado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            'MsgBox("Erro ao conectar com Banco de Dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'LOGIN
    Sub gerar_idConta() 'é a coluna (0) da tabela tbUsuarios
        sql = "select * from tbUsuarios order by idConta desc"
        rs = db.Execute(Sql)
        If rs.BOF = True Then 'se houver algum usuario cadastrado na tbUsuarios
            idConta = 1
        Else
            idConta = rs.Fields(0).Value + 1
        End If
    End Sub

    'ADMIN
    Sub carregar_listaContas()
        Try
            With frmAdmin.listaContas 'Datagridview do frmAdmin
                cont = 1
                sql = "select * from tbUsuarios order by usuario asc"
                rs = db.Execute(sql)
                .Rows.Clear() 'Limpa cada linha do Datagridview
                Do While rs.EOF = False 'Acrescente itens no Datagridview enquanto existir registros na tbUsuarios
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext() 'Move para o proximo registro enquanto existir registros na tbUsuarios
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_conta()
        With frmAdmin
            .txtNome.Clear()
            .txtEmail.Clear()
            .txtSenha.Clear()
            .txtRepSenha.Clear()
            .txtNome.Focus()
        End With
    End Sub

    Sub carregar_tipoBusca()
        Try
            With frmAdmin.cmbTipoBusca.Items
                .Add("Nome")
            End With
            frmAdmin.cmbTipoBusca.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'PACIENTES
    Sub carregar_listaPacientes()
        Try
            With frmPacientes.listaPacientes 'Datagridview do frmPacientes
                cont = 1
                sql = "select * from tbPacientes order by nome asc"
                rs = db.Execute(sql)
                .Rows.Clear() 'Limpa cada linha do Datagridview
                Do While rs.EOF = False 'Acrescente itens no Datagridview enquanto existir registros na tbPacientes
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    cont = cont + 1
                    rs.MoveNext() 'Move para o proximo registro enquanto existir registros na tbPacientes
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_dados()
        With frmPacientes
            .txtCpf.Clear()
            .txtNome.Clear()
            '.cmbData
            .txtCelular.Clear()
            .txtEmail.Clear()
            .txtCpf.Focus()
        End With
    End Sub

    Sub carregar_tipo()
        Try
            With frmPacientes.cmbTipoBusca.Items
                .Add("CPF")
                .Add("Nome")
            End With
            frmPacientes.cmbTipoBusca.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tiposRelatorio()
        Try
            With frmPacientes.cmbRelatPacientes.Items
                .Add("Relatório de Pacientes por Nome")
            End With
            frmPacientes.cmbRelatPacientes.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar relatório!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'CONSULTAS
    Sub carregar_listaConsultas()
        'Try
        With frmConsultas.listaConsultas 'Datagridview do frmConsultas
            cont = 1
            sql = "select * from tbConsultas order by paciente desc"
            rs = db.Execute(sql)
            .Rows.Clear() 'Limpa cada linha do Datagridview
            Do While rs.EOF = False 'Acrescente itens no Datagridview enquanto existir registros na tbConsultas
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                cont = cont + 1
                rs.MoveNext() 'Move para o proximo registro enquanto existir registros na tbConsultas
            Loop
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub limpar_consulta()
        With frmConsultas
            .txtPaciente.Clear()
            .txtDoutor.Clear()
            .txtEspecialidade.Clear()
            '.cmbData
            '.cmbHora
            .txtDescricao.Clear()
            .txtPaciente.Focus()
        End With
    End Sub

    Sub carregar_relatConsultas()
        Try
            With frmConsultas.cmbRelatConsultas.Items
                .Add("Relatório de Consultas por Doutor")
            End With
            frmConsultas.cmbRelatConsultas.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar relatório!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
