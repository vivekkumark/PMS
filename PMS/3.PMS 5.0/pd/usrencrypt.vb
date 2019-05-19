Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class usrencrypt
    Private Sub check()
        Dim per As Integer
        per = PdfWriter.ALLOW_ASSEMBLY Or PdfWriter.ALLOW_COPY Or PdfWriter.ALLOW_DEGRADED_PRINTING Or PdfWriter.ALLOW_FILL_IN Or PdfWriter.ALLOW_MODIFY_ANNOTATIONS Or PdfWriter.ALLOW_MODIFY_CONTENTS Or PdfWriter.ALLOW_PRINTING Or PdfWriter.ALLOW_SCREENREADERS
        per = -1
        PdfEncryptor.Encrypt(New PdfReader("C:\Documents and Settings\inst20001668\Desktop\TE.PDF"), New System.IO.FileStream("C:\Documents and Settings\inst20001668\Desktop\TE1.PDF", IO.FileMode.Create), PdfWriter.STRENGTH128BITS, "", "", per)
    End Sub
    Private Function CreateFold(ByRef foname As String) As String
        Try
            Dim tname As String = "PMS-CRYPT"

            If FileIO.FileSystem.DirectoryExists(FileIO.FileSystem.CombinePath(foname, tname)) Then
                For k1 = 1 To 65536
                    If FileIO.FileSystem.DirectoryExists(FileIO.FileSystem.CombinePath(foname, tname & "-" & CStr(k1))) = False Then
                        tname = tname & "-" & CStr(k1)
                        Exit For
                    End If
                Next
            End If
            FileIO.FileSystem.CreateDirectory(FileIO.FileSystem.CombinePath(foname, tname))
            Return FileIO.FileSystem.CombinePath(foname, tname)
        Catch ex As Exception
            Return "-1"
        End Try

    End Function

    Private Sub butstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butstart.Click

        Try

            Dim foldername As String = ""

            Dim per As Integer = 0
            If chkAllowAssembly.Checked Then
                per = per Or PdfWriter.ALLOW_PRINTING
            End If
            If chkAllowDegradedPrinting.Checked Then
                per = per Or PdfWriter.ALLOW_DEGRADED_PRINTING
            End If
            If chkAllowModifyContents.Checked Then
                per = per Or PdfWriter.ALLOW_MODIFY_CONTENTS
            End If
            If chkAllowAssembly.Checked Then
                per = per Or PdfWriter.ALLOW_ASSEMBLY
            End If
            If chkAllowCopy.Checked Then
                per = per Or PdfWriter.ALLOW_COPY
            End If
            If chkAllowScreenReaders.Checked Then
                per = per Or PdfWriter.ALLOW_SCREENREADERS
            End If
            If chkAllowModifyAnnotations.Checked Then
                per = per Or PdfWriter.ALLOW_MODIFY_ANNOTATIONS
            End If
            If chkAllowFillIn.Checked Then
                per = per Or PdfWriter.ALLOW_FILL_IN
            End If

            If radpath.Checked Then
                If Strings.Replace(txtoutpath.Text, " ", "") = "" Then
                    MsgBox("Please Enter The Folder Path")
                    txtoutpath.Focus()
                    Exit Sub
                End If
                If FileIO.FileSystem.DirectoryExists(txtoutpath.Text) = False Then
                    MsgBox("Please Enter The Valid Folder Path")
                    txtoutpath.Focus()
                    Exit Sub
                End If
                foldername = CreateFold(txtoutpath.Text)
                If foldername = "-1" Then
                    MsgBox("You Don't have Write Access for the path you have entered.Enter The Valid Path")
                    txtoutpath.Focus()
                    Exit Sub
                End If
                If FileIO.FileSystem.DirectoryExists(txtrootpath.Text) = False Then
                    MsgBox("Please Enter The Valid Root Path")
                    txtrootpath.Focus()
                    Exit Sub
                End If
            End If

            If chkpassuser.Checked Then
                If txtpassuser.Text.Replace(" ", "").Length < 1 Then
                    MsgBox("Please Enter The Valid User Password")
                    Exit Sub
                End If
            End If

            If chkpassowner.Checked Then
                If txtpassowner.Text.Replace(" ", "").Length < 1 Then
                    MsgBox("Please Enter The Valid Owner Password")
                    Exit Sub
                End If
            End If

            If raddirect.Checked Then

                For k1 = 0 To grid.RowCount - 1

                    Dim fname As String = grid.Rows(k1).Cells(0).Value.ToString & grid.Rows(k1).Cells(1).Value.ToString
                    Dim fpath As String = grid.Rows(k1).Cells("CPATH").Value.ToString
                    Dim tempfname As String = MyPDFLib.getfilename(fpath, "~temp~.pdf")

                    Dim reader As PdfReader
                    Dim stamper As PdfStamper

                    If grid.Rows(k1).Cells(3).Value = "" Then
                        reader = New PdfReader(fname)
                    Else
                        reader = New PdfReader(fname, Con_byte(grid.Rows(k1).Cells(3).Value))
                    End If

                    stamper = New PdfStamper(reader, New FileStream(tempfname, FileMode.Create))

                    If chkpassuser.Checked = False And chkpassowner.Checked = False Then
                        grid.Rows(k1).Cells(3).Value = ""
                    ElseIf chkpassuser.Checked = False And chkpassowner.Checked = True Then
                        stamper.SetEncryption(PdfWriter.STRENGTH128BITS, "", txtpassowner.Text, per)
                        grid.Rows(k1).Cells(3).Value = txtpassowner.Text
                    ElseIf chkpassuser.Checked = True And chkpassowner.Checked = False Then
                        stamper.SetEncryption(PdfWriter.STRENGTH128BITS, txtpassuser.Text, txtpassuser.Text, -1)
                        grid.Rows(k1).Cells(3).Value = txtpassuser.Text
                    ElseIf chkpassuser.Checked = True And chkpassowner.Checked = True Then
                        stamper.SetEncryption(PdfWriter.STRENGTH128BITS, txtpassuser.Text, txtpassowner.Text, per)
                        grid.Rows(k1).Cells(3).Value = txtpassowner.Text
                    End If
                    stamper.Close()
                    'File Move
                    FileIO.FileSystem.DeleteFile(fname)
                    FileIO.FileSystem.MoveFile(tempfname, fname)
                Next
            Else
                For k1 = 0 To grid.RowCount - 1

                    Dim fname As String = grid.Rows(k1).Cells(0).Value.ToString & grid.Rows(k1).Cells(1).Value.ToString
                    Dim fpath As String = grid.Rows(k1).Cells(0).Value.ToString


                    Dim tempfolder As String = foldername
                    If fpath.Contains(txtrootpath.Text) Then
                        Dim te As String = Replace(fpath, txtrootpath.Text, "")
                        If te(0) = "\" Then
                            te = Strings.Mid(te, 2)
                        End If

                        tempfolder = FileIO.FileSystem.CombinePath(foldername, te)
                        If FileIO.FileSystem.DirectoryExists(tempfolder) = False Then
                            FileIO.FileSystem.CreateDirectory(tempfolder)
                        End If
                    End If

                    Dim tempfname As String = MyPDFLib.getfilename(tempfolder, grid.Rows(k1).Cells(1).Value.ToString)


                    Dim reader As PdfReader
                    Dim stamper As PdfStamper

                    If grid.Rows(k1).Cells(3).Value = "" Then
                        reader = New PdfReader(fname)
                    Else
                        reader = New PdfReader(fname, Con_byte(grid.Rows(k1).Cells(3).Value))
                    End If

                    stamper = New PdfStamper(reader, New FileStream(tempfname, FileMode.Create))

                    If chkpassuser.Checked = False And chkpassowner.Checked = False Then
                    ElseIf chkpassuser.Checked = False And chkpassowner.Checked = True Then
                        stamper.SetEncryption(PdfWriter.STRENGTH128BITS, "", txtpassowner.Text, per)
                    ElseIf chkpassuser.Checked = True And chkpassowner.Checked = False Then
                        stamper.SetEncryption(PdfWriter.STRENGTH128BITS, txtpassuser.Text, txtpassuser.Text, -1)
                    ElseIf chkpassuser.Checked = True And chkpassowner.Checked = True Then
                        stamper.SetEncryption(PdfWriter.STRENGTH128BITS, txtpassuser.Text, txtpassowner.Text, per)
                    End If
                    stamper.Close()

                Next
            End If
            MsgBox("Successfully Completed")
        Catch ex As Exception
            MsgBox("Files Are Not Encryped/Decryped Successfully.Try after closing all pdf files", MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        check()

        'Dim reader As PdfReader
        'Dim outfile As PdfCopy
        'Dim doc As Document = New Document()
        'outfile = New PdfCopy(doc, New FileStream("C:\Documents and Settings\inst20001668\Desktop\TE3.PDF", FileMode.Create))
        'reader = New PdfReader("C:\Documents and Settings\inst20001668\Desktop\TE1.PDF", Con_byte("he"))
        'doc.Open()

        'For np = 1 To reader.NumberOfPages - 1
        '    Dim pr As Int32 = reader.GetPageRotation(np)
        '    Dim ReR As Int32 = 0
        '    reader.GetPageN(np).Put(iTextSharp.text.pdf.PdfName.ROTATE, New iTextSharp.text.pdf.PdfNumber(pr + ReR))
        '    outfile.AddPage(outfile.GetImportedPage(reader, np))
        'Next

        'reader.Close()
        'doc.Close()

    End Sub
    Private Sub usrencrypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grid.Columns.Add("CPATH", "PATH")
        grid.Columns("CPATH").Width = 50
        grid.Columns("CPATH").ReadOnly = True

        grid.Columns.Add("CFNAME", "FILE NAME")
        grid.Columns("CFNAME").Width = 250
        grid.Columns("CFNAME").ReadOnly = True

        grid.Columns.Add("CTP", "TOTAL PAGES")
        grid.Columns("CTP").Width = 50
        grid.Columns("CTP").ReadOnly = True

        grid.Columns.Add("PASS", "PASSWORD")
        grid.Columns("PASS").ReadOnly = True
        grid.Columns("PASS").Width = 50

        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = True
        grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub
    'UI
    'UI
    Private Sub chkAllowPrinting_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowPrinting.MouseHover
        TTencrypt.ToolTipTitle = "AllowPrinting"
        TTencrypt.Show("Printing the document", sender)
    End Sub

    Private Sub chkAllowDegradedPrinting_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowDegradedPrinting.MouseHover
        TTencrypt.ToolTipTitle = "AllowDegradedPrinting"
        TTencrypt.Show("Printing the document, but not with the quality ", sender)
    End Sub

    Private Sub chkAllowModifyContents_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowModifyContents.MouseHover
        TTencrypt.ToolTipTitle = "AllowModifyContents"
        TTencrypt.Show("Modifying the contents—for example,changing the content of a page, or inserting or removing a page", sender)
    End Sub

    Private Sub chkAllowAssembly_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowAssembly.MouseHover
        TTencrypt.ToolTipTitle = "AllowAssembly"
        TTencrypt.Show("Inserting, removing, and rotating pages and adding bookmarks is allowed. The content of a page can’t be changed", sender)
    End Sub

    Private Sub chkAllowCopy_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowCopy.MouseHover
        TTencrypt.ToolTipTitle = "AllowCopy"
        TTencrypt.Show("Copying or otherwise extracting text and graphics from the document, including assistive technologies such as screen readers or other accessibility devices", sender)
    End Sub

    Private Sub chkAllowScreenReaders_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowScreenReaders.MouseHover
        TTencrypt.ToolTipTitle = "AllowScreenReaders"
        TTencrypt.Show("Extracting text and graphics for use by accessibility devices", sender)
    End Sub

    Private Sub chkAllowModifyAnnotations_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowModifyAnnotations.MouseHover
        TTencrypt.ToolTipTitle = "AllowModifyAnnotations"
        TTencrypt.Show("Adding or modifying text annotations and interactive form fields", sender)
    End Sub

    Private Sub chkAllowFillIn_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllowFillIn.MouseHover
        TTencrypt.ToolTipTitle = "AllowFillIn"
        TTencrypt.Show("Filling form fields; adding or modifying annotations only", sender)
    End Sub

    Private Sub chkpassuser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpassuser.CheckedChanged
        txtpassuser.Enabled = chkpassuser.Checked
    End Sub

    Private Sub chkpassowner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpassowner.CheckedChanged
        txtpassowner.Enabled = chkpassowner.Checked
        grpPermissions.Enabled = chkpassowner.Checked
    End Sub
    Public Sub grid_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grid.DragDrop

        Dim readflag As Boolean = False
        Dim listprotectedfiles As String = ""
        Dim pagecount As Int32 = -1
        Dim password As String = ""


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

            For Each fileLoc As String In filelist

                Try

                    Try
                        Dim reader As PdfReader
                        reader = New PdfReader(fileLoc)
                        If reader.IsOpenedWithFullPermissions Then
                            pagecount = reader.NumberOfPages
                            password = ""
                        Else
                            ChkPassBruteF(fileLoc, password, pagecount)
                        End If
                        reader.Close()
                    Catch ex As Exception
                        ChkPassBruteF(fileLoc, password, pagecount)
                    End Try

                    'Dim pagecount As Int32 = MyPDFLib.CheckEncrypt(OpenFileDialogin.FileNames(k1))
                    If pagecount > 0 Then
                        grid.Rows.Add()
                        grid.Rows(grid.Rows.Count - 1).Cells("CPATH").Value = fileLoc.Replace(FileIO.FileSystem.GetName(fileLoc), "")

                        If txtrootpath.Text = "" Then
                            txtrootpath.Text = FileIO.FileSystem.GetParentPath(grid.Rows(grid.Rows.Count - 1).Cells("CPATH").Value)
                        End If

                        grid.Rows(grid.Rows.Count - 1).Cells("CFNAME").Value = FileIO.FileSystem.GetName(fileLoc)
                        grid.Rows(grid.Rows.Count - 1).Cells("CTP").Value = pagecount
                        grid.Rows(grid.Rows.Count - 1).Cells("PASS").Value = password
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
                MsgBox("The following Protected Files Are Skiped" & listprotectedfiles)
            End If

            'Try
            '    If pagecount > 0 Then
            '        grid.Rows.Add()
            '        grid.Rows(grid.Rows.Count - 1).Cells("CPATH").Value = fileLoc.Replace(FileIO.FileSystem.GetName(fileLoc), "")
            '        grid.Rows(grid.Rows.Count - 1).Cells("CFNAME").Value = FileIO.FileSystem.GetName(fileLoc)
            '        grid.Rows(grid.Rows.Count - 1).Cells("CTP").Value = pagecount
            '    Else
            '        readflag = True
            '        listprotectedfiles = listprotectedfiles & vbLf & fileLoc
            '    End If

            'Catch ex As Exception
            '    readflag = True
            '    listprotectedfiles = listprotectedfiles & vbLf & fileLoc
            'End Try


            'Next
            'If readflag = True Then
            '    MsgBox("The following Protected Files Are Skiped" & listprotectedfiles)
            'End If

        End If
    End Sub
    Private Function checkpdfpass(ByVal fname As String, ByVal pass As String) As Int32
        Try
            Dim reader As PdfReader
            reader = New PdfReader(fname, Con_byte(pass))
            If reader.IsOpenedWithFullPermissions Then
                checkpdfpass = reader.NumberOfPages
                Exit Function
            End If
            checkpdfpass = -1
        Catch ex As Exception
            checkpdfpass = -1
        End Try
    End Function

    Private Sub ChkPassBruteF(ByVal fname As String, ByRef password As String, ByRef pagecount As Int32)

        'FileOpen(2, "C:\Time.txt", OpenMode.Append)
        'WriteLine(2, TimeOfDay.ToString)
        'FileClose(1)

        pagecount = -1
        password = ""

        Try

            For lic = 0 To listdecryptpass.Items.Count - 1
                Dim chval As Int32 = checkpdfpass(fname, listdecryptpass.Items(lic).ToString)
                If chval > 0 Then
                    pagecount = chval
                    password = listdecryptpass.Items(lic).ToString
                    Exit For
                End If
            Next

            'Start Brute Force

            If grpbruteforce.Visible = True And pagecount = -1 And rtxtbruteforce.TextLength > 0 Then
                Dim minpass As UInt16 = numminpass.Value
                Dim maxpass As UInt16 = minpass
                Dim temppass As String = ""
                If nummaxpass.Value > numminpass.Value Then
                    maxpass = nummaxpass.Value
                End If

                Dim MText As String = rtxtbruteforce.Text
                Dim MPassLen As String = MText.Length

                Dim CPassLen As UInt16

                For CPassLen = minpass To maxpass

                    Dim Pary(CPassLen - 1) As Int16
                    temppass = ""
                    Dim initpass As String

                    Dim flag As Boolean = True
                    'Gen Pass
                    For k1 = 0 To CPassLen - 1
                        temppass = temppass & MText(Pary(k1))
                    Next
                    initpass = temppass

                    While flag
                        'FileOpen(1, "C:\HI.txt", OpenMode.Append)
                        'WriteLine(1, temppass)
                        'FileClose(1)
                        pagecount = checkpdfpass(fname, temppass)
                        If pagecount <> -1 Then
                            password = temppass
                            txtdecryptpass.Text = password
                            butadddecryptpass.PerformClick()
                            GoTo L1
                        End If
                        For L1 = 0 To CPassLen - 1
                            Pary(L1) = (Pary(L1) + 1) Mod MPassLen
                            If Pary(L1) <> 0 Then
                                Exit For
                            End If
                        Next
                        'Gen Pass
                        temppass = ""
                        For k1 = 0 To CPassLen - 1
                            temppass = temppass & MText(Pary(k1))
                        Next

                        If temppass = initpass Then
                            flag = False
                        End If
                    End While

                Next
L1:
            End If

        Catch ex As Exception

        End Try

        'WriteLine(2, TimeOfDay.ToString)
        'FileClose(2)

    End Sub
    Private Sub butbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butbrowse.Click
        Try
            OpenFileDialogin.ShowDialog()
            Dim readflag As Boolean = False
            Dim listprotectedfiles As String = ""
            Dim pagecount As Int32 = -1
            Dim password As String = ""

            For k1 = 0 To OpenFileDialogin.SafeFileNames.Length - 1
                Try

                    Try
                        Dim reader As PdfReader
                        reader = New PdfReader(OpenFileDialogin.FileNames(k1))
                        If reader.IsOpenedWithFullPermissions Then
                            pagecount = reader.NumberOfPages
                            password = ""
                        Else
                            ChkPassBruteF(OpenFileDialogin.FileNames(k1), password, pagecount)
                        End If
                        reader.Close()
                    Catch ex As Exception
                        ChkPassBruteF(OpenFileDialogin.FileNames(k1), password, pagecount)
                    End Try

                    'Dim pagecount As Int32 = MyPDFLib.CheckEncrypt(OpenFileDialogin.FileNames(k1))
                    If pagecount > 0 Then
                        grid.Rows.Add()
                        grid.Rows(grid.Rows.Count - 1).Cells("CPATH").Value = OpenFileDialogin.FileNames(k1).Replace(OpenFileDialogin.SafeFileNames(k1), "")

                        If txtrootpath.Text = "" Then
                            txtrootpath.Text = FileIO.FileSystem.GetParentPath(grid.Rows(grid.Rows.Count - 1).Cells("CPATH").Value)
                        End If

                        grid.Rows(grid.Rows.Count - 1).Cells("CFNAME").Value = OpenFileDialogin.SafeFileNames(k1)
                        grid.Rows(grid.Rows.Count - 1).Cells("CTP").Value = pagecount
                        grid.Rows(grid.Rows.Count - 1).Cells("PASS").Value = password
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub butpanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butpanel.Click
        butauthor.WhereToDrop = "ENCRYPT"
        butauthor.Visible = False
        Dim pan As New dlgpanel
        pan.ShowDialog()
        butauthor.Visible = True
    End Sub
    Private Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        If e.ColumnIndex = 0 Then
            System.Diagnostics.Process.Start(grid.CurrentCell.Value.ToString)
        ElseIf e.ColumnIndex = 1 Then
            Try
                If butauthor.radfoxit.Checked Then
                    Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                    Dim h As Object = obj.GetFile(grid.Rows(e.RowIndex).Cells(0).Value.ToString & grid.CurrentCell.Value.ToString)
                    System.Diagnostics.Process.Start("Foxit.exe", h.shortpath)
                ElseIf butauthor.radeditor.Checked Then
                    Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                    Dim h As Object = obj.GetFile(grid.Rows(e.RowIndex).Cells(0).Value.ToString & grid.CurrentCell.Value.ToString)
                    System.Diagnostics.Process.Start("PDFEdit.exe", h.shortpath)
                Else
                    System.Diagnostics.Process.Start(grid.Rows(e.RowIndex).Cells(0).Value.ToString & grid.CurrentCell.Value.ToString)
                End If
            Catch ex As Exception
                Try
                    System.Diagnostics.Process.Start(grid.Rows(e.RowIndex).Cells(0).Value.ToString & grid.CurrentCell.Value.ToString)
                Catch ex1 As Exception

                End Try
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


    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Private Sub butadddecryptpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butadddecryptpass.Click
        If txtdecryptpass.Text.Replace(" ", "").Length > 0 Then
            For k1 = 0 To listdecryptpass.Items.Count - 1
                If txtdecryptpass.Text = listdecryptpass.Items(k1).ToString Then
                    'MsgBox("Password is Already there in the List")
                    Exit Sub
                End If
            Next
            listdecryptpass.Items.Add(txtdecryptpass.Text)
        Else
            MsgBox("Password Length Should Be Minimun 1")
        End If
    End Sub

    Private Sub butdeletedecrptpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butdeletedecrptpass.Click

        Dim ary(0) As String
        Dim len As Int32 = -1
        For KK = 0 To listdecryptpass.Items.Count - 1
            If listdecryptpass.SelectedIndices.Contains(KK) = False Then
                len += 1
                ReDim Preserve ary(len)
                ary(len) = listdecryptpass.Items(KK).ToString
            End If
        Next

        listdecryptpass.Items.Clear()

        For KK = 0 To len
            listdecryptpass.Items.Add(ary(KK))
        Next

    End Sub

    Private Sub butimportpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butimportpass.Click
        Try
            OpenFileDialogtxt.ShowDialog()
            For k1 = 0 To OpenFileDialogtxt.SafeFileNames.Length - 1
                Dim fs As StreamReader = New StreamReader(OpenFileDialogtxt.FileNames(k1))
                While fs.EndOfStream = False
                    Dim filepass As String = fs.ReadLine
                    If filepass.Replace(" ", "").Length > 0 Then
                        Dim flag As Boolean = False
                        For KK = 0 To listdecryptpass.Items.Count - 1
                            If filepass = listdecryptpass.Items(KK).ToString Then
                                flag = True
                                Exit For
                            End If
                        Next
                        If flag = False Then
                            listdecryptpass.Items.Add(filepass)
                        End If
                    End If
                End While
                fs.Close()
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub butclearall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butclearall.Click
        listdecryptpass.Items.Clear()
    End Sub
    Private Sub appendchars(ByVal ch As String)
        For k1 = 0 To ch.Length - 1
            If rtxtbruteforce.Text.Contains(ch(k1)) = False Then
                rtxtbruteforce.Text = rtxtbruteforce.Text & ch(k1)
            End If
        Next        
    End Sub
    Private Sub butNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butNumbers.Click
        appendchars("0123456789")
    End Sub

    Private Sub butSmallChar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSmallChar.Click
        appendchars("abcdefghijklmnopqrstuvwxyz")
    End Sub

    Private Sub butcaps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butcaps.Click
        appendchars("ABCDEFGHIJKLMNOPQRSTUVWXYZ")
    End Sub

    Private Sub butspecial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butspecial.Click
        appendchars("`~!@#$%^&*()-_=+[{]}\|;:'"",<.>/? ")
    End Sub

    Private Sub rtxtbruteforce_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtxtbruteforce.TextChanged
        Dim mytxt As String = ""
        For k1 = 0 To rtxtbruteforce.Text.Length - 1
            If mytxt.Contains(rtxtbruteforce.Text(k1)) = False Then
                mytxt = mytxt & rtxtbruteforce.Text(k1)
            End If
        Next
        rtxtbruteforce.Text = mytxt        
    End Sub

    Private Sub butoutfolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butoutfolder.Click
        FolderBrowserDialogout.ShowDialog()
        txtoutpath.Text = FolderBrowserDialogout.SelectedPath
    End Sub
    Private Sub raddirect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles raddirect.CheckedChanged
        txtoutpath.Enabled = radpath.Checked
        butoutfolder.Enabled = radpath.Checked
        lblrootlable.Enabled = radpath.Checked
        txtrootpath.Enabled = radpath.Checked
    End Sub

    Private Sub radpath_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radpath.CheckedChanged
        txtoutpath.Enabled = radpath.Checked
        butoutfolder.Enabled = radpath.Checked
        lblrootlable.Enabled = radpath.Checked
        txtrootpath.Enabled = radpath.Checked
    End Sub

End Class
