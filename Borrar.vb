Imports System.Data.SqlClient
Public Class Borrar
    Private conexion As New SqlConnection("server=LAPTOP-L743C0KB; database=Panaderia; integrated security = true")

    Private Sub boMenu_Click(sender As Object, e As EventArgs) Handles boMenu.Click
        Menuu.Show()
        Me.Hide()
    End Sub

    Private Sub bo_Buscar_Click(sender As Object, e As EventArgs) Handles bo_Buscar.Click
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
            bo_borrar.Enabled = True
        Else
            MessageBox.Show("No existe un artículo con el código ingresado")
        End If
        conexion.Close()
    End Sub

    Private Sub bo_borrar_Click(sender As Object, e As EventArgs) Handles bo_borrar.Click
        conexion.Open()

        Dim cod As String = codigo_txt.Text

        Dim cadena As String = "delete from Productos where ID=" & cod

        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)

        Dim cant As Integer

        cant = comando.ExecuteNonQuery()

        If cant = 1 Then
            codigo_txt.Text = ""
            nom_lb.Text = ""
            tam_lb.Text = ""
            can_lb.Text = ""
            pre_lb.Text = ""
            MessageBox.Show("Se borró el artículo")
        Else
            MessageBox.Show("No existe un artículo con el código ingresado")
        End If

        conexion.Close()

        bo_borrar.Enabled = False
    End Sub
End Class