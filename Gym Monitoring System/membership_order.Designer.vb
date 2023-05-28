<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class membership_order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(membership_order))
        Me.txtMembershipOrder = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMembershipOrder
        '
        Me.txtMembershipOrder.Location = New System.Drawing.Point(98, 31)
        Me.txtMembershipOrder.Name = "txtMembershipOrder"
        Me.txtMembershipOrder.Size = New System.Drawing.Size(235, 20)
        Me.txtMembershipOrder.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(155, 109)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 25)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Enter"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Cyan
        Me.lbl1.Location = New System.Drawing.Point(137, 54)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(140, 13)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Membership Order ID"
        '
        'membership_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(411, 146)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtMembershipOrder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "membership_order"
        Me.Text = "Activate Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMembershipOrder As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lbl1 As Label
End Class
