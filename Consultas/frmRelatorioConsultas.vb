Public Class frmRelatorioConsultas

    Private Sub frmRelatorioConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'cadastroPacientesDataSet1.tbConsultas' table. You can move, or remove it, as needed.
        Me.tbConsultasTableAdapter.queryConsultas(Me.cadastroPacientesDataSet1.tbConsultas)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class