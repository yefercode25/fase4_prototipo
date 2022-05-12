<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitMenuView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InitMenuView))
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FormRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnAdminStudents = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnLogin = New Bunifu.Framework.UI.BunifuTileButton()
        Me.DragForm = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BtnAdminRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnLoginRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
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
        Me.PnlTop.Size = New System.Drawing.Size(445, 45)
        Me.PnlTop.TabIndex = 1
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.Location = New System.Drawing.Point(371, 7)
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
        Me.BtnClose.Location = New System.Drawing.Point(404, 7)
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
        Me.Label1.Size = New System.Drawing.Size(152, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Acciones de inicio"
        '
        'FormRadius
        '
        Me.FormRadius.ElipseRadius = 5
        Me.FormRadius.TargetControl = Me
        '
        'BtnAdminStudents
        '
        Me.BtnAdminStudents.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnAdminStudents.color = System.Drawing.Color.SeaGreen
        Me.BtnAdminStudents.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BtnAdminStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminStudents.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdminStudents.ForeColor = System.Drawing.Color.White
        Me.BtnAdminStudents.Image = CType(resources.GetObject("BtnAdminStudents.Image"), System.Drawing.Image)
        Me.BtnAdminStudents.ImagePosition = 14
        Me.BtnAdminStudents.ImageZoom = 50
        Me.BtnAdminStudents.LabelPosition = 29
        Me.BtnAdminStudents.LabelText = "Administrar Estudiantes"
        Me.BtnAdminStudents.Location = New System.Drawing.Point(34, 81)
        Me.BtnAdminStudents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAdminStudents.Name = "BtnAdminStudents"
        Me.BtnAdminStudents.Size = New System.Drawing.Size(171, 127)
        Me.BtnAdminStudents.TabIndex = 2
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnLogin.color = System.Drawing.SystemColors.HotTrack
        Me.BtnLogin.colorActive = System.Drawing.SystemColors.MenuHighlight
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Image = CType(resources.GetObject("BtnLogin.Image"), System.Drawing.Image)
        Me.BtnLogin.ImagePosition = 14
        Me.BtnLogin.ImageZoom = 50
        Me.BtnLogin.LabelPosition = 29
        Me.BtnLogin.LabelText = "Iniciar Sesión"
        Me.BtnLogin.Location = New System.Drawing.Point(241, 81)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(171, 127)
        Me.BtnLogin.TabIndex = 3
        '
        'DragForm
        '
        Me.DragForm.Fixed = True
        Me.DragForm.Horizontal = True
        Me.DragForm.TargetControl = Me.PnlTop
        Me.DragForm.Vertical = True
        '
        'BtnAdminRadius
        '
        Me.BtnAdminRadius.ElipseRadius = 5
        Me.BtnAdminRadius.TargetControl = Me.BtnAdminStudents
        '
        'BtnLoginRadius
        '
        Me.BtnLoginRadius.ElipseRadius = 5
        Me.BtnLoginRadius.TargetControl = Me.BtnLogin
        '
        'InitMenuView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 243)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnAdminStudents)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "InitMenuView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InitMenuView"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents BtnMinimize As PictureBox
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FormRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnAdminStudents As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnLogin As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents DragForm As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BtnAdminRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnLoginRadius As Bunifu.Framework.UI.BunifuElipse
End Class
