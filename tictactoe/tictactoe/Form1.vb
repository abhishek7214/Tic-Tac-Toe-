Public Class Form1
    Dim user As Integer = 1
    Dim bt(8) As Char
    Dim i As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If user Mod 2 <> 0 Then
            Button1.BackgroundImage = Image.FromFile("O1.png")
            bt(0) = "O"
        Else
            Button1.BackgroundImage = Image.FromFile("X1.png")
            bt(0) = "X"
        End If
        Button1.Enabled = False
        user = user + 1
        wins()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.BackColor = Color.White
        If user Mod 2 <> 0 Then
            Button2.BackgroundImage = Image.FromFile("O1.png")
            bt(1) = "O"
        Else
            Button2.BackgroundImage = Image.FromFile("X1.png")
            bt(1) = "X"
        End If
        Button2.Enabled = False
        user = user + 1
        wins()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If user Mod 2 <> 0 Then
            bt(2) = "O"
            Button3.BackgroundImage = Image.FromFile("O1.png")
        Else
            Button3.BackgroundImage = Image.FromFile("X1.png")
            bt(2) = "X"
        End If
        Button3.Enabled = False
        user = user + 1
        wins()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If user Mod 2 <> 0 Then
            bt(3) = "O"
            Button4.BackgroundImage = Image.FromFile("O1.png")
        Else
            Button4.BackgroundImage = Image.FromFile("X1.png")
            bt(3) = "X"
        End If
        Button4.Enabled = False
        user = user + 1
        wins()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If user Mod 2 <> 0 Then
            bt(4) = "O"
            Button5.BackgroundImage = Image.FromFile("O1.png")
        Else
            Button5.BackgroundImage = Image.FromFile("X1.png")
            bt(4) = "X"
        End If
        Button5.Enabled = False
        user = user + 1
        wins()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If user Mod 2 <> 0 Then
            bt(5) = "O"
            Button6.BackgroundImage = Image.FromFile("O1.png")
        Else
            Button6.BackgroundImage = Image.FromFile("X1.png")
            bt(5) = "X"
        End If
        Button6.Enabled = False
        user = user + 1
        wins()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If user Mod 2 <> 0 Then
            bt(6) = "O"
            Button7.BackgroundImage = Image.FromFile("O1.png")
        Else
            Button7.BackgroundImage = Image.FromFile("X1.png")
            bt(6) = "X"
        End If
        Button7.Enabled = False
        user = user + 1
        wins()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If user Mod 2 <> 0 Then
            bt(7) = "O"
            Button8.BackgroundImage = Image.FromFile("O1.png")
        Else
            Button8.BackgroundImage = Image.FromFile("X1.png")
            bt(7) = "X"
        End If
        Button8.Enabled = False
        user = user + 1
        wins()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If user Mod 2 <> 0 Then
            bt(8) = "O"
            Button9.BackgroundImage = Image.FromFile("O1.png")
        Else
            Button9.BackgroundImage = Image.FromFile("X1.png")
            bt(8) = "X"
        End If
        Button9.Enabled = False
        user = user + 1
        wins()
    End Sub
    Public Sub wins()
        If (bt(0) = "O" And bt(1) = "O" And bt(2) = "O") Or (bt(3) = "O" And bt(4) = "O" And bt(5) = "O") Or (bt(6) = "O" And bt(7) = "O" And bt(8) = "O") Or (bt(0) = "O" And bt(3) = "O" And bt(6) = "O") Or (bt(1) = "O" And bt(4) = "O" And bt(7) = "O") Or (bt(2) = "O" And bt(5) = "O" And bt(8) = "O") Or (bt(0) = "O" And bt(4) = "O" And bt(8) = "O") Or (bt(2) = "O" And bt(4) = "O" And bt(6) = "O") Then
            Label2.Text = "O WIN"
            disable()
        ElseIf (bt(0) = "X" And bt(1) = "X" And bt(2) = "X") Or (bt(3) = "X" And bt(4) = "X" And bt(5) = "X") Or (bt(6) = "X" And bt(7) = "X" And bt(8) = "X") Or (bt(0) = "X" And bt(3) = "X" And bt(6) = "X") Or (bt(1) = "X" And bt(4) = "X" And bt(7) = "X") Or (bt(2) = "X" And bt(5) = "X" And bt(8) = "X") Or (bt(0) = "X" And bt(4) = "X" And bt(8) = "X") Or (bt(2) = "X" And bt(4) = "X" And bt(6) = "X") Then
            Label2.Text = "X WIN"
            disable()
        Else
            If user > 9 Then
                Label2.Text = "Match Tie"
            End If

        End If
    End Sub
    Public Sub disable()
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Button Then
                DirectCast(obj, Windows.Forms.Button).Enabled = False
            End If
        Next
        Button10.Enabled = True
    End Sub
    Public Sub reset()
        For Each obj As Object In Me.Controls
            If TypeOf obj Is Windows.Forms.Button Then
                DirectCast(obj, Windows.Forms.Button).Enabled = True
                DirectCast(obj, Windows.Forms.Button).BackgroundImage = Nothing
            End If
        Next
        user = 1
        For i As Integer = 0 To 8
            bt(i) = ""
        Next
        Label2.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Enabled = False
        Label2.Text = "Click Stat  "
        disable()
        Button10.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        reset()
    End Sub

End Class


