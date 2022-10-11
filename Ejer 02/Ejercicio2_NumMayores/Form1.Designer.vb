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
        Me.lblNumMayor1 = New System.Windows.Forms.Label()
        Me.lblNumMayor2 = New System.Windows.Forms.Label()
        Me.lblNumMayor3 = New System.Windows.Forms.Label()
        Me.btnNumMay = New System.Windows.Forms.Button()
        Me.lblNumCompleto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumMayor1
        '
        Me.lblNumMayor1.AutoSize = True
        Me.lblNumMayor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMayor1.Location = New System.Drawing.Point(12, 68)
        Me.lblNumMayor1.Name = "lblNumMayor1"
        Me.lblNumMayor1.Size = New System.Drawing.Size(124, 18)
        Me.lblNumMayor1.TabIndex = 2
        Me.lblNumMayor1.Text = "Numero Mayor 1:"
        '
        'lblNumMayor2
        '
        Me.lblNumMayor2.AutoSize = True
        Me.lblNumMayor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMayor2.Location = New System.Drawing.Point(12, 97)
        Me.lblNumMayor2.Name = "lblNumMayor2"
        Me.lblNumMayor2.Size = New System.Drawing.Size(124, 18)
        Me.lblNumMayor2.TabIndex = 3
        Me.lblNumMayor2.Text = "Numero Mayor 2:"
        '
        'lblNumMayor3
        '
        Me.lblNumMayor3.AutoSize = True
        Me.lblNumMayor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMayor3.Location = New System.Drawing.Point(12, 128)
        Me.lblNumMayor3.Name = "lblNumMayor3"
        Me.lblNumMayor3.Size = New System.Drawing.Size(124, 18)
        Me.lblNumMayor3.TabIndex = 4
        Me.lblNumMayor3.Text = "Numero Mayor 3:"
        '
        'btnNumMay
        '
        Me.btnNumMay.Location = New System.Drawing.Point(12, 185)
        Me.btnNumMay.Name = "btnNumMay"
        Me.btnNumMay.Size = New System.Drawing.Size(123, 41)
        Me.btnNumMay.TabIndex = 5
        Me.btnNumMay.Text = "Ingresar numeros"
        Me.btnNumMay.UseVisualStyleBackColor = True
        '
        'lblNumCompleto
        '
        Me.lblNumCompleto.AutoSize = True
        Me.lblNumCompleto.Font = New System.Drawing.Font("Arial Narrow", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCompleto.Location = New System.Drawing.Point(12, 24)
        Me.lblNumCompleto.Name = "lblNumCompleto"
        Me.lblNumCompleto.Size = New System.Drawing.Size(128, 20)
        Me.lblNumCompleto.TabIndex = 6
        Me.lblNumCompleto.Text = "Numero Completo: "
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 234)
        Me.Controls.Add(Me.lblNumCompleto)
        Me.Controls.Add(Me.btnNumMay)
        Me.Controls.Add(Me.lblNumMayor3)
        Me.Controls.Add(Me.lblNumMayor2)
        Me.Controls.Add(Me.lblNumMayor1)
        Me.Name = "frmInicio"
        Me.Text = "Numero Mayores "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumMayor1 As System.Windows.Forms.Label
    Friend WithEvents lblNumMayor2 As System.Windows.Forms.Label
    Friend WithEvents lblNumMayor3 As System.Windows.Forms.Label
    Friend WithEvents btnNumMay As System.Windows.Forms.Button
    Friend WithEvents lblNumCompleto As System.Windows.Forms.Label

End Class
