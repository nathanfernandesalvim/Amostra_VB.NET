Imports meuProjeto1.Models

Namespace meuProjeto1.Interfaces

    Public Interface IAmostraRepositorio
        Sub Inserir(amostra As Amostra)
        Sub Atualizar(amostra As Amostra)
        Sub Deletar(id As Integer)
        Function LerAmostra(id As Integer) As Amostra
        Function ObterPrimeiroRegistro() As Amostra
    End Interface

End Namespace