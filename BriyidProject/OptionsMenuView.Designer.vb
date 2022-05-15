<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsMenuView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsMenuView))
        Me.pnlbtn = New System.Windows.Forms.Panel()
        Me.Btnminimizar = New System.Windows.Forms.PictureBox()
        Me.Btncerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnQueEs = New System.Windows.Forms.Button()
        Me.BtnComoFunciona = New System.Windows.Forms.Button()
        Me.BtnEnQueUtiliza = New System.Windows.Forms.Button()
        Me.BtnExamen = New System.Windows.Forms.Button()
        Me.pnlbtn.SuspendLayout()
        CType(Me.Btnminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnlbtn.Size = New System.Drawing.Size(505, 45)
        Me.pnlbtn.TabIndex = 4
        '
        'Btnminimizar
        '
        Me.Btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnminimizar.Image = CType(resources.GetObject("Btnminimizar.Image"), System.Drawing.Image)
        Me.Btnminimizar.Location = New System.Drawing.Point(419, 3)
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
        Me.Btncerrar.Location = New System.Drawing.Point(456, 3)
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
        Me.Label1.Location = New System.Drawing.Point(147, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENU DE OPCIONES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Minería de datos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnQueEs
        '
        Me.BtnQueEs.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnQueEs.Location = New System.Drawing.Point(25, 98)
        Me.BtnQueEs.Name = "BtnQueEs"
        Me.BtnQueEs.Size = New System.Drawing.Size(451, 38)
        Me.BtnQueEs.TabIndex = 5
        Me.BtnQueEs.Text = "¿Qué es?"
        Me.BtnQueEs.UseVisualStyleBackColor = True
        '
        'BtnComoFunciona
        '
        Me.BtnComoFunciona.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnComoFunciona.Location = New System.Drawing.Point(25, 153)
        Me.BtnComoFunciona.Name = "BtnComoFunciona"
        Me.BtnComoFunciona.Size = New System.Drawing.Size(451, 38)
        Me.BtnComoFunciona.TabIndex = 6
        Me.BtnComoFunciona.Text = "¿Cómo funciona? - Tipos de Modelado"
        Me.BtnComoFunciona.UseVisualStyleBackColor = True
        '
        'BtnEnQueUtiliza
        '
        Me.BtnEnQueUtiliza.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEnQueUtiliza.Location = New System.Drawing.Point(25, 211)
        Me.BtnEnQueUtiliza.Name = "BtnEnQueUtiliza"
        Me.BtnEnQueUtiliza.Size = New System.Drawing.Size(451, 38)
        Me.BtnEnQueUtiliza.TabIndex = 7
        Me.BtnEnQueUtiliza.Text = "¿En qué se utiliza?"
        Me.BtnEnQueUtiliza.UseVisualStyleBackColor = True
        '
        'BtnExamen
        '
        Me.BtnExamen.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExamen.Location = New System.Drawing.Point(25, 267)
        Me.BtnExamen.Name = "BtnExamen"
        Me.BtnExamen.Size = New System.Drawing.Size(451, 38)
        Me.BtnExamen.TabIndex = 8
        Me.BtnExamen.Text = "Examen"
        Me.BtnExamen.UseVisualStyleBackColor = True
        '
        'OptionsMenuView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 335)
        Me.Controls.Add(Me.BtnExamen)
        Me.Controls.Add(Me.BtnEnQueUtiliza)
        Me.Controls.Add(Me.BtnComoFunciona)
        Me.Controls.Add(Me.BtnQueEs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OptionsMenuView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OptionsMenuView"
        Me.pnlbtn.ResumeLayout(False)
        Me.pnlbtn.PerformLayout()
        CType(Me.Btnminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlbtn As Panel
    Friend WithEvents Btnminimizar As PictureBox
    Friend WithEvents Btncerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnQueEs As Button
    Friend WithEvents BtnComoFunciona As Button
    Friend WithEvents BtnEnQueUtiliza As Button
    Friend WithEvents BtnExamen As Button
End Class
