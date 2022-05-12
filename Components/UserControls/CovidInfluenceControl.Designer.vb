<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CovidInfluenceControl
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
        Me.ThirdBrowerComponent = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(761, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "El Covid 19 y la realidad aumentada"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ThirdBrowerComponent
        '
        Me.ThirdBrowerComponent.Location = New System.Drawing.Point(3, 49)
        Me.ThirdBrowerComponent.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ThirdBrowerComponent.Name = "ThirdBrowerComponent"
        Me.ThirdBrowerComponent.Size = New System.Drawing.Size(845, 324)
        Me.ThirdBrowerComponent.TabIndex = 3
        '
        'CovidInfluenceControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Controls.Add(Me.ThirdBrowerComponent)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "CovidInfluenceControl"
        Me.Size = New System.Drawing.Size(848, 373)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ThirdBrowerComponent As WebBrowser
End Class
