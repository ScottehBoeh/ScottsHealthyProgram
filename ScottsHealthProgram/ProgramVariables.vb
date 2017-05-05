Module ProgramVariables

    'Program Variables:
    ' This classed is used to store important variables concerning
    ' logging in/out aswell as populating the users text file with
    ' the required information
    '
    ' - Created by Scott Robertson

    Public validSession As Boolean = False '- Valid or Invalid Session (Logged in/out)
    Public userName As String = "" '- Session Username
    Public loginFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\users.txt" '- Path for users.txt file (Created/Used from Windows User)
    Public blogSaveDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\userblogs\" '- Directory to save user blogs
    Public cachedUsers As String() '- Cached Users string array
    Public cachedBlog As String() '- Cached Blog Posts string array

End Module
