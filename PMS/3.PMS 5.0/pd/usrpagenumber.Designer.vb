﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrpagenumber
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
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialogin = New System.Windows.Forms.OpenFileDialog()
        Me.butdown = New System.Windows.Forms.Button()
        Me.butup = New System.Windows.Forms.Button()
        Me.txtoutfile = New System.Windows.Forms.TextBox()
        Me.butbrowseout = New System.Windows.Forms.Button()
        Me.butbrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butpnok = New System.Windows.Forms.Button()
        Me.radTopLeft = New System.Windows.Forms.RadioButton()
        Me.radTopRight = New System.Windows.Forms.RadioButton()
        Me.radBottomRight = New System.Windows.Forms.RadioButton()
        Me.radBottomLeft = New System.Windows.Forms.RadioButton()
        Me.radTopCenter = New System.Windows.Forms.RadioButton()
        Me.radBottomCenter = New System.Windows.Forms.RadioButton()
        Me.grppagepos = New System.Windows.Forms.GroupBox()
        Me.pageColorDialog = New System.Windows.Forms.ColorDialog()
        Me.pageFontDialog = New System.Windows.Forms.FontDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radBOLDITALIC = New System.Windows.Forms.RadioButton()
        Me.radITALIC = New System.Windows.Forms.RadioButton()
        Me.radBOLD = New System.Windows.Forms.RadioButton()
        Me.radNORMAL = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numfontsize = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radTimesRoman = New System.Windows.Forms.RadioButton()
        Me.radHelvetica = New System.Windows.Forms.RadioButton()
        Me.radCourier = New System.Windows.Forms.RadioButton()
        Me.butchangecolor = New System.Windows.Forms.Button()
        Me.butchangetext = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblpageno = New System.Windows.Forms.Label()
        Me.FolderBrowserDialogout = New System.Windows.Forms.FolderBrowserDialog()
        Me.grpoffset = New System.Windows.Forms.GroupBox()
        Me.numver = New System.Windows.Forms.NumericUpDown()
        Me.numhori = New System.Windows.Forms.NumericUpDown()
        Me.lblver = New System.Windows.Forms.Label()
        Me.lblhori = New System.Windows.Forms.Label()
        Me.conopen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoxitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.butpanel = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grppagepos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numfontsize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grpoffset.SuspendLayout()
        CType(Me.numver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numhori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conopen.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowDrop = True
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(14, 215)
        Me.grid.Name = "grid"
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(847, 267)
        Me.grid.TabIndex = 74
        '
        'OpenFileDialogin
        '
        Me.OpenFileDialogin.Filter = "PDF Files|*.pdf"
        Me.OpenFileDialogin.Multiselect = True
        Me.OpenFileDialogin.RestoreDirectory = True
        '
        'butdown
        '
        Me.butdown.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butdown.Location = New System.Drawing.Point(83, 187)
        Me.butdown.Name = "butdown"
        Me.butdown.Size = New System.Drawing.Size(60, 26)
        Me.butdown.TabIndex = 72
        Me.butdown.Text = "DOWN"
        Me.butdown.UseVisualStyleBackColor = True
        '
        'butup
        '
        Me.butup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butup.Location = New System.Drawing.Point(14, 187)
        Me.butup.Name = "butup"
        Me.butup.Size = New System.Drawing.Size(63, 26)
        Me.butup.TabIndex = 73
        Me.butup.Text = "UP"
        Me.butup.UseVisualStyleBackColor = True
        '
        'txtoutfile
        '
        Me.txtoutfile.AllowDrop = True
        Me.txtoutfile.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoutfile.Location = New System.Drawing.Point(14, 508)
        Me.txtoutfile.Name = "txtoutfile"
        Me.txtoutfile.Size = New System.Drawing.Size(754, 23)
        Me.txtoutfile.TabIndex = 71
        '
        'butbrowseout
        '
        Me.butbrowseout.AllowDrop = True
        Me.butbrowseout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butbrowseout.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butbrowseout.Location = New System.Drawing.Point(781, 508)
        Me.butbrowseout.Name = "butbrowseout"
        Me.butbrowseout.Size = New System.Drawing.Size(80, 24)
        Me.butbrowseout.TabIndex = 70
        Me.butbrowseout.Text = "BROWSE"
        Me.butbrowseout.UseVisualStyleBackColor = True
        '
        'butbrowse
        '
        Me.butbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butbrowse.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butbrowse.Location = New System.Drawing.Point(782, 181)
        Me.butbrowse.Name = "butbrowse"
        Me.butbrowse.Size = New System.Drawing.Size(79, 32)
        Me.butbrowse.TabIndex = 69
        Me.butbrowse.Text = "BROWSE"
        Me.butbrowse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 482)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "TARGET FOLDER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(329, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 26)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "SOURCE PDF DOCUMENTS"
        '
        'butpnok
        '
        Me.butpnok.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpnok.Location = New System.Drawing.Point(385, 537)
        Me.butpnok.Name = "butpnok"
        Me.butpnok.Size = New System.Drawing.Size(102, 31)
        Me.butpnok.TabIndex = 66
        Me.butpnok.Text = "&OK"
        Me.butpnok.UseVisualStyleBackColor = True
        '
        'radTopLeft
        '
        Me.radTopLeft.AutoSize = True
        Me.radTopLeft.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTopLeft.Location = New System.Drawing.Point(10, 19)
        Me.radTopLeft.Name = "radTopLeft"
        Me.radTopLeft.Size = New System.Drawing.Size(67, 19)
        Me.radTopLeft.TabIndex = 75
        Me.radTopLeft.Text = "TopLeft"
        Me.radTopLeft.UseVisualStyleBackColor = True
        '
        'radTopRight
        '
        Me.radTopRight.AutoSize = True
        Me.radTopRight.Checked = True
        Me.radTopRight.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTopRight.Location = New System.Drawing.Point(219, 19)
        Me.radTopRight.Name = "radTopRight"
        Me.radTopRight.Size = New System.Drawing.Size(73, 19)
        Me.radTopRight.TabIndex = 75
        Me.radTopRight.TabStop = True
        Me.radTopRight.Text = "TopRight"
        Me.radTopRight.UseVisualStyleBackColor = True
        '
        'radBottomRight
        '
        Me.radBottomRight.AutoSize = True
        Me.radBottomRight.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBottomRight.Location = New System.Drawing.Point(219, 44)
        Me.radBottomRight.Name = "radBottomRight"
        Me.radBottomRight.Size = New System.Drawing.Size(95, 19)
        Me.radBottomRight.TabIndex = 75
        Me.radBottomRight.Text = "BottomRight"
        Me.radBottomRight.UseVisualStyleBackColor = True
        '
        'radBottomLeft
        '
        Me.radBottomLeft.AutoSize = True
        Me.radBottomLeft.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBottomLeft.Location = New System.Drawing.Point(10, 44)
        Me.radBottomLeft.Name = "radBottomLeft"
        Me.radBottomLeft.Size = New System.Drawing.Size(89, 19)
        Me.radBottomLeft.TabIndex = 75
        Me.radBottomLeft.Text = "BottomLeft"
        Me.radBottomLeft.UseVisualStyleBackColor = True
        '
        'radTopCenter
        '
        Me.radTopCenter.AutoSize = True
        Me.radTopCenter.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTopCenter.Location = New System.Drawing.Point(112, 19)
        Me.radTopCenter.Name = "radTopCenter"
        Me.radTopCenter.Size = New System.Drawing.Size(83, 19)
        Me.radTopCenter.TabIndex = 75
        Me.radTopCenter.Text = "TopCenter"
        Me.radTopCenter.UseVisualStyleBackColor = True
        '
        'radBottomCenter
        '
        Me.radBottomCenter.AutoSize = True
        Me.radBottomCenter.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBottomCenter.Location = New System.Drawing.Point(112, 44)
        Me.radBottomCenter.Name = "radBottomCenter"
        Me.radBottomCenter.Size = New System.Drawing.Size(105, 19)
        Me.radBottomCenter.TabIndex = 75
        Me.radBottomCenter.Text = "BottomCenter"
        Me.radBottomCenter.UseVisualStyleBackColor = True
        '
        'grppagepos
        '
        Me.grppagepos.Controls.Add(Me.radTopCenter)
        Me.grppagepos.Controls.Add(Me.radTopLeft)
        Me.grppagepos.Controls.Add(Me.radBottomLeft)
        Me.grppagepos.Controls.Add(Me.radTopRight)
        Me.grppagepos.Controls.Add(Me.radBottomCenter)
        Me.grppagepos.Controls.Add(Me.radBottomRight)
        Me.grppagepos.Location = New System.Drawing.Point(14, 22)
        Me.grppagepos.Name = "grppagepos"
        Me.grppagepos.Size = New System.Drawing.Size(316, 67)
        Me.grppagepos.TabIndex = 77
        Me.grppagepos.TabStop = False
        Me.grppagepos.Text = "PAGE NUMBER POSITION"
        '
        'pageFontDialog
        '
        Me.pageFontDialog.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.butchangecolor)
        Me.GroupBox1.Controls.Add(Me.butchangetext)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(334, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 159)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAGE NUMBER DESIGNER"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radBOLDITALIC)
        Me.GroupBox3.Controls.Add(Me.radITALIC)
        Me.GroupBox3.Controls.Add(Me.radBOLD)
        Me.GroupBox3.Controls.Add(Me.radNORMAL)
        Me.GroupBox3.Location = New System.Drawing.Point(426, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(106, 100)
        Me.GroupBox3.TabIndex = 89
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Font Style"
        '
        'radBOLDITALIC
        '
        Me.radBOLDITALIC.AutoSize = True
        Me.radBOLDITALIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBOLDITALIC.Location = New System.Drawing.Point(7, 77)
        Me.radBOLDITALIC.Name = "radBOLDITALIC"
        Me.radBOLDITALIC.Size = New System.Drawing.Size(97, 17)
        Me.radBOLDITALIC.TabIndex = 0
        Me.radBOLDITALIC.Text = "BOLDITALIC"
        Me.radBOLDITALIC.UseVisualStyleBackColor = True
        '
        'radITALIC
        '
        Me.radITALIC.AutoSize = True
        Me.radITALIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radITALIC.Location = New System.Drawing.Point(7, 57)
        Me.radITALIC.Name = "radITALIC"
        Me.radITALIC.Size = New System.Drawing.Size(58, 17)
        Me.radITALIC.TabIndex = 0
        Me.radITALIC.Text = "ITALIC"
        Me.radITALIC.UseVisualStyleBackColor = True
        '
        'radBOLD
        '
        Me.radBOLD.AutoSize = True
        Me.radBOLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBOLD.Location = New System.Drawing.Point(7, 35)
        Me.radBOLD.Name = "radBOLD"
        Me.radBOLD.Size = New System.Drawing.Size(58, 17)
        Me.radBOLD.TabIndex = 0
        Me.radBOLD.Text = "BOLD"
        Me.radBOLD.UseVisualStyleBackColor = True
        '
        'radNORMAL
        '
        Me.radNORMAL.AutoSize = True
        Me.radNORMAL.Checked = True
        Me.radNORMAL.Location = New System.Drawing.Point(7, 14)
        Me.radNORMAL.Name = "radNORMAL"
        Me.radNORMAL.Size = New System.Drawing.Size(71, 17)
        Me.radNORMAL.TabIndex = 0
        Me.radNORMAL.TabStop = True
        Me.radNORMAL.Text = "NORMAL"
        Me.radNORMAL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numfontsize)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.radTimesRoman)
        Me.GroupBox2.Controls.Add(Me.radHelvetica)
        Me.GroupBox2.Controls.Add(Me.radCourier)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 92)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Font"
        '
        'numfontsize
        '
        Me.numfontsize.Location = New System.Drawing.Point(100, 56)
        Me.numfontsize.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.numfontsize.Name = "numfontsize"
        Me.numfontsize.Size = New System.Drawing.Size(53, 20)
        Me.numfontsize.TabIndex = 2
        Me.numfontsize.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Size"
        '
        'radTimesRoman
        '
        Me.radTimesRoman.AutoSize = True
        Me.radTimesRoman.Checked = True
        Me.radTimesRoman.Location = New System.Drawing.Point(6, 19)
        Me.radTimesRoman.Name = "radTimesRoman"
        Me.radTimesRoman.Size = New System.Drawing.Size(90, 17)
        Me.radTimesRoman.TabIndex = 0
        Me.radTimesRoman.TabStop = True
        Me.radTimesRoman.Text = "Times-Roman"
        Me.radTimesRoman.UseVisualStyleBackColor = True
        '
        'radHelvetica
        '
        Me.radHelvetica.AutoSize = True
        Me.radHelvetica.Location = New System.Drawing.Point(6, 72)
        Me.radHelvetica.Name = "radHelvetica"
        Me.radHelvetica.Size = New System.Drawing.Size(70, 17)
        Me.radHelvetica.TabIndex = 0
        Me.radHelvetica.Text = "Helvetica"
        Me.radHelvetica.UseVisualStyleBackColor = True
        '
        'radCourier
        '
        Me.radCourier.AutoSize = True
        Me.radCourier.Location = New System.Drawing.Point(6, 46)
        Me.radCourier.Name = "radCourier"
        Me.radCourier.Size = New System.Drawing.Size(58, 17)
        Me.radCourier.TabIndex = 0
        Me.radCourier.Text = "Courier"
        Me.radCourier.UseVisualStyleBackColor = True
        '
        'butchangecolor
        '
        Me.butchangecolor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butchangecolor.Location = New System.Drawing.Point(277, 124)
        Me.butchangecolor.Name = "butchangecolor"
        Me.butchangecolor.Size = New System.Drawing.Size(120, 29)
        Me.butchangecolor.TabIndex = 86
        Me.butchangecolor.Text = "Change Colour ?"
        Me.butchangecolor.UseVisualStyleBackColor = True
        '
        'butchangetext
        '
        Me.butchangetext.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butchangetext.Location = New System.Drawing.Point(79, 23)
        Me.butchangetext.Name = "butchangetext"
        Me.butchangetext.Size = New System.Drawing.Size(120, 23)
        Me.butchangetext.TabIndex = 81
        Me.butchangetext.Text = "Change Text ??"
        Me.butchangetext.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblpageno)
        Me.Panel1.Location = New System.Drawing.Point(6, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 104)
        Me.Panel1.TabIndex = 82
        '
        'lblpageno
        '
        Me.lblpageno.AutoSize = True
        Me.lblpageno.Location = New System.Drawing.Point(18, 25)
        Me.lblpageno.Name = "lblpageno"
        Me.lblpageno.Size = New System.Drawing.Size(90, 13)
        Me.lblpageno.TabIndex = 0
        Me.lblpageno.Text = "PAGE NO:<<N>>"
        '
        'grpoffset
        '
        Me.grpoffset.Controls.Add(Me.numver)
        Me.grpoffset.Controls.Add(Me.numhori)
        Me.grpoffset.Controls.Add(Me.lblver)
        Me.grpoffset.Controls.Add(Me.lblhori)
        Me.grpoffset.Location = New System.Drawing.Point(14, 95)
        Me.grpoffset.Name = "grpoffset"
        Me.grpoffset.Size = New System.Drawing.Size(316, 76)
        Me.grpoffset.TabIndex = 82
        Me.grpoffset.TabStop = False
        Me.grpoffset.Text = "PAGE NUMBER OFFSET"
        '
        'numver
        '
        Me.numver.Location = New System.Drawing.Point(172, 45)
        Me.numver.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numver.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numver.Name = "numver"
        Me.numver.Size = New System.Drawing.Size(120, 20)
        Me.numver.TabIndex = 1
        Me.numver.Value = New Decimal(New Integer() {5, 0, 0, -2147483648})
        '
        'numhori
        '
        Me.numhori.Location = New System.Drawing.Point(172, 16)
        Me.numhori.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numhori.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numhori.Name = "numhori"
        Me.numhori.Size = New System.Drawing.Size(120, 20)
        Me.numhori.TabIndex = 1
        Me.numhori.Value = New Decimal(New Integer() {5, 0, 0, -2147483648})
        '
        'lblver
        '
        Me.lblver.AutoSize = True
        Me.lblver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblver.Location = New System.Drawing.Point(18, 45)
        Me.lblver.Name = "lblver"
        Me.lblver.Size = New System.Drawing.Size(144, 16)
        Me.lblver.TabIndex = 0
        Me.lblver.Text = "Vertical     (In Pixels):"
        '
        'lblhori
        '
        Me.lblhori.AutoSize = True
        Me.lblhori.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhori.Location = New System.Drawing.Point(18, 20)
        Me.lblhori.Name = "lblhori"
        Me.lblhori.Size = New System.Drawing.Size(144, 16)
        Me.lblhori.TabIndex = 0
        Me.lblhori.Text = "Horizontal (In Pixels):"
        '
        'conopen
        '
        Me.conopen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.FoxitToolStripMenuItem})
        Me.conopen.Name = "conopen"
        Me.conopen.Size = New System.Drawing.Size(121, 48)
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'FoxitToolStripMenuItem
        '
        Me.FoxitToolStripMenuItem.Name = "FoxitToolStripMenuItem"
        Me.FoxitToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.FoxitToolStripMenuItem.Text = "Foxit"
        '
        'butpanel
        '
        Me.butpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butpanel.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpanel.ForeColor = System.Drawing.Color.White
        Me.butpanel.Location = New System.Drawing.Point(703, 181)
        Me.butpanel.Name = "butpanel"
        Me.butpanel.Size = New System.Drawing.Size(76, 33)
        Me.butpanel.TabIndex = 83
        Me.butpanel.Text = "Panel"
        Me.butpanel.UseVisualStyleBackColor = False
        '
        'usrpagenumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.Controls.Add(Me.butpanel)
        Me.Controls.Add(Me.grpoffset)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grppagepos)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtoutfile)
        Me.Controls.Add(Me.butbrowseout)
        Me.Controls.Add(Me.butdown)
        Me.Controls.Add(Me.butup)
        Me.Controls.Add(Me.butbrowse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.butpnok)
        Me.Controls.Add(Me.Label1)
        Me.Name = "usrpagenumber"
        Me.Size = New System.Drawing.Size(875, 571)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grppagepos.ResumeLayout(False)
        Me.grppagepos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numfontsize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpoffset.ResumeLayout(False)
        Me.grpoffset.PerformLayout()
        CType(Me.numver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numhori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conopen.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialogin As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butdown As System.Windows.Forms.Button
    Friend WithEvents butup As System.Windows.Forms.Button
    Friend WithEvents txtoutfile As System.Windows.Forms.TextBox
    Friend WithEvents butbrowseout As System.Windows.Forms.Button
    Friend WithEvents butbrowse As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butpnok As System.Windows.Forms.Button
    Friend WithEvents radTopLeft As System.Windows.Forms.RadioButton
    Friend WithEvents radTopRight As System.Windows.Forms.RadioButton
    Friend WithEvents radBottomRight As System.Windows.Forms.RadioButton
    Friend WithEvents radBottomLeft As System.Windows.Forms.RadioButton
    Friend WithEvents radTopCenter As System.Windows.Forms.RadioButton
    Friend WithEvents radBottomCenter As System.Windows.Forms.RadioButton
    Friend WithEvents grppagepos As System.Windows.Forms.GroupBox
    Friend WithEvents pageColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents pageFontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents butchangecolor As System.Windows.Forms.Button
    Friend WithEvents butchangetext As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblpageno As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialogout As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents grpoffset As System.Windows.Forms.GroupBox
    Friend WithEvents lblhori As System.Windows.Forms.Label
    Friend WithEvents lblver As System.Windows.Forms.Label
    Friend WithEvents numver As System.Windows.Forms.NumericUpDown
    Friend WithEvents numhori As System.Windows.Forms.NumericUpDown
    Friend WithEvents conopen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoxitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radTimesRoman As System.Windows.Forms.RadioButton
    Friend WithEvents radCourier As System.Windows.Forms.RadioButton
    Friend WithEvents radHelvetica As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radBOLDITALIC As System.Windows.Forms.RadioButton
    Friend WithEvents radITALIC As System.Windows.Forms.RadioButton
    Friend WithEvents radBOLD As System.Windows.Forms.RadioButton
    Friend WithEvents radNORMAL As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numfontsize As System.Windows.Forms.NumericUpDown
    Friend WithEvents butpanel As System.Windows.Forms.Button

End Class
