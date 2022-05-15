<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExamView
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamView))
        Me.TopPanelView = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FormRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DragTopPanel = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnPrev = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnPrevRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnFinish = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnFinishRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BtnNext = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnNextRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.RadOptionA = New System.Windows.Forms.RadioButton()
        Me.RadOptionB = New System.Windows.Forms.RadioButton()
        Me.RadOptionC = New System.Windows.Forms.RadioButton()
        Me.RadOptionD = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.BtnResetForm = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnResetRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ControlTime = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Animate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.TopPanelView.SuspendLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanelView
        '
        Me.TopPanelView.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TopPanelView.Controls.Add(Me.BtnMinimize)
        Me.TopPanelView.Controls.Add(Me.BtnClose)
        Me.TopPanelView.Controls.Add(Me.Label1)
        Me.Animate.SetDecoration(Me.TopPanelView, BunifuAnimatorNS.DecorationType.None)
        Me.TopPanelView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanelView.Location = New System.Drawing.Point(0, 0)
        Me.TopPanelView.Name = "TopPanelView"
        Me.TopPanelView.Size = New System.Drawing.Size(1054, 50)
        Me.TopPanelView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Animate.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Examen - Realidad aumentada"
        '
        'FormRadius
        '
        Me.FormRadius.ElipseRadius = 10
        Me.FormRadius.TargetControl = Me
        '
        'DragTopPanel
        '
        Me.DragTopPanel.Fixed = True
        Me.DragTopPanel.Horizontal = True
        Me.DragTopPanel.TargetControl = Me.TopPanelView
        Me.DragTopPanel.Vertical = True
        '
        'LblTitle
        '
        Me.Animate.SetDecoration(Me.LblTitle, BunifuAnimatorNS.DecorationType.None)
        Me.LblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(22, 76)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(1009, 24)
        Me.LblTitle.TabIndex = 23
        Me.LblTitle.Text = "Este es el título de la pregunta, hagamos esta evaluación"
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnPrev.color = System.Drawing.SystemColors.HotTrack
        Me.BtnPrev.colorActive = System.Drawing.SystemColors.Highlight
        Me.BtnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animate.SetDecoration(Me.BtnPrev, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPrev.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.ForeColor = System.Drawing.Color.White
        Me.BtnPrev.Image = Nothing
        Me.BtnPrev.ImagePosition = 13
        Me.BtnPrev.ImageZoom = 50
        Me.BtnPrev.LabelPosition = 26
        Me.BtnPrev.LabelText = "Anterior"
        Me.BtnPrev.Location = New System.Drawing.Point(26, 261)
        Me.BtnPrev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(108, 35)
        Me.BtnPrev.TabIndex = 39
        '
        'BtnPrevRadius
        '
        Me.BtnPrevRadius.ElipseRadius = 5
        Me.BtnPrevRadius.TargetControl = Me.BtnPrev
        '
        'BtnFinish
        '
        Me.BtnFinish.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnFinish.color = System.Drawing.SystemColors.HotTrack
        Me.BtnFinish.colorActive = System.Drawing.SystemColors.Highlight
        Me.BtnFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animate.SetDecoration(Me.BtnFinish, BunifuAnimatorNS.DecorationType.None)
        Me.BtnFinish.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinish.ForeColor = System.Drawing.Color.White
        Me.BtnFinish.Image = Nothing
        Me.BtnFinish.ImagePosition = 13
        Me.BtnFinish.ImageZoom = 50
        Me.BtnFinish.LabelPosition = 26
        Me.BtnFinish.LabelText = "Finalizar cuestionario"
        Me.BtnFinish.Location = New System.Drawing.Point(157, 261)
        Me.BtnFinish.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(183, 35)
        Me.BtnFinish.TabIndex = 40
        '
        'BtnFinishRadius
        '
        Me.BtnFinishRadius.ElipseRadius = 5
        Me.BtnFinishRadius.TargetControl = Me.BtnFinish
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnNext.color = System.Drawing.SystemColors.HotTrack
        Me.BtnNext.colorActive = System.Drawing.SystemColors.Highlight
        Me.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animate.SetDecoration(Me.BtnNext, BunifuAnimatorNS.DecorationType.None)
        Me.BtnNext.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.White
        Me.BtnNext.Image = Nothing
        Me.BtnNext.ImagePosition = 13
        Me.BtnNext.ImageZoom = 50
        Me.BtnNext.LabelPosition = 26
        Me.BtnNext.LabelText = "Siguiente"
        Me.BtnNext.Location = New System.Drawing.Point(366, 261)
        Me.BtnNext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(108, 35)
        Me.BtnNext.TabIndex = 41
        '
        'BtnNextRadius
        '
        Me.BtnNextRadius.ElipseRadius = 5
        Me.BtnNextRadius.TargetControl = Me.BtnNext
        '
        'RadOptionA
        '
        Me.RadOptionA.AutoSize = True
        Me.Animate.SetDecoration(Me.RadOptionA, BunifuAnimatorNS.DecorationType.None)
        Me.RadOptionA.ForeColor = System.Drawing.Color.White
        Me.RadOptionA.Location = New System.Drawing.Point(31, 111)
        Me.RadOptionA.Name = "RadOptionA"
        Me.RadOptionA.Size = New System.Drawing.Size(438, 25)
        Me.RadOptionA.TabIndex = 42
        Me.RadOptionA.TabStop = True
        Me.RadOptionA.Text = "Esta es la primera opción, no es la correcta o talvez sí"
        Me.RadOptionA.UseVisualStyleBackColor = True
        '
        'RadOptionB
        '
        Me.RadOptionB.AutoSize = True
        Me.Animate.SetDecoration(Me.RadOptionB, BunifuAnimatorNS.DecorationType.None)
        Me.RadOptionB.ForeColor = System.Drawing.Color.White
        Me.RadOptionB.Location = New System.Drawing.Point(31, 143)
        Me.RadOptionB.Name = "RadOptionB"
        Me.RadOptionB.Size = New System.Drawing.Size(447, 25)
        Me.RadOptionB.TabIndex = 43
        Me.RadOptionB.TabStop = True
        Me.RadOptionB.Text = "Esta es la segunda opción, no es la correcta o talvez sí"
        Me.RadOptionB.UseVisualStyleBackColor = True
        '
        'RadOptionC
        '
        Me.RadOptionC.AutoSize = True
        Me.Animate.SetDecoration(Me.RadOptionC, BunifuAnimatorNS.DecorationType.None)
        Me.RadOptionC.ForeColor = System.Drawing.Color.White
        Me.RadOptionC.Location = New System.Drawing.Point(31, 174)
        Me.RadOptionC.Name = "RadOptionC"
        Me.RadOptionC.Size = New System.Drawing.Size(425, 25)
        Me.RadOptionC.TabIndex = 44
        Me.RadOptionC.TabStop = True
        Me.RadOptionC.Text = "Esta es la tercer opción, no es la correcta o talvez sí"
        Me.RadOptionC.UseVisualStyleBackColor = True
        '
        'RadOptionD
        '
        Me.RadOptionD.AutoSize = True
        Me.Animate.SetDecoration(Me.RadOptionD, BunifuAnimatorNS.DecorationType.None)
        Me.RadOptionD.ForeColor = System.Drawing.Color.White
        Me.RadOptionD.Location = New System.Drawing.Point(31, 205)
        Me.RadOptionD.Name = "RadOptionD"
        Me.RadOptionD.Size = New System.Drawing.Size(432, 25)
        Me.RadOptionD.TabIndex = 45
        Me.RadOptionD.TabStop = True
        Me.RadOptionD.Text = "Esta es la cuarta opción, no es la correcta o talvez sí"
        Me.RadOptionD.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Animate.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(26, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 28)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Resultado:"
        Me.Label13.Visible = False
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.Animate.SetDecoration(Me.LblResult, BunifuAnimatorNS.DecorationType.None)
        Me.LblResult.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.LblResult.Location = New System.Drawing.Point(165, 326)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(21, 23)
        Me.LblResult.TabIndex = 47
        Me.LblResult.Text = "?"
        Me.LblResult.Visible = False
        '
        'BtnResetForm
        '
        Me.BtnResetForm.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnResetForm.color = System.Drawing.SystemColors.HotTrack
        Me.BtnResetForm.colorActive = System.Drawing.SystemColors.Highlight
        Me.BtnResetForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animate.SetDecoration(Me.BtnResetForm, BunifuAnimatorNS.DecorationType.None)
        Me.BtnResetForm.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetForm.ForeColor = System.Drawing.Color.White
        Me.BtnResetForm.Image = Nothing
        Me.BtnResetForm.ImagePosition = 13
        Me.BtnResetForm.ImageZoom = 50
        Me.BtnResetForm.LabelPosition = 26
        Me.BtnResetForm.LabelText = "Reiniciar cuestionario"
        Me.BtnResetForm.Location = New System.Drawing.Point(498, 261)
        Me.BtnResetForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnResetForm.Name = "BtnResetForm"
        Me.BtnResetForm.Size = New System.Drawing.Size(184, 35)
        Me.BtnResetForm.TabIndex = 48
        Me.BtnResetForm.Visible = False
        '
        'BtnResetRadius
        '
        Me.BtnResetRadius.ElipseRadius = 5
        Me.BtnResetRadius.TargetControl = Me.BtnResetForm
        '
        'ControlTime
        '
        Me.ControlTime.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Animate.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(482, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 23)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Tiempo Restante:"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.Animate.SetDecoration(Me.LblTime, BunifuAnimatorNS.DecorationType.None)
        Me.LblTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.LblTime.Location = New System.Drawing.Point(651, 328)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(114, 19)
        Me.LblTime.TabIndex = 50
        Me.LblTime.Text = "180 segundos"
        '
        'Animate
        '
        Me.Animate.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.Animate.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.Animate.DefaultAnimation = Animation3
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animate.SetDecoration(Me.BtnMinimize, BunifuAnimatorNS.DecorationType.None)
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.Location = New System.Drawing.Point(979, 9)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(31, 31)
        Me.BtnMinimize.TabIndex = 4
        Me.BtnMinimize.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animate.SetDecoration(Me.BtnClose, BunifuAnimatorNS.DecorationType.None)
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(1012, 9)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(31, 31)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.TabStop = False
        '
        'ExamView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1054, 379)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnResetForm)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.RadOptionD)
        Me.Controls.Add(Me.RadOptionC)
        Me.Controls.Add(Me.RadOptionB)
        Me.Controls.Add(Me.RadOptionA)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnFinish)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.TopPanelView)
        Me.Animate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ExamView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio13"
        Me.TopPanelView.ResumeLayout(False)
        Me.TopPanelView.PerformLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopPanelView As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FormRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DragTopPanel As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnFinish As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnPrev As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnPrevRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnFinishRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnNext As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnNextRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents RadOptionA As RadioButton
    Friend WithEvents RadOptionD As RadioButton
    Friend WithEvents RadOptionC As RadioButton
    Friend WithEvents RadOptionB As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents BtnResetForm As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BtnResetRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ControlTime As Timer
    Friend WithEvents LblTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Animate As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BtnMinimize As PictureBox
    Friend WithEvents BtnClose As PictureBox
End Class
