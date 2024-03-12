<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripRelatorio = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbRelatPacientes = New System.Windows.Forms.ToolStripComboBox()
        Me.btnGerarRelat = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAgendarConsulta = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.cmbDatanasc = New System.Windows.Forms.DateTimePicker()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.listaPacientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.cmbData = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBuscaPaciente = New System.Windows.Forms.TextBox()
        Me.cmbTipoBusca = New System.Windows.Forms.ComboBox()
        Me.ToolStripRelatorio.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripRelatorio
        '
        Me.ToolStripRelatorio.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripRelatorio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.cmbRelatPacientes, Me.btnGerarRelat})
        Me.ToolStripRelatorio.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripRelatorio.Name = "ToolStripRelatorio"
        Me.ToolStripRelatorio.Size = New System.Drawing.Size(1129, 25)
        Me.ToolStripRelatorio.TabIndex = 1
        Me.ToolStripRelatorio.Text = "ToolStrip1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripLabel3.Text = "Gerar Relatório"
        '
        'cmbRelatPacientes
        '
        Me.cmbRelatPacientes.Name = "cmbRelatPacientes"
        Me.cmbRelatPacientes.Size = New System.Drawing.Size(121, 25)
        '
        'btnGerarRelat
        '
        Me.btnGerarRelat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGerarRelat.Image = CType(resources.GetObject("btnGerarRelat.Image"), System.Drawing.Image)
        Me.btnGerarRelat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGerarRelat.Name = "btnGerarRelat"
        Me.btnGerarRelat.Size = New System.Drawing.Size(23, 22)
        Me.btnGerarRelat.Text = "ToolStripButton1"
        Me.btnGerarRelat.ToolTipText = "Visualizar relatório"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnAgendarConsulta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 452)
        Me.Panel1.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(47, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 25)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "HealthSys"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(22, 396)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(148, 37)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'btnAgendarConsulta
        '
        Me.btnAgendarConsulta.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAgendarConsulta.FlatAppearance.BorderSize = 0
        Me.btnAgendarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendarConsulta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendarConsulta.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgendarConsulta.Location = New System.Drawing.Point(22, 341)
        Me.btnAgendarConsulta.Name = "btnAgendarConsulta"
        Me.btnAgendarConsulta.Size = New System.Drawing.Size(148, 37)
        Me.btnAgendarConsulta.TabIndex = 12
        Me.btnAgendarConsulta.Text = "Agendar Consulta"
        Me.btnAgendarConsulta.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(400, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 30)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Cadastro de Pacientes"
        '
        'cmbGenero
        '
        Me.cmbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cmbGenero.Location = New System.Drawing.Point(204, 263)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(183, 21)
        Me.cmbGenero.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(204, 390)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(182, 15)
        Me.txtEmail.TabIndex = 6
        '
        'txtCelular
        '
        Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(204, 330)
        Me.txtCelular.Mask = "(99)99999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(182, 15)
        Me.txtCelular.TabIndex = 5
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbDatanasc
        '
        Me.cmbDatanasc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDatanasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDatanasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDatanasc.Location = New System.Drawing.Point(271, 216)
        Me.cmbDatanasc.Name = "cmbDatanasc"
        Me.cmbDatanasc.Size = New System.Drawing.Size(0, 26)
        Me.cmbDatanasc.TabIndex = 50
        Me.cmbDatanasc.Value = New Date(2024, 2, 20, 0, 0, 0, 0)
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(204, 140)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(181, 15)
        Me.txtNome.TabIndex = 2
        '
        'txtCpf
        '
        Me.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpf.Location = New System.Drawing.Point(204, 85)
        Me.txtCpf.Mask = "999,999,999-99"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(180, 15)
        Me.txtCpf.TabIndex = 1
        Me.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(200, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 21)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(200, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Celular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(200, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Gênero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(200, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 21)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Data de Nascimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(200, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(200, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "CPF"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCadastrar.FlatAppearance.BorderSize = 0
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.ForeColor = System.Drawing.Color.White
        Me.btnCadastrar.Location = New System.Drawing.Point(555, 423)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(119, 37)
        Me.btnCadastrar.TabIndex = 7
        Me.btnCadastrar.Text = "CADASTRAR"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'listaPacientes
        '
        Me.listaPacientes.AllowUserToAddRows = False
        Me.listaPacientes.AllowUserToDeleteRows = False
        Me.listaPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.listaPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.listaPacientes.BackgroundColor = System.Drawing.Color.White
        Me.listaPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listaPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.listaPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listaPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.listaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listaPacientes.DefaultCellStyle = DataGridViewCellStyle9
        Me.listaPacientes.Location = New System.Drawing.Point(405, 63)
        Me.listaPacientes.Name = "listaPacientes"
        Me.listaPacientes.ReadOnly = True
        Me.listaPacientes.Size = New System.Drawing.Size(712, 356)
        Me.listaPacientes.TabIndex = 56
        '
        'Column1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 46
        '
        'Column2
        '
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "CPF"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 56
        '
        'Column3
        '
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column4
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "Data Nascimento"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.Width = 125
        '
        'Column5
        '
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column5.HeaderText = "Gênero"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.Width = 77
        '
        'Column6
        '
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column6.HeaderText = "Celular"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 74
        '
        'Column7
        '
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column7.HeaderText = "E-mail"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 70
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Location = New System.Drawing.Point(849, 423)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(119, 37)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(702, 423)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(119, 37)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'cmbData
        '
        Me.cmbData.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.cmbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbData.Location = New System.Drawing.Point(204, 199)
        Me.cmbData.MinDate = New Date(1809, 12, 31, 0, 0, 0, 0)
        Me.cmbData.Name = "cmbData"
        Me.cmbData.Size = New System.Drawing.Size(181, 20)
        Me.cmbData.TabIndex = 3
        Me.cmbData.Value = New Date(2024, 2, 29, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(907, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Busca paciente"
        '
        'txtBuscaPaciente
        '
        Me.txtBuscaPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscaPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaPaciente.Location = New System.Drawing.Point(796, 37)
        Me.txtBuscaPaciente.Name = "txtBuscaPaciente"
        Me.txtBuscaPaciente.Size = New System.Drawing.Size(105, 19)
        Me.txtBuscaPaciente.TabIndex = 10
        '
        'cmbTipoBusca
        '
        Me.cmbTipoBusca.FormattingEnabled = True
        Me.cmbTipoBusca.Location = New System.Drawing.Point(1032, 36)
        Me.cmbTipoBusca.Name = "cmbTipoBusca"
        Me.cmbTipoBusca.Size = New System.Drawing.Size(85, 21)
        Me.cmbTipoBusca.TabIndex = 11
        '
        'frmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1129, 477)
        Me.Controls.Add(Me.cmbTipoBusca)
        Me.Controls.Add(Me.txtBuscaPaciente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbData)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.listaPacientes)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.cmbDatanasc)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStripRelatorio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE PACIENTES"
        Me.ToolStripRelatorio.ResumeLayout(False)
        Me.ToolStripRelatorio.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripRelatorio As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbRelatPacientes As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnGerarRelat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAgendarConsulta As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbDatanasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents listaPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents cmbData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBuscaPaciente As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoBusca As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
