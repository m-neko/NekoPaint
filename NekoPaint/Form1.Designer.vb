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
        PnlBottom = New Panel()
        PnlMain = New Panel()
        PbxMain = New PictureBox()
        DlgOpenFile = New OpenFileDialog()
        DlgSaveFile = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
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
        MenuOpen.Size = New Size(180, 22)
        MenuOpen.Text = "ファイルを開く(&O)"
        ' 
        ' MenuSaveAs
        ' 
        MenuSaveAs.Name = "MenuSaveAs"
        MenuSaveAs.Size = New Size(180, 22)
        MenuSaveAs.Text = "名前を付けて保存(&A)"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(177, 6)
        ' 
        ' MenuExit
        ' 
        MenuExit.Name = "MenuExit"
        MenuExit.Size = New Size(180, 22)
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
        PnlTop.Dock = DockStyle.Top
        PnlTop.Location = New Point(0, 24)
        PnlTop.Name = "PnlTop"
        PnlTop.Size = New Size(800, 52)
        PnlTop.TabIndex = 2
        ' 
        ' PnlBottom
        ' 
        PnlBottom.Dock = DockStyle.Bottom
        PnlBottom.Location = New Point(0, 374)
        PnlBottom.Name = "PnlBottom"
        PnlBottom.Size = New Size(800, 52)
        PnlBottom.TabIndex = 3
        ' 
        ' PnlMain
        ' 
        PnlMain.AutoScroll = True
        PnlMain.Controls.Add(PbxMain)
        PnlMain.Dock = DockStyle.Fill
        PnlMain.Location = New Point(0, 76)
        PnlMain.Name = "PnlMain"
        PnlMain.Size = New Size(800, 298)
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

End Class
