Public Class Fumo
    Public m_Id As String
    Public m_Nama As String
    Public m_Harga As Integer

    Public Sub New(id As String, nama As String, harga As Integer)
        Me.m_Id = id
        Me.m_Nama = nama
        Me.m_Harga = harga
    End Sub

    Public Function Update(nama As String, harga As Integer) As Boolean
        Me.m_Nama = nama
        Me.m_Harga = harga
        Return FumoRepository.Update(Me)
    End Function
End Class
