<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSaveClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditAuctions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReportsPurchaseActivity = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReportsShowInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cboSelectAuction = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.tsmEdit, Me.tsmReports, Me.tsmHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(637, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSaveClose, Me.tsmExit})
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(44, 24)
        Me.tsmFile.Text = "&File"
        '
        'tsmSaveClose
        '
        Me.tsmSaveClose.Name = "tsmSaveClose"
        Me.tsmSaveClose.Size = New System.Drawing.Size(171, 26)
        Me.tsmSaveClose.Text = "&Save && Close"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(171, 26)
        Me.tsmExit.Text = "E&xit"
        '
        'tsmEdit
        '
        Me.tsmEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEditAuctions, Me.tsmEditInventory})
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(47, 24)
        Me.tsmEdit.Text = "&Edit"
        '
        'tsmEditAuctions
        '
        Me.tsmEditAuctions.Name = "tsmEditAuctions"
        Me.tsmEditAuctions.Size = New System.Drawing.Size(145, 26)
        Me.tsmEditAuctions.Text = "A&uctions"
        '
        'tsmEditInventory
        '
        Me.tsmEditInventory.Name = "tsmEditInventory"
        Me.tsmEditInventory.Size = New System.Drawing.Size(145, 26)
        Me.tsmEditInventory.Text = "&Inventory"
        '
        'tsmReports
        '
        Me.tsmReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmReportsPurchaseActivity, Me.tsmReportsShowInventory})
        Me.tsmReports.Name = "tsmReports"
        Me.tsmReports.Size = New System.Drawing.Size(72, 24)
        Me.tsmReports.Text = "&Reports"
        '
        'tsmReportsPurchaseActivity
        '
        Me.tsmReportsPurchaseActivity.Name = "tsmReportsPurchaseActivity"
        Me.tsmReportsPurchaseActivity.Size = New System.Drawing.Size(195, 26)
        Me.tsmReportsPurchaseActivity.Text = "&Purchase Activity"
        '
        'tsmReportsShowInventory
        '
        Me.tsmReportsShowInventory.Name = "tsmReportsShowInventory"
        Me.tsmReportsShowInventory.Size = New System.Drawing.Size(195, 26)
        Me.tsmReportsShowInventory.Text = "&Show Inventory"
        '
        'tsmHelp
        '
        Me.tsmHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmHelpAbout})
        Me.tsmHelp.Name = "tsmHelp"
        Me.tsmHelp.Size = New System.Drawing.Size(53, 24)
        Me.tsmHelp.Text = "&Help"
        '
        'tsmHelpAbout
        '
        Me.tsmHelpAbout.Name = "tsmHelpAbout"
        Me.tsmHelpAbout.Size = New System.Drawing.Size(125, 26)
        Me.tsmHelpAbout.Text = "&About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(637, 25)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(153, 20)
        Me.lblStatus.Text = "ToolStripStatusLabel1"
        '
        'cboSelectAuction
        '
        Me.cboSelectAuction.FormattingEnabled = True
        Me.cboSelectAuction.Items.AddRange(New Object() {"1000", "1001", "1002"})
        Me.cboSelectAuction.Location = New System.Drawing.Point(137, 76)
        Me.cboSelectAuction.Name = "cboSelectAuction"
        Me.cboSelectAuction.Size = New System.Drawing.Size(121, 24)
        Me.cboSelectAuction.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Auction:"
        '
        'btnUpdate
        '
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdate.Location = New System.Drawing.Point(99, 366)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 35)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(355, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(417, 78)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Date:"
        '
        'Main
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(637, 492)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSelectAuction)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antiques"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmFile As ToolStripMenuItem
    Friend WithEvents tsmEdit As ToolStripMenuItem
    Friend WithEvents tsmReports As ToolStripMenuItem
    Friend WithEvents tsmReportsPurchaseActivity As ToolStripMenuItem
    Friend WithEvents tsmSaveClose As ToolStripMenuItem
    Friend WithEvents tsmExit As ToolStripMenuItem
    Friend WithEvents tsmEditAuctions As ToolStripMenuItem
    Friend WithEvents tsmEditInventory As ToolStripMenuItem
    Friend WithEvents tsmReportsShowInventory As ToolStripMenuItem
    Friend WithEvents tsmHelp As ToolStripMenuItem
    Friend WithEvents tsmHelpAbout As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents cboSelectAuction As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label2 As Label
End Class
