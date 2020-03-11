<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tbUname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbChatLog = New System.Windows.Forms.TextBox()
        Me.tbMessage = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(197, 217)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'tbUname
        '
        Me.tbUname.Location = New System.Drawing.Point(73, 10)
        Me.tbUname.Name = "tbUname"
        Me.tbUname.Size = New System.Drawing.Size(100, 20)
        Me.tbUname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'tbChatLog
        '
        Me.tbChatLog.BackColor = System.Drawing.Color.White
        Me.tbChatLog.Location = New System.Drawing.Point(12, 36)
        Me.tbChatLog.Multiline = True
        Me.tbChatLog.Name = "tbChatLog"
        Me.tbChatLog.ReadOnly = True
        Me.tbChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbChatLog.Size = New System.Drawing.Size(260, 177)
        Me.tbChatLog.TabIndex = 3
        '
        'tbMessage
        '
        Me.tbMessage.Location = New System.Drawing.Point(12, 219)
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.Size = New System.Drawing.Size(179, 20)
        Me.tbMessage.TabIndex = 4
        '
        'tbPort
        '
        Me.tbPort.Location = New System.Drawing.Point(234, 10)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(38, 20)
        Me.tbPort.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Port"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 250)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPort)
        Me.Controls.Add(Me.tbMessage)
        Me.Controls.Add(Me.tbChatLog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbUname)
        Me.Controls.Add(Me.btnSend)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 289)
        Me.MinimumSize = New System.Drawing.Size(300, 289)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSend As Button
    Friend WithEvents tbUname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbChatLog As TextBox
    Friend WithEvents tbMessage As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tbPort As TextBox
    Friend WithEvents Label2 As Label
End Class
