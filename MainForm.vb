Public Class MainForm

    Public contador As Integer = 1
    Public Property ImageLocation As String


    Public hombres As Boolean = False
    Public mujeres As Boolean = False
    Public calzado As Boolean = False
    Public accesorios As Boolean = False

    Public tipocategoria As String = Nothing

    Public izquierda As Boolean = False
    Public derecha As Boolean = False

    Public image1_seleccionada As Boolean = False
    Public image2_seleccionada As Boolean = False
    Public image3_seleccionada As Boolean = False
    Public image4_seleccionada As Boolean = False

    Public n_hombres1 As Integer = 0
    Public n_hombres2 As Integer = 0
    Public n_hombres3 As Integer = 0

    Public n_mujeres1 As Integer = 0
    Public n_mujeres2 As Integer = 0
    Public n_mujeres3 As Integer = 0

    Public n_calzado1 As Integer = 0
    Public n_calzado2 As Integer = 0
    Public n_calzado3 As Integer = 0

    Public n_accesorios1 As Integer = 0
    Public n_accesorios2 As Integer = 0


    Private numero_articulos_a_comprar As Integer = 0

    Private precio_hombres As Double = 0
    Private precio_mujeres As Double = 0
    Private precio_calzado As Double = 0
    Private precio_accesorios As Double = 0

    Private numero_articulos_suma As Boolean = False
    Private numero_articulos_resta As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = "Cottom Linen V - Neck Jumper"
        Me.Button1.Text = "HOMBRES"
        Me.Button1.ForeColor = Color.DarkGray
        Me.Button2.Text = "MUJERES"
        Me.Button2.ForeColor = Color.DarkGray
        Me.Button3.Text = "CALZADO"
        Me.Button3.ForeColor = Color.DarkGray
        Me.Button4.Text = "ACCESORIOS"
        Me.Button4.ForeColor = Color.DarkGray


        PictureBox1.Image = My.Resources.h_03_01_normal
        PictureBox2.Image = My.Resources.h_03_02_normal
        PictureBox3.Image = My.Resources.h_03_03_normal
        PictureBox4.Image = My.Resources.h_03_04_normal



        Me.Button1.ForeColor = Color.SteelBlue
        Me.Button2.ForeColor = Color.DarkGray
        Me.Button3.ForeColor = Color.DarkGray
        Me.Button4.ForeColor = Color.DarkGray

        hombres = True
        mujeres = False
        calzado = False
        accesorios = False

        Call verificarPaletas(hombres, mujeres, calzado, accesorios)

        image1_seleccionada = True
        image2_seleccionada = False
        image3_seleccionada = False
        image4_seleccionada = False

        mostrar_Image_Principal(image1_seleccionada, image2_seleccionada, image3_seleccionada, image4_seleccionada)
        'PictureBox5.Image = PictureBox1.Image
        lblPrecio.Text = String.Format("${0:0}", "95")

        lblTallaT.Text = "TALLA"
        lblCantidadT.Text = "CANTIDAD"
        Me.btnAgregar.Text = "AGREGAR AL CARRITO ???"
        Me.btnComprar.Text = "COMPRAR "
        Me.lblTotalT.Text = "TOTAL A PAGAR"
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        numero_articulos_suma = False
        numero_articulos_resta = False
        derecha = True
        izquierda = False
        Call Cargar_dependiendo_Categoria(tipocategoria, derecha, izquierda)
        mostrar_Image_Principal(image1_seleccionada, image2_seleccionada, image3_seleccionada, image4_seleccionada)



    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        derecha = False
        izquierda = True
        Call Cargar_dependiendo_Categoria(tipocategoria, derecha, izquierda)
        mostrar_Image_Principal(image1_seleccionada, image2_seleccionada, image3_seleccionada, image4_seleccionada)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnRight.PerformClick()
        contador = 1

        Me.Button1.ForeColor = Color.SteelBlue
        Me.Button2.ForeColor = Color.DarkGray
        Me.Button3.ForeColor = Color.DarkGray
        Me.Button4.ForeColor = Color.DarkGray

        hombres = True
        mujeres = False
        calzado = False
        accesorios = False

        Call verificarPaletas(hombres, mujeres, calzado, accesorios)

        Me.lblTitulo.Text = "Cottom Linen V - Neck Jumper"
        PictureBox1.Image = My.Resources.h_03_01_normal
        PictureBox2.Image = My.Resources.h_03_02_normal
        PictureBox3.Image = My.Resources.h_03_03_normal
        PictureBox4.Image = My.Resources.h_03_04_normal
        PictureBox5.Image = PictureBox1.Image

        txtCantidad.Text = n_hombres1.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btnRight.PerformClick()
        contador = 1

        Me.Button1.ForeColor = Color.DarkGray
        Me.Button2.ForeColor = Color.SteelBlue
        Me.Button3.ForeColor = Color.DarkGray
        Me.Button4.ForeColor = Color.DarkGray


        hombres = False
        mujeres = True
        calzado = False
        accesorios = False

        Call verificarPaletas(hombres, mujeres, calzado, accesorios)

        Me.lblTitulo.Text = "Nicola Blouse"
        PictureBox1.Image = My.Resources.m_02_01_normal
        PictureBox2.Image = My.Resources.m_02_02_normal
        PictureBox3.Image = My.Resources.m_02_03_normal
        PictureBox4.Image = My.Resources.m_02_04_normal
        PictureBox5.Image = PictureBox1.Image
        lblPrecio.Text = String.Format("${0:0}", "120")



        txtCantidad.Text = n_mujeres1.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        btnRight.PerformClick()
        contador = 1

        Me.Button1.ForeColor = Color.DarkGray
        Me.Button2.ForeColor = Color.DarkGray
        Me.Button3.ForeColor = Color.SteelBlue
        Me.Button4.ForeColor = Color.DarkGray


        hombres = False
        mujeres = False
        calzado = True
        accesorios = False

        Call verificarPaletas(hombres, mujeres, calzado, accesorios)

        Me.lblTitulo.Text = "Philip 1d Trainers"
        PictureBox1.Image = My.Resources.I_5054618311879_50_20160419
        PictureBox2.Image = My.Resources.I_5054618311879_51_20160419
        PictureBox3.Image = My.Resources.I_5054618311879_52_20160419
        PictureBox4.Image = My.Resources.I_5054618311879_54_20160419
        PictureBox5.Image = PictureBox1.Image
        lblPrecio.Text = String.Format("${0:0}", "55")

        txtCantidad.Text = n_calzado1.ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        btnRight.PerformClick()
        contador = 1

        Me.Button1.ForeColor = Color.DarkGray
        Me.Button2.ForeColor = Color.DarkGray
        Me.Button3.ForeColor = Color.DarkGray
        Me.Button4.ForeColor = Color.SteelBlue

        hombres = False
        mujeres = False
        calzado = False
        accesorios = True


        Call verificarPaletas(hombres, mujeres, calzado, accesorios)

        Me.lblTitulo.Text = "Strap Watch 1791"
        PictureBox1.Image = My.Resources.a_01_01_normal
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = PictureBox1.Image
        lblPrecio.Text = String.Format("${0:0}", "175")

        txtCantidad.Text = n_accesorios1.ToString()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'ImageLocation = ""
        image1_seleccionada = True
        image2_seleccionada = False
        image3_seleccionada = False
        image4_seleccionada = False

        mostrar_Image_Principal(image1_seleccionada, image2_seleccionada, image3_seleccionada, image4_seleccionada)
        'ImageLocation = PictureBox1.Image
        'MsgBox(PictureBox1.Image)
        'PictureBox5.Image = Image.FromFile(Me.PictureBox1.ImageLocation)
        'PictureBox1.Image = Image.FromFile("ruta imagen")
    End Sub

    Public Sub verificarPaletas(hombres As Boolean, mujeres As Boolean, calzado As Boolean, accesorios As Boolean)
        If (hombres = True) Then
            tipocategoria = "HOMBRES"
            'MsgBox(tipocategoria)

        ElseIf (mujeres = True) Then
            tipocategoria = "MUJERES"
            'MsgBox(tipocategoria)
        ElseIf (calzado = True) Then
            tipocategoria = "CALZADO"
            'MsgBox(tipocategoria)
        ElseIf (accesorios = True) Then
            tipocategoria = "ACCESORIOS"
            'MsgBox(tipocategoria)
        Else
            MsgBox("Seleccione una Categoria Correspomdiente")
        End If

    End Sub
    Public Sub guardar_cantidad(valor As Integer, cantidad As Integer)
        valor = cantidad
        cantidad = 0
    End Sub
    Public Sub Cargar_dependiendo_Categoria(ByVal tipocategoria As String, ByVal derecha As Boolean, ByVal izquierda As Boolean)
        Select Case tipocategoria
            Case "HOMBRES"
                If (derecha = True) Then
                    contador += 1
                    If (contador <= 0 Or contador > 3) Then
                        contador = 1
                        Me.lblTitulo.Text = "Cottom Linen V - Neck Jumper"
                        PictureBox1.Image = My.Resources.h_03_01_normal
                        PictureBox2.Image = My.Resources.h_03_02_normal
                        PictureBox3.Image = My.Resources.h_03_03_normal
                        PictureBox4.Image = My.Resources.h_03_04_normal
                        lblPrecio.Text = String.Format("${0:0}", "95")
                        n_hombres3 = Val(txtCantidad.Text)
                        txtCantidad.Text = n_hombres1.ToString()
                    Else
                        If (contador = 1) Then
                            Me.lblTitulo.Text = "Cottom Linen V - Neck Jumper"
                            PictureBox1.Image = My.Resources.h_03_01_normal
                            PictureBox2.Image = My.Resources.h_03_02_normal
                            PictureBox3.Image = My.Resources.h_03_03_normal
                            PictureBox4.Image = My.Resources.h_03_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "95")
                            n_hombres3 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_hombres1.ToString()

                        ElseIf (contador = 2) Then
                            Me.lblTitulo.Text = "Eng Poplin Shirt"
                            PictureBox1.Image = My.Resources.h_02_01_normal
                            PictureBox2.Image = My.Resources.h_02_02_normal
                            PictureBox3.Image = My.Resources.h_02_03_normal
                            PictureBox4.Image = My.Resources.h_02_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "85")
                            n_hombres1 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_hombres2.ToString()

                        ElseIf (contador = 3) Then
                            Me.lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                            PictureBox1.Image = My.Resources.h_01_01_normal
                            PictureBox2.Image = My.Resources.h_01_02_normal
                            PictureBox3.Image = My.Resources.h_01_03_normal
                            PictureBox4.Image = My.Resources.h_01_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "110")
                            n_hombres2 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_hombres3.ToString()

                        End If
                    End If
                ElseIf (izquierda = True) Then
                    contador -= 1
                    If (contador <= 0 Or contador > 3) Then
                        contador = 3
                        Me.lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                        PictureBox1.Image = My.Resources.h_01_01_normal
                        PictureBox2.Image = My.Resources.h_01_02_normal
                        PictureBox3.Image = My.Resources.h_01_03_normal
                        PictureBox4.Image = My.Resources.h_01_04_normal
                        lblPrecio.Text = String.Format("${0:0}", "110")
                        n_hombres1 = Val(txtCantidad.Text)
                        txtCantidad.Text = n_hombres3.ToString()
                    Else
                        If (contador = 1) Then
                            Me.lblTitulo.Text = "Cottom Linen V - Neck Jumper"
                            PictureBox1.Image = My.Resources.h_03_01_normal
                            PictureBox2.Image = My.Resources.h_03_02_normal
                            PictureBox3.Image = My.Resources.h_03_03_normal
                            PictureBox4.Image = My.Resources.h_03_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "95")
                            n_hombres2 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_hombres1.ToString()
                        ElseIf (contador = 2) Then
                            Me.lblTitulo.Text = "Eng Poplin Shirt"
                            PictureBox1.Image = My.Resources.h_02_01_normal
                            PictureBox2.Image = My.Resources.h_02_02_normal
                            PictureBox3.Image = My.Resources.h_02_03_normal
                            PictureBox4.Image = My.Resources.h_02_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "85")
                            n_hombres3 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_hombres2.ToString()
                        ElseIf (contador = 3) Then
                            Me.lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                            PictureBox1.Image = My.Resources.h_01_01_normal
                            PictureBox2.Image = My.Resources.h_01_02_normal
                            PictureBox3.Image = My.Resources.h_01_03_normal
                            PictureBox4.Image = My.Resources.h_01_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "110")
                            n_hombres1 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_hombres3.ToString()
                        End If
                    End If
                End If


            Case "MUJERES"
                If (derecha = True) Then
                    contador += 1
                    If (contador <= 0 Or contador > 3) Then
                        contador = 1
                        Me.lblTitulo.Text = "Nicola Blouse"
                        PictureBox1.Image = My.Resources.m_02_01_normal
                        PictureBox2.Image = My.Resources.m_02_02_normal
                        PictureBox3.Image = My.Resources.m_02_03_normal
                        PictureBox4.Image = My.Resources.m_02_04_normal
                        lblPrecio.Text = String.Format("${0:0}", "120")
                        n_mujeres3 = Val(txtCantidad.Text)
                        txtCantidad.Text = n_mujeres1.ToString()
                    Else
                        If (contador = 1) Then
                            Me.lblTitulo.Text = "Nicola Blouse"
                            PictureBox1.Image = My.Resources.m_02_01_normal
                            PictureBox2.Image = My.Resources.m_02_02_normal
                            PictureBox3.Image = My.Resources.m_02_03_normal
                            PictureBox4.Image = My.Resources.m_02_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "120")
                            n_mujeres3 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_mujeres1.ToString()
                        ElseIf (contador = 2) Then
                            Me.lblTitulo.Text = "Jemma Blazer"
                            PictureBox1.Image = My.Resources.m_02_01_normal1
                            PictureBox2.Image = My.Resources.m_02_02_normal1
                            PictureBox3.Image = My.Resources.m_02_03_normal1
                            PictureBox4.Image = My.Resources.m_02_04_normal1
                            lblPrecio.Text = String.Format("${0:0}", "190")
                            n_mujeres1 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_mujeres2.ToString()
                        ElseIf (contador = 3) Then
                            Me.lblTitulo.Text = "Neige Dress"
                            PictureBox1.Image = My.Resources.m_03_01_normal
                            PictureBox2.Image = My.Resources.m_03_02_normal

                            PictureBox3.Image = Nothing
                            PictureBox4.Image = Nothing
                            lblPrecio.Text = String.Format("${0:0}", "125")
                            n_mujeres2 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_mujeres3.ToString()
                        End If
                    End If
                ElseIf (izquierda = True) Then
                    contador -= 1
                    If (contador <= 0 Or contador > 3) Then
                        contador = 3
                        Me.lblTitulo.Text = "Neige Dress"
                        PictureBox1.Image = My.Resources.m_03_01_normal
                        PictureBox2.Image = My.Resources.m_03_02_normal
                        PictureBox3.Image = Nothing
                        PictureBox4.Image = Nothing
                        lblPrecio.Text = String.Format("${0:0}", "125")
                        n_mujeres1 = Val(txtCantidad.Text)
                        txtCantidad.Text = n_mujeres3.ToString()
                    Else
                        If (contador = 1) Then
                            Me.lblTitulo.Text = "Nicola Blouse"
                            PictureBox1.Image = My.Resources.m_02_01_normal
                            PictureBox2.Image = My.Resources.m_02_02_normal
                            PictureBox3.Image = My.Resources.m_02_03_normal
                            PictureBox4.Image = My.Resources.m_02_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "120")
                            n_mujeres2 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_mujeres1.ToString()
                        ElseIf (contador = 2) Then
                            Me.lblTitulo.Text = "Jemma Blazer"
                            PictureBox1.Image = My.Resources.m_02_01_normal1
                            PictureBox2.Image = My.Resources.m_02_02_normal1
                            PictureBox3.Image = My.Resources.m_02_03_normal1
                            PictureBox4.Image = My.Resources.m_02_04_normal1
                            lblPrecio.Text = String.Format("${0:0}", "190")
                            n_mujeres3 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_mujeres2.ToString()
                        ElseIf (contador = 3) Then
                            Me.lblTitulo.Text = "Neige Dress"
                            PictureBox1.Image = My.Resources.m_03_01_normal
                            PictureBox2.Image = My.Resources.m_03_02_normal
                            PictureBox3.Image = Nothing
                            PictureBox4.Image = Nothing
                            lblPrecio.Text = String.Format("${0:0}", "125")
                            n_mujeres1 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_mujeres3.ToString()
                        End If
                    End If
                End If
            Case "CALZADO"
                If (derecha = True) Then
                    contador += 1
                    If (contador <= 0 Or contador > 3) Then
                        contador = 1
                        Me.lblTitulo.Text = "Philip 1d Trainers"
                        PictureBox1.Image = My.Resources.I_5054618311879_50_20160419
                        PictureBox2.Image = My.Resources.I_5054618311879_51_20160419
                        PictureBox3.Image = My.Resources.I_5054618311879_52_20160419
                        PictureBox4.Image = My.Resources.I_5054618311879_54_20160419
                        lblPrecio.Text = String.Format("${0:0}", "55")
                        n_calzado3 = Val(txtCantidad.Text)
                        txtCantidad.Text = n_calzado1.ToString()
                    Else
                        If (contador = 1) Then
                            Me.lblTitulo.Text = "Philip 1d Trainers"
                            PictureBox1.Image = My.Resources.I_5054618311879_50_20160419
                            PictureBox2.Image = My.Resources.I_5054618311879_51_20160419
                            PictureBox3.Image = My.Resources.I_5054618311879_52_20160419
                            PictureBox4.Image = My.Resources.I_5054618311879_54_20160419
                            lblPrecio.Text = String.Format("${0:0}", "55")
                            n_calzado3 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_calzado1.ToString()
                        ElseIf (contador = 2) Then
                            Me.lblTitulo.Text = "Deck 4d Mixed"
                            PictureBox1.Image = My.Resources.c_02_01_normal
                            PictureBox2.Image = My.Resources.c_02_02_normal
                            PictureBox3.Image = My.Resources.c_02_03_normal
                            PictureBox4.Image = My.Resources.c_02_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "80")
                            n_calzado1 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_calzado2.ToString()
                        ElseIf (contador = 3) Then
                            Me.lblTitulo.Text = "Parson 8n Mid Heel"
                            PictureBox1.Image = My.Resources.c_03_01_normal
                            PictureBox2.Image = My.Resources.c_03_02_normal
                            PictureBox3.Image = My.Resources.c_03_03_normal
                            PictureBox4.Image = My.Resources.c_03_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "155")
                            n_calzado2 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_calzado3.ToString()
                        End If
                    End If
                ElseIf (izquierda = True) Then
                    contador -= 1
                    If (contador <= 0 Or contador > 3) Then
                        contador = 3
                        Me.lblTitulo.Text = "Parson 8n Mid Heel"
                        PictureBox1.Image = My.Resources.c_03_01_normal
                        PictureBox2.Image = My.Resources.c_03_02_normal
                        PictureBox3.Image = My.Resources.c_03_03_normal
                        PictureBox4.Image = My.Resources.c_03_04_normal
                        lblPrecio.Text = String.Format("${0:0}", "155")
                        n_calzado1 = Val(txtCantidad.Text)
                        txtCantidad.Text = n_calzado3.ToString()
                    Else
                        If (contador = 1) Then
                            Me.lblTitulo.Text = "Philip 1d Trainers"
                            PictureBox1.Image = My.Resources.I_5054618311879_50_20160419
                            PictureBox2.Image = My.Resources.I_5054618311879_51_20160419
                            PictureBox3.Image = My.Resources.I_5054618311879_52_20160419
                            PictureBox4.Image = My.Resources.I_5054618311879_54_20160419
                            lblPrecio.Text = String.Format("${0:0}", "55")
                            n_calzado2 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_calzado1.ToString()
                        ElseIf (contador = 2) Then
                            Me.lblTitulo.Text = "Deck 4d Mixed"
                            PictureBox1.Image = My.Resources.c_02_01_normal
                            PictureBox2.Image = My.Resources.c_02_02_normal
                            PictureBox3.Image = My.Resources.c_02_03_normal
                            PictureBox4.Image = My.Resources.c_02_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "80")
                            n_calzado3 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_calzado2.ToString()
                        ElseIf (contador = 3) Then
                            Me.lblTitulo.Text = "Parson 8n Mid Heel"
                            PictureBox1.Image = My.Resources.c_03_01_normal
                            PictureBox2.Image = My.Resources.c_03_02_normal
                            PictureBox3.Image = My.Resources.c_03_03_normal
                            PictureBox4.Image = My.Resources.c_03_04_normal
                            lblPrecio.Text = String.Format("${0:0}", "155")
                            n_calzado1 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_calzado3.ToString()
                        End If
                    End If
                End If



            Case "ACCESORIOS"
                If (derecha = True) Then
                    contador += 1
                    If (contador <= 0 Or contador > 2) Then
                        contador = 1
                        Me.lblTitulo.Text = "Strap Watch 1791"
                        PictureBox1.Image = My.Resources.a_01_01_normal
                        PictureBox2.Image = Nothing
                        PictureBox3.Image = Nothing
                        PictureBox4.Image = Nothing
                        lblPrecio.Text = String.Format("${0:0}", "175")
                        n_accesorios2 = Val(txtCantidad.Text)
                        txtCantidad.Text = n_accesorios1.ToString()
                    Else
                        If (contador = 1) Then
                            Me.lblTitulo.Text = "Strap Watch 1791"
                            PictureBox1.Image = My.Resources.a_01_01_normal
                            PictureBox2.Image = Nothing
                            PictureBox3.Image = Nothing
                            PictureBox4.Image = Nothing
                            lblPrecio.Text = String.Format("${0:0}", "175")
                            n_accesorios2 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_accesorios1.ToString()
                        ElseIf (contador = 2) Then
                            Me.lblTitulo.Text = "Classic Logo Red Cap"
                            PictureBox1.Image = My.Resources.a_02_01_normal
                            PictureBox2.Image = Nothing
                            PictureBox3.Image = Nothing
                            PictureBox4.Image = Nothing
                            lblPrecio.Text = String.Format("${0:0}", "25")
                            n_accesorios1 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_accesorios2.ToString()
                        End If
                    End If
                ElseIf (izquierda = True) Then
                    contador -= 1
                    If (contador <= 0 Or contador > 2) Then
                        contador = 2
                        Me.lblTitulo.Text = "Classic Logo Red Cap"
                        PictureBox1.Image = My.Resources.a_02_01_normal
                        PictureBox2.Image = Nothing
                        PictureBox3.Image = Nothing
                        PictureBox4.Image = Nothing
                        lblPrecio.Text = String.Format("${0:0}", "25")
                        n_accesorios1 = Val(txtCantidad.Text)
                        txtCantidad.Text = n_accesorios2.ToString()
                    Else
                        If (contador = 1) Then
                            Me.lblTitulo.Text = "Strap Watch 1791"
                            PictureBox1.Image = My.Resources.a_01_01_normal
                            PictureBox2.Image = Nothing
                            PictureBox3.Image = Nothing
                            PictureBox4.Image = Nothing
                            lblPrecio.Text = String.Format("${0:0}", "175")
                            n_accesorios2 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_accesorios1.ToString()
                        ElseIf (contador = 2) Then
                            Me.lblTitulo.Text = "Classic Logo Red Cap"
                            PictureBox1.Image = My.Resources.a_02_01_normal
                            PictureBox2.Image = Nothing
                            PictureBox3.Image = Nothing
                            PictureBox4.Image = Nothing
                            lblPrecio.Text = String.Format("${0:0}", "25")
                            n_accesorios1 = Val(txtCantidad.Text)
                            txtCantidad.Text = n_accesorios2.ToString()
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'PictureBox5.Image = PictureBox2.Image
        image1_seleccionada = False
        image2_seleccionada = True
        image3_seleccionada = False
        image4_seleccionada = False
        mostrar_Image_Principal(image1_seleccionada, image2_seleccionada, image3_seleccionada, image4_seleccionada)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'PictureBox5.Image = PictureBox3.Image
        image1_seleccionada = False
        image2_seleccionada = False
        image3_seleccionada = True
        image4_seleccionada = False
        mostrar_Image_Principal(image1_seleccionada, image2_seleccionada, image3_seleccionada, image4_seleccionada)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'PictureBox5.Image = PictureBox4.Image
        image1_seleccionada = False
        image2_seleccionada = False
        image3_seleccionada = False
        image4_seleccionada = True
        mostrar_Image_Principal(image1_seleccionada, image2_seleccionada, image3_seleccionada, image4_seleccionada)
    End Sub

    Public Sub mostrar_Image_Principal(ByVal image1_seleccionada As Boolean, ByVal image2_seleccionada As Boolean, ByVal image3_seleccionada As Boolean, ByVal image4_seleccionada As Boolean)
        If (image1_seleccionada = True) Then
            PictureBox5.Image = PictureBox1.Image
        ElseIf (image2_seleccionada = True) Then
            PictureBox5.Image = PictureBox2.Image
        ElseIf (image3_seleccionada = True) Then
            PictureBox5.Image = PictureBox3.Image
        ElseIf (image4_seleccionada = True) Then
            PictureBox5.Image = PictureBox4.Image
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        numero_articulos_a_comprar = CType(txtCantidad.Text, Integer)
        numero_articulos_a_comprar -= 1
        If (numero_articulos_a_comprar <= 0) Then
            numero_articulos_a_comprar = 0
            txtCantidad.Text = CType(numero_articulos_a_comprar, String)
        Else
            txtCantidad.Text = CType(numero_articulos_a_comprar, String)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub


    Private total_hombre As Double = 0
    Private total_mujeres As Double = 0
    Private total_calzado As Double = 0
    Private total_accesorios As Double = 0
    Private total_pagar As Double = 0
End Class