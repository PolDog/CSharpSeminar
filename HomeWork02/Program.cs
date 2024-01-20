// See https://aka.ms/new-console-template for more information
using System.Globalization;
int num;
// Функция поиска максимального значения из двух цифр
int findMaxValue(int ferstNumber, int secondNumber)
{
    int max = ferstNumber;
    if (secondNumber > max)
    {
        max = secondNumber;
    }
    return max;
}

//функция подсчета количества знаков в числе
int findAmountDig(int num)
{
    int amount = 0;
    bool isEnd = false;
    while (!isEnd)
    {
        if (num != 0)
        {
            num = num / 10;
            amount++;
        }
        else
        {
            isEnd = true;
        }
    }
    return amount;
}

//функция печати поэлементно числа
void printDig(int amountDig, int num)
{
    bool isEnd = false;
    //int lenght=amountDig;
    int var = 0;
    //amountDig=amountDig-1;
    while (!isEnd)
    {
        int ten = 1;
        for (int i = 1; i <= amountDig - 1; i++)
        {
            ten = ten * 10;
        }
        if (num / ten != 0)
        {

            //Console.WriteLine($"t{ten}");
            var = num / ten;
            Console.Write($"{var} ");
            num = num - var * ten;
            //Console.WriteLine($"n{num}");
            //isEnd = true;
            amountDig = amountDig - 1;
            //Console.WriteLine($"a{amountDig}");
        }
        else
        {
            isEnd = true;
        }
        //Console.WriteLine($"var {var}++");
    }
}

//функция генерирования числа
int randomNumber(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

//функция принимающая параметры для генерации чисел
int numberGeneration(bool useMinus)
{
    int amountDec = 2;
    int amountVar = 20;
    int dec = 1;
    int amountDig = 0;
    int minNumber = 0;
    int maxNumber = 200;
    if (useMinus)
    {
        minNumber = -maxNumber;

    }
    for (int i = 0; i < amountDec; i++)
    {
        dec = dec * 10;
    }
    //System.Console.WriteLine($"Минимальное значение {minNumber}");
    //System.Console.WriteLine($"Максимальное значение {maxNumber}");
    //System.Console.WriteLine($"Нужно сгенерировать несколько {amountDec}-х значное число за {amountVar} генераций.");
    //System.Console.WriteLine($"");
    dec = dec - 1;
    num = randomNumber(minNumber, maxNumber);
    for (int i = 0; i < amountVar; i++)
    {
        if (num <= dec)
        {
            //System.Console.Write($"[{num}] ");
            amountDig = amountDig + 1;
        }
        else
        {
            //System.Console.Write($"{num} ");
        }
        num = randomNumber(minNumber, maxNumber);
    }
    //Console.WriteLine();

    //Console.WriteLine($"Из {amountVar} вариантов было {amountDig} {amountDec}-х значных числа");
    //Console.WriteLine($"Сгенерировано число {num}");
    return num;
}


//================================================================================================
Console.WriteLine($"----====== Задача 1 ======-----");
num = numberGeneration(true);
Console.WriteLine($"Сгенерировано число {num}");
int firstNumber = 7;
int secondNumber = 23;
if ((num % firstNumber) == 0 && (num % secondNumber) == 0)
{
    Console.WriteLine($"Число {num} кратное числам {firstNumber} и {secondNumber}");
}
else
{
    Console.WriteLine($"Число {num} не кратное числам {firstNumber} и {secondNumber}");
}


//================================================================================================
Console.WriteLine($"----====== Задача 2 ======-----");
int x = numberGeneration(true);
int y = numberGeneration(true);
while (x == 0)
{
    Console.WriteLine($"Сгенерировано число X {x}, переделываю");
    x = numberGeneration(true);
}
while (y == 0)
{
    Console.WriteLine($"Сгенерировано число Y {y}, переделываю");
    y = numberGeneration(true);
}
Console.WriteLine($"Сгенерировано число X {x}");
Console.WriteLine($"Сгенерировано число Y {y}");

if (x > 0 && y > 0)
{
    Console.WriteLine($"Четверть I");
}
if (x < 0 && y > 0)
{
    Console.WriteLine($"Четверть II");
}
if (x < 0 && y < 0)
{
    Console.WriteLine($"Четверть III");
}
if (x > 0 && y < 0)
{
    Console.WriteLine($"Четверть IV");
}


//================================================================================================
Console.WriteLine($"----====== Задача 3 ======-----");
int minAmount = 10;
int maxAmount = 99;
num = numberGeneration(false);
while (num < minAmount || num > maxAmount)
{
    Console.WriteLine($"Сгенерировано число {num} не попадает в диапазон {minAmount}...{maxAmount}, перегенерирую");
    num = numberGeneration(false);
}
Console.WriteLine($"Сгенерировано число {num} из диапазона {minAmount}...{maxAmount}.");
firstNumber = num / 10;
Console.WriteLine($"Первое число {firstNumber}");
secondNumber = num - firstNumber * 10;
Console.WriteLine($"Первое число {secondNumber}");
Console.WriteLine($"Максимальная цифра в числе {findMaxValue(firstNumber, secondNumber)}");


//================================================================================================
Console.WriteLine($"----====== Задача 4 ======-----");
num = numberGeneration(true);
Console.WriteLine($"Сгенерировано число {num}");
int amountDig = findAmountDig(num);
//Console.WriteLine($"Число знаков {amountDig}");
printDig(amountDig, num);
Console.WriteLine();

