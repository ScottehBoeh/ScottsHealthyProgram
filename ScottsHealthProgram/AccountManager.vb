
'Various required Imports
Imports System
Imports System.IO
Imports System.Text

Public Class AccountManager

    'Account Manager:
    ' This class is used to Create, Delete, Add/Remove, Validate and everything
    ' else related to the Users/Log/Verification and Session Validating of the
    ' program
    '
    ' - Created by Scott Robertson

    'Register User
    ' Register a user using the given Username and Password
    ' - givenUsername - The user name used to create a new user
    ' - givenPassword - The password used to create a new user
    Shared Function registerUser(givenUsername As String, givenPassword As String)

        Dim usersFile As New System.IO.FileInfo(ProgramVariables.loginFilePath) '- Cast users file
        Dim inputUserAndPass As String '- String used for new Input to users file

        'Check if the user file has any inputs already. If not: add input to first line
        If (usersFile.Length.ToString = 0) Then
            'New user input
            inputUserAndPass = givenUsername.GetHashCode.ToString + ":" + givenPassword.GetHashCode.ToString
        Else
            'New user input (on new line)
            inputUserAndPass = Environment.NewLine + givenUsername.GetHashCode.ToString + ":" + givenPassword.GetHashCode.ToString
        End If

        'Send input to text file
        My.Computer.FileSystem.WriteAllText(
          ProgramVariables.loginFilePath, inputUserAndPass, True)

    End Function

    'Can Register Function
    ' Used to check that the Username does not already exist
    ' - givenUsername - The user name used to register the user
    ' - givenPassword - The password used to register the user
    Shared Function canRegister(givenUsername As String, givenPassword As String) As Boolean

        Dim strFileName() As String '- String Array used to store all users/passwords from users text file
        Dim tempStr As String = "" '- Temp string used for each user in list
        strFileName = IO.File.ReadAllLines(ProgramVariables.loginFilePath) '- cast file contents to the String Array

        'For each line in the text file
        For Each UserPassLine In strFileName

            Dim splitLine As String() = UserPassLine.Split(":") '- Split the User/Password appart (eg username:password)
            Dim userName As String = splitLine(0) '- Get username from splitLine

            'If the Username compares to the given Username from the text file, return False (They can't register that username)
            If (givenUsername = userName) Then
                Return False
            End If

            'Next username/password line in text file
        Next

        'Else return True (They can register that username and password)
        Return True

    End Function

    'Can Login Function
    ' Used to check if the Username and Password are acceptable/secure
    ' - givenUsername - The user name used to login
    ' - givenPassword - The password used to login
    Shared Function canLogin(givenUsername As String, givenPassword As String) As Boolean

        Dim strFileName() As String '- String Array used to store usernames/passwords from users text file
        Dim tempStr As String = "" '- Empty String used to store each username/password line
        strFileName = IO.File.ReadAllLines(ProgramVariables.loginFilePath) '- Cast String Array to each line of users text file

        'For each line in String Array
        For Each UserPassLine In strFileName

            Dim splitLine As String() = UserPassLine.Split(":") '- String Array of username/password split
            Dim userName As String = splitLine(0) '- Username from split
            Dim passWord As String = splitLine(1) '- Password from split

            'Does given username compare to username in text file
            If (givenUsername.GetHashCode = userName) Then

                'Does given password compare to password in text file
                If (givenPassword.GetHashCode = passWord) Then

                    'Return True (can login to this user with given Username & Password)
                    Return True

                End If

            End If

        Next

        'Return False (can not login to this user with given Username/Password)
        Return False

    End Function

    'Does User Exist Function
    ' Used to check if the Username given already exists on the System
    ' - givenUsername - The user name to search for
    Shared Function userExists(givenUsername As String) As Boolean

        Dim strFileName() As String '- String Array for storing users from users text file
        Dim tempStr As String = "" '- Temp string used to store each line in users text file
        strFileName = IO.File.ReadAllLines(ProgramVariables.loginFilePath) '- Cast String Array to each line in users text file

        'For each line in Users File String Array
        For Each UserPassLine In strFileName

            Dim splitLine As String() = UserPassLine.Split(":") '- Split String Array username/password
            Dim userName As String = splitLine(0) '- Get Username from split

            'If given username compares to username from split
            If (givenUsername = userName.GetHashCode.ToString) Then

                'Return true (The user does exist)
                Return True

            End If

            'Next username/password in line
        Next

        'Else, return false (The user does not exist)
        Return False

    End Function

    'Login Function
    ' Officialy log into the Account using the given Username
    ' - givenUsername - The user name to log into
    Shared Function login(givenUsername As String)

        ProgramVariables.userName = givenUsername 'Set session username to given Username
        ProgramVariables.validSession = True 'Declare session as Valid

    End Function

    'Populate User File Function
    ' Used to Find/Create/Populate the users.txt file
    ' (File Path/Location/Name depends on the ProgramVariables value)
    Shared Function populateUserFile()

        Dim strFileName() As String '- String Array of all users in Users File

        'Check that Users file exists before caching
        If My.Computer.FileSystem.FileExists(ProgramVariables.loginFilePath) Then

            'If file does exist:
            strFileName = IO.File.ReadAllLines(ProgramVariables.loginFilePath) '- Populate String Array with contents of users text file

        Else

            Dim adminString As String = "admin".GetHashCode '- Used to add Admin user to Users Text File

            'Inform user that file does not exist and that the file is being created in the given path
            MsgBox("Users storage file not found! Creating one in '" + ProgramVariables.loginFilePath + "'")

            Dim fileStream As FileStream = File.Create(ProgramVariables.loginFilePath) '- Create new Text File
            Dim inputString As Byte() = New UTF8Encoding(True).GetBytes(adminString + ":" + adminString) '- Add Admin Account string to text file
            fileStream.Write(inputString, 0, inputString.Length) '- Write to file
            fileStream.Close() '- Close Write Stream to file
            populateUserFile() '- Rerun function to refresh users file

        End If

        ProgramVariables.cachedUsers = strFileName '- Cast String Array to Cached Users Array

    End Function

    'Logout Function
    ' Quickly log out of the current session
    ' Changes valid session to False and sets session username to ""
    Shared Function logOut()

        ProgramVariables.validSession = False '- Set session to false (Invalid session)
        ProgramVariables.userName = "" '- Set username to null (no user logged in)

    End Function

End Class