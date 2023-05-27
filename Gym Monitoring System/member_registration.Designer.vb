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
        Me.medCon = New System.Windows.Forms.RichTextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.showPassword = New System.Windows.Forms.PictureBox()
        Me.hidePassword = New System.Windows.Forms.PictureBox()
        Me.showPassword2 = New System.Windows.Forms.PictureBox()
        Me.hidePassword2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFNameRequired = New System.Windows.Forms.Label()
        Me.lblAddrRequired = New System.Windows.Forms.Label()
        Me.lblBirthdayRequired = New System.Windows.Forms.Label()
        Me.lblAgeRequired = New System.Windows.Forms.Label()
        Me.lblGenderRequired = New System.Windows.Forms.Label()
        Me.lblContactNumRequired = New System.Windows.Forms.Label()
        Me.lblEmailRequired = New System.Windows.Forms.Label()
        Me.lblECPRequired = New System.Windows.Forms.Label()
        Me.lblContactNum2Required = New System.Windows.Forms.Label()
        Me.lblPasswordRequired = New System.Windows.Forms.Label()
        Me.lblPassword2Required = New System.Windows.Forms.Label()
        Me.lblPassRequirements = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.showPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showPassword2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidePassword2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.Cyan
        Me.lblFullName.Location = New System.Drawing.Point(122, 165)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(72, 13)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name"
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(200, 161)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(307, 20)
        Me.txtFullname.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(200, 193)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(307, 20)
        Me.txtAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Cyan
        Me.lblAddress.Location = New System.Drawing.Point(133, 197)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.ForeColor = System.Drawing.Color.Cyan
        Me.lblBirthday.Location = New System.Drawing.Point(130, 228)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(64, 13)
        Me.lblBirthday.TabIndex = 4
        Me.lblBirthday.Text = "Birthday"
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(200, 225)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(200, 20)
        Me.dtpBirthday.TabIndex = 5
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Cyan
        Me.lblAge.Location = New System.Drawing.Point(163, 258)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(31, 13)
        Me.lblAge.TabIndex = 6
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(200, 255)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(200, 20)
        Me.txtAge.TabIndex = 7
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Cyan
        Me.lblGender.Location = New System.Drawing.Point(140, 296)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(54, 13)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Checked = True
        Me.rdbMale.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.ForeColor = System.Drawing.Color.Cyan
        Me.rdbMale.Location = New System.Drawing.Point(6, 15)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(57, 17)
        Me.rdbMale.TabIndex = 9
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.ForeColor = System.Drawing.Color.Cyan
        Me.rdbFemale.Location = New System.Drawing.Point(110, 15)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(70, 17)
        Me.rdbFemale.TabIndex = 10
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(200, 326)
        Me.txtContactNumber.MaxLength = 11
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(307, 20)
        Me.txtContactNumber.TabIndex = 12
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.Cyan
        Me.lblContactNumber.Location = New System.Drawing.Point(82, 328)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(112, 13)
        Me.lblContactNumber.TabIndex = 11
        Me.lblContactNumber.Text = "Contact Number"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(200, 355)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(307, 20)
        Me.txtEmail.TabIndex = 14
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Cyan
        Me.lblEmail.Location = New System.Drawing.Point(153, 357)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 13)
        Me.lblEmail.TabIndex = 13
        Me.lblEmail.Text = "Email"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(545, 260)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(99, 20)
        Me.txtHeight.TabIndex = 16
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.Cyan
        Me.lblHeight.Location = New System.Drawing.Point(491, 263)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(48, 13)
        Me.lblHeight.TabIndex = 15
        Me.lblHeight.Text = "Height"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(545, 296)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(99, 20)
        Me.txtWeight.TabIndex = 18
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.Cyan
        Me.lblWeight.Location = New System.Drawing.Point(490, 298)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(51, 13)
        Me.lblWeight.TabIndex = 17
        Me.lblWeight.Text = "Weight"
        '
        'txtContactNumber2
        '
        Me.txtContactNumber2.Location = New System.Drawing.Point(200, 414)
        Me.txtContactNumber2.MaxLength = 11
        Me.txtContactNumber2.Name = "txtContactNumber2"
        Me.txtContactNumber2.Size = New System.Drawing.Size(307, 20)
        Me.txtContactNumber2.TabIndex = 22
        '
        'lblContactNumber2
        '
        Me.lblContactNumber2.AutoSize = True
        Me.lblContactNumber2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber2.ForeColor = System.Drawing.Color.Cyan
        Me.lblContactNumber2.Location = New System.Drawing.Point(84, 416)
        Me.lblContactNumber2.Name = "lblContactNumber2"
        Me.lblContactNumber2.Size = New System.Drawing.Size(112, 13)
        Me.lblContactNumber2.TabIndex = 21
        Me.lblContactNumber2.Text = "Contact Number"
        '
        'txtEmergencyContactPerson
        '
        Me.txtEmergencyContactPerson.Location = New System.Drawing.Point(200, 384)
        Me.txtEmergencyContactPerson.Name = "txtEmergencyContactPerson"
        Me.txtEmergencyContactPerson.Size = New System.Drawing.Size(307, 20)
        Me.txtEmergencyContactPerson.TabIndex = 20
        '
        'lblEmergencyContactPerson
        '
        Me.lblEmergencyContactPerson.AutoSize = True
        Me.lblEmergencyContactPerson.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergencyContactPerson.ForeColor = System.Drawing.Color.Cyan
        Me.lblEmergencyContactPerson.Location = New System.Drawing.Point(12, 386)
        Me.lblEmergencyContactPerson.Name = "lblEmergencyContactPerson"
        Me.lblEmergencyContactPerson.Size = New System.Drawing.Size(182, 13)
        Me.lblEmergencyContactPerson.TabIndex = 19
        Me.lblEmergencyContactPerson.Text = "Emergency Contact Person"
        '
        'txtReTypePassword
        '
        Me.txtReTypePassword.Location = New System.Drawing.Point(200, 477)
        Me.txtReTypePassword.Name = "txtReTypePassword"
        Me.txtReTypePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtReTypePassword.Size = New System.Drawing.Size(307, 20)
        Me.txtReTypePassword.TabIndex = 26
        '
        'lblReTypePassword
        '
        Me.lblReTypePassword.AutoSize = True
        Me.lblReTypePassword.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReTypePassword.ForeColor = System.Drawing.Color.Cyan
        Me.lblReTypePassword.Location = New System.Drawing.Point(75, 480)
        Me.lblReTypePassword.Name = "lblReTypePassword"
        Me.lblReTypePassword.Size = New System.Drawing.Size(121, 13)
        Me.lblReTypePassword.TabIndex = 25
        Me.lblReTypePassword.Text = "Re-Type Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(200, 445)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(307, 20)
        Me.txtPassword.TabIndex = 24
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Cyan
        Me.lblPassword.Location = New System.Drawing.Point(123, 447)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(72, 13)
        Me.lblPassword.TabIndex = 23
        Me.lblPassword.Text = "Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Cyan
        Me.Label14.Location = New System.Drawing.Point(42, 507)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Any Medical Condition?"
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Checked = True
        Me.rdbNo.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNo.ForeColor = System.Drawing.Color.Cyan
        Me.rdbNo.Location = New System.Drawing.Point(263, 505)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(43, 17)
        Me.rdbNo.TabIndex = 29
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbYes
        '
        Me.rdbYes.AutoSize = True
        Me.rdbYes.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbYes.ForeColor = System.Drawing.Color.Cyan
        Me.rdbYes.Location = New System.Drawing.Point(205, 505)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(47, 17)
        Me.rdbYes.TabIndex = 28
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes"
        Me.rdbYes.UseVisualStyleBackColor = True
        '
        'medCon
        '
        Me.medCon.Location = New System.Drawing.Point(202, 526)
        Me.medCon.Name = "medCon"
        Me.medCon.Size = New System.Drawing.Size(307, 96)
        Me.medCon.TabIndex = 30
        Me.medCon.Text = ""
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(353, 669)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(93, 23)
        Me.btnRegister.TabIndex = 31
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(253, 669)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "  Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(650, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "CM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(650, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "KG"
        '
        'showPassword
        '
        Me.showPassword.Image = CType(resources.GetObject("showPassword.Image"), System.Drawing.Image)
        Me.showPassword.Location = New System.Drawing.Point(511, 445)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(19, 20)
        Me.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showPassword.TabIndex = 68
        Me.showPassword.TabStop = False
        '
        'hidePassword
        '
        Me.hidePassword.Image = CType(resources.GetObject("hidePassword.Image"), System.Drawing.Image)
        Me.hidePassword.Location = New System.Drawing.Point(511, 445)
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
        Me.showPassword2.Location = New System.Drawing.Point(511, 477)
        Me.showPassword2.Name = "showPassword2"
        Me.showPassword2.Size = New System.Drawing.Size(19, 20)
        Me.showPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showPassword2.TabIndex = 70
        Me.showPassword2.TabStop = False
        '
        'hidePassword2
        '
        Me.hidePassword2.Image = CType(resources.GetObject("hidePassword2.Image"), System.Drawing.Image)
        Me.hidePassword2.Location = New System.Drawing.Point(511, 477)
        Me.hidePassword2.Name = "hidePassword2"
        Me.hidePassword2.Size = New System.Drawing.Size(19, 20)
        Me.hidePassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidePassword2.TabIndex = 71
        Me.hidePassword2.TabStop = False
        Me.hidePassword2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbMale)
        Me.GroupBox1.Controls.Add(Me.rdbFemale)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(200, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 38)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'lblFNameRequired
        '
        Me.lblFNameRequired.AutoSize = True
        Me.lblFNameRequired.ForeColor = System.Drawing.Color.Red
        Me.lblFNameRequired.Location = New System.Drawing.Point(511, 164)
        Me.lblFNameRequired.Name = "lblFNameRequired"
        Me.lblFNameRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblFNameRequired.TabIndex = 73
        Me.lblFNameRequired.Text = "Required"
        Me.lblFNameRequired.Visible = False
        '
        'lblAddrRequired
        '
        Me.lblAddrRequired.AutoSize = True
        Me.lblAddrRequired.ForeColor = System.Drawing.Color.Red
        Me.lblAddrRequired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAddrRequired.Location = New System.Drawing.Point(513, 196)
        Me.lblAddrRequired.Name = "lblAddrRequired"
        Me.lblAddrRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblAddrRequired.TabIndex = 73
        Me.lblAddrRequired.Text = "Required"
        Me.lblAddrRequired.Visible = False
        '
        'lblBirthdayRequired
        '
        Me.lblBirthdayRequired.AutoSize = True
        Me.lblBirthdayRequired.ForeColor = System.Drawing.Color.Red
        Me.lblBirthdayRequired.Location = New System.Drawing.Point(406, 229)
        Me.lblBirthdayRequired.Name = "lblBirthdayRequired"
        Me.lblBirthdayRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblBirthdayRequired.TabIndex = 73
        Me.lblBirthdayRequired.Text = "Required"
        Me.lblBirthdayRequired.Visible = False
        '
        'lblAgeRequired
        '
        Me.lblAgeRequired.AutoSize = True
        Me.lblAgeRequired.ForeColor = System.Drawing.Color.Red
        Me.lblAgeRequired.Location = New System.Drawing.Point(406, 259)
        Me.lblAgeRequired.Name = "lblAgeRequired"
        Me.lblAgeRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblAgeRequired.TabIndex = 73
        Me.lblAgeRequired.Text = "Required"
        Me.lblAgeRequired.Visible = False
        '
        'lblGenderRequired
        '
        Me.lblGenderRequired.AutoSize = True
        Me.lblGenderRequired.ForeColor = System.Drawing.Color.Red
        Me.lblGenderRequired.Location = New System.Drawing.Point(406, 297)
        Me.lblGenderRequired.Name = "lblGenderRequired"
        Me.lblGenderRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblGenderRequired.TabIndex = 73
        Me.lblGenderRequired.Text = "Required"
        Me.lblGenderRequired.Visible = False
        '
        'lblContactNumRequired
        '
        Me.lblContactNumRequired.AutoSize = True
        Me.lblContactNumRequired.ForeColor = System.Drawing.Color.Red
        Me.lblContactNumRequired.Location = New System.Drawing.Point(513, 330)
        Me.lblContactNumRequired.Name = "lblContactNumRequired"
        Me.lblContactNumRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblContactNumRequired.TabIndex = 73
        Me.lblContactNumRequired.Text = "Required"
        Me.lblContactNumRequired.Visible = False
        '
        'lblEmailRequired
        '
        Me.lblEmailRequired.AutoSize = True
        Me.lblEmailRequired.ForeColor = System.Drawing.Color.Red
        Me.lblEmailRequired.Location = New System.Drawing.Point(514, 359)
        Me.lblEmailRequired.Name = "lblEmailRequired"
        Me.lblEmailRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblEmailRequired.TabIndex = 73
        Me.lblEmailRequired.Text = "Required"
        Me.lblEmailRequired.Visible = False
        '
        'lblECPRequired
        '
        Me.lblECPRequired.AutoSize = True
        Me.lblECPRequired.ForeColor = System.Drawing.Color.Red
        Me.lblECPRequired.Location = New System.Drawing.Point(513, 389)
        Me.lblECPRequired.Name = "lblECPRequired"
        Me.lblECPRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblECPRequired.TabIndex = 73
        Me.lblECPRequired.Text = "Required"
        Me.lblECPRequired.Visible = False
        '
        'lblContactNum2Required
        '
        Me.lblContactNum2Required.AutoSize = True
        Me.lblContactNum2Required.ForeColor = System.Drawing.Color.Red
        Me.lblContactNum2Required.Location = New System.Drawing.Point(513, 417)
        Me.lblContactNum2Required.Name = "lblContactNum2Required"
        Me.lblContactNum2Required.Size = New System.Drawing.Size(50, 13)
        Me.lblContactNum2Required.TabIndex = 73
        Me.lblContactNum2Required.Text = "Required"
        Me.lblContactNum2Required.Visible = False
        '
        'lblPasswordRequired
        '
        Me.lblPasswordRequired.AutoSize = True
        Me.lblPasswordRequired.ForeColor = System.Drawing.Color.Red
        Me.lblPasswordRequired.Location = New System.Drawing.Point(536, 448)
        Me.lblPasswordRequired.Name = "lblPasswordRequired"
        Me.lblPasswordRequired.Size = New System.Drawing.Size(50, 13)
        Me.lblPasswordRequired.TabIndex = 73
        Me.lblPasswordRequired.Text = "Required"
        Me.lblPasswordRequired.Visible = False
        '
        'lblPassword2Required
        '
        Me.lblPassword2Required.AutoSize = True
        Me.lblPassword2Required.ForeColor = System.Drawing.Color.Red
        Me.lblPassword2Required.Location = New System.Drawing.Point(536, 480)
        Me.lblPassword2Required.Name = "lblPassword2Required"
        Me.lblPassword2Required.Size = New System.Drawing.Size(50, 13)
        Me.lblPassword2Required.TabIndex = 73
        Me.lblPassword2Required.Text = "Required"
        Me.lblPassword2Required.Visible = False
        '
        'lblPassRequirements
        '
        Me.lblPassRequirements.AutoSize = True
        Me.lblPassRequirements.ForeColor = System.Drawing.Color.Red
        Me.lblPassRequirements.Location = New System.Drawing.Point(619, 449)
        Me.lblPassRequirements.Name = "lblPassRequirements"
        Me.lblPassRequirements.Size = New System.Drawing.Size(84, 13)
        Me.lblPassRequirements.TabIndex = 74
        Me.lblPassRequirements.Text = "pw requirements"
        Me.lblPassRequirements.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(587, 27)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(91, 87)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 77
        Me.PictureBox6.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(169, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(417, 75)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "GymBros PH"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(77, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'member_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 704)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPassRequirements)
        Me.Controls.Add(Me.lblPassword2Required)
        Me.Controls.Add(Me.lblPasswordRequired)
        Me.Controls.Add(Me.lblContactNum2Required)
        Me.Controls.Add(Me.lblECPRequired)
        Me.Controls.Add(Me.lblEmailRequired)
        Me.Controls.Add(Me.lblContactNumRequired)
        Me.Controls.Add(Me.lblGenderRequired)
        Me.Controls.Add(Me.lblAgeRequired)
        Me.Controls.Add(Me.lblBirthdayRequired)
        Me.Controls.Add(Me.lblAddrRequired)
        Me.Controls.Add(Me.lblFNameRequired)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.showPassword2)
        Me.Controls.Add(Me.hidePassword2)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.hidePassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.medCon)
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
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.lblFullName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "member_registration"
        Me.Text = "member_registration"
        CType(Me.showPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showPassword2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidePassword2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents medCon As RichTextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents showPassword As PictureBox
    Friend WithEvents hidePassword As PictureBox
    Friend WithEvents showPassword2 As PictureBox
    Friend WithEvents hidePassword2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFNameRequired As Label
    Friend WithEvents lblAddrRequired As Label
    Friend WithEvents lblBirthdayRequired As Label
    Friend WithEvents lblAgeRequired As Label
    Friend WithEvents lblGenderRequired As Label
    Friend WithEvents lblContactNumRequired As Label
    Friend WithEvents lblEmailRequired As Label
    Friend WithEvents lblECPRequired As Label
    Friend WithEvents lblContactNum2Required As Label
    Friend WithEvents lblPasswordRequired As Label
    Friend WithEvents lblPassword2Required As Label
    Friend WithEvents lblPassRequirements As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
