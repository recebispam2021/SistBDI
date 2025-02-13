Public Class ClassChavePix
    Private _idchavepix As Byte
    Public Property IdChavePix As Byte 'ID da ChavePix
        Get
            Return _idchavepix
        End Get
        Set(value As Byte)
            _idchavepix = value
        End Set
    End Property
    Private _instituicao As String
    Public Property Instituicao As String 'Nome da instituição
        Get
            Return _instituicao
        End Get
        Set(value As String)
            _instituicao = value
        End Set
    End Property

End Class
