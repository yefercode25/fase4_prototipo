<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Que_es
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Que_es))
        Me.pnlbtn = New System.Windows.Forms.Panel()
        Me.Btnminimizar = New System.Windows.Forms.PictureBox()
        Me.Btncerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pnlbtn.SuspendLayout()
        CType(Me.Btnminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlbtn.Size = New System.Drawing.Size(747, 45)
        Me.pnlbtn.TabIndex = 3
        '
        'Btnminimizar
        '
        Me.Btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnminimizar.Image = CType(resources.GetObject("Btnminimizar.Image"), System.Drawing.Image)
        Me.Btnminimizar.Location = New System.Drawing.Point(661, 3)
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
        Me.Btncerrar.Location = New System.Drawing.Point(698, 3)
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
        Me.Label1.Location = New System.Drawing.Point(205, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿QUÉ ES LA MINERÍA DE DATOS?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 378)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(747, 424)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(365, 78)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(364, 358)
        Me.AxWindowsMediaPlayer1.TabIndex = 6
        '
        'Que_es
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 469)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Que_es"
        Me.Text = "Que_es"
        Me.pnlbtn.ResumeLayout(False)
        Me.pnlbtn.PerformLayout()
        CType(Me.Btnminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlbtn As Panel
    Friend WithEvents Btnminimizar As PictureBox
    Friend WithEvents Btncerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
