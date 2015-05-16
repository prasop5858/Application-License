Imports System.Data.OleDb

Public Class frmOS_License

    Private Sub frmOS_License_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLicense.Close()
        tlsVersion.Text = strVersion
        setGrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLicense.Close()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        frmLicense.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Public Sub setGrid()
        Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\npfiles\it_develop\prasop\dbLicense.mdb"
        Dim Conn As New OleDbConnection(strConn)
        Dim ds As New DataSet

        If ds.Tables.Contains("MyData") Then
            ds.Tables.Remove("MyData")
        End If

        Dim strSql As String
        strSql = "SELECT * FROM LICENSE"
        Dim da As OleDbDataAdapter
        da = New OleDbDataAdapter(strSql, Conn)
        da.Fill(ds, "MyData")
        Me.dgvMain.DataSource = ds.Tables("MyData")
    End Sub

End Class