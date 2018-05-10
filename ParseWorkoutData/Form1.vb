Imports System.IO

Public Class Form1
    'todo add code to write/append to text file.
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDataToParse.TextChanged
        btnParse.Enabled = True
    End Sub

    Private Sub btnParse_Click(sender As Object, e As EventArgs) Handles btnParse.Click
        Dim dateLine As String
        Dim workoutDate As Date
        Dim spaceAfterDay As Integer
        Dim exerciseName As String = ""
        Dim weight As Decimal
        Dim reps As Integer

        For Each strLine As String In txtDataToParse.Text.Split(vbNewLine)
            If InStr(strLine, "FitNotes Workout - ") Then
                lstResults.Visible = True
                dateLine = strLine.Substring(19, Len(strLine) - 19)
                spaceAfterDay = InStr(1, dateLine, " ")
                dateLine = dateLine.Substring(spaceAfterDay, Len(dateLine) - (spaceAfterDay))
                workoutDate = extractWorkoutDate(dateLine)
            End If
            If InStr(strLine, "**") Then
                exerciseName = extractExercise(strLine)
            End If
            If InStr(strLine, "lbs") Then
                weight = extractWeight(strLine)
                reps = extractReps(strLine)
                lstResults.Items.Add(workoutDate & ", " & exerciseName & "," & weight & ", " & reps)
            End If
        Next
        btnWriteToFile.Visible = True
    End Sub

    Function extractWorkoutDate(ByRef dateLine As String) As Date
        Dim workoutDay As String
        Dim workoutMonth As Integer

        workoutDay = dateLine.Substring(0, InStr(1, dateLine, " "))
        If InStr(workoutDay, "nd") Then
            workoutDay = workoutDay.Substring(0, InStr(1, workoutDay, "nd") - 1)
        End If
        If InStr(workoutDay, "th") Then
            workoutDay = workoutDay.Substring(0, InStr(1, workoutDay, "th") - 1)
        End If
        If InStr(workoutDay, "st") Then
            workoutDay = workoutDay.Substring(0, InStr(1, workoutDay, "st") - 1)
        End If
        If InStr(workoutDay, "rd") Then
            workoutDay = workoutDay.Substring(0, InStr(1, workoutDay, "rd") - 1)
        End If
        If InStr(dateLine, "January") Then
            workoutMonth = 1
        ElseIf InStr(dateLine, "February") Then
            workoutMonth = 2
        ElseIf InStr(dateLine, "March") Then
            workoutMonth = 3
        ElseIf InStr(dateLine, "April") Then
            workoutMonth = 4
        ElseIf InStr(dateLine, "May") Then
            workoutMonth = 5
        End If
        extractWorkoutDate = CDate(workoutMonth & "/" & workoutDay & "/" & dateLine.Substring(dateLine.Length - 4))
    End Function
    Function extractExercise(ByRef lineReadIn As String) As String
        extractExercise = lineReadIn.Substring(3, Len(lineReadIn) - 6)

    End Function

    Function extractWeight(ByRef lineReadIn As String) As Decimal
        If InStr(lineReadIn, "lbs") Then
            extractWeight = CDbl(lineReadIn.Substring(3, InStr(lineReadIn, "lbs") - 4))
        Else
            extractWeight = 0.0
        End If

    End Function

    Function extractReps(ByRef lineReadIn As String) As Integer
        Dim tempLine As String = ""
        If InStr(lineReadIn, "reps") Then
            tempLine = lineReadIn.Substring(InStr(lineReadIn, "lbs") + 4, Len(lineReadIn) - InStr(lineReadIn, " x ") - 5)
        End If
        extractReps = CInt(tempLine)
    End Function

    Private Sub btnWriteToFile_Click(sender As Object, e As EventArgs) Handles btnWriteToFile.Click
        Dim dir As String
        dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim strFile As String = dir & "\fitNotes.csv"
        Dim fileExists As Boolean = File.Exists(strFile)
        Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
            For l_index As Integer = 0 To lstResults.Items.Count - 1
                Dim l_text As String = CStr(lstResults.Items(l_index))
                sw.WriteLine(l_text)
            Next
            sw.Close()
            MsgBox("Results written to: " & strFile)
        End Using


    End Sub
End Class
