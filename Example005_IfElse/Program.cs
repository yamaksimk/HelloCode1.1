﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "даша")
{
    Console.WriteLine("Привет,зайка");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}