<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.txtNomeAmostra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiametro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdAmostra = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(178, 176)
        Me.btnCadastrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(84, 41)
        Me.btnCadastrar.TabIndex = 0
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(267, 176)
        Me.btnAtualizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(84, 41)
        Me.btnAtualizar.TabIndex = 0
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(356, 176)
        Me.btnDeletar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(84, 41)
        Me.btnDeletar.TabIndex = 0
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'txtNomeAmostra
        '
        Me.txtNomeAmostra.Location = New System.Drawing.Point(175, 52)
        Me.txtNomeAmostra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNomeAmostra.Name = "txtNomeAmostra"
        Me.txtNomeAmostra.Size = New System.Drawing.Size(295, 20)
        Me.txtNomeAmostra.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Amostra"
        '
        'txtDiametro
        '
        Me.txtDiametro.Location = New System.Drawing.Point(175, 85)
        Me.txtDiametro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDiametro.Name = "txtDiametro"
        Me.txtDiametro.Size = New System.Drawing.Size(295, 20)
        Me.txtDiametro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Diâmetro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Área:"
        '
        'lblArea
        '
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArea.Location = New System.Drawing.Point(175, 120)
        Me.lblArea.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(294, 21)
        Me.lblArea.TabIndex = 4
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Id:"
        '
        'txtIdAmostra
        '
        Me.txtIdAmostra.Location = New System.Drawing.Point(175, 19)
        Me.txtIdAmostra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIdAmostra.Name = "txtIdAmostra"
        Me.txtIdAmostra.Size = New System.Drawing.Size(295, 20)
        Me.txtIdAmostra.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(444, 176)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(84, 41)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(90, 176)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(84, 41)
        Me.btnLimpar.TabIndex = 0
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 254)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDiametro)
        Me.Controls.Add(Me.txtIdAmostra)
        Me.Controls.Add(Me.txtNomeAmostra)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(636, 293)
        Me.MinimumSize = New System.Drawing.Size(636, 293)
        Me.Name = "Form1"
        Me.Text = "Cadastro Básico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnDeletar As Button
    Friend WithEvents txtNomeAmostra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiametro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdAmostra As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpar As Button
End Class
