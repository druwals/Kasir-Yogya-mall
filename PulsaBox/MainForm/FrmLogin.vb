Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbPulsaBoxDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DbPulsaBoxDataSet.Users)
        tPassword.UseSystemPasswordChar = True
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If MsgBox("Ingin keluar dari aplikasi?", vbYesNo + vbQuestion, "Konfirmasi") = vbYes Then
            Me.Dispose()
            End
        End If
    End Sub

    Private Sub cekLogin()
        Try
            Dim Dr() As DataRow = DbPulsaBoxDataSet.Users.Select("Username ='" & tUsername.Text & "' AND Pass='" & tPassword.Text & "'")
            If Dr.Length = 0 Then
                MsgBox("Username atau Password salah!", vbExclamation, "Peringatan")
                tUsername.Clear()
                tPassword.Clear()
                tUsername.Focus()
            Else
                FrmDashboard.Text = "Dashboard - " & tUsername.Text & " -- " & Dr(0)("Lvl")

                If Dr(0)("Lvl").ToString = "Kasir" Then
                    FrmDashboard.MasterDataToolStripMenuItem.Enabled = False
                ElseIf Dr(0)("Lvl").ToString = "Admin" Then
                    FrmDashboard.MasterDataToolStripMenuItem.Enabled = True
                End If

                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call cekLogin()
    End Sub

    Private Sub tUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles tUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            tPassword.Focus()
        End If
    End Sub

    Private Sub tPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin_Click(e, AcceptButton)
        End If
    End Sub
End Class