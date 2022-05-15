<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Como_funciona___tipos_de_modelado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Como_funciona___tipos_de_modelado))
        Me.pnlbtn = New System.Windows.Forms.Panel()
        Me.Btnminimizar = New System.Windows.Forms.PictureBox()
        Me.Btncerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlbtn.SuspendLayout()
        CType(Me.Btnminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlbtn.Size = New System.Drawing.Size(800, 45)
        Me.pnlbtn.TabIndex = 4
        '
        'Btnminimizar
        '
        Me.Btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnminimizar.Image = CType(resources.GetObject("Btnminimizar.Image"), System.Drawing.Image)
        Me.Btnminimizar.Location = New System.Drawing.Point(714, 3)
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
        Me.Btncerrar.Location = New System.Drawing.Point(751, 3)
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
        Me.Label1.Location = New System.Drawing.Point(206, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿CÓMO FUNCIONA? - TIPOS DE MODELADO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(477, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 232)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(12, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 152)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(432, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 134)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "MODELADO PREDICTIVO: Clasifica eventos y calcula resultado desconocidos, las técn" &
    "icas son:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Regresión" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Redes neuronales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Arboles de decisión "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(222, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 147)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(617, 335)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(157, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Como_funciona___tipos_de_modelado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 517)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Como_funciona___tipos_de_modelado"
        Me.Text = "Como_funciona___tipos_de_modelado"
        Me.pnlbtn.ResumeLayout(False)
        Me.pnlbtn.PerformLayout()
        CType(Me.Btnminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlbtn As Panel
    Friend WithEvents Btnminimizar As PictureBox
    Friend WithEvents Btncerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
