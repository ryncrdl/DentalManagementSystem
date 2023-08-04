<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
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
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.AnimationInterval = 200
        Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.DragForm = False
        Guna2BorderlessForm1.ShadowColor = Color.Silver
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.Image = My.Resources.Resources.logo
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(55, 22)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(205, 161)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(125, 137, 149)
        Guna2HtmlLabel1.Location = New Point(87, 189)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(118, 39)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = "Loading..."
        ' 
        ' LoadingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(322, 264)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoadingForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoadingForm"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
