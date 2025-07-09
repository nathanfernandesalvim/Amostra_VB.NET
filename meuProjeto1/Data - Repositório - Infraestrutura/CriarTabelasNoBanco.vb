Imports System.Data.OleDb

Public Class CriarTabelasNoBanco

    Private ReadOnly _conexao As CriarConexaoBanco

    Public Sub New(conexao As CriarConexaoBanco)
        _conexao = conexao
    End Sub

    Public Sub CriarTabelaAmostrasSeNaoExistir()
        Try
            'Using garante o descarte automático após o uso dispose()
            Using conn = _conexao.CriarConexao()
                conn.Open()

                'Esse array restringe os resultados retornados pelo schema, onde:
                ' 0 = Catalogo; 1 = Proprietário; 2 = NomeTabela; 3 = Tipo Objeto
                Dim restricoes() As String = {Nothing, Nothing, "Amostras", "TABLE"}

                'Retorna com metadados sobre as tabelas no banco
                Dim tabela As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, restricoes)

                If tabela.Rows.Count = 0 Then
                    ' Tabela não existe → criar
                    Dim sql = "
                        CREATE TABLE Amostras (
                            Id AUTOINCREMENT PRIMARY KEY,
                            Nome TEXT(100),
                            Diametro DOUBLE,
                            Area DOUBLE
                        )"
                    Using cmd As New OleDbCommand(sql, conn)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Tabela 'Amostras' criada com sucesso.")
                Else
                    ' A tabela já existe → não faz nada
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao verificar/criar tabela: " & ex.Message)
        End Try
    End Sub


End Class
