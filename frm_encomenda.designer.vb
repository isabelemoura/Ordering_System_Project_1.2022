<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class encomenda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ENCOMENDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEDIDONOVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTROLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROMOÇÃOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOTIFICAÇÃOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btn_encom_salvar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.cpf_text = New System.Windows.Forms.Label()
        Me.celular_text = New System.Windows.Forms.Label()
        Me.nome_text = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.consulta_grid = New System.Windows.Forms.DataGridView()
        Me.numero_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_qnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENCOMENDAToolStripMenuItem, Me.PROMOÇÃOToolStripMenuItem, Me.AJUDAToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ENCOMENDAToolStripMenuItem
        '
        Me.ENCOMENDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PEDIDONOVOToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.CONTROLEToolStripMenuItem})
        Me.ENCOMENDAToolStripMenuItem.Name = "ENCOMENDAToolStripMenuItem"
        Me.ENCOMENDAToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ENCOMENDAToolStripMenuItem.Text = "ENCOMENDA"
        '
        'PEDIDONOVOToolStripMenuItem
        '
        Me.PEDIDONOVOToolStripMenuItem.Name = "PEDIDONOVOToolStripMenuItem"
        Me.PEDIDONOVOToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.PEDIDONOVOToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PEDIDONOVOToolStripMenuItem.Text = "NOVO PEDIDO"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'CONTROLEToolStripMenuItem
        '
        Me.CONTROLEToolStripMenuItem.Name = "CONTROLEToolStripMenuItem"
        Me.CONTROLEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.CONTROLEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CONTROLEToolStripMenuItem.Text = "CONTROLE"
        '
        'PROMOÇÃOToolStripMenuItem
        '
        Me.PROMOÇÃOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTROToolStripMenuItem, Me.NOTIFICAÇÃOToolStripMenuItem})
        Me.PROMOÇÃOToolStripMenuItem.Name = "PROMOÇÃOToolStripMenuItem"
        Me.PROMOÇÃOToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.PROMOÇÃOToolStripMenuItem.Text = "PROMOÇÃO"
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CADASTROToolStripMenuItem.Text = "CADASTRO"
        '
        'NOTIFICAÇÃOToolStripMenuItem
        '
        Me.NOTIFICAÇÃOToolStripMenuItem.Name = "NOTIFICAÇÃOToolStripMenuItem"
        Me.NOTIFICAÇÃOToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.NOTIFICAÇÃOToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NOTIFICAÇÃOToolStripMenuItem.Text = "NOTIFICAÇÃO"
        '
        'AJUDAToolStripMenuItem
        '
        Me.AJUDAToolStripMenuItem.Name = "AJUDAToolStripMenuItem"
        Me.AJUDAToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AJUDAToolStripMenuItem.Text = "AJUDA"
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SAIRToolStripMenuItem.Text = "SAIR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CLIENTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(151, 100)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(236, 20)
        Me.txt_nome.TabIndex = 2
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(413, 100)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(236, 20)
        Me.txt_email.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(319, 213)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(90, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(452, 213)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(323, 20)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(217, 213)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(59, 20)
        Me.TextBox6.TabIndex = 6
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(629, 409)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(146, 20)
        Me.TextBox7.TabIndex = 9
        '
        'btn_encom_salvar
        '
        Me.btn_encom_salvar.Location = New System.Drawing.Point(629, 445)
        Me.btn_encom_salvar.Name = "btn_encom_salvar"
        Me.btn_encom_salvar.Size = New System.Drawing.Size(146, 32)
        Me.btn_encom_salvar.TabIndex = 21
        Me.btn_encom_salvar.Text = "SALVAR"
        Me.btn_encom_salvar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "PEDIDO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(22, 213)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(152, 20)
        Me.TextBox3.TabIndex = 5
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 202)
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(25, 100)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf.TabIndex = 1
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(675, 100)
        Me.txt_celular.Mask = "(99) 00000-0000"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(100, 20)
        Me.txt_celular.TabIndex = 4
        '
        'cpf_text
        '
        Me.cpf_text.AutoSize = True
        Me.cpf_text.Location = New System.Drawing.Point(22, 84)
        Me.cpf_text.Name = "cpf_text"
        Me.cpf_text.Size = New System.Drawing.Size(30, 13)
        Me.cpf_text.TabIndex = 24
        Me.cpf_text.Text = "CPF:"
        '
        'celular_text
        '
        Me.celular_text.AutoSize = True
        Me.celular_text.Location = New System.Drawing.Point(672, 84)
        Me.celular_text.Name = "celular_text"
        Me.celular_text.Size = New System.Drawing.Size(59, 13)
        Me.celular_text.TabIndex = 25
        Me.celular_text.Text = "CELULAR:"
        '
        'nome_text
        '
        Me.nome_text.AutoSize = True
        Me.nome_text.Location = New System.Drawing.Point(148, 84)
        Me.nome_text.Name = "nome_text"
        Me.nome_text.Size = New System.Drawing.Size(42, 13)
        Me.nome_text.TabIndex = 26
        Me.nome_text.Text = "NOME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "E-MAIL:"
        '
        'consulta_grid
        '
        Me.consulta_grid.AllowUserToAddRows = False
        Me.consulta_grid.AllowUserToDeleteRows = False
        Me.consulta_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.consulta_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero_pedido, Me.tb_pedido, Me.Column1, Me.tb_qnt, Me.tb_valor, Me.tb_status, Me.Column2})
        Me.consulta_grid.Location = New System.Drawing.Point(22, 248)
        Me.consulta_grid.Name = "consulta_grid"
        Me.consulta_grid.ReadOnly = True
        Me.consulta_grid.Size = New System.Drawing.Size(753, 132)
        Me.consulta_grid.TabIndex = 28
        '
        'numero_pedido
        '
        Me.numero_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.numero_pedido.HeaderText = "Item"
        Me.numero_pedido.MinimumWidth = 50
        Me.numero_pedido.Name = "numero_pedido"
        Me.numero_pedido.ReadOnly = True
        '
        'tb_pedido
        '
        Me.tb_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_pedido.HeaderText = "ID Produto"
        Me.tb_pedido.Name = "tb_pedido"
        Me.tb_pedido.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Descrição"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 89
        '
        'tb_qnt
        '
        Me.tb_qnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_qnt.HeaderText = "Qtd."
        Me.tb_qnt.Name = "tb_qnt"
        Me.tb_qnt.ReadOnly = True
        '
        'tb_valor
        '
        Me.tb_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_valor.HeaderText = "Valor Unit."
        Me.tb_valor.Name = "tb_valor"
        Me.tb_valor.ReadOnly = True
        '
        'tb_status
        '
        Me.tb_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_status.HeaderText = "Subtotal"
        Me.tb_status.Name = "tb_status"
        Me.tb_status.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Obs."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "ID PRODUTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "QTD."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "VALOR UNIT."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(449, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "OBS."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(626, 393)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "VALOR TOTAL"
        '
        'encomenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 489)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.consulta_grid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nome_text)
        Me.Controls.Add(Me.celular_text)
        Me.Controls.Add(Me.cpf_text)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.btn_encom_salvar)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "encomenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ENCOMENDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PEDIDONOVOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTROLEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROMOÇÃOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AJUDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents btn_encom_salvar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents cpf_text As Label
    Friend WithEvents celular_text As Label
    Friend WithEvents nome_text As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents consulta_grid As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents numero_pedido As DataGridViewTextBoxColumn
    Friend WithEvents tb_pedido As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents tb_qnt As DataGridViewTextBoxColumn
    Friend WithEvents tb_valor As DataGridViewTextBoxColumn
    Friend WithEvents tb_status As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NOTIFICAÇÃOToolStripMenuItem As ToolStripMenuItem
End Class
