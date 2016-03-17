Public Class Games
    Dim charName As String
    Dim cSystem As String
    Dim cId As Integer

    Public Sub New()

    End Sub

    Public Sub New(Name As String, System As String)
        Me.charName = Name
        Me.cSystem = System
    End Sub

    Public Property Id() As Integer
        Get
            Return cId
        End Get
        Set(ByVal value As Integer)
            cId = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return charName
        End Get
        Set(ByVal value As String)
            charName = value
        End Set
    End Property

    Public Property System() As String
        Get
            Return cSystem
        End Get
        Set(ByVal value As String)
            cSystem = value
        End Set
    End Property
End Class
