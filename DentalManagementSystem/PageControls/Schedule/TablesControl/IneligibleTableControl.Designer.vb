<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IneligibleTableControl
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        RejectedTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(components)
        ID = New DataGridViewTextBoxColumn()
        ClientsId = New DataGridViewTextBoxColumn()
        Fullname = New DataGridViewTextBoxColumn()
        Contact = New DataGridViewTextBoxColumn()
        Dates = New DataGridViewTextBoxColumn()
        Service = New DataGridViewTextBoxColumn()
        Doctor = New DataGridViewTextBoxColumn()
        Payment = New DataGridViewTextBoxColumn()
        CType(RejectedTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 20
        Guna2Elipse1.TargetControl = Me
        ' 
        ' RejectedTable
        ' 
        RejectedTable.AllowUserToAddRows = False
        RejectedTable.AllowUserToDeleteRows = False
        RejectedTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        RejectedTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        RejectedTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        RejectedTable.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        RejectedTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        RejectedTable.ColumnHeadersHeight = 44
        RejectedTable.Columns.AddRange(New DataGridViewColumn() {ID, ClientsId, Fullname, Contact, Dates, Service, Doctor, Payment})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        RejectedTable.DefaultCellStyle = DataGridViewCellStyle3
        RejectedTable.GridColor = Color.Silver
        RejectedTable.ImeMode = ImeMode.NoControl
        RejectedTable.Location = New Point(0, 0)
        RejectedTable.Margin = New Padding(0)
        RejectedTable.MultiSelect = False
        RejectedTable.Name = "RejectedTable"
        RejectedTable.ReadOnly = True
        RejectedTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        RejectedTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        RejectedTable.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        RejectedTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        RejectedTable.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        RejectedTable.RowTemplate.Height = 35
        RejectedTable.Size = New Size(650, 386)
        RejectedTable.TabIndex = 4
        RejectedTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        RejectedTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        RejectedTable.ThemeStyle.AlternatingRowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RejectedTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        RejectedTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        RejectedTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White
        RejectedTable.ThemeStyle.BackColor = SystemColors.Control
        RejectedTable.ThemeStyle.GridColor = Color.Silver
        RejectedTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(0), CByte(118), CByte(212))
        RejectedTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        RejectedTable.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RejectedTable.ThemeStyle.HeaderStyle.ForeColor = Color.White
        RejectedTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        RejectedTable.ThemeStyle.HeaderStyle.Height = 44
        RejectedTable.ThemeStyle.ReadOnly = True
        RejectedTable.ThemeStyle.RowsStyle.BackColor = Color.White
        RejectedTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        RejectedTable.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RejectedTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        RejectedTable.ThemeStyle.RowsStyle.Height = 35
        RejectedTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        RejectedTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.White
        ' 
        ' Guna2Elipse2
        ' 
        Guna2Elipse2.BorderRadius = 20
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
        ' ClientsId
        ' 
        ClientsId.HeaderText = "Column1"
        ClientsId.Name = "ClientsId"
        ClientsId.ReadOnly = True
        ClientsId.Visible = False
        ' 
        ' Fullname
        ' 
        Fullname.FillWeight = 150F
        Fullname.HeaderText = "Full Name"
        Fullname.Name = "Fullname"
        Fullname.ReadOnly = True
        Fullname.Width = 160
        ' 
        ' Contact
        ' 
        Contact.FillWeight = 150F
        Contact.HeaderText = "Contact"
        Contact.Name = "Contact"
        Contact.ReadOnly = True
        Contact.Width = 161
        ' 
        ' Dates
        ' 
        Dates.FillWeight = 150F
        Dates.HeaderText = "Date"
        Dates.Name = "Dates"
        Dates.ReadOnly = True
        Dates.Width = 160
        ' 
        ' Service
        ' 
        Service.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Service.FillWeight = 150F
        Service.HeaderText = "Service"
        Service.Name = "Service"
        Service.ReadOnly = True
        Service.Width = 89
        ' 
        ' Doctor
        ' 
        Doctor.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
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
        ' 
        ' IneligibleTableControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(RejectedTable)
        Name = "IneligibleTableControl"
        Size = New Size(650, 386)
        CType(RejectedTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents RejectedTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ClientsId As DataGridViewTextBoxColumn
    Friend WithEvents Fullname As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Dates As DataGridViewTextBoxColumn
    Friend WithEvents Service As DataGridViewTextBoxColumn
    Friend WithEvents Doctor As DataGridViewTextBoxColumn
    Friend WithEvents Payment As DataGridViewTextBoxColumn
End Class
