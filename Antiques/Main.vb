'****************************************************************************************
'* Name:      Kevin Sandberg
'* Project:   Final Project - Antiques
'* Date:      March 25, 2016
'* Purpose:   Application to track Antique business purchases, expenses and inventory
'****************************************************************************************

Public Class Main
    Dim theDate As Date
    Dim myAuctionsArray() As String = {"1000,1/23/15,Joe Blow Auctions,115.40", "1001,4/3/15,George's Auctions,105.76", "1002,11/4/15,Auction House,93.25"}

    ''' <summary>
    ''' Form Load
    ''' </summary>
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = ""
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

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        Me.Close()
    End Sub
    '********End of code for all menu items **********

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectAuction.SelectedIndexChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtDate.BackColor = DefaultBackColor
        txtDate.ForeColor = DefaultForeColor
        If (Date.TryParse(txtDate.Text, theDate)) Then
            lblStatus.Text = "Good Job - Valid Date"
        Else
            lblStatus.Text = "Oh-oh, you entered an invalid date! Try again."
            lblStatus.ForeColor = Color.Red
            txtDate.Focus()
            txtDate.BackColor = Color.Yellow

        End If
    End Sub
End Class
