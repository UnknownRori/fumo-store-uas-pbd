Imports Google.Protobuf.Reflection
Imports iText.StyledXmlParser.Jsoup.Select.Evaluator

Public Class MasterFumo
    Dim Id As String = "-1"

    Private Sub Kembali()
        Me.Dispose()
    End Sub

    Private Sub Bersih()
        InNama.Text = ""
        InHarga.Text = ""
    End Sub

    Private Sub ModeTambah()
        ID = "-1"
        BtnTambah.Enabled = True
        BtnHapus.Enabled = False
        BtnEdit.Enabled = False
    End Sub

    Private Sub ModeEditDanHapus()
        BtnTambah.Enabled = False
        BtnHapus.Enabled = True
        BtnEdit.Enabled = True
    End Sub

    Private Sub Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Kembali()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Kembali()
    End Sub

    Private Sub Tampil()
        Dim data = FumoRepository.All()
        data.Columns.Add("Harga", GetType(String))
        For Each row As DataRow In data.Rows
            row("Harga") = String.Format(Indonesian.Culture, "{0:C}", row("rawharga"))
        Next
        data.Columns.Remove("rawharga")
        Dim dataView As New DataView(data)

        TableFumo.DataSource = dataView
    End Sub

    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub ClickCell(sender As Object, e As DataGridViewCellEventArgs) Handles TableFumo.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim selectedRow As DataGridViewRow = TableFumo.Rows(e.RowIndex)
                Dim idValue As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
                Dim fumo As Fumo = FumoRepository.Find(idValue)
                Id = idValue
                InNama.Text = fumo.m_Nama
                InHarga.Text = fumo.m_Harga
                ModeEditDanHapus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        Bersih()
        ModeTambah()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim fumo = New Fumo(-1, InNama.Text, InHarga.Text)
        If FumoRepository.Tambah(fumo) Then
            MessageBox.Show("Data berhasil ditambahkan!")
            Tampil()
        Else
            MessageBox.Show("Gagal menambah data!")
        End If
        Bersih()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim fumo = New Fumo(Me.Id, InNama.Text, InHarga.Text)
        ModeTambah()
        If FumoRepository.Hapus(Fumo) Then
            MessageBox.Show("Data berhasil dihapus!")
            Tampil()
        Else
            MessageBox.Show("Gagal menghapus data!")
        End If
        Bersih()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim fumo = New Fumo(Me.Id, InNama.Text, InHarga.Text)
        ModeTambah()
        If fumo.Update(InNama.Text, InHarga.Text) Then
            MessageBox.Show("Data berhasil diupdate!")
            Tampil()
        Else
            MessageBox.Show("Gagal meng-update data!")
        End If
        Bersih()
    End Sub
End Class