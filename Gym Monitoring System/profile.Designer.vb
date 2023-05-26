<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profile))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtReTypePassword = New System.Windows.Forms.TextBox()
        Me.lblReTypePassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtContactNumber2 = New System.Windows.Forms.TextBox()
        Me.lblContactNumber2 = New System.Windows.Forms.Label()
        Me.txtEmergencyContactPerson = New System.Windows.Forms.TextBox()
        Me.lblEmergencyContactPerson = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.showPassword = New System.Windows.Forms.PictureBox()
        Me.hidePassword = New System.Windows.Forms.PictureBox()
        Me.showPassword2 = New System.Windows.Forms.PictureBox()
        Me.hidePassword2 = New System.Windows.Forms.PictureBox()
        Me.lblPassRequirements = New System.Windows.Forms.Label()
        Me.lblPassword2Required = New System.Windows.Forms.Label()
        Me.lblPasswordRequired = New System.Windows.Forms.Label()
        Me.lblContactNum2Required = New System.Windows.Forms.Label()
        Me.lblECPRequired = New System.Windows.Forms.Label()
        Me.lblEmailRequired = New System.Windows.Forms.Label()
        Me.lblContactNumRequired = New System.Windows.Forms.Label()
        Me.lblAddrRequired = New System.Windows.Forms.Label()
        Me.lblFNameRequired = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbloldpass = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.hideoldpass = New System.Windows.Forms.PictureBox()
        Me.seeoldpass = New System.Windows.Forms.PictureBox()
        Me.lbloldpasswordrequired = New System.Windows.Forms.Label()
        Me.lbloldpasswordrequired2 = New System.Windows.Forms.Label()
        CType(Me.showPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showPassword2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidePassword2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hideoldpass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seeoldpass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(397, 610)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 61
        Me.btnBack.Text = "  Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(251, 610)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 60
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtReTypePassword
        '
        Me.txtReTypePassword.Location = New System.Drawing.Point(215, 553)
        Me.txtReTypePassword.Name = "txtReTypePassword"
        Me.txtReTypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtReTypePassword.Size = New System.Drawing.Size(307, 20)
        Me.txtReTypePassword.TabIndex = 59
        '
        'lblReTypePassword
        '
        Me.lblReTypePassword.AutoSize = True
        Me.lblReTypePassword.Location = New System.Drawing.Point(90, 556)
        Me.lblReTypePassword.Name = "lblReTypePassword"
        Me.lblReTypePassword.Size = New System.Drawing.Size(122, 13)
        Me.lblReTypePassword.TabIndex = 58
        Me.lblReTypePassword.Text = "Re-Type New Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(215, 518)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(307, 20)
        Me.txtPassword.TabIndex = 57
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(134, 521)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 13)
        Me.lblPassword.TabIndex = 56
        Me.lblPassword.Text = "New Password"
        '
        'txtContactNumber2
        '
        Me.txtContactNumber2.Location = New System.Drawing.Point(215, 455)
        Me.txtContactNumber2.MaxLength = 11
        Me.txtContactNumber2.Name = "txtContactNumber2"
        Me.txtContactNumber2.Size = New System.Drawing.Size(307, 20)
        Me.txtContactNumber2.TabIndex = 55
        '
        'lblContactNumber2
        '
        Me.lblContactNumber2.AutoSize = True
        Me.lblContactNumber2.Location = New System.Drawing.Point(128, 458)
        Me.lblContactNumber2.Name = "lblContactNumber2"
        Me.lblContactNumber2.Size = New System.Drawing.Size(84, 13)
        Me.lblContactNumber2.TabIndex = 54
        Me.lblContactNumber2.Text = "Contact Number"
        '
        'txtEmergencyContactPerson
        '
        Me.txtEmergencyContactPerson.Location = New System.Drawing.Point(215, 419)
        Me.txtEmergencyContactPerson.Name = "txtEmergencyContactPerson"
        Me.txtEmergencyContactPerson.Size = New System.Drawing.Size(307, 20)
        Me.txtEmergencyContactPerson.TabIndex = 53
        '
        'lblEmergencyContactPerson
        '
        Me.lblEmergencyContactPerson.AutoSize = True
        Me.lblEmergencyContactPerson.Location = New System.Drawing.Point(76, 422)
        Me.lblEmergencyContactPerson.Name = "lblEmergencyContactPerson"
        Me.lblEmergencyContactPerson.Size = New System.Drawing.Size(136, 13)
        Me.lblEmergencyContactPerson.TabIndex = 52
        Me.lblEmergencyContactPerson.Text = "Emergency Contact Person"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(215, 384)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(307, 20)
        Me.txtWeight.TabIndex = 51
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(171, 387)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 50
        Me.lblWeight.Text = "Weight"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(215, 343)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(307, 20)
        Me.txtHeight.TabIndex = 49
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(174, 346)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 48
        Me.lblHeight.Text = "Height"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(215, 310)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(307, 20)
        Me.txtEmail.TabIndex = 47
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(180, 313)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 46
        Me.lblEmail.Text = "Email"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(215, 273)
        Me.txtContactNumber.MaxLength = 11
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(307, 20)
        Me.txtContactNumber.TabIndex = 45
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(128, 276)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(84, 13)
        Me.lblContactNumber.TabIndex = 44
        Me.lblContactNumber.Text = "Contact Number"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(170, 243)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 41
        Me.lblGender.Text = "Gender"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(167, 170)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(45, 13)
        Me.lblBirthday.TabIndex = 37
        Me.lblBirthday.Text = "Birthday"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(215, 132)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(307, 20)
        Me.txtAddress.TabIndex = 36
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(167, 135)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 35
        Me.lblAddress.Text = "Address"
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(215, 94)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(307, 20)
        Me.txtFullname.TabIndex = 34
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(160, 97)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(54, 13)
        Me.lblFullName.TabIndex = 33
        Me.lblFullName.Text = "Full Name"
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(215, 167)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.ReadOnly = True
        Me.txtBirthday.Size = New System.Drawing.Size(307, 20)
        Me.txtBirthday.TabIndex = 62
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(215, 240)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(307, 20)
        Me.txtGender.TabIndex = 63
        '
        'showPassword
        '
        Me.showPassword.Image = CType(resources.GetObject("showPassword.Image"), System.Drawing.Image)
        Me.showPassword.Location = New System.Drawing.Point(528, 518)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(19, 20)
        Me.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showPassword.TabIndex = 64
        Me.showPassword.TabStop = False
        '
        'hidePassword
        '
        Me.hidePassword.Image = CType(resources.GetObject("hidePassword.Image"), System.Drawing.Image)
        Me.hidePassword.Location = New System.Drawing.Point(528, 518)
        Me.hidePassword.Name = "hidePassword"
        Me.hidePassword.Size = New System.Drawing.Size(19, 20)
        Me.hidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidePassword.TabIndex = 65
        Me.hidePassword.TabStop = False
        Me.hidePassword.Visible = False
        '
        'showPassword2
        '
        Me.showPassword2.Image = CType(resources.GetObject("showPassword2.Image"), System.Drawing.Image)
        Me.showPassword2.Location = New System.Drawing.Point(528, 554)
        Me.showPassword2.Name = "showPassword2"
        Me.showPassword2.Size = New System.Drawing.Size(19, 20)
        Me.showPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showPassword2.TabIndex = 66
        Me.showPassword2.TabStop = False
        '
        'hidePassword2
        '
        Me.hidePassword2.Image = CType(resources.GetObject("hidePassword2.Image"), System.Drawing.Image)
        Me.hidePassword2.Location = New System.Drawing.Point(528, 554)
        Me.hidePassword2.Name = "hidePassword2"
        Me.hidePassword2.Size = New System.Drawing.Size(19, 20)
        Me.hidePassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidePassword2.TabIndex = 67
        Me.hidePassword2.TabStop = False
        Me.hidePassword2.Visible = False
        '
        'lblPassRequirements
        '
        Me.lblPassRequirements.AutoSize = True
        Me.lblPassRequirements.ForeColor = System.Drawing.Color.Red
        Me.lblPassRequirements.Location = New System.Drawing.Point(628, 521)
        Me.lblPassRequirements.Name = "lblPassRequirements"
        Me.lblPassRequirements.Size = New System.Drawing.Size(84, 13)
        Me.lblPassRequirements.TabIndex = 86
        Me.lblPassRequirements.Text = "pw requirements"
        Me.lblPassRequirements.Visible = False
        '
        'lblPassword2Required
        '
        Me.lblPassword2Required.AutoSize = True
        Me.lblPassword2Required.ForeColor = System.Drawing.Color.Red
        Me.lblPassword2Required.Location = New System.Drawing.Point(553, 556)
        Me.lblPassword2Required.Name = "lblPassword2Required"
        Me.lblPassword2Required.Size = New System.Drawing.Size(50, 13)
        Me.lblPassword2Required.TabIndex = 75
        Me.lblPassword2Required.Text = "Required"
        Me.lblPassword2Required.Visible = False
        '
        'lblPasswordRequired
        '
        Me.lblPasswordRequired.AutoSize = True
        Me.lblPasswordRequired.ForeColor = System.Drawing.Color.Red
        Me.lblPasswordRequired.Location = New System.Drawing.Point(553, 521)
        Me.lblPasswordRequired.Name = "lblPasswordRequired"
        Me.lblPasswordRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblPasswordRequired.TabIndex = 76
        Me.lblPasswordRequired.Text = "Required"
        Me.lblPasswordRequired.Visible = False
        '
        'lblContactNum2Required
        '
        Me.lblContactNum2Required.AutoSize = True
        Me.lblContactNum2Required.ForeColor = System.Drawing.Color.Red
        Me.lblContactNum2Required.Location = New System.Drawing.Point(525, 458)
        Me.lblContactNum2Required.Name = "lblContactNum2Required"
        Me.lblContactNum2Required.Size = New System.Drawing.Size(50, 13)
        Me.lblContactNum2Required.TabIndex = 77
        Me.lblContactNum2Required.Text = "Required"
        Me.lblContactNum2Required.Visible = False
        '
        'lblECPRequired
        '
        Me.lblECPRequired.AutoSize = True
        Me.lblECPRequired.ForeColor = System.Drawing.Color.Red
        Me.lblECPRequired.Location = New System.Drawing.Point(525, 423)
        Me.lblECPRequired.Name = "lblECPRequired"
        Me.lblECPRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblECPRequired.TabIndex = 78
        Me.lblECPRequired.Text = "Required"
        Me.lblECPRequired.Visible = False
        '
        'lblEmailRequired
        '
        Me.lblEmailRequired.AutoSize = True
        Me.lblEmailRequired.ForeColor = System.Drawing.Color.Red
        Me.lblEmailRequired.Location = New System.Drawing.Point(525, 314)
        Me.lblEmailRequired.Name = "lblEmailRequired"
        Me.lblEmailRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblEmailRequired.TabIndex = 79
        Me.lblEmailRequired.Text = "Required"
        Me.lblEmailRequired.Visible = False
        '
        'lblContactNumRequired
        '
        Me.lblContactNumRequired.AutoSize = True
        Me.lblContactNumRequired.ForeColor = System.Drawing.Color.Red
        Me.lblContactNumRequired.Location = New System.Drawing.Point(525, 277)
        Me.lblContactNumRequired.Name = "lblContactNumRequired"
        Me.lblContactNumRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblContactNumRequired.TabIndex = 80
        Me.lblContactNumRequired.Text = "Required"
        Me.lblContactNumRequired.Visible = False
        '
        'lblAddrRequired
        '
        Me.lblAddrRequired.AutoSize = True
        Me.lblAddrRequired.ForeColor = System.Drawing.Color.Red
        Me.lblAddrRequired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAddrRequired.Location = New System.Drawing.Point(525, 136)
        Me.lblAddrRequired.Name = "lblAddrRequired"
        Me.lblAddrRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblAddrRequired.TabIndex = 84
        Me.lblAddrRequired.Text = "Required"
        Me.lblAddrRequired.Visible = False
        '
        'lblFNameRequired
        '
        Me.lblFNameRequired.AutoSize = True
        Me.lblFNameRequired.ForeColor = System.Drawing.Color.Red
        Me.lblFNameRequired.Location = New System.Drawing.Point(525, 98)
        Me.lblFNameRequired.Name = "lblFNameRequired"
        Me.lblFNameRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblFNameRequired.TabIndex = 85
        Me.lblFNameRequired.Text = "Required"
        Me.lblFNameRequired.Visible = False
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(215, 201)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(307, 20)
        Me.txtAge.TabIndex = 88
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(186, 204)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 87
        Me.lblAge.Text = "Age"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(322, 610)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 89
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbloldpass
        '
        Me.lbloldpass.AutoSize = True
        Me.lbloldpass.Location = New System.Drawing.Point(140, 490)
        Me.lbloldpass.Name = "lbloldpass"
        Me.lbloldpass.Size = New System.Drawing.Size(72, 13)
        Me.lbloldpass.TabIndex = 56
        Me.lbloldpass.Text = "Old Password"
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(215, 487)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtOldPass.Size = New System.Drawing.Size(307, 20)
        Me.txtOldPass.TabIndex = 57
        '
        'hideoldpass
        '
        Me.hideoldpass.Image = CType(resources.GetObject("hideoldpass.Image"), System.Drawing.Image)
        Me.hideoldpass.Location = New System.Drawing.Point(528, 487)
        Me.hideoldpass.Name = "hideoldpass"
        Me.hideoldpass.Size = New System.Drawing.Size(19, 20)
        Me.hideoldpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hideoldpass.TabIndex = 65
        Me.hideoldpass.TabStop = False
        Me.hideoldpass.Visible = False
        '
        'seeoldpass
        '
        Me.seeoldpass.Image = CType(resources.GetObject("seeoldpass.Image"), System.Drawing.Image)
        Me.seeoldpass.Location = New System.Drawing.Point(528, 487)
        Me.seeoldpass.Name = "seeoldpass"
        Me.seeoldpass.Size = New System.Drawing.Size(19, 20)
        Me.seeoldpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.seeoldpass.TabIndex = 64
        Me.seeoldpass.TabStop = False
        '
        'lbloldpasswordrequired
        '
        Me.lbloldpasswordrequired.AutoSize = True
        Me.lbloldpasswordrequired.ForeColor = System.Drawing.Color.Red
        Me.lbloldpasswordrequired.Location = New System.Drawing.Point(553, 490)
        Me.lbloldpasswordrequired.Name = "lbloldpasswordrequired"
        Me.lbloldpasswordrequired.Size = New System.Drawing.Size(50, 13)
        Me.lbloldpasswordrequired.TabIndex = 76
        Me.lbloldpasswordrequired.Text = "Required"
        Me.lbloldpasswordrequired.Visible = False
        '
        'lbloldpasswordrequired2
        '
        Me.lbloldpasswordrequired2.AutoSize = True
        Me.lbloldpasswordrequired2.ForeColor = System.Drawing.Color.Red
        Me.lbloldpasswordrequired2.Location = New System.Drawing.Point(628, 490)
        Me.lbloldpasswordrequired2.Name = "lbloldpasswordrequired2"
        Me.lbloldpasswordrequired2.Size = New System.Drawing.Size(84, 13)
        Me.lbloldpasswordrequired2.TabIndex = 86
        Me.lbloldpasswordrequired2.Text = "pw requirements"
        Me.lbloldpasswordrequired2.Visible = False
        '
        'profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 667)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lbloldpasswordrequired2)
        Me.Controls.Add(Me.lblPassRequirements)
        Me.Controls.Add(Me.lblPassword2Required)
        Me.Controls.Add(Me.lbloldpasswordrequired)
        Me.Controls.Add(Me.lblPasswordRequired)
        Me.Controls.Add(Me.lblContactNum2Required)
        Me.Controls.Add(Me.lblECPRequired)
        Me.Controls.Add(Me.lblEmailRequired)
        Me.Controls.Add(Me.lblContactNumRequired)
        Me.Controls.Add(Me.lblAddrRequired)
        Me.Controls.Add(Me.lblFNameRequired)
        Me.Controls.Add(Me.showPassword2)
        Me.Controls.Add(Me.seeoldpass)
        Me.Controls.Add(Me.hidePassword2)
        Me.Controls.Add(Me.hideoldpass)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.hidePassword)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtReTypePassword)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.lblReTypePassword)
        Me.Controls.Add(Me.lbloldpass)
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
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.lblFullName)
        Me.Name = "profile"
        Me.Text = "profile"
        CType(Me.showPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showPassword2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidePassword2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hideoldpass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seeoldpass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtReTypePassword As TextBox
    Friend WithEvents lblReTypePassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtContactNumber2 As TextBox
    Friend WithEvents lblContactNumber2 As Label
    Friend WithEvents txtEmergencyContactPerson As TextBox
    Friend WithEvents lblEmergencyContactPerson As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents showPassword As PictureBox
    Friend WithEvents hidePassword As PictureBox
    Friend WithEvents showPassword2 As PictureBox
    Friend WithEvents hidePassword2 As PictureBox
    Friend WithEvents lblPassRequirements As Label
    Friend WithEvents lblPassword2Required As Label
    Friend WithEvents lblPasswordRequired As Label
    Friend WithEvents lblContactNum2Required As Label
    Friend WithEvents lblECPRequired As Label
    Friend WithEvents lblEmailRequired As Label
    Friend WithEvents lblContactNumRequired As Label
    Friend WithEvents lblAddrRequired As Label
    Friend WithEvents lblFNameRequired As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lbloldpass As Label
    Friend WithEvents txtOldPass As TextBox
    Friend WithEvents hideoldpass As PictureBox
    Friend WithEvents seeoldpass As PictureBox
    Friend WithEvents lbloldpasswordrequired As Label
    Friend WithEvents lbloldpasswordrequired2 As Label
End Class
