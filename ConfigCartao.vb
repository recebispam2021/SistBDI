Imports System.Drawing.Drawing2D

Public Class ConfigCartao
    Partial Public Class InfCartao
        Inherits ClassCartao

        Private _dateinicial As Date
        Public Property DateInicial As Date 'Data de hoje
            Get
                Return _dateinicial
            End Get
            Set(value As Date)
                _dateinicial = value
            End Set
        End Property

        Private _mesinicial As Integer
        Public Property MesInicial As Integer 'Mês da data de hoje
            Get
                Return _mesinicial
            End Get
            Set(value As Integer)
                _mesinicial = value
            End Set
        End Property

        Private _anoinicial As Integer
        Public Property AnoInicial As Integer 'Ano da data de hoje
            Get
                Return _anoinicial
            End Get
            Set(value As Integer)
                _anoinicial = value
            End Set
        End Property

        Private ReadOnly _mesfinal As Integer = Month(Today)

        Private _mdate As Date
        Public Property MDate As Date 'Data ajustada do cartão
            Get
                Return _mdate
            End Get
            Private Set(value As Date)
                _mdate = value
            End Set
        End Property
        Private _novadata As Date
        Public Property NovaData As Date 'DateData do Vencimento do cartão
            Get
                Return _novadata
            End Get
            Private Set(value As Date)
                _novadata = value
            End Set
        End Property

        Private _qtddias As Integer
        Public Property QtdDias As Integer 'Qtd de dias para calculo
            Get
                Return _qtddias
            End Get
            Private Set(value As Integer)
                _qtddias = value
            End Set
        End Property
        Public Function CalcularData()
            MDate = CDate(DiaVenc & "/" & MesInicial & "/" & AnoInicial)
            NovaData = DateAdd("m", 1, MDate)
            QtdDias = DateDiff("d", DateInicial, NovaData)
            If MesInicial = _mesfinal Then
                NovaData = DateAdd("m", 1, MDate)
            ElseIf QtdDias >= 15 Then
                NovaData = DateAdd("m", 1, MDate)
            ElseIf QtdDias <= 14 And QtdDias >= 0 Then
                NovaData = DateAdd("m", 2, MDate)
            End If
            Return True
        End Function
        Private _qtdcartao As Integer
        Public Property QtdCartao As Integer 'Qtd de cartões utilizados
            Get
                Return _qtdcartao
            End Get
            Set(value As Integer)
                _qtdcartao = value
            End Set
        End Property
        Public Function VerificaCartao() As Integer
            MsgBox(IdCartao)
            Return True
        End Function

    End Class

    Partial Public Class Caixa
        Inherits ClassCartao
        Private _parc As Double 'Valor das parcelas
        Public Property Parc As Double
            Get
                Return _parc
            End Get
            Set(value As Double)
                _parc = value
            End Set
        End Property

        Private _totParc As Double 'Valor total das parcelas
        Public Property TotParc As Double
            Get
                Return _totParc
            End Get
            Set(value As Double)
                _totParc = value
            End Set
        End Property

        Private _valorpago As Double 'Valor pago das parcelas
        Public Property ValorPago As Double
            Get
                Return _valorpago
            End Get
            Set(value As Double)
                _valorpago = value
            End Set
        End Property

        Private _num As Integer 'N° de parcelas para calculo
        Public Property Num As Integer
            Get
                Return _num
            End Get
            Set(value As Integer)
                _num = value
            End Set
        End Property

        Private _credito As Double
        Public Property Credito As Double 'Crédito do cartao
            Get
                Return _credito
            End Get
            Set(value As Double)
                _credito = value
            End Set
        End Property

        Private _saldolimite As Double
        Public Property SaldoLimite As Double 'Saldo restante do cartao
            Get
                Return _saldolimite
            End Get
            Set(value As Double)
                _saldolimite = value
            End Set
        End Property

        Private _valordel As Double
        Public Property ValorDel As Double 'Saldo restante do cartao
            Get
                Return _valordel
            End Get
            Set(value As Double)
                _valordel = value
            End Set
        End Property

        Private _percmov As Double
        Public Property PercMov As Decimal 'Saldo restante do cartao
            Get
                Return _percmov
            End Get
            Set(value As Decimal)
                _percmov = value
            End Set
        End Property
        Public Function Comprar() As Double
            Divida += TotParc
            Return Divida
        End Function
        Public Function Pagar() As Double
            Divida += ValorPago
            Return Divida
        End Function
        'Função para calcular o total dos valores
        Public Function TotalCompra() As Double
            TotParc = FormatCurrency(Parc * Num)
            Return TotParc
        End Function
        'Função para calcular o Credito
        Public Function CalculoLimiteComprar() As Double
            Credito = FormatCurrency(Divida + TotParc)
            Return Credito
        End Function

        'Função para calcular o Credito
        Public Function CalculoLimitePagar() As Double
            Credito = FormatCurrency(Divida + ValorPago)
            Return Credito
        End Function

        Public Function CalculoDel() As Double
            ValorDel = FormatCurrency(ValorDel * -1)
            Return ValorDel
        End Function
        'Função para calcular o limite de crédito
        Public Function CalculoPercMov() As Double
            PercMov = FormatCurrency(Divida + ValorPago)
            'MsgBox(PercMov)
            Return PercMov
        End Function

    End Class
End Class
Public Class Exemplos
    'Exemplo de funçao de Soma
    Public Function Soma() As Integer
        Soma = 10 + 10
    End Function

End Class


Public Class ContaBancaria

End Class
Public Class LimiteCartao

End Class
