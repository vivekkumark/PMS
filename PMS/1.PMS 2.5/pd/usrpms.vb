Imports System.Data.OleDb
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.IO
Imports PdfSharp.Pdf.IO
Public Class usrpms
    Private Sub mergefiles()
        Try
            If grid.RowCount < 1 Then
                MsgBox("Please Add Atleast One Source File(Browse Or DragDrop[File(s) Or Folder(s)])")
                Exit Sub
            End If

            If Strings.Right(txtoutfile.Text, 4).ToLower <> ".pdf" Then
                MsgBox("Please Enter Target File Name(Browse) Properly")
                Exit Sub
            End If

            Dim ndoc As Boolean = False
            For k1 = 0 To grid.RowCount - 1
                If grid.Rows(k1).Cells("CSelect").Value = True Then
                    ndoc = True
                End If
            Next
            If ndoc = False Then
                MsgBox("Please Select Atleast One Document(Chech Box)")
                Exit Sub
            End If

            Dim newpdfdoc As PdfDocument
            newpdfdoc = New PdfDocument()

            For k1 = 0 To grid.RowCount - 1
                If grid.Rows(k1).Cells("CSelect").Value = False Then
                    Continue For
                End If
                Dim fname As String = grid.Rows(k1).Cells(1).Value.ToString & grid.Rows(k1).Cells(2).Value.ToString
                Dim tpdfdoc As PdfDocument = CompatiblePdfReader.Open(fname)
                Dim s() As String = grid.Rows(k1).Cells(4).Value.ToString.Split(",")
                For s1 = 0 To s.Length - 1
                    If s(s1).Contains("-") = True Then
                        Dim v1 As Int16 = CInt(s(s1).Split("-")(0))
                        Dim v2 As Int16 = CInt(s(s1).Split("-")(1))
                        If v2 < v1 Then
                            Dim temp As Int16 = v1
                            v1 = v2
                            v2 = temp
                        End If
                        For kk1 = v1 To v2
                            tpdfdoc.Pages(kk1 - 1).Rotate = CInt(grid.Rows(k1).Cells("ROT").Value)
                            newpdfdoc.AddPage(tpdfdoc.Pages(kk1 - 1))
                        Next
                    Else
                        tpdfdoc.Pages(CInt(s(s1)) - 1).Rotate = CInt(grid.Rows(k1).Cells("ROT").Value)
                        newpdfdoc.AddPage(tpdfdoc.Pages(CInt(s(s1)) - 1))
                    End If
                Next
            Next

            If newpdfdoc.PageCount < 1 Then
                MsgBox("Please Give Proper Value In PAGES TO MERGE Column" & vbLf _
                        & "0 Document Is Merged")
            Else


                newpdfdoc.Save(txtoutfile.Text)

                If radcircle.Checked Then
                    Dim cnewpdfdoc As New PdfDocument
                    newpdfdoc = CompatiblePdfReader.Open(txtoutfile.Text)
                    If newpdfdoc.PageCount Mod 2 Then
                        newpdfdoc.AddPage()
                    End If

                    For pp1 As Int16 = 1 To CInt(newpdfdoc.PageCount / 2)
                        cnewpdfdoc.AddPage(newpdfdoc.Pages(pp1 - 1))
                        newpdfdoc.Pages(newpdfdoc.PageCount - pp1).Rotate = 180
                        cnewpdfdoc.AddPage(newpdfdoc.Pages(newpdfdoc.PageCount - pp1))
                    Next
                    newpdfdoc = cnewpdfdoc
                End If

                newpdfdoc.Save(FileIO.FileSystem.GetParentPath(txtoutfile.Text) & "\~PMSTEMP.PDF")
                CompatiblePdfReader.PdfChangeversion(txtoutfile.Text)
                FileIO.FileSystem.DeleteFile(FileIO.FileSystem.GetParentPath(txtoutfile.Text) & "\~PMSTEMP.PDF")

                If MsgBox("Files Are Merged Successfully.Do You Want To Open", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        If frmPMS.radfoxit.Checked Then
                            Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                            Dim h As Object = obj.GetFile(txtoutfile.Text)
                            System.Diagnostics.Process.Start("Foxit.exe", h.shortpath)
                        ElseIf frmPMS.radeditor.Checked Then
                            Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                            Dim h As Object = obj.GetFile(txtoutfile.Text)
                            System.Diagnostics.Process.Start("PDFEdit.exe", h.shortpath)
                        Else
                            System.Diagnostics.Process.Start(txtoutfile.Text)
                        End If
                    Catch ex As Exception
                        System.Diagnostics.Process.Start(txtoutfile.Text)
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Files Are Not Merged Successfully", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Function getfilename(ByVal path As String, ByVal rtfname As String) As String
        rtfname = Strings.Replace(Strings.Left(rtfname, Len(rtfname) - 4), ".pdf", "")
        If path(path.Length - 1) <> "\" Then
            path = path & "\"
        End If

        Dim k1 As UInt32 = 1
        While FileIO.FileSystem.FileExists(path & rtfname & "-" & CStr(k1) & ".pdf")
            k1 += 1
        End While
        getfilename = path & rtfname & "-" & CStr(k1) & ".pdf"
    End Function
    Private Sub splitfiles()
        Try
            If grid.RowCount < 1 Then
                MsgBox("Please Add Atleast One Source File(Browse Or DragDrop[File(s) Or Folder(s)])")
                Exit Sub
            End If

            If FileIO.FileSystem.DirectoryExists(txtoutfile.Text) = False Then
                MsgBox("Please Enter Target Path.Properly")
                Exit Sub
            End If

            Dim ndoc As Boolean = False
            For k1 = 0 To grid.RowCount - 1
                If grid.Rows(k1).Cells("CSelect").Value = True Then
                    ndoc = True
                End If
            Next
            If ndoc = False Then
                MsgBox("Please Select Atleast One Document(Chech Box)")
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
                Dim s() As String = grid.Rows(k1).Cells(4).Value.ToString.Split(",")
                For s1 = 0 To s.Length - 1
                    If s(s1).Contains("-") = True Then
                        Dim v1 As Int16 = CInt(s(s1).Split("-")(0))
                        Dim v2 As Int16 = CInt(s(s1).Split("-")(1))
                        If v2 < v1 Then
                            Dim temp As Int16 = v1
                            v1 = v2
                            v2 = temp
                        End If
                        For kk1 = v1 To v2
                            tpdfdoc.Pages(kk1 - 1).Rotate = CInt(grid.Rows(k1).Cells("ROT").Value)
                            newpdfdoc.AddPage(tpdfdoc.Pages(kk1 - 1))
                        Next
                    Else
                        tpdfdoc.Pages(CInt(s(s1)) - 1).Rotate = CInt(grid.Rows(k1).Cells("ROT").Value)
                        newpdfdoc.AddPage(tpdfdoc.Pages(CInt(s(s1)) - 1))
                    End If
                Next



                If radcircle.Checked Then
                    Dim cnewpdfdoc As New PdfDocument

                    If newpdfdoc.PageCount Mod 2 Then
                        newpdfdoc.AddPage()
                    End If

                    For pp1 As Int16 = 1 To CInt(newpdfdoc.PageCount / 2)
                        cnewpdfdoc.AddPage(newpdfdoc.Pages(pp1 - 1))
                        newpdfdoc.Pages(newpdfdoc.PageCount - pp1).Rotate = 180
                        cnewpdfdoc.AddPage(newpdfdoc.Pages(newpdfdoc.PageCount - pp1))
                    Next
                    newpdfdoc = cnewpdfdoc
                End If

                newpdfdoc.Save(getfilename(txtoutfile.Text, grid.Rows(k1).Cells(2).Value.ToString))

            Next


            If MsgBox("Files Are split Successfully.Do You Want To Open", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(txtoutfile.Text)
            End If

        Catch ex As Exception
            MsgBox("Files Are Not Split Successfully", MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub butmergeok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butmergeok.Click

        'Dim document As PdfDocument = PdfReader.Open("D:\FS.pdf")
        'Dim font As XFont = New XFont("Verdana", 20, XFontStyle.Bold)
        'For k1 = 0 To document.Pages.Count - 1
        '    Dim gfx As XGraphics = XGraphics.FromPdfPage(document.Pages(k1))
        '    Dim pagestr As String = "PAGE No:" & CStr(k1 + 1)
        '    Dim gr As Graphics = Me.CreateGraphics
        '    Dim wid As Int16 = CInt(gr.MeasureString(pagestr, New Font("Verdana", 20, FontStyle.Bold)).Width)
        '    Dim hig As Int16 = CInt(gr.MeasureString(pagestr, New Font("Verdana", 20, FontStyle.Bold)).Height)
        '    'gfx.DrawString(pagestr, font, XBrushes.Black, New XRect(document.Pages(k1).Width.Point - wid, 0, wid, hig), XStringFormats.TopCenter)
        '    gfx.DrawString(pagestr, font, XBrushes.Black, New XRect(document.Pages(k1).Width.Point - wid, 0, wid, hig), XStringFormats.TopCenter)
        'Next
        'Dim filename As String = "HelloWorld.pdf"
        'document.Save(filename)
        'Process.Start(filename)

        If radmerge.Checked Then
            mergefiles()
        Else
            splitfiles()
        End If

    End Sub

    Public Sub butbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butbrowse.Click
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
                grid.Rows(grid.Rows.Count - 1).Cells("CPTM").Value = "1-" & document.PageCount
                grid.Rows(grid.Rows.Count - 1).Cells("ROT").Value = "0"
                grid.Rows(grid.Rows.Count - 1).Cells("ROT").Style.ForeColor = Color.Red
            Catch ex As Exception
                readflag = True
                listprotectedfiles = listprotectedfiles & vbLf & OpenFileDialogin.FileNames(k1)
            End Try
        Next
        If readflag = True Then
            MsgBox("The following Protected Files Are Skiped" & listprotectedfiles)
        End If
    End Sub


    Public Overridable Sub usrpdfpage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


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
        grid.Columns("CFNAME").Width = 200
        grid.Columns("CFNAME").ReadOnly = True

        grid.Columns.Add("CTP", "TOTAL PAGES")
        grid.Columns("CTP").Width = 200
        grid.Columns("CTP").ReadOnly = True

        grid.Columns.Add("CPTM", "PAGES TO MERGE")
        grid.Columns("CPTM").Width = 200

        grid.Columns.Add("ROT", "ROTATION")
        grid.Columns("ROT").Width = 100
        grid.Columns("ROT").ReadOnly = True


        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = True
        grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


    End Sub

    Public Sub grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellClick
        Try
            If e.ColumnIndex = 0 Then
                grid.CurrentCell.Value = Not grid.CurrentCell.Value
            ElseIf e.ColumnIndex = 5 Then
                grid.CurrentCell.Value = (grid.CurrentCell.Value + 90) Mod 360
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.ColumnIndex = 1 Then
            Try
                System.Diagnostics.Process.Start(grid.CurrentCell.Value.ToString)
            Catch ex2 As Exception

            End Try
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
                Try
                    System.Diagnostics.Process.Start(grid.Rows(e.RowIndex).Cells(1).Value.ToString & grid.CurrentCell.Value.ToString)
                Catch ex1 As Exception

                End Try
            End Try
        End If
    End Sub

    Public Sub butbrowseout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butbrowseout.Click
        If radmerge.Checked Then
            SaveFileDialogout.ShowDialog()
            txtoutfile.Text = SaveFileDialogout.FileName
        Else
            FolderBrowserDialogout.ShowDialog()
            txtoutfile.Text = FolderBrowserDialogout.SelectedPath
        End If
    End Sub

    Public Sub grid_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grid.CellValidating
        If grid.CurrentCell.ColumnIndex = 4 Then
            Try
                Dim s() As String = grid.CurrentCell.EditedFormattedValue.ToString.Split(",")
                Dim kkk1 As Int16
                For s1 = 0 To s.Length - 1
                    If s(s1).Contains("-") = True Then
                        kkk1 = CInt(s(s1).Split("-")(0))
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

                        kkk1 = CInt(s(s1).Split("-")(1))
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
                    Else
                        kkk1 = CInt(s(s1))
                        If kkk1 < 1 Then
                            MsgBox("Please Enter A Page Number Greater Than 1")
                            e.Cancel = True
                            Exit Sub
                        End If
                        If kkk1 > CInt(grid.Rows(e.RowIndex).Cells(3).Value.ToString) Then
                            MsgBox("Please Enter A Page Number Within Total Pages")
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                Next
            Catch ex As Exception
                MsgBox("Please Enter The Pages Correctly")
                e.Cancel = True
                Exit Sub
            End Try

        End If
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
                    grid.Rows(grid.Rows.Count - 1).Cells("CPTM").Value = "1-" & document.PageCount
                    grid.Rows(grid.Rows.Count - 1).Cells("ROT").Value = "0"
                    grid.Rows(grid.Rows.Count - 1).Cells("ROT").Style.ForeColor = Color.Red
                Catch ex As Exception
                    readflag = True
                    listprotectedfiles = listprotectedfiles & vbLf & fileLoc
                End Try
            Next
            If readflag = True Then
                MsgBox("The following Files could not read" & listprotectedfiles)
            End If
        End If
    End Sub
    Public Sub grid_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub UP()
        Try
            Dim Arow() As Int16
            ReDim Arow(grid.SelectedRows.Count - 1)
            Dim k1 As Int16 = 0

            For Each row As DataGridViewRow In grid.SelectedRows
                Arow(k1) = row.Index
                k1 += 1
            Next

            If UBound(Arow) > 0 Then
                For kk1 = 0 To UBound(Arow)
                    For kk2 = 0 To UBound(Arow)
                        If Arow(kk2) > Arow(kk1) Then
                            Dim temp As Int16
                            temp = Arow(kk2)
                            Arow(kk2) = Arow(kk1)
                            Arow(kk1) = temp
                        End If
                    Next
                Next
            End If

            If Arow(0) = 0 Then
                'MsgBox("Can Not Move,One Of Your Selected row has been reached top")
                Exit Sub
            End If

            For k2 = 0 To UBound(Arow)
                swaprow(Arow(k2), Arow(k2) - 1)
            Next



            'swaprow(row.Index - 1, row.Index)
            'If grid.SelectedRows.Count <> 1 Then
            '    MsgBox("Please Select One Row")
            '    Exit Sub
            'End If
            'For k1 = 0 To grid.SelectedRows.Count - 1
            '    swaprow(grid.SelectedRows(k1).Cells(0).RowIndex - 1, grid.SelectedRows(k1).Cells(0).RowIndex)
            '    Dim srow As Int16 = grid.SelectedRows(k1).Cells(0).RowIndex
            '    grid.Rows(srow).Selected = False
            '    grid.Rows(srow - 1).Selected = True
            'Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub butup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butup.Click
        UP()
    End Sub
    Public Sub swaprow(ByRef r1 As Int16, ByRef r2 As Int16)

        For k1 = 0 To grid.ColumnCount - 1
            If r2 < 0 Or r1 < 0 Or r1 >= grid.Rows.Count Or r2 >= grid.Rows.Count Then
                Exit Sub
            End If
            Dim temp As Object = grid.Rows(r1).Cells(k1).Value
            grid.Rows(r1).Cells(k1).Value = grid.Rows(r2).Cells(k1).Value
            grid.Rows(r2).Cells(k1).Value = temp
            grid.Rows(r1).Selected = False
            grid.Rows(r2).Selected = True
        Next
    End Sub
    Private Sub DOWN()
        Try
            Dim Arow() As Int16
            ReDim Arow(grid.SelectedRows.Count - 1)
            Dim k1 As Int16 = 0

            For Each row As DataGridViewRow In grid.SelectedRows
                Arow(k1) = row.Index
                k1 += 1
            Next

            If UBound(Arow) > 0 Then
                For kk1 = 0 To UBound(Arow)
                    For kk2 = 0 To UBound(Arow)
                        If Arow(kk2) < Arow(kk1) Then
                            Dim temp As Int16
                            temp = Arow(kk2)
                            Arow(kk2) = Arow(kk1)
                            Arow(kk1) = temp
                        End If
                    Next
                Next
            End If

            If Arow(0) = grid.Rows.Count - 1 Then
                'MsgBox("Can Not Move,One Of Your Selected row has been reached Bottom")
                Exit Sub
            End If

            For k2 = 0 To UBound(Arow)
                swaprow(Arow(k2), Arow(k2) + 1)
            Next

            'If grid.SelectedRows.Count <> 1 Then
            '    MsgBox("Please Select One Row")
            '    Exit Sub
            'End If
            'For k1 = 0 To grid.SelectedRows.Count - 1
            '    swaprow(grid.SelectedRows(k1).Cells(0).RowIndex + 1, grid.SelectedRows(k1).Cells(0).RowIndex)
            '    Dim srow As Int16 = grid.SelectedRows(k1).Cells(0).RowIndex
            '    grid.Rows(srow).Selected = False
            '    grid.Rows(srow + 1).Selected = True
            'Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub butdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butdown.Click
        DOWN()
    End Sub

    Private Sub butbrowseout_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtoutfile.DragDrop, butbrowseout.DragDrop
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
                    If radmerge.Checked Then
                        SaveFileDialogout.RestoreDirectory = False
                        SaveFileDialogout.FileName = ""
                        SaveFileDialogout.InitialDirectory = path
                        SaveFileDialogout.RestoreDirectory = True
                        SaveFileDialogout.ShowDialog()
                        txtoutfile.Text = SaveFileDialogout.FileName
                    Else
                        FolderBrowserDialogout.SelectedPath = ""
                        FolderBrowserDialogout.SelectedPath = path
                        FolderBrowserDialogout.ShowDialog()
                        txtoutfile.Text = FolderBrowserDialogout.SelectedPath
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub butbrowseout_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtoutfile.DragEnter, butbrowseout.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub butdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butdel.Click
        For Each row As DataGridViewRow In grid.SelectedRows
            grid.Rows.Remove(row)
        Next
    End Sub

    Private Sub butduplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butduplicate.Click
        If grid.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In grid.SelectedRows
                Dim k1 As Int16
                For k1 = row.Index To row.Index + numdup.Value - 1
                    grid.Rows.InsertCopy(k1, k1 + 1)
                    For c1 = 0 To grid.Columns.Count - 1
                        grid.Rows(k1 + 1).Cells(c1).Value = row.Cells(c1).Value
                    Next
                Next
            Next
        Else
            MsgBox("Please Select Atleast One Row")
        End If

    End Sub

    Private Sub butsplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butsplit.Click
        If grid.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In grid.SelectedRows
                Dim k1 As Int16
                Dim nrow As Int32
                Dim stp As Int32 = 1
                Dim ctp As Int32 = row.Cells("CTP").Value

                nrow = Math.Ceiling(row.Cells("CTP").Value * 1.0 / numsplit.Value)
                For k1 = row.Index To row.Index + nrow - 1
                    grid.Rows.InsertCopy(k1, k1 + 1)

                    grid.Rows(k1 + 1).Cells("CSELECT").Value = row.Cells("CSELECT").Value
                    grid.Rows(k1 + 1).Cells("CPATH").Value = row.Cells("CPATH").Value
                    grid.Rows(k1 + 1).Cells("CFNAME").Value = row.Cells("CFNAME").Value
                    grid.Rows(k1 + 1).Cells("CTP").Value = row.Cells("CTP").Value

                    If ctp < numsplit.Value Then
                        grid.Rows(k1 + 1).Cells("CPTM").Value = CStr(stp) & "-" & CStr(row.Cells("CTP").Value)
                    Else
                        grid.Rows(k1 + 1).Cells("CPTM").Value = CStr(stp) & "-" & CStr(stp + numsplit.Value - 1)
                    End If

                    grid.Rows(k1 + 1).Cells("ROT").Value = row.Cells("ROT").Value

                    stp += numsplit.Value
                    ctp -= numsplit.Value
                Next
            Next
        Else
            MsgBox("Please Select Atleast One Row")
        End If
    End Sub

    Private Sub butusplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butusplit.Click
        Try
            If grid.SelectedRows.Count <> 1 Then
                MsgBox("Please Select One Row")
                Exit Sub
            End If
            For k1 = 0 To grid.SelectedRows.Count - 1

                Dim A() As String = CStr(grid.SelectedRows(k1).Cells("CPTM").Value).Split(",")

                If UBound(A) < 0 Then
                    Exit For
                End If

                For K2 = 0 To UBound(A)
                    grid.Rows.InsertCopy(grid.SelectedRows(k1).Index, grid.SelectedRows(k1).Index + 1)

                    grid.Rows(grid.SelectedRows(k1).Index + 1).Cells("CSELECT").Value = grid.SelectedRows(k1).Cells("CSELECT").Value
                    grid.Rows(grid.SelectedRows(k1).Index + 1).Cells("CPATH").Value = grid.SelectedRows(k1).Cells("CPATH").Value
                    grid.Rows(grid.SelectedRows(k1).Index + 1).Cells("CFNAME").Value = grid.SelectedRows(k1).Cells("CFNAME").Value
                    grid.Rows(grid.SelectedRows(k1).Index + 1).Cells("CTP").Value = grid.SelectedRows(k1).Cells("CTP").Value
                    grid.Rows(grid.SelectedRows(k1).Index + 1).Cells("CPTM").Value = A(UBound(A) - K2)
                    grid.Rows(grid.SelectedRows(k1).Index + 1).Cells("ROT").Value = grid.SelectedRows(k1).Cells("ROT").Value

                Next

            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub grid_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.MouseEnter
        grid.Select()
    End Sub

    Private Sub usrpms_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid.MouseWheel
        If frmPMS.mflag Then
            If e.Delta < 0 Then
                DOWN()
            End If
            If e.Delta > 0 Then
                UP()
            End If
        End If
    End Sub

    Private Sub radmerge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radmerge.CheckedChanged
        lbltarget.Text = "TARGET PDF DOCUMENT"
        txtoutfile.Text = ""
    End Sub

    Private Sub radsplit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radsplit.CheckedChanged
        lbltarget.Text = "TARGET PATH"
        txtoutfile.Text = ""
    End Sub

    Private Sub butpanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butpanel.Click
        frmPMS.Visible = False
        Dim pan As New dlgpanel
        pan.ShowDialog()
        frmPMS.Visible = True
    End Sub
End Class
