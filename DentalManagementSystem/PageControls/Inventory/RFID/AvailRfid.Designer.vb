<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailRfid
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
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        CustomMessageError = New Guna.UI2.WinForms.Guna2MessageDialog()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CreateMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        BtnCancel = New Guna.UI2.WinForms.Guna2GradientButton()
        BtnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        MessageSuccessfully = New Guna.UI2.WinForms.Guna2MessageDialog()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtContact = New Guna.UI2.WinForms.Guna2TextBox()
        BtnSearch = New Guna.UI2.WinForms.Guna2GradientButton()
        txtFullname = New Guna.UI2.WinForms.Guna2TextBox()
        txtrfidnumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtRfid = New Guna.UI2.WinForms.Guna2TextBox()
        txtname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        txterror = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2MessageDialog1 = New Guna.UI2.WinForms.Guna2MessageDialog()
        Timer1 = New Timer(components)
        BtnClear = New Guna.UI2.WinForms.Guna2GradientButton()
        avail = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2CustomGradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' CustomMessageError
        ' 
        CustomMessageError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        CustomMessageError.Caption = Nothing
        CustomMessageError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
        CustomMessageError.Parent = Me
        CustomMessageError.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        CustomMessageError.Text = "RFID NUMBER IS ALREADY TAKEN!"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2HtmlLabel1.Location = New Point(25, 107)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(158, 23)
        Guna2HtmlLabel1.TabIndex = 54
        Guna2HtmlLabel1.Text = "Enter Contact Number"
        ' 
        ' CreateMessageDialog
        ' 
        CreateMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        CreateMessageDialog.Caption = ""
        CreateMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        CreateMessageDialog.Parent = Me
        CreateMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        CreateMessageDialog.Text = "All fields are required."
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.AnimateWindow = True
        Guna2BorderlessForm1.AnimationInterval = 100
        Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockForm = False
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.ResizeForm = False
        Guna2BorderlessForm1.ShadowColor = Color.Silver
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Guna2GradientPanel1
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BackColor = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges17
        Guna2GradientPanel1.Dock = DockStyle.Top
        Guna2GradientPanel1.FillColor = Color.DarkViolet
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2GradientPanel1.Size = New Size(433, 30)
        Guna2GradientPanel1.TabIndex = 48
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BorderColor = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnCancel.BorderRadius = 10
        BtnCancel.BorderThickness = 1
        BtnCancel.CustomizableEdges = CustomizableEdges11
        BtnCancel.DisabledState.BorderColor = Color.DarkGray
        BtnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        BtnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnCancel.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnCancel.FillColor = Color.Empty
        BtnCancel.FillColor2 = Color.Empty
        BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnCancel.HoverState.FillColor = Color.DarkViolet
        BtnCancel.HoverState.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnCancel.HoverState.ForeColor = Color.White
        BtnCancel.Location = New Point(222, 404)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        BtnCancel.Size = New Size(190, 50)
        BtnCancel.TabIndex = 53
        BtnCancel.Text = "Cancel"
        ' 
        ' BtnSave
        ' 
        BtnSave.BorderRadius = 10
        BtnSave.CustomizableEdges = CustomizableEdges15
        BtnSave.DisabledState.BorderColor = Color.DarkGray
        BtnSave.DisabledState.CustomBorderColor = Color.DarkGray
        BtnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnSave.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnSave.FillColor = Color.DarkViolet
        BtnSave.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(26, 404)
        BtnSave.Name = "BtnSave"
        BtnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        BtnSave.Size = New Size(190, 50)
        BtnSave.TabIndex = 49
        BtnSave.Text = "Save"
        ' 
        ' MessageSuccessfully
        ' 
        MessageSuccessfully.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        MessageSuccessfully.Caption = Nothing
        MessageSuccessfully.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        MessageSuccessfully.Parent = Me
        MessageSuccessfully.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        MessageSuccessfully.Text = "Registered Successfully"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.White
        Guna2HtmlLabel4.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel4.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2HtmlLabel4.Location = New Point(66, 36)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(305, 47)
        Guna2HtmlLabel4.TabIndex = 58
        Guna2HtmlLabel4.Text = "REGISTER YOUR RFID"
        ' 
        ' txtContact
        ' 
        txtContact.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        txtContact.BorderRadius = 10
        txtContact.CustomizableEdges = CustomizableEdges7
        txtContact.DefaultText = ""
        txtContact.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtContact.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtContact.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtContact.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtContact.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtContact.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtContact.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtContact.IconRight = My.Resources.Resources.icons8_search_100
        txtContact.IconRightOffset = New Point(20, 0)
        txtContact.IconRightSize = New Size(25, 25)
        txtContact.Location = New Point(22, 137)
        txtContact.Margin = New Padding(4, 4, 4, 4)
        txtContact.Name = "txtContact"
        txtContact.PasswordChar = ChrW(0)
        txtContact.PlaceholderText = "Search"
        txtContact.SelectedText = ""
        txtContact.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtContact.Size = New Size(390, 49)
        txtContact.TabIndex = 63
        ' 
        ' BtnSearch
        ' 
        BtnSearch.BorderRadius = 10
        BtnSearch.CustomizableEdges = CustomizableEdges3
        BtnSearch.DisabledState.BorderColor = Color.DarkGray
        BtnSearch.DisabledState.CustomBorderColor = Color.DarkGray
        BtnSearch.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnSearch.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnSearch.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnSearch.FillColor = Color.IndianRed
        BtnSearch.FillColor2 = Color.RosyBrown
        BtnSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSearch.ForeColor = Color.White
        BtnSearch.Location = New Point(100, 3)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        BtnSearch.Size = New Size(188, 41)
        BtnSearch.TabIndex = 65
        BtnSearch.Text = "Search"
        ' 
        ' txtFullname
        ' 
        txtFullname.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        txtFullname.BorderRadius = 10
        txtFullname.CustomizableEdges = CustomizableEdges13
        txtFullname.DefaultText = ""
        txtFullname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtFullname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtFullname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFullname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFullname.Enabled = False
        txtFullname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtFullname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtFullname.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtFullname.IconRightOffset = New Point(20, 0)
        txtFullname.IconRightSize = New Size(25, 25)
        txtFullname.Location = New Point(22, 223)
        txtFullname.Margin = New Padding(4, 4, 4, 4)
        txtFullname.Name = "txtFullname"
        txtFullname.PasswordChar = ChrW(0)
        txtFullname.PlaceholderText = "FULL NAME"
        txtFullname.SelectedText = ""
        txtFullname.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        txtFullname.Size = New Size(390, 49)
        txtFullname.TabIndex = 50
        txtFullname.Visible = False
        ' 
        ' txtrfidnumber
        ' 
        txtrfidnumber.BackColor = Color.Transparent
        txtrfidnumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtrfidnumber.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        txtrfidnumber.Location = New Point(22, 279)
        txtrfidnumber.Name = "txtrfidnumber"
        txtrfidnumber.Size = New Size(104, 23)
        txtrfidnumber.TabIndex = 55
        txtrfidnumber.Text = " RFID NUMBER"
        txtrfidnumber.Visible = False
        ' 
        ' txtRfid
        ' 
        txtRfid.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        txtRfid.BorderRadius = 10
        txtRfid.CustomizableEdges = CustomizableEdges9
        txtRfid.DefaultText = ""
        txtRfid.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtRfid.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtRfid.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRfid.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRfid.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRfid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtRfid.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtRfid.IconRightOffset = New Point(20, 0)
        txtRfid.IconRightSize = New Size(25, 25)
        txtRfid.Location = New Point(22, 309)
        txtRfid.Margin = New Padding(4, 4, 4, 4)
        txtRfid.Name = "txtRfid"
        txtRfid.PasswordChar = ChrW(0)
        txtRfid.PlaceholderText = "Type or Scan"
        txtRfid.SelectedText = ""
        txtRfid.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtRfid.Size = New Size(390, 49)
        txtRfid.TabIndex = 61
        txtRfid.Visible = False
        ' 
        ' txtname
        ' 
        txtname.BackColor = Color.Transparent
        txtname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtname.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        txtname.Location = New Point(25, 193)
        txtname.Name = "txtname"
        txtname.Size = New Size(74, 23)
        txtname.TabIndex = 62
        txtname.Text = "Full Name"
        txtname.Visible = False
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.Controls.Add(txterror)
        Guna2CustomGradientPanel1.Controls.Add(BtnSearch)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2CustomGradientPanel1.Location = New Point(22, 193)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2CustomGradientPanel1.Size = New Size(390, 184)
        Guna2CustomGradientPanel1.TabIndex = 66
        ' 
        ' txterror
        ' 
        txterror.BackColor = Color.White
        txterror.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txterror.ForeColor = Color.Red
        txterror.Location = New Point(29, 105)
        txterror.Name = "txterror"
        txterror.Size = New Size(27, 23)
        txterror.TabIndex = 67
        txterror.Text = "ads"
        txterror.Visible = False
        ' 
        ' Guna2MessageDialog1
        ' 
        Guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Guna2MessageDialog1.Caption = Nothing
        Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Guna2MessageDialog1.Parent = Nothing
        Guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default
        Guna2MessageDialog1.Text = Nothing
        ' 
        ' BtnClear
        ' 
        BtnClear.BorderRadius = 10
        BtnClear.CustomizableEdges = CustomizableEdges1
        BtnClear.DisabledState.BorderColor = Color.DarkGray
        BtnClear.DisabledState.CustomBorderColor = Color.DarkGray
        BtnClear.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnClear.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnClear.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnClear.FillColor = Color.DarkViolet
        BtnClear.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        BtnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClear.ForeColor = Color.White
        BtnClear.Location = New Point(26, 404)
        BtnClear.Name = "BtnClear"
        BtnClear.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        BtnClear.Size = New Size(190, 50)
        BtnClear.TabIndex = 67
        BtnClear.Text = "Clear"
        BtnClear.Visible = False
        ' 
        ' avail
        ' 
        avail.AutoSize = True
        avail.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        avail.CheckedState.BorderRadius = 0
        avail.CheckedState.BorderThickness = 0
        avail.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        avail.Location = New Point(22, 358)
        avail.Name = "avail"
        avail.Size = New Size(79, 19)
        avail.TabIndex = 68
        avail.Text = "Avail New"
        avail.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        avail.UncheckedState.BorderRadius = 0
        avail.UncheckedState.BorderThickness = 0
        avail.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        avail.Visible = False
        ' 
        ' AvailRfid
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(433, 483)
        ControlBox = False
        Controls.Add(BtnClear)
        Controls.Add(Guna2CustomGradientPanel1)
        Controls.Add(txtContact)
        Controls.Add(txtname)
        Controls.Add(txtRfid)
        Controls.Add(Guna2HtmlLabel4)
        Controls.Add(txtrfidnumber)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(BtnCancel)
        Controls.Add(txtFullname)
        Controls.Add(BtnSave)
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(avail)
        FormBorderStyle = FormBorderStyle.None
        Name = "AvailRfid"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RFID REGISTED SUCCESFULLY"
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2CustomGradientPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CustomMessageError As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CreateMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BtnCancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents MessageSuccessfully As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtRfid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtrfidnumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtFullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnSearch As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txterror As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2MessageDialog1 As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnClear As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents avail As Guna.UI2.WinForms.Guna2CheckBox
End Class
