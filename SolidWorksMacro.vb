Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swconst
Imports System.Runtime.InteropServices
Imports System


Partial Class SolidWorksMacro
    Public Sub main()
        Dim message As String
        Dim swVersion As Integer
        Dim swDoc As ModelDoc2
        Dim swTitle As String

        swDoc = swApp.ActiveDoc
        swTitle = swDoc.GetTitle
        swVersion = swApp.DateCode

        message = "Hello Solidworks " & swVersion.ToString _
            & vbCrLf & "Document: " & swTitle
        'Show the message
        MsgBox(message)

    End Sub
    ''' <summary>
    ''' The SldWorks swApp variable is pre-assigned for you.
    ''' </summary>
    Public swApp As SldWorks
End Class
