<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class promocao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(promocao))
        Me.prom_idprod = New System.Windows.Forms.TextBox()
        Me.prom_search_icon = New System.Windows.Forms.PictureBox()
        Me.consulta_grid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_prom_salvar = New System.Windows.Forms.Button()
        Me.promocao_txt = New System.Windows.Forms.Label()
        CType(Me.prom_search_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prom_idprod
        '
        Me.prom_idprod.Location = New System.Drawing.Point(12, 90)
        Me.prom_idprod.Name = "prom_idprod"
        Me.prom_idprod.Size = New System.Drawing.Size(163, 20)
        Me.prom_idprod.TabIndex = 0
        Me.prom_idprod.Text = "ID PRODUTO"
        '
        'prom_search_icon
        '
        Me.prom_search_icon.Image = CType(resources.GetObject("prom_search_icon.Image"), System.Drawing.Image)
        Me.prom_search_icon.Location = New System.Drawing.Point(181, 90)
        Me.prom_search_icon.Name = "prom_search_icon"
        Me.prom_search_icon.Size = New System.Drawing.Size(25, 26)
        Me.prom_search_icon.TabIndex = 7
        Me.prom_search_icon.TabStop = False
        '
        'consulta_grid
        '
        Me.consulta_grid.AllowUserToAddRows = False
        Me.consulta_grid.AllowUserToDeleteRows = False
        Me.consulta_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.consulta_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.consulta_grid.Location = New System.Drawing.Point(12, 150)
        Me.consulta_grid.Name = "consulta_grid"
        Me.consulta_grid.ReadOnly = True
        Me.consulta_grid.Size = New System.Drawing.Size(776, 150)
        Me.consulta_grid.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "id_produto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "produto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "valor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "promoção"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btn_prom_salvar
        '
        Me.btn_prom_salvar.Location = New System.Drawing.Point(596, 372)
        Me.btn_prom_salvar.Name = "btn_prom_salvar"
        Me.btn_prom_salvar.Size = New System.Drawing.Size(192, 32)
        Me.btn_prom_salvar.TabIndex = 22
        Me.btn_prom_salvar.Text = "SALVAR"
        Me.btn_prom_salvar.UseVisualStyleBackColor = True
        '
        'promocao_txt
        '
        Me.promocao_txt.AutoSize = True
        Me.promocao_txt.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.promocao_txt.Location = New System.Drawing.Point(8, 22)
        Me.promocao_txt.Name = "promocao_txt"
        Me.promocao_txt.Size = New System.Drawing.Size(100, 20)
        Me.promocao_txt.TabIndex = 23
        Me.promocao_txt.Text = "PROMOÇÃO"
        '
        'promocao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.promocao_txt)
        Me.Controls.Add(Me.btn_prom_salvar)
        Me.Controls.Add(Me.consulta_grid)
        Me.Controls.Add(Me.prom_search_icon)
        Me.Controls.Add(Me.prom_idprod)
        Me.Name = "promocao"
        Me.Text = "promocao"
        CType(Me.prom_search_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.consulta_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prom_idprod As TextBox
    Friend WithEvents prom_search_icon As PictureBox
    Friend WithEvents consulta_grid As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewCheckBoxColumn
    Friend WithEvents btn_prom_salvar As Button
    Friend WithEvents promocao_txt As Label
End Class
