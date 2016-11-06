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
        Me.textContoSite = New System.Windows.Forms.TextBox()
        Me.but_launch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textFinalSend = New System.Windows.Forms.TextBox()
        Me.but_on_off = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(180, 22)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(250, 324)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://www.autojacker.com", System.UriKind.Absolute)
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(26, 296)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(150, 22)
        Me.txtResults.TabIndex = 3
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.Red
        Me.txtLog.Location = New System.Drawing.Point(20, 201)
        Me.txtLog.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(154, 88)
        Me.txtLog.TabIndex = 23
        '
        'txtURI
        '
        Me.txtURI.Location = New System.Drawing.Point(22, 108)
        Me.txtURI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtURI.Multiline = True
        Me.txtURI.Name = "txtURI"
        Me.txtURI.Size = New System.Drawing.Size(152, 24)
        Me.txtURI.TabIndex = 25
        Me.txtURI.Text = "http://autojacker.com/shock2/device_toy.txt"
        '
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(20, 75)
        Me.btnFetch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(154, 25)
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
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "1"
        '
        'textContoSite
        '
        Me.textContoSite.Location = New System.Drawing.Point(20, 171)
        Me.textContoSite.Margin = New System.Windows.Forms.Padding(4)
        Me.textContoSite.Multiline = True
        Me.textContoSite.Name = "textContoSite"
        Me.textContoSite.Size = New System.Drawing.Size(154, 24)
        Me.textContoSite.TabIndex = 27
        Me.textContoSite.Text = "http://autojacker.com/shock2/device_toy.txt"
        '
        'but_launch
        '
        Me.but_launch.Location = New System.Drawing.Point(20, 139)
        Me.but_launch.Name = "but_launch"
        Me.but_launch.Size = New System.Drawing.Size(154, 25)
        Me.but_launch.TabIndex = 28
        Me.but_launch.Text = "copy url"
        Me.but_launch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.but_on_off)
        Me.GroupBox1.Controls.Add(Me.textFinalSend)
        Me.GroupBox1.Controls.Add(Me.btnFetch)
        Me.GroupBox1.Controls.Add(Me.but_launch)
        Me.GroupBox1.Controls.Add(Me.WebBrowser1)
        Me.GroupBox1.Controls.Add(Me.txtResults)
        Me.GroupBox1.Controls.Add(Me.textContoSite)
        Me.GroupBox1.Controls.Add(Me.txtLog)
        Me.GroupBox1.Controls.Add(Me.txtURI)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 391)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'textFinalSend
        '
        Me.textFinalSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.textFinalSend.Location = New System.Drawing.Point(26, 324)
        Me.textFinalSend.Name = "textFinalSend"
        Me.textFinalSend.Size = New System.Drawing.Size(148, 22)
        Me.textFinalSend.TabIndex = 29
        '
        'but_on_off
        '
        Me.but_on_off.Location = New System.Drawing.Point(20, 23)
        Me.but_on_off.Name = "but_on_off"
        Me.but_on_off.Size = New System.Drawing.Size(153, 50)
        Me.but_on_off.TabIndex = 30
        Me.but_on_off.Text = "Button1"
        Me.but_on_off.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 542)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "web_browser_only"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents textContoSite As TextBox
    Friend WithEvents but_launch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textFinalSend As TextBox
    Friend WithEvents but_on_off As Button
End Class
