Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hight As Integer
        Dim Weight As Integer
        Dim textbmi As String
        Dim BMI As Double
        Hight = TextBox2.Text
        Weight = TextBox1.Text
        BMI = Weight / (Hight / 100) ^ 2
        TextBox3.Text = BMI
        If BMI < 18.5 Then
            textbmi = "ผอมเกินไป"
        ElseIf BMI >= 18.5 And BMI <= 23.5 Then
            textbmi = "ปกติ"
        ElseIf BMI >= 23.5 And BMI <= 28.5 Then
            textbmi = "อวบ"
        ElseIf BMI >= 28.5 And BMI <= 35.5 Then
            textbmi = "อ้วนระยะที่1"
        ElseIf BMI >= 35.5 And BMI < 40 Then
            textbmi = "อ้วนระยะที่2"
        ElseIf BMI > 40 Then
            textbmi = "อ้วนมาก"
        End If
        TextBox4.Text = textbmi
        MessageBox.Show(textbmi)
    End Sub
End Class
