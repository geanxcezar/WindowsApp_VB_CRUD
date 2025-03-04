Imports System.Data.SqlClient
Imports System.IO
Imports OfficeOpenXml
Imports LicenseContext = OfficeOpenXml.LicenseContext ' Importar a biblioteca EPPlus
Public Class frmTransacoes

    Private Sub MostrarRegistros()
        Dim adt As New DataTable
        Dim ada As New SqlDataAdapter
        Try
            AbrirConexao()
            ada = New SqlDataAdapter("MostrarTransacoes", conexao)
            ada.Fill(adt)
            dataListaTransacoes.DataSource = adt
            FecharConexao()

            AjustarColunas()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PesquisarRegistros()
        Dim adt As New DataTable
        Dim ada As New SqlDataAdapter
        Try
            AbrirConexao()

            ' Configura o SqlCommand para chamar a Stored Procedure
            Dim cmd As New SqlCommand("PesquisaTransacoes", conexao)
            cmd.CommandType = CommandType.StoredProcedure ' Define o tipo como Stored Procedure
            cmd.Parameters.AddWithValue("@Pesquisa", txtPesquisa.Text)

            ' Configura o SqlDataAdapter
            ada = New SqlDataAdapter(cmd)
            ada.Fill(adt)

            ' Atualiza o DataGridView
            dataListaTransacoes.DataSource = adt

            FecharConexao()
            AjustarColunas()

        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao pesquisar transações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AjustarColunas()
        ' Ajustar tamanho do campos das colunas
        dataListaTransacoes.Columns(0).Width = 40   'Id Transacao
        dataListaTransacoes.Columns(1).Width = 40   'Id Transacao
        dataListaTransacoes.Columns(2).Width = 110  'Nº do Cartao
        dataListaTransacoes.Columns(3).Width = 110  'Valor Transacao
        dataListaTransacoes.Columns(4).Width = 110  'Data Transacao
        dataListaTransacoes.Columns(5).Width = 240  'Descricao
        dataListaTransacoes.Columns(6).Width = 80   'Statu

        ' Ajustar Aparencia do HEADER
        dataListaTransacoes.EnableHeadersVisualStyles = False
        Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
        estilo.BackColor = Color.White
        estilo.ForeColor = Color.Black
        estilo.Font = New Font("Segoe UI", 9, FontStyle.Regular Or FontStyle.Bold)
        dataListaTransacoes.ColumnHeadersDefaultCellStyle = estilo
    End Sub

    Private Sub LimparCampos()
        txtIDTransacao.Clear()
        txtNumero_Cartao.Clear()
        txtValor_Transacao.Clear()
        dtTimeDataTransacao.Value = Now
        txtDescricao.Clear()
        rbCancelada.Checked = False
        rbPendente.Checked = False
        rbAprovada.Checked = False
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimparCampos()
        panelRegistros.Visible = False
        panelLateral.Visible = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Dim cmdquery As New SqlCommand
        If txtNumero_Cartao.Text <> "" Or txtValor_Transacao.Text <> "" Then
            Try
                ' Abre a conexão com o banco de dados
                AbrirConexao()

                ' Verifica qual RadioButton está selecionado
                Dim VariavelStatus As String = String.Empty
                If rbCancelada.Checked Then
                    VariavelStatus = "Cancelada"
                ElseIf rbPendente.Checked Then
                    VariavelStatus = "Pendente"
                ElseIf rbAprovada.Checked Then
                    VariavelStatus = "Aprovada"
                Else
                    ' Caso nenhum RadioButton esteja selecionado
                    MessageBox.Show("Selecione um status para a transação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return ' Sai do método sem continuar a execução
                End If

                ' Configura o cmdquery SQL para chamar a Stored Procedure
                cmdquery = New SqlCommand("InserirTransacao", conexao)
                cmdquery.CommandType = 4 ' Define o tipo como Stored Procedure

                ' Adiciona os parâmetros
                cmdquery.Parameters.AddWithValue("@Numero_Cartao", txtNumero_Cartao.Text.ToString())
                cmdquery.Parameters.AddWithValue("@Valor_Transacao", Decimal.Parse(txtValor_Transacao.Text)) ' Converte para Decimal
                cmdquery.Parameters.AddWithValue("@Data_Transacao", dtTimeDataTransacao.Value) ' Usa o valor do DateTimePicker
                cmdquery.Parameters.AddWithValue("@Descricao", txtDescricao.Text.ToString())
                cmdquery.Parameters.AddWithValue("@Status_Transacao", VariavelStatus)

                ' Executa o cmdquery
                cmdquery.ExecuteNonQuery()

                ' Exibe uma mensagem de sucesso
                MessageBox.Show("Transação inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Erro ao inserir a transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Fecha a conexão com o banco de dados
                FecharConexao()
                panelRegistros.Visible = False
                panelLateral.Visible = True
                LimparCampos() ' Limpas os campos para nao deixar vesquiciuso de registros anteriosres
                MostrarRegistros() ' Atualiza a lista de registros apos gravar

            End Try
        Else
            MsgBox("Os campos Nº Cartao, Valor e Data da transação são Obrigatorio terem valor!", vbInformation + vbOKOnly, "Aviso")
        End If

    End Sub

    Private Sub frmTransacoes_Load(sender As Object, e As EventArgs) Handles Me.Load
        MostrarRegistros()
    End Sub

    Private Sub txtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged
        PesquisarRegistros()
        ' case o usuario for pesquisar algo volta painel da grid com o botao novo
        panelRegistros.Visible = False
        panelLateral.Visible = True
    End Sub

    Private Sub dataListaTransacoes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListaTransacoes.CellContentDoubleClick

        Try
            If dataListaTransacoes.SelectedCells.Item(5).Value IsNot Nothing Then
                ' Obtém o valor do status da transação
                Dim status As String = dataListaTransacoes.SelectedCells.Item(6).Value.ToString()
                If Not status = "Aprovada" Then
                    ' Exibe o painel de registros
                    panelRegistros.Visible = True
                    ' Preenche os campos com os valores da linha selecionada
                    txtIDTransacao.Text = dataListaTransacoes.SelectedCells.Item(1).Value.ToString()
                    txtNumero_Cartao.Text = dataListaTransacoes.SelectedCells.Item(2).Value.ToString()
                    txtValor_Transacao.Text = dataListaTransacoes.SelectedCells.Item(3).Value.ToString()
                    dtTimeDataTransacao.Value = DateTime.Parse(dataListaTransacoes.SelectedCells.Item(4).Value.ToString())

                    txtDescricao.Text = dataListaTransacoes.SelectedCells.Item(5).Value.ToString()

                    ' Define o RadioButton correto com base no status
                    Select Case status
                        Case "Cancelada"
                            rbCancelada.Checked = True
                        Case "Pendente"
                            rbPendente.Checked = True
                        Case "Aprovada"
                            rbAprovada.Checked = True
                        Case Else
                            ' Caso o status não corresponda a nenhum valor esperado
                            rbCancelada.Checked = False
                            rbPendente.Checked = False
                            rbAprovada.Checked = False
                    End Select
                    btnGravar.Enabled = False
                    btnModificar.Enabled = True
                Else
                    MsgBox("Essa Transacao nao poder ser alterada pois ja se encontra com o Status de Aprovada ", vbInformation + vbOKOnly, "Aviso")
                    Return
                End If

            End If
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao carregar os dados da transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ' Tira o painel do botao Novo
        panelLateral.Visible = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim cmdquery As New SqlCommand
        If txtNumero_Cartao.Text <> "" Or txtValor_Transacao.Text <> "" Then
            Try
                ' Abre a conexão com o banco de dados
                AbrirConexao()

                ' Verifica qual RadioButton está selecionado
                Dim VariavelStatus As String = String.Empty
                If rbCancelada.Checked Then
                    VariavelStatus = "Cancelada"
                ElseIf rbPendente.Checked Then
                    VariavelStatus = "Pendente"
                ElseIf rbAprovada.Checked Then
                    VariavelStatus = "Aprovada"
                Else
                    ' Caso nenhum RadioButton esteja selecionado
                    MessageBox.Show("Selecione um status para a transação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return ' Sai do método sem continuar a execução
                End If

                ' Configura o cmdquery SQL para chamar a Stored Procedure
                cmdquery = New SqlCommand("AlterarTransacao", conexao)
                cmdquery.CommandType = 4 ' Define o tipo como Stored Procedure

                ' Adiciona os parâmetros
                cmdquery.Parameters.AddWithValue("@Id_Transacao", txtIDTransacao.Text.ToString())
                cmdquery.Parameters.AddWithValue("@Numero_Cartao", txtNumero_Cartao.Text.ToString())
                cmdquery.Parameters.AddWithValue("@Valor_Transacao", Decimal.Parse(txtValor_Transacao.Text)) ' Converte para Decimal
                cmdquery.Parameters.AddWithValue("@Data_Transacao", dtTimeDataTransacao.Value) ' Usa o valor do DateTimePicker

                cmdquery.Parameters.AddWithValue("@Descricao", txtDescricao.Text.ToString())
                cmdquery.Parameters.AddWithValue("@Status_Transacao", VariavelStatus)

                ' Executa o cmdquery
                cmdquery.ExecuteNonQuery()

                ' Exibe uma mensagem de sucesso
                MessageBox.Show("Transação inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Exibe uma mensagem de erro caso ocorra uma exceção
                MessageBox.Show("Erro ao inserir a transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Fecha a conexão com o banco de dados
                FecharConexao()
                panelRegistros.Visible = False
                panelLateral.Visible = True
                LimparCampos() ' Limpas os campos para nao deixar vesquiciuso de registros anteriosres
                MostrarRegistros() ' Atualiza a lista de registros apos gravar

            End Try
        Else
            MsgBox("Os campos Nº Cartao, Valor e Data da transação são Obrigatorio terem valor!", vbInformation + vbOKOnly, "Aviso")
        End If
    End Sub

    Private Sub dataListaTransacoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListaTransacoes.CellContentClick
        ' Verificar a Coluna para saber se eh a coluna de exclusao 
        If e.ColumnIndex = dataListaTransacoes.Columns.Item("Excluir").Index Then
            Dim result As DialogResult
            result = MsgBox("O registro sera eliminado do bando de dados. Deseja realmente excluir o registro?", vbQuestion + vbOKCancel, "Aviso")
            If result = DialogResult.OK Then
                Dim cmdquery As SqlCommand
                Try
                    AbrirConexao()
                    cmdquery = New SqlCommand("ExcluirTransacao", conexao)
                    cmdquery.CommandType = 4
                    cmdquery.Parameters.AddWithValue("@Id_Transacao", dataListaTransacoes.SelectedCells.Item(1).Value)
                    cmdquery.ExecuteNonQuery()
                    FecharConexao()
                    ' Atualiza a lista de registros
                    MostrarRegistros()

                Catch ex As Exception

                End Try
            Else
                MsgBox("Exclusao de registro cancelada!", vbInformation + vbOKOnly, "Aviso")
            End If
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        panelRegistros.Visible = True
        panelLateral.Visible = False
        btnGravar.Enabled = True
        btnModificar.Enabled = False
        btnGravar.Enabled = True
        txtIDTransacao.Text = "ID Gerado pelo Banco"
        txtNumero_Cartao.Focus()
        rbPendente.Checked = True
    End Sub


    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ExportarParaExcel()
    End Sub

    Private Sub ExportarParaExcel()
        ' Define a licença do EPPlus (necessário para versões acima da 4.0) usei
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        ' Define o caminho e o nome do arquivo Excel
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx"
        saveFileDialog.FileName = "Transacoes_Categorizadas.xlsx"

        ' Abre a caixa de diálogo para o usuário escolher onde salvar o arquivo
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim arquivoExcel As New FileInfo(saveFileDialog.FileName)

            ' Cria um novo pacote Excel
            Using package As New ExcelPackage(arquivoExcel)
                ' Adiciona uma planilha ao arquivo Excel
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Transacoes")

                ' Define os cabeçalhos das colunas
                worksheet.Cells(1, 1).Value = "ID Transação"
                worksheet.Cells(1, 2).Value = "Nº Cartão"
                worksheet.Cells(1, 3).Value = "Valor Transação"
                worksheet.Cells(1, 4).Value = "Data Transação"
                worksheet.Cells(1, 5).Value = "Descrição"
                worksheet.Cells(1, 6).Value = "Status"
                worksheet.Cells(1, 7).Value = "Categoria"

                ' Obtém as transações categorizadas nao colocar para digitar :( faltou tempo!
                Dim transacoes As DataTable = ObterTransacoesCategorizadas(New DateTime(2025, 1, 1), New DateTime(2025, 12, 31))

                ' Preenche a planilha com os dados das transações
                Dim linha As Integer = 2
                For Each row As DataRow In transacoes.Rows
                    worksheet.Cells(linha, 1).Value = row("Id_Transacao").ToString()
                    worksheet.Cells(linha, 2).Value = row("Numero_Cartao").ToString()
                    worksheet.Cells(linha, 3).Value = row("Valor_Transacao").ToString()
                    worksheet.Cells(linha, 4).Value = row("Data_Transacao").ToString()
                    worksheet.Cells(linha, 5).Value = row("Descricao").ToString()
                    worksheet.Cells(linha, 6).Value = row("Status_Transacao").ToString()
                    worksheet.Cells(linha, 7).Value = row("Categoria").ToString()
                    linha += 1
                Next

                ' Salva o arquivo Excel
                package.Save()
            End Using

            ' Exibe uma mensagem de sucesso
            MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function ObterTransacoesCategorizadas(dataInicial As DateTime, dataFinal As DateTime) As DataTable
        Dim dt As New DataTable()
        Try
            AbrirConexao()

            ' Consulta para obter as transações categorizadas
            Dim query As String = "SELECT * FROM dbo.fn_TransacoesCategorizadas(@Data_Inicial, @Data_Final)"
            Dim cmd As New SqlCommand(query, conexao)
            cmd.Parameters.AddWithValue("@Data_Inicial", dataInicial)
            cmd.Parameters.AddWithValue("@Data_Final", dataFinal)

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)

            FecharConexao()
        Catch ex As Exception
            MessageBox.Show("Erro ao obter transações categorizadas: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
End Class
