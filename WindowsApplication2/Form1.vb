Public Class Form1
    Public cedulas(9), i As Integer
    Public nombres(9) As String
    Dim pos As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cedulas(0) = 1193119006
        nombres(0) = "Alexis"
        cedulas(1) = 1193119007
        nombres(1) = "pedro"
        cedulas(2) = 1193119008
        nombres(2) = "alex"
        cedulas(3) = 1193119009
        nombres(3) = "carlos"
        cedulas(4) = 1193119010
        nombres(4) = "arturo"
        cedulas(5) = 1193119011
        nombres(5) = "Juan"
        cedulas(6) = 1193119012
        nombres(6) = "Maria"
        cedulas(7) = 1193119013
        nombres(7) = "Sandra"
        cedulas(8) = 1193119014
        nombres(8) = "Jose"
        cedulas(9) = 1193119015
        nombres(9) = "Santiago"

        TextBox1.Clear()
        TextBox1.Focus()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox2.Visible = False
        groupBoxVotante.Visible = True
        Button3.Visible = False
        pictureBoxPetroPresidente.Visible = False
        Button6.Visible = False

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub







    Private Sub botonDeVotar_Click(sender As Object, e As EventArgs) Handles botonDeVotar.Click
        cedulas(0) = 1193119006
        nombres(0) = "Alexis"
        cedulas(1) = 1193119007
        nombres(1) = "pedro"
        cedulas(2) = 1193119008
        nombres(2) = "alex"
        cedulas(3) = 1193119009
        nombres(3) = "carlos"
        cedulas(4) = 1193119010
        nombres(4) = "arturo"
        cedulas(5) = 1193119011
        nombres(5) = "Juan"
        cedulas(6) = 1193119012
        nombres(6) = "Maria"
        cedulas(7) = 1193119013
        nombres(7) = "Sandra"
        cedulas(8) = 1193119014
        nombres(8) = "Jose"
        cedulas(9) = 1193119015
        nombres(9) = "Santiago"


        If TextBox1.Text > "1193119015" Then
            MessageBox.Show("Numero no encontrado en la base de datos ")

        End If
        If TextBox1.Text < 1193119006 Then
            MessageBox.Show("Numero no encontrado en la base de datos ")
        End If

        If TextBox1.Text = "1193119006" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Alexis"



        ElseIf TextBox1.Text = "1193119007" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Pedro"

        ElseIf TextBox1.Text = "1193119008" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Alex"

        ElseIf TextBox1.Text = "1193119009" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Carlos"

        ElseIf TextBox1.Text = "1193119010" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Arturo"

        ElseIf TextBox1.Text = "1193119011" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Juan"

        ElseIf TextBox1.Text = "1193119012" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Maria"

        ElseIf TextBox1.Text = "1193119013" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Sandra"

        ElseIf TextBox1.Text = "1193119014" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Jose"

        ElseIf TextBox1.Text = "1193119015" Then
            MessageBox.Show("Por favor elija bien, una vez seleccionado su voto no puede ser cambiado")
            GroupBox2.Visible = True
            TextBox2.Text = "Santiago"



            GroupBox2.Visible = True
            GroupBox2.Visible = True


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        BoxResultadoPetro.Text += 1
        Button3.Visible = True
        GroupBox2.Visible = False
        groupBoxVotante.Visible = False

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        BoxResultadoRodolfoHernandez.Text += 1
        Button3.Visible = True
        GroupBox2.Visible = False
        groupBoxVotante.Visible = False
    End Sub







    Private Sub buttonIngresar_Click(sender As Object, e As EventArgs) Handles buttonIngresar.Click
       


        If textBoxContraseña.Text = "1530" Then
            buttonResultados.Visible = True
            GroupBox4.Visible = False
            buttonReiniciarElecciones.Visible = True
        ElseIf textBoxContraseña.Text <> "1530" Then
            MessageBox.Show("La contraseña que escribio es incorrecta")
            textBoxContraseña.Clear()
            textBoxContraseña.Focus()
        End If
        Button6.Visible = True
        groupBoxVotante.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub buttonRegresarElecciones_Click(sender As Object, e As EventArgs) Handles buttonRegresarElecciones.Click

        buttonReiniciarElecciones.Visible = False
        Button3.Visible = True
        GroupBox4.Visible = False
        textBoxContraseña.Clear()
        Button5.Visible = True
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        groupBoxVotante.Visible = False
        GroupBox2.Visible = False
        textBoxContraseña.Clear()
        textBoxContraseñaReiniciarElecciones.Clear()
        Button3.Visible = False
        textBoxContraseña.Visible = True
        GroupBox4.Visible = True
        GroupBox3.Visible = False
        Button5.Visible = False
        textBoxContraseña.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox3.Visible = False
        buttonResultados.Visible = False
        Button3.Visible = True
        Button5.Visible = True

        Button6.Visible = False
        pictureBoxPetroPresidente.Visible = False
        PictureBoxRodolfoHernandezPresidente.Visible = False
        pictureBoxEmpate.Visible = False
        textBoxContraseña.Clear()
        buttonReiniciarElecciones.Visible = False
        groupBoxReiniciarElecciones.Visible = False

    End Sub

   
   
   
    
 
    Private Sub buttonResultados_Click(sender As Object, e As EventArgs) Handles buttonResultados.Click
        GroupBox3.Visible = True
        If BoxResultadoPetro.Text > BoxResultadoRodolfoHernandez.Text Then
            pictureBoxPetroPresidente.Visible = True
            PictureBoxRodolfoHernandezPresidente.Visible = False
            pictureBoxEmpate.Visible = False
        End If
        If BoxResultadoRodolfoHernandez.Text > BoxResultadoPetro.Text Then
            PictureBoxRodolfoHernandezPresidente.Visible = True
            pictureBoxPetroPresidente.Visible = False
            pictureBoxEmpate.Visible = False
        End If
        If BoxResultadoPetro.Text = BoxResultadoRodolfoHernandez.Text Then
            pictureBoxEmpate.Visible = True
            pictureBoxPetroPresidente.Visible = False
            PictureBoxRodolfoHernandezPresidente.Visible = False

        End If
    End Sub



    Private Sub buttonContraseñaReiniciarElecciones_Click(sender As Object, e As EventArgs) Handles buttonContraseñaReiniciarElecciones.Click
        If textBoxContraseñaReiniciarElecciones.Text = "1193119006" Then
            BoxResultadoPetro.Clear()
            BoxResultadoRodolfoHernandez.Clear()
            Button3.Visible = True
            Button5.Visible = True
            groupBoxReiniciarElecciones.Visible = False
            buttonReiniciarElecciones.Visible = False
            buttonResultados.Visible = False
            Button6.Visible = False
            pictureBoxEmpate.Visible = False
            pictureBoxPetroPresidente.Visible = False
            PictureBoxRodolfoHernandezPresidente.Visible = False
        ElseIf textBoxContraseñaReiniciarElecciones.Text <> "1193119006" Then
            MessageBox.Show("La contraseña que escribio es incorrecta")
            textBoxContraseñaReiniciarElecciones.Clear()
            textBoxContraseñaReiniciarElecciones.Focus()
        End If
    End Sub

    Private Sub buttonReiniciarElecciones_Click(sender As Object, e As EventArgs) Handles buttonReiniciarElecciones.Click
        MessageBox.Show("Una vez reiniciadas las elecciones no se podrán recuperar los votos")
        groupBoxReiniciarElecciones.Visible = True
        textBoxContraseñaReiniciarElecciones.Focus()
        pictureBoxEmpate.Visible = False
        pictureBoxPetroPresidente.Visible = False
        PictureBoxRodolfoHernandezPresidente.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        groupBoxReiniciarElecciones.Visible = False
        GroupBox3.Visible = False
        buttonResultados.Visible = False
        Button3.Visible = True
        Button5.Visible = True
        Button6.Visible = False
        pictureBoxPetroPresidente.Visible = False
        PictureBoxRodolfoHernandezPresidente.Visible = False
        pictureBoxEmpate.Visible = False
        textBoxContraseña.Clear()
        buttonReiniciarElecciones.Visible = False
    End Sub


   
End Class
