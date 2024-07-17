Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Koneksi
    Public Shared m_connStr As String = "server=localhost;user=root;database=aruskas;port=3306;password=;"
    Public Shared m_conn As New MySqlConnection(m_connStr)

    Public Shared Function Konek() As Boolean
        Try
            m_conn.Open()
            MessageBox.Show("Koneksi Berhasil")
            Return True
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function GetKoneksi() As MySqlConnection
        Return m_conn
    End Function

    Public Shared Function Query(queryString As String) As MySqlCommand
        Return New MySqlCommand(queryString, Koneksi.GetKoneksi())
    End Function
End Class