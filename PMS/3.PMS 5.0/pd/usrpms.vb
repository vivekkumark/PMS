Imports System.Data.OleDb
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports System.IO
Imports PdfSharp.Pdf.IO
Imports iTextSharp
Public Class usrpms
    Private Sub mergefiles()
        Try
            If grpoverwrite.RowCount < 1 Then
                MsgBox("Please Add Atleast One Source File(Browse Or DragDrop[File(s) Or Folder(s)])")
                Exit Sub
            End If

            If txtoutfile.Text.Replace(" ", "").Length < 1 Then
                MsgBox("Please Enter Output File Name Properly")
                txtoutfile.Focus()
                Exit Sub
            End If

            If FileIO.FileSystem.DirectoryExists(FileIO.FileSystem.GetParentPath(txtoutfile.Text)) = False Then
                MsgBox("Please Enter Output File Name Properly")
                txtoutfile.Focus()
                Exit Sub
            End If

            If Strings.Right(txtoutfile.Text, 4).ToLower <> ".pdf" Then
                MsgBox("Please Enter Target File Name(Browse) Properly")
                txtoutfile.Focus()
                Exit Sub
            End If

            Dim ndoc As Boolean = False
            For k1 = 0 To grpoverwrite.RowCount - 1
                If grpoverwrite.Rows(k1).Cells("CSelect").Value = True Then
                    ndoc = True
                End If
            Next
            If ndoc = False Then
                MsgBox("Please Select Atleast One Document(Chech Box)")
                Exit Sub
            End If


            MyPDFLib.MergePDF(Me)

            'Dim reader As iTextSharp.text.pdf.PdfReader
            'reader = New iTextSharp.text.pdf.PdfReader(txtoutfile.Text)
            'For k = 1 To reader.NumberOfPages
            '    reader.GetPageN(k).Put(iTextSharp.text.pdf.PdfName.ROTATE, New iTextSharp.text.pdf.PdfNumber(-90))
            'Next

            'Dim stp As iTextSharp.text.pdf.PdfStamper
            'stp = New iTextSharp.text.pdf.PdfStamper(reader, New FileStream("C:\pdf1.pdf", FileMode.Create))
            'stp.Close()


            If MsgBox("Files Are Merged Successfully.Do You Want To Open", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    If butauthor.radfoxit.Checked Then
                        Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                        Dim h As Object = obj.GetFile(txtoutfile.Text)
                        System.Diagnostics.Process.Start("Foxit.exe", h.shortpath)
                    ElseIf butauthor.radeditor.Checked Then
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

        Catch ex As Exception
            MsgBox("Files Are Not Merged Successfully", MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Function getfilename(ByVal path As String, ByVal rtfname As String) As String
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
            If grpoverwrite.RowCount < 1 Then
                MsgBox("Please Add Atleast One Source File(Browse Or DragDrop[File(s) Or Folder(s)])")
                Exit Sub
            End If

            If FileIO.FileSystem.DirectoryExists(txtoutfile.Text) = False Then
                MsgBox("Please Enter Target Path.Properly")
                Exit Sub
            End If

            Dim ndoc As Boolean = False
            For k1 = 0 To grpoverwrite.RowCount - 1
                If grpoverwrite.Rows(k1).Cells("CSelect").Value = True Then
                    ndoc = True
                End If
            Next
            If ndoc = False Then
                MsgBox("Please Select Atleast One Document(Chech Box)")
                Exit Sub
            End If

            MyPDFLib.SplitPDF(Me)

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
                Dim pagecount As Int32 = MyPDFLib.CheckPDFEncrypt(OpenFileDialogin.FileNames(k1))
                If pagecount > 0 Then
                    grpoverwrite.Rows.Add()
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CSelect").Value = True
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CPATH").Value = OpenFileDialogin.FileNames(k1).Replace(FileIO.FileSystem.GetName(OpenFileDialogin.FileNames(k1)), "")
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CFNAME").Value = FileIO.FileSystem.GetName(OpenFileDialogin.FileNames(k1))
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CTP").Value = pagecount
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CPTM").Value = "1-" & pagecount
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("ROT").Value = "0"
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("ROT").Style.ForeColor = Color.Red
                Else
                    readflag = True
                    listprotectedfiles = listprotectedfiles & vbLf & OpenFileDialogin.FileNames(k1)
                End If
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
        grpoverwrite.Columns.Add(col)

        grpoverwrite.Columns.Add("CPATH", "PATH")
        grpoverwrite.Columns("CPATH").Width = 200
        grpoverwrite.Columns("CPATH").ReadOnly = True

        grpoverwrite.Columns.Add("CFNAME", "FILE NAME")
        grpoverwrite.Columns("CFNAME").Width = 300
        grpoverwrite.Columns("CFNAME").ReadOnly = True

        grpoverwrite.Columns.Add("CTP", "TOTAL PAGES")
        grpoverwrite.Columns("CTP").Width = 100
        grpoverwrite.Columns("CTP").ReadOnly = True
        grpoverwrite.Columns("CTP").CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        grpoverwrite.Columns.Add("CPTM", "PAGES TO MERGE")
        grpoverwrite.Columns("CPTM").Width = 200
        grpoverwrite.Columns("CPTM").CellTemplate.Style.ForeColor = Color.Green

        grpoverwrite.Columns.Add("ROT", "ROTATION")
        grpoverwrite.Columns("ROT").Width = 100
        grpoverwrite.Columns("ROT").ReadOnly = True


        grpoverwrite.AllowUserToAddRows = False
        grpoverwrite.AllowUserToDeleteRows = True
        grpoverwrite.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        'Add Command Line Files

        Dim listprotectedfiles As String = ""
        Dim filelist As New List(Of String)
        For Each fileLoc As String In My.Application.CommandLineArgs
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
                Dim pagecount As Int32 = MyPDFLib.CheckPDFEncrypt(fileLoc)
                If pagecount > 0 Then
                    grpoverwrite.Rows.Add()
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CSelect").Value = True
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CPATH").Value = fileLoc.Replace(FileIO.FileSystem.GetName(fileLoc), "")
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CFNAME").Value = FileIO.FileSystem.GetName(fileLoc)
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CTP").Value = pagecount
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CPTM").Value = "1-" & pagecount
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("ROT").Value = "0"
                    grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("ROT").Style.ForeColor = Color.Red
                Else
                    readflag = True
                    listprotectedfiles = listprotectedfiles & vbLf & fileLoc
                End If
            Catch ex As Exception
                readflag = True
                listprotectedfiles = listprotectedfiles & vbLf & fileLoc
            End Try
        Next
        If readflag = True Then
            MsgBox("The following Files could not read" & listprotectedfiles)
        End If


    End Sub

    Public Sub grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grpoverwrite.CellClick
        Try
            If e.ColumnIndex = 0 Then
                grpoverwrite.CurrentCell.Value = Not grpoverwrite.CurrentCell.Value
                'ElseIf e.ColumnIndex = 5 Then
                '    grid.CurrentCell.Value = (grid.CurrentCell.Value + 90) Mod 360
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grpoverwrite.CellDoubleClick
        If e.ColumnIndex = 1 Then
            Try
                System.Diagnostics.Process.Start(grpoverwrite.CurrentCell.Value.ToString)
            Catch ex2 As Exception

            End Try
        ElseIf e.ColumnIndex = 2 Then
            Try
                If butauthor.radfoxit.Checked Then
                    Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                    Dim h As Object = obj.GetFile(grpoverwrite.Rows(e.RowIndex).Cells(1).Value.ToString & grpoverwrite.CurrentCell.Value.ToString)
                    System.Diagnostics.Process.Start("Foxit.exe", h.shortpath)
                ElseIf butauthor.radeditor.Checked Then
                    Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                    Dim h As Object = obj.GetFile(grpoverwrite.Rows(e.RowIndex).Cells(1).Value.ToString & grpoverwrite.CurrentCell.Value.ToString)
                    System.Diagnostics.Process.Start("PDFEdit.exe", h.shortpath)
                Else
                    System.Diagnostics.Process.Start(grpoverwrite.Rows(e.RowIndex).Cells(1).Value.ToString & grpoverwrite.CurrentCell.Value.ToString)
                End If
            Catch ex As Exception
                Try
                    System.Diagnostics.Process.Start(grpoverwrite.Rows(e.RowIndex).Cells(1).Value.ToString & grpoverwrite.CurrentCell.Value.ToString)
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

    Public Sub grid_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grpoverwrite.CellValidating
        If grpoverwrite.CurrentCell.ColumnIndex = 4 Then
            Try
                Dim s() As String = grpoverwrite.CurrentCell.EditedFormattedValue.ToString.Split(",")
                Dim kkk1 As Int16
                For s1 = 0 To s.Length - 1
                    If s(s1).Contains("-") = True Then
                        kkk1 = CInt(s(s1).Split("-")(0))
                        If kkk1 > CInt(grpoverwrite.Rows(e.RowIndex).Cells(3).Value.ToString) Then
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
                        If kkk1 > CInt(grpoverwrite.Rows(e.RowIndex).Cells(3).Value.ToString) Then
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
                        If kkk1 > CInt(grpoverwrite.Rows(e.RowIndex).Cells(3).Value.ToString) Then
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
    Public Sub grid_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grpoverwrite.DragDrop
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
                    Dim pagecount As Int32 = MyPDFLib.CheckPDFEncrypt(fileLoc)
                    If pagecount > 0 Then
                        grpoverwrite.Rows.Add()
                        grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CSelect").Value = True
                        grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CPATH").Value = fileLoc.Replace(FileIO.FileSystem.GetName(fileLoc), "")
                        grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CFNAME").Value = FileIO.FileSystem.GetName(fileLoc)
                        grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CTP").Value = pagecount
                        grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("CPTM").Value = "1-" & pagecount
                        grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("ROT").Value = "0"
                        grpoverwrite.Rows(grpoverwrite.Rows.Count - 1).Cells("ROT").Style.ForeColor = Color.Red
                    Else
                        readflag = True
                        listprotectedfiles = listprotectedfiles & vbLf & fileLoc
                    End If
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
    Public Sub grid_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grpoverwrite.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub UP()
        Try
            Dim Arow() As Int16
            ReDim Arow(grpoverwrite.SelectedRows.Count - 1)
            Dim k1 As Int16 = 0

            For Each row As DataGridViewRow In grpoverwrite.SelectedRows
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

        Catch ex As Exception

        End Try
    End Sub
    Public Sub butup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butup.Click
        UP()
    End Sub
    Public Sub swaprow(ByRef r1 As Int16, ByRef r2 As Int16)

        For k1 = 0 To grpoverwrite.ColumnCount - 1
            If r2 < 0 Or r1 < 0 Or r1 >= grpoverwrite.Rows.Count Or r2 >= grpoverwrite.Rows.Count Then
                Exit Sub
            End If
            Dim temp As Object = grpoverwrite.Rows(r1).Cells(k1).Value
            grpoverwrite.Rows(r1).Cells(k1).Value = grpoverwrite.Rows(r2).Cells(k1).Value
            grpoverwrite.Rows(r2).Cells(k1).Value = temp
            grpoverwrite.Rows(r1).Selected = False
            grpoverwrite.Rows(r2).Selected = True
        Next
    End Sub
    Private Sub DOWN()
        Try
            Dim Arow() As Int16
            ReDim Arow(grpoverwrite.SelectedRows.Count - 1)
            Dim k1 As Int16 = 0

            For Each row As DataGridViewRow In grpoverwrite.SelectedRows
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

            If Arow(0) = grpoverwrite.Rows.Count - 1 Then
                'MsgBox("Can Not Move,One Of Your Selected row has been reached Bottom")
                Exit Sub
            End If

            For k2 = 0 To UBound(Arow)
                swaprow(Arow(k2), Arow(k2) + 1)
            Next

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
        For Each row As DataGridViewRow In grpoverwrite.SelectedRows
            grpoverwrite.Rows.Remove(row)
        Next
    End Sub

    Private Sub butduplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butduplicate.Click
        If grpoverwrite.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In grpoverwrite.SelectedRows
                Dim k1 As Int16
                For k1 = row.Index To row.Index + numdup.Value - 1
                    grpoverwrite.Rows.InsertCopy(k1, k1 + 1)
                    For c1 = 0 To grpoverwrite.Columns.Count - 1
                        grpoverwrite.Rows(k1 + 1).Cells(c1).Value = row.Cells(c1).Value
                    Next
                Next
            Next
        Else
            MsgBox("Please Select Atleast One Row")
        End If

    End Sub

    Private Sub butsplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butsplit.Click
        If grpoverwrite.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In grpoverwrite.SelectedRows
                Dim k1 As Int16
                Dim nrow As Int32
                Dim stp As Int32 = 1
                Dim ctp As Int32 = row.Cells("CTP").Value

                nrow = Math.Ceiling(row.Cells("CTP").Value * 1.0 / numsplit.Value)
                For k1 = row.Index To row.Index + nrow - 1
                    grpoverwrite.Rows.InsertCopy(k1, k1 + 1)

                    grpoverwrite.Rows(k1 + 1).Cells("CSELECT").Value = row.Cells("CSELECT").Value
                    grpoverwrite.Rows(k1 + 1).Cells("CPATH").Value = row.Cells("CPATH").Value
                    grpoverwrite.Rows(k1 + 1).Cells("CFNAME").Value = row.Cells("CFNAME").Value
                    grpoverwrite.Rows(k1 + 1).Cells("CTP").Value = row.Cells("CTP").Value

                    If ctp < numsplit.Value Then
                        grpoverwrite.Rows(k1 + 1).Cells("CPTM").Value = CStr(stp) & "-" & CStr(row.Cells("CTP").Value)
                    Else
                        grpoverwrite.Rows(k1 + 1).Cells("CPTM").Value = CStr(stp) & "-" & CStr(stp + numsplit.Value - 1)
                    End If

                    grpoverwrite.Rows(k1 + 1).Cells("ROT").Value = row.Cells("ROT").Value

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
            If grpoverwrite.SelectedRows.Count <> 1 Then
                MsgBox("Please Select One Row")
                Exit Sub
            End If
            For k1 = 0 To grpoverwrite.SelectedRows.Count - 1

                Dim A() As String = CStr(grpoverwrite.SelectedRows(k1).Cells("CPTM").Value).Split(",")

                If UBound(A) < 0 Then
                    Exit For
                End If

                For K2 = 0 To UBound(A)
                    grpoverwrite.Rows.InsertCopy(grpoverwrite.SelectedRows(k1).Index, grpoverwrite.SelectedRows(k1).Index + 1)

                    grpoverwrite.Rows(grpoverwrite.SelectedRows(k1).Index + 1).Cells("CSELECT").Value = grpoverwrite.SelectedRows(k1).Cells("CSELECT").Value
                    grpoverwrite.Rows(grpoverwrite.SelectedRows(k1).Index + 1).Cells("CPATH").Value = grpoverwrite.SelectedRows(k1).Cells("CPATH").Value
                    grpoverwrite.Rows(grpoverwrite.SelectedRows(k1).Index + 1).Cells("CFNAME").Value = grpoverwrite.SelectedRows(k1).Cells("CFNAME").Value
                    grpoverwrite.Rows(grpoverwrite.SelectedRows(k1).Index + 1).Cells("CTP").Value = grpoverwrite.SelectedRows(k1).Cells("CTP").Value
                    grpoverwrite.Rows(grpoverwrite.SelectedRows(k1).Index + 1).Cells("CPTM").Value = A(UBound(A) - K2)
                    grpoverwrite.Rows(grpoverwrite.SelectedRows(k1).Index + 1).Cells("ROT").Value = grpoverwrite.SelectedRows(k1).Cells("ROT").Value

                Next

            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub grid_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpoverwrite.MouseEnter
        grpoverwrite.Select()
    End Sub

    Private Sub usrpms_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grpoverwrite.MouseWheel
        If butauthor.mflag Then
            If e.Delta < 0 Then
                DOWN()
            End If
            If e.Delta > 0 Then
                UP()
            End If
        End If
    End Sub

    Private Sub radmerge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radmerge.CheckedChanged
        grpoverwrite.Visible = radmerge.Checked
        lbltarget.Text = "TARGET PDF DOCUMENT"
        txtoutfile.Text = ""
    End Sub

    Private Sub radsplit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radsplit.CheckedChanged
        grpoverwrite.Visible = radmerge.Checked
        lbltarget.Text = "TARGET PATH"
        txtoutfile.Text = ""
    End Sub

    Private Sub butpanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butpanel.Click
        butauthor.WhereToDrop = "PMS"
        butauthor.Visible = False
        Dim pan As New dlgpanel
        pan.ShowDialog()
        butauthor.Visible = True
    End Sub

    'Private Sub txtoutfile_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoutfile.Leave
    '    Try
    '        If radmerge.Checked Then
    '            If FileIO.FileSystem.DirectoryExists(FileIO.FileSystem.GetParentPath(txtoutfile.Text)) = False Then
    '                MsgBox("Please Enter Output File Name Properly")
    '                txtoutfile.Focus()
    '                Exit Sub
    '            End If
    '            If Strings.Right(txtoutfile.Text, 4).ToLower <> ".pdf" Then
    '                MsgBox("Please Enter Target File Name(Browse) Properly")
    '                txtoutfile.Focus()
    '                Exit Sub
    '            End If
    '        Else
    '            If FileIO.FileSystem.DirectoryExists(txtoutfile.Text) = False Then
    '                MsgBox("Please Enter Target Path.Properly")
    '                txtoutfile.Focus()
    '                Exit Sub
    '            End If
    '        End If
    '    Catch ex As Exception
    '        'MsgBox("Please Enter Properly")
    '        'txtoutfile.Focus()
    '    End Try

    'End Sub

    Private Sub butrotok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butrotok.Click
        'get angle
        Dim angle As Int16 = 0
        If radrot90.Checked Then
            angle = 90
        ElseIf radrot180.Checked Then
            angle = 180
        ElseIf radrot270.Checked Then
            angle = 270
        ElseIf radrotm90.Checked Then
            angle = -90
        ElseIf radrotm180.Checked Then
            angle = -180
        ElseIf radrotm270.Checked Then
            angle = -270
        Else
            angle = 0
        End If

        For Each row As DataGridViewRow In grpoverwrite.SelectedRows
            row.Cells("ROT").Value = angle
        Next
    End Sub
End Class
