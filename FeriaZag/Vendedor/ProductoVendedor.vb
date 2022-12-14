Public Class ProductoVendedor
    Dim obj As New DProducto

#Region "Cargar Producto Vendedor"
    Private Sub ProductoVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "DataGridView Contenido por fila"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TBCodigo.Text = DataGridView1.Item(0, e.RowIndex).Value
        TBNombrePvendedor.Text = DataGridView1.Item(2, e.RowIndex).Value
        CBcategoriaPvendedor.Text = DataGridView1.Item(1, e.RowIndex).Value
        TBPrecioPvendedor.Text = DataGridView1.Item(3, e.RowIndex).Value
        TBStockPvendedor.Text = DataGridView1.Item(4, e.RowIndex).Value
        TBActivo.Text = DataGridView1.Item(4, e.RowIndex).Value
    End Sub
#End Region

#Region "Solo letras Nombre Producto Vendedor"
    Private Sub TBNombrePvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombrePvendedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo numeros Precio Vendedor"
    Private Sub TBPrecioPvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPrecioPvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo numeros Stock Producto Vendedor"
    Private Sub TBStockPvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStockPvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo letras Nombre2 Producto Vendedor"
    Private Sub TBNombre2Pvendedor_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloLetras(e)
    End Sub
#End Region

#Region "Buscar Producto por nombre"
    Private Sub ICBBuscar_Click(sender As Object, e As EventArgs) Handles ICBBuscar.Click
        If ComboBox2.Text = "Todos" Then
            obj.llenarDataGridview(DataGridView1)
        ElseIf ComboBox2.Text = "Categoria" Then
            Dim dtpro1 = obj.BuscarProductosPorCategoria(TBCodigo2.Text)
            DataGridView1.DataSource = dtpro1
        ElseIf ComboBox2.Text = "Codigo" Then
            Dim dtpro1 = obj.BuscarProductosPorCodigo(TBCodigo2.Text)
            DataGridView1.DataSource = dtpro1
        Else
            Dim dtpro1 = obj.BuscarProductosPorNombre(TBCodigo2.Text)
            DataGridView1.DataSource = dtpro1
        End If
    End Sub
#End Region

End Class