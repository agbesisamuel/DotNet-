
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class User
    'declaring class properties
    Private strUserID As String
    Private strAccountName As String
    Private strPassword As String
    Private strDepartment As String

    Dim vUserAccount, vPassword, vConfirmPassword, vAccountType As String

    Dim intResponse As Integer
    Dim strMessage As String = "Are you sure you want to remove this account ?"





    ' the constructor for the class
    Public Sub New(ByVal userID As String, ByVal accountName As String, ByVal password As String, ByVal department As String)
        strUserID = userID
        strAccountName = accountName
        strPassword = password
        strDepartment = department
    End Sub
    Public Sub New()
        strUserID = ""
        strPassword = ""
        strDepartment = ""

    End Sub

    'property procedures for the  class
    Public Property UserID() As String
        Get
            Return strUserID
        End Get
        Set(ByVal userID As String)

            strUserID = userID
        End Set
    End Property

    Public Property AccountName() As String
        Get
            Return strAccountName
        End Get
        Set(ByVal accountName As String)
            strAccountName = accountName
        End Set
    End Property

    Public Property Password() As String
        Get
            Return strPassword
        End Get
        Set(ByVal password As String)
            strPassword = password
        End Set
    End Property

    Public Property department() As String
        Get
            Return strDepartment
        End Get
        Set(ByVal department As String)
            strDepartment = department
        End Set
    End Property

    'check text procedure checks if all text boxes are not blank
    Public Sub checkTextBox(ByVal strUserAccount As String, ByVal strPassword As String, ByVal strConfirmPassword As String, ByVal AccountType As String)
        Dim frmUserAccount As New User_Account  'creating an instance of the user acount class

        'Assigninvariablesg the parameters to the local 
        vUserAccount = strUserAccount
        vPassword = strPassword
        vConfirmPassword = strConfirmPassword
        vAccountType = strAccountType

        With frmUserAccount
            If vUserAccount = "" Then
                MsgBox("Enter account name", MsgBoxStyle.Information)
                .txtAccountName.Focus()

            ElseIf vPassword = "" Then
                MsgBox("Password can't be empty", MsgBoxStyle.Information)
                .txtPassWord.Focus()

            ElseIf vConfirmPassword = "" Then
                MsgBox("Please confirm password", MsgBoxStyle.Information)
                .txtConfirmPassWord.Focus()

            ElseIf vPassword <> vConfirmPassword Then
                MsgBox("Password is not the same", MsgBoxStyle.Information)

            ElseIf vUserAccount.Length < 8 Then
                MsgBox("Account name can't be less then 8 characters", MsgBoxStyle.Information)
                .txtAccountName.Text = ""
                .txtAccountName.Focus()

            ElseIf vPassword.Length < 8 Then
                MsgBox("Pasword can't be empty", MsgBoxStyle.Information)
                .txtPassWord.Text = ""
                .txtPassWord.Focus()

            Else
                'checkAccountName()

            End If
        End With

        'procedure to change user account

    End Sub
    Public Sub changeAccountName()
        Dim strOldName, strNewName As String
        Dim checkDataset As New DataSet
        Dim checkDataTable As New DataTable
        strOldName = InputBox("Please enter the old account  name", "Church management system")

        'initializing the connection string
        ' CMSConnection.ConnectionString = "Data Source= (Local);Initial Catalog=CHURCH;Integrated Security=True"

        CMSConnection.Open() 'opening the connection string

        Dim strcheckAccount As String = " SELECT * FROM Users WHERE UserID = '" + strOldName + "'"  'sql statement to select the record

        Dim checkAccountAdapter As New SqlDataAdapter(strcheckAccount, CMSConnection)
        checkAccountAdapter.Fill(checkDataset, "Users")
        checkDataTable = checkDataset.Tables("Users")
        Dim checkCount As Integer = checkDataTable.Rows.Count
        If checkCount <= 0 Then
            MsgBox("Account name does not exist", MsgBoxStyle.Information)
            CMSConnection.Close()
        Else
            ' calling the input box procedure to accept a user account name
            strNewName = InputBox("Please enter the new account name")

            'declaring procedural variables with a sql query to update the old user account name
            Dim strUpdate As String = " UPDATE Users SET UserID = '" + strNewName + "' WHERE UserID = '" + strOldName + "'"

            Dim checkCommand As New SqlCommand(strUpdate, CMSConnection)
            'CMSConnection.Open()
            checkCommand.ExecuteNonQuery()
            CMSConnection.Close()

        End If

    End Sub
    Public Sub chnagePassword()
        Dim strOldName, strNewName As String
        Dim checkDataset As New DataSet
        Dim checkDataTable As New DataTable
        strOldName = InputBox("Please enter the old password", "Church management system")

        'initializing the connection string
        'CMSConnection.ConnectionString = "Data Source= (Local);Initial Catalog=CHURCH;Integrated Security=True"

        CMSConnection.Open() 'opening the connection string

        Dim strcheckAccount As String = " SELECT * FROM Users WHERE Password = '" + strOldName + "'"  'sql statement to select the record

        Dim checkAccountAdapter As New SqlDataAdapter(strcheckAccount, CMSConnection)
        checkAccountAdapter.Fill(checkDataset, "Users")
        checkDataTable = checkDataset.Tables("Users")
        Dim checkCount As Integer = checkDataTable.Rows.Count
        If checkCount <= 0 Then
            MsgBox("Password does not exist", MsgBoxStyle.Information)
            CMSConnection.Close()
        Else
            ' calling the input box procedure to accept a user account name
            strNewName = InputBox("Please enter the new password")

            'declaring procedural variables with a sql query to update the old user account name
            Dim strUpdate As String = " UPDATE Users SET Password = '" + strNewName + "' WHERE Password = '" + strOldName + "'"

            Dim checkCommand As New SqlCommand(strUpdate, CMSConnection)
            'CMSConnection.Open()
            checkCommand.ExecuteNonQuery()
            CMSConnection.Close()

        End If


    End Sub
    Public Sub removeAccount()
        Dim strAccountName, strPassword As String
        Dim getDataset As New DataSet
        Dim getDataTable As New DataTable

        'initializing connection string
        'CMSConnection.ConnectionString = "Data Source =(Local); Initial Catalog =CHURCH; Integrated security = True"
        strAccountName = InputBox("Enter your account name", "Church Management System")
        CMSConnection.Open()

        'sql statement to validate the account name
        Dim strSelectName As String = "SELECT UserID FROM Users WHERE UserID = '" + strAccountName + "'"

        'creating an instance of the dataAdapter
        Dim getDataAdapter As New SqlDataAdapter(strSelectName, CMSConnection)
        getDataAdapter.Fill(getDataset, "Users")
        getDataTable = getDataset.Tables("Users")

        Dim getCnt As Integer
        getCnt = getDataTable.Rows.Count 'counting the records in the dataTable

        If getCnt < 1 Then
            MsgBox("Account name does not exist", MsgBoxStyle.Information, "Church Management system")
            CMSConnection.Close()
        Else
            strPassword = InputBox("Enter your pass word", "Church Management System")
            Dim strSelectPassword As String = "SELECT Password FROM Users WHERE Password = '" + strPassword + "'"

            Dim getDataAdapter2 As New SqlDataAdapter(strSelectPassword, CMSConnection)
            getDataAdapter2.Fill(getDataset, "Users")
            getDataTable = getDataset.Tables("Users")

            Dim cnt2 As Integer
            cnt2 = getDataTable.Rows.Count
            If cnt2 < 1 Then
                MsgBox("Password does not match", "Church Management System")
                CMSConnection.Close()
            Else
                intResponse = MsgBox(strMessage, vbYesNoCancel + vbCritical + vbDefaultButton2, "Remove User Accout")
                If intResponse = vbYes Then
                    Dim strRemoveUser = "DELETE FROM Users WHERE UserID = '" + strAccountName + "' AND Password = '" + strPassword + "'"
                    'creatint a new instance of the sqlcommand to delete
                    Dim removeCommand As New SqlCommand(strRemoveUser, CMSConnection)

                    removeCommand.ExecuteNonQuery()

                    CMSConnection.Close()
                    MsgBox("Account sucessfully removed", MsgBoxStyle.Information, "Remove User Account")
                Else
                    MsgBox("Account has not been remove", MsgBoxStyle.Information, "Remove User Account")


                End If

            End If



        End If

    End Sub
    Public Sub closeForm()

    End Sub


    Public Sub checkAccountName()
        Dim selectUser As String
        Dim cntAccountName As Integer
        Dim userAccountDataset As New DataSet
        Dim frmUserAccount As New User_Account  'creating an instance of the user acount class

        'passing the database path to the CMSConnection string object
        'CMSConnection.ConnectionString = "Data Source= (Local);Initial Catalog=CHURCH;Integrated Security=True"

        CMSConnection.Open() 'opening the database connection

        'assigning the sql statement to the to the string object
        selectUser = "SELECT userID FROM Users WHERE UserID = '" + vUserAccount + "'"

        'creating an instance  of the sqlcommand and the sqlDataadapter object
        Dim userAccountAdapter As New SqlDataAdapter(selectUser, CMSConnection)
        Dim userAccountCommand As New SqlCommand(selectUser, CMSConnection)

        'creating an instance of the data table
        Dim userAccountDataTable As New DataTable

        userAccountAdapter.Fill(userAccountDataset, "Users")
        userAccountDataTable = userAccountDataset.Tables("Users")
        cntAccountName = userAccountDataTable.Rows.Count

        If cntAccountName > 0 Then
            MsgBox("Account name already exist", MsgBoxStyle.Information)
            CMSConnection.Close()

            'calling the clearTextBox procedure from the user account form c lass
            frmUserAccount.clearTextBox()
        Else
            With frmUserAccount


                Dim insertUserCommand As New SqlCommand("INSERT INTO Users" & "(UserID, Password, Department, UserType)" & "VALUES('" + vUserAccount + "','" + vPassword + "', '" + strAccountType + "',  '" + strAccountType + "' )", CMSConnection)


                insertUserCommand.ExecuteNonQuery()
                CMSConnection.Close()

            End With
            

        End If

    End Sub


End Class
