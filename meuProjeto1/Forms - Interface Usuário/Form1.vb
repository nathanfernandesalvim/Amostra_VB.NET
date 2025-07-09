Imports meuProjeto1.Models
Imports meuProjeto1.Data
Imports meuProjeto1.Services
Imports meuProjeto1.Controllers

Public Class Form1

    '=====================================================================================
    'Responsabilidades: 
    '- Capturar entradas (textboxes);
    '- Chamar o serviço de Controller ou AplicattionService (AmostraApplicationService);
    '- Chamar o repositório (infraestrutura) (ou delegar ao serviço);
    '- Atualizar a interface visual com base nos resultados;

    'Não fere SRP (única responsabilidade), pois o Form1 controla o fluxo entre
    'a UI (interface de úsuário) e as camadas de aplicação.
    '=====================================================================================

    'Declara as variáveis locais, que virarão objetos no momento que forem instânciadas
    Private _conexao As CriarConexaoBanco
    Private _cadastro As AmostraApplicationService
    Private _repositorio As ManipularAmostrasNoBanco

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caminhoBanco As String = IO.Path.Combine(My.Application.Info.DirectoryPath, "Banco de Dados\bdCadastro.mdb")

        'Verifica se o banco já existe
        If Not IO.File.Exists(caminhoBanco) Then
            Dim bancoCriado As Boolean = CriarBancoDados.CriarBancoAccess(caminhoBanco)
            If Not bancoCriado Then
                MessageBox.Show("Falha ao criar o banco de dados.")
                Exit Sub
            End If
        End If

        'Inicializa o objeto da conexão ao Banco passando o caminho como parâmetro
        _conexao = New CriarConexaoBanco(caminhoBanco)

        'Cria o objeto responsável por gerenciar a criação de tabelas no banco de dados.
        'Realiza a injeção da dependência de conexão à classe CriarTabelasNoBanco.
        Dim tabelaCriador As New CriarTabelasNoBanco(_conexao)

        'Cria tabela e colunas necessárias no BD
        tabelaCriador.CriarTabelaAmostrasSeNaoExistir()

        'Inicializa o objeto responsável por gerenciar comandos CRUD no BD
        'Realiza a injeção de dependência do objeto de conexão com o BD
        _repositorio = New ManipularAmostrasNoBanco(_conexao)

        'Inicializa o objeto responsável por orquestrar as operações de amostra na aplicação
        'Realiza a injeção de dependência do repositório, que executa os comandos no banco de dados.
        _cadastro = New AmostraApplicationService(_repositorio)

        'Recupera o primeiro registro da tabela de amostras no banco de dados.
        'Utiliza o serviço de aplicação para encapsular a lógica de acesso ao repositório.
        'A chamada BuscarPrimeiroRegistro() está abstraindo a lógica de acesso ao banco, sem precisar explicitar o comando SQL aplicado.
        Dim primeiroRegistro As Amostra = _cadastro.BuscarPrimeiroRegistro

        'Recebe os dados do primeiro registro e exibe nos campos do formulário
        PreencherCampos(primeiroRegistro)

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim nome As String = txtNomeAmostra.Text
        Dim diametro As Double

        If Not Double.TryParse(txtDiametro.Text, diametro) Then
            MessageBox.Show("Digite um valor numérico válido para o diâmetro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            'Cria o objeto amostra com a lógica de negócio (serviço)
            Dim novaAmostra = _cadastro.CriarAmostra(nome, diametro)

            'Armazena os dados (persistir dados) usando o objeto que gerencia os comandos CRUD
            _repositorio.Inserir(novaAmostra)

            MessageBox.Show("Amostra cadastrada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        Dim nome As String = txtNomeAmostra.Text
        Dim id As Integer
        Dim diametro As Double

        If Not Integer.TryParse(txtIdAmostra.Text, id) Then
            MessageBox.Show("Id inválido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not Double.TryParse(txtDiametro.Text, diametro) Then
            MessageBox.Show("Diâmetro inválido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Try
            'Cria o objeto amostra com a lógica de negócio (serviço)
            Dim atualizaAmostra = _cadastro.AtualizarAmostra(id, nome, diametro)

            'Atualiza os dados usando o objeto que gerencia os comandos CRUD
            _repositorio.Atualizar(atualizaAmostra)

            MessageBox.Show("Atualização realizada com sucesso.")
        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click

        Dim id As Integer

        If Not Integer.TryParse(txtIdAmostra.Text, id) Then
            MessageBox.Show("Id inválido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            _cadastro.DeletarAmostra(id)
            MessageBox.Show("Cadastro excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar: " & ex.Message)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim id As Integer
        If Not Integer.TryParse(txtIdAmostra.Text, id) Then
            MessageBox.Show("Informe um Id válido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            Dim amostra = _cadastro.BuscarAmostraPorId(id)
            PreencherCampos(amostra)
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar leitura da amostra: " & ex.Message)
        End Try

    End Sub

    Private Sub PreencherCampos(amostra As Amostra)

        If Not amostra Is Nothing Then
            txtIdAmostra.Text = amostra.Id
            txtNomeAmostra.Text = amostra.Nome
            txtDiametro.Text = amostra.Diametro
            lblArea.Text = amostra.Area.ToString("0.00")
        Else
            LimparCampos()
            MessageBox.Show("Erro ao buscar a leitura da Amostra", "Erro de Leitura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub LimparCampos()

        txtIdAmostra.Text = ""
        txtNomeAmostra.Text = ""
        txtDiametro.Text = ""
        lblArea.Text = ""

    End Sub

    Private Sub txtDiametro_TextChanged(sender As Object, e As EventArgs) Handles txtDiametro.TextChanged
        Dim diametro As Double
        If Double.TryParse(txtDiametro.Text, diametro) AndAlso diametro > 0 Then
            Dim area = _cadastro.CalcularArea(diametro)
            lblArea.Text = area.ToString("0.00")
        Else
            lblArea.Text = "-"
        End If
    End Sub


End Class
