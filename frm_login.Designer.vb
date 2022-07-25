<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_login_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_login_senha = New System.Windows.Forms.TextBox()
        Me.btn_login_acessar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_login_cpf
        '
        Me.txt_login_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_login_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_login_cpf.Font = New System.Drawing.Font("Lucida Fax", 11.0!)
        Me.txt_login_cpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_login_cpf.Location = New System.Drawing.Point(343, 371)
        Me.txt_login_cpf.Mask = "000,000,000-00"
        Me.txt_login_cpf.Name = "txt_login_cpf"
        Me.txt_login_cpf.Size = New System.Drawing.Size(215, 25)
        Me.txt_login_cpf.TabIndex = 0
        Me.txt_login_cpf.Tag = ""
        Me.txt_login_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_login_senha
        '
        Me.txt_login_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txt_login_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_login_senha.Font = New System.Drawing.Font("Modern No. 20", 11.0!)
        Me.txt_login_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txt_login_senha.Location = New System.Drawing.Point(343, 441)
        Me.txt_login_senha.Name = "txt_login_senha"
        Me.txt_login_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_login_senha.Size = New System.Drawing.Size(215, 23)
        Me.txt_login_senha.TabIndex = 1
        Me.txt_login_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_login_acessar
        '
        Me.btn_login_acessar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btn_login_acessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_login_acessar.FlatAppearance.BorderSize = 0
        Me.btn_login_acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login_acessar.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_login_acessar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btn_login_acessar.Image = CType(resources.GetObject("btn_login_acessar.Image"), System.Drawing.Image)
        Me.btn_login_acessar.Location = New System.Drawing.Point(387, 510)
        Me.btn_login_acessar.Name = "btn_login_acessar"
        Me.btn_login_acessar.Size = New System.Drawing.Size(126, 33)
        Me.btn_login_acessar.TabIndex = 2
        Me.btn_login_acessar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XxToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 50)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'XxToolStripMenuItem
        '
        Me.XxToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.XxToolStripMenuItem.Image = CType(resources.GetObject("XxToolStripMenuItem.Image"), System.Drawing.Image)
        Me.XxToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.XxToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.XxToolStripMenuItem.Name = "XxToolStripMenuItem"
        Me.XxToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.XxToolStripMenuItem.Size = New System.Drawing.Size(28, 46)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(381, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Esqueceu sua senha?"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(900, 615)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login_acessar)
        Me.Controls.Add(Me.txt_login_senha)
        Me.Controls.Add(Me.txt_login_cpf)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_login_cpf As MaskedTextBox
    Friend WithEvents txt_login_senha As TextBox
    Friend WithEvents btn_login_acessar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents XxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
