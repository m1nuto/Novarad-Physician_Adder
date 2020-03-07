Imports System
Imports System.IO
Imports System.Threading
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Runtime.CompilerServices

Module StringExtensions

    'ATTEMPT AT BACKGROUND THREAD RUN
    'Sub MyBackgroundThread()
    '    Console.WriteLine("Hullo")
    'End Sub
    'And then create and start the thread with;
    '    Dim thread As New Thread(AddressOf MyBackgroundThread)
    'thread.Start()
    '    'Or as a lambda function.
    'Dim thread as New Thread(
    '  Sub() 
    '        Console.WriteLine("Hullo")
    '    End Sub
    ')
    'thread.Start()

    'INSERTS CHAR AFTER EVERY CHAR IN STR
    Public Function InsertEveryNthChar(ByVal str As String, ByVal inserString As String, ByVal nthChar As Int32) As String
        If String.IsNullOrEmpty(str) Then Return str

        Dim builder As New StringBuilder(str)
        Dim startIndex = builder.Length - (builder.Length Mod nthChar)

        For i As Int32 = startIndex To nthChar Step -nthChar
            builder.Insert(i, inserString)
        Next i

        Return builder.ToString()
    End Function
End Module

Public Class FrmMain
#Region "UNUSED"
    'UNUSED TRASH

    'ATTEMPT TO CREATE SUFFIX STANDARDIZER
    'UNUSED
    Private Sub BtnRegex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegex.Click
        regfix()
    End Sub
    Public Sub regfix()

        Dim reg_exp1 As String = ("([A-Z]{2,29})\.{1,}")
        '    Dim reg_exp2 As String = ("/^([A-Z]{2,29})\,{2,}./g")
        Dim op As String
        For Each st As String In TxtGroup.Text.Split(nl)
            If Regex.IsMatch(st, reg_exp1) Then
                Dim t2 As String = st.Split("."c).First()
                op &= (t2(0) & "," & t2(1)).Replace(",,", ",") & nl
            Else
                op &= st & nl
            End If

        Next
        TxtGroup.Text = op

        '            Dim mt = Regex.Match(st, reg_exp1)
        '            Dim mti As Integer = mt.Length
        '            st = Regex.Replace(st, reg_exp1, "$1") & st.Remove(0, mti)
        '        ElseIf Regex.IsMatch(st, reg_exp2) Then

        '            Dim mt = Regex.Match(st, reg_exp2)
        '            Dim mti As Integer = mt.Length
        '            st = Regex.Replace(st, reg_exp2, "$1") & st.Remove(0, mti)

        '        Else
        '            st = st
        '        End If
        '        op &= st & nl
        '    Next
        '    TxtGroup.Text = op
    End Sub

    'FROM CSVREDOLINE
    'Try
    '    Dim modline As String = ""
    '    Dim therequote As String = ""
    '    Dim replacement As String = ""
    '    Dim rx As New Regex("(?<="").+(?="")")
    '    therequote = rx.Match(Line).Value
    '    If therequote <> "" Then
    '        'MsgBox(therequote)
    '        replacement = therequote.Replace(",", "")
    '        modline = Line.Replace(therequote, replacement)
    '        'MsgBox(modline)
    '    End If

    '    Dim bp() As String = Line.Split(","c)


    '    ' If 1 = 1 = True Then 
    '    'If bp(TxtSection.Text.ToString).Contains("XR") Or bp(TxtSection.Text.ToString).Contains("NM") Or bp(TxtSection.Text.ToString).Contains("US") Or bp(TxtSection.Text.ToString).Contains("CT") Or bp(TxtSection.Text.ToString).Contains("MM") Or bp(TxtSection.Text.ToString).Contains("MG") Or bp(TxtSection.Text.ToString).Contains("MR") Then
    '    ourcpt = ourcpt.Replace(" ", "")

    'End Try

    '

    'Public Sub getans(ByVal FileName As String)
    '    Dim failed As String = ""
    '    Try


    '        Using reader As New StreamReader(FileName)
    '            While Not reader.EndOfStream
    '                Dim line As String = reader.ReadLine()
    '                Dim unmodline As String = line
    '                Try
    '                    Dim modline As String = ""
    '                    Dim therequote As String = ""
    '                    Dim replacement As String = ""
    '                    Dim rx As New Regex("(?<="").+(?="")")
    '                    therequote = rx.Match(line).Value
    '                    If therequote <> "" Then
    '                        'MsgBox(therequote)
    '                        replacement = therequote.Replace(",", "")
    '                        modline = line.Replace(therequote, replacement)
    '                        'MsgBox(modline)
    '                    End If
    '                    Dim isMG As Boolean = False
    '                    Dim bp() As String = line.Split(","c)
    '                    Dim thecptint As Integer = TxtCPT.Text
    '                    Dim thedescint As Integer = TxtDesc.Text
    '                    Dim ourcpt As String = bp(TxtCPT.Text.ToString)
    '                    ' If 1 = 1 = True Then 
    '                    'If bp(TxtSection.Text.ToString).Contains("XR") Or bp(TxtSection.Text.ToString).Contains("NM") Or bp(TxtSection.Text.ToString).Contains("US") Or bp(TxtSection.Text.ToString).Contains("CT") Or bp(TxtSection.Text.ToString).Contains("MM") Or bp(TxtSection.Text.ToString).Contains("MG") Or bp(TxtSection.Text.ToString).Contains("MR") Then
    '                    ourcpt = ourcpt.Replace(" ", "")
    '                    Dim lines() As String = Filter(System.IO.File.ReadAllLines(ad & ("codes.txt")), ourcpt)

    '                    If bp(TxtDesc.Text.ToString).Contains("BREAST") Or bp(TxtDesc.Text.ToString).Contains("mammo") Or bp(TxtSection.Text.ToString).Contains("MG") Or bp(TxtSection.Text.ToString).Contains("Mammo") Then 'Or bp(TxtSection.Text.ToString).Contains("MM")
    '                        isMG = True
    '                    End If
    '                    If UBound(lines) = -1 Then
    '                        Dim s As String = ourcpt
    '                        If ourcpt.Contains("LT") Or ourcpt.Contains("RT") Then
    '                            'MsgBox(s & "END")
    '                            s = s.Substring(0, 5)
    '                            'MsgBox(s & "END")
    '                        End If

    '                        Dim num2() As String = Filter(System.IO.File.ReadAllLines(ad & ("codes.txt")), s)
    '                        If UBound(num2) = -1 Then
    '                            If isMG = True Then
    '                                myans &= unmodline.ToString & "," & "," & "YES" & Environment.NewLine
    '                            Else
    '                                myans &= unmodline.ToString & "," & "," & Environment.NewLine
    '                            End If
    '                        Else
    '                            If isMG = True Then
    '                                myans &= unmodline.ToString & "," & s & "," & "YES" & Environment.NewLine
    '                            Else
    '                                myans &= unmodline.ToString & "," & s & Environment.NewLine
    '                            End If
    '                        End If
    '                    Else
    '                        If isMG = True Then
    '                            myans &= unmodline.ToString & "," & bp(TxtCPT.Text.ToString) & "," & "YES" & Environment.NewLine
    '                        Else
    '                            myans &= unmodline.ToString & "," & bp(TxtCPT.Text.ToString) & Environment.NewLine
    '                        End If
    '                    End If
    '                    'End If
    '                Catch ex As Exception
    '                    failed &= unmodline & Environment.NewLine
    '                End Try

    '            End While
    '        End Using
    '        SaveFileDialog1.ShowDialog()
    '        File.WriteAllText(SaveFileDialog1.FileName, myans)
    '        If failed <> "" Then
    '            Try
    '                File.WriteAllText(ad & "failed.csv", failed)
    '                MsgBox("Had failed items, please check failed.csv in the Applicaiton Directory", MsgBoxStyle.Critical, "Oops...")
    '            Catch ex As Exception
    '                MsgBox("Had failed items, but failed.csv is open", MsgBoxStyle.Critical, "Oops...")
    '            End Try
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message & Environment.NewLine & "Make sure no files are open that are in use.", MsgBoxStyle.Critical, "There was an error...")
    '    End Try
    'End Sub
