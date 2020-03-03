﻿Imports Sistema.Datos
Imports Sistema.Entidades
Public Class NIngreso
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DIngreso
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(valor As String) As DataTable
        Try
            Dim Datos As New DIngreso
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Anular(Id As Integer) As Boolean
        Try
            Dim Datos As New DIngreso
            Datos.Anular(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Insertar(Obj As Ingreso, Det As DataTable) As Boolean
        Try
            Dim Datos As New DIngreso
            Datos.Insertar(Obj, Det)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


End Class
