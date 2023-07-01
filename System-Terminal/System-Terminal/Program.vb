Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())

        Dim input As String

        Dim pass As String

        Dim pingInput As String

        Dim cdInput As String

        Dim sudo As Boolean = False

        Dim symbol As String = " > "

        Console.WriteLine("=== System Terminal ===")

        Console.WriteLine("Please type in help for a list of commands.")
        While True

            If sudo = True Then
                symbol = " $ "
            End If

            Console.WriteLine()
            Console.Write(symbol)

            input = Console.ReadLine()

            Select Case input
                ' Standard Commands
                Case "help"
                    If sudo = False Then
                        Console.WriteLine()
                        Console.WriteLine("Here's a list of commands: ")
                        Console.WriteLine("help: Provides you with a list of commands.")
                        Console.WriteLine("netport: Provides you with a list of open ports and vulnerabilities.")
                        Console.WriteLine("exit: Exits the terminal.")
                    ElseIf sudo = True Then
                        Console.WriteLine()
                        Console.WriteLine("Here's a list of sudo commands: ")
                        Console.WriteLine("help: Provides you with a list of commands.")
                        Console.WriteLine("netport: Provides you with a list of open ports and vulnerabilities.")
                        Console.WriteLine("sysusers: Provides you with a list of users in your workspace.")
                        Console.WriteLine("localusers: Provides you with a list of users in your device.")
                        Console.WriteLine("exit: Exits the terminal.")
                    End If
                Case "netport"
                    Thread.Sleep(1000)
                    Console.WriteLine()
                    Console.WriteLine("1 | 12.1.1.0 | 8000")
                    Console.WriteLine("2 | 127.428.4.0 | 6464")
                    Console.WriteLine("1 | 12.1.1.0 | 8000")
                    Thread.Sleep(900)
                    Console.WriteLine("1 | 12.1.1.0 | 8000")
                Case "sudo"
                    Console.WriteLine()
                    Console.Write("Password: ")

                    pass = Console.ReadLine()

                    If pass = "1234" Then
                        sudo = True
                    End If
                Case "exit"
                    Exit Sub

                Case "ping"
                    Console.WriteLine()
                    Console.Write("Ping: ")
                    pingInput = Console.ReadLine()

                    Thread.Sleep(2000)

                    Console.WriteLine()
                    Console.Write("Pinging: ")
                    Console.WriteLine(pingInput)

                    ' Ping Output

                    Console.WriteLine()
                    Console.WriteLine("1 | 127.0.0.1 | 281ms")
                    Thread.Sleep(900)
                    Console.WriteLine("2 | 127.0.0.1 | 287ms")
                    Thread.Sleep(900)
                    Console.WriteLine("3 | 127.0.0.1 | 245ms")
                    Thread.Sleep(900)
                    Console.WriteLine("4 | 127.0.0.1 | 298ms")
                    Thread.Sleep(900)
                    Console.WriteLine("5 | 127.0.0.1 | 281ms")

                Case "cd"
                    Console.WriteLine()
                    Console.WriteLine("CD To: ")
                    cdInput = Console.ReadLine()
                    If cdInput = "Desktop" OrElse "Downloads" OrElse "Documents" OrElse "System" Then
                        symbol = symbol & cdInput & ""
                    End If
                ' Sudo Commands
                Case "sysusers"
                    If sudo = True Then
                        Console.WriteLine()
                        Console.WriteLine("1 | jdoe | User")
                        Console.WriteLine("2 | kdough | Admin")
                        Console.WriteLine("3 | erubenstein | Admin")
                        Console.WriteLine("4 | wgohle | User")
                    ElseIf sudo = False Then
                        Console.WriteLine("You do not have permission to run this command.")
                    End If
                Case "localusers"
                    If sudo = True Then
                        Console.WriteLine()
                        Console.WriteLine("1 | kdough | Admin")
                        Console.WriteLine("2 | erubenstein | Admin")
                    ElseIf sudo = False Then
                        Console.WriteLine("You do not have permission to run this command.")
                    End If
                Case Else
                    Console.WriteLine("Invalid command.")
            End Select
        End While
    End Sub
End Module
