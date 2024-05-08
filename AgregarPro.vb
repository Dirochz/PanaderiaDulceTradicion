Imports System.Data.SqlClient
Imports System.Configuration

Public Class AgregarPro
    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles Menu.Click
        Menuu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As SqlConnection

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PanaderiaDulceTradicion.My.MySettings.PasteleriaConnectionString").ConnectionString

        conexion = New SqlConnection(connectionString)
        conexion.Open()

        Dim nom As String = Producto.Text
        Dim tam As String = Tamaño.Text
        Dim can As String = Cantidad.Text
        Dim pre As String = Precio.Text

        Dim cadena As String = "insert into Productos(Nombre,Tamaño,Cantidad,Precio) values ('" & nom & "','" & tam & "','" & can & "','" & pre & "')"
        Dim comando As SqlCommand

        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()

        MessageBox.Show("Los datos se guardaron correctamente")

        Producto.Text = ""
        Tamaño.Text = "Seleccionar"
        Cantidad.Text = ""
        Precio.Text = ""

        conexion.Close()
    End Sub
End Class