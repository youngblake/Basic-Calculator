Public Class Form1
    Private num1 As Double
    Private operation As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text &= "0"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text &= "."
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text &= "00"
    End Sub

    Private Sub Buttonplus_Click(sender As Object, e As EventArgs) Handles Buttonplus.Click
        num1 = Val(TextBox1.Text)
        operation = "+"
        Label5.Text = num1.ToString()
        Label3.Text = operation
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonminus_Click(sender As Object, e As EventArgs) Handles Buttonminus.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "-"
        Else
            num1 = Val(TextBox1.Text)
            operation = "-"
            Label5.Text = num1.ToString()
            Label3.Text = operation
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Buttondivide_Click(sender As Object, e As EventArgs) Handles Buttondivide.Click
        num1 = Val(TextBox1.Text)
        operation = "/"
        Label5.Text = num1.ToString()
        Label3.Text = operation
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonmultiply_Click(sender As Object, e As EventArgs) Handles Buttonmultiply.Click
        num1 = Val(TextBox1.Text)
        operation = "x"
        Label5.Text = num1.ToString()
        Label3.Text = operation
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonpercent_Click(sender As Object, e As EventArgs) Handles Buttonpercent.Click
        num1 = Val(TextBox1.Text)
        operation = "%"
        Label5.Text = num1.ToString()
        Label3.Text = operation
        TextBox1.Text = ""
    End Sub

    Private Sub Buttondelete_Click(sender As Object, e As EventArgs) Handles Buttondelete.Click
        TextBox1.Text = ""
        num1 = 0
        operation = ""
        Label3.Text = ""
        Label5.Text = ""
    End Sub

    Private Sub Buttonequal_Click(sender As Object, e As EventArgs) Handles Buttonequal.Click
        Dim num2 As Double = Val(TextBox1.Text)
        Dim result As Double

        If operation = "+" Then
            result = num1 + num2
        ElseIf operation = "-" Then
            result = num1 - num2
        ElseIf operation = "/" Then
            If num2 = 0 Then
                If num1 < 0 Or num2 < 0 Then
                    TextBox1.Text = "Undefined"  ' Division by zero with any negative number is undefined
                Else
                    TextBox1.Text = "0"  ' Division of zero by zero is treated as zero here
                End If
                Label3.Text = ""
                Label5.Text = ""
                Exit Sub
            Else
                result = num1 / num2  ' Regular division if no zero in denominator
            End If
        ElseIf operation = "x" Then
            result = num1 * num2
        ElseIf operation = "%" Then
            result = num1 Mod num2
        Else
            result = num2
        End If

        TextBox1.Text = result.ToString()
        Label3.Text = ""
        Label5.Text = ""
        operation = ""
    End Sub
End Class
