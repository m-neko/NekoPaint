Public Class FrmMain

    Private ratio As Double = 1.0#      ' 画像の拡大率
    Private bmp As Bitmap = Nothing     ' 画像データ

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        Application.Exit()
    End Sub

    '画面更新処理
    Private Sub UpdateFormData()
        LblRatio.Text = "倍率: "
        LblPictureSize.Text = "元の画像サイズ: "
        If Not bmp Is Nothing Then
            LblRatio.Text &= ratio.ToString("0.00")
            LblPictureSize.Text &= bmp.Width & " × " & bmp.Height
        Else
            PbxMain.Size = New Size(0, 0)
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateFormData()
    End Sub

    Private Sub MenuOpen_Click(sender As Object, e As EventArgs) Handles MenuOpen.Click
        If DlgOpenFile.ShowDialog() = DialogResult.OK Then
            Try
                bmp = New Bitmap(DlgOpenFile.FileName)
                PbxMain.Image = bmp
                ratio = 1.0#
            Catch ex As Exception
                bmp = Nothing
                PbxMain.Image = Nothing
                MessageBox.Show("画像の読み込みに失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            UpdateFormData()
        End If
    End Sub

End Class
