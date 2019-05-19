<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrpms
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpoverwrite = New System.Windows.Forms.DataGridView()
        Me.butdown = New System.Windows.Forms.Button()
        Me.butup = New System.Windows.Forms.Button()
        Me.txtoutfile = New System.Windows.Forms.TextBox()
        Me.butbrowseout = New System.Windows.Forms.Button()
        Me.butbrowse = New System.Windows.Forms.Button()
        Me.lbltarget = New System.Windows.Forms.Label()
        Me.butmergeok = New System.Windows.Forms.Button()
        Me.OpenFileDialogin = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialogout = New System.Windows.Forms.SaveFileDialog()
        Me.butdel = New System.Windows.Forms.Button()
        Me.butusplit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radsplit = New System.Windows.Forms.RadioButton()
        Me.radmerge = New System.Windows.Forms.RadioButton()
        Me.FolderBrowserDialogout = New System.Windows.Forms.FolderBrowserDialog()
        Me.butpanel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.butrotok = New System.Windows.Forms.Button()
        Me.radrotm270 = New System.Windows.Forms.RadioButton()
        Me.radrot270 = New System.Windows.Forms.RadioButton()
        Me.radrotm180 = New System.Windows.Forms.RadioButton()
        Me.radrot180 = New System.Windows.Forms.RadioButton()
        Me.radrotm90 = New System.Windows.Forms.RadioButton()
        Me.radrot0 = New System.Windows.Forms.RadioButton()
        Me.radrot90 = New System.Windows.Forms.RadioButton()
        Me.butsplit = New System.Windows.Forms.Button()
        Me.butduplicate = New System.Windows.Forms.Button()
        Me.numdup = New System.Windows.Forms.NumericUpDown()
        Me.numsplit = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radyes = New System.Windows.Forms.RadioButton()
        Me.radno = New System.Windows.Forms.RadioButton()
        CType(Me.grpoverwrite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numdup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numsplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpoverwrite
        '
        Me.grpoverwrite.AllowDrop = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grpoverwrite.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grpoverwrite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grpoverwrite.DefaultCellStyle = DataGridViewCellStyle4
        Me.grpoverwrite.Location = New System.Drawing.Point(11, 74)
        Me.grpoverwrite.Name = "grpoverwrite"
        Me.grpoverwrite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grpoverwrite.Size = New System.Drawing.Size(853, 393)
        Me.grpoverwrite.TabIndex = 65
        '
        'butdown
        '
        Me.butdown.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butdown.Location = New System.Drawing.Point(11, 48)
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
        Me.butup.Location = New System.Drawing.Point(11, 23)
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
        Me.txtoutfile.Location = New System.Drawing.Point(11, 508)
        Me.txtoutfile.Name = "txtoutfile"
        Me.txtoutfile.Size = New System.Drawing.Size(765, 23)
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
        Me.butbrowse.Location = New System.Drawing.Point(775, 16)
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
        'butdel
        '
        Me.butdel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butdel.ForeColor = System.Drawing.Color.Red
        Me.butdel.Location = New System.Drawing.Point(69, 48)
        Me.butdel.Name = "butdel"
        Me.butdel.Size = New System.Drawing.Size(85, 25)
        Me.butdel.TabIndex = 67
        Me.butdel.Text = "&Delete Row"
        Me.butdel.UseVisualStyleBackColor = True
        '
        'butusplit
        '
        Me.butusplit.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butusplit.ForeColor = System.Drawing.Color.Navy
        Me.butusplit.Location = New System.Drawing.Point(126, 36)
        Me.butusplit.Name = "butusplit"
        Me.butusplit.Size = New System.Drawing.Size(102, 24)
        Me.butusplit.TabIndex = 67
        Me.butusplit.Text = "&User Defined Split"
        Me.butusplit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radsplit)
        Me.GroupBox2.Controls.Add(Me.radmerge)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 468)
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
        Me.butpanel.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpanel.ForeColor = System.Drawing.Color.White
        Me.butpanel.Location = New System.Drawing.Point(700, 10)
        Me.butpanel.Name = "butpanel"
        Me.butpanel.Size = New System.Drawing.Size(76, 60)
        Me.butpanel.TabIndex = 71
        Me.butpanel.Text = "Panel To Import"
        Me.butpanel.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.butrotok)
        Me.GroupBox3.Controls.Add(Me.radrotm270)
        Me.GroupBox3.Controls.Add(Me.radrot270)
        Me.GroupBox3.Controls.Add(Me.radrotm180)
        Me.GroupBox3.Controls.Add(Me.radrot180)
        Me.GroupBox3.Controls.Add(Me.radrotm90)
        Me.GroupBox3.Controls.Add(Me.radrot0)
        Me.GroupBox3.Controls.Add(Me.radrot90)
        Me.GroupBox3.Location = New System.Drawing.Point(297, -1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 73)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rotate (Selected Row)"
        '
        'butrotok
        '
        Me.butrotok.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butrotok.ForeColor = System.Drawing.Color.Black
        Me.butrotok.Location = New System.Drawing.Point(100, 40)
        Me.butrotok.Name = "butrotok"
        Me.butrotok.Size = New System.Drawing.Size(41, 27)
        Me.butrotok.TabIndex = 1
        Me.butrotok.Text = "OK"
        Me.butrotok.UseVisualStyleBackColor = True
        '
        'radrotm270
        '
        Me.radrotm270.AutoSize = True
        Me.radrotm270.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radrotm270.Location = New System.Drawing.Point(55, 52)
        Me.radrotm270.Name = "radrotm270"
        Me.radrotm270.Size = New System.Drawing.Size(46, 17)
        Me.radrotm270.TabIndex = 0
        Me.radrotm270.Text = "-270"
        Me.radrotm270.UseVisualStyleBackColor = True
        '
        'radrot270
        '
        Me.radrot270.AutoSize = True
        Me.radrot270.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radrot270.Location = New System.Drawing.Point(6, 52)
        Me.radrot270.Name = "radrot270"
        Me.radrot270.Size = New System.Drawing.Size(48, 17)
        Me.radrot270.TabIndex = 0
        Me.radrot270.Text = "+270"
        Me.radrot270.UseVisualStyleBackColor = True
        '
        'radrotm180
        '
        Me.radrotm180.AutoSize = True
        Me.radrotm180.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radrotm180.Location = New System.Drawing.Point(55, 34)
        Me.radrotm180.Name = "radrotm180"
        Me.radrotm180.Size = New System.Drawing.Size(46, 17)
        Me.radrotm180.TabIndex = 0
        Me.radrotm180.Text = "-180"
        Me.radrotm180.UseVisualStyleBackColor = True
        '
        'radrot180
        '
        Me.radrot180.AutoSize = True
        Me.radrot180.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radrot180.Location = New System.Drawing.Point(6, 33)
        Me.radrot180.Name = "radrot180"
        Me.radrot180.Size = New System.Drawing.Size(48, 17)
        Me.radrot180.TabIndex = 0
        Me.radrot180.Text = "+180"
        Me.radrot180.UseVisualStyleBackColor = True
        '
        'radrotm90
        '
        Me.radrotm90.AutoSize = True
        Me.radrotm90.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radrotm90.Location = New System.Drawing.Point(55, 15)
        Me.radrotm90.Name = "radrotm90"
        Me.radrotm90.Size = New System.Drawing.Size(40, 17)
        Me.radrotm90.TabIndex = 0
        Me.radrotm90.Text = "-90"
        Me.radrotm90.UseVisualStyleBackColor = True
        '
        'radrot0
        '
        Me.radrot0.AutoSize = True
        Me.radrot0.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radrot0.Location = New System.Drawing.Point(101, 17)
        Me.radrot0.Name = "radrot0"
        Me.radrot0.Size = New System.Drawing.Size(31, 17)
        Me.radrot0.TabIndex = 0
        Me.radrot0.Text = "0"
        Me.radrot0.UseVisualStyleBackColor = True
        '
        'radrot90
        '
        Me.radrot90.AutoSize = True
        Me.radrot90.Checked = True
        Me.radrot90.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radrot90.Location = New System.Drawing.Point(6, 15)
        Me.radrot90.Name = "radrot90"
        Me.radrot90.Size = New System.Drawing.Size(42, 17)
        Me.radrot90.TabIndex = 0
        Me.radrot90.TabStop = True
        Me.radrot90.Text = "+90"
        Me.radrot90.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numsplit)
        Me.GroupBox1.Controls.Add(Me.numdup)
        Me.GroupBox1.Controls.Add(Me.butduplicate)
        Me.GroupBox1.Controls.Add(Me.butsplit)
        Me.GroupBox1.Controls.Add(Me.butusplit)
        Me.GroupBox1.Location = New System.Drawing.Point(456, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 63)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radno)
        Me.GroupBox4.Controls.Add(Me.radyes)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 531)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(126, 37)
        Me.GroupBox4.TabIndex = 73
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Overwrite"
        '
        'radyes
        '
        Me.radyes.AutoSize = True
        Me.radyes.Checked = True
        Me.radyes.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radyes.Location = New System.Drawing.Point(10, 12)
        Me.radyes.Name = "radyes"
        Me.radyes.Size = New System.Drawing.Size(48, 22)
        Me.radyes.TabIndex = 0
        Me.radyes.TabStop = True
        Me.radyes.Text = "YES"
        Me.radyes.UseVisualStyleBackColor = True
        '
        'radno
        '
        Me.radno.AutoSize = True
        Me.radno.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radno.Location = New System.Drawing.Point(64, 12)
        Me.radno.Name = "radno"
        Me.radno.Size = New System.Drawing.Size(46, 22)
        Me.radno.TabIndex = 1
        Me.radno.Text = "NO"
        Me.radno.UseVisualStyleBackColor = True
        '
        'usrpms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.butpanel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.butdel)
        Me.Controls.Add(Me.grpoverwrite)
        Me.Controls.Add(Me.butdown)
        Me.Controls.Add(Me.butup)
        Me.Controls.Add(Me.txtoutfile)
        Me.Controls.Add(Me.butbrowseout)
        Me.Controls.Add(Me.butbrowse)
        Me.Controls.Add(Me.lbltarget)
        Me.Controls.Add(Me.butmergeok)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "usrpms"
        Me.Size = New System.Drawing.Size(875, 571)
        CType(Me.grpoverwrite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numdup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numsplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpoverwrite As System.Windows.Forms.DataGridView
    Friend WithEvents butdown As System.Windows.Forms.Button
    Friend WithEvents butup As System.Windows.Forms.Button
    Friend WithEvents txtoutfile As System.Windows.Forms.TextBox
    Friend WithEvents butbrowseout As System.Windows.Forms.Button
    Friend WithEvents butbrowse As System.Windows.Forms.Button
    Friend WithEvents lbltarget As System.Windows.Forms.Label
    Friend WithEvents butmergeok As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogin As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialogout As System.Windows.Forms.SaveFileDialog
    Friend WithEvents butdel As System.Windows.Forms.Button
    Friend WithEvents butusplit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radsplit As System.Windows.Forms.RadioButton
    Friend WithEvents radmerge As System.Windows.Forms.RadioButton
    Friend WithEvents FolderBrowserDialogout As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents butpanel As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radrotm270 As System.Windows.Forms.RadioButton
    Friend WithEvents radrot270 As System.Windows.Forms.RadioButton
    Friend WithEvents radrotm180 As System.Windows.Forms.RadioButton
    Friend WithEvents radrot180 As System.Windows.Forms.RadioButton
    Friend WithEvents radrotm90 As System.Windows.Forms.RadioButton
    Friend WithEvents radrot90 As System.Windows.Forms.RadioButton
    Friend WithEvents butrotok As System.Windows.Forms.Button
    Friend WithEvents radrot0 As System.Windows.Forms.RadioButton
    Friend WithEvents butsplit As System.Windows.Forms.Button
    Friend WithEvents butduplicate As System.Windows.Forms.Button
    Friend WithEvents numdup As System.Windows.Forms.NumericUpDown
    Friend WithEvents numsplit As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radno As System.Windows.Forms.RadioButton
    Friend WithEvents radyes As System.Windows.Forms.RadioButton


End Class
