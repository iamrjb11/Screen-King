Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Label2.Text = Me.Size.Height
        Label3.Text = Me.Size.Width
        Label1.Text = "Height :" + Label2.Text + " Width :" + Label3.Text
    End Sub
End Class