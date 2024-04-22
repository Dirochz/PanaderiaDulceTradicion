<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visualizar))
        Me.bo_rec = New System.Windows.Forms.Button()
        Me.bo_salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.tabla = New System.Windows.Forms.TextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_com = New System.Windows.Forms.ComboBox()
        Me.info_lb = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bo_rec
        '
        Me.bo_rec.BackColor = System.Drawing.Color.Bisque
        Me.bo_rec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_rec.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_rec.Location = New System.Drawing.Point(403, 162)
        Me.bo_rec.Name = "bo_rec"
        Me.bo_rec.Size = New System.Drawing.Size(134, 37)
        Me.bo_rec.TabIndex = 0
        Me.bo_rec.Text = "Recuperar"
        Me.bo_rec.UseVisualStyleBackColor = False
        '
        'bo_salir
        '
        Me.bo_salir.BackColor = System.Drawing.Color.Bisque
        Me.bo_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bo_salir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bo_salir.Location = New System.Drawing.Point(311, 386)
        Me.bo_salir.Name = "bo_salir"
        Me.bo_salir.Size = New System.Drawing.Size(138, 52)
        Me.bo_salir.TabIndex = 1
        Me.bo_salir.Text = "Salir"
        Me.bo_salir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.pastelito
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 94)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.copcake
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(440, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(97, 111)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.pastel
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(598, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(205, 199)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'tabla
        '
        Me.tabla.BackColor = System.Drawing.Color.Bisque
        Me.tabla.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabla.Location = New System.Drawing.Point(24, 241)
        Me.tabla.Multiline = True
        Me.tabla.Name = "tabla"
        Me.tabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tabla.Size = New System.Drawing.Size(764, 139)
        Me.tabla.TabIndex = 5
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 450)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.Pastelrosa
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(185, 64)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(138, 93)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tabla:"
        '
        'tab_com
        '
        Me.tab_com.BackColor = System.Drawing.Color.Bisque
        Me.tab_com.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tab_com.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_com.FormattingEnabled = True
        Me.tab_com.Items.AddRange(New Object() {"Seleccionar", "Producto", "Factura"})
        Me.tab_com.Location = New System.Drawing.Point(175, 163)
        Me.tab_com.Name = "tab_com"
        Me.tab_com.Size = New System.Drawing.Size(188, 37)
        Me.tab_com.TabIndex = 8
        Me.tab_com.Text = "Seleccionar"
        '
        'info_lb
        '
        Me.info_lb.AutoSize = True
        Me.info_lb.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_lb.Location = New System.Drawing.Point(20, 218)
        Me.info_lb.Name = "info_lb"
        Me.info_lb.Size = New System.Drawing.Size(54, 20)
        Me.info_lb.TabIndex = 9
        Me.info_lb.Text = "Label2"
        '
        'Visualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImage = Global.PanaderiaDulceTradicion.My.Resources.Resources.chocolate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.info_lb)
        Me.Controls.Add(Me.tab_com)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bo_salir)
        Me.Controls.Add(Me.bo_rec)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Visualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bo_rec As Button
    Friend WithEvents bo_salir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents tabla As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tab_com As ComboBox
    Friend WithEvents info_lb As Label
End Class
