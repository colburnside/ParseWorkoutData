Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDataToParse.TextChanged
        btnParse.Enabled = True
    End Sub

    Private Sub btnParse_Click(sender As Object, e As EventArgs) Handles btnParse.Click
        Dim dateLine As String
        Dim workoutDate As Date
        Dim spaceAfterDay As Integer
        Dim workoutDay As Integer

        For Each strLine As String In txtDataToParse.Text.Split(vbNewLine)
            If InStr(strLine, "FitNotes Workout - ") Then
                dateLine = strLine.Substring(19, Len(strLine) - 19)
                spaceAfterDay = InStr(1, dateLine, " ")
                dateLine = dateLine.Substring(spaceAfterDay, Len(dateLine) - (spaceAfterDay))
                MsgBox(dateLine)
                'dateLine = "30 April 2018"
                'workoutDay = Convert.ToInt32(dateLine)
                'MsgBox(workoutDay)
                workoutDate = CDate(dateLine)
            End If
            Debug.Print(strLine)
        Next
        MsgBox(workoutDate)
    End Sub
End Class
