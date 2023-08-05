<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        label1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        BtnPending = New Guna.UI2.WinForms.Guna2GradientButton()
        BtnScheduled = New Guna.UI2.WinForms.Guna2GradientButton()
        BtnIneligible = New Guna.UI2.WinForms.Guna2GradientButton()
        panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        Guna2Elipse1.TargetControl = Me
        ' 
        ' label1
        ' 
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        label1.Location = New Point(39, 41)
        label1.Name = "label1"
        label1.Size = New Size(85, 32)
        label1.TabIndex = 2
        label1.Text = "Pending"
        ' 
        ' BtnPending
        ' 
        BtnPending.BorderRadius = 10
        BtnPending.CustomizableEdges = CustomizableEdges9
        BtnPending.DisabledState.BorderColor = Color.DarkGray
        BtnPending.DisabledState.CustomBorderColor = Color.DarkGray
        BtnPending.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnPending.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnPending.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnPending.FillColor = Color.DarkViolet
        BtnPending.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnPending.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPending.ForeColor = Color.White
        BtnPending.Location = New Point(383, 45)
        BtnPending.Name = "BtnPending"
        BtnPending.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        BtnPending.Size = New Size(103, 28)
        BtnPending.TabIndex = 10
        BtnPending.Text = "Pending"
        ' 
        ' BtnScheduled
        ' 
        BtnScheduled.BorderRadius = 10
        BtnScheduled.CustomizableEdges = CustomizableEdges7
        BtnScheduled.DisabledState.BorderColor = Color.DarkGray
        BtnScheduled.DisabledState.CustomBorderColor = Color.DarkGray
        BtnScheduled.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnScheduled.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnScheduled.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnScheduled.FillColor = Color.DarkViolet
        BtnScheduled.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnScheduled.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnScheduled.ForeColor = Color.White
        BtnScheduled.Location = New Point(478, 45)
        BtnScheduled.Name = "BtnScheduled"
        BtnScheduled.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        BtnScheduled.Size = New Size(112, 28)
        BtnScheduled.TabIndex = 11
        BtnScheduled.Text = "Scheduled"
        ' 
        ' BtnIneligible
        ' 
        BtnIneligible.BorderRadius = 10
        BtnIneligible.CustomizableEdges = CustomizableEdges5
        BtnIneligible.DisabledState.BorderColor = Color.DarkGray
        BtnIneligible.DisabledState.CustomBorderColor = Color.DarkGray
        BtnIneligible.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnIneligible.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnIneligible.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnIneligible.FillColor = Color.DarkViolet
        BtnIneligible.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnIneligible.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIneligible.ForeColor = Color.White
        BtnIneligible.Location = New Point(577, 45)
        BtnIneligible.Name = "BtnIneligible"
        BtnIneligible.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        BtnIneligible.Size = New Size(112, 28)
        BtnIneligible.TabIndex = 12
        BtnIneligible.Text = "ineligible"
        ' 
        ' panel1
        ' 
        panel1.CustomizableEdges = CustomizableEdges3
        panel1.Location = New Point(39, 136)
        panel1.Name = "panel1"
        panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        panel1.Size = New Size(650, 465)
        panel1.TabIndex = 13
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2TextBox1.BorderRadius = 10
        Guna2TextBox1.CustomizableEdges = CustomizableEdges1
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.IconRight = My.Resources.Resources.icons8_search_100
        Guna2TextBox1.IconRightOffset = New Point(20, 0)
        Guna2TextBox1.IconRightSize = New Size(25, 25)
        Guna2TextBox1.Location = New Point(39, 80)
        Guna2TextBox1.Margin = New Padding(4, 4, 4, 4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = "Search"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(650, 49)
        Guna2TextBox1.TabIndex = 3
        ' 
        ' ScheduleControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(label1)
        Controls.Add(Guna2TextBox1)
        Controls.Add(panel1)
        Controls.Add(BtnIneligible)
        Controls.Add(BtnScheduled)
        Controls.Add(BtnPending)
        Name = "ScheduleControl"
        Size = New Size(945, 640)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents label1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnPending As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnIneligible As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnScheduled As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
