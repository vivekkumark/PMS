<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrencrypt
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.butpanel = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.butbrowse = New System.Windows.Forms.Button()
        Me.grpPermissions = New System.Windows.Forms.GroupBox()
        Me.chkAllowFillIn = New System.Windows.Forms.CheckBox()
        Me.chkAllowAssembly = New System.Windows.Forms.CheckBox()
        Me.chkAllowModifyAnnotations = New System.Windows.Forms.CheckBox()
        Me.chkAllowModifyContents = New System.Windows.Forms.CheckBox()
        Me.chkAllowScreenReaders = New System.Windows.Forms.CheckBox()
        Me.chkAllowDegradedPrinting = New System.Windows.Forms.CheckBox()
        Me.chkAllowCopy = New System.Windows.Forms.CheckBox()
        Me.chkAllowPrinting = New System.Windows.Forms.CheckBox()
        Me.TTencrypt = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtpassowner = New System.Windows.Forms.TextBox()
        Me.chkpassowner = New System.Windows.Forms.CheckBox()
        Me.txtpassuser = New System.Windows.Forms.TextBox()
        Me.chkpassuser = New System.Windows.Forms.CheckBox()
        Me.butstart = New System.Windows.Forms.Button()
        Me.grpDecrypt = New System.Windows.Forms.GroupBox()
        Me.butimportpass = New System.Windows.Forms.Button()
        Me.butclearall = New System.Windows.Forms.Button()
        Me.butdeletedecrptpass = New System.Windows.Forms.Button()
        Me.butadddecryptpass = New System.Windows.Forms.Button()
        Me.txtdecryptpass = New System.Windows.Forms.TextBox()
        Me.listdecryptpass = New System.Windows.Forms.ListBox()
        Me.OpenFileDialogin = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogtxt = New System.Windows.Forms.OpenFileDialog()
        Me.grpbruteforce = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.butspecial = New System.Windows.Forms.Button()
        Me.butcaps = New System.Windows.Forms.Button()
        Me.butSmallChar = New System.Windows.Forms.Button()
        Me.butNumbers = New System.Windows.Forms.Button()
        Me.rtxtbruteforce = New System.Windows.Forms.RichTextBox()
        Me.nummaxpass = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numminpass = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblrootlable = New System.Windows.Forms.Label()
        Me.txtrootpath = New System.Windows.Forms.TextBox()
        Me.butoutfolder = New System.Windows.Forms.Button()
        Me.txtoutpath = New System.Windows.Forms.TextBox()
        Me.radpath = New System.Windows.Forms.RadioButton()
        Me.raddirect = New System.Windows.Forms.RadioButton()
        Me.FolderBrowserDialogout = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPermissions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpDecrypt.SuspendLayout()
        Me.grpbruteforce.SuspendLayout()
        CType(Me.nummaxpass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numminpass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'butpanel
        '
        Me.butpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butpanel.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpanel.ForeColor = System.Drawing.Color.White
        Me.butpanel.Location = New System.Drawing.Point(435, 133)
        Me.butpanel.Name = "butpanel"
        Me.butpanel.Size = New System.Drawing.Size(81, 38)
        Me.butpanel.TabIndex = 74
        Me.butpanel.Text = "Panel"
        Me.butpanel.UseVisualStyleBackColor = False
        '
        'grid
        '
        Me.grid.AllowDrop = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle4
        Me.grid.Location = New System.Drawing.Point(4, 178)
        Me.grid.Name = "grid"
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(605, 285)
        Me.grid.TabIndex = 73
        '
        'butbrowse
        '
        Me.butbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butbrowse.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butbrowse.Location = New System.Drawing.Point(522, 133)
        Me.butbrowse.Name = "butbrowse"
        Me.butbrowse.Size = New System.Drawing.Size(81, 38)
        Me.butbrowse.TabIndex = 72
        Me.butbrowse.Text = "BROWSE"
        Me.butbrowse.UseVisualStyleBackColor = True
        '
        'grpPermissions
        '
        Me.grpPermissions.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.grpPermissions.Controls.Add(Me.chkAllowFillIn)
        Me.grpPermissions.Controls.Add(Me.chkAllowAssembly)
        Me.grpPermissions.Controls.Add(Me.chkAllowModifyAnnotations)
        Me.grpPermissions.Controls.Add(Me.chkAllowModifyContents)
        Me.grpPermissions.Controls.Add(Me.chkAllowScreenReaders)
        Me.grpPermissions.Controls.Add(Me.chkAllowDegradedPrinting)
        Me.grpPermissions.Controls.Add(Me.chkAllowCopy)
        Me.grpPermissions.Controls.Add(Me.chkAllowPrinting)
        Me.grpPermissions.Enabled = False
        Me.grpPermissions.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPermissions.Location = New System.Drawing.Point(29, 120)
        Me.grpPermissions.Name = "grpPermissions"
        Me.grpPermissions.Size = New System.Drawing.Size(222, 247)
        Me.grpPermissions.TabIndex = 75
        Me.grpPermissions.TabStop = False
        Me.grpPermissions.Text = "PERMISSIONS"
        '
        'chkAllowFillIn
        '
        Me.chkAllowFillIn.AutoSize = True
        Me.chkAllowFillIn.Location = New System.Drawing.Point(13, 215)
        Me.chkAllowFillIn.Name = "chkAllowFillIn"
        Me.chkAllowFillIn.Size = New System.Drawing.Size(82, 19)
        Me.chkAllowFillIn.TabIndex = 0
        Me.chkAllowFillIn.Text = "AllowFillIn"
        Me.chkAllowFillIn.UseVisualStyleBackColor = True
        '
        'chkAllowAssembly
        '
        Me.chkAllowAssembly.AutoSize = True
        Me.chkAllowAssembly.Location = New System.Drawing.Point(14, 103)
        Me.chkAllowAssembly.Name = "chkAllowAssembly"
        Me.chkAllowAssembly.Size = New System.Drawing.Size(109, 19)
        Me.chkAllowAssembly.TabIndex = 0
        Me.chkAllowAssembly.Text = "AllowAssembly"
        Me.chkAllowAssembly.UseVisualStyleBackColor = True
        '
        'chkAllowModifyAnnotations
        '
        Me.chkAllowModifyAnnotations.AutoSize = True
        Me.chkAllowModifyAnnotations.Location = New System.Drawing.Point(13, 186)
        Me.chkAllowModifyAnnotations.Name = "chkAllowModifyAnnotations"
        Me.chkAllowModifyAnnotations.Size = New System.Drawing.Size(162, 19)
        Me.chkAllowModifyAnnotations.TabIndex = 0
        Me.chkAllowModifyAnnotations.Text = "AllowModifyAnnotations"
        Me.chkAllowModifyAnnotations.UseVisualStyleBackColor = True
        '
        'chkAllowModifyContents
        '
        Me.chkAllowModifyContents.AutoSize = True
        Me.chkAllowModifyContents.Location = New System.Drawing.Point(14, 74)
        Me.chkAllowModifyContents.Name = "chkAllowModifyContents"
        Me.chkAllowModifyContents.Size = New System.Drawing.Size(145, 19)
        Me.chkAllowModifyContents.TabIndex = 0
        Me.chkAllowModifyContents.Text = "AllowModifyContents"
        Me.chkAllowModifyContents.UseVisualStyleBackColor = True
        '
        'chkAllowScreenReaders
        '
        Me.chkAllowScreenReaders.AutoSize = True
        Me.chkAllowScreenReaders.Location = New System.Drawing.Point(13, 157)
        Me.chkAllowScreenReaders.Name = "chkAllowScreenReaders"
        Me.chkAllowScreenReaders.Size = New System.Drawing.Size(138, 19)
        Me.chkAllowScreenReaders.TabIndex = 0
        Me.chkAllowScreenReaders.Text = "AllowScreenReaders"
        Me.chkAllowScreenReaders.UseVisualStyleBackColor = True
        '
        'chkAllowDegradedPrinting
        '
        Me.chkAllowDegradedPrinting.AutoSize = True
        Me.chkAllowDegradedPrinting.Location = New System.Drawing.Point(14, 45)
        Me.chkAllowDegradedPrinting.Name = "chkAllowDegradedPrinting"
        Me.chkAllowDegradedPrinting.Size = New System.Drawing.Size(153, 19)
        Me.chkAllowDegradedPrinting.TabIndex = 0
        Me.chkAllowDegradedPrinting.Text = "AllowDegradedPrinting"
        Me.chkAllowDegradedPrinting.UseVisualStyleBackColor = True
        '
        'chkAllowCopy
        '
        Me.chkAllowCopy.AutoSize = True
        Me.chkAllowCopy.Location = New System.Drawing.Point(14, 128)
        Me.chkAllowCopy.Name = "chkAllowCopy"
        Me.chkAllowCopy.Size = New System.Drawing.Size(84, 19)
        Me.chkAllowCopy.TabIndex = 0
        Me.chkAllowCopy.Text = "AllowCopy"
        Me.chkAllowCopy.UseVisualStyleBackColor = True
        '
        'chkAllowPrinting
        '
        Me.chkAllowPrinting.AccessibleDescription = ""
        Me.chkAllowPrinting.AccessibleName = ""
        Me.chkAllowPrinting.AutoSize = True
        Me.chkAllowPrinting.Location = New System.Drawing.Point(15, 16)
        Me.chkAllowPrinting.Name = "chkAllowPrinting"
        Me.chkAllowPrinting.Size = New System.Drawing.Size(100, 19)
        Me.chkAllowPrinting.TabIndex = 0
        Me.chkAllowPrinting.Tag = ""
        Me.chkAllowPrinting.Text = "AllowPrinting"
        Me.chkAllowPrinting.UseVisualStyleBackColor = True
        '
        'TTencrypt
        '
        Me.TTencrypt.Tag = ""
        Me.TTencrypt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TTencrypt.ToolTipTitle = "Des"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Controls.Add(Me.txtpassowner)
        Me.GroupBox1.Controls.Add(Me.grpPermissions)
        Me.GroupBox1.Controls.Add(Me.chkpassowner)
        Me.GroupBox1.Controls.Add(Me.txtpassuser)
        Me.GroupBox1.Controls.Add(Me.chkpassuser)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(609, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 384)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set Password"
        '
        'txtpassowner
        '
        Me.txtpassowner.Enabled = False
        Me.txtpassowner.Location = New System.Drawing.Point(6, 91)
        Me.txtpassowner.Name = "txtpassowner"
        Me.txtpassowner.Size = New System.Drawing.Size(245, 23)
        Me.txtpassowner.TabIndex = 2
        '
        'chkpassowner
        '
        Me.chkpassowner.AutoSize = True
        Me.chkpassowner.Location = New System.Drawing.Point(5, 73)
        Me.chkpassowner.Name = "chkpassowner"
        Me.chkpassowner.Size = New System.Drawing.Size(250, 19)
        Me.chkpassowner.TabIndex = 0
        Me.chkpassowner.Text = "Permissions Password (Owner Password)"
        Me.chkpassowner.UseVisualStyleBackColor = True
        '
        'txtpassuser
        '
        Me.txtpassuser.Enabled = False
        Me.txtpassuser.Location = New System.Drawing.Point(7, 39)
        Me.txtpassuser.Name = "txtpassuser"
        Me.txtpassuser.Size = New System.Drawing.Size(244, 23)
        Me.txtpassuser.TabIndex = 2
        '
        'chkpassuser
        '
        Me.chkpassuser.AutoSize = True
        Me.chkpassuser.Location = New System.Drawing.Point(6, 21)
        Me.chkpassuser.Name = "chkpassuser"
        Me.chkpassuser.Size = New System.Drawing.Size(202, 19)
        Me.chkpassuser.TabIndex = 0
        Me.chkpassuser.Text = "Open Password (User Password)"
        Me.chkpassuser.UseVisualStyleBackColor = True
        '
        'butstart
        '
        Me.butstart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butstart.Location = New System.Drawing.Point(609, 510)
        Me.butstart.Name = "butstart"
        Me.butstart.Size = New System.Drawing.Size(63, 47)
        Me.butstart.TabIndex = 77
        Me.butstart.Text = "Start"
        Me.butstart.UseVisualStyleBackColor = True
        '
        'grpDecrypt
        '
        Me.grpDecrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpDecrypt.Controls.Add(Me.butimportpass)
        Me.grpDecrypt.Controls.Add(Me.butclearall)
        Me.grpDecrypt.Controls.Add(Me.butdeletedecrptpass)
        Me.grpDecrypt.Controls.Add(Me.butadddecryptpass)
        Me.grpDecrypt.Controls.Add(Me.txtdecryptpass)
        Me.grpDecrypt.Controls.Add(Me.listdecryptpass)
        Me.grpDecrypt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDecrypt.Location = New System.Drawing.Point(4, 41)
        Me.grpDecrypt.Name = "grpDecrypt"
        Me.grpDecrypt.Size = New System.Drawing.Size(355, 130)
        Me.grpDecrypt.TabIndex = 78
        Me.grpDecrypt.TabStop = False
        Me.grpDecrypt.Text = "To Decrypt Files (Passwords List)"
        '
        'butimportpass
        '
        Me.butimportpass.Location = New System.Drawing.Point(206, 10)
        Me.butimportpass.Name = "butimportpass"
        Me.butimportpass.Size = New System.Drawing.Size(143, 39)
        Me.butimportpass.TabIndex = 4
        Me.butimportpass.Text = "Import Passwords From TextFile"
        Me.butimportpass.UseVisualStyleBackColor = True
        '
        'butclearall
        '
        Me.butclearall.Location = New System.Drawing.Point(145, 85)
        Me.butclearall.Name = "butclearall"
        Me.butclearall.Size = New System.Drawing.Size(60, 26)
        Me.butclearall.TabIndex = 3
        Me.butclearall.Text = "ClearAll"
        Me.butclearall.UseVisualStyleBackColor = True
        '
        'butdeletedecrptpass
        '
        Me.butdeletedecrptpass.Location = New System.Drawing.Point(145, 55)
        Me.butdeletedecrptpass.Name = "butdeletedecrptpass"
        Me.butdeletedecrptpass.Size = New System.Drawing.Size(60, 26)
        Me.butdeletedecrptpass.TabIndex = 3
        Me.butdeletedecrptpass.Text = "Clear"
        Me.butdeletedecrptpass.UseVisualStyleBackColor = True
        '
        'butadddecryptpass
        '
        Me.butadddecryptpass.Location = New System.Drawing.Point(149, 13)
        Me.butadddecryptpass.Name = "butadddecryptpass"
        Me.butadddecryptpass.Size = New System.Drawing.Size(51, 27)
        Me.butadddecryptpass.TabIndex = 3
        Me.butadddecryptpass.Text = "Add"
        Me.butadddecryptpass.UseVisualStyleBackColor = True
        '
        'txtdecryptpass
        '
        Me.txtdecryptpass.Location = New System.Drawing.Point(6, 16)
        Me.txtdecryptpass.Name = "txtdecryptpass"
        Me.txtdecryptpass.Size = New System.Drawing.Size(137, 22)
        Me.txtdecryptpass.TabIndex = 2
        '
        'listdecryptpass
        '
        Me.listdecryptpass.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listdecryptpass.FormattingEnabled = True
        Me.listdecryptpass.Location = New System.Drawing.Point(6, 42)
        Me.listdecryptpass.Name = "listdecryptpass"
        Me.listdecryptpass.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listdecryptpass.Size = New System.Drawing.Size(137, 82)
        Me.listdecryptpass.TabIndex = 1
        '
        'OpenFileDialogin
        '
        Me.OpenFileDialogin.Filter = "PDF Files|*.pdf"
        Me.OpenFileDialogin.Multiselect = True
        Me.OpenFileDialogin.RestoreDirectory = True
        '
        'OpenFileDialogtxt
        '
        Me.OpenFileDialogtxt.Filter = "Text Files|*.txt"
        Me.OpenFileDialogtxt.RestoreDirectory = True
        '
        'grpbruteforce
        '
        Me.grpbruteforce.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpbruteforce.Controls.Add(Me.Label4)
        Me.grpbruteforce.Controls.Add(Me.butspecial)
        Me.grpbruteforce.Controls.Add(Me.butcaps)
        Me.grpbruteforce.Controls.Add(Me.butSmallChar)
        Me.grpbruteforce.Controls.Add(Me.butNumbers)
        Me.grpbruteforce.Controls.Add(Me.rtxtbruteforce)
        Me.grpbruteforce.Controls.Add(Me.nummaxpass)
        Me.grpbruteforce.Controls.Add(Me.Label3)
        Me.grpbruteforce.Controls.Add(Me.numminpass)
        Me.grpbruteforce.Controls.Add(Me.Label2)
        Me.grpbruteforce.Controls.Add(Me.Label1)
        Me.grpbruteforce.Location = New System.Drawing.Point(377, 5)
        Me.grpbruteforce.Name = "grpbruteforce"
        Me.grpbruteforce.Size = New System.Drawing.Size(489, 98)
        Me.grpbruteforce.TabIndex = 80
        Me.grpbruteforce.TabStop = False
        Me.grpbruteforce.Text = "Brute Force"
        Me.grpbruteforce.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Type The Chars"
        '
        'butspecial
        '
        Me.butspecial.Location = New System.Drawing.Point(378, 7)
        Me.butspecial.Name = "butspecial"
        Me.butspecial.Size = New System.Drawing.Size(87, 22)
        Me.butspecial.TabIndex = 4
        Me.butspecial.Text = "Special Chars"
        Me.butspecial.UseVisualStyleBackColor = True
        '
        'butcaps
        '
        Me.butcaps.Location = New System.Drawing.Point(280, 7)
        Me.butcaps.Name = "butcaps"
        Me.butcaps.Size = New System.Drawing.Size(87, 22)
        Me.butcaps.TabIndex = 4
        Me.butcaps.Text = "Capital Letters"
        Me.butcaps.UseVisualStyleBackColor = True
        '
        'butSmallChar
        '
        Me.butSmallChar.Location = New System.Drawing.Point(192, 8)
        Me.butSmallChar.Name = "butSmallChar"
        Me.butSmallChar.Size = New System.Drawing.Size(76, 22)
        Me.butSmallChar.TabIndex = 4
        Me.butSmallChar.Text = "Small Letters"
        Me.butSmallChar.UseVisualStyleBackColor = True
        '
        'butNumbers
        '
        Me.butNumbers.Location = New System.Drawing.Point(113, 8)
        Me.butNumbers.Name = "butNumbers"
        Me.butNumbers.Size = New System.Drawing.Size(68, 22)
        Me.butNumbers.TabIndex = 4
        Me.butNumbers.Text = "Numbers"
        Me.butNumbers.UseVisualStyleBackColor = True
        '
        'rtxtbruteforce
        '
        Me.rtxtbruteforce.Location = New System.Drawing.Point(113, 46)
        Me.rtxtbruteforce.Name = "rtxtbruteforce"
        Me.rtxtbruteforce.Size = New System.Drawing.Size(370, 46)
        Me.rtxtbruteforce.TabIndex = 3
        Me.rtxtbruteforce.Text = ""
        '
        'nummaxpass
        '
        Me.nummaxpass.Location = New System.Drawing.Point(52, 64)
        Me.nummaxpass.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.nummaxpass.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nummaxpass.Name = "nummaxpass"
        Me.nummaxpass.Size = New System.Drawing.Size(56, 20)
        Me.nummaxpass.TabIndex = 2
        Me.nummaxpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nummaxpass.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Max"
        '
        'numminpass
        '
        Me.numminpass.Location = New System.Drawing.Point(52, 39)
        Me.numminpass.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.numminpass.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numminpass.Name = "numminpass"
        Me.numminpass.Size = New System.Drawing.Size(55, 20)
        Me.numminpass.TabIndex = 2
        Me.numminpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numminpass.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Min"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pass Word Length"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblrootlable)
        Me.GroupBox2.Controls.Add(Me.txtrootpath)
        Me.GroupBox2.Controls.Add(Me.butoutfolder)
        Me.GroupBox2.Controls.Add(Me.txtoutpath)
        Me.GroupBox2.Controls.Add(Me.radpath)
        Me.GroupBox2.Controls.Add(Me.raddirect)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 469)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(603, 99)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Option"
        '
        'lblrootlable
        '
        Me.lblrootlable.AutoSize = True
        Me.lblrootlable.Location = New System.Drawing.Point(17, 68)
        Me.lblrootlable.Name = "lblrootlable"
        Me.lblrootlable.Size = New System.Drawing.Size(109, 13)
        Me.lblrootlable.TabIndex = 5
        Me.lblrootlable.Text = "Enter Root Path Here"
        '
        'txtrootpath
        '
        Me.txtrootpath.Location = New System.Drawing.Point(20, 80)
        Me.txtrootpath.Name = "txtrootpath"
        Me.txtrootpath.Size = New System.Drawing.Size(492, 20)
        Me.txtrootpath.TabIndex = 4
        '
        'butoutfolder
        '
        Me.butoutfolder.Location = New System.Drawing.Point(518, 41)
        Me.butoutfolder.Name = "butoutfolder"
        Me.butoutfolder.Size = New System.Drawing.Size(76, 28)
        Me.butoutfolder.TabIndex = 3
        Me.butoutfolder.Text = "Browse"
        Me.butoutfolder.UseVisualStyleBackColor = True
        '
        'txtoutpath
        '
        Me.txtoutpath.Location = New System.Drawing.Point(20, 47)
        Me.txtoutpath.Name = "txtoutpath"
        Me.txtoutpath.Size = New System.Drawing.Size(492, 20)
        Me.txtoutpath.TabIndex = 2
        '
        'radpath
        '
        Me.radpath.AutoSize = True
        Me.radpath.Location = New System.Drawing.Point(19, 31)
        Me.radpath.Name = "radpath"
        Me.radpath.Size = New System.Drawing.Size(309, 17)
        Me.radpath.TabIndex = 1
        Me.radpath.Text = "Paste the Encrypted Or Decryped File In The Following Path"
        Me.radpath.UseVisualStyleBackColor = True
        '
        'raddirect
        '
        Me.raddirect.AutoSize = True
        Me.raddirect.Checked = True
        Me.raddirect.Location = New System.Drawing.Point(19, 13)
        Me.raddirect.Name = "raddirect"
        Me.raddirect.Size = New System.Drawing.Size(231, 17)
        Me.raddirect.TabIndex = 0
        Me.raddirect.TabStop = True
        Me.raddirect.Text = "Encrypt Or Decrypt The Source File Directly"
        Me.raddirect.UseVisualStyleBackColor = True
        '
        'usrencrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpbruteforce)
        Me.Controls.Add(Me.grpDecrypt)
        Me.Controls.Add(Me.butstart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.butpanel)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.butbrowse)
        Me.Name = "usrencrypt"
        Me.Size = New System.Drawing.Size(875, 571)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPermissions.ResumeLayout(False)
        Me.grpPermissions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDecrypt.ResumeLayout(False)
        Me.grpDecrypt.PerformLayout()
        Me.grpbruteforce.ResumeLayout(False)
        Me.grpbruteforce.PerformLayout()
        CType(Me.nummaxpass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numminpass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butpanel As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents butbrowse As System.Windows.Forms.Button
    Friend WithEvents grpPermissions As System.Windows.Forms.GroupBox
    Friend WithEvents chkAllowPrinting As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowModifyContents As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowDegradedPrinting As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowFillIn As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowAssembly As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowModifyAnnotations As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowScreenReaders As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowCopy As System.Windows.Forms.CheckBox
    Friend WithEvents TTencrypt As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkpassuser As System.Windows.Forms.CheckBox
    Friend WithEvents txtpassuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpassowner As System.Windows.Forms.TextBox
    Friend WithEvents chkpassowner As System.Windows.Forms.CheckBox
    Friend WithEvents butstart As System.Windows.Forms.Button
    Friend WithEvents grpDecrypt As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialogin As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butdeletedecrptpass As System.Windows.Forms.Button
    Friend WithEvents butadddecryptpass As System.Windows.Forms.Button
    Friend WithEvents txtdecryptpass As System.Windows.Forms.TextBox
    Friend WithEvents listdecryptpass As System.Windows.Forms.ListBox
    Friend WithEvents butimportpass As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogtxt As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butclearall As System.Windows.Forms.Button
    Friend WithEvents grpbruteforce As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numminpass As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nummaxpass As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtxtbruteforce As System.Windows.Forms.RichTextBox
    Friend WithEvents butNumbers As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents butspecial As System.Windows.Forms.Button
    Friend WithEvents butcaps As System.Windows.Forms.Button
    Friend WithEvents butSmallChar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radpath As System.Windows.Forms.RadioButton
    Friend WithEvents raddirect As System.Windows.Forms.RadioButton
    Friend WithEvents butoutfolder As System.Windows.Forms.Button
    Friend WithEvents txtoutpath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialogout As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtrootpath As System.Windows.Forms.TextBox
    Friend WithEvents lblrootlable As System.Windows.Forms.Label

End Class
