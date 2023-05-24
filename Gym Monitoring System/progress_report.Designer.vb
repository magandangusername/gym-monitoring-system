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
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.txtFullname = New System.Windows.Forms.TextBox()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtWeightLost = New System.Windows.Forms.TextBox()
        Me.lblWeightLost = New System.Windows.Forms.Label()
        Me.lblRecommendation = New System.Windows.Forms.Label()
        Me.rtbRecommendation = New System.Windows.Forms.RichTextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtBmi = New System.Windows.Forms.TextBox()
        Me.lblBmi = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnRecommendation = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(937, 23)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(138, 23)
        Me.btnReport.TabIndex = 24
        Me.btnReport.Text = "Progress Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(1096, 23)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(75, 23)
        Me.btnProfile.TabIndex = 23
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(1188, 23)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnlogout.TabIndex = 22
        Me.btnlogout.Text = "Log out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(557, 433)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(307, 20)
        Me.txtFullname.TabIndex = 36
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(478, 436)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(82, 13)
        Me.lblDate.TabIndex = 35
        Me.lblDate.Text = "Date of Session"
        '
        'txtSubscription
        '
        Me.txtSubscription.Location = New System.Drawing.Point(152, 135)
        Me.txtSubscription.Name = "txtSubscription"
        Me.txtSubscription.Size = New System.Drawing.Size(307, 20)
        Me.txtSubscription.TabIndex = 38
        '
        'lblSubscription
        '
        Me.lblSubscription.AutoSize = True
        Me.lblSubscription.Location = New System.Drawing.Point(86, 138)
        Me.lblSubscription.Name = "lblSubscription"
        Me.lblSubscription.Size = New System.Drawing.Size(65, 13)
        Me.lblSubscription.TabIndex = 37
        Me.lblSubscription.Text = "Subscription"
        '
        'txtEndSub
        '
        Me.txtEndSub.Location = New System.Drawing.Point(152, 161)
        Me.txtEndSub.Name = "txtEndSub"
        Me.txtEndSub.Size = New System.Drawing.Size(307, 20)
        Me.txtEndSub.TabIndex = 40
        '
        'lblEndSub
        '
        Me.lblEndSub.AutoSize = True
        Me.lblEndSub.Location = New System.Drawing.Point(35, 164)
        Me.lblEndSub.Name = "lblEndSub"
        Me.lblEndSub.Size = New System.Drawing.Size(116, 13)
        Me.lblEndSub.TabIndex = 39
        Me.lblEndSub.Text = "Subscription End Time "
        '
        'txtInitialHeight
        '
        Me.txtInitialHeight.Location = New System.Drawing.Point(152, 187)
        Me.txtInitialHeight.Name = "txtInitialHeight"
        Me.txtInitialHeight.Size = New System.Drawing.Size(307, 20)
        Me.txtInitialHeight.TabIndex = 42
        '
        'lblInitialHeight
        '
        Me.lblInitialHeight.AutoSize = True
        Me.lblInitialHeight.Location = New System.Drawing.Point(42, 190)
        Me.lblInitialHeight.Name = "lblInitialHeight"
        Me.lblInitialHeight.Size = New System.Drawing.Size(109, 13)
        Me.lblInitialHeight.TabIndex = 41
        Me.lblInitialHeight.Text = "Height at Registration"
        '
        'txtInitialWeight
        '
        Me.txtInitialWeight.Location = New System.Drawing.Point(152, 213)
        Me.txtInitialWeight.Name = "txtInitialWeight"
        Me.txtInitialWeight.Size = New System.Drawing.Size(307, 20)
        Me.txtInitialWeight.TabIndex = 44
        '
        'lblInitialWeight
        '
        Me.lblInitialWeight.AutoSize = True
        Me.lblInitialWeight.Location = New System.Drawing.Point(39, 216)
        Me.lblInitialWeight.Name = "lblInitialWeight"
        Me.lblInitialWeight.Size = New System.Drawing.Size(112, 13)
        Me.lblInitialWeight.TabIndex = 43
        Me.lblInitialWeight.Text = "Weight at Registration"
        '
        'txtInitialBmi
        '
        Me.txtInitialBmi.Location = New System.Drawing.Point(152, 239)
        Me.txtInitialBmi.Name = "txtInitialBmi"
        Me.txtInitialBmi.Size = New System.Drawing.Size(307, 20)
        Me.txtInitialBmi.TabIndex = 46
        '
        'lblInitialBmi
        '
        Me.lblInitialBmi.AutoSize = True
        Me.lblInitialBmi.Location = New System.Drawing.Point(54, 242)
        Me.lblInitialBmi.Name = "lblInitialBmi"
        Me.lblInitialBmi.Size = New System.Drawing.Size(97, 13)
        Me.lblInitialBmi.TabIndex = 45
        Me.lblInitialBmi.Text = "BMI at Registration"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(476, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(787, 343)
        Me.DataGridView1.TabIndex = 47
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(557, 459)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(307, 20)
        Me.txtHeight.TabIndex = 49
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(478, 462)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 48
        Me.lblHeight.Text = "Height"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(557, 485)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(307, 20)
        Me.txtWeight.TabIndex = 51
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(478, 488)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 50
        Me.lblWeight.Text = "Weight"
        '
        'txtWeightLost
        '
        Me.txtWeightLost.Location = New System.Drawing.Point(557, 511)
        Me.txtWeightLost.Name = "txtWeightLost"
        Me.txtWeightLost.Size = New System.Drawing.Size(307, 20)
        Me.txtWeightLost.TabIndex = 53
        '
        'lblWeightLost
        '
        Me.lblWeightLost.AutoSize = True
        Me.lblWeightLost.Location = New System.Drawing.Point(478, 514)
        Me.lblWeightLost.Name = "lblWeightLost"
        Me.lblWeightLost.Size = New System.Drawing.Size(64, 13)
        Me.lblWeightLost.TabIndex = 52
        Me.lblWeightLost.Text = "Weight Lost"
        '
        'lblRecommendation
        '
        Me.lblRecommendation.AutoSize = True
        Me.lblRecommendation.Location = New System.Drawing.Point(886, 476)
        Me.lblRecommendation.Name = "lblRecommendation"
        Me.lblRecommendation.Size = New System.Drawing.Size(90, 13)
        Me.lblRecommendation.TabIndex = 54
        Me.lblRecommendation.Text = "Recommendation"
        '
        'rtbRecommendation
        '
        Me.rtbRecommendation.Location = New System.Drawing.Point(982, 473)
        Me.rtbRecommendation.Name = "rtbRecommendation"
        Me.rtbRecommendation.Size = New System.Drawing.Size(281, 54)
        Me.rtbRecommendation.TabIndex = 55
        Me.rtbRecommendation.Text = ""
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(982, 433)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(281, 20)
        Me.txtRemarks.TabIndex = 57
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(927, 436)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 13)
        Me.lblRemarks.TabIndex = 56
        Me.lblRemarks.Text = "Remarks"
        '
        'txtBmi
        '
        Me.txtBmi.Location = New System.Drawing.Point(557, 545)
        Me.txtBmi.Name = "txtBmi"
        Me.txtBmi.Size = New System.Drawing.Size(307, 20)
        Me.txtBmi.TabIndex = 59
        '
        'lblBmi
        '
        Me.lblBmi.AutoSize = True
        Me.lblBmi.Location = New System.Drawing.Point(478, 545)
        Me.lblBmi.Name = "lblBmi"
        Me.lblBmi.Size = New System.Drawing.Size(26, 13)
        Me.lblBmi.TabIndex = 58
        Me.lblBmi.Text = "BMI"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(38, 282)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(421, 321)
        Me.ListView1.TabIndex = 60
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 109)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(307, 20)
        Me.txtName.TabIndex = 62
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(100, 109)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 13)
        Me.lblName.TabIndex = 61
        Me.lblName.Text = "FullName"
        '
        'btnRecommendation
        '
        Me.btnRecommendation.Location = New System.Drawing.Point(1031, 562)
        Me.btnRecommendation.Name = "btnRecommendation"
        Me.btnRecommendation.Size = New System.Drawing.Size(199, 23)
        Me.btnRecommendation.TabIndex = 63
        Me.btnRecommendation.Text = "Generate Recommendation"
        Me.btnRecommendation.UseVisualStyleBackColor = True
        '
        'progress_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 631)
        Me.Controls.Add(Me.btnRecommendation)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtBmi)
        Me.Controls.Add(Me.lblBmi)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.rtbRecommendation)
        Me.Controls.Add(Me.lblRecommendation)
        Me.Controls.Add(Me.txtWeightLost)
        Me.Controls.Add(Me.lblWeightLost)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnlogout)
        Me.Name = "progress_report"
        Me.Text = "progress_report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReport As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents txtFullname As TextBox
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtWeightLost As TextBox
    Friend WithEvents lblWeightLost As Label
    Friend WithEvents lblRecommendation As Label
    Friend WithEvents rtbRecommendation As RichTextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtBmi As TextBox
    Friend WithEvents lblBmi As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnRecommendation As Button
End Class
