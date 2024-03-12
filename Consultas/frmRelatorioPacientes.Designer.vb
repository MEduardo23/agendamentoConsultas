<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorioPacientes
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorioPacientes))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cadastroPacientesDataSet1 = New WindowsApplication1.cadastroPacientesDataSet1()
        Me.tbPacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbPacientesTableAdapter = New WindowsApplication1.cadastroPacientesDataSet1TableAdapters.tbPacientesTableAdapter()
        CType(Me.cadastroPacientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbPacientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1133, 476)
        Me.ReportViewer1.TabIndex = 0
        '
        'cadastroPacientesDataSet1
        '
        Me.cadastroPacientesDataSet1.DataSetName = "cadastroPacientesDataSet1"
        Me.cadastroPacientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbPacientesBindingSource
        '
        Me.tbPacientesBindingSource.DataMember = "tbPacientes"
        Me.tbPacientesBindingSource.DataSource = Me.cadastroPacientesDataSet1
        '
        'tbPacientesTableAdapter
        '
        Me.tbPacientesTableAdapter.ClearBeforeFill = True
        '
        'frmRelatorioPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 476)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelatorioPacientes"
        Me.Text = "Relatório de Pacientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.cadastroPacientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbPacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cadastroPacientesDataSet1 As WindowsApplication1.cadastroPacientesDataSet1
    Friend WithEvents tbPacientesTableAdapter As WindowsApplication1.cadastroPacientesDataSet1TableAdapters.tbPacientesTableAdapter
End Class
