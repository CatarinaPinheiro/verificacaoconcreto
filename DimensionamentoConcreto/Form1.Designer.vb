<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calc
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Sub Dispose()
        Try
            If Disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(Disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtbase = New System.Windows.Forms.TextBox()
        Me.txtaltura = New System.Windows.Forms.TextBox()
        Me.txtfck = New System.Windows.Forms.TextBox()
        Me.txtfyk = New System.Windows.Forms.TextBox()
        Me.txtprotensao = New System.Windows.Forms.TextBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lb4 = New System.Windows.Forms.Label()
        Me.lb5 = New System.Windows.Forms.Label()
        Me.lb6 = New System.Windows.Forms.Label()
        Me.txtforca = New System.Windows.Forms.TextBox()
        Me.lb7 = New System.Windows.Forms.Label()
        Me.lb8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Bt1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtposicaoarmadura = New System.Windows.Forms.TextBox()
        Me.txtarmadura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtcurva = New System.Windows.Forms.ComboBox()
        Me.txtfsu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtepsu = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtbase
        '
        Me.txtbase.Location = New System.Drawing.Point(131, 35)
        Me.txtbase.Name = "txtbase"
        Me.txtbase.Size = New System.Drawing.Size(102, 20)
        Me.txtbase.TabIndex = 0
        Me.txtbase.Text = "200"
        '
        'txtaltura
        '
        Me.txtaltura.Location = New System.Drawing.Point(131, 61)
        Me.txtaltura.Name = "txtaltura"
        Me.txtaltura.Size = New System.Drawing.Size(102, 20)
        Me.txtaltura.TabIndex = 1
        Me.txtaltura.Text = "650"
        '
        'txtfck
        '
        Me.txtfck.Location = New System.Drawing.Point(470, 57)
        Me.txtfck.Name = "txtfck"
        Me.txtfck.Size = New System.Drawing.Size(102, 20)
        Me.txtfck.TabIndex = 2
        Me.txtfck.Text = "30"
        '
        'txtfyk
        '
        Me.txtfyk.Location = New System.Drawing.Point(470, 83)
        Me.txtfyk.Name = "txtfyk"
        Me.txtfyk.Size = New System.Drawing.Size(102, 20)
        Me.txtfyk.TabIndex = 3
        Me.txtfyk.Text = "500"
        '
        'txtprotensao
        '
        Me.txtprotensao.Location = New System.Drawing.Point(470, 109)
        Me.txtprotensao.Name = "txtprotensao"
        Me.txtprotensao.Size = New System.Drawing.Size(102, 20)
        Me.txtprotensao.TabIndex = 4
        Me.txtprotensao.Text = "0"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Location = New System.Drawing.Point(5, 38)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(46, 13)
        Me.lb1.TabIndex = 6
        Me.lb1.Text = "Base (b)"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Location = New System.Drawing.Point(5, 64)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(76, 13)
        Me.lb2.TabIndex = 7
        Me.lb2.Text = "Altura Total (h)"
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Location = New System.Drawing.Point(262, 64)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(204, 13)
        Me.lb3.TabIndex = 8
        Me.lb3.Text = "Resistência Característica Concreto (Fck)"
        '
        'lb4
        '
        Me.lb4.AutoSize = True
        Me.lb4.Location = New System.Drawing.Point(262, 90)
        Me.lb4.Name = "lb4"
        Me.lb4.Size = New System.Drawing.Size(179, 13)
        Me.lb4.TabIndex = 9
        Me.lb4.Text = "Resistência Característica Aço (Fyk)"
        '
        'lb5
        '
        Me.lb5.AutoSize = True
        Me.lb5.Location = New System.Drawing.Point(262, 116)
        Me.lb5.Name = "lb5"
        Me.lb5.Size = New System.Drawing.Size(145, 13)
        Me.lb5.TabIndex = 10
        Me.lb5.Text = "Influência da Protensão (γsp)"
        '
        'lb6
        '
        Me.lb6.AutoSize = True
        Me.lb6.Location = New System.Drawing.Point(5, 90)
        Me.lb6.Name = "lb6"
        Me.lb6.Size = New System.Drawing.Size(0, 13)
        Me.lb6.TabIndex = 11
        '
        'txtforca
        '
        Me.txtforca.Location = New System.Drawing.Point(131, 158)
        Me.txtforca.Name = "txtforca"
        Me.txtforca.Size = New System.Drawing.Size(102, 20)
        Me.txtforca.TabIndex = 13
        Me.txtforca.Text = "0"
        '
        'lb7
        '
        Me.lb7.AutoSize = True
        Me.lb7.Location = New System.Drawing.Point(262, 38)
        Me.lb7.Name = "lb7"
        Me.lb7.Size = New System.Drawing.Size(135, 13)
        Me.lb7.TabIndex = 14
        Me.lb7.Text = "Curva Tensão Deformação"
        '
        'lb8
        '
        Me.lb8.AutoSize = True
        Me.lb8.Location = New System.Drawing.Point(0, 101)
        Me.lb8.Name = "lb8"
        Me.lb8.Size = New System.Drawing.Size(105, 13)
        Me.lb8.TabIndex = 15
        Me.lb8.Text = "Esforços Solicitantes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 16
        '
        'Bt1
        '
        Me.Bt1.Location = New System.Drawing.Point(497, 286)
        Me.Bt1.Name = "Bt1"
        Me.Bt1.Size = New System.Drawing.Size(75, 23)
        Me.Bt1.TabIndex = 17
        Me.Bt1.Text = "Calcular"
        Me.Bt1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Geometria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "cm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "cm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(262, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Material:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Força Normal (N)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Área de Armadura (As)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Verificação:"
        '
        'txtposicaoarmadura
        '
        Me.txtposicaoarmadura.Location = New System.Drawing.Point(131, 251)
        Me.txtposicaoarmadura.Name = "txtposicaoarmadura"
        Me.txtposicaoarmadura.Size = New System.Drawing.Size(100, 20)
        Me.txtposicaoarmadura.TabIndex = 26
        Me.txtposicaoarmadura.Text = "610"
        '
        'txtarmadura
        '
        Me.txtarmadura.Location = New System.Drawing.Point(131, 225)
        Me.txtarmadura.Name = "txtarmadura"
        Me.txtarmadura.Size = New System.Drawing.Size(100, 20)
        Me.txtarmadura.TabIndex = 27
        Me.txtarmadura.Text = "1250"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Posição da Armadura (Ds)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(262, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Resultados:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(262, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Momento (M)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(262, 262)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Esforço Normal (N)"
        '
        'txtcurva
        '
        Me.txtcurva.DisplayMember = "CEB"
        Me.txtcurva.FormattingEnabled = True
        Me.txtcurva.Items.AddRange(New Object() {"CEB", "EN ( em breve )", "NBR( em breve )", "NS ( em breve )"})
        Me.txtcurva.Location = New System.Drawing.Point(470, 30)
        Me.txtcurva.Name = "txtcurva"
        Me.txtcurva.Size = New System.Drawing.Size(102, 21)
        Me.txtcurva.TabIndex = 41
        Me.txtcurva.Text = "CEB"
        '
        'txtfsu
        '
        Me.txtfsu.Location = New System.Drawing.Point(470, 162)
        Me.txtfsu.Name = "txtfsu"
        Me.txtfsu.Size = New System.Drawing.Size(100, 20)
        Me.txtfsu.TabIndex = 42
        Me.txtfsu.Text = "600"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Resistência última do aço (fsu)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(262, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Deformação última do aço (epsu)"
        '
        'txtepsu
        '
        Me.txtepsu.Location = New System.Drawing.Point(470, 135)
        Me.txtepsu.Name = "txtepsu"
        Me.txtepsu.Size = New System.Drawing.Size(100, 20)
        Me.txtepsu.TabIndex = 45
        Me.txtepsu.Text = "50"
        '
        'Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(584, 311)
        Me.Controls.Add(Me.txtepsu)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfsu)
        Me.Controls.Add(Me.txtcurva)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtarmadura)
        Me.Controls.Add(Me.txtposicaoarmadura)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lb8)
        Me.Controls.Add(Me.lb7)
        Me.Controls.Add(Me.txtforca)
        Me.Controls.Add(Me.lb6)
        Me.Controls.Add(Me.lb5)
        Me.Controls.Add(Me.lb4)
        Me.Controls.Add(Me.lb3)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.txtprotensao)
        Me.Controls.Add(Me.txtfyk)
        Me.Controls.Add(Me.txtfck)
        Me.Controls.Add(Me.txtaltura)
        Me.Controls.Add(Me.txtbase)
        Me.Name = "Calc"
        Me.Text = "Calculadora Flexão Composta Normal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents txtbase As TextBox
    Friend WithEvents txtaltura As TextBox
    Friend WithEvents txtfck As TextBox
    Friend WithEvents txtfyk As TextBox
    Friend WithEvents txtprotensao As TextBox
    Friend WithEvents lb1 As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents lb4 As Label
    Friend WithEvents lb5 As Label
    Friend WithEvents lb6 As Label
    Friend WithEvents txtforca As TextBox
    Friend WithEvents lb7 As Label
    Friend WithEvents lb8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Bt1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtposicaoarmadura As TextBox
    Friend WithEvents txtarmadura As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtcurva As ComboBox
    Friend WithEvents txtfsu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtepsu As TextBox
End Class