#End Region
#Region "VARIABLES"
    'CREATE VARIABLES
    Public Shared continueLooping As Boolean = True

    Public Shared keepgoing = False

    ReadOnly CurrentSessionID As Integer = Process.GetCurrentProcess.SessionId
    Dim doit As Boolean
    Dim ad As String = AppDomain.CurrentDomain.BaseDirectory

    Dim UserList = File.ReadAllText(ad & "NRUsers.csv").ToUpper

    Dim Suffixes As String = "PHD,P.H.D.,N.P.FNP-C,FDY,APRN,P.A.,DDS,FAAP,DPM,Dpm,MD,NP-FNP,FNP,N.P.,M.D,FAAP,PA-C, -C,DO ,DC,M.D.,MD.,DO., DO ,D.O.,D.C.,DC."
    Dim PreFixes As String = "DR ,Dr,Dr.,DR."

    Dim Suffix() As String = Suffixes.Split(","c)
    Dim Prefix() As String = PreFixes.Split(","c)
    Dim nl As String = Environment.NewLine
    Dim pr As String = """"
    Dim fin As String = Nothing

    Public Shared p As Process
    Dim curwrk As String = ad & "CurWork.CSV"

#End Region

#Region "START UP"
    'LOAD MOST RECENT SAVE TO TXT BEFORE
    Public Sub loadrec()
        Dim opener
        If File.Exists(curwrk) Then opener = curwrk Else opener = ad & "default.csv"
        Try

            TxtGroup.Text = File.ReadAllText(opener)
        Catch ex As Exception

        End Try

    End Sub

    'LOAD MAIN
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FILL AUTOHOTKEY INSTANCES
        killah()
        'LOAD RECENT SAVE
        loadrec()
    End Sub
#End Region

#Region "STANDARDIZE NAME - LOCATE PORTIONS"
    'FIND LINEAGE IN NAME
    Public Function FindLineage(ByVal str As String) As String
        Dim OPtxt As String = Nothing
        Dim LnTxt As String = " III, II, JR, JR., J.R., SR, SR., S.R."
        Dim LN() As String = LnTxt.Split(","c)
        For Each l As String In LN
            If str.Contains(l) Then
                OPtxt = R(str, l) & ":" & RSP(l)
                Exit For

            Else
                Dim l2 As String = Rp(l, " ", ",")
                If str.Contains(l2) Then
                    OPtxt = R(str, l2) & ":" & l2
                    Exit For

                End If
            End If
        Next

        'RETURN OP STRING
        If OPtxt = Nothing Then OPtxt = str
        Return OPtxt
    End Function
    'STANDARDIZE SUFFIX
    Public Sub fixpre()
        TxtGroup.Text = TxtGroup.Text.ToUpper.Replace("PHD", "P.H.D.").Replace(",DO,", ",D.O.,").Replace(",DO" & nl, ",D.O." & nl).Replace(" DO" & nl, " D.O." & nl).Replace(" DO ", " D.O. ").Replace(", DO,", ", D.O.,").Replace(", PA,", ", P.A.,").Replace("DO ", "D.O.").Replace(",DO,", ",D.O.,").Replace(" DO ", " D.O. ")
    End Sub
    'STANDARDIZE ENTRY TO ADD QUOTATIONS BEFORE PROCESSING
    Public Function AdPer(ByVal sumstr As String) As String

        If sumstr.Contains("""") = False Or CntCh(sumstr, pr) = 1 Then

            Dim lstr As String = sumstr.Split(","c).Last()
            If lstr.Length > 0 And IsNumeric(lstr) Then
                sumstr = pr & sumstr.Replace("," & lstr, "") & pr & "," & lstr
            Else
                sumstr = pr & sumstr & pr

            End If
            ' or 
            'Dim lastIndex = Path.LastIndexOf("/")
            'If lastIndex >= 0 Then
            '    fileName = Path.Substring(lastIndex + 1)
            'End If
        Else
            Dim Char1 As Char
            Dim char2 As Char
            Char1 = sumstr.Substring(0, 1)

            char2 = sumstr.Substring(sumstr.Length - 1, 1)
            If Char1 <> pr Then sumstr = pr & sumstr
            If char2 <> pr Then sumstr = sumstr & pr
        End If

        sumstr = sumstr.Replace("," & pr, pr & ",").Replace(pr & pr, pr)

        Return sumstr
    End Function
#End Region

