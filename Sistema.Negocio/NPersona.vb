Imports Sistema.Datos
Imports Sistema.Entidades
Public Class NPersona

    Public Function Listar() As DataTable
        Try
            Dim Datos As New DPesona
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarProveedores() As DataTable
        Try
            Dim Datos As New DPesona
            Dim Tabla As New DataTable
            Tabla = Datos.ListarProveedores()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ListarClientes() As DataTable
        Try
            Dim Datos As New DPesona
            Dim Tabla As New DataTable
            Tabla = Datos.ListarClientes()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(valor As String) As DataTable
        Try
            Dim Datos As New DPesona
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarProveedores(valor As String) As DataTable
        Try
            Dim Datos As New DPesona
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarProveedores(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function BuscarClientes(valor As String) As DataTable
        Try
            Dim Datos As New DPesona
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarClientes(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function Insertar(Obj As Persona) As Boolean
        Try
            Dim Datos As New DPesona
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(Obj As Persona) As Boolean
        Try
            Dim Datos As New DPesona
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DPesona
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
