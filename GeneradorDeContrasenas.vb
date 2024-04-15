Module MainModule

    Sub Main()
        Console.WriteLine("Generador de contraseñas seguras")
        Console.WriteLine("---------------------------------")

        ' Solicitar al usuario la longitud deseada de la contraseña
        Console.Write("Ingrese la longitud deseada de la contraseña: ")
        Dim longitud As Integer = Integer.Parse(Console.ReadLine())

        ' Generar contraseña aleatoria
        Dim contraseña As String = GenerarContraseña(longitud)

        ' Mostrar contraseña generada
        Console.WriteLine("Contraseña generada: " & contraseña)

        ' Encriptar la contraseña antes de almacenarla
        Dim contraseñaEncriptada As String = Encriptar(contraseña)

        ' Mostrar contraseña encriptada
        Console.WriteLine("Contraseña encriptada: " & contraseñaEncriptada)

        Console.ReadLine()
    End Sub

    Function GenerarContraseña(longitud As Integer) As String
        Dim caracteres As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+[]{}|;:,.<>?/"
        Dim contraseña As String = ""
        Dim rnd As New Random()

        For i As Integer = 1 To longitud
            Dim caracterAleatorio As Char = caracteres(rnd.Next(0, caracteres.Length))
            contraseña &= caracterAleatorio
        Next

        Return contraseña
    End Function

    Function Encriptar(contraseña As String) As String
        Dim contraseñaEncriptada As String = ""

        ' Aplicar una simple sustitución a cada caracter de la contraseña
        For Each caracter As Char In contraseña
            Dim caracterEncriptado As Char = ChrW(Asc(caracter) + 1) ' Incrementar el valor ASCII en 1
            contraseñaEncriptada &= caracterEncriptado
        Next

        Return contraseñaEncriptada
    End Function

End Module
