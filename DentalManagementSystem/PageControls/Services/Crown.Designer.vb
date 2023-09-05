<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crown
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
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Crown))
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Label1 = New Label()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.Image = My.Resources.Resources.crown_and_fixed_bridge_557706d723e51bc344a5
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(184, 12)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(206, 193)
        Guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox1.TabIndex = 7
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.ForeColor = Color.Blue
        Guna2HtmlLabel1.Location = New Point(184, 211)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(366, 49)
        Guna2HtmlLabel1.TabIndex = 8
        Guna2HtmlLabel1.Text = "Crown & Fixed Bridge"
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
        Guna2CircleButton1.Location = New Point(267, 442)
        Guna2CircleButton1.Name = "Guna2CircleButton1"
        Guna2CircleButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton1.Size = New Size(27, 29)
        Guna2CircleButton1.TabIndex = 10
        Guna2CircleButton1.Text = "Guna2CircleButton1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(0, 299)
        Label1.Name = "Label1"
        Label1.Size = New Size(559, 125)
        Label1.TabIndex = 13
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Crown
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bgsplashscreen
        ClientSize = New Size(560, 473)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(Guna2CircleButton1)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2CirclePictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Crown"
        StartPosition = FormStartPosition.CenterScreen
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label1 As Label
End Class
