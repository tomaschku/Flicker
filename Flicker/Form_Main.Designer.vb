<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel_Flicker = New System.Windows.Forms.Panel()
        Me.Panel_Control = New System.Windows.Forms.Panel()
        Me.CB_Random = New System.Windows.Forms.CheckBox()
        Me.UD_FPS = New System.Windows.Forms.NumericUpDown()
        Me.Slider_FPS = New System.Windows.Forms.TrackBar()
        Me.Btn_Color2 = New System.Windows.Forms.Button()
        Me.Btn_Color1 = New System.Windows.Forms.Button()
        Me.Btn_ActivationSwitch = New System.Windows.Forms.Button()
        Me.Dialog_Color1 = New System.Windows.Forms.ColorDialog()
        Me.Timer_FPS = New System.Windows.Forms.Timer(Me.components)
        Me.Dialog_Color2 = New System.Windows.Forms.ColorDialog()
        Me.Panel_Control.SuspendLayout()
        CType(Me.UD_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slider_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Flicker
        '
        Me.Panel_Flicker.Location = New System.Drawing.Point(0, 46)
        Me.Panel_Flicker.Name = "Panel_Flicker"
        Me.Panel_Flicker.Size = New System.Drawing.Size(585, 374)
        Me.Panel_Flicker.TabIndex = 0
        '
        'Panel_Control
        '
        Me.Panel_Control.Controls.Add(Me.CB_Random)
        Me.Panel_Control.Controls.Add(Me.UD_FPS)
        Me.Panel_Control.Controls.Add(Me.Slider_FPS)
        Me.Panel_Control.Controls.Add(Me.Btn_Color2)
        Me.Panel_Control.Controls.Add(Me.Btn_Color1)
        Me.Panel_Control.Controls.Add(Me.Btn_ActivationSwitch)
        Me.Panel_Control.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Control.Name = "Panel_Control"
        Me.Panel_Control.Size = New System.Drawing.Size(585, 45)
        Me.Panel_Control.TabIndex = 0
        '
        'CB_Random
        '
        Me.CB_Random.Location = New System.Drawing.Point(511, 3)
        Me.CB_Random.Name = "CB_Random"
        Me.CB_Random.Size = New System.Drawing.Size(71, 39)
        Me.CB_Random.TabIndex = 5
        Me.CB_Random.Text = "Random Color"
        Me.CB_Random.UseVisualStyleBackColor = True
        '
        'UD_FPS
        '
        Me.UD_FPS.Location = New System.Drawing.Point(331, 13)
        Me.UD_FPS.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.UD_FPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UD_FPS.Name = "UD_FPS"
        Me.UD_FPS.Size = New System.Drawing.Size(55, 20)
        Me.UD_FPS.TabIndex = 4
        Me.UD_FPS.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Slider_FPS
        '
        Me.Slider_FPS.AutoSize = False
        Me.Slider_FPS.LargeChange = 10
        Me.Slider_FPS.Location = New System.Drawing.Point(65, 5)
        Me.Slider_FPS.Maximum = 1000
        Me.Slider_FPS.Minimum = 1
        Me.Slider_FPS.Name = "Slider_FPS"
        Me.Slider_FPS.Size = New System.Drawing.Size(260, 37)
        Me.Slider_FPS.TabIndex = 3
        Me.Slider_FPS.TickFrequency = 50
        Me.Slider_FPS.Value = 500
        '
        'Btn_Color2
        '
        Me.Btn_Color2.Location = New System.Drawing.Point(450, 3)
        Me.Btn_Color2.Name = "Btn_Color2"
        Me.Btn_Color2.Size = New System.Drawing.Size(55, 39)
        Me.Btn_Color2.TabIndex = 2
        Me.Btn_Color2.Text = "Second Color"
        Me.Btn_Color2.UseVisualStyleBackColor = True
        '
        'Btn_Color1
        '
        Me.Btn_Color1.Location = New System.Drawing.Point(392, 3)
        Me.Btn_Color1.Name = "Btn_Color1"
        Me.Btn_Color1.Size = New System.Drawing.Size(57, 39)
        Me.Btn_Color1.TabIndex = 1
        Me.Btn_Color1.Text = "First Color"
        Me.Btn_Color1.UseVisualStyleBackColor = True
        '
        'Btn_ActivationSwitch
        '
        Me.Btn_ActivationSwitch.Location = New System.Drawing.Point(3, 3)
        Me.Btn_ActivationSwitch.Name = "Btn_ActivationSwitch"
        Me.Btn_ActivationSwitch.Size = New System.Drawing.Size(56, 39)
        Me.Btn_ActivationSwitch.TabIndex = 0
        Me.Btn_ActivationSwitch.Text = "Start"
        Me.Btn_ActivationSwitch.UseVisualStyleBackColor = True
        '
        'Dialog_Color1
        '
        Me.Dialog_Color1.SolidColorOnly = True
        '
        'Timer_FPS
        '
        Me.Timer_FPS.Interval = 500
        '
        'Dialog_Color2
        '
        Me.Dialog_Color2.SolidColorOnly = True
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 420)
        Me.Controls.Add(Me.Panel_Control)
        Me.Controls.Add(Me.Panel_Flicker)
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flicker"
        Me.Panel_Control.ResumeLayout(False)
        CType(Me.UD_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slider_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Flicker As Panel
    Friend WithEvents Panel_Control As Panel
    Friend WithEvents Slider_FPS As TrackBar
    Friend WithEvents Btn_Color2 As Button
    Friend WithEvents Btn_Color1 As Button
    Friend WithEvents Btn_ActivationSwitch As Button
    Friend WithEvents Dialog_Color1 As ColorDialog
    Friend WithEvents Timer_FPS As Timer
    Friend WithEvents Dialog_Color2 As ColorDialog
    Friend WithEvents UD_FPS As NumericUpDown
    Friend WithEvents CB_Random As CheckBox
End Class
