<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembershipSearchForm
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
        Me.dgvMemberhipsTable = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAddMembership = New System.Windows.Forms.Button()
        Me.cbSearchBy = New System.Windows.Forms.ComboBox()
        CType(Me.dgvMemberhipsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMemberhipsTable
        '
        Me.dgvMemberhipsTable.AllowUserToAddRows = False
        Me.dgvMemberhipsTable.AllowUserToDeleteRows = False
        Me.dgvMemberhipsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMemberhipsTable.Location = New System.Drawing.Point(53, 173)
        Me.dgvMemberhipsTable.Name = "dgvMemberhipsTable"
        Me.dgvMemberhipsTable.ReadOnly = True
        Me.dgvMemberhipsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMemberhipsTable.Size = New System.Drawing.Size(686, 242)
        Me.dgvMemberhipsTable.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(215, 147)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 20)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(523, 144)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(141, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAddMembership
        '
        Me.btnAddMembership.Location = New System.Drawing.Point(523, 106)
        Me.btnAddMembership.Name = "btnAddMembership"
        Me.btnAddMembership.Size = New System.Drawing.Size(141, 29)
        Me.btnAddMembership.TabIndex = 4
        Me.btnAddMembership.Text = "Add Membership"
        Me.btnAddMembership.UseVisualStyleBackColor = True
        '
        'cbSearchBy
        '
        Me.cbSearchBy.AutoCompleteCustomSource.AddRange(New String() {"RFID", "First Name", "Last Name", "CC Last 4"})
        Me.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchBy.FormattingEnabled = True
        Me.cbSearchBy.Items.AddRange(New Object() {"RFID", "First Name", "Last Name", "CC Last 4"})
        Me.cbSearchBy.Location = New System.Drawing.Point(417, 146)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(100, 21)
        Me.cbSearchBy.TabIndex = 5
        '
        'MembershipSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 499)
        Me.Controls.Add(Me.cbSearchBy)
        Me.Controls.Add(Me.btnAddMembership)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvMemberhipsTable)
        Me.Name = "MembershipSearchForm"
        Me.Text = "Membership Search"
        CType(Me.dgvMemberhipsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMemberhipsTable As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddMembership As Button
    Friend WithEvents cbSearchBy As ComboBox
End Class
