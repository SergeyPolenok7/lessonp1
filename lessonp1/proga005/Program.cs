﻿Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лиза")
{
    Console.WriteLine("Ура, это же Лиза!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}