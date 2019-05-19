<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPMS))
        Me.butpms = New System.Windows.Forms.Button
        Me.butpdfpageno = New System.Windows.Forms.Button
        Me.panpdf = New System.Windows.Forms.Panel
        Me.butauthor = New System.Windows.Forms.Button
        Me.grpopen = New System.Windows.Forms.GroupBox
        Me.raddefault = New System.Windows.Forms.RadioButton
        Me.radeditor = New System.Windows.Forms.RadioButton
        Me.radfoxit = New System.Windows.Forms.RadioButton
        Me.grpopen.SuspendLayout()
        Me.SuspendLayout()
        '
        'butpms
        '
        Me.butpms.BackColor = System.Drawing.Color.Black
        Me.butpms.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpms.ForeColor = System.Drawing.Color.Lavender
        Me.butpms.Location = New System.Drawing.Point(231, 2)
        Me.butpms.Name = "butpms"
        Me.butpms.Size = New System.Drawing.Size(229, 30)
        Me.butpms.TabIndex = 0
        Me.butpms.Text = "PDF MERGE AND SPLIT"
        Me.butpms.UseVisualStyleBackColor = False
        '
        'butpdfpageno
        '
        Me.butpdfpageno.BackColor = System.Drawing.Color.White
        Me.butpdfpageno.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpdfpageno.Location = New System.Drawing.Point(466, 1)
        Me.butpdfpageno.Name = "butpdfpageno"
        Me.butpdfpageno.Size = New System.Drawing.Size(228, 31)
        Me.butpdfpageno.TabIndex = 0
        Me.butpdfpageno.Text = "PAGE NUMBER"
        Me.butpdfpageno.UseVisualStyleBackColor = False
        '
        'panpdf
        '
        Me.panpdf.Location = New System.Drawing.Point(12, 38)
        Me.panpdf.Name = "panpdf"
        Me.panpdf.Size = New System.Drawing.Size(875, 571)
        Me.panpdf.TabIndex = 1
        '
        'butauthor
        '
        Me.butauthor.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butauthor.Location = New System.Drawing.Point(785, 2)
        Me.butauthor.Name = "butauthor"
        Me.butauthor.Size = New System.Drawing.Size(110, 30)
        Me.butauthor.TabIndex = 2
        Me.butauthor.Text = "About Author"
        Me.butauthor.UseVisualStyleBackColor = True
        '
        'grpopen
        '
        Me.grpopen.Controls.Add(Me.raddefault)
        Me.grpopen.Controls.Add(Me.radeditor)
        Me.grpopen.Controls.Add(Me.radfoxit)
        Me.grpopen.Location = New System.Drawing.Point(12, 1)
        Me.grpopen.Name = "grpopen"
        Me.grpopen.Size = New System.Drawing.Size(213, 34)
        Me.grpopen.TabIndex = 3
        Me.grpopen.TabStop = False
        Me.grpopen.Text = "Open With"
        '
        'raddefault
        '
        Me.raddefault.AutoSize = True
        Me.raddefault.Location = New System.Drawing.Point(152, 14)
        Me.raddefault.Name = "raddefault"
        Me.raddefault.Size = New System.Drawing.Size(59, 17)
        Me.raddefault.TabIndex = 0
        Me.raddefault.Text = "Default"
        Me.raddefault.UseVisualStyleBackColor = True
        '
        'radeditor
        '
        Me.radeditor.AutoSize = True
        Me.radeditor.Location = New System.Drawing.Point(82, 14)
        Me.radeditor.Name = "radeditor"
        Me.radeditor.Size = New System.Drawing.Size(68, 17)
        Me.radeditor.TabIndex = 0
        Me.radeditor.Text = "Foxit Edit"
        Me.radeditor.UseVisualStyleBackColor = True
        '
        'radfoxit
        '
        Me.radfoxit.AutoSize = True
        Me.radfoxit.Checked = True
        Me.radfoxit.Location = New System.Drawing.Point(6, 14)
        Me.radfoxit.Name = "radfoxit"
        Me.radfoxit.Size = New System.Drawing.Size(76, 17)
        Me.radfoxit.TabIndex = 0
        Me.radfoxit.TabStop = True
        Me.radfoxit.Text = "Foxit Read"
        Me.radfoxit.UseVisualStyleBackColor = True
        '
        'frmPMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(899, 619)
        Me.Controls.Add(Me.grpopen)
        Me.Controls.Add(Me.butauthor)
        Me.Controls.Add(Me.panpdf)
        Me.Controls.Add(Me.butpdfpageno)
        Me.Controls.Add(Me.butpms)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(907, 653)
        Me.MinimumSize = New System.Drawing.Size(907, 653)
        Me.Name = "frmPMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PMS 2.5                                       "
        Me.grpopen.ResumeLayout(False)
        Me.grpopen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butpms As System.Windows.Forms.Button
    Friend WithEvents butpdfpageno As System.Windows.Forms.Button
    Friend WithEvents panpdf As System.Windows.Forms.Panel
    Friend WithEvents butauthor As System.Windows.Forms.Button
    Friend WithEvents grpopen As System.Windows.Forms.GroupBox
    Friend WithEvents raddefault As System.Windows.Forms.RadioButton
    Friend WithEvents radfoxit As System.Windows.Forms.RadioButton
    Friend WithEvents radeditor As System.Windows.Forms.RadioButton
End Class
