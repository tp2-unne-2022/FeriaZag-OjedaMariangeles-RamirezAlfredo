﻿Public Class FrmFactura
    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FeriaZagDataSet.GenerarComprobante' Puede moverla o quitarla según sea necesario.
        Me.GenerarComprobanteTableAdapter.Fill(Me.FeriaZagDataSet.GenerarComprobante, idcabecera)
        'TODO: esta línea de código carga datos en la tabla 'FeriaZagDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.FeriaZagDataSet.Clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class