Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swconst
Imports System.Runtime.InteropServices
Imports System


Partial Class SolidWorksMacro
    Public Sub main()
        Dim message As String
        Dim swVersion As Integer
        swVersion = swApp.DateCode

        message = "Hello Solidworks " & swVersion.ToString
        'Show the message
        MsgBox(message)

    End Sub
    ''' <summary>
    ''' The SldWorks swApp variable is pre-assigned for you.
    ''' </summary>
    Public swApp As SldWorks
End Class
