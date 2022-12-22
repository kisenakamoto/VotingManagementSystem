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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAdmin.Location = New System.Drawing.Point(277, 173)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(218, 86)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUser.Location = New System.Drawing.Point(277, 281)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(218, 86)
        Me.btnUser.TabIndex = 2
        Me.btnUser.Text = "USER"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VotingManagementSystem.My.Resources.Resources.IMG_3266
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 512)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnAdmin)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSG Voting System"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button

End Class
