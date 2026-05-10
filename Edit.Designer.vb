<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCCLast4 = New System.Windows.Forms.TextBox()
        Me.cbPlanType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvRFID = New System.Windows.Forms.DataGridView()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.btnRemoveVehicle = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRenew = New System.Windows.Forms.Button()
        CType(Me.dgvRFID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(111, 78)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(107, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(255, 79)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(107, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtCCLast4
        '
        Me.txtCCLast4.Location = New System.Drawing.Point(410, 78)
        Me.txtCCLast4.Name = "txtCCLast4"
        Me.txtCCLast4.Size = New System.Drawing.Size(107, 20)
        Me.txtCCLast4.TabIndex = 2
        '
        'cbPlanType
        '
        Me.cbPlanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlanType.FormattingEnabled = True
        Me.cbPlanType.Items.AddRange(New Object() {"Medium", "Spicy", "Cajun Hot"})
        Me.cbPlanType.Location = New System.Drawing.Point(552, 78)
        Me.cbPlanType.Name = "cbPlanType"
        Me.cbPlanType.Size = New System.Drawing.Size(121, 21)
        Me.cbPlanType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(437, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CC Last 4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(583, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Plan Type"
        '
        'dgvRFID
        '
        Me.dgvRFID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRFID.Location = New System.Drawing.Point(100, 158)
        Me.dgvRFID.Name = "dgvRFID"
        Me.dgvRFID.ReadOnly = True
        Me.dgvRFID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRFID.Size = New System.Drawing.Size(481, 180)
        Me.dgvRFID.TabIndex = 8
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.Location = New System.Drawing.Point(632, 158)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(119, 23)
        Me.btnAddVehicle.TabIndex = 9
        Me.btnAddVehicle.Text = "Add Vehicle"
        Me.btnAddVehicle.UseVisualStyleBackColor = True
        '
        'btnRemoveVehicle
        '
        Me.btnRemoveVehicle.Location = New System.Drawing.Point(632, 211)
        Me.btnRemoveVehicle.Name = "btnRemoveVehicle"
        Me.btnRemoveVehicle.Size = New System.Drawing.Size(119, 23)
        Me.btnRemoveVehicle.TabIndex = 10
        Me.btnRemoveVehicle.Text = "Remove Vehicle"
        Me.btnRemoveVehicle.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(160, 379)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(123, 20)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(410, 379)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(115, 20)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRenew
        '
        Me.btnRenew.Location = New System.Drawing.Point(632, 262)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(119, 20)
        Me.btnRenew.TabIndex = 13
        Me.btnRenew.Text = "Renew"
        Me.btnRenew.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemoveVehicle)
        Me.Controls.Add(Me.btnAddVehicle)
        Me.Controls.Add(Me.dgvRFID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPlanType)
        Me.Controls.Add(Me.txtCCLast4)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Edit"
        Me.Text = "Edit"
        CType(Me.dgvRFID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtCCLast4 As TextBox
    Friend WithEvents cbPlanType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvRFID As DataGridView
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents btnRemoveVehicle As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRenew As Button
End Class
