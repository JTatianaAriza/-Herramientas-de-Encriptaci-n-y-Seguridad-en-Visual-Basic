Module MainModule

    Sub Main()
        Console.WriteLine("Verificador de Contraseña con Hash")
        Console.WriteLine("----------------------------------")

        ' Solicitar al usuario la contraseña
        Console.Write("Ingrese la contraseña: ")
        Dim contraseña As String = Console.ReadLine()

       
        Console.Write("Ingrese el hash esperado: ")
        Dim hashEsperado As String = Console.ReadLine()

        
        Dim verificador As New VerificadorContraseña()
        Dim resultado As Boolean = verificador.VerificarContraseña(contraseña, hashEsperado)

        
        If resultado Then
            Console.WriteLine("La contraseña es válida.")
        Else
            Console.WriteLine("La contraseña no es válida.")
        End If

        Console.ReadLine()
    End Sub

End Module

Class VerificadorContraseña

    Public Function VerificarContraseña(contraseña As String, hashEsperado As String) As Boolean
        ' Implementación simple de verificación de hash (suma de valores ASCII)
        Dim hash As Integer = 0
        For Each caracter As Char In contraseña
            hash += Asc(caracter)
        Next

        Dim hashCalculado As String = hash.ToString()
        Return hashCalculado = hashEsperado
    End Function

End Class


