
Public Class Form1

    Dim first_value As Double
    Dim second_value As Double = 0
    Dim Oper As String

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        'to make the less code the click event for all the numeric button is same
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

    Private Sub btn_point_Click(sender As Object, e As EventArgs) Handles btn_point.Click
        If txtbox_input.Text.Contains(".") Then
            txtbox_input.Text += ""
        Else
            txtbox_input.Text += "."
        End If
    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click, btn_multiply.Click, btn_minus.Click, btn_divide.Click

        'to make the less code the operator buttons click event is same
        Dim btn_operator As Object = sender

        If txtbox_input.Text = "" Then
            lbl_output.Text = "Input in valid way"
        Else
            first_value = CDbl(txtbox_input.Text)
            txtbox_input.Clear()
            Oper = btn_operator.text
        End If

    End Sub


    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click


        If txtbox_input.Text = "" Then
            MessageBox.Show("Invalid")
        Else
            second_value = CDbl(txtbox_input.Text)
            If Oper = "+" Then
                txtbox_input.Text = airthematic_operation.add(first_value, second_value)
            ElseIf Oper = "-" Then
                txtbox_input.Text = airthematic_operation.subtract(first_value, second_value)
            ElseIf Oper = "*" Then
                txtbox_input.Text = airthematic_operation.multiply(first_value, second_value)
            ElseIf Oper = "/" Then
                txtbox_input.Text = airthematic_operation.divide(first_value, second_value)
            End If

        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txtbox_input.Clear()
    End Sub

    Private Sub btn_percentage_Click(sender As Object, e As EventArgs) Handles btn_percentage.Click
        txtbox_input.Text = (CDbl(txtbox_input.Text) / 100)
    End Sub

    Private Sub btn_plus_minus_Click(sender As Object, e As EventArgs) Handles btn_plus_minus.Click
        If txtbox_input.Text.Contains("-") Then
            Dim x As Boolean
            x = True
        Else
            Dim str2 As String
            str2 = txtbox_input.Text.Insert(0, "-")
            txtbox_input.Text = str2
        End If

    End Sub
End Class
