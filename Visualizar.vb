Imports System.Configuration
Imports System.Data.SqlClient

Public Class Visualizar
    Private Sub bo_salir_Click(sender As Object, e As EventArgs) Handles bo_salir.Click
        Menuu.Show()

        Me.Hide()

        tabla.Clear()

        tab_com.Text = "Seleccionar"

        info_lb.Text = ""
    End Sub

    Private Sub bo_rec_Click(sender As Object, e As EventArgs) Handles bo_rec.Click
        Dim op As String
        op = tab_com.Text

        tabla.Clear()
        Select Case (op)
            Case "Producto"
                info_lb.Text = "ID - Nombre - Tamaño - Cantidad - Precio"

                Dim conexion As SqlConnection

                Dim connectionString As String = ConfigurationManager.ConnectionStrings("PanaderiaDulceTradicion.My.MySettings.PasteleriaConnectionString").ConnectionString

                conexion = New SqlConnection(connectionString)

                conexion.Open()

                Dim cadena As String = "Select ID, Nombre, Tamaño, Cantidad, Precio from Productos"

                Dim comando As SqlCommand
                comando = New SqlCommand(cadena, conexion)

                Dim registros As SqlDataReader
                registros = comando.ExecuteReader()

                Do While registros.Read() = True
                    tabla.AppendText(registros("ID"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Nombre"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Tamaño"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Cantidad"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Precio"))
                    tabla.AppendText(vbCrLf)
                Loop

                conexion.Close()

            Case "Factura"
                info_lb.Text = "ID - Nombre - RFC - Producto - Fecha - Precio - Cantidad - Descuento - Subtotal - IVA - Total"

                Dim conexion As SqlConnection

                Dim connectionString As String = ConfigurationManager.ConnectionStrings("PanaderiaDulceTradicion.My.MySettings.PasteleriaConnectionString").ConnectionString

                conexion = New SqlConnection(connectionString)

                conexion.Open()

                Dim cadena As String = "Select * from Factura"

                Dim comando As SqlCommand
                comando = New SqlCommand(cadena, conexion)

                Dim registros As SqlDataReader
                registros = comando.ExecuteReader()

                Do While registros.Read() = True
                    tabla.AppendText(registros("ID"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Nombre"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("RFC"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Producto"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Fecha"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Precio"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Cantidad"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Descuento"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Subtotal"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("IVA"))
                    tabla.AppendText(" - ")
                    tabla.AppendText(registros("Total"))
                    tabla.AppendText(vbCrLf)
                Loop

                conexion.Close()
        End Select

    End Sub

    Private Sub Visualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        info_lb.Text = ""
    End Sub
End Class