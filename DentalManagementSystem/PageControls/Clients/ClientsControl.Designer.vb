<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        ErrorMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        QuestionMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        BtnEdit = New Guna.UI2.WinForms.Guna2Button()
        BtnDelete = New Guna.UI2.WinForms.Guna2Button()
        BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
        ClientsTable = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Fullname = New DataGridViewTextBoxColumn()
        Username = New DataGridViewTextBoxColumn()
        Password = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        SuccessfulMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(components)
        CType(ClientsTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        Guna2Elipse1.TargetControl = Me
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
        ' QuestionMessage
        ' 
        QuestionMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo
        QuestionMessage.Caption = Nothing
        QuestionMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question
        QuestionMessage.Parent = Nothing
        QuestionMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        QuestionMessage.Text = ""
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.Transparent
        BtnEdit.Cursor = Cursors.Hand
        BtnEdit.CustomizableEdges = CustomizableEdges1
        BtnEdit.DisabledState.BorderColor = Color.DarkGray
        BtnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        BtnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnEdit.FillColor = Color.Transparent
        BtnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnEdit.ForeColor = Color.White
        BtnEdit.Image = My.Resources.Resources.edit
        BtnEdit.ImageSize = New Size(30, 30)
        BtnEdit.Location = New Point(552, 36)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        BtnEdit.Size = New Size(30, 30)
        BtnEdit.TabIndex = 21
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.Transparent
        BtnDelete.Cursor = Cursors.Hand
        BtnDelete.CustomizableEdges = CustomizableEdges3
        BtnDelete.DisabledState.BorderColor = Color.DarkGray
        BtnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        BtnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnDelete.FillColor = Color.Transparent
        BtnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnDelete.ForeColor = Color.White
        BtnDelete.Image = My.Resources.Resources.delete
        BtnDelete.ImageSize = New Size(30, 30)
        BtnDelete.Location = New Point(601, 36)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        BtnDelete.Size = New Size(30, 30)
        BtnDelete.TabIndex = 20
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.Transparent
        BtnAdd.Cursor = Cursors.Hand
        BtnAdd.CustomizableEdges = CustomizableEdges5
        BtnAdd.DisabledState.BorderColor = Color.DarkGray
        BtnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        BtnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        BtnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        BtnAdd.FillColor = Color.Transparent
        BtnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAdd.ForeColor = Color.White
        BtnAdd.Image = My.Resources.Resources.add1
        BtnAdd.ImageSize = New Size(30, 30)
        BtnAdd.Location = New Point(650, 36)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        BtnAdd.Size = New Size(30, 30)
        BtnAdd.TabIndex = 19
        BtnAdd.Visible = False
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 20
        Guna2Elipse2.TargetControl = ClientsTable
        ' 
        ' ClientsTable
        ' 
        ClientsTable.AllowUserToAddRows = False
        ClientsTable.AllowUserToDeleteRows = False
        ClientsTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        ClientsTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        ClientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        ClientsTable.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        ClientsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        ClientsTable.ColumnHeadersHeight = 44
        ClientsTable.Columns.AddRange(New DataGridViewColumn() {ID, Fullname, Username, Password, Contact})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        ClientsTable.DefaultCellStyle = DataGridViewCellStyle3
        ClientsTable.GridColor = Color.Silver
        ClientsTable.ImeMode = ImeMode.NoControl
        ClientsTable.Location = New Point(30, 165)
        ClientsTable.Margin = New Padding(0)
        ClientsTable.MultiSelect = False
        ClientsTable.Name = "ClientsTable"
        ClientsTable.ReadOnly = True
        ClientsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        ClientsTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        ClientsTable.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        ClientsTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        ClientsTable.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ClientsTable.RowTemplate.Height = 35
        ClientsTable.ScrollBars = ScrollBars.None
        ClientsTable.Size = New Size(650, 386)
        ClientsTable.TabIndex = 22
        ClientsTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        ClientsTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        ClientsTable.ThemeStyle.AlternatingRowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ClientsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ClientsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ClientsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White
        ClientsTable.ThemeStyle.BackColor = SystemColors.Control
        ClientsTable.ThemeStyle.GridColor = Color.Silver
        ClientsTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        ClientsTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        ClientsTable.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ClientsTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        ClientsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        ClientsTable.ThemeStyle.HeaderStyle.Height = 44
        ClientsTable.ThemeStyle.ReadOnly = True
        ClientsTable.ThemeStyle.RowsStyle.BackColor = Color.White
        ClientsTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        ClientsTable.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ClientsTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ClientsTable.ThemeStyle.RowsStyle.Height = 35
        ClientsTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ClientsTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.White
        ' 
        ' ID
        ' 
        ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ID.Width = 50
        ' 
        ' Fullname
        ' 
        Fullname.FillWeight = 150F
        Fullname.HeaderText = "Full Name"
        Fullname.Name = "Fullname"
        Fullname.ReadOnly = True
        Fullname.Width = 220
        ' 
        ' Username
        ' 
        Username.FillWeight = 150F
        Username.HeaderText = "Username"
        Username.Name = "Username"
        Username.ReadOnly = True
        Username.Width = 161
        ' 
        ' Password
        ' 
        Password.FillWeight = 150F
        Password.HeaderText = "Password"
        Password.Name = "Password"
        Password.ReadOnly = True
        Password.Width = 160
        ' 
        ' Contact
        ' 
        Contact.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Contact.FillWeight = 150F
        Contact.HeaderText = "Contact"
        Contact.Name = "Contact"
        Contact.ReadOnly = True
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2TextBox1.BorderRadius = 10
        Guna2TextBox1.CustomizableEdges = CustomizableEdges7
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.IconRight = My.Resources.Resources.icons8_search_100
        Guna2TextBox1.IconRightOffset = New Point(20, 0)
        Guna2TextBox1.IconRightSize = New Size(25, 25)
        Guna2TextBox1.Location = New Point(31, 101)
        Guna2TextBox1.Margin = New Padding(4, 4, 4, 4)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = "Search"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2TextBox1.Size = New Size(650, 49)
        Guna2TextBox1.TabIndex = 18
        ' 
        ' SuccessfulMessage
        ' 
        SuccessfulMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        SuccessfulMessage.Caption = Nothing
        SuccessfulMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        SuccessfulMessage.Parent = Nothing
        SuccessfulMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
        SuccessfulMessage.Text = Nothing
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2HtmlLabel1.Location = New Point(30, 32)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(90, 39)
        Guna2HtmlLabel1.TabIndex = 16
        Guna2HtmlLabel1.Text = "Clients"
        ' 
        ' Guna2Elipse3
        ' 
        Guna2Elipse3.BorderRadius = 20
        ' 
        ' ClientsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(ClientsTable)
        Controls.Add(BtnEdit)
        Controls.Add(BtnDelete)
        Controls.Add(BtnAdd)
        Controls.Add(Guna2TextBox1)
        Controls.Add(Guna2HtmlLabel1)
        Name = "ClientsControl"
        Size = New Size(714, 597)
        CType(ClientsTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ErrorMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents QuestionMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents SuccessfulMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ClientsTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Fullname As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
End Class
