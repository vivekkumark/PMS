'Imports LogWrite
Imports System.DirectoryServices
Public Class frmPMS
    'Public Declare Sub writeLog Lib "LogWrite.DLL" Alias "Log.WriteLog" (ByVal fpath As String, ByVal fname As String, ByVal str As String)
    Public pms As usrpms
    Public pgno As usrpagenumber
    Public mflag As Boolean = False
    'Dim Log As LogWrite.LOG

    Private Sub butpms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butpms.Click

        butpms.ForeColor = Color.Lavender
        butpms.BackColor = Color.Black

        butpdfpageno.ForeColor = Color.Black
        butpdfpageno.BackColor = Color.White

        Me.BackColor = Color.Lavender
        panpdf.Controls.Clear()
        panpdf.Controls.Add(pms)
    End Sub

    Private Sub butpdfpageno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butpdfpageno.Click
        butpdfpageno.ForeColor = Color.Yellow
        butpdfpageno.BackColor = Color.Black

        butpms.ForeColor = Color.Black
        butpms.BackColor = Color.White

        Me.BackColor = Color.Cornsilk
        panpdf.Controls.Clear()
        panpdf.Controls.Add(pgno)
    End Sub

    Private Sub butauthor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butauthor.Click
        Dim myd As New Author
        myd.ShowDialog()
    End Sub



    Private Sub frmPMS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            mflag = True
        End If
    End Sub

    Private Sub frmPMS_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            mflag = False
        End If
    End Sub
    Private Function FULLNAME(ByVal UsernameToFind As String) As String
        Using searcher As New DirectorySearcher(New DirectoryEntry())
            searcher.PageSize = 1000
            searcher.SearchScope = SearchScope.Subtree
            searcher.Filter = "(&(samAccountType=805306368)(sAMAccountName=" & UsernameToFind & "))"
            Using Results As SearchResultCollection = searcher.FindAll
                If Results Is Nothing OrElse Results.Count <> 1 Then
                    'Throw New ApplicationException("Invalid number of results returned - either no users were found or more than one user account was found")
                    Return "INVALID"
                End If
                Using UserDE As DirectoryEntry = Results(0).GetDirectoryEntry
                    Return UserDE.Name.Replace("CN=", "")
                End Using
            End Using
        End Using
    End Function

    Private Sub frmPMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'MsgBox(getpagecount("C:\Documents and Settings\inst20001668\Desktop\Merged.pdf"))


        Try
            If Strings.LCase(Environ("USERNAME")) <> "inst20001668" Then
                writelog("\\LTV-PC-837\Extlister", "PMS.txt", "Unauthorised")
                MsgBox("You R A Unauthorised User")
                End
            End If
            writelog("\\LTV-PC-837\Extlister", "PMS.txt", "OPEN")
        Catch ex As Exception

        End Try

        panpdf.Controls.Clear()
        pms = New usrpms
        pgno = New usrpagenumber

        panpdf.Controls.Add(pms)

    End Sub
    Private Sub frmPMS_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            writelog("\\LTV-PC-837\Extlister", "PMS.txt", "CLOSE")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub writelog(ByVal fpath As String, ByVal fname As String, ByVal str As String)

        Dim mydate As String
        Dim dateo As Date = Now
        mydate = dateo.Day & "\" & dateo.Month & "\" & dateo.Year & "$" & dateo.ToLongTimeString
        str = str & "$" & FULLNAME(Environ("USERNAME")) & "$" & Environ("USERNAME") & "$" & Environ("COMPUTERNAME") & "$" & mydate & "$" & Application.ExecutablePath
        Try
            If FileIO.FileSystem.DirectoryExists(fpath) Then
                Dim objWriter As New System.IO.StreamWriter(fpath & "\" & fname, True)
                objWriter.WriteLine(str)
                objWriter.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class