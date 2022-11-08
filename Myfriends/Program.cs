using System;       
string name = "Protyk";
double birthday = 04.11;
int age = 33;
bool smoking = true;

Console.ReadKey();
Console.Clear();

Console.WriteLine($"Имя: {name}, День рождения: {birthday}, Возраст: {age}old, Курит: {smoking}");

Console.ReadKey();
Console.Clear();
Console.BackgroundColor = ConsoleColor.DarkBlue;

name = "Tywa";
birthday = 06.04;
age = 32;
smoking = true;

Console.WriteLine($"Имя: {name}, День рождения: {birthday}, Возраст: {age}old , Курит: {smoking}");

Console.ReadKey();
Console.Clear();

name = "Ksusha";
birthday = 08.04;
age = 32;
smoking = false;

Console.WriteLine($"Имя: {name}, День рождения: {birthday}, Возраст: {age}old, Курит: {smoking}");

Console.ReadKey();
Console.Clear();

name = "Vinni";
birthday = 30.10;
age = 33;
smoking = true;

Console.WriteLine("Имя: {0} День рождения: {2} Возраст: {1}old Курит: {3}", name, age, birthday, smoking);

Console.ReadKey();
Console.Clear();
