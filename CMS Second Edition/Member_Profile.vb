

Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing.Image
Imports System


Public Class Member_Profile


    Dim myStream As Stream
    Dim insStream As ADODB.Stream
    Dim OpenMyFile As New OpenFileDialog()
    Dim objMember As New Member()
    Dim getpict As String


    Private Sub txtMemberID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemberID.TextChanged

    End Sub


    Private Sub txtGeneral_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGeneral.TextChanged

    End Sub

    Private Sub Member_Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'disabling the command buttons on the form
        'cmdAddProfile.Enabled = True
        cmdDeleteProfile.Enabled = False
        cmdUpdateProfile.Enabled = False
        cmdAddChild.Enabled = False
        cmdUpdateChild.Enabled = False


    End Sub


    Private Sub cmdGenerateID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerateID.Click

        If txtFirstName.Text = "" Or txtLastName.Text = "" Then
            MsgBox("Please enter full name before you generate ID", MsgBoxStyle.Information, "Member profile")
        Else
            objMember.generateID(txtFirstName.Text.Substring(0, 1), txtLastName.Text.Substring(0, 1)) 'using the substring procedure to extract the first character) 'calling a method of the member to generate membership ID
            txtMemberID.Text = objMember.memberID 'passing the ID instant to the ID text box control

        End If



    End Sub



    Public Sub cmdAddProfile_Click(ByRef sender As System.Object, ByRef e As System.EventArgs)

      
    End Sub

    Private Sub cmdSearchByID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchByID.Click

    End Sub

    Private Sub cmdExtendSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExtendSearch.Click

    End Sub

    Private Sub cmdProfilePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProfilePicture.Click
        Try
            OpenMyFile.InitialDirectory = "c:\"
            OpenMyFile.Filter = "txt files(*.txt)|*.txt| All files(*.*)| *.*"
            OpenMyFile.FilterIndex = 2
            OpenMyFile.RestoreDirectory = True

            If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                myStream = OpenFileDialog.OpenFile

                If Not (myStream Is Nothing) Then
                    frmMyPict.Image = System.Drawing.Bitmap.FromStream(myStream)
                    getpict = OpenFileDialog.FileName
                    myStream.Close()

                End If
            End If

            MyPict = New ADODB.Stream
            MyPict.Type = ADODB.StreamTypeEnum.adTypeBinary
            MyPict.Open()
            MyPict.LoadFromFile(OpenFileDialog.FileName)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Member profile")

        End Try
    End Sub

    Private Sub cmdAddrec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddrec.Click

        'passing the data as the parameter of the Member object
        Dim objpMember As New Member(txtMemberID.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, DOB.Value.Date.Date, cmbGender.Text, txtNationality.Text, txtResidence.Text, txtHomeTown.Text, cmbMstatus.Text, txtMnumber.Text, txtHnumber.Text, txtFname.Text, txtMname.Text, txtProffesion.Text, txtPlaceOfWork.Text, txtDatebabtised.Text, txtFormarChurch.Text, txtFormarPosition.Text, MyPict.Read, txtEmail.Text, txtNspouse.Text, cmbCurrentPosition.Text, txtJoining.Text, cmbCareGroup.Text, txtConfidential.Text, txtGeneral.Text, UserID)

        With objpMember
            .checkControl()
            .addProfile()
        End With


    End Sub
End Class