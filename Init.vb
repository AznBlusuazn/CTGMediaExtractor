Public Class Init
    Public Shared Sub Initialization()
        InitFile()
        InitDrops()
        InitLabels()
        InitRich()
    End Sub
    Private Shared Sub InitFile()
        CTGVidX.VidX.Prep()
        Mem.UpdaterD = ClarkTribeGames.MySQLReader.Query(LCase(Mem.Updater).Replace(".exe", ""), "d")
        Action.UpdaterCheck()
    End Sub
    Private Shared Sub InitDrops()
        Main.TypeDrop.Items.Clear()
        For Each type In Mem.AV
            Main.TypeDrop.Items.Add(type)
        Next
        Main.ExtDrop.Items.Clear()
        Main.TypeDrop.SelectedIndex = 0
    End Sub
    Private Shared Sub InitRich()
        Main.LogBox.Text = Main.AppLabel.Text & Main.VerLabel.Text & " Starting..."
    End Sub
    Private Shared Sub InitLabels()
        Dim Title As String = Application.ProductName
        Main.Text = Title
        Main.Icon = My.Resources.logo
        Main.AppLabel.Text = Title & " v"
        Mem.Current = ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
        Main.VerLabel.Text = Mem.Current
        Mem.Available = ClarkTribeGames.MySQLReader.Query(LCase(Mem.Updater).Replace(".exe", ""), "v")
        Mem.UpdaterU = ClarkTribeGames.MySQLReader.Query(LCase(Mem.Updater).Replace(".exe", ""), "u")
        Action.VersionCheck()
    End Sub
End Class
