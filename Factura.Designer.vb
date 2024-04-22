<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Me.tot_txt = New System.Windows.Forms.TextBox()
        Me.iva_txt = New System.Windows.Forms.TextBox()
        Me.sub_txt = New System.Windows.Forms.TextBox()
        Me.des_txt = New System.Windows.Forms.TextBox()
        Me.can_txt = New System.Windows.Forms.TextBox()
        Me.pre_txt = New System.Windows.Forms.TextBox()
        Me.fec_txt = New System.Windows.Forms.TextBox()
        Me.rfc_txt = New System.Windows.Forms.TextBox()
        Me.nom_txt = New System.Windows.Forms.TextBox()
        Me.pro_com = New System.Windows.Forms.ComboBox()
        Me.bo_sal = New System.Windows.Forms.Button()
        Me.bo_lim = New System.Windows.Forms.Button()
        Me.bo_cob = New System.Windows.Forms.Button()
        Me.tim_lb = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tot_txt
        '
        Me.tot_txt.BackColor = System.Drawing.Color.Bisque
        Me.tot_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tot_txt.Location = New System.Drawing.Point(529, 222)
        Me.tot_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tot_txt.Name = "tot_txt"
        Me.tot_txt.Size = New System.Drawing.Size(76, 30)
        Me.tot_txt.TabIndex = 51
        '
        'iva_txt
        '
        Me.iva_txt.BackColor = System.Drawing.Color.Bisque
        Me.iva_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iva_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.iva_txt.Location = New System.Drawing.Point(393, 222)
        Me.iva_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.iva_txt.Name = "iva_txt"
        Me.iva_txt.Size = New System.Drawing.Size(76, 30)
        Me.iva_txt.TabIndex = 50
        '
        'sub_txt
        '
        Me.sub_txt.BackColor = System.Drawing.Color.Bisque
        Me.sub_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.sub_txt.Location = New System.Drawing.Point(260, 222)
        Me.sub_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.sub_txt.Name = "sub_txt"
        Me.sub_txt.Size = New System.Drawing.Size(86, 30)
        Me.sub_txt.TabIndex = 49
        '
        'des_txt
        '
        Me.des_txt.BackColor = System.Drawing.Color.Bisque
        Me.des_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.des_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.des_txt.Location = New System.Drawing.Point(88, 222)
        Me.des_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.des_txt.Name = "des_txt"
        Me.des_txt.Size = New System.Drawing.Size(84, 30)
        Me.des_txt.TabIndex = 48
        '
        'can_txt
        '
        Me.can_txt.BackColor = System.Drawing.Color.Bisque
        Me.can_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.can_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.can_txt.Location = New System.Drawing.Point(379, 160)
        Me.can_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.can_txt.Name = "can_txt"
        Me.can_txt.Size = New System.Drawing.Size(90, 30)
        Me.can_txt.TabIndex = 47
        '
        'pre_txt
        '
        Me.pre_txt.BackColor = System.Drawing.Color.Bisque
        Me.pre_txt.Enabled = False
        Me.pre_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pre_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.pre_txt.Location = New System.Drawing.Point(135, 160)
        Me.pre_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pre_txt.Name = "pre_txt"
        Me.pre_txt.Size = New System.Drawing.Size(104, 30)
        Me.pre_txt.TabIndex = 46
        '
        'fec_txt
        '
        Me.fec_txt.BackColor = System.Drawing.Color.Bisque
        Me.fec_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fec_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.fec_txt.Location = New System.Drawing.Point(379, 108)
        Me.fec_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.fec_txt.Name = "fec_txt"
        Me.fec_txt.Size = New System.Drawing.Size(122, 30)
        Me.fec_txt.TabIndex = 45
        '
        'rfc_txt
        '
        Me.rfc_txt.BackColor = System.Drawing.Color.Bisque
        Me.rfc_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rfc_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.rfc_txt.Location = New System.Drawing.Point(379, 66)
        Me.rfc_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rfc_txt.Name = "rfc_txt"
        Me.rfc_txt.Size = New System.Drawing.Size(90, 30)
        Me.rfc_txt.TabIndex = 43
        '
        'nom_txt
        '
        Me.nom_txt.BackColor = System.Drawing.Color.Bisque
        Me.nom_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.nom_txt.Location = New System.Drawing.Point(135, 61)
        Me.nom_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nom_txt.Name = "nom_txt"
        Me.nom_txt.Size = New System.Drawing.Size(159, 30)
        Me.nom_txt.TabIndex = 42
        '
        'pro_com
        '
        Me.pro_com.BackColor = System.Drawing.Color.Bisque
        Me.pro_com.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pro_com.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_com.ForeColor = System.Drawing.SystemColors.Desktop
        Me.pro_com.FormattingEnabled = True
        Me.pro_com.Items.AddRange(New Object() {"Seleccionar"})
        Me.pro_com.Location = New System.Drawing.Point(135, 108)
        Me.pro_com.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pro_com.Name = "pro_com"
        Me.pro_com.Size = New System.Drawing.Size(159, 31)
        Me.pro_com.TabIndex = 41
        Me.pro_com.Text = "Seleccionar"
        '
        'bo_sal
        '
        Me.bo_sal.BackColor = System.Drawing.Color.Bisque
        Me.bo_sal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_sal.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_sal.ForeColor = System.Drawing.SystemColors.Desktop
        Me.bo_sal.Location = New System.Drawing.Point(393, 292)
        Me.bo_sal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bo_sal.Name = "bo_sal"
        Me.bo_sal.Size = New System.Drawing.Size(97, 33)
        Me.bo_sal.TabIndex = 40
        Me.bo_sal.Text = "Salir"
        Me.bo_sal.UseVisualStyleBackColor = False
        '
        'bo_lim
        '
        Me.bo_lim.BackColor = System.Drawing.Color.Bisque
        Me.bo_lim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_lim.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_lim.ForeColor = System.Drawing.SystemColors.Desktop
        Me.bo_lim.Location = New System.Drawing.Point(256, 292)
        Me.bo_lim.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bo_lim.Name = "bo_lim"
        Me.bo_lim.Size = New System.Drawing.Size(97, 33)
        Me.bo_lim.TabIndex = 39
        Me.bo_lim.Text = "Limpiar"
        Me.bo_lim.UseVisualStyleBackColor = False
        '
        'bo_cob
        '
        Me.bo_cob.BackColor = System.Drawing.Color.Bisque
        Me.bo_cob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_cob.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_cob.ForeColor = System.Drawing.SystemColors.Desktop
        Me.bo_cob.Location = New System.Drawing.Point(120, 292)
        Me.bo_cob.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bo_cob.Name = "bo_cob"
        Me.bo_cob.Size = New System.Drawing.Size(97, 33)
        Me.bo_cob.TabIndex = 38
        Me.bo_cob.Text = "Cobrar"
        Me.bo_cob.UseVisualStyleBackColor = False
        '
        'tim_lb
        '
        Me.tim_lb.AutoSize = True
        Me.tim_lb.BackColor = System.Drawing.Color.Transparent
        Me.tim_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tim_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tim_lb.Location = New System.Drawing.Point(275, 0)
        Me.tim_lb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tim_lb.Name = "tim_lb"
        Me.tim_lb.Size = New System.Drawing.Size(71, 23)
        Me.tim_lb.TabIndex = 37
        Me.tim_lb.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label11.Location = New System.Drawing.Point(477, 227)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 23)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Location = New System.Drawing.Point(349, 227)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 23)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "IVA:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(176, 227)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 23)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Sub Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(4, 227)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Descuento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(303, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 23)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Cantidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(70, 165)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Precio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(323, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(51, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(338, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "RFC:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(4, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre Cliente:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.copcake
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(504, 66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 133)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.chocolate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(619, 346)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tot_txt)
        Me.Controls.Add(Me.iva_txt)
        Me.Controls.Add(Me.sub_txt)
        Me.Controls.Add(Me.des_txt)
        Me.Controls.Add(Me.can_txt)
        Me.Controls.Add(Me.pre_txt)
        Me.Controls.Add(Me.fec_txt)
        Me.Controls.Add(Me.rfc_txt)
        Me.Controls.Add(Me.nom_txt)
        Me.Controls.Add(Me.pro_com)
        Me.Controls.Add(Me.bo_sal)
        Me.Controls.Add(Me.bo_lim)
        Me.Controls.Add(Me.bo_cob)
        Me.Controls.Add(Me.tim_lb)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tot_txt As TextBox
    Friend WithEvents iva_txt As TextBox
    Friend WithEvents sub_txt As TextBox
    Friend WithEvents des_txt As TextBox
    Friend WithEvents can_txt As TextBox
    Friend WithEvents pre_txt As TextBox
    Friend WithEvents fec_txt As TextBox
    Friend WithEvents rfc_txt As TextBox
    Friend WithEvents nom_txt As TextBox
    Friend WithEvents pro_com As ComboBox
    Friend WithEvents bo_sal As Button
    Friend WithEvents bo_lim As Button
    Friend WithEvents bo_cob As Button
    Friend WithEvents tim_lb As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
