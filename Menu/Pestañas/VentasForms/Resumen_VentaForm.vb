Imports Entidad
Imports Negocio
Public Class ResumenVentaForm
    Dim fecha = DateTime.Now
    Dim consulta As Consulta_Venta = New Consulta_Venta

    Private Sub ResumenVentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ACarritoResumen()

        'OrdenarDatos()
        lblTotal.Text = total_Ventas.ToString
    End Sub




    '------------*******************---------------*****************------------***********


    Private Function getListOfItems() As List(Of entidadVentaItem)
        Dim listItems As New List(Of entidadVentaItem)

        For Each row As DataGridViewRow In dgvResumen.Rows
            Dim itemVenta As New entidadVentaItem
            itemVenta.IdProducto = CInt(row.Cells(0).Value)
            itemVenta.PrecioUnidad = CDbl(row.Cells(2).Value)
            itemVenta.Cantidad = CDbl(row.Cells(3).Value)
            itemVenta.Total = CDbl(row.Cells(4).Value)

            'para evitar que agregue el total como item.
            If itemVenta.IdProducto <> 0 Then
                listItems.Add(itemVenta)
            End If

        Next

        Return listItems
    End Function

    Private Sub ACarritoResumen()

        For a As Integer = 0 To VentasForm.dgvCarrito.Rows.Count - 1

            Dim dato As String = VentasForm.dgvCarrito.Item(1, a).Value
            If Not dato = "" Then

                Dim Id As Integer = VentasForm.dgvCarrito.Item(0, a).Value
                Dim nombre As String = VentasForm.dgvCarrito.Item(0, a).Value
                Dim precioUnidad As Decimal = VentasForm.dgvCarrito.Item(2, a).Value
                Dim cantidad As Integer = VentasForm.dgvCarrito.Item(3, a).Value
                Dim preTotal As Decimal = VentasForm.dgvCarrito.Item(4, a).Value

                dgvResumen.Rows.Add(Id, nombre, precioUnidad, cantidad, preTotal)
            End If
        Next


    End Sub
    Private Function TotalVentas() As Decimal
        Dim total As Decimal = 0
        For a As Integer = 0 To dgvResumen.Rows.Count - 1
            Dim dato As String = dgvResumen.Item(1, a).Value
            If Not dato = "" Then
                Dim PrecioTotal As Decimal = CDec(dgvResumen.Item(6, a).Value)
                total = total + PrecioTotal
            End If
        Next
        Return total
    End Function

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If lblID.Text = "" Then
            MsgBox("Seleccione Cliente")
        Else
            Try

                Dim items As List(Of entidadVentaItem) = getListOfItems()

                If items.Count = 0 Then

                    Return
                End If

                consulta.TerminarVenta(consulta.nuevaVenta(CInt(lblID.Text), CDec(lblTotal.Text)), items)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListaClientes.Show()
    End Sub
    Private Function total_Ventas() As Decimal
        Dim total As Decimal = 0
        For a As Integer = 0 To dgvResumen.Rows.Count - 1
            Dim dato As String = dgvResumen.Item(1, a).Value
            If Not dato = "" Then
                Dim PrecioTotal As Decimal = CDec(dgvResumen.Item(4, a).Value)
                total = total + PrecioTotal
            End If
        Next
        Return total
    End Function
End Class