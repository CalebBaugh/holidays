Imports System.IO
Public Class Form1
    Private Structure CustomerData
        Public Client As String
        Public First As String
        Public Second As String
        Public DateBirth As Date
        Public Email As String
    End Structure

    Private Function ValidateCheck(ByVal CheckField As String, ByVal CheckString As String, ByVal MaximumLength As Integer) As String
        If CheckString = "" Then
            MessageBox.Show("Please enter a value in " & CheckField)
        ElseIf CheckString > MaximumLength Then
            MessageBox.Show("The information entered in " & CheckField & " is either too long or too short but it must be less than " & MaximumLength & "words long")
        ElseIf CheckField = "Email" And (CheckString.Contains("@") = False Or CheckString.Contains(".") = False) Then
            MessageBox.Show("The email is not valid please enter a valid email address")
        End If
        Return ""
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtClientID.Enabled = False

    End Sub
    Private Sub txtName1_KeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtName1.PreviewKeyDown
        Select Case e.KeyValue
            Case Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.D0, Keys.ControlKey, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.NumPad0
                SendKeys.Send("{BACKSPACE}")
        End Select
    End Sub

    Private Sub txtName2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName2.KeyDown
        Select Case e.KeyValue
            Case Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.D0, Keys.ControlKey, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.NumPad0
                SendKeys.Send("{BACKSPACE}")
        End Select
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click

        txtClientID.Enabled = True

        MessageBox.Show("Please enter the Client ID you would like to search for")
        txtClientID.Text = ""
        txtName1.Text = ""
        txtName2.Text = ""
        txtEmailAddress.Text = ""
        txtDOB.Text = ""
        txtClientID.Enabled = True
        txtName1.Enabled = False
        txtName2.Enabled = False
        txtEmailAddress.Enabled = False
        txtDOB.Enabled = False
        Dim CustomerDetails As String = "E:\Computing Tasks\Candidate\Holidays\CustomerData.text"

        Dim TextLine As String

        If System.IO.File.Exists(CustomerDetails) = True Then

        End If

        Dim objReader As New System.IO.StreamReader(CustomerDetails)

        Do While objReader.Peek() <> -1

            TextLine = TextLine & objReader.ReadLine() & vbNewLine

        Loop

        txtDetails.Text = TextLine
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        Dim CustomerData As String = "E:\Computing Tasks\Candidate\Holidays\CustomerData.text"

        If System.IO.File.Exists(CustomerData) = True Then

        End If

        Dim objWriter As New System.IO.StreamWriter(CustomerData)

        objWriter.Write(txtName1.Text)
        objWriter.Write(" ")
        objWriter.Write(txtName2.Text)
        objWriter.Write(" ")
        objWriter.Write(txtEmailAddress.Text)
        objWriter.Write(" ")
        objWriter.Write(txtDOB.Text)
        objWriter.Close()
    End Sub
End Class
