<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AplicativoView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AplicativoView))
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FormRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnRealidad = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnMineria = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnRealidadRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnMineriaRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DragForm = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BtnCondicional = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnCondicionalRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PnlTop.SuspendLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PnlTop.Controls.Add(Me.BtnMinimize)
        Me.PnlTop.Controls.Add(Me.BtnClose)
        Me.PnlTop.Controls.Add(Me.Label1)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(611, 45)
        Me.PnlTop.TabIndex = 2
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.Location = New System.Drawing.Point(537, 7)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(31, 31)
        Me.BtnMinimize.TabIndex = 2
        Me.BtnMinimize.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(570, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(31, 31)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al aplicativo"
        '
        'FormRadius
        '
        Me.FormRadius.ElipseRadius = 5
        Me.FormRadius.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccione el tema a estudiar"
        '
        'BtnRealidad
        '
        Me.BtnRealidad.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnRealidad.color = System.Drawing.SystemColors.HotTrack
        Me.BtnRealidad.colorActive = System.Drawing.SystemColors.MenuHighlight
        Me.BtnRealidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRealidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRealidad.ForeColor = System.Drawing.Color.White
        Me.BtnRealidad.Image = CType(resources.GetObject("BtnRealidad.Image"), System.Drawing.Image)
        Me.BtnRealidad.ImagePosition = 14
        Me.BtnRealidad.ImageZoom = 50
        Me.BtnRealidad.LabelPosition = 29
        Me.BtnRealidad.LabelText = "Realidad aumentada"
        Me.BtnRealidad.Location = New System.Drawing.Point(221, 98)
        Me.BtnRealidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRealidad.Name = "BtnRealidad"
        Me.BtnRealidad.Size = New System.Drawing.Size(171, 127)
        Me.BtnRealidad.TabIndex = 5
        '
        'BtnMineria
        '
        Me.BtnMineria.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnMineria.color = System.Drawing.Color.SeaGreen
        Me.BtnMineria.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BtnMineria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMineria.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMineria.ForeColor = System.Drawing.Color.White
        Me.BtnMineria.Image = CType(resources.GetObject("BtnMineria.Image"), System.Drawing.Image)
        Me.BtnMineria.ImagePosition = 14
        Me.BtnMineria.ImageZoom = 50
        Me.BtnMineria.LabelPosition = 29
        Me.BtnMineria.LabelText = "Minería de datos"
        Me.BtnMineria.Location = New System.Drawing.Point(16, 98)
        Me.BtnMineria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMineria.Name = "BtnMineria"
        Me.BtnMineria.Size = New System.Drawing.Size(171, 127)
        Me.BtnMineria.TabIndex = 4
        '
        'BtnRealidadRadius
        '
        Me.BtnRealidadRadius.ElipseRadius = 5
        Me.BtnRealidadRadius.TargetControl = Me.BtnRealidad
        '
        'BtnMineriaRadius
        '
        Me.BtnMineriaRadius.ElipseRadius = 5
        Me.BtnMineriaRadius.TargetControl = Me.BtnMineria
        '
        'DragForm
        '
        Me.DragForm.Fixed = True
        Me.DragForm.Horizontal = True
        Me.DragForm.TargetControl = Me.PnlTop
        Me.DragForm.Vertical = True
        '
        'BtnCondicional
        '
        Me.BtnCondicional.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnCondicional.color = System.Drawing.SystemColors.HotTrack
        Me.BtnCondicional.colorActive = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCondicional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCondicional.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCondicional.ForeColor = System.Drawing.Color.White
        Me.BtnCondicional.Image = CType(resources.GetObject("BtnCondicional.Image"), System.Drawing.Image)
        Me.BtnCondicional.ImagePosition = 14
        Me.BtnCondicional.ImageZoom = 50
        Me.BtnCondicional.LabelPosition = 29
        Me.BtnCondicional.LabelText = "Condicionales"
        Me.BtnCondicional.Location = New System.Drawing.Point(421, 98)
        Me.BtnCondicional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCondicional.Name = "BtnCondicional"
        Me.BtnCondicional.Size = New System.Drawing.Size(171, 127)
        Me.BtnCondicional.TabIndex = 6
        '
        'BtnCondicionalRadius
        '
        Me.BtnCondicionalRadius.ElipseRadius = 5
        Me.BtnCondicionalRadius.TargetControl = Me.BtnCondicional
        '
        'AplicativoView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 252)
        Me.Controls.Add(Me.BtnCondicional)
        Me.Controls.Add(Me.BtnRealidad)
        Me.Controls.Add(Me.BtnMineria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AplicativoView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AplicativoView"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents BtnMinimize As PictureBox
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FormRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnRealidad As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnMineria As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnRealidadRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnMineriaRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DragForm As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BtnCondicional As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnCondicionalRadius As Bunifu.Framework.UI.BunifuElipse
End Class
