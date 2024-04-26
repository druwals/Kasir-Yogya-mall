Public Class FrmAgent
    Dim ScalarQry As DbPulsaBoxDataSetTableAdapters.CRUD = New DbPulsaBoxDataSetTableAdapters.CRUD
    Dim bNew As Boolean = False

    Private Sub FrmAgent_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadAgent()
    End Sub

    Private Sub tNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tNO.KeyPress
        If Strings.InStr("1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub Bersih()
        btnTmbh.Enabled = True
        btnTmbh.Text = "Tambah"
        BtnBtl.Enabled = False

        tProvider.Clear()
        tNO.Clear()
        tNama.Clear()
        tAlmt.Clear()

        tProvider.Enabled = False
        tNO.Enabled = False
        tAlmt.Enabled = False
        tNama.Enabled = False
        dgv.Enabled = True
        bNew = False
    End Sub

    Private Sub LoadAgent()
        Me.AgentTableAdapter.Fill(Me.DbPulsaBoxDataSet.Agent)

        dgv.Rows.Clear()
        For i As Integer = 0 To DbPulsaBoxDataSet.Agent.Rows.Count - 1
            dgv.Rows.Add()
            dgv.Rows(dgv.Rows.Count - 1).Cells("dgvId").Value = DbPulsaBoxDataSet.Agent.Rows(i).Item("Id").ToString
            dgv.Rows(dgv.Rows.Count - 1).Cells("dgvNoHp").Value = DbPulsaBoxDataSet.Agent.Rows(i).Item("NoHp").ToString
            dgv.Rows(dgv.Rows.Count - 1).Cells("dgvNama").Value = DbPulsaBoxDataSet.Agent.Rows(i).Item("Nama").ToString
            dgv.Rows(dgv.Rows.Count - 1).Cells("dgvAlamat").Value = DbPulsaBoxDataSet.Agent.Rows(i).Item("Alamat").ToString
        Next
        Bersih()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.ColumnIndex = dgv.Columns("dgvHapus").Index Then
            If MsgBox("Yakin menghapus data ini?", vbYesNo + vbQuestion, "Konfirmasi") = vbYes Then
                ScalarQry.Deleteagent(dgv.CurrentRow.Cells("dgvId").Value)
                dgv.Rows.RemoveAt(e.RowIndex)
            End If
        End If

        If e.ColumnIndex = dgv.Columns("dgvEdit").Index Then
            If MsgBox("Yakin Mengubah data ini?", vbYesNo + vbQuestion, "Konfirmasi") = vbYes Then
                tProvider.Text = dgv.CurrentRow.Cells("dgvId").Value
                tNO.Text = dgv.CurrentRow.Cells("dgvNoHp").Value
                tNama.Text = dgv.CurrentRow.Cells("dgvNama").Value
                tAlmt.Text = dgv.CurrentRow.Cells("dgvAlamat").Value

                tNO.Enabled = True
                tNama.Enabled = True
                tAlmt.Enabled = True
                tNO.Focus()
                btnTmbh.Text = "Simpan"
                BtnBtl.Enabled = True
                dgv.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnTmbh_Click(sender As Object, e As EventArgs) Handles btnTmbh.Click
        If btnTmbh.Text = "Tambah" Then
            btnTmbh.Text = "Simpan"
            BtnBtl.Enabled = True
            tProvider.Enabled = True
            tNama.Enabled = True
            tNO.Enabled = True
            tAlmt.Enabled = True
            bNew = True
            tProvider.Focus()
        Else
            If bNew = True Then
                If Trim(tProvider.Text) = Nothing Then
                    MsgBox("ID harus diisi", vbExclamation, "Peringatan")
                    tProvider.Focus()
                    Exit Sub
                End If
                If Trim(tNO.Text) = Nothing Then
                    MsgBox("No HP harus diisi", vbExclamation, "Peringatan")
                    tProvider.Focus()
                    Exit Sub
                End If
                If Trim(tNama.Text) = Nothing Then
                    MsgBox("Nama harus diisi", vbExclamation, "Peringatan")
                    tProvider.Focus()
                    Exit Sub
                End If
                If Trim(tAlmt.Text) = Nothing Then
                    MsgBox("Alamat harus diisi", vbExclamation, "Peringatan")
                    tProvider.Focus()
                    Exit Sub
                End If

                For i As Integer = 0 To dgv.Rows.Count - 1
                    If dgv.Rows(i).Cells("dgvId").Value = tProvider.Text Then
                        MsgBox("ID sudah terdaftar", vbExclamation, "Peringatan")
                        tProvider.Focus()
                        tProvider.SelectAll()
                        Exit Sub
                    End If
                Next

                ScalarQry.InsertAgent(tProvider.Text, tNO.Text, tNama.Text, tAlmt.Text)
            Else
                ScalarQry.UpdateAgent(tNO.Text, tNama.Text, tAlmt.Text, tProvider.Text)
            End If

            Call LoadAgent()
            Call Bersih()
        End If
    End Sub

    Private Sub BtnBtl_Click(sender As Object, e As EventArgs) Handles BtnBtl.Click
        Call Bersih()
    End Sub

    Private Sub FrmAgent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        FrmDashboard.Text = "Druwal Kasir"
    End Sub

    Private Sub bTtp_Click(sender As Object, e As EventArgs) Handles bTtp.Click
        Me.Close()
    End Sub
End Class