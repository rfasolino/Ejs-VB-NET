Public Class Form1

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click

        Dim NomFam As String
        Dim Hijos As Integer
        Dim Edad As Integer
        Dim Rs As Integer = 6
        Dim F As Integer
        Dim Subs As Integer
        Dim Ad As Integer

        Do While Rs = 6

            NomFam = InputBox("Ingresar apellido de la familia.")
            Hijos = InputBox("Ingresar cantidad de hijos.")

            For F = 1 To Hijos

                Edad = InputBox("Ingresar edad del hijo " & F)

                If Edad >= 6 And Edad <= 18 Then

                    Subs = Subs + 1000

                    Ad = Ad + 1

                End If

            Next

            If Hijos = 2 Then

                Subs = Subs + 700

            End If

            If Hijos >= 3 And Hijos <= 5 Then

                Subs = Subs + 800

            End If

            If Hijos > 5 Then

                Subs = Subs + 1200

            End If

            LstB1.Items.Add("Familia: " & NomFam)
            LstB1.Items.Add("Hijos: " & Hijos)
            LstB1.Items.Add("Subsidio: " & Subs)
            LstB1.Items.Add("Adicionales: " & Ad)
            LstB1.Items.Add("=====================")

            Subs = 0

            Rs = MsgBox("¿Ingresar mas datos?", vbYesNo)

        Loop

    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        End
    End Sub
End Class
