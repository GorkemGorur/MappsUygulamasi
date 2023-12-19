<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Me.AnaMenu = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DurumCubugu = New System.Windows.Forms.StatusStrip()
        Me.ZoomPBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.KonumLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.YakınlasGBox = New System.Windows.Forms.GroupBox()
        Me.ZoomNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HaritaSecimGBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HaritaSecCBox = New System.Windows.Forms.ComboBox()
        Me.KonumaGitGBox = New System.Windows.Forms.GroupBox()
        Me.KonumaGitBtn = New System.Windows.Forms.Button()
        Me.BoylamTBox = New System.Windows.Forms.TextBox()
        Me.EnlemTBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PRHMapKontrol = New GMap.NET.WindowsForms.GMapControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AdreseGitBtn = New System.Windows.Forms.Button()
        Me.AdresTBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AnaMenu.SuspendLayout()
        Me.DurumCubugu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.YakınlasGBox.SuspendLayout()
        CType(Me.ZoomNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HaritaSecimGBox.SuspendLayout()
        Me.KonumaGitGBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnaMenu
        '
        Me.AnaMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.AnaMenu.Location = New System.Drawing.Point(0, 0)
        Me.AnaMenu.Name = "AnaMenu"
        Me.AnaMenu.Size = New System.Drawing.Size(800, 24)
        Me.AnaMenu.TabIndex = 0
        Me.AnaMenu.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇıkışToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'DurumCubugu
        '
        Me.DurumCubugu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomPBar, Me.KonumLbl})
        Me.DurumCubugu.Location = New System.Drawing.Point(0, 428)
        Me.DurumCubugu.Name = "DurumCubugu"
        Me.DurumCubugu.Size = New System.Drawing.Size(800, 22)
        Me.DurumCubugu.TabIndex = 1
        Me.DurumCubugu.Text = "StatusStrip1"
        '
        'ZoomPBar
        '
        Me.ZoomPBar.Name = "ZoomPBar"
        Me.ZoomPBar.Size = New System.Drawing.Size(100, 16)
        '
        'KonumLbl
        '
        Me.KonumLbl.Name = "KonumLbl"
        Me.KonumLbl.Size = New System.Drawing.Size(49, 17)
        Me.KonumLbl.Text = "Konum:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.YakınlasGBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.HaritaSecimGBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KonumaGitGBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PRHMapKontrol)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 404)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 2
        '
        'YakınlasGBox
        '
        Me.YakınlasGBox.Controls.Add(Me.ZoomNUD)
        Me.YakınlasGBox.Controls.Add(Me.Label4)
        Me.YakınlasGBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.YakınlasGBox.Location = New System.Drawing.Point(0, 160)
        Me.YakınlasGBox.Name = "YakınlasGBox"
        Me.YakınlasGBox.Size = New System.Drawing.Size(250, 59)
        Me.YakınlasGBox.TabIndex = 2
        Me.YakınlasGBox.TabStop = False
        Me.YakınlasGBox.Text = "Yakınlaşma"
        '
        'ZoomNUD
        '
        Me.ZoomNUD.Location = New System.Drawing.Point(68, 25)
        Me.ZoomNUD.Name = "ZoomNUD"
        Me.ZoomNUD.Size = New System.Drawing.Size(108, 20)
        Me.ZoomNUD.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Yakınlaş:"
        '
        'HaritaSecimGBox
        '
        Me.HaritaSecimGBox.Controls.Add(Me.Label3)
        Me.HaritaSecimGBox.Controls.Add(Me.HaritaSecCBox)
        Me.HaritaSecimGBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.HaritaSecimGBox.Location = New System.Drawing.Point(0, 88)
        Me.HaritaSecimGBox.Name = "HaritaSecimGBox"
        Me.HaritaSecimGBox.Size = New System.Drawing.Size(250, 72)
        Me.HaritaSecimGBox.TabIndex = 1
        Me.HaritaSecimGBox.TabStop = False
        Me.HaritaSecimGBox.Text = "Harita Seçimi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harita:"
        '
        'HaritaSecCBox
        '
        Me.HaritaSecCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HaritaSecCBox.FormattingEnabled = True
        Me.HaritaSecCBox.Location = New System.Drawing.Point(57, 28)
        Me.HaritaSecCBox.Name = "HaritaSecCBox"
        Me.HaritaSecCBox.Size = New System.Drawing.Size(187, 21)
        Me.HaritaSecCBox.TabIndex = 0
        '
        'KonumaGitGBox
        '
        Me.KonumaGitGBox.Controls.Add(Me.KonumaGitBtn)
        Me.KonumaGitGBox.Controls.Add(Me.BoylamTBox)
        Me.KonumaGitGBox.Controls.Add(Me.EnlemTBox)
        Me.KonumaGitGBox.Controls.Add(Me.Label2)
        Me.KonumaGitGBox.Controls.Add(Me.Label1)
        Me.KonumaGitGBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.KonumaGitGBox.Location = New System.Drawing.Point(0, 0)
        Me.KonumaGitGBox.Name = "KonumaGitGBox"
        Me.KonumaGitGBox.Size = New System.Drawing.Size(250, 88)
        Me.KonumaGitGBox.TabIndex = 0
        Me.KonumaGitGBox.TabStop = False
        Me.KonumaGitGBox.Text = "Konuma Git"
        '
        'KonumaGitBtn
        '
        Me.KonumaGitBtn.Image = Global.PiriReisHarita.My.Resources.Resources.Konum
        Me.KonumaGitBtn.Location = New System.Drawing.Point(194, 16)
        Me.KonumaGitBtn.Name = "KonumaGitBtn"
        Me.KonumaGitBtn.Size = New System.Drawing.Size(50, 64)
        Me.KonumaGitBtn.TabIndex = 4
        Me.KonumaGitBtn.Text = "Git"
        Me.KonumaGitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KonumaGitBtn.UseVisualStyleBackColor = True
        '
        'BoylamTBox
        '
        Me.BoylamTBox.Location = New System.Drawing.Point(57, 52)
        Me.BoylamTBox.Name = "BoylamTBox"
        Me.BoylamTBox.Size = New System.Drawing.Size(131, 20)
        Me.BoylamTBox.TabIndex = 3
        '
        'EnlemTBox
        '
        Me.EnlemTBox.Location = New System.Drawing.Point(57, 26)
        Me.EnlemTBox.Name = "EnlemTBox"
        Me.EnlemTBox.Size = New System.Drawing.Size(131, 20)
        Me.EnlemTBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Boylam:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enlem:"
        '
        'PRHMapKontrol
        '
        Me.PRHMapKontrol.Bearing = 0!
        Me.PRHMapKontrol.CanDragMap = True
        Me.PRHMapKontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PRHMapKontrol.EmptyTileColor = System.Drawing.Color.Navy
        Me.PRHMapKontrol.GrayScaleMode = False
        Me.PRHMapKontrol.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.PRHMapKontrol.LevelsKeepInMemory = 5
        Me.PRHMapKontrol.Location = New System.Drawing.Point(0, 0)
        Me.PRHMapKontrol.MarkersEnabled = True
        Me.PRHMapKontrol.MaxZoom = 2
        Me.PRHMapKontrol.MinZoom = 2
        Me.PRHMapKontrol.MouseWheelZoomEnabled = True
        Me.PRHMapKontrol.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.PRHMapKontrol.Name = "PRHMapKontrol"
        Me.PRHMapKontrol.NegativeMode = False
        Me.PRHMapKontrol.PolygonsEnabled = True
        Me.PRHMapKontrol.RetryLoadTile = 0
        Me.PRHMapKontrol.RoutesEnabled = True
        Me.PRHMapKontrol.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.PRHMapKontrol.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PRHMapKontrol.ShowTileGridLines = False
        Me.PRHMapKontrol.Size = New System.Drawing.Size(546, 404)
        Me.PRHMapKontrol.TabIndex = 0
        Me.PRHMapKontrol.Zoom = 0R
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AdreseGitBtn)
        Me.GroupBox1.Controls.Add(Me.AdresTBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 88)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adrese Git"
        '
        'AdreseGitBtn
        '
        Me.AdreseGitBtn.Image = Global.PiriReisHarita.My.Resources.Resources.Konum
        Me.AdreseGitBtn.Location = New System.Drawing.Point(194, 16)
        Me.AdreseGitBtn.Name = "AdreseGitBtn"
        Me.AdreseGitBtn.Size = New System.Drawing.Size(50, 64)
        Me.AdreseGitBtn.TabIndex = 4
        Me.AdreseGitBtn.Text = "Git"
        Me.AdreseGitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AdreseGitBtn.UseVisualStyleBackColor = True
        '
        'AdresTBox
        '
        Me.AdresTBox.Location = New System.Drawing.Point(57, 16)
        Me.AdresTBox.Multiline = True
        Me.AdresTBox.Name = "AdresTBox"
        Me.AdresTBox.Size = New System.Drawing.Size(131, 64)
        Me.AdresTBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Adres:"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.DurumCubugu)
        Me.Controls.Add(Me.AnaMenu)
        Me.MainMenuStrip = Me.AnaMenu
        Me.Name = "AnaForm"
        Me.Text = "Piri Reis Harita Uygulaması"
        Me.AnaMenu.ResumeLayout(False)
        Me.AnaMenu.PerformLayout()
        Me.DurumCubugu.ResumeLayout(False)
        Me.DurumCubugu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.YakınlasGBox.ResumeLayout(False)
        Me.YakınlasGBox.PerformLayout()
        CType(Me.ZoomNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HaritaSecimGBox.ResumeLayout(False)
        Me.HaritaSecimGBox.PerformLayout()
        Me.KonumaGitGBox.ResumeLayout(False)
        Me.KonumaGitGBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AnaMenu As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DurumCubugu As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PRHMapKontrol As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents YakınlasGBox As GroupBox
    Friend WithEvents HaritaSecimGBox As GroupBox
    Friend WithEvents KonumaGitGBox As GroupBox
    Friend WithEvents KonumaGitBtn As Button
    Friend WithEvents BoylamTBox As TextBox
    Friend WithEvents EnlemTBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HaritaSecCBox As ComboBox
    Friend WithEvents ZoomPBar As ToolStripProgressBar
    Friend WithEvents KonumLbl As ToolStripStatusLabel
    Friend WithEvents ZoomNUD As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AdreseGitBtn As Button
    Friend WithEvents AdresTBox As TextBox
    Friend WithEvents Label6 As Label
End Class
