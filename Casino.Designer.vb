<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Casino
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
        Me.BTNexit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DriveHome = New System.Windows.Forms.Button()
        Me.Bathroom = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.MoneyCounter = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNexit
        '
        Me.BTNexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNexit.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNexit.Location = New System.Drawing.Point(1485, 847)
        Me.BTNexit.Name = "BTNexit"
        Me.BTNexit.Size = New System.Drawing.Size(234, 55)
        Me.BTNexit.TabIndex = 0
        Me.BTNexit.Text = "E&xit"
        Me.BTNexit.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1731, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu
        '
        Me.Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkMode, Me.LightMode})
        Me.Menu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(129, 29)
        Me.Menu.Text = "Menu Items"
        '
        'DarkMode
        '
        Me.DarkMode.Name = "DarkMode"
        Me.DarkMode.Size = New System.Drawing.Size(186, 30)
        Me.DarkMode.Text = "Dark Mode"
        '
        'LightMode
        '
        Me.LightMode.Name = "LightMode"
        Me.LightMode.Size = New System.Drawing.Size(186, 30)
        Me.LightMode.Text = "Light Mode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(900, 102)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DrUnk DRiving Sim 2.0"
        '
        'DriveHome
        '
        Me.DriveHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DriveHome.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriveHome.Location = New System.Drawing.Point(1485, 786)
        Me.DriveHome.Name = "DriveHome"
        Me.DriveHome.Size = New System.Drawing.Size(234, 55)
        Me.DriveHome.TabIndex = 3
        Me.DriveHome.Text = "Drive Home"
        Me.DriveHome.UseVisualStyleBackColor = False
        '
        'Bathroom
        '
        Me.Bathroom.BackColor = System.Drawing.Color.Yellow
        Me.Bathroom.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bathroom.Location = New System.Drawing.Point(1485, 725)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(234, 55)
        Me.Bathroom.TabIndex = 4
        Me.Bathroom.Text = "Go To The Bathroom"
        Me.Bathroom.UseVisualStyleBackColor = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Reset.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(1245, 847)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(234, 55)
        Me.Reset.TabIndex = 5
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = False
        Me.Reset.Visible = False
        '
        'MoneyCounter
        '
        Me.MoneyCounter.AutoSize = True
        Me.MoneyCounter.Font = New System.Drawing.Font("Yu Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyCounter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MoneyCounter.Location = New System.Drawing.Point(1570, 49)
        Me.MoneyCounter.Name = "MoneyCounter"
        Me.MoneyCounter.Size = New System.Drawing.Size(149, 27)
        Me.MoneyCounter.TabIndex = 6
        Me.MoneyCounter.Text = "Money: $1000"
        '
        'Casino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1731, 914)
        Me.Controls.Add(Me.MoneyCounter)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.DriveHome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNexit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Casino"
        Me.Text = "Casino"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNexit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Menu As ToolStripMenuItem
    Friend WithEvents DarkMode As ToolStripMenuItem
    Friend WithEvents LightMode As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DriveHome As Button
    Friend WithEvents Bathroom As Button
    Friend WithEvents Reset As Button
    Friend WithEvents MoneyCounter As Label
End Class
