Public Class Form4
    Dim bt As Button() = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "X"
        Button1.BackgroundImage = Image.FromFile("X1.png")
        Button1.Enabled = False
        bt(0).Text = "X"
        wins()
        C_Input()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackgroundImage = Image.FromFile("X1.png")
        bt(1).Text = "X"
        Button2.Enabled = False
        wins()
        C_Input()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.BackgroundImage = Image.FromFile("X1.png")
        bt(2).Text = "X"
        Button3.Enabled = False
        wins()
        C_Input()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.BackgroundImage = Image.FromFile("X1.png")
        bt(3).Text = "X"
        Button4.Enabled = False
        wins()
        C_Input()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.BackgroundImage = Image.FromFile("X1.png")
        bt(4).Text = "X"
        Button5.Enabled = False
        wins()
        C_Input()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.BackgroundImage = Image.FromFile("X1.png")
        bt(5).Text = "X"
        Button6.Enabled = False
        wins()
        C_Input()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.BackgroundImage = Image.FromFile("X1.png")
        bt(6).Text = "X"
        Button7.Enabled = False
        wins()
        C_Input()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.BackgroundImage = Image.FromFile("X1.png")
        bt(7).Text = "X"
        Button8.Enabled = False
        wins()
        C_Input()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.BackgroundImage = Image.FromFile("X1.png")
        bt(8).Text = "X"
        Button9.Enabled = False
        wins()
        C_Input()
    End Sub
    Public Sub wins()
        If (bt(0).Text = "O" And bt(1).Text = "O" And bt(2).Text = "O") Or (bt(3).Text = "O" And bt(4).Text = "O" And bt(5).Text = "O") Or (bt(6).Text = "O" And bt(7).Text = "O" And bt(8).Text = "O") Or (bt(0).Text = "O" And bt(3).Text = "O" And bt(6).Text = "O") Or (bt(1).Text = "O" And bt(4).Text = "O" And bt(7).Text = "O") Or (bt(2).Text = "O" And bt(5).Text = "O" And bt(8).Text = "O") Or (bt(0).Text = "O" And bt(4).Text = "O" And bt(8).Text = "O") Or (bt(2).Text = "O" And bt(4).Text = "O" And bt(6).Text = "O") Then
            Label2.Text = "O WIN"
            disable()
        ElseIf (bt(0).Text = "X" And bt(1).Text = "X" And bt(2).Text = "X") Or (bt(3).Text = "X" And bt(4).Text = "X" And bt(5).Text = "X") Or (bt(6).Text = "X" And bt(7).Text = "X" And bt(8).Text = "X") Or (bt(0).Text = "X" And bt(3).Text = "X" And bt(6).Text = "X") Or (bt(1).Text = "X" And bt(4).Text = "X" And bt(7).Text = "X") Or (bt(2).Text = "X" And bt(5).Text = "X" And bt(8).Text = "X") Or (bt(0).Text = "X" And bt(4).Text = "X" And bt(8).Text = "X") Or (bt(2).Text = "X" And bt(4).Text = "X" And bt(6).Text = "X") Then
            Label2.Text = "X WIN"
            disable()
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
                DirectCast(obj, Windows.Forms.Button).Text = ""
            End If
        Next
        Label2.Text = ""
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Enabled = False
        Label1.Text = "Click Start  "
        disable()
        Button10.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        reset()
    End Sub
    Public Function C_Input()
        Dim possInput As List(Of Button) = New List(Of Button)
        For j As Integer = 0 To bt.Length - 1
            If (bt(j).Text <> "O" And bt(j).Text <> "X") Then
                possInput.Add(bt(j))
            End If
        Next
        Dim ran As Integer
        ran = New Random().Next(0, possInput.Count - 1)
        MsgBox(ran)
        Dim btn As Button = New Button
        btn = possInput(ran)
        btn.BackgroundImage = Image.FromFile("O1.png")
        bt(ran).Text = "O"
        btn.Enabled = False
        wins()
        Return (False)
    End Function

End Class



