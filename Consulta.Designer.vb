<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Me.consulta_grid = New System.Windows.Forms.DataGridView()
        Me.numero_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_qnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ENCOMENDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEDIDONOVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTROLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROMOÇÃOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.consul_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cpf_text = New System.Windows.Forms.Label()
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'consulta_grid
        '
        Me.consulta_grid.AllowUserToAddRows = False
        Me.consulta_grid.AllowUserToDeleteRows = False
        Me.consulta_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.consulta_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero_pedido, Me.tb_data, Me.tb_hora, Me.tb_pedido, Me.tb_qnt, Me.tb_valor, Me.tb_status})
        Me.consulta_grid.Location = New System.Drawing.Point(12, 223)
        Me.consulta_grid.Name = "consulta_grid"
        Me.consulta_grid.ReadOnly = True
        Me.consulta_grid.Size = New System.Drawing.Size(776, 150)
        Me.consulta_grid.TabIndex = 1
        '
        'numero_pedido
        '
        Me.numero_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.numero_pedido.HeaderText = "n_pedido"
        Me.numero_pedido.Name = "numero_pedido"
        Me.numero_pedido.ReadOnly = True
        '
        'tb_data
        '
        Me.tb_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_data.HeaderText = "data"
        Me.tb_data.Name = "tb_data"
        Me.tb_data.ReadOnly = True
        '
        'tb_hora
        '
        Me.tb_hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_hora.HeaderText = "hora"
        Me.tb_hora.Name = "tb_hora"
        Me.tb_hora.ReadOnly = True
        '
        'tb_pedido
        '
        Me.tb_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_pedido.HeaderText = "pedido"
        Me.tb_pedido.Name = "tb_pedido"
        Me.tb_pedido.ReadOnly = True
        '
        'tb_qnt
        '
        Me.tb_qnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_qnt.HeaderText = "qnt"
        Me.tb_qnt.Name = "tb_qnt"
        Me.tb_qnt.ReadOnly = True
        '
        'tb_valor
        '
        Me.tb_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_valor.HeaderText = "valor"
        Me.tb_valor.Name = "tb_valor"
        Me.tb_valor.ReadOnly = True
        '
        'tb_status
        '
        Me.tb_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tb_status.HeaderText = "status"
        Me.tb_status.Name = "tb_status"
        Me.tb_status.ReadOnly = True
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToOrderColumns = True
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_dados.Location = New System.Drawing.Point(12, 203)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(776, 23)
        Me.dgv_dados.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Nome:"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Email:"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Celular:"
        Me.Column3.Name = "Column3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENCOMENDAToolStripMenuItem, Me.PROMOÇÃOToolStripMenuItem, Me.AJUDAToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
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
        Me.PEDIDONOVOToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PEDIDONOVOToolStripMenuItem.Text = "PEDIDO NOVO"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'CONTROLEToolStripMenuItem
        '
        Me.CONTROLEToolStripMenuItem.Name = "CONTROLEToolStripMenuItem"
        Me.CONTROLEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.CONTROLEToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CONTROLEToolStripMenuItem.Text = "CONTROLE"
        '
        'PROMOÇÃOToolStripMenuItem
        '
        Me.PROMOÇÃOToolStripMenuItem.Name = "PROMOÇÃOToolStripMenuItem"
        Me.PROMOÇÃOToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.PROMOÇÃOToolStripMenuItem.Text = "PROMOÇÃO"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(118, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 26)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'consul_cpf
        '
        Me.consul_cpf.Location = New System.Drawing.Point(12, 114)
        Me.consul_cpf.Mask = "000.000.000-00"
        Me.consul_cpf.Name = "consul_cpf"
        Me.consul_cpf.Size = New System.Drawing.Size(100, 20)
        Me.consul_cpf.TabIndex = 0
        '
        'cpf_text
        '
        Me.cpf_text.AutoSize = True
        Me.cpf_text.Location = New System.Drawing.Point(12, 98)
        Me.cpf_text.Name = "cpf_text"
        Me.cpf_text.Size = New System.Drawing.Size(30, 13)
        Me.cpf_text.TabIndex = 25
        Me.cpf_text.Text = "CPF:"
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cpf_text)
        Me.Controls.Add(Me.consul_cpf)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.consulta_grid)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents consulta_grid As DataGridView
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents numero_pedido As DataGridViewTextBoxColumn
    Friend WithEvents tb_data As DataGridViewTextBoxColumn
    Friend WithEvents tb_hora As DataGridViewTextBoxColumn
    Friend WithEvents tb_pedido As DataGridViewTextBoxColumn
    Friend WithEvents tb_qnt As DataGridViewTextBoxColumn
    Friend WithEvents tb_valor As DataGridViewTextBoxColumn
    Friend WithEvents tb_status As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ENCOMENDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PEDIDONOVOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTROLEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROMOÇÃOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AJUDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents consul_cpf As MaskedTextBox
    Friend WithEvents cpf_text As Label
End Class
