Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start.Opacity = 0%

        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)


        Dim sPath As New SaveFileDialog
        sPath.Filter = "Image (*.png)|*,*"
        sPath.ShowDialog()
        Dim bmp As Bitmap
        Try
            bmp = screenshot
            bmp.Save(sPath.FileName + ".png")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyBase.Close()

    End Sub
End Class