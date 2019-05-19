Imports System.Data.OleDb
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.IO
Imports PdfSharp.Pdf.IO
Imports System.Drawing
Public Class usrpagenumber
    Dim cola As PdfSharp.Forms.ColorComboBox = New PdfSharp.Forms.ColorComboBox()

    Private Sub butchangefont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butchangefont.Click
        pageFontDialog.ShowDialog()
        lblpageno.Font = New Font(pageFontDialog.Font.FontFamily.ToString, pageFontDialog.Font.Size, pageFontDialog.Font.Style, GraphicsUnit.Pixel)
    End Sub
    Private Sub butchangecolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pageColorDialog.ShowDialog()
        lblpageno.ForeColor = pageColorDialog.Color
    End Sub
    Private Sub usrpagenumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'grid.ContextMenu.Name = "conopen"

        cola.Location = New Point(325, 100)
        cola.Show()
        cola.SelectedIndex = 1
        Me.GroupBox1.Controls.Add(cola)

        radTopRight.Checked = True
        lblpageno.Font = pageFontDialog.Font
        lblpageno.ForeColor = pageColorDialog.Color

        Dim col As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        col.HeaderText = ""
        col.Name = "Cselect"
        col.Width = 30
        col.ReadOnly = True
        grid.Columns.Add(col)

        grid.Columns.Add("CPATH", "PATH")
        grid.Columns("CPATH").Width = 50
        grid.Columns("CPATH").ReadOnly = True

        grid.Columns.Add("CFNAME", "FILE NAME")
        grid.Columns("CFNAME").Width = 250
        grid.Columns("CFNAME").ReadOnly = True

        grid.Columns.Add("CTP", "TOTAL PAGES")
        grid.Columns("CTP").Width = 50
        grid.Columns("CTP").ReadOnly = True

        grid.Columns.Add("CPTN", "PAGES FOR PN")
        grid.Columns("CPTN").Width = 250

        grid.Columns.Add("CSPN", "START PN")
        grid.Columns("CSPN").Width = 50

        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = True
        grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub
    Public Sub grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellClick
        If e.ColumnIndex = 0 Then
            grid.CurrentCell.Value = Not grid.CurrentCell.Value
        End If
    End Sub

    Public Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.ColumnIndex = 1 Then
            System.Diagnostics.Process.Start(grid.CurrentCell.Value.ToString)
        ElseIf e.ColumnIndex = 2 Then
            Try
                If frmPMS.radfoxit.Checked Then
                    Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                    Dim h As Object = obj.GetFile(grid.Rows(e.RowIndex).Cells(1).Value.ToString & grid.CurrentCell.Value.ToString)
                    System.Diagnostics.Process.Start("Foxit.exe", h.shortpath)
                ElseIf frmPMS.radeditor.Checked Then
                    Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                    Dim h As Object = obj.GetFile(grid.Rows(e.RowIndex).Cells(1).Value.ToString & grid.CurrentCell.Value.ToString)
                    System.Diagnostics.Process.Start("PDFEdit.exe", h.shortpath)
                Else
                    System.Diagnostics.Process.Start(grid.Rows(e.RowIndex).Cells(1).Value.ToString & grid.CurrentCell.Value.ToString)
                End If
            Catch ex As Exception
                System.Diagnostics.Process.Start(grid.Rows(e.RowIndex).Cells(1).Value.ToString & grid.CurrentCell.Value.ToString)
            End Try
        End If
    End Sub
    Private Sub butchangetext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butchangetext.Click
        Dim Str1 As String
        Str1 = InputBox("Enter Text:", "New Text", lblpageno.Text)
        'If Str1 <> "" Then
        '    lblpageno.Text = Str1
        'End If
    End Sub
    Public Sub grid_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid.DragDrop
        Dim listprotectedfiles As String = ""
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Dim filelist As New List(Of String)
            For Each fileLoc As String In filePaths
                If FileIO.FileSystem.DirectoryExists(fileLoc) Then
                    For Each files In FileIO.FileSystem.GetFiles(fileLoc, FileIO.SearchOption.SearchAllSubDirectories, "*.pdf")
                        filelist.Add(files)
                    Next
                Else
                    If fileLoc.ToLower.EndsWith(".pdf") Then
                        filelist.Add(fileLoc)
                    End If
                End If
            Next
            Dim readflag As Boolean = False
            For Each fileLoc As String In filelist
                Try
                    Dim document As PdfDocument = CompatiblePdfReader.Open(fileLoc)
                    document.Close()
                    grid.Rows.Add()
                    grid.Rows(grid.Rows.Count - 1).Cells("CSelect").Value = True
                    grid.Rows(grid.Rows.Count - 1).Cells("CPATH").Value = fileLoc.Replace(FileIO.FileSystem.GetName(fileLoc), "")
                    grid.Rows(grid.Rows.Count - 1).Cells("CFNAME").Value = FileIO.FileSystem.GetName(fileLoc)
                    grid.Rows(grid.Rows.Count - 1).Cells("CTP").Value = document.PageCount
                    grid.Rows(grid.Rows.Count - 1).Cells("CPTN").Value = "1-" & document.PageCount
                    grid.Rows(grid.Rows.Count - 1).Cells("CSPN").Value = "1"
                Catch ex As Exception
                    readflag = True
                    listprotectedfiles = listprotectedfiles & vbLf & fileLoc
                End Try
            Next
            If readflag = True Then
                MsgBox("The following Protected Files Are Skiped" & listprotectedfiles)
            End If
        End If
    End Sub
    Public Sub butbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butbrowse.Click
        Try
            OpenFileDialogin.ShowDialog()
            Dim readflag As Boolean = False
            Dim listprotectedfiles As String = ""
            For k1 = 0 To OpenFileDialogin.SafeFileNames.Length - 1
                Try
                    Dim document As PdfDocument = CompatiblePdfReader.Open(OpenFileDialogin.FileNames(k1))
                    document.Close()
                    grid.Rows.Add()
                    grid.Rows(grid.Rows.Count - 1).Cells("CSelect").Value = True
                    grid.Rows(grid.Rows.Count - 1).Cells("CPATH").Value = OpenFileDialogin.FileNames(k1).Replace(OpenFileDialogin.SafeFileNames(k1), "")
                    grid.Rows(grid.Rows.Count - 1).Cells("CFNAME").Value = OpenFileDialogin.SafeFileNames(k1)
                    grid.Rows(grid.Rows.Count - 1).Cells("CTP").Value = document.PageCount
                    grid.Rows(grid.Rows.Count - 1).Cells("CPTN").Value = "1-" & document.PageCount
                    grid.Rows(grid.Rows.Count - 1).Cells("CSPN").Value = "1"
                Catch ex As Exception
                    readflag = True
                    listprotectedfiles = listprotectedfiles & vbLf & OpenFileDialogin.FileNames(k1)
                End Try
            Next
            If readflag = True Then
                MsgBox("The following Protected Files Are Skiped" & listprotectedfiles)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub grid_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grid.CellValidating
        Dim kkk1 As Int16
        If grid.CurrentCell.ColumnIndex = 4 Then
            Try
                If grid.CurrentCell.EditedFormattedValue.ToString.Contains(",") Then
                    MsgBox("Please Enter The Page Range Correctly")
                    e.Cancel = True
                    Exit Sub
                End If

                kkk1 = CInt(grid.CurrentCell.EditedFormattedValue.ToString.Split("-")(0))
                If kkk1 > CInt(grid.Rows(e.RowIndex).Cells(3).Value.ToString) Then
                    MsgBox("Please Enter A Page Number Within Total Pages")
                    e.Cancel = True
                    Exit Sub
                End If

                If kkk1 < 1 Then
                    MsgBox("Please Enter A Page Number Greater Than 1")
                    e.Cancel = True
                    Exit Sub
                End If

                kkk1 = CInt(grid.CurrentCell.EditedFormattedValue.ToString.Split("-")(1))
                If kkk1 > CInt(grid.Rows(e.RowIndex).Cells(3).Value.ToString) Then
                    MsgBox("Please Enter A Page Number Within Total Pages")
                    e.Cancel = True
                    Exit Sub
                End If
                If kkk1 < 1 Then
                    MsgBox("Please Enter A Page Number Greater Than 1")
                    e.Cancel = True
                    Exit Sub
                End If

            Catch ex As Exception
                MsgBox("Please Enter The Page Range Correctly")
                e.Cancel = True
            End Try

        End If
        If grid.CurrentCell.ColumnIndex = 5 Then
            Try
                kkk1 = CInt(grid.CurrentCell.EditedFormattedValue.ToString)
                If kkk1 < 1 Then
                    MsgBox("Page Number Can Not Be Less Than One")
                    e.Cancel = True
                End If
            Catch ex As Exception
                MsgBox("Please Enter The Starting Page Number Correctly")
                e.Cancel = True
            End Try
        End If

    End Sub
    Public Sub grid_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Public Sub butup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butup.Click
        Try
            If grid.SelectedRows.Count <> 1 Then
                MsgBox("Please Select One Row")
                Exit Sub
            End If
            For k1 = 0 To grid.SelectedRows.Count - 1
                swaprow(grid.SelectedRows(k1).Cells(0).RowIndex - 1, grid.SelectedRows(k1).Cells(0).RowIndex)
                Dim srow As Int16 = grid.SelectedRows(k1).Cells(0).RowIndex
                grid.Rows(srow).Selected = False
                grid.Rows(srow - 1).Selected = True
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub swaprow(ByRef r1 As Int16, ByRef r2 As Int16)

        For k1 = 0 To grid.ColumnCount - 1
            Dim temp As Object = grid.Rows(r1).Cells(k1).Value
            grid.Rows(r1).Cells(k1).Value = grid.Rows(r2).Cells(k1).Value
            grid.Rows(r2).Cells(k1).Value = temp
        Next
    End Sub
    Public Sub butdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butdown.Click
        Try
            If grid.SelectedRows.Count <> 1 Then
                MsgBox("Please Select One Row")
                Exit Sub
            End If
            For k1 = 0 To grid.SelectedRows.Count - 1
                swaprow(grid.SelectedRows(k1).Cells(0).RowIndex + 1, grid.SelectedRows(k1).Cells(0).RowIndex)
                Dim srow As Int16 = grid.SelectedRows(k1).Cells(0).RowIndex
                grid.Rows(srow).Selected = False
                grid.Rows(srow + 1).Selected = True
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub butbrowseout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butbrowseout.Click
        FolderBrowserDialogout.ShowDialog()
        txtoutfile.Text = FolderBrowserDialogout.SelectedPath
    End Sub

    Private Sub butpnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butpnok.Click

        Try
            If grid.RowCount < 1 Then
                MsgBox("Please Add Atleast One Source File(Browse Or DragDrop[File(s) Or Folder(s)])")
                Exit Sub
            End If

            If txtoutfile.Text = "" Then
                MsgBox("Please Select OutPut Folder To Save PDF Files")
                Exit Sub
            End If

            Dim ndoc As Boolean = False
            For k1 = 0 To grid.RowCount - 1
                If grid.Rows(k1).Cells("CSelect").Value = True Then
                    ndoc = True
                End If
            Next
            If ndoc = False Then
                MsgBox("Please Select Atleast One Document")
                Exit Sub
            End If
            Dim newpdfdoc As PdfDocument

            For k1 = 0 To grid.RowCount - 1
                If grid.Rows(k1).Cells("CSelect").Value = False Then
                    Continue For
                End If

                newpdfdoc = New PdfDocument()

                Dim fname As String = grid.Rows(k1).Cells(1).Value.ToString & grid.Rows(k1).Cells(2).Value.ToString
                Dim tpdfdoc As PdfDocument = CompatiblePdfReader.Open(fname)

                Dim v1 As Int16 = CInt(grid.Rows(k1).Cells(4).Value.ToString.Split("-")(0))
                Dim v2 As Int16 = CInt(grid.Rows(k1).Cells(4).Value.ToString.Split("-")(1))

                If v2 < v1 Then
                    Dim temp As Int16 = v1
                    v1 = v2
                    v2 = temp
                End If

                For p1 = 0 To tpdfdoc.Pages.Count - 1
                    newpdfdoc.AddPage(tpdfdoc.Pages(p1))
                Next


                Dim pn As Int16 = grid.Rows(k1).Cells(5).Value

                For c1 = 0 To newpdfdoc.Pages.Count - 1

                    If (c1 + 1) >= v1 And (c1 + 1) <= v2 Then

                        Dim gfx As XGraphics = XGraphics.FromPdfPage(newpdfdoc.Pages(c1))
                        Dim pagestr As String = lblpageno.Text.Replace("<<N>>", CStr(pn)).Replace("<<n>>", CStr(pn))
                        Dim gr As Graphics = Me.CreateGraphics
                        Dim wid As Int16 = CInt(gr.MeasureString(pagestr, pageFontDialog.Font).Width)
                        Dim hig As Int16 = CInt(gr.MeasureString(pagestr, pageFontDialog.Font).Height)
                        Dim pagepos As XRect

                        newpdfdoc.Pages(c1).Rotate = 0
                        Dim hor, ver As Int16
                        If newpdfdoc.Pages(c1).Rotate = 90 Or newpdfdoc.Pages(c1).Rotate = 270 Then

                            If radTopLeft.Checked Then
                                hor = 0
                                ver = 0
                            ElseIf radTopCenter.Checked Then
                                hor = newpdfdoc.Pages(c1).Height.Point / 2 - wid / 2
                                ver = 0
                            ElseIf radTopRight.Checked Then
                                hor = newpdfdoc.Pages(c1).Height.Point - wid
                                ver = 0
                            ElseIf radBottomLeft.Checked Then
                                hor = 0
                                ver = newpdfdoc.Pages(c1).Width.Point - hig
                            ElseIf radBottomCenter.Checked Then
                                hor = newpdfdoc.Pages(c1).Height.Point / 2 - wid / 2
                                ver = newpdfdoc.Pages(c1).Width.Point - hig
                            ElseIf radBottomRight.Checked Then
                                hor = newpdfdoc.Pages(c1).Height.Point - wid
                                ver = newpdfdoc.Pages(c1).Width.Point - hig
                            End If
                        Else
                            If radTopLeft.Checked Then
                                hor = 0
                                ver = 0
                            ElseIf radTopCenter.Checked Then
                                hor = newpdfdoc.Pages(c1).Width.Point / 2 - wid / 2
                                ver = 0
                            ElseIf radTopRight.Checked Then
                                hor = newpdfdoc.Pages(c1).Width.Point - wid
                                ver = 0
                            ElseIf radBottomLeft.Checked Then
                                hor = 0
                                ver = newpdfdoc.Pages(c1).Height.Point - hig
                            ElseIf radBottomCenter.Checked Then
                                hor = newpdfdoc.Pages(c1).Width.Point / 2 - wid / 2
                                ver = newpdfdoc.Pages(c1).Height.Point - hig
                            ElseIf radBottomRight.Checked Then
                                hor = newpdfdoc.Pages(c1).Width.Point - wid
                                ver = newpdfdoc.Pages(c1).Height.Point - hig
                            End If
                        End If

                        hor += CInt(numhori.Value)
                        ver += CInt(numver.Value)
                        pagepos = New XRect(hor, ver, wid, hig)

                        gfx.DrawString(pagestr, New XFont(pageFontDialog.Font.FontFamily.ToString, pageFontDialog.Font.Size, pageFontDialog.Font.Style), New PdfSharp.Drawing.XSolidBrush(cola.Color), pagepos, XStringFormats.Center)
                        pn += 1

                    End If
                Next

                newpdfdoc.Save(txtoutfile.Text & "\" & grid.Rows(k1).Cells(2).Value.ToString)

                If radcircle.Checked Then
                    Dim cnewpdfdoc As New PdfDocument
                    newpdfdoc = CompatiblePdfReader.Open(txtoutfile.Text & "\" & grid.Rows(k1).Cells(2).Value.ToString)
                    If newpdfdoc.PageCount Mod 2 Then
                        newpdfdoc.AddPage()
                    End If

                    For pp1 As Int16 = 1 To CInt(newpdfdoc.PageCount / 2)
                        cnewpdfdoc.AddPage(newpdfdoc.Pages(pp1 - 1))
                        newpdfdoc.Pages(newpdfdoc.PageCount - pp1).Rotate = 180
                        cnewpdfdoc.AddPage(newpdfdoc.Pages(newpdfdoc.PageCount - pp1))
                    Next
                    newpdfdoc = cnewpdfdoc
                    newpdfdoc.Save(txtoutfile.Text & "\" & grid.Rows(k1).Cells(2).Value.ToString)
                End If


            Next
            If MsgBox("Page Numbers Has Been Added Successfully.Do You Want To Open", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Process.Start(txtoutfile.Text)
                Try
                    If frmPMS.radfoxit.Checked Then
                        Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                        Dim h As Object = obj.GetFile(txtoutfile.Text & "\" & grid.Rows(0).Cells(2).Value.ToString)
                        System.Diagnostics.Process.Start("Foxit.exe", h.shortpath)
                    ElseIf frmPMS.radeditor.Checked Then
                        Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                        Dim h As Object = obj.GetFile(txtoutfile.Text & "\" & grid.Rows(0).Cells(2).Value.ToString)
                        System.Diagnostics.Process.Start("PDFEdit.exe", h.shortpath)
                    Else
                        System.Diagnostics.Process.Start(txtoutfile.Text & "\" & grid.Rows(0).Cells(2).Value.ToString)
                    End If
                Catch ex As Exception
                    Try
                        System.Diagnostics.Process.Start(txtoutfile.Text & "\" & grid.Rows(0).Cells(2).Value.ToString)
                    Catch ex1 As Exception

                    End Try
                End Try
            End If
        Catch ex As Exception
            MsgBox("Page Numbers Have Not Been Added Successfully.Please Close All Opened PDF Documents Then Try Again", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtoutfile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtoutfile.DoubleClick
        Try
            System.Diagnostics.Process.Start(txtoutfile.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem.Click
        MsgBox("hI")
    End Sub

    Private Sub txtoutfile_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtoutfile.DragEnter, butbrowseout.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub txtoutfile_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtoutfile.DragDrop, butbrowseout.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If filePaths.Length > 0 Then
                Dim path As String = ""
                If FileIO.FileSystem.FileExists(filePaths(0)) Then
                    path = FileIO.FileSystem.GetParentPath(filePaths(0))
                ElseIf FileIO.FileSystem.DirectoryExists(filePaths(0)) Then
                    path = filePaths(0)
                End If
                If path <> "" Then
                    FolderBrowserDialogout.SelectedPath = ""
                    FolderBrowserDialogout.SelectedPath = path
                    FolderBrowserDialogout.ShowDialog()
                    txtoutfile.Text = FolderBrowserDialogout.SelectedPath
                End If
            End If
        End If
    End Sub

End Class
