Imports System.Windows.Forms

Public Class dlgpanel
    Private Sub butdone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butdone.Click
        Me.Close()
    End Sub

    Private Sub lblinst_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop, lblinst.DragDrop, butdone.DragDrop
        Select Case frmPMS.WhereToDrop
            Case "PMS25"
                frmPMS.pms25.grid_DragDrop(sender, e)
            Case "PMS"
                frmPMS.pms.grid_DragDrop(sender, e)
            Case "PAGENUMBER"
                frmPMS.pgno.grid_DragDrop(sender, e)
            Case "ENCRYPT"
                frmPMS.pencrypt.grid_DragDrop(sender, e)
        End Select
    End Sub

    Private Sub lblinst_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter, lblinst.DragEnter, butdone.DragEnter
        Select Case frmPMS.WhereToDrop
            Case "PMS25"
                frmPMS.pms25.grid_DragEnter(sender, e)
            Case "PMS"
                frmPMS.pms.grid_DragEnter(sender, e)
            Case "PAGENUMBER"
                frmPMS.pgno.grid_DragEnter(sender, e)
            Case "ENCRYPT"
                frmPMS.pencrypt.grid_DragEnter(sender, e)
        End Select
    End Sub
End Class
