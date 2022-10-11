Public Class FrmInicio
    Private Sub btnMonto_Click_1(sender As System.Object, e As System.EventArgs) Handles btnMonto.Click
        Dim monto As Integer

        monto = 0

        If rbt1a3.Checked = True Then
            If rbtCompu.Checked = True Then
                monto = 3000
            ElseIf rbtConta.Checked = True Then
                monto = 2500
            ElseIf rbtSecre.Checked = True Then
                monto = 2300
            ElseIf rbtOtro.Checked = True Then
                monto = 2000
            End If
        ElseIf rbt4a6.Checked = True Then

            If rbtCompu.Checked = True Then
                monto = 3200
            ElseIf rbtConta.Checked = True Then
                monto = 2800
            ElseIf rbtSecre.Checked = True Then
                monto = 2200
            ElseIf rbtOtro.Checked = True Then
                monto = 2500
            End If

        End If

        If rbtManiana.Checked = True Then
            monto += 250
        ElseIf rbtTarde.Checked = True Then
            monto += 200
        ElseIf rbtNoche.Checked = True Then
            monto += 300
        End If

        MsgBox("El monto a pagar del alumno " & txtNombre.Text & " es de" & Str(monto), , "Monto a pagar")
    End Sub
End Class
