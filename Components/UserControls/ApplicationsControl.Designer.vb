<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplicationsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplicationsControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPlay = New System.Windows.Forms.PictureBox()
        Me.BtnReset = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usos de la realidad aumentada"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(310, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BtnPlay
        '
        Me.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPlay.Image = CType(resources.GetObject("BtnPlay.Image"), System.Drawing.Image)
        Me.BtnPlay.Location = New System.Drawing.Point(346, 305)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(47, 45)
        Me.BtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnPlay.TabIndex = 3
        Me.BtnPlay.TabStop = False
        '
        'BtnReset
        '
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.Image = CType(resources.GetObject("BtnReset.Image"), System.Drawing.Image)
        Me.BtnReset.Location = New System.Drawing.Point(435, 305)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(47, 45)
        Me.BtnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(342, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Recurso de audio"
        '
        'ApplicationsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Vivaldi", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ApplicationsControl"
        Me.Size = New System.Drawing.Size(848, 373)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnPlay As PictureBox
    Friend WithEvents BtnReset As PictureBox
    Friend WithEvents Label2 As Label
End Class
