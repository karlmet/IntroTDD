Public Class Copieur
    Private aSource As Interfaces.ISource
    Private aDestination As Interfaces.IDestination
    
    Public Sub New(source As Interfaces.ISource, destination As Interfaces.IDestination)
        aSource = source
        aDestination = destination
    End Sub

    Public Sub Copier()
        Throw New NotImplementedException()
    End Sub
End Class
