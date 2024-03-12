<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripRelatorio = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbRelatConsultas = New System.Windows.Forms.ToolStripComboBox()
        Me.btnGerarRelat = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCadastrarPaciente = New System.Windows.Forms.Button()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtEspecialidade = New System.Windows.Forms.TextBox()
        Me.txtDoutor = New System.Windows.Forms.TextBox()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbHora = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbData = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnAgendar = New System.Windows.Forms.Button()
        Me.listaConsultas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStripRelatorio.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripRelatorio
        '
        Me.ToolStripRelatorio.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripRelatorio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.cmbRelatConsultas, Me.btnGerarRelat})
        Me.ToolStripRelatorio.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripRelatorio.Name = "ToolStripRelatorio"
        Me.ToolStripRelatorio.Size = New System.Drawing.Size(1068, 25)
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
        'cmbRelatConsultas
        '
        Me.cmbRelatConsultas.Name = "cmbRelatConsultas"
        Me.cmbRelatConsultas.Size = New System.Drawing.Size(121, 25)
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnCadastrarPaciente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 438)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(47, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "HealthSys"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(23, 247)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(148, 37)
        Me.btnLogout.TabIndex = 11
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
        'btnCadastrarPaciente
        '
        Me.btnCadastrarPaciente.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCadastrarPaciente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPaciente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarPaciente.ForeColor = System.Drawing.Color.Transparent
        Me.btnCadastrarPaciente.Location = New System.Drawing.Point(23, 195)
        Me.btnCadastrarPaciente.Name = "btnCadastrarPaciente"
        Me.btnCadastrarPaciente.Size = New System.Drawing.Size(148, 37)
        Me.btnCadastrarPaciente.TabIndex = 10
        Me.btnCadastrarPaciente.Text = "Cadastrar paciente"
        Me.btnCadastrarPaciente.UseVisualStyleBackColor = False
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.White
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(196, 386)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(181, 15)
        Me.txtDescricao.TabIndex = 6
        '
        'txtEspecialidade
        '
        Me.txtEspecialidade.BackColor = System.Drawing.Color.White
        Me.txtEspecialidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEspecialidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecialidade.Location = New System.Drawing.Point(195, 207)
        Me.txtEspecialidade.Name = "txtEspecialidade"
        Me.txtEspecialidade.Size = New System.Drawing.Size(181, 15)
        Me.txtEspecialidade.TabIndex = 3
        '
        'txtDoutor
        '
        Me.txtDoutor.BackColor = System.Drawing.Color.White
        Me.txtDoutor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDoutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoutor.Location = New System.Drawing.Point(195, 155)
        Me.txtDoutor.Name = "txtDoutor"
        Me.txtDoutor.Size = New System.Drawing.Size(181, 15)
        Me.txtDoutor.TabIndex = 2
        '
        'txtPaciente
        '
        Me.txtPaciente.BackColor = System.Drawing.Color.White
        Me.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaciente.Location = New System.Drawing.Point(195, 104)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(181, 15)
        Me.txtPaciente.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(191, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Paciente"
        '
        'cmbHora
        '
        Me.cmbHora.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.cmbHora.Location = New System.Drawing.Point(195, 322)
        Me.cmbHora.MinDate = New Date(2024, 2, 29, 0, 0, 0, 0)
        Me.cmbHora.Name = "cmbHora"
        Me.cmbHora.Size = New System.Drawing.Size(182, 20)
        Me.cmbHora.TabIndex = 5
        Me.cmbHora.Value = New Date(2024, 2, 29, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(191, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 21)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Especialidade"
        '
        'cmbData
        '
        Me.cmbData.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.cmbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbData.Location = New System.Drawing.Point(195, 262)
        Me.cmbData.MinDate = New Date(2024, 2, 29, 0, 0, 0, 0)
        Me.cmbData.Name = "cmbData"
        Me.cmbData.Size = New System.Drawing.Size(181, 20)
        Me.cmbData.TabIndex = 4
        Me.cmbData.Value = New Date(2024, 2, 29, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(191, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Descrição"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Location = New System.Drawing.Point(191, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 21)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Hora da Consulta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Location = New System.Drawing.Point(191, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 21)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Data da Consulta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Location = New System.Drawing.Point(191, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 21)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Doutor"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(791, 407)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(109, 37)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(666, 407)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(109, 37)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "ALTERAR"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnAgendar
        '
        Me.btnAgendar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAgendar.FlatAppearance.BorderSize = 0
        Me.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendar.ForeColor = System.Drawing.Color.White
        Me.btnAgendar.Location = New System.Drawing.Point(540, 407)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(109, 37)
        Me.btnAgendar.TabIndex = 7
        Me.btnAgendar.Text = "AGENDAR"
        Me.btnAgendar.UseVisualStyleBackColor = False
        '
        'listaConsultas
        '
        Me.listaConsultas.AllowUserToAddRows = False
        Me.listaConsultas.AllowUserToDeleteRows = False
        Me.listaConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.listaConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.listaConsultas.BackgroundColor = System.Drawing.Color.White
        Me.listaConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listaConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listaConsultas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.listaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaConsultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column7, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.listaConsultas.Location = New System.Drawing.Point(397, 80)
        Me.listaConsultas.Name = "listaConsultas"
        Me.listaConsultas.ReadOnly = True
        Me.listaConsultas.Size = New System.Drawing.Size(659, 321)
        Me.listaConsultas.TabIndex = 39
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Consulta"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 103
        '
        'Column7
        '
        Me.Column7.HeaderText = "Paciente"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 84
        '
        'Column2
        '
        Me.Column2.HeaderText = "Doutor"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 76
        '
        'Column3
        '
        Me.Column3.HeaderText = "Especialidade"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 113
        '
        'Column4
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Data"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.Width = 61
        '
        'Column5
        '
        DataGridViewCellStyle3.Format = "t"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Hora"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.Width = 63
        '
        'Column6
        '
        Me.Column6.HeaderText = "Descrição"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(392, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 30)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Agendamento de Consultas"
        '
        'frmConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1068, 463)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.listaConsultas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnAgendar)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtEspecialidade)
        Me.Controls.Add(Me.txtDoutor)
        Me.Controls.Add(Me.txtPaciente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbHora)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbData)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStripRelatorio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGENDAMENTO DE CONSULTAS"
        Me.ToolStripRelatorio.ResumeLayout(False)
        Me.ToolStripRelatorio.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripRelatorio As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbRelatConsultas As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnGerarRelat As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecialidade As System.Windows.Forms.TextBox
    Friend WithEvents txtDoutor As System.Windows.Forms.TextBox
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnAgendar As System.Windows.Forms.Button
    Friend WithEvents listaConsultas As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarPaciente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
