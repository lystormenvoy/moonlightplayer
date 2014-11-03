<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.playlist = New System.Windows.Forms.ListBox()
        Me.PlayListPnl = New System.Windows.Forms.TabControl()
        Me.DefaultList = New System.Windows.Forms.TabPage()
        Me.btnAddFile = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PlayListPnl.SuspendLayout()
        Me.DefaultList.SuspendLayout()
        Me.SuspendLayout()
        '
        'playlist
        '
        Me.playlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playlist.FormattingEnabled = True
        Me.playlist.ItemHeight = 12
        Me.playlist.Location = New System.Drawing.Point(6, 6)
        Me.playlist.Name = "playlist"
        Me.playlist.Size = New System.Drawing.Size(436, 412)
        Me.playlist.TabIndex = 0
        '
        'PlayListPnl
        '
        Me.PlayListPnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayListPnl.Controls.Add(Me.DefaultList)
        Me.PlayListPnl.Location = New System.Drawing.Point(4, 5)
        Me.PlayListPnl.Name = "PlayListPnl"
        Me.PlayListPnl.SelectedIndex = 0
        Me.PlayListPnl.Size = New System.Drawing.Size(456, 451)
        Me.PlayListPnl.TabIndex = 1
        '
        'DefaultList
        '
        Me.DefaultList.Controls.Add(Me.playlist)
        Me.DefaultList.Location = New System.Drawing.Point(4, 22)
        Me.DefaultList.Name = "DefaultList"
        Me.DefaultList.Padding = New System.Windows.Forms.Padding(3)
        Me.DefaultList.Size = New System.Drawing.Size(448, 425)
        Me.DefaultList.TabIndex = 0
        Me.DefaultList.Text = "默认"
        Me.DefaultList.UseVisualStyleBackColor = True
        '
        'btnAddFile
        '
        Me.btnAddFile.Location = New System.Drawing.Point(4, 462)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFile.TabIndex = 1
        Me.btnAddFile.Text = "添加文件"
        Me.btnAddFile.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(85, 462)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "添加文件夹"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 490)
        Me.Controls.Add(Me.btnAddFile)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PlayListPnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.PlayListPnl.ResumeLayout(False)
        Me.DefaultList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents playlist As System.Windows.Forms.ListBox
    Friend WithEvents PlayListPnl As System.Windows.Forms.TabControl
    Friend WithEvents DefaultList As System.Windows.Forms.TabPage
    Friend WithEvents btnAddFile As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
