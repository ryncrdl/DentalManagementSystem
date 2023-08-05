<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ineligible
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DoctorsTable = New Guna.UI2.WinForms.Guna2DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Firstname = New DataGridViewTextBoxColumn()
        Lastname = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        CType(DoctorsTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DoctorsTable
        ' 
        DoctorsTable.AllowUserToAddRows = False
        DoctorsTable.AllowUserToDeleteRows = False
        DoctorsTable.AllowUserToOrderColumns = True
        DoctorsTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DoctorsTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DoctorsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        DoctorsTable.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DoctorsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DoctorsTable.ColumnHeadersHeight = 44
        DoctorsTable.Columns.AddRange(New DataGridViewColumn() {ID, Firstname, Lastname, Contact, Email, Address})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DoctorsTable.DefaultCellStyle = DataGridViewCellStyle3
        DoctorsTable.GridColor = Color.Silver
        DoctorsTable.ImeMode = ImeMode.NoControl
        DoctorsTable.Location = New Point(-3, 2)
        DoctorsTable.Margin = New Padding(0)
        DoctorsTable.MultiSelect = False
        DoctorsTable.Name = "DoctorsTable"
        DoctorsTable.ReadOnly = True
        DoctorsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        DoctorsTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DoctorsTable.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DoctorsTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        DoctorsTable.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DoctorsTable.RowTemplate.Height = 35
        DoctorsTable.Size = New Size(884, 497)
        DoctorsTable.TabIndex = 16
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
        ' ineligible
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(921, 508)
        ControlBox = False
        Controls.Add(DoctorsTable)
        Name = "ineligible"
        CType(DoctorsTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DoctorsTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
End Class
