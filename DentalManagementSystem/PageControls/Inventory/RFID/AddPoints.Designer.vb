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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AddPoints))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        BtnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        rfidnumber = New Guna.UI2.WinForms.Guna2TextBox()
        ErrorMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        Timer1 = New Timer(components)
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        messok = New Guna.UI2.WinForms.Guna2MessageDialog()
        Guna2GradientPanel1.SuspendLayout()
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
        Guna2GradientPanel1.Controls.Add(BtnClose)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2GradientPanel1.Dock = DockStyle.Top
        Guna2GradientPanel1.FillColor = Color.DarkViolet
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientPanel1.Size = New Size(485, 30)
        Guna2GradientPanel1.TabIndex = 49
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnClose.BackColor = Color.Transparent
        BtnClose.CustomizableEdges = CustomizableEdges3
        BtnClose.FillColor = Color.Transparent
        BtnClose.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClose.IconColor = Color.Black
        BtnClose.Location = New Point(442, 0)
        BtnClose.Name = "BtnClose"
        BtnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        BtnClose.Size = New Size(40, 30)
        BtnClose.TabIndex = 3
        ' 
        ' rfidnumber
        ' 
        rfidnumber.CustomizableEdges = CustomizableEdges7
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
        rfidnumber.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        rfidnumber.Size = New Size(200, 36)
        rfidnumber.TabIndex = 51
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
        ' Timer1
        ' 
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(59, 41)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(360, 395)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 53
        Guna2PictureBox1.TabStop = False
        ' 
        ' messok
        ' 
        messok.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        messok.Caption = "Succes"
        messok.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        messok.Parent = Nothing
        messok.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        messok.Text = "Points Added Successfully!"
        ' 
        ' AddPoints
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(485, 448)
        ControlBox = False
        Controls.Add(Guna2PictureBox1)
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(rfidnumber)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddPoints"
        StartPosition = FormStartPosition.CenterScreen
        Guna2GradientPanel1.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents rfidnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ErrorMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents messok As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents BtnClose As Guna.UI2.WinForms.Guna2ControlBox
End Class
