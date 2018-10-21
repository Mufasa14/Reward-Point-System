Imports System.Data.OleDb
Public Class Form1
    Private Sub LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection(“Provider=Microsoft.ACE.OLEDB.12.0;Data Source=” & Application.StartupPath & “\login.accdb”)
        Dim cmd As OleDbCommand = New OleDbCommand(
"SELECT * FROM login WHERE Username = '" &
TextBox1.Text & "' AND Password = '" & TextBox2.Text & "'", con)
        Dim user As String = ""
        Dim pass As String = ""

        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            user = sdr("Username")
            Console.Write(user)
            pass = sdr("Password")
            Console.Write(pass)
            MessageBox.Show(“Login Successfully!”)
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show(“Invalid username or password!”)
        End If
    End Sub
End Class
