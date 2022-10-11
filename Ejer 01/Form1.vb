Public Class frmInicio

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged

        Dim i, cantPar, cantImpar, maxNum, minNum, flag, posMax, posMin As Integer
        Dim arrayNum As String

        arrayNum = txtNumero.Text

        maxNum = 0
        minNum = 0
        flag = 0
        For i = 0 To arrayNum.Length - 1 Step 1

            If Val(arrayNum(i)) > maxNum Then
                maxNum = Val(arrayNum(i))
                posMax = i
            End If

            If flag = 0 Or Val(arrayNum(i)) < minNum Then

                minNum = Val(arrayNum(i))
                posMin = i

                flag = 1
            End If


            If (Val(arrayNum(i)) Mod 2 = 0) Then
                cantPar = cantPar + 1

            Else
                cantImpar = cantImpar + 1

            End If

        Next

        lblCantPar.Text = cantPar
        lblCantImpar.Text = cantImpar
        lblPosMenor.Text = posMin
        lblPosMayor.Text = posMax

    End Sub

    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
