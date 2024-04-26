Imports System
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Public Class FrmDashboard

    Private currentChildForm As Form

    Private Sub BtnHome_Click(ByVal sender As Object, ByVal e As EventArgs)
        currentChildForm.Close()
        Reset()
    End Sub

    Private Sub Reset()
        ' IconCurrentChildForm.IconColor = Color.MediumPurple
        lblTitleChildForm.Text = "Home"
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelTitleBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Structure RGBColors
        Public Shared color1 As Color = Color.FromArgb(172, 126, 241)
        Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
        Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
        Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
        Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
        Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
        Public Shared color7 As Color = Color.FromArgb(149, 100, 55)
        Public Shared color8 As Color = Color.FromArgb(10, 151, 201)
    End Structure


    Private Sub OpenChildForm(ByVal childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnChildForm.Controls.Add(childForm)
        pnChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblTitleChildForm.Text = childForm.Text
    End Sub

    Private Sub FrmDashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FrmLogin.ShowDialog()
    End Sub

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.IsMdiContainer = True
        pnChildForm.BackgroundImage = Image.FromFile("bgaplikasi.png")
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub AgentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgentToolStripMenuItem1.Click
        OpenChildForm(New FrmAgent)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        FrmLogin.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Ingin keluar dari aplikasi?", vbYesNo + vbQuestion, "Konfirmasi") = vbYes Then
            End
        End If
    End Sub

    Private Sub ProviderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProviderToolStripMenuItem.Click
        OpenChildForm(FrmProvider)
    End Sub
End Class
