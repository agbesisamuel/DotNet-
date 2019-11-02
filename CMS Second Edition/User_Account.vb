
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class User_Account

    Dim objUser As New User
    Dim intResponse As Integer
    Dim strMessage As String = "Are you sure you want to remove this account ?"


    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmdNewAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewAccount.Click
       


        objUser.checkTextBox(txtAccountName.Text, txtPassWord.Text, txtConfirmPassWord.Text, strAccountType)

        If rdAdministrator.Focus = False Or rdLimited.Focus = False Then
            MsgBox("choose your user accout type", MsgBoxStyle.Information)
            rdLimited.Focus()

        ElseIf rdAdministrator.Focus = True Then
            strAccountType = "Aministrator"
        Else
            strAccountType = "Limited"

        End If

        objUser.checkAccountName()

    End Sub
    Public Sub clearTextBox()

        'refreshing the user account form
        txtAccountName.Text = ""
        txtPassWord.Text = ""
        txtConfirmPassWord.Text = ""
        txtAccountName.Focus()


    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub User_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAccountName.Focus()
        rdLimited.Focus()

    End Sub

    Private Sub cmdChangeAccountName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeAccountName.Click
        objUser.changeAccountName()


    End Sub

    Private Sub cmdChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangePassword.Click
        objUser.chnagePassword()

    End Sub

    Private Sub cmdRemoveAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveAccount.Click
        objUser.removeAccount()
    End Sub


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        strMessage = "Are you sure you want to close this window ?"
        intResponse = MsgBox(strMessage, vbYesNoCancel + vbCritical + vbDefaultButton2, "User Account Window")

        If intResponse = vbYes Then
            Me.Close()
        Else
            txtAccountName.Focus()


        End If

    End Sub
End Class
