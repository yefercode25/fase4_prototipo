<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.FormRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.TxtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DragForm = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSubname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BtnAction = New System.Windows.Forms.Button()
        Me.BtnActionRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PnlTop.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PnlTop.Controls.Add(Me.BtnClose)
        Me.PnlTop.Controls.Add(Me.LblTitle)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(392, 45)
        Me.PnlTop.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(351, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(31, 31)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTitle.Location = New System.Drawing.Point(12, 11)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(181, 19)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Gestión de estudiantes"
        '
        'FormRadius
        '
        Me.FormRadius.ElipseRadius = 5
        Me.FormRadius.TargetControl = Me
        '
        'TxtName
        '
        Me.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtName.HintForeColor = System.Drawing.Color.Empty
        Me.TxtName.HintText = ""
        Me.TxtName.isPassword = False
        Me.TxtName.LineFocusedColor = System.Drawing.SystemColors.Highlight
        Me.TxtName.LineIdleColor = System.Drawing.SystemColors.HotTrack
        Me.TxtName.LineMouseHoverColor = System.Drawing.Color.RoyalBlue
        Me.TxtName.LineThickness = 4
        Me.TxtName.Location = New System.Drawing.Point(16, 95)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(355, 33)
        Me.TxtName.TabIndex = 2
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DragForm
        '
        Me.DragForm.Fixed = True
        Me.DragForm.Horizontal = True
        Me.DragForm.TargetControl = Me.PnlTop
        Me.DragForm.Vertical = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellidos:"
        '
        'TxtSubname
        '
        Me.TxtSubname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSubname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtSubname.HintForeColor = System.Drawing.Color.Empty
        Me.TxtSubname.HintText = ""
        Me.TxtSubname.isPassword = False
        Me.TxtSubname.LineFocusedColor = System.Drawing.SystemColors.Highlight
        Me.TxtSubname.LineIdleColor = System.Drawing.SystemColors.HotTrack
        Me.TxtSubname.LineMouseHoverColor = System.Drawing.Color.RoyalBlue
        Me.TxtSubname.LineThickness = 4
        Me.TxtSubname.Location = New System.Drawing.Point(16, 178)
        Me.TxtSubname.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSubname.Name = "TxtSubname"
        Me.TxtSubname.Size = New System.Drawing.Size(355, 33)
        Me.TxtSubname.TabIndex = 4
        Me.TxtSubname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtEmail.HintForeColor = System.Drawing.Color.Empty
        Me.TxtEmail.HintText = ""
        Me.TxtEmail.isPassword = False
        Me.TxtEmail.LineFocusedColor = System.Drawing.SystemColors.Highlight
        Me.TxtEmail.LineIdleColor = System.Drawing.SystemColors.HotTrack
        Me.TxtEmail.LineMouseHoverColor = System.Drawing.Color.RoyalBlue
        Me.TxtEmail.LineThickness = 4
        Me.TxtEmail.Location = New System.Drawing.Point(16, 265)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(355, 33)
        Me.TxtEmail.TabIndex = 6
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contraseña:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.TxtPassword.HintText = ""
        Me.TxtPassword.isPassword = False
        Me.TxtPassword.LineFocusedColor = System.Drawing.SystemColors.Highlight
        Me.TxtPassword.LineIdleColor = System.Drawing.SystemColors.HotTrack
        Me.TxtPassword.LineMouseHoverColor = System.Drawing.Color.RoyalBlue
        Me.TxtPassword.LineThickness = 4
        Me.TxtPassword.Location = New System.Drawing.Point(16, 347)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(355, 33)
        Me.TxtPassword.TabIndex = 8
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnAction
        '
        Me.BtnAction.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnAction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAction.FlatAppearance.BorderSize = 0
        Me.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAction.ForeColor = System.Drawing.Color.White
        Me.BtnAction.Location = New System.Drawing.Point(12, 409)
        Me.BtnAction.Name = "BtnAction"
        Me.BtnAction.Size = New System.Drawing.Size(359, 43)
        Me.BtnAction.TabIndex = 10
        Me.BtnAction.Text = "Agregar"
        Me.BtnAction.UseVisualStyleBackColor = False
        '
        'BtnActionRadius
        '
        Me.BtnActionRadius.ElipseRadius = 5
        Me.BtnActionRadius.TargetControl = Me.BtnAction
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(392, 476)
        Me.Controls.Add(Me.BtnAction)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSubname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentForm"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents FormRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents TxtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DragForm As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSubname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnAction As Button
    Friend WithEvents BtnActionRadius As Bunifu.Framework.UI.BunifuElipse
End Class
