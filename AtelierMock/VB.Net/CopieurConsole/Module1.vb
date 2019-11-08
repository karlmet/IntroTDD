Imports CaractereCopieur

Module Programme

    Private Class SourceConsole
        Implements Interfaces.ISource

        Public Function ObtenirChar() As Char Implements CaractereCopieur.Interfaces.ISource.ObtenirChar

            Dim x As Integer = Console.Read()
            Return Convert.ToChar(x)

        End Function

    End Class

    Private Class DestinationConsole
        Implements Interfaces.IDestination

        Public Sub FixerChar(nouveau As Char) Implements CaractereCopieur.Interfaces.IDestination.FixerChar

            Console.WriteLine(nouveau)

        End Sub

    End Class

    Sub Main()

        Dim copieur As Copieur = New Copieur(New SourceConsole, New DestinationConsole)
        copieur.Copier()

        Console.Read()

    End Sub

End Module
