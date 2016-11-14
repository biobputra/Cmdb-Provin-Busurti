Imports System.Data

Public Class JurnalH

#Region "declaretion"

    Private xIDJurnalH As Long
    Public Property IDJurnalH As Long
        Get
            Return xIDJurnalH
        End Get
        Set(value As Long)
            xIDJurnalH = value
        End Set
    End Property

    Private xTanggal As Date
    Public Property Tanggal As Date
        Get
            Return xTanggal
        End Get
        Set(value As Date)
            xTanggal = value
        End Set
    End Property

    Private xSumber As String
    Public Property Sumber As String
        Get
            Return xSumber
        End Get
        Set(value As String)
            xSumber = value
        End Set
    End Property

    Private xIDTransaksi As Long
    Public Property IDTransaksi As Long
        Get
            Return xIDTransaksi
        End Get
        Set(value As Long)
            xIDTransaksi = value
        End Set
    End Property

    Private xKeterangan As String
    Public Property Keterangan As String
        Get
            Return xKeterangan
        End Get
        Set(value As String)
            xKeterangan = value
        End Set
    End Property

    Private xStatusAktif As Boolean
    Public Property StatusAktif As Boolean
        Get
            Return xStatusAktif
        End Get
        Set(value As Boolean)
            xStatusAktif = value
        End Set
    End Property

    Private xIsCredited As Boolean
    Public Property IsCredited As Boolean
        Get
            Return xIsCredited
        End Get
        Set(value As Boolean)
            xIsCredited = value
        End Set
    End Property

    Private xIDJurnalKredit As Long
    Public Property IDJurnalKredit As Long
        Get
            Return xIDJurnalKredit
        End Get
        Set(value As Long)
            xIDJurnalKredit = value
        End Set
    End Property

#End Region


#Region "Methods"
    Public Sub New()

    End Sub

    Public Sub New(ByVal MyIDJurnalH As Long, ByVal MyTanggal As Date, ByVal MySumber As String, ByVal MyIDTransaksi As Long, MyKeterangan As String, MyStatusAktif As Boolean, MyIsCredited As Boolean, MyIDJurnalKredit As Long)
        IDJurnalH = MyIDJurnalH : Tanggal = MyTanggal : Sumber = MySumber : IDTransaksi = MyIDTransaksi : Keterangan = MyKeterangan : StatusAktif = MyStatusAktif : IsCredited = MyIsCredited : IDJurnalKredit = MyIDJurnalKredit
    End Sub

    Shared Function GetJurnalHByIDJurnalH(MyIDJurnalH As Long) As JurnalH
        Dim MyJurnalH As New JurnalH()

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Acc_GetJurnalHByIDJurnalH " & MyIDJurnalH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDJurnalH")) Then MyJurnalH.IDJurnalH = Convert.ToInt64(.Item("IDJurnalH"))
                        If Not IsDBNull(.Item("Tanggal")) Then MyJurnalH.Tanggal = Convert.ToDateTime(.Item("Tanggal"))
                        If Not IsDBNull(.Item("Sumber")) Then MyJurnalH.Sumber = .Item("Sumber").ToString
                        If Not IsDBNull(.Item("IDTransaksi")) Then MyJurnalH.IDTransaksi = Convert.ToInt64(.Item("IDTransaksi"))
                        If Not IsDBNull(.Item("Keterangan")) Then MyJurnalH.Keterangan = .Item("Keterangan").ToString
                        If Not IsDBNull(.Item("StatusAktif")) Then MyJurnalH.StatusAktif = Convert.ToBoolean(.Item("StatusAktif"))
                        If Not IsDBNull(.Item("IsCredited")) Then MyJurnalH.IsCredited = Convert.ToBoolean(.Item("IsCredited"))
                        If Not IsDBNull(.Item("IDJurnalKredit")) Then MyJurnalH.IDJurnalKredit = Convert.ToInt64(.Item("IDJurnalKredit"))
                    End With
                Next
            End If
        End Using

        Return MyJurnalH
    End Function

    Shared Function GetListJurnalHPerbulanAktif(MyBulan As Integer, MyTahun As Integer) As List(Of JurnalH)
        Dim MyListJurnalH As New List(Of JurnalH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Acc_GetListJurnalHPerbulanAktif " & MyBulan & ", " & MyTahun)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyJurnalH = New JurnalH()
                    With MyRow
                        If Not IsDBNull(.Item("IDJurnalH")) Then MyJurnalH.IDJurnalH = Convert.ToInt64(.Item("IDJurnalH"))
                        If Not IsDBNull(.Item("Tanggal")) Then MyJurnalH.Tanggal = Convert.ToDateTime(.Item("Tanggal"))
                        If Not IsDBNull(.Item("Sumber")) Then MyJurnalH.Sumber = .Item("Sumber").ToString
                        If Not IsDBNull(.Item("IDTransaksi")) Then MyJurnalH.IDTransaksi = Convert.ToInt64(.Item("IDTransaksi"))
                        If Not IsDBNull(.Item("Keterangan")) Then MyJurnalH.Keterangan = .Item("Keterangan").ToString
                        If Not IsDBNull(.Item("StatusAktif")) Then MyJurnalH.StatusAktif = Convert.ToBoolean(.Item("StatusAktif"))
                        If Not IsDBNull(.Item("IsCredited")) Then MyJurnalH.IsCredited = Convert.ToBoolean(.Item("IsCredited"))
                        If Not IsDBNull(.Item("IDJurnalKredit")) Then MyJurnalH.IDJurnalKredit = Convert.ToInt64(.Item("IDJurnalKredit"))
                    End With
                Next
            End If
        End Using

        Return MyListJurnalH
    End Function

#End Region

End Class
