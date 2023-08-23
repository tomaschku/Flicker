Public Class Main_Form
    Dim Running As Boolean = False
    Dim Color1 As Color = Color.White
    Dim Color2 As Color = Color.Black
    Dim FPS_Dividend As Integer = 500

    Private Sub Btn_ActivationSwitch_Click(sender As Object, e As EventArgs) Handles Btn_ActivationSwitch.Click
        FPS(FPS_State.Alternate)
    End Sub

    Private Sub Btn_Color1_Click(sender As Object, e As EventArgs) Handles Btn_Color1.Click
        Dialog_Color1.ShowDialog()
        Color1 = Dialog_Color1.Color
    End Sub
    Private Sub Btn_Color2_Click(sender As Object, e As EventArgs) Handles Btn_Color2.Click
        Dialog_Color2.ShowDialog()
        Color2 = Dialog_Color2.Color
    End Sub


    Enum FPS_State
        [On]
        Off
        Alternate
        Validate 'Sets values without changing "Running" Variable
    End Enum
    Public Sub FPS(state As FPS_State)
        Select Case state
            Case FPS_State.On
                Running = True
                Btn_ActivationSwitch.Text = "Stop"
                Timer_FPS.Enabled = True
            Case FPS_State.Off
                Running = False
                Btn_ActivationSwitch.Text = "Start"
                Timer_FPS.Enabled = False
            Case FPS_State.Alternate
                If (Running) Then
                    Running = False
                    Btn_ActivationSwitch.Text = "Start"
                    Timer_FPS.Enabled = False
                Else
                    Running = True
                    Btn_ActivationSwitch.Text = "Stop"
                    Timer_FPS.Enabled = True
                End If
            Case FPS_State.Validate
                If (Running) Then
                    Btn_ActivationSwitch.Text = "Start"
                    Timer_FPS.Enabled = False
                Else
                    Btn_ActivationSwitch.Text = "Stop"
                    Timer_FPS.Enabled = True
                End If
        End Select
    End Sub

    Private Sub Slider_FPS_Scroll(sender As Object, e As EventArgs) Handles Slider_FPS.Scroll
        FPS_Dividend = Slider_FPS.Value
        UD_FPS.Value = FPS_Dividend
        Timer_FPS.Interval = FPS_Dividend
    End Sub

    Private Sub UD_FPS_ValueChanged(sender As Object, e As EventArgs) Handles UD_FPS.ValueChanged
        FPS_Dividend = UD_FPS.Value
        Slider_FPS.Value = FPS_Dividend
        Timer_FPS.Interval = FPS_Dividend

    End Sub

    Private Sub Timer_FPS_Tick(sender As Object, e As EventArgs) Handles Timer_FPS.Tick
        If (CB_Random.Checked) Then
            Dim i As New Random
            Panel_Flicker.BackColor = Color.FromArgb(i.Next())
        Else
            Static CurrentColor = 1

            If (CurrentColor = 1) Then
                Panel_Flicker.BackColor = Color1
                CurrentColor = 2
            Else
                Panel_Flicker.BackColor = Color2
                CurrentColor = 1
            End If
        End If
    End Sub

    Private Sub Main_Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel_Flicker.Width = MyBase.Width
        Panel_Flicker.Height = MyBase.Height - 46
        Panel_Flicker.Location = New Point(0, 46)

        Panel_Control.Width = MyBase.Width
    End Sub
End Class