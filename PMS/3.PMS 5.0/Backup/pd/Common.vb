Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports System.IO

Public Module CompatiblePdfReader

    ''' <summary>
    ''' uses itextsharp 4.1.6 to convert any pdf to 1.4 compatible pdf, called instead of PdfReader.open
    ''' </summary>
    ''' <param name="sFilename"></param>
    ''' <returns></returns>
    ''' 
    Public Function getpagecount(ByVal sFilename As String) As Int32
        Dim reader As New iTextSharp.text.pdf.PdfReader(sFilename)

        'Dim str As String = ""
        'For k1 = 1 To reader.NumberOfPages
        '    str = str & reader.GetPageRotation(k1) & vbLf
        'Next
        'MsgBox(str)

        reader.Close()
        Return reader.NumberOfPages
    End Function
    Public Function Open(ByVal sFilename As String) As PdfDocument

        Dim reader As New PdfDocument()

        Try
            reader = PdfReader.Open(sFilename, PdfDocumentOpenMode.Import)
        Catch generatedExceptionName As PdfSharp.Pdf.IO.PdfReaderException
            'workaround if pdfsharp doesnt dupport this pdf
            Dim newName As MemoryStream = ReturnCompatiblePdf(sFilename)
            reader = PdfReader.Open(newName, PdfDocumentOpenMode.Import)
        End Try

        Return reader
    End Function


    ''' <summary>
    ''' uses itextsharp 4.1.6 to convert any pdf to 1.4 compatible pdf
    ''' </summary>
    ''' <param name="sFilename"></param>
    ''' <returns></returns>
    Private Function ReturnCompatiblePdf(ByVal sFilename As String) As MemoryStream

        Dim reader As New iTextSharp.text.pdf.PdfReader(sFilename)
        Dim output_stream As New MemoryStream

        ' we retrieve the total number of pages
        Dim n As Integer = reader.NumberOfPages
        ' step 1: creation of a document-object
        Dim document As New iTextSharp.text.Document(reader.GetPageSizeWithRotation(1))

        ' step 2: we create a writer that listens to the document
        Dim writer As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(document, output_stream)
        'write pdf that pdfsharp can understand
        writer.SetPdfVersion(iTextSharp.text.pdf.PdfWriter.PDF_VERSION_1_4)

        ' step 3: we open the document
        document.Open()
        Dim cb As iTextSharp.text.pdf.PdfContentByte = writer.DirectContent
        Dim page As iTextSharp.text.pdf.PdfImportedPage

        Dim rotation As Integer

        Dim i As Integer = 0
        While i < n
            i += 1
            document.SetPageSize(reader.GetPageSizeWithRotation(i))
            document.NewPage()
            page = writer.GetImportedPage(reader, i)
            rotation = reader.GetPageRotation(i)
            If rotation = 90 OrElse rotation = 270 Then
                cb.AddTemplate(page, 0, -1.0F, 1.0F, 0, 0, _
                reader.GetPageSizeWithRotation(i).Height)
            Else
                cb.AddTemplate(page, 1.0F, 0, 0, 1.0F, 0, _
                0)
            End If
        End While

        '---- Keep the stream open!
        writer.CloseStream = False

        ' step 5: we close the document
        document.Close()

        Return output_stream

    End Function
    Public Sub PdfChangeversion(ByVal sFilename As String)

        Dim reader As New iTextSharp.text.pdf.PdfReader(FileIO.FileSystem.GetParentPath(sFilename) & "\~PMSTEMP.PDF")

        Dim output_stream As New MemoryStream

        ' we retrieve the total number of pages
        Dim n As Integer = reader.NumberOfPages
        ' step 1: creation of a document-object
        Dim document As New iTextSharp.text.Document(reader.GetPageSizeWithRotation(1))

        ' step 2: we create a writer that listens to the document
        Dim writer As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(document, New FileStream(sFilename, FileMode.Create))
        'write pdf that pdfsharp can understand
        writer.SetPdfVersion(iTextSharp.text.pdf.PdfWriter.PDF_VERSION_1_4)

        ' step 3: we open the document
        document.Open()
        Dim cb As iTextSharp.text.pdf.PdfContentByte = writer.DirectContent
        Dim page As iTextSharp.text.pdf.PdfImportedPage

        Dim rotation As Integer

        Dim i As Integer = 0
        While i < n
            i += 1
            document.SetPageSize(reader.GetPageSizeWithRotation(i))
            document.NewPage()
            page = writer.GetImportedPage(reader, i)
            rotation = reader.GetPageRotation(i)
            If rotation = 90 OrElse rotation = 270 Then
                cb.AddTemplate(page, 0, -1.0F, 1.0F, 0, 0, reader.GetPageSizeWithRotation(i).Height)
            Else
                cb.AddTemplate(page, 1.0F, 0, 0, 1.0F, 0, 0)
            End If
        End While


        '---- Keep the stream open!
        writer.CloseStream = True

        ' step 5: we close the document
        document.Close()

    End Sub

End Module