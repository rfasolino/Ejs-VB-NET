<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbEspecialidad = New System.Windows.Forms.GroupBox()
        Me.rbtOtro = New System.Windows.Forms.RadioButton()
        Me.rbtSecre = New System.Windows.Forms.RadioButton()
        Me.rbtConta = New System.Windows.Forms.RadioButton()
        Me.rbtCompu = New System.Windows.Forms.RadioButton()
        Me.gbTurno = New System.Windows.Forms.GroupBox()
        Me.rbtNoche = New System.Windows.Forms.RadioButton()
        Me.rbtTarde = New System.Windows.Forms.RadioButton()
        Me.rbtManiana = New System.Windows.Forms.RadioButton()
        Me.gbCiclo = New System.Windows.Forms.GroupBox()
        Me.rbt4a6 = New System.Windows.Forms.RadioButton()
        Me.rbt1a3 = New System.Windows.Forms.RadioButton()
        Me.btnMonto = New System.Windows.Forms.Button()
        Me.gbEspecialidad.SuspendLayout()
        Me.gbTurno.SuspendLayout()
        Me.gbCiclo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(125, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(180, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Inscripcion del Alumo"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(109, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(196, 25)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'gbEspecialidad
        '
        Me.gbEspecialidad.Controls.Add(Me.rbtOtro)
        Me.gbEspecialidad.Controls.Add(Me.rbtSecre)
        Me.gbEspecialidad.Controls.Add(Me.rbtConta)
        Me.gbEspecialidad.Controls.Add(Me.rbtCompu)
        Me.gbEspecialidad.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEspecialidad.Location = New System.Drawing.Point(31, 82)
        Me.gbEspecialidad.Name = "gbEspecialidad"
        Me.gbEspecialidad.Size = New System.Drawing.Size(134, 191)
        Me.gbEspecialidad.TabIndex = 3
        Me.gbEspecialidad.TabStop = False
        Me.gbEspecialidad.Text = "Especialidad"
        '
        'rbtOtro
        '
        Me.rbtOtro.AutoSize = True
        Me.rbtOtro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtOtro.Location = New System.Drawing.Point(18, 111)
        Me.rbtOtro.Name = "rbtOtro"
        Me.rbtOtro.Size = New System.Drawing.Size(48, 19)
        Me.rbtOtro.TabIndex = 6
        Me.rbtOtro.TabStop = True
        Me.rbtOtro.Text = "Otro"
        Me.rbtOtro.UseVisualStyleBackColor = True
        '
        'rbtSecre
        '
        Me.rbtSecre.AutoSize = True
        Me.rbtSecre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSecre.Location = New System.Drawing.Point(18, 61)
        Me.rbtSecre.Name = "rbtSecre"
        Me.rbtSecre.Size = New System.Drawing.Size(95, 19)
        Me.rbtSecre.TabIndex = 5
        Me.rbtSecre.TabStop = True
        Me.rbtSecre.Text = "Secretariado"
        Me.rbtSecre.UseVisualStyleBackColor = True
        '
        'rbtConta
        '
        Me.rbtConta.AutoSize = True
        Me.rbtConta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtConta.Location = New System.Drawing.Point(18, 86)
        Me.rbtConta.Name = "rbtConta"
        Me.rbtConta.Size = New System.Drawing.Size(95, 19)
        Me.rbtConta.TabIndex = 4
        Me.rbtConta.TabStop = True
        Me.rbtConta.Text = "Contabilidad"
        Me.rbtConta.UseVisualStyleBackColor = True
        '
        'rbtCompu
        '
        Me.rbtCompu.AutoSize = True
        Me.rbtCompu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCompu.Location = New System.Drawing.Point(18, 36)
        Me.rbtCompu.Name = "rbtCompu"
        Me.rbtCompu.Size = New System.Drawing.Size(99, 19)
        Me.rbtCompu.TabIndex = 0
        Me.rbtCompu.TabStop = True
        Me.rbtCompu.Text = "Computacion"
        Me.rbtCompu.UseVisualStyleBackColor = True
        '
        'gbTurno
        '
        Me.gbTurno.Controls.Add(Me.rbtNoche)
        Me.gbTurno.Controls.Add(Me.rbtTarde)
        Me.gbTurno.Controls.Add(Me.rbtManiana)
        Me.gbTurno.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTurno.Location = New System.Drawing.Point(300, 82)
        Me.gbTurno.Name = "gbTurno"
        Me.gbTurno.Size = New System.Drawing.Size(107, 191)
        Me.gbTurno.TabIndex = 7
        Me.gbTurno.TabStop = False
        Me.gbTurno.Text = "Turno"
        '
        'rbtNoche
        '
        Me.rbtNoche.AutoSize = True
        Me.rbtNoche.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNoche.Location = New System.Drawing.Point(18, 90)
        Me.rbtNoche.Name = "rbtNoche"
        Me.rbtNoche.Size = New System.Drawing.Size(61, 19)
        Me.rbtNoche.TabIndex = 5
        Me.rbtNoche.TabStop = True
        Me.rbtNoche.Text = "Noche"
        Me.rbtNoche.UseVisualStyleBackColor = True
        '
        'rbtTarde
        '
        Me.rbtTarde.AutoSize = True
        Me.rbtTarde.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtTarde.Location = New System.Drawing.Point(18, 63)
        Me.rbtTarde.Name = "rbtTarde"
        Me.rbtTarde.Size = New System.Drawing.Size(56, 19)
        Me.rbtTarde.TabIndex = 4
        Me.rbtTarde.TabStop = True
        Me.rbtTarde.Text = "Tarde"
        Me.rbtTarde.UseVisualStyleBackColor = True
        '
        'rbtManiana
        '
        Me.rbtManiana.AutoSize = True
        Me.rbtManiana.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtManiana.Location = New System.Drawing.Point(18, 36)
        Me.rbtManiana.Name = "rbtManiana"
        Me.rbtManiana.Size = New System.Drawing.Size(69, 19)
        Me.rbtManiana.TabIndex = 0
        Me.rbtManiana.TabStop = True
        Me.rbtManiana.Text = "Mañana"
        Me.rbtManiana.UseVisualStyleBackColor = True
        '
        'gbCiclo
        '
        Me.gbCiclo.Controls.Add(Me.rbt4a6)
        Me.gbCiclo.Controls.Add(Me.rbt1a3)
        Me.gbCiclo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCiclo.Location = New System.Drawing.Point(171, 82)
        Me.gbCiclo.Name = "gbCiclo"
        Me.gbCiclo.Size = New System.Drawing.Size(123, 191)
        Me.gbCiclo.TabIndex = 7
        Me.gbCiclo.TabStop = False
        Me.gbCiclo.Text = "Ciclo Lectivo"
        '
        'rbt4a6
        '
        Me.rbt4a6.AutoSize = True
        Me.rbt4a6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt4a6.Location = New System.Drawing.Point(18, 84)
        Me.rbt4a6.Name = "rbt4a6"
        Me.rbt4a6.Size = New System.Drawing.Size(75, 19)
        Me.rbt4a6.TabIndex = 5
        Me.rbt4a6.TabStop = True
        Me.rbt4a6.Text = "4to al 6to"
        Me.rbt4a6.UseVisualStyleBackColor = True
        '
        'rbt1a3
        '
        Me.rbt1a3.AutoSize = True
        Me.rbt1a3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt1a3.Location = New System.Drawing.Point(18, 36)
        Me.rbt1a3.Name = "rbt1a3"
        Me.rbt1a3.Size = New System.Drawing.Size(80, 19)
        Me.rbt1a3.TabIndex = 0
        Me.rbt1a3.TabStop = True
        Me.rbt1a3.Text = "1er al 3er "
        Me.rbt1a3.UseVisualStyleBackColor = True
        '
        'btnMonto
        '
        Me.btnMonto.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonto.Location = New System.Drawing.Point(300, 279)
        Me.btnMonto.Name = "btnMonto"
        Me.btnMonto.Size = New System.Drawing.Size(107, 33)
        Me.btnMonto.TabIndex = 9
        Me.btnMonto.Text = "Calcular"
        Me.btnMonto.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 326)
        Me.Controls.Add(Me.btnMonto)
        Me.Controls.Add(Me.gbCiclo)
        Me.Controls.Add(Me.gbTurno)
        Me.Controls.Add(Me.gbEspecialidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmInicio"
        Me.Text = "Inscripcion del Alumno"
        Me.gbEspecialidad.ResumeLayout(False)
        Me.gbEspecialidad.PerformLayout()
        Me.gbTurno.ResumeLayout(False)
        Me.gbTurno.PerformLayout()
        Me.gbCiclo.ResumeLayout(False)
        Me.gbCiclo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbEspecialidad As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCompu As System.Windows.Forms.RadioButton
    Friend WithEvents rbtConta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSecre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOtro As System.Windows.Forms.RadioButton
    Friend WithEvents gbTurno As System.Windows.Forms.GroupBox
    Friend WithEvents rbtNoche As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTarde As System.Windows.Forms.RadioButton
    Friend WithEvents rbtManiana As System.Windows.Forms.RadioButton
    Friend WithEvents gbCiclo As System.Windows.Forms.GroupBox
    Friend WithEvents rbt4a6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt1a3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnMonto As System.Windows.Forms.Button

End Class
