Imports Querys
Imports Entidad

Public Class Consulta_Clientes

    Dim backupDatosClientes As Entidad_Clientes = New Entidad_Clientes
    Dim consultaAQueryClientes As Query_Clientes = New Query_Clientes
    'Cargar datos a DataGrillView
    Public Function Cargar_Datos() As DataTable
        Return consultaAQueryClientes.CargarLista
    End Function


    'Ingresar Datos a DB
    Public Function Obtener_Datos(ByVal Nombre As String, ByVal Telefono As String, ByVal correo As String) As Boolean
        Dim llave As Boolean = False
        If Nombre = "" Then
            MsgBox("Nombre Obligatorio")
            llave = False
        ElseIf Telefono = "" Then
            MsgBox("Telefono Obligatorio")
            llave = False
        ElseIf correo = "" Then
            MsgBox("Correo Obligatorio")
            llave = False
        Else
            Dim enti As Entidad_Clientes = New Entidad_Clientes
            enti.Nombre = Nombre
            enti.Telefono = Telefono
            enti.Correo = correo
            Ingresar_Datos(enti)
            llave = True
        End If
        Return llave
    End Function


    Private Sub Ingresar_Datos(ByVal enti As Entidad_Clientes)
        consultaAQueryClientes.Ingresar_Clientes(enti)
    End Sub

    Public Function Modificar_Cliente(ByVal id2 As Integer, ByVal nombre2 As String, ByVal telefono2 As String, ByVal correo2 As String) As Boolean
        Dim llave As Boolean = False
        If nombre2 = "" Then
            MsgBox("Nombre Obligatorio")
            llave = False
        ElseIf telefono2 = "" Then
            MsgBox("Telefono Obligatorio")
            llave = False
        ElseIf correo2 = "" Then
            MsgBox("Correo Obligatorio")
            llave = False
        Else

            If backupDatosClientes.Nombre = nombre2 And backupDatosClientes.Telefono = telefono2 And backupDatosClientes.Correo = correo2 Then
                MsgBox("Sin Cambios")

            Else
                backupDatosClientes.Id = id2
                backupDatosClientes.Nombre = nombre2
                backupDatosClientes.Telefono = telefono2
                backupDatosClientes.Correo = correo2
                llave = consultaAQueryClientes.Modificar(backupDatosClientes)

            End If



        End If
        Return llave
    End Function

    Public Sub backup_accion(ByVal id As Integer, ByVal nombre As String, ByVal telefono As String, ByVal correo As String)
        backupDatosClientes.Id = id
        backupDatosClientes.Nombre = nombre
        backupDatosClientes.Telefono = telefono
        backupDatosClientes.Correo = correo

    End Sub

    Public Function Eliminar_Cliente(ByVal id As Integer) As Boolean
        Dim llave As Boolean
        Dim result As MsgBoxResult
        result = MsgBox("Esta Seguro en eliminar? ", MsgBoxStyle.YesNo, "Eliminar Cliente")
        If result = MsgBoxResult.Yes Then
            consultaAQueryClientes.Eliminar_Cliente(id)
            llave = True
        ElseIf result = MsgBoxResult.No Then
            llave = False
        End If

        Return llave
    End Function

End Class
