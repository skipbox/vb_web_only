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
        Me.components = New System.ComponentModel.Container()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtURI = New System.Windows.Forms.TextBox()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(152, 274)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(305, 122)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://www.autojacker.com", System.UriKind.Absolute)
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(152, 84)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(132, 22)
        Me.txtResults.TabIndex = 3
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.Red
        Me.txtLog.Location = New System.Drawing.Point(152, 125)
        Me.txtLog.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(305, 142)
        Me.txtLog.TabIndex = 23
        '
        'txtURI
        '
        Me.txtURI.Location = New System.Drawing.Point(152, 37)
        Me.txtURI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtURI.Multiline = True
        Me.txtURI.Name = "txtURI"
        Me.txtURI.Size = New System.Drawing.Size(575, 24)
        Me.txtURI.TabIndex = 25
        Me.txtURI.Text = "http://autojacker.com/shock2/device_toy.txt"
        '
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(59, 37)
        Me.btnFetch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(85, 25)
        Me.btnFetch.TabIndex = 24
        Me.btnFetch.Text = "btnFetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(589, 137)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 542)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtURI)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form1"
        Me.Text = "web_browser_only"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents txtResults As TextBox
    Friend WithEvents txtLog As TextBox
    Friend WithEvents txtURI As TextBox
    Friend WithEvents btnFetch As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
