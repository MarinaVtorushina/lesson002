void Zadacha9()
{
        // 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
        // 78 -> 8 
        // 12-> 2 
        // 85 -> 8

        Random random = new Random();
        int number = random.Next(10, 100); 
        Console.WriteLine(number);
        int tens = number / 10;
        int ones = number % 10;
        Console.WriteLine(tens);
        Console.WriteLine(ones);
        
        if (tens > ones)
        {
            Console.WriteLine("Наибольшее " + tens);
        }
        else
            Console.WriteLine("Наибольшее " + ones);
}
         void Zadacha11()
{
        // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
        // 456 -> 46
        // 782 -> 72
        // 918 -> 98
        Random random = new Random();
        int number = random.Next(100, 1000); 
        Console.WriteLine(number);
        int hundreds = number / 100;
        int tens = number / 10 % 10;
        int ones = number % 10;
        Console.WriteLine(" " + hundreds + ones);
       
}


void Zadacha12()
{
        // 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
        // 34, 5 -> не кратно, остаток 4 
        // 16, 4 -> кратно
        Random random = new Random();
        int number1 = random.Next(10, 100); 
        int number2 = random.Next(10, 100); 
        Console.WriteLine(number1);
        Console.WriteLine(number2);
                
        if (number2 % number1 == 0)
        {
            Console.WriteLine("Кратное ");
        }
        else
            Console.WriteLine($"Не кратно, остаток = {number2 % number1 }");
}
void Zadacha14()
{
        //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

        Console.WriteLine ("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 % 161 == 0)
        {
            Console.WriteLine("Число кратное 7 и 23 " + number1);
        }
        else
            Console.WriteLine("Число не кратное 7 и 23 -  " + number1);
}

void Zadacha16()
{
        //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

        Console.WriteLine ("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 * number1 == number2)
        {
            Console.WriteLine("Второе число является квадратом первого");
        }
        else
            Console.WriteLine("Второе число не является квадратом первого");
}
void Zadacha17()
{
        //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

        Console.WriteLine ("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 == number2 * number2 || number2 == number1 * number1)
        {
            Console.WriteLine("Число является квадратом второго числа");
        }
        else
            Console.WriteLine("Не является квадратом ");
}

void Zadacha10()
{
        //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        Console.WriteLine ("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Вторая цифра трехзначного числа " + number/10%10);

}
void Zadacha13()
{

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        Console.WriteLine ("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 99)
        {
            while (number > 999)
            {
                number /=10;
            }
            Console.WriteLine("Третья цифра трехзначного числа " + number%10);

        }
        else
        {
            Console.WriteLine("Отстсвует третье число");
        }     
}  
void Zadacha15()
{
        // Напишите программу, которая будет выдавать название дня недели по заданному номеру.
        // 	3 -> Среда 
        // 5 -> Пятница

        Console.WriteLine("Введите число, соответствующее дню недели");
        int week = Convert.ToInt32(Console.ReadLine()); // 1 - понедельник
        if (week == 1)
        {
            Console.WriteLine("Понедельник");
        }
        if (week == 2)
        {
            Console.WriteLine("Вторник");
        }
        if (week == 3)
        {
            Console.WriteLine("Среда");
        }
        if (week == 4)
        {
            Console.WriteLine("Четверг");
        }
        if (week == 5)
        {
            Console.WriteLine("Пятница");
        }
        if (week == 6)
        {
            Console.WriteLine("Суббота");
        }
        if (week == 7)
        {
            Console.WriteLine("Воскресенье");
        }
        
        {
            Console.WriteLine("Нет такого дня недели");
        }
}
Zadacha15();