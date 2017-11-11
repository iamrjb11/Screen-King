Public Class Start
    Dim modeValue As Integer = 0
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles capturebtn.Click
        
        Me.Hide()
        If modeValue = 0 Then
            Form1.Show()
        End If
        If modeValue = 1 Then
            Form3.Show()
        End If
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub T1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles rectangularToolStripMenuItem.Click
        modeValue = 0
        modeLabel.Text = "Rectangular"
        capturebtn.Text = "Capture"

    End Sub

    Private Sub fullscreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles fullscreenToolStripMenuItem.Click
        modeValue = 1
        modeLabel.Text = "Full-Screen"
        capturebtn.Text = "Capture"

    End Sub

    Private Sub RecorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecorderToolStripMenuItem.Click
        modeValue = 2
        modeLabel.Text = "   Recorder  "
        capturebtn.Text = "Start"

    End Sub
End Class