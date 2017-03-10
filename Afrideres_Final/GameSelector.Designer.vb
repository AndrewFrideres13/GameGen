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
        Me.lbxGameList.AllowDrop = True
        Me.lbxGameList.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lbxGameList.Font = New System.Drawing.Font("Snap ITC", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxGameList.FormattingEnabled = True
        Me.lbxGameList.ItemHeight = 23
        Me.lbxGameList.Location = New System.Drawing.Point(27, 159)
        Me.lbxGameList.Name = "lbxGameList"
        Me.lbxGameList.Size = New System.Drawing.Size(308, 188)
        Me.lbxGameList.TabIndex = 0
        '
        'lbxSystem
        '
        Me.lbxSystem.BackColor = System.Drawing.SystemColors.Control
        Me.lbxSystem.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxSystem.ItemHeight = 25
        Me.lbxSystem.Location = New System.Drawing.Point(434, 159)
        Me.lbxSystem.Name = "lbxSystem"
        Me.lbxSystem.Size = New System.Drawing.Size(178, 179)
        Me.lbxSystem.TabIndex = 0
        '
        'lblGameSelector
        '
        Me.lblGameSelector.AutoSize = True
        Me.lblGameSelector.Font = New System.Drawing.Font("Ravie", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameSelector.Location = New System.Drawing.Point(104, 9)
        Me.lblGameSelector.Name = "lblGameSelector"
        Me.lblGameSelector.Size = New System.Drawing.Size(489, 63)
        Me.lblGameSelector.TabIndex = 2
        Me.lblGameSelector.Text = "Game Selector"
        '
        'lblGame
        '
        Me.lblGame.AutoEllipsis = True
        Me.lblGame.Font = New System.Drawing.Font("Snap ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.Location = New System.Drawing.Point(-3, 72)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(324, 84)
        Me.lblGame.TabIndex = 3
        Me.lblGame.Text = "Game"
        Me.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Font = New System.Drawing.Font("Snap ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.Location = New System.Drawing.Point(474, 96)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(128, 35)
        Me.lblSystem.TabIndex = 4
        Me.lblSystem.Text = "System"
        '
        'btnGameSelect
        '
        Me.btnGameSelect.Font = New System.Drawing.Font("Segoe Script", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGameSelect.Location = New System.Drawing.Point(27, 363)
        Me.btnGameSelect.Name = "btnGameSelect"
        Me.btnGameSelect.Size = New System.Drawing.Size(133, 90)
        Me.btnGameSelect.TabIndex = 5
        Me.btnGameSelect.Text = "Pick a game!"
        Me.btnGameSelect.UseVisualStyleBackColor = True
        '
        'lblGameText
        '
        Me.lblGameText.AutoSize = True
        Me.lblGameText.Font = New System.Drawing.Font("Snap ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameText.Location = New System.Drawing.Point(317, 97)
        Me.lblGameText.Name = "lblGameText"
        Me.lblGameText.Size = New System.Drawing.Size(126, 35)
        Me.lblGameText.TabIndex = 6
        Me.lblGameText.Text = "for the"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe Script", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(273, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 46)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe Script", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(481, 363)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 90)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Remove Game"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddGame
        '
        Me.btnAddGame.Font = New System.Drawing.Font("Segoe Script", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGame.Location = New System.Drawing.Point(270, 363)
        Me.btnAddGame.Name = "btnAddGame"
        Me.btnAddGame.Size = New System.Drawing.Size(124, 90)
        Me.btnAddGame.TabIndex = 12
        Me.btnAddGame.Text = "Add Game"
        Me.btnAddGame.UseVisualStyleBackColor = True
        '
        'GameSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(652, 526)
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
