Public Class Form1

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        Dim Numero As String = Txt1.Text

        If Val(Numero(Numero.Length - 1)) = 0 Then

            Numero = Numero * 2

            MsgBox("El numero termina en 0, y fue multiplicado por 2")

        End If

        If Val(Numero(Numero.Length - 1)) = 5 Then

            Numero = Numero * 2

            MsgBox("El numero termina en 5, y fue multiplicado por 2")

        End If

        If Val(Numero(Numero.Length - 1)) = 1 Then

            Numero = Numero * 0.1

            MsgBox("El numero termina en 1, se muestra su decima parte")

        End If

        If Val(Numero(Numero.Length - 1)) = 9 Then

            Numero = Numero * 0.1

            MsgBox("El numero termina en 9, se muestra su decima parte")

        End If

        If Val(Numero(Numero.Length - 1)) = 2 Then

            Numero = Numero * 3

            MsgBox("El numero termina en 2, y fue multiplicado por 3")

        End If

        If Val(Numero(Numero.Length - 1)) = 3 Then

            Numero = Numero * 3

            MsgBox("El numero termina en 3, y fue multiplicado por 3")

        End If

        Label2.Text = "Numero Analizado: " & Numero
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        End
    End Sub
End Class
