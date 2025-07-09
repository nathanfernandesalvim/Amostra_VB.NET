Imports System.Data.OleDb
Imports meuProjeto1.Models


Namespace meuProjeto1.Data

    Public Class ManipularAmostrasNoBanco

        Private ReadOnly _conexao As CriarConexaoBanco

        'Construtor da classe recebe e armazena a dependência para uso futuro
        Public Sub New(conexao As CriarConexaoBanco)
            _conexao = conexao
        End Sub

        Public Sub Inserir(amostra As Amostra)
            Using conn = _conexao.CriarConexao()
                conn.Open()
                Dim sql = "INSERT INTO Amostras (Nome, Diametro, Area) VALUES (?, ?, ?)"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", amostra.Nome)
                    cmd.Parameters.AddWithValue("?", amostra.Diametro)
                    cmd.Parameters.AddWithValue("?", amostra.Area)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Atualizar(amostra As Amostra)
            Using conn = _conexao.CriarConexao()
                conn.Open()
                Dim sql = "UPDATE Amostras SET Nome = ?, Diametro = ?, Area = ? WHERE Id = ?"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", amostra.Nome)
                    cmd.Parameters.AddWithValue("?", amostra.Diametro)
                    cmd.Parameters.AddWithValue("?", amostra.Area)
                    cmd.Parameters.AddWithValue("?", amostra.Id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Sub Deletar(id As Integer)
            Using conn = _conexao.CriarConexao()
                conn.Open()
                Dim sql = "DELETE FROM Amostras WHERE Id = ?"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Function LerAmostra(id As Integer) As Amostra
            Using conn = _conexao.CriarConexao()
                conn.Open()
                Dim sql = "SELECT * FROM Amostras WHERE Id = ?"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", id)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return New Amostra With {
                            .Id = Convert.ToInt32(reader("Id")),
                            .Nome = reader("Nome").ToString(),
                            .Diametro = Convert.ToDouble(reader("Diametro")),
                            .Area = Convert.ToDouble(reader("Area"))
                        }
                        Else
                            Return Nothing
                        End If
                    End Using
                End Using
            End Using
        End Function

        Public Function ObterPrimeiroRegistro() As Amostra
            Using conn = _conexao.CriarConexao()
                conn.Open()
                Dim sql = "SELECT TOP 1 * FROM Amostras ORDER BY Id ASC"
                Using cmd = New OleDbCommand(sql, conn)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return New Amostra With {
                         .Id = Convert.ToInt32(reader("Id")),
                         .Nome = reader("Nome").ToString(),
                         .Diametro = Convert.ToDouble(reader("Diametro")),
                         .Area = Convert.ToDouble(reader("Area"))
                        }
                        Else
                            Return Nothing
                        End If
                    End Using
                End Using
            End Using
        End Function

    End Class

End Namespace