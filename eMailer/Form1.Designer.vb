<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtToEmail = New System.Windows.Forms.TextBox()
        Me.txtFromEmail = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.lblToEmail = New System.Windows.Forms.Label()
        Me.lblFromEmail = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtToEmail
        '
        Me.txtToEmail.Location = New System.Drawing.Point(65, 18)
        Me.txtToEmail.Name = "txtToEmail"
        Me.txtToEmail.Size = New System.Drawing.Size(350, 20)
        Me.txtToEmail.TabIndex = 0
        '
        'txtFromEmail
        '
        Me.txtFromEmail.Location = New System.Drawing.Point(65, 44)
        Me.txtFromEmail.Name = "txtFromEmail"
        Me.txtFromEmail.Size = New System.Drawing.Size(350, 20)
        Me.txtFromEmail.TabIndex = 1
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(65, 70)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(350, 20)
        Me.txtSubject.TabIndex = 2
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(65, 96)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(350, 142)
        Me.txtBody.TabIndex = 3
        '
        'lblToEmail
        '
        Me.lblToEmail.AutoSize = True
        Me.lblToEmail.Location = New System.Drawing.Point(12, 21)
        Me.lblToEmail.Name = "lblToEmail"
        Me.lblToEmail.Size = New System.Drawing.Size(20, 13)
        Me.lblToEmail.TabIndex = 4
        Me.lblToEmail.Text = "To"
        '
        'lblFromEmail
        '
        Me.lblFromEmail.AutoSize = True
        Me.lblFromEmail.Location = New System.Drawing.Point(12, 47)
        Me.lblFromEmail.Name = "lblFromEmail"
        Me.lblFromEmail.Size = New System.Drawing.Size(30, 13)
        Me.lblFromEmail.TabIndex = 5
        Me.lblFromEmail.Text = "From"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(12, 73)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(43, 13)
        Me.lblSubject.TabIndex = 6
        Me.lblSubject.Text = "Subject"
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Location = New System.Drawing.Point(12, 99)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(50, 13)
        Me.lblBody.TabIndex = 7
        Me.lblBody.Text = "Message"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(65, 244)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "&Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 279)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblBody)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblFromEmail)
        Me.Controls.Add(Me.lblToEmail)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtFromEmail)
        Me.Controls.Add(Me.txtToEmail)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eMailer for Gmail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtToEmail As TextBox
    Friend WithEvents txtFromEmail As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtBody As TextBox
    Friend WithEvents lblToEmail As Label
    Friend WithEvents lblFromEmail As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblBody As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents Button1 As Button
End Class
