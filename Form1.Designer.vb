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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToSurvivalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScrapMechanicFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScrapMechanicSurvivalFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowDoIUseThisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowenviromentVariablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenBlueprintsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreativeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SurvivalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BlueprintsName = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(395, 174)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 177)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Please Select your Scrap Mechanic Blueprints Folder"
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.Recent
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ShowenviromentVariablesToolStripMenuItem, Me.OpenBlueprintsFolderToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectPathToolStripMenuItem, Me.ImportToSurvivalToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SelectPathToolStripMenuItem
        '
        Me.SelectPathToolStripMenuItem.Name = "SelectPathToolStripMenuItem"
        Me.SelectPathToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SelectPathToolStripMenuItem.Text = "Select &Path"
        '
        'ImportToSurvivalToolStripMenuItem
        '
        Me.ImportToSurvivalToolStripMenuItem.Name = "ImportToSurvivalToolStripMenuItem"
        Me.ImportToSurvivalToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ImportToSurvivalToolStripMenuItem.Text = "&Import to Survival"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScrapMechanicFolderToolStripMenuItem, Me.ScrapMechanicSurvivalFolderToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        Me.SettingsToolStripMenuItem.Visible = False
        '
        'ScrapMechanicFolderToolStripMenuItem
        '
        Me.ScrapMechanicFolderToolStripMenuItem.Name = "ScrapMechanicFolderToolStripMenuItem"
        Me.ScrapMechanicFolderToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ScrapMechanicFolderToolStripMenuItem.Text = "&Scrap Mechanic &Creative Folder"
        '
        'ScrapMechanicSurvivalFolderToolStripMenuItem
        '
        Me.ScrapMechanicSurvivalFolderToolStripMenuItem.Name = "ScrapMechanicSurvivalFolderToolStripMenuItem"
        Me.ScrapMechanicSurvivalFolderToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ScrapMechanicSurvivalFolderToolStripMenuItem.Text = "Scrap Mechanic &Survival Folder"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HowDoIUseThisToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'HowDoIUseThisToolStripMenuItem
        '
        Me.HowDoIUseThisToolStripMenuItem.Name = "HowDoIUseThisToolStripMenuItem"
        Me.HowDoIUseThisToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.HowDoIUseThisToolStripMenuItem.Text = "&How do i use this?"
        '
        'ShowenviromentVariablesToolStripMenuItem
        '
        Me.ShowenviromentVariablesToolStripMenuItem.Name = "ShowenviromentVariablesToolStripMenuItem"
        Me.ShowenviromentVariablesToolStripMenuItem.Size = New System.Drawing.Size(161, 20)
        Me.ShowenviromentVariablesToolStripMenuItem.Text = "Show &enviroment variables"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'OpenBlueprintsFolderToolStripMenuItem
        '
        Me.OpenBlueprintsFolderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreativeToolStripMenuItem, Me.SurvivalToolStripMenuItem})
        Me.OpenBlueprintsFolderToolStripMenuItem.Name = "OpenBlueprintsFolderToolStripMenuItem"
        Me.OpenBlueprintsFolderToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.OpenBlueprintsFolderToolStripMenuItem.Text = "Open Blueprints Folder"
        '
        'CreativeToolStripMenuItem
        '
        Me.CreativeToolStripMenuItem.Name = "CreativeToolStripMenuItem"
        Me.CreativeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CreativeToolStripMenuItem.Text = "Creative"
        '
        'SurvivalToolStripMenuItem
        '
        Me.SurvivalToolStripMenuItem.Name = "SurvivalToolStripMenuItem"
        Me.SurvivalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SurvivalToolStripMenuItem.Text = "Survival"
        '
        'FolderBrowserDialog2
        '
        Me.FolderBrowserDialog2.Description = "Please Select your Scrap Mechanic Blueprints Folder"
        Me.FolderBrowserDialog2.RootFolder = System.Environment.SpecialFolder.Recent
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel1.Text = "Steam Folder found: No"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(184, 17)
        Me.ToolStripStatusLabel2.Text = "Scrap Mechanic Folder found: No"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(395, 355)
        Me.SplitContainer1.SplitterDistance = 177
        Me.SplitContainer1.TabIndex = 4
        '
        'BlueprintsName
        '
        Me.BlueprintsName.AutoSize = True
        Me.BlueprintsName.Location = New System.Drawing.Point(12, 43)
        Me.BlueprintsName.Name = "BlueprintsName"
        Me.BlueprintsName.Size = New System.Drawing.Size(0, 13)
        Me.BlueprintsName.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(413, 70)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(375, 355)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Blueprint|*.blueprint"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BlueprintsName)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Paitorocxon's Scrap Mechanic Blueprint Importer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToSurvivalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScrapMechanicFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScrapMechanicSurvivalFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowDoIUseThisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BlueprintsName As Label
    Friend WithEvents ShowenviromentVariablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenBlueprintsFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreativeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SurvivalToolStripMenuItem As ToolStripMenuItem
End Class
