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
Zadacha11();