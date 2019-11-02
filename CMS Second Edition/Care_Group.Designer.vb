<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Care_Group
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
        Me.cmbCGName = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCGLeader = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCGID = New System.Windows.Forms.TextBox
        Me.drgCareGroup = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdRemoveCG = New System.Windows.Forms.Button
        Me.cmdUpdateCG = New System.Windows.Forms.Button
        Me.cmdEditCG = New System.Windows.Forms.Button
        Me.cmdAddRings = New System.Windows.Forms.Button
        Me.cmdSearchCG = New System.Windows.Forms.Button
        Me.cmdCreate = New System.Windows.Forms.Button
        Me.cmdSelectName = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.drgCareGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCGName
        '
        Me.cmbCGName.FormattingEnabled = True
        Me.cmbCGName.Items.AddRange(New Object() {"SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"})
        Me.cmbCGName.Location = New System.Drawing.Point(146, 83)
        Me.cmbCGName.Name = "cmbCGName"
        Me.cmbCGName.Size = New System.Drawing.Size(185, 21)
        Me.cmbCGName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TITUS Cyberbit Basic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(140, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create new Care Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(14, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select care group"
        '
        'txtCGLeader
        '
        Me.txtCGLeader.Location = New System.Drawing.Point(146, 129)
        Me.txtCGLeader.Name = "txtCGLeader"
        Me.txtCGLeader.Size = New System.Drawing.Size(148, 20)
        Me.txtCGLeader.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(14, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Leader's ID"
        '
        'txtCGID
        '
        Me.txtCGID.Location = New System.Drawing.Point(146, 174)
        Me.txtCGID.Name = "txtCGID"
        Me.txtCGID.Size = New System.Drawing.Size(148, 20)
        Me.txtCGID.TabIndex = 3
        '
        'drgCareGroup
        '
        Me.drgCareGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgCareGroup.Location = New System.Drawing.Point(6, 14)
        Me.drgCareGroup.Name = "drgCareGroup"
        Me.drgCareGroup.Size = New System.Drawing.Size(336, 122)
        Me.drgCareGroup.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRefresh)
        Me.GroupBox1.Controls.Add(Me.cmdRemoveCG)
        Me.GroupBox1.Controls.Add(Me.cmdUpdateCG)
        Me.GroupBox1.Controls.Add(Me.cmdEditCG)
        Me.GroupBox1.Controls.Add(Me.cmdAddRings)
        Me.GroupBox1.Controls.Add(Me.cmdSearchCG)
        Me.GroupBox1.Controls.Add(Me.cmdCreate)
        Me.GroupBox1.Location = New System.Drawing.Point(390, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 239)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Location = New System.Drawing.Point(6, 206)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(129, 26)
        Me.cmdRefresh.TabIndex = 6
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdRemoveCG
        '
        Me.cmdRemoveCG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemoveCG.Location = New System.Drawing.Point(6, 174)
        Me.cmdRemoveCG.Name = "cmdRemoveCG"
        Me.cmdRemoveCG.Size = New System.Drawing.Size(129, 26)
        Me.cmdRemoveCG.TabIndex = 5
        Me.cmdRemoveCG.Text = "Remove care group"
        Me.cmdRemoveCG.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdRemoveCG.UseVisualStyleBackColor = True
        '
        'cmdUpdateCG
        '
        Me.cmdUpdateCG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateCG.Location = New System.Drawing.Point(6, 143)
        Me.cmdUpdateCG.Name = "cmdUpdateCG"
        Me.cmdUpdateCG.Size = New System.Drawing.Size(129, 26)
        Me.cmdUpdateCG.TabIndex = 4
        Me.cmdUpdateCG.Text = "Update care group"
        Me.cmdUpdateCG.UseVisualStyleBackColor = True
        '
        'cmdEditCG
        '
        Me.cmdEditCG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditCG.Location = New System.Drawing.Point(6, 112)
        Me.cmdEditCG.Name = "cmdEditCG"
        Me.cmdEditCG.Size = New System.Drawing.Size(129, 26)
        Me.cmdEditCG.TabIndex = 3
        Me.cmdEditCG.Text = "Edit care group"
        Me.cmdEditCG.UseVisualStyleBackColor = True
        '
        'cmdAddRings
        '
        Me.cmdAddRings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRings.Location = New System.Drawing.Point(6, 50)
        Me.cmdAddRings.Name = "cmdAddRings"
        Me.cmdAddRings.Size = New System.Drawing.Size(129, 26)
        Me.cmdAddRings.TabIndex = 2
        Me.cmdAddRings.Text = "Add rings"
        Me.cmdAddRings.UseVisualStyleBackColor = True
        '
        'cmdSearchCG
        '
        Me.cmdSearchCG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearchCG.Location = New System.Drawing.Point(6, 81)
        Me.cmdSearchCG.Name = "cmdSearchCG"
        Me.cmdSearchCG.Size = New System.Drawing.Size(129, 26)
        Me.cmdSearchCG.TabIndex = 1
        Me.cmdSearchCG.Text = "Search care group"
        Me.cmdSearchCG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearchCG.UseVisualStyleBackColor = True
        '
        'cmdCreate
        '
        Me.cmdCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreate.Location = New System.Drawing.Point(6, 19)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(129, 26)
        Me.cmdCreate.TabIndex = 4
        Me.cmdCreate.Text = "Create care group"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'cmdSelectName
        '
        Me.cmdSelectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectName.Location = New System.Drawing.Point(300, 115)
        Me.cmdSelectName.Name = "cmdSelectName"
        Me.cmdSelectName.Size = New System.Drawing.Size(53, 48)
        Me.cmdSelectName.TabIndex = 9
        Me.cmdSelectName.Text = "Select name"
        Me.cmdSelectName.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.drgCareGroup)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 142)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List care groups"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(21, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Care group ID"
        '
        'Care_Group
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 344)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdSelectName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCGID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCGLeader)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCGName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Care_Group"
        Me.Text = "Care_Group"
        CType(Me.drgCareGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend WithEvents cmdRemoveCG As System.Windows.Forms.Button
    Friend WithEvents cmdUpdateCG As System.Windows.Forms.Button
    Friend WithEvents cmdEditCG As System.Windows.Forms.Button
    Friend WithEvents cmdAddRings As System.Windows.Forms.Button
    Friend WithEvents cmdSearchCG As System.Windows.Forms.Button
    Friend WithEvents cmdSelectName As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents cmbCGName As System.Windows.Forms.ComboBox
    Public WithEvents txtCGLeader As System.Windows.Forms.TextBox
    Public WithEvents txtCGID As System.Windows.Forms.TextBox
    Public WithEvents drgCareGroup As System.Windows.Forms.DataGridView
End Class
