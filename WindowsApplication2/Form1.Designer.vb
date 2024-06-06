<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBoxVotante = New System.Windows.Forms.GroupBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.botonDeVotar = New System.Windows.Forms.Button()
        Me.textBoxCedula = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelCandidatoDonRamon = New System.Windows.Forms.Label()
        Me.LabelCandidatoBotija = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.buttonRegresarElecciones = New System.Windows.Forms.Button()
        Me.buttonIngresar = New System.Windows.Forms.Button()
        Me.textBoxContraseña = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoxResultadoPetro = New System.Windows.Forms.TextBox()
        Me.BoxResultadoRodolfoHernandez = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.pictureBoxEmpate = New System.Windows.Forms.PictureBox()
        Me.buttonResultados = New System.Windows.Forms.Button()
        Me.buttonReiniciarElecciones = New System.Windows.Forms.Button()
        Me.groupBoxReiniciarElecciones = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.buttonContraseñaReiniciarElecciones = New System.Windows.Forms.Button()
        Me.textBoxContraseñaReiniciarElecciones = New System.Windows.Forms.TextBox()
        Me.PictureBoxRodolfoHernandezPresidente = New System.Windows.Forms.PictureBox()
        Me.pictureBoxPetroPresidente = New System.Windows.Forms.PictureBox()
        Me.groupBoxVotante.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pictureBoxEmpate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxReiniciarElecciones.SuspendLayout()
        CType(Me.PictureBoxRodolfoHernandezPresidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxPetroPresidente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxVotante
        '
        Me.groupBoxVotante.BackColor = System.Drawing.Color.Transparent
        Me.groupBoxVotante.Controls.Add(Me.labelNombre)
        Me.groupBoxVotante.Controls.Add(Me.TextBox2)
        Me.groupBoxVotante.Controls.Add(Me.TextBox1)
        Me.groupBoxVotante.Controls.Add(Me.botonDeVotar)
        Me.groupBoxVotante.Controls.Add(Me.textBoxCedula)
        Me.groupBoxVotante.Location = New System.Drawing.Point(37, 48)
        Me.groupBoxVotante.Name = "groupBoxVotante"
        Me.groupBoxVotante.Size = New System.Drawing.Size(391, 139)
        Me.groupBoxVotante.TabIndex = 0
        Me.groupBoxVotante.TabStop = False
        Me.groupBoxVotante.Text = "Votante"
        Me.groupBoxVotante.Visible = False
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(9, 75)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(44, 13)
        Me.labelNombre.TabIndex = 4
        Me.labelNombre.Text = "Nombre"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(54, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(54, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'botonDeVotar
        '
        Me.botonDeVotar.Location = New System.Drawing.Point(219, 55)
        Me.botonDeVotar.Name = "botonDeVotar"
        Me.botonDeVotar.Size = New System.Drawing.Size(75, 23)
        Me.botonDeVotar.TabIndex = 1
        Me.botonDeVotar.Text = "Votar"
        Me.botonDeVotar.UseVisualStyleBackColor = True
        '
        'textBoxCedula
        '
        Me.textBoxCedula.AutoSize = True
        Me.textBoxCedula.Location = New System.Drawing.Point(9, 37)
        Me.textBoxCedula.Name = "textBoxCedula"
        Me.textBoxCedula.Size = New System.Drawing.Size(40, 13)
        Me.textBoxCedula.TabIndex = 0
        Me.textBoxCedula.Text = "Cedula"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelCandidatoDonRamon)
        Me.GroupBox2.Controls.Add(Me.LabelCandidatoBotija)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Candidatos"
        Me.GroupBox2.Visible = False
        '
        'LabelCandidatoDonRamon
        '
        Me.LabelCandidatoDonRamon.AutoSize = True
        Me.LabelCandidatoDonRamon.Location = New System.Drawing.Point(60, 131)
        Me.LabelCandidatoDonRamon.Name = "LabelCandidatoDonRamon"
        Me.LabelCandidatoDonRamon.Size = New System.Drawing.Size(32, 13)
        Me.LabelCandidatoDonRamon.TabIndex = 4
        Me.LabelCandidatoDonRamon.Text = "Petro"
        '
        'LabelCandidatoBotija
        '
        Me.LabelCandidatoBotija.AutoSize = True
        Me.LabelCandidatoBotija.Location = New System.Drawing.Point(235, 131)
        Me.LabelCandidatoBotija.Name = "LabelCandidatoBotija"
        Me.LabelCandidatoBotija.Size = New System.Drawing.Size(99, 13)
        Me.LabelCandidatoBotija.TabIndex = 2
        Me.LabelCandidatoBotija.Text = "Rodolfo Hernandez"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(234, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 86)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(25, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 86)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.buttonRegresarElecciones)
        Me.GroupBox4.Controls.Add(Me.buttonIngresar)
        Me.GroupBox4.Controls.Add(Me.textBoxContraseña)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(153, 199)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(249, 70)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Solo personal autorizado"
        Me.GroupBox4.Visible = False
        '
        'buttonRegresarElecciones
        '
        Me.buttonRegresarElecciones.Location = New System.Drawing.Point(111, 45)
        Me.buttonRegresarElecciones.Name = "buttonRegresarElecciones"
        Me.buttonRegresarElecciones.Size = New System.Drawing.Size(129, 23)
        Me.buttonRegresarElecciones.TabIndex = 19
        Me.buttonRegresarElecciones.Text = "Regresar a Elecciones"
        Me.buttonRegresarElecciones.UseVisualStyleBackColor = True
        '
        'buttonIngresar
        '
        Me.buttonIngresar.Location = New System.Drawing.Point(6, 45)
        Me.buttonIngresar.Name = "buttonIngresar"
        Me.buttonIngresar.Size = New System.Drawing.Size(75, 23)
        Me.buttonIngresar.TabIndex = 18
        Me.buttonIngresar.Text = "Ingresar"
        Me.buttonIngresar.UseVisualStyleBackColor = True
        '
        'textBoxContraseña
        '
        Me.textBoxContraseña.Location = New System.Drawing.Point(26, 19)
        Me.textBoxContraseña.Name = "textBoxContraseña"
        Me.textBoxContraseña.Size = New System.Drawing.Size(149, 20)
        Me.textBoxContraseña.TabIndex = 17
        Me.textBoxContraseña.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(650, 568)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Petro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rodolfo Hernandez"
        '
        'BoxResultadoPetro
        '
        Me.BoxResultadoPetro.Enabled = False
        Me.BoxResultadoPetro.Location = New System.Drawing.Point(120, 16)
        Me.BoxResultadoPetro.Name = "BoxResultadoPetro"
        Me.BoxResultadoPetro.Size = New System.Drawing.Size(100, 20)
        Me.BoxResultadoPetro.TabIndex = 5
        Me.BoxResultadoPetro.Text = "0"
        '
        'BoxResultadoRodolfoHernandez
        '
        Me.BoxResultadoRodolfoHernandez.Enabled = False
        Me.BoxResultadoRodolfoHernandez.Location = New System.Drawing.Point(120, 57)
        Me.BoxResultadoRodolfoHernandez.Name = "BoxResultadoRodolfoHernandez"
        Me.BoxResultadoRodolfoHernandez.Size = New System.Drawing.Size(100, 20)
        Me.BoxResultadoRodolfoHernandez.TabIndex = 6
        Me.BoxResultadoRodolfoHernandez.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.BoxResultadoPetro)
        Me.GroupBox3.Controls.Add(Me.BoxResultadoRodolfoHernandez)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 391)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 112)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultados"
        Me.GroupBox3.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(479, 520)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 19)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Solo Personal Autorizado"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(484, 480)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(129, 23)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Regresar a elecciones"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'pictureBoxEmpate
        '
        Me.pictureBoxEmpate.BackgroundImage = CType(resources.GetObject("pictureBoxEmpate.BackgroundImage"), System.Drawing.Image)
        Me.pictureBoxEmpate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBoxEmpate.Location = New System.Drawing.Point(12, 48)
        Me.pictureBoxEmpate.Name = "pictureBoxEmpate"
        Me.pictureBoxEmpate.Size = New System.Drawing.Size(583, 307)
        Me.pictureBoxEmpate.TabIndex = 28
        Me.pictureBoxEmpate.TabStop = False
        Me.pictureBoxEmpate.Visible = False
        '
        'buttonResultados
        '
        Me.buttonResultados.Location = New System.Drawing.Point(311, 435)
        Me.buttonResultados.Name = "buttonResultados"
        Me.buttonResultados.Size = New System.Drawing.Size(75, 23)
        Me.buttonResultados.TabIndex = 20
        Me.buttonResultados.Text = "Resultados"
        Me.buttonResultados.UseVisualStyleBackColor = True
        Me.buttonResultados.Visible = False
        '
        'buttonReiniciarElecciones
        '
        Me.buttonReiniciarElecciones.Location = New System.Drawing.Point(341, 476)
        Me.buttonReiniciarElecciones.Name = "buttonReiniciarElecciones"
        Me.buttonReiniciarElecciones.Size = New System.Drawing.Size(113, 23)
        Me.buttonReiniciarElecciones.TabIndex = 29
        Me.buttonReiniciarElecciones.Text = "Reiniciar Elecciones"
        Me.buttonReiniciarElecciones.UseVisualStyleBackColor = True
        Me.buttonReiniciarElecciones.Visible = False
        '
        'groupBoxReiniciarElecciones
        '
        Me.groupBoxReiniciarElecciones.Controls.Add(Me.Button4)
        Me.groupBoxReiniciarElecciones.Controls.Add(Me.buttonContraseñaReiniciarElecciones)
        Me.groupBoxReiniciarElecciones.Controls.Add(Me.textBoxContraseñaReiniciarElecciones)
        Me.groupBoxReiniciarElecciones.Location = New System.Drawing.Point(163, 193)
        Me.groupBoxReiniciarElecciones.Name = "groupBoxReiniciarElecciones"
        Me.groupBoxReiniciarElecciones.Size = New System.Drawing.Size(246, 91)
        Me.groupBoxReiniciarElecciones.TabIndex = 30
        Me.groupBoxReiniciarElecciones.TabStop = False
        Me.groupBoxReiniciarElecciones.Text = "Reiniciar elecciones"
        Me.groupBoxReiniciarElecciones.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(102, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Regresar a elecciones"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'buttonContraseñaReiniciarElecciones
        '
        Me.buttonContraseñaReiniciarElecciones.Location = New System.Drawing.Point(21, 61)
        Me.buttonContraseñaReiniciarElecciones.Name = "buttonContraseñaReiniciarElecciones"
        Me.buttonContraseñaReiniciarElecciones.Size = New System.Drawing.Size(75, 23)
        Me.buttonContraseñaReiniciarElecciones.TabIndex = 1
        Me.buttonContraseñaReiniciarElecciones.Text = "Reiniciar"
        Me.buttonContraseñaReiniciarElecciones.UseVisualStyleBackColor = True
        '
        'textBoxContraseñaReiniciarElecciones
        '
        Me.textBoxContraseñaReiniciarElecciones.Location = New System.Drawing.Point(62, 35)
        Me.textBoxContraseñaReiniciarElecciones.Name = "textBoxContraseñaReiniciarElecciones"
        Me.textBoxContraseñaReiniciarElecciones.Size = New System.Drawing.Size(100, 20)
        Me.textBoxContraseñaReiniciarElecciones.TabIndex = 0
        '
        'PictureBoxRodolfoHernandezPresidente
        '
        Me.PictureBoxRodolfoHernandezPresidente.BackgroundImage = CType(resources.GetObject("PictureBoxRodolfoHernandezPresidente.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxRodolfoHernandezPresidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxRodolfoHernandezPresidente.Location = New System.Drawing.Point(3, 71)
        Me.PictureBoxRodolfoHernandezPresidente.Name = "PictureBoxRodolfoHernandezPresidente"
        Me.PictureBoxRodolfoHernandezPresidente.Size = New System.Drawing.Size(639, 303)
        Me.PictureBoxRodolfoHernandezPresidente.TabIndex = 27
        Me.PictureBoxRodolfoHernandezPresidente.TabStop = False
        Me.PictureBoxRodolfoHernandezPresidente.Visible = False
        '
        'pictureBoxPetroPresidente
        '
        Me.pictureBoxPetroPresidente.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxPetroPresidente.BackgroundImage = CType(resources.GetObject("pictureBoxPetroPresidente.BackgroundImage"), System.Drawing.Image)
        Me.pictureBoxPetroPresidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBoxPetroPresidente.Enabled = False
        Me.pictureBoxPetroPresidente.Location = New System.Drawing.Point(-18, 48)
        Me.pictureBoxPetroPresidente.Name = "pictureBoxPetroPresidente"
        Me.pictureBoxPetroPresidente.Size = New System.Drawing.Size(671, 313)
        Me.pictureBoxPetroPresidente.TabIndex = 26
        Me.pictureBoxPetroPresidente.TabStop = False
        Me.pictureBoxPetroPresidente.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 564)
        Me.Controls.Add(Me.groupBoxReiniciarElecciones)
        Me.Controls.Add(Me.buttonReiniciarElecciones)
        Me.Controls.Add(Me.buttonResultados)
        Me.Controls.Add(Me.pictureBoxPetroPresidente)
        Me.Controls.Add(Me.PictureBoxRodolfoHernandezPresidente)
        Me.Controls.Add(Me.pictureBoxEmpate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupBoxVotante)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COLOMBIA DECIDE 2022"
        Me.groupBoxVotante.ResumeLayout(False)
        Me.groupBoxVotante.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pictureBoxEmpate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxReiniciarElecciones.ResumeLayout(False)
        Me.groupBoxReiniciarElecciones.PerformLayout()
        CType(Me.PictureBoxRodolfoHernandezPresidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxPetroPresidente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupBoxVotante As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents botonDeVotar As System.Windows.Forms.Button
    Friend WithEvents textBoxCedula As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelCandidatoDonRamon As System.Windows.Forms.Label
    Friend WithEvents LabelCandidatoBotija As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoxResultadoPetro As System.Windows.Forms.TextBox
    Friend WithEvents BoxResultadoRodolfoHernandez As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents buttonRegresarElecciones As System.Windows.Forms.Button
    Friend WithEvents buttonIngresar As System.Windows.Forms.Button
    Friend WithEvents textBoxContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents pictureBoxEmpate As System.Windows.Forms.PictureBox
    Friend WithEvents buttonResultados As System.Windows.Forms.Button
    Friend WithEvents buttonReiniciarElecciones As System.Windows.Forms.Button
    Friend WithEvents groupBoxReiniciarElecciones As System.Windows.Forms.GroupBox
    Friend WithEvents buttonContraseñaReiniciarElecciones As System.Windows.Forms.Button
    Friend WithEvents textBoxContraseñaReiniciarElecciones As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBoxRodolfoHernandezPresidente As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBoxPetroPresidente As System.Windows.Forms.PictureBox

End Class
