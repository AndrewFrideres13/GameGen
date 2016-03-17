<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameSelector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbxGameList = New System.Windows.Forms.ListBox()
        Me.lbxSystem = New System.Windows.Forms.ListBox()
        Me.lblGameSelector = New System.Windows.Forms.Label()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.btnGameSelect = New System.Windows.Forms.Button()
        Me.lblGameText = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbxGameList
        '
        Me.lbxGameList.FormattingEnabled = True
        Me.lbxGameList.Location = New System.Drawing.Point(24, 106)
        Me.lbxGameList.Name = "lbxGameList"
        Me.lbxGameList.Size = New System.Drawing.Size(150, 95)
        Me.lbxGameList.TabIndex = 0
        '
        'lbxSystem
        '
        Me.lbxSystem.FormattingEnabled = True
        Me.lbxSystem.Location = New System.Drawing.Point(283, 106)
        Me.lbxSystem.Name = "lbxSystem"
        Me.lbxSystem.Size = New System.Drawing.Size(147, 95)
        Me.lbxSystem.TabIndex = 1
        '
        'lblGameSelector
        '
        Me.lblGameSelector.AutoSize = True
        Me.lblGameSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblGameSelector.Location = New System.Drawing.Point(105, 9)
        Me.lblGameSelector.Name = "lblGameSelector"
        Me.lblGameSelector.Size = New System.Drawing.Size(243, 39)
        Me.lblGameSelector.TabIndex = 2
        Me.lblGameSelector.Text = "Game Selector"
        '
        'lblGame
        '
        Me.lblGame.AutoEllipsis = True
        Me.lblGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblGame.Location = New System.Drawing.Point(39, 59)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(135, 44)
        Me.lblGame.TabIndex = 3
        Me.lblGame.Text = "Game"
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblSystem.Location = New System.Drawing.Point(331, 56)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(71, 24)
        Me.lblSystem.TabIndex = 4
        Me.lblSystem.Text = "System"
        '
        'btnGameSelect
        '
        Me.btnGameSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnGameSelect.Location = New System.Drawing.Point(24, 207)
        Me.btnGameSelect.Name = "btnGameSelect"
        Me.btnGameSelect.Size = New System.Drawing.Size(105, 62)
        Me.btnGameSelect.TabIndex = 5
        Me.btnGameSelect.Text = "Pick a game!"
        Me.btnGameSelect.UseVisualStyleBackColor = True
        '
        'lblGameText
        '
        Me.lblGameText.AutoSize = True
        Me.lblGameText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblGameText.Location = New System.Drawing.Point(194, 56)
        Me.lblGameText.Name = "lblGameText"
        Me.lblGameText.Size = New System.Drawing.Size(62, 24)
        Me.lblGameText.TabIndex = 6
        Me.lblGameText.Text = "for the"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnExit.Location = New System.Drawing.Point(325, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 62)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(233, 207)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(76, 62)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Remove Game"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddGame
        '
        Me.btnAddGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGame.Location = New System.Drawing.Point(148, 207)
        Me.btnAddGame.Name = "btnAddGame"
        Me.btnAddGame.Size = New System.Drawing.Size(73, 62)
        Me.btnAddGame.TabIndex = 12
        Me.btnAddGame.Text = "Add a Game"
        Me.btnAddGame.UseVisualStyleBackColor = True
        '
        'GameSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 291)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddGame)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblGameText)
        Me.Controls.Add(Me.btnGameSelect)
        Me.Controls.Add(Me.lblSystem)
        Me.Controls.Add(Me.lblGame)
        Me.Controls.Add(Me.lblGameSelector)
        Me.Controls.Add(Me.lbxSystem)
        Me.Controls.Add(Me.lbxGameList)
        Me.Name = "GameSelector"
        Me.Text = "Game Selector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxGameList As ListBox
    Friend WithEvents lbxSystem As ListBox
    Friend WithEvents lblGameSelector As Label
    Friend WithEvents lblGame As Label
    Friend WithEvents lblSystem As Label
    Friend WithEvents btnGameSelect As Button
    Friend WithEvents lblGameText As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddGame As Button
End Class
