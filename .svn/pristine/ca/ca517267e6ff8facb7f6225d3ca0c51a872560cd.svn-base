Public NotInheritable Class FrmStop

    Private Sub FrmStop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        'Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.Left = 25
        Me.Top = My.Computer.Screen.WorkingArea.Height - Me.Height - (Me.Height / 4)
    End Sub



    Private Sub BtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStop.Click
        On Error Resume Next
        FrmMain.keepgoing = False
        FrmMain.TmrDoAll.Stop()
        FrmMain.keepgoing = False

        FrmMain.continueLooping = False
        FrmMain.p.Kill()

        For Each pr As Process In Process.GetProcessesByName("AutoHotkey")
            pr.Kill()
        Next


        'FrmMain.TmrAliasOn.Stop()

        FrmMain.Show()
        FrmMain.Focus()

        Me.Close()
    End Sub
End Class
