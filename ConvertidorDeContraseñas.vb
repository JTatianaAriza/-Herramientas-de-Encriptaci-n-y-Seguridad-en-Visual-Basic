Module MainModule

    Sub Main()
        Console.WriteLine("Convertidor de Contraseñas con Triple Encriptación")
        Console.WriteLine("---------------------------------------------------")

        
        Console.Write("Ingrese la contraseña: ")
        Dim contraseña As String = Console.ReadLine()

        
        Dim tripleEncriptacion As String = EncriptarTriple(contraseña)
        Console.WriteLine("Contraseña con triple encriptación: " & tripleEncriptacion)

        Console.ReadLine()
    End Sub

    Function EncriptarTriple(contraseña As String) As String
        
        Dim primeraEncriptacion As String = StrReverse(contraseña)
        
        Dim segundaEncriptacion As String = CambiarMayusculasMinisculas(primeraEncriptacion)
        
        ' Realizar la tercera encriptación (reemplazar caracteres con su valor ASCII)
        Dim terceraEncriptacion As String = ReemplazarConASCII(segundaEncriptacion)
        
        Return terceraEncriptacion
    End Function

    Function CambiarMayusculasMinisculas(entrada As String) As String
        Dim resultado As String = ""
        For Each caracter As Char In entrada
            If Char.IsUpper(caracter) Then
                resultado &= Char.ToLower(caracter)
            Else
                resultado &= Char.ToUpper(caracter)
            End If
        Next
        Return resultado
    End Function

    Function ReemplazarConASCII(entrada As String) As String
        Dim resultado As String = ""
        For Each caracter As Char In entrada
            resultado &= Asc(caracter) & " "
        Next
        Return resultado
    End Function

End Module
