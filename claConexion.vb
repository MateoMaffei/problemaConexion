Imports System.Data.SqlClient

Public Class claConexion


    Public Function conectarBD(ByRef objConexion As SqlConnection) As Integer

        Dim strconexion As String

        strconexion = "Data Source=DESKTOP-5LPGIL1;Initial Catalog=zulupage;Integrated Security=True"
        'strconexion = "Data Source=SQL5080.site4now.net;Initial Catalog=DB_A68458_Ateo19;User Id=DB_A68458_Ateo19_admin;Password=Nokialumia520;"
        'strconexion="Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;Initial Catalog=myDataBase;User ID=DB_A68458_Ateo19_admin;Password=Password=Nokialumia520;"
        'strconexion = "Provider=SQLOLEDB;Data Source=SQL5080.site4now.net;Initial Catalog=DB_A68458_Ateo19;User Id=DB_A68458_Ateo19_admin;Password=Nokialumia520;"


        objConexion.ConnectionString = strconexion

        objConexion.Open()

        Return 1

    End Function

    Public Function RecuperardataSet(ByRef dtsDatos As DataSet, ByVal strSqltext As String, ByVal strTabla As String) As Integer

        Dim intRetorno As Integer
        Dim objConexion2 As SqlConnection

        objConexion2 = New SqlConnection
        Me.conectarBD(objConexion2)

        Dim objCommand As New SqlCommand(strSqltext, objConexion2)
        Dim objAdapter As New SqlDataAdapter
        objAdapter.SelectCommand = objCommand
        intRetorno = objAdapter.Fill(dtsDatos, strTabla)
        objConexion2.Close()
        objConexion2 = Nothing

        Return intRetorno


    End Function


End Class
