﻿Public Class Form1
    Private counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        If counter = 1 Then
            btn1.BackColor = Color.LightGray
            btn2.BackColor = Color.LightGray
            btn3.BackColor = Color.Red
            btn4.BackColor = Color.LightGray
            btn5.BackColor = Color.LightGray
            btn6.BackColor = Color.Red
            btn7.BackColor = Color.LightGray

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
        btn1.BackColor = Color.Red
        btn2.BackColor = Color.Red
        btn3.BackColor = Color.Red
        btn4.BackColor = Color.LightGray
        btn5.BackColor = Color.Red
        btn6.BackColor = Color.Red
        btn7.BackColor = Color.Red
    End Sub
End Class
