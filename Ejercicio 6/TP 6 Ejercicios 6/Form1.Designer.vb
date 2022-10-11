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
        Me.LstB1 = New System.Windows.Forms.ListBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstB1
        '
        Me.LstB1.FormattingEnabled = True
        Me.LstB1.Location = New System.Drawing.Point(60, 23)
        Me.LstB1.Name = "LstB1"
        Me.LstB1.Size = New System.Drawing.Size(156, 160)
        Me.LstB1.TabIndex = 0
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(60, 189)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Empezar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(141, 189)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 2
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
        Me.Controls.Add(Me.LstB1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstB1 As System.Windows.Forms.ListBox
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button

End Class
