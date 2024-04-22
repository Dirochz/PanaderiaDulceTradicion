<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Borrar))
        Me.bo_Buscar = New System.Windows.Forms.Button()
        Me.bo_borrar = New System.Windows.Forms.Button()
        Me.boMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nom_lb = New System.Windows.Forms.Label()
        Me.tam_lb = New System.Windows.Forms.Label()
        Me.codigo_txt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.can_lb = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pre_lb = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bo_Buscar
        '
        Me.bo_Buscar.BackColor = System.Drawing.Color.Bisque
        Me.bo_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_Buscar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_Buscar.Location = New System.Drawing.Point(487, 105)
        Me.bo_Buscar.Name = "bo_Buscar"
        Me.bo_Buscar.Size = New System.Drawing.Size(122, 42)
        Me.bo_Buscar.TabIndex = 0
        Me.bo_Buscar.Text = "Buscar"
        Me.bo_Buscar.UseVisualStyleBackColor = False
        '
        'bo_borrar
        '
        Me.bo_borrar.BackColor = System.Drawing.Color.Bisque
        Me.bo_borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_borrar.Enabled = False
        Me.bo_borrar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_borrar.Location = New System.Drawing.Point(143, 376)
        Me.bo_borrar.Name = "bo_borrar"
        Me.bo_borrar.Size = New System.Drawing.Size(122, 42)
        Me.bo_borrar.TabIndex = 1
        Me.bo_borrar.Text = "Borrar"
        Me.bo_borrar.UseVisualStyleBackColor = False
        '
        'boMenu
        '
        Me.boMenu.BackColor = System.Drawing.Color.Bisque
        Me.boMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boMenu.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boMenu.Location = New System.Drawing.Point(463, 376)
        Me.boMenu.Name = "boMenu"
        Me.boMenu.Size = New System.Drawing.Size(122, 42)
        Me.boMenu.TabIndex = 2
        Me.boMenu.Text = "Menú"
        Me.boMenu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(221, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tamaño:"
        '
        'nom_lb
        '
        Me.nom_lb.AutoSize = True
        Me.nom_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_lb.Location = New System.Drawing.Point(339, 167)
        Me.nom_lb.Name = "nom_lb"
        Me.nom_lb.Size = New System.Drawing.Size(104, 29)
        Me.nom_lb.TabIndex = 6
        Me.nom_lb.Text = "_______"
        '
        'tam_lb
        '
        Me.tam_lb.AutoSize = True
        Me.tam_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tam_lb.Location = New System.Drawing.Point(339, 227)
        Me.tam_lb.Name = "tam_lb"
        Me.tam_lb.Size = New System.Drawing.Size(104, 29)
        Me.tam_lb.TabIndex = 7
        Me.tam_lb.Text = "_______"
        '
        'codigo_txt
        '
        Me.codigo_txt.BackColor = System.Drawing.Color.Bisque
        Me.codigo_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo_txt.Location = New System.Drawing.Point(325, 112)
        Me.codigo_txt.Name = "codigo_txt"
        Me.codigo_txt.Size = New System.Drawing.Size(129, 35)
        Me.codigo_txt.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.pastel
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(519, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 223)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.copcake
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(156, 200)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cantidad:"
        '
        'can_lb
        '
        Me.can_lb.AutoSize = True
        Me.can_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.can_lb.Location = New System.Drawing.Point(339, 285)
        Me.can_lb.Name = "can_lb"
        Me.can_lb.Size = New System.Drawing.Size(104, 29)
        Me.can_lb.TabIndex = 7
        Me.can_lb.Text = "_______"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(238, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio:"
        '
        'pre_lb
        '
        Me.pre_lb.AutoSize = True
        Me.pre_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pre_lb.Location = New System.Drawing.Point(339, 334)
        Me.pre_lb.Name = "pre_lb"
        Me.pre_lb.Size = New System.Drawing.Size(104, 29)
        Me.pre_lb.TabIndex = 7
        Me.pre_lb.Text = "_______"
        '
        'Borrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.chocolate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(791, 442)
        Me.Controls.Add(Me.boMenu)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.codigo_txt)
        Me.Controls.Add(Me.pre_lb)
        Me.Controls.Add(Me.can_lb)
        Me.Controls.Add(Me.tam_lb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nom_lb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bo_borrar)
        Me.Controls.Add(Me.bo_Buscar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Borrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bo_Buscar As Button
    Friend WithEvents bo_borrar As Button
    Friend WithEvents boMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nom_lb As Label
    Friend WithEvents tam_lb As Label
    Friend WithEvents codigo_txt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents can_lb As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pre_lb As Label
End Class
