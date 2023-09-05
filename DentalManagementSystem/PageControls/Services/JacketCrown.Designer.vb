<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JacketCrown
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(JacketCrown))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Label1 = New Label()
        Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.Image = My.Resources.Resources.jacketCrown_98c2694eb8fabc78f681
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(176, 12)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(209, 187)
        Guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox1.TabIndex = 6
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.ForeColor = Color.Blue
        Guna2HtmlLabel1.Location = New Point(176, 205)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(239, 49)
        Guna2HtmlLabel1.TabIndex = 7
        Guna2HtmlLabel1.Text = "Jacket Crowns"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(-2, 257)
        Label1.Name = "Label1"
        Label1.Size = New Size(571, 175)
        Label1.TabIndex = 12
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Guna2CircleButton1
        ' 
        Guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton1.FillColor = Color.Red
        Guna2CircleButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2CircleButton1.ForeColor = Color.White
        Guna2CircleButton1.Location = New Point(268, 440)
        Guna2CircleButton1.Name = "Guna2CircleButton1"
        Guna2CircleButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton1.Size = New Size(27, 29)
        Guna2CircleButton1.TabIndex = 13
        Guna2CircleButton1.Text = "Guna2CircleButton1"
        ' 
        ' JacketCrown
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bgsplashscreen
        ClientSize = New Size(560, 473)
        ControlBox = False
        Controls.Add(Guna2CircleButton1)
        Controls.Add(Label1)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2CirclePictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "JacketCrown"
        StartPosition = FormStartPosition.CenterScreen
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
End Class
