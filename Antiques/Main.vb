'****************************************************************************************
'* Name:      Kevin Sandberg
'* Project:   Final Project - Antiques
'* Date:      March 25, 2016
'* Purpose:   Application to track Antique business purchases, expenses and inventory
'****************************************************************************************

Public Class Main
    ''' <summary>
    ''' Form Load
    ''' </summary>

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = ""

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
End Class
