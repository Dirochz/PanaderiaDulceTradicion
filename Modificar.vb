Imports System.Configuration
Imports System.Data.SqlClient

Public Class Modificar
    Private Sub bo_bus_Click(sender As Object, e As EventArgs) Handles bo_bus.Click
        Dim conexion As SqlConnection

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PanaderiaDulceTradicion.My.MySettings.PasteleriaConnectionString").ConnectionString

        conexion = New SqlConnection(connectionString)

        conexion.Open()

        Dim cod As String = cod_txt.Text

        Dim cadena As String = "select Nombre, Tamaño, Cantidad, Precio from Productos where ID=" & cod

        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)

        Dim registro As SqlDataReader
        registro = comando.ExecuteReader()

        If registro.Read() Then
            nom_txt.Text = registro("Nombre")
            tam_txt.Text = registro("Tamaño")
            can_txt.Text = registro("Cantidad")
            pre_txt.Text = registro("Precio")
            bo_mod.Enabled = True
        Else
            MessageBox.Show("No existe un artículo con el código ingresado")
        End If
        conexion.Close()
    End Sub

    Private Sub bo_mod_Click(sender As Object, e As EventArgs) Handles bo_mod.Click
        Dim conexion As SqlConnection

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PanaderiaDulceTradicion.My.MySettings.PasteleriaConnectionString").ConnectionString

        conexion = New SqlConnection(connectionString)

        conexion.Open()

        Dim cod As Integer = cod_txt.Text

        Dim nom As String = nom_txt.Text

        Dim tam As String = tam_txt.Text

        Dim can As Integer = can_txt.Text

        Dim pre As Double = pre_txt.Text

        Dim cadena As String = "update Productos set Nombre='" & nom & "', Tamaño='" & tam & "', Cantidad='" & can & "', Precio='" & pre & "' where ID='" & cod & "'"

        Dim comando As SqlCommand

        comando = New SqlCommand(cadena, conexion)

        Dim cant As Integer
        cant = comando.ExecuteNonQuery()

        If cant = 1 Then
            MessageBox.Show("Se modificaron los datos del artículo")

            cod_txt.Text = ""
            nom_txt.Text = ""
            tam_txt.Text = ""
            can_txt.Text = ""
            pre_txt.Text = ""
        Else
            MessageBox.Show("No existe un artículo con el código ingresado")

            cod_txt.Text = ""
        End If
        conexion.Close()

        bo_mod.Enabled = False
    End Sub

    Private Sub bo_sal_Click(sender As Object, e As EventArgs) Handles bo_sal.Click
        Menuu.Show()

        Me.Hide()
    End Sub
End Class