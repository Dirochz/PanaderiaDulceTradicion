Public Class Menuu
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        AgregarPro.Show()
        Me.Hide()
    End Sub

    Private Sub bo_borrar_Click(sender As Object, e As EventArgs) Handles bo_borrar.Click
        Borrar.Show()
        Me.Hide()
    End Sub

    Private Sub bo_vis_Click(sender As Object, e As EventArgs) Handles bo_vis.Click
        Visualizar.Show()
        Me.Hide()
    End Sub

    Private Sub bo_bus_Click(sender As Object, e As EventArgs) Handles bo_bus.Click
        Buscar.Show()
        Me.Hide()
    End Sub

    Private Sub bo_mod_Click(sender As Object, e As EventArgs) Handles bo_mod.Click
        Modificar.Show()
        Me.Hide()
    End Sub

    Private Sub bo_fac_Click(sender As Object, e As EventArgs) Handles bo_fac.Click
        Factura.show()
        Me.Hide()
    End Sub
End Class
