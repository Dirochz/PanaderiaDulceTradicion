Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenido al Sistema")
    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim usua, clave As String

        usua = usuario.Text

        clave = Contraseña.Text

        If usua = "Admin" Then
            If clave = "usuario" Then
                MsgBox("El usuario es correcto")

                Menuu.Show()

                Me.Hide()
            Else
                MsgBox("El usuario es incorrecto")
            End If
        Else
            MsgBox("El usuario es incorrecto")
        End If
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class