Public Class Form2

    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        Dim OpenDlg = New OpenFileDialog
        OpenDlg.Multiselect = True
        OpenDlg.CheckFileExists = True
        OpenDlg.Title = "添加音乐文件"
        If OpenDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each filename In OpenDlg.FileNames
                playlist.Items.Add(filename)
            Next
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenFldDlg As New FolderBrowserDialog
        If OpenFldDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'For Each filename In OpenFldDlg.SelectedPath
        End If
    End Sub
End Class