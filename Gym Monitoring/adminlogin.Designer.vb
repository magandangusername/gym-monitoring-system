<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminlogin
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
        Label1 = New Label()
        Button2 = New Button()
        Label5 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Times New Roman", 36F, FontStyle.Bold Or FontStyle.Strikeout, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 55)
        Label1.TabIndex = 9
        Label1.Text = "GYM BRO'S"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Location = New Point(377, 130)
        Button2.Name = "Button2"
        Button2.Size = New Size(589, 350)
        Button2.TabIndex = 10
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(621, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 31)
        Label5.TabIndex = 11
        Label5.Text = "LOGIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(401, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 19)
        Label3.TabIndex = 12
        Label3.Text = "USERNAME/EMAIL:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(569, 241)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(264, 23)
        TextBox1.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(401, 319)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 19)
        Label4.TabIndex = 17
        Label4.Text = "PASSWORD:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(509, 315)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(264, 23)
        TextBox2.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(621, 408)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 31)
        Button1.TabIndex = 19
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._346147946_556976099898120_7022869176502006998_n
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1331, 578)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Form9"
        Text = "Form9"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
