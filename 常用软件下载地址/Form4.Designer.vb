<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "关于作者和现行可用法律条款"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "作者：CGM_smoKboY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "联系方式：QQ：3192917424"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(404, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "使用不受著作权保护的作品或材料，进行法律不要求经著作权人许可的使用"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "实施著作权或与著作权有关的权益控制范围之外的行为"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "均不属于著作权法上的侵权行为。"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "本软件为开源项目，在GitHub上？"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 208)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 23)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "https://github.com/smoKnoY/-"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 342)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
