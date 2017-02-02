Module Module1

    Sub Main()

        Dim numbers() As Integer = {2, 3, 5, 7, 11, 13, 17, 19, 23}

        'Dim numbers(9) As Integer

        'numbers(0) = 2
        'numbers(1) = 3
        'numbers(2) = 5
        'numbers(3) = 7
        'numbers(4) = 11
        'numbers(5) = 13
        'numbers(6) = 17
        'numbers(7) = 19
        'numbers(8) = 23


        Dim key As Integer

        key = 5

        Dim found As Boolean

        found = False

        Dim l, m, h As Integer

        l = 0
        h = 8

        m = Int(((l + h) / 2))


        While (l < h)
            If numbers(m) = key Then
                found = True
                Console.WriteLine("the key was found at index " & m)
                Exit While
            End If

            If numbers(m) > key Then
                h = m - 1
            Else
                l = m + 1
            End If

            m = Int((l + h) / 2)


        End While

        If found = False Then
            Console.WriteLine("the number was not found")
        End If

        'Console.ReadKey()

    End Sub

End Module