#Region "STRING MODIFICATION ROUTINES"
    'REMOVE A STRING FROM STRING
    Public Function R(ByVal str As String, ByVal L As String) As String
        Return str.Replace(L, "")
    End Function
    'REPLACE A STRING IN STRING WITH STRING
    Public Function Rp(ByVal str As String, ByVal FrmStr As String, ByVal ToStr As String) As String
        Return str.Replace(FrmStr, ToStr)
    End Function
    'REPACE A STRING WITH SPACE
    Public Function RSP(ByVal str As String) As String
        Return R(str, " ")
    End Function
    'Add Lineage to Last Name
    Public Function AdLn(ByVal str As String) As String
        Return str & " " & TxtLineage.Text
    End Function
    'COUNTS NUMBER OF A CHAR IN ALL CHARACTERS IN STRING AND RETURNS INT
    Public Function CntCh(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c.ToString = ch.ToString Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    'SEND A STRING TO CLIPBOARD
    Public Sub ClpTxt(ByVal str As String)
GO:
        If str = Nothing Or str = "" Then str = " "
        Try
            Do Until Windows.Forms.Clipboard.GetText = str
                Windows.Forms.Clipboard.SetText(str)
            Loop
            Exit Sub

        Catch ex As Exception
            GoTo GO

        End Try
    End Sub
#End Region

#Region "MAIN NAME PROCESSING"
    'RUN TEXT BEFORE CLEANER (CSVREDOLINE) ON ENTIRE FILE
    Public Sub CSVRedoFile(ByVal FileName As String)
        fin = Nothing

        'Dim reader as new StreamReader =  StreamReader(FileName, Encoding.Default)
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(FileName)
        Dim a As String
        Do
            a = reader.ReadLine
            fin &= CSVRedoLine(a)
        Loop Until a Is Nothing

        reader.Close()

    End Sub

    'CLEAN ALL LINES OF BEFORE TEXTBOX
    Public Sub CSVRedoBefore(ByVal Str As String)

        Dim TextLines() As String = Str.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)

        For Each a As String In TextLines
            If ChkPeriod.Checked Then a = a.Replace(".", ",")
            Dim tmpline = CSVRedoLine(a)
            If ChkExisting.Checked AndAlso CheckUser(TxtUser.Text.ToUpper.Trim, TxtFirst.Text.ToUpper.Trim, TxtLast.Text.ToUpper.Trim) = False Then
                doit = True
                If TxtAfter.Text = "" Then
                    TxtAfter.Text = tmpline
                Else
                    TxtAfter.Text = tmpline & nl & TxtAfter.Text

                End If
            Else
                doit = False
                If TxtSkipped.Text = "" Then
                    TxtSkipped.Text = tmpline
                Else
                    TxtSkipped.Text = tmpline & nl & TxtSkipped.Text

                End If

            End If

            TxtGroup.Text.Replace(Str & nl, "")
        Next

    End Sub

    'PROCESS SINGLE LINE - PRIMARY OPERATION FOR SINGLE
    Public Function CSVRedoLine(ByVal Line As String) As String
        On Error Resume Next

        'INSTANTIATE VARIABLES
        Dim unmodline As String = Line
        Dim modline As String = Nothing

        Dim NameFull As String = Nothing
        Dim NameLast As String = Nothing
        Dim NameFirst As String = Nothing
        Dim NameSuff As String = Nothing
        Dim NameFax As String = Nothing
        Dim NameAlias As String = Nothing

        'FIND FAX ADD 1 TO FAX IF OUTSIDE AREA
        Dim rx As New Regex("(?<="").+(?="")")
        NameAlias = rx.Match(Line).Value
        NameFax = Line.Replace(NameAlias, "").Replace("-", "").Replace(" ", "").Replace("""", "").Replace(",", "")

        Dim realnum = System.Text.RegularExpressions.Regex.Replace(NameFax, "[^\d]", " ")
        Dim x = realnum.Trim

        If x.Length > 2 AndAlso (x.StartsWith("713") Or x.StartsWith("281") Or x.StartsWith("832") Or x.StartsWith("979")) Then
        Else
            If x.Length <= 10 Then x = "1" & x.Replace(",", "").Replace("""", "")
        End If

        NameFull = NameAlias.ToUpper.Replace("  ", " ").Replace(", ", ",").Trim


        'FIND LINEAGE
        Dim lineA As String = Nothing
        Dim lineage As String = FindLineage(NameFull)
        If lineage.Contains(":") = True Then
            Dim ln As String() = lineage.Split(":"c)
            NameFull = ln(0)
            lineA = ln(1)
            TxtLineage.Text = lineA
        End If

        'FIND SUFFIX AND GENERALIZE
        For Each Str As String In Suffix
            Dim str4 = Str & ", "
            Dim str5 = Str & ","
            Dim str6 = Str & " "

            Dim Str3 = Str & "."

            Dim str7 = Str3 & ", " '
            Dim str8 = Str3 & ","
            Dim str9 = Str3 & " "

            If NameFull.Contains(Str) Or NameFull.Contains(Str3) Or NameFull.Contains(str4) _
            Or NameFull.Contains(str5) Or NameFull.Contains(str6) Or NameFull.Contains(str7) _
            Or NameFull.Contains(str8) Or NameFull.Contains(str9) Then
                If NameSuff Is Nothing Then

                    NameSuff = Str.Replace(".", "")
                ElseIf NameSuff IsNot Nothing Then
                    NameSuff &= " " & Str.Replace(".", "")
                End If
                NameFull = NameFull.Replace(str7, "")
                NameFull = NameFull.Replace(str8, "")
                NameFull = NameFull.Replace(str9, "")
                NameFull = NameFull.Replace(Str3, "")
                NameFull = NameFull.Replace(str4, "")
                NameFull = NameFull.Replace(str5, "")
                NameFull = NameFull.Replace(str6, "")
                NameFull = NameFull.Replace(Str, "")
            End If


        Next

        For Each Str As String In Prefix
            Dim str2 = Nothing


            Dim str4 = Str & ", "
            Dim str5 = Str & ","
            Dim str6 = Str & " "

            Dim Str3 = Str & "."

            Dim str7 = Str3 & ", "
            Dim str8 = Str3 & ","
            Dim str9 = Str3 & " "

            NameFull = NameFull.Replace(str7, "")
            NameFull = NameFull.Replace(str8, "")
            NameFull = NameFull.Replace(str9, "")
            NameFull = NameFull.Replace(Str3, "")
            NameFull = NameFull.Replace(str4, "")
            NameFull = NameFull.Replace(str5, "")
            NameFull = NameFull.Replace(str6, "")
            NameFull = NameFull.Replace(Str, "")
        Next

        'ACCOUNT FOR NO FAX NUMBER
        If x <> "1" Then TxtFax.Text = x

        'CAPITALIZE FIELDS
        TxtSuff.Text = NameSuff.ToUpper.Trim
        TxtNameFull.Text = NameFull.ToUpper.Trim

        'BREAK NAME UP TO RESPECTIVE TEXTBOX
        Dim NameAry() As String = NameFull.ToUpper.Split(","c)
        If NameAry.Count = 1 Then
            Dim nmtmp = NameAry(0).Replace(" Dr ", " Dr. ")

            Dim nm() As String = nmtmp.Split(" Dr. ")
            TxtLast.Text = nm(0)
            TxtFirst.Text = nm(1)
            If nm.Count = 1 Then
                Dim nm2() As String = nm(0).Split(" "c)
                TxtLast.Text = nm2(0).Trim
                TxtFirst.Text = nm2(1).Trim
            End If
        Else
            TxtLast.Text = NameAry(0).Trim
            TxtFirst.Text = NameAry(1).Trim
        End If

        'REPLACE HYPHENS IN LAST NAME IF CHECKED
        If ChkHyphan.Checked = True Then TxtLast.Text = TxtLast.Text.Replace(" ", "-").Trim
        Dim unameb As String()

        'SPLIT UP FIRST NAME IF MULTIPLE
        If TxtFirst.Text.Contains(" ") Then
            unameb = TxtFirst.Text.Replace("  ", " ").Split(" "c)
        Else
            unameb = TxtFirst.Text.Split(" ")
        End If
        'CREATE USER NAME
        Dim username = unameb(0).ToLower.Replace(".", "").Trim & TxtLast.Text.Replace(" ", "-").ToLower
        TxtUser.Text = username

        'CREATE OUTPUT STRING FOR AFTER TXTBOX
        Dim OP As String = TxtLast.Text & "," & TxtFirst.Text & "," _
        & TxtFax.Text & "," & username & "," & """" & NameAlias & """"
        OP = OP.Replace(", ,", "").Replace("  ", " ").Replace(", ", ",").Replace(",,", "").Replace(", ", ",")

        addaliases(NameAlias, unameb(0))

        If TxtLineage.Text <> "" Then TxtLast.Text &= " " & TxtLineage.Text
        Return OP

    End Function
#End Region

#Region "EXISTING USER SEARCH"
    'SEARCH EXISTING USERS FUNCTION RETURNS BOOLEAN
    Public Function CheckUser(ByVal Uname As String, ByVal FName As String, ByVal LName As String) As Boolean

        Dim TextLines() As String = UserList.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)

        'Dim reader as new StreamReader =  StreamReader(FileName, Encoding.Default)

        Dim found As Boolean = False

        For Each a As String In TextLines

            If a.Contains(Uname) = True Or (a.Contains(FName) = True AndAlso a.Contains(LName) = True) Then
                found = True

            End If
        Next

        Return found

    End Function
