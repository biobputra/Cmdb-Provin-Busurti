Imports DevExpress.XtraBars.Alerter
Module GlobalModule

    Public MyAlert As New AlertControl

    Public MyLoggedInPengguna As New Pengguna()

    Sub DeleteData(NamaTabel As String, MyPrimaryKey As Integer, IDPengguna As Integer)
        DataAccess.SQLNonQuery("EXEC App_Delete " & NamaTabel & " , " & MyPrimaryKey & "," & IDPengguna)
    End Sub
End Module
