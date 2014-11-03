<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnhide = New System.Windows.Forms.Button()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btncls = New System.Windows.Forms.Button()
        Me.lblTtl = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPre = New System.Windows.Forms.Button()
        Me.btnNxt = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(68, 54)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(50, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "播放"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 38)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(383, 10)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnhide
        '
        Me.btnhide.FlatAppearance.BorderSize = 0
        Me.btnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhide.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnhide.Location = New System.Drawing.Point(305, -2)
        Me.btnhide.Name = "btnhide"
        Me.btnhide.Size = New System.Drawing.Size(28, 23)
        Me.btnhide.TabIndex = 3
        Me.btnhide.Text = ""
        Me.btnhide.UseVisualStyleBackColor = True
        '
        'btnmin
        '
        Me.btnmin.FlatAppearance.BorderSize = 0
        Me.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmin.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnmin.Location = New System.Drawing.Point(332, -2)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(32, 23)
        Me.btnmin.TabIndex = 4
        Me.btnmin.Text = ""
        Me.btnmin.UseVisualStyleBackColor = True
        '
        'btncls
        '
        Me.btncls.BackColor = System.Drawing.Color.Red
        Me.btncls.FlatAppearance.BorderSize = 0
        Me.btncls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncls.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btncls.ForeColor = System.Drawing.Color.Gainsboro
        Me.btncls.Location = New System.Drawing.Point(363, -2)
        Me.btncls.Name = "btncls"
        Me.btncls.Size = New System.Drawing.Size(38, 23)
        Me.btncls.TabIndex = 5
        Me.btncls.Text = ""
        Me.btncls.UseVisualStyleBackColor = False
        '
        'lblTtl
        '
        Me.lblTtl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTtl.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTtl.Location = New System.Drawing.Point(0, 0)
        Me.lblTtl.Name = "lblTtl"
        Me.lblTtl.Size = New System.Drawing.Size(401, 35)
        Me.lblTtl.TabIndex = 6
        Me.lblTtl.Text = "Moonlight Player Alpha"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(180, 54)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(50, 23)
        Me.btnStop.TabIndex = 7
        Me.btnStop.Text = "停止"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.Location = New System.Drawing.Point(12, 54)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(50, 23)
        Me.btnPre.TabIndex = 8
        Me.btnPre.Text = "上一首"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnNxt
        '
        Me.btnNxt.Location = New System.Drawing.Point(124, 54)
        Me.btnNxt.Name = "btnNxt"
        Me.btnNxt.Size = New System.Drawing.Size(50, 23)
        Me.btnNxt.TabIndex = 9
        Me.btnNxt.Text = "下一首"
        Me.btnNxt.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(403, 179)
        Me.Controls.Add(Me.btnNxt)
        Me.Controls.Add(Me.btnPre)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btncls)
        Me.Controls.Add(Me.btnmin)
        Me.Controls.Add(Me.btnhide)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblTtl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Moonlight Player"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnhide As System.Windows.Forms.Button
    Friend WithEvents btnmin As System.Windows.Forms.Button
    Friend WithEvents btncls As System.Windows.Forms.Button
    Friend WithEvents lblTtl As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNxt As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
