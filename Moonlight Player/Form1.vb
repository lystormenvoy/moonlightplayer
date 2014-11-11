Imports Un4seen.Bass
Imports Un4seen.Bass.BassNet
'BassNet.Registration("lywjk@outlook.com", "2X534201724822") 
Public Class Form1

    Dim i As Integer = 0
    Dim musicstream As Integer

#Region "界面部分"

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Form2.Top = Me.Top + Me.Height + 1
        Form2.Left = Me.Left
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Form2.Width = Me.Width
    End Sub

    Private Sub btnhide_Click(sender As Object, e As EventArgs) Handles btnhide.Click
        Me.WindowState = FormWindowState.Minimized
        Form2.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnmin_MouseEnter(sender As Object, e As EventArgs) Handles btnmin.MouseEnter
        btnmin.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnmin_MouseLeave(sender As Object, e As EventArgs) Handles btnmin.MouseLeave
        btnmin.BackColor = Color.White
    End Sub
    Private Sub btnhide_MouseEnter(sender As Object, e As EventArgs) Handles btnhide.MouseEnter
        btnhide.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnhide_MouseLeave(sender As Object, e As EventArgs) Handles btnhide.MouseLeave
        btnhide.BackColor = Color.White
    End Sub

    Dim mousex As Integer
    Dim mousey As Integer
    Dim drag As Boolean

    Private Sub lblTtl_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTtl.MouseDown

        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub lblTtl_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTtl.MouseMove
        If drag = True Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub

    Private Sub lblTtl_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTtl.MouseUp
        drag = False
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Form2.WindowState = FormWindowState.Normal 
    End Sub
#End Region

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BassNet.Registration("lywjk@outlook.com", "2X534201724822")
        Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, Me.Handle)
        Bass.BASS_Start()
        Form2.Show()
        Form2.Top = Me.Top + Me.Height + 1
        Form2.Left = Me.Left
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If btnPlay.Text = "播放" Then
            If ProgressBar1.Value = 0 Then
                If Form2.playlist.Items.Count <> 0 And Form2.playlist.SelectedItem <> "" Then
                    'i = Form2.playlist.SelectedIndex
                    musicstream = Bass.BASS_StreamCreateFile(Form2.playlist.SelectedItem, 0, 0, BASSFlag.BASS_DEFAULT)
                    If musicstream <> 0 Then
                        Bass.BASS_ChannelPlay(musicstream, False)
                    Else
                        Console.WriteLine("Stream error: {0}", Bass.BASS_ErrorGetCode())
                    End If
                    Timer1.Enabled = True
                    btnPlay.Text = "暂停"
                Else
                    If Form2.playlist.Items.Count <> 0 Then
                        Form2.playlist.SetSelected(0, True)
                        btnPlay_Click(sender, e)
                    End If
                    If Form2.playlist.Items.Count = 0 Then
                        Form2.btnAddFile_Click(sender, e)
                        btnPlay_Click(sender, e)
                    End If
                End If
            Else
                'musicstream = Bass.BASS_StreamCreateFile(Form2.playlist.SelectedItem, 0, 0, BASSFlag.BASS_DEFAULT)
                Bass.BASS_ChannelPlay(musicstream, False)
                Timer1.Enabled = True
                btnPlay.Text = "暂停"
            End If
        Else
            Bass.BASS_ChannelPause(musicstream)
            btnPlay.Text = "播放"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim pos As Long
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = Bass.BASS_ChannelBytes2Seconds(musicstream, Bass.BASS_ChannelGetLength(musicstream))

        pos = Bass.BASS_ChannelBytes2Seconds(musicstream, Bass.BASS_ChannelGetPosition(musicstream))
        If ProgressBar1.Value < pos Then
            ProgressBar1.Value = Bass.BASS_ChannelBytes2Seconds(musicstream, Bass.BASS_ChannelGetPosition(musicstream))
        Else
            i += 1
            Form2.playlist_SltChg(i)
            ProgressBar1.Value = 0
            musicstream = Bass.BASS_StreamCreateFile(Form2.playlist.SelectedItem, 0, 0, BASSFlag.BASS_DEFAULT)
            Bass.BASS_ChannelPlay(musicstream, True)
        End If
    End Sub

    Private Sub btncls_Click(sender As Object, e As EventArgs) Handles btncls.Click
        Bass.BASS_ChannelStop(musicstream)
        Bass.BASS_StreamFree(musicstream)
        Bass.BASS_Stop()
        Bass.BASS_Free()
        Me.Close()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        btnPlay.Text = "播放"
        Bass.BASS_ChannelStop(musicstream)
        Bass.BASS_StreamFree(musicstream)
    End Sub

    'Private Sub btnPre_Click(sender As Object, e As EventArgs) Handles btnPre.Click '上一首按钮
    '    Dim pre As Integer
    '    pre = Form2.playlist.SelectedIndex - 1
    '    If pre >= 0 Then
    '        Form2.playlist.SetSelected(pre, True)
    '        player.OpenFile(Form2.playlist.SelectedItem, TStreamFormat.sfAutodetect)
    '        player.StartPlayback()
    '    Else
    '        pre = 0
    '        Form2.playlist.SetSelected(pre, True)
    '        player.OpenFile(Form2.playlist.SelectedItem, TStreamFormat.sfAutodetect)
    '        player.StartPlayback()
    '    End If

    'End Sub

    'Private Sub btnNxt_Click(sender As Object, e As EventArgs) Handles btnNxt.Click '下一首按钮
    '    Dim nxt As Integer
    '    nxt = Form2.playlist.SelectedIndex + 1
    '    If nxt <= Form2.playlist.Items.Count - 1 Then
    '        Form2.playlist.SetSelected(nxt, True)
    '        player.OpenFile(Form2.playlist.SelectedItem, TStreamFormat.sfAutodetect)
    '        player.StartPlayback()
    '    Else
    '        nxt = 0
    '        Form2.playlist.SetSelected(nxt, True)
    '        player.OpenFile(Form2.playlist.SelectedItem, TStreamFormat.sfAutodetect)
    '        player.StartPlayback()
    '    End If
    'End Sub

    Private Sub Vol1_ValueChanged(sender As Object, e As EventArgs) Handles Vol1.ValueChanged
        Bass.BASS_ChannelSetAttribute(musicstream, BASSAttribute.BASS_ATTRIB_VOL, Vol1.Value / Vol1.Maximum)
    End Sub
End Class
