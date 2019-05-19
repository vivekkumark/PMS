<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgpanel
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
        Me.lblinst = New System.Windows.Forms.Label()
        Me.butdone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblinst
        '
        Me.lblinst.AllowDrop = True
        Me.lblinst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblinst.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinst.Location = New System.Drawing.Point(5, -2)
        Me.lblinst.Name = "lblinst"
        Me.lblinst.Size = New System.Drawing.Size(74, 59)
        Me.lblinst.TabIndex = 0
        Me.lblinst.Text = "Drop Your Files Here"
        Me.lblinst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'butdone
        '
        Me.butdone.AllowDrop = True
        Me.butdone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butdone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butdone.Location = New System.Drawing.Point(8, 60)
        Me.butdone.Name = "butdone"
        Me.butdone.Size = New System.Drawing.Size(67, 29)
        Me.butdone.TabIndex = 1
        Me.butdone.Text = "Done"
        Me.butdone.UseVisualStyleBackColor = True
        '
        'dlgpanel
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(86, 92)
        Me.Controls.Add(Me.butdone)
        Me.Controls.Add(Me.lblinst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgpanel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblinst As System.Windows.Forms.Label
    Friend WithEvents butdone As System.Windows.Forms.Button

End Class
