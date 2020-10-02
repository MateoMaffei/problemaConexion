Public Class claRecuperar
    Inherits claConexion

    Public Function recFotos(ByRef ARdataSet As DataSet) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select *,LTRIM(RTRIM([imagenes].[url])) AS 'url-imagen',case when stock = '1' then 'En stock'
              when stock = '0' then 'Sin Stock' 
			  END AS stockkkk from imagenes"

        intRetorno = Me.RecuperardataSet(ARdataSet, strSql, "imagenes")

        Return intRetorno

    End Function
    Public Function recFotosporNomb(ByRef ARdataSet As DataSet) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select *,LTRIM(RTRIM([imagenes].[url])) as 'url-imagen',case when stock = '1' then 'En stock'
              when stock = '0' then 'Sin Stock' 
			  END AS stockkkk from imagenes order by nombre"

        intRetorno = Me.RecuperardataSet(ARdataSet, strSql, "imagenes")

        Return intRetorno

    End Function

    Public Function recFotosporPrecio(ByRef ARdataSet As DataSet) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select *,LTRIM(RTRIM([imagenes].[url])) as 'url-imagen',case when stock = '1' then 'En stock'
              when stock = '0' then 'Sin Stock' 
			  END AS stockkkk from imagenes order by precio"

        intRetorno = Me.RecuperardataSet(ARdataSet, strSql, "imagenes")

        Return intRetorno

    End Function

    Public Function recFotosporStock(ByRef ARdataSet As DataSet) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select *,
		 LTRIM(RTRIM([imagenes].[url])) as 'url-imagen',
		 case when stock = '1' then 'En stock'
              when stock = '0' then 'Sin Stock' 
			  END AS stockkkk
			  from imagenes 
			  where stock='true'"

        intRetorno = Me.RecuperardataSet(ARdataSet, strSql, "imagenes")

        Return intRetorno

    End Function

End Class
