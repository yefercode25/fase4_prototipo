<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OneComponentBrower = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(229, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Qué es la realidad aumentada?"
        '
        'OneComponentBrower
        '
        Me.OneComponentBrower.Location = New System.Drawing.Point(1, 46)
        Me.OneComponentBrower.MinimumSize = New System.Drawing.Size(20, 20)
        Me.OneComponentBrower.Name = "OneComponentBrower"
        Me.OneComponentBrower.Size = New System.Drawing.Size(845, 324)
        Me.OneComponentBrower.TabIndex = 1
        '
        'MeaningControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Controls.Add(Me.OneComponentBrower)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MeaningControl"
        Me.Size = New System.Drawing.Size(848, 373)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OneComponentBrower As WebBrowser
End Class