#End Region

#Region "ALIAS LISTBOX ROUTINES"

    Private Sub addaliases(ByVal namealias As String, ByVal unameb As String)

        AddLst(namealias)
        If ChkAlias.Checked Then
            AddLst(TxtLast.Text & " " & TxtFirst.Text)
            AddLst(TxtFirst.Text & " " & TxtLast.Text)
            AddLst(TxtLast.Text & "." & TxtFirst.Text)
            AddLst(TxtFirst.Text & "." & TxtLast.Text)

            AddLst("DR. " & TxtLast.Text & " " & TxtFirst.Text)
            AddLst("DR. " & TxtFirst.Text & " " & TxtLast.Text)
            AddLst("DR. " & TxtLast.Text & "." & TxtFirst.Text)
            AddLst("DR. " & TxtFirst.Text & "." & TxtLast.Text)

            AddLst("DR " & TxtLast.Text & " " & TxtFirst.Text)
            AddLst("DR " & TxtFirst.Text & " " & TxtLast.Text)
            AddLst("DR " & TxtLast.Text & "." & TxtFirst.Text)
            AddLst("DR " & TxtFirst.Text & "." & TxtLast.Text)

            AddLst(TxtLast.Text & " " & TxtFirst.Text & " M.D.")
            AddLst(TxtFirst.Text & " " & TxtLast.Text & " M.D.")
            AddLst(TxtLast.Text & "." & TxtFirst.Text & " M.D.")
            AddLst(TxtFirst.Text & "." & TxtLast.Text & " M.D.")

            AddLst("DR " & TxtLast.Text & " " & TxtFirst.Text & " MD")
            AddLst("DR " & TxtFirst.Text & " " & TxtLast.Text & " MD")
            AddLst("DR " & TxtLast.Text & "." & TxtFirst.Text & " MD")
            AddLst("DR " & TxtFirst.Text & "." & TxtLast.Text & " MD")

            AddLst("DR. " & TxtLast.Text & " " & TxtFirst.Text & " MD")
            AddLst("DR. " & TxtFirst.Text & " " & TxtLast.Text & " MD")
            AddLst("DR. " & TxtLast.Text & "." & TxtFirst.Text & " MD")
            AddLst("DR. " & TxtFirst.Text & "." & TxtLast.Text & " MD")

            AddLst(TxtLast.Text & " " & TxtFirst.Text & " MD")
            AddLst(TxtFirst.Text & " " & TxtLast.Text & " MD")
            AddLst(TxtLast.Text & "." & TxtFirst.Text & " MD")
            AddLst(TxtFirst.Text & "." & TxtLast.Text & " MD")

            AddLst("DR " & TxtLast.Text & " " & TxtFirst.Text & " M.D.")
            AddLst("DR " & TxtFirst.Text & " " & TxtLast.Text & " M.D.")
            AddLst("DR " & TxtLast.Text & "." & TxtFirst.Text & " M.D.")
            AddLst("DR " & TxtFirst.Text & "." & TxtLast.Text & " M.D.")

            AddLst("DR. " & TxtLast.Text & " " & TxtFirst.Text & " M.D.")
            AddLst("DR. " & TxtFirst.Text & " " & TxtLast.Text & " M.D.")
            AddLst("DR. " & TxtLast.Text & "." & TxtFirst.Text & " M.D.")
            AddLst("DR. " & TxtFirst.Text & "." & TxtLast.Text & " M.D.")

            AddLst(TxtLast.Text & " " & TxtFirst.Text & " DR.")
            AddLst(TxtLast.Text & " " & TxtFirst.Text & " DR")

            AddLst(TxtLast.Text & " " & TxtFirst.Text & " MD.")
            AddLst(TxtFirst.Text & " " & TxtLast.Text & " MD.")
            AddLst(TxtLast.Text & "." & TxtFirst.Text & " MD.")
            AddLst(TxtFirst.Text & "." & TxtLast.Text & " MD.")

            AddLst(TxtLast.Text & ", " & TxtFirst.Text)
            AddLst(TxtFirst.Text & ", " & TxtLast.Text)




            'BEGIN ALIASES FOR LINEAGE


            If TxtLineage.Text <> "" Then
                Dim ln As String = TxtLineage.Text

                AddLst(AdLn(TxtLast.Text) & ", " & TxtFirst.Text)
                AddLst(TxtFirst.Text & ", " & AdLn(TxtLast.Text))
                AddLst(unameb.ToUpper.Trim & "," & AdLn(TxtLast.Text))
                AddLst(unameb.ToUpper.Trim & ", " & AdLn(TxtLast.Text))
                AddLst(AdLn(TxtLast.Text) & "," & unameb.ToUpper.Trim)
                AddLst(AdLn(TxtLast.Text) & ", " & unameb.ToUpper.Trim)

                AddLst("DR " & AdLn(TxtLast.Text) & "," & unameb.ToUpper.Trim)
                AddLst("DR. " & AdLn(TxtLast.Text) & ", " & unameb.ToUpper.Trim)
                AddLst("DR " & unameb.ToUpper.Trim & "," & AdLn(TxtLast.Text))
                AddLst("DR. " & unameb.ToUpper.Trim & ", " & AdLn(TxtLast.Text))
                If (TxtSuff.Text <> "") Then AddLst(AdLn(TxtLast.Text) & ", " & unameb.ToUpper.Trim & "." & TxtSuff.Text.Trim.ToUpper)
                If (TxtSuff.Text <> "") Then AddLst(AdLn(TxtLast.Text) & ", " & TxtFirst.Text.ToUpper & "." & TxtSuff.Text.Trim.ToUpper)
                If (TxtSuff.Text <> "") Then AddLst("DR " & AdLn(TxtLast.Text) & "," & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)
                If (TxtSuff.Text <> "") Then AddLst("DR. " & AdLn(TxtLast.Text) & ", " & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)
                AddLst(unameb.ToUpper.Trim & " " & AdLn(TxtLast.Text.ToUpper))
                If (TxtSuff.Text <> "") Then AddLst(unameb.ToUpper.Trim & " " & AdLn(TxtLast.Text.ToUpper) & " " & TxtSuff.Text.Trim.ToUpper)
                AddLst("DR " & unameb.ToUpper.Trim & " " & AdLn(TxtLast.Text.ToUpper))
                AddLst("DR. " & unameb.ToUpper.Trim & " " & AdLn(TxtLast.Text.ToUpper))
                If (TxtSuff.Text <> "") Then AddLst("DR " & unameb.ToUpper.Trim & " " & AdLn(TxtLast.Text.ToUpper) & " " & TxtSuff.Text.Trim.ToUpper)
                If (TxtSuff.Text <> "") Then AddLst("DR. " & unameb.ToUpper.Trim & " " & AdLn(TxtLast.Text.ToUpper) & " " & TxtSuff.Text.Trim.ToUpper)

                'ADD MORE ALIAS
                If (TxtSuff.Text <> "") Then AddLst("DR " & unameb.ToUpper.Trim & "," & AdLn(TxtLast.Text) & " " & TxtSuff.Text.Trim.ToUpper)
                If (TxtSuff.Text <> "") Then AddLst("DR. " & unameb.ToUpper.Trim & ", " & AdLn(TxtLast.Text) & " " & TxtSuff.Text.Trim.ToUpper)
                AddLst(TxtLast.Text.ToUpper & " " & unameb.ToUpper.Trim)
                If (TxtSuff.Text <> "") Then AddLst(AdLn(TxtLast.Text.ToUpper) & " " & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)
                AddLst("DR " & AdLn(TxtLast.Text.ToUpper) & " " & unameb.ToUpper.Trim)
                AddLst("DR. " & AdLn(TxtLast.Text.ToUpper) & " " & unameb.ToUpper.Trim)
                If (TxtSuff.Text <> "") Then AddLst("DR " & AdLn(TxtLast.Text.ToUpper) & " " & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)
                If (TxtSuff.Text <> "") Then AddLst("DR. " & AdLn(TxtLast.Text.ToUpper) & " " & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)


            End If
            'END LINEAGE ALIASES

            'ADD MD FOR THE HELL OF IT TO ALIAS iF NO SUFFIX
            If TxtSuff.Text.Length < 2 Then
                AddLst(TxtLast.Text & ", " & TxtFirst.Text & " MD")
                AddLst(TxtLast.Text & ", " & TxtFirst.Text & " M.D.")
                AddLst(TxtFirst.Text & ", " & TxtLast.Text & " M.D.")
                AddLst(TxtFirst.Text & ", " & TxtLast.Text & " MD")
                AddLst(unameb.ToUpper.Trim & "," & TxtLast.Text)
                AddLst(unameb.ToUpper.Trim & ", " & TxtLast.Text)
                AddLst(TxtLast.Text & "," & unameb.ToUpper.Trim)
                AddLst(TxtLast.Text & ", " & unameb.ToUpper.Trim)
            End If

            'Add DR. Type Abbreviation to Name
            AddLst("DR " & TxtLast.Text & "," & unameb.ToUpper.Trim)
            AddLst("DR. " & TxtLast.Text & ", " & unameb.ToUpper.Trim)
            AddLst("DR " & unameb.ToUpper.Trim & "," & TxtLast.Text)
            AddLst("DR. " & unameb.ToUpper.Trim & ", " & TxtLast.Text)

            'If Suffix Found Add to List with Multiples
            If (TxtSuff.Text <> "") Then AddLst(TxtLast.Text & ", " & unameb.ToUpper.Trim & "." & TxtSuff.Text.Trim.ToUpper)
            If (TxtSuff.Text <> "") Then AddLst(TxtLast.Text & ", " & TxtFirst.Text.ToUpper & "." & TxtSuff.Text.Trim.ToUpper)
            If (TxtSuff.Text <> "") Then AddLst("DR " & TxtLast.Text & "," & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)
            If (TxtSuff.Text <> "") Then AddLst("DR. " & TxtLast.Text & ", " & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)
            AddLst(unameb.ToUpper.Trim & " " & TxtLast.Text.ToUpper)
            If (TxtSuff.Text <> "") Then AddLst(unameb.ToUpper.Trim & " " & TxtLast.Text.ToUpper & " " & TxtSuff.Text.Trim.ToUpper)
            AddLst("DR " & unameb.ToUpper.Trim & " " & TxtLast.Text.ToUpper)
            AddLst("DR. " & unameb.ToUpper.Trim & " " & TxtLast.Text.ToUpper)
            If (TxtSuff.Text <> "") Then AddLst("DR " & unameb.ToUpper.Trim & " " & TxtLast.Text.ToUpper & " " & TxtSuff.Text.Trim.ToUpper)
            If (TxtSuff.Text <> "") Then AddLst("DR. " & unameb.ToUpper.Trim & " " & TxtLast.Text.ToUpper & " " & TxtSuff.Text.Trim.ToUpper)

            If (TxtSuff.Text <> "") Then AddLst("DR " & unameb.ToUpper.Trim & "," & TxtLast.Text & " " & TxtSuff.Text.Trim.ToUpper)
            If (TxtSuff.Text <> "") Then AddLst("DR. " & unameb.ToUpper.Trim & ", " & TxtLast.Text & " " & TxtSuff.Text.Trim.ToUpper)
            AddLst(TxtLast.Text.ToUpper & " " & unameb.ToUpper.Trim)
            If (TxtSuff.Text <> "") Then AddLst(TxtLast.Text.ToUpper & " " & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)
            AddLst("DR " & TxtLast.Text.ToUpper & " " & unameb.ToUpper.Trim)
            AddLst("DR. " & TxtLast.Text.ToUpper & " " & unameb.ToUpper.Trim)
            If (TxtSuff.Text <> "") Then AddLst("DR " & TxtLast.Text.ToUpper & " " & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)
            If (TxtSuff.Text <> "") Then AddLst("DR. " & TxtLast.Text.ToUpper & " " & unameb.ToUpper.Trim & " " & TxtSuff.Text.Trim.ToUpper)

        End If


        'IF GENERIC DOCTOR THEN ADD THOSE ALIAS
        If TxtFirst.Text = "DOCTOR" Then
            Dim LaN As String = TxtLast.Text
            AddLst("DR," & LaN)
            AddLst(LaN & ",DR")
            AddLst(LaN & ",")
            AddLst("," & LaN)
            AddLst("DR, " & LaN)
            AddLst(LaN & ", DR")
            AddLst(", " & LaN)
        End If

        CleanAli()
    End Sub
    'Run Through Alias Listbox and Remove Duplicates
    Private Sub CleanAli()
        Dim newList As List(Of String) = New List(Of String)()
        Dim itemsToRemove As List(Of String) = New List(Of String)()

        'For Each itm As String In LstAliases.Items
        '    If itm.ToUpper.Contains("DR ") Or itm.ToUpper.Contains("DR. ") Then
        '        Dim newone As String = itm.ToUpper.Replace("DR ", "").Replace("DR. ", "")
        '        If LstAliases.Items.Contains(newone) = False Then LstAliases.Items.Add(newone)
        '    End If


        'Next

        For Each item As String In LstAliases.Items
            If newList.Contains(item) Then
                itemsToRemove.Add(item)
            Else
                newList.Add(item)
            End If
        Next

        For Each item As String In itemsToRemove
            LstAliases.Items.Remove(item)
        Next
    End Sub
    'Add Alias to List and Create Duplicates with Likeness
    Public Sub AddLst(ByVal str)
        If str.TOUPPER.CONTAINS("DOCTOR") = False Then

            Dim found As Boolean = False

            If (LstAliases.Items.Count > 0) Then
                For Each st As String In LstAliases.Items
                    If st = str.trim Then
                        found = True
                    End If
                Next
            End If

            If Not found Then
                LstAliases.Items.Add(str.trim)
            End If

            If str.contains("-") = True AndAlso str.contains(".") = False Then

                Dim nstr = str.replace("-", " ").trim
                Dim found2 As Boolean = False
                For Each st As String In LstAliases.Items
                    If st.Trim = nstr.trim Then
                        found2 = True
                    End If
                Next

                If found2 = False Then AddLst(nstr.trim)
            ElseIf (str.contains(".") = True AndAlso str.contains("-") = False) Then

                Dim nstr = str.replace(".", " ").trim
                Dim found2 As Boolean = False
                For Each st As String In LstAliases.Items
                    If st.Trim = nstr.trim Then
                        found2 = True
                    End If
                Next

                If found2 = False Then AddLst(nstr.trim)
            End If
        End If
    End Sub
    'CYCLE THROUGH LISTBOX ALIASES AND CLEAN
    Public Sub CycAlias()
        For Each Str As String In LstAliases.Items
            ClpTxt(Str)
        Next
    End Sub
