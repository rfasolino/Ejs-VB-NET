Public Class Form1

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click

        Dim Rs As Integer = 6
        Dim Nom As String
        Dim Edad As Integer
        Dim Gen As String
        Dim EstCiv As String
        Dim SumaEdad As Integer
        Dim CantEdades As Integer
        Dim HCant As Integer
        Dim MCant As Integer
        Dim CantMuj As Integer

        Do While Rs = 6

            Nom = InputBox("Ingresar nombre.")
            Edad = InputBox("Ingresar edad.")
            Gen = InputBox("Ingresar genero. (H/M/Otro)")
            EstCiv = InputBox("Ingresar estado civil. (Soltero, Divorciado, Viudo)")

            LstB1.Items.Add("Nombre: " & Nom)
            LstB1.Items.Add("Edad: " & Edad)
            LstB1.Items.Add("Genero: " & Gen)
            LstB1.Items.Add("Estado civil: " & EstCiv)
            LstB1.Items.Add("==================")

            SumaEdad = SumaEdad + Edad
            CantEdades = CantEdades + 1

            If Gen = "H" Then

                HCant = HCant + 1

            ElseIf Gen = "M" Then

                MCant = MCant + 1

            End If

            If Gen = "M" And Edad > 20 And EstCiv = "Soltero" Then

                CantMuj = CantMuj + 1

            End If

            Rs = MsgBox("¿Ingresar mas personas?", vbYesNo)

        Loop

        Label1.Text = "El promedio de edad es de: " & SumaEdad / CantEdades

        If HCant > MCant Then

            Label2.Text = "Mayor cantidad de participantes Hombres"

        ElseIf HCant < MCant Then

            Label2.Text = "Mayor cantidad de participantes Mujeres"

        End If

        Label3.Text = "La cantidad de Mujeres solteras: " & CantMuj

    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        End
    End Sub

End Class
