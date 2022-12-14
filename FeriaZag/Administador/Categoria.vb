Public Class Categoria

#Region "Variables"
    Dim cat As New DCategoria
    Dim obj As New DProducto
#End Region

#Region "Limpiar"
    Private Sub limpiar()
        TBCategoria.Text = ""
        TBCodigoCategoria.Text = ""
    End Sub
#End Region

#Region "Carga de Categoria"
    Private Sub Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cat.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Boton Agregar"
    Private Sub ICBAgregarCategoria_Click(sender As Object, e As EventArgs) Handles ICBAgregarCategoria.Click
        If TBCategoria.Text = "" Then
            MsgBox("Error debe Completar todos los campos", vbCritical, "Error")
        Else
            cat.RegistrarCategoria(TBCategoria.Text, TBActivo.Text)
            cat.llenarDataGridview(DataGridView1)
        End If
        limpiar()
        Desconectar()
    End Sub
#End Region

#Region "DataGridView Contenido por fila"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim FilaActual As Integer
        FilaActual = DataGridView1.CurrentRow.Index
        TBCodigoCategoria.Text = DataGridView1.Rows(FilaActual).Cells(0).Value
        TBCategoria.Text = DataGridView1.Rows(FilaActual).Cells(1).Value
        TBActivo.Text = DataGridView1.Rows(FilaActual).Cells(2).Value
        ICBAgregarCategoria.Enabled = False
        ICBModificarCategoria.Enabled = True
        ICBEliminarCategoria.Enabled = True
    End Sub
#End Region

#Region "Boton Eliminar"
    Private Sub ICBEliminarCategoria_Click(sender As Object, e As EventArgs) Handles ICBEliminarCategoria.Click
        cat.EliminarCategoria(TBCategoria.Text)
        cat.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Boton Agregrar Categoria"
    Private Sub ICBNuevoCategoria_Click(sender As Object, e As EventArgs) Handles ICBNuevoCategoria.Click
        ICBAgregarCategoria.Enabled = True
        ICBEliminarCategoria.Enabled = False
        ICBModificarCategoria.Enabled = False
        limpiar()
    End Sub
#End Region

#Region "Boton Modificar Categoria"
    Private Sub ICBModificarCategoria_Click(sender As Object, e As EventArgs) Handles ICBModificarCategoria.Click
        cat.ModificarCategoria(TBCodigoCategoria.Text, TBCategoria.Text, TBActivo.Text)
        cat.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Buscar Categorias"
    Private Sub ICBBuscar_Click(sender As Object, e As EventArgs) Handles ICBBuscar.Click
        If CBCategoria2.Text = "Todo" Then
            cat.llenarDataGridview(DataGridView1)
        ElseIf CBCategoria2.Text = "Categoria" Then
            Dim dtpro1 = cat.BuscarCategoria(TbBusqueda.Text)
            DataGridView1.DataSource = dtpro1
        Else
            Dim dtpro1 = cat.BuscarCategoriaPorCodigo(TbBusqueda.Text)
            DataGridView1.DataSource = dtpro1
        End If
    End Sub
#End Region

End Class