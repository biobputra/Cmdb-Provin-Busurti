Imports System.Data

Public Class MasterShiftH

#Region "Properties"

    Private xIDMasterShiftH As Long
    Public Property IDMasterShiftH As Long
        Get
            Return xIDMasterShiftH
        End Get
        Set(value As Long)
            xIDMasterShiftH = value
        End Set
    End Property

    Private xTanggalAwal As Date
    Public Property TanggalAwal As Date
        Get
            Return xTanggalAwal
        End Get
        Set(value As Date)
            xTanggalAwal = value
        End Set
    End Property

    Private xTanggalAkhir As Date
    Public Property TanggalAkhir As Date
        Get
            Return xTanggalAkhir
        End Get
        Set(value As Date)
            xTanggalAkhir = value
        End Set
    End Property

    Private xJudul As String
    Public Property Judul As String
        Get
            Return xJudul
        End Get
        Set(value As String)
            xJudul = value
        End Set
    End Property

    Private xMulai As DateTime
    Public Property Mulai As DateTime
        Get
            Return xMulai
        End Get
        Set(value As DateTime)
            xMulai = value
        End Set
    End Property

    Private xSelesai As DateTime
    Public Property Selesai As DateTime
        Get
            Return xSelesai
        End Get
        Set(value As DateTime)
            xSelesai = value
        End Set
    End Property

#End Region


#Region "Method"

    Public Sub New()

    End Sub

    Public Sub New(ByVal MyIDMasterShiftH As Long, ByVal MyTanggalAwal As Date, ByVal MyTanggalAkhir As Date, ByVal MyJudul As String, ByVal MyMulai As DateTime, ByVal MySelesai As DateTime)
        IDMasterShiftH = MyIDMasterShiftH : TanggalAwal = MyTanggalAwal : TanggalAkhir = MyTanggalAkhir : Judul = MyJudul : Mulai = MyMulai : Selesai = MySelesai
    End Sub


    Shared Function GetMasterShiftHByIDMasterShiftH(ByVal MyIDMasterShiftH As Long) As MasterShiftH
        Dim MymasterShiftH As New MasterShiftH

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Kry_GetMasterShiftHByIDMasterShiftH " & MyIDMasterShiftH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDMasterShiftH")) Then MymasterShiftH.IDMasterShiftH = Convert.ToInt64(.Item("IDMasterShiftH"))
                        If Not IsDBNull(.Item("TanggalAwal")) Then MymasterShiftH.TanggalAwal = Convert.ToDateTime(.Item("TanggalAwal"))
                        If Not IsDBNull(.Item("TanggalAkhir")) Then MymasterShiftH.TanggalAkhir = Convert.ToDateTime(.Item("TanggalAkhir"))
                        If Not IsDBNull(.Item("Judul")) Then MymasterShiftH.Judul = .Item("Judul").ToString
                        If Not IsDBNull(.Item("Mulai")) Then MymasterShiftH.Mulai = Convert.ToDateTime(.Item("Mulai"))
                        If Not IsDBNull(.Item("Selesai")) Then MymasterShiftH.Selesai = Convert.ToDateTime(.Item("Selesai"))
                    End With
                Next
            End If
        End Using

        Return MymasterShiftH
    End Function

    Shared Function GetListMasterShiftHPerPeriode(MyBulan As Integer, MyTahun As Integer) As List(Of MasterShiftH)
        Dim MyListMasterShiftH As New List(Of MasterShiftH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Kry_GetListMasterShiftHPerPeriode " & MyBulan & ", " & MyTahun)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyMasterShiftH = New MasterShiftH()
                    With MyRow
                        If Not IsDBNull(.Item("IDMasterShiftH")) Then MyMasterShiftH.IDMasterShiftH = Convert.ToInt64(.Item("IDMasterShiftH"))
                        If Not IsDBNull(.Item("TanggalAwal")) Then MyMasterShiftH.TanggalAwal = Convert.ToDateTime(.Item("TanggalAwal"))
                        If Not IsDBNull(.Item("TanggalAkhir")) Then MyMasterShiftH.TanggalAkhir = Convert.ToDateTime(.Item("TanggalAkhir"))
                        If Not IsDBNull(.Item("Judul")) Then MyMasterShiftH.Judul = .Item("Judul").ToString
                        If Not IsDBNull(.Item("Mulai")) Then MyMasterShiftH.Mulai = Convert.ToDateTime(.Item("Mulai"))
                        If Not IsDBNull(.Item("Selesai")) Then MyMasterShiftH.Selesai = Convert.ToDateTime(.Item("Selesai"))
                    End With
                Next
            End If
        End Using

        Return MyListMasterShiftH
    End Function

    Shared Function GetListMasterShiftHBerlaku() As List(Of MasterShiftH)
        Dim MyListMasterShiftH As New List(Of MasterShiftH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Kry_GetListMasterShiftHBerlaku")
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyMasterShiftH = New MasterShiftH()
                    With MyRow
                        If Not IsDBNull(.Item("IDMasterShiftH")) Then MyMasterShiftH.IDMasterShiftH = Convert.ToInt64(.Item("IDMasterShiftH"))
                        If Not IsDBNull(.Item("TanggalAwal")) Then MyMasterShiftH.TanggalAwal = Convert.ToDateTime(.Item("TanggalAwal"))
                        If Not IsDBNull(.Item("TanggalAkhir")) Then MyMasterShiftH.TanggalAkhir = Convert.ToDateTime(.Item("TanggalAkhir"))
                        If Not IsDBNull(.Item("Judul")) Then MyMasterShiftH.Judul = .Item("Judul").ToString
                        If Not IsDBNull(.Item("Mulai")) Then MyMasterShiftH.Mulai = Convert.ToDateTime(.Item("Mulai"))
                        If Not IsDBNull(.Item("Selesai")) Then MyMasterShiftH.Selesai = Convert.ToDateTime(.Item("Selesai"))
                    End With
                Next
            End If
        End Using

        Return MyListMasterShiftH
    End Function

#End Region

End Class
