﻿Public Class Dashboard

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim tanya
        tanya = MessageBox.Show("Anda Yakin Ingin Keluar ??", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            End
        End If
    End Sub

    Private Sub Menu_utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_tgl.Text = Format(Today, "ddd, MMMM yyyy")
        lbl_jam.Text = Format(Now, "hh:mm tt")

        GunaButton1.BaseColor = Color.FromArgb(16, 128, 230)
        GunaButton1.Image = Games_Dashboard.My.Resources.Resources.dashboard

        GunaButton2.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton2.Image = Games_Dashboard.My.Resources.Resources.console__1_
        GunaButton3.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton3.Image = Games_Dashboard.My.Resources.Resources.user
        GunaButton4.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton4.Image = Games_Dashboard.My.Resources.Resources.information__1_

        panel_dashboard.Visible = True
        Panel_allgames.Visible = False
        panel_account.Visible = False
        panel_info.Visible = False


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        'If PictureBox1.ImageLocation = "" Then
        '    login_atau_sign_in.Show()
        'End If
    End Sub

    Private Sub GunaButton11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        GunaButton1.BaseColor = Color.FromArgb(16, 128, 230)
        GunaButton1.Image = Games_Dashboard.My.Resources.Resources.dashboard

        GunaButton2.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton2.Image = Games_Dashboard.My.Resources.Resources.console__1_
        GunaButton3.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton3.Image = Games_Dashboard.My.Resources.Resources.user
        GunaButton4.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton4.Image = Games_Dashboard.My.Resources.Resources.information__1_

        panel_dashboard.Visible = True
        Panel_allgames.Visible = False
        panel_account.Visible = False
        panel_info.Visible = False
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        GunaButton2.BaseColor = Color.FromArgb(16, 128, 230)
        GunaButton2.Image = Games_Dashboard.My.Resources.Resources.games

        GunaButton1.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton1.Image = Games_Dashboard.My.Resources.Resources.menu__3_
        GunaButton3.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton3.Image = Games_Dashboard.My.Resources.Resources.user
        GunaButton4.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton4.Image = Games_Dashboard.My.Resources.Resources.information__1_

        panel_dashboard.Visible = False
        Panel_allgames.Visible = True
        panel_account.Visible = False
        panel_info.Visible = False

        GunaPanel5.Visible = True
        GunaPanel6.Visible = False
        GunaPanel3.Visible = True
        GunaPanel4.Visible = False
        GunaPanel1.Visible = True
        GunaPanel2.Visible = False
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        GunaButton3.BaseColor = Color.FromArgb(16, 128, 230)
        GunaButton3.Image = Games_Dashboard.My.Resources.Resources.user__1_

        GunaButton1.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton1.Image = Games_Dashboard.My.Resources.Resources.menu__3_
        GunaButton2.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton2.Image = Games_Dashboard.My.Resources.Resources.console__1_
        GunaButton4.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton4.Image = Games_Dashboard.My.Resources.Resources.information__1_

        panel_dashboard.Visible = False
        Panel_allgames.Visible = False
        panel_account.Visible = True
        panel_info.Visible = False
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        GunaButton4.BaseColor = Color.FromArgb(16, 128, 230)
        GunaButton4.Image = Games_Dashboard.My.Resources.Resources.info_button

        GunaButton1.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton1.Image = Games_Dashboard.My.Resources.Resources.menu__3_
        GunaButton2.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton2.Image = Games_Dashboard.My.Resources.Resources.console__1_
        GunaButton3.BaseColor = Color.FromArgb(25, 27, 31)
        GunaButton3.Image = Games_Dashboard.My.Resources.Resources.user

        panel_dashboard.Visible = False
        Panel_allgames.Visible = False
        panel_account.Visible = False
        panel_info.Visible = True
        GunaPanel1.Visible = True
        GunaPanel2.Visible = False
    End Sub

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.Click
        '    If PictureBox1.ImageLocation = "" Then
        '        Me.Hide()
        '        login_atau_sign_in.Show()
        '    End If
    End Sub

    Private Sub GunaPanel1_MouseHover(sender As Object, e As EventArgs) Handles GunaPanel1.MouseHover, Label11.MouseHover
        GunaPanel1.Visible = False
        GunaPanel2.Visible = True
    End Sub

    Private Sub GunaPanel3_MouseHover(sender As Object, e As EventArgs) Handles GunaPanel3.MouseHover, Label12.MouseHover
        GunaPanel3.Visible = False
        GunaPanel4.Visible = True
    End Sub

    Private Sub GunaPanel5_MouseHover(sender As Object, e As EventArgs) Handles GunaPanel5.MouseHover, Label28.MouseHover
        GunaPanel5.Visible = False
        GunaPanel6.Visible = True
    End Sub

    Private Sub GunaPanel2_MouseLeave(sender As Object, e As EventArgs) Handles GunaPanel2.MouseLeave
        GunaPanel1.Visible = True
        GunaPanel2.Visible = False
    End Sub

    Private Sub GunaPanel4_MouseLeave(sender As Object, e As EventArgs) Handles GunaPanel4.MouseLeave
        GunaPanel3.Visible = True
        GunaPanel4.Visible = False
    End Sub

    Private Sub GunaPanel6_MouseLeave(sender As Object, e As EventArgs) Handles GunaPanel6.MouseLeave
        GunaPanel5.Visible = True
        GunaPanel6.Visible = False
    End Sub

    Private Sub GunaPanel7_MouseHover(sender As Object, e As EventArgs) Handles GunaPanel7.MouseHover
        GunaPanel7.Hide()
        GunaPanel8.Show()
    End Sub

    Private Sub GunaPanel8_MouseLeave(sender As Object, e As EventArgs) Handles GunaPanel8.MouseLeave
        GunaPanel8.Hide()
        GunaPanel7.Show()
    End Sub

    Private Sub GunaPanel9_MouseHover(sender As Object, e As EventArgs) Handles GunaPanel9.MouseHover
        GunaPanel9.Visible = False
        GunaPanel10.Visible = True
    End Sub

    Private Sub GunaPanel10_MouseLeave(sender As Object, e As EventArgs) Handles GunaPanel10.MouseLeave
        GunaPanel10.Visible = False
        GunaPanel9.Visible = True
    End Sub

    Private Sub GunaPanel11_MouseHover(sender As Object, e As EventArgs) Handles GunaPanel11.MouseHover
        GunaPanel11.Visible = False
        GunaPanel12.Visible = True
    End Sub

    Private Sub GunaPanel12_MouseLeave(sender As Object, e As EventArgs) Handles GunaPanel12.MouseLeave
        GunaPanel12.Visible = False
        GunaPanel11.Visible = True
    End Sub
End Class