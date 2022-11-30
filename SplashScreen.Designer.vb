<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RCPC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RCPC))
        Me.SplashProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PBPercentage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SplashProgressBar
        '
        Me.SplashProgressBar.Location = New System.Drawing.Point(75, 215)
        Me.SplashProgressBar.Name = "SplashProgressBar"
        Me.SplashProgressBar.Size = New System.Drawing.Size(350, 25)
        Me.SplashProgressBar.TabIndex = 0
        '
        'Timer1
        '
        '
        'PBPercentage
        '
        Me.PBPercentage.AutoSize = True
        Me.PBPercentage.Location = New System.Drawing.Point(222, 190)
        Me.PBPercentage.Name = "PBPercentage"
        Me.PBPercentage.Size = New System.Drawing.Size(39, 13)
        Me.PBPercentage.TabIndex = 1
        Me.PBPercentage.Text = "Label1"
        '
        'RCPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(498, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.PBPercentage)
        Me.Controls.Add(Me.SplashProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RCPC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplashProgressBar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PBPercentage As Label
End Class
