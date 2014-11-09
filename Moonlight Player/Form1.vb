Imports Un4seen.Bass
Imports Un4seen.Bass.BassNet
'BassNet.Registration("lywjk@outlook.com", "2X534201724822")
Public Class Form1

    Dim i As Integer = 0

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
        Form2.Show()
        Form2.Top = Me.Top + Me.Height + 1
        Form2.Left = Me.Left
        Dim Form3 As New Form
        Dim listbox2 = New DvsAlphaListBox
        listbox2.Location = New Point(0, 0)
        Form3.Controls.Add(listbox2)
        Form3.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim musicstream As Integer

        If btnPlay.Text = "播放" Then
                If ProgressBar1.Value = 0 Then
                If Form2.playlist.Items.Count <> 0 And Form2.playlist.SelectedItem <> "" Then
                    musicstream = Bass.BASS_StreamCreateFile(Form2.playlist.SelectedItem.ToString, 0, 0, BASSFlag.BASS_DEFAULT)
                    If musicstream <> 0 Then
                        ' play the stream channel
                        Bass.BASS_ChannelPlay(musicstream, True)
                    Else
                        ' error creating the stream
                        Console.WriteLine("Stream error: {0}", Bass.BASS_ErrorGetCode())
                    End If
                    Timer1.Enabled = True
                    btnPlay.Text = "暂停"
                End If
                Else
                    Bass.BASS_ChannelPlay(Form2.playlist.SelectedItem, False)
                End If
        Else
            'Bass.BASS_ChannelPause()
            btnPlay.Text = "播放"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'ProgressBar1.Minimum = 0
        'ProgressBar1.Maximum = CInt(Fix(StreamInfo.Length.sec))

        'If ProgressBar1.Maximum > CInt(Fix(pos.sec)) Then
        'ProgressBar1.Value = CInt(Fix(pos.sec))
        'Else
        'i += 1
        'Bass.BASS_ChannelPlay(Form2.playlist.Items.Item(i), True)
        'End If
    End Sub

    Private Sub btncls_Click(sender As Object, e As EventArgs) Handles btncls.Click
        Me.Close()
    End Sub

    'Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
    '    player.StopPlayback()
    'End Sub

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

    Public Class DvsAlphaListBox
        Inherits ListBox
        Private doc As Object
        Public Sub New()
            AddAlpha()
            Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            Me.DoubleBuffered = True
            Me.ItemHeight = 30
            Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, _
            System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        End Sub
        Private Sub AddAlpha()
            Me.SetStyle(ControlStyles.UserPaint, True)
            Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.DoubleBuffer, True)
        End Sub
        Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
            Me.Invalidate()
            MyBase.OnSelectedIndexChanged(e)
        End Sub
        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            AddAlpha()
            If Me.Focused AndAlso Me.SelectedItem IsNot Nothing Then
                Dim itemRect As Rectangle = Me.GetItemRectangle(Me.SelectedIndex)
                e.Graphics.FillRectangle(Brushes.LightBlue, itemRect)
            End If
            Dim i As Integer = 0
            While i < Items.Count
                Dim strFmt As StringFormat = New System.Drawing.StringFormat()
                strFmt.LineAlignment = StringAlignment.Center
                e.Graphics.DrawString(Me.GetItemText(Me.Items(i)), Me.Font, New SolidBrush(Me.ForeColor), Me.GetItemRectangle(i), strFmt)
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
            MyBase.OnPaint(e)
        End Sub
        Private Sub Me_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
            '这里是单击右键能够在列表中选中的列表项上面弹出菜单 的 源代码
            On Error Resume Next
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim ht As Integer = Me.ItemHeight
                Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, ht)
                For SelectListItem As Integer = 0 To Me.Items.Count - 1
                    If rect.Contains(e.Location) Then
                        Me.SelectedIndex = SelectListItem + Me.TopIndex
                        Me.SetSelected(Me.SelectedIndex, True)
                        Exit For
                    Else
                        rect.Y += ht
                    End If
                Next SelectListItem
                ht = Nothing
                rect = Nothing
            End If
        End Sub
    End Class

End Class
