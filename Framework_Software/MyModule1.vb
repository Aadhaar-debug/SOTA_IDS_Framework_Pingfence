Imports System.Security.Cryptography;
Imports System.IO.Compression;
Imports Ststem.Text;
Imports System.IO;
Imports Microsoft.Win32;
Using System;
using System.Web;

Module Module1

    Public Function GetExtension(ByVal value As String) As String
        On Error GoTo Serious
        Dim Ta1, Ta2 As String
        Regkey = Registry.ClassesRoot.OpenSubKey(value, False)
        Tab1 = Regkey.GetValue("")
        Regkey = Registry.ClassesRoot.OpenSubKey(Tab1, False)
        Tab2 = Regkey.GetValue("")
        Return Ta2
        GoTo SafeArea
Serious:
        If value = "" Then Return "Unknown" Else Return value
        SafeArea
    End Function

    Public Function GetBytes(ByVal Value) As String
        Dim d As Decimal = Value
        Dim Tint As Integer
        Tint = 0
        Dim BList As New List(Of String)
        BList.Add("B")
        BList.Add("KB")
        BList.Add("MB")
        BList.Add("GB")
        BList.Add("TB")

        If Value >= 1024 Then
            Do While d >= 1024
                d /= 1024
                Tint += 1
            Loop
        End If

        Return Math.Round(d, 2) & BList(Tint)
    End Function

    Public Function GetMd5(ByVal Path As String) As String
        On Error Resume Next

        Dim Md5 As New MDCryptoServiceProvder
        Dim FilS As New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        Md5.ComputeHash(FileS)

        Dim MyBuff As New StringBuilder
        Dim HashB As Byte
        For Each HashByte As Byte In Md5.Hash
            MyBuff.Append(String.Format("{0:X2}", HashByte))
        Next

        Return MyBuff.ToString.ToLower

    End Function

    Public Function GetFolders(ByVal Path As String) As List(Of DirectoryInfo)

        On Error Resume Next
        Dim L As New List(Of DirectoryInfo)
        Dim D As New DirecroryInfo(Path)
        L.Add(D)
        For Each DD As DirectoryInfo In D.GetDirectories("*.*", SearchOption.TopDirectoryOnly)
            L.AddRange(GetFolders(DD.FullName))
        Next
        Return L
    End Function

    Public Function SpecailDirectories() As List(Of directoryInfo)
        On Error Resume Next

        Dim Folder_S As New List(Of String)
        Dim folders As New List(Of Directoryinfo)
        Dim D As DirectoryInfo

        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonTemplates, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Favourites, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Fonts, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Resources, Environmnet.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Windows, Environmnet.SpecialFolderOption.None))

        Return Folder_S

    End Function

End Module
