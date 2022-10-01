//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

System.Console.WriteLine("Введите число А :");
double a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В :");
double b = Convert.ToInt32(Console.ReadLine());
double result = 0;

while(true)
{
result = Math.Pow(a,b);
System.Console.WriteLine("Результат : " + result);
break;
}



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите количество цифр в числе: \t ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elements];

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"Введите цифры числа ( по одной цифре) :  ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.Write("\n Вывод суммы цифр :  ");
int sum = array.Sum();
System.Console.WriteLine(sum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите количество элементов массива :\t ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elements];

for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"Введите элемент массива под индексом {i}: \t ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine("\n Вывод массива :  ");
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}