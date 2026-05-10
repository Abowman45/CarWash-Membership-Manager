<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMembershipForm
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
        Me.txtRFID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCCLast4 = New System.Windows.Forms.TextBox()
        Me.cmbPlanType = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLicensePlate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtRFID
        '
        Me.txtRFID.Location = New System.Drawing.Point(288, 59)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(156, 20)
        Me.txtRFID.TabIndex = 0
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(288, 102)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(156, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(288, 147)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(156, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtCCLast4
        '
        Me.txtCCLast4.Location = New System.Drawing.Point(288, 197)
        Me.txtCCLast4.Name = "txtCCLast4"
        Me.txtCCLast4.Size = New System.Drawing.Size(156, 20)
        Me.txtCCLast4.TabIndex = 3
        '
        'cmbPlanType
        '
        Me.cmbPlanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanType.FormattingEnabled = True
        Me.cmbPlanType.Items.AddRange(New Object() {"Medium", "Spicy", "Cajun Hot"})
        Me.cmbPlanType.Location = New System.Drawing.Point(574, 63)
        Me.cmbPlanType.Name = "cmbPlanType"
        Me.cmbPlanType.Size = New System.Drawing.Size(121, 21)
        Me.cmbPlanType.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(305, 292)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(305, 344)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(112, 23)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "RFID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CC Last 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(502, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Plan Type"
        '
        'txtLicensePlate
        '
        Me.txtLicensePlate.Location = New System.Drawing.Point(288, 248)
        Me.txtLicensePlate.Name = "txtLicensePlate"
        Me.txtLicensePlate.Size = New System.Drawing.Size(156, 20)
        Me.txtLicensePlate.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "License Plate"
        '
        'AddMembershipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLicensePlate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbPlanType)
        Me.Controls.Add(Me.txtCCLast4)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtRFID)
        Me.Name = "AddMembershipForm"
        Me.Text = "AddMembershipForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRFID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtCCLast4 As TextBox
    Friend WithEvents cmbPlanType As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLicensePlate As TextBox
    Friend WithEvents Label6 As Label
End Class
