<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealidadAumentadaView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealidadAumentadaView))
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FormRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PnlComponents = New System.Windows.Forms.Panel()
        Me.BtnPreview = New System.Windows.Forms.Button()
        Me.DragForm = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnExam = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnPrevRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnNextRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnExamRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnBackRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
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
        Me.PnlTop.Size = New System.Drawing.Size(896, 45)
        Me.PnlTop.TabIndex = 1
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.Location = New System.Drawing.Point(822, 7)
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
        Me.BtnClose.Location = New System.Drawing.Point(855, 7)
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
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tema 2 - Realidad aumentada"
        '
        'FormRadius
        '
        Me.FormRadius.ElipseRadius = 5
        Me.FormRadius.TargetControl = Me
        '
        'PnlComponents
        '
        Me.PnlComponents.Location = New System.Drawing.Point(23, 75)
        Me.PnlComponents.Name = "PnlComponents"
        Me.PnlComponents.Size = New System.Drawing.Size(848, 373)
        Me.PnlComponents.TabIndex = 2
        '
        'BtnPreview
        '
        Me.BtnPreview.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPreview.FlatAppearance.BorderSize = 0
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPreview.Location = New System.Drawing.Point(23, 474)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(178, 43)
        Me.BtnPreview.TabIndex = 5
        Me.BtnPreview.Text = "Anterior"
        Me.BtnPreview.UseVisualStyleBackColor = False
        '
        'DragForm
        '
        Me.DragForm.Fixed = True
        Me.DragForm.Horizontal = True
        Me.DragForm.TargetControl = Me.PnlTop
        Me.DragForm.Vertical = True
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.ForeColor = System.Drawing.Color.White
        Me.BtnNext.Location = New System.Drawing.Point(230, 474)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(178, 43)
        Me.BtnNext.TabIndex = 6
        Me.BtnNext.Text = "Siguiente"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnExam
        '
        Me.BtnExam.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnExam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExam.FlatAppearance.BorderSize = 0
        Me.BtnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExam.ForeColor = System.Drawing.Color.White
        Me.BtnExam.Location = New System.Drawing.Point(441, 474)
        Me.BtnExam.Name = "BtnExam"
        Me.BtnExam.Size = New System.Drawing.Size(226, 43)
        Me.BtnExam.TabIndex = 7
        Me.BtnExam.Text = "Presentar exámen"
        Me.BtnExam.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Crimson
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(696, 474)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(175, 43)
        Me.BtnBack.TabIndex = 8
        Me.BtnBack.Text = "Regresar"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnPrevRadius
        '
        Me.BtnPrevRadius.ElipseRadius = 5
        Me.BtnPrevRadius.TargetControl = Me.BtnPreview
        '
        'BtnNextRadius
        '
        Me.BtnNextRadius.ElipseRadius = 5
        Me.BtnNextRadius.TargetControl = Me.BtnNext
        '
        'BtnExamRadius
        '
        Me.BtnExamRadius.ElipseRadius = 5
        Me.BtnExamRadius.TargetControl = Me.BtnExam
        '
        'BtnBackRadius
        '
        Me.BtnBackRadius.ElipseRadius = 5
        Me.BtnBackRadius.TargetControl = Me.BtnBack
        '
        'PanelRadius
        '
        Me.PanelRadius.ElipseRadius = 5
        Me.PanelRadius.TargetControl = Me.PnlComponents
        '
        'RealidadAumentadaView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 549)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnExam)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPreview)
        Me.Controls.Add(Me.PnlComponents)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "RealidadAumentadaView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealidadAumentadaView"
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
    Friend WithEvents PnlComponents As Panel
    Friend WithEvents BtnPreview As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents DragForm As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BtnExam As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnPrevRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnNextRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnExamRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnBackRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelRadius As Bunifu.Framework.UI.BunifuElipse
End Class
