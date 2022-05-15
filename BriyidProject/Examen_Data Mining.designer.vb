<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Examen_Data_Mining
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Examen_Data_Mining))
        Me.pnlbtn = New System.Windows.Forms.Panel()
        Me.Btnminimizar = New System.Windows.Forms.PictureBox()
        Me.Btncerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Rbtnop3pgt5 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Rbtnop2pgt5 = New System.Windows.Forms.RadioButton()
        Me.Rbtnop1pgt5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rbtnop3pgt4 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Rbtnop2pgt4 = New System.Windows.Forms.RadioButton()
        Me.Rbtnop1pgt4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rbtnop3pgt3 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rbtnop2pgt3 = New System.Windows.Forms.RadioButton()
        Me.Rbtnop1pgt3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rbtnop2pgt2 = New System.Windows.Forms.RadioButton()
        Me.Rbtnop1pgt2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rbtnop3pgt1 = New System.Windows.Forms.RadioButton()
        Me.Rbtnop2pgt1 = New System.Windows.Forms.RadioButton()
        Me.Rbtnop1pgt1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.lblcorrectas = New System.Windows.Forms.Label()
        Me.lblcorrect = New System.Windows.Forms.Label()
        Me.lblincorrect = New System.Windows.Forms.Label()
        Me.lblincorrectas = New System.Windows.Forms.Label()
        Me.Btniniciar = New System.Windows.Forms.Button()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblseg = New System.Windows.Forms.Label()
        Me.tmr_lim = New System.Windows.Forms.Timer(Me.components)
        Me.pnlbtn.SuspendLayout()
        CType(Me.Btnminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()

        Me.StartPosition = FormStartPosition.CenterScreen

        '
        'pnlbtn
        '
        Me.pnlbtn.BackColor = System.Drawing.Color.DarkBlue
        Me.pnlbtn.Controls.Add(Me.Btnminimizar)
        Me.pnlbtn.Controls.Add(Me.Btncerrar)
        Me.pnlbtn.Controls.Add(Me.Label1)
        Me.pnlbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlbtn.Location = New System.Drawing.Point(0, 0)
        Me.pnlbtn.Name = "pnlbtn"
        Me.pnlbtn.Size = New System.Drawing.Size(785, 45)
        Me.pnlbtn.TabIndex = 5
        '
        'Btnminimizar
        '
        Me.Btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnminimizar.Image = CType(resources.GetObject("Btnminimizar.Image"), System.Drawing.Image)
        Me.Btnminimizar.Location = New System.Drawing.Point(699, 3)
        Me.Btnminimizar.Name = "Btnminimizar"
        Me.Btnminimizar.Size = New System.Drawing.Size(39, 35)
        Me.Btnminimizar.TabIndex = 2
        Me.Btnminimizar.TabStop = False
        '
        'Btncerrar
        '
        Me.Btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btncerrar.BackColor = System.Drawing.Color.Red
        Me.Btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncerrar.Image = CType(resources.GetObject("Btncerrar.Image"), System.Drawing.Image)
        Me.Btncerrar.Location = New System.Drawing.Point(736, 3)
        Me.Btncerrar.Name = "Btncerrar"
        Me.Btncerrar.Size = New System.Drawing.Size(39, 35)
        Me.Btncerrar.TabIndex = 1
        Me.Btncerrar.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(248, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EXAMEN DE MINERÍA DE DATOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(8, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 386)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox5.Controls.Add(Me.Rbtnop3pgt5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Rbtnop2pgt5)
        Me.GroupBox5.Controls.Add(Me.Rbtnop1pgt5)
        Me.GroupBox5.Location = New System.Drawing.Point(411, 198)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(354, 182)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pregunta 5"
        '
        'Rbtnop3pgt5
        '
        Me.Rbtnop3pgt5.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop3pgt5.Location = New System.Drawing.Point(13, 128)
        Me.Rbtnop3pgt5.Name = "Rbtnop3pgt5"
        Me.Rbtnop3pgt5.Size = New System.Drawing.Size(334, 22)
        Me.Rbtnop3pgt5.TabIndex = 14
        Me.Rbtnop3pgt5.Text = "Bases de datos"
        Me.Rbtnop3pgt5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Label6.Location = New System.Drawing.Point(9, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(337, 37)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "¿Cuál de estos menciona las industrias en las que se usa la minería de datos?"
        '
        'Rbtnop2pgt5
        '
        Me.Rbtnop2pgt5.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop2pgt5.Location = New System.Drawing.Point(13, 103)
        Me.Rbtnop2pgt5.Name = "Rbtnop2pgt5"
        Me.Rbtnop2pgt5.Size = New System.Drawing.Size(333, 18)
        Me.Rbtnop2pgt5.TabIndex = 13
        Me.Rbtnop2pgt5.Text = "Comunicación, educación, bancos"
        Me.Rbtnop2pgt5.UseVisualStyleBackColor = True
        '
        'Rbtnop1pgt5
        '
        Me.Rbtnop1pgt5.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop1pgt5.Location = New System.Drawing.Point(14, 75)
        Me.Rbtnop1pgt5.Name = "Rbtnop1pgt5"
        Me.Rbtnop1pgt5.Size = New System.Drawing.Size(332, 18)
        Me.Rbtnop1pgt5.TabIndex = 12
        Me.Rbtnop1pgt5.Text = "Facebook, universidad, computador"
        Me.Rbtnop1pgt5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox4.Controls.Add(Me.Rbtnop3pgt4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Rbtnop2pgt4)
        Me.GroupBox4.Controls.Add(Me.Rbtnop1pgt4)
        Me.GroupBox4.Location = New System.Drawing.Point(410, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 182)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pregunta 4"
        '
        'Rbtnop3pgt4
        '
        Me.Rbtnop3pgt4.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop3pgt4.Location = New System.Drawing.Point(13, 139)
        Me.Rbtnop3pgt4.Name = "Rbtnop3pgt4"
        Me.Rbtnop3pgt4.Size = New System.Drawing.Size(334, 22)
        Me.Rbtnop3pgt4.TabIndex = 10
        Me.Rbtnop3pgt4.Text = "Estadística, machine learning, realidad virtual"
        Me.Rbtnop3pgt4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Label5.Location = New System.Drawing.Point(11, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(337, 37)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "¿Cuáles son las 3 disciplinas que intervienen en la minería de datos y en el proc" &
    "eso"
        '
        'Rbtnop2pgt4
        '
        Me.Rbtnop2pgt4.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop2pgt4.Location = New System.Drawing.Point(14, 115)
        Me.Rbtnop2pgt4.Name = "Rbtnop2pgt4"
        Me.Rbtnop2pgt4.Size = New System.Drawing.Size(333, 18)
        Me.Rbtnop2pgt4.TabIndex = 9
        Me.Rbtnop2pgt4.Text = "Cálculo, estadística y proporción"
        Me.Rbtnop2pgt4.UseVisualStyleBackColor = True
        '
        'Rbtnop1pgt4
        '
        Me.Rbtnop1pgt4.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop1pgt4.Location = New System.Drawing.Point(13, 73)
        Me.Rbtnop1pgt4.Name = "Rbtnop1pgt4"
        Me.Rbtnop1pgt4.Size = New System.Drawing.Size(332, 36)
        Me.Rbtnop1pgt4.TabIndex = 8
        Me.Rbtnop1pgt4.Text = "Estadística, inteligencia artificial y machine learning"
        Me.Rbtnop1pgt4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.Rbtnop3pgt3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Rbtnop2pgt3)
        Me.GroupBox3.Controls.Add(Me.Rbtnop1pgt3)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 251)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 130)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pregunta 3"
        '
        'Rbtnop3pgt3
        '
        Me.Rbtnop3pgt3.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop3pgt3.Location = New System.Drawing.Point(10, 90)
        Me.Rbtnop3pgt3.Name = "Rbtnop3pgt3"
        Me.Rbtnop3pgt3.Size = New System.Drawing.Size(359, 20)
        Me.Rbtnop3pgt3.TabIndex = 9
        Me.Rbtnop3pgt3.TabStop = True
        Me.Rbtnop3pgt3.Text = "Descriptivo, cualitativo, predictivo"
        Me.Rbtnop3pgt3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(375, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "¿Cuáles son los 3 tipos de modelados?"
        '
        'Rbtnop2pgt3
        '
        Me.Rbtnop2pgt3.AutoSize = True
        Me.Rbtnop2pgt3.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop2pgt3.Location = New System.Drawing.Point(10, 68)
        Me.Rbtnop2pgt3.Name = "Rbtnop2pgt3"
        Me.Rbtnop2pgt3.Size = New System.Drawing.Size(244, 18)
        Me.Rbtnop2pgt3.TabIndex = 8
        Me.Rbtnop2pgt3.TabStop = True
        Me.Rbtnop2pgt3.Text = "Descriptivo, predictivo, prescriptivo"
        Me.Rbtnop2pgt3.UseVisualStyleBackColor = True
        '
        'Rbtnop1pgt3
        '
        Me.Rbtnop1pgt3.AutoSize = True
        Me.Rbtnop1pgt3.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop1pgt3.Location = New System.Drawing.Point(10, 46)
        Me.Rbtnop1pgt3.Name = "Rbtnop1pgt3"
        Me.Rbtnop1pgt3.Size = New System.Drawing.Size(257, 18)
        Me.Rbtnop1pgt3.TabIndex = 7
        Me.Rbtnop1pgt3.TabStop = True
        Me.Rbtnop1pgt3.Text = "Cuantitativo, cualitativo y descriptivo"
        Me.Rbtnop1pgt3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.Rbtnop2pgt2)
        Me.GroupBox2.Controls.Add(Me.Rbtnop1pgt2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pregunta 2"
        '
        'Rbtnop2pgt2
        '
        Me.Rbtnop2pgt2.AutoSize = True
        Me.Rbtnop2pgt2.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop2pgt2.Location = New System.Drawing.Point(282, 67)
        Me.Rbtnop2pgt2.Name = "Rbtnop2pgt2"
        Me.Rbtnop2pgt2.Size = New System.Drawing.Size(57, 18)
        Me.Rbtnop2pgt2.TabIndex = 2
        Me.Rbtnop2pgt2.TabStop = True
        Me.Rbtnop2pgt2.Text = "Falso"
        Me.Rbtnop2pgt2.UseVisualStyleBackColor = True
        '
        'Rbtnop1pgt2
        '
        Me.Rbtnop1pgt2.AutoSize = True
        Me.Rbtnop1pgt2.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop1pgt2.Location = New System.Drawing.Point(10, 67)
        Me.Rbtnop1pgt2.Name = "Rbtnop1pgt2"
        Me.Rbtnop1pgt2.Size = New System.Drawing.Size(90, 18)
        Me.Rbtnop1pgt2.TabIndex = 1
        Me.Rbtnop1pgt2.TabStop = True
        Me.Rbtnop1pgt2.Text = "Verdadero"
        Me.Rbtnop1pgt2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 47)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "¿Para el tema de la publicidad en Facebook y los anuncios que nos aparecen o tien" &
    "en mas visibilidad, Facebook utiliza la minería de datos?"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Rbtnop3pgt1)
        Me.GroupBox1.Controls.Add(Me.Rbtnop2pgt1)
        Me.GroupBox1.Controls.Add(Me.Rbtnop1pgt1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pregunta 1"
        '
        'Rbtnop3pgt1
        '
        Me.Rbtnop3pgt1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop3pgt1.Location = New System.Drawing.Point(10, 83)
        Me.Rbtnop3pgt1.Name = "Rbtnop3pgt1"
        Me.Rbtnop3pgt1.Size = New System.Drawing.Size(359, 39)
        Me.Rbtnop3pgt1.TabIndex = 6
        Me.Rbtnop3pgt1.Text = "Un proceso que determina correlación de datos, anomalías y patrones para calcular" &
    " eventos futuros"
        Me.Rbtnop3pgt1.UseVisualStyleBackColor = True
        '
        'Rbtnop2pgt1
        '
        Me.Rbtnop2pgt1.AutoSize = True
        Me.Rbtnop2pgt1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop2pgt1.Location = New System.Drawing.Point(10, 62)
        Me.Rbtnop2pgt1.Name = "Rbtnop2pgt1"
        Me.Rbtnop2pgt1.Size = New System.Drawing.Size(263, 18)
        Me.Rbtnop2pgt1.TabIndex = 5
        Me.Rbtnop2pgt1.Text = "Un proceso de analisis de información"
        Me.Rbtnop2pgt1.UseVisualStyleBackColor = True
        '
        'Rbtnop1pgt1
        '
        Me.Rbtnop1pgt1.AutoSize = True
        Me.Rbtnop1pgt1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Rbtnop1pgt1.Location = New System.Drawing.Point(10, 40)
        Me.Rbtnop1pgt1.Name = "Rbtnop1pgt1"
        Me.Rbtnop1pgt1.Size = New System.Drawing.Size(316, 18)
        Me.Rbtnop1pgt1.TabIndex = 4
        Me.Rbtnop1pgt1.Text = "Un proceso por el cual se decide de marketing"
        Me.Rbtnop1pgt1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(375, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "La minería de datos se define como:"
        '
        'Btnguardar
        '
        Me.Btnguardar.BackColor = System.Drawing.Color.MidnightBlue
        Me.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnguardar.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.Btnguardar.ForeColor = System.Drawing.Color.White
        Me.Btnguardar.Location = New System.Drawing.Point(391, 54)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(119, 24)
        Me.Btnguardar.TabIndex = 7
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = False
        '
        'lblcorrectas
        '
        Me.lblcorrectas.AutoSize = True
        Me.lblcorrectas.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblcorrectas.Location = New System.Drawing.Point(158, 60)
        Me.lblcorrectas.Name = "lblcorrectas"
        Me.lblcorrectas.Size = New System.Drawing.Size(71, 14)
        Me.lblcorrectas.TabIndex = 8
        Me.lblcorrectas.Text = "Correctas"
        '
        'lblcorrect
        '
        Me.lblcorrect.AutoSize = True
        Me.lblcorrect.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblcorrect.Location = New System.Drawing.Point(232, 60)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(16, 14)
        Me.lblcorrect.TabIndex = 9
        Me.lblcorrect.Text = "0"
        '
        'lblincorrect
        '
        Me.lblincorrect.AutoSize = True
        Me.lblincorrect.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblincorrect.Location = New System.Drawing.Point(352, 60)
        Me.lblincorrect.Name = "lblincorrect"
        Me.lblincorrect.Size = New System.Drawing.Size(16, 14)
        Me.lblincorrect.TabIndex = 11
        Me.lblincorrect.Text = "0"
        '
        'lblincorrectas
        '
        Me.lblincorrectas.AutoSize = True
        Me.lblincorrectas.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblincorrectas.Location = New System.Drawing.Point(267, 60)
        Me.lblincorrectas.Name = "lblincorrectas"
        Me.lblincorrectas.Size = New System.Drawing.Size(83, 14)
        Me.lblincorrectas.TabIndex = 10
        Me.lblincorrectas.Text = "Incorrectas"
        '
        'Btniniciar
        '
        Me.Btniniciar.BackColor = System.Drawing.Color.Lime
        Me.Btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btniniciar.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.Btniniciar.ForeColor = System.Drawing.Color.White
        Me.Btniniciar.Location = New System.Drawing.Point(12, 54)
        Me.Btniniciar.Name = "Btniniciar"
        Me.Btniniciar.Size = New System.Drawing.Size(119, 24)
        Me.Btniniciar.TabIndex = 12
        Me.Btniniciar.Text = "Iniciar"
        Me.Btniniciar.UseVisualStyleBackColor = False
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.lblmin.ForeColor = System.Drawing.Color.Black
        Me.lblmin.Location = New System.Drawing.Point(559, 54)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(38, 25)
        Me.lblmin.TabIndex = 51
        Me.lblmin.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(593, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = ":"
        '
        'lblseg
        '
        Me.lblseg.AutoSize = True
        Me.lblseg.Font = New System.Drawing.Font("Verdana", 15.0!)
        Me.lblseg.ForeColor = System.Drawing.Color.Black
        Me.lblseg.Location = New System.Drawing.Point(612, 54)
        Me.lblseg.Name = "lblseg"
        Me.lblseg.Size = New System.Drawing.Size(38, 25)
        Me.lblseg.TabIndex = 53
        Me.lblseg.Text = "00"
        '
        'tmr_lim
        '
        Me.tmr_lim.Interval = 1000
        '
        'Examen_Data_Mining
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 493)
        Me.Controls.Add(Me.lblseg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblmin)
        Me.Controls.Add(Me.Btniniciar)
        Me.Controls.Add(Me.lblincorrect)
        Me.Controls.Add(Me.lblincorrectas)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.lblcorrectas)
        Me.Controls.Add(Me.Btnguardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Examen_Data_Mining"
        Me.Text = "Examen_Data_Mining"
        Me.pnlbtn.ResumeLayout(False)
        Me.pnlbtn.PerformLayout()
        CType(Me.Btnminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlbtn As Panel
    Friend WithEvents Btnminimizar As PictureBox
    Friend WithEvents Btncerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Rbtnop2pgt2 As RadioButton
    Friend WithEvents Rbtnop1pgt2 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Rbtnop3pgt1 As RadioButton
    Friend WithEvents Rbtnop2pgt1 As RadioButton
    Friend WithEvents Rbtnop1pgt1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Rbtnop3pgt3 As RadioButton
    Friend WithEvents Rbtnop2pgt3 As RadioButton
    Friend WithEvents Rbtnop1pgt3 As RadioButton
    Friend WithEvents Rbtnop3pgt4 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Rbtnop2pgt4 As RadioButton
    Friend WithEvents Rbtnop1pgt4 As RadioButton
    Friend WithEvents Rbtnop3pgt5 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Rbtnop2pgt5 As RadioButton
    Friend WithEvents Rbtnop1pgt5 As RadioButton
    Friend WithEvents Btnguardar As Button
    Friend WithEvents lblcorrectas As Label
    Friend WithEvents lblcorrect As Label
    Friend WithEvents lblincorrect As Label
    Friend WithEvents lblincorrectas As Label
    Friend WithEvents Btniniciar As Button
    Friend WithEvents lblmin As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblseg As Label
    Friend WithEvents tmr_lim As Timer
End Class
