Public Class Form1
    Dim cboVal As Integer
    Dim cboVal1 As Integer
    Dim cboVal2 As Integer
    Dim cboVal3 As Integer
    Dim cboVal4 As Integer
    Dim cboVal5 As Integer
    Dim cboVal6 As Integer
    Dim cboVal7 As Integer
    Dim ComboBox11 As Integer
    Dim ComboBox22 As Integer
    Dim ComboBox33 As Integer
    Dim ComboBox44 As Integer
    Dim cbo1Val As Double
    Dim cbo2Val As Double
    Dim cbo3Val As Double
    Dim cbo4Val As Double
    Dim cbo5Val As Double
    Dim cbo6Val As Double
    Dim cbo7Val As Double
    Dim cbo8Val As Double
    Dim ComboBox3v As Double
    Dim ComboBox4v As Double

    Private Sub lbl6_Click(sender As Object, e As EventArgs) Handles lbl6.Click
        lbl6.Text = "Welcome " & loginform.TextBox1.Text
    End Sub



    'Credit hours calculations
    Private Sub cbo9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo9.SelectedIndexChanged
        Select Case cbo9.Text
            Case "1"
                cboVal = 1
            Case "2"
                cboVal = 2
            Case "3"
                cboVal = 3
            Case "4"
                cboVal = 4
            Case "5"
                cboVal = 5
            Case Else
                cboVal = 0
        End Select
    End Sub

    Private Sub cbo10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo10.SelectedIndexChanged
        Select Case cbo10.Text
            Case "1"
                cboVal1 = 1
            Case "2"
                cboVal1 = 2
            Case "3"
                cboVal1 = 3
            Case "4"
                cboVal1 = 4
            Case "5"
                cboVal1 = 5
            Case Else
                cboVal1 = 0
        End Select
    End Sub

    Private Sub cbo11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo11.SelectedIndexChanged
        Select Case cbo11.SelectedItem
            Case "1"
                cboVal2 = 1
            Case "2"
                cboVal2 = 2
            Case "3"
                cboVal2 = 3
            Case "4"
                cboVal2 = 4
            Case "5"
                cboVal2 = 5
            Case Else
                cboVal2 = 0
        End Select
    End Sub

    Private Sub cbo12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo12.SelectedIndexChanged
        Select Case cbo12.SelectedItem
            Case "1"
                cboVal3 = 1
            Case "2"
                cboVal3 = 2
            Case "3"
                cboVal3 = 3
            Case "4"
                cboVal3 = 4
            Case "5"
                cboVal3 = 5
            Case Else
                cboVal3 = 0
        End Select
    End Sub

    Private Sub cbo13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo13.SelectedIndexChanged
        Select Case cbo13.SelectedItem
            Case "1"
                cboVal4 = 1
            Case "2"
                cboVal4 = 2
            Case "3"
                cboVal4 = 3
            Case "4"
                cboVal4 = 4
            Case "5"
                cboVal4 = 5
            Case Else
                cboVal4 = 0
        End Select
    End Sub

    Private Sub cbo14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo14.SelectedIndexChanged
        Select Case cbo14.SelectedItem
            Case "1"
                cboVal5 = 1
            Case "2"
                cboVal5 = 2
            Case "3"
                cboVal5 = 3
            Case "4"
                cboVal5 = 4
            Case "5"
                cboVal5 = 5
            Case Else
                cboVal5 = 0
        End Select
    End Sub

    Private Sub cbo15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo15.SelectedIndexChanged
        Select Case cbo15.SelectedItem
            Case "1"
                cboVal6 = 1
            Case "2"
                cboVal6 = 2
            Case "3"
                cboVal6 = 3
            Case "4"
                cboVal6 = 4
            Case "5"
                cboVal6 = 5
            Case Else
                cboVal6 = 0
        End Select
    End Sub

    Private Sub cbo16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo16.SelectedIndexChanged, ComboBox4.SelectedIndexChanged, ComboBox2.SelectedIndexChanged
        Select Case cbo16.SelectedItem
            Case "1"
                cboVal7 = 1
            Case "2"
                cboVal7 = 2
            Case "3"
                cboVal7 = 3
            Case "4"
                cboVal7 = 4
            Case "5"
                cboVal7 = 5
            Case Else
                cboVal7 = 0
        End Select
    End Sub

    Private Sub btnCredit_Click(sender As Object, e As EventArgs) Handles btnCredit.Click
        'Credithrs = 
        txtChrs.Text = cboVal + cboVal1 + cboVal2 + cboVal3 + cboVal4 + cboVal5 + cboVal6 + cboVal7 + ComboBox11 + ComboBox22
    End Sub




    'Grade Calculations
    Private Sub cbo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo1.SelectedIndexChanged
        Select Case cbo1.SelectedItem
            Case "A"
                cbo1Val = 4.0
            Case "B+"
                cbo1Val = 3.5
            Case "B"
                cbo1Val = 3.0
            Case "C+"
                cbo1Val = 2.5
            Case "C"
                cbo1Val = 2.0
            Case "D+"
                cbo1Val = 1.5
            Case "D"
                cbo1Val = 1.0
            Case "E"
                cbo1Val = 0.0
        End Select
    End Sub

    Private Sub cbo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo2.SelectedIndexChanged
        Select Case cbo2.SelectedItem
            Case "A"
                cbo2Val = 4.0
            Case "B+"
                cbo2Val = 3.5
            Case "B"
                cbo2Val = 3.0
            Case "C+"
                cbo2Val = 2.5
            Case "C"
                cbo2Val = 2.0
            Case "D+"
                cbo2Val = 1.5
            Case "D"
                cbo2Val = 1.0
            Case "E"
                cbo2Val = 0.0
        End Select
    End Sub

    Private Sub cbo3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo3.SelectedIndexChanged
        Select Case cbo3.SelectedItem
            Case "A"
                cbo3Val = 4.0
            Case "B+"
                cbo3Val = 3.5
            Case "B"
                cbo3Val = 3.0
            Case "C+"
                cbo3Val = 2.5
            Case "C"
                cbo3Val = 2.0
            Case "D+"
                cbo3Val = 1.5
            Case "D"
                cbo3Val = 1.0
            Case "E"
                cbo3Val = 0.0
        End Select
    End Sub

    Private Sub cbo4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo4.SelectedIndexChanged
        Select Case cbo4.SelectedItem
            Case "A"
                cbo4Val = 4.0
            Case "B+"
                cbo4Val = 3.5
            Case "B"
                cbo4Val = 3.0
            Case "C+"
                cbo4Val = 2.5
            Case "C"
                cbo4Val = 2.0
            Case "D+"
                cbo4Val = 1.5
            Case "D"
                cbo4Val = 1.0
            Case "E"
                cbo4Val = 0.0
        End Select
    End Sub

    Private Sub cbo5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo5.SelectedIndexChanged
        Select Case cbo5.SelectedItem
            Case "A"
                cbo5Val = 4.0
            Case "B+"
                cbo5Val = 3.5
            Case "B"
                cbo5Val = 3.0
            Case "C+"
                cbo5Val = 2.5
            Case "C"
                cbo5Val = 2.0
            Case "D+"
                cbo5Val = 1.5
            Case "D"
                cbo5Val = 1.0
            Case "E"
                cbo5Val = 0.0
        End Select
    End Sub

    Private Sub cbo6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo6.SelectedIndexChanged
        Select Case cbo6.SelectedItem
            Case "A"
                cbo6Val = 4.0
            Case "B+"
                cbo6Val = 3.5
            Case "B"
                cbo6Val = 3.0
            Case "C+"
                cbo6Val = 2.5
            Case "C"
                cbo6Val = 2.0
            Case "D+"
                cbo6Val = 1.5
            Case "D"
                cbo6Val = 1.0
            Case "E"
                cbo6Val = 0.0
        End Select
    End Sub

    Private Sub cbo7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo7.SelectedIndexChanged
        Select Case cbo7.SelectedItem
            Case "A"
                cbo7Val = 4.0
            Case "B+"
                cbo7Val = 3.5
            Case "B"
                cbo7Val = 3.0
            Case "C+"
                cbo7Val = 2.5
            Case "C"
                cbo7Val = 2.0
            Case "D+"
                cbo7Val = 1.5
            Case "D"
                cbo7Val = 1.0
            Case "E"
                cbo7Val = 0.0
        End Select
    End Sub

    Private Sub cbo8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo8.SelectedIndexChanged, ComboBox3.SelectedIndexChanged, ComboBox1.SelectedIndexChanged
        Select Case cbo8.SelectedItem
            Case "A"
                cbo8Val = 4.0
            Case "B+"
                cbo8Val = 3.5
            Case "B"
                cbo8Val = 3.0
            Case "C+"
                cbo8Val = 2.5
            Case "C"
                cbo8Val = 2.0
            Case "D+"
                cbo8Val = 1.5
            Case "D"
                cbo8Val = 1.0
            Case "E"
                cbo8Val = 0.0
        End Select
    End Sub


    Private Sub btnEarned_Click(sender As Object, e As EventArgs) Handles btnEarned.Click
        txtCearned.Text = (cboVal * cbo1Val) + (cboVal1 * cbo2Val) + (cboVal2 * cbo3Val) + (cboVal3 * cbo4Val) + (cboVal4 * cbo5Val) + (cboVal5 * cbo6Val) + (cboVal6 * cbo7Val) + (cboVal7 * cbo8Val) + (ComboBox11 * ComboBox3v) + (ComboBox22 * ComboBox4v)
    End Sub

    Private Sub btnGPA_Click(sender As Object, e As EventArgs) Handles btnGPA.Click
        txtGPA.Text = (CDbl(Val(txtCearned.Text)) / CDbl(Val(txtChrs.Text)))
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox3.ForeColor = Color.Black Then
            TextBox3.ForeColor = Color.Green
        ElseIf TextBox3.ForeColor = Color.Green Then
            TextBox3.ForeColor = Color.Red
        ElseIf TextBox3.ForeColor = Color.Red Then
            TextBox3.ForeColor = Color.Yellow
        ElseIf TextBox3.ForeColor = Color.Yellow Then
            TextBox3.ForeColor = Color.Black
        ElseIf TextBox3.ForeColor = Color.Black Then
            TextBox3.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "1"
                ComboBox11 = 1
            Case "2"
                ComboBox11 = 2
            Case "3"
                ComboBox11 = 3
            Case "4"
                ComboBox11 = 4
            Case "5"
                ComboBox11 = 5
            Case Else
                ComboBox11 = 0
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "1"
                ComboBox22 = 1
            Case "2"
                ComboBox22 = 2
            Case "3"
                ComboBox22 = 3
            Case "4"
                ComboBox22 = 4
            Case "5"
                ComboBox22 = 5
            Case Else
                ComboBox22 = 0
        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.Text
            Case "A+"
                ComboBox3v = 5.0
            Case "A"
                ComboBox3v = 4.0
            Case "B+"
                ComboBox3v = 3.5
            Case "B"
                ComboBox3v = 3.0
            Case "C+"
                ComboBox3v = 2.5
            Case "C"
                ComboBox3v = 2.0
            Case "D+"
                ComboBox3v = 1.5
            Case "D"
                ComboBox3v = 1.0
            Case "F"
                ComboBox3v = 0.0
            Case "E"
                ComboBox3v = 0.0
            Case "Absent"
                ComboBox3v = 0.0
        End Select
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Select Case ComboBox4.Text
            Case "A+"
                ComboBox4v = 5.0
            Case "A"
                ComboBox4v = 4.0
            Case "B+"
                ComboBox4v = 3.5
            Case "B"
                ComboBox4v = 3.0
            Case "C+"
                ComboBox4v = 2.5
            Case "C"
                ComboBox4v = 2.0
            Case "D+"
                ComboBox4v = 1.5
            Case "D"
                ComboBox4v = 1.0
            Case "F"
                ComboBox4v = 0.0
            Case "E"
                ComboBox4v = 0.0
            Case "Absent"
                ComboBox4v = 0.0
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
