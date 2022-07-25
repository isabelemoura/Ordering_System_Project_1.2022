<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_comanda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_comanda))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv_itens = New System.Windows.Forms.DataGridView()
        Me.numero_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_qnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.un = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_pedido = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv_itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(565, 60)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Image = CType(resources.GetObject("TestToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(125, 56)
        '
        'dgv_itens
        '
        Me.dgv_itens.AllowUserToAddRows = False
        Me.dgv_itens.AllowUserToDeleteRows = False
        Me.dgv_itens.BackgroundColor = System.Drawing.Color.White
        Me.dgv_itens.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_itens.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_itens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero_pedido, Me.tb_pedido, Me.Column1, Me.tb_qnt, Me.un, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_itens.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_itens.EnableHeadersVisualStyles = False
        Me.dgv_itens.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv_itens.Location = New System.Drawing.Point(21, 186)
        Me.dgv_itens.Name = "dgv_itens"
        Me.dgv_itens.ReadOnly = True
        Me.dgv_itens.Size = New System.Drawing.Size(522, 225)
        Me.dgv_itens.TabIndex = 29
        '
        'numero_pedido
        '
        Me.numero_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.numero_pedido.HeaderText = "Item"
        Me.numero_pedido.MinimumWidth = 40
        Me.numero_pedido.Name = "numero_pedido"
        Me.numero_pedido.ReadOnly = True
        Me.numero_pedido.Width = 62
        '
        'tb_pedido
        '
        Me.tb_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tb_pedido.HeaderText = "ID Produto"
        Me.tb_pedido.Name = "tb_pedido"
        Me.tb_pedido.ReadOnly = True
        Me.tb_pedido.Width = 104
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Descrição"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 96
        '
        'tb_qnt
        '
        Me.tb_qnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.tb_qnt.DefaultCellStyle = DataGridViewCellStyle2
        Me.tb_qnt.HeaderText = "Qtd."
        Me.tb_qnt.Name = "tb_qnt"
        Me.tb_qnt.ReadOnly = True
        Me.tb_qnt.Width = 61
        '
        'un
        '
        Me.un.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.un.HeaderText = "Unid."
        Me.un.Name = "un"
        Me.un.ReadOnly = True
        Me.un.Width = 68
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Obs."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 62
        '
        'lbl_data
        '
        Me.lbl_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lbl_data.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.lbl_data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lbl_data.Location = New System.Drawing.Point(136, 134)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(96, 20)
        Me.lbl_data.TabIndex = 46
        Me.lbl_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_pedido
        '
        Me.lbl_pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lbl_pedido.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.lbl_pedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lbl_pedido.Location = New System.Drawing.Point(369, 134)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(98, 20)
        Me.lbl_pedido.TabIndex = 47
        Me.lbl_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lbl_total.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.lbl_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lbl_total.Location = New System.Drawing.Point(276, 438)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(121, 20)
        Me.lbl_total.TabIndex = 48
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_comanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(565, 481)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_pedido)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.dgv_itens)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Name = "frm_comanda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMANDA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv_itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgv_itens As DataGridView
    Friend WithEvents numero_pedido As DataGridViewTextBoxColumn
    Friend WithEvents tb_pedido As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents tb_qnt As DataGridViewTextBoxColumn
    Friend WithEvents un As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_pedido As Label
    Friend WithEvents lbl_total As Label
End Class
