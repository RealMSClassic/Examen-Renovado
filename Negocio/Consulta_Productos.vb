Imports Querys
Imports Entidad

Public Class Consulta_Productos
    Dim backup2 As Entidad_Producto = New Entidad_Producto
    Dim consultas As Query_Productos = New Query_Productos


    'Cargar datos a DataGrillView
    Public Function Cargar_Datos_lista() As DataTable
        Return consultas.CargarLista
    End Function


    'Ingresar Datos a DB
    Public Function Obtener_Datos(ByVal Nombre As String, ByVal Precio As Decimal, ByVal Categoria As String) As Boolean
        Dim llave As Boolean = False
        If Nombre = "" Then
            MsgBox("Nombre Obligatorio")
            llave = False
        ElseIf Precio = 0 Then
            MsgBox("Precio Obligatorio")
            llave = False
        ElseIf Categoria = "" Then
            MsgBox("Categoria Obligatorio")
            llave = False
        Else
            Dim enti As Entidad_Producto = New Entidad_Producto
            enti.Nombre = Nombre
            enti.Precio = Precio
            enti.Categoria = Categoria
            Ingresar_Datos(enti)
            llave = True
        End If
        Return llave
    End Function


    Private Sub Ingresar_Datos(ByVal enti As Entidad_Producto)
        consultas.Ingresar_Producto(enti)
    End Sub

    Public Function Modificar_Cliente(ByVal id2 As Integer, ByVal nombre2 As String, ByVal precio2 As Decimal, ByVal categoria2 As String)
        Dim llave As Boolean = False
        If nombre2 = "" Then
            MsgBox("Nombre Obligatorio")
            llave = False
        ElseIf precio2 = 0 Then
            MsgBox("Precio Obligatorio")
            llave = False
        ElseIf categoria2 = "" Then
            MsgBox("Categoria Obligatoria")
            llave = False
        Else


            If backup2.Nombre = nombre2 And backup2.Precio = precio2 And backup2.Categoria = categoria2 Then


                MsgBox("Sin Cambios")

            Else
                backup2.Id = id2
                backup2.Nombre = nombre2

                backup2.Precio = CDec(precio2)

                backup2.Categoria = categoria2
                llave = consultas.Modificar(backup2)

            End If



        End If
        Return llave
    End Function

    Public Sub backup_accion(ByVal id As Integer, ByVal nombre As String, ByVal Precio As Decimal, ByVal Categoria As String)
        backup2.Id = id
        backup2.Nombre = nombre
        backup2.Precio = Precio
        backup2.Categoria = Categoria


    End Sub

    Public Function Eliminar_Producto(ByVal id As Integer) As Boolean
        Dim llave As Boolean
        Dim result As MsgBoxResult
        result = MsgBox("Esta Seguro en eliminar? ", MsgBoxStyle.YesNo, "Eliminar Cliente")
        If result = MsgBoxResult.Yes Then
            consultas.Eliminar_Producto(id)
            llave = True
        ElseIf result = MsgBoxResult.No Then
            llave = False
        End If

        Return llave
    End Function

End Class
