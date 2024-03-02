Imports System.ComponentModel

Public Class FrmMain

    Private ratio As Double = 1.0#      ' 画像の拡大率
    Private bmp As Bitmap = Nothing     ' 画像データ
    Private filePath As String = ""     ' 開いているファイルのパス

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        Application.Exit()
    End Sub

    '画面更新処理
    Private Sub UpdateFormData()
        LblRatio.Text = "倍率: "
        LblPictureSize.Text = "元の画像サイズ: "
        Me.Text = "NekoPaint"

        If Not bmp Is Nothing Then
            Me.Text &= " - " & filePath
            LblRatio.Text &= ratio.ToString("0.00")
            LblPictureSize.Text &= bmp.Width & " × " & bmp.Height
            MenuSaveAs.Enabled = True
        Else
            PbxMain.Size = New Size(0, 0)
            MenuSaveAs.Enabled = False
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
                filePath = DlgOpenFile.FileName
            Catch ex As Exception
                bmp = Nothing
                PbxMain.Image = Nothing
                MessageBox.Show("画像の読み込みに失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            UpdateFormData()
        End If
    End Sub

    Private Sub MenuSaveAs_Click(sender As Object, e As EventArgs) Handles MenuSaveAs.Click
        DlgSaveFile.FileName = ""

        If DlgSaveFile.ShowDialog() = DialogResult.OK Then
            Try
                Dim ext As String = IO.Path.GetExtension(DlgSaveFile.FileName)

                Select Case ext.ToUpper
                    Case ".PNG"
                        PbxMain.Image.Save(DlgSaveFile.FileName, Imaging.ImageFormat.Png)
                    Case ".BMP"
                        PbxMain.Image.Save(DlgSaveFile.FileName, Imaging.ImageFormat.Bmp)
                    Case ".JPG", ".JPEG"
                        PbxMain.Image.Save(DlgSaveFile.FileName, Imaging.ImageFormat.Jpeg)
                End Select
                filePath = DlgSaveFile.FileName
            Catch ex As Exception
                MessageBox.Show("画像の保存に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            UpdateFormData()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Dim temp As RadioButton = CType(sender, RadioButton)
        MsgBox(temp.BackColor.ToString)
    End Sub

    Private Sub PbxMain_Click(sender As Object, e As EventArgs) Handles PbxMain.Click
        'Dim g As Graphics = Graphics.FromImage(bmp)
        'Dim pos As Point = PbxMain.PointToClient(System.Windows.Forms.Cursor.Position)
        'Dim objPen As Pen = New Pen(Color.FromArgb(255, 255, 255), 2)
        ''g.DrawString("Hello World", Me.Font, Brushes.Blue, pos.X, pos.Y)
        'g.DrawLine(objPen, pos.X, pos.Y, pos.X + 1, pos.Y + 1)
        'objPen.Dispose()
        'g.Dispose()

        'PbxMain.Image = bmp
    End Sub

    Private Sub PbxMain_DragOver(sender As Object, e As DragEventArgs) Handles PbxMain.DragOver
        'Dim g As Graphics = Graphics.FromImage(bmp)
        'Dim pos As Point = PbxMain.PointToClient(System.Windows.Forms.Cursor.Position)
        'Dim objPen As Pen = New Pen(Color.FromArgb(255, 255, 255), 2)
        ''g.DrawString("Hello World", Me.Font, Brushes.Blue, pos.X, pos.Y)
        'g.DrawLine(objPen, pos.X, pos.Y, pos.X + 1, pos.Y + 1)
        'objPen.Dispose()
        'g.Dispose()

        'PbxMain.Image = bmp
    End Sub

    Private Sub PbxMain_MouseDown(sender As Object, e As MouseEventArgs) Handles PbxMain.MouseDown
        'Dim g As Graphics = Graphics.FromImage(bmp)
        'Dim pos As Point = PbxMain.PointToClient(System.Windows.Forms.Cursor.Position)
        'Dim objPen As Pen = New Pen(Color.FromArgb(255, 255, 255), 2)
        ''g.DrawString("Hello World", Me.Font, Brushes.Blue, pos.X, pos.Y)
        'g.DrawLine(objPen, pos.X, pos.Y, pos.X + 1, pos.Y + 1)
        'objPen.Dispose()
        'g.Dispose()

        'PbxMain.Image = bmp
    End Sub

    Private Sub PbxMain_MouseMove(sender As Object, e As MouseEventArgs) Handles PbxMain.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim pos As Point = PbxMain.PointToClient(System.Windows.Forms.Cursor.Position)
            Dim objPen As Pen = New Pen(Color.FromArgb(255, 255, 255))
            'g.DrawString("Hello World", Me.Font, Brushes.Blue, pos.X, pos.Y)
            g.DrawLine(objPen, pos, pos)
            objPen.Dispose()
            g.Dispose()

            PbxMain.Image = bmp
        End If
    End Sub
End Class
