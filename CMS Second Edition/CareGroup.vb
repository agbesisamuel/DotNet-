Public Class CareGroup
    Private strCGID As String
    Private strMemberID As String
    Private strCGName As String

    Public Sub New(ByVal cgID As String, ByVal memberID As String, ByVal cgName As String)
        strCGID = cgID
        strMemberID = memberID
        strCGName = cgName

    End Sub

    Public Property cgID() As String
        Get
            Return strCGID

        End Get
        Set(ByVal value As String)
            strCGID = value

        End Set

    End Property

    Public Property memberID() As String
        Get
            Return strMemberID
        End Get
        Set(ByVal value As String)

            strMemberID = value

        End Set
    End Property

    Public Property cgName() As String
        Get
            Return strCGName
        End Get
        Set(ByVal value As String)

            strCGName = value

        End Set
    End Property


    Public Sub validateControl()

        Dim frmCareGroup As New Care_Group

        If frmCareGroup.txtCGID.Text = "" Then
            MsgBox("Please generate care group ID", MsgBoxStyle.Information)
            frmCareGroup.txtCGID.Focus()
        Else
            If frmCareGroup.txtCGLeader.Text = "" Then
                MsgBox("Enter care group leader's name", MsgBoxStyle.Information)
                frmCareGroup.txtCGLeader.Focus()
            Else
                If frmCareGroup.cmbCGName.Text = "" Then
                    MsgBox("Select care group", MsgBoxStyle.Information)
                    frmCareGroup.cmbCGName.Focus()
                End If
            End If
        End If

    End Sub

    Public Sub addCareGroup()
        validateControl() 'calling the procedure

        CMSConnection.Open()
        sqlStatement = "INSERT INTO CareGroup" & "(CareGroupID, MemberID, CNAme)" & "VALUES('" + strCGID + "', '" + strMemberID + "', '" + strCGName + "')"
        'mySql.EndExecuteNonQuery()
        mySql.ExecuteNonQuery()
        CMSConnection.Close()
    End Sub

End Class

