Imports ADOX
Public Class CriarBancoDados

    Public Shared Function CriarBancoAccess(caminhoCompleto As String) As Boolean
        Try
            ' Verifica se o diretório existe, senão cria
            Dim pasta = IO.Path.GetDirectoryName(caminhoCompleto)
            If Not IO.Directory.Exists(pasta) Then
                IO.Directory.CreateDirectory(pasta)
            End If

            ' Cria o banco
            Dim cat As New Catalog()
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & caminhoCompleto)

            Return True
        Catch ex As Exception
            MessageBox.Show("Erro ao criar banco: " & ex.Message)
            Return False
        End Try
    End Function


End Class
