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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.RBtn1 = New System.Windows.Forms.RadioButton()
        Me.RBtn3 = New System.Windows.Forms.RadioButton()
        Me.RBtn2 = New System.Windows.Forms.RadioButton()
        Me.GpB1 = New System.Windows.Forms.GroupBox()
        Me.GpB2 = New System.Windows.Forms.GroupBox()
        Me.RBtn4 = New System.Windows.Forms.RadioButton()
        Me.RBtn5 = New System.Windows.Forms.RadioButton()
        Me.RBtn6 = New System.Windows.Forms.RadioButton()
        Me.RBtn7 = New System.Windows.Forms.RadioButton()
        Me.GpB3 = New System.Windows.Forms.GroupBox()
        Me.RBtn8 = New System.Windows.Forms.RadioButton()
        Me.RBtn9 = New System.Windows.Forms.RadioButton()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.GpB1.SuspendLayout()
        Me.GpB2.SuspendLayout()
        Me.GpB3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(120, 29)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 20)
        Me.Txt1.TabIndex = 1
        '
        'RBtn1
        '
        Me.RBtn1.AutoSize = True
        Me.RBtn1.Location = New System.Drawing.Point(6, 18)
        Me.RBtn1.Name = "RBtn1"
        Me.RBtn1.Size = New System.Drawing.Size(64, 17)
        Me.RBtn1.TabIndex = 2
        Me.RBtn1.TabStop = True
        Me.RBtn1.Text = "Mañana"
        Me.RBtn1.UseVisualStyleBackColor = True
        '
        'RBtn3
        '
        Me.RBtn3.AutoSize = True
        Me.RBtn3.Location = New System.Drawing.Point(6, 64)
        Me.RBtn3.Name = "RBtn3"
        Me.RBtn3.Size = New System.Drawing.Size(57, 17)
        Me.RBtn3.TabIndex = 4
        Me.RBtn3.TabStop = True
        Me.RBtn3.Text = "Noche"
        Me.RBtn3.UseVisualStyleBackColor = True
        '
        'RBtn2
        '
        Me.RBtn2.AutoSize = True
        Me.RBtn2.Location = New System.Drawing.Point(6, 41)
        Me.RBtn2.Name = "RBtn2"
        Me.RBtn2.Size = New System.Drawing.Size(53, 17)
        Me.RBtn2.TabIndex = 3
        Me.RBtn2.TabStop = True
        Me.RBtn2.Text = "Tarde"
        Me.RBtn2.UseVisualStyleBackColor = True
        '
        'GpB1
        '
        Me.GpB1.Controls.Add(Me.RBtn2)
        Me.GpB1.Controls.Add(Me.RBtn3)
        Me.GpB1.Controls.Add(Me.RBtn1)
        Me.GpB1.Location = New System.Drawing.Point(28, 60)
        Me.GpB1.Name = "GpB1"
        Me.GpB1.Size = New System.Drawing.Size(71, 91)
        Me.GpB1.TabIndex = 5
        Me.GpB1.TabStop = False
        Me.GpB1.Text = "Turno"
        '
        'GpB2
        '
        Me.GpB2.Controls.Add(Me.RBtn7)
        Me.GpB2.Controls.Add(Me.RBtn6)
        Me.GpB2.Controls.Add(Me.RBtn5)
        Me.GpB2.Controls.Add(Me.RBtn4)
        Me.GpB2.Location = New System.Drawing.Point(120, 60)
        Me.GpB2.Name = "GpB2"
        Me.GpB2.Size = New System.Drawing.Size(132, 120)
        Me.GpB2.TabIndex = 6
        Me.GpB2.TabStop = False
        Me.GpB2.Text = "Especialidad"
        '
        'RBtn4
        '
        Me.RBtn4.AutoSize = True
        Me.RBtn4.Location = New System.Drawing.Point(6, 19)
        Me.RBtn4.Name = "RBtn4"
        Me.RBtn4.Size = New System.Drawing.Size(87, 17)
        Me.RBtn4.TabIndex = 0
        Me.RBtn4.TabStop = True
        Me.RBtn4.Text = "Computacion"
        Me.RBtn4.UseVisualStyleBackColor = True
        '
        'RBtn5
        '
        Me.RBtn5.AutoSize = True
        Me.RBtn5.Location = New System.Drawing.Point(6, 42)
        Me.RBtn5.Name = "RBtn5"
        Me.RBtn5.Size = New System.Drawing.Size(83, 17)
        Me.RBtn5.TabIndex = 7
        Me.RBtn5.TabStop = True
        Me.RBtn5.Text = "Contabilidad"
        Me.RBtn5.UseVisualStyleBackColor = True
        '
        'RBtn6
        '
        Me.RBtn6.AutoSize = True
        Me.RBtn6.Location = New System.Drawing.Point(6, 65)
        Me.RBtn6.Name = "RBtn6"
        Me.RBtn6.Size = New System.Drawing.Size(73, 17)
        Me.RBtn6.TabIndex = 8
        Me.RBtn6.TabStop = True
        Me.RBtn6.Text = "Secretario"
        Me.RBtn6.UseVisualStyleBackColor = True
        '
        'RBtn7
        '
        Me.RBtn7.AutoSize = True
        Me.RBtn7.Location = New System.Drawing.Point(6, 88)
        Me.RBtn7.Name = "RBtn7"
        Me.RBtn7.Size = New System.Drawing.Size(124, 17)
        Me.RBtn7.TabIndex = 9
        Me.RBtn7.TabStop = True
        Me.RBtn7.Text = "Otras Especialidades"
        Me.RBtn7.UseVisualStyleBackColor = True
        '
        'GpB3
        '
        Me.GpB3.Controls.Add(Me.RBtn9)
        Me.GpB3.Controls.Add(Me.RBtn8)
        Me.GpB3.Location = New System.Drawing.Point(28, 157)
        Me.GpB3.Name = "GpB3"
        Me.GpB3.Size = New System.Drawing.Size(71, 62)
        Me.GpB3.TabIndex = 7
        Me.GpB3.TabStop = False
        Me.GpB3.Text = "Ciclo"
        '
        'RBtn8
        '
        Me.RBtn8.AutoSize = True
        Me.RBtn8.Location = New System.Drawing.Point(6, 19)
        Me.RBtn8.Name = "RBtn8"
        Me.RBtn8.Size = New System.Drawing.Size(67, 17)
        Me.RBtn8.TabIndex = 0
        Me.RBtn8.TabStop = True
        Me.RBtn8.Text = "1ro a 3ro"
        Me.RBtn8.UseVisualStyleBackColor = True
        '
        'RBtn9
        '
        Me.RBtn9.AutoSize = True
        Me.RBtn9.Location = New System.Drawing.Point(6, 42)
        Me.RBtn9.Name = "RBtn9"
        Me.RBtn9.Size = New System.Drawing.Size(67, 17)
        Me.RBtn9.TabIndex = 1
        Me.RBtn9.TabStop = True
        Me.RBtn9.Text = "4to a 6to"
        Me.RBtn9.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(120, 186)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(132, 23)
        Me.Btn1.TabIndex = 8
        Me.Btn1.Text = "Tasar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(120, 215)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(132, 23)
        Me.Btn2.TabIndex = 9
        Me.Btn2.Text = "Salir"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.GpB3)
        Me.Controls.Add(Me.GpB2)
        Me.Controls.Add(Me.GpB1)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GpB1.ResumeLayout(False)
        Me.GpB1.PerformLayout()
        Me.GpB2.ResumeLayout(False)
        Me.GpB2.PerformLayout()
        Me.GpB3.ResumeLayout(False)
        Me.GpB3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents RBtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn3 As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents GpB1 As System.Windows.Forms.GroupBox
    Friend WithEvents GpB2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBtn7 As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn6 As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn5 As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn4 As System.Windows.Forms.RadioButton
    Friend WithEvents GpB3 As System.Windows.Forms.GroupBox
    Friend WithEvents RBtn9 As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn8 As System.Windows.Forms.RadioButton
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button

End Class
