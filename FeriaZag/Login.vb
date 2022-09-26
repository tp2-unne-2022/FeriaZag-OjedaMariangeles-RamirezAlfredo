﻿Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Login
    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Public cnx As New SqlConnection("Data Source=DESKTOP-2715FLN\SQLEXPRESS;Initial Catalog=FeriaZag;Integrated Security=True")
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable

#End Region

#Region "Base de datos"
    Public Sub Conectar()
        Try
            cnx.Open()
        Catch ex As Exception
            MsgBox("No conectado" + ex.ToString)
        End Try
    End Sub

#End Region

#Region "Boton Ingresar"
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim User, pass As String
        User = tbUsuario.Text
        pass = tbContraseña.Text
        If User = "Admin" And pass = "1234" Then
            MsgBox("Bienvenido Administrador al Sistema de Feria Zag")
            Administrador.Show()
            Me.Hide()
        Else

        End If

        Dim User2, pass2 As String
        User2 = tbUsuario.Text
        pass2 = tbContraseña.Text
        If User = "Vendedor" And pass = "56789" Then
            MsgBox("Bienvenido Vendedor al Sistema de Feria Zag")
            Vendedor.Show()
            Me.Hide()
        End If
        tbUsuario.Text = ""
        tbContraseña.Text = ""
    End Sub
#End Region

#Region "EliminarProducto"
    Public Function EliminarProducto(codigo As String)
        Dim eliminar As New SqlCommand("EliminarProductos", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@Codigo", codigo)
        Dim resp As Integer
        Try
            resp = eliminar.ExecuteNonQuery
            MsgBox("Eliminado con exito " + codigo)
        Catch ex As Exception
            MsgBox("Error al eliminar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "llenarDataGridView"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select Productos.Codigo,Producto,IdCategoria, Precio,Stock from Productos", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "listarCategoria"
    Public Function ListarCategoria() As DataTable
        Dim da As New SqlDataAdapter("select Categoria.IdCategoria,Categoria from Categoria", cnx)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl
    End Function
#End Region

#Region "ModificarProducto"
    Public Function ModificarProducto(codigo As String, producto As String, idcategoria As String, precio As Decimal, stock As Integer)
        Dim modificar As New SqlCommand("ModificarProductos", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@Codigo", codigo)
        modificar.Parameters.AddWithValue("@Producto", producto)
        modificar.Parameters.AddWithValue("@IdCategoria", idcategoria)
        modificar.Parameters.AddWithValue("@Precio", precio)
        modificar.Parameters.AddWithValue("@Stock", stock)
        Dim resp As Integer
        Try
            resp = modificar.ExecuteNonQuery
            MsgBox("Modificado con exito " + codigo)
        Catch ex As Exception
            MsgBox("Error al modificar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "RegistrarProducto"
    Public Function RegistrarProducto(nombreproducto As String, idcategoria As String, precio As Decimal, stock As Integer)
        Dim da As New SqlCommand("RegistrarProductos", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Producto", nombreproducto)
        da.Parameters.AddWithValue("@IdCategoria", idcategoria)
        da.Parameters.AddWithValue("@Precio", precio)
        da.Parameters.AddWithValue("@Stock", stock)
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            MsgBox("Registrador con exito " + nombreproducto)
        Catch ex As Exception
            MsgBox("Error al registrar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "BuscarProducto"
    Public Function BuscarProductos(nombreproducto As String, idcategoria As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("select Productos.Producto,IdCategoria from Productos", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Producto", nombreproducto)
        cmd.Parameters.AddWithValue("@IdCategoria", idcategoria)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function

#End Region
End Class

