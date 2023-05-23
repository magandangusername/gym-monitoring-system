<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buy_membership
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbdiscount1 = New System.Windows.Forms.RadioButton()
        Me.rdbdiscount2 = New System.Windows.Forms.RadioButton()
        Me.rdbdiscount3 = New System.Windows.Forms.RadioButton()
        Me.rdbdiscount4 = New System.Windows.Forms.RadioButton()
        Me.rdbdiscount5 = New System.Windows.Forms.RadioButton()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Membership"
        '
        'rdbdiscount1
        '
        Me.rdbdiscount1.AutoSize = True
        Me.rdbdiscount1.Location = New System.Drawing.Point(36, 68)
        Me.rdbdiscount1.Name = "rdbdiscount1"
        Me.rdbdiscount1.Size = New System.Drawing.Size(188, 17)
        Me.rdbdiscount1.TabIndex = 1
        Me.rdbdiscount1.TabStop = True
        Me.rdbdiscount1.Text = "2 Weeks - 2% Discount (PHP 750)"
        Me.rdbdiscount1.UseVisualStyleBackColor = True
        '
        'rdbdiscount2
        '
        Me.rdbdiscount2.AutoSize = True
        Me.rdbdiscount2.Location = New System.Drawing.Point(36, 101)
        Me.rdbdiscount2.Name = "rdbdiscount2"
        Me.rdbdiscount2.Size = New System.Drawing.Size(187, 17)
        Me.rdbdiscount2.TabIndex = 2
        Me.rdbdiscount2.TabStop = True
        Me.rdbdiscount2.Text = "1 Month 5% Discount (PHP 1,500)"
        Me.rdbdiscount2.UseVisualStyleBackColor = True
        '
        'rdbdiscount3
        '
        Me.rdbdiscount3.AutoSize = True
        Me.rdbdiscount3.Location = New System.Drawing.Point(36, 137)
        Me.rdbdiscount3.Name = "rdbdiscount3"
        Me.rdbdiscount3.Size = New System.Drawing.Size(204, 17)
        Me.rdbdiscount3.TabIndex = 3
        Me.rdbdiscount3.TabStop = True
        Me.rdbdiscount3.Text = "3 Months - 10% Discount (PHP 3,500)"
        Me.rdbdiscount3.UseVisualStyleBackColor = True
        '
        'rdbdiscount4
        '
        Me.rdbdiscount4.AutoSize = True
        Me.rdbdiscount4.Location = New System.Drawing.Point(36, 173)
        Me.rdbdiscount4.Name = "rdbdiscount4"
        Me.rdbdiscount4.Size = New System.Drawing.Size(204, 17)
        Me.rdbdiscount4.TabIndex = 4
        Me.rdbdiscount4.TabStop = True
        Me.rdbdiscount4.Text = "6 Months - 13% Discount (PHP 5,500)"
        Me.rdbdiscount4.UseVisualStyleBackColor = True
        '
        'rdbdiscount5
        '
        Me.rdbdiscount5.AutoSize = True
        Me.rdbdiscount5.Location = New System.Drawing.Point(36, 208)
        Me.rdbdiscount5.Name = "rdbdiscount5"
        Me.rdbdiscount5.Size = New System.Drawing.Size(191, 17)
        Me.rdbdiscount5.TabIndex = 5
        Me.rdbdiscount5.TabStop = True
        Me.rdbdiscount5.Text = "1 Year - 13% Discount (PHP 9,000)"
        Me.rdbdiscount5.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(89, 258)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceOrder.TabIndex = 6
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'buy_membership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 317)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.rdbdiscount5)
        Me.Controls.Add(Me.rdbdiscount4)
        Me.Controls.Add(Me.rdbdiscount3)
        Me.Controls.Add(Me.rdbdiscount2)
        Me.Controls.Add(Me.rdbdiscount1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "buy_membership"
        Me.Text = "buy_membership"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdbdiscount1 As RadioButton
    Friend WithEvents rdbdiscount2 As RadioButton
    Friend WithEvents rdbdiscount3 As RadioButton
    Friend WithEvents rdbdiscount4 As RadioButton
    Friend WithEvents rdbdiscount5 As RadioButton
    Friend WithEvents btnPlaceOrder As Button
End Class
