<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class controle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(controle))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consulta_grid = New System.Windows.Forms.DataGridView()
        Me.numero_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_qnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ctrle_idprod = New System.Windows.Forms.TextBox()
        Me.ctrle_search_icon = New System.Windows.Forms.PictureBox()
        Me.controle_txt = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctrle_search_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 23)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Nome:"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Email:"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Telefone:"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'consulta_grid
        '
        Me.consulta_grid.AllowUserToAddRows = False
        Me.consulta_grid.AllowUserToDeleteRows = False
        Me.consulta_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.consulta_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero_pedido, Me.tb_data, Me.tb_hora, Me.tb_pedido, Me.tb_qnt, Me.tb_valor, Me.tb_status})
        Me.consulta_grid.Location = New System.Drawing.Point(12, 180)
        Me.consulta_grid.Name = "consulta_grid"
        Me.consulta_grid.ReadOnly = True
        Me.consulta_grid.Size = New System.Drawing.Size(776, 150)
        Me.consulta_grid.TabIndex = 3
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
        Me.tb_status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tb_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ctrle_idprod
        '
        Me.ctrle_idprod.Location = New System.Drawing.Point(16, 67)
        Me.ctrle_idprod.Name = "ctrle_idprod"
        Me.ctrle_idprod.Size = New System.Drawing.Size(163, 20)
        Me.ctrle_idprod.TabIndex = 0
        Me.ctrle_idprod.Text = "ID PRODUTO"
        '
        'ctrle_search_icon
        '
        Me.ctrle_search_icon.Image = CType(resources.GetObject("ctrle_search_icon.Image"), System.Drawing.Image)
        Me.ctrle_search_icon.Location = New System.Drawing.Point(185, 67)
        Me.ctrle_search_icon.Name = "ctrle_search_icon"
        Me.ctrle_search_icon.Size = New System.Drawing.Size(25, 26)
        Me.ctrle_search_icon.TabIndex = 6
        Me.ctrle_search_icon.TabStop = False
        '
        'controle_txt
        '
        Me.controle_txt.AutoSize = True
        Me.controle_txt.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controle_txt.Location = New System.Drawing.Point(12, 21)
        Me.controle_txt.Name = "controle_txt"
        Me.controle_txt.Size = New System.Drawing.Size(90, 20)
        Me.controle_txt.TabIndex = 24
        Me.controle_txt.Text = "CONTROLE"
        '
        'controle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.controle_txt)
        Me.Controls.Add(Me.ctrle_search_icon)
        Me.Controls.Add(Me.ctrle_idprod)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.consulta_grid)
        Me.Name = "controle"
        Me.Text = "controle"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctrle_search_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents consulta_grid As DataGridView
    Friend WithEvents ctrle_idprod As TextBox
    Friend WithEvents numero_pedido As DataGridViewTextBoxColumn
    Friend WithEvents tb_data As DataGridViewTextBoxColumn
    Friend WithEvents tb_hora As DataGridViewTextBoxColumn
    Friend WithEvents tb_pedido As DataGridViewTextBoxColumn
    Friend WithEvents tb_qnt As DataGridViewTextBoxColumn
    Friend WithEvents tb_valor As DataGridViewTextBoxColumn
    Friend WithEvents tb_status As DataGridViewComboBoxColumn
    Friend WithEvents ctrle_search_icon As PictureBox
    Friend WithEvents controle_txt As Label
End Class
