Public Class productos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Recfotos()

    End Sub

    Protected Sub ddlSeleccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSeleccion.SelectedIndexChanged

        Dim seleccion As String = ddlSeleccion.SelectedValue

        Select Case seleccion
            Case "PorNombre"
                RecPorNombre()
            Case "Normal"
                Recfotos()
            Case "Precio"
                RecPorPrecio()
            Case "Stock"
                RecPorStock()

        End Select

    End Sub

    Private Sub Recfotos()

        Dim objRecupera As New claRecuperar
        Dim dtsDataSet As New DataSet
        Dim intRetorno As Integer

        intRetorno = objRecupera.recFotos(dtsDataSet)

        If intRetorno > 0 Then

            repProductos.DataSource = dtsDataSet.Tables("imagenes")
            repProductos.DataBind()

        End If

    End Sub

    Private Sub RecPorNombre()

        Dim objRecupera As New claRecuperar
        Dim dtsDataSet As New DataSet
        Dim intRetorno As Integer

        intRetorno = objRecupera.recFotosporNomb(dtsDataSet)

        If intRetorno > 0 Then

            repProductos.DataSource = dtsDataSet.Tables("imagenes")
            repProductos.DataBind()

        End If

    End Sub
    Private Sub RecPorPrecio()

        Dim objRecupera As New claRecuperar
        Dim dtsDataSet As New DataSet
        Dim intRetorno As Integer

        intRetorno = objRecupera.recFotosporPrecio(dtsDataSet)

        If intRetorno > 0 Then

            repProductos.DataSource = dtsDataSet.Tables("imagenes")
            repProductos.DataBind()

        End If

    End Sub

    Private Sub RecPorStock()

        Dim objRecupera As New claRecuperar
        Dim dtsDataSet As New DataSet
        Dim intRetorno As Integer

        intRetorno = objRecupera.recFotosporStock(dtsDataSet)

        If intRetorno > 0 Then

            repProductos.DataSource = dtsDataSet.Tables("imagenes")
            repProductos.DataBind()

        End If

    End Sub

End Class