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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ScheduleControl))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        label1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        BtnPending = New Guna.UI2.WinForms.Guna2GradientButton()
        BtnScheduled = New Guna.UI2.WinForms.Guna2GradientButton()
        BtnIneligible = New Guna.UI2.WinForms.Guna2GradientButton()
        PanelTable = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        PanelCompleted = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
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
        label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        label1.Location = New Point(29, 45)
        label1.Name = "label1"
        label1.Size = New Size(109, 39)
        label1.TabIndex = 2
        label1.Text = "Pending"
        ' 
        ' BtnPending
        ' 
        BtnPending.Animated = True
        BtnPending.BackColor = Color.Transparent
        BtnPending.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnPending.BorderRadius = 10
        BtnPending.BorderThickness = 1
        BtnPending.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        BtnPending.Checked = True
        BtnPending.CheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnPending.CheckedState.FillColor2 = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnPending.CheckedState.ForeColor = Color.White
        BtnPending.CustomizableEdges = CustomizableEdges11
        BtnPending.DisabledState.BorderColor = Color.DarkGray
        BtnPending.DisabledState.CustomBorderColor = Color.DarkGray
        BtnPending.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnPending.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnPending.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnPending.FillColor = Color.Empty
        BtnPending.FillColor2 = Color.Empty
        BtnPending.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPending.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnPending.Location = New Point(256, 45)
        BtnPending.Name = "BtnPending"
        BtnPending.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        BtnPending.Size = New Size(137, 46)
        BtnPending.TabIndex = 10
        BtnPending.Text = "Pending"
        ' 
        ' BtnScheduled
        ' 
        BtnScheduled.Animated = True
        BtnScheduled.BackColor = Color.Transparent
        BtnScheduled.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnScheduled.BorderRadius = 10
        BtnScheduled.BorderThickness = 1
        BtnScheduled.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        BtnScheduled.CheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnScheduled.CheckedState.FillColor2 = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnScheduled.CheckedState.ForeColor = Color.White
        BtnScheduled.CustomizableEdges = CustomizableEdges9
        BtnScheduled.DisabledState.BorderColor = Color.DarkGray
        BtnScheduled.DisabledState.CustomBorderColor = Color.DarkGray
        BtnScheduled.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnScheduled.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnScheduled.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnScheduled.FillColor = Color.Empty
        BtnScheduled.FillColor2 = Color.Empty
        BtnScheduled.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnScheduled.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnScheduled.Location = New Point(399, 45)
        BtnScheduled.Name = "BtnScheduled"
        BtnScheduled.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        BtnScheduled.Size = New Size(137, 46)
        BtnScheduled.TabIndex = 11
        BtnScheduled.Text = "Scheduled"
        ' 
        ' BtnIneligible
        ' 
        BtnIneligible.Animated = True
        BtnIneligible.BackColor = Color.Transparent
        BtnIneligible.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnIneligible.BorderRadius = 10
        BtnIneligible.BorderThickness = 1
        BtnIneligible.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        BtnIneligible.CheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnIneligible.CheckedState.FillColor2 = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnIneligible.CheckedState.ForeColor = Color.White
        BtnIneligible.CustomizableEdges = CustomizableEdges7
        BtnIneligible.DisabledState.BorderColor = Color.DarkGray
        BtnIneligible.DisabledState.CustomBorderColor = Color.DarkGray
        BtnIneligible.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnIneligible.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnIneligible.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnIneligible.FillColor = Color.Empty
        BtnIneligible.FillColor2 = Color.Empty
        BtnIneligible.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIneligible.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnIneligible.Location = New Point(542, 45)
        BtnIneligible.Name = "BtnIneligible"
        BtnIneligible.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        BtnIneligible.Size = New Size(137, 46)
        BtnIneligible.TabIndex = 12
        BtnIneligible.Text = "ineligible"
        ' 
        ' PanelTable
        ' 
        PanelTable.BackColor = Color.Transparent
        PanelTable.BorderRadius = 10
        PanelTable.CustomizableEdges = CustomizableEdges5
        PanelTable.Location = New Point(29, 164)
        PanelTable.Name = "PanelTable"
        PanelTable.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        PanelTable.Size = New Size(650, 386)
        PanelTable.TabIndex = 13
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2TextBox1.BorderRadius = 10
        Guna2TextBox1.CustomizableEdges = CustomizableEdges3
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
        Guna2TextBox1.Location = New Point(29, 105)
        Guna2TextBox1.Margin = New Padding(4, 4, 4, 4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = "Search"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TextBox1.Size = New Size(650, 49)
        Guna2TextBox1.TabIndex = 3
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.Cursor = Cursors.Hand
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), Image)
        Guna2Button1.ImageSize = New Size(30, 30)
        Guna2Button1.Location = New Point(205, 36)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(51, 62)
        Guna2Button1.TabIndex = 50
        ' 
        ' PanelCompleted
        ' 
        PanelCompleted.CustomizableEdges = CustomizableEdges13
        PanelCompleted.Dock = DockStyle.Fill
        PanelCompleted.Location = New Point(0, 0)
        PanelCompleted.Name = "PanelCompleted"
        PanelCompleted.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        PanelCompleted.Size = New Size(714, 597)
        PanelCompleted.TabIndex = 51
        ' 
        ' ScheduleControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Guna2Button1)
        Controls.Add(label1)
        Controls.Add(Guna2TextBox1)
        Controls.Add(PanelTable)
        Controls.Add(BtnIneligible)
        Controls.Add(BtnScheduled)
        Controls.Add(BtnPending)
        Controls.Add(PanelCompleted)
        Name = "ScheduleControl"
        Size = New Size(714, 597)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents label1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnPending As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnIneligible As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnScheduled As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PanelTable As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelCompleted As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class
