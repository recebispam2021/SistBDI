Imports System.Drawing.Drawing2D
Public Class ClassPessoal
    Inherits ClassConfgInfor

    Private _anonascimento As Date

    Public Property AnoNacimento As Date
        Get
            Return _anonascimento
        End Get
        Set(ByVal value As Date)
            _anonascimento = value
        End Set
    End Property

    Private _dias As Integer

    Public Property Dias As Integer
        Get
            Return _dias
        End Get
        Private Set(ByVal value As Integer)
            _dias = value
        End Set
    End Property

    Public Function CalcularIdade()
        _dias = DateDiff(DateInterval.Day, AnoNacimento, Now)
        Return _dias
    End Function

    Public Function CalcularAno()
        Dim dAn, dAt As Integer
        dAt = Now.Year
        dAn = Now.Year - AnoNacimento.Year
        MsgBox(Nome & ", você tem " & dAn & " anos!", vbInformation, "Tempo de vida!")
        Return dAn
    End Function

End Class

