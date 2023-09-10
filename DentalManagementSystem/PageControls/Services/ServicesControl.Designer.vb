<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicesControl
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        ErrorMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        QuestionMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        BtnEdit = New Guna.UI2.WinForms.Guna2Button()
        BtnDelete = New Guna.UI2.WinForms.Guna2Button()
        BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        SuccessfulMessage = New Guna.UI2.WinForms.Guna2MessageDialog()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(components)
        ServicesTable = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Image = New DataGridViewTextBoxColumn()
        Title = New DataGridViewTextBoxColumn()
        Description = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Payment = New DataGridViewTextBoxColumn()
        CType(ServicesTable, ComponentModel.ISupportInitialize).BeginInit()
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
        BtnEdit.Location = New Point(553, 39)
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
        BtnDelete.Location = New Point(602, 39)
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
        BtnAdd.Location = New Point(651, 39)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        BtnAdd.Size = New Size(30, 30)
        BtnAdd.TabIndex = 19
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 20
        Guna2Elipse2.TargetControl = ServicesTable
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
        Guna2TextBox1.Location = New Point(32, 104)
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
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2HtmlLabel2.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2HtmlLabel2.Location = New Point(31, 35)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(107, 39)
        Guna2HtmlLabel2.TabIndex = 16
        Guna2HtmlLabel2.Text = "Services"
        ' 
        ' Guna2Elipse3
        ' 
        Guna2Elipse3.BorderRadius = 20
        ' 
        ' ServicesTable
        ' 
        ServicesTable.AllowUserToAddRows = False
        ServicesTable.AllowUserToDeleteRows = False
        ServicesTable.AllowUserToOrderColumns = True
        ServicesTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        ServicesTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        ServicesTable.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        ServicesTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        ServicesTable.ColumnHeadersHeight = 44
        ServicesTable.Columns.AddRange(New DataGridViewColumn() {ID, Image, Title, Description, Price, Payment})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        ServicesTable.DefaultCellStyle = DataGridViewCellStyle3
        ServicesTable.GridColor = Color.Silver
        ServicesTable.ImeMode = ImeMode.NoControl
        ServicesTable.Location = New Point(32, 171)
        ServicesTable.Margin = New Padding(0)
        ServicesTable.MultiSelect = False
        ServicesTable.Name = "ServicesTable"
        ServicesTable.ReadOnly = True
        ServicesTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        ServicesTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        ServicesTable.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        ServicesTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        ServicesTable.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ServicesTable.RowTemplate.Height = 35
        ServicesTable.Size = New Size(650, 386)
        ServicesTable.TabIndex = 48
        ServicesTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        ServicesTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        ServicesTable.ThemeStyle.AlternatingRowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ServicesTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ServicesTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ServicesTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White
        ServicesTable.ThemeStyle.BackColor = SystemColors.Control
        ServicesTable.ThemeStyle.GridColor = Color.Silver
        ServicesTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        ServicesTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        ServicesTable.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ServicesTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        ServicesTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        ServicesTable.ThemeStyle.HeaderStyle.Height = 44
        ServicesTable.ThemeStyle.ReadOnly = True
        ServicesTable.ThemeStyle.RowsStyle.BackColor = Color.White
        ServicesTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        ServicesTable.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ServicesTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ServicesTable.ThemeStyle.RowsStyle.Height = 35
        ServicesTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ServicesTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.White
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
        ' Image
        ' 
        Image.FillWeight = 150F
        Image.HeaderText = "Image"
        Image.Name = "Image"
        Image.ReadOnly = True
        ' 
        ' Title
        ' 
        Title.FillWeight = 150F
        Title.HeaderText = "Title"
        Title.Name = "Title"
        Title.ReadOnly = True
        ' 
        ' Description
        ' 
        Description.HeaderText = "Description"
        Description.Name = "Description"
        Description.ReadOnly = True
        ' 
        ' Price
        ' 
        Price.FillWeight = 150F
        Price.HeaderText = "Price"
        Price.Name = "Price"
        Price.ReadOnly = True
        ' 
        ' Payment
        ' 
        Payment.HeaderText = "Payment"
        Payment.Name = "Payment"
        Payment.ReadOnly = True
        ' 
        ' ServicesControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        Controls.Add(ServicesTable)
        Controls.Add(BtnEdit)
        Controls.Add(BtnDelete)
        Controls.Add(BtnAdd)
        Controls.Add(Guna2TextBox1)
        Controls.Add(Guna2HtmlLabel2)
        Name = "ServicesControl"
        Size = New Size(714, 597)
        CType(ServicesTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ErrorMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents QuestionMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents SuccessfulMessage As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2vScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents ServicesTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Image As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Payment As DataGridViewTextBoxColumn
End Class
