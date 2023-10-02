<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPoints
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AddPoints))
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        rfidnumber = New Guna.UI2.WinForms.Guna2TextBox()
        SuccessMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        ErrorMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges7
        Guna2GradientPanel1.Dock = DockStyle.Top
        Guna2GradientPanel1.FillColor = Color.DarkViolet
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2GradientPanel1.Size = New Size(485, 30)
        Guna2GradientPanel1.TabIndex = 49
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges9
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(97, 74)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2PictureBox1.Size = New Size(291, 287)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 50
        Guna2PictureBox1.TabStop = False
        ' 
        ' rfidnumber
        ' 
        rfidnumber.CustomizableEdges = CustomizableEdges11
        rfidnumber.DefaultText = ""
        rfidnumber.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        rfidnumber.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        rfidnumber.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        rfidnumber.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        rfidnumber.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        rfidnumber.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        rfidnumber.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        rfidnumber.Location = New Point(144, 345)
        rfidnumber.Name = "rfidnumber"
        rfidnumber.PasswordChar = ChrW(0)
        rfidnumber.PlaceholderText = ""
        rfidnumber.SelectedText = ""
        rfidnumber.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        rfidnumber.Size = New Size(200, 36)
        rfidnumber.TabIndex = 51
        ' 
        ' SuccessMessage
        ' 
        SuccessMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        SuccessMessage.Caption = Nothing
        SuccessMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        SuccessMessage.Parent = Me
        SuccessMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        SuccessMessage.Text = "Points Successfully added."
        ' 
        ' ErrorMessage
        ' 
        ErrorMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        ErrorMessage.Caption = "Failed"
        ErrorMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
        ErrorMessage.Parent = Me
        ErrorMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        ErrorMessage.Text = "Invalid RFID!"
        ' 
        ' AddPoints
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(485, 448)
        ControlBox = False
        Controls.Add(rfidnumber)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(Guna2GradientPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddPoints"
        StartPosition = FormStartPosition.CenterScreen
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents rfidnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents SuccessMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents ErrorMessage As Guna.UI2.WinForms.Guna2MessageDialog
End Class
