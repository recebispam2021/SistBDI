Public Class ClassCartao
    Inherits ClassAgencias
    Private _idcartao As Integer
    Public Property IdCartao As Integer 'ID do cartão
        Get
            Return _idcartao
        End Get
        Set(value As Integer)
            _idcartao = value
        End Set
    End Property
    Private _nucartao As Long
    Public Property NuCartao As Long 'Número do cartão
        Get
            Return _nucartao
        End Get
        Set(value As Long)
            _nucartao = value
        End Set
    End Property
    Private _donoCartao As String
    Public Property DonoCartao As String 'Dono do cartão
        Get
            Return _donoCartao
        End Get
        Set(value As String)
            _donoCartao = value
        End Set
    End Property
    Private _diavenc As Integer 'Dia do vencimento do cartão
    Public Property DiaVenc As Integer
        Get
            Return _diavenc
        End Get
        Set(value As Integer)
            _diavenc = value
        End Set
    End Property
    Private _diafech As Integer 'Dia do fechamento do cartão
    Public Property DiaFech As Integer
        Get
            Return _diafech
        End Get
        Set(value As Integer)
            _diafech = value
        End Set
    End Property
    Public Property Cartao As String

    Private _limite As Decimal
    Public Property Limite As Decimal 'Limite total do cartão
        Get
            Return _limite
        End Get
        Set(value As Decimal)
            _limite = value
        End Set
    End Property

    Private _divida As Decimal
    Public Property Divida As Decimal 'Divida do cartao
        Get
            Return _divida
        End Get
        Set(value As Decimal)
            _divida = value
        End Set
    End Property

    Private _perc As Decimal
    Public Property Perc As Decimal 'Percentual de gastos do cartao
        Get
            Return _perc
        End Get
        Set(value As Decimal)
            _perc = value
        End Set
    End Property
    Public Function Percentual()
        Perc = (Divida * -1) / Limite
        Return Perc
    End Function

End Class

