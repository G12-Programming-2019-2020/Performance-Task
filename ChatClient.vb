Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Dns
Imports System.Text
Imports System.Xml
Imports System.Threading

Public Class Form1
    Dim _listenerThread As Thread
    Dim ReadOnly _receivingUdpClient As New UdpClient(11001)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbChatLog.Text = "Chat Client Program" + vbCrLf
        tbUname.Focus()
        _listenerThread = New Thread(New ThreadStart(AddressOf ListenMessage))
        _listenerThread.IsBackground = True
        _listenerThread.Start()
    End Sub

    Private Sub ListenMessage()
        While _listenerThread.IsAlive
            Dim remoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
            Try
                Dim receiveBytes As Byte() = _receivingUdpClient.Receive(remoteIpEndPoint)
                Dim returnData As String = Encoding.ASCII.GetString(receiveBytes)
                Dim messDoc As New XmlDocument
                messDoc.LoadXml(returnData)
                Dim username As String = messDoc.SelectSingleNode("//chatMessage/username").InnerText
                Dim message As String = messDoc.SelectSingleNode("//chatMessage/message").InnerText
                tbChatLog.Invoke(Sub() tbChatLog.AppendText(username + ": " + message + vbCrLf))
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End While
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Not tbMessage.Text.Equals("") And Not tbUname.Text.Equals("") And Not tbPort.Text.Equals("") Then
            Dim messageDoc As New XmlDocument
            Dim proc As XmlProcessingInstruction = messageDoc.CreateProcessingInstruction("xml", "version = '1.0'")
            Dim root As XmlElement = messageDoc.CreateElement("chatMessage")
            Dim ipNode As XmlElement = messageDoc.CreateElement("ip")
            ipNode.InnerText = GetHostEntry(GetHostName).AddressList(1).ToString
            Dim usernameNode As XmlElement = messageDoc.CreateElement("username")
            usernameNode.InnerText = tbUname.Text
            Dim messageNode As XmlElement = messageDoc.CreateElement("message")
            messageNode.InnerText = tbMessage.Text
            root.AppendChild(ipNode)
            root.AppendChild(usernameNode)
            root.AppendChild(messageNode)
            messageDoc.AppendChild(proc)
            messageDoc.AppendChild(root)
            SendMessage(messageDoc)
            tbMessage.Clear()
            tbMessage.Focus()
        End If
    End Sub

    Private Sub SendMessage(loadDoc As XmlDocument)
        Dim udpClient As New UdpClient
        Dim sendBytes As Byte() = Encoding.ASCII.GetBytes(loadDoc.OuterXml)
        Try
            udpClient.Send(sendBytes, sendBytes.Length, "255.255.255.255", Integer.Parse(tbPort.Text))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
