Imports System.Windows.Forms

Public Class dlgpanel
    Private Sub butdone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butdone.Click
        Me.Close()
    End Sub

    Private Sub lblinst_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop, lblinst.DragDrop, butdone.DragDrop
        frmPMS.pms.grid_DragDrop(sender, e)
    End Sub

    Private Sub lblinst_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter, lblinst.DragEnter, butdone.DragEnter
        frmPMS.pms.grid_DragEnter(sender, e)
    End Sub

    Private Sub lblinst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblinst.Click

    End Sub

End Class
