<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Request
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Request))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GyM_DBDataSet1 = New Gym_Monitoring_System.GYM_DBDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCurrDateTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDiscounted = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMembership = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.GyM_DBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Name"
        '
        'GyM_DBDataSet1
        '
        Me.GyM_DBDataSet1.DataSetName = "GYM_DBDataSet"
        Me.GyM_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(173, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Print Request"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblCurrDateTime
        '
        Me.lblCurrDateTime.AutoSize = True
        Me.lblCurrDateTime.BackColor = System.Drawing.Color.White
        Me.lblCurrDateTime.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrDateTime.Location = New System.Drawing.Point(333, 93)
        Me.lblCurrDateTime.Name = "lblCurrDateTime"
        Me.lblCurrDateTime.Size = New System.Drawing.Size(136, 16)
        Me.lblCurrDateTime.TabIndex = 2
        Me.lblCurrDateTime.Text = "Current Datetime"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Discount in %"
        '
        'lblDiscounted
        '
        Me.lblDiscounted.AutoSize = True
        Me.lblDiscounted.BackColor = System.Drawing.Color.White
        Me.lblDiscounted.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscounted.Location = New System.Drawing.Point(146, 301)
        Me.lblDiscounted.Name = "lblDiscounted"
        Me.lblDiscounted.Size = New System.Drawing.Size(16, 16)
        Me.lblDiscounted.TabIndex = 11
        Me.lblDiscounted.Text = "0"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(146, 247)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(16, 16)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.Text = "0"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BackColor = System.Drawing.Color.White
        Me.lblDiscount.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(146, 274)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(16, 16)
        Me.lblDiscount.TabIndex = 13
        Me.lblDiscount.Text = "0"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(146, 119)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(40, 16)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "NAME"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(146, 151)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 16)
        Me.lblAddress.TabIndex = 14
        Me.lblAddress.Text = "ADDRESS"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.White
        Me.lblContact.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(146, 185)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(120, 16)
        Me.lblContact.TabIndex = 14
        Me.lblContact.Text = "CONTACT NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Membership"
        '
        'lblMembership
        '
        Me.lblMembership.AutoSize = True
        Me.lblMembership.BackColor = System.Drawing.Color.White
        Me.lblMembership.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembership.Location = New System.Drawing.Point(146, 219)
        Me.lblMembership.Name = "lblMembership"
        Me.lblMembership.Size = New System.Drawing.Size(88, 16)
        Me.lblMembership.TabIndex = 15
        Me.lblMembership.Text = "MEMBERSHIP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Order ID"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.BackColor = System.Drawing.Color.White
        Me.lblOrderID.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.Location = New System.Drawing.Point(146, 93)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(72, 16)
        Me.lblOrderID.TabIndex = 16
        Me.lblOrderID.Text = "00000000"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(353, 21)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 27
        Me.PictureBox6.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(149, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 35)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "GymBros PH"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(92, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Order_Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(492, 387)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMembership)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDiscounted)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCurrDateTime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Order_Request"
        Me.Text = "Order_Request"
        CType(Me.GyM_DBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GyM_DBDataSet1 As GYM_DBDataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents lblCurrDateTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDiscounted As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMembership As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
