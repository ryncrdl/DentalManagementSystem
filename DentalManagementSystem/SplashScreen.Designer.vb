<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2TaskBarProgress1 = New Guna.UI2.WinForms.Guna2TaskBarProgress(components)
        Guna2ProgressIndicator1 = New Guna.UI2.WinForms.Guna2ProgressIndicator()
        Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(184, 79)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(123, 39)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Welcome"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.Location = New Point(228, 144)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(36, 39)
        Guna2HtmlLabel2.TabIndex = 1
        Guna2HtmlLabel2.Text = "To"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel3.Location = New Point(71, 216)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(366, 39)
        Guna2HtmlLabel3.TabIndex = 2
        Guna2HtmlLabel3.Text = "Dental Management System"
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.AnimationInterval = 100
        Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockForm = False
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.DragForm = False
        Guna2BorderlessForm1.DragOrientation = Guna.UI2.WinForms.Enums.DragOrientation.Horizontal
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2TaskBarProgress1
        ' 
        Guna2TaskBarProgress1.TargetForm = Me
        ' 
        ' Guna2ProgressIndicator1
        ' 
        Guna2ProgressIndicator1.Location = New Point(375, 70)
        Guna2ProgressIndicator1.Name = "Guna2ProgressIndicator1"
        Guna2ProgressIndicator1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ProgressIndicator1.Size = New Size(90, 90)
        Guna2ProgressIndicator1.TabIndex = 3
        ' 
        ' Guna2ProgressBar1
        ' 
        Guna2ProgressBar1.CustomizableEdges = CustomizableEdges2
        Guna2ProgressBar1.Dock = DockStyle.Bottom
        Guna2ProgressBar1.Location = New Point(0, 409)
        Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Guna2ProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Guna2ProgressBar1.Size = New Size(554, 18)
        Guna2ProgressBar1.TabIndex = 4
        Guna2ProgressBar1.Text = "Guna2ProgressBar1"
        Guna2ProgressBar1.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        ' 
        ' Guna2WinProgressIndicator1
        ' 
        Guna2WinProgressIndicator1.Location = New Point(54, 60)
        Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Guna2WinProgressIndicator1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2WinProgressIndicator1.Size = New Size(90, 90)
        Guna2WinProgressIndicator1.TabIndex = 5
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(554, 427)
        Controls.Add(Guna2WinProgressIndicator1)
        Controls.Add(Guna2ProgressBar1)
        Controls.Add(Guna2ProgressIndicator1)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SplashScreen"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2TaskBarProgress1 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2ProgressIndicator1 As Guna.UI2.WinForms.Guna2ProgressIndicator
End Class
