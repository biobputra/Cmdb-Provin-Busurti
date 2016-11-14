Public Class MasterShiftD

#Region "Properties"

    Private xIDMasterShiftH As Long
    Public Property IDMasterShiftH() As Long
        Get
            Return xIDMasterShiftH
        End Get
        Set(ByVal value As Long)
            xIDMasterShiftH = value
        End Set
    End Property

    Private xIDMasterShiftD As Long
    Public Property IDMasterShiftD() As Long
        Get
            Return xIDMasterShiftD
        End Get
        Set(ByVal value As Long)
            xIDMasterShiftD = value
        End Set
    End Property

    Private xIDKaryawan As Long
    Public Property IDKaryawan() As Long
        Get
            Return xIDKaryawan
        End Get
        Set(ByVal value As Long)
            xIDKaryawan = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Sub New()

    End Sub

    Public Sub New(ByVal MyIDMasterShiftH As Long, ByVal MyIDMasterShiftD As Long, ByVal MyIDKaryawan As Long)
        IDMasterShiftH = MyIDMasterShiftH : IDMasterShiftD = MyIDMasterShiftD : IDKaryawan = MyIDKaryawan
    End Sub

    Shared Function GetListMasterShiftDByIDMasterShiftH(MyIDMasterShiftH As Long) As List(Of MasterShiftD)
        Dim MyListMasterShiftD As New List(Of MasterShiftD)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Kry_GetListMasterShiftDByIDMasterShiftH " & MyIDMasterShiftH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyMasterShiftD = New MasterShiftD()
                    With MyRow
                        If Not IsDBNull(.Item("IDMasterShiftH")) Then MyMasterShiftD.IDMasterShiftH = Convert.ToInt64(.Item("IDMasterShiftH"))
                        If Not IsDBNull(.Item("IDMasterShiftD")) Then MyMasterShiftD.IDMasterShiftD = Convert.ToInt64(.Item("IDMasterShiftD"))
                        If Not IsDBNull(.Item("IDKaryawan")) Then MyMasterShiftD.IDKaryawan = Convert.ToInt64(.Item("IDKaryawan"))
                    End With
                Next
            End If
        End Using

        Return MyListMasterShiftD
    End Function


#End Region
End Class
