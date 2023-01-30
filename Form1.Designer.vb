<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.TxtY2 = New System.Windows.Forms.TextBox()
        Me.TxtY1 = New System.Windows.Forms.TextBox()
        Me.TxtX2 = New System.Windows.Forms.TextBox()
        Me.TxtX1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtDistancia = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(665, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(123, 50)
        Me.btnLimpiar.TabIndex = 0
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(665, 329)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(123, 50)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(193, 525)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(123, 50)
        Me.BtnCalcular.TabIndex = 2
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'TxtY2
        '
        Me.TxtY2.Location = New System.Drawing.Point(28, 303)
        Me.TxtY2.Name = "TxtY2"
        Me.TxtY2.Size = New System.Drawing.Size(100, 22)
        Me.TxtY2.TabIndex = 3
        '
        'TxtY1
        '
        Me.TxtY1.Location = New System.Drawing.Point(28, 156)
        Me.TxtY1.Name = "TxtY1"
        Me.TxtY1.Size = New System.Drawing.Size(100, 22)
        Me.TxtY1.TabIndex = 4
        '
        'TxtX2
        '
        Me.TxtX2.Location = New System.Drawing.Point(501, 436)
        Me.TxtX2.Name = "TxtX2"
        Me.TxtX2.Size = New System.Drawing.Size(100, 22)
        Me.TxtX2.TabIndex = 5
        '
        'TxtX1
        '
        Me.TxtX1.Location = New System.Drawing.Point(193, 436)
        Me.TxtX1.Name = "TxtX1"
        Me.TxtX1.Size = New System.Drawing.Size(100, 22)
        Me.TxtX1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Distancia Entre 2 Puntos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Distancia"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(147, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(512, 355)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'TxtDistancia
        '
        Me.TxtDistancia.Location = New System.Drawing.Point(344, 539)
        Me.TxtDistancia.Name = "TxtDistancia"
        Me.TxtDistancia.ReadOnly = True
        Me.TxtDistancia.Size = New System.Drawing.Size(123, 22)
        Me.TxtDistancia.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 598)
        Me.Controls.Add(Me.TxtDistancia)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtX1)
        Me.Controls.Add(Me.TxtX2)
        Me.Controls.Add(Me.TxtY1)
        Me.Controls.Add(Me.TxtY2)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TxtY2 As TextBox
    Friend WithEvents TxtY1 As TextBox
    Friend WithEvents TxtX2 As TextBox
    Friend WithEvents TxtX1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtDistancia As TextBox
End Class
