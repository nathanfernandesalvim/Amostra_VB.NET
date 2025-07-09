Imports meuProjeto1.Models
Imports meuProjeto1.Data

Namespace meuProjeto1.Services

    Public Class AmostraDomainService

        Private ReadOnly _repositorio As ManipularAmostrasNoBanco

        'Construtor sobrecarregado que recebe o objeto ManipularAmostrasBanco
        'Isso garantirá que _repositório já esteja instanciado ao receber uma chamada
        Public Sub New(repositorio As ManipularAmostrasNoBanco)
            _repositorio = repositorio
        End Sub

        Public Function CalcularArea(diametro As Double) As Double
            If diametro <= 0 Then Return 0
            Return Math.PI * Math.Pow(diametro / 2, 2)
        End Function

        Public Function CriarAmostra(nome As String, diametro As Double) As Amostra
            Dim area = CalcularArea(diametro)

            Return New Amostra With {
            .Nome = nome,
            .Diametro = diametro,
            .Area = area
        }

        End Function

        Public Function AtualizarAmostra(id As Integer, nome As String, diametro As Double) As Amostra
            Dim area = CalcularArea(diametro)

            Return New Amostra With {
            .Id = id,
            .Nome = nome,
            .Diametro = diametro,
            .Area = area
        }

        End Function

    End Class

End Namespace