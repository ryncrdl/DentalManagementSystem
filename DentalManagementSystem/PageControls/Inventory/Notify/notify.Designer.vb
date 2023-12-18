<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notify
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        PendingTable = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        ClientsId = New DataGridViewTextBoxColumn()
        Fullname = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        Dates = New DataGridViewTextBoxColumn()
        Service = New DataGridViewTextBoxColumn()
        Doctor = New DataGridViewTextBoxColumn()
        Payment = New DataGridViewImageColumn()
        DocCon = New DataGridViewTextBoxColumn()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(components)
        BtnIneligible = New Guna.UI2.WinForms.Guna2GradientButton()
        BtnNotify = New Guna.UI2.WinForms.Guna2GradientButton()
        ErrorMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        messok = New Guna.UI2.WinForms.Guna2MessageDialog()
        er = New Guna.UI2.WinForms.Guna2MessageDialog()
        CType(PendingTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        ' 
        ' PendingTable
        ' 
        PendingTable.AllowUserToAddRows = False
        PendingTable.AllowUserToDeleteRows = False
        PendingTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        PendingTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        PendingTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        PendingTable.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        PendingTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        PendingTable.ColumnHeadersHeight = 44
        PendingTable.Columns.AddRange(New DataGridViewColumn() {ID, ClientsId, Fullname, Contact, Dates, Service, Doctor, Payment, DocCon})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        PendingTable.DefaultCellStyle = DataGridViewCellStyle3
        PendingTable.GridColor = Color.Silver
        PendingTable.ImeMode = ImeMode.NoControl
        PendingTable.Location = New Point(9, 50)
        PendingTable.Margin = New Padding(0)
        PendingTable.MultiSelect = False
        PendingTable.Name = "PendingTable"
        PendingTable.ReadOnly = True
        PendingTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        PendingTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        PendingTable.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        PendingTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        PendingTable.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        PendingTable.RowTemplate.Height = 35
        PendingTable.Size = New Size(650, 386)
        PendingTable.TabIndex = 5
        PendingTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        PendingTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        PendingTable.ThemeStyle.AlternatingRowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PendingTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        PendingTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        PendingTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White
        PendingTable.ThemeStyle.BackColor = SystemColors.Control
        PendingTable.ThemeStyle.GridColor = Color.Silver
        PendingTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        PendingTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        PendingTable.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PendingTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        PendingTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        PendingTable.ThemeStyle.HeaderStyle.Height = 44
        PendingTable.ThemeStyle.ReadOnly = True
        PendingTable.ThemeStyle.RowsStyle.BackColor = Color.White
        PendingTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        PendingTable.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PendingTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        PendingTable.ThemeStyle.RowsStyle.Height = 35
        PendingTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        PendingTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.White
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ID.Width = 50
        ' 
        ' ClientsId
        ' 
        ClientsId.HeaderText = "Client ID"
        ClientsId.Name = "ClientsId"
        ClientsId.ReadOnly = True
        ClientsId.Visible = False
        ClientsId.Width = 99
        ' 
        ' Fullname
        ' 
        Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Fullname.FillWeight = 150F
        Fullname.HeaderText = "Full Name"
        Fullname.Name = "Fullname"
        Fullname.ReadOnly = True
        Fullname.Width = 111
        ' 
        ' Contact
        ' 
        Contact.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Contact.FillWeight = 150F
        Contact.HeaderText = "Contact"
        Contact.Name = "Contact"
        Contact.ReadOnly = True
        Contact.Width = 92
        ' 
        ' Dates
        ' 
        Dates.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Dates.FillWeight = 150F
        Dates.HeaderText = "Date"
        Dates.Name = "Dates"
        Dates.ReadOnly = True
        Dates.Width = 69
        ' 
        ' Service
        ' 
        Service.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Service.FillWeight = 150F
        Service.HeaderText = "Service"
        Service.Name = "Service"
        Service.ReadOnly = True
        Service.Width = 89
        ' 
        ' Doctor
        ' 
        Doctor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Doctor.FillWeight = 200F
        Doctor.HeaderText = "Doctor"
        Doctor.Name = "Doctor"
        Doctor.ReadOnly = True
        Doctor.Width = 85
        ' 
        ' Payment
        ' 
        Payment.HeaderText = "Payment"
        Payment.Name = "Payment"
        Payment.ReadOnly = True
        Payment.Resizable = DataGridViewTriState.True
        Payment.SortMode = DataGridViewColumnSortMode.Automatic
        Payment.Width = 101
        ' 
        ' DocCon
        ' 
        DocCon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DocCon.HeaderText = "DocCon"
        DocCon.Name = "DocCon"
        DocCon.ReadOnly = True
        DocCon.Visible = False
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
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.Dock = DockStyle.Top
        Guna2GradientPanel1.FillColor = Color.DarkViolet
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(94), CByte(105), CByte(255))
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.Size = New Size(674, 30)
        Guna2GradientPanel1.TabIndex = 80
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.BorderRadius = 20
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 20
        ' 
        ' Guna2Elipse3
        ' 
        Guna2Elipse3.BorderRadius = 20
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
        BtnIneligible.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIneligible.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnIneligible.Location = New Point(525, 452)
        BtnIneligible.Name = "BtnIneligible"
        BtnIneligible.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        BtnIneligible.Size = New Size(137, 46)
        BtnIneligible.TabIndex = 81
        BtnIneligible.Text = "Close"
        ' 
        ' BtnNotify
        ' 
        BtnNotify.Animated = True
        BtnNotify.BackColor = Color.Transparent
        BtnNotify.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnNotify.BorderRadius = 10
        BtnNotify.BorderThickness = 1
        BtnNotify.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        BtnNotify.CheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnNotify.CheckedState.FillColor2 = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnNotify.CheckedState.ForeColor = Color.White
        BtnNotify.CustomizableEdges = CustomizableEdges3
        BtnNotify.DisabledState.BorderColor = Color.DarkGray
        BtnNotify.DisabledState.CustomBorderColor = Color.DarkGray
        BtnNotify.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnNotify.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnNotify.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnNotify.FillColor = Color.Empty
        BtnNotify.FillColor2 = Color.Empty
        BtnNotify.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNotify.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        BtnNotify.Location = New Point(12, 452)
        BtnNotify.Name = "BtnNotify"
        BtnNotify.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        BtnNotify.Size = New Size(137, 46)
        BtnNotify.TabIndex = 82
        BtnNotify.Text = "Notify"
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
        ' messok
        ' 
        messok.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        messok.Caption = "Notify"
        messok.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        messok.Parent = Nothing
        messok.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        messok.Text = "Sent Successfully"
        ' 
        ' er
        ' 
        er.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        er.Caption = "Notify"
        er.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        er.Parent = Nothing
        er.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        er.Text = "Error Sending Message"
        ' 
        ' notify
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(674, 527)
        ControlBox = False
        Controls.Add(BtnNotify)
        Controls.Add(BtnIneligible)
        Controls.Add(PendingTable)
        Controls.Add(Guna2GradientPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "notify"
        StartPosition = FormStartPosition.CenterScreen
        CType(PendingTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents PendingTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ClientsId As DataGridViewTextBoxColumn
    Friend WithEvents Fullname As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Dates As DataGridViewTextBoxColumn
    Friend WithEvents Service As DataGridViewTextBoxColumn
    Friend WithEvents Doctor As DataGridViewTextBoxColumn
    Friend WithEvents Payment As DataGridViewImageColumn
    Friend WithEvents DocCon As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnIneligible As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnNotify As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ErrorMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents messok As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents er As Guna.UI2.WinForms.Guna2MessageDialog
End Class
