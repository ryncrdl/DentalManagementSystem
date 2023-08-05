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
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        ErrorMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        QuestionMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        BtnEdit = New Guna.UI2.WinForms.Guna2Button()
        BtnDelete = New Guna.UI2.WinForms.Guna2Button()
        BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
        DoctorsTable = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Firstname = New DataGridViewTextBoxColumn()
        Lastname = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        SuccessfulMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(components)
        CType(DoctorsTable, ComponentModel.ISupportInitialize).BeginInit()
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
        BtnEdit.CustomizableEdges = CustomizableEdges17
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
        BtnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        BtnEdit.Size = New Size(30, 30)
        BtnEdit.TabIndex = 21
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.Transparent
        BtnDelete.Cursor = Cursors.Hand
        BtnDelete.CustomizableEdges = CustomizableEdges19
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
        BtnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        BtnDelete.Size = New Size(30, 30)
        BtnDelete.TabIndex = 20
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.Transparent
        BtnAdd.Cursor = Cursors.Hand
        BtnAdd.CustomizableEdges = CustomizableEdges21
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
        BtnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        BtnAdd.Size = New Size(30, 30)
        BtnAdd.TabIndex = 19
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 20
        Guna2Elipse2.TargetControl = DoctorsTable
        ' 
        ' DoctorsTable
        ' 
        DoctorsTable.AllowUserToAddRows = False
        DoctorsTable.AllowUserToDeleteRows = False
        DoctorsTable.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle11.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle11.SelectionForeColor = Color.White
        DoctorsTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        DoctorsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DoctorsTable.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = Color.White
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        DoctorsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        DoctorsTable.ColumnHeadersHeight = 44
        DoctorsTable.Columns.AddRange(New DataGridViewColumn() {ID, Firstname, Lastname, Contact, Email, Address})
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = Color.White
        DataGridViewCellStyle13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle13.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle13.SelectionForeColor = Color.White
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.False
        DoctorsTable.DefaultCellStyle = DataGridViewCellStyle13
        DoctorsTable.GridColor = Color.Silver
        DoctorsTable.ImeMode = ImeMode.NoControl
        DoctorsTable.Location = New Point(30, 173)
        DoctorsTable.Margin = New Padding(0)
        DoctorsTable.MultiSelect = False
        DoctorsTable.Name = "DoctorsTable"
        DoctorsTable.ReadOnly = True
        DoctorsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = Color.White
        DataGridViewCellStyle14.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle14.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = Color.White
        DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.False
        DoctorsTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        DoctorsTable.RowHeadersVisible = False
        DataGridViewCellStyle15.WrapMode = DataGridViewTriState.True
        DoctorsTable.RowsDefaultCellStyle = DataGridViewCellStyle15
        DoctorsTable.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DoctorsTable.RowTemplate.Height = 35
        DoctorsTable.Size = New Size(650, 386)
        DoctorsTable.TabIndex = 17
        DoctorsTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        DoctorsTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DoctorsTable.ThemeStyle.AlternatingRowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DoctorsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DoctorsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DoctorsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White
        DoctorsTable.ThemeStyle.BackColor = SystemColors.Control
        DoctorsTable.ThemeStyle.GridColor = Color.Silver
        DoctorsTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DoctorsTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        DoctorsTable.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DoctorsTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        DoctorsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DoctorsTable.ThemeStyle.HeaderStyle.Height = 44
        DoctorsTable.ThemeStyle.ReadOnly = True
        DoctorsTable.ThemeStyle.RowsStyle.BackColor = Color.White
        DoctorsTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DoctorsTable.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DoctorsTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DoctorsTable.ThemeStyle.RowsStyle.Height = 35
        DoctorsTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DoctorsTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.White
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
        ' Firstname
        ' 
        Firstname.FillWeight = 150F
        Firstname.HeaderText = "First Name"
        Firstname.Name = "Firstname"
        Firstname.ReadOnly = True
        Firstname.Width = 160
        ' 
        ' Lastname
        ' 
        Lastname.FillWeight = 150F
        Lastname.HeaderText = "Last Name"
        Lastname.Name = "Lastname"
        Lastname.ReadOnly = True
        Lastname.Width = 161
        ' 
        ' Contact
        ' 
        Contact.FillWeight = 150F
        Contact.HeaderText = "Contact"
        Contact.Name = "Contact"
        Contact.ReadOnly = True
        Contact.Width = 160
        ' 
        ' Email
        ' 
        Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Email.FillWeight = 150F
        Email.HeaderText = "Email"
        Email.Name = "Email"
        Email.ReadOnly = True
        Email.Width = 76
        ' 
        ' Address
        ' 
        Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Address.FillWeight = 200F
        Address.HeaderText = "Address"
        Address.Name = "Address"
        Address.ReadOnly = True
        Address.Width = 93
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2TextBox1.BorderRadius = 10
        Guna2TextBox1.CustomizableEdges = CustomizableEdges23
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
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges24
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
        Controls.Add(BtnEdit)
        Controls.Add(BtnDelete)
        Controls.Add(BtnAdd)
        Controls.Add(Guna2TextBox1)
        Controls.Add(DoctorsTable)
        Controls.Add(Guna2HtmlLabel1)
        Name = "ClientsControl"
        Size = New Size(714, 597)
        CType(DoctorsTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DoctorsTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ErrorMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents QuestionMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents SuccessfulMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
End Class
