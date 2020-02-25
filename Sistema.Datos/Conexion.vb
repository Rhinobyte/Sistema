Imports System.Data.SqlClient
Public Class Conexion

    Public conn As SqlConnection


    Public Sub New()
        Me.conn = New SqlConnection("Data Source=DGI-SF02VMS\SQLEXPRESS;Initial Catalog=nomina;User ID=isaac;Password=Jigz2019")
    End Sub

End Class
