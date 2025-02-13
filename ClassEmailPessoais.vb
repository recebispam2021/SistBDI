Public Class ClassEmailPessoais
    Private _idEmailPessoais As Byte
    Public Property IdEmailPessoais As Byte 'ID de EmailPessoais
        Get
            Return _idEmailPessoais
        End Get
        Set(value As Byte)
            _idEmailPessoais = value
        End Set
    End Property
    Private _EmailNome As String
    Public Property EmailNome As String 'Nome de EmailPessoais
        Get
            Return _EmailNome
        End Get
        Set(value As String)
            _EmailNome = value
        End Set
    End Property

End Class
