Imports System.IO
Imports System.Runtime.InteropServices


Module Module1

    Public Sub Main()
        Dim objApp As SolidEdgeFramework.Application
        Dim objDoc As SolidEdgeDraft.DraftDocument
        Dim objModelLinks As SolidEdgeDraft.ModelLinks
        Dim objModelLink As SolidEdgeDraft.ModelLink
        Dim objModelLinkApp As SolidEdgeFramework.Application
        'Const TESTFILE = "J:\Chris\Working\SimpSM.psm"
        Dim Int As Integer, Ind As Integer

        objApp = GetObject(, "SolidEdge.Application")
        objDoc = objApp.ActiveDocument
        'Add a model to the Document
        objModelLinks = objDoc.ModelLinks

        Int = objModelLinks.Count
        For Each item In objModelLinks
            Ind = Ind + 1
            objModelLink = objModelLinks.Item(Index:=Ind)
            ClassGV.Nm = objModelLink.FileName ' & " (Index " & objModelLink.IndexReference & ")"
            ClassGV.IndRef = objModelLink.IndexReference
            Form1.ListBox1.Items.Add(ClassGV.Nm)
            Form1.ListBox1.Items.Add(ClassGV.IndRef & objApp.ActiveDocument.path)

        Next
        Form1.ListBox1.Items.Add(Int & " Link(s)")
        Form1.TextBox5.Text = objApp.ActiveDocument.path & "\" & objApp.ActiveDocument.name
        ' Release objects
        objApp = Nothing
        objDoc = Nothing
        objModelLinks = Nothing
        objModelLink = Nothing
        objModelLinkApp = Nothing
    End Sub


    Public Sub GetSelected()
        Dim Path As String, newfilename As String, FileExist As String
        Dim objModelLink As SolidEdgeDraft.ModelLink
        Dim objApp As SolidEdgeFramework.Application
        Dim objDoc As SolidEdgeDraft.DraftDocument
        Dim objModelLinks As SolidEdgeDraft.ModelLinks

        objApp = GetObject(, "SolidEdge.Application")
        objDoc = objApp.ActiveDocument

        If Form1.ListBox1.SelectedIndex >= 0 Then
            Form1.TextBox1.Text = Form1.ListBox1.SelectedItem.ToString() 'Original linked model
        Else
            MsgBox("Nothing selected. Make selection and try again.")
            Exit Sub
        End If

        Path = System.IO.Path.GetDirectoryName(Form1.TextBox1.Text) 'Just the path
        Form1.TextBox2.Text = Path
        newfilename = Form1.TextBox3.Text 'Desired PART NUMBER for new model file
        ClassGV.newlink = objApp.ActiveDocument.path & "\" & newfilename 'Create full name with path
        Form1.TextBox4.Text = ClassGV.newlink 'Write full name to textbox4


        FileExist = (If(IO.File.Exists(ClassGV.newlink), "YesFile", "NoFile")) 'Check to see if it exists
        objModelLinks = objDoc.ModelLinks
        objModelLink = objModelLinks.Item(Index:=ClassGV.IndRef)
        ClassGV.IndRef = objModelLink.IndexReference

        Try
            If FileExist = "YesFile" Then
                objModelLink.ChangeSource(ClassGV.newlink)
            Else
                MsgBox("File does not exist")
            End If
        Catch ex As Exception
            ' Display the message.
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Public Sub CreateNewModelFile()
        System.IO.File.Copy(ClassGV.Nm, ClassGV.newlink)
    End Sub
    ' Bring up a dialog to chose a folder path in which to open or save a file.
    Public Sub folderChoose()
        Dim objApp As SolidEdgeFramework.Application
        Dim folderBrowserDialog1 As FolderBrowserDialog
        Dim newFileName As String, folderName As String
        Dim objDoc As SolidEdgeDraft.DraftDocument
        Dim oDocs As SolidEdgeFramework.Documents
        Dim fullNewName As String
        objApp = GetObject(, "SolidEdge.Application")
        objDoc = objApp.ActiveDocument
        oDocs = objApp.Documents
        folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        folderBrowserDialog1.SelectedPath = "L:\SPECIALS\NEWFRPXL-2012"
        ' Show the FolderBrowserDialog.
        Dim result As DialogResult = folderBrowserDialog1.ShowDialog()
        newFileName = Form1.TextBox3.Text
        If (result = DialogResult.OK) Then
            folderName = folderBrowserDialog1.SelectedPath
            Form1.TextBox6.Text = folderName
            Form1.TextBox7.Text = folderName & "\" & newFileName & ".dft"
            fullNewName = folderName & "\" & newFileName
            fullNewName = fullNewName & ".dft"
            System.IO.File.Copy(Form1.TextBox5.Text, fullNewName)
            fullNewName = fullNewName.Replace("L:", "L:\")
            objDoc = oDocs.Open(fullNewName)
            'Using fs As FileStream = File.Open(fullNewName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite)

            'End Using
        End If
    End Sub
End Module
