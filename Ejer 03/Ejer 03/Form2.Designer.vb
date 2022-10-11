<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Me.btnMonto = New System.Windows.Forms.Button()
        Me.rbt4a6 = New System.Windows.Forms.RadioButton()
        Me.rbtManiana = New System.Windows.Forms.RadioButton()
        Me.rbtTarde = New System.Windows.Forms.RadioButton()
        Me.rbtNoche = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.rbt1a3 = New System.Windows.Forms.RadioButton()
        Me.rbtCompu = New System.Windows.Forms.RadioButton()
        Me.rbtConta = New System.Windows.Forms.RadioButton()
        Me.rbtSecre = New System.Windows.Forms.RadioButton()
        Me.rbtOtro = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMonto
        '
        Me.btnMonto.Location = New System.Drawing.Point(158, 243)
        Me.btnMonto.Name = "btnMonto"
        Me.btnMonto.Size = New System.Drawing.Size(75, 23)
        Me.btnMonto.TabIndex = 0
        Me.btnMonto.Text = "&Monto"
        Me.btnMonto.UseVisualStyleBackColor = True
        '
        'rbt4a6
        '
        Me.rbt4a6.AutoSize = True
        Me.rbt4a6.Location = New System.Drawing.Point(19, 42)
        Me.rbt4a6.Name = "rbt4a6"
        Me.rbt4a6.Size = New System.Drawing.Size(57, 17)
        Me.rbt4a6.TabIndex = 12
        Me.rbt4a6.TabStop = True
        Me.rbt4a6.Text = "4º a 6º"
        Me.rbt4a6.UseVisualStyleBackColor = True
        '
        'rbtManiana
        '
        Me.rbtManiana.AutoSize = True
        Me.rbtManiana.Location = New System.Drawing.Point(18, 19)
        Me.rbtManiana.Name = "rbtManiana"
        Me.rbtManiana.Size = New System.Drawing.Size(64, 17)
        Me.rbtManiana.TabIndex = 13
        Me.rbtManiana.TabStop = True
        Me.rbtManiana.Text = "Mañana"
        Me.rbtManiana.UseVisualStyleBackColor = True
        '
        'rbtTarde
        '
        Me.rbtTarde.AutoSize = True
        Me.rbtTarde.Location = New System.Drawing.Point(18, 42)
        Me.rbtTarde.Name = "rbtTarde"
        Me.rbtTarde.Size = New System.Drawing.Size(53, 17)
        Me.rbtTarde.TabIndex = 14
        Me.rbtTarde.TabStop = True
        Me.rbtTarde.Text = "Tarde"
        Me.rbtTarde.UseVisualStyleBackColor = True
        '
        'rbtNoche
        '
        Me.rbtNoche.AutoSize = True
        Me.rbtNoche.Location = New System.Drawing.Point(18, 65)
        Me.rbtNoche.Name = "rbtNoche"
        Me.rbtNoche.Size = New System.Drawing.Size(57, 17)
        Me.rbtNoche.TabIndex = 15
        Me.rbtNoche.TabStop = True
        Me.rbtNoche.Text = "Noche"
        Me.rbtNoche.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(175, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 17
        '
        'rbt1a3
        '
        Me.rbt1a3.AutoSize = True
        Me.rbt1a3.Location = New System.Drawing.Point(19, 19)
        Me.rbt1a3.Name = "rbt1a3"
        Me.rbt1a3.Size = New System.Drawing.Size(57, 17)
        Me.rbt1a3.TabIndex = 7
        Me.rbt1a3.TabStop = True
        Me.rbt1a3.Text = "1º a 3º"
        Me.rbt1a3.UseVisualStyleBackColor = True
        '
        'rbtCompu
        '
        Me.rbtCompu.AutoSize = True
        Me.rbtCompu.Location = New System.Drawing.Point(22, 14)
        Me.rbtCompu.Name = "rbtCompu"
        Me.rbtCompu.Size = New System.Drawing.Size(87, 17)
        Me.rbtCompu.TabIndex = 8
        Me.rbtCompu.TabStop = True
        Me.rbtCompu.Text = "Computación"
        Me.rbtCompu.UseVisualStyleBackColor = True
        '
        'rbtConta
        '
        Me.rbtConta.AutoSize = True
        Me.rbtConta.Location = New System.Drawing.Point(22, 37)
        Me.rbtConta.Name = "rbtConta"
        Me.rbtConta.Size = New System.Drawing.Size(68, 17)
        Me.rbtConta.TabIndex = 9
        Me.rbtConta.TabStop = True
        Me.rbtConta.Text = "Contador"
        Me.rbtConta.UseVisualStyleBackColor = True
        '
        'rbtSecre
        '
        Me.rbtSecre.AutoSize = True
        Me.rbtSecre.Location = New System.Drawing.Point(22, 60)
        Me.rbtSecre.Name = "rbtSecre"
        Me.rbtSecre.Size = New System.Drawing.Size(85, 17)
        Me.rbtSecre.TabIndex = 10
        Me.rbtSecre.TabStop = True
        Me.rbtSecre.Text = "Secretariado"
        Me.rbtSecre.UseVisualStyleBackColor = True
        '
        'rbtOtro
        '
        Me.rbtOtro.AutoSize = True
        Me.rbtOtro.Location = New System.Drawing.Point(22, 83)
        Me.rbtOtro.Name = "rbtOtro"
        Me.rbtOtro.Size = New System.Drawing.Size(123, 17)
        Me.rbtOtro.TabIndex = 11
        Me.rbtOtro.TabStop = True
        Me.rbtOtro.Text = "Otras especialidades"
        Me.rbtOtro.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtOtro)
        Me.Panel1.Controls.Add(Me.rbtSecre)
        Me.Panel1.Controls.Add(Me.rbtConta)
        Me.Panel1.Controls.Add(Me.rbtCompu)
        Me.Panel1.Location = New System.Drawing.Point(12, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 124)
        Me.Panel1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtNoche)
        Me.GroupBox1.Controls.Add(Me.rbtTarde)
        Me.GroupBox1.Controls.Add(Me.rbtManiana)
        Me.GroupBox1.Location = New System.Drawing.Point(284, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 96)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Turno"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbt1a3)
        Me.GroupBox2.Controls.Add(Me.rbt4a6)
        Me.GroupBox2.Location = New System.Drawing.Point(175, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(95, 69)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ciclo"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 278)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMonto)
        Me.Name = "FrmInicio"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents btnMonto As System.Windows.Forms.Button
    Friend WithEvents rbt4a6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtManiana As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTarde As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNoche As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents rbt1a3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCompu As System.Windows.Forms.RadioButton
    Friend WithEvents rbtConta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSecre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOtro As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
