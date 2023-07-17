Imports System.Data.SqlClient
Public Class Form1

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim str As String
    Dim dt As DataTable

    Dim reg As String
    Dim name_ As String
    Dim year As String
    Dim dept As String
    Dim mail As String
    Dim phone As String
    Dim oath As String


    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\23_ANTIRAGGING\Database1.mdf;Integrated Security=True")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtDept.Text = "" Or txtMail.Text = "" Or txtName.Text = "" Or txtOath.Text = "" Or txtPhone.Text = "" _
                        Or txtRegNo.Text = "" Or (rb1.Checked = False And rb2.Checked = False And rb3.Checked = False And rb4.Checked = False) Then
            MsgBox("Fill All Details Completely")
        Else
            If rb1.Checked = True Then
                year = "I YEAR"
            ElseIf rb2.Checked = True Then
                year = "II YEAR"
            ElseIf rb3.Checked = True Then
                year = "III Year"
            ElseIf rb4.Checked = True Then
                year = "IV Year"
            End If

            con.Open()

            str = "INSERT INTO STUDENT VALUES ('" & txtRegNo.Text & "','" & txtName.Text & "','" &
                year & "','" & txtDept.Text & "','" & txtMail.Text & "','" & txtPhone.Text & "','" _
                & txtOath.Text & "')"

            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()

            MsgBox("Data Added Succesfully ! ")

            cmd.Dispose()
            con.Close()

            txtRegNo.Clear()
            txtName.Clear()
            txtPhone.Clear()
            txtOath.Clear()
            txtDept.Clear()
            txtMail.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
