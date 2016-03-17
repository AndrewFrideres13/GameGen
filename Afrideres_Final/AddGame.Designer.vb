<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAddGame = New System.Windows.Forms.Button()
        Me.txtGame = New System.Windows.Forms.TextBox()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.txtSystem = New System.Windows.Forms.TextBox()
        Me.lblGame = New System.Windows.Forms.Label()
        Me.lblSyst = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(167, 132)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 31)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddGame
        '
        Me.btnAddGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnAddGame.Location = New System.Drawing.Point(167, 61)
        Me.btnAddGame.Name = "btnAddGame"
        Me.btnAddGame.Size = New System.Drawing.Size(105, 55)
        Me.btnAddGame.TabIndex = 10
        Me.btnAddGame.Text = "Add Game Info"
        Me.btnAddGame.UseVisualStyleBackColor = True
        '
        'txtGame
        '
        Me.txtGame.Location = New System.Drawing.Point(36, 89)
        Me.txtGame.Name = "txtGame"
        Me.txtGame.Size = New System.Drawing.Size(105, 20)
        Me.txtGame.TabIndex = 11
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.lblAdd.Location = New System.Drawing.Point(56, 9)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(190, 29)
        Me.lblAdd.TabIndex = 12
        Me.lblAdd.Text = "Add Game Form"
        '
        'txtSystem
        '
        Me.txtSystem.Location = New System.Drawing.Point(36, 140)
        Me.txtSystem.Name = "txtSystem"
        Me.txtSystem.Size = New System.Drawing.Size(105, 20)
        Me.txtSystem.TabIndex = 14
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblGame.Location = New System.Drawing.Point(53, 61)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(65, 25)
        Me.lblGame.TabIndex = 15
        Me.lblGame.Text = "Game"
        '
        'lblSyst
        '
        Me.lblSyst.AutoSize = True
        Me.lblSyst.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblSyst.Location = New System.Drawing.Point(47, 112)
        Me.lblSyst.Name = "lblSyst"
        Me.lblSyst.Size = New System.Drawing.Size(78, 25)
        Me.lblSyst.TabIndex = 16
        Me.lblSyst.Text = "System"
        '
        'AddGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 192)
        Me.Controls.Add(Me.lblSyst)
        Me.Controls.Add(Me.lblGame)
        Me.Controls.Add(Me.txtSystem)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.txtGame)
        Me.Controls.Add(Me.btnAddGame)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "AddGame"
        Me.Text = "Add Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddGame As Button
    Friend WithEvents txtGame As TextBox
    Friend WithEvents lblAdd As Label
    Friend WithEvents txtSystem As TextBox
    Friend WithEvents lblGame As Label
    Friend WithEvents lblSyst As Label
End Class
