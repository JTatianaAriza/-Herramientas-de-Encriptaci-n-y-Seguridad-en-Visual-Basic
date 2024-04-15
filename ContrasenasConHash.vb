Module MainModule

    Sub Main()
        Console.WriteLine("Generador de Contraseñas Seguras con Hash")
        Console.WriteLine("------------------------------------------")

        ' Solicitar al usuario la longitud deseada de la contraseña
        Console.Write("Ingrese la longitud deseada de la contraseña: ")
        Dim longitud As Integer = Integer.Parse(Console.ReadLine())

        ' Generar contraseña aleatoria
        Dim generador As New GeneradorContraseñas(longitud)
        Dim contraseña As String = generador.GenerarContraseña()

        ' Mostrar contraseña generada
        Console.WriteLine("Contraseña generada: " & contraseña)

        ' Generar hash de la contraseña
        Dim hash As String = generador.GenerarHash(contraseña)

        ' Mostrar hash generado
        Console.WriteLine("Hash de la contraseña: " & hash)

        Console.ReadLine()
    End Sub

End Module

Class GeneradorContraseñas
    Private ReadOnly longitud As Integer

    Public Sub New(longitud As Integer)
        Me.longitud = longitud
    End Sub

    Public Function GenerarContraseña() As String
        Dim caracteres As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+[]{}|;:,.<>?/"
        Dim contraseña As String = ""
        Dim rnd As New Random()

        For i As Integer = 1 To longitud
            Dim caracterAleatorio As Char = caracteres(rnd.Next(0, caracteres.Length))
            contraseña &= caracterAleatorio
        Next

        Return contraseña
    End Function

    Public Function GenerarHash(contraseña As String) As String
        ' Implementación simple de hash (suma de valores ASCII)
        Dim hash As Integer = 0
        For Each caracter As Char In contraseña
            hash += Asc(caracter)
        Next

        Return hash.ToString()
    End Function
End Class

