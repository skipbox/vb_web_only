Imports System.IO
Imports System.Text
Imports System.Net


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.WebBrowser1.Navigate("http://autojacker.com/shock2/simple.php")
    End Sub


    Dim IgnoreCommandsFlag As Integer

    Private Sub btnFetch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFetch.Click

        Try
            ' Make a WebClient.
            Dim web_client As WebClient = New WebClient

            ' Get the indicated URI.
            'Dim response As Stream = web_client.OpenRead("http://www.livesitetoday.com/doug/device.txt")
            Dim response As Stream = web_client.OpenRead(txtURI.Text)

            ' Read the result.
            Dim stream_reader As New IO.StreamReader(response)
            Dim string_read As String
            string_read = stream_reader.ReadToEnd()
            If string_read <> txtResults.Text Then
                txtLog.Text = string_read + vbCrLf + txtLog.Text
                Dim firstChar = txtResults.Text.Substring(0, 1)
                'MsgBox("sending-=== " + firstChar)
                textFinalSend.Text = firstChar
            End If

            txtResults.Text = string_read



            ' Close the stream reader and its underlying stream.
            stream_reader.Close()

            If txtLog.BackColor = Color.Red Then
                IgnoreCommandsFlag = 1
                txtLog.BackColor = Color.White
            End If

        Catch ex As Exception
            txtLog.BackColor = Color.Red
            txtResults.Text = "ERROR"
            'MessageBox.Show(ex.Message, "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = 9 Then Label1.Text = 0
        Label1.Text = Label1.Text + 1
        btnFetch_Click(sender, New System.EventArgs())

        txtResults.BackColor = Color.LightCyan


        'send if its ready
        If (textFinalSend.Text <> "") Then
            'MsgBox(textFinalSend.Text)
            textFinalSend.Text = "test"
        End If
    End Sub

    Private Sub but_launch_Click(sender As Object, e As EventArgs) Handles but_launch.Click
        sender.text = textContoSite.Text
        Clipboard.SetText(textContoSite.Text)
    End Sub

    Private Sub txtResults_TextChanged(sender As Object, e As EventArgs) Handles txtResults.TextChanged
        MsgBox("on change")
    End Sub
End Class
