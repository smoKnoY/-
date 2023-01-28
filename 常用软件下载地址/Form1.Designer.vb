<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "常用软件下载地址实用工具"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(135, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "分辨捆绑与P2P下载器实用工具"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "您参加的测试项目，无论是自愿还是被迫！都不能对此软件进行逆向工程"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "作者：CGM_smoKboY QQ：3192917424"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "该软件不设计在除中国大陆的所有国家和地区使用"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(330, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 28)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 268)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "启动台"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
End Class
