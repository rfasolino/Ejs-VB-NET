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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblCantPar = New System.Windows.Forms.Label()
        Me.lblCantImpar = New System.Windows.Forms.Label()
        Me.lblPosMayor = New System.Windows.Forms.Label()
        Me.lblPosMenor = New System.Windows.Forms.Label()
        Me.lblTexNumPares = New System.Windows.Forms.Label()
        Me.lblTexNumImpar = New System.Windows.Forms.Label()
        Me.lblTexPosMen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(12, 34)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(187, 20)
        Me.txtNumero.TabIndex = 0
        '
        'lblCantPar
        '
        Me.lblCantPar.AutoSize = True
        Me.lblCantPar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantPar.Location = New System.Drawing.Point(143, 80)
        Me.lblCantPar.Name = "lblCantPar"
        Me.lblCantPar.Size = New System.Drawing.Size(0, 13)
        Me.lblCantPar.TabIndex = 1
        '
        'lblCantImpar
        '
        Me.lblCantImpar.AutoSize = True
        Me.lblCantImpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantImpar.Location = New System.Drawing.Point(143, 107)
        Me.lblCantImpar.Name = "lblCantImpar"
        Me.lblCantImpar.Size = New System.Drawing.Size(0, 13)
        Me.lblCantImpar.TabIndex = 2
        '
        'lblPosMayor
        '
        Me.lblPosMayor.AutoSize = True
        Me.lblPosMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosMayor.Location = New System.Drawing.Point(213, 155)
        Me.lblPosMayor.Name = "lblPosMayor"
        Me.lblPosMayor.Size = New System.Drawing.Size(0, 13)
        Me.lblPosMayor.TabIndex = 3
        '
        'lblPosMenor
        '
        Me.lblPosMenor.AutoSize = True
        Me.lblPosMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosMenor.Location = New System.Drawing.Point(215, 130)
        Me.lblPosMenor.Name = "lblPosMenor"
        Me.lblPosMenor.Size = New System.Drawing.Size(0, 13)
        Me.lblPosMenor.TabIndex = 4
        '
        'lblTexNumPares
        '
        Me.lblTexNumPares.AutoSize = True
        Me.lblTexNumPares.Location = New System.Drawing.Point(9, 80)
        Me.lblTexNumPares.Name = "lblTexNumPares"
        Me.lblTexNumPares.Size = New System.Drawing.Size(96, 13)
        Me.lblTexNumPares.TabIndex = 5
        Me.lblTexNumPares.Text = "N° de Cifras Pares:"
        '
        'lblTexNumImpar
        '
        Me.lblTexNumImpar.AutoSize = True
        Me.lblTexNumImpar.Location = New System.Drawing.Point(9, 107)
        Me.lblTexNumImpar.Name = "lblTexNumImpar"
        Me.lblTexNumImpar.Size = New System.Drawing.Size(106, 13)
        Me.lblTexNumImpar.TabIndex = 6
        Me.lblTexNumImpar.Text = "N° de Cifras Impares:"
        '
        'lblTexPosMen
        '
        Me.lblTexPosMen.AutoSize = True
        Me.lblTexPosMen.Location = New System.Drawing.Point(10, 130)
        Me.lblTexPosMen.Name = "lblTexPosMen"
        Me.lblTexPosMen.Size = New System.Drawing.Size(202, 13)
        Me.lblTexPosMen.TabIndex = 7
        Me.lblTexPosMen.Text = "Posicion que se encuentra la cifra menor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Posicion que se encuentra la cifra mayor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ingresar un numero"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 223)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTexPosMen)
        Me.Controls.Add(Me.lblTexNumImpar)
        Me.Controls.Add(Me.lblTexNumPares)
        Me.Controls.Add(Me.lblPosMenor)
        Me.Controls.Add(Me.lblPosMayor)
        Me.Controls.Add(Me.lblCantImpar)
        Me.Controls.Add(Me.lblCantPar)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "frmInicio"
        Me.Text = "Numeros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblCantPar As System.Windows.Forms.Label
    Friend WithEvents lblCantImpar As System.Windows.Forms.Label
    Friend WithEvents lblPosMayor As System.Windows.Forms.Label
    Friend WithEvents lblPosMenor As Label
    Friend WithEvents lblTexNumPares As System.Windows.Forms.Label
    Friend WithEvents lblTexNumImpar As System.Windows.Forms.Label
    Friend WithEvents lblTexPosMen As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
