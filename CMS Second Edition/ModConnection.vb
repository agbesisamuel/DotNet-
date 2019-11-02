Module ModConnection
    Dim conn As String = "Data Source= (Local);Initial Catalog=CMSDATA;Integrated Security=True"
    Public strAccountType As String
    Public CMSConnection As New SqlClient.SqlConnection(conn)
    Public UserID As String
    Public sqlStatement As String
    Public mySql As New SqlClient.SqlCommand(sqlStatement, CMSConnection)
    Public MyPict As ADODB.Stream
End Module


