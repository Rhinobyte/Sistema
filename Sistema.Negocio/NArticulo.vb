Imports Sistema.Datos
Imports Sistema.Entidades
Public Class NArticulo
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DArticulo
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
            Dim Datos As New DArticulo
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function BuscarVenta(valor As String) As DataTable
        Try
            Dim Datos As New DArticulo
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarVenta(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function BuscarCodigo(valor As String) As Articulo
        Try
            Dim Datos As New DArticulo
            Dim Tabla As New DataTable
            Dim Art As New Articulo

            Tabla = Datos.BuscarCodigo(valor)
            If (Tabla.Rows.Count > 0) Then
                Art.IdArticulo = Tabla.Rows(0).Item(0).ToString
                Art.Codigo = Tabla.Rows(0).Item(1).ToString
                Art.Nombre = Tabla.Rows(0).Item(2).ToString
                Art.PrecioVenta = Tabla.Rows(0).Item(3).ToString
                Art.Stock = Tabla.Rows(0).Item(4).ToString
                Return Art
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function BuscarCodigoVenta(valor As String) As Articulo
        Try
            Dim Datos As New DArticulo
            Dim Tabla As New DataTable
            Dim Art As New Articulo

            Tabla = Datos.BuscarCodigoVenta(valor)
            If (Tabla.Rows.Count > 0) Then
                Art.IdArticulo = Tabla.Rows(0).Item(0).ToString
                Art.Codigo = Tabla.Rows(0).Item(1).ToString
                Art.Nombre = Tabla.Rows(0).Item(2).ToString
                Art.PrecioVenta = Tabla.Rows(0).Item(3).ToString
                Art.Stock = Tabla.Rows(0).Item(4).ToString
                Return Art
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(Obj As Articulo) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(Obj As Articulo) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Desactivar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
