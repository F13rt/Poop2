<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bar
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
        Me.BAC = New System.Windows.Forms.Label()
        Me.Bathroom = New System.Windows.Forms.Button()
        Me.DriveHome = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BAC
        '
        Me.BAC.AutoSize = True
        Me.BAC.Font = New System.Drawing.Font("Segoe Print", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAC.Location = New System.Drawing.Point(12, 9)
        Me.BAC.Name = "BAC"
        Me.BAC.Size = New System.Drawing.Size(301, 77)
        Me.BAC.TabIndex = 0
        Me.BAC.Text = "B.A.C.: 0.00"
        '
        'Bathroom
        '
        Me.Bathroom.BackColor = System.Drawing.Color.Yellow
        Me.Bathroom.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bathroom.Location = New System.Drawing.Point(455, 246)
        Me.Bathroom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(237, 42)
        Me.Bathroom.TabIndex = 6
        Me.Bathroom.Text = "Go To The Bathroom"
        Me.Bathroom.UseVisualStyleBackColor = False
        '
        'DriveHome
        '
        Me.DriveHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DriveHome.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DriveHome.Location = New System.Drawing.Point(455, 298)
        Me.DriveHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DriveHome.Name = "DriveHome"
        Me.DriveHome.Size = New System.Drawing.Size(237, 42)
        Me.DriveHome.TabIndex = 5
        Me.DriveHome.Text = "Drive Home"
        Me.DriveHome.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Back.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(455, 350)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(237, 42)
        Me.Back.TabIndex = 7
        Me.Back.Text = "Go Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Coors Light", "Bud Light", "Jack Daniels", "Crown Royal", "Whiskey", "Rum"})
        Me.ListBox1.Location = New System.Drawing.Point(25, 147)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(288, 124)
        Me.ListBox1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(25, 279)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(288, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Drink" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Bar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(705, 403)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.DriveHome)
        Me.Controls.Add(Me.BAC)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Bar"
        Me.Text = "Bar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BAC As Label
    Friend WithEvents Bathroom As Button
    Friend WithEvents DriveHome As Button
    Friend WithEvents Back As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
End Class
