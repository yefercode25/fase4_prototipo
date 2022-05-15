<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhoCreateControl
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
        Me.SecondComponentBrower = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SecondComponentBrower
        '
        Me.SecondComponentBrower.Location = New System.Drawing.Point(3, 52)
        Me.SecondComponentBrower.MinimumSize = New System.Drawing.Size(20, 20)
        Me.SecondComponentBrower.Name = "SecondComponentBrower"
        Me.SecondComponentBrower.Size = New System.Drawing.Size(845, 318)
        Me.SecondComponentBrower.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(147, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cómo se crea la realidad aumentada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(170, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Este recurso requiere conexión a internet"
        '
        'WhoCreateControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SecondComponentBrower)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WhoCreateControl"
        Me.Size = New System.Drawing.Size(848, 373)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SecondComponentBrower As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
