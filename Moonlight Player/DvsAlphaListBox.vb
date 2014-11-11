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

