<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrpms25
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.butdown = New System.Windows.Forms.Button()
        Me.butup = New System.Windows.Forms.Button()
        Me.txtoutfile = New System.Windows.Forms.TextBox()
        Me.butbrowseout = New System.Windows.Forms.Button()
        Me.butbrowse = New System.Windows.Forms.Button()
        Me.lbltarget = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butmergeok = New System.Windows.Forms.Button()
        Me.OpenFileDialogin = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialogout = New System.Windows.Forms.SaveFileDialog()
        Me.grprotate = New System.Windows.Forms.GroupBox()
        Me.radcircle = New System.Windows.Forms.RadioButton()
        Me.radnormal = New System.Windows.Forms.RadioButton()
        Me.butdel = New System.Windows.Forms.Button()
        Me.butsplit = New System.Windows.Forms.Button()
        Me.butduplicate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numsplit = New System.Windows.Forms.NumericUpDown()
        Me.numdup = New System.Windows.Forms.NumericUpDown()
        Me.butusplit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radsplit = New System.Windows.Forms.RadioButton()
        Me.radmerge = New System.Windows.Forms.RadioButton()
        Me.FolderBrowserDialogout = New System.Windows.Forms.FolderBrowserDialog()
        Me.butpanel = New System.Windows.Forms.Button()
        Me.pms5 = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grprotate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numsplit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numdup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowDrop = True
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(11, 99)
        Me.grid.Name = "grid"
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(847, 362)
        Me.grid.TabIndex = 65
        '
        'butdown
        '
        Me.butdown.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butdown.Location = New System.Drawing.Point(11, 65)
        Me.butdown.Name = "butdown"
        Me.butdown.Size = New System.Drawing.Size(58, 25)
        Me.butdown.TabIndex = 63
        Me.butdown.Text = "DO&WN"
        Me.butdown.UseVisualStyleBackColor = True
        '
        'butup
        '
        Me.butup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butup.Location = New System.Drawing.Point(11, 34)
        Me.butup.Name = "butup"
        Me.butup.Size = New System.Drawing.Size(58, 25)
        Me.butup.TabIndex = 64
        Me.butup.Text = "&UP"
        Me.butup.UseVisualStyleBackColor = True
        '
        'txtoutfile
        '
        Me.txtoutfile.AllowDrop = True
        Me.txtoutfile.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoutfile.Location = New System.Drawing.Point(20, 508)
        Me.txtoutfile.Name = "txtoutfile"
        Me.txtoutfile.Size = New System.Drawing.Size(748, 23)
        Me.txtoutfile.TabIndex = 62
        '
        'butbrowseout
        '
        Me.butbrowseout.AllowDrop = True
        Me.butbrowseout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butbrowseout.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butbrowseout.Location = New System.Drawing.Point(779, 504)
        Me.butbrowseout.Name = "butbrowseout"
        Me.butbrowseout.Size = New System.Drawing.Size(85, 28)
        Me.butbrowseout.TabIndex = 61
        Me.butbrowseout.Text = "BROWSE"
        Me.butbrowseout.UseVisualStyleBackColor = True
        '
        'butbrowse
        '
        Me.butbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butbrowse.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butbrowse.Location = New System.Drawing.Point(767, 44)
        Me.butbrowse.Name = "butbrowse"
        Me.butbrowse.Size = New System.Drawing.Size(91, 49)
        Me.butbrowse.TabIndex = 60
        Me.butbrowse.Text = "BROWSE TO IMPORT"
        Me.butbrowse.UseVisualStyleBackColor = True
        '
        'lbltarget
        '
        Me.lbltarget.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltarget.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltarget.Location = New System.Drawing.Point(321, 479)
        Me.lbltarget.Name = "lbltarget"
        Me.lbltarget.Size = New System.Drawing.Size(228, 26)
        Me.lbltarget.TabIndex = 58
        Me.lbltarget.Text = "TARGET PDF DOCUMENT"
        Me.lbltarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(308, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 26)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "SOURCE PDF DOCUMENTS"
        '
        'butmergeok
        '
        Me.butmergeok.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butmergeok.Location = New System.Drawing.Point(384, 537)
        Me.butmergeok.Name = "butmergeok"
        Me.butmergeok.Size = New System.Drawing.Size(102, 31)
        Me.butmergeok.TabIndex = 57
        Me.butmergeok.Text = "&OK"
        Me.butmergeok.UseVisualStyleBackColor = True
        '
        'OpenFileDialogin
        '
        Me.OpenFileDialogin.Filter = "PDF Files|*.pdf"
        Me.OpenFileDialogin.Multiselect = True
        Me.OpenFileDialogin.RestoreDirectory = True
        '
        'SaveFileDialogout
        '
        Me.SaveFileDialogout.Filter = "PDF Files|*.pdf"
        Me.SaveFileDialogout.RestoreDirectory = True
        '
        'grprotate
        '
        Me.grprotate.Controls.Add(Me.radcircle)
        Me.grprotate.Controls.Add(Me.radnormal)
        Me.grprotate.Location = New System.Drawing.Point(20, 537)
        Me.grprotate.Name = "grprotate"
        Me.grprotate.Size = New System.Drawing.Size(163, 32)
        Me.grprotate.TabIndex = 66
        Me.grprotate.TabStop = False
        Me.grprotate.Text = "Rotation"
        Me.grprotate.Visible = False
        '
        'radcircle
        '
        Me.radcircle.AutoSize = True
        Me.radcircle.Location = New System.Drawing.Point(84, 14)
        Me.radcircle.Name = "radcircle"
        Me.radcircle.Size = New System.Drawing.Size(51, 17)
        Me.radcircle.TabIndex = 67
        Me.radcircle.Text = "Circle"
        Me.radcircle.UseVisualStyleBackColor = True
        '
        'radnormal
        '
        Me.radnormal.AutoSize = True
        Me.radnormal.Checked = True
        Me.radnormal.Location = New System.Drawing.Point(6, 14)
        Me.radnormal.Name = "radnormal"
        Me.radnormal.Size = New System.Drawing.Size(58, 17)
        Me.radnormal.TabIndex = 67
        Me.radnormal.TabStop = True
        Me.radnormal.Text = "Normal"
        Me.radnormal.UseVisualStyleBackColor = True
        '
        'butdel
        '
        Me.butdel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butdel.ForeColor = System.Drawing.Color.Red
        Me.butdel.Location = New System.Drawing.Point(227, 41)
        Me.butdel.Name = "butdel"
        Me.butdel.Size = New System.Drawing.Size(54, 40)
        Me.butdel.TabIndex = 67
        Me.butdel.Text = "&Delete Row"
        Me.butdel.UseVisualStyleBackColor = True
        '
        'butsplit
        '
        Me.butsplit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butsplit.ForeColor = System.Drawing.Color.Navy
        Me.butsplit.Location = New System.Drawing.Point(3, 35)
        Me.butsplit.Name = "butsplit"
        Me.butsplit.Size = New System.Drawing.Size(66, 26)
        Me.butsplit.TabIndex = 67
        Me.butsplit.Text = "&Split"
        Me.butsplit.UseVisualStyleBackColor = True
        '
        'butduplicate
        '
        Me.butduplicate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butduplicate.ForeColor = System.Drawing.Color.Green
        Me.butduplicate.Location = New System.Drawing.Point(3, 8)
        Me.butduplicate.Name = "butduplicate"
        Me.butduplicate.Size = New System.Drawing.Size(66, 26)
        Me.butduplicate.TabIndex = 68
        Me.butduplicate.Text = "&Duplicate"
        Me.butduplicate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numsplit)
        Me.GroupBox1.Controls.Add(Me.numdup)
        Me.GroupBox1.Controls.Add(Me.butduplicate)
        Me.GroupBox1.Controls.Add(Me.butsplit)
        Me.GroupBox1.Location = New System.Drawing.Point(83, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 63)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'numsplit
        '
        Me.numsplit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numsplit.Location = New System.Drawing.Point(76, 37)
        Me.numsplit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numsplit.Name = "numsplit"
        Me.numsplit.Size = New System.Drawing.Size(48, 23)
        Me.numsplit.TabIndex = 69
        Me.numsplit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numdup
        '
        Me.numdup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numdup.Location = New System.Drawing.Point(76, 9)
        Me.numdup.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numdup.Name = "numdup"
        Me.numdup.Size = New System.Drawing.Size(48, 23)
        Me.numdup.TabIndex = 69
        Me.numdup.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'butusplit
        '
        Me.butusplit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butusplit.ForeColor = System.Drawing.Color.Navy
        Me.butusplit.Location = New System.Drawing.Point(576, 60)
        Me.butusplit.Name = "butusplit"
        Me.butusplit.Size = New System.Drawing.Size(130, 29)
        Me.butusplit.TabIndex = 67
        Me.butusplit.Text = "&User Defined Split"
        Me.butusplit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radsplit)
        Me.GroupBox2.Controls.Add(Me.radmerge)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 467)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 37)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Mode"
        '
        'radsplit
        '
        Me.radsplit.AutoSize = True
        Me.radsplit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radsplit.ForeColor = System.Drawing.Color.Navy
        Me.radsplit.Location = New System.Drawing.Point(84, 14)
        Me.radsplit.Name = "radsplit"
        Me.radsplit.Size = New System.Drawing.Size(54, 22)
        Me.radsplit.TabIndex = 1
        Me.radsplit.Text = "Split"
        Me.radsplit.UseVisualStyleBackColor = True
        '
        'radmerge
        '
        Me.radmerge.AutoSize = True
        Me.radmerge.Checked = True
        Me.radmerge.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radmerge.ForeColor = System.Drawing.Color.Red
        Me.radmerge.Location = New System.Drawing.Point(7, 14)
        Me.radmerge.Name = "radmerge"
        Me.radmerge.Size = New System.Drawing.Size(67, 22)
        Me.radmerge.TabIndex = 0
        Me.radmerge.TabStop = True
        Me.radmerge.Text = "Merge"
        Me.radmerge.UseVisualStyleBackColor = True
        '
        'butpanel
        '
        Me.butpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butpanel.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpanel.ForeColor = System.Drawing.Color.White
        Me.butpanel.Location = New System.Drawing.Point(719, 44)
        Me.butpanel.Name = "butpanel"
        Me.butpanel.Size = New System.Drawing.Size(49, 49)
        Me.butpanel.TabIndex = 71
        Me.butpanel.Text = "Panel"
        Me.butpanel.UseVisualStyleBackColor = False
        '
        'pms5
        '
        Me.pms5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pms5.Location = New System.Drawing.Point(226, -1)
        Me.pms5.Name = "pms5"
        Me.pms5.Size = New System.Drawing.Size(69, 27)
        Me.pms5.TabIndex = 75
        Me.pms5.Text = "To Ver 5.0"
        Me.pms5.UseVisualStyleBackColor = True
        '
        'usrpms25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.pms5)
        Me.Controls.Add(Me.butpanel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.butdel)
        Me.Controls.Add(Me.grprotate)
        Me.Controls.Add(Me.butusplit)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.butdown)
        Me.Controls.Add(Me.butup)
        Me.Controls.Add(Me.txtoutfile)
        Me.Controls.Add(Me.butbrowseout)
        Me.Controls.Add(Me.butbrowse)
        Me.Controls.Add(Me.lbltarget)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butmergeok)
        Me.Name = "usrpms25"
        Me.Size = New System.Drawing.Size(875, 571)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grprotate.ResumeLayout(False)
        Me.grprotate.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.numsplit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numdup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents butdown As System.Windows.Forms.Button
    Friend WithEvents butup As System.Windows.Forms.Button
    Friend WithEvents txtoutfile As System.Windows.Forms.TextBox
    Friend WithEvents butbrowseout As System.Windows.Forms.Button
    Friend WithEvents butbrowse As System.Windows.Forms.Button
    Friend WithEvents lbltarget As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butmergeok As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogin As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialogout As System.Windows.Forms.SaveFileDialog
    Friend WithEvents grprotate As System.Windows.Forms.GroupBox
    Friend WithEvents radcircle As System.Windows.Forms.RadioButton
    Friend WithEvents radnormal As System.Windows.Forms.RadioButton
    Friend WithEvents butdel As System.Windows.Forms.Button
    Friend WithEvents butsplit As System.Windows.Forms.Button
    Friend WithEvents butduplicate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents numsplit As System.Windows.Forms.NumericUpDown
    Friend WithEvents numdup As System.Windows.Forms.NumericUpDown
    Friend WithEvents butusplit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radsplit As System.Windows.Forms.RadioButton
    Friend WithEvents radmerge As System.Windows.Forms.RadioButton
    Friend WithEvents FolderBrowserDialogout As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents butpanel As System.Windows.Forms.Button
    Friend WithEvents pms5 As System.Windows.Forms.Button


End Class
