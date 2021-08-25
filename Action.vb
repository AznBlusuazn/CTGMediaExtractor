Public Class Action
    Private Shared Sub Extract(code As String, urls() As String, filename As String, ext As String, switch As Boolean)
        For Each url In urls
            Dim Thread1 As New System.Threading.Thread(Sub()
                                                           CTGVidX.VidX.Extract(code, url, filename, ext, switch)
                                                           For i = 0 To 100000
                                                               If Not System.IO.File.Exists(filename) Then System.Threading.Thread.
                                                                Sleep(1) Else i = 100000
                                                           Next
                                                       End Sub)
            With Thread1
                .IsBackground = True
                .Start()
            End With
        Next
    End Sub
    Public Shared Sub TypeDropChange(converttype As Integer)
        Main.ExtDrop.Enabled = True
        Main.ExtDrop.Items.Clear()
        Select Case converttype
            Case 0
                For Each ext In Mem.AT
                    Main.ExtDrop.Items.Add(ext)
                Next
                Main.ExtDrop.SelectedIndex = 0
            Case 1
                For Each ext In Mem.VT
                    Main.ExtDrop.Items.Add(ext)
                Next
                Main.ExtDrop.SelectedIndex = 0
            Case Else
                Main.ExtDrop.Items.Clear()
                Main.ExtDrop.Enabled = False
        End Select
    End Sub
    Public Shared Sub GetTitle(url As String)
        Main.FileText.Text = ExtractTitle(url)
    End Sub
    Private Shared Function ExtractTitle(url As String) As String
        Dim FoundName As String
        Try
            FoundName = System.Text.RegularExpressions.Regex.
            Replace(System.Text.RegularExpressions.Regex.Replace(CTGVidX.
            VidX.TitleOnly(url), "[^a-zA-Z0-9 ]", ""), " {2,}", " ")
        Catch ex As Exception
            FoundName = ""
        End Try
        Return FoundName
    End Function

    Public Shared Sub NameCheckChange(checkbox As CheckBox, filename As TextBox)
        Select Case checkbox.CheckState
            Case CheckState.Checked
                filename.Text = Mem.OGVid
                filename.Enabled = False
            Case Else
                If filename.Text = Mem.OGVid Then filename.Text = ""
                filename.Enabled = True
        End Select
    End Sub
    Public Shared Sub TextBoxesCheck(urltext As TextBox, filetext As TextBox, button As Button)
        If urltext.TextLength > 0 And filetext.TextLength > 0 Then button.Enabled = True Else button.Enabled = False
    End Sub

    Public Shared Sub AddButton(typedrop As ComboBox, extdrop As ComboBox, urltext As TextBox, filetext As TextBox,
        checkbox As CheckBox, listbox As ListBox)
        Dim Log As String = "Extract "
        Select Case (typedrop.SelectedIndex)
            Case 0
                Log &= "Audio > "
            Case 1
                Log &= "Video > "
        End Select
        Log &= UCase(extdrop.Text.Substring(1)) & " File > " & urltext.Text & " > "
        Select Case (filetext.Text)
            Case Mem.OGVid
                Log &= "Default Video Name"
            Case Else
                Log &= filetext.Text
        End Select
        If listbox.Items.Cast(Of String)().Contains(Log) Then
            MessageBox.Show("You already have this file in queue!")
        Else
            listbox.Items.Add(Log)
            ClearFields()
        End If
    End Sub
    Private Shared Sub ClearFields()
        Main.TypeDrop.SelectedIndex = 0
        Main.URLText.Text = ""
        Main.NameCheck.CheckState = CheckState.Unchecked
        Main.NameCheck.CheckState = CheckState.Checked
        CheckList(Main.JobList, Main.AddButton, Main.RemoveButton)
    End Sub
    Public Shared Sub CheckList(listbox As ListBox, add As Button, remove As Button)
        If listbox.Items.Count > 9 Then add.Enabled = False Else add.Enabled = True
        If listbox.Items.Count = 0 Then remove.Enabled = False Else remove.Enabled = True
    End Sub
    Public Shared Sub RemoveButton(listbox As ListBox)
        If listbox.SelectedItem IsNot Nothing Then
            Dim Answer As Integer = MsgBox("Are you sure you want to delete this item?", vbYesNo)
            If Answer = vbYes Then listbox.Items.Remove(listbox.SelectedItem) Else MsgBox("Action Cancelled!")
        Else
            MsgBox("Please select an item to remove first!")
        End If
    End Sub
    Public Shared Sub SelectPath()
        Dim FilePath As String = GetPath()
        If FilePath = "" Then MsgBox("Something went wrong, try again!") Else Main.FolderText.Text = FilePath
    End Sub
    Private Shared Function GetPath()
        Dim folderBrowser As New OpenFileDialog With {
            .ValidateNames = False,
            .CheckFileExists = False,
            .CheckPathExists = True,
            .Title = "Select Save To Folder",
            .FileName = "Use This Folder"
        }
        If folderBrowser.ShowDialog() = DialogResult.OK Then Return System.IO.Path.
            GetDirectoryName(folderBrowser.FileName) Else Return ""
    End Function
    Public Shared Sub CheckGo(listbox As ListBox, dirtext As TextBox, go As Button)
        If listbox.Items.Count > 0 And System.IO.Directory.Exists(dirtext.Text) Then go.Enabled = True Else go.Enabled = False
    End Sub
    Public Shared Sub GoButton(listbox As ListBox)
        FlipAll(False)
        Dim FileName As String = ""
        For ListIndex As Integer = 0 To listbox.Items.Count - 1
            Dim ListParts() As String = CStr(listbox.Items(ListIndex)).Split(">")
            Dim ItemCode As String = LCase(ListParts(0).Replace("Extract ", "")) & "." &
                LCase(ListParts(1).Replace(" File", ""))
            Dim DestName As String, DestFolder As String = Main.FolderText.Text & "\"
            If ListParts(3).Substring(1) = "Default Video Name" Or ListParts(3).Substring(1) = "" Then DestName =
                ExtractTitle(ListParts(2)) Else DestName = ListParts(3).Substring(1)
            ItemCode = ItemCode.Replace(" ", "")
            FileName = DestFolder & DestName & "." & ItemCode.Split(".")(1)
            Dim BackStatus As Boolean
            If Main.BackCheck.CheckState = CheckState.Checked Then BackStatus = True Else BackStatus = False
            Try
                Extract(ItemCode, {ListParts(2).Substring(1).Replace(" ", "")}, FileName, LCase(ListParts(1).Replace(" File", "")).Replace(" ", ""), BackStatus)
            Catch ex As Exception
                MsgBox("Something went wrong with Item #" & CStr(ListIndex + 1))
                AddToRich(Main.LogBox, (FileName.Replace(DestFolder, "") & " NOT created!  Something went wrong."))
            End Try
            Do While Not System.IO.File.Exists(FileName)
                System.Threading.Thread.Sleep(1)
            Loop
            AddToRich(Main.LogBox, (FileName.Replace(DestFolder, "") & " created!"))
        Next
        System.Threading.Thread.Sleep(1000)
        AddToRich(Main.LogBox, "Tasks Complete!")
    End Sub
    Private Shared Sub AddToRich(textbox As RichTextBox, text As String)
        textbox.Text = textbox.Text & vbCrLf & text
    End Sub
    Public Shared Function VersionConverter(versionpart As String, digits As Integer) As String
        Dim PartLength As Integer = Len(versionpart)
        Select Case PartLength
            Case digits - 1
                VersionConverter = "0" + versionpart
            Case digits - 2
                VersionConverter = "00" + versionpart
            Case digits - 3
                VersionConverter = "000" + versionpart
            Case digits - 4
                VersionConverter = "0000" + versionpart
            Case Else
                VersionConverter = versionpart
        End Select
    End Function
    Private Shared Sub FlipAll(action As Boolean)
        Main.TypeDrop.Enabled = action
        Main.ExtDrop.Enabled = action
        Main.URLText.Enabled = action
        Main.NameCheck.Enabled = action
        Main.FileText.Enabled = action
        Main.JobList.Enabled = action
        Main.GetButton.Enabled = action
        Main.AddButton.Enabled = action
        Main.RemoveButton.Enabled = action
        Main.FolderText.Enabled = action
        Main.DirButton.Enabled = action
        Main.GoButton.Enabled = action
    End Sub
    Public Shared Sub StartOver()
        Main.JobList.Items.Clear()
        Main.FolderText.Text = ""
        FlipAll(True)
        ClearFields()
    End Sub
    Public Shared Sub ExitApp()
        CTGVidX.VidX.Finished()
        GC.Collect()
        Main.Dispose()
        Main.Close()
    End Sub
End Class
