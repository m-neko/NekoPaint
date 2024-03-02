<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        MenuStrip1 = New MenuStrip()
        MenuFile = New ToolStripMenuItem()
        MenuOpen = New ToolStripMenuItem()
        MenuSaveAs = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        MenuExit = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        LblRatio = New ToolStripStatusLabel()
        LblPictureSize = New ToolStripStatusLabel()
        PnlTop = New Panel()
        Panel2 = New Panel()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        Panel1 = New Panel()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        PnlBottom = New Panel()
        PnlMain = New Panel()
        PbxMain = New PictureBox()
        DlgOpenFile = New OpenFileDialog()
        DlgSaveFile = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        PnlTop.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        PnlMain.SuspendLayout()
        CType(PbxMain, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuFile})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuFile
        ' 
        MenuFile.DropDownItems.AddRange(New ToolStripItem() {MenuOpen, MenuSaveAs, ToolStripMenuItem1, MenuExit})
        MenuFile.Name = "MenuFile"
        MenuFile.Size = New Size(67, 20)
        MenuFile.Text = "ファイル(&F)"
        ' 
        ' MenuOpen
        ' 
        MenuOpen.Name = "MenuOpen"
        MenuOpen.Size = New Size(177, 22)
        MenuOpen.Text = "ファイルを開く(&O)"
        ' 
        ' MenuSaveAs
        ' 
        MenuSaveAs.Name = "MenuSaveAs"
        MenuSaveAs.Size = New Size(177, 22)
        MenuSaveAs.Text = "名前を付けて保存(&A)"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(174, 6)
        ' 
        ' MenuExit
        ' 
        MenuExit.Name = "MenuExit"
        MenuExit.Size = New Size(177, 22)
        MenuExit.Text = "終了(&X)"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {LblRatio, LblPictureSize})
        StatusStrip1.Location = New Point(0, 426)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 24)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' LblRatio
        ' 
        LblRatio.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        LblRatio.BorderStyle = Border3DStyle.SunkenOuter
        LblRatio.Name = "LblRatio"
        LblRatio.Size = New Size(62, 19)
        LblRatio.Text = "倍率: x.xx"
        ' 
        ' LblPictureSize
        ' 
        LblPictureSize.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        LblPictureSize.BorderStyle = Border3DStyle.SunkenOuter
        LblPictureSize.Name = "LblPictureSize"
        LblPictureSize.Size = New Size(153, 19)
        LblPictureSize.Text = "元の画像サイズ: 1000 × 1000"
        ' 
        ' PnlTop
        ' 
        PnlTop.Controls.Add(Panel2)
        PnlTop.Controls.Add(Panel1)
        PnlTop.Dock = DockStyle.Top
        PnlTop.Location = New Point(0, 24)
        PnlTop.Name = "PnlTop"
        PnlTop.Size = New Size(800, 52)
        PnlTop.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(RadioButton4)
        Panel2.Controls.Add(RadioButton5)
        Panel2.Controls.Add(RadioButton6)
        Panel2.Location = New Point(336, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(162, 52)
        Panel2.TabIndex = 1
        ' 
        ' RadioButton4
        ' 
        RadioButton4.Appearance = Appearance.Button
        RadioButton4.BackColor = Color.Chocolate
        RadioButton4.Location = New Point(108, 3)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(48, 48)
        RadioButton4.TabIndex = 5
        RadioButton4.TabStop = True
        RadioButton4.Text = "マーカー"
        RadioButton4.UseVisualStyleBackColor = False
        ' 
        ' RadioButton5
        ' 
        RadioButton5.Appearance = Appearance.Button
        RadioButton5.Location = New Point(57, 2)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(48, 48)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "消しゴム"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.Appearance = Appearance.Button
        RadioButton6.Location = New Point(6, 2)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(48, 48)
        RadioButton6.TabIndex = 3
        RadioButton6.TabStop = True
        RadioButton6.Text = "鉛筆"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(RadioButton3)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Location = New Point(11, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 48)
        Panel1.TabIndex = 0
        ' 
        ' RadioButton3
        ' 
        RadioButton3.Appearance = Appearance.Button
        RadioButton3.Location = New Point(103, 1)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(48, 48)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "マーカー"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.Appearance = Appearance.Button
        RadioButton2.Location = New Point(52, 0)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(48, 48)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "消しゴム"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.Appearance = Appearance.Button
        RadioButton1.Location = New Point(1, 0)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(48, 48)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "鉛筆"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' PnlBottom
        ' 
        PnlBottom.Dock = DockStyle.Bottom
        PnlBottom.Location = New Point(0, 407)
        PnlBottom.Name = "PnlBottom"
        PnlBottom.Size = New Size(800, 19)
        PnlBottom.TabIndex = 3
        ' 
        ' PnlMain
        ' 
        PnlMain.AutoScroll = True
        PnlMain.Controls.Add(PbxMain)
        PnlMain.Dock = DockStyle.Fill
        PnlMain.Location = New Point(0, 76)
        PnlMain.Name = "PnlMain"
        PnlMain.Size = New Size(800, 331)
        PnlMain.TabIndex = 4
        ' 
        ' PbxMain
        ' 
        PbxMain.Location = New Point(0, 0)
        PbxMain.Name = "PbxMain"
        PbxMain.Size = New Size(4096, 3072)
        PbxMain.SizeMode = PictureBoxSizeMode.AutoSize
        PbxMain.TabIndex = 0
        PbxMain.TabStop = False
        ' 
        ' DlgOpenFile
        ' 
        DlgOpenFile.Filter = "画像ファイル|*.bmp;*.jpg;*.jpeg;*.png|すべてのファイル|*.*"
        DlgOpenFile.Title = "ファイルを開く"
        ' 
        ' DlgSaveFile
        ' 
        DlgSaveFile.Filter = "PNG|*.png|BMP|*.bmp|JPEG|*.jpg;*.jpeg"
        DlgSaveFile.Title = "名前を付けて保存"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PnlMain)
        Controls.Add(PnlBottom)
        Controls.Add(PnlTop)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "FrmMain"
        Text = "NekoPaint"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        PnlTop.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        PnlMain.ResumeLayout(False)
        PnlMain.PerformLayout()
        CType(PbxMain, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuFile As ToolStripMenuItem
    Friend WithEvents MenuOpen As ToolStripMenuItem
    Friend WithEvents MenuSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents MenuExit As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LblRatio As ToolStripStatusLabel
    Friend WithEvents LblPictureSize As ToolStripStatusLabel
    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlBottom As Panel
    Friend WithEvents PnlMain As Panel
    Friend WithEvents PbxMain As PictureBox
    Friend WithEvents DlgOpenFile As OpenFileDialog
    Friend WithEvents DlgSaveFile As SaveFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton

End Class
