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
End Class
