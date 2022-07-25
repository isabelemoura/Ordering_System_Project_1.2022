<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CONFEXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENCOMENDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTROLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROMOÇÃOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOTIFICAÇÃOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRDACONTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENCERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.btn_encom_salvar = New System.Windows.Forms.Button()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.consulta_grid = New System.Windows.Forms.DataGridView()
        Me.numero_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_qnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.un = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_valor_unit = New System.Windows.Forms.Label()
        Me.lbl_descont = New System.Windows.Forms.Label()
        Me.lbl_valor_total = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.cmb_prod = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONFEXToolStripMenuItem, Me.ENCOMENDAToolStripMenuItem, Me.PROMOÇÃOToolStripMenuItem, Me.AJUDAToolStripMenuItem, Me.SAIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 55)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CONFEXToolStripMenuItem
        '
        Me.CONFEXToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CONFEXToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 16.0!)
        Me.CONFEXToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.CONFEXToolStripMenuItem.Image = CType(resources.GetObject("CONFEXToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CONFEXToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CONFEXToolStripMenuItem.Margin = New System.Windows.Forms.Padding(20, 0, 150, 0)
        Me.CONFEXToolStripMenuItem.Name = "CONFEXToolStripMenuItem"
        Me.CONFEXToolStripMenuItem.Size = New System.Drawing.Size(125, 55)
        '
        'ENCOMENDAToolStripMenuItem
        '
        Me.ENCOMENDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTARToolStripMenuItem, Me.CONTROLEToolStripMenuItem})
        Me.ENCOMENDAToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.ENCOMENDAToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ENCOMENDAToolStripMenuItem.Image = CType(resources.GetObject("ENCOMENDAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ENCOMENDAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ENCOMENDAToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ENCOMENDAToolStripMenuItem.Name = "ENCOMENDAToolStripMenuItem"
        Me.ENCOMENDAToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20)
        Me.ENCOMENDAToolStripMenuItem.Size = New System.Drawing.Size(140, 55)
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CONSULTARToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CONSULTARToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CONSULTARToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CONSULTARToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        '
        'CONTROLEToolStripMenuItem
        '
        Me.CONTROLEToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CONTROLEToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CONTROLEToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CONTROLEToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CONTROLEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.CONTROLEToolStripMenuItem.Name = "CONTROLEToolStripMenuItem"
        Me.CONTROLEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.CONTROLEToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CONTROLEToolStripMenuItem.Text = "CONTROLE"
        '
        'PROMOÇÃOToolStripMenuItem
        '
        Me.PROMOÇÃOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTROToolStripMenuItem, Me.NOTIFICAÇÃOToolStripMenuItem})
        Me.PROMOÇÃOToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.PROMOÇÃOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PROMOÇÃOToolStripMenuItem.Image = CType(resources.GetObject("PROMOÇÃOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PROMOÇÃOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PROMOÇÃOToolStripMenuItem.Name = "PROMOÇÃOToolStripMenuItem"
        Me.PROMOÇÃOToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.PROMOÇÃOToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.PROMOÇÃOToolStripMenuItem.Size = New System.Drawing.Size(100, 55)
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CADASTROToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CADASTROToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CADASTROToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CADASTROToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CADASTROToolStripMenuItem.Text = "CADASTRO"
        '
        'NOTIFICAÇÃOToolStripMenuItem
        '
        Me.NOTIFICAÇÃOToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.NOTIFICAÇÃOToolStripMenuItem.BackgroundImage = CType(resources.GetObject("NOTIFICAÇÃOToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.NOTIFICAÇÃOToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NOTIFICAÇÃOToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.NOTIFICAÇÃOToolStripMenuItem.Name = "NOTIFICAÇÃOToolStripMenuItem"
        Me.NOTIFICAÇÃOToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.NOTIFICAÇÃOToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NOTIFICAÇÃOToolStripMenuItem.Text = "NOTIFICAÇÃO"
        '
        'AJUDAToolStripMenuItem
        '
        Me.AJUDAToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.AJUDAToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AJUDAToolStripMenuItem.Image = CType(resources.GetObject("AJUDAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AJUDAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AJUDAToolStripMenuItem.Name = "AJUDAToolStripMenuItem"
        Me.AJUDAToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.AJUDAToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.AJUDAToolStripMenuItem.Size = New System.Drawing.Size(63, 55)
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SAIRDACONTAToolStripMenuItem, Me.ENCERRARToolStripMenuItem})
        Me.SAIRToolStripMenuItem.Font = New System.Drawing.Font("Lucida Fax", 9.0!)
        Me.SAIRToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.SAIRToolStripMenuItem.Image = CType(resources.GetObject("SAIRToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SAIRToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SAIRToolStripMenuItem.Margin = New System.Windows.Forms.Padding(220, 0, 0, 0)
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(42, 55)
        '
        'SAIRDACONTAToolStripMenuItem
        '
        Me.SAIRDACONTAToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SAIRDACONTAToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SAIRDACONTAToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SAIRDACONTAToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SAIRDACONTAToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.SAIRDACONTAToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.SAIRDACONTAToolStripMenuItem.Name = "SAIRDACONTAToolStripMenuItem"
        Me.SAIRDACONTAToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SAIRDACONTAToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        '
        'ENCERRARToolStripMenuItem
        '
        Me.ENCERRARToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ENCERRARToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ENCERRARToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ENCERRARToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ENCERRARToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ENCERRARToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ENCERRARToolStripMenuItem.Name = "ENCERRARToolStripMenuItem"
        Me.ENCERRARToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ENCERRARToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ENCERRARToolStripMenuItem.Text = "ENCERRAR"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_email.Location = New System.Drawing.Point(485, 209)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(10)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(188, 15)
        Me.txt_email.TabIndex = 3
        '
        'txt_obs
        '
        Me.txt_obs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_obs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_obs.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.txt_obs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_obs.Location = New System.Drawing.Point(651, 318)
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(123, 15)
        Me.txt_obs.TabIndex = 8
        '
        'txt_qtd
        '
        Me.txt_qtd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_qtd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qtd.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.txt_qtd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_qtd.Location = New System.Drawing.Point(316, 318)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(50, 15)
        Me.txt_qtd.TabIndex = 7
        Me.txt_qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_encom_salvar
        '
        Me.btn_encom_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_encom_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_encom_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_encom_salvar.Font = New System.Drawing.Font("Lucida Fax", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encom_salvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btn_encom_salvar.Image = CType(resources.GetObject("btn_encom_salvar.Image"), System.Drawing.Image)
        Me.btn_encom_salvar.Location = New System.Drawing.Point(715, 533)
        Me.btn_encom_salvar.Name = "btn_encom_salvar"
        Me.btn_encom_salvar.Size = New System.Drawing.Size(114, 32)
        Me.btn_encom_salvar.TabIndex = 10
        Me.btn_encom_salvar.UseVisualStyleBackColor = False
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
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_cpf.Location = New System.Drawing.Point(79, 208)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(107, 15)
        Me.txt_cpf.TabIndex = 1
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_celular
        '
        Me.txt_celular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_celular.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.txt_celular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_celular.Location = New System.Drawing.Point(715, 208)
        Me.txt_celular.Mask = "(99) 00000-0000"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(114, 15)
        Me.txt_celular.TabIndex = 4
        Me.txt_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'consulta_grid
        '
        Me.consulta_grid.AllowUserToAddRows = False
        Me.consulta_grid.AllowUserToDeleteRows = False
        Me.consulta_grid.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.consulta_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.consulta_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.consulta_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero_pedido, Me.tb_pedido, Me.Column1, Me.tb_qnt, Me.un, Me.tb_valor, Me.Column3, Me.tb_status, Me.Column2, Me.excluir})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.consulta_grid.DefaultCellStyle = DataGridViewCellStyle5
        Me.consulta_grid.EnableHeadersVisualStyles = False
        Me.consulta_grid.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.consulta_grid.Location = New System.Drawing.Point(77, 358)
        Me.consulta_grid.Name = "consulta_grid"
        Me.consulta_grid.ReadOnly = True
        Me.consulta_grid.Size = New System.Drawing.Size(752, 132)
        Me.consulta_grid.TabIndex = 28
        '
        'numero_pedido
        '
        Me.numero_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.numero_pedido.HeaderText = "Item"
        Me.numero_pedido.MinimumWidth = 40
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
        Me.Column1.Width = 120
        '
        'tb_qnt
        '
        Me.tb_qnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.tb_qnt.DefaultCellStyle = DataGridViewCellStyle2
        Me.tb_qnt.HeaderText = "Qtd."
        Me.tb_qnt.Name = "tb_qnt"
        Me.tb_qnt.ReadOnly = True
        '
        'un
        '
        Me.un.HeaderText = "Unid."
        Me.un.Name = "un"
        Me.un.ReadOnly = True
        Me.un.Width = 50
        '
        'tb_valor
        '
        Me.tb_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.tb_valor.DefaultCellStyle = DataGridViewCellStyle3
        Me.tb_valor.HeaderText = "Valor Unit."
        Me.tb_valor.Name = "tb_valor"
        Me.tb_valor.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Desconto (%)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'tb_status
        '
        Me.tb_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.tb_status.DefaultCellStyle = DataGridViewCellStyle4
        Me.tb_status.HeaderText = "Subtotal"
        Me.tb_status.Name = "tb_status"
        Me.tb_status.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Obs."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 70
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.Name = "excluir"
        Me.excluir.ReadOnly = True
        Me.excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.excluir.Width = 50
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.txt_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_nome.Location = New System.Drawing.Point(245, 209)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(10)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(186, 15)
        Me.txt_nome.TabIndex = 2
        '
        'lbl_valor_unit
        '
        Me.lbl_valor_unit.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lbl_valor_unit.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.lbl_valor_unit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lbl_valor_unit.Location = New System.Drawing.Point(401, 313)
        Me.lbl_valor_unit.Name = "lbl_valor_unit"
        Me.lbl_valor_unit.Size = New System.Drawing.Size(72, 20)
        Me.lbl_valor_unit.TabIndex = 45
        Me.lbl_valor_unit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_descont
        '
        Me.lbl_descont.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lbl_descont.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.lbl_descont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lbl_descont.Location = New System.Drawing.Point(522, 313)
        Me.lbl_descont.Name = "lbl_descont"
        Me.lbl_descont.Size = New System.Drawing.Size(89, 20)
        Me.lbl_descont.TabIndex = 46
        Me.lbl_descont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_valor_total
        '
        Me.lbl_valor_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lbl_valor_total.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.lbl_valor_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lbl_valor_total.Location = New System.Drawing.Point(238, 533)
        Me.lbl_valor_total.Name = "lbl_valor_total"
        Me.lbl_valor_total.Size = New System.Drawing.Size(101, 20)
        Me.lbl_valor_total.TabIndex = 47
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Excluir"
        Me.DataGridViewImageColumn1.Image = Global.projeto_integrado.My.Resources.Resources.search_icon24
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 50
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Transparent
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.ForeColor = System.Drawing.Color.Transparent
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.Location = New System.Drawing.Point(804, 315)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(25, 23)
        Me.btn_ok.TabIndex = 9
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'cmb_prod
        '
        Me.cmb_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_prod.Font = New System.Drawing.Font("Lucida Fax", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_prod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.cmb_prod.FormattingEnabled = True
        Me.cmb_prod.Location = New System.Drawing.Point(77, 315)
        Me.cmb_prod.Name = "cmb_prod"
        Me.cmb_prod.Size = New System.Drawing.Size(206, 24)
        Me.cmb_prod.TabIndex = 5
        '
        'frm_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(880, 620)
        Me.Controls.Add(Me.cmb_prod)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.lbl_valor_total)
        Me.Controls.Add(Me.lbl_descont)
        Me.Controls.Add(Me.lbl_valor_unit)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.txt_qtd)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.consulta_grid)
        Me.Controls.Add(Me.btn_encom_salvar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_pedido"
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
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTROLEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROMOÇÃOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AJUDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents btn_encom_salvar As Button
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents consulta_grid As DataGridView
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NOTIFICAÇÃOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONFEXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAIRDACONTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENCERRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_valor_unit As Label
    Friend WithEvents lbl_descont As Label
    Friend WithEvents lbl_valor_total As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btn_ok As Button
    Friend WithEvents cmb_prod As ComboBox
    Friend WithEvents numero_pedido As DataGridViewTextBoxColumn
    Friend WithEvents tb_pedido As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents tb_qnt As DataGridViewTextBoxColumn
    Friend WithEvents un As DataGridViewTextBoxColumn
    Friend WithEvents tb_valor As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents tb_status As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents excluir As DataGridViewImageColumn
End Class
