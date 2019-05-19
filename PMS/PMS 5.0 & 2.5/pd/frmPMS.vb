'Imports LogWrite
Imports System.DirectoryServices
Imports System.ComponentModel
Imports PdfSharp.Pdf

Public Class frmPMS
    'Public Declare Sub writeLog Lib "LogWrite.DLL" Alias "Log.WriteLog" (ByVal fpath As String, ByVal fname As String, ByVal str As String)
    Public WhereToDrop As String = "PMS"
    Public pms As usrpms
    Public pms25 As usrpms25
    Public pgno As usrpagenumber
    Public pencrypt As usrencrypt
    Public mflag As Boolean = False
    'Dim Log As LogWrite.LOG
    Dim flag As Boolean
    Dim status As String
    Private Sub butpms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butpms.Click

        butpms.ForeColor = Color.Lavender
        butpms.BackColor = Color.Black

        butpdfpageno.ForeColor = Color.Black
        butpdfpageno.BackColor = Color.White

        butencrypt.ForeColor = Color.Black
        butencrypt.BackColor = Color.White

        Me.BackColor = Color.Lavender
        grpauthordetails.BackColor = Color.Lavender
        panpdf.Controls.Clear()
        panpdf.Controls.Add(pms)
    End Sub
    Public Sub changeto25()
        panpdf.Controls.Clear()
        panpdf.Controls.Add(pms25)
    End Sub
    Public Sub changeto5()
        panpdf.Controls.Clear()
        panpdf.Controls.Add(pms)
    End Sub
    Private Sub butpdfpageno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butpdfpageno.Click
        butpdfpageno.ForeColor = Color.Yellow
        butpdfpageno.BackColor = Color.Black

        butpms.ForeColor = Color.Black
        butpms.BackColor = Color.White

        butencrypt.ForeColor = Color.Black
        butencrypt.BackColor = Color.White

        Me.BackColor = Color.Cornsilk
        grpauthordetails.BackColor = Color.Cornsilk
        panpdf.Controls.Clear()
        panpdf.Controls.Add(pgno)
    End Sub
    Private Sub butencrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butencrypt.Click
        butencrypt.ForeColor = Color.Pink
        butencrypt.BackColor = Color.Black

        butpms.ForeColor = Color.Black
        butpms.BackColor = Color.White

        butpdfpageno.ForeColor = Color.Black
        butpdfpageno.BackColor = Color.White

        Me.BackColor = Color.Pink
        grpauthordetails.BackColor = Color.Pink
        panpdf.Controls.Clear()
        panpdf.Controls.Add(pencrypt)
    End Sub
    Private Sub butauthor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myd As New Author
        myd.ShowDialog()
    End Sub
    Private Sub frmPMS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            mflag = True
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.B And e.Alt And e.Control Then
            pencrypt.grpbruteforce.Visible = Not pencrypt.grpbruteforce.Visible
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
        status = "Open"
        flag = True
        Try
            'If Strings.LCase(Environ("USERNAME")) <> "inst20001668" Then
            '    writelog("\\LTV-PC-837\Extlister", "PMS.txt", "Unauthorised")
            '    MsgBox("You R A Unauthorised User")
            '    End
            'End If

            bgworker.RunWorkerAsync(status)
            'writelog("\\LTV-PC-837\Extlister", "PMS.txt", "OPEN")
        Catch ex As Exception

        End Try

        panpdf.Controls.Clear()
        pms = New usrpms
        pms25 = New usrpms25
        pgno = New usrpagenumber
        pencrypt = New usrencrypt



        panpdf.Controls.Add(pms)

    End Sub
    Private Sub frmPMS_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'status = "Close"
        Try
            'writelog("\\LTV-PC-837\Extlister", "PMS.txt", "CLOSE")            
            'bgworker.RunWorkerAsync(status)
            'While bgworker.IsBusy
            'End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub writelog(ByVal fpath As String, ByVal fname As String, ByVal str As String)

        If flag Then
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
                flag = False
            End Try
        End If

    End Sub

    Private Sub llblsuggestions_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblsuggestions.LinkClicked
        Dim Filename As String = "mailto:vivek.k@lntvaldel.com;vivek87k@yahoo.co.in"
        Dim MailP As New Process 'declare a new process
        MailP.StartInfo.FileName = Filename 'open default mail client
        MailP.StartInfo.UseShellExecute = True
        MailP.StartInfo.RedirectStandardOutput = False
        MailP.Start()
        MailP.Dispose()
    End Sub

    Private Sub llhelp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llhelp.LinkClicked
        If FileIO.FileSystem.FileExists("Help.pps") Then
            System.Diagnostics.Process.Start("Help.pps")
        ElseIf FileIO.FileSystem.FileExists("Help.ppt") Then
            System.Diagnostics.Process.Start("Help.ppt")
        Else
            MsgBox("Help File Is Not Found")
        End If

    End Sub

    Private Sub bgworker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgworker.DoWork
        '  Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Dim mystatus As String
        mystatus = CStr(e.Argument)
        writelog("\\LTV-PC-837\Extlister", "PMS.txt", mystatus)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butauthor.Click
        Dim myd As New Author
        myd.ShowDialog()
    End Sub
End Class