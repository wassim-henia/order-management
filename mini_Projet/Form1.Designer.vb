<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListesDesClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FournisseursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListesDesFournisseursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListesDesProduisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FactureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListesDesFacturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientsToolStripMenuItem, Me.FournisseursToolStripMenuItem, Me.ProduitsToolStripMenuItem, Me.FactureToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.ListesDesClientsToolStripMenuItem})
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.ClientsToolStripMenuItem.Text = "Clients"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.AjouterToolStripMenuItem.Text = "Ajouter un Client"
        '
        'ListesDesClientsToolStripMenuItem
        '
        Me.ListesDesClientsToolStripMenuItem.Name = "ListesDesClientsToolStripMenuItem"
        Me.ListesDesClientsToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ListesDesClientsToolStripMenuItem.Text = "Listes des Clients"
        '
        'FournisseursToolStripMenuItem
        '
        Me.FournisseursToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem1, Me.ListesDesFournisseursToolStripMenuItem})
        Me.FournisseursToolStripMenuItem.Name = "FournisseursToolStripMenuItem"
        Me.FournisseursToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.FournisseursToolStripMenuItem.Text = "Fournisseurs"
        '
        'AjouterToolStripMenuItem1
        '
        Me.AjouterToolStripMenuItem1.Name = "AjouterToolStripMenuItem1"
        Me.AjouterToolStripMenuItem1.Size = New System.Drawing.Size(239, 26)
        Me.AjouterToolStripMenuItem1.Text = "Ajouter un Fournisseur"
        '
        'ListesDesFournisseursToolStripMenuItem
        '
        Me.ListesDesFournisseursToolStripMenuItem.Name = "ListesDesFournisseursToolStripMenuItem"
        Me.ListesDesFournisseursToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.ListesDesFournisseursToolStripMenuItem.Text = "Listes des Fournisseurs"
        '
        'ProduitsToolStripMenuItem
        '
        Me.ProduitsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem2, Me.ListesDesProduisToolStripMenuItem})
        Me.ProduitsToolStripMenuItem.Name = "ProduitsToolStripMenuItem"
        Me.ProduitsToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.ProduitsToolStripMenuItem.Text = "Produits"
        '
        'AjouterToolStripMenuItem2
        '
        Me.AjouterToolStripMenuItem2.Name = "AjouterToolStripMenuItem2"
        Me.AjouterToolStripMenuItem2.Size = New System.Drawing.Size(213, 26)
        Me.AjouterToolStripMenuItem2.Text = "Ajouter un Produit"
        '
        'ListesDesProduisToolStripMenuItem
        '
        Me.ListesDesProduisToolStripMenuItem.Name = "ListesDesProduisToolStripMenuItem"
        Me.ListesDesProduisToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.ListesDesProduisToolStripMenuItem.Text = "Listes des Produis"
        '
        'FactureToolStripMenuItem
        '
        Me.FactureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem3, Me.ListesDesFacturesToolStripMenuItem})
        Me.FactureToolStripMenuItem.Name = "FactureToolStripMenuItem"
        Me.FactureToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.FactureToolStripMenuItem.Text = "Factures"
        '
        'AjouterToolStripMenuItem3
        '
        Me.AjouterToolStripMenuItem3.Name = "AjouterToolStripMenuItem3"
        Me.AjouterToolStripMenuItem3.Size = New System.Drawing.Size(220, 26)
        Me.AjouterToolStripMenuItem3.Text = "Ajouter une Facture"
        '
        'ListesDesFacturesToolStripMenuItem
        '
        Me.ListesDesFacturesToolStripMenuItem.Name = "ListesDesFacturesToolStripMenuItem"
        Me.ListesDesFacturesToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.ListesDesFacturesToolStripMenuItem.Text = "Listes des Factures"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(30, 24)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AProposToolStripMenuItem.Text = "A propos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(859, 479)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principale"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FournisseursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProduitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FactureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListesDesClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListesDesFournisseursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListesDesProduisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListesDesFacturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
End Class
