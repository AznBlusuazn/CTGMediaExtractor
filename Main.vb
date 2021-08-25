Public Class Main
    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Init.Initialization()
    End Sub
    Private Sub MainClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Action.ExitApp()
    End Sub
    Private Sub TypeDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeDrop.SelectedIndexChanged
        Action.TypeDropChange(TypeDrop.SelectedIndex)
    End Sub
    Private Sub GetButton_Click(sender As Object, e As EventArgs) Handles GetButton.Click
        Action.GetTitle(URLText.Text)
    End Sub
    Private Sub NameCheck_CheckedChanged(sender As Object, e As EventArgs) Handles NameCheck.CheckedChanged
        Action.NameCheckChange(NameCheck, FileText)
    End Sub
    Private Sub TextBoxes_TextChanged(sender As Object, e As EventArgs) Handles URLText.TextChanged,
        FileText.TextChanged, FolderText.TextChanged
        Action.TextBoxesCheck(URLText, FileText, AddButton)
        Action.CheckGo(JobList, FolderText, GoButton)
    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Action.AddButton(TypeDrop, ExtDrop, URLText, FileText, NameCheck, JobList)
        Action.CheckList(JobList, AddButton, RemoveButton)
        Action.CheckGo(JobList, FolderText, GoButton)
    End Sub
    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Action.RemoveButton(JobList)
        Action.CheckList(JobList, AddButton, RemoveButton)
        Action.CheckGo(JobList, FolderText, GoButton)
    End Sub
    Private Sub DirButton_Click(sender As Object, e As EventArgs) Handles DirButton.Click
        Action.SelectPath()
    End Sub
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Action.GoButton(JobList)
    End Sub
    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Action.StartOver()
    End Sub
    Private Sub CRLabel_Click(sender As Object, e As EventArgs) Handles CRLabel.Click
        Process.Start(Mem.Mail)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim Message As String = "This application was created by ClarkTribeGames LLC." & vbCrLf &
                                vbCrLf &
                                "The purpose was to create an application that made the" & vbCrLf &
                                "conversions of online videos to local media easier." & vbCrLf &
                                vbCrLf &
                                "If you found this application useful, please consider" & vbCrLf &
                                "a Donation or Patreon contribution.  Thank you!" & vbCrLf &
                                vbCrLf &
                                "- Geoff @ ClarkTribeGames"
        MsgBox(Message, vbOKOnly + vbInformation)
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        If Updater.Checker(Mem.Current, Mem.Available) = True Then
            Dim Answer As Integer = MsgBox("Update " & Mem.Available & " Available!" & vbCrLf & vbCrLf & "Would you like to update now?", vbYesNo + vbExclamation)
            If Answer = vbYes Then Updater.InstallUpdate() Else MsgBox("Please update as soon as possible!")
        Else
            MsgBox("No Update Available!")
        End If
    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        Process.Start(Mem.PP)
    End Sub

    Private Sub PatreonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatreonToolStripMenuItem.Click
        Process.Start(Mem.PT)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim answer As Integer
        answer = MsgBox("Are you sure you want to Exit?", vbYesNo + vbExclamation)
        If answer = vbYes Then Action.ExitApp()
    End Sub
End Class
