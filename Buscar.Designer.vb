<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buscar))
        Me.boMenu = New System.Windows.Forms.Button()
        Me.codigo_txt = New System.Windows.Forms.TextBox()
        Me.pre_lb = New System.Windows.Forms.Label()
        Me.can_lb = New System.Windows.Forms.Label()
        Me.tam_lb = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nom_lb = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bo_Buscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'boMenu
        '
        Me.boMenu.BackColor = System.Drawing.Color.Bisque
        Me.boMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boMenu.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boMenu.Location = New System.Drawing.Point(248, 379)
        Me.boMenu.Name = "boMenu"
        Me.boMenu.Size = New System.Drawing.Size(122, 42)
        Me.boMenu.TabIndex = 12
        Me.boMenu.Text = "Menú"
        Me.boMenu.UseVisualStyleBackColor = False
        '
        'codigo_txt
        '
        Me.codigo_txt.BackColor = System.Drawing.Color.Bisque
        Me.codigo_txt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo_txt.Location = New System.Drawing.Point(161, 83)
        Me.codigo_txt.Name = "codigo_txt"
        Me.codigo_txt.Size = New System.Drawing.Size(209, 35)
        Me.codigo_txt.TabIndex = 22
        '
        'pre_lb
        '
        Me.pre_lb.AutoSize = True
        Me.pre_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pre_lb.Location = New System.Drawing.Point(176, 311)
        Me.pre_lb.Name = "pre_lb"
        Me.pre_lb.Size = New System.Drawing.Size(104, 29)
        Me.pre_lb.TabIndex = 19
        Me.pre_lb.Text = "_______"
        '
        'can_lb
        '
        Me.can_lb.AutoSize = True
        Me.can_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.can_lb.Location = New System.Drawing.Point(176, 262)
        Me.can_lb.Name = "can_lb"
        Me.can_lb.Size = New System.Drawing.Size(104, 29)
        Me.can_lb.TabIndex = 20
        Me.can_lb.Text = "_______"
        '
        'tam_lb
        '
        Me.tam_lb.AutoSize = True
        Me.tam_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tam_lb.Location = New System.Drawing.Point(176, 204)
        Me.tam_lb.Name = "tam_lb"
        Me.tam_lb.Size = New System.Drawing.Size(104, 29)
        Me.tam_lb.TabIndex = 21
        Me.tam_lb.Text = "_______"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Precio:"
        '
        'nom_lb
        '
        Me.nom_lb.AutoSize = True
        Me.nom_lb.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_lb.Location = New System.Drawing.Point(176, 144)
        Me.nom_lb.Name = "nom_lb"
        Me.nom_lb.Size = New System.Drawing.Size(104, 29)
        Me.nom_lb.TabIndex = 18
        Me.nom_lb.Text = "_______"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 29)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 29)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tamaño:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Código:"
        '
        'bo_Buscar
        '
        Me.bo_Buscar.BackColor = System.Drawing.Color.Bisque
        Me.bo_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_Buscar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_Buscar.Location = New System.Drawing.Point(75, 379)
        Me.bo_Buscar.Name = "bo_Buscar"
        Me.bo_Buscar.Size = New System.Drawing.Size(122, 42)
        Me.bo_Buscar.TabIndex = 11
        Me.bo_Buscar.Text = "Buscar"
        Me.bo_Buscar.UseVisualStyleBackColor = False
        '
        'Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.chocolate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(446, 450)
        Me.Controls.Add(Me.boMenu)
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
        Me.Controls.Add(Me.bo_Buscar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Buscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boMenu As Button
    Friend WithEvents codigo_txt As TextBox
    Friend WithEvents pre_lb As Label
    Friend WithEvents can_lb As Label
    Friend WithEvents tam_lb As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nom_lb As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bo_Buscar As Button
End Class
