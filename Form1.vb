Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text


Public Class Form1
    Dim startzeit As New TimeSpan(Now.Day, Now.Month, Now.Hour, Now.Minute)
    Dim version As String = "v2021.3.16"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            If Button3.Text = "German" Then
                MsgBox("please select a List! (error 0103)")
            Else
                MsgBox("Bitte wähle eine Liste! (Fehler 0103)")
            End If
            My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " error while applying list (code: 0103)!" & vbCrLf, True)
        Else
            If ComboBox1.Text = "56633" Then
                If Button3.Text = "German" Then
                    MsgBox("YOU FOUND AN EASTER EGG!!!!!")
                Else
                    MsgBox("DU HAST EIN EASTEER EGG GEFUNDEN!!!!!")
                End If
                My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " Easter Egg found!" & vbCrLf, True)
            Else
                If ComboBox1.Text = "56634" Then
                    MsgBox("O̴̡̧̢͎̖̘̹̪̜̟̞̼̙̭͈̟͚̩̺̞̱̫̳͉̭͖̦͚͈̦̒͌͛̓̌͒̊̇͒̆̉̎͗̓̀̔͑́̀͑́̀̓̚͝͠͠͝ͅͅM̵̢̧̥̻̬̘͍̻͍̬̜͔̣͈̟̝̤̯̹̹̖͕͚͓̯̬̱̯̤͔̲͈̮̝͉̞̫̖̦͓̪̦̻͑́̍̾̓̈́̑͝Ģ̷̧̧̡̛̮̩͇͎͚̝̠̜̣̹͚̰̝̹͓̺͎̙̼̫̙̜̬͈̩̃̓͊̍̋͆̔̉̆̈́̒̂̇͋́̈́̏̎͆̈́̈́̆̌̍̌͆͊̅́͆͘̚͘̚͜͠͝ͅ")
                    My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " Easter Egg found!" & vbCrLf, True)
                End If
            End If
        End If


        Dim appdata As String
        appdata = Environ$("appdata")
        If (ComboBox1.Text = "Game Server") Or (ComboBox1.Text = "game servers") Then
            My.Computer.FileSystem.CopyFile(
    "game_servers.dat",
    appdata + "\.minecraft\servers.dat", overwrite:=True)
            If Button3.Text = "German" Then
                MsgBox("successfully!")
            Else
                MsgBox("Erfolgreich!")
            End If
            My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " applyed Game_Servers!" & vbCrLf, True)
        End If
        If (ComboBox1.Text = "Partner Server") Or (ComboBox1.Text = "partner servers") Then
            My.Computer.FileSystem.CopyFile(
    "cool_servers.dat",
    appdata + "\.minecraft\servers.dat", overwrite:=True)
            If Button3.Text = "German" Then
                MsgBox("successfully!")
            Else
                MsgBox("Erfolgreich!")
            End If
            My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " applyed Cool_Server!" & vbCrLf, True)
        End If
        If (ComboBox1.Text = "eingesendete Server") Or (ComboBox1.Text = "submitted servers") Then
            My.Computer.FileSystem.CopyFile(
        "sub_servers.dat",
        appdata + "\.minecraft\servers.dat", overwrite:=True)
            If Button3.Text = "German" Then
                    MsgBox("successfully!")
                Else
                    MsgBox("Erfolgreich!")
                End If
            My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " applyed submitted_servers!" & vbCrLf, True)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " Program started!" & vbCrLf, True)
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("Bitte überprüfe deine Internet verbindung!")
            Me.Close()
        Else
            ProgressBar1.Maximum = "100"
            ProgressBar1.Minimum = "0"
            ProgressBar1.Value = "0"
            ProgressBar1.Value = "10"
            TabPage2.Text = "Neuigkeiten"
            TabPage1.Text = "Updates"
            WebBrowser1.Navigate("http://ponolisoft.epizy.com/mcst.php?lang=de")
            ProgressBar1.Value = "20"
            WebBrowser2.Navigate("http://ponolisoft.epizy.com/mcslt_updates")
            My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " Websites loaded!" & vbCrLf, True)
            ProgressBar1.Value = "30"
            Button3.Enabled = False
            Label2.Text = "MCSLT " + version + " by Twisterry"
            Me.Text = "MCSLT " + version
            ProgressBar1.Value = "40"
            If My.Computer.FileSystem.FileExists("game_servers.dat") Then
            Else
                If My.Computer.Network.IsAvailable Then
                    My.Computer.Network.DownloadFile(
        "https://raw.githubusercontent.com/twisterry/mcserverlisttool/main/listen/game_servers.dat",
        "game_servers.dat", False, 500)
                Else
                    MsgBox("Fehler: 0101")
                End If
                ProgressBar1.Value = "50"
                If My.Computer.FileSystem.FileExists("cool_servers.dat") Then
                Else
                    ProgressBar1.Value = "70"
                    If My.Computer.Network.IsAvailable Then
                        My.Computer.Network.DownloadFile(
        "https://raw.githubusercontent.com/twisterry/mcserverlisttool/main/listen/cool_servers.dat",
        "cool_servers.dat", False, 500)
                    Else
                        MsgBox("Fehler 0101")
                    End If
                End If

                If My.Computer.Network.IsAvailable Then
                    My.Computer.Network.DownloadFile(
    "https://raw.githubusercontent.com/twisterry/mcserverlisttool/main/listen/sub_servers.dat",
    "sub_servers.dat", False, 500)
                Else
                    MsgBox("Fehler 0101")
                End If
            End If

            ProgressBar1.Value = "0"
            My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " All files ready!" & vbCrLf, True)
        End If

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.FileSystem.DeleteFile("game_servers.dat")
        My.Computer.FileSystem.DeleteFile("cool_servers.dat")
        My.Computer.FileSystem.DeleteFile("sub_servers.dat")
        My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " Program closed!" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "-----------" & vbCrLf, True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim appdata As String
        appdata = Environ$("appdata")
        If My.Computer.FileSystem.FileExists(appdata + "\.minecraft\servers.dat") Then
            My.Computer.FileSystem.DeleteFile(appdata + "\.minecraft\servers.dat")
            If Button3.Text = "German" Then
                MsgBox("successfully!")
            Else
                MsgBox("Erfolgreich!")
            End If
            My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " all servers deleted successfully!" & vbCrLf, True)
        Else
            If Button3.Text = "German" Then
                MsgBox("There are no servers! (error: 0102)")
            Else
                MsgBox("Es sind keine Server vorhanden! (Fehler: 0102)")
            End If
            My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " error while deleting servers (code: 0102)" & vbCrLf, True)

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabPage2.Text = "News"
        Button3.Enabled = True
        Button3.Text = "German"
        Button4.Text = "English"
        Button4.Enabled = False
        Label1.Text = "please select a list:"
        Button1.Text = "save"
        Button2.Text = "delete all Servers"
        Button5.Text = "reload lists"
        Button6.Text = "close"
        ComboBox1.DataSource = Nothing
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("game servers")
        ComboBox1.Items.Add("partner servers")
        ComboBox1.Items.Add("submitted servers")
        WebBrowser1.Navigate("http://ponolisoft.epizy.com/mcst.php?lang=en")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabPage2.Text = "Neuigkeiten"
        Button3.Enabled = False
        Button3.Text = "Deutsch"
        Button4.Text = "Englisch"
        Button4.Enabled = True
        Label1.Text = "Bitte eine Liste wählen:"
        Button1.Text = "Speichern"
        Button2.Text = "Alle Server löschen!"
        Button5.Text = "Listen aktualisieren"
        Button6.Text = "Beenden"
        ComboBox1.DataSource = Nothing
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Game Server")
        ComboBox1.Items.Add("Partner Server")
        ComboBox1.Items.Add("eingesendete Server")
        WebBrowser1.Navigate("http://ponolisoft.epizy.com/mcst.php?lang=de")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'neuladen der Listen
        My.Computer.FileSystem.DeleteFile("game_servers.dat") 'alte Listen löschen
        My.Computer.FileSystem.DeleteFile("cool_servers.dat")
        ProgressBar1.Maximum = "100" 'ProgressBar einstellen
        ProgressBar1.Minimum = "0"
        ProgressBar1.Value = "0" 'Progressbar ist bei 0
        My.Computer.Network.DownloadFile( 'neue Listen werden Heruntergeladen
    "https://raw.githubusercontent.com/twisterry/mcserverlisttool/main/listen/cool_servers.dat",
    "cool_servers.dat", False, 500)
        ProgressBar1.Value = "50"
        My.Computer.Network.DownloadFile(
    "https://raw.githubusercontent.com/twisterry/mcserverlisttool/main/listen/game_servers.dat",
    "game_servers.dat", False, 500)
        ProgressBar1.Value = "100"
        If Button3.Text = "German" Then 'erfolgsmeldung
            MsgBox("successfully!")
        Else
            MsgBox("Erfolgreich!")
        End If
        My.Computer.FileSystem.WriteAllText("C://mcslt_log.txt", "[" + startzeit.ToString + "]" + " successfully reloaded lists!" & vbCrLf, True)
        ProgressBar1.Value = "0"
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class
