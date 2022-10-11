Public Class EJ2

    Private Sub BtnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnI.Click
        Dim vector(10) As Integer
        Dim F As Integer
        Dim Prim As Integer = 0
        Dim Seg As Integer = 0
        Dim Ter As Integer = 0

        For F = 1 To 10

            vector(F) = InputBox("Ingresar numero " & F)

        Next

        For F = 1 To 10

            If vector(F) > Prim Then

                Prim = vector(F)

            End If

        Next

        txt1.Text = Prim

        For F = 1 To 10

            If vector(F) > Seg And vector(F) <> Prim Then

                Seg = vector(F)

            End If

        Next

        txt2.Text = Seg

        For F = 1 To 10

            If vector(F) > Ter And vector(F) <> Prim And vector(F) <> Seg Then

                Ter = vector(F)

            End If

        Next
        txt3.Text = Ter
    End Sub

    Private Sub BtnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnS.Click
        End
    End Sub
End Class
