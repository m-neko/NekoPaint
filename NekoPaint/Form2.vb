Imports System.Text.RegularExpressions

Public Class FrmNewDoc
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If Regex.IsMatch(txtWidth.Text, "^[1-9][0-9]*$") And Regex.IsMatch(txtHeight.Text, "^[1-9][0-9]*$") Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("画像のサイズは数値のみで指定してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FrmNewDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHeight.Text = ""
        txtWidth.Text = ""
        Me.ActiveControl = Me.txtWidth
    End Sub
End Class