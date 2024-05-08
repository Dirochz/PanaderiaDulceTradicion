Imports System.Configuration
Imports System.Data.SqlClient

Public Class Buscar
    Private Sub bo_Buscar_Click(sender As Object, e As EventArgs) Handles bo_Buscar.Click
        Dim conexion As SqlConnection

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PanaderiaDulceTradicion.My.MySettings.PasteleriaConnectionString").ConnectionString

        conexion = New SqlConnection(connectionString)

        conexion.Open()

        Dim cod As String = codigo_txt.Text

        Dim cadena As String = "select Nombre, Tamaño, Cantidad, Precio from Productos where ID=" & cod

        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)

        Dim registro As SqlDataReader

        registro = comando.ExecuteReader()
        If registro.Read() Then
            nom_lb.Text = registro("Nombre")
            tam_lb.Text = registro("Tamaño")
            can_lb.Text = registro("Cantidad")
            pre_lb.Text = registro("Precio")
        Else
            MessageBox.Show("No existe un artículo con el código ingresado")
            codigo_txt.Text = ""
        End If

        conexion.Close()
    End Sub

    Private Sub boMenu_Click(sender As Object, e As EventArgs) Handles boMenu.Click
        Menuu.Show()
        Me.Hide()
    End Sub
End Class