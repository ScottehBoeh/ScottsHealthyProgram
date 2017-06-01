
'Various required Imports
Imports System.IO

Public Class BlogManager

    'BLog Manager:
    ' This class is used to create and open Blogs/Logs created by the user
    '
    ' - Created by Scott Robertson

    'Create Blog Post
    ' Create a new Blog Post using given text input
    ' - givenText - The text input from the user
    Shared Function createBlogPost(givenText As String)

        Dim currentDate As String 'Current Date
        Dim finalOutput As String 'File Output Name
        'Cast currentDate variable to current system date/time
        currentDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'Reformat file output and include current Date/Time
        finalOutput = currentDate + " " + givenText

        Dim textFileName As String 'Name of Text File (String)
        'Format text file name (Including username as hash code
        textFileName = ProgramVariables.userName.GetHashCode.ToString + ".txt"

        'If the blog text fiel does not exist
        If Not My.Computer.FileSystem.FileExists(ProgramVariables.blogSaveDirectory + textFileName) Then

            'Create a new text file and close the filestream
            Dim fileStream As FileStream = File.Create(ProgramVariables.blogSaveDirectory + textFileName) '- Create new Text File
            fileStream.Close()

        End If

        'Cast userFile to blog file
        Dim usersFile As New System.IO.FileInfo(ProgramVariables.blogSaveDirectory + textFileName)

        'If the blog file has no inputs, input as single line
        If (usersFile.Length.ToString = 0) Then
            'New user input
            finalOutput = finalOutput
            'Else, add new line before printing to text file
        Else
            'New user input (on new line)
            finalOutput = Environment.NewLine + finalOutput
        End If

        'Send input to text file
        My.Computer.FileSystem.WriteAllText(
          ProgramVariables.blogSaveDirectory + textFileName, finalOutput, True)

    End Function

    'Get Blog
    ' Load and Cache the users blog from a text file to the program variables class
    Shared Function getBlog()

        Dim textFileName As String 'Text File Name for Format
        'Format text file name to include username as hash code
        textFileName = ProgramVariables.userName.GetHashCode.ToString + ".txt"

        'Check if the blog exists or not
        If (doesBlogExist()) Then

            Dim textFileLines() As String 'String to hold all file outputs
            'Read all text outputs line by line and add them to textFileLines string array
            textFileLines = IO.File.ReadAllLines(ProgramVariables.blogSaveDirectory + textFileName)
            ProgramVariables.cachedBlog = textFileLines 'Save lines to ProgramVariables Cached Blog

        End If

    End Function

    'Create Blog Directory
    ' Create the Blog Directory if it does not already exist
    Shared Function createBlogDirectory()

        'If the Blog Directory does not exist
        If Not My.Computer.FileSystem.DirectoryExists(ProgramVariables.blogSaveDirectory) Then

            'Create the Directory using given directory name from ProgramVariables class
            My.Computer.FileSystem.CreateDirectory(ProgramVariables.blogSaveDirectory)
            'Inform the user that the directory did not exist and has now been created
            MsgBox("Blog directory: " & ProgramVariables.blogSaveDirectory & " did not exist! Creating!")

        End If

    End Function

    'Does Blog Exist
    ' If the Blog Directory/File does or does not exist, return boolean
    Shared Function doesBlogExist() As Boolean

        Dim textFileName As String 'Text File Name
        'Format text file name (using username hash code)
        textFileName = ProgramVariables.userName.GetHashCode.ToString + ".txt"

        'If file at direcotyr exists
        If My.Computer.FileSystem.FileExists(ProgramVariables.blogSaveDirectory + textFileName) Then
            'Return True (File does exist)
            Return True
        Else
            'Return False (File does not exist)
            Return False
        End If

    End Function

End Class