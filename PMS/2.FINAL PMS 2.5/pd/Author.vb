Imports System.Windows.Forms
Public Class Author
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub llblcomments_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblcomments.LinkClicked
        Dim Filename As String = "mailto:vivek.k@lntvaldel.com;vivek87k@yahoo.co.in"
        Dim MailP As New Process 'declare a new process
        MailP.StartInfo.FileName = Filename 'open default mail client
        MailP.StartInfo.UseShellExecute = True
        MailP.StartInfo.RedirectStandardOutput = False
        MailP.Start()
        MailP.Dispose()
        Me.Close()
    End Sub

    Private Sub Author_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub Author_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Author_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        frmPMS.writelog("\\LTV-PC-837\Extlister", "PMS.txt", "AUTHOR")
    End Sub
End Class
