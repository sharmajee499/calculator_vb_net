Public Class Form1
    Dim first_value As Double
    Dim second_value As Double
    Dim Oper As String

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        Dim btn As Button = sender
        txtbox_input.Text += btn.Text
    End Sub

    Private Sub btn_back_space_Click(sender As Object, e As EventArgs) Handles btn_back_space.Click
        Dim str As String = txtbox_input.Text
        If txtbox_input.Text <> "" Then
            txtbox_input.Text = str.Remove(str.Length - 1, 1)
        Else
            txtbox_input.Text = ""
        End If


    End Sub
End Class