#End Region

#Region "PROCESS LINE ORGANIZING - SINGLE"
    'MAIN ORG ROUTINE FOR SINGLE RUN
    Public Sub DoSingle()
        fixpre()
        continueLooping = True
        'Dim thread as New Thread(
        '  Sub() 
        '        Console.WriteLine("Hullo")
        '    End Sub
        ')
        'thread.Start()
        'While (continueLooping)
        'TxtAfter.Clear()
        TxtFax.Clear()
        TxtFirst.Clear()
        TxtLast.Clear()
        TxtMiddle.Clear()
        TxtNameFull.Clear()
        TxtSuff.Clear()
        TxtLineage.Clear()

        LstAliases.Items.Clear()
        Dim b As String() = Split(TxtGroup.Text, vbNewLine)
        Dim realnum = System.Text.RegularExpressions.Regex.Replace(b(0), "[^\d]", " ")
        Dim x = realnum.Trim
        Dim apstr = b(0).Replace("  ", " ".Replace("," & x, "").Replace(", " & x, ""))

        If continueLooping AndAlso ChkPeriod.Checked Then CSVRedoBefore(AdPer(b(0)) & "," & x) Else CSVRedoBefore(b(0)) 'AdPer(b(0)) & "," & x)


        If continueLooping Then TxtGroup.Text = String.Join(vbNewLine, b, 1, b.Length - 1)


        If ChkAuto.Checked Then
            If ChkExisting.Checked AndAlso doit = True Then AutoM()

            If ChkExisting.Checked = False Then AutoM()

        End If
        'End While

        If keepgoing Then
            If TxtGroup.Text.Split(nl).Count > 1 Then
                FrmStop.Show()
                TmrDoAll.Start()
            Else
                keepgoing = False
            End If

        End If
    End Sub
