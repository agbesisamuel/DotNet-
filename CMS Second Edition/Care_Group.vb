Public Class Care_Group
    Public strCGID As String

    Private Sub Care_Group_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdAddRings.Enabled = False
        cmdSearchCG.Enabled = False
        cmdEditCG.Enabled = False
        cmdUpdateCG.Enabled = False
        cmdRemoveCG.Enabled = False
        txtCGLeader.Enabled = False
        txtCGID.Enabled = False


    End Sub

    Private Sub cmbCGName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCGName.Leave
        If cmbCGName.Text = "" Then
            MsgBox("Sorry please select the care group you want to create", MsgBoxStyle.Information, "Care group management")
        Else
            txtCGLeader.Enabled = True
            txtCGLeader.Focus()
        End If

    End Sub

    Private Sub cmbCGName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCGName.SelectedIndexChanged

    End Sub

    Private Sub txtCGID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCGID.TextChanged

    End Sub

    Private Sub txtCGLeader_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCGLeader.Leave

        If txtCGLeader.Text = "" Then
            MsgBox("Please enter the care group leader's ID or click on the select button to select name", MsgBoxStyle.Information, "Care group management")
        Else
            'txtCGID.Enabled = True
            'txtCGID.Focus()

        End If
    End Sub

    Private Sub txtCGLeader_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCGLeader.TextChanged

    End Sub

    Private Sub cmbCGName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCGName.TextChanged

        Dim careGroup As String
        careGroup = cmbCGName.Text

        Select Case careGroup
            Case "SUNDAY"
                txtCGID.Text = "SUN001"
            Case "MONDAY"
                txtCGID.Text = "MON002"
            Case "TUESDAY"
                txtCGID.Text = "TUE003"
            Case "WEDNESDAY"
                txtCGID.Text = "WED004"
            Case "THURSDAY"
                txtCGID.Text = "THU005"
            Case "FRIDAY"
                txtCGID.Text = "FRI006"
            Case "SATURDAY"
                txtCGID.Text = "SAT007"
            Case Else
                MsgBox("Please make sure u select car group's name")

        End Select

    End Sub

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click


        Dim objCareGroup As New CareGroup(cmbCGName.Text, txtCGLeader.Text, txtCGID.Text)
        objCareGroup.addCareGroup()

    End Sub


End Class