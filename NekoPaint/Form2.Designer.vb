<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewDoc
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnCancel = New Button()
        BtnOK = New Button()
        txtHeight = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtWidth = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Location = New Point(21, 98)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(81, 35)
        BtnCancel.TabIndex = 0
        BtnCancel.Text = "キャンセル"
        BtnCancel.UseVisualStyleBackColor = True
        ' 
        ' BtnOK
        ' 
        BtnOK.Location = New Point(109, 98)
        BtnOK.Name = "BtnOK"
        BtnOK.Size = New Size(81, 35)
        BtnOK.TabIndex = 1
        BtnOK.Text = "OK"
        BtnOK.UseVisualStyleBackColor = True
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(75, 64)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(51, 23)
        txtHeight.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(19, 15)
        Label1.TabIndex = 3
        Label1.Text = "縦"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(132, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 15)
        Label2.TabIndex = 4
        Label2.Text = "px"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(132, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 15)
        Label3.TabIndex = 7
        Label3.Text = "px"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(19, 15)
        Label4.TabIndex = 6
        Label4.Text = "横"
        ' 
        ' txtWidth
        ' 
        txtWidth.Location = New Point(75, 35)
        txtWidth.Name = "txtWidth"
        txtWidth.Size = New Size(51, 23)
        txtWidth.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 15)
        Label5.TabIndex = 8
        Label5.Text = "新しく作成する画像のサイズ"
        ' 
        ' FrmNewDoc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(208, 145)
        ControlBox = False
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(txtWidth)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtHeight)
        Controls.Add(BtnOK)
        Controls.Add(BtnCancel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FrmNewDoc"
        StartPosition = FormStartPosition.CenterParent
        Text = "新規作成"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label5 As Label
End Class
