<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginView))
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FormRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnLoginAction = New System.Windows.Forms.Button()
        Me.BtnLoginActionRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.LblCreateUser = New System.Windows.Forms.Label()
        Me.DragForm = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.LblNotCredentials = New System.Windows.Forms.Label()
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
        Me.PnlTop.Size = New System.Drawing.Size(295, 45)
        Me.PnlTop.TabIndex = 2
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.Location = New System.Drawing.Point(221, 7)
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
        Me.BtnClose.Location = New System.Drawing.Point(254, 7)
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
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Iniciar sesión"
        '
        'FormRadius
        '
        Me.FormRadius.ElipseRadius = 5
        Me.FormRadius.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.White
        Me.TxtEmail.HintForeColor = System.Drawing.Color.Empty
        Me.TxtEmail.HintText = ""
        Me.TxtEmail.isPassword = False
        Me.TxtEmail.LineFocusedColor = System.Drawing.Color.SlateGray
        Me.TxtEmail.LineIdleColor = System.Drawing.Color.White
        Me.TxtEmail.LineMouseHoverColor = System.Drawing.Color.SlateGray
        Me.TxtEmail.LineThickness = 4
        Me.TxtEmail.Location = New System.Drawing.Point(18, 92)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(252, 39)
        Me.TxtEmail.TabIndex = 4
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtPass
        '
        Me.TxtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.White
        Me.TxtPass.HintForeColor = System.Drawing.Color.Empty
        Me.TxtPass.HintText = ""
        Me.TxtPass.isPassword = False
        Me.TxtPass.LineFocusedColor = System.Drawing.Color.SlateGray
        Me.TxtPass.LineIdleColor = System.Drawing.Color.White
        Me.TxtPass.LineMouseHoverColor = System.Drawing.Color.SlateGray
        Me.TxtPass.LineThickness = 4
        Me.TxtPass.Location = New System.Drawing.Point(20, 192)
        Me.TxtPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(252, 39)
        Me.TxtPass.TabIndex = 6
        Me.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña:"
        '
        'BtnLoginAction
        '
        Me.BtnLoginAction.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnLoginAction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoginAction.FlatAppearance.BorderSize = 0
        Me.BtnLoginAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoginAction.ForeColor = System.Drawing.Color.White
        Me.BtnLoginAction.Location = New System.Drawing.Point(20, 274)
        Me.BtnLoginAction.Name = "BtnLoginAction"
        Me.BtnLoginAction.Size = New System.Drawing.Size(250, 43)
        Me.BtnLoginAction.TabIndex = 7
        Me.BtnLoginAction.Text = "Acceder"
        Me.BtnLoginAction.UseVisualStyleBackColor = False
        '
        'BtnLoginActionRadius
        '
        Me.BtnLoginActionRadius.ElipseRadius = 5
        Me.BtnLoginActionRadius.TargetControl = Me.BtnLoginAction
        '
        'LblCreateUser
        '
        Me.LblCreateUser.AutoSize = True
        Me.LblCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCreateUser.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LblCreateUser.ForeColor = System.Drawing.Color.Lime
        Me.LblCreateUser.Location = New System.Drawing.Point(48, 323)
        Me.LblCreateUser.Name = "LblCreateUser"
        Me.LblCreateUser.Size = New System.Drawing.Size(193, 19)
        Me.LblCreateUser.TabIndex = 8
        Me.LblCreateUser.Text = "Registrar nuevo estudiante"
        '
        'DragForm
        '
        Me.DragForm.Fixed = True
        Me.DragForm.Horizontal = True
        Me.DragForm.TargetControl = Me.PnlTop
        Me.DragForm.Vertical = True
        '
        'LblNotCredentials
        '
        Me.LblNotCredentials.AutoSize = True
        Me.LblNotCredentials.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblNotCredentials.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotCredentials.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LblNotCredentials.Location = New System.Drawing.Point(59, 375)
        Me.LblNotCredentials.Name = "LblNotCredentials"
        Me.LblNotCredentials.Size = New System.Drawing.Size(161, 16)
        Me.LblNotCredentials.TabIndex = 9
        Me.LblNotCredentials.Text = "Acceder como invitado"
        '
        'LoginView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(295, 413)
        Me.Controls.Add(Me.LblNotCredentials)
        Me.Controls.Add(Me.LblCreateUser)
        Me.Controls.Add(Me.BtnLoginAction)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "LoginView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginView"
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
    Friend WithEvents TxtEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLoginAction As Button
    Friend WithEvents BtnLoginActionRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents LblCreateUser As Label
    Friend WithEvents DragForm As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LblNotCredentials As Label
End Class
