﻿Imports System.Data.SqlClient
Public Class Login

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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
End Class

