<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class member_registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(member_registration))
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtContactNumber2 = New System.Windows.Forms.TextBox()
        Me.lblContactNumber2 = New System.Windows.Forms.Label()
        Me.txtEmergencyContactPerson = New System.Windows.Forms.TextBox()
        Me.lblEmergencyContactPerson = New System.Windows.Forms.Label()
        Me.txtReTypePassword = New System.Windows.Forms.TextBox()
        Me.lblReTypePassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.showPassword = New System.Windows.Forms.PictureBox()
        Me.hidePassword = New System.Windows.Forms.PictureBox()
        Me.showPassword2 = New System.Windows.Forms.PictureBox()
        Me.hidePassword2 = New System.Windows.Forms.PictureBox()
        CType(Me.showPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showPassword2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidePassword2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(57, 41)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(54, 13)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name"
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(112, 38)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(307, 20)
        Me.txtFullname.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(112, 74)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(307, 20)
        Me.txtAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(57, 77)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(57, 117)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(45, 13)
        Me.lblBirthday.TabIndex = 4
        Me.lblBirthday.Text = "Birthday"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(112, 114)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(200, 20)
        Me.dtpBirthday.TabIndex = 5
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(57, 162)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 6
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(112, 159)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(200, 20)
        Me.txtAge.TabIndex = 7
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(57, 206)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(112, 201)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(48, 17)
        Me.rdbMale.TabIndex = 9
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(222, 201)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdbFemale.TabIndex = 10
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(147, 245)
        Me.txtContactNumber.MaxLength = 11
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(307, 20)
        Me.txtContactNumber.TabIndex = 12
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(57, 245)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(84, 13)
        Me.lblContactNumber.TabIndex = 11
        Me.lblContactNumber.Text = "Contact Number"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(112, 289)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(307, 20)
        Me.txtEmail.TabIndex = 14
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(57, 292)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 13
        Me.lblEmail.Text = "Email"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(469, 162)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(200, 20)
        Me.txtHeight.TabIndex = 16
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(414, 165)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 15
        Me.lblHeight.Text = "Height"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(469, 201)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(200, 20)
        Me.txtWeight.TabIndex = 18
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(414, 204)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 17
        Me.lblWeight.Text = "Weight"
        '
        'txtContactNumber2
        '
        Me.txtContactNumber2.Location = New System.Drawing.Point(147, 389)
        Me.txtContactNumber2.MaxLength = 11
        Me.txtContactNumber2.Name = "txtContactNumber2"
        Me.txtContactNumber2.Size = New System.Drawing.Size(307, 20)
        Me.txtContactNumber2.TabIndex = 22
        '
        'lblContactNumber2
        '
        Me.lblContactNumber2.AutoSize = True
        Me.lblContactNumber2.Location = New System.Drawing.Point(57, 392)
        Me.lblContactNumber2.Name = "lblContactNumber2"
        Me.lblContactNumber2.Size = New System.Drawing.Size(84, 13)
        Me.lblContactNumber2.TabIndex = 21
        Me.lblContactNumber2.Text = "Contact Number"
        '
        'txtEmergencyContactPerson
        '
        Me.txtEmergencyContactPerson.Location = New System.Drawing.Point(199, 342)
        Me.txtEmergencyContactPerson.Name = "txtEmergencyContactPerson"
        Me.txtEmergencyContactPerson.Size = New System.Drawing.Size(307, 20)
        Me.txtEmergencyContactPerson.TabIndex = 20
        '
        'lblEmergencyContactPerson
        '
        Me.lblEmergencyContactPerson.AutoSize = True
        Me.lblEmergencyContactPerson.Location = New System.Drawing.Point(57, 345)
        Me.lblEmergencyContactPerson.Name = "lblEmergencyContactPerson"
        Me.lblEmergencyContactPerson.Size = New System.Drawing.Size(136, 13)
        Me.lblEmergencyContactPerson.TabIndex = 19
        Me.lblEmergencyContactPerson.Text = "Emergency Contact Person"
        '
        'txtReTypePassword
        '
        Me.txtReTypePassword.Location = New System.Drawing.Point(160, 478)
        Me.txtReTypePassword.Name = "txtReTypePassword"
        Me.txtReTypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtReTypePassword.Size = New System.Drawing.Size(307, 20)
        Me.txtReTypePassword.TabIndex = 26
        '
        'lblReTypePassword
        '
        Me.lblReTypePassword.AutoSize = True
        Me.lblReTypePassword.Location = New System.Drawing.Point(57, 485)
        Me.lblReTypePassword.Name = "lblReTypePassword"
        Me.lblReTypePassword.Size = New System.Drawing.Size(97, 13)
        Me.lblReTypePassword.TabIndex = 25
        Me.lblReTypePassword.Text = "Re-Type Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(112, 435)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(307, 20)
        Me.txtPassword.TabIndex = 24
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(57, 438)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 23
        Me.lblPassword.Text = "Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(57, 529)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Any Medical Condition?"
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Location = New System.Drawing.Point(354, 525)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(39, 17)
        Me.rdbNo.TabIndex = 29
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbYes
        '
        Me.rdbYes.AutoSize = True
        Me.rdbYes.Location = New System.Drawing.Point(222, 527)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(43, 17)
        Me.rdbYes.TabIndex = 28
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes"
        Me.rdbYes.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(60, 566)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(367, 96)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(610, 406)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 31
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(610, 475)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "  Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(675, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "CM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(675, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "KG"
        '
        'showPassword
        '
        Me.showPassword.Image = CType(resources.GetObject("showPassword.Image"), System.Drawing.Image)
        Me.showPassword.Location = New System.Drawing.Point(425, 435)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(19, 20)
        Me.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showPassword.TabIndex = 68
        Me.showPassword.TabStop = False
        '
        'hidePassword
        '
        Me.hidePassword.Image = CType(resources.GetObject("hidePassword.Image"), System.Drawing.Image)
        Me.hidePassword.Location = New System.Drawing.Point(425, 435)
        Me.hidePassword.Name = "hidePassword"
        Me.hidePassword.Size = New System.Drawing.Size(19, 20)
        Me.hidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidePassword.TabIndex = 69
        Me.hidePassword.TabStop = False
        Me.hidePassword.Visible = False
        '
        'showPassword2
        '
        Me.showPassword2.Image = CType(resources.GetObject("showPassword2.Image"), System.Drawing.Image)
        Me.showPassword2.Location = New System.Drawing.Point(473, 478)
        Me.showPassword2.Name = "showPassword2"
        Me.showPassword2.Size = New System.Drawing.Size(19, 20)
        Me.showPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showPassword2.TabIndex = 70
        Me.showPassword2.TabStop = False
        '
        'hidePassword2
        '
        Me.hidePassword2.Image = CType(resources.GetObject("hidePassword2.Image"), System.Drawing.Image)
        Me.hidePassword2.Location = New System.Drawing.Point(473, 478)
        Me.hidePassword2.Name = "hidePassword2"
        Me.hidePassword2.Size = New System.Drawing.Size(19, 20)
        Me.hidePassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidePassword2.TabIndex = 71
        Me.hidePassword2.TabStop = False
        Me.hidePassword2.Visible = False
        '
        'member_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 704)
        Me.Controls.Add(Me.showPassword2)
        Me.Controls.Add(Me.hidePassword2)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.hidePassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.rdbNo)
        Me.Controls.Add(Me.rdbYes)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtReTypePassword)
        Me.Controls.Add(Me.lblReTypePassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtContactNumber2)
        Me.Controls.Add(Me.lblContactNumber2)
        Me.Controls.Add(Me.txtEmergencyContactPerson)
        Me.Controls.Add(Me.lblEmergencyContactPerson)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.rdbFemale)
        Me.Controls.Add(Me.rdbMale)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.lblFullName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "member_registration"
        Me.Text = "member_registration"
        CType(Me.showPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showPassword2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidePassword2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtContactNumber2 As TextBox
    Friend WithEvents lblContactNumber2 As Label
    Friend WithEvents txtEmergencyContactPerson As TextBox
    Friend WithEvents lblEmergencyContactPerson As Label
    Friend WithEvents txtReTypePassword As TextBox
    Friend WithEvents lblReTypePassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents rdbNo As RadioButton
    Friend WithEvents rdbYes As RadioButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents showPassword As PictureBox
    Friend WithEvents hidePassword As PictureBox
    Friend WithEvents showPassword2 As PictureBox
    Friend WithEvents hidePassword2 As PictureBox
End Class
