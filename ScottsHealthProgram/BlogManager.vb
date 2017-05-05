
'Various required Imports
Imports System
Imports System.IO
Imports System.Text

Public Class BlogManager

    'BLog Manager:
    ' This class is used to create and open Blogs/Logs created by the user
    '
    ' - Created by Scott Robertson

    Shared Function createBlogPost(givenText As String)

        Dim currentDate As String
        Dim finalOutput As String
        currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        finalOutput = currentDate + " " + givenText

        Dim textFileName As String
        textFileName = ProgramVariables.userName.GetHashCode.ToString + ".txt"

        If Not My.Computer.FileSystem.FileExists(ProgramVariables.blogSaveDirectory + textFileName) Then

            Dim fileStream As FileStream = File.Create(ProgramVariables.blogSaveDirectory + textFileName) '- Create new Text File
            fileStream.Close()

        End If

        Dim usersFile As New System.IO.FileInfo(ProgramVariables.blogSaveDirectory + textFileName)

        If (usersFile.Length.ToString = 0) Then
            'New user input
            finalOutput = finalOutput
        Else
            'New user input (on new line)
            finalOutput = Environment.NewLine + finalOutput
        End If

        'Send input to text file
        My.Computer.FileSystem.WriteAllText(
          ProgramVariables.blogSaveDirectory + textFileName, finalOutput, True)

    End Function


    Shared Function getBlog()

        Dim textFileName As String
        textFileName = ProgramVariables.userName.GetHashCode.ToString + ".txt"

        If (doesBlogExist()) Then

            Dim textFileLines() As String
            textFileLines = IO.File.ReadAllLines(ProgramVariables.blogSaveDirectory + textFileName)
            ProgramVariables.cachedBlog = textFileLines

        End If

    End Function

    Shared Function createBlogDirectory()

        If Not My.Computer.FileSystem.DirectoryExists(ProgramVariables.blogSaveDirectory) Then

            My.Computer.FileSystem.CreateDirectory(ProgramVariables.blogSaveDirectory)
            MsgBox("Blog directory: " & ProgramVariables.blogSaveDirectory & " did not exist! Creating!")

        End If

    End Function

    Shared Function doesBlogExist() As Boolean

        Dim textFileName As String
        textFileName = ProgramVariables.userName.GetHashCode.ToString + ".txt"

        If My.Computer.FileSystem.FileExists(ProgramVariables.blogSaveDirectory + textFileName) Then

            Return True

        Else

            Return False

        End If
    End Function

End Class