# About 

Code provides

-  A method to chunk a file into separate files by chunk size
-  Validate the chunk process worked

The code is from a C# application I created for work. Don't have the time right now to document it but it works and has been working for two years four days a week.

Minimal coding although there are events to tie into and also a verifcation process which is optional.
```vb
Public Module demo
    Sub Example()
        FileOperations.ChunkFile("File to chunk", 300, Nothing, "Chunk")
    End Sub
End Module
```