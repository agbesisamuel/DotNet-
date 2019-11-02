Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing.Image
Imports System
Imports System.Data.SqlClient
Imports System.Data.Common



Public Class Member

    'declaring the constance of this class
    Private strMemberID As String
    Private strFirstName As String
    Private strMiddleName As String
    Private strLastName As String
    Private dDOB As Date
    Private strGender As String
    Private strNationality As String
    Private strRessAdd As String
    Private strHomeTown As String
    Private strMstatus As String
    Private strMnumber As String
    Private strHnumber As String
    Private strFname As String
    Private strMname As String
    Private strProffesion As String
    Private strPlaceOfWork As String
    Private strDateBabtised As String
    Private strFormarChurch As String
    Private strFormarPosition As String
    Private strMyPict As ADODB.Stream
    Private strEmail As String
    Private strNspouse As String
    Private strCurrentPosition As String
    Private strJoining As String
    Private strMemberGroup As String
    Private strNconfidential As String
    Private strNgeneral As String
    Private strUserID As String

    'generating data objects
    Dim profileAdapter As New SqlDataAdapter
    Dim myCommand As SqlCommand
    Dim dt As New DataTable
    Dim ds As New DataSet
    Dim dv As DataView
    Dim sql As String


    'the constructor of the class
    Public Sub New(ByVal memberID As String, ByVal firstName As String, ByVal middleName As String, ByVal lastName As String, ByVal DOB As Date, ByVal gender As String, ByVal nationality As String, ByVal ressAdd As String, ByVal homeTown As String, ByVal mStatus As String, ByVal mNumber As String, ByVal hNumber As String, ByVal fName As String, ByVal mName As String, ByVal proffesion As String, ByVal placeOfWork As String, ByVal dateBabtised As String, ByVal formarChurch As String, ByVal formarPosition As String, ByVal pict As String, ByVal email As String, ByVal nSpouse As String, ByVal currentPosition As String, ByVal joining As String, ByVal memberGroup As String, ByVal nconfidential As String, ByVal nGeneral As String, ByVal userID As String)
        strMemberID = memberID
        strFirstName = firstName
        strMiddleName = middleName
        strLastName = lastName
        dDOB = DOB
        strGender = gender
        strNationality = nationality
        strRessAdd = ressAdd
        strHomeTown = homeTown
        strMstatus = mStatus
        strMnumber = mNumber
        strHnumber = hNumber
        strFname = fName
        strMname = mName
        strProffesion = proffesion
        strPlaceOfWork = placeOfWork
        strDateBabtised = dateBabtised
        strFormarChurch = formarChurch
        strFormarPosition = formarPosition
        strMyPict = pict
        strEmail = email
        strNspouse = nSpouse
        strCurrentPosition = currentPosition
        strJoining = joining
        strMemberGroup = memberGroup
        strNconfidential = nconfidential
        strNgeneral = nGeneral
        strUserID = userID
    End Sub
    Public Sub New()
        strMemberID = ""
        strFirstName = ""
        strMiddleName = ""
        strLastName = ""
        dDOB = Date.Now
        strGender = ""
        strNationality = ""
        strRessAdd = ""
        strHomeTown = ""
        strMstatus = ""
        strMnumber = ""
        strHnumber = ""
        strFname = ""
        strMname = ""
        strProffesion = ""
        strPlaceOfWork = ""
        strDateBabtised = ""
        strFormarChurch = ""
        strFormarPosition = ""
        strMyPict = strMyPict
        strEmail = ""
        strNspouse = ""
        strCurrentPosition = ""
        strJoining = ""
        strMemberGroup = ""
        strNconfidential = ""
        strNgeneral = ""
        strUserID = ""

    End Sub
    'creating the properties of the meber class

    Public Property memberID() As String
        Get
            Return strMemberID
        End Get
        Set(ByVal value As String)

            strMemberID = value

        End Set
    End Property
    Public Property firstName() As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set

    End Property
    Public Property middleName() As String
        Get
            Return strMiddleName
        End Get
        Set(ByVal value As String)
            strMiddleName = value

        End Set
    End Property

    Public Property lastName() As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value

        End Set
    End Property

    Public Property DOB() As Date
        Get
            Return dDOB
        End Get
        Set(ByVal value As Date)
            dDOB = value
        End Set
    End Property

    Public Property gender() As String
        Get
            Return strGender
        End Get
        Set(ByVal value As String)

            strGender = value

        End Set
    End Property

    Public Property nationality() As String
        Get
            Return strNationality
        End Get
        Set(ByVal value As String)
            strNationality = value
        End Set
    End Property

    Public Property resAddress() As String
        Get
            Return strRessAdd
        End Get
        Set(ByVal value As String)

            strRessAdd = value
        End Set
    End Property

    Public Property homeTown() As String
        Get
            Return strHomeTown
        End Get
        Set(ByVal value As String)
            strHomeTown = value

        End Set
    End Property

    Public Property mStatus() As String
        Get
            Return strMstatus
        End Get
        Set(ByVal value As String)

            strMstatus = value
        End Set
    End Property

    Public Property mNumber() As String
        Get
            Return strMnumber
        End Get
        Set(ByVal value As String)

            strMnumber = value
        End Set
    End Property

    Public Property hNumber() As String
        Get
            Return strHnumber
        End Get
        Set(ByVal value As String)

            strHnumber = value
        End Set
    End Property


    Public Property fName() As String
        Get
            Return strFname
        End Get
        Set(ByVal value As String)
            strFname = value
        End Set
    End Property

    Public Property mName() As String
        Get
            Return strMname
        End Get
        Set(ByVal value As String)

            strMname = value
        End Set
    End Property

    
    Public Property profession() As String
        Get
            Return strProffesion
        End Get
        Set(ByVal value As String)

            strProffesion = value

        End Set
    End Property

    Public Property placeOfWork() As String
        Get
            Return strPlaceOfWork
        End Get
        Set(ByVal value As String)

            strPlaceOfWork = value

        End Set
    End Property

    Public Property dateBabtised() As String
        Get
            Return strDateBabtised
        End Get
        Set(ByVal value As String)

            strDateBabtised = value
        End Set
    End Property

    Public Property formarChurch() As String
        Get
            Return strFormarChurch
        End Get
        Set(ByVal value As String)

            strFormarChurch = value
        End Set
    End Property
    Public Property formarPosition() As StringAlignment
        Get
            Return strFormarPosition

        End Get
        Set(ByVal value As StringAlignment)
            strFormarPosition = value
        End Set
    End Property

    Public Property myPict() As ADODB.Stream
        Get
            Return strMyPict
        End Get
        Set(ByVal value As ADODB.Stream)

            strMyPict = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)

            strEmail = value

        End Set
    End Property

    Public Property nSpouse() As String
        Get
            Return strNspouse
        End Get
        Set(ByVal value As String)

            strNspouse = value

        End Set
    End Property

    Public Property currentPosition() As String
        Get
            Return strCurrentPosition
        End Get
        Set(ByVal value As String)

            strCurrentPosition = value

        End Set
    End Property

    Public Property joining() As String
        Get
            Return strJoining
        End Get
        Set(ByVal value As String)

            strJoining = value

        End Set
    End Property

    Public Property memberGrooup() As String
        Get
            Return strMemberGroup
        End Get
        Set(ByVal value As String)

            strMemberGroup = value

        End Set
    End Property

    Public Property nConfidential() As String
        Get
            Return strNconfidential
        End Get
        Set(ByVal value As String)

            strNconfidential = value

        End Set
    End Property


    Public Property nGeneral() As String
        Get
            Return strNgeneral
        End Get
        Set(ByVal value As String)

            strNgeneral = value

        End Set
    End Property

    Public Property userID() As String
        Get
            Return strUserID
        End Get
        Set(ByVal value As String)

            strUserID = value

        End Set
    End Property





    Public Sub checkControl()
        Try

            Dim frmProfile As New Member_Profile()
            Dim strProfile As String = "Member profile"
            With frmProfile
                If strMemberID = "" Then
                    MsgBox("Generate membership ID", MsgBoxStyle.Information, strProfile)
                    .txtMemberID.Focus()
                ElseIf strFirstName = "" Then
                    MsgBox("First name can't be blank", MsgBoxStyle.Information, strProfile)
                    .txtFirstName.Focus()
                ElseIf strLastName = "" Then
                    MsgBox("Last name can't be blank", MsgBoxStyle.Information, strProfile)
                    .txtLastName.Focus()
                ElseIf dDOB > Date.Now Then
                    MsgBox("Please select the date of birth", MsgBoxStyle.Information, strProfile)
                    .DOB.Focus()
                ElseIf strGender = "" Then
                    MsgBox("Please select gender", MsgBoxStyle.Information, strProfile)
                    .cmbGender.Focus()
                ElseIf strNationality = "" Then
                    MsgBox("Nationality can't be blank", MsgBoxStyle.Information, strProfile)
                    .txtNationality.Focus()
                ElseIf strRessAdd = "" Then
                    MsgBox("Please enter residential address", MsgBoxStyle.Information, strProfile)
                    .txtResidence.Focus()
                ElseIf strHomeTown = "" Then
                    MsgBox("home town can't be blank", MsgBoxStyle.Information, strProfile)
                    .txtHomeTown.Focus()
                ElseIf strMstatus = "" Then
                    MsgBox("Please choose marital status", MsgBoxStyle.Information, strProfile)
                    .cmbMstatus.Focus()
                ElseIf strMemberGroup = "" Then
                    MsgBox("Please choos care group", MsgBoxStyle.Information, strProfile)
                    .cmbCareGroup.Focus()
                Else
                    'addProfile()

                End If

            End With


        Catch ex As Exception

        End Try

    End Sub



    Public Sub generateID(ByVal firstChar As String, ByVal secondChar As String)


        Dim strFirstChar As Char
        Dim strLastChar As Char
        Dim mInt As Integer
        'Dim strMemberID As String
        Dim randomInt As New Random 'creating an istance of the random class

        Try


            strFirstChar = firstChar
            strLastChar = secondChar
            mInt = randomInt.Next(100, 1000) 'generating random numbers withing the range of the parameters
            strMemberID = CStr(strFirstChar + strLastChar + CStr(mInt))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Member profile")

        End Try

    End Sub

    Public Sub addProfile()
        Dim frmProfile As New Member_Profile()

        CMSConnection.Open()
        sqlStatement = "INSERT INTO PersonalProfile" & _
        "(MemberID, FirstName, MiddleName, LastName, DOB, Gender, Nationality, RessAdd, HomeTown, Mstatus, Mnumber, Hnumber, Fname, Mname, Proffesion,PlaceOfWork, Datebabtised, FormarChurch, FormarPosition, Mypict, email, Nspouse, CurrentPosition, Joining, MemberGroup, Nconfidential, Ngeneral, UserID)" & _
        "VALUES('" + strMemberID + "', '" + strFirstName + "', '" + strMiddleName + "', " & _
        "'" + strLastName + "', '" + dDOB + "', '" + strGender + "', '" + strNationality + "', " & _
        "'" + strRessAdd + "', '" + strHomeTown + "', '" + strMstatus + "', '" + strMnumber + "', " & _
        "'" + strHnumber + "', '" + strFname + "', '" + strMname + "', '" + strProffesion + "', '" + strPlaceOfWork + "', " & _
        "'" + strDateBabtised + "', '" + strFormarChurch + "', '" + strFormarPosition + "', '" + myPict.Read + "', '" + strEmail + "', " & _
        "'" + strNspouse + "' , '" + strCurrentPosition + "', '" + strJoining + "', '" + strMemberGroup + "', '" + strNconfidential + "', " & _
        "'" + strNgeneral + "', '" + userID + "')"

        mySql.ExecuteNonQuery()
        CMSConnection.Close()

    End Sub

End Class
