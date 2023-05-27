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
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtBmi = New System.Windows.Forms.TextBox()
        Me.lblBmi = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnRecommendation = New System.Windows.Forms.Button()
        Me.txtRecommendation = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(1033, 30)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(184, 23)
        Me.btnReport.TabIndex = 24
        Me.btnReport.Text = "Progress Report"
        Me.btnReport.UseVisualStyleBackColor = True
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
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(580, 444)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(337, 20)
        Me.txtFullname.TabIndex = 36
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(474, 447)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(106, 13)
        Me.lblDate.TabIndex = 35
        Me.lblDate.Text = "Date of Session"
        '
        'txtSubscription
        '
        Me.txtSubscription.Location = New System.Drawing.Point(159, 97)
        Me.txtSubscription.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSubscription.Name = "txtSubscription"
        Me.txtSubscription.Size = New System.Drawing.Size(301, 20)
        Me.txtSubscription.TabIndex = 38
        '
        'lblSubscription
        '
        Me.lblSubscription.AutoSize = True
        Me.lblSubscription.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubscription.Location = New System.Drawing.Point(71, 100)
        Me.lblSubscription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubscription.Name = "lblSubscription"
        Me.lblSubscription.Size = New System.Drawing.Size(88, 13)
        Me.lblSubscription.TabIndex = 37
        Me.lblSubscription.Text = "Subscription"
        '
        'txtEndSub
        '
        Me.txtEndSub.Location = New System.Drawing.Point(159, 123)
        Me.txtEndSub.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEndSub.Name = "txtEndSub"
        Me.txtEndSub.Size = New System.Drawing.Size(301, 20)
        Me.txtEndSub.TabIndex = 40
        '
        'lblEndSub
        '
        Me.lblEndSub.AutoSize = True
        Me.lblEndSub.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndSub.Location = New System.Drawing.Point(8, 127)
        Me.lblEndSub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndSub.Name = "lblEndSub"
        Me.lblEndSub.Size = New System.Drawing.Size(147, 13)
        Me.lblEndSub.TabIndex = 39
        Me.lblEndSub.Text = "Subscription End Time "
        '
        'txtInitialHeight
        '
        Me.txtInitialHeight.Location = New System.Drawing.Point(159, 149)
        Me.txtInitialHeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInitialHeight.Name = "txtInitialHeight"
        Me.txtInitialHeight.Size = New System.Drawing.Size(301, 20)
        Me.txtInitialHeight.TabIndex = 42
        '
        'lblInitialHeight
        '
        Me.lblInitialHeight.AutoSize = True
        Me.lblInitialHeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialHeight.Location = New System.Drawing.Point(12, 152)
        Me.lblInitialHeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInitialHeight.Name = "lblInitialHeight"
        Me.lblInitialHeight.Size = New System.Drawing.Size(149, 13)
        Me.lblInitialHeight.TabIndex = 41
        Me.lblInitialHeight.Text = "Height at Registration"
        '
        'txtInitialWeight
        '
        Me.txtInitialWeight.Location = New System.Drawing.Point(159, 175)
        Me.txtInitialWeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInitialWeight.Name = "txtInitialWeight"
        Me.txtInitialWeight.Size = New System.Drawing.Size(301, 20)
        Me.txtInitialWeight.TabIndex = 44
        '
        'lblInitialWeight
        '
        Me.lblInitialWeight.AutoSize = True
        Me.lblInitialWeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialWeight.Location = New System.Drawing.Point(8, 178)
        Me.lblInitialWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInitialWeight.Name = "lblInitialWeight"
        Me.lblInitialWeight.Size = New System.Drawing.Size(152, 13)
        Me.lblInitialWeight.TabIndex = 43
        Me.lblInitialWeight.Text = "Weight at Registration"
        '
        'txtInitialBmi
        '
        Me.txtInitialBmi.Location = New System.Drawing.Point(159, 201)
        Me.txtInitialBmi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInitialBmi.Name = "txtInitialBmi"
        Me.txtInitialBmi.Size = New System.Drawing.Size(301, 20)
        Me.txtInitialBmi.TabIndex = 46
        '
        'lblInitialBmi
        '
        Me.lblInitialBmi.AutoSize = True
        Me.lblInitialBmi.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialBmi.Location = New System.Drawing.Point(28, 204)
        Me.lblInitialBmi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInitialBmi.Name = "lblInitialBmi"
        Me.lblInitialBmi.Size = New System.Drawing.Size(132, 13)
        Me.lblInitialBmi.TabIndex = 45
        Me.lblInitialBmi.Text = "BMI at Registration"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(468, 71)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(853, 343)
        Me.DataGridView1.TabIndex = 47
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(580, 470)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(337, 20)
        Me.txtHeight.TabIndex = 49
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(474, 473)
        Me.lblHeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(48, 13)
        Me.lblHeight.TabIndex = 48
        Me.lblHeight.Text = "Height"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(580, 496)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(337, 20)
        Me.txtWeight.TabIndex = 51
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(474, 499)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(51, 13)
        Me.lblWeight.TabIndex = 50
        Me.lblWeight.Text = "Weight"
        '
        'txtWeightLost
        '
        Me.txtWeightLost.Location = New System.Drawing.Point(580, 522)
        Me.txtWeightLost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWeightLost.Name = "txtWeightLost"
        Me.txtWeightLost.Size = New System.Drawing.Size(337, 20)
        Me.txtWeightLost.TabIndex = 53
        '
        'lblWeightLost
        '
        Me.lblWeightLost.AutoSize = True
        Me.lblWeightLost.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightLost.Location = New System.Drawing.Point(474, 525)
        Me.lblWeightLost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeightLost.Name = "lblWeightLost"
        Me.lblWeightLost.Size = New System.Drawing.Size(83, 13)
        Me.lblWeightLost.TabIndex = 52
        Me.lblWeightLost.Text = "Weight Lost"
        '
        'lblRecommendation
        '
        Me.lblRecommendation.AutoSize = True
        Me.lblRecommendation.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecommendation.Location = New System.Drawing.Point(945, 487)
        Me.lblRecommendation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecommendation.Name = "lblRecommendation"
        Me.lblRecommendation.Size = New System.Drawing.Size(113, 13)
        Me.lblRecommendation.TabIndex = 54
        Me.lblRecommendation.Text = "Recommendation"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(1016, 444)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(305, 20)
        Me.txtRemarks.TabIndex = 57
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(945, 448)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(63, 13)
        Me.lblRemarks.TabIndex = 56
        Me.lblRemarks.Text = "Remarks"
        '
        'txtBmi
        '
        Me.txtBmi.Location = New System.Drawing.Point(580, 556)
        Me.txtBmi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBmi.Name = "txtBmi"
        Me.txtBmi.Size = New System.Drawing.Size(337, 20)
        Me.txtBmi.TabIndex = 59
        '
        'lblBmi
        '
        Me.lblBmi.AutoSize = True
        Me.lblBmi.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBmi.Location = New System.Drawing.Point(474, 556)
        Me.lblBmi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBmi.Name = "lblBmi"
        Me.lblBmi.Size = New System.Drawing.Size(31, 13)
        Me.lblBmi.TabIndex = 58
        Me.lblBmi.Text = "BMI"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(31, 237)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(429, 339)
        Me.ListView1.TabIndex = 60
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(159, 71)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(301, 20)
        Me.txtName.TabIndex = 62
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(89, 71)
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
        Me.txtRecommendation.Location = New System.Drawing.Point(948, 507)
        Me.txtRecommendation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRecommendation.Multiline = True
        Me.txtRecommendation.Name = "txtRecommendation"
        Me.txtRecommendation.Size = New System.Drawing.Size(373, 69)
        Me.txtRecommendation.TabIndex = 64
        '
        'progress_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 631)
        Me.Controls.Add(Me.txtRecommendation)
        Me.Controls.Add(Me.btnRecommendation)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtBmi)
        Me.Controls.Add(Me.lblBmi)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lblRemarks)
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
        Me.Font = New System.Drawing.Font("Copperplate Gothic Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
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
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtBmi As TextBox
    Friend WithEvents lblBmi As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnRecommendation As Button
    Friend WithEvents txtRecommendation As TextBox
End Class
