<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar))
        Me.cod_lb = New System.Windows.Forms.Label()
        Me.nom_lb = New System.Windows.Forms.Label()
        Me.tam_lb = New System.Windows.Forms.Label()
        Me.can_lb = New System.Windows.Forms.Label()
        Me.cod_txt = New System.Windows.Forms.TextBox()
        Me.nom_txt = New System.Windows.Forms.TextBox()
        Me.tam_txt = New System.Windows.Forms.TextBox()
        Me.can_txt = New System.Windows.Forms.TextBox()
        Me.bo_bus = New System.Windows.Forms.Button()
        Me.bo_mod = New System.Windows.Forms.Button()
        Me.pre_lb = New System.Windows.Forms.Label()
        Me.pre_txt = New System.Windows.Forms.TextBox()
        Me.bo_sal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cod_lb
        '
        Me.cod_lb.AutoSize = True
        Me.cod_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_lb.Location = New System.Drawing.Point(243, 103)
        Me.cod_lb.Name = "cod_lb"
        Me.cod_lb.Size = New System.Drawing.Size(85, 29)
        Me.cod_lb.TabIndex = 0
        Me.cod_lb.Text = "Codigo:"
        '
        'nom_lb
        '
        Me.nom_lb.AutoSize = True
        Me.nom_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_lb.Location = New System.Drawing.Point(230, 157)
        Me.nom_lb.Name = "nom_lb"
        Me.nom_lb.Size = New System.Drawing.Size(98, 29)
        Me.nom_lb.TabIndex = 1
        Me.nom_lb.Text = "Nombre:"
        '
        'tam_lb
        '
        Me.tam_lb.AutoSize = True
        Me.tam_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tam_lb.Location = New System.Drawing.Point(233, 209)
        Me.tam_lb.Name = "tam_lb"
        Me.tam_lb.Size = New System.Drawing.Size(95, 29)
        Me.tam_lb.TabIndex = 2
        Me.tam_lb.Text = "Tamaño:"
        '
        'can_lb
        '
        Me.can_lb.AutoSize = True
        Me.can_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.can_lb.Location = New System.Drawing.Point(223, 266)
        Me.can_lb.Name = "can_lb"
        Me.can_lb.Size = New System.Drawing.Size(105, 29)
        Me.can_lb.TabIndex = 3
        Me.can_lb.Text = "Cantidad:"
        '
        'cod_txt
        '
        Me.cod_txt.BackColor = System.Drawing.Color.Bisque
        Me.cod_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_txt.Location = New System.Drawing.Point(358, 97)
        Me.cod_txt.Name = "cod_txt"
        Me.cod_txt.Size = New System.Drawing.Size(121, 35)
        Me.cod_txt.TabIndex = 4
        '
        'nom_txt
        '
        Me.nom_txt.BackColor = System.Drawing.Color.Bisque
        Me.nom_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_txt.Location = New System.Drawing.Point(358, 151)
        Me.nom_txt.Name = "nom_txt"
        Me.nom_txt.Size = New System.Drawing.Size(192, 35)
        Me.nom_txt.TabIndex = 5
        '
        'tam_txt
        '
        Me.tam_txt.BackColor = System.Drawing.Color.Bisque
        Me.tam_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tam_txt.Location = New System.Drawing.Point(358, 203)
        Me.tam_txt.Name = "tam_txt"
        Me.tam_txt.Size = New System.Drawing.Size(121, 35)
        Me.tam_txt.TabIndex = 6
        '
        'can_txt
        '
        Me.can_txt.BackColor = System.Drawing.Color.Bisque
        Me.can_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.can_txt.Location = New System.Drawing.Point(358, 260)
        Me.can_txt.Name = "can_txt"
        Me.can_txt.Size = New System.Drawing.Size(121, 35)
        Me.can_txt.TabIndex = 7
        '
        'bo_bus
        '
        Me.bo_bus.BackColor = System.Drawing.Color.Bisque
        Me.bo_bus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_bus.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_bus.Location = New System.Drawing.Point(529, 89)
        Me.bo_bus.Name = "bo_bus"
        Me.bo_bus.Size = New System.Drawing.Size(129, 43)
        Me.bo_bus.TabIndex = 8
        Me.bo_bus.Text = "Buscar"
        Me.bo_bus.UseVisualStyleBackColor = False
        '
        'bo_mod
        '
        Me.bo_mod.BackColor = System.Drawing.Color.Bisque
        Me.bo_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_mod.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_mod.Location = New System.Drawing.Point(228, 420)
        Me.bo_mod.Name = "bo_mod"
        Me.bo_mod.Size = New System.Drawing.Size(129, 43)
        Me.bo_mod.TabIndex = 9
        Me.bo_mod.Text = "Modificar"
        Me.bo_mod.UseVisualStyleBackColor = False
        '
        'pre_lb
        '
        Me.pre_lb.AutoSize = True
        Me.pre_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pre_lb.Location = New System.Drawing.Point(247, 329)
        Me.pre_lb.Name = "pre_lb"
        Me.pre_lb.Size = New System.Drawing.Size(81, 29)
        Me.pre_lb.TabIndex = 3
        Me.pre_lb.Text = "Precio:"
        '
        'pre_txt
        '
        Me.pre_txt.BackColor = System.Drawing.Color.Bisque
        Me.pre_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pre_txt.Location = New System.Drawing.Point(358, 323)
        Me.pre_txt.Name = "pre_txt"
        Me.pre_txt.Size = New System.Drawing.Size(121, 35)
        Me.pre_txt.TabIndex = 7
        '
        'bo_sal
        '
        Me.bo_sal.BackColor = System.Drawing.Color.Bisque
        Me.bo_sal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_sal.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_sal.Location = New System.Drawing.Point(442, 420)
        Me.bo_sal.Name = "bo_sal"
        Me.bo_sal.Size = New System.Drawing.Size(129, 43)
        Me.bo_sal.TabIndex = 9
        Me.bo_sal.Text = "Salir"
        Me.bo_sal.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.pastel
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 179)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.copcake
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(611, 179)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 193)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.pastelito
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(-21, 294)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(218, 182)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.chocolate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(812, 475)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bo_sal)
        Me.Controls.Add(Me.bo_mod)
        Me.Controls.Add(Me.bo_bus)
        Me.Controls.Add(Me.pre_txt)
        Me.Controls.Add(Me.can_txt)
        Me.Controls.Add(Me.tam_txt)
        Me.Controls.Add(Me.nom_txt)
        Me.Controls.Add(Me.pre_lb)
        Me.Controls.Add(Me.cod_txt)
        Me.Controls.Add(Me.can_lb)
        Me.Controls.Add(Me.tam_lb)
        Me.Controls.Add(Me.nom_lb)
        Me.Controls.Add(Me.cod_lb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cod_lb As Label
    Friend WithEvents nom_lb As Label
    Friend WithEvents tam_lb As Label
    Friend WithEvents can_lb As Label
    Friend WithEvents cod_txt As TextBox
    Friend WithEvents nom_txt As TextBox
    Friend WithEvents tam_txt As TextBox
    Friend WithEvents can_txt As TextBox
    Friend WithEvents bo_bus As Button
    Friend WithEvents bo_mod As Button
    Friend WithEvents pre_lb As Label
    Friend WithEvents pre_txt As TextBox
    Friend WithEvents bo_sal As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
