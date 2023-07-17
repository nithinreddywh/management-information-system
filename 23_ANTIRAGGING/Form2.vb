Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form2

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter

    Dim str As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAHOO\Desktop\Visual Basic - Exps\23_ANTIRAGGING\Database1.mdf;Integrated Security=True")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtName.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Or txtCity.Text = "" Or txtState.Text = "" Then
            MsgBox("Fill All Details Completely")
        Else

            con.Open()

            str = "INSERT INTO GUARDIAN VALUES ('" & txtName.Text & "','" & txtPhone.Text & "','" &
                txtAddress.Text & "','" & txtCity.Text & "','" & txtState.Text & "')"

            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()

            MsgBox("Data Added Succesfully ! ")

            txtPhone.Clear()
            txtAddress.Clear()
            txtCity.Clear()
            txtState.Clear()
            txtName.Clear()

            cmd.Dispose()
            con.Close()

        End If
    End Sub
End Class