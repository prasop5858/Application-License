<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicense
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tlsOperation = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsSoftware = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 311)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(891, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsOperation, Me.tlsSoftware, Me.tlsExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tlsOperation
        '
        Me.tlsOperation.Name = "tlsOperation"
        Me.tlsOperation.Size = New System.Drawing.Size(114, 20)
        Me.tlsOperation.Text = "Operation License"
        '
        'tlsSoftware
        '
        Me.tlsSoftware.Name = "tlsSoftware"
        Me.tlsSoftware.Size = New System.Drawing.Size(107, 20)
        Me.tlsSoftware.Text = "Software License"
        '
        'tlsExit
        '
        Me.tlsExit.Name = "tlsExit"
        Me.tlsExit.Size = New System.Drawing.Size(37, 20)
        Me.tlsExit.Text = "Exit"
        '
        'tlsStatus
        '
        Me.tlsStatus.Name = "tlsStatus"
        Me.tlsStatus.Size = New System.Drawing.Size(121, 17)
        Me.tlsStatus.Text = "ToolStripStatusLabel1"
        '
        'frmLicense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 333)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmLicense"
        Me.Text = "License Application"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tlsOperation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsSoftware As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
