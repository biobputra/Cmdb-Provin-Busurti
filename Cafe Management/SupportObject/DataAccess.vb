Imports System.Data
Imports System.Data.SqlClient

Imports System.IO
Public Class DataAccess
    Shared SQLConnectionString As String

    Shared Function TestConnection() As Boolean
        If Not File.Exists(Application.StartupPath & "\cfg.txt") Then
            
            Return False
            Exit Function
        End If

        Dim MyString As String = File.ReadAllText(Application.StartupPath & "\cfg.txt")
        Dim MyArrayString() As String = Split(MyString,"<!Split>")

        SQLConnectionString = "Server=" & MyArrayString(0) & ";Database=" & MyArrayString(1) & ";User Id=" & MyArrayString(2) & ";Password=" & MyArrayString(3) & ";"

        My.Settings.Item("connString") = SQLConnectionString
        If SQLConnectionString = "" Then

            MsgBox("Connection string is not yer defined !")
            Return False
            Exit Function
        End If

        Dim MySQLConnection As New SqlConnection(SQLConnectionString)
        Try
            MySQLConnection.Open()
      MySQLConnection.Close()
      Settings.Default("connString") = String.Format(SQLConnectionString)



            Return True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            MySQLConnection.Close()
            Return False
        End Try
    End Function

    Shared Function GetSingleValue(ByVal QueryString As String) As String
        Dim MyValue As String = ""
        Using MySQLConnection As New SqlConnection(SQLConnectionString)
            Dim MySQLCommand As New SqlCommand("", MySQLConnection)
            Dim MySQLDataReader As SqlDataReader
            MySQLConnection.Open()
            Try

                MySQLCommand.CommandText = QueryString
                MySQLDataReader = MySQLCommand.ExecuteReader
                MySQLDataReader.Read()
                MyValue = CType(MySQLDataReader(0), String)
                MySQLConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                MySQLConnection.Close()
            End Try
        End Using
        Return MyValue
    End Function

    Public Shared Function ExecuteQueryTable(ByVal QueryString As String) As DataTable
        Dim MyDataTable As DataTable

        Using MySQLConnection As New SqlConnection(SQLConnectionString)
            MySQLConnection.Open()

            Dim MyTransaction As SqlTransaction
            MyTransaction = MySQLConnection.BeginTransaction()
            Try
                Dim MySQLCommand As New SqlCommand(QueryString, MySQLConnection)
                MySQLCommand.CommandTimeout = 3000

                Dim MyDataAdapter As New SqlDataAdapter(MySQLCommand)
                MyDataTable = New DataTable
                MyTransaction.Commit()
                MyDataAdapter.Fill(MyDataTable)

                Return MyDataTable
                MySQLConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Try
                    MyTransaction.Rollback()
                Catch exs As Exception
                End Try
                MySQLConnection.Close()
                Return Nothing
            End Try
        End Using
    End Function

    Shared Sub SQLNonQuery(ByVal QueryString As String)
        Using MySQLConnection As New SqlConnection(SQLConnectionString)
            MySQLConnection.Open()

            Dim MyTransaction As SqlTransaction
            MyTransaction = MySQLConnection.BeginTransaction()
            Try
                Dim MySQLCommand As New SqlCommand(QueryString, MySQLConnection, MyTransaction)
                MySQLCommand.CommandTimeout = 3000
                MySQLCommand.ExecuteNonQuery()
                MyTransaction.Commit()
                MySQLConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                MyTransaction.Rollback()
                MySQLConnection.Close()
            End Try
        End Using
    End Sub

    Shared Sub SQLNonQuery(ByVal QueryString As List(Of String))
        Using MySQLConnection As New SqlConnection(SQLConnectionString)
            MySQLConnection.Open()

            Dim MyTransaction As SqlTransaction
            MyTransaction = MySQLConnection.BeginTransaction()
            Try
                Dim MySQLCommand As New SqlCommand("", MySQLConnection, MyTransaction)
                MySQLCommand.CommandTimeout = 3000

                For Each item As String In QueryString
                    MySQLCommand.CommandText = item
                    MySQLCommand.ExecuteNonQuery()
                Next

                MyTransaction.Commit()
                MySQLConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                MyTransaction.Rollback()
                MySQLConnection.Close()
            End Try
        End Using
    End Sub

End Class
