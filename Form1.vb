Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            If Button3.Text = "German" Then
                MsgBox("please select a List:")
            Else
                MsgBox("Bitte wähle eine Liste!")
            End If
        Else
            If ComboBox1.Text = "56633" Then
                If Button3.Text = "German" Then
                    MsgBox("YOU FOUND AN EASTER EGG!!!!!")
                Else
                    MsgBox("DU HAST EIN EASTEER EGG GEFUNDEN!!!!!")
                End If
            Else
            End If
        End If

        Dim appdata As String
        appdata = Environ$("appdata")
        If ComboBox1.Text = "Game Server" Then
            My.Computer.FileSystem.CopyFile(
    "game_servers.dat",
    appdata + "\.minecraft\servers.dat", overwrite:=True)
            If Button3.Text = "German" Then
                MsgBox("successfully!")
            Else
                MsgBox("Erfolgreich!")
            End If
        End If
        If ComboBox1.Text = "Cool Servers" Then
            My.Computer.FileSystem.CopyFile(
    "cool_servers.dat",
    appdata + "\.minecraft\servers.dat", overwrite:=True)
            If Button3.Text = "German" Then
                MsgBox("successfully!")
            Else
                MsgBox("Erfolgreich!")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = "100"
        ProgressBar1.Minimum = "0"
        ProgressBar1.Value = "0"
        ProgressBar1.Value = "10"
        TabPage2.Text = "Neuigkeiten"
        TabPage1.Text = "Updates"
        WebBrowser1.Navigate("http://ponolisoft.epizy.com/mcst.php?lang=de")
        ProgressBar1.Value = "20"
        WebBrowser2.Navigate("http://ponolisoft.epizy.com/mcslt_updates")
        ProgressBar1.Value = "30"
        Button3.Enabled = False
        Me.Text = "MCSLT v0.3 R2"
        ProgressBar1.Value = "40"
        If My.Computer.FileSystem.FileExists("game_servers.dat") Then
        Else
            My.Computer.Network.DownloadFile(
    "http://benheymann.de/7pWy8Hf4eaqd25qpnSSrBWnZGL5XDWe6dbJYSEp/files/server_lists/game_servers.dat",
    "game_servers.dat", False, 500)
        End If
        ProgressBar1.Value = "50"
        If My.Computer.FileSystem.FileExists("cool_servers.dat") Then
        Else
            ProgressBar1.Value = "70"
            My.Computer.Network.DownloadFile(
    "http://benheymann.de/7pWy8Hf4eaqd25qpnSSrBWnZGL5XDWe6dbJYSEp/files/server_lists/cool_servers.dat",
    "cool_servers.dat", False, 500)
        End If
        ProgressBar1.Value = "0"
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
            If Button3.Text = "German" Then
                MsgBox("successfully!")
            Else
                MsgBox("Erfolgreich!")
            End If
        Else
            If Button3.Text = "German" Then
                MsgBox("There are no servers!")
            Else
                MsgBox("Es sind keine Server vorhanden!")
            End If

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
        WebBrowser1.Navigate("http://ponolisoft.epizy.com/mcst.php?lang=de")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.FileSystem.DeleteFile("game_servers.dat")
        My.Computer.FileSystem.DeleteFile("cool_servers.dat")
        ProgressBar1.Maximum = "100"
        ProgressBar1.Minimum = "0"
        ProgressBar1.Value = "0"
        My.Computer.Network.DownloadFile(
    "http://benheymann.de/7pWy8Hf4eaqd25qpnSSrBWnZGL5XDWe6dbJYSEp/files/server_lists/cool_servers.dat",
    "cool_servers.dat", False, 500)
        ProgressBar1.Value = "50"
        My.Computer.Network.DownloadFile(
    "http://benheymann.de/7pWy8Hf4eaqd25qpnSSrBWnZGL5XDWe6dbJYSEp/files/server_lists/game_servers.dat",
    "game_servers.dat", False, 500)
        ProgressBar1.Value = "100"
        If Button3.Text = "German" Then
            MsgBox("successfully!")
        Else
            MsgBox("Erfolgreich!")
        End If
        ProgressBar1.Value = "0"
    End Sub

End Class
