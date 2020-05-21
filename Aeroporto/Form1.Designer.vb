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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarAviãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarAviõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PróximoAviãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescolarAviãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilaToolStripMenuItem
        '
        Me.FilaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarAviãoToolStripMenuItem, Me.ListarAviõesToolStripMenuItem, Me.PróximoAviãoToolStripMenuItem, Me.DescolarAviãoToolStripMenuItem})
        Me.FilaToolStripMenuItem.Name = "FilaToolStripMenuItem"
        Me.FilaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.FilaToolStripMenuItem.Text = "Menu"
        '
        'AdicionarAviãoToolStripMenuItem
        '
        Me.AdicionarAviãoToolStripMenuItem.Name = "AdicionarAviãoToolStripMenuItem"
        Me.AdicionarAviãoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdicionarAviãoToolStripMenuItem.Text = "Adicionar Avião"
        '
        'ListarAviõesToolStripMenuItem
        '
        Me.ListarAviõesToolStripMenuItem.Name = "ListarAviõesToolStripMenuItem"
        Me.ListarAviõesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListarAviõesToolStripMenuItem.Text = "Listar Aviões"
        '
        'PróximoAviãoToolStripMenuItem
        '
        Me.PróximoAviãoToolStripMenuItem.Name = "PróximoAviãoToolStripMenuItem"
        Me.PróximoAviãoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PróximoAviãoToolStripMenuItem.Text = "Próximo Avião"
        '
        'DescolarAviãoToolStripMenuItem
        '
        Me.DescolarAviãoToolStripMenuItem.Name = "DescolarAviãoToolStripMenuItem"
        Me.DescolarAviãoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DescolarAviãoToolStripMenuItem.Text = "Descolar Avião"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aeroporto Sá da Bandeira"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Aviões a aguardar descolagem: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 307)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FilaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarAviãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarAviõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PróximoAviãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescolarAviãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
