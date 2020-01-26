Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginform.Show()
        loginform.MdiParent = Me
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("GPA Calculator for both Degree and HND Students." & vbCrLf & "Created By: Shadrack Inusah." & vbCrLf & "Mob: 0541006400 / 0271218557" & vbCrLf & "E-mail: satelliton22@gmail.com" & vbCrLf & "Department of Science and Technology, Dominion University College", "About..", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub StudentPortalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentPortalToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://makslinesolutions.com/ducstud/login.php")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If ExitToolStripMenuItem.Enabled = True AndAlso MessageBox.Show("Are You Sure You Want To Close GPA Calculator ?", "Exit GPA Calculator ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Application.Exit()

            Dim resposta As Integer
            If resposta = vbNo Then
                Me.Show()
            End If
        End If
    End Sub


    Private Sub DUCHomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUCHomeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://duc.edu.gh")
    End Sub

    Private Sub DegreeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DegreeToolStripMenuItem.Click
        Form1.Show()
        Form1.MdiParent = Me
    End Sub

    Private Sub HNDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HNDToolStripMenuItem.Click
        Form3.Show()
        Form3.MdiParent = Me
    End Sub

    'Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '   PrintDialog1.AllowSomePages = True
    '  PrintDialog1.ShowHelp = True
    ' PrintDialog1.Document = PrintDocument1
    'Dim result As DialogResult = PrintDialog1.ShowDialog()
    '   If (result = DialogResult.OK) Then
    '      PrintDocument1.Print()
    ' End If
    'End Sub
End Class