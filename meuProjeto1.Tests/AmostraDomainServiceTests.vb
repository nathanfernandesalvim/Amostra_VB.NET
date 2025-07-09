Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports meuProjeto1.Models
Imports meuProjeto1.Services
Imports meuProjeto1.Interfaces

<TestClass>
Public Class AmostraDomainServiceTests

    <TestMethod>
    Public Sub CalcularArea_DeveCalcularCorretamente()
        ' Arrange
        Dim repositorioFalso As New RepositorioFalso()
        Dim service As New AmostraDomainService(repositorioFalso)
        Dim diametro As Double = 10

        ' Act
        Dim resultado As Amostra = service.CriarAmostra("Teste", diametro)

        ' Assert
        Dim areaEsperada As Double = Math.PI * (diametro / 2) ^ 2
        Assert.AreEqual(areaEsperada, resultado.Area, 0.01)
    End Sub

End Class

' Simulação do repositório só para o teste
Public Class RepositorioFalso
    Implements IAmostraRepositorio

    Public Sub Inserir(amostra As Amostra) Implements Interfaces.IAmostraRepositorio.Inserir
    End Sub

    Public Sub Atualizar(amostra As Amostra) Implements Interfaces.IAmostraRepositorio.Atualizar
    End Sub

    Public Sub Deletar(id As Integer) Implements Interfaces.IAmostraRepositorio.Deletar
    End Sub

    Public Function LerAmostra(id As Integer) As Amostra Implements Interfaces.IAmostraRepositorio.LerAmostra
        Return Nothing
    End Function

    Public Function ObterPrimeiroRegistro() As Amostra Implements Interfaces.IAmostraRepositorio.ObterPrimeiroRegistro
        Return Nothing
    End Function
End Class
