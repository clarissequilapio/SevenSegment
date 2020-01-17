Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 1000 Then
            btn1.BackColor = Color.Red
            btn2.BackColor = Color.Red
            btn3.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn6.BackColor = Color.Red
            btn7.BackColor = Color.Red

        ElseIf Timer1.Interval = +1000 Then
            btn3.BackColor = Color.Red
            btn6.BackColor = Color.Red
            btn1.BackColor = Color.Gray
            btn2.BackColor = Color.Gray
            btn5.BackColor = Color.Gray
            btn6.BackColor = Color.Gray
            btn7.BackColor = Color.Gray

        End If




    End Sub
End Class
