Imports iText.StyledXmlParser.Jsoup.Select.Evaluator

Public Class TransaksiFumo
    Dim m_fumos As List(Of Fumo) = New List(Of Fumo)
    Dim m_table As DataTable = New DataTable
    Dim total_harga = 0
    Dim m_index = 1
    Dim NO = -1

    Private Sub Kembali()
        Me.Dispose()
    End Sub

    Private Sub Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Kembali()
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        Kembali()
    End Sub

    Private Sub Bersih()
        fumoComboBox.SelectedIndex = -1
        InJumlah.Text = ""
        TotalHarga.Text = ""
    End Sub

    Private Sub ModeTambah()
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        BtnTambah.Enabled = True
        NO = -1
    End Sub

    Private Sub ModeEditDanHapus()
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
        BtnTambah.Enabled = False
    End Sub

    Private Sub TransaksiFumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fumoRaw = FumoRepository.All()
        For Each row As DataRow In fumoRaw.Rows
            Dim fumo = New Fumo(row("id"), row("nama"), row("rawharga"))
            fumoComboBox.Items.Add(fumo.m_Nama & " - " & fumo.m_Harga)
            m_fumos.Add(fumo)
        Next
        m_table.Columns.Add("no", GetType(String))
        m_table.Columns.Add("id", GetType(String))
        m_table.Columns.Add("nama", GetType(String))
        m_table.Columns.Add("jumlah", GetType(String))
        m_table.Columns.Add("rawharga", GetType(Integer))
        m_table.Columns.Add("rawtotal", GetType(Integer))

        UpdateTampil()
        ModeTambah()
    End Sub

    Private Sub UpdateTampil()
        total_harga = 0
        Dim clone = m_table.Copy()
        clone.Columns.Add("harga")

        For Each row As DataRow In clone.Rows
            row("harga") = String.Format(Indonesian.Culture, "{0:C}", row("rawharga"))
        Next
        clone.Columns.Add("total")
        For Each row As DataRow In clone.Rows
            total_harga += Val(row("rawtotal"))
            row("total") = String.Format(Indonesian.Culture, "{0:C}", Val(row("rawtotal")))
        Next
        clone.Columns.Remove("rawharga")
        clone.Columns.Remove("rawtotal")
        TotalHargaTampil.Text = String.Format(Indonesian.Culture, "{0:C}", total_harga)
        TableTransaksi.DataSource = New DataView(clone)
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim Index = fumoComboBox.SelectedIndex()
        If Index < 0 Or Index > m_fumos.Count Then
            MsgBox("Belum memilih barang")
            Return
        End If

        Try
            Dim fumo = m_fumos(Index)
            Dim row = m_table.NewRow()
            row("no") = m_index
            row("id") = fumo.m_Id
            row("nama") = fumo.m_Nama
            row("jumlah") = InJumlah.Text
            row("rawharga") = fumo.m_Harga
            row("rawtotal") = fumo.m_Harga * Val(InJumlah.Text)
            m_table.Rows.Add(row)

            UpdateTampil()
            m_index += 1
        Catch ex As Exception
            MsgBox("Harga tidak berbentuk angka")
        End Try
    End Sub

    Private Sub InJumlah_TextChanged(sender As Object, e As EventArgs) Handles InJumlah.TextChanged
        Dim Index = fumoComboBox.SelectedIndex()
        If Index < 0 Or Index > m_fumos.Count Then
            Return
        End If
        Try
            Dim fumo = m_fumos(Index)
            ' TotalHarga.Text = fumo.m_Harga * Val(InJumlah.Text)
            TotalHarga.Text = String.Format(Indonesian.Culture, "{0:C}", fumo.m_Harga * Val(InJumlah.Text))
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ClickCell(sender As Object, e As DataGridViewCellEventArgs) Handles TableTransaksi.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim selectedRow As DataGridViewRow = TableTransaksi.Rows(e.RowIndex)
                Dim idValue As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
                Dim fumo As Fumo = FumoRepository.Find(idValue)
                NO = e.RowIndex
                Dim index = 0
                For Each fumo In m_fumos
                    If String.Compare(fumo.m_Id, idValue) = 0 Then
                        Exit For
                    End If
                    index += 1
                Next
                fumoComboBox.SelectedIndex = index
                InJumlah.Text = selectedRow.Cells("jumlah").Value
                ModeEditDanHapus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        ModeTambah()
        Bersih()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            Dim row = m_table.Rows(NO)
            Dim idValue As Integer = Convert.ToInt32(row("id").Value)
            Dim fumo As Fumo = FumoRepository.Find(idValue)
            row("jumlah") = InJumlah.Text
            row("total") = Val(InJumlah.Text) * fumo.m_Harga
            UpdateTampil()
        Catch ex As Exception
            MessageBox.Show("Data tidak valid")
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        m_table.Columns.RemoveAt(NO)
        UpdateTampil()
    End Sub

    Private Sub InBayar_TextChanged(sender As Object, e As EventArgs) Handles InBayar.TextChanged
        Kembalian.Text = String.Format(Indonesian.Culture, "{0:C}", Val(InBayar.Text) - total_harga)
    End Sub

    Private Sub fumoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fumoComboBox.SelectedIndexChanged
        Dim Index = fumoComboBox.SelectedIndex()
        If Index < 0 Or Index > m_fumos.Count Then
            Return
        End If
        Try
            Dim fumo = m_fumos(Index)
            ' TotalHarga.Text = fumo.m_Harga * Val(InJumlah.Text)
            TotalHarga.Text = String.Format(Indonesian.Culture, "{0:C}", fumo.m_Harga * Val(InJumlah.Text))
        Catch ex As Exception
        End Try
    End Sub
End Class