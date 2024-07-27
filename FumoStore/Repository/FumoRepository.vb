Imports iText.StyledXmlParser.Jsoup.Select.Evaluator
Imports MySql.Data.MySqlClient

Public Class FumoRepository
    Public Shared Function All() As DataTable
        Dim query = "SELECT id, nama, harga AS rawharga FROM barang"

        Dim cmd As New MySqlCommand(query, Koneksi.GetKoneksi())
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        Return dataTable
    End Function

    Public Shared Function Find(id As String) As Fumo
        Dim query = "SELECT * FROM barang WHERE id = @id"

        Dim command As New MySqlCommand(query, Koneksi.GetKoneksi())
        command.Parameters.AddWithValue("@id", id)

        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Check if there is any data
        If reader.Read() Then
            Dim fumo = New Fumo(reader("id").ToString(), reader("nama").ToString(), Integer.Parse(reader("harga").ToString()))
            reader.Close()
            Return fumo
        End If

        Return Nothing
    End Function

    Public Shared Function Tambah(fumo As Fumo) As Integer
        Dim query As String = "INSERT INTO barang (nama, harga) VALUES (@nama, @harga)"
        Dim cmd As MySqlCommand = Koneksi.Query(query)

        cmd.Parameters.AddWithValue("@nama", fumo.m_Nama)
        cmd.Parameters.AddWithValue("@harga", fumo.m_Harga)

        Return Convert.ToInt32(cmd.ExecuteNonQuery())
    End Function

    Public Shared Function Update(fumo As Fumo) As Integer
        Dim query As String = "UPDATE barang SET nama= @nama, harga = @harga WHERE id = @id"
        Dim cmd As MySqlCommand = Koneksi.Query(query)

        cmd.Parameters.AddWithValue("@id", fumo.m_Id)
        cmd.Parameters.AddWithValue("@nama", fumo.m_Nama)
        cmd.Parameters.AddWithValue("@harga", fumo.m_Harga)

        Return Convert.ToInt32(cmd.ExecuteNonQuery())
    End Function

    Public Shared Function Hapus(fumo As Fumo) As Boolean
        Dim query As String = "DELETE FROM barang WHERE id = @id"
        Try
            Dim cmd As MySqlCommand = Koneksi.Query(query)

            cmd.Parameters.AddWithValue("@id", fumo.m_Id)

            Dim result As Integer = Convert.ToInt32(cmd.ExecuteNonQuery())

            If result > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            Return False
        End Try
    End Function
End Class
