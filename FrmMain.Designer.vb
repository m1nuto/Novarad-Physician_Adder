﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkAlias = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDelAliasNum = New System.Windows.Forms.TextBox()
        Me.BtnAliasDEL = New System.Windows.Forms.Button()
        Me.BtnCopyFirst = New System.Windows.Forms.Button()
        Me.ChkPeriod = New System.Windows.Forms.CheckBox()
        Me.BtnRegex = New System.Windows.Forms.Button()
        Me.ChkExisting = New System.Windows.Forms.CheckBox()
        Me.ChkHyphan = New System.Windows.Forms.CheckBox()
        Me.BtnPaste = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.ChkAuto = New System.Windows.Forms.CheckBox()
        Me.BtnOpenAD = New System.Windows.Forms.Button()
        Me.BtnAuto = New System.Windows.Forms.Button()
        Me.BtnDir = New System.Windows.Forms.Button()
        Me.BtnSaveWork = New System.Windows.Forms.Button()
        Me.BtnSingle = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnALL = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtGroup = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSkipped = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAfter = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtLineage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNameFull = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSuff = New System.Windows.Forms.TextBox()
        Me.LstAliases = New System.Windows.Forms.ListBox()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtMiddle = New System.Windows.Forms.TextBox()
        Me.TxtLast = New System.Windows.Forms.TextBox()
        Me.TxtFirst = New System.Windows.Forms.TextBox()
        Me.TmrDoAll = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ChkAlias)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtnCopyFirst)
        Me.Panel1.Controls.Add(Me.ChkPeriod)
        Me.Panel1.Controls.Add(Me.BtnRegex)
        Me.Panel1.Controls.Add(Me.ChkExisting)
        Me.Panel1.Controls.Add(Me.ChkHyphan)
        Me.Panel1.Controls.Add(Me.BtnPaste)
        Me.Panel1.Controls.Add(Me.BtnReload)
        Me.Panel1.Controls.Add(Me.ChkAuto)
        Me.Panel1.Controls.Add(Me.BtnOpenAD)
        Me.Panel1.Controls.Add(Me.BtnAuto)
        Me.Panel1.Controls.Add(Me.BtnDir)
        Me.Panel1.Controls.Add(Me.BtnSaveWork)
        Me.Panel1.Controls.Add(Me.BtnSingle)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnALL)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 616)
        Me.Panel1.TabIndex = 0
        '
        'ChkAlias
        '
        Me.ChkAlias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkAlias.AutoSize = True
        Me.ChkAlias.Checked = True
        Me.ChkAlias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAlias.Location = New System.Drawing.Point(5, 199)
        Me.ChkAlias.Name = "ChkAlias"
        Me.ChkAlias.Size = New System.Drawing.Size(65, 17)
        Me.ChkAlias.TabIndex = 35
        Me.ChkAlias.Text = "Aliases?"
        Me.ChkAlias.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtDelAliasNum)
        Me.GroupBox1.Controls.Add(Me.BtnAliasDEL)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(639, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 35)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DEL Alias"
        '
        'TxtDelAliasNum
        '
        Me.TxtDelAliasNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDelAliasNum.Location = New System.Drawing.Point(6, 12)
        Me.TxtDelAliasNum.Name = "TxtDelAliasNum"
        Me.TxtDelAliasNum.Size = New System.Drawing.Size(53, 17)
        Me.TxtDelAliasNum.TabIndex = 35
        '
        'BtnAliasDEL
        '
        Me.BtnAliasDEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAliasDEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.BtnAliasDEL.Location = New System.Drawing.Point(65, 8)
        Me.BtnAliasDEL.Name = "BtnAliasDEL"
        Me.BtnAliasDEL.Size = New System.Drawing.Size(35, 23)
        Me.BtnAliasDEL.TabIndex = 34
        Me.BtnAliasDEL.Text = "GO"
        Me.BtnAliasDEL.UseVisualStyleBackColor = True
        '
        'BtnCopyFirst
        '
        Me.BtnCopyFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCopyFirst.Location = New System.Drawing.Point(279, 220)
        Me.BtnCopyFirst.Name = "BtnCopyFirst"
        Me.BtnCopyFirst.Size = New System.Drawing.Size(50, 23)
        Me.BtnCopyFirst.TabIndex = 32
        Me.BtnCopyFirst.Text = "Copy"
        Me.BtnCopyFirst.UseVisualStyleBackColor = True
        '
        'ChkPeriod
        '
        Me.ChkPeriod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkPeriod.AutoSize = True
        Me.ChkPeriod.Location = New System.Drawing.Point(132, 197)
        Me.ChkPeriod.Name = "ChkPeriod"
        Me.ChkPeriod.Size = New System.Drawing.Size(72, 17)
        Me.ChkPeriod.TabIndex = 31
        Me.ChkPeriod.Text = "Replace ."
        Me.ChkPeriod.UseVisualStyleBackColor = True
        '
        'BtnRegex
        '
        Me.BtnRegex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRegex.Location = New System.Drawing.Point(210, 193)
        Me.BtnRegex.Name = "BtnRegex"
        Me.BtnRegex.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegex.TabIndex = 30
        Me.BtnRegex.Text = "RegEx"
        Me.BtnRegex.UseVisualStyleBackColor = True
        '
        'ChkExisting
        '
        Me.ChkExisting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkExisting.AutoSize = True
        Me.ChkExisting.Checked = True
        Me.ChkExisting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkExisting.Location = New System.Drawing.Point(351, 197)
        Me.ChkExisting.Name = "ChkExisting"
        Me.ChkExisting.Size = New System.Drawing.Size(57, 17)
        Me.ChkExisting.TabIndex = 29
        Me.ChkExisting.Text = "If Exist"
        Me.ChkExisting.UseVisualStyleBackColor = True
        '
        'ChkHyphan
        '
        Me.ChkHyphan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHyphan.AutoSize = True
        Me.ChkHyphan.Location = New System.Drawing.Point(414, 197)
        Me.ChkHyphan.Name = "ChkHyphan"
        Me.ChkHyphan.Size = New System.Drawing.Size(57, 17)
        Me.ChkHyphan.TabIndex = 28
        Me.ChkHyphan.Text = """ "" to -"
        Me.ChkHyphan.UseVisualStyleBackColor = True
        '
        'BtnPaste
        '
        Me.BtnPaste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPaste.Location = New System.Drawing.Point(223, 220)
        Me.BtnPaste.Name = "BtnPaste"
        Me.BtnPaste.Size = New System.Drawing.Size(50, 23)
        Me.BtnPaste.TabIndex = 27
        Me.BtnPaste.Text = "Paste"
        Me.BtnPaste.UseVisualStyleBackColor = True
        '
        'BtnReload
        '
        Me.BtnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnReload.Location = New System.Drawing.Point(169, 220)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(50, 23)
        Me.BtnReload.TabIndex = 26
        Me.BtnReload.Text = "Reload"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'ChkAuto
        '
        Me.ChkAuto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAuto.AutoSize = True
        Me.ChkAuto.Location = New System.Drawing.Point(491, 197)
        Me.ChkAuto.Name = "ChkAuto"
        Me.ChkAuto.Size = New System.Drawing.Size(71, 17)
        Me.ChkAuto.TabIndex = 25
        Me.ChkAuto.Text = "Automate"
        Me.ChkAuto.UseVisualStyleBackColor = True
        '
        'BtnOpenAD
        '
        Me.BtnOpenAD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenAD.Location = New System.Drawing.Point(587, 220)
        Me.BtnOpenAD.Name = "BtnOpenAD"
        Me.BtnOpenAD.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpenAD.TabIndex = 24
        Me.BtnOpenAD.Text = "Open Admin"
        Me.BtnOpenAD.UseVisualStyleBackColor = True
        '
        'BtnAuto
        '
        Me.BtnAuto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAuto.Location = New System.Drawing.Point(668, 220)
        Me.BtnAuto.Name = "BtnAuto"
        Me.BtnAuto.Size = New System.Drawing.Size(75, 23)
        Me.BtnAuto.TabIndex = 23
        Me.BtnAuto.Text = "Auto Alias"
        Me.BtnAuto.UseVisualStyleBackColor = True
        '
        'BtnDir
        '
        Me.BtnDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDir.Location = New System.Drawing.Point(84, 220)
        Me.BtnDir.Name = "BtnDir"
        Me.BtnDir.Size = New System.Drawing.Size(75, 23)
        Me.BtnDir.TabIndex = 22
        Me.BtnDir.Text = "Open Dir"
        Me.BtnDir.UseVisualStyleBackColor = True
        '
        'BtnSaveWork
        '
        Me.BtnSaveWork.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveWork.Location = New System.Drawing.Point(3, 220)
        Me.BtnSaveWork.Name = "BtnSaveWork"
        Me.BtnSaveWork.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveWork.TabIndex = 21
        Me.BtnSaveWork.Text = "Save"
        Me.BtnSaveWork.UseVisualStyleBackColor = True
        '
        'BtnSingle
        '
        Me.BtnSingle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSingle.Location = New System.Drawing.Point(497, 220)
        Me.BtnSingle.Name = "BtnSingle"
        Me.BtnSingle.Size = New System.Drawing.Size(75, 23)
        Me.BtnSingle.TabIndex = 20
        Me.BtnSingle.Text = "Single"
        Me.BtnSingle.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(346, 220)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 19
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnALL
        '
        Me.BtnALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnALL.Location = New System.Drawing.Point(419, 220)
        Me.BtnALL.Name = "BtnALL"
        Me.BtnALL.Size = New System.Drawing.Size(75, 23)
        Me.BtnALL.TabIndex = 18
        Me.BtnALL.Text = "ALL"
        Me.BtnALL.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SplitContainer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(746, 367)
        Me.Panel3.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtGroup)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtSkipped)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtAfter)
        Me.SplitContainer1.Size = New System.Drawing.Size(746, 367)
        Me.SplitContainer1.SplitterDistance = 342
        Me.SplitContainer1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label9.Location = New System.Drawing.Point(0, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 12)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Before"
        '
        'TxtGroup
        '
        Me.TxtGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtGroup.Location = New System.Drawing.Point(0, 0)
        Me.TxtGroup.Multiline = True
        Me.TxtGroup.Name = "TxtGroup"
        Me.TxtGroup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtGroup.Size = New System.Drawing.Size(342, 367)
        Me.TxtGroup.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label11.Location = New System.Drawing.Point(0, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 12)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "After"
        '
        'TxtSkipped
        '
        Me.TxtSkipped.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtSkipped.Location = New System.Drawing.Point(0, 231)
        Me.TxtSkipped.Multiline = True
        Me.TxtSkipped.Name = "TxtSkipped"
        Me.TxtSkipped.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtSkipped.Size = New System.Drawing.Size(400, 136)
        Me.TxtSkipped.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label8.Location = New System.Drawing.Point(0, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 12)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "After"
        '
        'TxtAfter
        '
        Me.TxtAfter.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtAfter.Location = New System.Drawing.Point(0, 0)
        Me.TxtAfter.Multiline = True
        Me.TxtAfter.Name = "TxtAfter"
        Me.TxtAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAfter.Size = New System.Drawing.Size(400, 216)
        Me.TxtAfter.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtLineage)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TxtNameFull)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtSuff)
        Me.Panel2.Controls.Add(Me.LstAliases)
        Me.Panel2.Controls.Add(Me.TxtFax)
        Me.Panel2.Controls.Add(Me.TxtUser)
        Me.Panel2.Controls.Add(Me.TxtMiddle)
        Me.Panel2.Controls.Add(Me.TxtLast)
        Me.Panel2.Controls.Add(Me.TxtFirst)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(746, 158)
        Me.Panel2.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label12.Location = New System.Drawing.Point(614, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 12)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Lineage"
        '
        'TxtLineage
        '
        Me.TxtLineage.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtLineage.Location = New System.Drawing.Point(614, 45)
        Me.TxtLineage.Name = "TxtLineage"
        Me.TxtLineage.Size = New System.Drawing.Size(120, 20)
        Me.TxtLineage.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label10.Location = New System.Drawing.Point(0, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 12)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Aliases"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label7.Location = New System.Drawing.Point(5, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 12)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Full Name"
        '
        'TxtNameFull
        '
        Me.TxtNameFull.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNameFull.Location = New System.Drawing.Point(3, 76)
        Me.TxtNameFull.Name = "TxtNameFull"
        Me.TxtNameFull.Size = New System.Drawing.Size(731, 20)
        Me.TxtNameFull.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label6.Location = New System.Drawing.Point(495, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Degree"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label5.Location = New System.Drawing.Point(4, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "User"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label4.Location = New System.Drawing.Point(495, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mid"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label3.Location = New System.Drawing.Point(250, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "First"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label2.Location = New System.Drawing.Point(248, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fax"
        '
        'TxtSuff
        '
        Me.TxtSuff.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtSuff.Location = New System.Drawing.Point(495, 45)
        Me.TxtSuff.Name = "TxtSuff"
        Me.TxtSuff.Size = New System.Drawing.Size(113, 20)
        Me.TxtSuff.TabIndex = 8
        '
        'LstAliases
        '
        Me.LstAliases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstAliases.FormattingEnabled = True
        Me.LstAliases.Location = New System.Drawing.Point(0, 102)
        Me.LstAliases.Name = "LstAliases"
        Me.LstAliases.ScrollAlwaysVisible = True
        Me.LstAliases.Size = New System.Drawing.Size(746, 56)
        Me.LstAliases.Sorted = True
        Me.LstAliases.TabIndex = 6
        '
        'TxtFax
        '
        Me.TxtFax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtFax.Location = New System.Drawing.Point(248, 45)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(239, 20)
        Me.TxtFax.TabIndex = 5
        '
        'TxtUser
        '
        Me.TxtUser.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtUser.Location = New System.Drawing.Point(3, 45)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(239, 20)
        Me.TxtUser.TabIndex = 4
        '
        'TxtMiddle
        '
        Me.TxtMiddle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMiddle.Location = New System.Drawing.Point(495, 12)
        Me.TxtMiddle.Name = "TxtMiddle"
        Me.TxtMiddle.Size = New System.Drawing.Size(239, 20)
        Me.TxtMiddle.TabIndex = 3
        '
        'TxtLast
        '
        Me.TxtLast.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtLast.Location = New System.Drawing.Point(250, 12)
        Me.TxtLast.Name = "TxtLast"
        Me.TxtLast.Size = New System.Drawing.Size(239, 20)
        Me.TxtLast.TabIndex = 2
        '
        'TxtFirst
        '
        Me.TxtFirst.Location = New System.Drawing.Point(5, 12)
        Me.TxtFirst.Name = "TxtFirst"
        Me.TxtFirst.Size = New System.Drawing.Size(239, 20)
        Me.TxtFirst.TabIndex = 1
        '
        'TmrDoAll
        '
        Me.TmrDoAll.Interval = 7500
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 605)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Novarad - Physician Adder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtLast As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirst As System.Windows.Forms.TextBox
    Friend WithEvents LstAliases As System.Windows.Forms.ListBox
    Friend WithEvents TxtFax As System.Windows.Forms.TextBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtMiddle As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuff As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNameFull As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TxtGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtAfter As System.Windows.Forms.TextBox
    Friend WithEvents BtnALL As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnSingle As System.Windows.Forms.Button
    Friend WithEvents BtnSaveWork As System.Windows.Forms.Button
    Friend WithEvents BtnDir As System.Windows.Forms.Button
    Friend WithEvents BtnAuto As System.Windows.Forms.Button
    Friend WithEvents BtnOpenAD As System.Windows.Forms.Button
    Friend WithEvents ChkAuto As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtSkipped As System.Windows.Forms.TextBox
    Friend WithEvents BtnReload As System.Windows.Forms.Button
    Friend WithEvents BtnPaste As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtLineage As System.Windows.Forms.TextBox
    Friend WithEvents ChkHyphan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkExisting As System.Windows.Forms.CheckBox
    Friend WithEvents TmrDoAll As System.Windows.Forms.Timer
    Friend WithEvents BtnRegex As System.Windows.Forms.Button
    Friend WithEvents ChkPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents BtnCopyFirst As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDelAliasNum As System.Windows.Forms.TextBox
    Friend WithEvents BtnAliasDEL As System.Windows.Forms.Button
    Friend WithEvents ChkAlias As System.Windows.Forms.CheckBox

End Class
