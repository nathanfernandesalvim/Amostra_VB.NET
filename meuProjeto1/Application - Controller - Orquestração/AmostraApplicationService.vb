Imports meuProjeto1.Models
Imports meuProjeto1.Data
Imports meuProjeto1.Services

Namespace meuProjeto1.Controllers

    Public Class AmostraApplicationService

        Private ReadOnly _repositorio As ManipularAmostrasNoBanco
        Private ReadOnly _service As AmostraDomainService

        Public Sub New(repositorio As ManipularAmostrasNoBanco)
            _repositorio = repositorio
            _service = New AmostraDomainService(_repositorio)
        End Sub

        Public Function CalcularArea(diametro As Double) As Double
            Return _service.CalcularArea(diametro)
        End Function

        Public Function CriarAmostra(nome As String, diametro As Double) As Amostra
            Return _service.CriarAmostra(nome, diametro)
        End Function

        Public Sub CadastrarAmostra(amostra As Amostra)
            _repositorio.Inserir(amostra)
        End Sub

        Public Function AtualizarAmostra(id As Integer, nome As String, diametro As Double) As Amostra
            Return _service.AtualizarAmostra(id, nome, diametro)
        End Function

        Public Sub AplicarAtualizacao(amostra As Amostra)
            _repositorio.Atualizar(amostra)
        End Sub

        Public Sub DeletarAmostra(id As Integer)
            _repositorio.Deletar(id)
        End Sub

        Public Function BuscarAmostraPorId(id As Integer) As Amostra
            Return _repositorio.LerAmostra(id)
        End Function

        Public Function BuscarPrimeiroRegistro() As Amostra
            Return _repositorio.ObterPrimeiroRegistro()
        End Function

    End Class

End Namespace