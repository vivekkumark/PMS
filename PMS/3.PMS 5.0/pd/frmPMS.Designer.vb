<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class butauthor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(butauthor))
        Me.butpms = New System.Windows.Forms.Button()
        Me.butpdfpageno = New System.Windows.Forms.Button()
        Me.panpdf = New System.Windows.Forms.Panel()
        Me.grpopen = New System.Windows.Forms.GroupBox()
        Me.raddefault = New System.Windows.Forms.RadioButton()
        Me.radeditor = New System.Windows.Forms.RadioButton()
        Me.radfoxit = New System.Windows.Forms.RadioButton()
        Me.grpauthordetails = New System.Windows.Forms.GroupBox()
        Me.llblsuggestions = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.llhelp = New System.Windows.Forms.LinkLabel()
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.butencrypt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpopen.SuspendLayout()
        Me.grpauthordetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'butpms
        '
        Me.butpms.BackColor = System.Drawing.Color.Black
        Me.butpms.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpms.ForeColor = System.Drawing.Color.Lavender
        Me.butpms.Location = New System.Drawing.Point(197, -1)
        Me.butpms.Name = "butpms"
        Me.butpms.Size = New System.Drawing.Size(175, 29)
        Me.butpms.TabIndex = 0
        Me.butpms.Text = "MERGE AND SPLIT"
        Me.butpms.UseVisualStyleBackColor = False
        '
        'butpdfpageno
        '
        Me.butpdfpageno.BackColor = System.Drawing.Color.White
        Me.butpdfpageno.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpdfpageno.Location = New System.Drawing.Point(378, -1)
        Me.butpdfpageno.Name = "butpdfpageno"
        Me.butpdfpageno.Size = New System.Drawing.Size(161, 29)
        Me.butpdfpageno.TabIndex = 0
        Me.butpdfpageno.Text = "PAGE NUMBER"
        Me.butpdfpageno.UseVisualStyleBackColor = False
        '
        'panpdf
        '
        Me.panpdf.Location = New System.Drawing.Point(12, 42)
        Me.panpdf.Name = "panpdf"
        Me.panpdf.Size = New System.Drawing.Size(875, 571)
        Me.panpdf.TabIndex = 1
        '
        'grpopen
        '
        Me.grpopen.Controls.Add(Me.raddefault)
        Me.grpopen.Controls.Add(Me.radeditor)
        Me.grpopen.Controls.Add(Me.radfoxit)
        Me.grpopen.Location = New System.Drawing.Point(22, 31)
        Me.grpopen.Name = "grpopen"
        Me.grpopen.Size = New System.Drawing.Size(213, 34)
        Me.grpopen.TabIndex = 3
        Me.grpopen.TabStop = False
        Me.grpopen.Text = "Open With (Dbl Click On FileName)"
        '
        'raddefault
        '
        Me.raddefault.AutoSize = True
        Me.raddefault.Checked = True
        Me.raddefault.Location = New System.Drawing.Point(6, 14)
        Me.raddefault.Name = "raddefault"
        Me.raddefault.Size = New System.Drawing.Size(59, 17)
        Me.raddefault.TabIndex = 0
        Me.raddefault.TabStop = True
        Me.raddefault.Text = "Default"
        Me.raddefault.UseVisualStyleBackColor = True
        '
        'radeditor
        '
        Me.radeditor.AutoSize = True
        Me.radeditor.Location = New System.Drawing.Point(139, 14)
        Me.radeditor.Name = "radeditor"
        Me.radeditor.Size = New System.Drawing.Size(68, 17)
        Me.radeditor.TabIndex = 0
        Me.radeditor.Text = "Foxit Edit"
        Me.radeditor.UseVisualStyleBackColor = True
        '
        'radfoxit
        '
        Me.radfoxit.AutoSize = True
        Me.radfoxit.Location = New System.Drawing.Point(65, 14)
        Me.radfoxit.Name = "radfoxit"
        Me.radfoxit.Size = New System.Drawing.Size(76, 17)
        Me.radfoxit.TabIndex = 0
        Me.radfoxit.Text = "Foxit Read"
        Me.radfoxit.UseVisualStyleBackColor = True
        '
        'grpauthordetails
        '
        Me.grpauthordetails.BackColor = System.Drawing.Color.Lavender
        Me.grpauthordetails.Controls.Add(Me.llblsuggestions)
        Me.grpauthordetails.Controls.Add(Me.Label1)
        Me.grpauthordetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpauthordetails.ForeColor = System.Drawing.Color.Black
        Me.grpauthordetails.Location = New System.Drawing.Point(718, 31)
        Me.grpauthordetails.Name = "grpauthordetails"
        Me.grpauthordetails.Size = New System.Drawing.Size(169, 52)
        Me.grpauthordetails.TabIndex = 4
        Me.grpauthordetails.TabStop = False
        Me.grpauthordetails.Text = "About Author"
        Me.grpauthordetails.Visible = False
        '
        'llblsuggestions
        '
        Me.llblsuggestions.AutoSize = True
        Me.llblsuggestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblsuggestions.Location = New System.Drawing.Point(6, 36)
        Me.llblsuggestions.Name = "llblsuggestions"
        Me.llblsuggestions.Size = New System.Drawing.Size(158, 13)
        Me.llblsuggestions.TabIndex = 1
        Me.llblsuggestions.TabStop = True
        Me.llblsuggestions.Text = "Click Here To Give Suggestions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vivek K (Inst)"
        '
        'llhelp
        '
        Me.llhelp.AutoSize = True
        Me.llhelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llhelp.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.llhelp.Location = New System.Drawing.Point(844, 9)
        Me.llhelp.Name = "llhelp"
        Me.llhelp.Size = New System.Drawing.Size(43, 19)
        Me.llhelp.TabIndex = 2
        Me.llhelp.TabStop = True
        Me.llhelp.Text = "HELP"
        '
        'bgworker
        '
        Me.bgworker.WorkerSupportsCancellation = True
        '
        'butencrypt
        '
        Me.butencrypt.BackColor = System.Drawing.Color.White
        Me.butencrypt.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butencrypt.Location = New System.Drawing.Point(545, -1)
        Me.butencrypt.Name = "butencrypt"
        Me.butencrypt.Size = New System.Drawing.Size(161, 29)
        Me.butencrypt.TabIndex = 0
        Me.butencrypt.Text = "ENCRYPTION"
        Me.butencrypt.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(778, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Author"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'butauthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(899, 619)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.llhelp)
        Me.Controls.Add(Me.grpopen)
        Me.Controls.Add(Me.grpauthordetails)
        Me.Controls.Add(Me.butencrypt)
        Me.Controls.Add(Me.butpdfpageno)
        Me.Controls.Add(Me.butpms)
        Me.Controls.Add(Me.panpdf)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(907, 653)
        Me.MinimumSize = New System.Drawing.Size(907, 653)
        Me.Name = "butauthor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PMS 5.0                                   "
        Me.grpopen.ResumeLayout(False)
        Me.grpopen.PerformLayout()
        Me.grpauthordetails.ResumeLayout(False)
        Me.grpauthordetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butpms As System.Windows.Forms.Button
    Friend WithEvents butpdfpageno As System.Windows.Forms.Button
    Friend WithEvents panpdf As System.Windows.Forms.Panel
    Friend WithEvents grpopen As System.Windows.Forms.GroupBox
    Friend WithEvents raddefault As System.Windows.Forms.RadioButton
    Friend WithEvents radfoxit As System.Windows.Forms.RadioButton
    Friend WithEvents radeditor As System.Windows.Forms.RadioButton
    Friend WithEvents grpauthordetails As System.Windows.Forms.GroupBox
    Friend WithEvents llblsuggestions As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents llhelp As System.Windows.Forms.LinkLabel
    Friend WithEvents bgworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents butencrypt As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
