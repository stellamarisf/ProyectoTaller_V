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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnpaly = New System.Windows.Forms.Button()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(194, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ganaste!!!!!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Snap ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(194, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ganaste!!!!!"
        '
        'btnpaly
        '
        Me.btnpaly.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnpaly.ForeColor = System.Drawing.Color.Black
        Me.btnpaly.Location = New System.Drawing.Point(638, 93)
        Me.btnpaly.Name = "btnpaly"
        Me.btnpaly.Size = New System.Drawing.Size(75, 38)
        Me.btnpaly.TabIndex = 2
        Me.btnpaly.Text = "Play"
        Me.btnpaly.UseVisualStyleBackColor = True
        '
        'btnstop
        '
        Me.btnstop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnstop.ForeColor = System.Drawing.Color.Black
        Me.btnstop.Location = New System.Drawing.Point(638, 156)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(75, 37)
        Me.btnstop.TabIndex = 3
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(149, 40)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(41, 15)
        Me.lblfecha.TabIndex = 4
        Me.lblfecha.Text = "Label3"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Snap ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(194, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 42)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ganaste!!!!!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 282)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnpaly)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Timer ♥"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnpaly As Button
    Friend WithEvents btnstop As Button
    Friend WithEvents lblfecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label3 As Label
End Class
