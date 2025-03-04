<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransacoes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransacoes))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panelPesquisa = New System.Windows.Forms.Panel()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelCentral = New System.Windows.Forms.Panel()
        Me.panelRegistros = New System.Windows.Forms.Panel()
        Me.dtTimeDataTransacao = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.rbCancelada = New System.Windows.Forms.RadioButton()
        Me.rbPendente = New System.Windows.Forms.RadioButton()
        Me.rbAprovada = New System.Windows.Forms.RadioButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblData_Transacao = New System.Windows.Forms.Label()
        Me.txtValor_Transacao = New System.Windows.Forms.TextBox()
        Me.lblValor_Transacao = New System.Windows.Forms.Label()
        Me.txtNumero_Cartao = New System.Windows.Forms.TextBox()
        Me.lblNumero_Cartao = New System.Windows.Forms.Label()
        Me.txtIDTransacao = New System.Windows.Forms.TextBox()
        Me.lblIDTransacao = New System.Windows.Forms.Label()
        Me.dataListaTransacoes = New System.Windows.Forms.DataGridView()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.panelTitulo.SuspendLayout()
        Me.panelPesquisa.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCentral.SuspendLayout()
        Me.panelRegistros.SuspendLayout()
        Me.grpStatus.SuspendLayout()
        CType(Me.dataListaTransacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.panelTitulo.Controls.Add(Me.lblTitulo)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(999, 75)
        Me.panelTitulo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(21, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(143, 35)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Transações"
        '
        'panelPesquisa
        '
        Me.panelPesquisa.BackColor = System.Drawing.SystemColors.Window
        Me.panelPesquisa.Controls.Add(Me.txtPesquisa)
        Me.panelPesquisa.Controls.Add(Me.PictureBox1)
        Me.panelPesquisa.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelPesquisa.Location = New System.Drawing.Point(0, 75)
        Me.panelPesquisa.Name = "panelPesquisa"
        Me.panelPesquisa.Size = New System.Drawing.Size(999, 60)
        Me.panelPesquisa.TabIndex = 1
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisa.Location = New System.Drawing.Point(72, 16)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(882, 30)
        Me.txtPesquisa.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelCentral
        '
        Me.panelCentral.Controls.Add(Me.panelRegistros)
        Me.panelCentral.Controls.Add(Me.dataListaTransacoes)
        Me.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentral.Location = New System.Drawing.Point(0, 135)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Size = New System.Drawing.Size(999, 501)
        Me.panelCentral.TabIndex = 2
        '
        'panelRegistros
        '
        Me.panelRegistros.Controls.Add(Me.dtTimeDataTransacao)
        Me.panelRegistros.Controls.Add(Me.btnCancelar)
        Me.panelRegistros.Controls.Add(Me.btnModificar)
        Me.panelRegistros.Controls.Add(Me.btnGravar)
        Me.panelRegistros.Controls.Add(Me.grpStatus)
        Me.panelRegistros.Controls.Add(Me.lblStatus)
        Me.panelRegistros.Controls.Add(Me.txtDescricao)
        Me.panelRegistros.Controls.Add(Me.lblDescricao)
        Me.panelRegistros.Controls.Add(Me.lblData_Transacao)
        Me.panelRegistros.Controls.Add(Me.txtValor_Transacao)
        Me.panelRegistros.Controls.Add(Me.lblValor_Transacao)
        Me.panelRegistros.Controls.Add(Me.txtNumero_Cartao)
        Me.panelRegistros.Controls.Add(Me.lblNumero_Cartao)
        Me.panelRegistros.Controls.Add(Me.txtIDTransacao)
        Me.panelRegistros.Controls.Add(Me.lblIDTransacao)
        Me.panelRegistros.Location = New System.Drawing.Point(0, 0)
        Me.panelRegistros.Name = "panelRegistros"
        Me.panelRegistros.Size = New System.Drawing.Size(1004, 529)
        Me.panelRegistros.TabIndex = 7
        Me.panelRegistros.Visible = False
        '
        'dtTimeDataTransacao
        '
        Me.dtTimeDataTransacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTimeDataTransacao.Location = New System.Drawing.Point(299, 211)
        Me.dtTimeDataTransacao.Name = "dtTimeDataTransacao"
        Me.dtTimeDataTransacao.Size = New System.Drawing.Size(560, 30)
        Me.dtTimeDataTransacao.TabIndex = 16
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(672, 430)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(216, 65)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.YellowGreen
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(383, 430)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(216, 65)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGravar
        '
        Me.btnGravar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGravar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGravar.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGravar.Location = New System.Drawing.Point(72, 430)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(216, 65)
        Me.btnGravar.TabIndex = 13
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = False
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rbCancelada)
        Me.grpStatus.Controls.Add(Me.rbPendente)
        Me.grpStatus.Controls.Add(Me.rbAprovada)
        Me.grpStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStatus.Location = New System.Drawing.Point(299, 331)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(560, 51)
        Me.grpStatus.TabIndex = 12
        Me.grpStatus.TabStop = False
        '
        'rbCancelada
        '
        Me.rbCancelada.AutoSize = True
        Me.rbCancelada.Location = New System.Drawing.Point(373, 16)
        Me.rbCancelada.Name = "rbCancelada"
        Me.rbCancelada.Size = New System.Drawing.Size(128, 29)
        Me.rbCancelada.TabIndex = 2
        Me.rbCancelada.Text = "Cancelada"
        Me.rbCancelada.UseVisualStyleBackColor = True
        '
        'rbPendente
        '
        Me.rbPendente.AutoSize = True
        Me.rbPendente.Checked = True
        Me.rbPendente.Location = New System.Drawing.Point(183, 16)
        Me.rbPendente.Name = "rbPendente"
        Me.rbPendente.Size = New System.Drawing.Size(117, 29)
        Me.rbPendente.TabIndex = 1
        Me.rbPendente.TabStop = True
        Me.rbPendente.Text = "Pendente"
        Me.rbPendente.UseVisualStyleBackColor = True
        '
        'rbAprovada
        '
        Me.rbAprovada.AutoSize = True
        Me.rbAprovada.Location = New System.Drawing.Point(16, 16)
        Me.rbAprovada.Name = "rbAprovada"
        Me.rbAprovada.Size = New System.Drawing.Size(118, 29)
        Me.rbAprovada.TabIndex = 0
        Me.rbAprovada.Text = "Aprovada"
        Me.rbAprovada.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(116, 346)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(167, 25)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Status Transação"
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(299, 264)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(560, 61)
        Me.txtDescricao.TabIndex = 9
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricao.Location = New System.Drawing.Point(116, 264)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(99, 25)
        Me.lblDescricao.TabIndex = 8
        Me.lblDescricao.Text = "Descrição"
        '
        'lblData_Transacao
        '
        Me.lblData_Transacao.AutoSize = True
        Me.lblData_Transacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData_Transacao.Location = New System.Drawing.Point(116, 211)
        Me.lblData_Transacao.Name = "lblData_Transacao"
        Me.lblData_Transacao.Size = New System.Drawing.Size(152, 25)
        Me.lblData_Transacao.TabIndex = 6
        Me.lblData_Transacao.Text = "Data Transação"
        '
        'txtValor_Transacao
        '
        Me.txtValor_Transacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor_Transacao.Location = New System.Drawing.Point(299, 154)
        Me.txtValor_Transacao.Name = "txtValor_Transacao"
        Me.txtValor_Transacao.Size = New System.Drawing.Size(560, 30)
        Me.txtValor_Transacao.TabIndex = 5
        '
        'lblValor_Transacao
        '
        Me.lblValor_Transacao.AutoSize = True
        Me.lblValor_Transacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor_Transacao.Location = New System.Drawing.Point(116, 154)
        Me.lblValor_Transacao.Name = "lblValor_Transacao"
        Me.lblValor_Transacao.Size = New System.Drawing.Size(157, 25)
        Me.lblValor_Transacao.TabIndex = 4
        Me.lblValor_Transacao.Text = "Valor Transação"
        '
        'txtNumero_Cartao
        '
        Me.txtNumero_Cartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_Cartao.Location = New System.Drawing.Point(299, 99)
        Me.txtNumero_Cartao.Name = "txtNumero_Cartao"
        Me.txtNumero_Cartao.Size = New System.Drawing.Size(560, 30)
        Me.txtNumero_Cartao.TabIndex = 3
        '
        'lblNumero_Cartao
        '
        Me.lblNumero_Cartao.AutoSize = True
        Me.lblNumero_Cartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero_Cartao.Location = New System.Drawing.Point(116, 99)
        Me.lblNumero_Cartao.Name = "lblNumero_Cartao"
        Me.lblNumero_Cartao.Size = New System.Drawing.Size(145, 25)
        Me.lblNumero_Cartao.TabIndex = 2
        Me.lblNumero_Cartao.Text = "Numero Cartão"
        '
        'txtIDTransacao
        '
        Me.txtIDTransacao.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtIDTransacao.Enabled = False
        Me.txtIDTransacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDTransacao.Location = New System.Drawing.Point(299, 49)
        Me.txtIDTransacao.Name = "txtIDTransacao"
        Me.txtIDTransacao.Size = New System.Drawing.Size(560, 30)
        Me.txtIDTransacao.TabIndex = 1
        '
        'lblIDTransacao
        '
        Me.lblIDTransacao.AutoSize = True
        Me.lblIDTransacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDTransacao.Location = New System.Drawing.Point(116, 49)
        Me.lblIDTransacao.Name = "lblIDTransacao"
        Me.lblIDTransacao.Size = New System.Drawing.Size(135, 25)
        Me.lblIDTransacao.TabIndex = 0
        Me.lblIDTransacao.Text = "ID Transacao "
        '
        'dataListaTransacoes
        '
        Me.dataListaTransacoes.AllowUserToAddRows = False
        Me.dataListaTransacoes.AllowUserToDeleteRows = False
        Me.dataListaTransacoes.AllowUserToResizeColumns = False
        Me.dataListaTransacoes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dataListaTransacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataListaTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListaTransacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Excluir})
        Me.dataListaTransacoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataListaTransacoes.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dataListaTransacoes.Location = New System.Drawing.Point(0, 0)
        Me.dataListaTransacoes.Name = "dataListaTransacoes"
        Me.dataListaTransacoes.RowHeadersVisible = False
        Me.dataListaTransacoes.RowHeadersWidth = 51
        Me.dataListaTransacoes.RowTemplate.Height = 24
        Me.dataListaTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListaTransacoes.Size = New System.Drawing.Size(999, 501)
        Me.dataListaTransacoes.TabIndex = 2
        '
        'Excluir
        '
        Me.Excluir.HeaderText = ""
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Excluir.MinimumWidth = 6
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Width = 125
        '
        'panelLateral
        '
        Me.panelLateral.Controls.Add(Me.btnNovo)
        Me.panelLateral.Controls.Add(Me.btnExportar)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelLateral.Location = New System.Drawing.Point(0, 563)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(999, 73)
        Me.panelLateral.TabIndex = 3
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.BackColor = System.Drawing.Color.DarkGray
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(4, 3)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(211, 61)
        Me.btnNovo.TabIndex = 16
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.BackColor = System.Drawing.Color.DarkGray
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(784, 3)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(212, 61)
        Me.btnExportar.TabIndex = 15
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'frmTransacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 636)
        Me.Controls.Add(Me.panelLateral)
        Me.Controls.Add(Me.panelCentral)
        Me.Controls.Add(Me.panelPesquisa)
        Me.Controls.Add(Me.panelTitulo)
        Me.Name = "frmTransacoes"
        Me.Text = "CRUD de Transacoes"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        Me.panelPesquisa.ResumeLayout(False)
        Me.panelPesquisa.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCentral.ResumeLayout(False)
        Me.panelRegistros.ResumeLayout(False)
        Me.panelRegistros.PerformLayout()
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        CType(Me.dataListaTransacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents panelPesquisa As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPesquisa As TextBox
    Friend WithEvents panelCentral As Panel
    Friend WithEvents dataListaTransacoes As DataGridView
    Friend WithEvents panelLateral As Panel
    Friend WithEvents panelRegistros As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents rbCancelada As RadioButton
    Friend WithEvents rbPendente As RadioButton
    Friend WithEvents rbAprovada As RadioButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents lblData_Transacao As Label
    Friend WithEvents txtValor_Transacao As TextBox
    Friend WithEvents lblValor_Transacao As Label
    Friend WithEvents txtNumero_Cartao As TextBox
    Friend WithEvents lblNumero_Cartao As Label
    Friend WithEvents txtIDTransacao As TextBox
    Friend WithEvents lblIDTransacao As Label
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents dtTimeDataTransacao As DateTimePicker
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnNovo As Button
End Class
