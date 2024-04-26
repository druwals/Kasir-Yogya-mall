Public Class FrmProvider
    Dim ScalarQry As DbPulsaBoxDataSetTableAdapters.CRUD = New DbPulsaBoxDataSetTableAdapters.CRUD
    Dim bNew As Boolean = False

    Private Sub FrmProvider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbPulsaBoxDataSet.Provid' table. You can move, or remove it, as needed.
        Me.ProvidTableAdapter.Fill(Me.DbPulsaBoxDataSet.Provid)
        LoadProvider()
    End Sub

    Private Sub Bersih()
        btnTmbh.Enabled = True
        btnTmbh.Text = "Tambah"
        BtnBtl.Enabled = False
        tProvider.Clear()

        tProvider.Enabled = False
        dgv.Enabled = True
        bNew = False
    End Sub


    Private Sub LoadProvider()
        Me.ProvidTableAdapter.Fill(Me.DbPulsaBoxDataSet.Provid)

        dgv.Rows.Clear()
        For i As Integer = 0 To DbPulsaBoxDataSet.Provid.Rows.Count - 1
            dgv.Rows.Add()
            dgv.Rows(dgv.Rows.Count - 1).Cells("dgvProvider").Value = DbPulsaBoxDataSet.Provid.Rows(i).Item("Provid").ToString
        Next
        Bersih()
    End Sub

    Private Sub BtnBtl_Click(sender As Object, e As EventArgs) Handles BtnBtl.Click
        Bersih()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.RowIndex = dgv.Columns("Column2").Index Then
            If MsgBox("Yakin ingin menghapus data ini?", vbYesNo + vbQuestion, "Konfirmasi") = vbYes Then
                ScalarQry.DeleteProvider(dgv.CurrentRow.Cells("dgvProvider").Value)
                Call Bersih()
            End If
        End If
    End Sub

    Private Sub FrmProvider_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub bTtp_Click(sender As Object, e As EventArgs) Handles bTtp.Click
        Me.Close()
    End Sub

    Private Sub btnTmbh_Click(sender As Object, e As EventArgs) Handles btnTmbh.Click
        If btnTmbh.Text = "Tambah" Then
            btnTmbh.Text = "Simpan"
            BtnBtl.Enabled = True
            tProvider.Enabled = True

            bNew = True
            tProvider.Focus()
        Else
            If bNew = True Then
                If Trim(tProvider.Text) = Nothing Then
                    MsgBox("Provider harus diisi", vbExclamation, "Peringatan")
                    tProvider.Focus()
                    Exit Sub
                End If

                For i As Integer = 0 To dgv.Rows.Count - 1
                    If dgv.Rows(i).Cells("dgvProvider").Value = tProvider.Text Then
                        MsgBox("ID sudah terdaftar", vbExclamation, "Peringatan")
                        tProvider.Focus()
                        tProvider.SelectAll()
                        Exit Sub
                    End If
                Next
                ScalarQry.InsertProvider(tProvider.Text)
            Else
            End If

            Call LoadProvider()
            Call Bersih()
        End If
    End Sub
End Class