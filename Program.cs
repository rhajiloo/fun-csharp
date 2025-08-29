Console.WriteLine("Please enter number 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter number 2: ");
int number2 = int.Parse(Console.ReadLine());

// بررسی بخش پذیری دو عدد بر یکدیگر و نمایش باقی مانده
if (number2 != 0 && number1 % number2 == 0)
{
    Console.WriteLine($"{number1}  is divisible by the {number2}");
    Console.WriteLine($"remainder1 {number1}  on {number2} is : 0");
}
else
{
    Console.WriteLine($"{number1}  is not divisible by the {number2}");
    Console.WriteLine($"remainder1 {number1}  on {number2} is : {number1 % number2}");
}

if (number1 != 0 && number2 % number1 == 0)
{
    Console.WriteLine($"{number2}  is divisible by the {number1}");
    Console.WriteLine($"remainder1 {number2}  on {number1} is : 0");
}
else
{
    Console.WriteLine($"{number2}  is not divisible by the {number1}");
    Console.WriteLine($"remainder1 {number2}  on {number1} is : {number2 % number1}");
}

// بررسی زوج و فرد بودن دو عدد دریافتی
if (number1 % 2 == 0)
    Console.WriteLine($"number1({number1}) is: even");
else
    Console.WriteLine($"number1({number1}) is: odd");

if (number2 % 2 == 0)
    Console.WriteLine($"number2({number2}) is: even");
else
    Console.WriteLine($"number2({number2}) is: odd");