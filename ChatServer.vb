Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Xml
Imports System.Threading

Module Module1
    Dim _listenerThread As Thread

    Sub Main()
        Console.Title = "Chat Server"
        Console.WriteLine("Chat Server Program")
        _listenerThread = New Thread(New ThreadStart(AddressOf ListenMessage))
        _listenerThread.IsBackground = True
        _listenerThread.Start()
        Console.ReadLine()
    End Sub

    Private Sub ListenMessage()
        Dim receivingUdpClient As New UdpClient(8080)
        While _listenerThread.IsAlive
            Dim remoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
            Try
                Dim receiveBytes As Byte() = receivingUdpClient.Receive(remoteIpEndPoint)
                Dim returnData As String = Encoding.ASCII.GetString(receiveBytes)
                Dim messDoc As New XmlDocument
                messDoc.LoadXml(returnData)
                ReadMessage(messDoc)
                SendMessage(returnData)
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End While
    End Sub

    Private Sub ReadMessage(recDoc As XmlDocument)
        Dim username As String = recDoc.SelectSingleNode("//chatMessage/username").InnerText
        Dim message As String = recDoc.SelectSingleNode("//chatMessage/message").InnerText
        Console.WriteLine(username + ": " + message)
    End Sub

    Private Sub SendMessage(message As String)
        Dim udpClient As New UdpClient
        Dim sendBytes As Byte() = Encoding.ASCII.GetBytes(message)
        Try
            udpClient.Send(sendBytes, sendBytes.Length, "255.255.255.255", 11001)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
