Public Class frmLicense

    Private Sub tlsExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsExit.Click
        Close()
    End Sub

    Private Sub tlsOperation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsOperation.Click
        Me.Hide()
        frmOS_License.Show()
    End Sub

    Private Sub tlsSoftware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsSoftware.Click
        Me.Hide()
        frmApplication_License.Show()
    End Sub

    Private Sub frmLicense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tlsStatus.Text = strVersion
    End Sub

End Class
