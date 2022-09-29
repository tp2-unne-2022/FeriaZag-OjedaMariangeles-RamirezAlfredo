﻿Public Class Administrador

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmproducto As New Producto
        frmproducto.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmproducto)
        frmproducto.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmcliente As New Cliente
        frmcliente.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmcliente)
        frmcliente.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmhora As New Hora
        frmhora.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmhora)
        frmhora.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmproveedor As New proveedor
        frmproveedor.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmproveedor)
        frmproveedor.Show()
    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblHora.Text = DateTime.Now.ToLongTimeString()
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

End Class