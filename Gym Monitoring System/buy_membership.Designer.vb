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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(buy_membership))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbdiscount1 = New System.Windows.Forms.RadioButton()
        Me.rdbdiscount2 = New System.Windows.Forms.RadioButton()
        Me.rdbdiscount3 = New System.Windows.Forms.RadioButton()
        Me.rdbdiscount4 = New System.Windows.Forms.RadioButton()
        Me.rdbdiscount5 = New System.Windows.Forms.RadioButton()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPriceTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(109, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Membership"
        '
        'rdbdiscount1
        '
        Me.rdbdiscount1.AutoSize = True
        Me.rdbdiscount1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbdiscount1.ForeColor = System.Drawing.Color.Cyan
        Me.rdbdiscount1.Location = New System.Drawing.Point(40, 125)
        Me.rdbdiscount1.Name = "rdbdiscount1"
        Me.rdbdiscount1.Size = New System.Drawing.Size(226, 17)
        Me.rdbdiscount1.TabIndex = 1
        Me.rdbdiscount1.TabStop = True
        Me.rdbdiscount1.Text = "2 Weeks - 2% Discount (PHP 750)"
        Me.rdbdiscount1.UseVisualStyleBackColor = True
        '
        'rdbdiscount2
        '
        Me.rdbdiscount2.AutoSize = True
        Me.rdbdiscount2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbdiscount2.ForeColor = System.Drawing.Color.Cyan
        Me.rdbdiscount2.Location = New System.Drawing.Point(40, 158)
        Me.rdbdiscount2.Name = "rdbdiscount2"
        Me.rdbdiscount2.Size = New System.Drawing.Size(232, 17)
        Me.rdbdiscount2.TabIndex = 2
        Me.rdbdiscount2.TabStop = True
        Me.rdbdiscount2.Text = "1 Month 5% Discount (PHP 1,500)"
        Me.rdbdiscount2.UseVisualStyleBackColor = True
        '
        'rdbdiscount3
        '
        Me.rdbdiscount3.AutoSize = True
        Me.rdbdiscount3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbdiscount3.ForeColor = System.Drawing.Color.Cyan
        Me.rdbdiscount3.Location = New System.Drawing.Point(40, 194)
        Me.rdbdiscount3.Name = "rdbdiscount3"
        Me.rdbdiscount3.Size = New System.Drawing.Size(252, 17)
        Me.rdbdiscount3.TabIndex = 3
        Me.rdbdiscount3.TabStop = True
        Me.rdbdiscount3.Text = "3 Months - 10% Discount (PHP 3,500)"
        Me.rdbdiscount3.UseVisualStyleBackColor = True
        '
        'rdbdiscount4
        '
        Me.rdbdiscount4.AutoSize = True
        Me.rdbdiscount4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbdiscount4.ForeColor = System.Drawing.Color.Cyan
        Me.rdbdiscount4.Location = New System.Drawing.Point(40, 230)
        Me.rdbdiscount4.Name = "rdbdiscount4"
        Me.rdbdiscount4.Size = New System.Drawing.Size(252, 17)
        Me.rdbdiscount4.TabIndex = 4
        Me.rdbdiscount4.TabStop = True
        Me.rdbdiscount4.Text = "6 Months - 13% Discount (PHP 5,500)"
        Me.rdbdiscount4.UseVisualStyleBackColor = True
        '
        'rdbdiscount5
        '
        Me.rdbdiscount5.AutoSize = True
        Me.rdbdiscount5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbdiscount5.ForeColor = System.Drawing.Color.Cyan
        Me.rdbdiscount5.Location = New System.Drawing.Point(40, 265)
        Me.rdbdiscount5.Name = "rdbdiscount5"
        Me.rdbdiscount5.Size = New System.Drawing.Size(235, 17)
        Me.rdbdiscount5.TabIndex = 5
        Me.rdbdiscount5.TabStop = True
        Me.rdbdiscount5.Text = "1 Year - 13% Discount (PHP 9,000)"
        Me.rdbdiscount5.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.Location = New System.Drawing.Point(80, 360)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(133, 23)
        Me.btnPlaceOrder.TabIndex = 6
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Cyan
        Me.lblPrice.Location = New System.Drawing.Point(37, 306)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 13)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price:"
        '
        'lblPriceTotal
        '
        Me.lblPriceTotal.AutoSize = True
        Me.lblPriceTotal.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceTotal.ForeColor = System.Drawing.Color.Cyan
        Me.lblPriceTotal.Location = New System.Drawing.Point(77, 306)
        Me.lblPriceTotal.Name = "lblPriceTotal"
        Me.lblPriceTotal.Size = New System.Drawing.Size(15, 13)
        Me.lblPriceTotal.TabIndex = 7
        Me.lblPriceTotal.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(80, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 31)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "GymBros PH"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(249, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'buy_membership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(307, 408)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPriceTotal)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.rdbdiscount5)
        Me.Controls.Add(Me.rdbdiscount4)
        Me.Controls.Add(Me.rdbdiscount3)
        Me.Controls.Add(Me.rdbdiscount2)
        Me.Controls.Add(Me.rdbdiscount1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "buy_membership"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblPriceTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
