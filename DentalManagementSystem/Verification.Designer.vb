<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verification
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        txtCode = New Guna.UI2.WinForms.Guna2TextBox()
        BtnVerify = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        BtnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        ErrorMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        SuccessMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        SuspendLayout()
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BackColor = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.Dock = DockStyle.Top
        Guna2GradientPanel1.FillColor = Color.DarkViolet
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.Size = New Size(330, 30)
        Guna2GradientPanel1.TabIndex = 4
        ' 
        ' txtCode
        ' 
        txtCode.Animated = True
        txtCode.BorderRadius = 10
        txtCode.Cursor = Cursors.IBeam
        txtCode.CustomizableEdges = CustomizableEdges3
        txtCode.DefaultText = ""
        txtCode.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtCode.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtCode.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCode.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCode.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtCode.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCode.IconLeftOffset = New Point(10, 0)
        txtCode.IconLeftSize = New Size(25, 25)
        txtCode.Location = New Point(34, 177)
        txtCode.Margin = New Padding(4, 4, 4, 4)
        txtCode.MaxLength = 6
        txtCode.Name = "txtCode"
        txtCode.PasswordChar = ChrW(0)
        txtCode.PlaceholderText = "Enter security code"
        txtCode.SelectedText = ""
        txtCode.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtCode.Size = New Size(257, 50)
        txtCode.TabIndex = 5
        txtCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnVerify
        ' 
        BtnVerify.BorderRadius = 10
        BtnVerify.CustomizableEdges = CustomizableEdges5
        BtnVerify.DisabledState.BorderColor = Color.DarkGray
        BtnVerify.DisabledState.CustomBorderColor = Color.DarkGray
        BtnVerify.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnVerify.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnVerify.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnVerify.FillColor = Color.DarkViolet
        BtnVerify.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnVerify.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnVerify.ForeColor = Color.White
        BtnVerify.Location = New Point(34, 240)
        BtnVerify.Name = "BtnVerify"
        BtnVerify.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        BtnVerify.Size = New Size(257, 50)
        BtnVerify.TabIndex = 10
        BtnVerify.Text = "Verify"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2HtmlLabel1.Location = New Point(52, 57)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(220, 27)
        Guna2HtmlLabel1.TabIndex = 11
        Guna2HtmlLabel1.Text = "Get your securiy code to" & vbCrLf & vbCrLf
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2HtmlLabel2.Location = New Point(67, 133)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(191, 27)
        Guna2HtmlLabel2.TabIndex = 12
        Guna2HtmlLabel2.Text = " registration as admin"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel3.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2HtmlLabel3.Location = New Point(42, 95)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(243, 27)
        Guna2HtmlLabel3.TabIndex = 13
        Guna2HtmlLabel3.Text = "Super admin" & vbCrLf & "  to verify your"
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 15
        Guna2Elipse1.TargetControl = Me
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Animated = True
        BtnCancel.BackColor = Color.Transparent
        BtnCancel.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnCancel.BorderRadius = 10
        BtnCancel.BorderThickness = 1
        BtnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        BtnCancel.CheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnCancel.CheckedState.FillColor2 = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnCancel.CheckedState.ForeColor = Color.White
        BtnCancel.CustomizableEdges = CustomizableEdges7
        BtnCancel.DisabledState.BorderColor = Color.DarkGray
        BtnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        BtnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnCancel.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnCancel.FillColor = Color.Empty
        BtnCancel.FillColor2 = Color.Empty
        BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnCancel.Location = New Point(34, 298)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        BtnCancel.Size = New Size(257, 46)
        BtnCancel.TabIndex = 14
        BtnCancel.Text = "Cancel"
        ' 
        ' ErrorMessage
        ' 
        ErrorMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        ErrorMessage.Caption = Nothing
        ErrorMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
        ErrorMessage.Parent = Nothing
        ErrorMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        ErrorMessage.Text = Nothing
        ' 
        ' SuccessMessage
        ' 
        SuccessMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        SuccessMessage.Caption = Nothing
        SuccessMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        SuccessMessage.Parent = Nothing
        SuccessMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        SuccessMessage.Text = Nothing
        ' 
        ' Verification
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(330, 376)
        Controls.Add(BtnCancel)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(BtnVerify)
        Controls.Add(txtCode)
        Controls.Add(Guna2GradientPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Verification"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Verification"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnVerify As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ErrorMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents SuccessMessage As Guna.UI2.WinForms.Guna2MessageDialog
End Class
