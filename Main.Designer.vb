<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TypeDrop = New System.Windows.Forms.ComboBox()
        Me.ExtDrop = New System.Windows.Forms.ComboBox()
        Me.URLText = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.LogBox = New System.Windows.Forms.RichTextBox()
        Me.FileText = New System.Windows.Forms.TextBox()
        Me.JobList = New System.Windows.Forms.ListBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.LogLabel = New System.Windows.Forms.Label()
        Me.ConvertLabel = New System.Windows.Forms.Label()
        Me.ExtLabel = New System.Windows.Forms.Label()
        Me.URLLabel = New System.Windows.Forms.Label()
        Me.FileLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatreonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderText = New System.Windows.Forms.TextBox()
        Me.DirButton = New System.Windows.Forms.Button()
        Me.FolderLabel = New System.Windows.Forms.Label()
        Me.CRLabel = New System.Windows.Forms.Label()
        Me.AppLabel = New System.Windows.Forms.Label()
        Me.VerLabel = New System.Windows.Forms.Label()
        Me.GetButton = New System.Windows.Forms.Button()
        Me.NameCheck = New System.Windows.Forms.CheckBox()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackCheck = New System.Windows.Forms.CheckBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TypeDrop
        '
        Me.TypeDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeDrop.FormattingEnabled = True
        Me.TypeDrop.Items.AddRange(New Object() {"Streaming To Audio"})
        Me.TypeDrop.Location = New System.Drawing.Point(93, 46)
        Me.TypeDrop.Name = "TypeDrop"
        Me.TypeDrop.Size = New System.Drawing.Size(199, 23)
        Me.TypeDrop.TabIndex = 0
        '
        'ExtDrop
        '
        Me.ExtDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ExtDrop.FormattingEnabled = True
        Me.ExtDrop.Items.AddRange(New Object() {"best quality"})
        Me.ExtDrop.Location = New System.Drawing.Point(93, 84)
        Me.ExtDrop.Name = "ExtDrop"
        Me.ExtDrop.Size = New System.Drawing.Size(199, 23)
        Me.ExtDrop.TabIndex = 1
        '
        'URLText
        '
        Me.URLText.Location = New System.Drawing.Point(298, 46)
        Me.URLText.Name = "URLText"
        Me.URLText.Size = New System.Drawing.Size(572, 21)
        Me.URLText.TabIndex = 2
        '
        'AddButton
        '
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AddButton.Location = New System.Drawing.Point(792, 83)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(78, 23)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'LogBox
        '
        Me.LogBox.Location = New System.Drawing.Point(12, 325)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.Size = New System.Drawing.Size(858, 109)
        Me.LogBox.TabIndex = 13
        Me.LogBox.Text = ""
        '
        'FileText
        '
        Me.FileText.Location = New System.Drawing.Point(298, 85)
        Me.FileText.Name = "FileText"
        Me.FileText.Size = New System.Drawing.Size(396, 21)
        Me.FileText.TabIndex = 4
        '
        'JobList
        '
        Me.JobList.FormattingEnabled = True
        Me.JobList.ItemHeight = 15
        Me.JobList.Location = New System.Drawing.Point(12, 116)
        Me.JobList.Name = "JobList"
        Me.JobList.Size = New System.Drawing.Size(766, 169)
        Me.JobList.TabIndex = 7
        '
        'RemoveButton
        '
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RemoveButton.Location = New System.Drawing.Point(792, 189)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(78, 23)
        Me.RemoveButton.TabIndex = 8
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GoButton.Location = New System.Drawing.Point(792, 293)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(78, 23)
        Me.GoButton.TabIndex = 11
        Me.GoButton.Text = "Go!"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'LogLabel
        '
        Me.LogLabel.AutoSize = True
        Me.LogLabel.Location = New System.Drawing.Point(9, 307)
        Me.LogLabel.Name = "LogLabel"
        Me.LogLabel.Size = New System.Drawing.Size(84, 15)
        Me.LogLabel.TabIndex = 26
        Me.LogLabel.Text = "Status Log:"
        '
        'ConvertLabel
        '
        Me.ConvertLabel.AutoSize = True
        Me.ConvertLabel.Location = New System.Drawing.Point(90, 30)
        Me.ConvertLabel.Name = "ConvertLabel"
        Me.ConvertLabel.Size = New System.Drawing.Size(119, 15)
        Me.ConvertLabel.TabIndex = 21
        Me.ConvertLabel.Text = "Conversion Type:"
        '
        'ExtLabel
        '
        Me.ExtLabel.AutoSize = True
        Me.ExtLabel.Location = New System.Drawing.Point(90, 68)
        Me.ExtLabel.Name = "ExtLabel"
        Me.ExtLabel.Size = New System.Drawing.Size(77, 15)
        Me.ExtLabel.TabIndex = 22
        Me.ExtLabel.Text = "File Type:"
        '
        'URLLabel
        '
        Me.URLLabel.AutoSize = True
        Me.URLLabel.Location = New System.Drawing.Point(295, 30)
        Me.URLLabel.Name = "URLLabel"
        Me.URLLabel.Size = New System.Drawing.Size(35, 15)
        Me.URLLabel.TabIndex = 23
        Me.URLLabel.Text = "URL:"
        '
        'FileLabel
        '
        Me.FileLabel.AutoSize = True
        Me.FileLabel.Location = New System.Drawing.Point(295, 68)
        Me.FileLabel.Name = "FileLabel"
        Me.FileLabel.Size = New System.Drawing.Size(98, 15)
        Me.FileLabel.TabIndex = 24
        Me.FileLabel.Text = "New FileName:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.DonateToolStripMenuItem, Me.PatreonToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'PatreonToolStripMenuItem
        '
        Me.PatreonToolStripMenuItem.Name = "PatreonToolStripMenuItem"
        Me.PatreonToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PatreonToolStripMenuItem.Text = "Patreon"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FolderText
        '
        Me.FolderText.Location = New System.Drawing.Point(298, 294)
        Me.FolderText.Name = "FolderText"
        Me.FolderText.Size = New System.Drawing.Size(376, 21)
        Me.FolderText.TabIndex = 9
        '
        'DirButton
        '
        Me.DirButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DirButton.Location = New System.Drawing.Point(680, 294)
        Me.DirButton.Name = "DirButton"
        Me.DirButton.Size = New System.Drawing.Size(98, 23)
        Me.DirButton.TabIndex = 10
        Me.DirButton.Text = "Select Path"
        Me.DirButton.UseVisualStyleBackColor = True
        '
        'FolderLabel
        '
        Me.FolderLabel.AutoSize = True
        Me.FolderLabel.Location = New System.Drawing.Point(152, 297)
        Me.FolderLabel.Name = "FolderLabel"
        Me.FolderLabel.Size = New System.Drawing.Size(140, 15)
        Me.FolderLabel.TabIndex = 25
        Me.FolderLabel.Text = "Destination Folder:"
        '
        'CRLabel
        '
        Me.CRLabel.AutoSize = True
        Me.CRLabel.Location = New System.Drawing.Point(593, 441)
        Me.CRLabel.Name = "CRLabel"
        Me.CRLabel.Size = New System.Drawing.Size(280, 15)
        Me.CRLabel.TabIndex = 19
        Me.CRLabel.Text = "Copyright © 2021 by ClarkTribeGames LLC"
        '
        'AppLabel
        '
        Me.AppLabel.AutoSize = True
        Me.AppLabel.Location = New System.Drawing.Point(9, 441)
        Me.AppLabel.Name = "AppLabel"
        Me.AppLabel.Size = New System.Drawing.Size(140, 15)
        Me.AppLabel.TabIndex = 27
        Me.AppLabel.Text = "CTGMediaExtractor v"
        '
        'VerLabel
        '
        Me.VerLabel.AutoSize = True
        Me.VerLabel.Location = New System.Drawing.Point(147, 441)
        Me.VerLabel.Name = "VerLabel"
        Me.VerLabel.Size = New System.Drawing.Size(56, 15)
        Me.VerLabel.TabIndex = 28
        Me.VerLabel.Text = "1.0.0.0"
        '
        'GetButton
        '
        Me.GetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GetButton.Location = New System.Drawing.Point(700, 83)
        Me.GetButton.Name = "GetButton"
        Me.GetButton.Size = New System.Drawing.Size(78, 23)
        Me.GetButton.TabIndex = 5
        Me.GetButton.Text = "Get Title"
        Me.GetButton.UseVisualStyleBackColor = True
        '
        'NameCheck
        '
        Me.NameCheck.AutoSize = True
        Me.NameCheck.Checked = True
        Me.NameCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NameCheck.Location = New System.Drawing.Point(399, 67)
        Me.NameCheck.Name = "NameCheck"
        Me.NameCheck.Size = New System.Drawing.Size(124, 19)
        Me.NameCheck.TabIndex = 3
        Me.NameCheck.Text = "Use Video Name"
        Me.NameCheck.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.NewButton.Location = New System.Drawing.Point(792, 262)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(78, 23)
        Me.NewButton.TabIndex = 12
        Me.NewButton.Text = "Start Over"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CTGMediaExtractor.My.Resources.Resources.image
        Me.PictureBox1.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'BackCheck
        '
        Me.BackCheck.AutoSize = True
        Me.BackCheck.Checked = True
        Me.BackCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BackCheck.Font = New System.Drawing.Font("Courier New", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackCheck.Location = New System.Drawing.Point(12, 293)
        Me.BackCheck.Name = "BackCheck"
        Me.BackCheck.Size = New System.Drawing.Size(139, 14)
        Me.BackCheck.TabIndex = 30
        Me.BackCheck.Text = "Show Background Windows"
        Me.ToolTips.SetToolTip(Me.BackCheck, "Recommended to keep on to observe conversion status.")
        Me.BackCheck.UseVisualStyleBackColor = True
        '
        'ToolTips
        '
        Me.ToolTips.AutomaticDelay = 150
        Me.ToolTips.BackColor = System.Drawing.Color.White
        Me.ToolTips.ForeColor = System.Drawing.Color.Black
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.BackCheck)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.GetButton)
        Me.Controls.Add(Me.VerLabel)
        Me.Controls.Add(Me.CRLabel)
        Me.Controls.Add(Me.FolderLabel)
        Me.Controls.Add(Me.DirButton)
        Me.Controls.Add(Me.FolderText)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FileLabel)
        Me.Controls.Add(Me.URLLabel)
        Me.Controls.Add(Me.ConvertLabel)
        Me.Controls.Add(Me.LogLabel)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.JobList)
        Me.Controls.Add(Me.FileText)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.URLText)
        Me.Controls.Add(Me.ExtDrop)
        Me.Controls.Add(Me.TypeDrop)
        Me.Controls.Add(Me.AppLabel)
        Me.Controls.Add(Me.NameCheck)
        Me.Controls.Add(Me.ExtLabel)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CTGMediaExtractor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TypeDrop As ComboBox
    Friend WithEvents ExtDrop As ComboBox
    Friend WithEvents URLText As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents LogBox As RichTextBox
    Friend WithEvents FileText As TextBox
    Friend WithEvents JobList As ListBox
    Friend WithEvents RemoveButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents LogLabel As Label
    Friend WithEvents ConvertLabel As Label
    Friend WithEvents ExtLabel As Label
    Friend WithEvents URLLabel As Label
    Friend WithEvents FileLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatreonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderText As TextBox
    Friend WithEvents DirButton As Button
    Friend WithEvents FolderLabel As Label
    Friend WithEvents CRLabel As Label
    Friend WithEvents AppLabel As Label
    Friend WithEvents VerLabel As Label
    Friend WithEvents GetButton As Button
    Friend WithEvents NameCheck As CheckBox
    Friend WithEvents NewButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackCheck As CheckBox
    Friend WithEvents ToolTips As ToolTip
End Class
