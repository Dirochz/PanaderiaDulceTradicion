Imports System.Data.SqlClient

Public Class Factura

    Dim contador As Integer
    Dim cargarPantalla = 0

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strcomando As String

        Dim adapter As SqlDataAdapter

        Dim conexion As String

        Dim Data = New DataSet

        conexion = "server=LAPTOP-L743C0KB; database=Panaderia; integrated security = true"

        strcomando = "Select ID,Nombre from Productos"

        adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion)
        adapter.Fill(Data)

        pro_com.DataSource = Data.Tables(0)
        pro_com.DisplayMember = "Nombre"
        pro_com.ValueMember = "Nombre"

        desactivarControles()

        fec_txt.Text = Date.Today

        contador = 1500

        Me.tim_lb.Text = contador

        Me.Timer1.Enabled = True

        pro_com.Text = "Seleccionar"

        cargarPantalla = 1

    End Sub

    Private Sub bo_sal_Click(sender As Object, e As EventArgs) Handles bo_sal.Click
        Menuu.Show()
        Me.Hide()
    End Sub

    Private Sub bo_cob_Click(sender As Object, e As EventArgs) Handles bo_cob.Click

        sub_txt.Text = (Val(can_txt.Text)) * (Val(pre_txt.Text))

        If sub_txt.Text >= 3000 Then
            des_txt.Text = (Val(sub_txt.Text) * 0.05)
        Else
            sub_txt.Text = sub_txt.Text
            des_txt.Text = 0
        End If

        iva_txt.Text = (Val(sub_txt.Text) * 0.16)
        tot_txt.Text = (Val(sub_txt.Text) - Val(des_txt.Text) + Val(iva_txt.Text))

        Dim conexion As SqlConnection

        conexion = New SqlConnection("server=LAPTOP-L743C0KB; database=Panaderia; integrated security = true")

        conexion.Open()

        Dim nom As String = nom_txt.Text
        Dim rfc As String = rfc_txt.Text
        Dim prod As String = pro_com.Text
        Dim fe As String = Date.Today
        Dim pre As String = pre_txt.Text
        Dim can As String = can_txt.Text
        Dim des As String = des_txt.Text
        Dim subt As String = sub_txt.Text
        Dim iva As String = iva_txt.Text
        Dim total As String = tot_txt.Text

        Dim cadena As String = "insert into Factura(Nombre,RFC,Producto,Fecha,Precio,Cantidad,Descuento,Subtotal,IVA,Total) values ('" & nom & "','" & rfc & "','" & prod & "','" & fe & "','" & pre & "','" & can & "','" & des & "','" & subt & "','" & iva & "','" & total & "')"

        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()

        MessageBox.Show("Se creo una Factura Exitosamente")

        conexion.Close()
    End Sub

    Private Sub bo_lim_Click(sender As Object, e As EventArgs) Handles bo_lim.Click
        nom_txt.Clear()
        rfc_txt.Clear()
        pro_com.Text = "Seleccionar"
        pre_txt.Clear()
        can_txt.Clear()
        des_txt.Clear()
        sub_txt.Clear()
        iva_txt.Clear()
        tot_txt.Clear()
    End Sub

    Private Sub desactivarControles()
        fec_txt.Enabled = False
        des_txt.Enabled = False
        sub_txt.Enabled = False
        iva_txt.Enabled = False
        tot_txt.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador = contador - 1

        Me.tim_lb.Text = contador

        If contador = 0 Then
            Me.Timer1.Enabled = False

            MsgBox("El tiempo de captura ha terminado")

            Menuu.Show()

            Me.Hide()
        End If
    End Sub

    Private Sub Pro_com_TextChanged(sender As Object, e As EventArgs) Handles pro_com.TextChanged
        If pro_com.Text <> "Seleccionar" And pro_com.Text <> "" And cargarPantalla = 1 Then

            pre_txt.Enabled = True

            Dim conexion As SqlConnection

            conexion = New SqlConnection("server=LAPTOP-L743C0KB ; database=Panaderia; integrated security = true")

            conexion.Open()

            Dim cod As String = pro_com.Text

            Dim cadena As String = "select Precio from Productos where Nombre= '" & cod & "'"

            Dim comando As SqlCommand
            comando = New SqlCommand(cadena, conexion)

            Dim registro As SqlDataReader

            registro = comando.ExecuteReader()
            If registro.Read() Then
                pre_txt.Text = registro("Precio")
            Else

            End If

            conexion.Close()

            pre_txt.Enabled = False
        End If
    End Sub
End Class