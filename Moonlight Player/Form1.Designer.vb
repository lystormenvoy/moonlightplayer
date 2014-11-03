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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.musicfile = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnhide = New System.Windows.Forms.Button()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btncls = New System.Windows.Forms.Button()
        Me.lblTtl = New System.Windows.Forms.Label()
        Me.OpenDlg = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFldDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(320, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'musicfile
        '
        Me.musicfile.Location = New System.Drawing.Point(12, 66)
        Me.musicfile.Name = "musicfile"
        Me.musicfile.Size = New System.Drawing.Size(383, 21)
        Me.musicfile.TabIndex = 1
        Me.musicfile.Text = "C:\Users\AVAS\Desktop\小爱的妈 -江山雪.mp3"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 93)
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
        Me.lblTtl.Size = New System.Drawing.Size(401, 26)
        Me.lblTtl.TabIndex = 6
        Me.lblTtl.Text = "Moonlight Player"
        '
        'OpenDlg
        '
        Me.OpenDlg.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(403, 179)
        Me.Controls.Add(Me.btncls)
        Me.Controls.Add(Me.btnmin)
        Me.Controls.Add(Me.btnhide)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.musicfile)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTtl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Moonlight Player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents musicfile As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnhide As System.Windows.Forms.Button
    Friend WithEvents btnmin As System.Windows.Forms.Button
    Friend WithEvents btncls As System.Windows.Forms.Button
    Friend WithEvents lblTtl As System.Windows.Forms.Label
    Friend WithEvents OpenDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFldDlg As System.Windows.Forms.FolderBrowserDialog

End Class
