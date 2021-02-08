
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("Bitte wähle eine Liste!")
        End If
        Dim appdata As String
        appdata = Environ$("appdata")
        If ComboBox1.Text = "Game Server" Then
            My.Computer.FileSystem.CopyFile(
    "game_servers.dat",
    appdata + "\.minecraft\servers.dat", overwrite:=True)
            MsgBox("Erfolgreich!")
        End If
        If ComboBox1.Text = "Coole Server :D" Then
            My.Computer.FileSystem.CopyFile(
    "cool_servers.dat",
    appdata + "\.minecraft\servers.dat", overwrite:=True)
            MsgBox("Erfolgreich!")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage2.Text = "Neuigkeiten"
        TabPage1.Text = "Updates"
        WebBrowser1.Navigate("http://ponolisoft.epizy.com/mcst.php?lang=de")
        WebBrowser2.Navigate("http://ponolisoft.epizy.com/mcslt_updates")
        Button3.Enabled = False
        Me.Text = "MCSLT v0.2 R2"
        If My.Computer.FileSystem.FileExists("game_servers.dat") Then
        Else
            My.Computer.Network.DownloadFile(
    "http://benheymann.de/7pWy8Hf4eaqd25qpnSSrBWnZGL5XDWe6dbJYSEp/files/server_lists/game_servers.dat",
    "game_servers.dat", False, 500)
        End If

        If My.Computer.FileSystem.FileExists("cool_servers.dat") Then
        Else
            My.Computer.Network.DownloadFile(
    "http://benheymann.de/7pWy8Hf4eaqd25qpnSSrBWnZGL5XDWe6dbJYSEp/files/server_lists/cool_servers.dat",
    "cool_servers.dat", False, 500)
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.FileSystem.DeleteFile("game_servers.dat")
        My.Computer.FileSystem.DeleteFile("cool_servers.dat")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim appdata As String
        appdata = Environ$("appdata")
        If My.Computer.FileSystem.FileExists(appdata + "\.minecraft\servers.dat") Then
            My.Computer.FileSystem.DeleteFile(appdata + "\.minecraft\servers.dat")
            MsgBox("Erfolgreich!")
        Else
            MsgBox("Es sind keine Server vorhanden!")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabPage2.Text = "News"
        Button3.Enabled = True
        Button3.Text = "German"
        Button4.Text = "English"
        Button4.Enabled = False
        Label1.Text = "Select a List:"
        Button1.Text = "Save"
        Button2.Text = "Delete all Servers"
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
        WebBrowser1.Navigate("http://ponolisoft.epizy.com/mcst.php?lang=de")
    End Sub
End Class
