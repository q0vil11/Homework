Public Class Form1
    Dim Name, Middle, y, z As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Hadia"
        TextBox2.Text = "Mohamed"
        TextBox3.Text = "Ahmed"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Name = "Hadia Mohamed Ahmed"
        Middle = Name.Substring(6, 7)
        TextBox4.Text = Middle
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        y = TextBox1.Text
        Dim cleanstr As String
        cleanstr = Name.Remove(14, 5)
        TextBox4.Text = cleanstr
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        z = TextBox2.Text
        Dim newstr As String
        newstr = Name.Insert(0, " Mohamed ")
        TextBox4.Text = newstr
    End Sub
End Class
