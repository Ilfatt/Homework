using System;
using System.Net;

namespace Task3;

public class NotTrueInputException : Exception
{
    public NotTrueInputException()
    {
        Console.WriteLine($"Ошибка.Читайте внимательне что разрешено подавать на вход. ");
    }
}