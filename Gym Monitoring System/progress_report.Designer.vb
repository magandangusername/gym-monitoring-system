<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class progress_report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.txtSessionDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtSubscription = New System.Windows.Forms.TextBox()
        Me.lblSubscription = New System.Windows.Forms.Label()
        Me.txtEndSub = New System.Windows.Forms.TextBox()
        Me.lblEndSub = New System.Windows.Forms.Label()
        Me.txtInitialHeight = New System.Windows.Forms.TextBox()
        Me.lblInitialHeight = New System.Windows.Forms.Label()
        Me.txtInitialWeight = New System.Windows.Forms.TextBox()
        Me.lblInitialWeight = New System.Windows.Forms.Label()
        Me.txtInitialBmi = New System.Windows.Forms.TextBox()
        Me.lblInitialBmi = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtCaloriesLost = New System.Windows.Forms.TextBox()
        Me.lblCaloriesLost = New System.Windows.Forms.Label()
        Me.lblRecommendation = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtInitialCalories = New System.Windows.Forms.TextBox()
        Me.lblInitialCalories = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnRecommendation = New System.Windows.Forms.Button()
        Me.txtRecommendation = New System.Windows.Forms.TextBox()
        Me.dgvSessions = New System.Windows.Forms.DataGridView()
        Me.dgvActivity = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(1461, 23)
        Me.btnProfile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(100, 23)
        Me.btnProfile.TabIndex = 23
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(1584, 23)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(100, 23)
        Me.btnlogout.TabIndex = 22
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'txtSessionDate
        '
        Me.txtSessionDate.Enabled = False
        Me.txtSessionDate.Location = New System.Drawing.Point(165, 191)
        Me.txtSessionDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSessionDate.Name = "txtSessionDate"
        Me.txtSessionDate.Size = New System.Drawing.Size(301, 20)
        Me.txtSessionDate.TabIndex = 36
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(59, 194)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(106, 13)
        Me.lblDate.TabIndex = 35
        Me.lblDate.Text = "Date of Session"
        '
        'txtSubscription
        '
        Me.txtSubscription.Enabled = False
        Me.txtSubscription.Location = New System.Drawing.Point(165, 59)
        Me.txtSubscription.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSubscription.Name = "txtSubscription"
        Me.txtSubscription.Size = New System.Drawing.Size(301, 20)
        Me.txtSubscription.TabIndex = 38
        '
        'lblSubscription
        '
        Me.lblSubscription.AutoSize = True
        Me.lblSubscription.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubscription.ForeColor = System.Drawing.Color.White
        Me.lblSubscription.Location = New System.Drawing.Point(77, 62)
        Me.lblSubscription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubscription.Name = "lblSubscription"
        Me.lblSubscription.Size = New System.Drawing.Size(88, 13)
        Me.lblSubscription.TabIndex = 37
        Me.lblSubscription.Text = "Subscription"
        '
        'txtEndSub
        '
        Me.txtEndSub.Enabled = False
        Me.txtEndSub.Location = New System.Drawing.Point(165, 85)
        Me.txtEndSub.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEndSub.Name = "txtEndSub"
        Me.txtEndSub.Size = New System.Drawing.Size(301, 20)
        Me.txtEndSub.TabIndex = 40
        '
        'lblEndSub
        '
        Me.lblEndSub.AutoSize = True
        Me.lblEndSub.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSub.ForeColor = System.Drawing.Color.White
        Me.lblEndSub.Location = New System.Drawing.Point(14, 89)
        Me.lblEndSub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndSub.Name = "lblEndSub"
        Me.lblEndSub.Size = New System.Drawing.Size(147, 13)
        Me.lblEndSub.TabIndex = 39
        Me.lblEndSub.Text = "Subscription End Time "
        '
        'txtInitialHeight
        '
        Me.txtInitialHeight.Enabled = False
        Me.txtInitialHeight.Location = New System.Drawing.Point(165, 111)
        Me.txtInitialHeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInitialHeight.Name = "txtInitialHeight"
        Me.txtInitialHeight.Size = New System.Drawing.Size(301, 20)
        Me.txtInitialHeight.TabIndex = 42
        '
        'lblInitialHeight
        '
        Me.lblInitialHeight.AutoSize = True
        Me.lblInitialHeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialHeight.ForeColor = System.Drawing.Color.White
        Me.lblInitialHeight.Location = New System.Drawing.Point(18, 114)
        Me.lblInitialHeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInitialHeight.Name = "lblInitialHeight"
        Me.lblInitialHeight.Size = New System.Drawing.Size(149, 13)
        Me.lblInitialHeight.TabIndex = 41
        Me.lblInitialHeight.Text = "Height at Registration"
        '
        'txtInitialWeight
        '
        Me.txtInitialWeight.Enabled = False
        Me.txtInitialWeight.Location = New System.Drawing.Point(165, 137)
        Me.txtInitialWeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInitialWeight.Name = "txtInitialWeight"
        Me.txtInitialWeight.Size = New System.Drawing.Size(301, 20)
        Me.txtInitialWeight.TabIndex = 44
        '
        'lblInitialWeight
        '
        Me.lblInitialWeight.AutoSize = True
        Me.lblInitialWeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialWeight.ForeColor = System.Drawing.Color.White
        Me.lblInitialWeight.Location = New System.Drawing.Point(14, 140)
        Me.lblInitialWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInitialWeight.Name = "lblInitialWeight"
        Me.lblInitialWeight.Size = New System.Drawing.Size(152, 13)
        Me.lblInitialWeight.TabIndex = 43
        Me.lblInitialWeight.Text = "Weight at Registration"
        '
        'txtInitialBmi
        '
        Me.txtInitialBmi.Enabled = False
        Me.txtInitialBmi.Location = New System.Drawing.Point(165, 163)
        Me.txtInitialBmi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInitialBmi.Name = "txtInitialBmi"
        Me.txtInitialBmi.Size = New System.Drawing.Size(301, 20)
        Me.txtInitialBmi.TabIndex = 46
        '
        'lblInitialBmi
        '
        Me.lblInitialBmi.AutoSize = True
        Me.lblInitialBmi.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialBmi.ForeColor = System.Drawing.Color.White
        Me.lblInitialBmi.Location = New System.Drawing.Point(34, 166)
        Me.lblInitialBmi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInitialBmi.Name = "lblInitialBmi"
        Me.lblInitialBmi.Size = New System.Drawing.Size(132, 13)
        Me.lblInitialBmi.TabIndex = 45
        Me.lblInitialBmi.Text = "BMI at Registration"
        '
        'txtHeight
        '
        Me.txtHeight.Enabled = False
        Me.txtHeight.Location = New System.Drawing.Point(133, 330)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(337, 20)
        Me.txtHeight.TabIndex = 49
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.White
        Me.lblHeight.Location = New System.Drawing.Point(27, 333)
        Me.lblHeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(48, 13)
        Me.lblHeight.TabIndex = 48
        Me.lblHeight.Text = "Height"
        '
        'txtWeight
        '
        Me.txtWeight.Enabled = False
        Me.txtWeight.Location = New System.Drawing.Point(133, 356)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(337, 20)
        Me.txtWeight.TabIndex = 51
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.White
        Me.lblWeight.Location = New System.Drawing.Point(27, 359)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(51, 13)
        Me.lblWeight.TabIndex = 50
        Me.lblWeight.Text = "Weight"
        '
        'txtCaloriesLost
        '
        Me.txtCaloriesLost.Enabled = False
        Me.txtCaloriesLost.Location = New System.Drawing.Point(165, 243)
        Me.txtCaloriesLost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCaloriesLost.Name = "txtCaloriesLost"
        Me.txtCaloriesLost.Size = New System.Drawing.Size(301, 20)
        Me.txtCaloriesLost.TabIndex = 53
        '
        'lblCaloriesLost
        '
        Me.lblCaloriesLost.AutoSize = True
        Me.lblCaloriesLost.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaloriesLost.ForeColor = System.Drawing.Color.White
        Me.lblCaloriesLost.Location = New System.Drawing.Point(5, 246)
        Me.lblCaloriesLost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaloriesLost.Name = "lblCaloriesLost"
        Me.lblCaloriesLost.Size = New System.Drawing.Size(156, 13)
        Me.lblCaloriesLost.TabIndex = 52
        Me.lblCaloriesLost.Text = "Calories Count Burned"
        '
        'lblRecommendation
        '
        Me.lblRecommendation.AutoSize = True
        Me.lblRecommendation.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecommendation.ForeColor = System.Drawing.Color.White
        Me.lblRecommendation.Location = New System.Drawing.Point(27, 425)
        Me.lblRecommendation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecommendation.Name = "lblRecommendation"
        Me.lblRecommendation.Size = New System.Drawing.Size(113, 13)
        Me.lblRecommendation.TabIndex = 54
        Me.lblRecommendation.Text = "Recommendation"
        '
        'txtRemarks
        '
        Me.txtRemarks.Enabled = False
        Me.txtRemarks.Location = New System.Drawing.Point(98, 382)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(372, 20)
        Me.txtRemarks.TabIndex = 57
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.ForeColor = System.Drawing.Color.White
        Me.lblRemarks.Location = New System.Drawing.Point(27, 386)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(63, 13)
        Me.lblRemarks.TabIndex = 56
        Me.lblRemarks.Text = "Remarks"
        '
        'txtInitialCalories
        '
        Me.txtInitialCalories.Enabled = False
        Me.txtInitialCalories.Location = New System.Drawing.Point(165, 217)
        Me.txtInitialCalories.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInitialCalories.Name = "txtInitialCalories"
        Me.txtInitialCalories.Size = New System.Drawing.Size(301, 20)
        Me.txtInitialCalories.TabIndex = 59
        '
        'lblInitialCalories
        '
        Me.lblInitialCalories.AutoSize = True
        Me.lblInitialCalories.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialCalories.ForeColor = System.Drawing.Color.White
        Me.lblInitialCalories.Location = New System.Drawing.Point(59, 220)
        Me.lblInitialCalories.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInitialCalories.Name = "lblInitialCalories"
        Me.lblInitialCalories.Size = New System.Drawing.Size(104, 13)
        Me.lblInitialCalories.TabIndex = 58
        Me.lblInitialCalories.Text = "Initial Calories"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(165, 33)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(301, 20)
        Me.txtName.TabIndex = 62
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(95, 33)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 13)
        Me.lblName.TabIndex = 61
        Me.lblName.Text = "FullName"
        '
        'btnRecommendation
        '
        Me.btnRecommendation.Location = New System.Drawing.Point(1375, 562)
        Me.btnRecommendation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRecommendation.Name = "btnRecommendation"
        Me.btnRecommendation.Size = New System.Drawing.Size(265, 23)
        Me.btnRecommendation.TabIndex = 63
        Me.btnRecommendation.Text = "Generate Recommendation"
        Me.btnRecommendation.UseVisualStyleBackColor = True
        '
        'txtRecommendation
        '
        Me.txtRecommendation.Enabled = False
        Me.txtRecommendation.Location = New System.Drawing.Point(30, 445)
        Me.txtRecommendation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRecommendation.Multiline = True
        Me.txtRecommendation.Name = "txtRecommendation"
        Me.txtRecommendation.Size = New System.Drawing.Size(440, 69)
        Me.txtRecommendation.TabIndex = 64
        '
        'dgvSessions
        '
        Me.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSessions.Location = New System.Drawing.Point(498, 33)
        Me.dgvSessions.Name = "dgvSessions"
        Me.dgvSessions.Size = New System.Drawing.Size(846, 226)
        Me.dgvSessions.TabIndex = 65
        '
        'dgvActivity
        '
        Me.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivity.Location = New System.Drawing.Point(498, 288)
        Me.dgvActivity.Name = "dgvActivity"
        Me.dgvActivity.Size = New System.Drawing.Size(846, 226)
        Me.dgvActivity.TabIndex = 65
        '
        'progress_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 558)
        Me.Controls.Add(Me.dgvActivity)
        Me.Controls.Add(Me.dgvSessions)
        Me.Controls.Add(Me.txtRecommendation)
        Me.Controls.Add(Me.btnRecommendation)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtInitialCalories)
        Me.Controls.Add(Me.lblInitialCalories)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.lblRecommendation)
        Me.Controls.Add(Me.txtCaloriesLost)
        Me.Controls.Add(Me.lblCaloriesLost)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtInitialBmi)
        Me.Controls.Add(Me.lblInitialBmi)
        Me.Controls.Add(Me.txtInitialWeight)
        Me.Controls.Add(Me.lblInitialWeight)
        Me.Controls.Add(Me.txtInitialHeight)
        Me.Controls.Add(Me.lblInitialHeight)
        Me.Controls.Add(Me.txtEndSub)
        Me.Controls.Add(Me.lblEndSub)
        Me.Controls.Add(Me.txtSubscription)
        Me.Controls.Add(Me.lblSubscription)
        Me.Controls.Add(Me.txtSessionDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnlogout)
        Me.Enabled = False
        Me.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "progress_report"
        Me.Text = "progress_report"
        CType(Me.dgvSessions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents txtSessionDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtSubscription As TextBox
    Friend WithEvents lblSubscription As Label
    Friend WithEvents txtEndSub As TextBox
    Friend WithEvents lblEndSub As Label
    Friend WithEvents txtInitialHeight As TextBox
    Friend WithEvents lblInitialHeight As Label
    Friend WithEvents txtInitialWeight As TextBox
    Friend WithEvents lblInitialWeight As Label
    Friend WithEvents txtInitialBmi As TextBox
    Friend WithEvents lblInitialBmi As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtCaloriesLost As TextBox
    Friend WithEvents lblCaloriesLost As Label
    Friend WithEvents lblRecommendation As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtInitialCalories As TextBox
    Friend WithEvents lblInitialCalories As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnRecommendation As Button
    Friend WithEvents txtRecommendation As TextBox
    Friend WithEvents dgvSessions As DataGridView
    Friend WithEvents dgvActivity As DataGridView
End Class
