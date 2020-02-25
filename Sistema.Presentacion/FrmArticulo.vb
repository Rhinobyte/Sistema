Imports System.IO
Public Class FrmArticulo
    Private RutaOrigen As String
    Private RutaDestino As String
    Private Directorio As String = "C:\Users\joelisaac.garcia\Documents\CursoUdemy\"
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Width = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(3).Width = 400
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 150
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 200
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NArticulo
            DgvListado.DataSource = Neg.Listar()
            LblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
            ChkSeleccionar.CheckState = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NArticulo
            Dim Valor As String
            Valor = TxtValor.Text

            DgvListado.DataSource = Neg.Buscar(Valor)
            LblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        BtnInsertar.Visible = True
        BtnActualizar.Visible = False
        TxtValor.Text = ""
        TxtId.Text = ""
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""
        TxtCodigo.Text = ""
        TxtPrecioVenta.Text = ""
        TxtStock.Text = ""
        TxtImagen.Text = ""
        PicImagen.Image = Nothing
    End Sub

    Private Sub CargarCategoria()
        Try
            Dim Neg As New Negocio.NCategoria
            CboCategoria.DataSource = Neg.Seleccionar
            CboCategoria.ValueMember = "idcategoria"
            CboCategoria.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CargarCategoria()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        Dim File As New OpenFileDialog
        File.Filter = "Image Files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png;"
        If File.ShowDialog() = DialogResult.OK Then
            PicImagen.Image = Image.FromFile(File.FileName)
            RutaOrigen = File.FileName
            TxtImagen.Text = File.FileName.Substring(File.FileName.LastIndexOf("\") + 1)
        End If
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            If Me.ValidateChildren = True And CboCategoria.Text <> "" And TxtNombre.Text <> "" And TxtPrecioVenta.Text <> "" And TxtStock.Text <> "" Then
                Dim Obj As New Entidades.Articulo
                Dim Neg As New Negocio.NArticulo

                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Codigo = TxtCodigo.Text
                Obj.Nombre = TxtNombre.Text
                Obj.PrecioVenta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Imagen = TxtImagen.Text
                Obj.Descripcion = TxtDescripcion.Text

                If (Neg.Insertar(Obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    If (TxtImagen.Text <> "") Then

                        RutaDestino = Directorio & TxtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)
                    End If
                    Me.Listar()
                Else
                    MsgBox("No se ha podido registrar", vbReadOnly + vbCritical, "Registro incorrecto")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios(*)", vbOKOnly + vbCritical, "Falta ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub
End Class