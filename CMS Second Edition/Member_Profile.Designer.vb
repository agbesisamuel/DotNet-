<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member_Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.frmMyPict = New System.Windows.Forms.PictureBox
        Me.txtMemberID = New System.Windows.Forms.TextBox
        Me.cmdGenerateID = New System.Windows.Forms.Button
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.lblMIddleName = New System.Windows.Forms.Label
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.lblLastName = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.lblDOB = New System.Windows.Forms.Label
        Me.DOB = New System.Windows.Forms.DateTimePicker
        Me.lblGender = New System.Windows.Forms.Label
        Me.cmbGender = New System.Windows.Forms.ComboBox
        Me.lblNationality = New System.Windows.Forms.Label
        Me.txtNationality = New System.Windows.Forms.TextBox
        Me.lblResidence = New System.Windows.Forms.Label
        Me.txtResidence = New System.Windows.Forms.TextBox
        Me.lblHomeTown = New System.Windows.Forms.Label
        Me.txtHomeTown = New System.Windows.Forms.TextBox
        Me.lblMstatus = New System.Windows.Forms.Label
        Me.cmbMstatus = New System.Windows.Forms.ComboBox
        Me.lblMnumber = New System.Windows.Forms.Label
        Me.txtMnumber = New System.Windows.Forms.MaskedTextBox
        Me.lblHnumber = New System.Windows.Forms.Label
        Me.txtHnumber = New System.Windows.Forms.MaskedTextBox
        Me.lblNspouse = New System.Windows.Forms.Label
        Me.txtNspouse = New System.Windows.Forms.TextBox
        Me.lblFname = New System.Windows.Forms.Label
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.lblMname = New System.Windows.Forms.Label
        Me.txtMname = New System.Windows.Forms.TextBox
        Me.lblPlaceOfWork = New System.Windows.Forms.Label
        Me.txtPlaceOfWork = New System.Windows.Forms.TextBox
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblDateBabtised = New System.Windows.Forms.Label
        Me.txtDatebabtised = New System.Windows.Forms.TextBox
        Me.lblJoining = New System.Windows.Forms.Label
        Me.txtJoining = New System.Windows.Forms.TextBox
        Me.lblProffesion = New System.Windows.Forms.Label
        Me.txtProffesion = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFormarChurch = New System.Windows.Forms.TextBox
        Me.lblFormarPosition = New System.Windows.Forms.Label
        Me.txtFormarPosition = New System.Windows.Forms.TextBox
        Me.lblCurrentPosition = New System.Windows.Forms.Label
        Me.cmbCurrentPosition = New System.Windows.Forms.ComboBox
        Me.lblCareGroup = New System.Windows.Forms.Label
        Me.cmbCareGroup = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAddrec = New System.Windows.Forms.Button
        Me.cmdExtendSearch = New System.Windows.Forms.Button
        Me.cmdGenderSearch = New System.Windows.Forms.Button
        Me.cmdUpdateProfile = New System.Windows.Forms.Button
        Me.cmdDeleteProfile = New System.Windows.Forms.Button
        Me.cmdSearchbyGroup = New System.Windows.Forms.Button
        Me.cmdSearchByID = New System.Windows.Forms.Button
        Me.cmdSearchByName = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.drgChildren = New System.Windows.Forms.DataGridView
        Me.chlName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblChildName = New System.Windows.Forms.Label
        Me.txtChildName = New System.Windows.Forms.TextBox
        Me.cmdUpdateChild = New System.Windows.Forms.Button
        Me.cmdSearchChild = New System.Windows.Forms.Button
        Me.cmdRemoveChild = New System.Windows.Forms.Button
        Me.cmdAddChild = New System.Windows.Forms.Button
        Me.tabComment = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.txtGeneral = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtConfidential = New System.Windows.Forms.TextBox
        Me.drgProfile = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.cmdProfilePicture = New System.Windows.Forms.Button
        CType(Me.frmMyPict, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.drgChildren, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabComment.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.drgProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(292, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member profile"
        '
        'frmMyPict
        '
        Me.frmMyPict.Location = New System.Drawing.Point(653, 12)
        Me.frmMyPict.Name = "frmMyPict"
        Me.frmMyPict.Size = New System.Drawing.Size(108, 94)
        Me.frmMyPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.frmMyPict.TabIndex = 1
        Me.frmMyPict.TabStop = False
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(27, 97)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(117, 20)
        Me.txtMemberID.TabIndex = 20
        '
        'cmdGenerateID
        '
        Me.cmdGenerateID.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdGenerateID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerateID.ForeColor = System.Drawing.Color.White
        Me.cmdGenerateID.Location = New System.Drawing.Point(27, 123)
        Me.cmdGenerateID.Name = "cmdGenerateID"
        Me.cmdGenerateID.Size = New System.Drawing.Size(117, 23)
        Me.cmdGenerateID.TabIndex = 4
        Me.cmdGenerateID.Text = "Generate ID"
        Me.cmdGenerateID.UseVisualStyleBackColor = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFirstName.Location = New System.Drawing.Point(12, 152)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 16)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(123, 154)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(141, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblMIddleName
        '
        Me.lblMIddleName.AutoSize = True
        Me.lblMIddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMIddleName.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMIddleName.Location = New System.Drawing.Point(264, 153)
        Me.lblMIddleName.Name = "lblMIddleName"
        Me.lblMIddleName.Size = New System.Drawing.Size(97, 16)
        Me.lblMIddleName.TabIndex = 7
        Me.lblMIddleName.Text = "Middle name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(357, 152)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(141, 20)
        Me.txtMiddleName.TabIndex = 1
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblLastName.Location = New System.Drawing.Point(504, 153)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(79, 16)
        Me.lblLastName.TabIndex = 9
        Me.lblLastName.Text = "Last name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(579, 152)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(141, 20)
        Me.txtLastName.TabIndex = 2
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDOB.Location = New System.Drawing.Point(12, 181)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(92, 16)
        Me.lblDOB.TabIndex = 11
        Me.lblDOB.Text = "Date of birth"
        '
        'DOB
        '
        Me.DOB.Location = New System.Drawing.Point(123, 182)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(141, 20)
        Me.DOB.TabIndex = 3
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblGender.Location = New System.Drawing.Point(12, 210)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 16)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cmbGender.Location = New System.Drawing.Point(123, 210)
        Me.cmbGender.MaxLength = 4
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(141, 21)
        Me.cmbGender.TabIndex = 5
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNationality.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNationality.Location = New System.Drawing.Point(264, 182)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(82, 16)
        Me.lblNationality.TabIndex = 5
        Me.lblNationality.Text = "Nationality"
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(357, 181)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(141, 20)
        Me.txtNationality.TabIndex = 4
        '
        'lblResidence
        '
        Me.lblResidence.AutoSize = True
        Me.lblResidence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResidence.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblResidence.Location = New System.Drawing.Point(264, 211)
        Me.lblResidence.Name = "lblResidence"
        Me.lblResidence.Size = New System.Drawing.Size(83, 16)
        Me.lblResidence.TabIndex = 15
        Me.lblResidence.Text = "Residence"
        '
        'txtResidence
        '
        Me.txtResidence.Location = New System.Drawing.Point(357, 210)
        Me.txtResidence.Name = "txtResidence"
        Me.txtResidence.Size = New System.Drawing.Size(141, 20)
        Me.txtResidence.TabIndex = 6
        '
        'lblHomeTown
        '
        Me.lblHomeTown.AutoSize = True
        Me.lblHomeTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeTown.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHomeTown.Location = New System.Drawing.Point(264, 327)
        Me.lblHomeTown.Name = "lblHomeTown"
        Me.lblHomeTown.Size = New System.Drawing.Size(84, 16)
        Me.lblHomeTown.TabIndex = 16
        Me.lblHomeTown.Text = "Home town"
        '
        'txtHomeTown
        '
        Me.txtHomeTown.Location = New System.Drawing.Point(368, 327)
        Me.txtHomeTown.Name = "txtHomeTown"
        Me.txtHomeTown.Size = New System.Drawing.Size(130, 20)
        Me.txtHomeTown.TabIndex = 14
        '
        'lblMstatus
        '
        Me.lblMstatus.AutoSize = True
        Me.lblMstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMstatus.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMstatus.Location = New System.Drawing.Point(264, 269)
        Me.lblMstatus.Name = "lblMstatus"
        Me.lblMstatus.Size = New System.Drawing.Size(100, 16)
        Me.lblMstatus.TabIndex = 18
        Me.lblMstatus.Text = "Marital status"
        '
        'cmbMstatus
        '
        Me.cmbMstatus.FormattingEnabled = True
        Me.cmbMstatus.Items.AddRange(New Object() {"SINGLE", "MARRIED", "WIDOW", "WIDOWER"})
        Me.cmbMstatus.Location = New System.Drawing.Point(370, 268)
        Me.cmbMstatus.MaxLength = 8
        Me.cmbMstatus.Name = "cmbMstatus"
        Me.cmbMstatus.Size = New System.Drawing.Size(128, 21)
        Me.cmbMstatus.TabIndex = 10
        '
        'lblMnumber
        '
        Me.lblMnumber.AutoSize = True
        Me.lblMnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMnumber.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMnumber.Location = New System.Drawing.Point(12, 268)
        Me.lblMnumber.Name = "lblMnumber"
        Me.lblMnumber.Size = New System.Drawing.Size(67, 16)
        Me.lblMnumber.TabIndex = 20
        Me.lblMnumber.Text = "Mobile #"
        '
        'txtMnumber
        '
        Me.txtMnumber.Location = New System.Drawing.Point(123, 267)
        Me.txtMnumber.Mask = "000-0000"
        Me.txtMnumber.Name = "txtMnumber"
        Me.txtMnumber.Size = New System.Drawing.Size(141, 20)
        Me.txtMnumber.TabIndex = 9
        '
        'lblHnumber
        '
        Me.lblHnumber.AutoSize = True
        Me.lblHnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHnumber.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHnumber.Location = New System.Drawing.Point(264, 240)
        Me.lblHnumber.Name = "lblHnumber"
        Me.lblHnumber.Size = New System.Drawing.Size(61, 16)
        Me.lblHnumber.TabIndex = 21
        Me.lblHnumber.Text = "Home #"
        '
        'txtHnumber
        '
        Me.txtHnumber.Location = New System.Drawing.Point(368, 239)
        Me.txtHnumber.Mask = "000-0000"
        Me.txtHnumber.Name = "txtHnumber"
        Me.txtHnumber.Size = New System.Drawing.Size(130, 20)
        Me.txtHnumber.TabIndex = 8
        '
        'lblNspouse
        '
        Me.lblNspouse.AutoSize = True
        Me.lblNspouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNspouse.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNspouse.Location = New System.Drawing.Point(12, 297)
        Me.lblNspouse.Name = "lblNspouse"
        Me.lblNspouse.Size = New System.Drawing.Size(121, 16)
        Me.lblNspouse.TabIndex = 22
        Me.lblNspouse.Text = "Name of spouse"
        '
        'txtNspouse
        '
        Me.txtNspouse.Location = New System.Drawing.Point(134, 295)
        Me.txtNspouse.Name = "txtNspouse"
        Me.txtNspouse.Size = New System.Drawing.Size(128, 20)
        Me.txtNspouse.TabIndex = 11
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFname.Location = New System.Drawing.Point(264, 298)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(106, 16)
        Me.lblFname.TabIndex = 24
        Me.lblFname.Text = "Father's name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(370, 298)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(128, 20)
        Me.txtFname.TabIndex = 12
        '
        'lblMname
        '
        Me.lblMname.AutoSize = True
        Me.lblMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMname.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMname.Location = New System.Drawing.Point(12, 326)
        Me.lblMname.Name = "lblMname"
        Me.lblMname.Size = New System.Drawing.Size(109, 16)
        Me.lblMname.TabIndex = 25
        Me.lblMname.Text = "Mother's name"
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(123, 323)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(141, 20)
        Me.txtMname.TabIndex = 13
        '
        'lblPlaceOfWork
        '
        Me.lblPlaceOfWork.AutoSize = True
        Me.lblPlaceOfWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaceOfWork.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPlaceOfWork.Location = New System.Drawing.Point(264, 385)
        Me.lblPlaceOfWork.Name = "lblPlaceOfWork"
        Me.lblPlaceOfWork.Size = New System.Drawing.Size(101, 16)
        Me.lblPlaceOfWork.TabIndex = 26
        Me.lblPlaceOfWork.Text = "Place of work"
        '
        'txtPlaceOfWork
        '
        Me.txtPlaceOfWork.Location = New System.Drawing.Point(370, 385)
        Me.txtPlaceOfWork.Name = "txtPlaceOfWork"
        Me.txtPlaceOfWork.Size = New System.Drawing.Size(128, 20)
        Me.txtPlaceOfWork.TabIndex = 18
        '
        'logo
        '
        Me.logo.Image = Global.CMS_Second_Edition.My.Resources.Resources.Church_Logo
        Me.logo.Location = New System.Drawing.Point(27, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(89, 76)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 27
        Me.logo.TabStop = False
        '
        'lblDateBabtised
        '
        Me.lblDateBabtised.AutoSize = True
        Me.lblDateBabtised.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateBabtised.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDateBabtised.Location = New System.Drawing.Point(12, 355)
        Me.lblDateBabtised.Name = "lblDateBabtised"
        Me.lblDateBabtised.Size = New System.Drawing.Size(106, 16)
        Me.lblDateBabtised.TabIndex = 28
        Me.lblDateBabtised.Text = "Date babtised"
        '
        'txtDatebabtised
        '
        Me.txtDatebabtised.Location = New System.Drawing.Point(123, 351)
        Me.txtDatebabtised.Name = "txtDatebabtised"
        Me.txtDatebabtised.Size = New System.Drawing.Size(141, 20)
        Me.txtDatebabtised.TabIndex = 15
        '
        'lblJoining
        '
        Me.lblJoining.AutoSize = True
        Me.lblJoining.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoining.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblJoining.Location = New System.Drawing.Point(264, 356)
        Me.lblJoining.Name = "lblJoining"
        Me.lblJoining.Size = New System.Drawing.Size(110, 16)
        Me.lblJoining.TabIndex = 29
        Me.lblJoining.Text = "Time of joining"
        '
        'txtJoining
        '
        Me.txtJoining.Location = New System.Drawing.Point(370, 356)
        Me.txtJoining.Name = "txtJoining"
        Me.txtJoining.Size = New System.Drawing.Size(128, 20)
        Me.txtJoining.TabIndex = 16
        '
        'lblProffesion
        '
        Me.lblProffesion.AutoSize = True
        Me.lblProffesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProffesion.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProffesion.Location = New System.Drawing.Point(12, 384)
        Me.lblProffesion.Name = "lblProffesion"
        Me.lblProffesion.Size = New System.Drawing.Size(78, 16)
        Me.lblProffesion.TabIndex = 30
        Me.lblProffesion.Text = "Proffesion"
        '
        'txtProffesion
        '
        Me.txtProffesion.Location = New System.Drawing.Point(123, 379)
        Me.txtProffesion.Name = "txtProffesion"
        Me.txtProffesion.Size = New System.Drawing.Size(141, 20)
        Me.txtProffesion.TabIndex = 17
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblEmail.Location = New System.Drawing.Point(12, 239)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(113, 16)
        Me.lblEmail.TabIndex = 32
        Me.lblEmail.Text = "E-mail address"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(123, 239)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(141, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(12, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Formar church"
        '
        'txtFormarChurch
        '
        Me.txtFormarChurch.Location = New System.Drawing.Point(123, 407)
        Me.txtFormarChurch.Name = "txtFormarChurch"
        Me.txtFormarChurch.Size = New System.Drawing.Size(141, 20)
        Me.txtFormarChurch.TabIndex = 19
        '
        'lblFormarPosition
        '
        Me.lblFormarPosition.AutoSize = True
        Me.lblFormarPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormarPosition.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFormarPosition.Location = New System.Drawing.Point(264, 414)
        Me.lblFormarPosition.Name = "lblFormarPosition"
        Me.lblFormarPosition.Size = New System.Drawing.Size(116, 16)
        Me.lblFormarPosition.TabIndex = 35
        Me.lblFormarPosition.Text = "Formar position"
        '
        'txtFormarPosition
        '
        Me.txtFormarPosition.Location = New System.Drawing.Point(380, 414)
        Me.txtFormarPosition.Name = "txtFormarPosition"
        Me.txtFormarPosition.Size = New System.Drawing.Size(118, 20)
        Me.txtFormarPosition.TabIndex = 20
        '
        'lblCurrentPosition
        '
        Me.lblCurrentPosition.AutoSize = True
        Me.lblCurrentPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPosition.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCurrentPosition.Location = New System.Drawing.Point(12, 442)
        Me.lblCurrentPosition.Name = "lblCurrentPosition"
        Me.lblCurrentPosition.Size = New System.Drawing.Size(116, 16)
        Me.lblCurrentPosition.TabIndex = 37
        Me.lblCurrentPosition.Text = "Current position"
        '
        'cmbCurrentPosition
        '
        Me.cmbCurrentPosition.FormattingEnabled = True
        Me.cmbCurrentPosition.Items.AddRange(New Object() {"MEMBER", "RING LEADER", "CARE GROUP LEADER", "DEACON", "DECONESS", "ELDER", "PRESIDING ELDER"})
        Me.cmbCurrentPosition.Location = New System.Drawing.Point(134, 435)
        Me.cmbCurrentPosition.MaxLength = 4
        Me.cmbCurrentPosition.Name = "cmbCurrentPosition"
        Me.cmbCurrentPosition.Size = New System.Drawing.Size(130, 21)
        Me.cmbCurrentPosition.TabIndex = 21
        '
        'lblCareGroup
        '
        Me.lblCareGroup.AutoSize = True
        Me.lblCareGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCareGroup.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCareGroup.Location = New System.Drawing.Point(264, 443)
        Me.lblCareGroup.Name = "lblCareGroup"
        Me.lblCareGroup.Size = New System.Drawing.Size(85, 16)
        Me.lblCareGroup.TabIndex = 39
        Me.lblCareGroup.Text = "Care group"
        '
        'cmbCareGroup
        '
        Me.cmbCareGroup.FormattingEnabled = True
        Me.cmbCareGroup.Items.AddRange(New Object() {"SUNDAY", "MONDAY", "TUESDAY", "WEDNESAY", "THURSDAY", "FRIDAY", "SATURDAY"})
        Me.cmbCareGroup.Location = New System.Drawing.Point(370, 443)
        Me.cmbCareGroup.MaxLength = 4
        Me.cmbCareGroup.Name = "cmbCareGroup"
        Me.cmbCareGroup.Size = New System.Drawing.Size(128, 21)
        Me.cmbCareGroup.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.cmdAddrec)
        Me.GroupBox1.Controls.Add(Me.cmdExtendSearch)
        Me.GroupBox1.Controls.Add(Me.cmdGenderSearch)
        Me.GroupBox1.Controls.Add(Me.cmdUpdateProfile)
        Me.GroupBox1.Controls.Add(Me.cmdDeleteProfile)
        Me.GroupBox1.Controls.Add(Me.cmdSearchbyGroup)
        Me.GroupBox1.Controls.Add(Me.cmdSearchByID)
        Me.GroupBox1.Controls.Add(Me.cmdSearchByName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(504, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 189)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Command and search zone"
        '
        'cmdAddrec
        '
        Me.cmdAddrec.BackColor = System.Drawing.Color.White
        Me.cmdAddrec.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAddrec.Location = New System.Drawing.Point(6, 21)
        Me.cmdAddrec.Name = "cmdAddrec"
        Me.cmdAddrec.Size = New System.Drawing.Size(134, 34)
        Me.cmdAddrec.TabIndex = 26
        Me.cmdAddrec.Text = "Add profile"
        Me.cmdAddrec.UseVisualStyleBackColor = False
        '
        'cmdExtendSearch
        '
        Me.cmdExtendSearch.BackColor = System.Drawing.Color.White
        Me.cmdExtendSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdExtendSearch.Location = New System.Drawing.Point(143, 142)
        Me.cmdExtendSearch.Name = "cmdExtendSearch"
        Me.cmdExtendSearch.Size = New System.Drawing.Size(134, 34)
        Me.cmdExtendSearch.TabIndex = 7
        Me.cmdExtendSearch.Text = "Extend search"
        Me.cmdExtendSearch.UseVisualStyleBackColor = False
        '
        'cmdGenderSearch
        '
        Me.cmdGenderSearch.BackColor = System.Drawing.Color.White
        Me.cmdGenderSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdGenderSearch.Location = New System.Drawing.Point(6, 140)
        Me.cmdGenderSearch.Name = "cmdGenderSearch"
        Me.cmdGenderSearch.Size = New System.Drawing.Size(134, 34)
        Me.cmdGenderSearch.TabIndex = 6
        Me.cmdGenderSearch.Text = "Gender search"
        Me.cmdGenderSearch.UseVisualStyleBackColor = False
        '
        'cmdUpdateProfile
        '
        Me.cmdUpdateProfile.BackColor = System.Drawing.Color.White
        Me.cmdUpdateProfile.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdUpdateProfile.Location = New System.Drawing.Point(6, 100)
        Me.cmdUpdateProfile.Name = "cmdUpdateProfile"
        Me.cmdUpdateProfile.Size = New System.Drawing.Size(134, 34)
        Me.cmdUpdateProfile.TabIndex = 5
        Me.cmdUpdateProfile.Text = "Update profile"
        Me.cmdUpdateProfile.UseVisualStyleBackColor = False
        '
        'cmdDeleteProfile
        '
        Me.cmdDeleteProfile.BackColor = System.Drawing.Color.White
        Me.cmdDeleteProfile.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdDeleteProfile.Location = New System.Drawing.Point(143, 61)
        Me.cmdDeleteProfile.Name = "cmdDeleteProfile"
        Me.cmdDeleteProfile.Size = New System.Drawing.Size(134, 34)
        Me.cmdDeleteProfile.TabIndex = 4
        Me.cmdDeleteProfile.Text = "Delete profile"
        Me.cmdDeleteProfile.UseVisualStyleBackColor = False
        '
        'cmdSearchbyGroup
        '
        Me.cmdSearchbyGroup.BackColor = System.Drawing.Color.White
        Me.cmdSearchbyGroup.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdSearchbyGroup.Location = New System.Drawing.Point(144, 102)
        Me.cmdSearchbyGroup.Name = "cmdSearchbyGroup"
        Me.cmdSearchbyGroup.Size = New System.Drawing.Size(134, 34)
        Me.cmdSearchbyGroup.TabIndex = 3
        Me.cmdSearchbyGroup.Text = "Search by group"
        Me.cmdSearchbyGroup.UseVisualStyleBackColor = False
        '
        'cmdSearchByID
        '
        Me.cmdSearchByID.BackColor = System.Drawing.Color.White
        Me.cmdSearchByID.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdSearchByID.Location = New System.Drawing.Point(6, 60)
        Me.cmdSearchByID.Name = "cmdSearchByID"
        Me.cmdSearchByID.Size = New System.Drawing.Size(134, 34)
        Me.cmdSearchByID.TabIndex = 2
        Me.cmdSearchByID.Text = "Search by ID"
        Me.cmdSearchByID.UseVisualStyleBackColor = False
        '
        'cmdSearchByName
        '
        Me.cmdSearchByName.BackColor = System.Drawing.Color.White
        Me.cmdSearchByName.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdSearchByName.Location = New System.Drawing.Point(144, 21)
        Me.cmdSearchByName.Name = "cmdSearchByName"
        Me.cmdSearchByName.Size = New System.Drawing.Size(134, 34)
        Me.cmdSearchByName.TabIndex = 1
        Me.cmdSearchByName.Text = "Search by name"
        Me.cmdSearchByName.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.drgChildren)
        Me.GroupBox2.Controls.Add(Me.lblChildName)
        Me.GroupBox2.Controls.Add(Me.txtChildName)
        Me.GroupBox2.Controls.Add(Me.cmdUpdateChild)
        Me.GroupBox2.Controls.Add(Me.cmdSearchChild)
        Me.GroupBox2.Controls.Add(Me.cmdRemoveChild)
        Me.GroupBox2.Controls.Add(Me.cmdAddChild)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(504, 435)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 249)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Children's records"
        '
        'drgChildren
        '
        Me.drgChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgChildren.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chlName})
        Me.drgChildren.Location = New System.Drawing.Point(9, 119)
        Me.drgChildren.Name = "drgChildren"
        Me.drgChildren.Size = New System.Drawing.Size(266, 122)
        Me.drgChildren.TabIndex = 44
        '
        'chlName
        '
        Me.chlName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.chlName.HeaderText = "List of children"
        Me.chlName.Name = "chlName"
        Me.chlName.ReadOnly = True
        Me.chlName.ToolTipText = "List of Children"
        '
        'lblChildName
        '
        Me.lblChildName.AutoSize = True
        Me.lblChildName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildName.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblChildName.Location = New System.Drawing.Point(3, 25)
        Me.lblChildName.Name = "lblChildName"
        Me.lblChildName.Size = New System.Drawing.Size(97, 16)
        Me.lblChildName.TabIndex = 43
        Me.lblChildName.Text = "Child's name"
        '
        'txtChildName
        '
        Me.txtChildName.Location = New System.Drawing.Point(106, 20)
        Me.txtChildName.Name = "txtChildName"
        Me.txtChildName.Size = New System.Drawing.Size(170, 21)
        Me.txtChildName.TabIndex = 23
        '
        'cmdUpdateChild
        '
        Me.cmdUpdateChild.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdUpdateChild.ForeColor = System.Drawing.Color.White
        Me.cmdUpdateChild.Location = New System.Drawing.Point(148, 86)
        Me.cmdUpdateChild.Name = "cmdUpdateChild"
        Me.cmdUpdateChild.Size = New System.Drawing.Size(113, 27)
        Me.cmdUpdateChild.TabIndex = 11
        Me.cmdUpdateChild.Text = "Update"
        Me.cmdUpdateChild.UseVisualStyleBackColor = False
        '
        'cmdSearchChild
        '
        Me.cmdSearchChild.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdSearchChild.ForeColor = System.Drawing.Color.White
        Me.cmdSearchChild.Location = New System.Drawing.Point(12, 86)
        Me.cmdSearchChild.Name = "cmdSearchChild"
        Me.cmdSearchChild.Size = New System.Drawing.Size(113, 27)
        Me.cmdSearchChild.TabIndex = 10
        Me.cmdSearchChild.Text = "Search name"
        Me.cmdSearchChild.UseVisualStyleBackColor = False
        '
        'cmdRemoveChild
        '
        Me.cmdRemoveChild.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdRemoveChild.ForeColor = System.Drawing.Color.White
        Me.cmdRemoveChild.Location = New System.Drawing.Point(149, 53)
        Me.cmdRemoveChild.Name = "cmdRemoveChild"
        Me.cmdRemoveChild.Size = New System.Drawing.Size(113, 27)
        Me.cmdRemoveChild.TabIndex = 9
        Me.cmdRemoveChild.Text = "Remove name"
        Me.cmdRemoveChild.UseVisualStyleBackColor = False
        '
        'cmdAddChild
        '
        Me.cmdAddChild.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAddChild.ForeColor = System.Drawing.Color.White
        Me.cmdAddChild.Location = New System.Drawing.Point(12, 53)
        Me.cmdAddChild.Name = "cmdAddChild"
        Me.cmdAddChild.Size = New System.Drawing.Size(113, 27)
        Me.cmdAddChild.TabIndex = 24
        Me.cmdAddChild.Text = "Add to list"
        Me.cmdAddChild.UseVisualStyleBackColor = False
        '
        'tabComment
        '
        Me.tabComment.Controls.Add(Me.TabPage1)
        Me.tabComment.Controls.Add(Me.TabPage2)
        Me.tabComment.Location = New System.Drawing.Point(15, 468)
        Me.tabComment.Name = "tabComment"
        Me.tabComment.SelectedIndex = 0
        Me.tabComment.Size = New System.Drawing.Size(365, 93)
        Me.tabComment.TabIndex = 43
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtGeneral)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(357, 67)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General comment"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtGeneral
        '
        Me.txtGeneral.Location = New System.Drawing.Point(0, 3)
        Me.txtGeneral.Multiline = True
        Me.txtGeneral.Name = "txtGeneral"
        Me.txtGeneral.Size = New System.Drawing.Size(355, 61)
        Me.txtGeneral.TabIndex = 44
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtConfidential)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(357, 67)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Confidential information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtConfidential
        '
        Me.txtConfidential.Location = New System.Drawing.Point(3, 3)
        Me.txtConfidential.Multiline = True
        Me.txtConfidential.Name = "txtConfidential"
        Me.txtConfidential.Size = New System.Drawing.Size(352, 61)
        Me.txtConfidential.TabIndex = 44
        '
        'drgProfile
        '
        Me.drgProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgProfile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.lName})
        Me.drgProfile.Location = New System.Drawing.Point(15, 567)
        Me.drgProfile.Name = "drgProfile"
        Me.drgProfile.Size = New System.Drawing.Size(483, 122)
        Me.drgProfile.TabIndex = 45
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "First name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'lName
        '
        Me.lName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lName.HeaderText = "Last name"
        Me.lName.Name = "lName"
        Me.lName.ReadOnly = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'cmdProfilePicture
        '
        Me.cmdProfilePicture.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdProfilePicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProfilePicture.ForeColor = System.Drawing.Color.White
        Me.cmdProfilePicture.Location = New System.Drawing.Point(653, 112)
        Me.cmdProfilePicture.Name = "cmdProfilePicture"
        Me.cmdProfilePicture.Size = New System.Drawing.Size(108, 23)
        Me.cmdProfilePicture.TabIndex = 46
        Me.cmdProfilePicture.Text = "Load picture"
        Me.cmdProfilePicture.UseVisualStyleBackColor = False
        '
        'Member_Profile
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(796, 704)
        Me.Controls.Add(Me.cmdProfilePicture)
        Me.Controls.Add(Me.drgProfile)
        Me.Controls.Add(Me.tabComment)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCareGroup)
        Me.Controls.Add(Me.lblCareGroup)
        Me.Controls.Add(Me.cmbCurrentPosition)
        Me.Controls.Add(Me.lblCurrentPosition)
        Me.Controls.Add(Me.txtFormarPosition)
        Me.Controls.Add(Me.lblFormarPosition)
        Me.Controls.Add(Me.txtFormarChurch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtProffesion)
        Me.Controls.Add(Me.lblProffesion)
        Me.Controls.Add(Me.txtJoining)
        Me.Controls.Add(Me.lblJoining)
        Me.Controls.Add(Me.txtDatebabtised)
        Me.Controls.Add(Me.lblDateBabtised)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.txtPlaceOfWork)
        Me.Controls.Add(Me.lblPlaceOfWork)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.lblMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.txtNspouse)
        Me.Controls.Add(Me.lblNspouse)
        Me.Controls.Add(Me.txtHnumber)
        Me.Controls.Add(Me.lblHnumber)
        Me.Controls.Add(Me.txtMnumber)
        Me.Controls.Add(Me.lblMnumber)
        Me.Controls.Add(Me.cmbMstatus)
        Me.Controls.Add(Me.lblMstatus)
        Me.Controls.Add(Me.txtHomeTown)
        Me.Controls.Add(Me.lblHomeTown)
        Me.Controls.Add(Me.txtResidence)
        Me.Controls.Add(Me.lblResidence)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.lblNationality)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.lblMIddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.cmdGenerateID)
        Me.Controls.Add(Me.txtMemberID)
        Me.Controls.Add(Me.frmMyPict)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Member_Profile"
        Me.Text = "Member profile"
        CType(Me.frmMyPict, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.drgChildren, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabComment.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.drgProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents logo As System.Windows.Forms.PictureBox
    Public WithEvents lblDateBabtised As System.Windows.Forms.Label
    Public WithEvents txtDatebabtised As System.Windows.Forms.TextBox
    Public WithEvents lblJoining As System.Windows.Forms.Label
    Public WithEvents txtJoining As System.Windows.Forms.TextBox
    Public WithEvents lblProffesion As System.Windows.Forms.Label
    Public WithEvents txtProffesion As System.Windows.Forms.TextBox
    Public WithEvents lblEmail As System.Windows.Forms.Label
    Public WithEvents txtEmail As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtFormarChurch As System.Windows.Forms.TextBox
    Public WithEvents lblFormarPosition As System.Windows.Forms.Label
    Public WithEvents txtFormarPosition As System.Windows.Forms.TextBox
    Public WithEvents lblCurrentPosition As System.Windows.Forms.Label
    Public WithEvents cmbCurrentPosition As System.Windows.Forms.ComboBox
    Public WithEvents lblCareGroup As System.Windows.Forms.Label
    Public WithEvents cmbCareGroup As System.Windows.Forms.ComboBox
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdUpdateProfile As System.Windows.Forms.Button
    Public WithEvents cmdDeleteProfile As System.Windows.Forms.Button
    Public WithEvents cmdSearchbyGroup As System.Windows.Forms.Button
    Public WithEvents cmdSearchByID As System.Windows.Forms.Button
    Public WithEvents cmdSearchByName As System.Windows.Forms.Button
    Public WithEvents cmdGenderSearch As System.Windows.Forms.Button
    Public WithEvents cmdExtendSearch As System.Windows.Forms.Button
    Public WithEvents cmdUpdateChild As System.Windows.Forms.Button
    Public WithEvents cmdSearchChild As System.Windows.Forms.Button
    Public WithEvents cmdRemoveChild As System.Windows.Forms.Button
    Public WithEvents cmdAddChild As System.Windows.Forms.Button
    Public WithEvents lblChildName As System.Windows.Forms.Label
    Public WithEvents txtChildName As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents frmMyPict As System.Windows.Forms.PictureBox
    Public WithEvents txtMemberID As System.Windows.Forms.TextBox
    Public WithEvents cmdGenerateID As System.Windows.Forms.Button
    Public WithEvents lblFirstName As System.Windows.Forms.Label
    Public WithEvents txtFirstName As System.Windows.Forms.TextBox
    Public WithEvents lblMIddleName As System.Windows.Forms.Label
    Public WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Public WithEvents lblLastName As System.Windows.Forms.Label
    Public WithEvents txtLastName As System.Windows.Forms.TextBox
    Public WithEvents lblDOB As System.Windows.Forms.Label
    Public WithEvents DOB As System.Windows.Forms.DateTimePicker
    Public WithEvents lblGender As System.Windows.Forms.Label
    Public WithEvents cmbGender As System.Windows.Forms.ComboBox
    Public WithEvents lblNationality As System.Windows.Forms.Label
    Public WithEvents txtNationality As System.Windows.Forms.TextBox
    Public WithEvents lblResidence As System.Windows.Forms.Label
    Public WithEvents txtResidence As System.Windows.Forms.TextBox
    Public WithEvents lblHomeTown As System.Windows.Forms.Label
    Public WithEvents txtHomeTown As System.Windows.Forms.TextBox
    Public WithEvents lblMstatus As System.Windows.Forms.Label
    Public WithEvents cmbMstatus As System.Windows.Forms.ComboBox
    Public WithEvents lblMnumber As System.Windows.Forms.Label
    Public WithEvents txtMnumber As System.Windows.Forms.MaskedTextBox
    Public WithEvents lblHnumber As System.Windows.Forms.Label
    Public WithEvents txtHnumber As System.Windows.Forms.MaskedTextBox
    Public WithEvents lblNspouse As System.Windows.Forms.Label
    Public WithEvents txtNspouse As System.Windows.Forms.TextBox
    Public WithEvents lblFname As System.Windows.Forms.Label
    Public WithEvents txtFname As System.Windows.Forms.TextBox
    Public WithEvents lblMname As System.Windows.Forms.Label
    Public WithEvents txtMname As System.Windows.Forms.TextBox
    Public WithEvents lblPlaceOfWork As System.Windows.Forms.Label
    Public WithEvents txtPlaceOfWork As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents tabComment As System.Windows.Forms.TabControl
    Public WithEvents txtGeneral As System.Windows.Forms.TextBox
    Public WithEvents txtConfidential As System.Windows.Forms.TextBox
    Friend WithEvents drgChildren As System.Windows.Forms.DataGridView
    Friend WithEvents chlName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents drgProfile As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lName As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Public WithEvents cmdProfilePicture As System.Windows.Forms.Button
    Public WithEvents cmdAddrec As System.Windows.Forms.Button
End Class
