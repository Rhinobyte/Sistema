Imports Sistema.Datos
Imports Sistema.Entidades
Public Class NCategoria
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DCategoria
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
            Dim Datos As New DCategoria
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(Obj As Categoria) As Boolean

    End Function

    Public Function Actualizar(Obj As Categoria) As Boolean

    End Function

    Public Function Eliminar(Id As Integer) As Boolean

    End Function

    Public Function Desactivar(Id As Integer) As Boolean

    End Function

    Public Function Activar(Id As Integer) As Boolean

    End Function
End Class
