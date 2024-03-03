Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmMain

    Private ratio As Double = 1.0#                      ' 画像の拡大率
    Private bmp As Bitmap = Nothing                     ' 画像データ
    Private filePath As String = ""                     ' 開いているファイルのパス
    Private fcolor As Color = Color.Black                     ' 前景色
    Private textFont As Font = New Font("ＭＳ ゴシック", 18)  ' フォント

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        Application.Exit()
    End Sub

    '画面更新処理
    Private Sub UpdateFormData()
        Me.Text = "NekoPaint"
        LblRatio.Text = "倍率: "
        LblPictureSize.Text = "元の画像サイズ: "
        LblFont.Text = textFont.Name & " : " & CInt(textFont.Size) & "pt"
        PbxColor.BackColor = fcolor

        If Not bmp Is Nothing Then
            If filePath <> "" Then
                Me.Text &= " - " & filePath
            End If
            LblRatio.Text &= ratio.ToString("0.00")
            LblPictureSize.Text &= bmp.Width & " × " & bmp.Height
            MenuSaveAs.Enabled = True
            MenuPrint.Enabled = True
        Else
            PbxMain.Size = New Size(0, 0)
            MenuSaveAs.Enabled = False
            MenuPrint.Enabled = False
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

    Private Sub PbxMain_Click(sender As Object, e As EventArgs) Handles PbxMain.Click

        If BtnText.Checked Then
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim pos As Point = PbxMain.PointToClient(System.Windows.Forms.Cursor.Position)
            Dim objBrush As SolidBrush = New SolidBrush(fcolor)

            g.DrawString(TxtText.Text, textFont, objBrush, pos)
            objBrush.Dispose()
            g.Dispose()
            PbxMain.Image = bmp
        End If

    End Sub

    Private Sub PbxMain_MouseMove(sender As Object, e As MouseEventArgs) Handles PbxMain.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim pos As Point = PbxMain.PointToClient(System.Windows.Forms.Cursor.Position)
            Dim objBrush As SolidBrush = New SolidBrush(fcolor)
            'g.DrawString("Hello World", Me.Font, Brushes.Blue, pos.X, pos.Y)
            'g.DrawLine(objPen, pos, pos)

            If BtnPencil.Checked Then
                g.FillEllipse(objBrush, New Rectangle(pos.X, pos.Y, 2, 2))
            ElseIf BtnMakerPen.Checked Then
                g.FillEllipse(objBrush, New Rectangle(pos.X, pos.Y, 8, 8))
            ElseIf BtnEraser.Checked Then
                g.FillRectangle(Brushes.White, New Rectangle(pos.X, pos.Y, 12, 12))
            End If

            objBrush.Dispose()
            g.Dispose()
            PbxMain.Image = bmp
        End If
    End Sub

    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColor.Click
        If DlgColor.ShowDialog() = DialogResult.OK Then
            fcolor = DlgColor.Color
            UpdateFormData()
        End If
    End Sub

    Private Sub BtnFont_Click(sender As Object, e As EventArgs) Handles BtnFont.Click
        If DlgFont.ShowDialog = DialogResult.OK Then
            textFont = DlgFont.Font
            UpdateFormData()
        End If
    End Sub

    Private Sub MenuVersion_Click(sender As Object, e As EventArgs) Handles MenuVersion.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub MenuPrint_Click(sender As Object, e As EventArgs) Handles MenuPrint.Click
        Dim doc As New System.Drawing.Printing.PrintDocument
        AddHandler doc.PrintPage, AddressOf pdcImage_PrintPage
        DlgPrint.Document = doc

        If DlgPrint.ShowDialog() = DialogResult.OK Then
            doc.Print()
        End If
    End Sub

    Private Sub pdcImage_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdcImage.PrintPage
        Dim recDoc As Rectangle = e.MarginBounds
        If e.MarginBounds.Width > e.MarginBounds.Height Then
            recDoc.Width *= CDbl(PbxMain.Height / PbxMain.Width)
        Else
            recDoc.Height *= CDbl(PbxMain.Height / PbxMain.Width)
        End If

        e.Graphics.DrawImage(PbxMain.Image, recDoc)
        e.HasMorePages = False
    End Sub

    Private Sub MenuNewDoc_Click(sender As Object, e As EventArgs) Handles MenuNewDoc.Click
        If FrmNewDoc.ShowDialog() = DialogResult.OK Then
            Try
                Dim bmpWidth As Integer = CInt(FrmNewDoc.txtWidth.Text)
                Dim bmpHeight As Integer = CInt(FrmNewDoc.txtHeight.Text)
                bmp = New Bitmap(bmpWidth, bmpHeight)
                filePath = ""
                Dim g As Graphics = Graphics.FromImage(bmp)
                g.FillRectangle(Brushes.White, 0, 0, bmpWidth, bmpHeight)
                g.Dispose()
            Catch ex As Exception
                MessageBox.Show("新しい画像の生成に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            PbxMain.Image = bmp
            UpdateFormData()
        End If
    End Sub
End Class
