Public Class ClassLivroRegistro
    Private _nome As String
    Public Property Nome As String 'Nome do dono do registro
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property
    Private _assunto As String
    Public Property Assunto As String 'Assunto do registro
        Get
            Return _assunto
        End Get
        Set(value As String)
            _assunto = value
        End Set
    End Property
End Class
