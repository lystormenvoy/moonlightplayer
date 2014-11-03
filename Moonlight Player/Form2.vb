Public Class Form2

    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        If OpenDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each filename In OpenDlg.FileNames
                playlist.Items.Add(filename)
            Next
        End If


    End Sub
End Class