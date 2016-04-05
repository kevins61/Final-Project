'****************************************************************************************
'* Name:      Kevin Sandberg
'* Project:   Final Project - Antiques
'* Date:      March 25, 2016
'* Purpose:   Application to track Antique business purchases, expenses and inventory
'****************************************************************************************

Public Class Main
    Dim theDate As Date = Today
    Dim amount As Decimal = 0
    Dim auctioneer As String = ""
    Dim lastID As Integer = 0
    Dim count As Integer = 0

    Dim myAuctionsArray() As String = {"1000,1/23/15,Joe Blow Auctions,115.40", "1001,4/3/15,George's Auctions,105.76", "1002,11/4/15,Auction House,93.25"}

    ''' <summary>
    ''' Form Load
    ''' </summary>
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = ""

        For Each a In myAuctionsArray
            Dim fields() As String = a.Split(","c)
            cboSelectAuction.Items.Add(fields(0).Trim())
            lastID = CInt(fields(0))
            count += 1
            lstAuctionList.Items.Add(fields(0) & ", " & CDate(fields(1)) & ", " & fields(2) & ", " & CDec(fields(3)).ToString("c"))
        Next
    End Sub

    ''' <summary>
    ''' Exit button
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '******** Start of code for all menu items *********
    ''' <summary>
    ''' Menu Help\About
    ''' </summary>
    Private Sub tsmHelpAbout_Click(sender As Object, e As EventArgs) Handles tsmHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmFileExit.Click
        Me.Close()
    End Sub
    '********End of code for all menu items **********

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectAuction.SelectedIndexChanged
        If cboSelectAuction.SelectedIndex > -1 Then
            lstAuctionList.Items.Clear()
            For Each a In myAuctionsArray
                Dim field() As String = a.Split(","c)
                If (field(0) = cboSelectAuction.SelectedItem.ToString) Then
                    lstAuctionList.Items.Add(field(0) & ", " & CDate(field(1)) & ", " & field(2) & ", " & CDec(field(3)).ToString("c"))
                    Return
                End If
            Next
        End If
    End Sub

    Sub updateDisplay()
        lstAuctionList.Items.Clear()

        For Each a In myAuctionsArray
            Dim field() As String = a.Split(","c)
            lstAuctionList.Items.Add(field(0) & ", " & CDate(field(1)) & ", " & field(2) & ", " & CDec(field(3)).ToString("c"))
        Next
    End Sub
    Private Sub btnAddAuction_Click(sender As Object, e As EventArgs) Handles btnAddAuction.Click
        cboSelectAuction.SelectedIndex = -1
        If Not (Date.TryParse(txtDate.Text, theDate)) Then
            UpdateStatus("Oh-oh, you entered an invalid date! Try again.")
            txtDate.Focus()
            Return
        End If
        If (txtAuctionCo.Text = "") Then
            UpdateStatus("Please enter an auction company")
            txtAuctionCo.Focus()
            Return
        End If
        If Not (Decimal.TryParse(txtAmount.Text, amount)) Then
            UpdateStatus("Please enter a valid amount")
            txtAmount.Focus()
            Return
        End If
        lastID += 1
        ReDim Preserve myAuctionsArray(count)
        myAuctionsArray(count) = lastID.ToString & ", " & theDate.ToString & ", " & txtAuctionCo.Text & ", " & amount.ToString
        cboSelectAuction.Items.Add(lastID)
        count += 1
        updateDisplay()
        txtDate.Text = ""
        txtAuctionCo.Text = ""
        txtAmount.Text = ""
        UpdateStatus("Record added successfully as Auction ID " & lastID)

    End Sub

    Sub UpdateStatus(ByVal msg As String)
        lblStatus.Text = msg
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        cboSelectAuction.SelectedIndex = -1
        updateDisplay()
    End Sub
End Class
