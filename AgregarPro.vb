Imports System.Data.SqlClient
Public Class AgregarPro
    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles Menu.Click
        Menuu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As SqlConnection

        conexion = New SqlConnection("server=LAPTOP-L743C0KB; database=Panaderia; integrated security = true")
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