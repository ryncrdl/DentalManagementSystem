<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(History))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        label1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        PanelTable = New Guna.UI2.WinForms.Guna2GradientPanel()
        BtnIneligible = New Guna.UI2.WinForms.Guna2GradientButton()
        BtnScheduled = New Guna.UI2.WinForms.Guna2GradientButton()
        BtnPending = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        ' 
        ' label1
        ' 
        label1.BackColor = Color.Transparent
        resources.ApplyResources(label1, "label1")
        label1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        label1.Name = "label1"
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
        resources.ApplyResources(Guna2TextBox1, "Guna2TextBox1")
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.IconRight = My.Resources.Resources.icons8_search_100
        Guna2TextBox1.IconRightOffset = New Point(20, 0)
        Guna2TextBox1.IconRightSize = New Size(25, 25)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = "Search"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ' 
        ' PanelTable
        ' 
        PanelTable.BackColor = Color.Transparent
        PanelTable.BorderRadius = 10
        PanelTable.CustomizableEdges = CustomizableEdges3
        resources.ApplyResources(PanelTable, "PanelTable")
        PanelTable.Name = "PanelTable"
        PanelTable.ShadowDecoration.CustomizableEdges = CustomizableEdges4
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
        BtnIneligible.CustomizableEdges = CustomizableEdges5
        BtnIneligible.DisabledState.BorderColor = Color.DarkGray
        BtnIneligible.DisabledState.CustomBorderColor = Color.DarkGray
        BtnIneligible.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnIneligible.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnIneligible.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnIneligible.FillColor = Color.Empty
        BtnIneligible.FillColor2 = Color.Empty
        resources.ApplyResources(BtnIneligible, "BtnIneligible")
        BtnIneligible.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnIneligible.Name = "BtnIneligible"
        BtnIneligible.ShadowDecoration.CustomizableEdges = CustomizableEdges6
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
        BtnScheduled.CustomizableEdges = CustomizableEdges7
        BtnScheduled.DisabledState.BorderColor = Color.DarkGray
        BtnScheduled.DisabledState.CustomBorderColor = Color.DarkGray
        BtnScheduled.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnScheduled.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnScheduled.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnScheduled.FillColor = Color.Empty
        BtnScheduled.FillColor2 = Color.Empty
        resources.ApplyResources(BtnScheduled, "BtnScheduled")
        BtnScheduled.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnScheduled.Name = "BtnScheduled"
        BtnScheduled.ShadowDecoration.CustomizableEdges = CustomizableEdges8
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
        BtnPending.CustomizableEdges = CustomizableEdges9
        BtnPending.DisabledState.BorderColor = Color.DarkGray
        BtnPending.DisabledState.CustomBorderColor = Color.DarkGray
        BtnPending.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnPending.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnPending.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnPending.FillColor = Color.Empty
        BtnPending.FillColor2 = Color.Empty
        resources.ApplyResources(BtnPending, "BtnPending")
        BtnPending.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnPending.Name = "BtnPending"
        BtnPending.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Guna2GradientPanel1
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BackColor = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges11
        resources.ApplyResources(Guna2GradientPanel1, "Guna2GradientPanel1")
        Guna2GradientPanel1.FillColor = Color.DarkViolet
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        ' 
        ' History
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ControlBox = False
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(label1)
        Controls.Add(Guna2TextBox1)
        Controls.Add(PanelTable)
        Controls.Add(BtnIneligible)
        Controls.Add(BtnScheduled)
        Controls.Add(BtnPending)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "History"
        ShowIcon = False
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents label1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PanelTable As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents BtnIneligible As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnScheduled As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnPending As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
End Class
