Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module ConexaoBanco
    ' Public conexao As New SqlConnection("Server=GEAN-CEZAR\SQLEXPRESS;Database=XYZ_CreditCard;User Id=meu_usuario;Password=meu_password")
    ' String de conexão com autenticação do Windows
    Public conexao As New SqlConnection("Server=GEAN-CEZAR\SQLEXPRESS;Database=XYZ_CreditCard;Integrated Security=True;")

    ' Função para abrir a conexão
    Public Sub AbrirConexao()
        Try
            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
                Console.WriteLine("Conexão aberta com sucesso!")
            End If
        Catch ex As Exception
            Console.WriteLine("Erro ao abrir a conexão: " & ex.Message)
        End Try
    End Sub

    ' Função para fechar a conexão
    Public Sub FecharConexao()
        Try
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
                Console.WriteLine("Conexão fechada com sucesso!")
            End If
        Catch ex As Exception
            Console.WriteLine("Erro ao fechar a conexão: " & ex.Message)
        End Try
    End Sub
End Module