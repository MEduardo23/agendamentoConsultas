Public Class frmRelatorioPacientes

    Private Sub frmRelatorioPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'cadastroPacientesDataSet1.tbPacientes' table. You can move, or remove it, as needed.
        Me.tbPacientesTableAdapter.queryPacientes(Me.cadastroPacientesDataSet1.tbPacientes)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class