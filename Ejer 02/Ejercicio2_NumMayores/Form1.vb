Public Class frmInicio


    Private Sub btnNumMay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumMay.Click

        Dim num As Integer
        Dim cont As Integer = 0
        Dim numMayor1 As Integer = 0
        Dim numMayor2 As Integer = 0
        Dim numMayor3 As Integer = 0


        Do While cont <> 9
            num = InputBox("Ingrese un numero:")

            If num >= numMayor1 Then

                numMayor3 = numMayor2
                numMayor2 = numMayor1
                numMayor1 = num
            ElseIf num >= numMayor2 Then

                numMayor3 = numMayor2
                numMayor2 = num

            ElseIf num >= numMayor3 Then
                numMayor3 = num
            End If

            lblNumCompleto.Text += num.ToString
            cont += 1
        Loop

        lblNumMayor1.Text += numMayor1.ToString
        lblNumMayor2.Text += numMayor2.ToString
        lblNumMayor3.Text += numMayor3.ToString
    End Sub

    Private Sub lblNumCompleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNumCompleto.Click

    End Sub
End Class
