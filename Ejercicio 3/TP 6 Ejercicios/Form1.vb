Public Class Form1

    Dim Turno As Boolean
    Dim Ciclo As Boolean
    Dim Especialidad As Boolean

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        If Turno = True And Ciclo = True And Especialidad = True Then

            Dim Total As Integer

            If RBtn1.Checked = True Then

                Total = Total + 250

            ElseIf RBtn2.Checked = True Then

                Total = Total + 200

            ElseIf RBtn3.Checked = True Then

                Total = Total + 300

            End If

            If RBtn8.Checked = True Then

                If RBtn4.Checked = True Then

                    Total = Total + 3000

                End If

                If RBtn5.Checked = True Then

                    Total = Total + 2500

                End If

                If RBtn6.Checked = True Then

                    Total = Total + 2300

                End If

                If RBtn7.Checked = True Then

                    Total = Total + 2000

                End If

            End If

            If RBtn9.Checked = True Then

                If RBtn4.Checked = True Then

                    Total = Total + 3200

                End If

                If RBtn5.Checked = True Then

                    Total = Total + 2800

                End If

                If RBtn6.Checked = True Then

                    Total = Total + 2200

                End If

                If RBtn7.Checked = True Then

                    Total = Total + 2500

                End If

            End If

            MsgBox(Txt1.Text & " debera pagar el importe de " & Total & "$")

        Else

            MsgBox("Faltan datos.")

        End If
    End Sub



    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        End
    End Sub

    Private Sub RBtn1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn1.CheckedChanged
        Turno = True
    End Sub

    Private Sub RBtn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn2.CheckedChanged
        Turno = True
    End Sub

    Private Sub RBtn3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn3.CheckedChanged
        Turno = True
    End Sub

    Private Sub RBtn4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn4.CheckedChanged
        Especialidad = True
    End Sub

    Private Sub RBtn5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn5.CheckedChanged
        Especialidad = True
    End Sub

    Private Sub RBtn6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn6.CheckedChanged
        Especialidad = True
    End Sub

    Private Sub RBtn7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn7.CheckedChanged
        Especialidad = True
    End Sub

    Private Sub RBtn8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn8.CheckedChanged
        Ciclo = True
    End Sub

    Private Sub RBtn9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn9.CheckedChanged
        Ciclo = True
    End Sub
End Class
