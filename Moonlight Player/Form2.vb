Imports System.IO
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports LayeredSkin.Forms
Imports LayeredSkin.DirectUI
Imports Un4seen.Bass
Imports Un4seen.Bass.BassNet


Public Class Form2
    Public Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
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
            OpenFldDlg.Description = "选择音乐文件夹导入音乐文件"
            GetAllFile(OpenFldDlg.SelectedPath)
        End If
    End Sub

    Private Sub GetAllFile(ByVal path As String)
        Dim strDir As String() = Directory.GetDirectories(path)
        Dim strFile As String() = Directory.GetFiles(path)
        Dim extname As String
        Dim i As Integer
        If strFile.Length > 0 Then
            For i = 0 To strFile.Length - 1
                extname = strFile(i).Substring(InStrRev(strFile(i), "."), strFile(i).Length - InStrRev(strFile(i), "."))
                If extname = "mp3" Or extname = "flac" Or extname = "ac3" Or extname = "ogg" Then
                    playlist.Items.Add(strFile(i))
                End If
            Next
        End If
        If strDir.Length > 0 Then
            For i = 0 To strDir.Length - 1
                GetAllFile(strDir(i))
            Next
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub List1_ItemClick(sender As Object, e As LayeredSkin.Controls.ItemClickEventArgs)

    End Sub

    Public Sub playlist_SltChg(ByVal index)
        If index >= 0 And index <= playlist.Items.Count - 1 Then
            playlist.SetSelected(index, True)
        Else
            playlist.SetSelected(0, True)
        End If
    End Sub
End Class