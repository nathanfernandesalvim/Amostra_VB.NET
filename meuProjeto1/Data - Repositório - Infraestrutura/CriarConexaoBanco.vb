Imports System.Data.OleDb

Public Class CriarConexaoBanco

    'É a classe responsável por encapsular a lógica de montar a connection string.

    Private ReadOnly _caminhoBanco As String

    Public Sub New(caminhoBanco As String)
        _caminhoBanco = caminhoBanco
    End Sub

    Public Function CriarConexao() As OleDbConnection
        Dim connStr = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={_caminhoBanco}"
        Return New OleDbConnection(connStr)
    End Function

End Class
