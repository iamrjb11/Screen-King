<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.capturebtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rectangularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.modeLabel = New System.Windows.Forms.Label()
        Me.RecorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'capturebtn
        '
        Me.capturebtn.BackColor = System.Drawing.Color.Orange
        Me.capturebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capturebtn.Location = New System.Drawing.Point(0, 0)
        Me.capturebtn.Name = "capturebtn"
        Me.capturebtn.Size = New System.Drawing.Size(120, 61)
        Me.capturebtn.TabIndex = 0
        Me.capturebtn.Text = "Capture"
        Me.capturebtn.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(369, 60)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rectangularToolStripMenuItem, Me.fullscreenToolStripMenuItem, Me.RecorderToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MenuToolStripMenuItem.Margin = New System.Windows.Forms.Padding(115, 0, 0, 0)
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Padding = New System.Windows.Forms.Padding(7, 20, 7, 11)
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(122, 56)
        Me.MenuToolStripMenuItem.Text = "Select Mode"
        '
        'rectangularToolStripMenuItem
        '
        Me.rectangularToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rectangularToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rectangularToolStripMenuItem.Name = "rectangularToolStripMenuItem"
        Me.rectangularToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.rectangularToolStripMenuItem.Text = "Rectangular"
        Me.rectangularToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fullscreenToolStripMenuItem
        '
        Me.fullscreenToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.fullscreenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem"
        Me.fullscreenToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.fullscreenToolStripMenuItem.Text = "Full-Screen"
        Me.fullscreenToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'modeLabel
        '
        Me.modeLabel.AutoSize = True
        Me.modeLabel.BackColor = System.Drawing.Color.Orange
        Me.modeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modeLabel.Location = New System.Drawing.Point(245, 1)
        Me.modeLabel.Name = "modeLabel"
        Me.modeLabel.Padding = New System.Windows.Forms.Padding(8, 19, 8, 18)
        Me.modeLabel.Size = New System.Drawing.Size(123, 57)
        Me.modeLabel.TabIndex = 3
        Me.modeLabel.Text = "Rectangular"
        '
        'RecorderToolStripMenuItem
        '
        Me.RecorderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RecorderToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RecorderToolStripMenuItem.Name = "RecorderToolStripMenuItem"
        Me.RecorderToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.RecorderToolStripMenuItem.Text = "Recorder"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 60)
        Me.Controls.Add(Me.modeLabel)
        Me.Controls.Add(Me.capturebtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Screen King"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents capturebtn As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rectangularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fullscreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modeLabel As System.Windows.Forms.Label
    Friend WithEvents RecorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
