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
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.GpB1 = New System.Windows.Forms.GroupBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.GpB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(44, 26)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(191, 20)
        Me.Txt1.TabIndex = 0
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(101, 52)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Empezar"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'GpB1
        '
        Me.GpB1.Controls.Add(Me.Label4)
        Me.GpB1.Controls.Add(Me.Label3)
        Me.GpB1.Controls.Add(Me.Label2)
        Me.GpB1.Controls.Add(Me.Label1)
        Me.GpB1.Controls.Add(Me.Txt5)
        Me.GpB1.Controls.Add(Me.Txt4)
        Me.GpB1.Controls.Add(Me.Txt3)
        Me.GpB1.Controls.Add(Me.Txt2)
        Me.GpB1.Location = New System.Drawing.Point(44, 81)
        Me.GpB1.Name = "GpB1"
        Me.GpB1.Size = New System.Drawing.Size(191, 122)
        Me.GpB1.TabIndex = 2
        Me.GpB1.TabStop = False
        Me.GpB1.Text = "Datos"
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(83, 19)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(100, 20)
        Me.Txt2.TabIndex = 0
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(83, 45)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(100, 20)
        Me.Txt3.TabIndex = 1
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(83, 71)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(100, 20)
        Me.Txt4.TabIndex = 2
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(83, 97)
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(100, 20)
        Me.Txt5.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Par"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Impar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mayor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Menor"
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(101, 209)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 3
        Me.Btn2.Text = "Salir"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.GpB1)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GpB1.ResumeLayout(False)
        Me.GpB1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents GpB1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt5 As System.Windows.Forms.TextBox
    Friend WithEvents Txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Btn2 As System.Windows.Forms.Button

End Class
