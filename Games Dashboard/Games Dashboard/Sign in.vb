Imports MySql.Data.MySqlClient
Imports System.IO
Public Class sign_in

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        register.Show()
    End Sub

    Private Sub login_atau_sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If GunaTextBox1.Text = "" Or GunaTextBox2.Text = "" Then
            MessageBox.Show("Password and Username are still empty")
        Else
            Call koneksi()
            Cmd = New MySqlCommand("select * from tbl_user where username = '" & GunaTextBox1.Text & "' and password = '" & GunaTextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = True Then
                Try

                    Dim gambar() As Byte

                    If Rd.HasRows() Then

                        gambar = Rd("photo")

                        Dim ms As New MemoryStream(gambar)
                        Dashboard.User_foto.Image = Image.FromStream(ms)
                        Dashboard.User_foto.SizeMode = PictureBoxSizeMode.StretchImage
                        Dashboard.lbl_nama.Text = Rd("username")

                        Dashboard.photo_akun.Image = Image.FromStream(ms)
                        Dashboard.photo_akun.SizeMode = PictureBoxSizeMode.StretchImage
                        Dashboard.lbl_username.Text = "Username: " + Rd("username")
                        Dashboard.lbl_password.Text = "Password: " + Rd("Password")
                    Else
                        PictureBox1.Image = Nothing
                        MsgBox("YOUR DATA DOES NOT EXIST", vbCritical, "Demo System")
                    End If
                    Rd.Close()
                Catch ex As Exception
                    MessageBox.Show("ERROR : " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.Hide()
                Dashboard.Show()
            Else
                MessageBox.Show("Your Password and Username is wrong")
            End If
        End If
    End Sub


    Private Sub GunaTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaTextBox1.MouseClick
        GunaTextBox1.ForeColor = Color.Black
        GunaTextBox1.Clear()
    End Sub

    Private Sub GunaTextBox1_MouseLeave(sender As Object, e As EventArgs) Handles GunaTextBox1.MouseLeave
        If GunaTextBox1.Text = "Username" Or GunaTextBox1.Text = "" Then
            GunaTextBox1.Text = "Username"
            GunaTextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub GunaTextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaTextBox2.MouseClick
        GunaTextBox2.Clear()
        GunaTextBox2.UseSystemPasswordChar = True
        GunaTextBox2.ForeColor = Color.Black
    End Sub

    Private Sub GunaTextBox2_MouseLeave(sender As Object, e As EventArgs) Handles GunaTextBox2.MouseLeave
        If GunaTextBox2.Text = "Password" Or GunaTextBox2.Text = "" Then
            GunaTextBox2.Text = "Password"
            GunaTextBox1.ForeColor = Color.Gray
        End If
    End Sub
End Class