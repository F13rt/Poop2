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
        Me.BTNexit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNexit
        '
        Me.BTNexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNexit.Location = New System.Drawing.Point(1544, 826)
        Me.BTNexit.Name = "BTNexit"
        Me.BTNexit.Size = New System.Drawing.Size(175, 76)
        Me.BTNexit.TabIndex = 0
        Me.BTNexit.Text = "E&xit"
        Me.BTNexit.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1731, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu
        '
        Me.Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkMode, Me.LightMode})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(82, 20)
        Me.Menu.Text = "Menu Items"
        '
        'DarkMode
        '
        Me.DarkMode.Name = "DarkMode"
        Me.DarkMode.Size = New System.Drawing.Size(180, 22)
        Me.DarkMode.Text = "Dark Mode"
        '
        'LightMode
        '
        Me.LightMode.Name = "LightMode"
        Me.LightMode.Size = New System.Drawing.Size(180, 22)
        Me.LightMode.Text = "Light Mode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(669, 76)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DrUnk DRiving Sim 2.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1731, 914)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNexit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Form1"
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
End Class
