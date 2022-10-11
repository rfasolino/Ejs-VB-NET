Public Class Form1

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click

        Dim Numero As String = Txt1.Text
        Dim i As Integer
        Dim Pares As Integer
        Dim Impares As Integer
        Dim Mayor As Integer
        Dim Menor As Integer
        Dim Bandera As Integer = 0

        For i = 0 To Numero.Length - 1

            If Val(Numero(i)) Mod 2 = 0 Then

                Pares = Pares + 1

            Else

                Impares = Impares + 1

            End If

        Next

        Txt2.Text = Pares

        Txt3.Text = Impares

        For i = 0 To Numero.Length - 1

            If Val(Numero(i)) > Bandera Then

                Mayor = i + 1

                Bandera = Val(Numero(i))

            End If

        Next

        Bandera = 0

        Txt4.Text = Mayor

        Bandera = Val(Numero(1))

        For i = 0 To Numero.Length - 1

            If Val(Numero(i)) < Bandera Then

                Menor = i + 1

                Bandera = Val(Numero(i))

            End If

        Next

        Txt5.Text = Menor
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        End
    End Sub
End Class
