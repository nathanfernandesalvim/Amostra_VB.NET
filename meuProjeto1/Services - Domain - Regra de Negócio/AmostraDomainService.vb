Imports meuProjeto1.Models
Imports meuProjeto1.Data
Imports meuProjeto1.Interfaces

Namespace meuProjeto1.Services

    Public Class AmostraDomainService

        Private ReadOnly _repositorio As IAmostraRepositorio

        ' Construtor que recebe uma implementação da interface IAmostraRepositorio.
        ' Isso permite a inversão de dependência, desacoplando esta classe de uma implementação específica.
        ' Facilita testes unitários, manutenção e reutilização, já que qualquer classe que implemente a interface pode ser usada.
        Public Sub New(repositorio As IAmostraRepositorio)
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