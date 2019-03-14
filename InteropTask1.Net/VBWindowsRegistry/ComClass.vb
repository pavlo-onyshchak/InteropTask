<ComClass(ComClass1.ClassId, ComClass1.InterfaceId, ComClass1.EventsId)>
Public Class ComClass1
    Public Const ClassId As String = "287ED548-AFE2-42D0-B879-C0DD7073DEF1"
    Public Const InterfaceId As String = "4C05FEF0-77AD-4E66-B5BF-6BF186030356"
    Public Const EventsId As String = "D970BB65-2983-4B3B-83CB-86D44B196BB5"

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub Write(ByVal log As String, ByVal pass As String)
        My.Computer.Registry.CurrentUser.CreateSubKey("regKey")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\regKey", "Login", log)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\regKey", "Password", pass)
    End Sub
    Public Function ReadLog() As String
        Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\regKey", "Login", "empty")
    End Function
    Public Function ReadPass() As String
        Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\regKey", "Password", "empty")
    End Function
End Class


