<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_promo_notif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_promo_notif))
        Me.TxtAssunto = New System.Windows.Forms.TextBox()
        Me.TxtMensagem = New System.Windows.Forms.TextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.LblAnexo = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.dgv_test = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_dest = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmb_prod = New System.Windows.Forms.ComboBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_test, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtAssunto
        '
        Me.TxtAssunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TxtAssunto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAssunto.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.TxtAssunto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TxtAssunto.Location = New System.Drawing.Point(48, 282)
        Me.TxtAssunto.Name = "TxtAssunto"
        Me.TxtAssunto.Size = New System.Drawing.Size(310, 15)
        Me.TxtAssunto.TabIndex = 2
        '
        'TxtMensagem
        '
        Me.TxtMensagem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TxtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMensagem.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.TxtMensagem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TxtMensagem.Location = New System.Drawing.Point(48, 338)
        Me.TxtMensagem.Multiline = True
        Me.TxtMensagem.Name = "TxtMensagem"
        Me.TxtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMensagem.Size = New System.Drawing.Size(308, 76)
        Me.TxtMensagem.TabIndex = 3
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BtnEnviar.Image = CType(resources.GetObject("BtnEnviar.Image"), System.Drawing.Image)
        Me.BtnEnviar.Location = New System.Drawing.Point(129, 496)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(128, 28)
        Me.BtnEnviar.TabIndex = 5
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'LblAnexo
        '
        Me.LblAnexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LblAnexo.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.LblAnexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.LblAnexo.Location = New System.Drawing.Point(48, 444)
        Me.LblAnexo.Name = "LblAnexo"
        Me.LblAnexo.Size = New System.Drawing.Size(310, 23)
        Me.LblAnexo.TabIndex = 4
        Me.LblAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'dgv_test
        '
        Me.dgv_test.AllowUserToAddRows = False
        Me.dgv_test.AllowUserToDeleteRows = False
        Me.dgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_test.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgv_test.Location = New System.Drawing.Point(474, 391)
        Me.dgv_test.Name = "dgv_test"
        Me.dgv_test.ReadOnly = True
        Me.dgv_test.Size = New System.Drawing.Size(230, 75)
        Me.dgv_test.TabIndex = 41
        Me.dgv_test.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "email"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'lbl_dest
        '
        Me.lbl_dest.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.lbl_dest.Font = New System.Drawing.Font("Lucida Fax", 9.5!)
        Me.lbl_dest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lbl_dest.Location = New System.Drawing.Point(48, 220)
        Me.lbl_dest.Name = "lbl_dest"
        Me.lbl_dest.Size = New System.Drawing.Size(308, 23)
        Me.lbl_dest.TabIndex = 1
        Me.lbl_dest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 60)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Image = CType(resources.GetObject("TestToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(125, 56)
        '
        'cmb_prod
        '
        Me.cmb_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_prod.Font = New System.Drawing.Font("Lucida Fax", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_prod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.cmb_prod.FormattingEnabled = True
        Me.cmb_prod.Location = New System.Drawing.Point(47, 166)
        Me.cmb_prod.Name = "cmb_prod"
        Me.cmb_prod.Size = New System.Drawing.Size(309, 24)
        Me.cmb_prod.TabIndex = 0
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.Transparent
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(426, 133)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(304, 334)
        Me.img_foto.TabIndex = 44
        Me.img_foto.TabStop = False
        '
        'frm_promo_notif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 541)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.cmb_prod)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lbl_dest)
        Me.Controls.Add(Me.dgv_test)
        Me.Controls.Add(Me.LblAnexo)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.TxtMensagem)
        Me.Controls.Add(Me.TxtAssunto)
        Me.Name = "frm_promo_notif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notificação de Promoção"
        CType(Me.dgv_test, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtAssunto As TextBox
    Friend WithEvents TxtMensagem As TextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents LblAnexo As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents dgv_test As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_dest As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmb_prod As ComboBox
    Friend WithEvents img_foto As PictureBox
End Class
