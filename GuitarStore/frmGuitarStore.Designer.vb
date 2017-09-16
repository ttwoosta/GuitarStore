<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuitarStore
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpGuitarChoices = New System.Windows.Forms.GroupBox()
        Me.rdoElectricGuitar = New System.Windows.Forms.RadioButton()
        Me.rdoSteelStringAcoustic = New System.Windows.Forms.RadioButton()
        Me.rdoClassicalAcoustic = New System.Windows.Forms.RadioButton()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picGuitar = New System.Windows.Forms.PictureBox()
        Me.grpGuitarChoices.SuspendLayout()
        CType(Me.picGuitar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(129, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(308, 29)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "What guitar would you like?"
        '
        'grpGuitarChoices
        '
        Me.grpGuitarChoices.Controls.Add(Me.rdoElectricGuitar)
        Me.grpGuitarChoices.Controls.Add(Me.rdoSteelStringAcoustic)
        Me.grpGuitarChoices.Controls.Add(Me.rdoClassicalAcoustic)
        Me.grpGuitarChoices.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGuitarChoices.Location = New System.Drawing.Point(24, 91)
        Me.grpGuitarChoices.Name = "grpGuitarChoices"
        Me.grpGuitarChoices.Size = New System.Drawing.Size(264, 169)
        Me.grpGuitarChoices.TabIndex = 2
        Me.grpGuitarChoices.TabStop = False
        Me.grpGuitarChoices.Text = "Guitar Choices"
        '
        'rdoElectricGuitar
        '
        Me.rdoElectricGuitar.AutoSize = True
        Me.rdoElectricGuitar.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoElectricGuitar.Location = New System.Drawing.Point(47, 120)
        Me.rdoElectricGuitar.Name = "rdoElectricGuitar"
        Me.rdoElectricGuitar.Size = New System.Drawing.Size(112, 21)
        Me.rdoElectricGuitar.TabIndex = 2
        Me.rdoElectricGuitar.Text = "Electric Guitar"
        Me.rdoElectricGuitar.UseVisualStyleBackColor = True
        '
        'rdoSteelStringAcoustic
        '
        Me.rdoSteelStringAcoustic.AutoSize = True
        Me.rdoSteelStringAcoustic.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSteelStringAcoustic.Location = New System.Drawing.Point(47, 78)
        Me.rdoSteelStringAcoustic.Name = "rdoSteelStringAcoustic"
        Me.rdoSteelStringAcoustic.Size = New System.Drawing.Size(153, 21)
        Me.rdoSteelStringAcoustic.TabIndex = 1
        Me.rdoSteelStringAcoustic.Text = "Steel String Acoustic"
        Me.rdoSteelStringAcoustic.UseVisualStyleBackColor = True
        '
        'rdoClassicalAcoustic
        '
        Me.rdoClassicalAcoustic.AutoSize = True
        Me.rdoClassicalAcoustic.Checked = True
        Me.rdoClassicalAcoustic.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoClassicalAcoustic.Location = New System.Drawing.Point(47, 36)
        Me.rdoClassicalAcoustic.Name = "rdoClassicalAcoustic"
        Me.rdoClassicalAcoustic.Size = New System.Drawing.Size(132, 21)
        Me.rdoClassicalAcoustic.TabIndex = 0
        Me.rdoClassicalAcoustic.TabStop = True
        Me.rdoClassicalAcoustic.Text = "Classical Acoustic"
        Me.rdoClassicalAcoustic.UseVisualStyleBackColor = True
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnjoy.Location = New System.Drawing.Point(72, 458)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(169, 24)
        Me.lblEnjoy.TabIndex = 3
        Me.lblEnjoy.Text = "Enjoy your guitar!"
        '
        'btnPurchase
        '
        Me.btnPurchase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.Location = New System.Drawing.Point(101, 375)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(111, 36)
        Me.btnPurchase.TabIndex = 4
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(74, 535)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(165, 36)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Guitar Store"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picGuitar
        '
        Me.picGuitar.Location = New System.Drawing.Point(310, 91)
        Me.picGuitar.Name = "picGuitar"
        Me.picGuitar.Size = New System.Drawing.Size(283, 480)
        Me.picGuitar.TabIndex = 6
        Me.picGuitar.TabStop = False
        '
        'frmGuitarStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 601)
        Me.Controls.Add(Me.picGuitar)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.grpGuitarChoices)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmGuitarStore"
        Me.Text = "Guitar Store"
        Me.grpGuitarChoices.ResumeLayout(False)
        Me.grpGuitarChoices.PerformLayout()
        CType(Me.picGuitar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpGuitarChoices As GroupBox
    Friend WithEvents rdoElectricGuitar As RadioButton
    Friend WithEvents rdoSteelStringAcoustic As RadioButton
    Friend WithEvents rdoClassicalAcoustic As RadioButton
    Friend WithEvents lblEnjoy As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picGuitar As PictureBox
End Class
