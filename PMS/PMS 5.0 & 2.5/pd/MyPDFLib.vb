Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Module MyPDFLib
    Public Sub MergePDF(ByRef UPMS As usrpms)
        Dim reader As PdfReader
        Dim outfile As PdfCopy

        Dim Ofname As String
        Dim fname As String

        'Keep Option For Overwrite Or Not-Overwrite

        If UPMS.radyes.Checked Then
            Ofname = MyPDFLib.getfilename(FileIO.FileSystem.GetParentPath(UPMS.txtoutfile.Text), "~temp~.pdf")
        Else
            Ofname = MyPDFLib.getfilename(FileIO.FileSystem.GetParentPath(UPMS.txtoutfile.Text), FileIO.FileSystem.GetName(UPMS.txtoutfile.Text))
        End If

        Dim doc As Document = New Document()
        outfile = New PdfCopy(doc, New FileStream(Ofname, FileMode.Create))        
        doc.Open()

        For k1 = 0 To UPMS.grpoverwrite.RowCount - 1
            If UPMS.grpoverwrite.Rows(k1).Cells("CSelect").Value = False Then
                Continue For
            End If

            fname = UPMS.grpoverwrite.Rows(k1).Cells(1).Value.ToString & UPMS.grpoverwrite.Rows(k1).Cells(2).Value.ToString

            Dim s() As String = UPMS.grpoverwrite.Rows(k1).Cells(4).Value.ToString.Split(",")

            For s1 = 0 To s.Length - 1
                reader = New PdfReader(fname)
                reader.SelectPages(s(s1))

                For np = 1 To reader.NumberOfPages
                    Dim pr As Int32 = reader.GetPageRotation(np)
                    Dim ReR As Int32 = UPMS.grpoverwrite.Rows(k1).Cells(5).Value
                    reader.GetPageN(np).Put(iTextSharp.text.pdf.PdfName.ROTATE, New iTextSharp.text.pdf.PdfNumber(pr + ReR))
                    outfile.AddPage(outfile.GetImportedPage(reader, np))
                Next

                reader.Close()
            Next
        Next

        doc.Close()

        If UPMS.radyes.Checked Then
            If FileIO.FileSystem.FileExists(UPMS.txtoutfile.Text) Then
                FileIO.FileSystem.DeleteFile(UPMS.txtoutfile.Text)
            End If            
            FileIO.FileSystem.MoveFile(Ofname, UPMS.txtoutfile.Text)
        End If

    End Sub
    Public Sub SplitPDF(ByRef UPMS As usrpms)
        Dim reader As PdfReader
        Dim outfile As PdfCopy
        Dim doc As Document


        For k1 = 0 To UPMS.grpoverwrite.RowCount - 1
            If UPMS.grpoverwrite.Rows(k1).Cells("CSelect").Value = False Then
                Continue For
            End If

            doc = New Document()

            Dim fname As String = UPMS.grpoverwrite.Rows(k1).Cells(1).Value.ToString & UPMS.grpoverwrite.Rows(k1).Cells(2).Value.ToString
            outfile = New PdfCopy(doc, New FileStream(UPMS.getfilename(UPMS.txtoutfile.Text, UPMS.grpoverwrite.Rows(k1).Cells(2).Value.ToString), FileMode.Create))
            doc.Open()

            Dim s() As String = UPMS.grpoverwrite.Rows(k1).Cells(4).Value.ToString.Split(",")
            For s1 = 0 To s.Length - 1
                reader = New PdfReader(fname)
                reader.SelectPages(s(s1))
                For np = 1 To reader.NumberOfPages

                    Dim pr As Int32 = reader.GetPageRotation(np)
                    Dim ReR As Int32 = UPMS.grpoverwrite.Rows(k1).Cells(5).Value
                    reader.GetPageN(np).Put(iTextSharp.text.pdf.PdfName.ROTATE, New iTextSharp.text.pdf.PdfNumber(pr + ReR))

                    outfile.AddPage(outfile.GetImportedPage(reader, np))
                Next
                reader.Close()
            Next

            outfile.Close()
            doc.Close()
        Next

    End Sub
    Public Function getfilename(ByVal path As String, ByVal rtfname As String) As String
        rtfname = Strings.Replace(Strings.Left(rtfname, Len(rtfname) - 4), ".pdf", "")
        If path(path.Length - 1) <> "\" Then
            path = path & "\"
        End If

        If FileIO.FileSystem.FileExists(path & rtfname & ".pdf") Then
            Dim k1 As UInt32 = 1
            While FileIO.FileSystem.FileExists(path & rtfname & "-" & CStr(k1) & ".pdf")
                k1 += 1
            End While
            getfilename = path & rtfname & "-" & CStr(k1) & ".pdf"
        Else
            getfilename = path & rtfname & ".pdf"
        End If


    End Function
    Public Sub PageNum(ByRef UPAGE As usrpagenumber)

        Dim ffname As String = ""

        Dim reader As PdfReader
        Dim stamper As PdfStamper

        Dim BaseF As BaseFont
        Dim iFont As Font

        Dim FontFam As iTextSharp.text.Font.FontFamily
        Dim Fontname As String


        If UPAGE.radTimesRoman.Checked Then
            FontFam = iTextSharp.text.Font.FontFamily.TIMES_ROMAN
            Fontname = "Times New Roman"
        ElseIf UPAGE.radHelvetica.Checked Then
            FontFam = iTextSharp.text.Font.FontFamily.HELVETICA
            Fontname = "Helvetica"
        Else
            FontFam = iTextSharp.text.Font.FontFamily.COURIER
            Fontname = "Courier"
        End If


        Dim FontStyle As Int16

        If UPAGE.radNORMAL.Checked Then
            FontStyle = iTextSharp.text.Font.NORMAL
        ElseIf UPAGE.radBOLD.Checked Then
            FontStyle = iTextSharp.text.Font.BOLD
        ElseIf UPAGE.radITALIC.Checked Then
            FontStyle = iTextSharp.text.Font.ITALIC
        ElseIf UPAGE.radBOLDITALIC.Checked Then
            FontStyle = iTextSharp.text.Font.BOLDITALIC
        End If

        Dim FontColor As BaseColor
        FontColor = New BaseColor(UPAGE.pageColorDialog.Color.R, UPAGE.pageColorDialog.Color.G, UPAGE.pageColorDialog.Color.B)

        For k1 = 0 To UPAGE.grid.Rows.Count - 1
            If UPAGE.grid.Rows(k1).Cells("CSelect").Value = False Then
                Continue For
            End If
            Dim fname As String
            fname = UPAGE.grid.Rows(k1).Cells(1).Value.ToString & UPAGE.grid.Rows(k1).Cells(2).Value.ToString
            Dim ofname As String
            ofname = getfilename(UPAGE.txtoutfile.Text, UPAGE.grid.Rows(k1).Cells(2).Value.ToString)

            If ffname = "" Then
                ffname = ofname
            End If

            reader = New PdfReader(fname)
            reader.SelectPages(UPAGE.grid.Rows(k1).Cells(4).Value.ToString)

            stamper = New PdfStamper(reader, New FileStream(ofname, FileMode.Create))

            Dim Page_Num As Int16 = UPAGE.grid.Rows(k1).Cells(5).Value
            For np = 1 To reader.NumberOfPages
                Dim over As PdfContentByte = stamper.GetOverContent(np)
                over.BeginText()

                iFont = New Font(FontFam, UPAGE.numfontsize.Value, FontStyle, FontColor)
                BaseF = iFont.GetCalculatedBaseFont(True)

                over.SetFontAndSize(BaseF, UPAGE.numfontsize.Value)
                over.SetRGBColorFill(UPAGE.pageColorDialog.Color.R, UPAGE.pageColorDialog.Color.G, UPAGE.pageColorDialog.Color.B)

                'Get Position
                Dim pagestr As String = UPAGE.lblpageno.Text.Replace("<<N>>", CStr(Page_Num)).Replace("<<n>>", CStr(Page_Num))
                Page_Num += 1

                Dim myfont As System.Drawing.Font
                myfont = New System.Drawing.Font(Fontname, UPAGE.numfontsize.Value, FontStyle, GraphicsUnit.Pixel)
                Dim gr As Graphics = UPAGE.CreateGraphics
                Dim wid As Int16 = CInt(gr.MeasureString(pagestr, myfont).Width)
                Dim hig As Int16 = CInt(gr.MeasureString(pagestr, myfont).Height)

                Dim rect As Rectangle = reader.GetPageSizeWithRotation(np)

                Dim hor As Int16
                Dim ver As Int16

                If UPAGE.radTopLeft.Checked Then
                    hor = 0
                    ver = rect.Height - hig
                ElseIf UPAGE.radTopCenter.Checked Then
                    hor = rect.Width / 2
                    ver = rect.Height - hig
                ElseIf UPAGE.radTopRight.Checked Then
                    hor = rect.Width - wid
                    ver = rect.Height - hig
                ElseIf UPAGE.radBottomLeft.Checked Then
                    hor = 0
                    ver = 0
                ElseIf UPAGE.radBottomCenter.Checked Then
                    hor = rect.Width / 2
                    ver = 0
                ElseIf UPAGE.radBottomRight.Checked Then
                    hor = rect.Width - wid
                    ver = 0
                End If

                'Dim x As Int16 = rect.Width - 100
                'Dim y As Int16 = rect.Height - 100

                hor += +UPAGE.numhori.Value
                ver += UPAGE.numver.Value

                over.SetTextMatrix(hor, ver)

                over.ShowText(pagestr)
                over.EndText()
            Next
            reader.Close()
            stamper.Close()
        Next

        If MsgBox("Page Numbers Has Been Added Successfully.Do You Want To Open", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Process.Start(UPAGE.txtoutfile.Text, vbMaximizedFocus)
            Try
                If frmPMS.radfoxit.Checked Then
                    Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                    Dim h As Object = obj.GetFile(ffname)
                    System.Diagnostics.Process.Start("Foxit.exe", h.shortpath)
                ElseIf frmPMS.radeditor.Checked Then
                    Dim obj As Object = CreateObject("Scripting.FileSystemObject")
                    Dim h As Object = obj.GetFile(ffname)
                    System.Diagnostics.Process.Start("PDFEdit.exe", h.shortpath)
                Else
                    System.Diagnostics.Process.Start(ffname)
                End If
            Catch ex As Exception
                Try
                    System.Diagnostics.Process.Start(ffname)
                Catch ex1 As Exception

                End Try
            End Try
        End If




        'For np = 1 To reader.NumberOfPages
        '    Dim over As PdfContentByte = stamper.GetOverContent(np)
        '    over.BeginText()

        '    iFont = New Font(2, 18)

        '    BaseF = iFont.GetCalculatedBaseFont(False)
        '    over.SetFontAndSize(BaseF, 18)
        '    Dim rect As Rectangle = reader.GetPageSizeWithRotation(np)
        '    Dim x As Int16 = rect.Width - 100
        '    Dim y As Int16 = rect.Height - 100

        '    over.SetTextMatrix(x, y)
        '    over.ShowText("PAGE " & np)
        '    over.EndText()
        '    'over.SetRGBColorStroke(0, 0, 0)
        '    'over.SetLineWidth(5.0F)
        '    'over.Ellipse(250, 450, 350, 550)
        '    'over.Stroke()
        'Next
        'stamper.Close()
    End Sub
    Public Sub ptest()

    End Sub
    Public Function CheckPDFEncrypt(ByVal fname As String) As Int32
        Try
            Dim reader As PdfReader
            reader = New PdfReader(fname)

            If reader.IsEncrypted() Then
                'MsgBox(PdfEncryptor.GetPermissionsVerbose(reader.Permissions))
                'MsgBox(reader.Permissions)
                'Dim str As String
                'str = ""
                'For Each k1 In reader.Info.Keys
                '    str &= reader.Info(k1) & vbLf
                'Next
                'MsgBox(str)
                CheckPDFEncrypt = -1
            Else
                CheckPDFEncrypt = reader.NumberOfPages
            End If
            reader.Close()
        Catch ex As Exception
            CheckPDFEncrypt = -1
        End Try
    End Function
    Public Function Con_byte(ByVal str As String) As System.Byte()
        Dim MyByte(str.Length - 1) As System.Byte
        For k1 = 0 To str.Length - 1
            MyByte(k1) = Convert.ToByte(str.Chars(k1))
        Next
        Return MyByte
    End Function
    Public Function CheckEncrypt(ByVal fname As String) As Int32
        Try                  
            Dim reader As PdfReader
            reader = New PdfReader(fname)
            CheckEncrypt = reader.NumberOfPages
            reader.Close()
        Catch ex As Exception
            CheckEncrypt = -1
        End Try
    End Function
End Module
