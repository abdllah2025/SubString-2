Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "عبدالله"
        TextBox2.Text = "محمد"
        TextBox3.Text = "المحضار"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = TextBox2.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = TextBox1.Text & " " & TextBox2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Text = "قاسم " & TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text
    End Sub

End Class