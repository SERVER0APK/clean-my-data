<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ComboBoxDrives = New System.Windows.Forms.ComboBox()
        Me.LabelTotalSize = New System.Windows.Forms.Label()
        Me.LabelUsedSize = New System.Windows.Forms.Label()
        Me.LabelFreeSize = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonCreateFile = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelProgressPercentage = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxDrives
        '
        Me.ComboBoxDrives.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ComboBoxDrives.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxDrives.ForeColor = System.Drawing.SystemColors.Window
        Me.ComboBoxDrives.FormattingEnabled = True
        Me.ComboBoxDrives.Location = New System.Drawing.Point(29, 44)
        Me.ComboBoxDrives.Name = "ComboBoxDrives"
        Me.ComboBoxDrives.Size = New System.Drawing.Size(247, 21)
        Me.ComboBoxDrives.TabIndex = 0
        '
        'LabelTotalSize
        '
        Me.LabelTotalSize.AutoSize = True
        Me.LabelTotalSize.Location = New System.Drawing.Point(117, 84)
        Me.LabelTotalSize.Name = "LabelTotalSize"
        Me.LabelTotalSize.Size = New System.Drawing.Size(0, 13)
        Me.LabelTotalSize.TabIndex = 1
        '
        'LabelUsedSize
        '
        Me.LabelUsedSize.AutoSize = True
        Me.LabelUsedSize.Location = New System.Drawing.Point(117, 116)
        Me.LabelUsedSize.Name = "LabelUsedSize"
        Me.LabelUsedSize.Size = New System.Drawing.Size(0, 13)
        Me.LabelUsedSize.TabIndex = 2
        '
        'LabelFreeSize
        '
        Me.LabelFreeSize.AutoSize = True
        Me.LabelFreeSize.Location = New System.Drawing.Point(117, 148)
        Me.LabelFreeSize.Name = "LabelFreeSize"
        Me.LabelFreeSize.Size = New System.Drawing.Size(0, 13)
        Me.LabelFreeSize.TabIndex = 3
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(29, 180)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(247, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'ButtonCreateFile
        '
        Me.ButtonCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCreateFile.Location = New System.Drawing.Point(111, 285)
        Me.ButtonCreateFile.Name = "ButtonCreateFile"
        Me.ButtonCreateFile.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCreateFile.TabIndex = 5
        Me.ButtonCreateFile.Text = "Start"
        Me.ButtonCreateFile.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(26, 236)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(0, 13)
        Me.LabelTime.TabIndex = 6
        '
        'LabelProgressPercentage
        '
        Me.LabelProgressPercentage.AutoSize = True
        Me.LabelProgressPercentage.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.LabelProgressPercentage.Location = New System.Drawing.Point(114, 186)
        Me.LabelProgressPercentage.Name = "LabelProgressPercentage"
        Me.LabelProgressPercentage.Size = New System.Drawing.Size(0, 13)
        Me.LabelProgressPercentage.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(258, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(305, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelProgressPercentage)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.ButtonCreateFile)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LabelFreeSize)
        Me.Controls.Add(Me.LabelUsedSize)
        Me.Controls.Add(Me.LabelTotalSize)
        Me.Controls.Add(Me.ComboBoxDrives)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxDrives As ComboBox
    Friend WithEvents LabelTotalSize As Label
    Friend WithEvents LabelUsedSize As Label
    Friend WithEvents LabelFreeSize As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ButtonCreateFile As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelTime As Label
    Friend WithEvents LabelProgressPercentage As Label
    Friend WithEvents Button1 As Button
End Class
