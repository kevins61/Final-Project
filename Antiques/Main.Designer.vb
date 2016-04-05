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
        Me.tsmFileSaveClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPuchaseLots = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditInventoryItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReportsPurchaseActivity = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReportsShowInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cboSelectAuction = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddAuction = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstAuctionList = New System.Windows.Forms.ListBox()
        Me.txtAuctionCo = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.tsmEditRecordSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReportsSales = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(590, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFileSaveClose, Me.tsmFileExit})
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(44, 24)
        Me.tsmFile.Text = "&File"
        '
        'tsmFileSaveClose
        '
        Me.tsmFileSaveClose.Name = "tsmFileSaveClose"
        Me.tsmFileSaveClose.Size = New System.Drawing.Size(181, 26)
        Me.tsmFileSaveClose.Text = "&Save && Close"
        '
        'tsmFileExit
        '
        Me.tsmFileExit.Name = "tsmFileExit"
        Me.tsmFileExit.Size = New System.Drawing.Size(181, 26)
        Me.tsmFileExit.Text = "E&xit"
        '
        'tsmEdit
        '
        Me.tsmEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPuchaseLots, Me.tsmEditInventoryItems, Me.tsmEditRecordSales})
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(47, 24)
        Me.tsmEdit.Text = "&Edit"
        '
        'tsmPuchaseLots
        '
        Me.tsmPuchaseLots.Name = "tsmPuchaseLots"
        Me.tsmPuchaseLots.Size = New System.Drawing.Size(185, 26)
        Me.tsmPuchaseLots.Text = "&Puchase Lots"
        '
        'tsmEditInventoryItems
        '
        Me.tsmEditInventoryItems.Name = "tsmEditInventoryItems"
        Me.tsmEditInventoryItems.Size = New System.Drawing.Size(185, 26)
        Me.tsmEditInventoryItems.Text = "&Inventory Items"
        '
        'tsmReports
        '
        Me.tsmReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmReportsPurchaseActivity, Me.tsmReportsShowInventory, Me.tsmReportsSales})
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
        Me.tsmReportsShowInventory.Text = "Show &Inventory"
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
        Me.tsmHelpAbout.Size = New System.Drawing.Size(181, 26)
        Me.tsmHelpAbout.Text = "&About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(590, 25)
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
        Me.cboSelectAuction.Location = New System.Drawing.Point(137, 76)
        Me.cboSelectAuction.Name = "cboSelectAuction"
        Me.cboSelectAuction.Size = New System.Drawing.Size(121, 24)
        Me.cboSelectAuction.TabIndex = 5
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
        'btnAddAuction
        '
        Me.btnAddAuction.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddAuction.Location = New System.Drawing.Point(93, 410)
        Me.btnAddAuction.Name = "btnAddAuction"
        Me.btnAddAuction.Size = New System.Drawing.Size(118, 35)
        Me.btnAddAuction.TabIndex = 3
        Me.btnAddAuction.Text = "Add Auction"
        Me.btnAddAuction.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(358, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(86, 360)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Date:"
        '
        'lstAuctionList
        '
        Me.lstAuctionList.FormattingEnabled = True
        Me.lstAuctionList.ItemHeight = 16
        Me.lstAuctionList.Location = New System.Drawing.Point(41, 148)
        Me.lstAuctionList.Name = "lstAuctionList"
        Me.lstAuctionList.Size = New System.Drawing.Size(493, 180)
        Me.lstAuctionList.TabIndex = 10
        '
        'txtAuctionCo
        '
        Me.txtAuctionCo.Location = New System.Drawing.Point(220, 359)
        Me.txtAuctionCo.Name = "txtAuctionCo"
        Me.txtAuctionCo.Size = New System.Drawing.Size(143, 22)
        Me.txtAuctionCo.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(425, 361)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 22)
        Me.txtAmount.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Auction Company:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(433, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Amount:"
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(298, 70)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(96, 34)
        Me.btnShowAll.TabIndex = 6
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'tsmEditRecordSales
        '
        Me.tsmEditRecordSales.Name = "tsmEditRecordSales"
        Me.tsmEditRecordSales.Size = New System.Drawing.Size(185, 26)
        Me.tsmEditRecordSales.Text = "&Record Sales"
        '
        'tsmReportsSales
        '
        Me.tsmReportsSales.Name = "tsmReportsSales"
        Me.tsmReportsSales.Size = New System.Drawing.Size(195, 26)
        Me.tsmReportsSales.Text = "&Sales"
        '
        'Main
        '
        Me.AcceptButton = Me.btnAddAuction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(590, 492)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtAuctionCo)
        Me.Controls.Add(Me.lstAuctionList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddAuction)
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
    Friend WithEvents tsmFileSaveClose As ToolStripMenuItem
    Friend WithEvents tsmFileExit As ToolStripMenuItem
    Friend WithEvents tsmPuchaseLots As ToolStripMenuItem
    Friend WithEvents tsmEditInventoryItems As ToolStripMenuItem
    Friend WithEvents tsmReportsShowInventory As ToolStripMenuItem
    Friend WithEvents tsmHelp As ToolStripMenuItem
    Friend WithEvents tsmHelpAbout As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents cboSelectAuction As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddAuction As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstAuctionList As ListBox
    Friend WithEvents txtAuctionCo As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnShowAll As Button
    Friend WithEvents tsmEditRecordSales As ToolStripMenuItem
    Friend WithEvents tsmReportsSales As ToolStripMenuItem
End Class