#End Region

#Region "EXECUTION OF SCRIPTS AND EXTERNAL EXE"
    'SPECIFIES COPY FIELD TO RUN INSTANCE
    Public Sub AutoM()
        'CLICK ADD AND BASIC
        If continueLooping = True Then runs(0)
        'INPUT USERNAME
        If continueLooping = True Then runs(1, TxtUser.Text)
        'INPUT FIRST NAME
        If continueLooping = True Then runs(2, TxtFirst.Text)
        'INPUT LAST NAME
        If continueLooping = True Then runs(3, TxtLast.Text)
        'FOR EACH ALIAS ADD ALIAS SCRIPT
        For Each Str As String In LstAliases.Items
            If continueLooping = True Then runs(4, Str)
        Next
        'CREATE USER IN RIS
        If continueLooping = True Then runs(5, TxtFax.Text)
        'INPUT FAX IF EXIST
        If continueLooping = True Then runs(6, TxtFax.Text, TxtUser.Text)
        'FINALIZE IF CREATED RIS AND WAITS IF EXIST
        If continueLooping = True Then runs(7)
        'continueLooping = True
    End Sub
    'ORGANIZES SCRIPT EXECUTION
    Public Sub runs(ByVal bit As String, Optional ByVal CpyStr As String = Nothing, Optional ByVal un As String = Nothing)
        Dim sdir = ad & "scripts\"
        Dim sk As String = Nothing
        Dim del As String = Nothing
        If CpyStr IsNot Nothing Then ClpTxt(CpyStr)
        Select Case bit
            Case 0
                sk = "0_OPEN_ADD_USER.ahk"
            Case 1
                sk = "1_USER_NAME_PASS.ahk"
            Case 2
                sk = "2_USER_FIRST.ahk"
            Case 3
                sk = "3_USER_LAST_PERMISSIONS.ahk"
            Case 4
                sk = "4_USER_ALIASES.ahk"
            Case 5

                sk = "5_RIS_INFO.ahk"
            Case 6
                If CpyStr.Length < 6 Then sk = "6_RIS_SPEC_NOFAX" Else sk = "6_RIS_SPEC"
                Dim bf = sdir & sk
                Dim uf = bf & "_" & un & ".ahk"
                If File.Exists(bf) = False Then
                    Dim tfil = File.ReadAllText(bf & ".ahk")
                    File.WriteAllText(uf, tfil.Replace("*USER*", un))
                End If
                sk = uf.Replace(sdir, "")
                del = uf
            Case 7
                sk = "7_FINISH.ahk"
            Case "DEL"
                sk = "DEL_ALIAS.ahk"
        End Select


        'Create a new ProcessStartInfo structure.
        Dim pInfo As New ProcessStartInfo()
        'Set the file name member of pinfo to Eula.txt in the system folder.
        pInfo.FileName = sdir & sk
        'Start the process.
        'Dim p As Process
        p = Process.Start(pInfo)
        'Wait for the process window to complete loading.
        'p.WaitForInputIdle()

        'Wait for the process to exit.
        p.WaitForExit(7500)
        killah()

        Threading.Thread.Sleep(250)
        If bit <> "DEL" Then
            If bit = 6 And del IsNot Nothing Then

                Threading.Thread.Sleep(150)
                File.Delete(del)
            End If
        End If


    End Sub
    'KILLS AUTOHOTKEY
    Public Sub killah()
        On Error Resume Next
        For Each proc As Process In Process.GetProcessesByName("autohotkey")

            proc.Kill()

        Next
    End Sub
    'OPEN URL WITH IE
    Public Sub GoIE(ByVal URL)
        Process.Start("C:\Program Files\" & "Internet Explorer\iexplore.exe", URL)
    End Sub
    'LOGIN TO NR ADMIN
    Private Sub NovaL(ByVal kind As String)

        If kind <> "ris" Then
            mineonce("clickoncerun")
            mineonce(kind)
        End If


        GoIE(kind & ".mrahouston.com")
    End Sub
    'RUN APP ONLY ONCE
    Public Function mineonce(ByVal program) As Boolean
        'Dim CurrentSessionID As Integer = Process.GetCurrentProcess.SessionId
        Dim prc() As Process = Process.GetProcessesByName(program)
        If Not prc Is Nothing AndAlso Not prc.Length = 0 Then
            For Each proc As Process In Process.GetProcessesByName(program)
                If proc.SessionId = CurrentSessionID Then
                    Exit For
                Else
                    Try
                        Process.Start(ad & "\" & program & ".exe")
                    Catch ex As Exception
                        'MsgBox(ex.Message & Environment.NewLine & "You are missing vital files, you must be logged into the workstation you are at and launch SSO to create these files.", MsgBoxStyle.Information, "Sorry")
                    End Try
                    Exit For
                End If
            Next
        Else
            Try
                Process.Start(ad & "\" & program & ".exe")
            Catch ex As Exception
                'MsgBox(ex.Message & Environment.NewLine & "You are missing vital files, you must be logged into the workstation you are at and launch SSO to create these files.", MsgBoxStyle.Information, "Sorry")
            End Try
        End If
    End Function
#End Region

#Region "INTERFACE ROUTINES AND RELATED"
    'SAVE CURRENT WORK
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        File.WriteAllText(ad & "OP.CSV", TxtAfter.Text)
    End Sub

    'Click All Button
    Private Sub BtnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnALL.Click
        keepgoing = True
        DoSingle()

        'fixpre()

        'continueLooping = True
        ''CSVRedoBefore(TxtGroup.Text)
        ''While continueLooping
        ''If ChkAuto.Checked = True Then
        'Dim b() As String = TxtGroup.Text.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)



        'For Each a As String In b
        '    'If continueLooping = True Then

        '    'TxtFax.Clear()
        '    'TxtFirst.Clear()
        '    'TxtLast.Clear()
        '    'TxtMiddle.Clear()
        '    'TxtNameFull.Clear()
        '    'TxtSuff.Clear()
        '    'LstAliases.Items.Clear()
        '    ''TxtGroup.Text = TxtGroup.Text
        '    ''Dim b As String() = Split(TxtGroup.Text, vbNewLine)
        '    'TxtAfter.Text &= CSVRedoLine(a)

        '    '' TxtGroup.Text = String.Join(vbNewLine, b, 1, b.Length - 1)



        '    'If ChkAuto.Checked AndAlso doit = True Then

        '    '    AutoM()

        '    'End If

        '    DoSingle()



        'Next
        ''Else


        ''    TxtFax.Clear()
        ''    TxtFirst.Clear()
        ''    TxtLast.Clear()
        ''    TxtMiddle.Clear()
        ''    TxtNameFull.Clear()
        ''    TxtSuff.Clear()
        ''    LstAliases.Items.Clear()

        ''    Dim b As String() = Split(TxtGroup.Text, vbNewLine)
        ''    For Each a As String In b
        ''        CSVRedoBefore(b(0))
        ''    Next

        ''    TxtGroup.Text = String.Join(vbNewLine, b, 1, b.Length - 1)


        ''End If

        ' ''End While

        ''continueLooping = True

        ''FrmStop.Close()
        ''fixpre()
        ' ''continueLooping = True
        ' ''Dim thread as New Thread(
        ' ''  Sub() 
        ' ''        Console.WriteLine("Hullo")
        ' ''    End Sub
        ' '')
        ' ''thread.Start()
        ' ''While (continueLooping)
        ' ''TxtAfter.Clear()
        ''TxtFax.Clear()
        ''TxtFirst.Clear()
        ''TxtLast.Clear()
        ''TxtMiddle.Clear()
        ''TxtNameFull.Clear()
        ''TxtSuff.Clear()
        ''LstAliases.Items.Clear()
        ''Dim b As String() = Split(TxtGroup.Text, vbNewLine)

        ''For Each str As String In b
        ''    CSVRedoBefore(str)

        ''    Try
        ''        TxtGroup.Text = TxtGroup.Text.Replace(str, "").Trim
        ''    Catch

        ''    End Try

        ''    If ChkAuto.Checked AndAlso doit = True Then

        ''        AutoM()

        '    End If
        'Next



        ''End While
        'continueLooping = True

    End Sub

    'PROCESS SINGLE LINE
    Private Sub BtnSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSingle.Click
        If keepgoing Then
            TmrDoAll.Stop()
            keepgoing = False
        Else
            keepgoing = False
            DoSingle()
        End If

    End Sub

    'SAVE CUR WORK
    Private Sub BtnSaveWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveWork.Click
        File.WriteAllText(curwrk, TxtGroup.Text)
    End Sub

    'OPEN RUN DIR
    Private Sub BtnDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDir.Click
        Process.Start("explorer", ad)
    End Sub

    'OPEN ADMIN CONSOLE
    Private Sub BtnOpenAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenAD.Click
        NovaL("admin")
    End Sub

    'COPY TXTFIRST TO CLP
    Private Sub TxtFirst_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUser.DoubleClick, TxtSuff.DoubleClick, TxtNameFull.DoubleClick, TxtMiddle.DoubleClick, TxtLast.DoubleClick, TxtFirst.DoubleClick, TxtFax.DoubleClick
        Dim TB As TextBox

        TB = CType(sender, TextBox)

        ClpTxt(TB.Text)
    End Sub

    'COPY SELECTED ALIAS TO LIST
    Private Sub LstAliases_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstAliases.MouseDoubleClick
        ClpTxt(LstAliases.SelectedItem)
    End Sub

    'AUTOMATION BUTTON
    Private Sub BtnAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAuto.Click
        continueLooping = True
        'FRMSTOP.SHOW()

        'While continueLooping
        For Each Str As String In LstAliases.Items
            runs(4, Str)
        Next
        'End While
        continueLooping = True
    End Sub

    'RIGHT CLICK REMOVE ALIAS
    Private Sub LstAliases_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LstAliases.MouseDown
        If e.Button = MouseButtons.Right Then
            If LstAliases.SelectedIndex > -1 Then
                LstAliases.Items.RemoveAt(LstAliases.SelectedIndex)
            End If
        End If

    End Sub

    'REVERT TO LAST SAVE IN TXTGROUP
    Private Sub BtnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReload.Click
        loadrec()

    End Sub

    'PASTE NEW LINE TO TOP OF TXTGROUP
    Private Sub BtnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPaste.Click
        Dim nt As String

Goagain:

        Try

            nt = Windows.Forms.Clipboard.GetText

        Catch ex As Exception
            GoTo Goagain
        End Try
        Dim CT As String = TxtGroup.Text.Replace(nl, "")
        If CT <> "" Then nt &= nl
        TxtGroup.Text = nt & TxtGroup.Text
    End Sub

    'COPY FIRST LINE TO CLIPBOARD
    Private Sub BtnCopyFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopyFirst.Click
        'GET FIRST LINE OF TXTGROUP TO CLIP
        Dim lines As String() = TxtGroup.Text.Split(nl.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
        Dim firstLine As String = lines.First ' lines.FirstOrDefault
        Dim lastLine As String = lines.Last ' lines.LastOrDefault
        ClpTxt(firstLine)
    End Sub
#End Region

    Private Sub TmrDoAll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrDoAll.Tick
        FrmStop.Close()


        TmrDoAll.Stop()
        If keepgoing = True Then DoSingle()

    End Sub

    Private Sub BtnAliasDEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAliasDEL.Click
        Dim i As Integer = TxtDelAliasNum.Text

        Do Until i = 0
            i = i - 1
            runs("DEL")
        Loop

        TxtDelAliasNum.Text = 0
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
