Projeto XYZ_CreditCard
Este projeto é um sistema de gerenciamento de transações de cartão de crédito, desenvolvido em VB.NET com banco de dados SQL Server. Ele permite cadastrar, visualizar, editar, excluir e exportar transações, além de gerar relatórios categorizados.

Funcionalidades
Cadastro de Transações:

Inserção de novas transações com número do cartão, valor, data, descrição e status.

Validação de campos e seleção de status (Aprovada, Pendente, Cancelada).

Visualização de Transações:

Listagem de todas as transações em uma DataGridView.

Pesquisa de transações por número do cartão, valor, data ou status.

Edição e Exclusão de Transações:

Atualização de transações existentes.

Exclusão de transações.

Exportação de Relatórios:

Exportação das transações para um arquivo Excel (.xlsx).

Categorização das transações por valor (Baixa, Média, Alta, Premium).

Funções e Stored Procedures:

fn_TransacoesCategorizadas: Retorna transações categorizadas por valor.

fn_CategoriaValor: Classifica o valor da transação em categorias.

sp_TotalTransacoes: Retorna o total de transações por status.

Pré-requisitos
Visual Studio 2022 (Community ou superior).

SQL Server (local ou remoto).

EPPlus (biblioteca para exportação de Excel, instalada via NuGet).

Configuração do Banco de Dados
Criação do Banco de Dados:

Execute o script SQL fornecido no arquivo Scripts/CreateDatabase.sql para criar o banco de dados XYZ_CreditCard.

Tabelas e Funções:

As tabelas, funções e stored procedures necessárias são criadas automaticamente pelo script.

Configuração da Conexão:

No arquivo ConexaoBanco.vb, atualize a string de conexão com as credenciais do seu SQL Server:

vb
Copy
Public conexao As New SqlConnection("Server=SEU_SERVIDOR;Database=XYZ_CreditCard;User Id=SEU_USUARIO;Password=SUA_SENHA;")
Como Executar o Projeto
Clone o Repositório:

bash
Copy
git clone https://github.com/seu-usuario/XYZ_CreditCard.git
Abra o Projeto no Visual Studio:

Abra o arquivo XYZ_CreditCard.sln no Visual Studio.

Restaurar Pacotes NuGet:

No Visual Studio, clique com o botão direito na solução e selecione Restaurar Pacotes NuGet.

Execute o Projeto:

Pressione F5 para compilar e executar o projeto.

Estrutura do Projeto
frmTransacoes.vb:

Formulário principal com a interface de gerenciamento de transações.

ConexaoBanco.vb:

Módulo para gerenciar a conexão com o banco de dados.

Scripts/:

Contém scripts SQL para criação do banco de dados, tabelas, funções e stored procedures.

Relatorios/:

Diretório onde os relatórios em Excel são salvos (opcional).

Exemplos de Uso
Consulta de Transações Categorizadas
sql
Copy
SELECT * FROM dbo.fn_TransacoesCategorizadas('2025-01-01', '2025-12-31');
Exportação para Excel
No formulário principal, clique no botão Exportar para gerar um relatório em Excel com as transações categorizadas.

Pesquisa de Transações
No campo de pesquisa, digite um valor (número do cartão, valor, data ou status) para filtrar as transações.

Contribuição
Contribuições são bem-vindas! Siga os passos abaixo:

Faça um fork do projeto.

Crie uma branch para sua feature (git checkout -b feature/nova-feature).

Commit suas mudanças (git commit -m 'Adicionando nova feature').

Push para a branch (git push origin feature/nova-feature).

Abra um Pull Request.

Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

Capturas de Tela (Opcional)
Se quiser, adicione capturas de tela da interface do projeto para ilustrar melhor o funcionamento.

