Public Class Form1
    Private counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If counter = 0 Then
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.Green
            btn3.BackColor = Color.Green
            btn4.BackColor = Color.LightGray
            btn5.BackColor = Color.Green
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.Green

        ElseIf counter = 1 Then
            btn1.BackColor = Color.LightGray
            btn2.BackColor = Color.LightGray
            btn3.BackColor = Color.Green
            btn4.BackColor = Color.LightGray
            btn5.BackColor = Color.LightGray
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.LightGray

        ElseIf counter = 2 Then
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.LightGray
            btn3.BackColor = Color.Green
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn6.BackColor = Color.LightGray
            btn7.BackColor = Color.Green
        ElseIf counter = 3 Then
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.LightGray
            btn3.BackColor = Color.Green
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.LightGray
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.Green
        ElseIf counter = 4 Then
            btn1.BackColor = Color.LightGray
            btn2.BackColor = Color.Green
            btn3.BackColor = Color.Green
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.LightGray
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.LightGray
        ElseIf counter = 5 Then
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.Green
            btn3.BackColor = Color.LightGray
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.LightGray
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.Green
        ElseIf counter = 6 Then
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.Green
            btn3.BackColor = Color.LightGray
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.Green
        ElseIf counter = 7 Then
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.LightGray
            btn3.BackColor = Color.Green
            btn4.BackColor = Color.LightGray
            btn5.BackColor = Color.LightGray
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.LightGray
        ElseIf counter = 8 Then
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.Green
            btn3.BackColor = Color.Green
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.Green
        End If
        If counter = 9 Then
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.Green
            btn3.BackColor = Color.Green
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.LightGray
            btn6.BackColor = Color.Green
            btn7.BackColor = Color.Green

            counter = 0
        Else
            counter += 1
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
        btn1.BackColor = Color.Green
        btn2.BackColor = Color.Green
        btn3.BackColor = Color.Green
        btn4.BackColor = Color.LightGray
        btn5.BackColor = Color.Green
        btn6.BackColor = Color.Green
        btn7.BackColor = Color.Green
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
